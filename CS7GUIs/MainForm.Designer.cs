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
            this.UITabCtrl = new TabControl();
            this.UITabPgCounter = new TabPage();
            this.panel1 = new Panel();
            this.UITextCounter = new TextBox();
            this.UIBtnCount = new Button();
            this.UITabPgTemp = new TabPage();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.label2 = new Label();
            this.UIInputC = new TextBox();
            this.UIInputF = new TextBox();
            this.label1 = new Label();
            this.UITabPgBook = new TabPage();
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.UIOptionBook = new ComboBox();
            this.UIInputStartDate = new TextBox();
            this.UIInputReturnDate = new TextBox();
            this.UIBtnBook = new Button();
            this.UIStatusBar = new StatusStrip();
            this.UIStatusLbl = new ToolStripStatusLabel();
            this.UIBtnShowLog = new ToolStripSplitButton();
            this.UITabCtrl.SuspendLayout();
            this.UITabPgCounter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UITabPgTemp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UITabPgBook.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.UIStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // UITabCtrl
            // 
            this.UITabCtrl.Controls.Add(this.UITabPgCounter);
            this.UITabCtrl.Controls.Add(this.UITabPgTemp);
            this.UITabCtrl.Controls.Add(this.UITabPgBook);
            this.UITabCtrl.Dock = DockStyle.Fill;
            this.UITabCtrl.Location = new Point(0, 0);
            this.UITabCtrl.Name = "UITabCtrl";
            this.UITabCtrl.SelectedIndex = 0;
            this.UITabCtrl.Size = new Size(482, 453);
            this.UITabCtrl.TabIndex = 1;
            // 
            // UITabPgCounter
            // 
            this.UITabPgCounter.Controls.Add(this.panel1);
            this.UITabPgCounter.Location = new Point(4, 28);
            this.UITabPgCounter.Name = "UITabPgCounter";
            this.UITabPgCounter.Padding = new Padding(3);
            this.UITabPgCounter.Size = new Size(474, 421);
            this.UITabPgCounter.TabIndex = 0;
            this.UITabPgCounter.Text = "Counter";
            this.UITabPgCounter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.panel1.Controls.Add(this.UITextCounter);
            this.panel1.Controls.Add(this.UIBtnCount);
            this.panel1.Location = new Point(6, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(458, 38);
            this.panel1.TabIndex = 0;
            // 
            // UITextCounter
            // 
            this.UITextCounter.Location = new Point(3, 7);
            this.UITextCounter.Name = "UITextCounter";
            this.UITextCounter.ReadOnly = true;
            this.UITextCounter.Size = new Size(125, 27);
            this.UITextCounter.TabIndex = 1;
            this.UITextCounter.Text = "0";
            // 
            // UIBtnCount
            // 
            this.UIBtnCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.UIBtnCount.Location = new Point(134, 6);
            this.UIBtnCount.Name = "UIBtnCount";
            this.UIBtnCount.Size = new Size(321, 29);
            this.UIBtnCount.TabIndex = 0;
            this.UIBtnCount.Text = "Count";
            this.UIBtnCount.UseVisualStyleBackColor = true;
            this.UIBtnCount.Click += this.UIBtnCount_Click;
            // 
            // UITabPgTemp
            // 
            this.UITabPgTemp.Controls.Add(this.tableLayoutPanel1);
            this.UITabPgTemp.Location = new Point(4, 28);
            this.UITabPgTemp.Name = "UITabPgTemp";
            this.UITabPgTemp.Padding = new Padding(3);
            this.UITabPgTemp.Size = new Size(474, 421);
            this.UITabPgTemp.TabIndex = 2;
            this.UITabPgTemp.Text = "TempConv";
            this.UITabPgTemp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.UIInputC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UIInputF, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new Point(8, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new Size(460, 37);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(373, 7);
            this.label2.Margin = new Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(83, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // UIInputC
            // 
            this.UIInputC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.UIInputC.Location = new Point(4, 4);
            this.UIInputC.Name = "UIInputC";
            this.UIInputC.Size = new Size(135, 27);
            this.UIInputC.TabIndex = 2;
            this.UIInputC.TextChanged += this.UIInputC_TextChanged;
            // 
            // UIInputF
            // 
            this.UIInputF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.UIInputF.Location = new Point(230, 4);
            this.UIInputF.Name = "UIInputF";
            this.UIInputF.Size = new Size(135, 27);
            this.UIInputF.TabIndex = 0;
            this.UIInputF.TextChanged += this.UIInputF_TextChanged;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(146, 7);
            this.label1.Margin = new Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius = ";
            // 
            // UITabPgBook
            // 
            this.UITabPgBook.Controls.Add(this.flowLayoutPanel1);
            this.UITabPgBook.Location = new Point(4, 28);
            this.UITabPgBook.Name = "UITabPgBook";
            this.UITabPgBook.Padding = new Padding(3);
            this.UITabPgBook.Size = new Size(474, 421);
            this.UITabPgBook.TabIndex = 3;
            this.UITabPgBook.Text = "Book Flight";
            this.UITabPgBook.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            this.flowLayoutPanel1.Controls.Add(this.UIOptionBook);
            this.flowLayoutPanel1.Controls.Add(this.UIInputStartDate);
            this.flowLayoutPanel1.Controls.Add(this.UIInputReturnDate);
            this.flowLayoutPanel1.Controls.Add(this.UIBtnBook);
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new Point(133, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(216, 390);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UIOptionBook
            // 
            this.UIOptionBook.DropDownStyle = ComboBoxStyle.DropDownList;
            this.UIOptionBook.FormattingEnabled = true;
            this.UIOptionBook.Location = new Point(3, 3);
            this.UIOptionBook.Name = "UIOptionBook";
            this.UIOptionBook.Size = new Size(213, 27);
            this.UIOptionBook.TabIndex = 0;
            this.UIOptionBook.SelectedIndexChanged += this.UIOptionBook_SelectedIndexChanged;
            // 
            // UIInputStartDate
            // 
            this.UIInputStartDate.Location = new Point(3, 36);
            this.UIInputStartDate.Name = "UIInputStartDate";
            this.UIInputStartDate.Size = new Size(213, 27);
            this.UIInputStartDate.TabIndex = 1;
            this.UIInputStartDate.TextChanged += this.UIInputStartDate_TextChanged;
            // 
            // UIInputReturnDate
            // 
            this.UIInputReturnDate.Location = new Point(3, 69);
            this.UIInputReturnDate.Name = "UIInputReturnDate";
            this.UIInputReturnDate.Size = new Size(213, 27);
            this.UIInputReturnDate.TabIndex = 2;
            this.UIInputReturnDate.TextChanged += this.UIInputReturnDate_TextChanged;
            // 
            // UIBtnBook
            // 
            this.UIBtnBook.Location = new Point(3, 102);
            this.UIBtnBook.Name = "UIBtnBook";
            this.UIBtnBook.Size = new Size(213, 29);
            this.UIBtnBook.TabIndex = 3;
            this.UIBtnBook.Text = "Book";
            this.UIBtnBook.UseVisualStyleBackColor = true;
            this.UIBtnBook.Click += this.UIBtnBook_Click;
            // 
            // UIStatusBar
            // 
            this.UIStatusBar.ImageScalingSize = new Size(20, 20);
            this.UIStatusBar.Items.AddRange(new ToolStripItem[] { this.UIStatusLbl, this.UIBtnShowLog });
            this.UIStatusBar.Location = new Point(0, 427);
            this.UIStatusBar.Name = "UIStatusBar";
            this.UIStatusBar.Size = new Size(482, 26);
            this.UIStatusBar.TabIndex = 1;
            this.UIStatusBar.Text = "statusStrip1";
            // 
            // UIStatusLbl
            // 
            this.UIStatusLbl.Name = "UIStatusLbl";
            this.UIStatusLbl.Size = new Size(442, 20);
            this.UIStatusLbl.Spring = true;
            this.UIStatusLbl.Text = "Ready";
            this.UIStatusLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UIBtnShowLog
            // 
            this.UIBtnShowLog.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.UIBtnShowLog.DropDownButtonWidth = 0;
            this.UIBtnShowLog.Image = Properties.Resources.log_icon;
            this.UIBtnShowLog.ImageTransparentColor = Color.Magenta;
            this.UIBtnShowLog.Name = "UIBtnShowLog";
            this.UIBtnShowLog.Size = new Size(25, 24);
            this.UIBtnShowLog.ToolTipText = "Show Log";
            this.UIBtnShowLog.ButtonClick += this.UIBtnShowLog_ButtonClick;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(9F, 19F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(482, 453);
            this.Controls.Add(this.UIStatusBar);
            this.Controls.Add(this.UITabCtrl);
            this.Name = "MainForm";
            this.Text = "7GUIs";
            this.Load += this.MainForm_Load;
            this.UITabCtrl.ResumeLayout(false);
            this.UITabPgCounter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UITabPgTemp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UITabPgBook.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.UIStatusBar.ResumeLayout(false);
            this.UIStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TabControl UITabCtrl;
        private TabPage UITabPgCounter;
        private StatusStrip UIStatusBar;
        private ToolStripStatusLabel UIStatusLbl;
        private ToolStripSplitButton UIBtnShowLog;
        private Panel panel1;
        private TextBox UITextCounter;
        private Button UIBtnCount;
        private TabPage UITabPgTemp;
        private Label label2;
        private TextBox UIInputC;
        private Label label1;
        private TextBox UIInputF;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage UITabPgBook;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox UIOptionBook;
        private TextBox UIInputStartDate;
        private TextBox UIInputReturnDate;
        private Button UIBtnBook;
    }
}
