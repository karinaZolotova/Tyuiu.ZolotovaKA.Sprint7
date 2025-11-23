namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormAbout
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
            pictureBoxAvatar_ZKA = new PictureBox();
            panelInfo_ZKA = new Panel();
            labelProject_ZKA = new Label();
            labelName_ZKA = new Label();
            labelGroup_ZKA = new Label();
            labelUniversity_ZKA = new Label();
            buttonOK_ZKA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZKA).BeginInit();
            panelInfo_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxAvatar_ZKA
            // 
            pictureBoxAvatar_ZKA.BackgroundImage = Properties.Resources.zka;
            pictureBoxAvatar_ZKA.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_ZKA.Location = new Point(20, 20);
            pictureBoxAvatar_ZKA.Name = "pictureBoxAvatar_ZKA";
            pictureBoxAvatar_ZKA.Size = new Size(150, 150);
            pictureBoxAvatar_ZKA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_ZKA.TabIndex = 0;
            pictureBoxAvatar_ZKA.TabStop = false;
            // 
            // panelInfo_ZKA
            // 
            panelInfo_ZKA.BorderStyle = BorderStyle.FixedSingle;
            panelInfo_ZKA.Controls.Add(labelProject_ZKA);
            panelInfo_ZKA.Controls.Add(labelName_ZKA);
            panelInfo_ZKA.Controls.Add(labelGroup_ZKA);
            panelInfo_ZKA.Controls.Add(labelUniversity_ZKA);
            panelInfo_ZKA.Location = new Point(190, 20);
            panelInfo_ZKA.Name = "panelInfo_ZKA";
            panelInfo_ZKA.Size = new Size(324, 150);
            panelInfo_ZKA.TabIndex = 1;
            // 
            // labelProject_ZKA
            // 
            labelProject_ZKA.AutoSize = true;
            labelProject_ZKA.Font = new Font("Segoe UI", 9F);
            labelProject_ZKA.Location = new Point(15, 105);
            labelProject_ZKA.Name = "labelProject_ZKA";
            labelProject_ZKA.Size = new Size(176, 30);
            labelProject_ZKA.TabIndex = 3;
            labelProject_ZKA.Text = "Проект: \"Система управления \r\nуниверситетом\"";
            // 
            // labelName_ZKA
            // 
            labelName_ZKA.AutoSize = true;
            labelName_ZKA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelName_ZKA.Location = new Point(15, 75);
            labelName_ZKA.Name = "labelName_ZKA";
            labelName_ZKA.Size = new Size(110, 20);
            labelName_ZKA.TabIndex = 2;
            labelName_ZKA.Text = "Золотова К.А.";
            // 
            // labelGroup_ZKA
            // 
            labelGroup_ZKA.AutoSize = true;
            labelGroup_ZKA.Font = new Font("Segoe UI", 10F);
            labelGroup_ZKA.Location = new Point(15, 45);
            labelGroup_ZKA.Name = "labelGroup_ZKA";
            labelGroup_ZKA.Size = new Size(134, 19);
            labelGroup_ZKA.TabIndex = 1;
            labelGroup_ZKA.Text = "Группа: ИСПб-24-1";
            // 
            // labelUniversity_ZKA
            // 
            labelUniversity_ZKA.AutoSize = true;
            labelUniversity_ZKA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelUniversity_ZKA.Location = new Point(15, 15);
            labelUniversity_ZKA.Name = "labelUniversity_ZKA";
            labelUniversity_ZKA.Size = new Size(303, 19);
            labelUniversity_ZKA.TabIndex = 0;
            labelUniversity_ZKA.Text = "Тюменский индустриальный университет";
            // 
            // buttonOK_ZKA
            // 
            buttonOK_ZKA.Location = new Point(374, 186);
            buttonOK_ZKA.Name = "buttonOK_ZKA";
            buttonOK_ZKA.Size = new Size(90, 30);
            buttonOK_ZKA.TabIndex = 2;
            buttonOK_ZKA.Text = "OK";
            buttonOK_ZKA.UseVisualStyleBackColor = true;
            buttonOK_ZKA.Click += buttonOK_ZKA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 231);
            Controls.Add(buttonOK_ZKA);
            Controls.Add(panelInfo_ZKA);
            Controls.Add(pictureBoxAvatar_ZKA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZKA).EndInit();
            panelInfo_ZKA.ResumeLayout(false);
            panelInfo_ZKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAvatar_ZKA;
        private Panel panelInfo_ZKA;
        private Label labelUniversity_ZKA;
        private Label labelGroup_ZKA;
        private Label labelName_ZKA;
        private Label labelProject_ZKA;
        private Button buttonOK_ZKA;
    }
}