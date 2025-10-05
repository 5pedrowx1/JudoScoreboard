using JudoScoreboard.Core;

namespace JudoScoreboard.Forms.Controls
{
    public partial class UC_Score : UserControl
    {
        public event Action<MatchData>? OnMatchDataChanged;
        public event Action? OnBackToSetup;

        private int ipponAzul = 0;
        private int wazaAzul = 0;
        private int yukoAzul = 0;
        private int shidoAzul = 0;

        private int ipponBranco = 0;
        private int wazaBranco = 0;
        private int yukoBranco = 0;
        private int shidoBranco = 0;

        private int tempoRestante;
        private int tempoTotal;
        private bool isRunning = false;
        private bool isGoldenScore = false;

        private string nomeAzul = "";
        private string nomeBranco = "";
        private string categoria = "";

        private enum LastAction
        {
            None,
            IpponAzul, WazaAzul, YukoAzul, ShidoAzul,
            IpponBranco, WazaBranco, YukoBranco, ShidoBranco
        }
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
            isGoldenScore = false;

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
                isGoldenScore = true;
                btnPlayPause.Text = "▶ GOLDEN SCORE";
                btnPlayPause.FillColor = Color.Gold;

                var result = MessageBox.Show(
                    "Tempo Esgotado! Iniciar Golden Score?",
                    "Golden Score",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    IniciarGoldenScore();
                }
                else
                {
                    DeterminarVencedor();
                }
            }
        }

        private void IniciarGoldenScore()
        {
            isGoldenScore = true;
            tempoRestante = 0;
            btnPlayPause.Text = "▶ CONTINUAR";
            btnPlayPause.FillColor = Color.Gold;
            NotificarMudanca();
        }

        private void AtualizarTimer()
        {
            if (isGoldenScore && tempoRestante == 0)
            {
                lblTimer.Text = "G.S.";
                lblTimer.ForeColor = Color.Gold;
            }
            else
            {
                int minutos = tempoRestante / 60;
                int segundos = tempoRestante % 60;
                lblTimer.Text = $"{minutos:D2}:{segundos:D2}";

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
        }

        private void AtualizarPontuacoes()
        {
            lblIpponAzul.Text = ipponAzul.ToString();
            lblWazaAzul.Text = wazaAzul.ToString();
            lblYukoAzul.Text = yukoAzul.ToString();
            lblShidoAzul.Text = shidoAzul.ToString();

            lblIpponBranco.Text = ipponBranco.ToString();
            lblWazaBranco.Text = wazaBranco.ToString();
            lblYukoBranco.Text = yukoBranco.ToString();
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
                YukoAzul = yukoAzul,
                ShidoAzul = shidoAzul,
                IpponBranco = ipponBranco,
                WazaBranco = wazaBranco,
                YukoBranco = yukoBranco,
                ShidoBranco = shidoBranco,
                IsRunning = isRunning,
                IsGoldenScore = isGoldenScore,
                Estado = isGoldenScore ? "Golden Score" : ""
            };

            OnMatchDataChanged?.Invoke(matchData);
        }

        // Botões Azul
        private void BtnIpponAzul_Click(object? sender, EventArgs e)
        {
            ipponAzul++;
            ultimaAcao = LastAction.IpponAzul;
            AtualizarPontuacoes();
            VerificarVitoria("AZUL");
        }

        private void BtnWazaAzul_Click(object? sender, EventArgs e)
        {
            wazaAzul++;
            ultimaAcao = LastAction.WazaAzul;
            AtualizarPontuacoes();

            if (wazaAzul >= 2)
            {
                VerificarVitoria("AZUL");
            }
        }

        private void BtnYukoAzul_Click(object? sender, EventArgs e)
        {
            yukoAzul++;
            ultimaAcao = LastAction.YukoAzul;
            AtualizarPontuacoes();
        }

        private void BtnShidoAzul_Click(object? sender, EventArgs e)
        {
            if (shidoAzul < 3)
            {
                shidoAzul++;
                ultimaAcao = LastAction.ShidoAzul;
                AtualizarPontuacoes();

                if (shidoAzul == 3)
                {
                    VerificarVitoria("BRANCO");
                }
            }
        }

        private void BtnRemoveAzul_Click(object? sender, EventArgs e)
        {
            switch (ultimaAcao)
            {
                case LastAction.IpponAzul:
                    if (ipponAzul > 0) ipponAzul--;
                    break;
                case LastAction.WazaAzul:
                    if (wazaAzul > 0) wazaAzul--;
                    break;
                case LastAction.YukoAzul:
                    if (yukoAzul > 0) yukoAzul--;
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
            VerificarVitoria("BRANCO");
        }

        private void BtnWazaBranco_Click(object? sender, EventArgs e)
        {
            wazaBranco++;
            ultimaAcao = LastAction.WazaBranco;
            AtualizarPontuacoes();

            if (wazaBranco >= 2)
            {
                VerificarVitoria("BRANCO");
            }
        }

        private void BtnYukoBranco_Click(object? sender, EventArgs e)
        {
            yukoBranco++;
            ultimaAcao = LastAction.YukoBranco;
            AtualizarPontuacoes();
        }

        private void BtnShidoBranco_Click(object? sender, EventArgs e)
        {
            if (shidoBranco < 3)
            {
                shidoBranco++;
                ultimaAcao = LastAction.ShidoBranco;
                AtualizarPontuacoes();

                if (shidoBranco == 3)
                {
                    VerificarVitoria("AZUL");
                }
            }
        }

        private void BtnRemoveBranco_Click(object? sender, EventArgs e)
        {
            switch (ultimaAcao)
            {
                case LastAction.IpponBranco:
                    if (ipponBranco > 0) ipponBranco--;
                    break;
                case LastAction.WazaBranco:
                    if (wazaBranco > 0) wazaBranco--;
                    break;
                case LastAction.YukoBranco:
                    if (yukoBranco > 0) yukoBranco--;
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
                timer.Stop();
                isRunning = false;
                btnPlayPause.Text = "▶ CONTINUAR";
                btnPlayPause.FillColor = Color.Green;
            }
            else
            {
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
                isGoldenScore = false;

                ipponAzul = 0;
                wazaAzul = 0;
                yukoAzul = 0;
                shidoAzul = 0;

                ipponBranco = 0;
                wazaBranco = 0;
                yukoBranco = 0;
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

        private void VerificarVitoria(string vencedor)
        {
            timer.Stop();
            isRunning = false;
            btnPlayPause.Text = "▶ INICIAR";
            btnPlayPause.FillColor = Color.Green;

            string nomeVencedor = vencedor == "AZUL" ? nomeAzul : nomeBranco;

            lblVitoria.Text = $"Vencedor: {nomeVencedor} ({vencedor})";

            NotificarMudanca();
        }

        private void DeterminarVencedor()
        {
            // Lógica de desempate por pontos
            int pontosAzul = (ipponAzul * 100) + (wazaAzul * 10) + (yukoAzul * 5) - (shidoAzul * 10);
            int pontosBranco = (ipponBranco * 100) + (wazaBranco * 10) + (yukoBranco * 5) - (shidoBranco * 10);

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