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
using System.Xml.Linq;
using System.IO;

//notes för användning av github och visual studio
//för att spara ändringar i visual studio -> git changes fönstret -> skriv notes över ändringar -> commit all
//alla ändringar visas under changes i git changes fönstret
//för att pusha ut till repo efter commit -> git changes fönstret -> push
//då sparas alla ändringar till github repo

//koll härifrån för att få struktur (schema) för datatable
//https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable.newrow?view=net-7.0

namespace todo
{
    public partial class Form1 : Form
    {

        //skapar nytt dataset och datatable
        DataSet ds = new DataSet();

        private string filePath = "notes.xml";

        //Datacolumn och datarow variabler för tabellen
        DataColumn column;
        DataRow row;
        DataView view;

        public Form1()
        {
            InitializeComponent();

            CreateTable();

            //################### .readxml fungerar inte med datatable, mpste använda dataset istället. #######################
            //läser sätter in i dataset från "notes.xml"
            ds.ReadXml(@"notes.xml");

            //binder datagridview med datasettet som innehåller xml filens tabell
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void CreateTable()
        {
            DataTable table1 = new DataTable("Note");

            //Skapar alla tabellens kolumner
            //namn kolumn
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "name";
            table1.Columns.Add(column);

            //beskrivning kolumn
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "desc";
            table1.Columns.Add(column);

            //deadline kolumn
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "deadline";
            table1.Columns.Add(column);

            //färg kolumn
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "colorCode";
            table1.Columns.Add(column);

            //sätter in i datasettet
            ds.Tables.Add(table1);
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            groupBoxNewNote.Visible = true;
        }

        //lägger till inmatad info i xml filen
        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            //hämtar all data som användaren skrivit in
            string name = textBoxName.Text;
            string desc = textBoxDesc.Text;
            string deadline = textBoxDeadline.Text;
            string colorCode = textBoxColorCode.Text;

            DataTable table1 = ds.Tables["Note"];

            //skapar raden som ska sättas in i tabellen, hämtar data från alla ifyllda fält
            DataRow dr = table1.NewRow();
            dr["name"] = name;
            dr["desc"] = desc;
            dr["deadline"] = deadline;
            dr["colorCode"] = colorCode;

            //sätter in raden i table1 tabellen
            table1.Rows.Add(dr);

            //kallar metod för att spara till xml filen
            SaveData();

            //tömmer alla textboxar före "new note" rutan gömms undan
            textBoxName.Clear();
            textBoxDesc.Clear();
            textBoxDeadline.Clear(); 
            textBoxColorCode.Clear();

            groupBoxNewNote.BackColor = DefaultBackColor;

            groupBoxNewNote.Visible = false;
            //--------------------------------------------------------------------
        }

        private void SaveData()
        {
            ds.WriteXml("notes.xml");

            //bara test för att sen i konsolen hur tabellen ser ut
            Console.WriteLine(ds.GetXml());
        }

        
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //(ändra "buttonColor" till note)
                groupBoxNewNote.BackColor = colorDialog1.Color;

                //skriver upp vald färg i textbox
                textBoxColorCode.Text = groupBoxNewNote.BackColor.ToString();
            }
        }

        private void buttonTestAddData_Click(object sender, EventArgs e)
        {
            //------------------här skapas tabell med kolumner och rader och sätts in i xml filen --------------------------
            //------------------bort kommenterat eftersom datatable och dataset kommer göras på annat vis -------------------

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
            //skapar raden
            DataRow task1 = table1.NewRow();
            //ger värden för varje kolumn
            task1["id"] = "1";
            task1["task"] = "yrkesprov";
            task1["description"] = "gör klart yrkesprovs projektet";
            task1["deadline"] = "mars";
            task1["color"] = "#222";
            //lägger till raden i tabellen
            table1.Rows.Add(task1);

            //skapar ett dataset och lägger dit tabellen
            DataSet ds = new DataSet("tabeller");
            ds.Tables.Add(table1);

            //skriver ut dataset i console, skriver all innehåll från dataset ds
            Console.WriteLine(ds.GetXml());

            //tabellens innehåll sparas i notes.xml, som hamnar i debug mappen
            table1.WriteXml("notes.xml");

            dataGridView1.Update();
            dataGridView1.Refresh();

            //------------------------------------------------------------------------------------------------
        }
    }
}
