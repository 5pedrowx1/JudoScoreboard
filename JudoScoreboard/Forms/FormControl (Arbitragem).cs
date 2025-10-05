using JudoScoreboard.Forms.Controls;

namespace JudoScoreboard.Forms
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            UC_Setup setup = new UC_Setup();
            setup.Dock = DockStyle.Fill;
            Panel_UC.Controls.Add(setup);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
