using NLog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CS7GUIs
{
    public partial class MainForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private readonly LogForm logForm;

        public MainForm()
        {
            this.InitializeComponent();

            this.logForm = new LogForm();

            // need to show up at first to make logger attach the control
            this.logForm.Show();
            this.logForm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.setupBook();
            this.setupTimer();
        }


        private void UIBtnShowLog_ButtonClick(object sender, EventArgs e)
        {
            this.logForm.Show();
        }

        #region Counter

        private int conter = 0;
        private void UIBtnCount_Click(object sender, EventArgs e)
        {
            this.conter++;
            this.UITextCounter.Text = this.conter.ToString();
            logger.Info($"Conter: {this.conter}");
        }

        #endregion

        #region TempConv

        private bool allowTriggerTextChange = true;

        private void UIInputC_TextChanged(object sender, EventArgs e)
        {
            if (!this.allowTriggerTextChange)
            {
                return;
            }

            if (!double.TryParse(this.UIInputC.Text, out double cVal))
            {
                return;
            }


            double fVal = (cVal * (9.0 / 5.0)) + 32.0;

            // log to make sure no circular calling
            logger.Info($"conv {cVal:0.00}C to {fVal:0.00}F");

            this.allowTriggerTextChange = false;
            this.UIInputF.Text = fVal.ToString("0.00");
            this.allowTriggerTextChange = true;
        }

        private void UIInputF_TextChanged(object sender, EventArgs e)
        {
            if (!this.allowTriggerTextChange)
            {
                return;
            }

            if (!double.TryParse(this.UIInputF.Text, out double fVal))
            {
                return;
            }


            double cVal = (fVal - 32.0) * (5.0 / 9.0);

            // log to make sure no circular calling
            logger.Info($"conv {fVal:0.00}F to {cVal:0.00}C");

            this.allowTriggerTextChange = false;
            this.UIInputC.Text = cVal.ToString("0.00");
            this.allowTriggerTextChange = true;
        }

        #endregion

        #region Book Flight

        private enum BookOption
        {
            OneWay,
            Return,
        }

        private class BookOptionDisplay
        {
            public BookOption Option { get; set; }
            public string? Display { get; set; }
        }

        private readonly List<BookOptionDisplay> itemList = new()
        {
            new BookOptionDisplay { Option = BookOption.OneWay, Display = "one-way flight" },
            new BookOptionDisplay { Option = BookOption.Return, Display = "return flight" }
        };

        private void setupBook()
        {
            this.UIOptionBook.DataSource = this.itemList;
            this.UIOptionBook.ValueMember = "Option";
            this.UIOptionBook.DisplayMember = "Display";

            this.UIOptionBook.SelectedIndex = (int)BookOption.OneWay;
        }
        private void UIOptionBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateBookUI();
        }

        private void UIInputStartDate_TextChanged(object sender, EventArgs e)
        {
            this.updateBookUI();
        }

        private void UIInputReturnDate_TextChanged(object sender, EventArgs e)
        {
            this.updateBookUI();
        }

        private void UIBtnBook_Click(object sender, EventArgs e)
        {
            BookOption selected = (BookOption)this.UIOptionBook.SelectedIndex;
            switch (selected)
            {
                case BookOption.OneWay:
                    _ = MessageBox.Show($"You have booked a one-way flight on {this.UIInputStartDate.Text}", "Book successful");
                    break;
                case BookOption.Return:
                    _ = MessageBox.Show($"You have booked a return flight on {this.UIInputStartDate.Text} and {this.UIInputReturnDate.Text}.", "Book successful");
                    break;
            }
        }

        private void updateBookUI()
        {
            BookOption selected = (BookOption)this.UIOptionBook.SelectedIndex;
            switch (selected)
            {
                case BookOption.OneWay:
                    this.UIInputReturnDate.Enabled = false;
                    this.UIBtnBook.Enabled = validateBookDate(this.UIInputStartDate, out DateTime _);
                    break;
                case BookOption.Return:
                    this.UIInputReturnDate.Enabled = true;
                    bool ok1 = this.UIBtnBook.Enabled = validateBookDate(this.UIInputStartDate, out DateTime t1);
                    bool ok2 = this.UIBtnBook.Enabled = validateBookDate(this.UIInputReturnDate, out DateTime t2);
                    this.UIBtnBook.Enabled = ok1 && ok2 && t1 <= t2;
                    break;
            }
        }

        private static bool validateBookDate(TextBox input, out DateTime date)
        {
            bool ok = DateTime.TryParseExact(input.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            input.ForeColor = ok ? System.Drawing.Color.Black : System.Drawing.Color.Red;
            return ok;
        }

        #endregion

        #region Timer
        const int DURATION_DEFAULT = 15000; // ms
        const int DURATION_MAXIMUM = 30000; // ms

        private DateTime timerStartTime;
        private void setupTimer()
        {
            this.UIProgessElapsed.Maximum = DURATION_DEFAULT;
            this.UITrackDuration.Maximum = DURATION_MAXIMUM;
            this.UITrackDuration.Value = DURATION_DEFAULT;

            this.timerStartTime = DateTime.Now;
        }

        private void UIPanelTimer_VisibleChanged(object sender, EventArgs e)
        {
            if (this.UIPanelTimer.Visible)
            {
                this.UITimeTicker.Start();
            }
            else
            {
                this.UITimeTicker.Stop();
            }
        }

        private void UITimeTicker_Tick(object sender, EventArgs e)
        {
            // Winform Timer trigger tick in UI thread, so it not need to Invoke.
            if (this.UITrackDuration.Value - this.UIProgessElapsed.Value >= 0)
            {
                DateTime now = DateTime.Now;
                var span = now - this.timerStartTime;
                if (span.TotalMilliseconds < this.UIProgessElapsed.Maximum)
                {
                    this.UIProgessElapsed.Value = (int)span.TotalMilliseconds;
                    this.UILblElapsed.Text = span.ToString();
                }
                else
                {
                    this.UIProgessElapsed.Value = this.UIProgessElapsed.Maximum;
                    this.UILblElapsed.Text = $"00:00:{this.UIProgessElapsed.Maximum / 1000.0:00.0000000}";
                }
            }
        }

        private void UITrackDuration_Scroll(object sender, EventArgs e)
        {
            this.UIProgessElapsed.Maximum = this.UITrackDuration.Value;
        }

        private void UIBtnResetTimer_Click(object sender, EventArgs e)
        {
            this.timerStartTime = DateTime.Now;
        }
        #endregion

    }
}
