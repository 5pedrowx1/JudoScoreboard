using JudoScoreboard.Core;

namespace JudoScoreboard.Forms.Controls
{
    public partial class UC_Score : UserControl
    {
        public event Action<MatchData>? OnMatchDataChanged;
        public event Action? OnBackToSetup;

        private int ipponAzul = 0;
        private int wazaAzul = 0;
        private int shidoAzul = 0;

        private int ipponBranco = 0;
        private int wazaBranco = 0;
        private int shidoBranco = 0;

        private int tempoRestante; 
        private int tempoTotal;
        private bool isRunning = false;

        private string nomeAzul = "";
        private string nomeBranco = "";
        private string categoria = "";

        private enum LastAction { None, IpponAzul, WazaAzul, ShidoAzul, IpponBranco, WazaBranco, ShidoBranco }
        private LastAction ultimaAcao = LastAction.None;

        public UC_Score()
        {
            InitializeComponent();
        }

        public void IniciarCombate(string nAzul, string nBranco, int tempo, string cat)
        {
            nomeAzul = nAzul;
            nomeBranco = nBranco;
            tempoTotal = tempo;
            tempoRestante = tempo;
            categoria = cat;

            lblNomeAzul.Text = nomeAzul;
            lblNomeBranco.Text = nomeBranco;
            lblCategoria.Text = categoria;

            AtualizarTimer();
            AtualizarPontuacoes();
            NotificarMudanca();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (tempoRestante > 0)
            {
                tempoRestante--;
                AtualizarTimer();
                NotificarMudanca();
            }
            else
            {
                timer.Stop();
                isRunning = false;
                btnPlayPause.Text = "▶ INICIAR";
                btnPlayPause.FillColor = Color.Green;
                MessageBox.Show("Tempo Esgotado!", "Fim do Combate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeterminarVencedor();
            }
        }

        private void AtualizarTimer()
        {
            int minutos = tempoRestante / 60;
            int segundos = tempoRestante % 60;
            lblTimer.Text = $"{minutos:D2}:{segundos:D2}";

            // Mudar cor quando menos de 30 segundos
            if (tempoRestante <= 30 && tempoRestante > 0)
            {
                lblTimer.ForeColor = Color.Orange;
            }
            else if (tempoRestante == 0)
            {
                lblTimer.ForeColor = Color.Red;
            }
            else
            {
                lblTimer.ForeColor = Color.LightGreen;
            }
        }

        private void AtualizarPontuacoes()
        {
            lblIpponAzul.Text = ipponAzul.ToString();
            lblWazaAzul.Text = wazaAzul.ToString();
            lblShidoAzul.Text = shidoAzul.ToString();

            lblIpponBranco.Text = ipponBranco.ToString();
            lblWazaBranco.Text = wazaBranco.ToString();
            lblShidoBranco.Text = shidoBranco.ToString();

            NotificarMudanca();
        }

        private void NotificarMudanca()
        {
            var matchData = new MatchData
            {
                NomeAzul = nomeAzul,
                NomeBranco = nomeBranco,
                Categoria = categoria,
                TempoRestante = tempoRestante,
                IpponAzul = ipponAzul,
                WazaAzul = wazaAzul,
                ShidoAzul = shidoAzul,
                IpponBranco = ipponBranco,
                WazaBranco = wazaBranco,
                ShidoBranco = shidoBranco,
                IsRunning = isRunning
            };

            OnMatchDataChanged?.Invoke(matchData);
        }

        // Botões Azul
        private void BtnIpponAzul_Click(object? sender, EventArgs e)
        {
            ipponAzul++;
            ultimaAcao = LastAction.IpponAzul;
            AtualizarPontuacoes();
            VerificarVitoria("AZUL", "IPPON");
        }

        private void BtnWazaAzul_Click(object? sender, EventArgs e)
        {
            wazaAzul++;
            ultimaAcao = LastAction.WazaAzul;
            AtualizarPontuacoes();

            // 2 Waza-ari = Ippon
            if (wazaAzul >= 2)
            {
                VerificarVitoria("AZUL", "2x WAZA-ARI = IPPON");
            }
        }

        private void BtnShidoAzul_Click(object? sender, EventArgs e)
        {
            if (shidoAzul < 3)
            {
                shidoAzul++;
                ultimaAcao = LastAction.ShidoAzul;
                AtualizarPontuacoes();

                // 3 Shidos = Hansoku-make (desqualificação)
                if (shidoAzul == 3)
                {
                    VerificarVitoria("BRANCO", "HANSOKU-MAKE (3 Shidos do Azul)");
                }
            }
        }

        private void BtnRemoveAzul_Click(object? sender, EventArgs e)
        {
            // Remove a última ação do lutador azul
            switch (ultimaAcao)
            {
                case LastAction.IpponAzul:
                    if (ipponAzul > 0) ipponAzul--;
                    break;
                case LastAction.WazaAzul:
                    if (wazaAzul > 0) wazaAzul--;
                    break;
                case LastAction.ShidoAzul:
                    if (shidoAzul > 0) shidoAzul--;
                    break;
            }
            ultimaAcao = LastAction.None;
            AtualizarPontuacoes();
        }

        // Botões Branco
        private void BtnIpponBranco_Click(object? sender, EventArgs e)
        {
            ipponBranco++;
            ultimaAcao = LastAction.IpponBranco;
            AtualizarPontuacoes();
            VerificarVitoria("BRANCO", "IPPON");
        }

        private void BtnWazaBranco_Click(object? sender, EventArgs e)
        {
            wazaBranco++;
            ultimaAcao = LastAction.WazaBranco;
            AtualizarPontuacoes();

            // 2 Waza-ari = Ippon
            if (wazaBranco >= 2)
            {
                VerificarVitoria("BRANCO", "2x WAZA-ARI = IPPON");
            }
        }

        private void BtnShidoBranco_Click(object? sender, EventArgs e)
        {
            if (shidoBranco < 3)
            {
                shidoBranco++;
                ultimaAcao = LastAction.ShidoBranco;
                AtualizarPontuacoes();

                // 3 Shidos = Hansoku-make (desqualificação)
                if (shidoBranco == 3)
                {
                    VerificarVitoria("AZUL", "HANSOKU-MAKE (3 Shidos do Branco)");
                }
            }
        }

        private void BtnRemoveBranco_Click(object? sender, EventArgs e)
        {
            // Remove a última ação do lutador branco
            switch (ultimaAcao)
            {
                case LastAction.IpponBranco:
                    if (ipponBranco > 0) ipponBranco--;
                    break;
                case LastAction.WazaBranco:
                    if (wazaBranco > 0) wazaBranco--;
                    break;
                case LastAction.ShidoBranco:
                    if (shidoBranco > 0) shidoBranco--;
                    break;
            }
            ultimaAcao = LastAction.None;
            AtualizarPontuacoes();
        }

        // Controles
        private void BtnPlayPause_Click(object? sender, EventArgs e)
        {
            if (isRunning)
            {
                // Pausar
                timer.Stop();
                isRunning = false;
                btnPlayPause.Text = "▶ CONTINUAR";
                btnPlayPause.FillColor = Color.Green;
            }
            else
            {
                // Iniciar/Continuar
                timer.Start();
                isRunning = true;
                btnPlayPause.Text = "⏸ PAUSAR";
                btnPlayPause.FillColor = Color.Orange;
            }
            NotificarMudanca();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmente resetar o combate?",
                "Confirmar Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                timer.Stop();
                isRunning = false;

                ipponAzul = 0;
                wazaAzul = 0;
                shidoAzul = 0;

                ipponBranco = 0;
                wazaBranco = 0;
                shidoBranco = 0;

                tempoRestante = tempoTotal;
                ultimaAcao = LastAction.None;

                btnPlayPause.Text = "▶ INICIAR";
                btnPlayPause.FillColor = Color.Green;

                AtualizarTimer();
                AtualizarPontuacoes();
            }
        }

