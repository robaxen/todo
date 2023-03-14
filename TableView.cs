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
    public partial class TableView : Form
    {
        public TableView()
        {
            InitializeComponent();

            //binder datagridview med datasettet som innehåller xml filens tabell
            Form1 mainForm = new Form1();
            dataGridView1.DataSource = mainForm.ds.Tables["Note"];

            

        }
    }
}
