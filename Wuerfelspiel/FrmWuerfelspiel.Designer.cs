namespace Wuerfelspiel
{
    partial class FrmWuerfelspiel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pbx_logo;
            this.btn_1Ps = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_2Ps = new System.Windows.Forms.Button();
            this.btn_3Ps = new System.Windows.Forms.Button();
            this.btn_4Ps = new System.Windows.Forms.Button();
            this.btn_5Ps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logo
            // 
            pbx_logo.Image = global::Wuerfelspiel.Properties.Resources.ChatGPT_Image_5__Mai_2025__10_50_28;
            pbx_logo.Location = new System.Drawing.Point(109, 12);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new System.Drawing.Size(559, 240);
            pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbx_logo.TabIndex = 2;
            pbx_logo.TabStop = false;
            pbx_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_1Ps
            // 
            this.btn_1Ps.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_1Ps.Location = new System.Drawing.Point(300, 329);
            this.btn_1Ps.Name = "btn_1Ps";
            this.btn_1Ps.Size = new System.Drawing.Size(28, 34);
            this.btn_1Ps.TabIndex = 0;
            this.btn_1Ps.Text = "1";
            this.btn_1Ps.UseVisualStyleBackColor = false;
            this.btn_1Ps.Click += new System.EventHandler(this.btn_1Ps_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_exit.Location = new System.Drawing.Point(333, 369);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 41);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Beende mich Buuton";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_play.Location = new System.Drawing.Point(300, 258);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(161, 49);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Spielen";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_2Ps
            // 
            this.btn_2Ps.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_2Ps.Location = new System.Drawing.Point(334, 329);
            this.btn_2Ps.Name = "btn_2Ps";
            this.btn_2Ps.Size = new System.Drawing.Size(28, 34);
            this.btn_2Ps.TabIndex = 0;
            this.btn_2Ps.Text = "2";
            this.btn_2Ps.UseVisualStyleBackColor = false;
            this.btn_2Ps.Click += new System.EventHandler(this.btn_2Ps_Click);
            // 
            // btn_3Ps
            // 
            this.btn_3Ps.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_3Ps.Location = new System.Drawing.Point(368, 329);
            this.btn_3Ps.Name = "btn_3Ps";
            this.btn_3Ps.Size = new System.Drawing.Size(28, 34);
            this.btn_3Ps.TabIndex = 0;
            this.btn_3Ps.Text = "3";
            this.btn_3Ps.UseVisualStyleBackColor = false;
            this.btn_3Ps.Click += new System.EventHandler(this.btn_3Ps_Click);
            // 
            // btn_4Ps
            // 
            this.btn_4Ps.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_4Ps.Location = new System.Drawing.Point(402, 329);
            this.btn_4Ps.Name = "btn_4Ps";
            this.btn_4Ps.Size = new System.Drawing.Size(28, 34);
            this.btn_4Ps.TabIndex = 0;
            this.btn_4Ps.Text = "4";
            this.btn_4Ps.UseVisualStyleBackColor = false;
            this.btn_4Ps.Click += new System.EventHandler(this.btn_4Ps_Click);
            // 
            // btn_5Ps
            // 
            this.btn_5Ps.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_5Ps.Location = new System.Drawing.Point(433, 329);
            this.btn_5Ps.Name = "btn_5Ps";
            this.btn_5Ps.Size = new System.Drawing.Size(28, 34);
            this.btn_5Ps.TabIndex = 0;
            this.btn_5Ps.Text = "5";
            this.btn_5Ps.UseVisualStyleBackColor = false;
            this.btn_5Ps.Click += new System.EventHandler(this.btn_5Ps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(355, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players?";
            // 
            // FrmWuerfelspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Wuerfelspiel.Properties.Resources.Screenshot_2025_05_05_105902;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pbx_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_5Ps);
            this.Controls.Add(this.btn_4Ps);
            this.Controls.Add(this.btn_3Ps);
            this.Controls.Add(this.btn_2Ps);
            this.Controls.Add(this.btn_1Ps);
            this.Name = "FrmWuerfelspiel";
            this.Text = "Craps Labs℠";
            this.Load += new System.EventHandler(this.FrmWuerfelspiel_Load);
            ((System.ComponentModel.ISupportInitialize)(pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_1Ps;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_2Ps;
        private System.Windows.Forms.Button btn_3Ps;
        private System.Windows.Forms.Button btn_4Ps;
        private System.Windows.Forms.Button btn_5Ps;
        private System.Windows.Forms.Label label1;
    }
}

