namespace PetTakipp
{
    partial class AddTreatmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTreatmentForm));
            lblTreatmentType = new Label();
            lblTreatmentName = new Label();
            lblTreatmentDate = new Label();
            lblDiagnosis = new Label();
            lblCost = new Label();
            lblVeterinarian = new Label();
            lblMedications = new Label();
            chkHasFollowUp = new CheckBox();
            lblFollowUpDate = new Label();
            cmbTreatmentType = new ComboBox();
            txtTreatmentName = new TextBox();
            dtpTreatmentDate = new DateTimePicker();
            dtpFollowUpDate = new DateTimePicker();
            txtVeterinarian = new TextBox();
            numCost = new NumericUpDown();
            txtDiagnosis = new TextBox();
            txtMedications = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTreatmentType
            // 
            lblTreatmentType.AutoSize = true;
            lblTreatmentType.Location = new Point(38, 31);
            lblTreatmentType.Name = "lblTreatmentType";
            lblTreatmentType.Size = new Size(88, 20);
            lblTreatmentType.TabIndex = 0;
            lblTreatmentType.Text = "Tedavi Türü:";
            // 
            // lblTreatmentName
            // 
            lblTreatmentName.AutoSize = true;
            lblTreatmentName.Location = new Point(38, 70);
            lblTreatmentName.Name = "lblTreatmentName";
            lblTreatmentName.Size = new Size(82, 20);
            lblTreatmentName.TabIndex = 1;
            lblTreatmentName.Text = "Tedavi Adı:";
            // 
            // lblTreatmentDate
            // 
            lblTreatmentDate.AutoSize = true;
            lblTreatmentDate.Location = new Point(38, 110);
            lblTreatmentDate.Name = "lblTreatmentDate";
            lblTreatmentDate.Size = new Size(43, 20);
            lblTreatmentDate.TabIndex = 2;
            lblTreatmentDate.Text = "Tarih:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(38, 231);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(51, 20);
            lblDiagnosis.TabIndex = 5;
            lblDiagnosis.Text = "Teşhis:";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(38, 191);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(47, 20);
            lblCost.TabIndex = 4;
            lblCost.Text = "Ücret:";
            // 
            // lblVeterinarian
            // 
            lblVeterinarian.AutoSize = true;
            lblVeterinarian.Location = new Point(38, 152);
            lblVeterinarian.Name = "lblVeterinarian";
            lblVeterinarian.Size = new Size(71, 20);
            lblVeterinarian.TabIndex = 3;
            lblVeterinarian.Text = "Veteriner:";
            // 
            // lblMedications
            // 
            lblMedications.AutoSize = true;
            lblMedications.Location = new Point(38, 271);
            lblMedications.Name = "lblMedications";
            lblMedications.Size = new Size(52, 20);
            lblMedications.TabIndex = 6;
            lblMedications.Text = "İlaçlar:";
            // 
            // chkHasFollowUp
            // 
            chkHasFollowUp.AutoSize = true;
            chkHasFollowUp.Location = new Point(38, 306);
            chkHasFollowUp.Name = "chkHasFollowUp";
            chkHasFollowUp.Size = new Size(150, 24);
            chkHasFollowUp.TabIndex = 7;
            chkHasFollowUp.Text = "Kontrol Gerekiyor.";
            chkHasFollowUp.UseVisualStyleBackColor = true;
            // 
            // lblFollowUpDate
            // 
            lblFollowUpDate.AutoSize = true;
            lblFollowUpDate.Location = new Point(37, 342);
            lblFollowUpDate.Name = "lblFollowUpDate";
            lblFollowUpDate.Size = new Size(100, 20);
            lblFollowUpDate.TabIndex = 8;
            lblFollowUpDate.Text = "Kontrol Tarihi:";
            // 
            // cmbTreatmentType
            // 
            cmbTreatmentType.FormattingEnabled = true;
            cmbTreatmentType.Items.AddRange(new object[] { "Parazit Kontrolü", "Röntgen ve ultrasonografi", "Cerrahi", "Yanık Tedavisi", "Özel diyetler, kilo kontrolü", "Diş Çekimi", "Tırnak kesimi", "Tüy bakımı ve tımar", "Davranış problemleri ", "Kısırlaştırma", "Yara onarımı", "Kan Testi", "Travma", "Zehirlenme tedavisi", "Göz enfeksiyonları", "Fizyoterapi" });
            cmbTreatmentType.Location = new Point(154, 23);
            cmbTreatmentType.Name = "cmbTreatmentType";
            cmbTreatmentType.Size = new Size(227, 28);
            cmbTreatmentType.TabIndex = 9;
            // 
            // txtTreatmentName
            // 
            txtTreatmentName.Location = new Point(154, 57);
            txtTreatmentName.Name = "txtTreatmentName";
            txtTreatmentName.Size = new Size(227, 27);
            txtTreatmentName.TabIndex = 10;
            // 
            // dtpTreatmentDate
            // 
            dtpTreatmentDate.Location = new Point(154, 103);
            dtpTreatmentDate.Name = "dtpTreatmentDate";
            dtpTreatmentDate.Size = new Size(227, 27);
            dtpTreatmentDate.TabIndex = 11;
            // 
            // dtpFollowUpDate
            // 
            dtpFollowUpDate.Location = new Point(154, 335);
            dtpFollowUpDate.Name = "dtpFollowUpDate";
            dtpFollowUpDate.Size = new Size(227, 27);
            dtpFollowUpDate.TabIndex = 12;
            // 
            // txtVeterinarian
            // 
            txtVeterinarian.Location = new Point(154, 145);
            txtVeterinarian.Name = "txtVeterinarian";
            txtVeterinarian.Size = new Size(227, 27);
            txtVeterinarian.TabIndex = 13;
            // 
            // numCost
            // 
            numCost.Location = new Point(154, 184);
            numCost.Name = "numCost";
            numCost.Size = new Size(118, 27);
            numCost.TabIndex = 14;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(154, 224);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(227, 27);
            txtDiagnosis.TabIndex = 15;
            // 
            // txtMedications
            // 
            txtMedications.Location = new Point(154, 264);
            txtMedications.Name = "txtMedications";
            txtMedications.Size = new Size(227, 27);
            txtMedications.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(178, 382);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 17;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // AddTreatmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtMedications);
            Controls.Add(txtDiagnosis);
            Controls.Add(numCost);
            Controls.Add(txtVeterinarian);
            Controls.Add(dtpFollowUpDate);
            Controls.Add(dtpTreatmentDate);
            Controls.Add(txtTreatmentName);
            Controls.Add(cmbTreatmentType);
            Controls.Add(lblFollowUpDate);
            Controls.Add(chkHasFollowUp);
            Controls.Add(lblMedications);
            Controls.Add(lblDiagnosis);
            Controls.Add(lblCost);
            Controls.Add(lblVeterinarian);
            Controls.Add(lblTreatmentDate);
            Controls.Add(lblTreatmentName);
            Controls.Add(lblTreatmentType);
            Name = "AddTreatmentForm";
            Text = "AddTreatmentForm";
            Load += AddTreatmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTreatmentType;
        private Label lblTreatmentName;
        private Label lblTreatmentDate;
        private Label lblDiagnosis;
        private Label lblCost;
        private Label lblVeterinarian;
        private Label lblMedications;
        private CheckBox chkHasFollowUp;
        private Label lblFollowUpDate;
        private ComboBox cmbTreatmentType;
        private TextBox txtTreatmentName;
        private DateTimePicker dtpTreatmentDate;
        private DateTimePicker dtpFollowUpDate;
        private TextBox txtVeterinarian;
        private NumericUpDown numCost;
        private TextBox txtDiagnosis;
        private TextBox txtMedications;
        private Button button1;
        private PictureBox pictureBox1;
    }
}