namespace Aufgabe_A1_2_2
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
            this.CmdOne = new System.Windows.Forms.Button();
            this.CmdTwo = new System.Windows.Forms.Button();
            this.CmdThree = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdOne
            // 
            this.CmdOne.Location = new System.Drawing.Point(13, 13);
            this.CmdOne.Name = "CmdOne";
            this.CmdOne.Size = new System.Drawing.Size(75, 23);
            this.CmdOne.TabIndex = 0;
            this.CmdOne.Text = "1er";
            this.CmdOne.UseVisualStyleBackColor = true;
            this.CmdOne.Click += new System.EventHandler(this.CmdOne_Click);
            // 
            // CmdTwo
            // 
            this.CmdTwo.Location = new System.Drawing.Point(95, 13);
            this.CmdTwo.Name = "CmdTwo";
            this.CmdTwo.Size = new System.Drawing.Size(75, 23);
            this.CmdTwo.TabIndex = 1;
            this.CmdTwo.Text = "2er";
            this.CmdTwo.UseVisualStyleBackColor = true;
            this.CmdTwo.Click += new System.EventHandler(this.CmdTwo_Click);
            // 
            // CmdThree
            // 
            this.CmdThree.Location = new System.Drawing.Point(177, 13);
            this.CmdThree.Name = "CmdThree";
            this.CmdThree.Size = new System.Drawing.Size(75, 23);
            this.CmdThree.TabIndex = 2;
            this.CmdThree.Text = "3er";
            this.CmdThree.UseVisualStyleBackColor = true;
            this.CmdThree.Click += new System.EventHandler(this.CmdThree_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(13, 43);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 13);
            this.lblPoints.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 250);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.CmdThree);
            this.Controls.Add(this.CmdTwo);
            this.Controls.Add(this.CmdOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOne;
        private System.Windows.Forms.Button CmdTwo;
        private System.Windows.Forms.Button CmdThree;
        private System.Windows.Forms.Label lblPoints;
    }
}

