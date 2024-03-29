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
-radera post
    -post raderas inte helt, gamla raderade poster dyker upp igen om man lägger till ny post
 */

namespace todo
{
    public partial class Form1 : Form
    {
        //skapar nytt dataset och datatable
        public DataSet ds = new DataSet();

        //Datacolumn variabel för tabellen
        DataColumn column;

        public Form1()
        {
            InitializeComponent();

            ////skapar instans av user control
            //noteItem = new NoteItem();

            ////subscribe till PropertyChanged event som finns i user control
            //noteItem.PropertyChanged += NoteItem_PropertyChanged;

            //Skapar tabellen som kommer innehålla alla notes
            CreateTable();

            //skapar xml filen om den inte redan finns
            if (!File.Exists(@"notes.xml"))
            {
                ds.WriteXml("notes.xml");
                Debug.Write("notes.xml does not exist, creating...");
            }

            //läser av notes.xml och sätter in i dataset
            LoadXml();

            //listar upp alla rader i en flowlayout panel
            populateItems();

            //disable horizontal scroll i flowlayout panelen
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void LoadXml()
        {
            //läser av notes.xml och sätter in i dataset
            ds.ReadXml(@"notes.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //flyttar redigerings rutan och ny note rutan ovanpå varann
            groupBoxEditNote.Location = new Point(12, 147);

            //flyttar flowlayout panel till rätt ställe
            flowLayoutPanel1.Size = new Size(976, 639);
        }

        private void CreateTable()
        {
            //skapar tabellenv
            DataTable table1 = new DataTable("Note");

            //--Skapar och sätter in  alla tabellens kolumner--

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

                //flyttar undan flowlayout panelen
                flowLayoutPanel1.Size = new Size(995, 639);
            }
            else
            {
                panelColor.BackColor = Color.Gray;

                //visar upp rutan ifall den inte redan är synlig
                groupBoxNewNote.Visible = true;
                groupBoxEditNote.Visible = false;

                //flyttar tillbaka flowlayout panelen
                flowLayoutPanel1.Size = new Size(976, 331);
            }
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            //hämtar all data som användaren skrivit in
            string name = textBoxName.Text;
            string desc = textBoxDesc.Text;
            int colorCode = panelColor.BackColor.ToArgb();

            DataTable table1 = ds.Tables["Note"];

            //skapar raden som ska sättas in i tabellen. All data kommer från alla ifyllda fält
            DataRow dr = table1.NewRow();
            dr["name"] = name;
            dr["desc"] = desc;
            dr["colorCode"] = colorCode;

            //sätter in den skapade raden i tabellen
            table1.Rows.Add(dr);

            //reset id för varje rad i tabellen och spara data
            ResetID();

            //kallar metod för att spara från tabell till xml filen
            SaveToXml();

            //tömmer alla fält i new note rutan
            ResetNewNoteBox();

            //radar upp alla notes igen
            populateItems();

            flowLayoutPanel1.Size = new Size(976, 639);
        }

        public void SaveToXml()
        {
            //sparar data från dataset till xml filen
            ds.WriteXml("notes.xml");
        }

        public void ResetNewNoteBox()
        {
            //tömmer alla textboxar före "new note" rutan gömms undan
            textBoxName.Clear();
            textBoxDesc.Clear();

            //gömmer new note rutan igen
            groupBoxNewNote.Visible = false;
        }

        //Sätter in varje rad från tabellen i sina egna rutor, och listar upp dem under varann i en flowlayout panel
        private void populateItems()
        {

            //tömmer flowlayout panel före nya laddas in
            flowLayoutPanel1.Controls.Clear();

            //skapar en array, får sin längd från antal rader i dataTable "Note"
            NoteItem[] noteItems = new NoteItem[ds.Tables["Note"].Rows.Count];

            //för varje "fack" i noteItems arrayn
            for (int i = 0; i < ds.Tables["Note"].Rows.Count; i++)
            {
                //deklarerar data variabler som kommer fyllas med rätt data beroende på rad id
                string id = "";
                string name = "";
                string desc = "";
                string color = "";

                //leta i rad där id = i, börjar från 1 i for loopen ovanför
                DataRow[] dr = ds.Tables[0].Select("id=" + i);

                foreach (DataRow row in dr)
                {
                    //delar ut värden åt variablerna
                    name = row["name"].ToString();
                    desc = row["desc"].ToString();
                    color = row["colorCode"].ToString();
                }

                //skapar en note ruta med user controllern NoteItem
                noteItems[i] = new NoteItem();

                //sparar id för noten
                noteItems[i].Id = i.ToString();
                //variablernas värde sätts in i text labels som finns på user controllern, alltså note rutorna
                noteItems[i].Name = name;
                noteItems[i].Description = desc;
                noteItems[i].ColorCode = color;

                //sätter in alla skapade notes rutor i flowlayout panelen, där de radas upp under varandra
                flowLayoutPanel1.Controls.Add(noteItems[i]);

                //subscribe till click event för varje note
                noteItems[i].Click += new System.EventHandler(this.UserControl_Click);

                //skapar item för att se till att lambda funktionen alltid refererar till rätt control, även om värdet på i ändras
                NoteItem item = noteItems[i];
                //subscribe till PropertyChanged event och skickar med notens id(noteItems[i].id
                item.PropertyChanged += (Sender, e) => NoteItem_PropertyChanged(Sender, e, item.Id);
            }
            SaveToXml();
        }
        private void NoteItem_PropertyChanged(object sender, PropertyChangedEventArgs e, string id)
        {
            Console.WriteLine("propertychanged method called");
            DeleteNote(Int32.Parse(id));
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
            DataRow[] dr = ds.Tables["Note"].Select("id='" + id + "'");
            for (int i = 0; i < dr.Length; i++)
            {
                Console.WriteLine("deleteing post w/ id " + id.ToString());
                dr[i].Delete();
            }
            ds.Tables["Note"].AcceptChanges();

            //resettar id fälten och sparar alla ändringar
            ResetID();

            //radar upp alla notes igen
            populateItems();
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

        void UserControl_Click(object sender, EventArgs e)
        {
            //user control objekt för att få tillgång till note controls (namn, besk...)
            NoteItem obj = (NoteItem)sender;

            groupBoxEditNote.Text = "Redigera note " + obj.Name;

            textBoxNameEdit.Text = obj.Name;
            textBoxDescEdit.Text = obj.Description;
            panelColorEdit.BackColor = ColorTranslator.FromHtml(obj.ColorCode);

            labelID.Text = obj.Id;

            //tar fram/undan olika rutor
            groupBoxEditNote.Visible = true;
            groupBoxNewNote.Visible = false;

            //flyttar undan flowlayout panel
            flowLayoutPanel1.Size = new Size(976, 331);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxEditNote.Visible = false;

            textBoxNameEdit.Clear();
            textBoxDescEdit.Clear();

            panelColorEdit.BackColor = default(Color);

            flowLayoutPanel1.Size = new Size(976, 639);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            textBoxName.Clear();
            textBoxDesc.Clear();

            panelColorEdit.BackColor = default(Color);

            flowLayoutPanel1.Size = new Size(976, 639);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Note"].Select("id=" + labelID.Text).FirstOrDefault();

            if (dr != null)
            {
                dr["name"] = textBoxNameEdit.Text;
                dr["desc"] = textBoxDescEdit.Text;

                dr["colorCode"] = panelColorEdit.BackColor.ToArgb();

                //sparar till xml filen
                SaveToXml();

                //radar upp notes igen
                populateItems();

                //tömmer alla fält
                textBoxNameEdit.Clear();
                textBoxDescEdit.Clear();
                panelColorEdit.BackColor = default(Color);

                //gömmer groupbox efter ändringar sparats
                groupBoxEditNote.Visible = false;

                //flyttar tillbaka flowlayout panel
                flowLayoutPanel1.Size = new Size(976, 639);
            }
        }

        //visar upp ruta som innehåller datatabellen "Note"
        private void buttonTableView_Click_1(object sender, EventArgs e)
        {
            TableView tbl = new TableView();
            tbl.ShowDialog();
        }

        //-------------------------------------för att välja färg-----------------------------------
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ChooseColor();
        }
        
        private void buttonColorEdit_Click(object sender, EventArgs e)
        {
            ChooseColorEdit();
        }

        private void ChooseColor()
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ändrar färg för panel
                panelColor.BackColor = colorDialog1.Color;
            }
        }

        private void ChooseColorEdit()
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ändrar färg för panel
                panelColorEdit.BackColor = colorDialog1.Color;
            }
        }

        private void buttonPopulate_Click(object sender, EventArgs e)
        {
            populateItems();
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            //raderar rad med id 1
            DeleteNote(1);
        }
        //--------------------------------------------------------------------------------------------
    }
}
