namespace todo
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
            this.buttonNewNote = new System.Windows.Forms.Button();
            this.groupBoxNewNote = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttontableview = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDeadline = new System.Windows.Forms.CheckBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBoxNewNote.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNewNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewNote.Location = new System.Drawing.Point(29, 20);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(206, 42);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "Ny note";
            this.buttonNewNote.UseVisualStyleBackColor = false;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // groupBoxNewNote
            // 
            this.groupBoxNewNote.Controls.Add(this.panelColor);
            this.groupBoxNewNote.Controls.Add(this.checkBoxDeadline);
            this.groupBoxNewNote.Controls.Add(this.dateTimePickerDeadline);
            this.groupBoxNewNote.Controls.Add(this.label2);
            this.groupBoxNewNote.Controls.Add(this.labelName);
            this.groupBoxNewNote.Controls.Add(this.buttonAddNote);
            this.groupBoxNewNote.Controls.Add(this.buttonColor);
            this.groupBoxNewNote.Controls.Add(this.textBoxDesc);
            this.groupBoxNewNote.Controls.Add(this.textBoxName);
            this.groupBoxNewNote.Location = new System.Drawing.Point(12, 125);
            this.groupBoxNewNote.Name = "groupBoxNewNote";
            this.groupBoxNewNote.Size = new System.Drawing.Size(243, 388);
            this.groupBoxNewNote.TabIndex = 12;
            this.groupBoxNewNote.TabStop = false;
            this.groupBoxNewNote.Text = "groupBox1";
            this.groupBoxNewNote.Visible = false;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Enabled = false;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(23, 221);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
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
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Namn";
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(23, 289);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(200, 36);
            this.buttonAddNote.TabIndex = 15;
            this.buttonAddNote.Text = "Lägg till";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(23, 247);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 36);
            this.buttonColor.TabIndex = 14;
            this.buttonColor.Text = "Ändra färg";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(23, 114);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 71);
            this.textBoxDesc.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(23, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.groupBoxNewNote);
            this.panel2.Controls.Add(this.buttontableview);
            this.panel2.Controls.Add(this.buttonNewNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 664);
            this.panel2.TabIndex = 24;
            // 
            // buttontableview
            // 
            this.buttontableview.BackColor = System.Drawing.Color.Gainsboro;
            this.buttontableview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttontableview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontableview.Location = new System.Drawing.Point(29, 68);
            this.buttontableview.Name = "buttontableview";
            this.buttontableview.Size = new System.Drawing.Size(206, 42);
            this.buttontableview.TabIndex = 26;
            this.buttontableview.Text = "tabell översikt";
            this.buttontableview.UseVisualStyleBackColor = false;
            this.buttontableview.Click += new System.EventHandler(this.buttontableview_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 664);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // checkBoxDeadline
            // 
            this.checkBoxDeadline.AutoSize = true;
            this.checkBoxDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeadline.Location = new System.Drawing.Point(23, 191);
            this.checkBoxDeadline.Name = "checkBoxDeadline";
            this.checkBoxDeadline.Size = new System.Drawing.Size(100, 24);
            this.checkBoxDeadline.TabIndex = 23;
            this.checkBoxDeadline.Text = "Deadline?";
            this.checkBoxDeadline.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(129, 247);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(94, 36);
            this.panelColor.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(973, 664);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxNewNote.ResumeLayout(false);
            this.groupBoxNewNote.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttontableview;
        private System.Windows.Forms.CheckBox checkBoxDeadline;
        private System.Windows.Forms.Panel panelColor;
    }
}

