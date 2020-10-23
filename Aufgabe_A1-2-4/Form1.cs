using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A1_2_4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void CmdWindowHeightInc_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height + 10);
            Location = new Point(Location.X, Location.Y - 5);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimensions.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdWindowHeightDec_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height - 10);
           Location = new Point(Location.X, Location.Y +5);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimensions.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdWindowWidthInc_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width + 10, Size.Height);
            Location = new Point(Location.X -5, Location.Y );
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimensions.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }

        private void CmdWindowWidthDec_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width - 10, Size.Height);
            Location = new Point(Location.X + 5, Location.Y);
            LblPosition.Text = "Position: X: " + Location.X + ", Y:" + Location.Y;
            LblDimensions.Text = "Breite: X: " + Size.Width + ", Höhe: " + Size.Height;
        }
    }
}
