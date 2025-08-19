namespace HospitalAppointmentSystem.Forms
{
    partial class Form2
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
            panel1 = new Panel();
            titleLabel = new Label();
            panel2 = new Panel();
            panel = new FlowLayoutPanel();
            button1 = new Button();
            dateTextBox = new MaskedTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 100);
            panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Palatino Linotype", 26.25F);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1112, 100);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Welcome Doctor!";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTextBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 692);
            panel2.TabIndex = 1;
            // 
            // panel
            // 
            panel.Location = new Point(3, 80);
            panel.Name = "panel";
            panel.Size = new Size(1106, 609);
            panel.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 15.75F);
            button1.Location = new Point(563, 7);
            button1.Name = "button1";
            button1.Size = new Size(535, 67);
            button1.TabIndex = 3;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTextBox
            // 
            dateTextBox.Font = new Font("Palatino Linotype", 15.75F);
            dateTextBox.Location = new Point(37, 38);
            dateTextBox.Mask = "00/00/0000";
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(479, 36);
            dateTextBox.TabIndex = 2;
            dateTextBox.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F);
            label1.Location = new Point(37, 7);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 0;
            label1.Text = "Please enter the date:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 822);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private MaskedTextBox dateTextBox;
        private FlowLayoutPanel panel;
    }
}