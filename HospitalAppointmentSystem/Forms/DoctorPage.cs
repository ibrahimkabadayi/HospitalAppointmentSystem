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
    public partial class Form2 : Form
    {
        private readonly int doctorID;
        private readonly IUnitOfWork _unitOfWork;
        public Form2(int id)
        {
            doctorID = id;
            InitializeComponent();
            var context = new HospitalDbContext();
            _unitOfWork = new UnitOfWork(context);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var doc = _unitOfWork.Doctors.GetByIdAsync(doctorID);
            Doctors docObject = doc.Result;
            titleLabel.Text = "Welcome doctor " + docObject.Name + " " + docObject.Surname + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
