using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentSystem.Forms
{
    public partial class AppointmentUC : UserControl
    {
        public AppointmentUC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void docCommentPictureBox_Click(object sender, EventArgs e)
        {

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
            
        }
    }
}
