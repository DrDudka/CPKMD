namespace CPKMD.Forms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            labelProgramNumber = new Label();
            textBoxProgramNumber = new TextBox();
            labelProgramName = new Label();
            comboBoxProgramName = new ComboBox();
            labelTrainingForm = new Label();
            comboBoxTrainingForm = new ComboBox();
            labelHours = new Label();
            numericUpDownHours = new NumericUpDown();
            labelCost = new Label();
            numericUpDownCost = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // labelProgramNumber
            // 
            labelProgramNumber.AutoSize = true;
            labelProgramNumber.Location = new Point(12, 20);
            labelProgramNumber.Name = "labelProgramNumber";
            labelProgramNumber.Size = new Size(117, 15);
            labelProgramNumber.TabIndex = 0;
            labelProgramNumber.Text = "Номер программы:";
            // 
            // textBoxProgramNumber
            // 
            textBoxProgramNumber.Location = new Point(148, 19);
            textBoxProgramNumber.Name = "textBoxProgramNumber";
            textBoxProgramNumber.Size = new Size(150, 23);
            textBoxProgramNumber.TabIndex = 1;
            // 
            // labelProgramName
            // 
            labelProgramName.AutoSize = true;
            labelProgramName.Location = new Point(12, 50);
            labelProgramName.Name = "labelProgramName";
            labelProgramName.Size = new Size(131, 15);
            labelProgramName.TabIndex = 2;
            labelProgramName.Text = "Название программы:";
            // 
            // comboBoxProgramName
            // 
            comboBoxProgramName.FormattingEnabled = true;
            comboBoxProgramName.Location = new Point(148, 48);
            comboBoxProgramName.Name = "comboBoxProgramName";
            comboBoxProgramName.Size = new Size(150, 23);
            comboBoxProgramName.TabIndex = 3;
            // 
            // labelTrainingForm
            // 
            labelTrainingForm.AutoSize = true;
            labelTrainingForm.Location = new Point(12, 80);
            labelTrainingForm.Name = "labelTrainingForm";
            labelTrainingForm.Size = new Size(104, 15);
            labelTrainingForm.TabIndex = 4;
            labelTrainingForm.Text = "Форма обучения:";
            // 
            // comboBoxTrainingForm
            // 
            comboBoxTrainingForm.FormattingEnabled = true;
            comboBoxTrainingForm.Location = new Point(148, 77);
            comboBoxTrainingForm.Name = "comboBoxTrainingForm";
            comboBoxTrainingForm.Size = new Size(150, 23);
            comboBoxTrainingForm.TabIndex = 5;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Location = new Point(12, 110);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(39, 15);
            labelHours.TabIndex = 6;
            labelHours.Text = "Часы:";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Location = new Point(148, 106);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(150, 23);
            numericUpDownHours.TabIndex = 7;
            numericUpDownHours.Value = new decimal(new int[] { 36, 0, 0, 0 });
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(12, 140);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(70, 15);
            labelCost.TabIndex = 8;
            labelCost.Text = "Стоимость:";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.Location = new Point(148, 136);
            numericUpDownCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(150, 23);
            numericUpDownCost.TabIndex = 9;
            numericUpDownCost.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(148, 169);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 30);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(229, 169);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(69, 30);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 220);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownCost);
            Controls.Add(labelCost);
            Controls.Add(numericUpDownHours);
            Controls.Add(labelHours);
            Controls.Add(comboBoxTrainingForm);
            Controls.Add(labelTrainingForm);
            Controls.Add(comboBoxProgramName);
            Controls.Add(labelProgramName);
            Controls.Add(textBoxProgramNumber);
            Controls.Add(labelProgramNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Программа";
            Load += ProgramForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelProgramNumber;
        private System.Windows.Forms.TextBox textBoxProgramNumber;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.ComboBox comboBoxProgramName;
        private System.Windows.Forms.Label labelTrainingForm;
        private System.Windows.Forms.ComboBox comboBoxTrainingForm;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}