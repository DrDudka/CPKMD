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
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            SuspendLayout();
            // 
            // labelProgramNumber
            // 
            labelProgramNumber.AutoSize = true;
            labelProgramNumber.Font = new Font("Segoe UI", 14.25F);
            labelProgramNumber.Location = new Point(12, 32);
            labelProgramNumber.Name = "labelProgramNumber";
            labelProgramNumber.Size = new Size(179, 25);
            labelProgramNumber.TabIndex = 0;
            labelProgramNumber.Text = "Номер программы:";
            // 
            // textBoxProgramNumber
            // 
            textBoxProgramNumber.Font = new Font("Segoe UI", 12F);
            textBoxProgramNumber.Location = new Point(222, 28);
            textBoxProgramNumber.Name = "textBoxProgramNumber";
            textBoxProgramNumber.Size = new Size(150, 29);
            textBoxProgramNumber.TabIndex = 1;
            // 
            // labelProgramName
            // 
            labelProgramName.AutoSize = true;
            labelProgramName.Font = new Font("Segoe UI", 14.25F);
            labelProgramName.Location = new Point(12, 67);
            labelProgramName.Name = "labelProgramName";
            labelProgramName.Size = new Size(204, 25);
            labelProgramName.TabIndex = 2;
            labelProgramName.Text = "Название программы:";
            // 
            // comboBoxProgramName
            // 
            comboBoxProgramName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgramName.Font = new Font("Segoe UI", 12F);
            comboBoxProgramName.FormattingEnabled = true;
            comboBoxProgramName.Location = new Point(222, 63);
            comboBoxProgramName.Name = "comboBoxProgramName";
            comboBoxProgramName.Size = new Size(786, 29);
            comboBoxProgramName.TabIndex = 3;
            // 
            // labelTrainingForm
            // 
            labelTrainingForm.AutoSize = true;
            labelTrainingForm.Font = new Font("Segoe UI", 14.25F);
            labelTrainingForm.Location = new Point(12, 104);
            labelTrainingForm.Name = "labelTrainingForm";
            labelTrainingForm.Size = new Size(164, 25);
            labelTrainingForm.TabIndex = 4;
            labelTrainingForm.Text = "Форма обучения:";
            // 
            // comboBoxTrainingForm
            // 
            comboBoxTrainingForm.Font = new Font("Segoe UI", 12F);
            comboBoxTrainingForm.FormattingEnabled = true;
            comboBoxTrainingForm.Location = new Point(222, 100);
            comboBoxTrainingForm.Name = "comboBoxTrainingForm";
            comboBoxTrainingForm.Size = new Size(150, 29);
            comboBoxTrainingForm.TabIndex = 5;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 14.25F);
            labelHours.Location = new Point(12, 142);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(61, 25);
            labelHours.TabIndex = 6;
            labelHours.Text = "Часы:";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Font = new Font("Segoe UI", 12F);
            numericUpDownHours.Location = new Point(222, 138);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(150, 29);
            numericUpDownHours.TabIndex = 7;
            numericUpDownHours.Value = new decimal(new int[] { 36, 0, 0, 0 });
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 14.25F);
            labelCost.Location = new Point(12, 178);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(109, 25);
            labelCost.TabIndex = 8;
            labelCost.Text = "Стоимость:";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.Font = new Font("Segoe UI", 12F);
            numericUpDownCost.Location = new Point(222, 174);
            numericUpDownCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(150, 29);
            numericUpDownCost.TabIndex = 9;
            numericUpDownCost.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkTurquoise;
            buttonSave.Font = new Font("Segoe UI", 14.25F);
            buttonSave.Location = new Point(899, 209);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 44);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.Font = new Font("Segoe UI", 14.25F);
            buttonCancel.Location = new Point(899, 259);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 44);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkTurquoise;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(1014, 63);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(35, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 315);
            Controls.Add(buttonAdd);
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
            FormClosed += EditForm_FormClosed;
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
        private Button buttonAdd;
    }
}