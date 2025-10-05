namespace JudoScoreboard
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Criar o FormDisplay (tela pública)
            var formDisplay = new Forms.FormDisplay();
            formDisplay.Show();

            // Criar o FormControl (tela de arbitragem)
            var formControl = new Forms.FormControl();

            // IMPORTANTE: Conectar os dois formulários
            formControl.DisplayForm = formDisplay;

            // Posicionar as janelas
            // FormDisplay em tela cheia no monitor principal
            formDisplay.StartPosition = FormStartPosition.Manual;
            formDisplay.Location = Screen.PrimaryScreen!.Bounds.Location;
            formDisplay.WindowState = FormWindowState.Maximized;

            // FormControl em janela menor (pode ser em segundo monitor)
            formControl.StartPosition = FormStartPosition.Manual;
            formControl.Location = new Point(100, 100);
            formControl.WindowState = FormWindowState.Normal;

            Application.Run(formControl);
        }
    }
}