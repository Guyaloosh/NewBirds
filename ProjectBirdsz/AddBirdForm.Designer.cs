﻿
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
            this.txtSerialBirds = new System.Windows.Forms.TextBox();
            this.txtStrain = new System.Windows.Forms.TextBox();
            this.txtSubSpecies = new System.Windows.Forms.TextBox();
            this.txtDateOfBird = new System.Windows.Forms.TextBox();
            this.txtCageNumber = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
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
            this.btnSaveBird = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AllBirdsBtn = new System.Windows.Forms.Button();
            this.EditBirdBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialBirds
            // 
            this.txtSerialBirds.Location = new System.Drawing.Point(243, 186);
            this.txtSerialBirds.Name = "txtSerialBirds";
            this.txtSerialBirds.Size = new System.Drawing.Size(144, 20);
            this.txtSerialBirds.TabIndex = 0;
            this.txtSerialBirds.TextChanged += new System.EventHandler(this.txtSerialBirds_TextChanged);
            // 
            // txtStrain
            // 
            this.txtStrain.Location = new System.Drawing.Point(243, 227);
            this.txtStrain.Name = "txtStrain";
            this.txtStrain.Size = new System.Drawing.Size(144, 20);
            this.txtStrain.TabIndex = 1;
            // 
            // txtSubSpecies
            // 
            this.txtSubSpecies.Location = new System.Drawing.Point(243, 268);
            this.txtSubSpecies.Name = "txtSubSpecies";
            this.txtSubSpecies.Size = new System.Drawing.Size(144, 20);
            this.txtSubSpecies.TabIndex = 2;
            // 
            // txtDateOfBird
            // 
            this.txtDateOfBird.Location = new System.Drawing.Point(243, 310);
            this.txtDateOfBird.Name = "txtDateOfBird";
            this.txtDateOfBird.Size = new System.Drawing.Size(144, 20);
            this.txtDateOfBird.TabIndex = 3;
            // 
            // txtCageNumber
            // 
            this.txtCageNumber.Location = new System.Drawing.Point(243, 394);
            this.txtCageNumber.Name = "txtCageNumber";
            this.txtCageNumber.Size = new System.Drawing.Size(144, 20);
            this.txtCageNumber.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(243, 352);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(144, 20);
            this.txtGender.TabIndex = 4;
            // 
            // txtMotherSerialNumber
            // 
            this.txtMotherSerialNumber.Location = new System.Drawing.Point(243, 471);
            this.txtMotherSerialNumber.Name = "txtMotherSerialNumber";
            this.txtMotherSerialNumber.Size = new System.Drawing.Size(144, 20);
            this.txtMotherSerialNumber.TabIndex = 7;
            // 
            // txtFatherSerialNumber
            // 
            this.txtFatherSerialNumber.Location = new System.Drawing.Point(243, 429);
            this.txtFatherSerialNumber.Name = "txtFatherSerialNumber";
            this.txtFatherSerialNumber.Size = new System.Drawing.Size(144, 20);
            this.txtFatherSerialNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(118, 186);
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
            this.Strain.Location = new System.Drawing.Point(167, 223);
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
            this.label3.Location = new System.Drawing.Point(106, 264);
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
            this.label4.Location = new System.Drawing.Point(110, 306);
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
            this.label5.Location = new System.Drawing.Point(151, 348);
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
            this.label6.Location = new System.Drawing.Point(97, 390);
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
            this.label7.Location = new System.Drawing.Point(36, 429);
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
            this.label8.Location = new System.Drawing.Point(32, 467);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(193, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mother Serial Number";
            // 
            // btnSaveBird
            // 
            this.btnSaveBird.Location = new System.Drawing.Point(83, 575);
            this.btnSaveBird.Name = "btnSaveBird";
            this.btnSaveBird.Size = new System.Drawing.Size(123, 57);
            this.btnSaveBird.TabIndex = 16;
            this.btnSaveBird.Text = "Save Bird";
            this.btnSaveBird.UseVisualStyleBackColor = true;
            this.btnSaveBird.Click += new System.EventHandler(this.btnSaveBird_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(461, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 305);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // AllBirdsBtn
            // 
            this.AllBirdsBtn.Location = new System.Drawing.Point(1348, 507);
            this.AllBirdsBtn.Name = "AllBirdsBtn";
            this.AllBirdsBtn.Size = new System.Drawing.Size(97, 37);
            this.AllBirdsBtn.TabIndex = 18;
            this.AllBirdsBtn.Text = "Show Birds";
            this.AllBirdsBtn.UseVisualStyleBackColor = true;
            this.AllBirdsBtn.Click += new System.EventHandler(this.AllBirdsBtn_Click);
            // 
            // EditBirdBtn
            // 
            this.EditBirdBtn.Location = new System.Drawing.Point(243, 575);
            this.EditBirdBtn.Name = "EditBirdBtn";
            this.EditBirdBtn.Size = new System.Drawing.Size(131, 57);
            this.EditBirdBtn.TabIndex = 19;
            this.EditBirdBtn.Text = "Save Changes";
            this.EditBirdBtn.UseVisualStyleBackColor = true;
            this.EditBirdBtn.Click += new System.EventHandler(this.EditBirdBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1368, 667);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(77, 34);
            this.BackBtn.TabIndex = 20;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SerialBirds
            // 
            this.SerialBirds.HeaderText = "SerialBirds";
            this.SerialBirds.Name = "SerialBirds";
            this.SerialBirds.Width = 120;
            // 
            // StrainBird
            // 
            this.StrainBird.HeaderText = "Strain";
            this.StrainBird.Name = "StrainBird";
            // 
            // SubSpecies
            // 
            this.SubSpecies.HeaderText = "SubSpecies";
            this.SubSpecies.Name = "SubSpecies";
            // 
            // DateOfBird
            // 
            this.DateOfBird.FillWeight = 110F;
            this.DateOfBird.HeaderText = "DateOfBird";
            this.DateOfBird.Name = "DateOfBird";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // CageNumber
            // 
            this.CageNumber.HeaderText = "CageNumber";
            this.CageNumber.Name = "CageNumber";
            // 
            // FatherSerialNumber
            // 
            this.FatherSerialNumber.HeaderText = "FatherSerialNumber";
            this.FatherSerialNumber.Name = "FatherSerialNumber";
            // 
            // MotherSerialNumber
            // 
            this.MotherSerialNumber.HeaderText = "MotherSerialNumber";
            this.MotherSerialNumber.Name = "MotherSerialNumber";
            this.MotherSerialNumber.Width = 130;
            // 
            // AddBirdLabel
            // 
            this.AddBirdLabel.AutoSize = true;
            this.AddBirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddBirdLabel.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBirdLabel.Location = new System.Drawing.Point(583, 54);
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
            this.label2.Location = new System.Drawing.Point(166, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Details : ";
            // 
            // AddBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 747);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBirdLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBirdBtn);
            this.Controls.Add(this.AllBirdsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveBird);
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
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDateOfBird);
            this.Controls.Add(this.txtSubSpecies);
            this.Controls.Add(this.txtStrain);
            this.Controls.Add(this.txtSerialBirds);
            this.Name = "AddBirdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBirdForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialBirds;
        private System.Windows.Forms.TextBox txtStrain;
        private System.Windows.Forms.TextBox txtSubSpecies;
        private System.Windows.Forms.TextBox txtDateOfBird;
        private System.Windows.Forms.TextBox txtCageNumber;
        private System.Windows.Forms.TextBox txtGender;
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
        private System.Windows.Forms.Button btnSaveBird;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AllBirdsBtn;
        private System.Windows.Forms.Button EditBirdBtn;
        private System.Windows.Forms.Button BackBtn;
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
    }
}