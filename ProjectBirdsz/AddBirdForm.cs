using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;


namespace ProjectBirdsz
{
    public partial class AddBirdForm : Form
    {
        private string ExcelFilePath;
        private DataGridView dataGridView;


        public AddBirdForm()
        {

            InitializeComponent();
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "birds.xlsx");
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


        private void btnSaveBird_Click(object sender, EventArgs e)
        {
            bool success = false;
            string SerialNumber = txtSerialBirds.Text;
            string Strain = txtStrain.Text;
            string SubSpecies = txtSubSpecies.Text;
            string DateOfBird = txtDateOfBird.Text;
            string Gender = txtGender.Text;
            string CageNumber =txtCageNumber.Text;
            string FatherSerialNumber = txtFatherSerialNumber.Text;
            string MotherSerialNumber = txtMotherSerialNumber.Text;

            success = SaveBirdToExcel(SerialNumber, Strain, SubSpecies, DateOfBird, Gender, CageNumber, FatherSerialNumber,MotherSerialNumber);

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

        private bool SaveBirdToExcel(string SerialNumber, string Strain, string SubSpecies, string DateOfBird, string Gender, string CageNumber, string FatherSerialNumber, string MotherSerialNumber)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;


            // Find the next available row in Excel
            int nextRow = range.Rows.Count + 1;

            // Save user information to Excel
            range.Cells[nextRow, 1].Value = SerialNumber;
            range.Cells[nextRow, 2].Value = Strain;
            range.Cells[nextRow, 3].Value = SubSpecies;
            range.Cells[nextRow, 4].Value = DateOfBird;
            range.Cells[nextRow, 5].Value = Gender;
            range.Cells[nextRow, 6].Value = CageNumber;
            range.Cells[nextRow, 7].Value = FatherSerialNumber;
            range.Cells[nextRow, 8].Value = MotherSerialNumber;
          

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
            txtStrain.Text = string.Empty;
            txtSubSpecies.Text = string.Empty;
            txtDateOfBird.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtCageNumber.Text = string.Empty;
            txtFatherSerialNumber.Text = string.Empty;
            txtMotherSerialNumber.Text = string.Empty;
        }

        private void AllBirdsBtn_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            LoadBirdsFromExcel();
            AddButtonColumn();
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Set the values of the text boxes based on the selected row
                txtSerialBirds.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txtStrain.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtSubSpecies.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txtDateOfBird.Text = Convert.ToString(selectedRow.Cells[3].Value);
                txtGender.Text = Convert.ToString(selectedRow.Cells[4].Value);
                txtCageNumber.Text = Convert.ToString(selectedRow.Cells[5].Value);
                txtFatherSerialNumber.Text = Convert.ToString(selectedRow.Cells[6].Value);
                txtMotherSerialNumber.Text = Convert.ToString(selectedRow.Cells[7].Value);
            }
        }

        private void EditBirdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Update the values in the DataGridView row with the values from the text boxes
                selectedRow.Cells[0].Value = txtSerialBirds.Text;
                selectedRow.Cells[1].Value = txtStrain.Text;
                selectedRow.Cells[2].Value = txtSubSpecies.Text;
                selectedRow.Cells[3].Value = txtDateOfBird.Text;
                selectedRow.Cells[4].Value = txtGender.Text;
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["AddChickColumn"].Index)
            {
                // Button cell clicked for the Add Chick action
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Extract values from the selected row
                string serialBird = Convert.ToString(selectedRow.Cells[0].Value);
                string strain = Convert.ToString(selectedRow.Cells[1].Value);
                string subSpecies = Convert.ToString(selectedRow.Cells[2].Value);
                string CageNumber= Convert.ToString(selectedRow.Cells[5].Value);

                // Set the text box values
                txtFatherSerialNumber.Text = serialBird;
                txtStrain.Text = strain;
                txtSubSpecies.Text = subSpecies;
                txtCageNumber.Text = CageNumber;

                // Clear the other text box values
                ClearInputFieldsForChick();

                MessageBox.Show("Add Chick action triggered for row " + (e.RowIndex + 1));
            }
        }

        private void ClearInputFieldsForChick()
        {
            // Clear all text boxes except for the ones already populated
            txtSerialBirds.Text = string.Empty;
            txtDateOfBird.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtMotherSerialNumber.Text = string.Empty;
        }
    }
}
