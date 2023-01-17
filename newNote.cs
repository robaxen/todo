using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class newNote : Form
    {
        public newNote()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //(ändra "buttonColor" till note)
                this.BackColor = colorDialog1.Color;

               //skriver upp vald färg i textbox
                textBoxColorCode.Text = this.BackColor.ToString();

                buttonAddNote.BackColor = this.BackColor;
            }
        }
    }
}
