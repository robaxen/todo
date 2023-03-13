﻿using System;
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
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

//notes för användning av github och visual studio
//för att spara ändringar i visual studio -> git changes fönstret -> skriv notes över ändringar -> commit all
//alla ändringar visas under changes i git changes fönstret
//för att pusha ut till repo efter commit -> git changes fönstret -> push
//då sparas alla ändringar till github repo


//To do lista för programmet
/*
-redigera post
-radera post
    -länka radera knapp till funktion
    -ta reda på note id och skicka till funktionen 
-man kan inte ändra datum före checkbox är ikryssad
 */

namespace todo
{
    public partial class Form1 : Form
    {
        //skapar nytt dataset och datatable
        public DataSet ds = new DataSet();

        //Datacolumn variabel för tabellen
        DataColumn column;

        string color;

        public Form1()
        {
            InitializeComponent();

            //Skapar tabellen som kommer innehålla 
            CreateTable();

            //skapar xml filen om den inte redan finns
            if (!File.Exists(@"notes.xml"))
            {
                ds.WriteXml("notes.xml");
                Console.WriteLine("notes.xml does not exist, creating...");
            }

            //läser och sätter in i dataset från "notes.xml"
            ds.ReadXml(@"notes.xml");
            
            //listar upp alla rader i en flowlayout panel
            populateItems();
        }

        private void CreateTable()
        {
            //skapar tabellenv
            DataTable table1 = new DataTable("Note");

            //Skapar och sätter in  alla tabellens kolumner

            //id kolumn
            //startar id vid 0 för att alla loops ska fungera
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 0;
            column.AutoIncrementStep = 1;
            
            column.ColumnName = "id";

            table1.Columns.Add(column);

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

            //sätter in tabellen i datasettet
            ds.Tables.Add(table1);
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            //knappen ska stänga 'ny note' rutan ifall den redan är uppe. 
            if (groupBoxNewNote.Visible == true)
            {
                //tömmer alla boxar från new note rutan
                ResetNewNoteBox();
            }
            else
            {
                panelColor.BackColor = Color.Gray;

                //visar upp rutan ifall den inte redan är synlig
                groupBoxNewNote.Visible = true;
            }
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            //hämtar all data som användaren skrivit in
            string name = textBoxName.Text;
            string desc = textBoxDesc.Text;
            string deadline = dateTimePickerDeadline.Text;
            int colorCode = panelColor.BackColor.ToArgb();

            ////tester för att se vald färg kod i olika format
            //Console.WriteLine("detta sätts in i colorCode kolumnen: " + panelColor.BackColor.ToArgb());
            //Console.WriteLine("ToString istället för ToArgb: " + panelColor.BackColor.ToString());

            DataTable table1 = ds.Tables["Note"]; 

            //skapar raden som ska sättas in i tabellen. All data kommer från alla ifyllda fält
            DataRow dr = table1.NewRow();
            dr["name"] = name;
            dr["desc"] = desc;
            dr["colorCode"] = colorCode;

            //sätter endast in deadline datum ifall checkbox är ikryssad
            if (checkBoxDeadline.Checked)
            {
                dr["deadline"] = deadline;
            }
            

            //sätter in den skapade raden i tabellen
            table1.Rows.Add(dr);

            //reset id och spara data
            ResetID();

            //kallar metod för att spara till xml filen
            SaveToXml();

            //tömmer alla boxar från new note rutan
            ResetNewNoteBox();
        }

        public void SaveToXml()
        {
            //sparar data från dataset till xml filen
            ds.WriteXml("notes.xml");
            populateItems();
        }

        public void ResetNewNoteBox()
        {
            //tömmer alla textboxar före "new note" rutan gömms undan
            textBoxName.Clear();
            textBoxDesc.Clear();
            dateTimePickerDeadline.ResetText();

            //gömmer new note rutan igen
            groupBoxNewNote.Visible = false;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ChooseColor();
        }

        private void ChooseColor()
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ändrar färg för panel
                panelColor.BackColor = colorDialog1.Color;

