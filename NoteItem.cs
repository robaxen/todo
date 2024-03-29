﻿using System;
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
        //definierar en event med namnet PropertyChanged. Kommer notifiera subscribers när ett värde ändras. 
        public event PropertyChangedEventHandler PropertyChanged;

        public NoteItem()
        {
            InitializeComponent();

            labelPostName.ForeColor = Color.Black;
            labelPostDescription.ForeColor = Color.Black;

            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private string stringA;

        public string a
        {
            get { return stringA; }
            set
            {
                //kollar om värdet ändrats
                if (value != stringA)
                {
                    //sätter nytt värde
                    stringA = value;

                    //kollar om det finns subscribers till eventet
                    if (PropertyChanged != null)
                    {
                        //notifierar subscribers att värdet på a har ändrats
                        PropertyChanged(this, new PropertyChangedEventArgs(a));
                    }
                }
            }
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
                //ändrar värdet på a till id för post
                a = Id;
                Console.WriteLine("delete button clicked, value of a: " + a);
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
