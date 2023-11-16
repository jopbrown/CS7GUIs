using NLog;
using System;
using System.Windows.Forms;

namespace CS7GUIs
{
    public partial class MainForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UIBtnShowLog_ButtonClick(object sender, EventArgs e)
        {
            this.UITabCtrl.SelectedTab = this.UITabPgLog;
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
    }
}
