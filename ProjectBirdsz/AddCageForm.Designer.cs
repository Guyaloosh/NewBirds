
namespace ProjectBirdsz
{
    partial class AddCageForm
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
            this.txtCageNumber = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllCagesBtn = new System.Windows.Forms.Button();
            this.btnSaveCage = new System.Windows.Forms.Button();
            this.EditCageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCageNumber
            // 
            this.txtCageNumber.Location = new System.Drawing.Point(904, 192);
            this.txtCageNumber.Name = "txtCageNumber";
            this.txtCageNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCageNumber.TabIndex = 0;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(904, 235);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 20);
            this.txtlength.TabIndex = 1;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(904, 279);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(100, 20);
            this.txtheight.TabIndex = 2;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(904, 327);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(100, 20);
            this.txtwidth.TabIndex = 3;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(904, 371);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cage Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1064, 509);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(93, 32);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CageNumber,
            this.Length,
            this.Height,
            this.Width,
            this.Material});
            this.dataGridView1.Location = new System.Drawing.Point(72, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 278);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CageNumber
            // 
            this.CageNumber.HeaderText = "CageNumber";
            this.CageNumber.Name = "CageNumber";
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // AllCagesBtn
            // 
            this.AllCagesBtn.Location = new System.Drawing.Point(72, 492);
            this.AllCagesBtn.Name = "AllCagesBtn";
            this.AllCagesBtn.Size = new System.Drawing.Size(97, 37);
            this.AllCagesBtn.TabIndex = 19;
            this.AllCagesBtn.Text = "Show cages";
            this.AllCagesBtn.UseVisualStyleBackColor = true;
            this.AllCagesBtn.Click += new System.EventHandler(this.AllCagesBtn_Click);
            // 
            // btnSaveCage
            // 
            this.btnSaveCage.Location = new System.Drawing.Point(749, 439);
            this.btnSaveCage.Name = "btnSaveCage";
            this.btnSaveCage.Size = new System.Drawing.Size(108, 40);
            this.btnSaveCage.TabIndex = 20;
            this.btnSaveCage.Text = "Save Cage";
            this.btnSaveCage.UseVisualStyleBackColor = true;
            this.btnSaveCage.Click += new System.EventHandler(this.btnSaveCage_Click);
            // 
            // EditCageBtn
            // 
            this.EditCageBtn.Location = new System.Drawing.Point(904, 439);
            this.EditCageBtn.Name = "EditCageBtn";
            this.EditCageBtn.Size = new System.Drawing.Size(101, 40);
            this.EditCageBtn.TabIndex = 21;
            this.EditCageBtn.Text = "Edit Cage";
            this.EditCageBtn.UseVisualStyleBackColor = true;
            this.EditCageBtn.Click += new System.EventHandler(this.EditCageBtn_Click);
            // 
            // AddCageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 568);
            this.Controls.Add(this.EditCageBtn);
            this.Controls.Add(this.btnSaveCage);
            this.Controls.Add(this.AllCagesBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.txtCageNumber);
            this.Name = "AddCageForm";
            this.Text = "AddCageForm";
            this.Load += new System.EventHandler(this.AddCageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCageNumber;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.Button AllCagesBtn;
        private System.Windows.Forms.Button btnSaveCage;
        private System.Windows.Forms.Button EditCageBtn;
    }
}