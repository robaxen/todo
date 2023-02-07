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
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

//notes för användning av github och visual studio
//för att spara ändringar i visual studio -> git changes fönstret -> skriv notes över ändringar -> commit all
//alla ändringar visas under changes i git changes fönstret
//för att pusha ut till repo efter commit -> git changes fönstret -> push
//då sparas alla ändringar till github repo

namespace todo
{
    public partial class Form1 : Form
    {
        //skapar nytt dataset och datatable
        public DataSet ds = new DataSet();

        //Datacolumn och datarow variabler för tabellen
        DataColumn column;

        string color;

        public Form1()
        {
            InitializeComponent();

            CreateTable();
            SaveData();

            //läser och sätter in i dataset från "notes.xml"
            ds.ReadXml(@"notes.xml");

            //binder datagridview med datasettet som innehåller xml filens tabell
            //dataGridView1.DataSource = ds.Tables[0];

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
            dr["deadline"] = deadline;
            dr["colorCode"] = colorCode;

            //sätter in den skapade raden i tabellen
            table1.Rows.Add(dr);

            //kallar metod för att spara till xml filen
            SaveData();

            //tömmer alla boxar från new note rutan
            ResetNewNoteBox();
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

        public void SaveData()
        {
            //sparar data från dataset till xml filen
            ds.WriteXml("notes.xml");
            populateItems();
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

        

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        public void Delete()
        {
            Debug.WriteLine("delete method called");

            DialogResult dialogResult = MessageBox.Show("Radera vald note?", "Radera", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //lägg hit kod för att radera en note
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void populateItems()
        {
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
                    ////testar i konsolen hur datan ser ut
                    //Console.WriteLine("note nummer " + row["id"] + " (i = " + i + ")");
                    //Console.WriteLine("namn: " + row["name"]);
                    //Console.WriteLine("besk: " + row["desc"]);

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
                noteItems[i].Deadline = "Deadline: " + deadline;
                noteItems[i].ColorCode = color;

                //sätter in alla skapade notes rutor i flowlayout panelen, där de radas upp under varandra
                flowLayoutPanel1.Controls.Add(noteItems[i]);
            }
        }

        private void buttontableview_Click(object sender, EventArgs e)
        {
            //visar upp ett fönster med tabellen, för att kolla tabellens innehåll
            TableView tableView = new TableView();
            tableView.ShowDialog();
        }
    }
}
