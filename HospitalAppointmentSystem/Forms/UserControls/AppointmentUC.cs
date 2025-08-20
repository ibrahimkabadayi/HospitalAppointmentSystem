using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem.Forms.DataTransferObjects;

namespace HospitalAppointmentSystem.Forms
{
    public partial class AppointmentUC : UserControl
    {
        private StatusDTO statusDTO;
        private NoteDTO noteDTO;
        private bool isDoctor;
        public AppointmentUC(StatusDTO statusDTO, NoteDTO noteDTO, bool isDoctor)
        {
            InitializeComponent();
            this.statusDTO = statusDTO;
            this.noteDTO = noteDTO;
            this.isDoctor = isDoctor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isDoctor && statusDTO.status.Equals("Active")) 
            {
                statusPictureBox.Image = Resource1.Tick;
                statusLabel.Text = "Seen";
                statusDTO.status = "Seen";
            } 
            else if(isDoctor && statusDTO.status.Equals("Seen")) 
            {
                statusPictureBox.Image = Resource1.Double_Tick;
                statusLabel.Text = "Active";
                statusDTO.status = "Active";
            }
            else if (statusDTO.status.Equals("Active"))
            {
                statusPictureBox.Image = Resource1.Tick;
                statusLabel.Text = "Canceled";
                statusDTO.status = "Canceled";
            }
            else 
            {
                statusPictureBox.Image = Resource1.Cross_Mark;
                statusLabel.Text = "Active";
                statusDTO.status = "Active";
            }
        }

        private void docCommentPictureBox_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Size = new Size(260, 245); 
            popup.MaximizeBox = false;
            popup.MinimizeBox = false;

            AddNoteUC noteUC = new AddNoteUC(noteDTO,isDoctor);
            noteUC.Dock = DockStyle.Fill;

            popup.Controls.Add(noteUC);
            popup.ShowDialog(); 
        }

        private void statusPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Methods.ImageMouseEnter(statusPictureBox);
        }

        private void statusPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Methods.ImageMouseLeave(statusPictureBox);
        }

        private void patientCommentPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Methods.ImageMouseEnter(patientCommentPictureBox);
        }

        private void patientCommentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Methods.ImageMouseLeave(patientCommentPictureBox);
        }

        private void docCommentPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Methods.ImageMouseEnter(docCommentPictureBox);
        }

        private void docCommentPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Methods.ImageMouseLeave(docCommentPictureBox);
        }

        private void patientCommentPictureBox_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Size = new Size(256, 242);
            popup.MaximizeBox = false;
            popup.MinimizeBox = false;

            ShowNoteUC noteUC = new ShowNoteUC(noteDTO, isDoctor);
            noteUC.Dock = DockStyle.Fill;

            popup.Controls.Add(noteUC);
            popup.ShowDialog();
        }

        private void AppointmentUC_Load(object sender, EventArgs e)
        {
            if(statusDTO.status.Equals("Active")) 
            {
                if (isDoctor) 
                {
                    statusPictureBox.Image = Resource1.Double_Tick;
                }
                else 
                {
                    statusPictureBox.Image = Resource1.Cross_Mark;
                }
                    return;
            }
            else if (statusDTO.status.Equals("Canceled")) 
            {
                statusPictureBox.Image = Resource1.Tick;

            }
            else 
            {
                statusPictureBox.Image = Resource1.Tick;
            }
            
        }
    }
}
