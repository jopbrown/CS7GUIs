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
            this.components = new System.ComponentModel.Container();
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
            this.UITabPgTimer = new TabPage();
            this.UIPanelTimer = new TableLayoutPanel();
            this.label3 = new Label();
            this.UILblElapsed = new Label();
            this.label5 = new Label();
            this.UIBtnResetTimer = new Button();
            this.UIProgessElapsed = new ProgressBar();
            this.UITrackDuration = new TrackBar();
            this.UITabCRUD = new TabPage();
            this.tableLayoutPanel2 = new TableLayoutPanel();
            this.label4 = new Label();
            this.UIInputFilter = new TextBox();
            this.label6 = new Label();
            this.label7 = new Label();
            this.UIUnputName = new TextBox();
            this.UIInputSurName = new TextBox();
            this.UIBtnCreate = new Button();
            this.UIBtnUpdate = new Button();
            this.UIBtnDelete = new Button();
            this.UIListBox = new ListBox();
            this.UIStatusBar = new StatusStrip();
            this.UIStatusLbl = new ToolStripStatusLabel();
            this.UIBtnShowLog = new ToolStripSplitButton();
            this.UITimeTicker = new Timer(this.components);
            this.UITabCtrl.SuspendLayout();
            this.UITabPgCounter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UITabPgTemp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UITabPgBook.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.UITabPgTimer.SuspendLayout();
            this.UIPanelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.UITrackDuration).BeginInit();
            this.UITabCRUD.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.UIStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // UITabCtrl
            // 
            this.UITabCtrl.Controls.Add(this.UITabPgCounter);
            this.UITabCtrl.Controls.Add(this.UITabPgTemp);
            this.UITabCtrl.Controls.Add(this.UITabPgBook);
            this.UITabCtrl.Controls.Add(this.UITabPgTimer);
            this.UITabCtrl.Controls.Add(this.UITabCRUD);
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
            // UITabPgTimer
            // 
            this.UITabPgTimer.Controls.Add(this.UIPanelTimer);
            this.UITabPgTimer.Location = new Point(4, 28);
            this.UITabPgTimer.Name = "UITabPgTimer";
            this.UITabPgTimer.Padding = new Padding(3);
            this.UITabPgTimer.Size = new Size(474, 421);
            this.UITabPgTimer.TabIndex = 4;
            this.UITabPgTimer.Text = "Timer";
            this.UITabPgTimer.UseVisualStyleBackColor = true;
            // 
            // UIPanelTimer
            // 
            this.UIPanelTimer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.UIPanelTimer.ColumnCount = 2;
            this.UIPanelTimer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            this.UIPanelTimer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.UIPanelTimer.Controls.Add(this.label3, 0, 0);
            this.UIPanelTimer.Controls.Add(this.UILblElapsed, 0, 1);
            this.UIPanelTimer.Controls.Add(this.label5, 0, 2);
            this.UIPanelTimer.Controls.Add(this.UIBtnResetTimer, 0, 3);
            this.UIPanelTimer.Controls.Add(this.UIProgessElapsed, 1, 0);
            this.UIPanelTimer.Controls.Add(this.UITrackDuration, 1, 2);
            this.UIPanelTimer.Location = new Point(8, 102);
            this.UIPanelTimer.Name = "UIPanelTimer";
            this.UIPanelTimer.RowCount = 4;
            this.UIPanelTimer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.UIPanelTimer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.UIPanelTimer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.UIPanelTimer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.UIPanelTimer.Size = new Size(460, 152);
            this.UIPanelTimer.TabIndex = 0;
            this.UIPanelTimer.VisibleChanged += this.UIPanelTimer_VisibleChanged;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(3, 10);
            this.label3.Margin = new Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(104, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Elapsed Time:";
            // 
            // UILblElapsed
            // 
            this.UILblElapsed.AutoSize = true;
            this.UIPanelTimer.SetColumnSpan(this.UILblElapsed, 2);
            this.UILblElapsed.Location = new Point(3, 48);
            this.UILblElapsed.Margin = new Padding(3, 10, 3, 0);
            this.UILblElapsed.Name = "UILblElapsed";
            this.UILblElapsed.Size = new Size(37, 19);
            this.UILblElapsed.TabIndex = 1;
            this.UILblElapsed.Text = "0.0s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(3, 86);
            this.label5.Margin = new Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(73, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Duration:";
            // 
            // UIBtnResetTimer
            // 
            this.UIPanelTimer.SetColumnSpan(this.UIBtnResetTimer, 2);
            this.UIBtnResetTimer.Dock = DockStyle.Fill;
            this.UIBtnResetTimer.Location = new Point(3, 117);
            this.UIBtnResetTimer.Name = "UIBtnResetTimer";
            this.UIBtnResetTimer.Size = new Size(454, 32);
            this.UIBtnResetTimer.TabIndex = 3;
            this.UIBtnResetTimer.Text = "Reset";
            this.UIBtnResetTimer.UseVisualStyleBackColor = true;
            this.UIBtnResetTimer.Click += this.UIBtnResetTimer_Click;
            // 
            // UIProgessElapsed
            // 
            this.UIProgessElapsed.Dock = DockStyle.Fill;
            this.UIProgessElapsed.Location = new Point(116, 3);
            this.UIProgessElapsed.Name = "UIProgessElapsed";
            this.UIProgessElapsed.Size = new Size(341, 32);
            this.UIProgessElapsed.TabIndex = 4;
            // 
            // UITrackDuration
            // 
            this.UITrackDuration.Dock = DockStyle.Fill;
            this.UITrackDuration.Location = new Point(116, 79);
            this.UITrackDuration.Name = "UITrackDuration";
            this.UITrackDuration.Size = new Size(341, 32);
            this.UITrackDuration.TabIndex = 5;
            this.UITrackDuration.Scroll += this.UITrackDuration_Scroll;
            // 
            // UITabCRUD
            // 
            this.UITabCRUD.Controls.Add(this.tableLayoutPanel2);
            this.UITabCRUD.Location = new Point(4, 28);
            this.UITabCRUD.Name = "UITabCRUD";
            this.UITabCRUD.Padding = new Padding(3);
            this.UITabCRUD.Size = new Size(474, 421);
            this.UITabCRUD.TabIndex = 5;
            this.UITabCRUD.Text = "CRUD";
            this.UITabCRUD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UIInputFilter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.UIUnputName, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.UIInputSurName, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.UIBtnCreate, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.UIBtnUpdate, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.UIBtnDelete, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.UIListBox, 0, 1);
            this.tableLayoutPanel2.Dock = DockStyle.Fill;
            this.tableLayoutPanel2.Location = new Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new Size(468, 415);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(3, 8);
            this.label4.Margin = new Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filter prefix:";
            // 
            // UIInputFilter
            // 
            this.UIInputFilter.Location = new Point(120, 6);
            this.UIInputFilter.Margin = new Padding(3, 6, 3, 3);
            this.UIInputFilter.Name = "UIInputFilter";
            this.UIInputFilter.Size = new Size(111, 27);
            this.UIInputFilter.TabIndex = 1;
            this.UIInputFilter.TextChanged += this.UIInputFilter_TextChanged;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(237, 46);
            this.label6.Margin = new Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(54, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(237, 86);
            this.label7.Margin = new Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(75, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Surname:";
            // 
            // UIUnputName
            // 
            this.UIUnputName.Location = new Point(354, 43);
            this.UIUnputName.Name = "UIUnputName";
            this.UIUnputName.Size = new Size(111, 27);
            this.UIUnputName.TabIndex = 5;
            // 
            // UIInputSurName
            // 
            this.UIInputSurName.Location = new Point(354, 83);
            this.UIInputSurName.Name = "UIInputSurName";
            this.UIInputSurName.Size = new Size(111, 27);
            this.UIInputSurName.TabIndex = 6;
            // 
            // UIBtnCreate
            // 
            this.UIBtnCreate.Dock = DockStyle.Fill;
            this.UIBtnCreate.Location = new Point(3, 356);
            this.UIBtnCreate.Name = "UIBtnCreate";
            this.UIBtnCreate.Size = new Size(111, 34);
            this.UIBtnCreate.TabIndex = 7;
            this.UIBtnCreate.Text = "Create";
            this.UIBtnCreate.UseVisualStyleBackColor = true;
            this.UIBtnCreate.Click += this.UIBtnCreate_Click;
            // 
            // UIBtnUpdate
            // 
            this.UIBtnUpdate.Dock = DockStyle.Fill;
            this.UIBtnUpdate.Location = new Point(120, 356);
            this.UIBtnUpdate.Name = "UIBtnUpdate";
            this.UIBtnUpdate.Size = new Size(111, 34);
            this.UIBtnUpdate.TabIndex = 8;
            this.UIBtnUpdate.Text = "Update";
            this.UIBtnUpdate.UseVisualStyleBackColor = true;
            this.UIBtnUpdate.Click += this.UIBtnUpdate_Click;
            // 
            // UIBtnDelete
            // 
            this.UIBtnDelete.Dock = DockStyle.Fill;
            this.UIBtnDelete.Location = new Point(237, 356);
            this.UIBtnDelete.Name = "UIBtnDelete";
            this.UIBtnDelete.Size = new Size(111, 34);
            this.UIBtnDelete.TabIndex = 9;
            this.UIBtnDelete.Text = "Delete";
            this.UIBtnDelete.UseVisualStyleBackColor = true;
            this.UIBtnDelete.Click += this.UIBtnDelete_Click;
            // 
            // UIListBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.UIListBox, 2);
            this.UIListBox.Dock = DockStyle.Fill;
            this.UIListBox.FormattingEnabled = true;
            this.UIListBox.ItemHeight = 19;
            this.UIListBox.Location = new Point(3, 43);
            this.UIListBox.Name = "UIListBox";
            this.tableLayoutPanel2.SetRowSpan(this.UIListBox, 4);
            this.UIListBox.Size = new Size(228, 307);
            this.UIListBox.TabIndex = 10;
            this.UIListBox.SelectedIndexChanged += this.UIListBox_SelectedIndexChanged;
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
            // UITimeTicker
            // 
            this.UITimeTicker.Tick += this.UITimeTicker_Tick;
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
            this.UITabPgTimer.ResumeLayout(false);
            this.UIPanelTimer.ResumeLayout(false);
            this.UIPanelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.UITrackDuration).EndInit();
            this.UITabCRUD.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private TabPage UITabPgTimer;
        private TableLayoutPanel UIPanelTimer;
        private Label label3;
        private Label UILblElapsed;
        private Label label5;
        private Button UIBtnResetTimer;
        private ProgressBar UIProgessElapsed;
        private TrackBar UITrackDuration;
        private Timer UITimeTicker;
        private TabPage UITabCRUD;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private TextBox UIInputFilter;
        private Label label6;
        private Label label7;
        private TextBox UIUnputName;
        private TextBox UIInputSurName;
        private Button UIBtnCreate;
        private Button UIBtnUpdate;
        private Button UIBtnDelete;
        private ListBox UIListBox;
    }
}
