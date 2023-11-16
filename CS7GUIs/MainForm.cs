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
            InitializeComponent();

            logForm = new LogForm();

            // need to show up at first to make logger attach the control
            logForm.Show();
            logForm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bindBookOption();
        }

        private void UIBtnShowLog_ButtonClick(object sender, EventArgs e)
        {
            logForm.Show();
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
            if (!allowTriggerTextChange)
            {
                return;
            }

            if (!double.TryParse(UIInputC.Text, out double cVal))
            {
                return;
            }


            double fVal = (cVal * (9.0 / 5.0)) + 32.0;

            // log to make sure no circular calling
            logger.Info($"conv {cVal:0.00}C to {fVal:0.00}F");

            allowTriggerTextChange = false;
            UIInputF.Text = fVal.ToString("0.00");
            allowTriggerTextChange = true;
        }

        private void UIInputF_TextChanged(object sender, EventArgs e)
        {
            if (!allowTriggerTextChange)
            {
                return;
            }

            if (!double.TryParse(UIInputF.Text, out double fVal))
            {
                return;
            }


            double cVal = (fVal - 32.0) * (5.0 / 9.0);

            // log to make sure no circular calling
            logger.Info($"conv {fVal:0.00}F to {cVal:0.00}C");

            allowTriggerTextChange = false;
            UIInputC.Text = cVal.ToString("0.00");
            allowTriggerTextChange = true;
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

        private void bindBookOption()
        {
            this.UIOptionBook.DataSource = itemList;
            this.UIOptionBook.ValueMember = "Option";
            this.UIOptionBook.DisplayMember = "Display";

            this.UIOptionBook.SelectedIndex = (int)BookOption.OneWay;
        }
        private void UIOptionBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBookUI();
        }

        private void UIInputStartDate_TextChanged(object sender, EventArgs e)
        {
            updateBookUI();
        }

        private void UIInputReturnDate_TextChanged(object sender, EventArgs e)
        {
            updateBookUI();
        }

        private void UIBtnBook_Click(object sender, EventArgs e)
        {
            BookOption selected = (BookOption)this.UIOptionBook.SelectedIndex;
            switch (selected)
            {
                case BookOption.OneWay:
                    _ = MessageBox.Show($"You have booked a one-way flight on {UIInputStartDate.Text}", "Book successful");
                    break;
                case BookOption.Return:
                    _ = MessageBox.Show($"You have booked a return flight on {UIInputStartDate.Text} and {UIInputReturnDate.Text}.", "Book successful");
                    break;
            }
        }

        private void updateBookUI()
        {
            BookOption selected = (BookOption)this.UIOptionBook.SelectedIndex;
            switch (selected)
            {
                case BookOption.OneWay:
                    UIInputReturnDate.Enabled = false;
                    UIBtnBook.Enabled = validateBookDate(UIInputStartDate, out DateTime _);
                    break;
                case BookOption.Return:
                    UIInputReturnDate.Enabled = true;
                    bool ok1 = UIBtnBook.Enabled = validateBookDate(UIInputStartDate, out DateTime t1);
                    bool ok2 = UIBtnBook.Enabled = validateBookDate(UIInputReturnDate, out DateTime t2);
                    UIBtnBook.Enabled = ok1 && ok2 && t1 <= t2;
                    break;
            }
        }

        private bool validateBookDate(TextBox input, out DateTime date)
        {
            bool ok = DateTime.TryParseExact(input.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            input.ForeColor = ok ? System.Drawing.Color.Black : System.Drawing.Color.Red;
            return ok;
        }

        #endregion



    }
}
