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

//notes för användning av github och visual studio
//för att spara ändringar i visual studio -> git changes fönstret -> skriv notes över ändringar -> commit all
//alla ändringar visas under changes i git changes fönstret
//för att pusha ut till repo efter commit -> git changes fönstret -> push
//då sparas alla ändringar till github repo

namespace todo
{
    public partial class Form1 : Form
    {
        DataTable table1;

        //skapar nytt dataset och datatable
        DataSet ds = new DataSet();

        //Datacolumn och datarow variabler för tabellen
        DataColumn column;

        public Form1()
        {
            InitializeComponent();

            CreateTable();

            //läser och sätter in i dataset från "notes.xml"
            ds.ReadXml(@"notes.xml");

            //binder datagridview med datasettet som innehåller xml filens tabell
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CreateTable()
        {
            //skapar tabellenv
            DataTable table1 = new DataTable("Note");

            //Skapar och sätter in  alla tabellens kolumner
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
            groupBoxNewNote.Visible = true;
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            //hämtar all data som användaren skrivit in
            string name = textBoxName.Text;
            string desc = textBoxDesc.Text;
            string deadline = dateTimePickerDeadline.Text;
            string colorCode = textBoxColorCode.Text;

            DataTable table1 = ds.Tables["Note"];

            //skapar raden som ska sättas in i tabellen, hämtar data från alla ifyllda fält
            DataRow dr = table1.NewRow();
            dr["name"] = name;
            dr["desc"] = desc;
            dr["deadline"] = deadline;
            dr["colorCode"] = colorCode;

            //sätter in den skapade raden i table1 tabellen
            table1.Rows.Add(dr);

            //kallar metod för att spara till xml filen
            SaveData();

            //tömmer alla textboxar före "new note" rutan gömms undan
            textBoxName.Clear();
            textBoxDesc.Clear();
            dateTimePickerDeadline.ResetText();
            textBoxColorCode.Clear();

            groupBoxNewNote.BackColor = DefaultBackColor;

            groupBoxNewNote.Visible = false;
            //--------------------------------------------------------------------
        }

        public static void SaveData()
        {
            //sparar data från dataset till xml filen
            ds.WriteXml("notes.xml");
        }

        
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //här öppnas det upp ett fönster där man kan välja en färg, colorDialog1 används för det
            //ändrar färg bara om man väljer "ok"
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //ändrar färg för newnote rutan
                groupBoxNewNote.BackColor = colorDialog1.Color;

                //skriver upp vald färg i textbox
                textBoxColorCode.Text = groupBoxNewNote.BackColor.ToString();
            }
        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        public static void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Radera vald note?", "Radera", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Raderar alla valda rader då man trycker på radera knappen
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    try
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kan inte radera vald rad, " + ex.Message);
                    }

                }
                SaveData();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void populateItems()
        {
            NoteItem[] noteItems = new NoteItem[dataGridView1.RowCount];

            //skapar alla notes och radar upp dem i flowlayoutpanel
            for (int i = 0; i < noteItems.Length; i++)
            {
                noteItems[i] = new NoteItem();
                noteItems[i].Name = "namn hit från datasource";
                noteItems[i].Description = "beskrivning från datasource";
                //noteItems[i].Color = "färg hit";

                //lägger till i flowlayout panel
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                flowLayoutPanel1.Controls.Add(noteItems[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
