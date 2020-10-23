namespace Aufgabe_A1_2_3
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
            this.CmdUp = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.CmdDown = new System.Windows.Forms.Button();
            this.CmdLeft = new System.Windows.Forms.Button();
            this.CmdRight = new System.Windows.Forms.Button();
            this.CmdCursor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdUp
            // 
            this.CmdUp.Location = new System.Drawing.Point(348, 12);
            this.CmdUp.Name = "CmdUp";
            this.CmdUp.Size = new System.Drawing.Size(75, 23);
            this.CmdUp.TabIndex = 0;
            this.CmdUp.Text = "Up";
            this.CmdUp.UseVisualStyleBackColor = true;
            this.CmdUp.Click += new System.EventHandler(this.CmdUp_Click);
            // 
            // CmdHome
            // 
            this.CmdHome.Location = new System.Drawing.Point(348, 41);
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(75, 23);
            this.CmdHome.TabIndex = 1;
            this.CmdHome.Text = "Home";
            this.CmdHome.UseVisualStyleBackColor = true;
            this.CmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // CmdDown
            // 
            this.CmdDown.Location = new System.Drawing.Point(348, 71);
            this.CmdDown.Name = "CmdDown";
            this.CmdDown.Size = new System.Drawing.Size(75, 23);
            this.CmdDown.TabIndex = 2;
            this.CmdDown.Text = "Down";
            this.CmdDown.UseVisualStyleBackColor = true;
            this.CmdDown.Click += new System.EventHandler(this.CmdDown_Click);
            // 
            // CmdLeft
            // 
            this.CmdLeft.Location = new System.Drawing.Point(267, 41);
            this.CmdLeft.Name = "CmdLeft";
            this.CmdLeft.Size = new System.Drawing.Size(75, 23);
            this.CmdLeft.TabIndex = 3;
            this.CmdLeft.Text = "Left";
            this.CmdLeft.UseVisualStyleBackColor = true;
            this.CmdLeft.Click += new System.EventHandler(this.CmdLeft_Click);
            // 
            // CmdRight
            // 
            this.CmdRight.Location = new System.Drawing.Point(430, 41);
            this.CmdRight.Name = "CmdRight";
            this.CmdRight.Size = new System.Drawing.Size(75, 23);
            this.CmdRight.TabIndex = 4;
            this.CmdRight.Text = "Right";
            this.CmdRight.UseVisualStyleBackColor = true;
            this.CmdRight.Click += new System.EventHandler(this.CmdRight_Click);
            // 
            // CmdCursor
            // 
            this.CmdCursor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CmdCursor.Location = new System.Drawing.Point(360, 230);
            this.CmdCursor.Name = "CmdCursor";
            this.CmdCursor.Size = new System.Drawing.Size(40, 40);
            this.CmdCursor.TabIndex = 5;
            this.CmdCursor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdCursor);
            this.Controls.Add(this.CmdRight);
            this.Controls.Add(this.CmdLeft);
            this.Controls.Add(this.CmdDown);
            this.Controls.Add(this.CmdHome);
            this.Controls.Add(this.CmdUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdUp;
        private System.Windows.Forms.Button CmdHome;
        private System.Windows.Forms.Button CmdDown;
        private System.Windows.Forms.Button CmdLeft;
        private System.Windows.Forms.Button CmdRight;
        private System.Windows.Forms.Button CmdCursor;
    }
}

