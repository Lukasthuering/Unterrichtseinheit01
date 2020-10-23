using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinErstesProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CmdDemo_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "Hello";
            CmdHello.Enabled = false;
        }
        private void CmdWorld_Click(object sender, EventArgs e)
        {
            LblOutput.Text = LblOutput.Text + "World";
            CmdWorld.Enabled = false;

        }
        private void CmdReset_Click(object sender, EventArgs e)
        {
            LblOutput.Text = "";
            CmdWorld.Enabled = true;
            CmdHello.Enabled = true;
        }
        private void CmdPunkt_Click(object sender, EventArgs e)
        {
            LblPunkte.Text = LblPunkte.Text + ".";
        }

        private void CmdChangeColor_Click(object sender, EventArgs e)
        {
            CmdChangeColor.BackColor = Color.Cyan;
        }

        private void CmdChangeWidth_Click(object sender, EventArgs e)
        {
            CmdChangeWidth.Width = CmdChangeWidth.Width + 200;
            CmdHello.Location = new Point(0, 0);
        }

    }
    
}