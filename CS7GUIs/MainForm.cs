using NLog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CS7GUIs
{
    public partial class MainForm : Form
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

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
            this.setupCRUD();
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
            log.Info($"Conter: {this.conter}");
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
            log.Info($"conv {cVal:0.00}C to {fVal:0.00}F");

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
            log.Info($"conv {fVal:0.00}F to {cVal:0.00}C");

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
            string msg;
            switch (selected)
            {
                case BookOption.OneWay:
                    msg = $"You have booked a one-way flight on {this.UIInputStartDate.Text}";
                    log.Info(msg);
                    _ = MessageBox.Show(msg, "Book successful");
                    break;
                case BookOption.Return:
                    msg = $"You have booked a return flight on {this.UIInputStartDate.Text} and {this.UIInputReturnDate.Text}.";
                    log.Info(msg);
                    _ = MessageBox.Show(msg, "Book successful");
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
            log.Info("reset timer");
            this.timerStartTime = DateTime.Now;
        }
        #endregion

        #region CRUD

        private class User
        {
            public string Name { get; set; } = string.Empty;
            public string SurName { get; set; } = string.Empty;

            public string FullName => $"{this.Name}, {this.SurName}";
        }

        private readonly List<User> allUsers = new();
        private List<User> displayUsers
        {
            get
            {
                if (string.IsNullOrEmpty(this.UIInputFilter.Text))
                {
                    return this.allUsers;
                }

                return this.allUsers.FindAll((user) =>
                {
                    return user.SurName.StartsWith(this.UIInputFilter.Text);
                }); ;
            }
        }

        private void setupCRUD()
        {
            this.allUsers.Add(new User() { Name = "Emil", SurName = "Hans" });
            this.allUsers.Add(new User() { Name = "Mustermann", SurName = "Max" });
            this.allUsers.Add(new User() { Name = "Tisch", SurName = "Roman" });

            this.updateListBox();
            this.UIListBox.SelectedIndex = 0;
        }

        private void updateListBox()
        {
            this.UIListBox.DataSource = null;
            this.UIListBox.DataSource = this.displayUsers;
            this.UIListBox.DisplayMember = "FullName";
        }

        private void UIInputFilter_TextChanged(object sender, EventArgs e)
        {
            this.updateListBox();
        }

        private void UIListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.UIListBox.SelectedItems.Count == 0)
            {
                this.UIBtnUpdate.Enabled = false;
                this.UIBtnDelete.Enabled = false;
                return;
            }

            var user = (User)this.UIListBox.SelectedItems[0];
            this.UIUnputName.Text = user?.Name;
            this.UIInputSurName.Text = user?.SurName;

            this.UIBtnUpdate.Enabled = true;
            this.UIBtnDelete.Enabled = true;
        }

        private void UIBtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.UIUnputName.Text) || string.IsNullOrEmpty(this.UIInputSurName.Text))
            {
                return;
            }
            var user = new User() { Name = this.UIUnputName.Text, SurName = this.UIInputSurName.Text };
            this.allUsers.Add(user);

            log.Info($"create {user.FullName}");

            this.updateListBox();
        }

        private void UIBtnUpdate_Click(object sender, EventArgs e)
        {
            if (this.UIListBox.SelectedItems.Count == 0)
            {
                return;
            }

            var user = (User)this.UIListBox.SelectedItems[0];
            user.Name = this.UIUnputName.Text;
            user.SurName = this.UIInputSurName.Text;

            log.Info($"update {user.FullName}");

            this.updateListBox();
        }

        private void UIBtnDelete_Click(object sender, EventArgs e)
        {
            if (this.UIListBox.SelectedItems.Count == 0)
            {
                return;
            }

            var user = (User)this.UIListBox.SelectedItems[0];
            this.allUsers.Remove(user);

            log.Info($"delete {user.FullName}");

            this.updateListBox();
        }

        #endregion


    }
}
