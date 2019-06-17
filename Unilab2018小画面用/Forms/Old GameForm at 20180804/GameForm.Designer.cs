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
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.forComboBox = new System.Windows.Forms.ComboBox();
            this.untilComboBox = new System.Windows.Forms.ComboBox();
            this.elseIfComboBox = new System.Windows.Forms.ComboBox();
            this.ifComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MPTextBox = new System.Windows.Forms.TextBox();
            this.PedometerTextBox = new System.Windows.Forms.TextBox();
            this.HPTextBox = new System.Windows.Forms.TextBox();
            this.codeTimer = new System.Windows.Forms.Timer(this.components);
            this.stage12Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage11Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage10Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stopBtn = new Unilab2018.CustomControl.ButtonEx();
            this.startBtn = new Unilab2018.CustomControl.ButtonEx();
            this.stage9Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage8Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage7Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage6Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage5Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage4Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage3Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage2Btn = new Unilab2018.CustomControl.ButtonEx();
            this.stage1Btn = new Unilab2018.CustomControl.ButtonEx();
            this.cureBtn = new Unilab2018.CustomControl.ButtonEx();
            this.resetPlayerBtn = new Unilab2018.CustomControl.ButtonEx();
            this.turnLeftBtn = new Unilab2018.CustomControl.ButtonEx();
            this.removeAllBtn = new Unilab2018.CustomControl.ButtonEx();
            this.moveBtn = new Unilab2018.CustomControl.ButtonEx();
            this.endBtn = new Unilab2018.CustomControl.ButtonEx();
            this.turnRightBtn = new Unilab2018.CustomControl.ButtonEx();
            this.removeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.leftBtn = new Unilab2018.CustomControl.ButtonEx();
            this.downBtn = new Unilab2018.CustomControl.ButtonEx();
            this.upBtn = new Unilab2018.CustomControl.ButtonEx();
            this.rightBtn = new Unilab2018.CustomControl.ButtonEx();
            this.exeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.endlessBtn = new Unilab2018.CustomControl.ButtonEx();
            this.untilBtn = new Unilab2018.CustomControl.ButtonEx();
            this.elseBtn = new Unilab2018.CustomControl.ButtonEx();
            this.elseIfBtn = new Unilab2018.CustomControl.ButtonEx();
            this.ifBtn = new Unilab2018.CustomControl.ButtonEx();
            this.forBtn = new Unilab2018.CustomControl.ButtonEx();
            this.editCustomSatgeBtn = new Unilab2018.CustomControl.ButtonEx();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // codeListBox
            // 
            this.codeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 12;
            this.codeListBox.Location = new System.Drawing.Point(498, 2);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeListBox.Name = "codeListBox";
            this.codeListBox.Size = new System.Drawing.Size(146, 446);
            this.codeListBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.backPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.codeListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.editCustomSatgeBtn, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1246, 546);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.stage12Btn);
            this.groupBox2.Controls.Add(this.stage11Btn);
            this.groupBox2.Controls.Add(this.stage10Btn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(649, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 42);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // backPictureBox
            // 
            this.backPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.backPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPictureBox.Location = new System.Drawing.Point(2, 2);
            this.backPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.backPictureBox.Name = "backPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.backPictureBox, 3);
            this.backPictureBox.Size = new System.Drawing.Size(492, 542);
            this.backPictureBox.TabIndex = 4;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.SizeChanged += new System.EventHandler(this.backPictureBox_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.stage9Btn);
            this.groupBox1.Controls.Add(this.stage8Btn);
            this.groupBox1.Controls.Add(this.stage7Btn);
            this.groupBox1.Controls.Add(this.stage6Btn);
            this.groupBox1.Controls.Add(this.stage5Btn);
            this.groupBox1.Controls.Add(this.stage4Btn);
            this.groupBox1.Controls.Add(this.stage3Btn);
            this.groupBox1.Controls.Add(this.stage2Btn);
            this.groupBox1.Controls.Add(this.stage1Btn);
            this.groupBox1.Controls.Add(this.cureBtn);
            this.groupBox1.Controls.Add(this.resetPlayerBtn);
            this.groupBox1.Controls.Add(this.turnLeftBtn);
            this.groupBox1.Controls.Add(this.removeAllBtn);
            this.groupBox1.Controls.Add(this.moveBtn);
            this.groupBox1.Controls.Add(this.endBtn);
            this.groupBox1.Controls.Add(this.turnRightBtn);
            this.groupBox1.Controls.Add(this.removeBtn);
            this.groupBox1.Controls.Add(this.leftBtn);
            this.groupBox1.Controls.Add(this.downBtn);
            this.groupBox1.Controls.Add(this.upBtn);
            this.groupBox1.Controls.Add(this.rightBtn);
            this.groupBox1.Controls.Add(this.exeBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(649, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 444);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.forComboBox);
            this.groupBox3.Controls.Add(this.endlessBtn);
            this.groupBox3.Controls.Add(this.untilComboBox);
            this.groupBox3.Controls.Add(this.untilBtn);
            this.groupBox3.Controls.Add(this.elseBtn);
            this.groupBox3.Controls.Add(this.elseIfComboBox);
            this.groupBox3.Controls.Add(this.elseIfBtn);
            this.groupBox3.Controls.Add(this.ifComboBox);
            this.groupBox3.Controls.Add(this.ifBtn);
            this.groupBox3.Controls.Add(this.forBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(949, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 444);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // forComboBox
            // 
            this.forComboBox.FormattingEnabled = true;
            this.forComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.forComboBox.Location = new System.Drawing.Point(62, 269);
            this.forComboBox.Name = "forComboBox";
            this.forComboBox.Size = new System.Drawing.Size(120, 20);
            this.forComboBox.TabIndex = 23;
            // 
            // untilComboBox
            // 
            this.untilComboBox.FormattingEnabled = true;
            this.untilComboBox.Items.AddRange(new object[] {
            "前が敵でなくなる",
            "上が敵でなくなる",
            "下が敵でなくなる",
            "右が敵でなくなる",
            "左が敵でなくなる"});
            this.untilComboBox.Location = new System.Drawing.Point(66, 336);
            this.untilComboBox.Name = "untilComboBox";
            this.untilComboBox.Size = new System.Drawing.Size(120, 20);
            this.untilComboBox.TabIndex = 20;
            // 
            // elseIfComboBox
            // 
            this.elseIfComboBox.FormattingEnabled = true;
            this.elseIfComboBox.Items.AddRange(new object[] {
            "前が壁なら",
            "上が壁なら",
            "下が壁なら",
            "右が壁なら",
            "左が壁なら",
            "前が敵なら",
            "上が敵なら",
            "下が敵なら",
            "右が敵なら",
            "左が敵なら",
            "前が道なら",
            "上が道なら",
            "下が道なら",
            "右が道なら",
            "左が道なら"});
            this.elseIfComboBox.Location = new System.Drawing.Point(128, 135);
            this.elseIfComboBox.Name = "elseIfComboBox";
            this.elseIfComboBox.Size = new System.Drawing.Size(121, 20);
            this.elseIfComboBox.TabIndex = 17;
            // 
            // ifComboBox
            // 
            this.ifComboBox.FormattingEnabled = true;
            this.ifComboBox.Items.AddRange(new object[] {
            "前が壁なら",
            "後ろが壁なら",
            "右が壁なら",
            "左が壁なら",
            "前がテレポーターなら",
            "後ろがテレポーターなら",
            "右がテレポーターなら",
            "左がテレポーターなら",
            "前が道なら",
            "後ろが道なら",
            "右が道なら",
            "左が道なら",
            "前が沼なら",
            "後ろが沼なら",
            "右が沼なら",
            "左が沼なら",
            "HPが1なら",
            "HPが4なら",
            "HPが7なら"});
            this.ifComboBox.Location = new System.Drawing.Point(128, 67);
            this.ifComboBox.Name = "ifComboBox";
            this.ifComboBox.Size = new System.Drawing.Size(121, 20);
            this.ifComboBox.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(649, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 42);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MPTextBox);
            this.groupBox5.Controls.Add(this.PedometerTextBox);
            this.groupBox5.Controls.Add(this.HPTextBox);
            this.groupBox5.Location = new System.Drawing.Point(949, 453);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 42);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // MPTextBox
            // 
            this.MPTextBox.Location = new System.Drawing.Point(102, 15);
            this.MPTextBox.Name = "MPTextBox";
            this.MPTextBox.Size = new System.Drawing.Size(80, 19);
            this.MPTextBox.TabIndex = 22;
            // 
            // PedometerTextBox
            // 
            this.PedometerTextBox.Location = new System.Drawing.Point(188, 16);
            this.PedometerTextBox.Name = "PedometerTextBox";
            this.PedometerTextBox.Size = new System.Drawing.Size(80, 19);
            this.PedometerTextBox.TabIndex = 23;
            // 
            // HPTextBox
            // 
            this.HPTextBox.Location = new System.Drawing.Point(16, 15);
            this.HPTextBox.Name = "HPTextBox";
            this.HPTextBox.Size = new System.Drawing.Size(80, 19);
            this.HPTextBox.TabIndex = 23;
            // 
            // codeTimer
            // 
            this.codeTimer.Tick += new System.EventHandler(this.codeTimer_Tick);
            // 
            // stage12Btn
            // 
            this.stage12Btn.Location = new System.Drawing.Point(191, 10);
            this.stage12Btn.Name = "stage12Btn";
            this.stage12Btn.Size = new System.Drawing.Size(75, 23);
            this.stage12Btn.TabIndex = 28;
            this.stage12Btn.Text = "ステージ12";
            this.stage12Btn.UseVisualStyleBackColor = true;
            this.stage12Btn.Click += new System.EventHandler(this.stage12Btn_Click);
            // 
            // stage11Btn
            // 
            this.stage11Btn.Location = new System.Drawing.Point(110, 10);
            this.stage11Btn.Name = "stage11Btn";
            this.stage11Btn.Size = new System.Drawing.Size(75, 23);
            this.stage11Btn.TabIndex = 27;
            this.stage11Btn.Text = "ステージ11";
            this.stage11Btn.UseVisualStyleBackColor = true;
            this.stage11Btn.Click += new System.EventHandler(this.stage11Btn_Click);
            // 
            // stage10Btn
            // 
            this.stage10Btn.Location = new System.Drawing.Point(29, 10);
            this.stage10Btn.Name = "stage10Btn";
            this.stage10Btn.Size = new System.Drawing.Size(75, 23);
            this.stage10Btn.TabIndex = 26;
            this.stage10Btn.Text = "ステージ10";
            this.stage10Btn.UseVisualStyleBackColor = true;
            this.stage10Btn.Click += new System.EventHandler(this.stage10Btn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.Location = new System.Drawing.Point(498, 500);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(146, 44);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "ストップ";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.Location = new System.Drawing.Point(498, 452);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(146, 44);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "スタート";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stage9Btn
            // 
            this.stage9Btn.Location = new System.Drawing.Point(195, 420);
            this.stage9Btn.Name = "stage9Btn";
            this.stage9Btn.Size = new System.Drawing.Size(75, 23);
            this.stage9Btn.TabIndex = 28;
            this.stage9Btn.Text = "ステージ9";
            this.stage9Btn.UseVisualStyleBackColor = true;
            this.stage9Btn.Click += new System.EventHandler(this.stage9Btn_Click);
            // 
            // stage8Btn
            // 
            this.stage8Btn.Location = new System.Drawing.Point(114, 420);
            this.stage8Btn.Name = "stage8Btn";
            this.stage8Btn.Size = new System.Drawing.Size(75, 23);
            this.stage8Btn.TabIndex = 27;
            this.stage8Btn.Text = "ステージ8";
            this.stage8Btn.UseVisualStyleBackColor = true;
            this.stage8Btn.Click += new System.EventHandler(this.stage8Btn_Click);
            // 
            // stage7Btn
            // 
            this.stage7Btn.Location = new System.Drawing.Point(33, 420);
            this.stage7Btn.Name = "stage7Btn";
            this.stage7Btn.Size = new System.Drawing.Size(75, 23);
            this.stage7Btn.TabIndex = 26;
            this.stage7Btn.Text = "ステージ7";
            this.stage7Btn.UseVisualStyleBackColor = true;
            this.stage7Btn.Click += new System.EventHandler(this.stage7Btn_Click);
            // 
            // stage6Btn
            // 
            this.stage6Btn.Location = new System.Drawing.Point(195, 391);
            this.stage6Btn.Name = "stage6Btn";
            this.stage6Btn.Size = new System.Drawing.Size(75, 23);
            this.stage6Btn.TabIndex = 25;
            this.stage6Btn.Text = "ステージ6";
            this.stage6Btn.UseVisualStyleBackColor = true;
            this.stage6Btn.Click += new System.EventHandler(this.stage6Btn_Click);
            // 
            // stage5Btn
            // 
            this.stage5Btn.Location = new System.Drawing.Point(114, 391);
            this.stage5Btn.Name = "stage5Btn";
            this.stage5Btn.Size = new System.Drawing.Size(75, 23);
            this.stage5Btn.TabIndex = 24;
            this.stage5Btn.Text = "ステージ5";
            this.stage5Btn.UseVisualStyleBackColor = true;
            this.stage5Btn.Click += new System.EventHandler(this.stage5Btn_Click);
            // 
            // stage4Btn
            // 
            this.stage4Btn.Location = new System.Drawing.Point(33, 391);
            this.stage4Btn.Name = "stage4Btn";
            this.stage4Btn.Size = new System.Drawing.Size(75, 23);
            this.stage4Btn.TabIndex = 23;
            this.stage4Btn.Text = "ステージ4";
            this.stage4Btn.UseVisualStyleBackColor = true;
            this.stage4Btn.Click += new System.EventHandler(this.stage4Btn_Click);
            // 
            // stage3Btn
            // 
            this.stage3Btn.Location = new System.Drawing.Point(195, 362);
            this.stage3Btn.Name = "stage3Btn";
            this.stage3Btn.Size = new System.Drawing.Size(75, 23);
            this.stage3Btn.TabIndex = 22;
            this.stage3Btn.Text = "ステージ3";
            this.stage3Btn.UseVisualStyleBackColor = true;
            this.stage3Btn.Click += new System.EventHandler(this.stage3Btn_Click);
            // 
            // stage2Btn
            // 
            this.stage2Btn.Location = new System.Drawing.Point(114, 362);
            this.stage2Btn.Name = "stage2Btn";
            this.stage2Btn.Size = new System.Drawing.Size(75, 23);
            this.stage2Btn.TabIndex = 21;
            this.stage2Btn.Text = "ステージ2";
            this.stage2Btn.UseVisualStyleBackColor = true;
            this.stage2Btn.Click += new System.EventHandler(this.stage2Btn_Click);
            // 
            // stage1Btn
            // 
            this.stage1Btn.Location = new System.Drawing.Point(33, 362);
            this.stage1Btn.Name = "stage1Btn";
            this.stage1Btn.Size = new System.Drawing.Size(75, 23);
            this.stage1Btn.TabIndex = 20;
            this.stage1Btn.Text = "ステージ1";
            this.stage1Btn.UseVisualStyleBackColor = true;
            this.stage1Btn.Click += new System.EventHandler(this.stage1Btn_Click);
            // 
            // cureBtn
            // 
            this.cureBtn.Location = new System.Drawing.Point(115, 189);
            this.cureBtn.Name = "cureBtn";
            this.cureBtn.Size = new System.Drawing.Size(75, 23);
            this.cureBtn.TabIndex = 19;
            this.cureBtn.Text = "回復";
            this.cureBtn.UseVisualStyleBackColor = true;
            this.cureBtn.Click += new System.EventHandler(this.cureBtn_Click);
            // 
            // resetPlayerBtn
            // 
            this.resetPlayerBtn.Location = new System.Drawing.Point(99, 278);
            this.resetPlayerBtn.Name = "resetPlayerBtn";
            this.resetPlayerBtn.Size = new System.Drawing.Size(115, 23);
            this.resetPlayerBtn.TabIndex = 18;
            this.resetPlayerBtn.Text = "プレイヤーをリセット";
            this.resetPlayerBtn.UseVisualStyleBackColor = true;
            this.resetPlayerBtn.Click += new System.EventHandler(this.resetPlayerBtn_Click);
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.Location = new System.Drawing.Point(43, 160);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(75, 23);
            this.turnLeftBtn.TabIndex = 15;
            this.turnLeftBtn.Text = "左を向く";
            this.turnLeftBtn.UseVisualStyleBackColor = true;
            this.turnLeftBtn.Click += new System.EventHandler(this.turnLeftBtn_Click);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.Location = new System.Drawing.Point(188, 247);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(75, 23);
            this.removeAllBtn.TabIndex = 17;
            this.removeAllBtn.Text = "全て削除";
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(115, 131);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(75, 23);
            this.moveBtn.TabIndex = 12;
            this.moveBtn.Text = "前に進む";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(115, 218);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 23);
            this.endBtn.TabIndex = 16;
            this.endBtn.Text = "ここまで";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.Location = new System.Drawing.Point(188, 160);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(75, 23);
            this.turnRightBtn.TabIndex = 13;
            this.turnRightBtn.Text = "右を向く";
            this.turnRightBtn.UseVisualStyleBackColor = true;
            this.turnRightBtn.Click += new System.EventHandler(this.turnRightBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(43, 247);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "１つ削除";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(43, 47);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(75, 23);
            this.leftBtn.TabIndex = 11;
            this.leftBtn.Text = "左に移動";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(115, 76);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 23);
            this.downBtn.TabIndex = 10;
            this.downBtn.Text = "下に移動";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(115, 18);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 23);
            this.upBtn.TabIndex = 8;
            this.upBtn.Text = "上に移動";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(188, 47);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(75, 23);
            this.rightBtn.TabIndex = 9;
            this.rightBtn.Text = "右に移動";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // exeBtn
            // 
            this.exeBtn.Location = new System.Drawing.Point(115, 316);
            this.exeBtn.Name = "exeBtn";
            this.exeBtn.Size = new System.Drawing.Size(75, 23);
            this.exeBtn.TabIndex = 6;
            this.exeBtn.Text = "実行";
            this.exeBtn.UseVisualStyleBackColor = true;
            this.exeBtn.Click += new System.EventHandler(this.exeBtn_Click);
            // 
            // endlessBtn
            // 
            this.endlessBtn.Location = new System.Drawing.Point(48, 376);
            this.endlessBtn.Name = "endlessBtn";
            this.endlessBtn.Size = new System.Drawing.Size(220, 49);
            this.endlessBtn.TabIndex = 22;
            this.endlessBtn.Text = "ずっと";
            this.endlessBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endlessBtn.UseVisualStyleBackColor = true;
            this.endlessBtn.Click += new System.EventHandler(this.endlessBtn_Click);
            // 
            // untilBtn
            // 
            this.untilBtn.Location = new System.Drawing.Point(48, 321);
            this.untilBtn.Name = "untilBtn";
            this.untilBtn.Size = new System.Drawing.Size(220, 49);
            this.untilBtn.TabIndex = 19;
            this.untilBtn.Text = "まで";
            this.untilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.untilBtn.UseVisualStyleBackColor = true;
            this.untilBtn.Click += new System.EventHandler(this.untilBtn_Click);
            // 
            // elseBtn
            // 
            this.elseBtn.Location = new System.Drawing.Point(48, 186);
            this.elseBtn.Name = "elseBtn";
            this.elseBtn.Size = new System.Drawing.Size(220, 49);
            this.elseBtn.TabIndex = 18;
            this.elseBtn.Text = "そうでなければ";
            this.elseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elseBtn.UseVisualStyleBackColor = true;
            this.elseBtn.Click += new System.EventHandler(this.elseBtn_Click);
            // 
            // elseIfBtn
            // 
            this.elseIfBtn.Location = new System.Drawing.Point(48, 120);
            this.elseIfBtn.Name = "elseIfBtn";
            this.elseIfBtn.Size = new System.Drawing.Size(220, 49);
            this.elseIfBtn.TabIndex = 16;
            this.elseIfBtn.Text = "そうでなく　もし";
            this.elseIfBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elseIfBtn.UseVisualStyleBackColor = true;
            this.elseIfBtn.Click += new System.EventHandler(this.elseIfBtn_Click);
            // 
            // ifBtn
            // 
            this.ifBtn.Location = new System.Drawing.Point(48, 52);
            this.ifBtn.Name = "ifBtn";
            this.ifBtn.Size = new System.Drawing.Size(220, 49);
            this.ifBtn.TabIndex = 12;
            this.ifBtn.Text = "もし";
            this.ifBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ifBtn.UseVisualStyleBackColor = true;
            this.ifBtn.Click += new System.EventHandler(this.ifBtn_Click);
            // 
            // forBtn
            // 
            this.forBtn.Location = new System.Drawing.Point(48, 254);
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(220, 49);
            this.forBtn.TabIndex = 13;
            this.forBtn.Text = "回　繰り返す";
            this.forBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forBtn.UseVisualStyleBackColor = true;
            this.forBtn.Click += new System.EventHandler(this.forBtn_Click);
            // 
            // editCustomSatgeBtn
            // 
            this.editCustomSatgeBtn.Location = new System.Drawing.Point(949, 501);
            this.editCustomSatgeBtn.Name = "editCustomSatgeBtn";
            this.editCustomSatgeBtn.Size = new System.Drawing.Size(152, 23);
            this.editCustomSatgeBtn.TabIndex = 25;
            this.editCustomSatgeBtn.Text = "edit custom stage";
            this.editCustomSatgeBtn.UseVisualStyleBackColor = true;
            this.editCustomSatgeBtn.Click += new System.EventHandler(this.editCustomSatgeBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.ListBox codeListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox backPictureBox;
        private ButtonEx stopBtn;
        private ButtonEx startBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private ButtonEx removeBtn;
        private ButtonEx leftBtn;
        private ButtonEx downBtn;
        private ButtonEx upBtn;
        private ButtonEx rightBtn;
        private ButtonEx exeBtn;
        private ButtonEx endBtn;
        private ButtonEx removeAllBtn;
        private ButtonEx resetPlayerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ButtonEx turnLeftBtn;
        private ButtonEx moveBtn;
        private ButtonEx turnRightBtn;
        private System.Windows.Forms.Timer codeTimer;
        private System.Windows.Forms.GroupBox groupBox4;
        private ButtonEx elseBtn;
        private System.Windows.Forms.ComboBox elseIfComboBox;
        private ButtonEx elseIfBtn;
        private System.Windows.Forms.ComboBox ifComboBox;
        private ButtonEx ifBtn;
        private ButtonEx forBtn;
        private System.Windows.Forms.ComboBox untilComboBox;
        private ButtonEx untilBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox MPTextBox;
        private System.Windows.Forms.TextBox PedometerTextBox;
        private System.Windows.Forms.TextBox HPTextBox;
        private ButtonEx cureBtn;
        private ButtonEx endlessBtn;
        private ButtonEx editCustomSatgeBtn;
        private ButtonEx stage3Btn;
        private ButtonEx stage2Btn;
        private ButtonEx stage1Btn;
        private ButtonEx stage12Btn;
        private ButtonEx stage11Btn;
        private ButtonEx stage10Btn;
        private ButtonEx stage9Btn;
        private ButtonEx stage8Btn;
        private ButtonEx stage7Btn;
        private ButtonEx stage6Btn;
        private ButtonEx stage5Btn;
        private ButtonEx stage4Btn;
        private System.Windows.Forms.ComboBox forComboBox;
    }
}

