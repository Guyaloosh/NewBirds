using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace ProjectBirdsz
{
    public partial class SearchBirdForm : Form
    {
        private string ExcelFilePath;
        private DataTable dataTable;

        public SearchBirdForm()
        {
            InitializeComponent();
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelFilePath = Path.Combine(projectDirectory, "birds.xlsx");
            dataTable = new DataTable(); // Initialize the DataTable
            dataTable.Clear(); // Clear any existing data
            dataTable.Columns.Clear(); // Clear any existing columns
            dataGridView.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            dataTable.Columns.Clear();
            dataGridView.Refresh();


            string serialNumber = txtSerialNumber.Text.Trim();
            string subSpecies = txtSubSpecies.Text.Trim();
            string strain = txtStrain.Text.Trim();
            string dateOfBirth = txtdateOfBirth.Text.Trim();
            string CageNUmber = txtCageNumber.Text.Trim();

            // Call the method to perform the search
            SearchBird(serialNumber, subSpecies, strain, dateOfBirth,CageNUmber);
        }

        private void SearchBird(string serialNumber, string subSpecies, string strain, string dateOfBirth,string CageNUmber)
        {
            // Load the Excel file
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(ExcelFilePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Get the used range of cells in the worksheet
            Excel.Range usedRange = worksheet.UsedRange;

            dataTable.Clear();
            dataTable.Columns.Clear();
            dataGridView.Refresh();
            dataTable.Reset();

            if (usedRange != null)
            {
                // Convert the used range to a DataTable
                ConvertRangeToDataTable(usedRange);

                // Create a DataView to filter the data
                DataView dataView = new DataView(dataTable);

                // Apply the filters based on the provided search 
                string filterExpression = $"SerialNumber = '{serialNumber}' OR SubSpecies = '{subSpecies}' OR Strain = '{strain}' OR DateOfBird = '{dateOfBirth}' OR CageNumber = '{CageNUmber}'";
                dataView.RowFilter = filterExpression;

                // Check if any birds match the search 
                if (dataView.Count > 0)
                {
                    // Show the matching birds in a DataGridView or any other desired control
                    dataGridView.DataSource = dataView.ToTable();
                }
                else
                {
                    MessageBox.Show("No birds found matching the search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Close the Excel workbook and release the resources
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

        private void ConvertRangeToDataTable(Excel.Range range)
        {
            try
            {
                if (range != null && range.Value != null)
                {
                    object[,] values = range.Value;
                    int rowCount = range.Rows.Count;
                    int columnCount = range.Columns.Count;

                    dataTable.Clear();
                    dataTable.Columns.Clear();
                    dataGridView.Refresh();

                    // Add columns to the DataTable
                    for (int c = 1; c <= columnCount; c++)
                    {
                        string columnName = Convert.ToString(values[1, c]);
                        dataTable.Columns.Add(columnName);
                    }

                    // Add rows to the DataTable
                    for (int r = 2; r <= rowCount; r++)
                    {
                        DataRow row = dataTable.NewRow();

                        for (int c = 1; c <= columnCount; c++)
                        {
                            object value = values[r, c];

                            if (value != null && value != DBNull.Value)
                            {
                                row[c - 1] = value;
                            }
                            else
                            {
                                // Set the value to an empty string if it is null
                                row[c - 1] = string.Empty;
                            }
                        }

                        dataTable.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while converting range to DataTable: " + ex.Message);
            }
        }
        private void Backbuttom_Click(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
           
        }
    }
}





