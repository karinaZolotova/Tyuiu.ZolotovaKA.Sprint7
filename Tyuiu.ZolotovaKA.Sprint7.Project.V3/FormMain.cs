using Tyuiu.ZolotovaKA.Sprint7.Project.V3.Lib;

namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogImport_ZKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogExport_ZKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        int rows;
        int columns;
        string OpenFilePath = "";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonExport_ZKA_Click(object sender, EventArgs e)
        {
            bool zerorows = false;
            foreach (DataGridViewRow row in dataGridViewMainGrid_ZKA.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var cellValue = cell.Value;
                    if (cellValue == null || cellValue.ToString() == "")
                    {
                        zerorows = true;
                        break;
                    }
                }
            }
            if (zerorows == false)
            {
                saveFileDialogExport_ZKA.FileName = "OutputSprint7.csv";
                saveFileDialogExport_ZKA.ShowDialog();

                string path = saveFileDialogExport_ZKA.FileName;

                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    file.Delete();
                }
                string str = "";

                for (int i = 0; i < dataGridViewMainGrid_ZKA.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewMainGrid_ZKA.ColumnCount; j++)
                    {
                        if (j != (columns - 1))
                        {
                            str += dataGridViewMainGrid_ZKA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewMainGrid_ZKA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            else
            {
                MessageBox.Show("В файле есть пустые ячейки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImport_ZKA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMainGrid_ZKA.Rows.Clear();
                openFileDialogImport_ZKA.ShowDialog();
                OpenFilePath = openFileDialogImport_ZKA.FileName;
                string[,] array = ds.OpenFile(OpenFilePath);
                dataGridViewMainGrid_ZKA.Columns[0].ValueType = typeof(int);
                dataGridViewMainGrid_ZKA.Columns[1].ValueType = typeof(string);
                dataGridViewMainGrid_ZKA.Columns[2].ValueType = typeof(long);
                dataGridViewMainGrid_ZKA.Columns[3].ValueType = typeof(string);
                dataGridViewMainGrid_ZKA.Columns[4].ValueType = typeof(int);
                dataGridViewMainGrid_ZKA.Columns[5].ValueType = typeof(int);
                dataGridViewMainGrid_ZKA.Columns[6].ValueType = typeof(int);
                dataGridViewMainGrid_ZKA.Columns[7].ValueType = typeof(int);

                rows = array.GetLength(0);
                columns = array.GetLength(1);

                dataGridViewMainGrid_ZKA.RowCount = rows;
                dataGridViewMainGrid_ZKA.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j == 0) || (4 <= j && j <= 7))
                        {
                            dataGridViewMainGrid_ZKA.Rows[i].Cells[j].Value = Convert.ToInt32(array[i, j]);
                        }
                        else if (j == 2)
                        {
                            dataGridViewMainGrid_ZKA.Rows[i].Cells[j].Value = Convert.ToInt64(array[i, j]);
                        }
                        else
                        {
                            dataGridViewMainGrid_ZKA.Rows[i].Cells[j].Value = array[i, j];
                        }
                    }
                }
                dataGridViewMainGrid_ZKA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonExport_ZKA.Enabled = true;
                buttonAddRow_ZKA.Enabled = true;
                buttonRemoveRow_ZKA.Enabled = true;
                textBoxSearch_ZKA.Enabled = true;
                buttonSearch_ZKA.Enabled = true;
                buttonMore_ZKA.Enabled = true;
                //buttonDeveloper_ZKA.Enabled = true;
                TabBarNavigation_ZKA.SelectedIndex = 1;
            }
            catch
            {
                MessageBox.Show("Некорректный файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddRow_ZKA_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridViewMainGrid_ZKA.Rows.Insert(0, row);
            dataGridViewMainGrid_ZKA.Height += 21;
        }

        private void buttonRemoveRow_ZKA_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainGrid_ZKA.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewMainGrid_ZKA.SelectedRows)
                {
                    dataGridViewMainGrid_ZKA.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_ZKA_Click(object sender, EventArgs e)
        {
            try
            {
                string request = textBoxSearch_ZKA.Text.ToLower();

                dataGridViewMainGrid_ZKA.ClearSelection();

                foreach (DataGridViewRow row in dataGridViewMainGrid_ZKA.Rows)
                {
                    bool visible = false;

                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell Cell in row.Cells)
                        {
                            if (Cell.Value != null && Cell.Value.ToString().ToLower().Contains(request))
                            {
                                visible = true;
                                break;
                            }
                        }
                    }

                    row.Visible = visible;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка запроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_ZKA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch_ZKA.TextLength == 0)
            {
                foreach (DataGridViewRow row in dataGridViewMainGrid_ZKA.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void textBoxSearch_ZKA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_ZKA_Click(sender, e);
            }
        }

        private void dataGridViewMainGrid_ZKA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewMainGrid_ZKA.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    buttonRemoveRow_ZKA_Click(sender, e);
                }
            }
        }

        private void dataGridViewMainGrid_ZKA_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewMainGrid_ZKA.SelectedRows.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void buttonImport_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonExport_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonAddRow_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonRemoveRow_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSearch_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void dataGridViewMainGrid_ZKA_SelectionChanged(object sender, EventArgs e)
        {
            labelSelected_ZKA.Text = "Выбрано: " + (dataGridViewMainGrid_ZKA.SelectedCells.Count).ToString();
            labelSelected_ZKA.Visible = true;
        }

        private void buttonMore_ZKA_Click(object sender, EventArgs e)
        {
            FormStatistics formMore = new FormStatistics(dataGridViewMainGrid_ZKA);
            formMore.ShowDialog();
        }

        private void buttonDeveloper_ZKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonGuide_ZKA_Click(object sender, EventArgs e)
        {
            FormUserGuide formUserGuide = new FormUserGuide();
            formUserGuide.ShowDialog();
        }

        private void dataGridViewMainGrid_ZKA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Пожалуйста, введите число в этом столбце.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}