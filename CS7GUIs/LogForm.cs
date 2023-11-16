using System.Windows.Forms;

namespace CS7GUIs
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 檢查是否是因為按下了X按鈕觸發的關閉事件
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 取消默認的窗口關閉行為
                e.Cancel = true;

                // 隱藏窗口而不是關閉它
                this.Hide();

                return;
            }

            base.OnFormClosing(e);
        }
    }
}
