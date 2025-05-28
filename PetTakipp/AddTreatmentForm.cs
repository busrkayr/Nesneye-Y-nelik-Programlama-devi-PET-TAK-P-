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
    public partial class AddTreatmentForm : Form
    {
        public Treatment Treatment { get; private set; }

        public AddTreatmentForm()
        {
            InitializeComponent();
        }
        private void AddTreatmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Treatment = new Treatment
            {
                TreatmentType = cmbTreatmentType.Text,
                TreatmentName = txtTreatmentName.Text,
                TreatmentDate = dtpTreatmentDate.Value,
                Veterinarian = txtVeterinarian.Text,
                Cost = numCost.Value,                
                Diagnosis = txtDiagnosis.Text,
                Medications = txtMedications.Text,
                HasFollowUp = chkHasFollowUp.Checked,
                FollowUpDate = chkHasFollowUp.Checked ? dtpFollowUpDate.Value : (DateTime?)null
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        

        }

    }
}
