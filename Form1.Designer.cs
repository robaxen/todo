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
            this.checkedListBoxNotes = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonNewNote
            // 
            this.buttonNewNote.Location = new System.Drawing.Point(12, 12);
            this.buttonNewNote.Name = "buttonNewNote";
            this.buttonNewNote.Size = new System.Drawing.Size(75, 23);
            this.buttonNewNote.TabIndex = 0;
            this.buttonNewNote.Text = "Ny note";
            this.buttonNewNote.UseVisualStyleBackColor = true;
            this.buttonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
            // 
            // checkedListBoxNotes
            // 
            this.checkedListBoxNotes.FormattingEnabled = true;
            this.checkedListBoxNotes.Location = new System.Drawing.Point(12, 41);
            this.checkedListBoxNotes.Name = "checkedListBoxNotes";
            this.checkedListBoxNotes.Size = new System.Drawing.Size(335, 229);
            this.checkedListBoxNotes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 436);
            this.Controls.Add(this.checkedListBoxNotes);
            this.Controls.Add(this.buttonNewNote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewNote;
        private System.Windows.Forms.CheckedListBox checkedListBoxNotes;
    }
}

