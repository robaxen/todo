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
        //skapar event handler för när delete knappen trycks på
        public event EventHandler DeleteButtonClicked;

        public NoteItem()
        {
            InitializeComponent();

            Form Form1 = (this.Parent as Form);
        }

        //getters och setters
        private string _name;
        private string _description;
        private string _deadline;
        private string _color;

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

        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; labelPostDeadline.Text = value; }
        }

        //public Color Color
        //{
        //    get { return _color; }
        //    set { _color = value; this.BackColor = value; }
        //}

        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("delete event recieved");
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
