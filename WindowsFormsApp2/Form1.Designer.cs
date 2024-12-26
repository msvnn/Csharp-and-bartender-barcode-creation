namespace WindowsFormsApp2
{
    partial class frmFQC
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.config_gBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.printer_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFilebtn = new System.Windows.Forms.Button();
            this.fileNametBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.preview_btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.config_gBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // config_gBox
            // 
            this.config_gBox.Controls.Add(this.label5);
            this.config_gBox.Controls.Add(this.num_textBox);
            this.config_gBox.Controls.Add(this.printer_comboBox);
            this.config_gBox.Controls.Add(this.label1);
            this.config_gBox.Controls.Add(this.openFilebtn);
            this.config_gBox.Controls.Add(this.fileNametBox);
            this.config_gBox.Location = new System.Drawing.Point(23, 9);
            this.config_gBox.Margin = new System.Windows.Forms.Padding(4);
            this.config_gBox.Name = "config_gBox";
            this.config_gBox.Padding = new System.Windows.Forms.Padding(4);
            this.config_gBox.Size = new System.Drawing.Size(441, 603);
            this.config_gBox.TabIndex = 133;
            this.config_gBox.TabStop = false;
            this.config_gBox.Text = "CONFIGURE PARAMETER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 16F);
            this.label5.Location = new System.Drawing.Point(156, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 134;
            this.label5.Text = "BARCOD";
            // 
            // num_textBox
            // 
            this.num_textBox.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_textBox.ForeColor = System.Drawing.Color.Blue;
            this.num_textBox.Location = new System.Drawing.Point(25, 274);
            this.num_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(376, 57);
            this.num_textBox.TabIndex = 133;
            this.num_textBox.TextChanged += new System.EventHandler(this.num_textBox_TextChanged);
            this.num_textBox.Enter += new System.EventHandler(this.num_textBox_Enter);
            this.num_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_textBox_KeyDown);
            this.num_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_textBox_KeyPress);
            // 
            // printer_comboBox
            // 
            this.printer_comboBox.Font = new System.Drawing.Font("SimSun", 16F);
            this.printer_comboBox.FormattingEnabled = true;
            this.printer_comboBox.Location = new System.Drawing.Point(16, 43);
            this.printer_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.printer_comboBox.Name = "printer_comboBox";
            this.printer_comboBox.Size = new System.Drawing.Size(401, 35);
            this.printer_comboBox.TabIndex = 127;
            this.printer_comboBox.Text = "SELECT PRINTER";
            this.printer_comboBox.SelectedIndexChanged += new System.EventHandler(this.printer_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "SELECT A TEMPLATE";
            // 
            // openFilebtn
            // 
            this.openFilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openFilebtn.Location = new System.Drawing.Point(376, 135);
            this.openFilebtn.Margin = new System.Windows.Forms.Padding(4);
            this.openFilebtn.Name = "openFilebtn";
            this.openFilebtn.Size = new System.Drawing.Size(43, 28);
            this.openFilebtn.TabIndex = 1;
            this.openFilebtn.Text = "...";
            this.openFilebtn.UseVisualStyleBackColor = true;
            this.openFilebtn.Click += new System.EventHandler(this.openFilebtn_Click);
            // 
            // fileNametBox
            // 
            this.fileNametBox.Location = new System.Drawing.Point(16, 137);
            this.fileNametBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileNametBox.Name = "fileNametBox";
            this.fileNametBox.Size = new System.Drawing.Size(351, 22);
            this.fileNametBox.TabIndex = 0;
            this.fileNametBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileNametBox_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 137;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(202, 20);
            this.toolStripStatusLabel1.Text = "© DEVELOPER: MSVN - 2023 ";
            // 
            // preview_btn
            // 
            this.preview_btn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preview_btn.Location = new System.Drawing.Point(23, 619);
            this.preview_btn.Margin = new System.Windows.Forms.Padding(4);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(441, 105);
            this.preview_btn.TabIndex = 135;
            this.preview_btn.Text = "PREVİEW";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(491, 52);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(560, 560);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 134;
            this.pictureBox.TabStop = false;
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.print_btn.Location = new System.Drawing.Point(491, 619);
            this.print_btn.Margin = new System.Windows.Forms.Padding(4);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(560, 105);
            this.print_btn.TabIndex = 136;
            this.print_btn.Text = "PRİNT";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // frmFQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 759);
            this.Controls.Add(this.config_gBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.print_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFQC";
            this.Text = "Label Maker128";
            this.Load += new System.EventHandler(this.frmFQC_Load);
            this.config_gBox.ResumeLayout(false);
            this.config_gBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox config_gBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.ComboBox printer_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFilebtn;
        private System.Windows.Forms.TextBox fileNametBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button preview_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button print_btn;
    }
}

