namespace PetTakipp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblName = new Label();
            lblType = new Label();
            lblBreed = new Label();
            lblWeight = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblOwner = new Label();
            lblBirthDate = new Label();
            lblColor = new Label();
            lblMicrochip = new Label();
            txtMicrochip = new TextBox();
            txtName = new TextBox();
            cmbType = new ComboBox();
            txtBreed = new TextBox();
            numAge = new NumericUpDown();
            cmbGender = new ComboBox();
            numWeight = new NumericUpDown();
            txtColor = new TextBox();
            dtpBirthDate = new DateTimePicker();
            txtOwner = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lstVaccination = new ListBox();
            lstTreatment = new ListBox();
            btnAddVaccination = new Button();
            btnAddTreatment = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Pet Ad:";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(24, 68);
            lblType.Name = "lblType";
            lblType.Size = new Size(33, 20);
            lblType.TabIndex = 1;
            lblType.Text = "Tür:";
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(24, 102);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(39, 20);
            lblBreed.TabIndex = 2;
            lblBreed.Text = "Cins:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(24, 209);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(85, 20);
            lblWeight.TabIndex = 5;
            lblWeight.Text = "Ağırlık (kg):";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(24, 175);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Cinsiyet:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(24, 138);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Yaş:";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Location = new Point(24, 318);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(53, 20);
            lblOwner.TabIndex = 8;
            lblOwner.Text = "Sahibi:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(24, 284);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(105, 20);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Doğum Tarihi: ";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(24, 247);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(44, 20);
            lblColor.TabIndex = 6;
            lblColor.Text = "Renk:";
            // 
            // lblMicrochip
            // 
            lblMicrochip.AutoSize = true;
            lblMicrochip.Location = new Point(24, 351);
            lblMicrochip.Name = "lblMicrochip";
            lblMicrochip.Size = new Size(129, 20);
            lblMicrochip.TabIndex = 9;
            lblMicrochip.Text = "MikroÇip Numara:";
            // 
            // txtMicrochip
            // 
            txtMicrochip.Location = new Point(159, 344);
            txtMicrochip.Name = "txtMicrochip";
            txtMicrochip.Size = new Size(229, 27);
            txtMicrochip.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 11;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Köpek", "Kedi", "Kuş" });
            cmbType.Location = new Point(159, 60);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(229, 28);
            cmbType.TabIndex = 12;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(159, 95);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(229, 27);
            txtBreed.TabIndex = 13;
            // 
            // numAge
            // 
            numAge.Location = new Point(159, 131);
            numAge.Name = "numAge";
            numAge.Size = new Size(99, 27);
            numAge.TabIndex = 14;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Dişi", "Erkek" });
            cmbGender.Location = new Point(159, 167);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(229, 28);
            cmbGender.TabIndex = 15;
            // 
            // numWeight
            // 
            numWeight.Location = new Point(159, 202);
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(99, 27);
            numWeight.TabIndex = 16;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(159, 240);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(229, 27);
            txtColor.TabIndex = 17;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(159, 277);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(229, 27);
            dtpBirthDate.TabIndex = 18;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(159, 311);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(229, 27);
            txtOwner.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(159, 387);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 49);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Pet Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(274, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 49);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(215, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 49);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(411, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(853, 347);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sticker28;
            pictureBox1.Location = new Point(1270, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1272, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 276);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 387);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 26;
            label1.Text = "Aşı Takip:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 387);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 27;
            label2.Text = "Tedavi Takip:";
            // 
            // lstVaccination
            // 
            lstVaccination.FormattingEnabled = true;
            lstVaccination.Location = new Point(411, 420);
            lstVaccination.Name = "lstVaccination";
            lstVaccination.Size = new Size(816, 84);
            lstVaccination.TabIndex = 28;
            // 
            // lstTreatment
            // 
            lstTreatment.FormattingEnabled = true;
            lstTreatment.Location = new Point(411, 534);
            lstTreatment.Name = "lstTreatment";
            lstTreatment.Size = new Size(816, 84);
            lstTreatment.TabIndex = 29;
            // 
            // btnAddVaccination
            // 
            btnAddVaccination.Location = new Point(586, 633);
            btnAddVaccination.Name = "btnAddVaccination";
            btnAddVaccination.Size = new Size(136, 48);
            btnAddVaccination.TabIndex = 30;
            btnAddVaccination.Text = "Aşı Ekle";
            btnAddVaccination.UseVisualStyleBackColor = true;
            btnAddVaccination.Click += btnAddVaccination_Click;
            // 
            // btnAddTreatment
            // 
            btnAddTreatment.Location = new Point(777, 633);
            btnAddTreatment.Name = "btnAddTreatment";
            btnAddTreatment.Size = new Size(136, 48);
            btnAddTreatment.TabIndex = 31;
            btnAddTreatment.Text = "Tedavi Ekle";
            btnAddTreatment.UseVisualStyleBackColor = true;
            btnAddTreatment.Click += btnAddTreatment_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sticker116;
            pictureBox3.Location = new Point(9, 387);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 231);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 713);
            Controls.Add(pictureBox3);
            Controls.Add(btnAddTreatment);
            Controls.Add(btnAddVaccination);
            Controls.Add(lstTreatment);
            Controls.Add(lstVaccination);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtOwner);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtColor);
            Controls.Add(numWeight);
            Controls.Add(cmbGender);
            Controls.Add(numAge);
            Controls.Add(txtBreed);
            Controls.Add(cmbType);
            Controls.Add(txtName);
            Controls.Add(txtMicrochip);
            Controls.Add(lblMicrochip);
            Controls.Add(lblOwner);
            Controls.Add(lblBirthDate);
            Controls.Add(lblColor);
            Controls.Add(lblWeight);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblBreed);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Evcil Hayvan Takip Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblType;
        private Label lblBreed;
        private Label lblWeight;
        private Label lblGender;
        private Label lblAge;
        private Label lblOwner;
        private Label lblBirthDate;
        private Label lblColor;
        private Label lblMicrochip;
        private TextBox txtMicrochip;
        private TextBox txtName;
        private ComboBox cmbType;
        private TextBox txtBreed;
        private NumericUpDown numAge;
        private ComboBox cmbGender;
        private NumericUpDown numWeight;
        private TextBox txtColor;
        private DateTimePicker dtpBirthDate;
        private TextBox txtOwner;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private ListBox lstVaccination;
        private ListBox lstTreatment;
        private Button btnAddVaccination;
        private Button btnAddTreatment;
        private PictureBox pictureBox3;
    }
}
