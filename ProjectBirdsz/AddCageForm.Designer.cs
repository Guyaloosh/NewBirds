
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCageForm));
            this.txtCageNumber = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCageNumber
            // 
            this.txtCageNumber.Location = new System.Drawing.Point(241, 199);
            this.txtCageNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCageNumber.Name = "txtCageNumber";
            this.txtCageNumber.Size = new System.Drawing.Size(132, 22);
            this.txtCageNumber.TabIndex = 0;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(241, 252);
            this.txtlength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(132, 22);
            this.txtlength.TabIndex = 1;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(241, 306);
            this.txtheight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(132, 22);
            this.txtheight.TabIndex = 2;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(241, 366);
            this.txtwidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(132, 22);
            this.txtwidth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cage Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1223, 615);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(124, 39);
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
            this.dataGridView1.Location = new System.Drawing.Point(551, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(724, 287);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CageNumber
            // 
            this.CageNumber.HeaderText = "CageNumber";
            this.CageNumber.MinimumWidth = 6;
            this.CageNumber.Name = "CageNumber";
            this.CageNumber.Width = 125;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.Width = 125;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.Width = 125;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.Width = 125;
            // 
            // AllCagesBtn
            // 
            this.AllCagesBtn.Location = new System.Drawing.Point(1145, 466);
            this.AllCagesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllCagesBtn.Name = "AllCagesBtn";
            this.AllCagesBtn.Size = new System.Drawing.Size(129, 46);
            this.AllCagesBtn.TabIndex = 19;
            this.AllCagesBtn.Text = "Show cages";
            this.AllCagesBtn.UseVisualStyleBackColor = true;
            this.AllCagesBtn.Click += new System.EventHandler(this.AllCagesBtn_Click);
            // 
            // btnSaveCage
            // 
            this.btnSaveCage.Location = new System.Drawing.Point(87, 554);
            this.btnSaveCage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveCage.Name = "btnSaveCage";
            this.btnSaveCage.Size = new System.Drawing.Size(144, 49);
            this.btnSaveCage.TabIndex = 20;
            this.btnSaveCage.Text = "Save Cage";
            this.btnSaveCage.UseVisualStyleBackColor = true;
            this.btnSaveCage.Click += new System.EventHandler(this.btnSaveCage_Click);
            // 
            // EditCageBtn
            // 
            this.EditCageBtn.Location = new System.Drawing.Point(293, 554);
            this.EditCageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCageBtn.Name = "EditCageBtn";
            this.EditCageBtn.Size = new System.Drawing.Size(135, 49);
            this.EditCageBtn.TabIndex = 21;
            this.EditCageBtn.Text = "Edit Cage";
            this.EditCageBtn.UseVisualStyleBackColor = true;
            this.EditCageBtn.Click += new System.EventHandler(this.EditCageBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(660, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 52);
            this.label6.TabIndex = 22;
            this.label6.Text = "Add Cage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Details : ";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.AllowDrop = true;
            this.MaterialComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Wood",
            "Plastic",
            "Metal"});
            this.MaterialComboBox.Location = new System.Drawing.Point(241, 421);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(132, 24);
            this.MaterialComboBox.TabIndex = 24;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox_SelectedIndexChanged);
            // 
            // AddCageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1363, 670);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.txtCageNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MaterialComboBox;
    }
}