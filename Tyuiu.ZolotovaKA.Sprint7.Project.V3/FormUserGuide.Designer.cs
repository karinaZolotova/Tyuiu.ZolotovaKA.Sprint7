namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormUserGuide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserGuide));
            groupBoxHelp_ZKA = new GroupBox();
            textBox1 = new TextBox();
            groupBoxHelp_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHelp_ZKA
            // 
            groupBoxHelp_ZKA.Controls.Add(textBox1);
            groupBoxHelp_ZKA.Dock = DockStyle.Fill;
            groupBoxHelp_ZKA.Location = new Point(0, 0);
            groupBoxHelp_ZKA.Name = "groupBoxHelp_ZKA";
            groupBoxHelp_ZKA.Size = new Size(584, 391);
            groupBoxHelp_ZKA.TabIndex = 0;
            groupBoxHelp_ZKA.TabStop = false;
            groupBoxHelp_ZKA.Text = "Помощь";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(578, 369);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormUserGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(groupBoxHelp_ZKA);
            MaximizeBox = false;
            MaximumSize = new Size(600, 430);
            Name = "FormUserGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            groupBoxHelp_ZKA.ResumeLayout(false);
            groupBoxHelp_ZKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHelp_ZKA;
        private TextBox textBox1;
    }
}
