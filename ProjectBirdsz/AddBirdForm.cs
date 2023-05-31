using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace ProjectBirdsz
{
    public partial class AddBirdForm : Form
    {
        private string ExcelFilePath;
        private string ExcelCagesFilePath;
        private DataGridView dataGridView;
        private string Gender1;
        private string BirdKind;
        private string SubBirdKind;
        private string birdDate;
        DateTime thisDay = DateTime.Today.AddDays(1);





        public AddBirdForm()
        {

            InitializeComponent();
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "birds.xlsx");
            ExcelCagesFilePath = Path.Combine(projectDirectory, "cages.xlsx");
            dataGridView = dataGridView1;
            AddButtonColumn(); // Add the button column
            LoadBirdsFromExcel();
            dataGridView.CellDoubleClick += dataGridView1_CellDoubleClick;


        }

        private void AddButtonColumn()
        {
            // Remove existing button column if any
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column is DataGridViewButtonColumn && column.Name == "AddChickColumn")
                {
                    dataGridView.Columns.Remove(column);
                    break;
                }
            }

            // Add the button column to the DataGridView
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Add Chick";
            buttonColumn.Name = "AddChickColumn";
            buttonColumn.Text = "Add Chick";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(buttonColumn);
        }

        private void BirdForm_Load(object sender, EventArgs e)
        {
            LoadBirdsFromExcel();
        }

        private void LoadBirdsFromExcel()
        {
            if (!File.Exists(ExcelFilePath))
            {
                MessageBox.Show("Excel file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            int rowCount = range.Rows.Count;
            int columnCount = range.Columns.Count;

           

            // Set up the DataGridView columns
            dataGridView.ColumnCount = columnCount;
            for (int c = 1; c <= columnCount; c++)
            {
                dataGridView.Columns[c - 1].Name = Convert.ToString(range.Cells[1, c].Value);
            }

            // Populate the DataGridView with data from Excel
            for (int r = 2; r <= rowCount; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int c = 1; c <= columnCount; c++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = Convert.ToString(range.Cells[r, c].Value);
                    row.Cells.Add(cell);
                }
                dataGridView.Rows.Add(row);
               
            }
            AddButtonColumn();
            // Clean up Excel objects
          
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

        bool CheckBirthDay(DateTime BirthDay)
        {
            if (BirthDay > thisDay)
            {
                return false;
            }
            return true;
        }
        
      
        private bool SaveBirdToExcel(string SerialNumber, string BirdKind, string SubSpecies, string DateOfBirth, string Gender1, string CageNumber, string FatherSerialNumber, string MotherSerialNumber)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;


            // Find the next available row in Excel
            int nextRow = range.Rows.Count + 1;

            // Save birds information to Excel
            range.Cells[nextRow, 1].Value = SerialNumber;
            range.Cells[nextRow, 2].Value = BirdKind;
            range.Cells[nextRow, 3].Value = SubSpecies;
            range.Cells[nextRow, 4].Value = birdDate;
            range.Cells[nextRow, 5].Value = Gender1;
            range.Cells[nextRow, 6].Value = CageNumber;
            range.Cells[nextRow, 7].Value = FatherSerialNumber;
            range.Cells[nextRow, 8].Value = MotherSerialNumber;

            
   


            Excel.Range sortRange = worksheet.Range["A2:H" + nextRow];
            sortRange.Sort(sortRange.Columns[1], Excel.XlSortOrder.xlAscending, Type.Missing, Type.Missing, Excel.XlSortOrder.xlAscending,
                Type.Missing, Excel.XlSortOrder.xlAscending, Excel.XlYesNoGuess.xlNo, Type.Missing, Type.Missing, Excel.XlSortOrientation.xlSortColumns,
                Excel.XlSortMethod.xlPinYin, Excel.XlSortDataOption.xlSortNormal, Excel.XlSortDataOption.xlSortNormal,
                Excel.XlSortDataOption.xlSortNormal);

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

        private void ClearInputFields()
        {
            txtSerialBirds.Text = string.Empty;
            BirdKind = string.Empty;
            comboBox2.Text = string.Empty;
            DateOfBirth.Text = string.Empty;
            txtCageNumber.Text = string.Empty;
            txtFatherSerialNumber.Text = string.Empty;
            txtMotherSerialNumber.Text = string.Empty;
            txtMotherSerialNumber.Enabled = true;
            txtFatherSerialNumber.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            txtCageNumber.Enabled = true;
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Set the values of the text boxes based on the selected row
                txtSerialBirds.Text = Convert.ToString(selectedRow.Cells[0].Value);
                BirdKind = Convert.ToString(selectedRow.Cells[1].Value);
                comboBox2.Text = Convert.ToString(selectedRow.Cells[2].Value);
                birdDate = Convert.ToString(selectedRow.Cells[3].Value);
                Gender1 = Convert.ToString(selectedRow.Cells[4].Value);
                txtCageNumber.Text = Convert.ToString(selectedRow.Cells[5].Value);
                txtFatherSerialNumber.Text = Convert.ToString(selectedRow.Cells[6].Value);
                txtMotherSerialNumber.Text = Convert.ToString(selectedRow.Cells[7].Value);
            }
        }

        


        private void SaveChangesToExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int rowIndex = row.Index + 2; // Add 2 to skip the header row

                // Update the values in the Excel worksheet with the values from the DataGridView
                worksheet.Cells[rowIndex, 1].Value = row.Cells[0].Value;
                worksheet.Cells[rowIndex, 2].Value = row.Cells[1].Value;
                worksheet.Cells[rowIndex, 3].Value = row.Cells[2].Value;
                worksheet.Cells[rowIndex, 4].Value = row.Cells[3].Value;
                worksheet.Cells[rowIndex, 5].Value = row.Cells[4].Value;
                worksheet.Cells[rowIndex, 6].Value = row.Cells[5].Value;
                worksheet.Cells[rowIndex, 7].Value = row.Cells[6].Value;
                worksheet.Cells[rowIndex, 8].Value = row.Cells[7].Value;
            }

            // Save the workbook
            workbook.Save();

            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["AddChickColumn"].Index)
            {
                ClearBtn.Visible = true;
                // Button cell clicked for the Add Chick action
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Extract values from the selected row
                string serialBird = Convert.ToString(selectedRow.Cells[0].Value);
                string strain = Convert.ToString(selectedRow.Cells[1].Value);
                string subSpecies = Convert.ToString(selectedRow.Cells[2].Value);
                string BirdGender = Convert.ToString(selectedRow.Cells[4].Value);
                string CageNumber= Convert.ToString(selectedRow.Cells[5].Value);

                // Set the text box values
                if (BirdGender == "Male") {
                    txtFatherSerialNumber.Text = serialBird;
                    txtFatherSerialNumber.Enabled = false;
                    txtMotherSerialNumber.Enabled = true;
                    txtMotherSerialNumber.Text = "";
                }
                else
                {
               
                    txtMotherSerialNumber.Text = serialBird;
                    txtMotherSerialNumber.Enabled = false;
                    txtFatherSerialNumber.Enabled = true;
                    txtFatherSerialNumber.Text = "";
                }




                comboBox1.Text = strain;
                comboBox1.Enabled = false;
                
                comboBox2.Text = subSpecies;
                comboBox2.Enabled = false;

                txtCageNumber.Text = CageNumber;
                txtCageNumber.Enabled = false;

                // Clear the other text box values
                ClearInputFieldsForChick();

                MessageBox.Show("Add Chick ");
            }
        }

        private void ClearInputFieldsForChick()
        {
            // Clear all text boxes except for the ones already populated
            txtSerialBirds.Text = string.Empty;
            birdDate = string.Empty;
            Gender1 = string.Empty;
            //txtMotherSerialNumber.Text = string.Empty;
        }

        private void txtSerialBirds_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidateSerialNumber(string serialNumber)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            bool flag = true;
            for (int i = 2; i <= lastRow; i++)
            {
                Excel.Range BirdsSerial = worksheet.Cells[i, 1];
                if (BirdsSerial.Text == serialNumber) { flag = false; }
            }

            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);

            // Serial number should contain only digits
            return Regex.IsMatch(serialNumber, @"^\d+$")&&flag;
        }

        private bool ValidateSpecies(string species)
        {
            // Species should contain only letters
            return Regex.IsMatch(species, @"^[A-Za-z\s]+$");
        }

        private bool ValidateSubspecies(string subspecies)
        {
            // Subspecies should contain only letters
            return Regex.IsMatch(subspecies, @"^[A-Za-z\s]+$");
        }

        private bool ValidateCageNumber(string cageNumber)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelCagesFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            

            // Get the used range of cells in the cages worksheet
           // Excel.Range range = worksheet.UsedRange;
            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            bool flag = false;
            for (int i = 2; i <= lastRow;i++)
            {
                Excel.Range Cageserial = worksheet.Cells[i, 1];
                if(Cageserial.Text== cageNumber) { flag = true; }
                 
               
            }
            
            
            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);

            // Cage number should contain only letters and numbers
            return Regex.IsMatch(cageNumber, @"^[A-Za-z0-9]+$")&&flag;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            Gender1 = "Male";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            Gender1 = "Female";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox1.SelectedIndex==0){ 
                BirdKind = "Golden Amrican";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Notrh America");
                comboBox2.Items.Add("Central America");
                comboBox2.Items.Add("South America");
                
            }
            if (comboBox1.SelectedIndex == 1) {
                BirdKind = "Golden European";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("East Europe");
                comboBox2.Items.Add("West Europe");
            }
            if (comboBox1.SelectedIndex == 2) 
            { 
                BirdKind = "Golden Australian";
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Central Australia");
                comboBox2.Items.Add("Coastal cities");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            ClearBtn.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            LoadBirdsFromExcel();
            AddButtonColumn();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Update the values in the DataGridView row with the values from the text boxes
                selectedRow.Cells[0].Value = txtSerialBirds.Text;
                selectedRow.Cells[1].Value = comboBox1.Text;
                selectedRow.Cells[2].Value = comboBox2.Text;
                selectedRow.Cells[3].Value = birdDate;
                selectedRow.Cells[4].Value = Gender1;
                selectedRow.Cells[5].Value = txtCageNumber.Text;
                selectedRow.Cells[6].Value = txtFatherSerialNumber.Text;
                selectedRow.Cells[7].Value = txtMotherSerialNumber.Text;

                // Save the changes back to the Excel file
                SaveChangesToExcel();

                MessageBox.Show("Changes saved successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = DateOfBirth.Value;
            birdDate = selectedDate.ToString("yyyy-MM-dd");
            bool success = false;
            string SerialNumber = txtSerialBirds.Text;
            string Strain = comboBox1.Text;
            string SubSpecies = comboBox2.Text;
            string Gender = Gender1;
            string CageNumber = txtCageNumber.Text;
            string FatherSerialNumber = txtFatherSerialNumber.Text;
            string MotherSerialNumber = txtMotherSerialNumber.Text;


            if (!CheckBirthDay(selectedDate))
            {
                MessageBox.Show("Check date , cant be bigger then Today date");
                return;
            }

            if (!ValidateSerialNumber(SerialNumber))
            {
                MessageBox.Show("Invalid serial number. Please enter digits only, confirm that bird does not exist");
                return;
            }

            if (!ValidateSpecies(Strain))
            {
                MessageBox.Show("Invalid strain. Please enter letters only.");
                return;
            }

            if (!ValidateSubspecies(SubSpecies))
            {
                MessageBox.Show("Invalid subspecies. Please enter letters only.");
                return;
            }

            if (!ValidateCageNumber(CageNumber))
            {
                MessageBox.Show("Invalid Cage Number. Please enter an existing cage number .");
                return;
            }

            success = SaveBirdToExcel(SerialNumber, Strain, SubSpecies, birdDate, Gender, CageNumber, FatherSerialNumber, MotherSerialNumber);

            if (success)
            {
                MessageBox.Show("Registration successful!");
                // Perform any additional actions for successful registration
                dataGridView.Rows.Clear();
                LoadBirdsFromExcel();
                ClearInputFields();
                AddButtonColumn();
            }
            else
            {
                MessageBox.Show("Error occurred during registration. Please try again.");
            }
        }
    }
}
