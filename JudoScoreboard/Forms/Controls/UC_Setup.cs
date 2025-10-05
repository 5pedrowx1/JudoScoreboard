

namespace JudoScoreboard.Forms.Controls
{
    public partial class UC_Setup : UserControl
    {
        public event Action<string, string, int, string>? OnStartMatch;

        public UC_Setup()
        {
            InitializeComponent();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            string nomeAzul = txtLutadorAzul.Text;
            string nomeBranco = txtLutadorBranco.Text;
            int tempo = (int)numMinutes.Value * 60;
            string categoria = txtCategoria.Text;

            OnStartMatch?.Invoke(nomeAzul, nomeBranco, tempo, categoria);
        }
    }
}
