using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBirdsz
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void AddBirdFoamBtn_Click(object sender, EventArgs e)
        {
            AddBirdForm obj = new AddBirdForm();
            this.Hide();
            obj.Show();
        }

        private void AddCageFormBtn_Click(object sender, EventArgs e)
        {
            AddCageForm obj = new AddCageForm();
            this.Hide();
            obj.Show();
        }
    }
}
