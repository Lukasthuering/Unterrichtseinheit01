namespace Aufgabe_A1_2_1
{
    partial class Form1
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
            this.CmdYellow = new System.Windows.Forms.Button();
            this.CmdRed = new System.Windows.Forms.Button();
            this.CmdGreen = new System.Windows.Forms.Button();
            this.CmdBlue = new System.Windows.Forms.Button();
            this.lblYellow = new System.Windows.Forms.Label();
            this.Lblred = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.LblBlue = new System.Windows.Forms.Label();
            this.CmdReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdYellow
            // 
            this.CmdYellow.Location = new System.Drawing.Point(13, 13);
            this.CmdYellow.Name = "CmdYellow";
            this.CmdYellow.Size = new System.Drawing.Size(75, 23);
            this.CmdYellow.TabIndex = 0;
            this.CmdYellow.Text = "Gelb";
            this.CmdYellow.UseVisualStyleBackColor = true;
            this.CmdYellow.Click += new System.EventHandler(this.CmdYellow_Click);
            // 
            // CmdRed
            // 
            this.CmdRed.Location = new System.Drawing.Point(13, 43);
            this.CmdRed.Name = "CmdRed";
            this.CmdRed.Size = new System.Drawing.Size(75, 23);
            this.CmdRed.TabIndex = 1;
            this.CmdRed.Text = "Rot";
            this.CmdRed.UseVisualStyleBackColor = true;
            this.CmdRed.Click += new System.EventHandler(this.CmdRed_Click);
            // 
            // CmdGreen
            // 
            this.CmdGreen.Location = new System.Drawing.Point(13, 73);
            this.CmdGreen.Name = "CmdGreen";
            this.CmdGreen.Size = new System.Drawing.Size(75, 23);
            this.CmdGreen.TabIndex = 2;
            this.CmdGreen.Text = "Grün";
            this.CmdGreen.UseVisualStyleBackColor = true;
            this.CmdGreen.Click += new System.EventHandler(this.CmdGreen_Click);
            // 
            // CmdBlue
            // 
            this.CmdBlue.Location = new System.Drawing.Point(13, 103);
            this.CmdBlue.Name = "CmdBlue";
            this.CmdBlue.Size = new System.Drawing.Size(75, 23);
            this.CmdBlue.TabIndex = 3;
            this.CmdBlue.Text = "Blau";
            this.CmdBlue.UseVisualStyleBackColor = true;
            this.CmdBlue.Click += new System.EventHandler(this.CmdBlue_Click);
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(143, 18);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(0, 13);
            this.lblYellow.TabIndex = 4;
            // 
            // Lblred
            // 
            this.Lblred.AutoSize = true;
            this.Lblred.Location = new System.Drawing.Point(146, 52);
            this.Lblred.Name = "Lblred";
            this.Lblred.Size = new System.Drawing.Size(0, 13);
            this.Lblred.TabIndex = 5;
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(146, 82);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(0, 13);
            this.LblGreen.TabIndex = 6;
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(146, 112);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(0, 13);
            this.LblBlue.TabIndex = 7;
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(13, 133);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(75, 23);
            this.CmdReset.TabIndex = 8;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 460);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.Lblred);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.CmdBlue);
            this.Controls.Add(this.CmdGreen);
            this.Controls.Add(this.CmdRed);
            this.Controls.Add(this.CmdYellow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdYellow;
        private System.Windows.Forms.Button CmdRed;
        private System.Windows.Forms.Button CmdGreen;
        private System.Windows.Forms.Button CmdBlue;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label Lblred;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.Label LblBlue;
        private System.Windows.Forms.Button CmdReset;
    }
}

