using JudoScoreboard.Core;
using JudoScoreboard.Forms.Controls;

namespace JudoScoreboard.Forms
{
    public partial class FormControl : Form
    {
        private UC_Setup? setupControl;
        private UC_Score? scoreControl;
        public FormDisplay? DisplayForm { get; set; }

        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            MostrarSetup();
        }

        private void MostrarSetup()
        {
            Panel_UC.Controls.Clear();

            setupControl = new UC_Setup();
            setupControl.Dock = DockStyle.Fill;
            setupControl.OnStartMatch += Setup_OnStartMatch;

            Panel_UC.Controls.Add(setupControl);
        }

        private void Setup_OnStartMatch(string nomeAzul, string nomeBranco, int tempo, string categoria)
        {
            // Validações
            if (string.IsNullOrWhiteSpace(nomeAzul) || string.IsNullOrWhiteSpace(nomeBranco))
            {
                MessageBox.Show("Por favor, preencha os nomes dos lutadores.", "Campos Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tempo <= 0)
            {
                MessageBox.Show("O tempo de luta deve ser maior que zero.", "Tempo Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mudar para tela de pontuação
            MostrarScore(nomeAzul, nomeBranco, tempo, categoria);
        }

        private void MostrarScore(string nomeAzul, string nomeBranco, int tempo, string categoria)
        {
            Panel_UC.Controls.Clear();

            scoreControl = new UC_Score();
            scoreControl.Dock = DockStyle.Fill;
            scoreControl.OnBackToSetup += Score_OnBackToSetup;
            scoreControl.OnMatchDataChanged += Score_OnMatchDataChanged;
            Panel_UC.Controls.Add(scoreControl);
            scoreControl.IniciarCombate(nomeAzul, nomeBranco, tempo, categoria);
        }

        private void Score_OnMatchDataChanged(MatchData data)
        {
            // Sincronizar com o FormDisplay
            DisplayForm?.AtualizarDisplay(data);

            // Aqui você pode adicionar mais lógica se necessário:
            // - Salvar em banco de dados
            // - Enviar para API
            // - Logar em arquivo
            // - Transmitir via rede
        }

        private void Score_OnBackToSetup()
        {
            MostrarSetup();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (scoreControl != null)
            {
                var result = MessageBox.Show(
                    "Tem certeza que deseja sair? O combate em andamento será perdido.",
                    "Confirmar Saída",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
            }

            this.Dispose();
            Application.Exit();
        }
    }
}