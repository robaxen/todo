using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

//notes för användning av github och visual studio
//för att spara ändringar i visual studio -> git changes fönstret -> skriv notes över ändringar -> commit all
//alla ändringar visas under changes i git changes fönstret
//för att pusha ut till repo efter commit -> git changes fönstret -> push
//då sparas alla ändringar till github repo

namespace todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //skapar nytt dataset som hämtar data från xml filen och visar upp i datagridview
            DataSet ds = new DataSet();
            ds.ReadXml(@"notes.xml");

            //binder datagridview med xml filen
            dataGridView1.DataSource = ds.Tables[0];

            ////---------------- bort kommenterat eftersom datatable och dataset kommer göras på annat vis -------------------
            ////kod för att skapa datatable(kommer sättas in i dataset, som kommer lagras i xml fil)
            ////skapar en tabell med namnet "notes"
            //DataTable table1 = new DataTable("notes");
            ////lägger till kolumner till tabellen
            //table1.Columns.Add("id");
            //table1.Columns.Add("task");
            //table1.Columns.Add("description");
            //table1.Columns.Add("deadline");
            //table1.Columns.Add("color");

            ////lägger till en test rad i tabellen
            ////skapar raden
            //DataRow task1 = table1.NewRow();
            ////ger värden för varje kolumn
            //task1["id"] = "1";
            //task1["task"] = "yrkesprov";
            //task1["description"] = "gör klart yrkesprovs projektet";
            //task1["deadline"] = "mars";
            //task1["color"] = "#222";
            ////lägger till raden i tabellen
            //table1.Rows.Add(task1);

            ////skapar ett dataset och lägger dit tabellen
            //DataSet ds = new DataSet("tabeller");
            //ds.Tables.Add(table1);

            ////skriver ut dataset i console, skriver all innehåll från dataset ds
            //Console.WriteLine(ds.GetXml());

            ////tabellens innehåll sparas i notes.xml, som hamnar i debug mappen
            //table1.WriteXml("notes.xml");
            //------------------------------------------------------------------------------------------------
        }


        public void testasdf()
        {
            //använder "using dataset" för att kalla dispose metoden så fort som datasettet inte används 
            using (DataSet set = new DataSet("tabeller"))
            {

            }
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            //öppnar upp newNote, för att skapa ny note och lägga till i xml filen samt datagridview
            newNote frm2 = new newNote();
            frm2.Show();
        }
    }
}
