namespace HospitalAppointmentSystem.Forms
{
    partial class ShowNoteUC
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
            button1 = new Button();
            noteTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 201);
            button1.Name = "button1";
            button1.Size = new Size(257, 41);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(0, 0);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.ReadOnly = true;
            noteTextBox.Size = new Size(257, 203);
            noteTextBox.TabIndex = 2;
            noteTextBox.Text = "";
            // 
            // ShowNoteUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(noteTextBox);
            Name = "ShowNoteUC";
            Size = new Size(256, 242);
            Load += ShowNoteUC_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox noteTextBox;
    }
}
