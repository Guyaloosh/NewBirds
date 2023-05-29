﻿
namespace ProjectBirdsz
{
    partial class SearchBirdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBirdForm));
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtStrain = new System.Windows.Forms.TextBox();
            this.txtSubSpecies = new System.Windows.Forms.TextBox();
            this.txtdateOfBirth = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Backbuttom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtCageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(153, 137);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(125, 20);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // txtStrain
            // 
            this.txtStrain.Location = new System.Drawing.Point(153, 183);
            this.txtStrain.Name = "txtStrain";
            this.txtStrain.Size = new System.Drawing.Size(125, 20);
            this.txtStrain.TabIndex = 1;
            // 
            // txtSubSpecies
            // 
            this.txtSubSpecies.Location = new System.Drawing.Point(153, 222);
            this.txtSubSpecies.Name = "txtSubSpecies";
            this.txtSubSpecies.Size = new System.Drawing.Size(125, 20);
            this.txtSubSpecies.TabIndex = 2;
            // 
            // txtdateOfBirth
            // 
            this.txtdateOfBirth.Location = new System.Drawing.Point(153, 266);
            this.txtdateOfBirth.Name = "txtdateOfBirth";
            this.txtdateOfBirth.Size = new System.Drawing.Size(125, 20);
            this.txtdateOfBirth.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 352);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 53);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Bird";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Strain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sub Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of birth";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(294, 137);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(465, 185);
            this.dataGridView.TabIndex = 9;
            // 
            // Backbuttom
            // 
            this.Backbuttom.Location = new System.Drawing.Point(684, 400);
            this.Backbuttom.Name = "Backbuttom";
            this.Backbuttom.Size = new System.Drawing.Size(75, 23);
            this.Backbuttom.TabIndex = 10;
            this.Backbuttom.Text = "Back";
            this.Backbuttom.UseVisualStyleBackColor = true;
            this.Backbuttom.Click += new System.EventHandler(this.Backbuttom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Bird";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(684, 330);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean table";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtCageNumber
            // 
            this.txtCageNumber.Location = new System.Drawing.Point(153, 302);
            this.txtCageNumber.Name = "txtCageNumber";
            this.txtCageNumber.Size = new System.Drawing.Size(125, 20);
            this.txtCageNumber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cage Number";
            // 
            // SearchBirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCageNumber);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Backbuttom);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtdateOfBirth);
            this.Controls.Add(this.txtSubSpecies);
            this.Controls.Add(this.txtStrain);
            this.Controls.Add(this.txtSerialNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBirdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBirdForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtStrain;
        private System.Windows.Forms.TextBox txtSubSpecies;
        private System.Windows.Forms.TextBox txtdateOfBirth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Backbuttom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtCageNumber;
        private System.Windows.Forms.Label label6;
    }
}