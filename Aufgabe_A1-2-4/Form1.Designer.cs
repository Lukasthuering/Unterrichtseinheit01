namespace Aufgabe_A1_2_4
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
            this.CmdWindowHeightInc = new System.Windows.Forms.Button();
            this.CmdWindowHeightDec = new System.Windows.Forms.Button();
            this.CmdWindowWidthInc = new System.Windows.Forms.Button();
            this.CmdWindowWidthDec = new System.Windows.Forms.Button();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblDimensions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdWindowHeightInc
            // 
            this.CmdWindowHeightInc.Location = new System.Drawing.Point(102, 30);
            this.CmdWindowHeightInc.Name = "CmdWindowHeightInc";
            this.CmdWindowHeightInc.Size = new System.Drawing.Size(189, 23);
            this.CmdWindowHeightInc.TabIndex = 0;
            this.CmdWindowHeightInc.Text = "Fensterhöhe vergrössern";
            this.CmdWindowHeightInc.UseVisualStyleBackColor = true;
            this.CmdWindowHeightInc.Click += new System.EventHandler(this.CmdWindowHeightInc_Click);
            // 
            // CmdWindowHeightDec
            // 
            this.CmdWindowHeightDec.Location = new System.Drawing.Point(102, 60);
            this.CmdWindowHeightDec.Name = "CmdWindowHeightDec";
            this.CmdWindowHeightDec.Size = new System.Drawing.Size(189, 23);
            this.CmdWindowHeightDec.TabIndex = 1;
            this.CmdWindowHeightDec.Text = "Fensterhöhe verkleinern";
            this.CmdWindowHeightDec.UseVisualStyleBackColor = true;
            this.CmdWindowHeightDec.Click += new System.EventHandler(this.CmdWindowHeightDec_Click);
            // 
            // CmdWindowWidthInc
            // 
            this.CmdWindowWidthInc.Location = new System.Drawing.Point(102, 90);
            this.CmdWindowWidthInc.Name = "CmdWindowWidthInc";
            this.CmdWindowWidthInc.Size = new System.Drawing.Size(189, 23);
            this.CmdWindowWidthInc.TabIndex = 2;
            this.CmdWindowWidthInc.Text = "Fensterbreite vergrössern";
            this.CmdWindowWidthInc.UseVisualStyleBackColor = true;
            this.CmdWindowWidthInc.Click += new System.EventHandler(this.CmdWindowWidthInc_Click);
            // 
            // CmdWindowWidthDec
            // 
            this.CmdWindowWidthDec.Location = new System.Drawing.Point(102, 120);
            this.CmdWindowWidthDec.Name = "CmdWindowWidthDec";
            this.CmdWindowWidthDec.Size = new System.Drawing.Size(189, 23);
            this.CmdWindowWidthDec.TabIndex = 3;
            this.CmdWindowWidthDec.Text = "Fensterbreite verkleinern";
            this.CmdWindowWidthDec.UseVisualStyleBackColor = true;
            this.CmdWindowWidthDec.Click += new System.EventHandler(this.CmdWindowWidthDec_Click);
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(13, 368);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 4;
            this.LblPosition.Text = "Position:";
            // 
            // LblDimensions
            // 
            this.LblDimensions.AutoSize = true;
            this.LblDimensions.Location = new System.Drawing.Point(162, 368);
            this.LblDimensions.Name = "LblDimensions";
            this.LblDimensions.Size = new System.Drawing.Size(71, 13);
            this.LblDimensions.TabIndex = 5;
            this.LblDimensions.Text = "Dimensionen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 393);
            this.Controls.Add(this.LblDimensions);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.CmdWindowWidthDec);
            this.Controls.Add(this.CmdWindowWidthInc);
            this.Controls.Add(this.CmdWindowHeightDec);
            this.Controls.Add(this.CmdWindowHeightInc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdWindowHeightInc;
        private System.Windows.Forms.Button CmdWindowHeightDec;
        private System.Windows.Forms.Button CmdWindowWidthInc;
        private System.Windows.Forms.Button CmdWindowWidthDec;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblDimensions;
    }
}

