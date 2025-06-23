using CPKMD.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CPKMD
{
    public partial class AuthForm : Form
    {
        private readonly CPKMEDContext _context;
        private readonly AuthService _authService;

        public AuthForm(CPKMEDContext context, AuthService authService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            int userId = _authService.AuthUser(login, password);

            if (userId == -1)
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mainForm = Program.ServiceProvider.GetService<MainForm>();
            mainForm.Show();
            this.Hide();
        }
    }
}
