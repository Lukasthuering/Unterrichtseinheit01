using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A1_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmdCursor.Enabled = false;
        }

        private void CmdUp_Click(object sender, EventArgs e)
        {
            CmdCursor.Location = new Point(CmdCursor.Location.X, CmdCursor.Location.Y - 15);
        }

        private void CmdDown_Click(object sender, EventArgs e)
        {
            CmdCursor.Location = new Point(CmdCursor.Location.X, CmdCursor.Location.Y + 15);
        }

        private void CmdLeft_Click(object sender, EventArgs e)
        {
            CmdCursor.Location = new Point(CmdCursor.Location.X - 15, CmdCursor.Location.Y);
        }

        private void CmdRight_Click(object sender, EventArgs e)
        {
            CmdCursor.Location = new Point(CmdCursor.Location.X + 15, CmdCursor.Location.Y);
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            CmdCursor.Location = new Point(360, 230);
        }
    }
}
