namespace ChineseeCheckers_v1
{
    partial class BaslangicEkrani
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
            this.btnOyna = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOyunKurallari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOyna.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.BGT;
            this.btnOyna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOyna.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyna.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnOyna.Image = global::ChineseeCheckers_v1.Properties.Resources.PLAY;
            this.btnOyna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyna.Location = new System.Drawing.Point(176, 189);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(352, 110);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.BGT;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Image = global::ChineseeCheckers_v1.Properties.Resources.exit_icon;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(227, 475);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(234, 75);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOyunKurallari
            // 
            this.btnOyunKurallari.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.BGT;
            this.btnOyunKurallari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOyunKurallari.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyunKurallari.ForeColor = System.Drawing.Color.Orange;
            this.btnOyunKurallari.Image = global::ChineseeCheckers_v1.Properties.Resources.levels;
            this.btnOyunKurallari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyunKurallari.Location = new System.Drawing.Point(194, 346);
            this.btnOyunKurallari.Name = "btnOyunKurallari";
            this.btnOyunKurallari.Size = new System.Drawing.Size(320, 75);
            this.btnOyunKurallari.TabIndex = 3;
            this.btnOyunKurallari.Text = "OYUN KURALLARI";
            this.btnOyunKurallari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOyunKurallari.UseVisualStyleBackColor = true;
            this.btnOyunKurallari.Click += new System.EventHandler(this.btnOyunKurallari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Image = global::ChineseeCheckers_v1.Properties.Resources.BGT;
            this.label1.Location = new System.Drawing.Point(138, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÇİN DAMASI";
            // 
            // BaslangicEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ChineseeCheckers_v1.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOyunKurallari);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOyna);
            this.DoubleBuffered = true;
            this.Name = "BaslangicEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaslangicEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOyunKurallari;
        private System.Windows.Forms.Label label1;
    }
}