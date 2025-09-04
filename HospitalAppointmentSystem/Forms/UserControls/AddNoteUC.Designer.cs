namespace HospitalAppointmentSystem.Forms
{
    partial class AddNoteUC
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
            noteTextBox = new RichTextBox();
            deleteButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(0, 0);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(257, 204);
            noteTextBox.TabIndex = 0;
            noteTextBox.Text = "";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(0, 201);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(133, 44);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 201);
            button2.Name = "button2";
            button2.Size = new Size(131, 44);
            button2.TabIndex = 2;
            button2.Text = "Save ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddNoteUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(deleteButton);
            Controls.Add(noteTextBox);
            Name = "AddNoteUC";
            Size = new Size(257, 246);
            Load += AddNoteUC_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox noteTextBox;
        private Button deleteButton;
        private Button button2;
    }
}
