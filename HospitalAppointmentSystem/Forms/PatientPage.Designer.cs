namespace HospitalAppointmentSystem.Forms
{
    partial class Form3
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
            titleLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            brachesListBox = new ListBox();
            doctorsTextBox = new ListBox();
            timeListBox = new ListBox();
            appointButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            dateTextBox = new MaskedTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Palatino Linotype", 26.25F);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1126, 100);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome Customer!";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 15.75F);
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Branches";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 15.75F);
            label3.Location = new Point(747, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 2;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 15.75F);
            label4.Location = new Point(379, 9);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 3;
            label4.Text = "Doctors";
            // 
            // brachesListBox
            // 
            brachesListBox.FormattingEnabled = true;
            brachesListBox.Location = new Point(11, 40);
            brachesListBox.Name = "brachesListBox";
            brachesListBox.Size = new Size(362, 544);
            brachesListBox.TabIndex = 4;
            // 
            // doctorsTextBox
            // 
            doctorsTextBox.FormattingEnabled = true;
            doctorsTextBox.Location = new Point(379, 40);
            doctorsTextBox.Name = "doctorsTextBox";
            doctorsTextBox.Size = new Size(362, 544);
            doctorsTextBox.TabIndex = 5;
            // 
            // timeListBox
            // 
            timeListBox.FormattingEnabled = true;
            timeListBox.Location = new Point(747, 40);
            timeListBox.Name = "timeListBox";
            timeListBox.Size = new Size(362, 544);
            timeListBox.TabIndex = 6;
            // 
            // appointButton
            // 
            appointButton.Font = new Font("Palatino Linotype", 15.75F);
            appointButton.Location = new Point(545, 601);
            appointButton.Name = "appointButton";
            appointButton.Size = new Size(564, 69);
            appointButton.TabIndex = 7;
            appointButton.Text = "Appoint";
            appointButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(6, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 100);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(appointButton);
            panel2.Controls.Add(dateTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(timeListBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(doctorsTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(brachesListBox);
            panel2.Location = new Point(6, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 723);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 15.75F);
            label5.Location = new Point(11, 603);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 2;
            label5.Text = "Date";
            // 
            // dateTextBox
            // 
            dateTextBox.Font = new Font("Palatino Linotype", 15.75F);
            dateTextBox.Location = new Point(11, 634);
            dateTextBox.Mask = "00/00/0000";
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(528, 36);
            dateTextBox.TabIndex = 3;
            dateTextBox.ValidatingType = typeof(DateTime);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox brachesListBox;
        private ListBox doctorsTextBox;
        private ListBox timeListBox;
        private Button appointButton;
        private Panel panel1;
        private Panel panel2;
        private MaskedTextBox dateTextBox;
        private Label label5;
    }
}