                Color color = colorDialog1.Color;
            }
        }

        private void populateItems()
        {
            //Sätter in varje rad från tabellen i sina egna rutor, och listar upp dem under varann i en flowlayout panel

            //tömmer flowlayout panel före nya laddas in
            flowLayoutPanel1.Controls.Clear();

            //skapar noteItems från en user control
            NoteItem[] noteItems = new NoteItem[ds.Tables["Note"].Rows.Count];

            //för varje rad i "note" tabellen
            for (int i = 0; i < ds.Tables["Note"].Rows.Count; i++)
            {
                //deklarerar data variabler som kommer fyllas med rätt data beroende på rad id
                string name = "";
                string desc = "";
                string deadline = "";

                color = "";

                //leta i rad där id = i, börjar från 1 i for loopen ovanför
                DataRow[] dr = ds.Tables[0].Select("id=" + i);

                foreach (DataRow row in dr)
                {
                    //delar ut värden åt variablerna
                    name = row["name"].ToString();
                    desc = row["desc"].ToString();
                    deadline = row["deadline"].ToString();
                    color = row["colorCode"].ToString(); 
                }

                //skapar en note ruta med user controllern NoteItem
                noteItems[i] = new NoteItem();
                //variablernas värde sätts in i text labels som finns på user controllern, alltså note rutorna
                noteItems[i].Name = name;
                noteItems[i].Description = desc;
                noteItems[i].ColorCode = color;

                //sparar id för noten
                noteItems[i].Id = i.ToString();

                //skriver endast i deadline om det finns en deadline sparad i tabellen
                //if (deadline.ToString().Length > 0)
                if (deadline.ToString().Length > 0)
                {
                    noteItems[i].Deadline = "Deadline: " + deadline;
                }
                else
                {
                }

                //sätter in alla skapade notes rutor i flowlayout panelen, där de radas upp under varandra
                flowLayoutPanel1.Controls.Add(noteItems[i]);
            }
        }

        private void buttontableview_Click(object sender, EventArgs e)
        {
            //visar upp ett fönster med tabellen, för att kolla tabellens innehåll under testning
            TableView tableView = new TableView();
            tableView.ShowDialog();
        }

        public void DeleteNote(int id)
        {
            //väljer ut och tilldelar "row" med rad med rätt id(id fås från metoden, skickas från NoteItem usercontrollern)
            DataRow[] row = ds.Tables[0].Select("id=" + id);

            for (int i = row.Length - 1; i >= 0; i--)
            {
                ds.Tables["Note"].Rows.RemoveAt(id);
            }

            //resettar id fälten och sparar alla ändringar
            ResetID();
        }


        public void editNote(string id, string name, string desc, string color)
        {

            textBoxNameEdit.Text = name;
            textBoxDescEdit.Text = desc;

            //if (groupBoxEditNote.Visible == false)
            //{
            //    //test för att kolla variablerna i konsolen
            //    Console.WriteLine("editNote method called");
            //    Console.WriteLine(id + " " + name + " " + desc + " " + color);

            //    //ändrar redigerings rutans rubrik
            //    groupBoxEditNote.Text = "Redigerar post " + name;

            //    //ändrar värdena i redigerings rutan
            //    textBoxNameEdit.Text = name;
            //    textBoxDescEdit.Text = desc;
            //    panelColorEdit.BackColor = ColorTranslator.FromHtml(color);

            //    //visar upp redigerings rutan
            //    groupBoxEditNote.Visible = true;
            //}
            //else
            //{
            //    groupBoxEditNote.Visible = false;
            //}


        }

        //används för att resetta alla id fält så att inga luckor uppstår,
        //behövs för att kunna lista upp notes enligt Id'n med loopningsmetoden jag använt
        public void ResetID()
        {
            //resettar id efter deletion (väldigt dålig lösning)
            int counter = -1;
            foreach (DataRow noteRow in ds.Tables["Note"].Rows)
            {
                noteRow["id"] = ++counter;
            }

            //Sparar ändringar
            ds.Tables["Note"].AcceptChanges();
            SaveToXml();
        }

        private void buttonEditTest_Click(object sender, EventArgs e)
        {
                //tillderar värden
                string id = "1";
                string name = "name";
                string desc = "description";
                string color = "111";

                editNote(id, name, desc, color);
        }

        NoteItem noteItem = new NoteItem();

        private void Form1_Load(object sender, EventArgs e)
        {
            

            noteItem.PropertyChanged += NoteItem_PropertyChanged;
        }

        private void NoteItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            textBoxNameEdit.Text = noteItem.a;

            Console.WriteLine("propertychanged");
        }
    }
}
