using System;
using System.Windows.Forms;

namespace ProjectBirdsz
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddCageForm obj = new AddCageForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddBirdForm obj = new AddBirdForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SearchBirdForm obj = new SearchBirdForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            SearchCageForm obj = new SearchCageForm();
            this.Hide();
            obj.Show();
        }
    }
}
