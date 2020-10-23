using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A1_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdYellow_Click(object sender, EventArgs e)
        {
            lblYellow.Text = "Gelbe Hintergrundfarbe";
            lblYellow.BackColor = Color.Yellow;
        }

        private void CmdRed_Click(object sender, EventArgs e)
        {
            Lblred.Text = "Rote Hintergrundfarbe";
            Lblred.BackColor = Color.Red;
        }

        private void CmdGreen_Click(object sender, EventArgs e)
        {
            LblGreen.Text = "Grüne Hintergrundfarbe";
            LblGreen.BackColor = Color.Green;
        }

        private void CmdBlue_Click(object sender, EventArgs e)
        {
            LblBlue.Text = "Blaue Hintergrundfarbe";
            LblBlue.BackColor = Color.Blue;
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
            lblYellow.Text = "";
            LblBlue.Text = "";
            LblGreen.Text = "";
            Lblred.Text = "";
            lblYellow.BackColor = Color.Transparent;
            LblBlue.BackColor = Color.Transparent;
            LblGreen.BackColor = Color.Transparent;
            Lblred.BackColor = Color.Transparent;
        }
    }
}
