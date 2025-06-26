using CPKMD.Data;
using CPKMD.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace CPKMD
{
    public partial class MainForm : Form
    {
        private readonly CPKMEDContext _context;

        public MainForm(CPKMEDContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTrainingForms();
            LoadPrograms();
        }

        private void LoadTrainingForms()
        {
            var forms = _context.TrainingForms
                .Select(tf => new { Value = tf.Id, Display = tf.Name })
                .ToList();
            forms.Insert(0, new { Value = 0, Display = "Все формы" });
            comboBoxTrainingForm.DataSource = forms;
            comboBoxTrainingForm.DisplayMember = "Display";
            comboBoxTrainingForm.ValueMember = "Value";
        }

        private void LoadPrograms()
        {
            int? trainingFormId = comboBoxTrainingForm.SelectedValue as int? ?? 0;
            if (trainingFormId > 0)
            {
                trainingFormId = trainingFormId;
            }
            else
            {
                trainingFormId = null;
            }

            var programs = _context.EducationalPrograms
                .Include(ep => ep.ProgramName)
                .Include(ep => ep.TrainingForm)
                .Where(ep => string.IsNullOrEmpty(textBoxSearch.Text) || ep.ProgramName.Name.Contains(textBoxSearch.Text))
                .Where(ep => !trainingFormId.HasValue || ep.TrainingFormId == trainingFormId)
                .Select(ep => new
                {
                    ep.Id,
                    ep.ProgramNumber,
                    ProgramName = ep.ProgramName.Name,
                    TrainingForm = ep.TrainingForm.Name,
                    ep.Hours,
                    ep.Cost
                })
                .OrderBy(ep => ep.ProgramNumber)
                .ToList();

            dataGridViewPrograms.DataSource = programs;
            dataGridViewPrograms.Columns["Id"].Visible = false;
            dataGridViewPrograms.Columns["ProgramNumber"].HeaderText = "№";
            dataGridViewPrograms.Columns["ProgramName"].HeaderText = "Название программы";
            dataGridViewPrograms.Columns["TrainingForm"].HeaderText = "Форма обучения";
            dataGridViewPrograms.Columns["Hours"].HeaderText = "Часы";
            dataGridViewPrograms.Columns["Cost"].HeaderText = "Стоимость (руб.)";
        }

        private void comboBoxTrainingForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPrograms();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPrograms();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadPrograms();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using var form = Program.ServiceProvider.GetService<EditForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPrograms();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrograms.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewPrograms.SelectedRows[0].Cells["Id"].Value;
                var program = _context.EducationalPrograms
                    .Include(ep => ep.ProgramName)
                    .Include(ep => ep.TrainingForm)
                    .FirstOrDefault(ep => ep.Id == id);
                if (program != null)
                {
                    using var form = Program.ServiceProvider.GetService<EditForm>();
                    form.LoadProgram(program);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadPrograms();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите программу для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrograms.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewPrograms.SelectedRows[0].Cells["Id"].Value;
                var program = _context.EducationalPrograms.Find(id);
                if (program != null)
                {
                    if (MessageBox.Show($"Удалить программу №{program.ProgramNumber}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _context.EducationalPrograms.Remove(program);
                        _context.SaveChanges();
                        LoadPrograms();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите программу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPrograms_CellDoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewPrograms.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewPrograms.SelectedRows[0].Cells["Id"].Value;
                var program = _context.EducationalPrograms
                    .Include(ep => ep.ProgramName)
                    .Include(ep => ep.TrainingForm)
                    .FirstOrDefault(ep => ep.Id == id);
                if (program != null)
                {
                    using var form = Program.ServiceProvider.GetService<EditForm>();
                    form.LoadProgram(program);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadPrograms();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите программу для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
