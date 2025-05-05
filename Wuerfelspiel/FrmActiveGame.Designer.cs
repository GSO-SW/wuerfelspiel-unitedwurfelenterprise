namespace Wuerfelspiel
{
    partial class FrmActiveGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.lbl_P3 = new System.Windows.Forms.Label();
            this.lbl_P4 = new System.Windows.Forms.Label();
            this.lbl_P5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lbl_P5);
            this.groupBox1.Controls.Add(this.lbl_P4);
            this.groupBox1.Controls.Add(this.lbl_P3);
            this.groupBox1.Controls.Add(this.lbl_P2);
            this.groupBox1.Controls.Add(this.lbl_P1);
            this.groupBox1.Location = new System.Drawing.Point(104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // lbl_P1
            // 
            this.lbl_P1.AutoSize = true;
            this.lbl_P1.Location = new System.Drawing.Point(6, 18);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(56, 16);
            this.lbl_P1.TabIndex = 0;
            this.lbl_P1.Text = "Player 1";
            // 
            // lbl_P2
            // 
            this.lbl_P2.AutoSize = true;
            this.lbl_P2.Location = new System.Drawing.Point(139, 18);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(56, 16);
            this.lbl_P2.TabIndex = 0;
            this.lbl_P2.Text = "Player 2";
            // 
            // lbl_P3
            // 
            this.lbl_P3.AutoSize = true;
            this.lbl_P3.Location = new System.Drawing.Point(259, 18);
            this.lbl_P3.Name = "lbl_P3";
            this.lbl_P3.Size = new System.Drawing.Size(56, 16);
            this.lbl_P3.TabIndex = 0;
            this.lbl_P3.Text = "Player 3";
            // 
            // lbl_P4
            // 
            this.lbl_P4.AutoSize = true;
            this.lbl_P4.Location = new System.Drawing.Point(379, 18);
            this.lbl_P4.Name = "lbl_P4";
            this.lbl_P4.Size = new System.Drawing.Size(56, 16);
            this.lbl_P4.TabIndex = 0;
            this.lbl_P4.Text = "Player 4";
            // 
            // lbl_P5
            // 
            this.lbl_P5.AutoSize = true;
            this.lbl_P5.Location = new System.Drawing.Point(517, 18);
            this.lbl_P5.Name = "lbl_P5";
            this.lbl_P5.Size = new System.Drawing.Size(56, 16);
            this.lbl_P5.TabIndex = 0;
            this.lbl_P5.Text = "Player 5";
            // 
            // FrmActiveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActiveGame";
            this.Text = "Craps Labs℠";
            this.Load += new System.EventHandler(this.FrmActiveGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_P5;
        private System.Windows.Forms.Label lbl_P4;
        private System.Windows.Forms.Label lbl_P3;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.Label lbl_P1;
    }
}