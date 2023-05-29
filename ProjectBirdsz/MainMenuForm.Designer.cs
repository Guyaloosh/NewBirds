
namespace ProjectBirdsz
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.AddBirdFoamBtn = new System.Windows.Forms.Button();
            this.AddCageFormBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBirdFoamBtn
            // 
            this.AddBirdFoamBtn.Location = new System.Drawing.Point(722, 293);
            this.AddBirdFoamBtn.Name = "AddBirdFoamBtn";
            this.AddBirdFoamBtn.Size = new System.Drawing.Size(168, 77);
            this.AddBirdFoamBtn.TabIndex = 0;
            this.AddBirdFoamBtn.Text = "Add Bird";
            this.AddBirdFoamBtn.UseVisualStyleBackColor = true;
            this.AddBirdFoamBtn.Click += new System.EventHandler(this.AddBirdFoamBtn_Click);
            // 
            // AddCageFormBtn
            // 
            this.AddCageFormBtn.Location = new System.Drawing.Point(539, 292);
            this.AddCageFormBtn.Name = "AddCageFormBtn";
            this.AddCageFormBtn.Size = new System.Drawing.Size(167, 79);
            this.AddCageFormBtn.TabIndex = 1;
            this.AddCageFormBtn.Text = "Add Cage";
            this.AddCageFormBtn.UseVisualStyleBackColor = true;
            this.AddCageFormBtn.Click += new System.EventHandler(this.AddCageFormBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search Bird";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search Cage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(405, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main menu : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(952, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddCageFormBtn);
            this.Controls.Add(this.AddBirdFoamBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBirdFoamBtn;
        private System.Windows.Forms.Button AddCageFormBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}