namespace todo
{
    partial class NoteItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPostName = new System.Windows.Forms.Label();
            this.labelPostDescription = new System.Windows.Forms.Label();
            this.labelPostDeadline = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPostName
            // 
            this.labelPostName.AutoSize = true;
            this.labelPostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostName.Location = new System.Drawing.Point(162, 12);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(61, 24);
            this.labelPostName.TabIndex = 1;
            this.labelPostName.Text = "Name";
            // 
            // labelPostDescription
            // 
            this.labelPostDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostDescription.Location = new System.Drawing.Point(151, 51);
            this.labelPostDescription.Name = "labelPostDescription";
            this.labelPostDescription.Size = new System.Drawing.Size(372, 28);
            this.labelPostDescription.TabIndex = 2;
            this.labelPostDescription.Text = "Description";
            // 
            // labelPostDeadline
            // 
            this.labelPostDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostDeadline.Location = new System.Drawing.Point(151, 92);
            this.labelPostDeadline.Name = "labelPostDeadline";
            this.labelPostDeadline.Size = new System.Drawing.Size(129, 23);
            this.labelPostDeadline.TabIndex = 3;
            this.labelPostDeadline.Text = "Deadline";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelColor.Controls.Add(this.buttonDone);
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(145, 143);
            this.panelColor.TabIndex = 4;
            // 
            // buttonDone
            // 
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(27, 38);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(93, 64);
            this.buttonDone.TabIndex = 23;
            this.buttonDone.Text = "Klart";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(571, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(115, 36);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Radera";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(450, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(115, 36);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Redigera";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // NoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelPostDeadline);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPostDescription);
            this.Controls.Add(this.labelPostName);
            this.Name = "NoteItem";
            this.Size = new System.Drawing.Size(698, 143);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPostName;
        private System.Windows.Forms.Label labelPostDescription;
        private System.Windows.Forms.Label labelPostDeadline;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
