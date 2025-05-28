using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetTakipp
{
    public partial class AddVaccinationForm : Form
    {
        public Vaccination Vaccination { get; private set; }
        private int petId;
        public AddVaccinationForm(int petId)
        {
            InitializeComponent();
            this.petId = petId;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vaccination = new Vaccination
            {
                Name = txtCustomVaccination.Text,
                Date = dtpVaccinationDate.Value,
                IsCompleted = chkCompleted.Checked,
                VeterinarianName = txtVeterinarian.Text,
                NextVaccinationDate = dtpNextVaccinationDate.Checked ? dtpNextVaccinationDate.Value : (DateTime?)null,
                BatchNumber = txtBatchNumber.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void cmbVaccinationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
