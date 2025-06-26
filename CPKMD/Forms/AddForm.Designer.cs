namespace CPKMD.Forms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            buttonCancel = new Button();
            buttonAdd = new Button();
            labelProgramName = new Label();
            textBoxProgramName = new TextBox();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.Font = new Font("Segoe UI", 14.25F);
            buttonCancel.Location = new Point(875, 104);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 44);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DarkTurquoise;
            buttonAdd.Font = new Font("Segoe UI", 14.25F);
            buttonAdd.Location = new Point(875, 54);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 44);
            buttonAdd.TabIndex = 22;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelProgramName
            // 
            labelProgramName.AutoSize = true;
            labelProgramName.Font = new Font("Segoe UI", 14.25F);
            labelProgramName.Location = new Point(12, 9);
            labelProgramName.Name = "labelProgramName";
            labelProgramName.Size = new Size(204, 25);
            labelProgramName.TabIndex = 14;
            labelProgramName.Text = "Название программы:";
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Font = new Font("Segoe UI", 12F);
            textBoxProgramName.Location = new Point(222, 9);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(803, 29);
            textBoxProgramName.TabIndex = 24;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 159);
            Controls.Add(textBoxProgramName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(labelProgramName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новая программа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonAdd;
        private Label labelProgramName;
        private TextBox textBoxProgramName;
    }
}