        private void BtnVoltar_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja voltar à configuração? O combate atual será perdido.",
                "Voltar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                timer.Stop();
                OnBackToSetup?.Invoke();
            }
        }

        private void VerificarVitoria(string vencedor, string motivo)
        {
            timer.Stop();
            isRunning = false;
            btnPlayPause.Text = "▶ INICIAR";
            btnPlayPause.FillColor = Color.Green;

            string nomeVencedor = vencedor == "AZUL" ? nomeAzul : nomeBranco;

            MessageBox.Show(
                $"Vencedor: {nomeVencedor}\nMotivo: {motivo}",
                "Fim do Combate",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            NotificarMudanca();
        }

        private void DeterminarVencedor()
        {
            // Lógica de desempate por pontos
            int pontosAzul = (ipponAzul * 10) + (wazaAzul * 5) - shidoAzul;
            int pontosBranco = (ipponBranco * 10) + (wazaBranco * 5) - shidoBranco;

            string resultado;
            if (pontosAzul > pontosBranco)
            {
                resultado = $"Vencedor: {nomeAzul} (AZUL) por pontos";
            }
            else if (pontosBranco > pontosAzul)
            {
                resultado = $"Vencedor: {nomeBranco} (BRANCO) por pontos";
            }
            else
            {
                // Em caso de empate, quem tem menos shidos vence
                if (shidoAzul < shidoBranco)
                {
                    resultado = $"Vencedor: {nomeAzul} (AZUL) - menos penalidades";
                }
                else if (shidoBranco < shidoAzul)
                {
                    resultado = $"Vencedor: {nomeBranco} (BRANCO) - menos penalidades";
                }
                else
                {
                    resultado = "EMPATE - Golden Score necessário";
                }
            }

            MessageBox.Show(resultado, "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}