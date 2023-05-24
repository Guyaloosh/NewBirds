
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
            this.AddBirdFoamBtn = new System.Windows.Forms.Button();
            this.AddCageFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBirdFoamBtn
            // 
            this.AddBirdFoamBtn.Location = new System.Drawing.Point(518, 131);
            this.AddBirdFoamBtn.Name = "AddBirdFoamBtn";
            this.AddBirdFoamBtn.Size = new System.Drawing.Size(168, 77);
            this.AddBirdFoamBtn.TabIndex = 0;
            this.AddBirdFoamBtn.Text = "Add Bird";
            this.AddBirdFoamBtn.UseVisualStyleBackColor = true;
            this.AddBirdFoamBtn.Click += new System.EventHandler(this.AddBirdFoamBtn_Click);
            // 
            // AddCageFormBtn
            // 
            this.AddCageFormBtn.Location = new System.Drawing.Point(518, 262);
            this.AddCageFormBtn.Name = "AddCageFormBtn";
            this.AddCageFormBtn.Size = new System.Drawing.Size(167, 79);
            this.AddCageFormBtn.TabIndex = 1;
            this.AddCageFormBtn.Text = "Add Cage";
            this.AddCageFormBtn.UseVisualStyleBackColor = true;
            this.AddCageFormBtn.Click += new System.EventHandler(this.AddCageFormBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCageFormBtn);
            this.Controls.Add(this.AddBirdFoamBtn);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBirdFoamBtn;
        private System.Windows.Forms.Button AddCageFormBtn;
    }
}