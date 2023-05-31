using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ProjectBirdsz
{
    public partial class SignInForm : Form
    {
        private string ExcelFilePath; // Path to the Excel file

        public SignInForm()
        {
            InitializeComponent();

            // Set the Excel file path relative to the project's directory
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "users.xlsx");

            // Create the Excel file if it doesn't exist
            if (!File.Exists(ExcelFilePath))
            {
                CreateExcelFile();
            }
        }
        private void CreateExcelFile()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Add column headers or any initial data
            worksheet.Cells[1, 1].Value = "Username";
            worksheet.Cells[1, 2].Value = "Password";

            // Save and close the workbook
            workbook.SaveAs(ExcelFilePath);
            workbook.Close();
            excelApp.Quit();

            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

       


        private bool CheckUserAuth(string username, string password)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            bool userExists = false;
            bool passwordinv = false;
            bool userinv = false;
            bool vialdLogin = false;
            // Iterate over the Excel rows to check for a matching username and password
            for (int row = 2; row <= range.Rows.Count; row++)
            {
                string storedUsername = range.Cells[row, 1].Value?.ToString();
                string storedPassword = range.Cells[row, 2].Value?.ToString();

                if (storedUsername == username )
                {
                    userExists = true;  
                    if(storedPassword == password)
                    {
                        passwordinv = true;
                        vialdLogin = true;      
                    }
    
                }
                if (storedUsername != username && storedPassword == password)
                {
                    passwordinv = true;
                    userinv = true;
                }
            }
            string msg = "Error ";
            if (userExists == false && passwordinv == false) { msg += ", user not found"; }
            if (userinv == true && passwordinv == true) { msg += ", username inviald"; }
            if (passwordinv == false) { msg += ", password inviald"; }

            if (vialdLogin == false)
                MessageBox.Show(msg);
            
            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);

            return vialdLogin;
        }

        // Helper method to release COM objects
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occurred while releasing object: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string convertToLowerCase(string username)
        {
            return username.ToLower();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check user existence in Excel
            bool Auth = CheckUserAuth(convertToLowerCase(username), password);
            if (Auth)
            {
                MessageBox.Show("Sign in successful!");
                // Perform any additional actions for successful sign-in
                MainMenuForm obj = new MainMenuForm();
                this.Hide();
                obj.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RegisterForm obj = new RegisterForm();
            this.Hide();
            obj.Show();
        }
    }
}
