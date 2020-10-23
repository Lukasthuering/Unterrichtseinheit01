namespace MeinErstesProjekt
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
            this.CmdHello = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.CmdWorld = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.CmdPunkt = new System.Windows.Forms.Button();
            this.LblPunkt = new System.Windows.Forms.Label();
            this.LblPunkte = new System.Windows.Forms.Label();
            this.CmdChangeColor = new System.Windows.Forms.Button();
            this.CmdChangeWidth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdHello
            // 
            this.CmdHello.Location = new System.Drawing.Point(53, 40);
            this.CmdHello.Name = "CmdHello";
            this.CmdHello.Size = new System.Drawing.Size(163, 57);
            this.CmdHello.TabIndex = 0;
            this.CmdHello.Text = "Hello";
            this.CmdHello.UseVisualStyleBackColor = true;
            this.CmdHello.Click += new System.EventHandler(this.CmdDemo_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(65, 559);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(107, 25);
            this.LblOutput.TabIndex = 1;
            this.LblOutput.Text = "TestLabel";
            // 
            // CmdWorld
            // 
            this.CmdWorld.Location = new System.Drawing.Point(265, 40);
            this.CmdWorld.Name = "CmdWorld";
            this.CmdWorld.Size = new System.Drawing.Size(165, 51);
            this.CmdWorld.TabIndex = 2;
            this.CmdWorld.Text = "World";
            this.CmdWorld.UseVisualStyleBackColor = true;
            this.CmdWorld.Click += new System.EventHandler(this.CmdWorld_Click);
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(53, 120);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(163, 52);
            this.CmdReset.TabIndex = 3;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdPunkt
            // 
            this.CmdPunkt.Location = new System.Drawing.Point(53, 286);
            this.CmdPunkt.Name = "CmdPunkt";
            this.CmdPunkt.Size = new System.Drawing.Size(151, 43);
            this.CmdPunkt.TabIndex = 4;
            this.CmdPunkt.Text = "Punkt";
            this.CmdPunkt.UseVisualStyleBackColor = true;
            this.CmdPunkt.Click += new System.EventHandler(this.CmdPunkt_Click);
            // 
            // LblPunkt
            // 
            this.LblPunkt.AutoSize = true;
            this.LblPunkt.Location = new System.Drawing.Point(313, 558);
            this.LblPunkt.Name = "LblPunkt";
            this.LblPunkt.Size = new System.Drawing.Size(0, 25);
            this.LblPunkt.TabIndex = 5;
            // 
            // LblPunkte
            // 
            this.LblPunkte.AutoSize = true;
            this.LblPunkte.Location = new System.Drawing.Point(237, 303);
            this.LblPunkte.Name = "LblPunkte";
            this.LblPunkte.Size = new System.Drawing.Size(18, 25);
            this.LblPunkte.TabIndex = 6;
            this.LblPunkte.Text = ".";
            // 
            // CmdChangeColor
            // 
            this.CmdChangeColor.Location = new System.Drawing.Point(53, 372);
            this.CmdChangeColor.Name = "CmdChangeColor";
            this.CmdChangeColor.Size = new System.Drawing.Size(151, 76);
            this.CmdChangeColor.TabIndex = 7;
            this.CmdChangeColor.Text = "Wechsle Farbe";
            this.CmdChangeColor.UseVisualStyleBackColor = true;
            this.CmdChangeColor.Click += new System.EventHandler(this.CmdChangeColor_Click);
            // 
            // CmdChangeWidth
            // 
            this.CmdChangeWidth.Location = new System.Drawing.Point(53, 455);
            this.CmdChangeWidth.Name = "CmdChangeWidth";
            this.CmdChangeWidth.Size = new System.Drawing.Size(151, 65);
            this.CmdChangeWidth.TabIndex = 8;
            this.CmdChangeWidth.Text = "Breite";
            this.CmdChangeWidth.UseVisualStyleBackColor = true;
            this.CmdChangeWidth.Click += new System.EventHandler(this.CmdChangeWidth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 682);
            this.Controls.Add(this.CmdChangeWidth);
            this.Controls.Add(this.CmdChangeColor);
            this.Controls.Add(this.LblPunkte);
            this.Controls.Add(this.LblPunkt);
            this.Controls.Add(this.CmdPunkt);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.CmdWorld);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CmdHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdHello;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button CmdWorld;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Button CmdPunkt;
        private System.Windows.Forms.Label LblPunkt;
        private System.Windows.Forms.Label LblPunkte;
        private System.Windows.Forms.Button CmdChangeColor;
        private System.Windows.Forms.Button CmdChangeWidth;
    }
}

