namespace ChineseeCheckers_v1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHamleMor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMorTm = new System.Windows.Forms.Button();
            this.btnMaviTm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHamleMavi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMorTm);
            this.panel1.Controls.Add(this.btnMaviTm);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(637, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 557);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHamleMor);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(252, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncu 2";
            // 
            // lblHamleMor
            // 
            this.lblHamleMor.AutoSize = true;
            this.lblHamleMor.Location = new System.Drawing.Point(156, 52);
            this.lblHamleMor.Name = "lblHamleMor";
            this.lblHamleMor.Size = new System.Drawing.Size(16, 17);
            this.lblHamleMor.TabIndex = 7;
            this.lblHamleMor.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Oyuncunun Taşı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yapılan Hamle Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHamleMavi);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Oyuncunun Taşı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılan Hamle Sayısı:";
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.HOME;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(1006, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.exit_icon;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1062, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 50);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMorTm
            // 
            this.btnMorTm.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.SA;
            this.btnMorTm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMorTm.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMorTm.ForeColor = System.Drawing.Color.Purple;
            this.btnMorTm.Location = new System.Drawing.Point(252, 17);
            this.btnMorTm.Name = "btnMorTm";
            this.btnMorTm.Size = new System.Drawing.Size(217, 56);
            this.btnMorTm.TabIndex = 4;
            this.btnMorTm.Text = "Tamam";
            this.btnMorTm.UseVisualStyleBackColor = true;
            this.btnMorTm.Click += new System.EventHandler(this.btnMorTm_Click);
            // 
            // btnMaviTm
            // 
            this.btnMaviTm.BackColor = System.Drawing.Color.Transparent;
            this.btnMaviTm.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.BlueSquareButton;
            this.btnMaviTm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaviTm.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaviTm.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMaviTm.Location = new System.Drawing.Point(3, 17);
            this.btnMaviTm.Name = "btnMaviTm";
            this.btnMaviTm.Size = new System.Drawing.Size(218, 56);
            this.btnMaviTm.TabIndex = 3;
            this.btnMaviTm.Text = "Tamam";
            this.btnMaviTm.UseVisualStyleBackColor = false;
            this.btnMaviTm.Click += new System.EventHandler(this.btnMaviTm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChineseeCheckers_v1.Properties.Resources.mor;
            this.pictureBox2.Location = new System.Drawing.Point(9, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChineseeCheckers_v1.Properties.Resources.laci;
            this.pictureBox1.Location = new System.Drawing.Point(9, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblHamleMavi
            // 
            this.lblHamleMavi.AutoSize = true;
            this.lblHamleMavi.Location = new System.Drawing.Point(156, 52);
            this.lblHamleMavi.Name = "lblHamleMavi";
            this.lblHamleMavi.Size = new System.Drawing.Size(16, 17);
            this.lblHamleMavi.TabIndex = 8;
            this.lblHamleMavi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1124, 637);
            this.ControlBox = false;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çin Daması - Chinesee Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMorTm;
        private System.Windows.Forms.Button btnMaviTm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblHamleMor;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.Label lblHamleMavi;
    }
}

