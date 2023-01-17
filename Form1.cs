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

            //skapar ett dataset och lägger dit tabellen
            DataSet ds = new DataSet("tabeller");
            ds.Tables.Add(table1);

            //skriver ut dataset i console, skriver all innehåll från dataset ds
            Console.WriteLine(ds.GetXml());

            //tabellens innehåll sparas i notes.xml, som hamnar i debug mappen
            table1.WriteXml("notes.xml");

            


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

        }

        //knapp som öppnar färg ruta, (flytta till lämpligare ställe senare)
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //(ändra "buttonColor" till note)
                buttonColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
