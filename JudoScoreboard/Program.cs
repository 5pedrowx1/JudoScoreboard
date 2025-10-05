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

            // Criar FormDisplay (P�blico - Tela cheia)
            displayForm = new FormDisplay();
            displayForm.Show();

            // Criar FormControl (Arbitragem - Janela menor)
            controlForm = new FormControl();

            // Quando o controle fecha, fechar o display tamb�m
            controlForm.FormClosed += (s, e) =>
            {
                displayForm?.Close();
                Application.Exit();
            };

            // Conectar sincroniza��o (ser� implementado no FormControl)
            // Quando houver mudan�a no FormControl, atualizar o FormDisplay

            Application.Run(controlForm);
        }
    }
}