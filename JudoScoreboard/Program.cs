using JudoScoreboard.Forms;

namespace JudoScoreboard
{
    internal static class Program
    {
        private static FormDisplay? displayForm;
        private static FormControl? controlForm;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Criar FormDisplay (Público - Tela cheia)
            displayForm = new FormDisplay();
            displayForm.Show();

            // Criar FormControl (Arbitragem - Janela menor)
            controlForm = new FormControl();

            // Quando o controle fecha, fechar o display também
            controlForm.FormClosed += (s, e) =>
            {
                displayForm?.Close();
                Application.Exit();
            };

            // Conectar sincronização (será implementado no FormControl)
            // Quando houver mudança no FormControl, atualizar o FormDisplay

            Application.Run(controlForm);
        }
    }
}