using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;

namespace ProjectBirdsz
{
    public partial class RegisterForm : Form
    {
        private string ExcelFilePath;
        public RegisterForm()
        {
            InitializeComponent();
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "users.xlsx");

        }



        private bool SaveUserToExcel(string username, string password, string Id)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            // Check if username already exists
            for (int row = 2; row <= range.Rows.Count; row++)
            {
                string existingUsername = Convert.ToString(range.Cells[row, 1].Value);
                if (existingUsername == username)
                {
                    MessageBox.Show("Username already exists.");
                    workbook.Close();
                    excelApp.Quit();
                    ReleaseObject(worksheet);
                    ReleaseObject(workbook);
                    ReleaseObject(excelApp);
                    return false;
                }
            }

            // Find the next available row in Excel
            int nextRow = range.Rows.Count + 1;

            // Save user information to Excel
            range.Cells[nextRow, 1].Value = username;
            range.Cells[nextRow, 2].Value = password;
            range.Cells[nextRow, 3].Value = Id;

            // Save the workbook
            workbook.Save();

            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);

            return true;
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

   

        private bool IsUsernameLegal(string username)
        {
            // Check if the username length is between 6 and 8 characters
            if (username.Length < 6 || username.Length > 8)
            { 
                MessageBox.Show("username length is between 6 and 8 characters.");
                return false;
            }

            int digitCount = 0;
            foreach (char c in username)
            {
                // Check if the character is a digit
                if (char.IsDigit(c))
                {
                    digitCount++;

                    // Check if the digit count exceeds 2
                    if (digitCount > 2)
                    {
                        MessageBox.Show("User name cannot contain more then 2 digits.");
                        return false;

                    }
                }
                // Check if the character is not a letter
                else if (!char.IsLetter(c))
                {
                    MessageBox.Show("User name most contain only numbers or letters.");
                    return false;
                }
            }

            // All conditions met, username is legal
            return true;
        }

        private bool IsPasswordValid(string password)
        {
            // Check if the password length is between 8 and 10 characters
            if (password.Length < 8 || password.Length > 10)
            {
                MessageBox.Show("Please enter password between 8 to 10 characters");
                return false;
            }

            // Check if the password contains at least one letter, one digit, and one special character
            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(c => !char.IsLetterOrDigit(c));
            if(!(hasLetter && hasDigit && hasSpecialChar)) { MessageBox.Show("Password most contain at least 1 letter, 1 digit and 1 special character "); }

            return hasLetter && hasDigit && hasSpecialChar;
        }

        private bool IsIdValid(string Id)
        {
            int len = Id.Length;
            //checking len of Id
            if (len != 9) 
            {
                return false; 
            }
            //confirm that  Id contains only digits 
            foreach(char c in Id)
            {
                if (!char.IsDigit(c)) 
                {
                    MessageBox.Show("Invaild id");
                    return false;
                }
            }
            return true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private string convertToLowerCase(string username)
        {
            return username.ToLower();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SignInForm obj = new SignInForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            bool success = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Id = IdTextBox.Text;

            if (IsUsernameLegal(username) && (IsPasswordValid(password)) && (IsIdValid(Id)))
            {
                success = SaveUserToExcel(convertToLowerCase(username), password, Id);
            }
            // Save user to Excel

            if (success)
            {
                MessageBox.Show("Registration successful!");
                SignInForm obj = new SignInForm();
                this.Hide();
                obj.Show();
              
            }
        }
    }
}
