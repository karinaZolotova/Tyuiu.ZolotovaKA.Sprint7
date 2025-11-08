namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormAbout
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
            pictureBoxAvatar_ZKA = new PictureBox();
            labelInformation_ZKA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZKA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_ZKA
            // 
            pictureBoxAvatar_ZKA.Location = new Point(12, 12);
            pictureBoxAvatar_ZKA.Name = "pictureBoxAvatar_ZKA";
            pictureBoxAvatar_ZKA.Size = new Size(193, 371);
            pictureBoxAvatar_ZKA.TabIndex = 2;
            pictureBoxAvatar_ZKA.TabStop = false;
            // 
            // labelInformation_ZKA
            // 
            labelInformation_ZKA.Font = new Font("Segoe UI", 14F);
            labelInformation_ZKA.Location = new Point(230, 140);
            labelInformation_ZKA.Name = "labelInformation_ZKA";
            labelInformation_ZKA.Size = new Size(342, 110);
            labelInformation_ZKA.TabIndex = 1;
            labelInformation_ZKA.Text = "Выполнила студентка ТИУ\r\nгруппы ИСПб-24-1\r\nЗолотова К.А.";
            labelInformation_ZKA.Click += labelInformation_ZKA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(labelInformation_ZKA);
            Controls.Add(pictureBoxAvatar_ZKA);
            MaximizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Разработчик";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_ZKA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAvatar_ZKA;
        private Label labelInformation_ZKA;
    }
}
