﻿namespace todo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.groupBoxNewNote = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxEditNote = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelColorEdit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonColorEdit = new System.Windows.Forms.Button();
            this.textBoxDescEdit = new System.Windows.Forms.TextBox();
            this.textBoxNameEdit = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxNewNote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxEditNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNewNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewNote.Location = new System.Drawing.Point(35, 12);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(937, 105);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "Ny note";
            this.buttonNewNote.UseVisualStyleBackColor = false;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // groupBoxNewNote
            // 
            this.groupBoxNewNote.Controls.Add(this.buttonCancel);
            this.groupBoxNewNote.Controls.Add(this.panelColor);
            this.groupBoxNewNote.Controls.Add(this.label2);
            this.groupBoxNewNote.Controls.Add(this.labelName);
            this.groupBoxNewNote.Controls.Add(this.buttonAddNote);
            this.groupBoxNewNote.Controls.Add(this.buttonColor);
            this.groupBoxNewNote.Controls.Add(this.textBoxDesc);
            this.groupBoxNewNote.Controls.Add(this.textBoxName);
            this.groupBoxNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewNote.Location = new System.Drawing.Point(12, 147);
            this.groupBoxNewNote.Name = "groupBoxNewNote";
            this.groupBoxNewNote.Size = new System.Drawing.Size(984, 286);
            this.groupBoxNewNote.TabIndex = 12;
            this.groupBoxNewNote.TabStop = false;
            this.groupBoxNewNote.Text = "Skapa ny note";
            this.groupBoxNewNote.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(346, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 48);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(801, 114);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(159, 92);
            this.panelColor.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Beskrivning";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(19, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Titel";
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNote.Location = new System.Drawing.Point(503, 223);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(129, 48);
            this.buttonAddNote.TabIndex = 15;
            this.buttonAddNote.Text = "Lägg till";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColor.Location = new System.Drawing.Point(801, 62);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(159, 36);
            this.buttonColor.TabIndex = 14;
            this.buttonColor.Text = "Ändra färg";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(23, 114);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(722, 92);
            this.textBoxDesc.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(23, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(722, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.groupBoxEditNote);
            this.panel2.Controls.Add(this.groupBoxNewNote);
            this.panel2.Controls.Add(this.buttonNewNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 745);
            this.panel2.TabIndex = 24;
            // 
            // groupBoxEditNote
            // 
            this.groupBoxEditNote.Controls.Add(this.labelID);
            this.groupBoxEditNote.Controls.Add(this.button1);
            this.groupBoxEditNote.Controls.Add(this.panelColorEdit);
            this.groupBoxEditNote.Controls.Add(this.label1);
            this.groupBoxEditNote.Controls.Add(this.label3);
            this.groupBoxEditNote.Controls.Add(this.buttonUpdate);
            this.groupBoxEditNote.Controls.Add(this.buttonColorEdit);
            this.groupBoxEditNote.Controls.Add(this.textBoxDescEdit);
            this.groupBoxEditNote.Controls.Add(this.textBoxNameEdit);
            this.groupBoxEditNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditNote.Location = new System.Drawing.Point(12, 439);
            this.groupBoxEditNote.Name = "groupBoxEditNote";
            this.groupBoxEditNote.Size = new System.Drawing.Size(984, 286);
            this.groupBoxEditNote.TabIndex = 25;
            this.groupBoxEditNote.TabStop = false;
            this.groupBoxEditNote.Text = "Redigera note";
            this.groupBoxEditNote.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Enabled = false;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(189, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 25;
            this.button1.Text = "Avbryt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelColorEdit
            // 
            this.panelColorEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorEdit.Location = new System.Drawing.Point(801, 114);
            this.panelColorEdit.Name = "panelColorEdit";
            this.panelColorEdit.Size = new System.Drawing.Size(159, 92);
            this.panelColorEdit.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Beskrivning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Namn";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(503, 223);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 48);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Uppdatera";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonColorEdit
            // 
            this.buttonColorEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorEdit.Location = new System.Drawing.Point(801, 62);
            this.buttonColorEdit.Name = "buttonColorEdit";
            this.buttonColorEdit.Size = new System.Drawing.Size(159, 36);
            this.buttonColorEdit.TabIndex = 14;
            this.buttonColorEdit.Text = "Ändra färg";
            this.buttonColorEdit.UseVisualStyleBackColor = true;
            this.buttonColorEdit.Click += new System.EventHandler(this.buttonColorEdit_Click);
            // 
            // textBoxDescEdit
            // 
            this.textBoxDescEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescEdit.Location = new System.Drawing.Point(23, 114);
            this.textBoxDescEdit.Multiline = true;
            this.textBoxDescEdit.Name = "textBoxDescEdit";
            this.textBoxDescEdit.Size = new System.Drawing.Size(722, 92);
            this.textBoxDescEdit.TabIndex = 12;
            // 
            // textBoxNameEdit
            // 
            this.textBoxNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameEdit.Location = new System.Drawing.Point(23, 62);
            this.textBoxNameEdit.Name = "textBoxNameEdit";
            this.textBoxNameEdit.Size = new System.Drawing.Size(722, 26);
            this.textBoxNameEdit.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 751);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 19);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 770);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "To Do";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNewNote.ResumeLayout(false);
            this.groupBoxNewNote.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxEditNote.ResumeLayout(false);
            this.groupBoxEditNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.GroupBox groupBoxNewNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.GroupBox groupBoxEditNote;
        private System.Windows.Forms.Panel panelColorEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonColorEdit;
        private System.Windows.Forms.TextBox textBoxDescEdit;
        private System.Windows.Forms.TextBox textBoxNameEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonCancel;
    }
}

