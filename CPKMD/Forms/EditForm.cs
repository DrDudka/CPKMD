using CPKMD.Data;
using CPKMD.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CPKMD.Forms
{
    public partial class EditForm : Form
    {
        private readonly CPKMEDContext _context;
        private EducationalProgram _program;

        public EditForm(CPKMEDContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            InitializeComponent();
        }

        public void LoadProgram(EducationalProgram program)
        {
            _program = program;
            textBoxProgramNumber.Text = program.ProgramNumber.ToString();
            comboBoxProgramName.SelectedValue = program.ProgramNameId;
            comboBoxTrainingForm.SelectedValue = program.TrainingFormId;
            numericUpDownHours.Value = program.Hours;
            numericUpDownCost.Value = program.Cost;
            Text = "Редактировать программу";
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            if (_program == null)
            {
                _program = new EducationalProgram();
                Text = "Добавить программу";
            }
        }

        private void LoadComboBoxes()
        {
            comboBoxProgramName.DataSource = _context.ProgramNames
                .Select(pn => new { pn.Id, pn.Name })
                .OrderBy(pn => pn.Name)
                .ToList();
            comboBoxProgramName.DisplayMember = "Name";
            comboBoxProgramName.ValueMember = "Id";

            comboBoxTrainingForm.DataSource = _context.TrainingForms
                .Select(tf => new { tf.Id, tf.Name })
                .OrderBy(tf => tf.Name)
                .ToList();
            comboBoxTrainingForm.DisplayMember = "Name";
            comboBoxTrainingForm.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxProgramNumber.Text, out int programNumber) || programNumber <= 0)
            {
                MessageBox.Show("Введите корректный номер программы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_context.EducationalPrograms.Any(ep => ep.ProgramNumber == programNumber && (_program.Id != ep.Id)))
            {
                MessageBox.Show("Программа с таким номером уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_program.Id == 0)
                {
                    _program.ProgramNumber = programNumber;
                    _program.ProgramNameId = (int)comboBoxProgramName.SelectedValue;
                    _program.TrainingFormId = (int)comboBoxTrainingForm.SelectedValue;
                    _program.Hours = (int)numericUpDownHours.Value;
                    _program.Cost = (int)numericUpDownCost.Value;
                    _context.EducationalPrograms.Add(_program);
                }
                else
                {
                    _context.Entry(_program).State = EntityState.Modified;
                    _program.ProgramNumber = programNumber;
                    _program.ProgramNameId = (int)comboBoxProgramName.SelectedValue;
                    _program.TrainingFormId = (int)comboBoxTrainingForm.SelectedValue;
                    _program.Hours = (int)numericUpDownHours.Value;
                    _program.Cost = (int)numericUpDownCost.Value;
                }
                _context.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

