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
    public partial class NoteItem : UserControl
    {
        public NoteItem()
        {
            InitializeComponent();
        }

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //klura ut hur man kallar en metod som är i en annan klass
        }


        //public Color Color
        //{
        //    get { return _color; }
        //    set { _color = value; this.BackColor = value; }
        //}

    }
}
