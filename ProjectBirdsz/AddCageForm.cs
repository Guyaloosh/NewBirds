using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ProjectBirdsz
{
    public partial class AddCageForm : Form
    {
        private string ExcelFilePath;
        private DataGridView dataGridView;
        public AddCageForm()
        {
            InitializeComponent();
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "cages.xlsx");
            
            dataGridView = dataGridView1;
            dataGridView.CellDoubleClick += dataGridView1_CellDoubleClick;
        }




        private void LoadCagesFromExcel()
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

            // Clean up Excel objects
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
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



        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }

        bool CheckOnlyNumber(String Number)
        {
            foreach (char letter in Number)
                if (!char.IsDigit(letter))
                    return false;
            if (Number == "")
                return false;
            return true;
        }
        bool CageSiral(String CageS)
        {
            foreach (char letter in CageS)
                if (!char.IsLetterOrDigit(letter))
                    return false;
            if (CageS == "")
                return false;
            return true;
        }
        private void btnSaveCage_Click(object sender, EventArgs e)
        {
            bool success = false;
            string CageNumber = txtCageNumber.Text;
            string CageLength = txtlength.Text;
            string CageHeight = txtheight.Text;
            string CageWitdh = txtwidth.Text;
            string CageMaterial = MaterialComboBox.Text;

            if (CageSiral(CageNumber)&& CageMaterial!="" && CheckOnlyNumber(CageLength) && CheckOnlyNumber(CageHeight) && CheckOnlyNumber(CageWitdh))
                success = SaveCageToExcel(CageNumber, CageLength, CageHeight, CageWitdh, CageMaterial);
 
            if (success)
            {
                MessageBox.Show("Registration successful!");
                // Perform any additional actions for successful registration
                dataGridView.Rows.Clear();
                LoadCagesFromExcel();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Error occurred during registration. Please try again.");
            }
        }

        private bool SaveCageToExcel(string CageNumber, string CageLength, string CageHeight, string CageWitdh, string CageMaterial)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;


            // Find the next available row in Excel
            int nextRow = range.Rows.Count + 1;

            // Save user information to Excel
            range.Cells[nextRow, 1].Value = CageNumber;
            range.Cells[nextRow, 2].Value = CageLength;
            range.Cells[nextRow, 3].Value = CageHeight;
            range.Cells[nextRow, 4].Value = CageWitdh;
            range.Cells[nextRow, 5].Value = CageMaterial;


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

        private void ClearInputFields()
        {
            txtCageNumber.Text = string.Empty;
            txtlength.Text = string.Empty;
            txtheight.Text = string.Empty;
            txtwidth.Text = string.Empty;
            MaterialComboBox.Text = string.Empty;
           
        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Set the values of the text boxes based on the selected row
                txtCageNumber.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txtlength.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtheight.Text = Convert.ToString(selectedRow.Cells[2].Value);
                txtwidth.Text = Convert.ToString(selectedRow.Cells[3].Value);
                MaterialComboBox.Text = Convert.ToString(selectedRow.Cells[4].Value);
                
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


        private void AddCageForm_Load(object sender, EventArgs e)
        {
            LoadCagesFromExcel();
        }

        private void EditCageBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Update the values in the DataGridView row with the values from the text boxes
                selectedRow.Cells[0].Value = txtCageNumber.Text;
                selectedRow.Cells[1].Value = txtlength.Text;
                selectedRow.Cells[2].Value = txtheight.Text;
                selectedRow.Cells[3].Value = txtwidth.Text;
                selectedRow.Cells[4].Value = MaterialComboBox.Text;
                

                // Save the changes back to the Excel file
                SaveChangesToExcel();

                MessageBox.Show("Changes saved successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void AllCagesBtn_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            LoadCagesFromExcel();

        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }
    }
}
