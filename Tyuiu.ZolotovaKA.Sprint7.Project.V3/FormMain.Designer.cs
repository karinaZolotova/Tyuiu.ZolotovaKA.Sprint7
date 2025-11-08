namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMenu_ZKA = new Panel();
            TabBarNavigation_ZKA = new TabControl();
            tabPageFile_ZKA = new TabPage();
            groupBoxFile_ZKA = new GroupBox();
            buttonExport_ZKA = new Button();
            labelExport_ZKA = new Label();
            labelImport_ZKA = new Label();
            buttonImport_ZKA = new Button();
            tabPageMain_ZKA = new TabPage();
            groupBoxSearch_ZKA = new GroupBox();
            buttonSearch_ZKA = new Button();
            textBoxSearch_ZKA = new TextBox();
            groupBoxEdit_ZKA = new GroupBox();
            labelRemoveRow_ZKA = new Label();
            labelAddRow_ZKA = new Label();
            buttonRemoveRow_ZKA = new Button();
            buttonAddRow_ZKA = new Button();
            tabPageInformation_ZKA = new TabPage();
            groupBoxInformation_ZKA = new GroupBox();
            buttonGuide_ZKA = new Button();
            labelHelp_ZKA = new Label();
            labelDevoleper_ZKA = new Label();
            buttonВeveloper_ZKA = new Button();
            panelGrid_ZKA = new Panel();
            dataGridViewMainGrid_ZKA = new DataGridView();
            ColumnID_ZKA = new DataGridViewTextBoxColumn();
            ColumnName_ZKA = new DataGridViewTextBoxColumn();
            ColumnNumber_ZKA = new DataGridViewTextBoxColumn();
            ColumnSubject_ZKA = new DataGridViewTextBoxColumn();
            ColumnAge_ZKA = new DataGridViewTextBoxColumn();
            ColumnAudienceNumber_ZKA = new DataGridViewTextBoxColumn();
            ColumnExperience_ZKA = new DataGridViewTextBoxColumn();
            ColumnHoursPerWeek_ZKA = new DataGridViewTextBoxColumn();
            openFileDialogImport_ZKA = new OpenFileDialog();
            saveFileDialogExport_ZKA = new SaveFileDialog();
            toolTip_ZKA = new ToolTip(components);
            buttonMore_ZKA = new Button();
            labelSelected_ZKA = new Label();
            panelStatistics_ZKA = new Panel();
            panelMenu_ZKA.SuspendLayout();
            TabBarNavigation_ZKA.SuspendLayout();
            tabPageFile_ZKA.SuspendLayout();
            groupBoxFile_ZKA.SuspendLayout();
            tabPageMain_ZKA.SuspendLayout();
            groupBoxSearch_ZKA.SuspendLayout();
            groupBoxEdit_ZKA.SuspendLayout();
            tabPageInformation_ZKA.SuspendLayout();
            groupBoxInformation_ZKA.SuspendLayout();
            panelGrid_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_ZKA).BeginInit();
            panelStatistics_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu_ZKA
            // 
            panelMenu_ZKA.BackColor = Color.DarkGray;
            panelMenu_ZKA.Controls.Add(TabBarNavigation_ZKA);
            panelMenu_ZKA.Dock = DockStyle.Top;
            panelMenu_ZKA.Location = new Point(0, 0);
            panelMenu_ZKA.Margin = new Padding(0);
            panelMenu_ZKA.Name = "panelMenu_ZKA";
            panelMenu_ZKA.Size = new Size(884, 156);
            panelMenu_ZKA.TabIndex = 0;
            // 
            // TabBarNavigation_ZKA
            // 
            TabBarNavigation_ZKA.Controls.Add(tabPageFile_ZKA);
            TabBarNavigation_ZKA.Controls.Add(tabPageMain_ZKA);
            TabBarNavigation_ZKA.Controls.Add(tabPageInformation_ZKA);
            TabBarNavigation_ZKA.Dock = DockStyle.Top;
            TabBarNavigation_ZKA.Location = new Point(0, 0);
            TabBarNavigation_ZKA.Name = "TabBarNavigation_ZKA";
            TabBarNavigation_ZKA.SelectedIndex = 0;
            TabBarNavigation_ZKA.Size = new Size(884, 156);
            TabBarNavigation_ZKA.TabIndex = 0;
            // 
            // tabPageFile_ZKA
            // 
            tabPageFile_ZKA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageFile_ZKA.Controls.Add(groupBoxFile_ZKA);
            tabPageFile_ZKA.Location = new Point(4, 24);
            tabPageFile_ZKA.Name = "tabPageFile_ZKA";
            tabPageFile_ZKA.Padding = new Padding(3);
            tabPageFile_ZKA.Size = new Size(876, 128);
            tabPageFile_ZKA.TabIndex = 0;
            tabPageFile_ZKA.Text = "Файл";
            // 
            // groupBoxFile_ZKA
            // 
            groupBoxFile_ZKA.BackColor = Color.FromArgb(241, 241, 241);
            groupBoxFile_ZKA.Controls.Add(buttonExport_ZKA);
            groupBoxFile_ZKA.Controls.Add(labelExport_ZKA);
            groupBoxFile_ZKA.Controls.Add(labelImport_ZKA);
            groupBoxFile_ZKA.Controls.Add(buttonImport_ZKA);
            groupBoxFile_ZKA.Dock = DockStyle.Fill;
            groupBoxFile_ZKA.Location = new Point(3, 3);
            groupBoxFile_ZKA.Name = "groupBoxFile_ZKA";
            groupBoxFile_ZKA.Size = new Size(870, 122);
            groupBoxFile_ZKA.TabIndex = 3;
            groupBoxFile_ZKA.TabStop = false;
            groupBoxFile_ZKA.Text = "Работа с файлом";
            // 
            // buttonExport_ZKA
            // 
            buttonExport_ZKA.BackColor = Color.White;
            buttonExport_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonExport_ZKA.Cursor = Cursors.Hand;
            buttonExport_ZKA.Enabled = false;
            buttonExport_ZKA.FlatStyle = FlatStyle.Popup;
            buttonExport_ZKA.Location = new Point(76, 22);
            buttonExport_ZKA.Name = "buttonExport_ZKA";
            buttonExport_ZKA.Size = new Size(64, 64);
            buttonExport_ZKA.TabIndex = 0;
            toolTip_ZKA.SetToolTip(buttonExport_ZKA, "Экспортировать файл из программы");
            buttonExport_ZKA.UseVisualStyleBackColor = false;
            buttonExport_ZKA.Click += buttonExport_ZKA_Click;
            buttonExport_ZKA.MouseEnter += buttonExport_ZKA_MouseEnter;
            // 
            // labelExport_ZKA
            // 
            labelExport_ZKA.AutoSize = true;
            labelExport_ZKA.Location = new Point(83, 89);
            labelExport_ZKA.Name = "labelExport_ZKA";
            labelExport_ZKA.Size = new Size(52, 15);
            labelExport_ZKA.TabIndex = 2;
            labelExport_ZKA.Text = "Экспорт";
            // 
            // labelImport_ZKA
            // 
            labelImport_ZKA.AutoSize = true;
            labelImport_ZKA.Location = new Point(13, 89);
            labelImport_ZKA.Name = "labelImport_ZKA";
            labelImport_ZKA.Size = new Size(51, 15);
            labelImport_ZKA.TabIndex = 1;
            labelImport_ZKA.Text = "Импорт";
            // 
            // buttonImport_ZKA
            // 
            buttonImport_ZKA.BackColor = Color.White;
            buttonImport_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonImport_ZKA.Cursor = Cursors.Hand;
            buttonImport_ZKA.FlatStyle = FlatStyle.Popup;
            buttonImport_ZKA.Location = new Point(6, 22);
            buttonImport_ZKA.Name = "buttonImport_ZKA";
            buttonImport_ZKA.Size = new Size(64, 64);
            buttonImport_ZKA.TabIndex = 0;
            toolTip_ZKA.SetToolTip(buttonImport_ZKA, "Импортировать файл в программу");
            buttonImport_ZKA.UseVisualStyleBackColor = false;
            buttonImport_ZKA.Click += buttonImport_ZKA_Click;
            buttonImport_ZKA.MouseEnter += buttonImport_ZKA_MouseEnter;
            // 
            // tabPageMain_ZKA
            // 
            tabPageMain_ZKA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageMain_ZKA.Controls.Add(groupBoxSearch_ZKA);
            tabPageMain_ZKA.Controls.Add(groupBoxEdit_ZKA);
            tabPageMain_ZKA.Location = new Point(4, 24);
            tabPageMain_ZKA.Margin = new Padding(0);
            tabPageMain_ZKA.Name = "tabPageMain_ZKA";
            tabPageMain_ZKA.Padding = new Padding(3);
            tabPageMain_ZKA.Size = new Size(876, 128);
            tabPageMain_ZKA.TabIndex = 1;
            tabPageMain_ZKA.Text = "Главная";
            // 
            // groupBoxSearch_ZKA
            // 
            groupBoxSearch_ZKA.Controls.Add(buttonSearch_ZKA);
            groupBoxSearch_ZKA.Controls.Add(textBoxSearch_ZKA);
            groupBoxSearch_ZKA.Dock = DockStyle.Fill;
            groupBoxSearch_ZKA.Location = new Point(150, 3);
            groupBoxSearch_ZKA.Margin = new Padding(0);
            groupBoxSearch_ZKA.Name = "groupBoxSearch_ZKA";
            groupBoxSearch_ZKA.Size = new Size(723, 122);
            groupBoxSearch_ZKA.TabIndex = 1;
            groupBoxSearch_ZKA.TabStop = false;
            groupBoxSearch_ZKA.Text = "Поиск";
            // 
            // buttonSearch_ZKA
            // 
            buttonSearch_ZKA.BackColor = Color.White;
            buttonSearch_ZKA.Cursor = Cursors.Hand;
            buttonSearch_ZKA.Enabled = false;
            buttonSearch_ZKA.FlatStyle = FlatStyle.Popup;
            buttonSearch_ZKA.Location = new Point(129, 37);
            buttonSearch_ZKA.Name = "buttonSearch_ZKA";
            buttonSearch_ZKA.Size = new Size(34, 34);
            buttonSearch_ZKA.TabIndex = 1;
            toolTip_ZKA.SetToolTip(buttonSearch_ZKA, "Поиск");
            buttonSearch_ZKA.UseVisualStyleBackColor = false;
            buttonSearch_ZKA.Click += buttonSearch_ZKA_Click;
            buttonSearch_ZKA.MouseEnter += buttonSearch_ZKA_MouseEnter;
            // 
            // textBoxSearch_ZKA
            // 
            textBoxSearch_ZKA.Cursor = Cursors.IBeam;
            textBoxSearch_ZKA.Enabled = false;
            textBoxSearch_ZKA.Location = new Point(6, 44);
            textBoxSearch_ZKA.Name = "textBoxSearch_ZKA";
            textBoxSearch_ZKA.Size = new Size(117, 23);
            textBoxSearch_ZKA.TabIndex = 0;
            textBoxSearch_ZKA.TextChanged += textBoxSearch_ZKA_TextChanged;
            textBoxSearch_ZKA.KeyDown += textBoxSearch_ZKA_KeyDown;
            // 
            // groupBoxEdit_ZKA
            // 
            groupBoxEdit_ZKA.BackColor = Color.FromArgb(241, 241, 241);
            groupBoxEdit_ZKA.Controls.Add(labelRemoveRow_ZKA);
            groupBoxEdit_ZKA.Controls.Add(labelAddRow_ZKA);
            groupBoxEdit_ZKA.Controls.Add(buttonRemoveRow_ZKA);
            groupBoxEdit_ZKA.Controls.Add(buttonAddRow_ZKA);
            groupBoxEdit_ZKA.Dock = DockStyle.Left;
            groupBoxEdit_ZKA.Location = new Point(3, 3);
            groupBoxEdit_ZKA.Margin = new Padding(0);
            groupBoxEdit_ZKA.Name = "groupBoxEdit_ZKA";
            groupBoxEdit_ZKA.Size = new Size(147, 122);
            groupBoxEdit_ZKA.TabIndex = 0;
            groupBoxEdit_ZKA.TabStop = false;
            groupBoxEdit_ZKA.Text = "Редактирование";
            // 
            // labelRemoveRow_ZKA
            // 
            labelRemoveRow_ZKA.AutoSize = true;
            labelRemoveRow_ZKA.Location = new Point(82, 89);
            labelRemoveRow_ZKA.Name = "labelRemoveRow_ZKA";
            labelRemoveRow_ZKA.Size = new Size(54, 30);
            labelRemoveRow_ZKA.TabIndex = 3;
            labelRemoveRow_ZKA.Text = "Удалить \r\nстроку";
            labelRemoveRow_ZKA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddRow_ZKA
            // 
            labelAddRow_ZKA.AutoSize = true;
            labelAddRow_ZKA.Location = new Point(10, 89);
            labelAddRow_ZKA.Name = "labelAddRow_ZKA";
            labelAddRow_ZKA.Size = new Size(62, 30);
            labelAddRow_ZKA.TabIndex = 2;
            labelAddRow_ZKA.Text = "Добавить \r\nстроку";
            labelAddRow_ZKA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRemoveRow_ZKA
            // 
            buttonRemoveRow_ZKA.BackColor = Color.White;
            buttonRemoveRow_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonRemoveRow_ZKA.Cursor = Cursors.Hand;
            buttonRemoveRow_ZKA.Enabled = false;
            buttonRemoveRow_ZKA.FlatStyle = FlatStyle.Popup;
            buttonRemoveRow_ZKA.Location = new Point(76, 22);
            buttonRemoveRow_ZKA.Name = "buttonRemoveRow_ZKA";
            buttonRemoveRow_ZKA.Size = new Size(64, 64);
            buttonRemoveRow_ZKA.TabIndex = 1;
            toolTip_ZKA.SetToolTip(buttonRemoveRow_ZKA, "Удалить выбранную строку");
            buttonRemoveRow_ZKA.UseVisualStyleBackColor = false;
            buttonRemoveRow_ZKA.Click += buttonRemoveRow_ZKA_Click;
            buttonRemoveRow_ZKA.MouseEnter += buttonRemoveRow_ZKA_MouseEnter;
            // 
            // buttonAddRow_ZKA
            // 
            buttonAddRow_ZKA.BackColor = Color.White;
            buttonAddRow_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonAddRow_ZKA.Cursor = Cursors.Hand;
            buttonAddRow_ZKA.Enabled = false;
            buttonAddRow_ZKA.FlatStyle = FlatStyle.Popup;
            buttonAddRow_ZKA.Location = new Point(6, 22);
            buttonAddRow_ZKA.Name = "buttonAddRow_ZKA";
            buttonAddRow_ZKA.Size = new Size(64, 64);
            buttonAddRow_ZKA.TabIndex = 1;
            toolTip_ZKA.SetToolTip(buttonAddRow_ZKA, "Добавить новую строку");
            buttonAddRow_ZKA.UseVisualStyleBackColor = false;
            buttonAddRow_ZKA.Click += buttonAddRow_ZKA_Click;
            buttonAddRow_ZKA.MouseEnter += buttonAddRow_ZKA_MouseEnter;
            // 
            // tabPageInformation_ZKA
            // 
            tabPageInformation_ZKA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageInformation_ZKA.Controls.Add(groupBoxInformation_ZKA);
            tabPageInformation_ZKA.Location = new Point(4, 24);
            tabPageInformation_ZKA.Name = "tabPageInformation_ZKA";
            tabPageInformation_ZKA.Padding = new Padding(3);
            tabPageInformation_ZKA.Size = new Size(876, 128);
            tabPageInformation_ZKA.TabIndex = 2;
            tabPageInformation_ZKA.Text = "О программе";
            // 
            // groupBoxInformation_ZKA
            // 
            groupBoxInformation_ZKA.Controls.Add(buttonGuide_ZKA);
            groupBoxInformation_ZKA.Controls.Add(labelHelp_ZKA);
            groupBoxInformation_ZKA.Controls.Add(labelDevoleper_ZKA);
            groupBoxInformation_ZKA.Controls.Add(buttonВeveloper_ZKA);
            groupBoxInformation_ZKA.Dock = DockStyle.Left;
            groupBoxInformation_ZKA.Location = new Point(3, 3);
            groupBoxInformation_ZKA.Name = "groupBoxInformation_ZKA";
            groupBoxInformation_ZKA.Size = new Size(157, 122);
            groupBoxInformation_ZKA.TabIndex = 0;
            groupBoxInformation_ZKA.TabStop = false;
            groupBoxInformation_ZKA.Text = "О разработке";
            // 
            // buttonGuide_ZKA
            // 
            buttonGuide_ZKA.BackColor = Color.White;
            buttonGuide_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonGuide_ZKA.Cursor = Cursors.Hand;
            buttonGuide_ZKA.FlatStyle = FlatStyle.Popup;
            buttonGuide_ZKA.Location = new Point(76, 22);
            buttonGuide_ZKA.Name = "buttonGuide_ZKA";
            buttonGuide_ZKA.Size = new Size(64, 64);
            buttonGuide_ZKA.TabIndex = 2;
            buttonGuide_ZKA.UseVisualStyleBackColor = false;
            buttonGuide_ZKA.Click += buttonGuide_ZKA_Click;
            // 
            // labelHelp_ZKA
            // 
            labelHelp_ZKA.Location = new Point(71, 89);
            labelHelp_ZKA.Name = "labelHelp_ZKA";
            labelHelp_ZKA.Size = new Size(82, 30);
            labelHelp_ZKA.TabIndex = 3;
            labelHelp_ZKA.Text = "Руководство пользователя";
            labelHelp_ZKA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDevoleper_ZKA
            // 
            labelDevoleper_ZKA.AutoSize = true;
            labelDevoleper_ZKA.Font = new Font("Segoe UI", 8F);
            labelDevoleper_ZKA.Location = new Point(0, 89);
            labelDevoleper_ZKA.Name = "labelDevoleper_ZKA";
            labelDevoleper_ZKA.Size = new Size(76, 13);
            labelDevoleper_ZKA.TabIndex = 3;
            labelDevoleper_ZKA.Text = "Разработчик";
            labelDevoleper_ZKA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonВeveloper_ZKA
            // 
            buttonВeveloper_ZKA.BackColor = Color.White;
            buttonВeveloper_ZKA.BackgroundImageLayout = ImageLayout.None;
            buttonВeveloper_ZKA.Cursor = Cursors.Hand;
            buttonВeveloper_ZKA.FlatStyle = FlatStyle.Popup;
            buttonВeveloper_ZKA.Location = new Point(6, 22);
            buttonВeveloper_ZKA.Name = "buttonВeveloper_ZKA";
            buttonВeveloper_ZKA.Size = new Size(64, 64);
            buttonВeveloper_ZKA.TabIndex = 2;
            toolTip_ZKA.SetToolTip(buttonВeveloper_ZKA, "Информация о разработчике");
            buttonВeveloper_ZKA.UseVisualStyleBackColor = false;
            buttonВeveloper_ZKA.Click += buttonDeveloper_ZKA_Click;
            // 
            // panelGrid_ZKA
            // 
            panelGrid_ZKA.AutoScroll = true;
            panelGrid_ZKA.Controls.Add(dataGridViewMainGrid_ZKA);
            panelGrid_ZKA.Dock = DockStyle.Fill;
            panelGrid_ZKA.Location = new Point(0, 156);
            panelGrid_ZKA.Name = "panelGrid_ZKA";
            panelGrid_ZKA.Size = new Size(884, 281);
            panelGrid_ZKA.TabIndex = 1;
            // 
            // dataGridViewMainGrid_ZKA
            // 
            dataGridViewMainGrid_ZKA.AllowUserToAddRows = false;
            dataGridViewMainGrid_ZKA.AllowUserToDeleteRows = false;
            dataGridViewMainGrid_ZKA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewMainGrid_ZKA.BackgroundColor = Color.White;
            dataGridViewMainGrid_ZKA.BorderStyle = BorderStyle.None;
            dataGridViewMainGrid_ZKA.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMainGrid_ZKA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMainGrid_ZKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMainGrid_ZKA.Columns.AddRange(new DataGridViewColumn[] { ColumnID_ZKA, ColumnName_ZKA, ColumnNumber_ZKA, ColumnSubject_ZKA, ColumnAge_ZKA, ColumnAudienceNumber_ZKA, ColumnExperience_ZKA, ColumnHoursPerWeek_ZKA });
            dataGridViewMainGrid_ZKA.Dock = DockStyle.Fill;
            dataGridViewMainGrid_ZKA.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewMainGrid_ZKA.Location = new Point(0, 0);
            dataGridViewMainGrid_ZKA.Name = "dataGridViewMainGrid_ZKA";
            dataGridViewMainGrid_ZKA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMainGrid_ZKA.Size = new Size(884, 281);
            dataGridViewMainGrid_ZKA.TabIndex = 0;
            dataGridViewMainGrid_ZKA.TabStop = false;
            dataGridViewMainGrid_ZKA.CellBeginEdit += dataGridViewMainGrid_ZKA_CellBeginEdit;
            dataGridViewMainGrid_ZKA.DataError += dataGridViewMainGrid_ZKA_DataError;
            dataGridViewMainGrid_ZKA.SelectionChanged += dataGridViewMainGrid_ZKA_SelectionChanged;
            dataGridViewMainGrid_ZKA.KeyDown += dataGridViewMainGrid_ZKA_KeyDown;
            // 
            // ColumnID_ZKA
            // 
            ColumnID_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnID_ZKA.HeaderText = "ID";
            ColumnID_ZKA.MinimumWidth = 30;
            ColumnID_ZKA.Name = "ColumnID_ZKA";
            ColumnID_ZKA.Width = 30;
            // 
            // ColumnName_ZKA
            // 
            ColumnName_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnName_ZKA.HeaderText = "ФИО";
            ColumnName_ZKA.MinimumWidth = 45;
            ColumnName_ZKA.Name = "ColumnName_ZKA";
            ColumnName_ZKA.Width = 45;
            // 
            // ColumnNumber_ZKA
            // 
            ColumnNumber_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnNumber_ZKA.HeaderText = "Номер телефона";
            ColumnNumber_ZKA.MinimumWidth = 80;
            ColumnNumber_ZKA.Name = "ColumnNumber_ZKA";
            ColumnNumber_ZKA.Width = 80;
            // 
            // ColumnSubject_ZKA
            // 
            ColumnSubject_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnSubject_ZKA.HeaderText = "Предмет";
            ColumnSubject_ZKA.MinimumWidth = 60;
            ColumnSubject_ZKA.Name = "ColumnSubject_ZKA";
            ColumnSubject_ZKA.Width = 60;
            // 
            // ColumnAge_ZKA
            // 
            ColumnAge_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnAge_ZKA.HeaderText = "Возраст";
            ColumnAge_ZKA.MinimumWidth = 60;
            ColumnAge_ZKA.Name = "ColumnAge_ZKA";
            ColumnAge_ZKA.Width = 60;
            // 
            // ColumnAudienceNumber_ZKA
            // 
            ColumnAudienceNumber_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnAudienceNumber_ZKA.HeaderText = "Номер аудитории";
            ColumnAudienceNumber_ZKA.MinimumWidth = 80;
            ColumnAudienceNumber_ZKA.Name = "ColumnAudienceNumber_ZKA";
            ColumnAudienceNumber_ZKA.Width = 80;
            // 
            // ColumnExperience_ZKA
            // 
            ColumnExperience_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnExperience_ZKA.HeaderText = "Опыт работы";
            ColumnExperience_ZKA.MinimumWidth = 60;
            ColumnExperience_ZKA.Name = "ColumnExperience_ZKA";
            ColumnExperience_ZKA.Width = 60;
            // 
            // ColumnHoursPerWeek_ZKA
            // 
            ColumnHoursPerWeek_ZKA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnHoursPerWeek_ZKA.HeaderText = "Количество часов в неделю";
            ColumnHoursPerWeek_ZKA.MinimumWidth = 85;
            ColumnHoursPerWeek_ZKA.Name = "ColumnHoursPerWeek_ZKA";
            ColumnHoursPerWeek_ZKA.Width = 85;
            // 
            // openFileDialogImport_ZKA
            // 
            openFileDialogImport_ZKA.FileName = "DataMain.csv";
            openFileDialogImport_ZKA.InitialDirectory = "C:\\DataSprint7";
            // 
            // saveFileDialogExport_ZKA
            // 
            saveFileDialogExport_ZKA.FileName = "OutPutTask7.csv";
            saveFileDialogExport_ZKA.InitialDirectory = "C:\\DataSprint7\\FileSave";
            // 
            // toolTip_ZKA
            // 
            toolTip_ZKA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_ZKA.ToolTipTitle = "Подсказка";
            // 
            // buttonMore_ZKA
            // 
            buttonMore_ZKA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMore_ZKA.Cursor = Cursors.Hand;
            buttonMore_ZKA.Enabled = false;
            buttonMore_ZKA.FlatStyle = FlatStyle.Popup;
            buttonMore_ZKA.Font = new Font("Segoe UI", 7F);
            buttonMore_ZKA.Location = new Point(863, 0);
            buttonMore_ZKA.Margin = new Padding(0);
            buttonMore_ZKA.Name = "buttonMore_ZKA";
            buttonMore_ZKA.Size = new Size(21, 23);
            buttonMore_ZKA.TabIndex = 1;
            toolTip_ZKA.SetToolTip(buttonMore_ZKA, "Дополнительные сведения");
            buttonMore_ZKA.UseVisualStyleBackColor = true;
            buttonMore_ZKA.Click += buttonMore_ZKA_Click;
            // 
            // labelSelected_ZKA
            // 
            labelSelected_ZKA.Location = new Point(13, 3);
            labelSelected_ZKA.Name = "labelSelected_ZKA";
            labelSelected_ZKA.Size = new Size(85, 15);
            labelSelected_ZKA.TabIndex = 0;
            labelSelected_ZKA.Text = "Выбрано: ";
            labelSelected_ZKA.Visible = false;
            // 
            // panelStatistics_ZKA
            // 
            panelStatistics_ZKA.BackColor = Color.Gainsboro;
            panelStatistics_ZKA.Controls.Add(buttonMore_ZKA);
            panelStatistics_ZKA.Controls.Add(labelSelected_ZKA);
            panelStatistics_ZKA.Dock = DockStyle.Bottom;
            panelStatistics_ZKA.Location = new Point(0, 437);
            panelStatistics_ZKA.Margin = new Padding(0);
            panelStatistics_ZKA.Name = "panelStatistics_ZKA";
            panelStatistics_ZKA.Padding = new Padding(5);
            panelStatistics_ZKA.Size = new Size(884, 24);
            panelStatistics_ZKA.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 461);
            Controls.Add(panelGrid_ZKA);
            Controls.Add(panelMenu_ZKA);
            Controls.Add(panelStatistics_ZKA);
            MinimumSize = new Size(900, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Преподаватели Университета";
            Load += FormMain_Load;
            panelMenu_ZKA.ResumeLayout(false);
            TabBarNavigation_ZKA.ResumeLayout(false);
            tabPageFile_ZKA.ResumeLayout(false);
            groupBoxFile_ZKA.ResumeLayout(false);
            groupBoxFile_ZKA.PerformLayout();
            tabPageMain_ZKA.ResumeLayout(false);
            groupBoxSearch_ZKA.ResumeLayout(false);
            groupBoxSearch_ZKA.PerformLayout();
            groupBoxEdit_ZKA.ResumeLayout(false);
            groupBoxEdit_ZKA.PerformLayout();
            tabPageInformation_ZKA.ResumeLayout(false);
            groupBoxInformation_ZKA.ResumeLayout(false);
            groupBoxInformation_ZKA.PerformLayout();
            panelGrid_ZKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_ZKA).EndInit();
            panelStatistics_ZKA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu_ZKA;
        private Panel panelGrid_ZKA;
        private OpenFileDialog openFileDialogImport_ZKA;
        private SaveFileDialog saveFileDialogExport_ZKA;
        private DataGridView dataGridViewMainGrid_ZKA;
        private DataGridViewTextBoxColumn ColumnID_ZKA;
        private DataGridViewTextBoxColumn ColumnName_ZKA;
        private DataGridViewTextBoxColumn ColumnNumber_ZKA;
        private DataGridViewTextBoxColumn ColumnSubject_ZKA;
        private DataGridViewTextBoxColumn ColumnAge_ZKA;
        private DataGridViewTextBoxColumn ColumnAudienceNumber_ZKA;
        private DataGridViewTextBoxColumn ColumnExperience_ZKA;
        private DataGridViewTextBoxColumn ColumnHoursPerWeek_ZKA;
        private ToolTip toolTip_ZKA;
        private Label labelSelected_ZKA;
        private Panel panelStatistics_ZKA;
        private TabControl TabBarNavigation_ZKA;
        private TabPage tabPageFile_ZKA;
        private GroupBox groupBoxFile_ZKA;
        private Button buttonExport_ZKA;
        private Label labelExport_ZKA;
        private Label labelImport_ZKA;
        private Button buttonImport_ZKA;
        private TabPage tabPageMain_ZKA;
        private GroupBox groupBoxSearch_ZKA;
        private Button buttonSearch_ZKA;
        private TextBox textBoxSearch_ZKA;
        private GroupBox groupBoxEdit_ZKA;
        private Label labelRemoveRow_ZKA;
        private Label labelAddRow_ZKA;
        private Button buttonRemoveRow_ZKA;
        private Button buttonAddRow_ZKA;
        private TabPage tabPageInformation_ZKA;
        private Button buttonMore_ZKA;
        private GroupBox groupBoxInformation_ZKA;
        private Label labelDevoleper_ZKA;
        private Button buttonВeveloper_ZKA;
        private Button buttonGuide_ZKA;
        private Label labelHelp_ZKA;
    }
}
