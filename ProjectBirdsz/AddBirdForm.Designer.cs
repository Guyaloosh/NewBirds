
namespace ProjectBirdsz
{
    partial class AddBirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBirdForm));
            this.txtSerialBirds = new System.Windows.Forms.TextBox();
            this.txtCageNumber = new System.Windows.Forms.TextBox();
            this.txtMotherSerialNumber = new System.Windows.Forms.TextBox();
            this.txtFatherSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Strain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialBirds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrainBird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBirdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialBirds
            // 
            this.txtSerialBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSerialBirds.Location = new System.Drawing.Point(235, 186);
            this.txtSerialBirds.Name = "txtSerialBirds";
            this.txtSerialBirds.Size = new System.Drawing.Size(144, 22);
            this.txtSerialBirds.TabIndex = 0;
            this.txtSerialBirds.TextChanged += new System.EventHandler(this.txtSerialBirds_TextChanged);
            // 
            // txtCageNumber
            // 
            this.txtCageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCageNumber.Location = new System.Drawing.Point(235, 394);
            this.txtCageNumber.Name = "txtCageNumber";
            this.txtCageNumber.Size = new System.Drawing.Size(144, 22);
            this.txtCageNumber.TabIndex = 5;
            // 
            // txtMotherSerialNumber
            // 
            this.txtMotherSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMotherSerialNumber.Location = new System.Drawing.Point(235, 471);
            this.txtMotherSerialNumber.Name = "txtMotherSerialNumber";
            this.txtMotherSerialNumber.Size = new System.Drawing.Size(144, 22);
            this.txtMotherSerialNumber.TabIndex = 7;
            // 
            // txtFatherSerialNumber
            // 
            this.txtFatherSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFatherSerialNumber.Location = new System.Drawing.Point(235, 429);
            this.txtFatherSerialNumber.Name = "txtFatherSerialNumber";
            this.txtFatherSerialNumber.Size = new System.Drawing.Size(144, 22);
            this.txtFatherSerialNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(110, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Serial Birds";
            // 
            // Strain
            // 
            this.Strain.AutoSize = true;
            this.Strain.BackColor = System.Drawing.Color.Transparent;
            this.Strain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Strain.ForeColor = System.Drawing.SystemColors.Control;
            this.Strain.Location = new System.Drawing.Point(159, 223);
            this.Strain.Name = "Strain";
            this.Strain.Size = new System.Drawing.Size(58, 22);
            this.Strain.TabIndex = 9;
            this.Strain.Text = "Strain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(98, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sub Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(102, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Bird";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(143, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(89, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cage Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(28, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Father Serial Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(24, 467);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(193, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mother Serial Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialBirds,
            this.StrainBird,
            this.SubSpecies,
            this.DateOfBird,
            this.Gender,
            this.CageNumber,
            this.FatherSerialNumber,
            this.MotherSerialNumber});
            this.dataGridView1.Location = new System.Drawing.Point(405, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(560, 306);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SerialBirds
            // 
            this.SerialBirds.HeaderText = "SerialBirds";
            this.SerialBirds.MinimumWidth = 10;
            this.SerialBirds.Name = "SerialBirds";
            this.SerialBirds.Width = 120;
            // 
            // StrainBird
            // 
            this.StrainBird.HeaderText = "Strain";
            this.StrainBird.MinimumWidth = 10;
            this.StrainBird.Name = "StrainBird";
            this.StrainBird.Width = 200;
            // 
            // SubSpecies
            // 
            this.SubSpecies.HeaderText = "SubSpecies";
            this.SubSpecies.MinimumWidth = 10;
            this.SubSpecies.Name = "SubSpecies";
            this.SubSpecies.Width = 200;
            // 
            // DateOfBird
            // 
            this.DateOfBird.FillWeight = 110F;
            this.DateOfBird.HeaderText = "DateOfBird";
            this.DateOfBird.MinimumWidth = 10;
            this.DateOfBird.Name = "DateOfBird";
            this.DateOfBird.Width = 200;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 10;
            this.Gender.Name = "Gender";
            this.Gender.Width = 200;
            // 
            // CageNumber
            // 
            this.CageNumber.HeaderText = "CageNumber";
            this.CageNumber.MinimumWidth = 10;
            this.CageNumber.Name = "CageNumber";
            this.CageNumber.Width = 200;
            // 
            // FatherSerialNumber
            // 
            this.FatherSerialNumber.HeaderText = "FatherSerialNumber";
            this.FatherSerialNumber.MinimumWidth = 10;
            this.FatherSerialNumber.Name = "FatherSerialNumber";
            this.FatherSerialNumber.Width = 200;
            // 
            // MotherSerialNumber
            // 
            this.MotherSerialNumber.HeaderText = "MotherSerialNumber";
            this.MotherSerialNumber.MinimumWidth = 10;
            this.MotherSerialNumber.Name = "MotherSerialNumber";
            this.MotherSerialNumber.Width = 130;
            // 
            // AddBirdLabel
            // 
            this.AddBirdLabel.AutoSize = true;
            this.AddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddBirdLabel.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBirdLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddBirdLabel.Location = new System.Drawing.Point(501, 34);
            this.AddBirdLabel.Name = "AddBirdLabel";
            this.AddBirdLabel.Size = new System.Drawing.Size(203, 41);
            this.AddBirdLabel.TabIndex = 21;
            this.AddBirdLabel.Text = "Add Bird : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(109, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Details : ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(235, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 23);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Male";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(317, 344);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 23);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Female";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Golden Amrican",
            "Golden European",
            "Golden Australian "});
            this.comboBox1.Location = new System.Drawing.Point(235, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Golden Amrican",
            "Golden European",
            "Golden Australian "});
            this.comboBox2.Location = new System.Drawing.Point(235, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(235, 306);
            this.DateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(144, 20);
            this.DateOfBirth.TabIndex = 27;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(200, 521);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(98, 22);
            this.ClearBtn.TabIndex = 28;
            this.ClearBtn.Text = "Clear fields";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Visible = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(939, 568);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(845, 494);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(280, 553);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(114, 553);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AddBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1090, 648);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBirdLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Strain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotherSerialNumber);
            this.Controls.Add(this.txtFatherSerialNumber);
            this.Controls.Add(this.txtCageNumber);
            this.Controls.Add(this.txtSerialBirds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBirdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBirdForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialBirds;
        private System.Windows.Forms.TextBox txtCageNumber;
        private System.Windows.Forms.TextBox txtMotherSerialNumber;
        private System.Windows.Forms.TextBox txtFatherSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Strain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialBirds;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrainBird;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBird;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherSerialNumber;
        private System.Windows.Forms.Label AddBirdLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}