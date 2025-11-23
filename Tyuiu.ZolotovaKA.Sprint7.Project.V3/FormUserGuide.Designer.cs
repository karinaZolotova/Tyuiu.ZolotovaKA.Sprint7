namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormUserGuide
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControlGuide_ZKA = new TabControl();
            tabPageMain_ZKA = new TabPage();
            richTextBoxGuide_ZKA = new RichTextBox();
            tabPageFunctions_ZKA = new TabPage();
            textBoxFunctions_ZKA = new TextBox();
            tabPageHotkeys_ZKA = new TabPage();
            textBoxHotkeys_ZKA = new TextBox();
            panelBottom_ZKA = new Panel();
            buttonClose_ZKA = new Button();
            panelTop_ZKA = new Panel();
            labelTitle_ZKA = new Label();
            tabControlGuide_ZKA.SuspendLayout();
            tabPageMain_ZKA.SuspendLayout();
            tabPageFunctions_ZKA.SuspendLayout();
            tabPageHotkeys_ZKA.SuspendLayout();
            panelBottom_ZKA.SuspendLayout();
            panelTop_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlGuide_ZKA
            // 
            tabControlGuide_ZKA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlGuide_ZKA.Controls.Add(tabPageMain_ZKA);
            tabControlGuide_ZKA.Controls.Add(tabPageFunctions_ZKA);
            tabControlGuide_ZKA.Controls.Add(tabPageHotkeys_ZKA);
            tabControlGuide_ZKA.Location = new Point(12, 50);
            tabControlGuide_ZKA.Name = "tabControlGuide_ZKA";
            tabControlGuide_ZKA.SelectedIndex = 0;
            tabControlGuide_ZKA.Size = new Size(560, 290);
            tabControlGuide_ZKA.TabIndex = 0;
            // 
            // tabPageMain_ZKA
            // 
            tabPageMain_ZKA.Controls.Add(richTextBoxGuide_ZKA);
            tabPageMain_ZKA.Location = new Point(4, 24);
            tabPageMain_ZKA.Name = "tabPageMain_ZKA";
            tabPageMain_ZKA.Padding = new Padding(3);
            tabPageMain_ZKA.Size = new Size(552, 262);
            tabPageMain_ZKA.TabIndex = 0;
            tabPageMain_ZKA.Text = "Основное";
            tabPageMain_ZKA.UseVisualStyleBackColor = true;
            // 
            // richTextBoxGuide_ZKA
            // 
            richTextBoxGuide_ZKA.BorderStyle = BorderStyle.None;
            richTextBoxGuide_ZKA.Dock = DockStyle.Fill;
            richTextBoxGuide_ZKA.Location = new Point(3, 3);
            richTextBoxGuide_ZKA.Name = "richTextBoxGuide_ZKA";
            richTextBoxGuide_ZKA.ReadOnly = true;
            richTextBoxGuide_ZKA.Size = new Size(546, 256);
            richTextBoxGuide_ZKA.TabIndex = 0;
            richTextBoxGuide_ZKA.Text = "";
            // 
            // tabPageFunctions_ZKA
            // 
            tabPageFunctions_ZKA.Controls.Add(textBoxFunctions_ZKA);
            tabPageFunctions_ZKA.Location = new Point(4, 24);
            tabPageFunctions_ZKA.Name = "tabPageFunctions_ZKA";
            tabPageFunctions_ZKA.Padding = new Padding(3);
            tabPageFunctions_ZKA.Size = new Size(552, 262);
            tabPageFunctions_ZKA.TabIndex = 1;
            tabPageFunctions_ZKA.Text = "Функции";
            tabPageFunctions_ZKA.UseVisualStyleBackColor = true;
            // 
            // textBoxFunctions_ZKA
            // 
            textBoxFunctions_ZKA.BorderStyle = BorderStyle.None;
            textBoxFunctions_ZKA.Dock = DockStyle.Fill;
            textBoxFunctions_ZKA.Location = new Point(3, 3);
            textBoxFunctions_ZKA.Multiline = true;
            textBoxFunctions_ZKA.Name = "textBoxFunctions_ZKA";
            textBoxFunctions_ZKA.ReadOnly = true;
            textBoxFunctions_ZKA.ScrollBars = ScrollBars.Vertical;
            textBoxFunctions_ZKA.Size = new Size(546, 256);
            textBoxFunctions_ZKA.TabIndex = 0;
            // 
            // tabPageHotkeys_ZKA
            // 
            tabPageHotkeys_ZKA.Controls.Add(textBoxHotkeys_ZKA);
            tabPageHotkeys_ZKA.Location = new Point(4, 24);
            tabPageHotkeys_ZKA.Name = "tabPageHotkeys_ZKA";
            tabPageHotkeys_ZKA.Padding = new Padding(3);
            tabPageHotkeys_ZKA.Size = new Size(552, 262);
            tabPageHotkeys_ZKA.TabIndex = 2;
            tabPageHotkeys_ZKA.Text = "Горячие клавиши";
            tabPageHotkeys_ZKA.UseVisualStyleBackColor = true;
            // 
            // textBoxHotkeys_ZKA
            // 
            textBoxHotkeys_ZKA.BorderStyle = BorderStyle.None;
            textBoxHotkeys_ZKA.Dock = DockStyle.Fill;
            textBoxHotkeys_ZKA.Location = new Point(3, 3);
            textBoxHotkeys_ZKA.Multiline = true;
            textBoxHotkeys_ZKA.Name = "textBoxHotkeys_ZKA";
            textBoxHotkeys_ZKA.ReadOnly = true;
            textBoxHotkeys_ZKA.ScrollBars = ScrollBars.Vertical;
            textBoxHotkeys_ZKA.Size = new Size(546, 256);
            textBoxHotkeys_ZKA.TabIndex = 0;
            // 
            // panelBottom_ZKA
            // 
            panelBottom_ZKA.Controls.Add(buttonClose_ZKA);
            panelBottom_ZKA.Dock = DockStyle.Bottom;
            panelBottom_ZKA.Location = new Point(0, 350);
            panelBottom_ZKA.Name = "panelBottom_ZKA";
            panelBottom_ZKA.Size = new Size(584, 41);
            panelBottom_ZKA.TabIndex = 1;
            // 
            // buttonClose_ZKA
            // 
            buttonClose_ZKA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose_ZKA.Location = new Point(472, 6);
            buttonClose_ZKA.Name = "buttonClose_ZKA";
            buttonClose_ZKA.Size = new Size(100, 30);
            buttonClose_ZKA.TabIndex = 0;
            buttonClose_ZKA.Text = "Закрыть";
            buttonClose_ZKA.UseVisualStyleBackColor = true;
            buttonClose_ZKA.Click += buttonClose_ZKA_Click;
            // 
            // panelTop_ZKA
            // 
            panelTop_ZKA.BackColor = SystemColors.ControlLight;
            panelTop_ZKA.Controls.Add(labelTitle_ZKA);
            panelTop_ZKA.Dock = DockStyle.Top;
            panelTop_ZKA.Location = new Point(0, 0);
            panelTop_ZKA.Name = "panelTop_ZKA";
            panelTop_ZKA.Size = new Size(584, 40);
            panelTop_ZKA.TabIndex = 2;
            // 
            // labelTitle_ZKA
            // 
            labelTitle_ZKA.AutoSize = true;
            labelTitle_ZKA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_ZKA.Location = new Point(12, 9);
            labelTitle_ZKA.Name = "labelTitle_ZKA";
            labelTitle_ZKA.Size = new Size(254, 21);
            labelTitle_ZKA.TabIndex = 0;
            labelTitle_ZKA.Text = "Руководство пользователя";
            // 
            // FormUserGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(tabControlGuide_ZKA);
            Controls.Add(panelTop_ZKA);
            Controls.Add(panelBottom_ZKA);
            MinimumSize = new Size(600, 430);
            Name = "FormUserGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            Load += FormUserGuide_Load;
            tabControlGuide_ZKA.ResumeLayout(false);
            tabPageMain_ZKA.ResumeLayout(false);
            tabPageFunctions_ZKA.ResumeLayout(false);
            tabPageFunctions_ZKA.PerformLayout();
            tabPageHotkeys_ZKA.ResumeLayout(false);
            tabPageHotkeys_ZKA.PerformLayout();
            panelBottom_ZKA.ResumeLayout(false);
            panelTop_ZKA.ResumeLayout(false);
            panelTop_ZKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlGuide_ZKA;
        private TabPage tabPageMain_ZKA;
        private TabPage tabPageFunctions_ZKA;
        private TabPage tabPageHotkeys_ZKA;
        private Panel panelBottom_ZKA;
        private Button buttonClose_ZKA;
        private RichTextBox richTextBoxGuide_ZKA;
        private TextBox textBoxFunctions_ZKA;
        private TextBox textBoxHotkeys_ZKA;
        private Panel panelTop_ZKA;
        private Label labelTitle_ZKA;
    }
}