using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetTakipp
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=BUSRAYASMIN\\SQLEXPRESS; Database=PetTakip; Trusted_Connection=True; TrustServerCertificate=True;";
        int selectedId = -1;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pet", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            cmbType.SelectedIndex = -1;
            txtBreed.Text = "";
            numAge.Value = 0;
            cmbGender.SelectedIndex = -1;
            numWeight.Value = 0;
            txtColor.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            txtOwner.Text = "";
            txtMicrochip.Text = "";
            selectedId = -1;
        }

        private Pet CreatePetFromForm()
        {
            string type = cmbType.SelectedItem?.ToString();
            Pet pet;

            switch (type)
            {
                case "Köpek":
                    pet = new Dog();
                    break;
                case "Kedi":
                    pet = new Cat();
                    break;
                case "Kuþ":
                    pet = new Bird();
                    break;
                default:
                    pet = new Pet(); 
                    break;
            }

            pet.Name = txtName.Text;
            pet.Type = type;
            pet.Breed = txtBreed.Text;
            pet.Age = (int)numAge.Value;
            pet.Gender = cmbGender.SelectedItem.ToString();
            pet.Weight = (double)numWeight.Value;
            pet.Color = txtColor.Text;
            pet.BirthDate = dtpBirthDate.Value;
            pet.Owner = txtOwner.Text;
            pet.MicrochipNumber = txtMicrochip.Text;
            pet.RegistrationDate = DateTime.Now;
            pet.IsActive = true;

            return pet;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
                cmbType.SelectedItem = row.Cells["Type"].Value.ToString();
                txtBreed.Text = row.Cells["Breed"].Value.ToString();
                numAge.Value = Convert.ToDecimal(row.Cells["Age"].Value);
                cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
                numWeight.Value = Convert.ToDecimal(row.Cells["Weight"].Value);
                txtColor.Text = row.Cells["Color"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                txtOwner.Text = row.Cells["Owner"].Value.ToString();
                txtMicrochip.Text = row.Cells["Microchip"].Value.ToString();

                LoadVaccinations(selectedId);
                LoadTreatment(selectedId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Lütfen güncellenecek Pet seçin.");
                return;
            }

            Pet pet = CreatePetFromForm();   

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtBreed.Text) ||
                cmbGender.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtOwner.Text) ||
                string.IsNullOrWhiteSpace(txtMicrochip.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Pet SET 
                            Name = @Name, 
                            Type = @Type, 
                            Breed = @Breed, 
                            Age = @Age, 
                            Gender = @Gender, 
                            Weight = @Weight, 
                            Color = @Color, 
                            BirthDate = @BirthDate, 
                            Owner = @Owner, 
                            Microchip = @Microchip 
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", pet.Name);
                cmd.Parameters.AddWithValue("@Type", pet.Type);
                cmd.Parameters.AddWithValue("@Breed", pet.Breed);
                cmd.Parameters.AddWithValue("@Age", pet.Age);
                cmd.Parameters.AddWithValue("@Gender", pet.Gender);
                cmd.Parameters.AddWithValue("@Weight", pet.Weight);
                cmd.Parameters.AddWithValue("@Color", pet.Color);
                cmd.Parameters.AddWithValue("@BirthDate", pet.BirthDate);
                cmd.Parameters.AddWithValue("@Owner", txtOwner.Text);
                cmd.Parameters.AddWithValue("@Microchip", pet.MicrochipNumber);
                cmd.Parameters.AddWithValue("@Id", selectedId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            ClearFields();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Lütfen silinecek kaydý seçin.");
                return;
            }

            DialogResult result = MessageBox.Show("Bu kaydý silmek istediðinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Pet WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", selectedId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            ClearFields();
            LoadData();
            MessageBox.Show("Kayýt baþarýyla silindi.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        cmbType.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(txtBreed.Text) ||
        cmbGender.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(txtColor.Text) ||
        string.IsNullOrWhiteSpace(txtOwner.Text) ||
        string.IsNullOrWhiteSpace(txtMicrochip.Text))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.");
                return;
            }

            Pet pet = CreatePetFromForm();            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Pet 
                         (Name, Type, Breed, Age, Gender, Weight, Color, BirthDate, Owner, Microchip) 
                         VALUES 
                         (@Name, @Type, @Breed, @Age, @Gender, @Weight, @Color, @BirthDate, @Owner, @Microchip)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", pet.Name);
                cmd.Parameters.AddWithValue("@Type", pet.Type);
                cmd.Parameters.AddWithValue("@Breed", pet.Breed);
                cmd.Parameters.AddWithValue("@Age", pet.Age);
                cmd.Parameters.AddWithValue("@Gender", pet.Gender);
                cmd.Parameters.AddWithValue("@Weight", pet.Weight);
                cmd.Parameters.AddWithValue("@Color", pet.Color);
                cmd.Parameters.AddWithValue("@BirthDate", pet.BirthDate);
                cmd.Parameters.AddWithValue("@Owner", txtOwner.Text);
                cmd.Parameters.AddWithValue("@Microchip", pet.MicrochipNumber);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            ClearFields();
            LoadData();
            MessageBox.Show("Kayýt baþarýyla eklendi.");
        }

        private void LoadVaccinations(int petId)
        {
            try
            {
                string query = @"
        SELECT 
            Name,
            Date,
            CASE WHEN IsCompleted = 1 THEN 'Tamamlandý' ELSE 'Planlandý' END as Status,
            VeterinarianName,
            NextVaccinationDate,
            VaccineBrand,
            BatchNumber
        FROM Vaccination 
        WHERE PetId = @PetId 
        ORDER BY Date DESC";

                using (SqlConnection con = new SqlConnection(connectionString)) 
                {
                    con.Open();

                    using (var command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@PetId", petId);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable vaccinationsTable = new DataTable();
                        adapter.Fill(vaccinationsTable);

                        lstVaccination.Items.Clear();

                        foreach (DataRow row in vaccinationsTable.Rows)
                        {
                            string vaccinationInfo = $"{row["Name"]} - {Convert.ToDateTime(row["Date"]):dd/MM/yyyy} - {row["Status"]}";

                            if (!string.IsNullOrWhiteSpace(row["VeterinarianName"]?.ToString()))
                            {
                                vaccinationInfo += $" - Dr. {row["VeterinarianName"]}";
                            }

                            if (row["NextVaccinationDate"] != DBNull.Value)
                            {
                                DateTime nextDate = Convert.ToDateTime(row["NextVaccinationDate"]);
                                vaccinationInfo += $" - Sonraki: {nextDate:dd/MM/yyyy}";
                            }

                            if (!string.IsNullOrWhiteSpace(row["VaccineBrand"]?.ToString()))
                            {
                                vaccinationInfo += $" - Marka: {row["VaccineBrand"]}";
                            }

                            lstVaccination.Items.Add(vaccinationInfo);
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aþý verileri yüklenirken hata oluþtu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Lütfen önce bir hayvan seçin!", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var addTreatmentForm = new AddTreatmentForm())
            {
                if (addTreatmentForm.ShowDialog() == DialogResult.OK)
                {
                    var treatment = addTreatmentForm.Treatment;
                    treatment.PetId = selectedId;

                    string query = @"
    INSERT INTO Treatment 
    (PetId, TreatmentType, TreatmentName, TreatmentDate, Veterinarian, Cost, Diagnosis, Medications, HasFollowUp, FollowUpDate)
    VALUES
    (@PetId, @TreatmentType, @TreatmentName, @TreatmentDate, @Veterinarian, @Cost, @Diagnosis, @Medications, @HasFollowUp, @FollowUpDate)";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PetId", treatment.PetId);
                        cmd.Parameters.AddWithValue("@TreatmentType", treatment.TreatmentType);
                        cmd.Parameters.AddWithValue("@TreatmentName", treatment.TreatmentName);
                        cmd.Parameters.AddWithValue("@TreatmentDate", treatment.TreatmentDate);
                        cmd.Parameters.AddWithValue("@Veterinarian", treatment.Veterinarian);
                        cmd.Parameters.AddWithValue("@Cost", treatment.Cost);
                        cmd.Parameters.AddWithValue("@Diagnosis", treatment.Diagnosis);
                        cmd.Parameters.AddWithValue("@Medications", treatment.Medications);
                        cmd.Parameters.AddWithValue("@HasFollowUp", treatment.HasFollowUp);
                        cmd.Parameters.AddWithValue("@FollowUpDate", (object?)treatment.FollowUpDate ?? DBNull.Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tedavi baþarýyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadTreatment(selectedId);
                }
            }


        }

        private void LoadTreatment(int petId)
        {
            lstTreatment.Items.Clear();

            string query = "SELECT TreatmentName, TreatmentDate, Veterinarian, Medications, HasFollowUp, FollowUpDate FROM Treatment WHERE PetId = @PetId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@PetId", petId);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["TreatmentName"].ToString();
                        DateTime date = (DateTime)reader["TreatmentDate"];
                        string vet = reader["Veterinarian"].ToString();
                        string meds = reader["Medications"].ToString();
                        bool hasFollowUp = (bool)reader["HasFollowUp"];
                        string followUpDate = hasFollowUp && reader["FollowUpDate"] != DBNull.Value
                            ? ((DateTime)reader["FollowUpDate"]).ToShortDateString()
                            : "-";

                        string itemText = $"{name} | {date:dd.MM.yyyy} | {vet} | {meds} | Takip: {(hasFollowUp ? "Var (" + followUpDate + ")" : "Yok")}";

                        lstTreatment.Items.Add(itemText);
                    }
                }
            }
        }


        private void btnAddVaccination_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Lütfen önce bir hayvan seçin!", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var addVaccinationForm = new AddVaccinationForm(selectedId))
            {
                if (addVaccinationForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var vaccination = addVaccinationForm.Vaccination;
                        string query = @"
                    INSERT INTO Vaccination 
                    (PetId, Name, Date, IsCompleted, VeterinarianName, NextVaccinationDate, VaccineBrand, BatchNumber) 
                    VALUES 
                    (@PetId, @Name, @Date, @IsCompleted, @VeterinarianName, @NextVaccinationDate, @VaccineBrand, @BatchNumber)";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@PetId", selectedId);
                                cmd.Parameters.AddWithValue("@Name", vaccination.Name ?? "");
                                cmd.Parameters.AddWithValue("@Date", vaccination.Date);
                                cmd.Parameters.AddWithValue("@IsCompleted", vaccination.IsCompleted);
                                cmd.Parameters.AddWithValue("@VeterinarianName", vaccination.VeterinarianName ?? "");
                                cmd.Parameters.AddWithValue("@NextVaccinationDate", (object?)vaccination.NextVaccinationDate ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@VaccineBrand", vaccination.VaccineBrand ?? "");
                                cmd.Parameters.AddWithValue("@BatchNumber", vaccination.BatchNumber ?? "");

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }

                        MessageBox.Show("Aþý baþarýyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadVaccinations(selectedId);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Aþý eklenirken hata oluþtu: " + ex.Message, "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
