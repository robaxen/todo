using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class NoteItem : UserControl
    {
        public NoteItem()
        {
            InitializeComponent();

            labelPostName.ForeColor = Color.Black;
            labelPostDescription.ForeColor = Color.Black;

            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        //getters och setters
        private string _id;
        private string _name;
        private string _description;
        private string _color;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; labelPostName.Text = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; labelPostDescription.Text = value; }
        }

        public string ColorCode
        {
            get { return _color; }
            set
            {
                _color = value;
                try
                {
                    panelColor.BackColor = ColorTranslator.FromHtml(value);
                }
                catch
                {
                    panelColor.BackColor = Color.Red;
                };
            }   
        }

        
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            //en extra ruta som frågar om man verkligen vill radera note
            DialogResult dialogResult = MessageBox.Show("Radera vald note?", "Radera", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //skriver ut id för note i console
                Debug.WriteLine("calling delete method for id=" + this.Id);

                //tilldelar rätt id och konverterar till int
                int id = Int32.Parse(this.Id);
                Form1 form = new Form1();

                //kallar funktion som finns på main form och skickar med id så att rätt post raderas
                //funktionen tar bort note från tabellen
                form.DeleteNote(id);

                //tar bort controllern från flowlayoutpanelen(onödigt)
                this.Parent.Controls.Remove(this);
            }
        }

        //-------------------hover effekt-------------------------
        private void NoteItem_MouseEnter(object sender, EventArgs e)
        {
            //ändrar färg då musen är i note
            this.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void NoteItem_MouseLeave(object sender, EventArgs e)
        {
            //ändrar tillbaka färg då musen lämnar note
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        //---------------------------------------------------------
    }
}
