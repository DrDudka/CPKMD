namespace CPKMD
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridViewPrograms = new DataGridView();
            comboBoxTrainingForm = new ComboBox();
            textBoxSearch = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            labelTrainingForm = new Label();
            labelSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrograms).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPrograms
            // 
            dataGridViewPrograms.AllowUserToAddRows = false;
            dataGridViewPrograms.AllowUserToDeleteRows = false;
            dataGridViewPrograms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrograms.BackgroundColor = Color.DarkTurquoise;
            dataGridViewPrograms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrograms.Location = new Point(12, 84);
            dataGridViewPrograms.Name = "dataGridViewPrograms";
            dataGridViewPrograms.ReadOnly = true;
            dataGridViewPrograms.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.World, 204);
            dataGridViewPrograms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrograms.Size = new Size(1011, 340);
            dataGridViewPrograms.TabIndex = 0;
            dataGridViewPrograms.CellDoubleClick += dataGridViewPrograms_CellDoubleClick;
            // 
            // comboBoxTrainingForm
            // 
            comboBoxTrainingForm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrainingForm.Font = new Font("Segoe UI", 14.25F);
            comboBoxTrainingForm.FormattingEnabled = true;
            comboBoxTrainingForm.Location = new Point(182, 40);
            comboBoxTrainingForm.Name = "comboBoxTrainingForm";
            comboBoxTrainingForm.Size = new Size(180, 33);
            comboBoxTrainingForm.TabIndex = 1;
            comboBoxTrainingForm.SelectedIndexChanged += comboBoxTrainingForm_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 14.25F);
            textBoxSearch.Location = new Point(625, 40);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(250, 33);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkTurquoise;
            buttonAdd.Font = new Font("Segoe UI", 14.25F);
            buttonAdd.Location = new Point(12, 430);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 41);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Tomato;
            buttonDelete.Font = new Font("Segoe UI", 14.25F);
            buttonDelete.Location = new Point(148, 430);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(137, 41);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.DarkTurquoise;
            buttonRefresh.Font = new Font("Segoe UI", 14.25F);
            buttonRefresh.Location = new Point(896, 39);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(127, 37);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelTrainingForm
            // 
            labelTrainingForm.AutoSize = true;
            labelTrainingForm.Font = new Font("Segoe UI", 14.25F);
            labelTrainingForm.Location = new Point(12, 43);
            labelTrainingForm.Name = "labelTrainingForm";
            labelTrainingForm.Size = new Size(164, 25);
            labelTrainingForm.TabIndex = 7;
            labelTrainingForm.Text = "Форма обучения:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 14.25F);
            labelSearch.Location = new Point(431, 45);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(188, 25);
            labelSearch.TabIndex = 8;
            labelSearch.Text = "Поиск по названию:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 596);
            Controls.Add(labelSearch);
            Controls.Add(labelTrainingForm);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxTrainingForm);
            Controls.Add(dataGridViewPrograms);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление образовательными услугами";
            WindowState = FormWindowState.Maximized;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrograms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrograms;
        private System.Windows.Forms.ComboBox comboBoxTrainingForm;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelTrainingForm;
        private System.Windows.Forms.Label labelSearch;
    }
}