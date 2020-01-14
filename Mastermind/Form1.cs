using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StartGame_MouseDown(object sender, MouseEventArgs e)
        {
            int Colors = decimal.ToInt32(this.colorAmount.Value);
            int slots = decimal.ToInt32(this.slpotAmount.Value);
            int tries = decimal.ToInt32(this.TryCountLimit.Value);
            Form2 gameMechanics = new Form2(this.enableNull.Checked, this.enableRepeats.Checked, Colors, slots, this.SinglePlayerOpt.Checked,this.ComputerPosition.Checked,tries);
            gameMechanics.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(this.SinglePlayerOpt.Checked)
            {
                this.ComputerPosition.Visible = true;
                this.ComputerPosition.Checked = true;
            }
            else
            {
                this.ComputerPosition.Visible = false;
                this.ComputerPosition.Checked = false;
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

        }
    }
}
