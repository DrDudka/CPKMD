using Npgsql;

namespace CPKMD.Forms
{
    public partial class AddForm : Form
    {
        private readonly string connectionString = "Host=localhost;Database=CPKMED;Username=postgres;Password=123;Port=5433";

        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using NpgsqlConnection connection = new(connectionString);
                connection.Open();

                string query = @"
                        INSERT INTO program_names 
                        (name) 
                        VALUES 
                        (@name)";

                using NpgsqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@name", textBoxProgramName.Text);


                if (!string.IsNullOrEmpty(textBoxProgramName.Text))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Заполните данные!", "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Ошибка: Заполните данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBoxProgramName.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
