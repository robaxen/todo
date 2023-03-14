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
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPostName
            // 
            this.labelPostName.AutoSize = true;
            this.labelPostName.Enabled = false;
            this.labelPostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostName.Location = new System.Drawing.Point(67, 15);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(59, 27);
            this.labelPostName.TabIndex = 1;
            this.labelPostName.Text = "Name";
            this.labelPostName.UseCompatibleTextRendering = true;
            // 
            // labelPostDescription
            // 
            this.labelPostDescription.Enabled = false;
            this.labelPostDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostDescription.Location = new System.Drawing.Point(67, 50);
            this.labelPostDescription.Name = "labelPostDescription";
            this.labelPostDescription.Size = new System.Drawing.Size(372, 28);
            this.labelPostDescription.TabIndex = 2;
            this.labelPostDescription.Text = "Description";
            this.labelPostDescription.UseCompatibleTextRendering = true;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelColor.Location = new System.Drawing.Point(0, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(61, 143);
            this.panelColor.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(924, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 45);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // NoteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelPostDescription);
            this.Controls.Add(this.labelPostName);
            this.Name = "NoteItem";
            this.Size = new System.Drawing.Size(991, 143);
            this.MouseEnter += new System.EventHandler(this.NoteItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NoteItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPostName;
        private System.Windows.Forms.Label labelPostDescription;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonDelete;
    }
}
