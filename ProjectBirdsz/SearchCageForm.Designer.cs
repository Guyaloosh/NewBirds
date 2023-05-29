﻿
namespace ProjectBirdsz
{
    partial class SearchCageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCageForm));
            this.btnClean = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Backbuttom = new System.Windows.Forms.Button();
            this.dataGridViewCages = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtCageSerialNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewBirds = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(686, 259);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 25;
            this.btnClean.Text = "Clean table";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 41);
            this.label5.TabIndex = 24;
            this.label5.Text = "Search Cage";
            // 
            // Backbuttom
            // 
            this.Backbuttom.Location = new System.Drawing.Point(775, 473);
            this.Backbuttom.Name = "Backbuttom";
            this.Backbuttom.Size = new System.Drawing.Size(75, 23);
            this.Backbuttom.TabIndex = 23;
            this.Backbuttom.Text = "Back";
            this.Backbuttom.UseVisualStyleBackColor = true;
            this.Backbuttom.Click += new System.EventHandler(this.Backbuttom_Click_1);
            // 
            // dataGridViewCages
            // 
            this.dataGridViewCages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCages.Location = new System.Drawing.Point(435, 139);
            this.dataGridViewCages.Name = "dataGridViewCages";
            this.dataGridViewCages.RowHeadersWidth = 82;
            this.dataGridViewCages.Size = new System.Drawing.Size(375, 114);
            this.dataGridViewCages.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(132, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Serial Number cage";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 53);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search Cage";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(229, 191);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(125, 20);
            this.txtMaterial.TabIndex = 14;
            // 
            // txtCageSerialNumber
            // 
            this.txtCageSerialNumber.Location = new System.Drawing.Point(229, 152);
            this.txtCageSerialNumber.Name = "txtCageSerialNumber";
            this.txtCageSerialNumber.Size = new System.Drawing.Size(125, 20);
            this.txtCageSerialNumber.TabIndex = 13;
            // 
            // dataGridViewBirds
            // 
            this.dataGridViewBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirds.Location = new System.Drawing.Point(435, 318);
            this.dataGridViewBirds.Name = "dataGridViewBirds";
            this.dataGridViewBirds.RowHeadersWidth = 82;
            this.dataGridViewBirds.Size = new System.Drawing.Size(375, 114);
            this.dataGridViewBirds.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(367, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cage : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(263, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Birds in the cage : ";
            // 
            // SearchCageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBirds);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Backbuttom);
            this.Controls.Add(this.dataGridViewCages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtCageSerialNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchCageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCageForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Backbuttom;
        private System.Windows.Forms.DataGridView dataGridViewCages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtCageSerialNumber;
        private System.Windows.Forms.DataGridView dataGridViewBirds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}