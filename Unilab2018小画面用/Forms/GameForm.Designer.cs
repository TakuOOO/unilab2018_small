using Unilab2018.CustomControl;

namespace Unilab2018.Forms
{
    partial class GameForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.codeTimer = new System.Windows.Forms.Timer(this.components);
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.MPTextBox = new System.Windows.Forms.TextBox();
            this.PedometerTextBox = new System.Windows.Forms.TextBox();
            this.forComboBox = new System.Windows.Forms.ComboBox();
            this.HPTextBox = new System.Windows.Forms.TextBox();
            this.ifComboBox = new System.Windows.Forms.ComboBox();
            this.currentStageTextBox = new System.Windows.Forms.TextBox();
            this.forNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.goalPictureBox = new System.Windows.Forms.PictureBox();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPictureBox = new System.Windows.Forms.PictureBox();
            this.startPagePictureBox = new System.Windows.Forms.PictureBox();
            this.allGoaledPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stage17Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage16Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage15Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage14Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage13Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage1Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage12Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage2Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage3Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage11Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage4Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage5Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage10Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage6Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage7Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage8Btn = new Unilab2018.CustomControl.ButtonEx();
            this.exeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.stage9Btn = new Unilab2018.CustomControl.ButtonEx();
            this.endlessBtn = new Unilab2018.CustomControl.ButtonEx();
            this.removeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.turnRightBtn = new Unilab2018.CustomControl.ButtonEx();
            this.endBtn = new Unilab2018.CustomControl.ButtonEx();
            this.moveBtn = new Unilab2018.CustomControl.ButtonEx();
            this.removeAllBtn = new Unilab2018.CustomControl.ButtonEx();
            this.turnLeftBtn = new Unilab2018.CustomControl.ButtonEx();
            this.resetPlayerBtn = new Unilab2018.CustomControl.ButtonEx();
            this.forBtn = new Unilab2018.CustomControl.ButtonEx();
            this.cureBtn = new Unilab2018.CustomControl.ButtonEx();
            this.editCustomSatgeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.ifBtn = new Unilab2018.CustomControl.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.forNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGoaledPictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // codeTimer
            // 
            this.codeTimer.Tick += new System.EventHandler(this.codeTimer_Tick);
            // 
            // codeListBox
            // 
            this.codeListBox.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Bold);
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 60;
            this.codeListBox.Location = new System.Drawing.Point(1497, 302);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(520, 1264);
            this.codeListBox.TabIndex = 32;
            // 
            // MPTextBox
            // 
            this.MPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MPTextBox.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Bold);
            this.MPTextBox.Location = new System.Drawing.Point(7, 152);
            this.MPTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MPTextBox.Name = "MPTextBox";
            this.MPTextBox.Size = new System.Drawing.Size(582, 67);
            this.MPTextBox.TabIndex = 50;
            // 
            // PedometerTextBox
            // 
            this.PedometerTextBox.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold);
            this.PedometerTextBox.Location = new System.Drawing.Point(2559, 1790);
            this.PedometerTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PedometerTextBox.Name = "PedometerTextBox";
            this.PedometerTextBox.Size = new System.Drawing.Size(680, 79);
            this.PedometerTextBox.TabIndex = 53;
            // 
            // forComboBox
            // 
            this.forComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forComboBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.forComboBox.FormattingEnabled = true;
            this.forComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.forComboBox.Location = new System.Drawing.Point(2531, 582);
            this.forComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.forComboBox.Name = "forComboBox";
            this.forComboBox.Size = new System.Drawing.Size(144, 44);
            this.forComboBox.TabIndex = 51;
            this.forComboBox.Visible = false;
            // 
            // HPTextBox
            // 
            this.HPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPTextBox.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Bold);
            this.HPTextBox.Location = new System.Drawing.Point(7, 79);
            this.HPTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.HPTextBox.Name = "HPTextBox";
            this.HPTextBox.Size = new System.Drawing.Size(582, 67);
            this.HPTextBox.TabIndex = 52;
            // 
            // ifComboBox
            // 
            this.ifComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ifComboBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ifComboBox.FormattingEnabled = true;
            this.ifComboBox.Items.AddRange(new object[] {
            "前が道なら",
            "後ろが道なら",
            "右が道なら",
            "左が道なら",
            "HPが1なら",
            "HPが4なら",
            "HPが7なら",
            "前が花なら",
            "後ろが花なら",
            "右が花なら",
            "左が花なら",
            "前が沼なら",
            "後ろが沼なら",
            "右が沼なら",
            "左が沼なら",
            "前がテレポーターなら",
            "後ろがテレポーターなら",
            "右がテレポーターなら",
            "左がテレポーターなら"});
            this.ifComboBox.Location = new System.Drawing.Point(2110, 134);
            this.ifComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ifComboBox.Name = "ifComboBox";
            this.ifComboBox.Size = new System.Drawing.Size(229, 44);
            this.ifComboBox.TabIndex = 40;
            this.ifComboBox.SelectedIndexChanged += new System.EventHandler(this.ifComboBox_SelectedIndexChanged);
            // 
            // currentStageTextBox
            // 
            this.currentStageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStageTextBox.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Bold);
            this.currentStageTextBox.Location = new System.Drawing.Point(7, 6);
            this.currentStageTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.currentStageTextBox.Name = "currentStageTextBox";
            this.currentStageTextBox.Size = new System.Drawing.Size(582, 67);
            this.currentStageTextBox.TabIndex = 70;
            // 
            // forNumericUpDown
            // 
            this.forNumericUpDown.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold);
            this.forNumericUpDown.Location = new System.Drawing.Point(2434, 135);
            this.forNumericUpDown.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.forNumericUpDown.Name = "forNumericUpDown";
            this.forNumericUpDown.Size = new System.Drawing.Size(182, 43);
            this.forNumericUpDown.TabIndex = 71;
            this.forNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // goalPictureBox
            // 
            this.goalPictureBox.BackgroundImage = global::Unilab2018.Properties.Resources.ステージクリア;
            this.goalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goalPictureBox.Location = new System.Drawing.Point(42, 302);
            this.goalPictureBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.goalPictureBox.Name = "goalPictureBox";
            this.goalPictureBox.Size = new System.Drawing.Size(1435, 989);
            this.goalPictureBox.TabIndex = 73;
            this.goalPictureBox.TabStop = false;
            this.goalPictureBox.Visible = false;
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.backPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPictureBox.Location = new System.Drawing.Point(42, 302);
            this.backPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(1435, 989);
            this.backPictureBox.TabIndex = 33;
            this.backPictureBox.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            this.backgroundPictureBox.BackgroundImage = global::Unilab2018.Properties.Resources.background;
            this.backgroundPictureBox.Location = new System.Drawing.Point(-120, -192);
            this.backgroundPictureBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.backgroundPictureBox.Name = "backgroundPictureBox";
            this.backgroundPictureBox.Size = new System.Drawing.Size(3094, 2160);
            this.backgroundPictureBox.TabIndex = 64;
            this.backgroundPictureBox.TabStop = false;
            this.backgroundPictureBox.Click += new System.EventHandler(this.backgroundPictureBox_Click);
            // 
            // startPagePictureBox
            // 
            this.startPagePictureBox.BackgroundImage = global::Unilab2018.Properties.Resources.表紙;
            this.startPagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startPagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.startPagePictureBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.startPagePictureBox.Name = "startPagePictureBox";
            this.startPagePictureBox.Size = new System.Drawing.Size(1300, 800);
            this.startPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startPagePictureBox.TabIndex = 72;
            this.startPagePictureBox.TabStop = false;
            this.startPagePictureBox.Click += new System.EventHandler(this.startPagePictureBox_Click);
            // 
            // allGoaledPictureBox
            // 
            this.allGoaledPictureBox.BackgroundImage = global::Unilab2018.Properties.Resources.全ステージクリア;
            this.allGoaledPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allGoaledPictureBox.Location = new System.Drawing.Point(0, 0);
            this.allGoaledPictureBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.allGoaledPictureBox.Name = "allGoaledPictureBox";
            this.allGoaledPictureBox.Size = new System.Drawing.Size(1300, 800);
            this.allGoaledPictureBox.TabIndex = 74;
            this.allGoaledPictureBox.TabStop = false;
            this.allGoaledPictureBox.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1638, 240);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.MPTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentStageTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.HPTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(881, 1346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(596, 220);
            this.tableLayoutPanel2.TabIndex = 76;
            // 
            // stage17Btn
            // 
            this.stage17Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ17;
            this.stage17Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage17Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage17Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage17Btn.Location = new System.Drawing.Point(1750, 128);
            this.stage17Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage17Btn.Name = "stage17Btn";
            this.stage17Btn.Size = new System.Drawing.Size(182, 120);
            this.stage17Btn.TabIndex = 69;
            this.stage17Btn.UseVisualStyleBackColor = true;
            this.stage17Btn.Click += new System.EventHandler(this.stage17Btn_Click);
            // 
            // stage16Btn
            // 
            this.stage16Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ16;
            this.stage16Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage16Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage16Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage16Btn.Location = new System.Drawing.Point(1750, 128);
            this.stage16Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage16Btn.Name = "stage16Btn";
            this.stage16Btn.Size = new System.Drawing.Size(182, 120);
            this.stage16Btn.TabIndex = 68;
            this.stage16Btn.UseVisualStyleBackColor = true;
            this.stage16Btn.Click += new System.EventHandler(this.stage16Btn_Click);
            // 
            // stage15Btn
            // 
            this.stage15Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ15;
            this.stage15Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage15Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage15Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage15Btn.Location = new System.Drawing.Point(1750, 128);
            this.stage15Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage15Btn.Name = "stage15Btn";
            this.stage15Btn.Size = new System.Drawing.Size(182, 120);
            this.stage15Btn.TabIndex = 67;
            this.stage15Btn.UseVisualStyleBackColor = true;
            this.stage15Btn.Click += new System.EventHandler(this.stage15Btn_Click);
            // 
            // stage14Btn
            // 
            this.stage14Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ14;
            this.stage14Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage14Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage14Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage14Btn.Location = new System.Drawing.Point(1691, 147);
            this.stage14Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage14Btn.Name = "stage14Btn";
            this.stage14Btn.Size = new System.Drawing.Size(182, 120);
            this.stage14Btn.TabIndex = 66;
            this.stage14Btn.UseVisualStyleBackColor = true;
            this.stage14Btn.Click += new System.EventHandler(this.stage14Btn_Click);
            // 
            // stage13Btn
            // 
            this.stage13Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ13;
            this.stage13Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage13Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage13Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage13Btn.Location = new System.Drawing.Point(1691, 116);
            this.stage13Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage13Btn.Name = "stage13Btn";
            this.stage13Btn.Size = new System.Drawing.Size(182, 120);
            this.stage13Btn.TabIndex = 65;
            this.stage13Btn.UseVisualStyleBackColor = true;
            this.stage13Btn.Click += new System.EventHandler(this.stage13Btn_Click);
            // 
            // stage1Btn
            // 
            this.stage1Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ１;
            this.stage1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage1Btn.Location = new System.Drawing.Point(108, 128);
            this.stage1Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage1Btn.Name = "stage1Btn";
            this.stage1Btn.Size = new System.Drawing.Size(182, 120);
            this.stage1Btn.TabIndex = 46;
            this.stage1Btn.UseVisualStyleBackColor = true;
            this.stage1Btn.Click += new System.EventHandler(this.stage1Btn_Click);
            // 
            // stage12Btn
            // 
            this.stage12Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ12;
            this.stage12Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage12Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage12Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage12Btn.Location = new System.Drawing.Point(1691, 93);
            this.stage12Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage12Btn.Name = "stage12Btn";
            this.stage12Btn.Size = new System.Drawing.Size(182, 120);
            this.stage12Btn.TabIndex = 63;
            this.stage12Btn.UseVisualStyleBackColor = true;
            this.stage12Btn.Click += new System.EventHandler(this.stage12Btn_Click);
            // 
            // stage2Btn
            // 
            this.stage2Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ2;
            this.stage2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage2Btn.Location = new System.Drawing.Point(303, 128);
            this.stage2Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage2Btn.Name = "stage2Btn";
            this.stage2Btn.Size = new System.Drawing.Size(182, 120);
            this.stage2Btn.TabIndex = 47;
            this.stage2Btn.UseVisualStyleBackColor = true;
            this.stage2Btn.Click += new System.EventHandler(this.stage2Btn_Click);
            // 
            // stage3Btn
            // 
            this.stage3Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ3;
            this.stage3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage3Btn.Location = new System.Drawing.Point(499, 128);
            this.stage3Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage3Btn.Name = "stage3Btn";
            this.stage3Btn.Size = new System.Drawing.Size(182, 120);
            this.stage3Btn.TabIndex = 49;
            this.stage3Btn.UseVisualStyleBackColor = true;
            this.stage3Btn.Click += new System.EventHandler(this.stage3Btn_Click);
            // 
            // stage11Btn
            // 
            this.stage11Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ11;
            this.stage11Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage11Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage11Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage11Btn.Location = new System.Drawing.Point(1691, 65);
            this.stage11Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage11Btn.Name = "stage11Btn";
            this.stage11Btn.Size = new System.Drawing.Size(182, 120);
            this.stage11Btn.TabIndex = 62;
            this.stage11Btn.UseVisualStyleBackColor = true;
            this.stage11Btn.Click += new System.EventHandler(this.stage11Btn_Click);
            // 
            // stage4Btn
            // 
            this.stage4Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ4;
            this.stage4Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage4Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage4Btn.Location = new System.Drawing.Point(693, 128);
            this.stage4Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage4Btn.Name = "stage4Btn";
            this.stage4Btn.Size = new System.Drawing.Size(182, 120);
            this.stage4Btn.TabIndex = 54;
            this.stage4Btn.UseVisualStyleBackColor = true;
            this.stage4Btn.Click += new System.EventHandler(this.stage4Btn_Click);
            // 
            // stage5Btn
            // 
            this.stage5Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ5;
            this.stage5Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage5Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage5Btn.Location = new System.Drawing.Point(888, 128);
            this.stage5Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage5Btn.Name = "stage5Btn";
            this.stage5Btn.Size = new System.Drawing.Size(182, 120);
            this.stage5Btn.TabIndex = 55;
            this.stage5Btn.UseVisualStyleBackColor = true;
            this.stage5Btn.Click += new System.EventHandler(this.stage5Btn_Click);
            // 
            // stage10Btn
            // 
            this.stage10Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ10;
            this.stage10Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage10Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage10Btn.Location = new System.Drawing.Point(1691, 34);
            this.stage10Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage10Btn.Name = "stage10Btn";
            this.stage10Btn.Size = new System.Drawing.Size(182, 120);
            this.stage10Btn.TabIndex = 61;
            this.stage10Btn.UseVisualStyleBackColor = true;
            this.stage10Btn.Click += new System.EventHandler(this.stage10Btn_Click);
            // 
            // stage6Btn
            // 
            this.stage6Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ6;
            this.stage6Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage6Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage6Btn.Location = new System.Drawing.Point(1083, 128);
            this.stage6Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage6Btn.Name = "stage6Btn";
            this.stage6Btn.Size = new System.Drawing.Size(182, 120);
            this.stage6Btn.TabIndex = 56;
            this.stage6Btn.UseVisualStyleBackColor = true;
            this.stage6Btn.Click += new System.EventHandler(this.stage6Btn_Click);
            // 
            // stage7Btn
            // 
            this.stage7Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ7;
            this.stage7Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage7Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage7Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage7Btn.Location = new System.Drawing.Point(1278, 128);
            this.stage7Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage7Btn.Name = "stage7Btn";
            this.stage7Btn.Size = new System.Drawing.Size(182, 120);
            this.stage7Btn.TabIndex = 58;
            this.stage7Btn.UseVisualStyleBackColor = true;
            this.stage7Btn.Click += new System.EventHandler(this.stage7Btn_Click);
            // 
            // stage8Btn
            // 
            this.stage8Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ8;
            this.stage8Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage8Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage8Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage8Btn.Location = new System.Drawing.Point(1473, 128);
            this.stage8Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage8Btn.Name = "stage8Btn";
            this.stage8Btn.Size = new System.Drawing.Size(182, 120);
            this.stage8Btn.TabIndex = 59;
            this.stage8Btn.UseVisualStyleBackColor = true;
            this.stage8Btn.Click += new System.EventHandler(this.stage8Btn_Click);
            // 
            // exeBtn
            // 
            this.exeBtn.BackgroundImage = global::Unilab2018.Properties.Resources.実行;
            this.exeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exeBtn.Location = new System.Drawing.Point(2138, 1130);
            this.exeBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.exeBtn.Name = "exeBtn";
            this.exeBtn.Size = new System.Drawing.Size(488, 185);
            this.exeBtn.TabIndex = 34;
            this.exeBtn.UseVisualStyleBackColor = true;
            this.exeBtn.Click += new System.EventHandler(this.exeBtn_Click);
            // 
            // stage9Btn
            // 
            this.stage9Btn.BackgroundImage = global::Unilab2018.Properties.Resources.ステージ9;
            this.stage9Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stage9Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stage9Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stage9Btn.Location = new System.Drawing.Point(1691, 15);
            this.stage9Btn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stage9Btn.Name = "stage9Btn";
            this.stage9Btn.Size = new System.Drawing.Size(182, 120);
            this.stage9Btn.TabIndex = 60;
            this.stage9Btn.UseVisualStyleBackColor = true;
            this.stage9Btn.Click += new System.EventHandler(this.stage9Btn_Click);
            // 
            // endlessBtn
            // 
            this.endlessBtn.BackgroundImage = global::Unilab2018.Properties.Resources.ずっと;
            this.endlessBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endlessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endlessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endlessBtn.Location = new System.Drawing.Point(2100, 282);
            this.endlessBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.endlessBtn.Name = "endlessBtn";
            this.endlessBtn.Size = new System.Drawing.Size(250, 180);
            this.endlessBtn.TabIndex = 48;
            this.endlessBtn.UseVisualStyleBackColor = true;
            this.endlessBtn.Click += new System.EventHandler(this.endlessBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackgroundImage = global::Unilab2018.Properties.Resources._1つ削除;
            this.removeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Location = new System.Drawing.Point(2038, 1399);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(228, 150);
            this.removeBtn.TabIndex = 35;
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.BackgroundImage = global::Unilab2018.Properties.Resources.右をむく_枠線なし_;
            this.turnRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnRightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnRightBtn.Location = new System.Drawing.Point(2425, 922);
            this.turnRightBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(250, 180);
            this.turnRightBtn.TabIndex = 39;
            this.turnRightBtn.UseVisualStyleBackColor = true;
            this.turnRightBtn.Click += new System.EventHandler(this.turnRightBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.BackgroundImage = global::Unilab2018.Properties.Resources.ここまで;
            this.endBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endBtn.Location = new System.Drawing.Point(2399, 282);
            this.endBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(250, 180);
            this.endBtn.TabIndex = 42;
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.moveBtn.BackgroundImage = global::Unilab2018.Properties.Resources.前に進む1;
            this.moveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveBtn.Location = new System.Drawing.Point(2254, 720);
            this.moveBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(250, 180);
            this.moveBtn.TabIndex = 36;
            this.moveBtn.UseVisualStyleBackColor = false;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.BackgroundImage = global::Unilab2018.Properties.Resources.全て削除;
            this.removeAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeAllBtn.Location = new System.Drawing.Point(2276, 1399);
            this.removeAllBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(228, 150);
            this.removeAllBtn.TabIndex = 43;
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.BackgroundImage = global::Unilab2018.Properties.Resources.左をむく;
            this.turnLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnLeftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnLeftBtn.Location = new System.Drawing.Point(2089, 922);
            this.turnLeftBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(250, 180);
            this.turnLeftBtn.TabIndex = 41;
            this.turnLeftBtn.UseVisualStyleBackColor = true;
            this.turnLeftBtn.Click += new System.EventHandler(this.turnLeftBtn_Click);
            // 
            // resetPlayerBtn
            // 
            this.resetPlayerBtn.BackgroundImage = global::Unilab2018.Properties.Resources.プレイヤー_をリセット;
            this.resetPlayerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetPlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetPlayerBtn.Location = new System.Drawing.Point(2518, 1399);
            this.resetPlayerBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.resetPlayerBtn.Name = "resetPlayerBtn";
            this.resetPlayerBtn.Size = new System.Drawing.Size(228, 150);
            this.resetPlayerBtn.TabIndex = 44;
            this.resetPlayerBtn.UseVisualStyleBackColor = true;
            this.resetPlayerBtn.Click += new System.EventHandler(this.resetPlayerBtn_Click);
            // 
            // forBtn
            // 
            this.forBtn.BackgroundImage = global::Unilab2018.Properties.Resources.くり返し;
            this.forBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forBtn.Location = new System.Drawing.Point(2398, 59);
            this.forBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(250, 180);
            this.forBtn.TabIndex = 38;
            this.forBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forBtn.UseVisualStyleBackColor = true;
            this.forBtn.Click += new System.EventHandler(this.forBtn_Click);
            // 
            // cureBtn
            // 
            this.cureBtn.BackgroundImage = global::Unilab2018.Properties.Resources.回復;
            this.cureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cureBtn.Location = new System.Drawing.Point(2248, 501);
            this.cureBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cureBtn.Name = "cureBtn";
            this.cureBtn.Size = new System.Drawing.Size(250, 180);
            this.cureBtn.TabIndex = 45;
            this.cureBtn.UseVisualStyleBackColor = true;
            this.cureBtn.Click += new System.EventHandler(this.cureBtn_Click);
            // 
            // editCustomSatgeBtn
            // 
            this.editCustomSatgeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editCustomSatgeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editCustomSatgeBtn.Location = new System.Drawing.Point(3902, 112);
            this.editCustomSatgeBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.editCustomSatgeBtn.Name = "editCustomSatgeBtn";
            this.editCustomSatgeBtn.Size = new System.Drawing.Size(182, 120);
            this.editCustomSatgeBtn.TabIndex = 57;
            this.editCustomSatgeBtn.Text = "ステージ編集";
            this.editCustomSatgeBtn.UseVisualStyleBackColor = true;
            this.editCustomSatgeBtn.Visible = false;
            this.editCustomSatgeBtn.Click += new System.EventHandler(this.editCustomSatgeBtn_Click);
            // 
            // ifBtn
            // 
            this.ifBtn.BackgroundImage = global::Unilab2018.Properties.Resources.もし;
            this.ifBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ifBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ifBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ifBtn.Location = new System.Drawing.Point(2100, 59);
            this.ifBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ifBtn.Name = "ifBtn";
            this.ifBtn.Size = new System.Drawing.Size(250, 180);
            this.ifBtn.TabIndex = 37;
            this.ifBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ifBtn.UseVisualStyleBackColor = true;
            this.ifBtn.Click += new System.EventHandler(this.ifBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1629);
            this.Controls.Add(this.startPagePictureBox);
            this.Controls.Add(this.allGoaledPictureBox);
            this.Controls.Add(this.goalPictureBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.forNumericUpDown);
            this.Controls.Add(this.stage17Btn);
            this.Controls.Add(this.stage16Btn);
            this.Controls.Add(this.stage15Btn);
            this.Controls.Add(this.stage14Btn);
            this.Controls.Add(this.stage13Btn);
            this.Controls.Add(this.stage1Btn);
            this.Controls.Add(this.stage12Btn);
            this.Controls.Add(this.stage2Btn);
            this.Controls.Add(this.codeListBox);
            this.Controls.Add(this.stage3Btn);
            this.Controls.Add(this.stage11Btn);
            this.Controls.Add(this.stage4Btn);
            this.Controls.Add(this.stage5Btn);
            this.Controls.Add(this.stage10Btn);
            this.Controls.Add(this.stage6Btn);
            this.Controls.Add(this.PedometerTextBox);
            this.Controls.Add(this.stage7Btn);
            this.Controls.Add(this.stage8Btn);
            this.Controls.Add(this.exeBtn);
            this.Controls.Add(this.stage9Btn);
            this.Controls.Add(this.endlessBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.forComboBox);
            this.Controls.Add(this.turnRightBtn);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.ifComboBox);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.turnLeftBtn);
            this.Controls.Add(this.resetPlayerBtn);
            this.Controls.Add(this.forBtn);
            this.Controls.Add(this.cureBtn);
            this.Controls.Add(this.editCustomSatgeBtn);
            this.Controls.Add(this.ifBtn);
            this.Controls.Add(this.backgroundPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.forNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGoaledPictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.Timer codeTimer;
        private ButtonEx stage1Btn;
        private ButtonEx stage12Btn;
        private System.Windows.Forms.PictureBox backPictureBox;
        private ButtonEx stage2Btn;
        private System.Windows.Forms.ListBox codeListBox;
        private ButtonEx stage3Btn;
        private ButtonEx stage11Btn;
        private ButtonEx stage4Btn;
        private System.Windows.Forms.TextBox MPTextBox;
        private ButtonEx stage5Btn;
        private ButtonEx stage10Btn;
        private ButtonEx stage6Btn;
        private System.Windows.Forms.TextBox PedometerTextBox;
        private ButtonEx stage7Btn;
        private ButtonEx stage8Btn;
        private ButtonEx exeBtn;
        private ButtonEx stage9Btn;
        private ButtonEx endlessBtn;
        private ButtonEx removeBtn;
        private System.Windows.Forms.ComboBox forComboBox;
        private ButtonEx turnRightBtn;
        private System.Windows.Forms.TextBox HPTextBox;
        private ButtonEx endBtn;
        private System.Windows.Forms.ComboBox ifComboBox;
        private ButtonEx moveBtn;
        private ButtonEx removeAllBtn;
        private ButtonEx turnLeftBtn;
        private ButtonEx resetPlayerBtn;
        private ButtonEx forBtn;
        private ButtonEx cureBtn;
        private ButtonEx editCustomSatgeBtn;
        private ButtonEx ifBtn;
        private System.Windows.Forms.PictureBox backgroundPictureBox;
        private ButtonEx stage13Btn;
        private ButtonEx stage17Btn;
        private ButtonEx stage16Btn;
        private ButtonEx stage15Btn;
        private ButtonEx stage14Btn;
        private System.Windows.Forms.TextBox currentStageTextBox;
        private System.Windows.Forms.NumericUpDown forNumericUpDown;
        private System.Windows.Forms.PictureBox startPagePictureBox;
        private System.Windows.Forms.PictureBox goalPictureBox;
        private System.Windows.Forms.PictureBox allGoaledPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

