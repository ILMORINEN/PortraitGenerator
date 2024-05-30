namespace PortraitGenerator
{
    partial class Form
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
            textBoxElementsPath = new TextBox();
            buttonSelectElementsFolder = new Button();
            label1 = new Label();
            rbGenderMale = new RadioButton();
            rbGenderFemale = new RadioButton();
            groupBox1 = new GroupBox();
            textBoxSkinColor = new TextBox();
            label2 = new Label();
            textBoxFaceType = new TextBox();
            label4 = new Label();
            pictureBox = new PictureBox();
            buttonGenerate = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            textBoxResultPath = new TextBox();
            buttonSelectResultFolder = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxElementsPath
            // 
            textBoxElementsPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxElementsPath.Location = new Point(12, 27);
            textBoxElementsPath.Name = "textBoxElementsPath";
            textBoxElementsPath.Size = new Size(570, 23);
            textBoxElementsPath.TabIndex = 0;
            // 
            // buttonSelectElementsFolder
            // 
            buttonSelectElementsFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelectElementsFolder.Location = new Point(588, 27);
            buttonSelectElementsFolder.Name = "buttonSelectElementsFolder";
            buttonSelectElementsFolder.Size = new Size(75, 23);
            buttonSelectElementsFolder.TabIndex = 1;
            buttonSelectElementsFolder.Text = "Обзор";
            buttonSelectElementsFolder.UseVisualStyleBackColor = true;
            buttonSelectElementsFolder.Click += buttonSelectElementsFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Путь с исходниками";
            // 
            // rbGenderMale
            // 
            rbGenderMale.AutoSize = true;
            rbGenderMale.Location = new Point(6, 22);
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.Size = new Size(77, 19);
            rbGenderMale.TabIndex = 3;
            rbGenderMale.TabStop = true;
            rbGenderMale.Text = "Мужской";
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            rbGenderFemale.AutoSize = true;
            rbGenderFemale.Location = new Point(6, 47);
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.Size = new Size(75, 19);
            rbGenderFemale.TabIndex = 4;
            rbGenderFemale.TabStop = true;
            rbGenderFemale.Text = "Женский";
            rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbGenderMale);
            groupBox1.Controls.Add(rbGenderFemale);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(104, 73);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пол";
            // 
            // textBoxSkinColor
            // 
            textBoxSkinColor.Location = new Point(12, 194);
            textBoxSkinColor.Name = "textBoxSkinColor";
            textBoxSkinColor.Size = new Size(108, 23);
            textBoxSkinColor.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Цвет кожи";
            // 
            // textBoxFaceType
            // 
            textBoxFaceType.Location = new Point(12, 238);
            textBoxFaceType.Name = "textBoxFaceType";
            textBoxFaceType.Size = new Size(108, 23);
            textBoxFaceType.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 2;
            label4.Text = "Тип лица";
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(126, 100);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(537, 399);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(12, 267);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(108, 39);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Создать";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxResultPath
            // 
            textBoxResultPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResultPath.Location = new Point(12, 71);
            textBoxResultPath.Name = "textBoxResultPath";
            textBoxResultPath.Size = new Size(570, 23);
            textBoxResultPath.TabIndex = 0;
            // 
            // buttonSelectResultFolder
            // 
            buttonSelectResultFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelectResultFolder.Location = new Point(588, 71);
            buttonSelectResultFolder.Name = "buttonSelectResultFolder";
            buttonSelectResultFolder.Size = new Size(75, 23);
            buttonSelectResultFolder.TabIndex = 1;
            buttonSelectResultFolder.Text = "Обзор";
            buttonSelectResultFolder.UseVisualStyleBackColor = true;
            buttonSelectResultFolder.Click += buttonSelectResultFolder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Путь с исходниками";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 514);
            Controls.Add(pictureBox);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxFaceType);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonSelectResultFolder);
            Controls.Add(buttonSelectElementsFolder);
            Controls.Add(textBoxSkinColor);
            Controls.Add(textBoxResultPath);
            Controls.Add(textBoxElementsPath);
            Name = "Form";
            Text = "Генератор лиц";
            FormClosed += Form_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxElementsPath;
        private Button buttonSelectElementsFolder;
        private Label label1;
        private RadioButton rbGenderMale;
        private RadioButton rbGenderFemale;
        private GroupBox groupBox1;
        private TextBox textBoxSkinColor;
        private Label label2;
        private TextBox textBoxFaceType;
        private Label label4;
        private PictureBox pictureBox;
        private Button buttonGenerate;
        private FolderBrowserDialog folderBrowserDialog;
        private TextBox textBoxResultPath;
        private Button buttonSelectResultFolder;
        private Label label3;
    }
}
