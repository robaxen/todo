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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //kod för att skapa datatable(kommer sättas in i dataset, som kommer lagras i xml fil)
            //skapar en tabell med namnet "notes"
            DataTable table1 = new DataTable("notes");
            //lägger till kolumner till tabellen
            table1.Columns.Add("id");
            table1.Columns.Add("task");
            table1.Columns.Add("description");
            table1.Columns.Add("deadline");
            table1.Columns.Add("color");



            //lägger till en test rad i tabellen
            table1.Rows.Add("1");
            table1.Rows.Add("yrkesprov ");
            table1.Rows.Add("gör klart yrkesprovs projektet");
            table1.Rows.Add("mars");
            table1.Rows.Add("#222");

            ////skapar ett dataset och lägger dit tabellen
            //DataSet set = new DataSet("tabeller");
            //set.Tables.Add(table1);

            ////skriver ut dataset i console, skriver ut notes tabellens innehåll
            //Console.WriteLine(set.GetXml());

        }

        
        public void testasdf()
        {
            //använder "using dataset" för att kalla dispose metoden så fort som datasettet inte används 
            using (DataSet set = new DataSet("tabeller"))
            {

            }
        }
    }
}
