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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        int StartP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartP += 1;
            MyProgress.Value = StartP;
            PresentageLbl.Text = StartP + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                SignInForm obj = new SignInForm();
                this.Hide();
                obj.Show();

            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
