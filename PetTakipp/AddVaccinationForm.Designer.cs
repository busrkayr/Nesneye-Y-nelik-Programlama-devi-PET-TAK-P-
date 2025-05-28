namespace PetTakipp
{
    partial class AddVaccinationForm
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
            lblVaccinationType = new Label();
            lblCustomVaccination = new Label();
            lblVaccinationDate = new Label();
            lblVeterinarian = new Label();
            lblBatchNumber = new Label();
            lblNextVaccinationDate = new Label();
            chkCompleted = new CheckBox();
            checkBox2 = new CheckBox();
            cmbVaccinationType = new ComboBox();
            txtCustomVaccination = new TextBox();
            dtpVaccinationDate = new DateTimePicker();
            txtVeterinarian = new TextBox();
            txtBatchNumber = new TextBox();
            dtpNextVaccinationDate = new DateTimePicker();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVaccinationType
            // 
            lblVaccinationType.AutoSize = true;
            lblVaccinationType.Location = new Point(22, 37);
            lblVaccinationType.Name = "lblVaccinationType";
            lblVaccinationType.Size = new Size(65, 20);
            lblVaccinationType.TabIndex = 0;
            lblVaccinationType.Text = "Aşı Türü:";
            // 
            // lblCustomVaccination
            // 
            lblCustomVaccination.AutoSize = true;
            lblCustomVaccination.Location = new Point(22, 74);
            lblCustomVaccination.Name = "lblCustomVaccination";
            lblCustomVaccination.Size = new Size(59, 20);
            lblCustomVaccination.TabIndex = 1;
            lblCustomVaccination.Text = "Aşı Adı:";
            // 
            // lblVaccinationDate
            // 
            lblVaccinationDate.AutoSize = true;
            lblVaccinationDate.Location = new Point(22, 114);
            lblVaccinationDate.Name = "lblVaccinationDate";
            lblVaccinationDate.Size = new Size(71, 20);
            lblVaccinationDate.TabIndex = 2;
            lblVaccinationDate.Text = "Aşı Tarihi:";
            // 
            // lblVeterinarian
            // 
            lblVeterinarian.AutoSize = true;
            lblVeterinarian.Location = new Point(22, 187);
            lblVeterinarian.Name = "lblVeterinarian";
            lblVeterinarian.Size = new Size(71, 20);
            lblVeterinarian.TabIndex = 3;
            lblVeterinarian.Text = "Veteriner:";
            // 
            // lblBatchNumber
            // 
            lblBatchNumber.AutoSize = true;
            lblBatchNumber.Location = new Point(22, 225);
            lblBatchNumber.Name = "lblBatchNumber";
            lblBatchNumber.Size = new Size(118, 20);
            lblBatchNumber.TabIndex = 4;
            lblBatchNumber.Text = "Aşı Seri Numara:";
            // 
            // lblNextVaccinationDate
            // 
            lblNextVaccinationDate.AutoSize = true;
            lblNextVaccinationDate.Location = new Point(22, 263);
            lblNextVaccinationDate.Name = "lblNextVaccinationDate";
            lblNextVaccinationDate.Size = new Size(120, 20);
            lblNextVaccinationDate.TabIndex = 5;
            lblNextVaccinationDate.Text = "Sonraki Aşı Tarih:";
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(22, 147);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(79, 24);
            chkCompleted.TabIndex = 7;
            chkCompleted.Text = "Yapıldı.";
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AccessibleDescription = "chkHasNextDate";
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(22, 295);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(152, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Planlanan aşı var.  ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // cmbVaccinationType
            // 
            cmbVaccinationType.FormattingEnabled = true;
            cmbVaccinationType.Items.AddRange(new object[] { "Kuduz", "Karma", "Çiçek" });
            cmbVaccinationType.Location = new Point(153, 29);
            cmbVaccinationType.Name = "cmbVaccinationType";
            cmbVaccinationType.Size = new Size(243, 28);
            cmbVaccinationType.TabIndex = 9;
            cmbVaccinationType.SelectedIndexChanged += cmbVaccinationType_SelectedIndexChanged;
            // 
            // txtCustomVaccination
            // 
            txtCustomVaccination.Location = new Point(153, 63);
            txtCustomVaccination.Name = "txtCustomVaccination";
            txtCustomVaccination.Size = new Size(243, 27);
            txtCustomVaccination.TabIndex = 10;
            // 
            // dtpVaccinationDate
            // 
            dtpVaccinationDate.Location = new Point(153, 107);
            dtpVaccinationDate.Name = "dtpVaccinationDate";
            dtpVaccinationDate.Size = new Size(243, 27);
            dtpVaccinationDate.TabIndex = 11;
            // 
            // txtVeterinarian
            // 
            txtVeterinarian.Location = new Point(153, 180);
            txtVeterinarian.Name = "txtVeterinarian";
            txtVeterinarian.Size = new Size(243, 27);
            txtVeterinarian.TabIndex = 12;
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.Location = new Point(153, 218);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.Size = new Size(243, 27);
            txtBatchNumber.TabIndex = 13;
            // 
            // dtpNextVaccinationDate
            // 
            dtpNextVaccinationDate.Location = new Point(153, 256);
            dtpNextVaccinationDate.Name = "dtpNextVaccinationDate";
            dtpNextVaccinationDate.Size = new Size(243, 27);
            dtpNextVaccinationDate.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sticker113;
            pictureBox1.Location = new Point(403, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(217, 295);
            button1.Name = "button1";
            button1.Size = new Size(128, 50);
            button1.TabIndex = 16;
            button1.Text = "Aşı Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddVaccinationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 382);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dtpNextVaccinationDate);
            Controls.Add(txtBatchNumber);
            Controls.Add(txtVeterinarian);
            Controls.Add(dtpVaccinationDate);
            Controls.Add(txtCustomVaccination);
            Controls.Add(cmbVaccinationType);
            Controls.Add(checkBox2);
            Controls.Add(chkCompleted);
            Controls.Add(lblNextVaccinationDate);
            Controls.Add(lblBatchNumber);
            Controls.Add(lblVeterinarian);
            Controls.Add(lblVaccinationDate);
            Controls.Add(lblCustomVaccination);
            Controls.Add(lblVaccinationType);
            Name = "AddVaccinationForm";
            Text = "AddVaccinationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVaccinationType;
        private Label lblCustomVaccination;
        private Label lblVaccinationDate;
        private Label lblVeterinarian;
        private Label lblBatchNumber;
        private Label lblNextVaccinationDate;
        private Label label7;
        private CheckBox chkCompleted;
        private CheckBox checkBox2;
        private ComboBox cmbVaccinationType;
        private TextBox txtCustomVaccination;
        private DateTimePicker dtpVaccinationDate;
        private TextBox txtVeterinarian;
        private TextBox txtBatchNumber;
        private DateTimePicker dtpNextVaccinationDate;
        private PictureBox pictureBox1;
        private Button button1;
    }
}