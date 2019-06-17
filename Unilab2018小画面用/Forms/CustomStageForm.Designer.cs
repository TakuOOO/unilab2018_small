namespace Unilab2018.Forms
{
    partial class CustomStageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.newStageBtn = new Unilab2018.CustomControl.ButtonEx();
            this.readFileBtn = new Unilab2018.CustomControl.ButtonEx();
            this.saveStageBtn = new Unilab2018.CustomControl.ButtonEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ylabel = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.backPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newStageBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.readFileBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.saveStageBtn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.objectListBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 547);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel1.SetRowSpan(this.backPictureBox, 5);
            this.backPictureBox.Size = new System.Drawing.Size(539, 543);
            this.backPictureBox.TabIndex = 5;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            this.backPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backPictureBox_MouseDown);
            this.backPictureBox.MouseLeave += new System.EventHandler(this.backPictureBox_MouseLeave);
            this.backPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backPictureBox_MouseMove);
            this.backPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backPictureBox_MouseUp);
            // 
            // newStageBtn
            // 
            this.newStageBtn.Location = new System.Drawing.Point(546, 458);
            this.newStageBtn.Name = "newStageBtn";
            this.newStageBtn.Size = new System.Drawing.Size(135, 23);
            this.newStageBtn.TabIndex = 6;
            this.newStageBtn.Text = "新規作成";
            this.newStageBtn.UseVisualStyleBackColor = true;
            this.newStageBtn.Click += new System.EventHandler(this.newStageBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(546, 488);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(135, 23);
            this.readFileBtn.TabIndex = 7;
            this.readFileBtn.Text = "ファイルから読み込む";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // saveStageBtn
            // 
            this.saveStageBtn.Location = new System.Drawing.Point(546, 520);
            this.saveStageBtn.Name = "saveStageBtn";
            this.saveStageBtn.Size = new System.Drawing.Size(135, 23);
            this.saveStageBtn.TabIndex = 8;
            this.saveStageBtn.Text = "保存";
            this.saveStageBtn.UseVisualStyleBackColor = true;
            this.saveStageBtn.Click += new System.EventHandler(this.saveStageBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ylabel);
            this.panel1.Controls.Add(this.xlabel);
            this.panel1.Location = new System.Drawing.Point(546, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 57);
            this.panel1.TabIndex = 9;
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(123, 23);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(13, 12);
            this.ylabel.TabIndex = 1;
            this.ylabel.Text = "y:";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(16, 23);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(21, 12);
            this.xlabel.TabIndex = 0;
            this.xlabel.Text = "x : ";
            // 
            // objectListBox
            // 
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.ItemHeight = 12;
            this.objectListBox.Items.AddRange(new object[] {
            "プレイヤー",
            "ゴール",
            "壁",
            "赤バラ",
            "白バラ",
            "毒沼",
            "テレポート元",
            "テレポート先　上",
            "テレポート先　下",
            "テレポート先　右",
            "テレポート先　左",
            "敵",
            "削除"});
            this.objectListBox.Location = new System.Drawing.Point(546, 66);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(228, 376);
            this.objectListBox.TabIndex = 10;
            this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.objectListBox_SelectedIndexChanged);
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // CustomStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomStageForm";
            this.Text = "CustomStage";
            this.Load += new System.EventHandler(this.CustomStageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox backPictureBox;
        private CustomControl.ButtonEx newStageBtn;
        private CustomControl.ButtonEx readFileBtn;
        private CustomControl.ButtonEx saveStageBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.ListBox objectListBox;
    }
}