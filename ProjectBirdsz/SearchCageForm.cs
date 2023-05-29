using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace ProjectBirdsz
{
    public partial class SearchCageForm : Form
    {
        private string ExcelCagesFilePath;
        private string ExcelBirdsFilePath;
        private DataTable cagesDataTable;
        private DataTable birdsDataTable;

        public SearchCageForm()
        {
            InitializeComponent();
            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ExcelCagesFilePath = Path.Combine(projectDirectory, "cages.xlsx");
            ExcelBirdsFilePath = Path.Combine(projectDirectory, "birds.xlsx");
            cagesDataTable = new DataTable();
            birdsDataTable = new DataTable();

            // Add the event handler for the SelectionChanged event
            dataGridViewCages.SelectionChanged += dataGridViewCages_SelectionChanged;
        }

        private void SearchCage(string cageSerialNumber, string material, string CageNUmForBirds)
        {
            cagesDataTable.Clear();
            birdsDataTable.Clear();
            
            

            // Load the cages Excel file
            Excel.Application excelAppCages = new Excel.Application();
            Excel.Workbook workbookCages = excelAppCages.Workbooks.Open(ExcelCagesFilePath);
            Excel.Worksheet worksheetCages = workbookCages.Sheets[1];

            // Get the used range of cells in the cages worksheet
            Excel.Range usedRangeCages = worksheetCages.UsedRange;

            if (usedRangeCages != null)
            {
                // Convert the used range to a DataTable for cages
                ConvertRangeToDataTable(usedRangeCages, cagesDataTable);

                // Filter the cages based on the provided search
                DataView dataView = new DataView(cagesDataTable);
                string filterExpression = $"CageNumber LIKE '%{cageSerialNumber}%' AND Material LIKE '%{material}%'";
                dataView.RowFilter = filterExpression;

                // Check if any cages match the search
                if (dataView.Count > 0)
                {
                    // Show the matching cages in the DataGridView
                    dataGridViewCages.DataSource = dataView.ToTable();

                    // Get the selected cage number
                    string selectedCageNumber = string.Empty;

                    // Check if any rows are selected
                    if (dataGridViewCages.SelectedRows.Count > 0)
                    {
                        // Get the selected cage number
                        selectedCageNumber = dataGridViewCages.SelectedRows[0].Cells["CageNumber"].Value?.ToString();
                    }

                    // Load the birds Excel file
                    Excel.Application excelAppBirds = new Excel.Application();
                    Excel.Workbook workbookBirds = excelAppBirds.Workbooks.Open(ExcelBirdsFilePath);
                    Excel.Worksheet worksheetBirds = workbookBirds.Sheets[1];

                    // Get the used range of cells in the birds worksheet
                    Excel.Range usedRangeBirds = worksheetBirds.UsedRange;

                    if (usedRangeBirds != null)
                    {
                        // Convert the used range to a DataTable for birds
                        ConvertRangeToDataTable(usedRangeBirds, birdsDataTable);

                        // Filter the birds based on the selected cage number
                        DataView birdsDataView = new DataView(birdsDataTable);
                        string birdsFilterExpression = $"CageNumber = '{CageNUmForBirds}'";
                        birdsDataView.RowFilter = birdsFilterExpression;

                        // Check if any birds match the selected cage number
                        if (birdsDataView.Count > 0)
                        {
                            // Show the birds in the separate DataGridView
                            dataGridViewBirds.DataSource = birdsDataView.ToTable();
                        }
                        else
                        {
                            MessageBox.Show("No birds found in the selected cage.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Close the birds Excel workbook and release the resources
                    workbookBirds.Close();
                    excelAppBirds.Quit();
                    ReleaseObject(worksheetBirds);
                    ReleaseObject(workbookBirds);
                    ReleaseObject(excelAppBirds);
                }
                else
                {
                    MessageBox.Show("No cages found matching the search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Close the cages Excel workbook and release the resources
            workbookCages.Close();
            excelAppCages.Quit();
            ReleaseObject(worksheetCages);
            ReleaseObject(workbookCages);
            ReleaseObject(excelAppCages);
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

        private void ConvertRangeToDataTable(Excel.Range range, DataTable dataTable)
        {
            if (range != null && range.Value != null)
            {
                object[,] values = range.Value;
                int rowCount = range.Rows.Count;
                int columnCount = range.Columns.Count;

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
                    bool rowHasValues = false; // Flag to track if the row has any non-null values

                    for (int c = 1; c <= columnCount; c++)
                    {
                        object value = values[r, c];

                        if (value != null && value != DBNull.Value) // Check for both null and DBNull.Value
                        {
                            rowHasValues = true;
                            row[c - 1] = value;
                        }
                        else
                        {
                            rowHasValues = true; // Consider the row as having values even if some cells are null
                        }
                    }

                    if (rowHasValues)
                    {
                        dataTable.Rows.Add(row);
                    }
                    
                }
            }
            
        }

        private void dataGridViewCages_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCages.SelectedRows.Count > 0)
            {
                // Get the selected cage number
                string selectedCageNumber = string.Empty;

                // Check if any rows are selected
                if (dataGridViewCages.SelectedRows.Count > 0)
                {
                    // Get the selected cage number
                    selectedCageNumber = dataGridViewCages.SelectedRows[0].Cells["CageNumber"].Value?.ToString();
                }

                if (!string.IsNullOrEmpty(selectedCageNumber))
                {
                    // Filter the birds based on the selected cage number
                    DataView birdsDataView = new DataView(birdsDataTable);
                    string birdsFilterExpression = $"CageNumber = '{selectedCageNumber}'";
                    birdsDataView.RowFilter = birdsFilterExpression;

                    // Check if any birds match the selected cage number
                    if (birdsDataView.Count > 0)
                    {
                        // Show the filtered birds in the separate DataGridView
                        dataGridViewBirds.DataSource = birdsDataView.ToTable();
                    }
                    else
                    {
                        dataGridViewBirds.DataSource = null; // Clear the data source if no birds match the selected cage number
                        MessageBox.Show("No birds found in the selected cage.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cagesDataTable.Clear();
            cagesDataTable.Columns.Clear();
            birdsDataTable.Clear();
            birdsDataTable.Columns.Clear();
            cagesDataTable.Reset();
            birdsDataTable.Reset();

            string cageSerialNumber = txtCageSerialNumber.Text.Trim();
            string material = txtMaterial.Text.Trim();
            string CageNUmForBirds = txtCageSerialNumber.Text.Trim();

            // Call the method to perform the search
            SearchCage(cageSerialNumber, material, CageNUmForBirds);
        }

        private void Backbuttom_Click_1(object sender, EventArgs e)
        {
            MainMenuForm obj = new MainMenuForm();
            this.Hide();
            obj.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            dataGridViewCages.DataSource = null;
            dataGridViewCages.Rows.Clear();
            dataGridViewCages.Columns.Clear();
            dataGridViewBirds.DataSource = null;
            dataGridViewBirds.Rows.Clear();
            dataGridViewBirds.Columns.Clear();
        }
    }
}
