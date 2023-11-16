using System.Drawing;
using System.Windows.Forms;

namespace CS7GUIs
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            UIRTBLog = new RichTextBox();
            UITabCtrl = new TabControl();
            UITabPgCounter = new TabPage();
            panel1 = new Panel();
            UITextCounter = new TextBox();
            UIBtnCount = new Button();
            UITabPgLog = new TabPage();
            UIStatusBar = new StatusStrip();
            UIStatusLbl = new ToolStripStatusLabel();
            UIBtnShowLog = new ToolStripSplitButton();
            UITabCtrl.SuspendLayout();
            UITabPgCounter.SuspendLayout();
            panel1.SuspendLayout();
            UITabPgLog.SuspendLayout();
            UIStatusBar.SuspendLayout();
            SuspendLayout();
            // 
            // UIRTBLog
            // 
            UIRTBLog.Dock = DockStyle.Fill;
            UIRTBLog.Location = new Point(3, 3);
            UIRTBLog.Name = "UIRTBLog";
            UIRTBLog.Size = new Size(468, 415);
            UIRTBLog.TabIndex = 0;
            UIRTBLog.Text = "";
            // 
            // UITabCtrl
            // 
            UITabCtrl.Controls.Add(UITabPgCounter);
            UITabCtrl.Controls.Add(UITabPgLog);
            UITabCtrl.Dock = DockStyle.Fill;
            UITabCtrl.Location = new Point(0, 0);
            UITabCtrl.Name = "UITabCtrl";
            UITabCtrl.SelectedIndex = 0;
            UITabCtrl.Size = new Size(482, 453);
            UITabCtrl.TabIndex = 1;
            // 
            // UITabPgCounter
            // 
            UITabPgCounter.Controls.Add(panel1);
            UITabPgCounter.Location = new Point(4, 28);
            UITabPgCounter.Name = "UITabPgCounter";
            UITabPgCounter.Padding = new Padding(3);
            UITabPgCounter.Size = new Size(474, 421);
            UITabPgCounter.TabIndex = 0;
            UITabPgCounter.Text = "Counter";
            UITabPgCounter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(UITextCounter);
            panel1.Controls.Add(UIBtnCount);
            panel1.Location = new Point(6, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 38);
            panel1.TabIndex = 0;
            // 
            // UITextCounter
            // 
            UITextCounter.Location = new Point(3, 7);
            UITextCounter.Name = "UITextCounter";
            UITextCounter.ReadOnly = true;
            UITextCounter.Size = new Size(125, 27);
            UITextCounter.TabIndex = 1;
            UITextCounter.Text = "0";
            // 
            // UIBtnCount
            // 
            UIBtnCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UIBtnCount.Location = new Point(134, 6);
            UIBtnCount.Name = "UIBtnCount";
            UIBtnCount.Size = new Size(321, 29);
            UIBtnCount.TabIndex = 0;
            UIBtnCount.Text = "Count";
            UIBtnCount.UseVisualStyleBackColor = true;
            UIBtnCount.Click += UIBtnCount_Click;
            // 
            // UITabPgLog
            // 
            UITabPgLog.Controls.Add(UIRTBLog);
            UITabPgLog.Location = new Point(4, 28);
            UITabPgLog.Name = "UITabPgLog";
            UITabPgLog.Padding = new Padding(3);
            UITabPgLog.Size = new Size(474, 421);
            UITabPgLog.TabIndex = 1;
            UITabPgLog.Text = "Log";
            UITabPgLog.UseVisualStyleBackColor = true;
            // 
            // UIStatusBar
            // 
            UIStatusBar.ImageScalingSize = new Size(20, 20);
            UIStatusBar.Items.AddRange(new ToolStripItem[] { UIStatusLbl, UIBtnShowLog });
            UIStatusBar.Location = new Point(0, 427);
            UIStatusBar.Name = "UIStatusBar";
            UIStatusBar.Size = new Size(482, 26);
            UIStatusBar.TabIndex = 1;
            UIStatusBar.Text = "statusStrip1";
            // 
            // UIStatusLbl
            // 
            UIStatusLbl.Name = "UIStatusLbl";
            UIStatusLbl.Size = new Size(403, 20);
            UIStatusLbl.Spring = true;
            UIStatusLbl.Text = "Ready";
            UIStatusLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UIBtnShowLog
            // 
            UIBtnShowLog.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UIBtnShowLog.DropDownButtonWidth = 0;
            UIBtnShowLog.Image = (Image)resources.GetObject("UIBtnShowLog.Image");
            UIBtnShowLog.ImageTransparentColor = Color.Magenta;
            UIBtnShowLog.Name = "UIBtnShowLog";
            UIBtnShowLog.Size = new Size(25, 24);
            UIBtnShowLog.Text = "toolStripSplitButton1";
            UIBtnShowLog.ButtonClick += UIBtnShowLog_ButtonClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(UIStatusBar);
            Controls.Add(UITabCtrl);
            Name = "MainForm";
            Text = "7GUIs";
            Load += Form1_Load;
            UITabCtrl.ResumeLayout(false);
            UITabPgCounter.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UITabPgLog.ResumeLayout(false);
            UIStatusBar.ResumeLayout(false);
            UIStatusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox UIRTBLog;
        private TabControl UITabCtrl;
        private TabPage UITabPgCounter;
        private TabPage UITabPgLog;
        private StatusStrip UIStatusBar;
        private ToolStripStatusLabel UIStatusLbl;
        private ToolStripSplitButton UIBtnShowLog;
        private Panel panel1;
        private TextBox UITextCounter;
        private Button UIBtnCount;
    }
}
