using JudoScoreboard.Core;

namespace JudoScoreboard.Forms
{
    public partial class FormDisplay : Form
    {
        private bool isGoldenScore = false;
        private System.Windows.Forms.Timer animationTimer;
        private int animationFrame = 0;

        public FormDisplay()
        {
            InitializeComponent();
            this.Load += FormDisplay_Load;
            this.KeyPreview = true;
            this.KeyDown += FormDisplay_KeyDown;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 500;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            if (isGoldenScore && lblTimer.Text.Contains("GOLDEN"))
            {
                animationFrame++;
                lblTimer.ForeColor = animationFrame % 2 == 0
                    ? Color.Gold
                    : Color.FromArgb(255, 200, 0);
            }
        }

        private void FormDisplay_Load(object? sender, EventArgs e)
        {
            lblEstado.Text = "";
            ResetarShidos();
            ApplyInitialStyles();
        }

        private void ApplyInitialStyles()
        {
            lblShido3Branco.Text = "";
            lblShido3Azul.Text = "";
        }

        private void FormDisplay_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else if (e.KeyCode == Keys.F11)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        public void AtualizarDisplay(MatchData data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AtualizarDisplay(data)));
                return;
            }

            // Atualizar nomes
            UpdateLabelWithTransition(lblNomeBranco, data.NomeBranco.ToUpper());
            UpdateLabelWithTransition(lblNomeAzul, data.NomeAzul.ToUpper());
            UpdateLabelWithTransition(lblCategoria, data.Categoria.ToUpper());

            // Atualizar timer
            if (data.IsGoldenScore && data.TempoRestante == 0)
            {
                lblTimer.Text = "GOLDEN\nSCORE";
                lblTimer.Font = new Font("Segoe UI Black", 90F, FontStyle.Bold);
                lblTimer.ForeColor = Color.Gold;
                animationTimer.Start();
            }
            else
            {
                animationTimer.Stop();
                int minutos = data.TempoRestante / 60;
                int segundos = data.TempoRestante % 60;
                lblTimer.Text = $"{minutos}:{segundos:D2}";
                lblTimer.Font = new Font("Segoe UI Black", 180F, FontStyle.Bold);

                if (data.TempoRestante <= 10 && data.IsRunning && data.TempoRestante > 0)
                {
                    lblTimer.ForeColor = Color.FromArgb(255, 50, 50);
                }
                else if (data.TempoRestante <= 30 && data.IsRunning && data.TempoRestante > 0)
                {
                    lblTimer.ForeColor = Color.FromArgb(255, 140, 0);
                }
                else if (data.IsRunning)
                {
                    lblTimer.ForeColor = Color.FromArgb(0, 255, 100);
                }
                else
                {
                    lblTimer.ForeColor = Color.FromArgb(200, 0, 0);
                }
            }

            isGoldenScore = data.IsGoldenScore;

            // Atualizar estado
            UpdateEstado(data);

            // Atualizar pontuações com animação
            UpdateScoreWithAnimation(lblIpponBranco, data.IpponBranco);
            UpdateScoreWithAnimation(lblWazaBranco, data.WazaBranco);
            UpdateScoreWithAnimation(lblYukoBranco, data.YukoBranco);
            UpdateScoreWithAnimation(lblIpponAzul, data.IpponAzul);
            UpdateScoreWithAnimation(lblWazaAzul, data.WazaAzul);
            UpdateScoreWithAnimation(lblYukoAzul, data.YukoAzul);

            // Atualizar Shidos
            AtualizarShidos(lblShido1Branco, lblShido2Branco, lblShido3Branco, data.ShidoBranco, false);
            AtualizarShidos(lblShido1Azul, lblShido2Azul, lblShido3Azul, data.ShidoAzul, true);

            // Verificar vencedor
            VerificarVencedor(data);

            this.Refresh();
        }

        private void UpdateLabelWithTransition(Guna.UI2.WinForms.Guna2HtmlLabel label, string newText)
        {
            if (label.Text != newText)
            {
                label.Text = newText;
            }
        }

        private void UpdateScoreWithAnimation(Guna.UI2.WinForms.Guna2HtmlLabel label, int newValue)
        {
            string newText = newValue.ToString();
            if (label.Text != newText)
            {
                var originalSize = label.Font.Size;
                label.Font = new Font(label.Font.FontFamily, originalSize * 1.15f, label.Font.Style);
                label.Text = newText;

                Task.Delay(150).ContinueWith(t =>
                {
                    if (this.IsHandleCreated && !this.IsDisposed)
                    {
                        try
                        {
                            this.Invoke(new Action(() =>
                            {
                                if (label != null && !label.IsDisposed)
                                    label.Font = new Font(label.Font.FontFamily, originalSize, label.Font.Style);
                            }));
                        }
                        catch { }
                    }
                });
            }
        }

        private void UpdateEstado(MatchData data)
        {
            if (isGoldenScore && data.IsRunning)
            {
                lblEstado.Text = "HAJIME";
                lblEstado.ForeColor = Color.Gold;
            }
            else if (isGoldenScore && !data.IsRunning)
            {
                lblEstado.Text = "GOLDEN SCORE";
                lblEstado.ForeColor = Color.Yellow;
            }
            else if (!data.IsRunning && data.TempoRestante > 0)
            {
                lblEstado.Text = "MATTE";
                lblEstado.ForeColor = Color.Orange;
            }
            else if (data.IsRunning)
            {
                lblEstado.Text = "HAJIME";
                lblEstado.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblEstado.Text = "";
            }
        }

        private void VerificarVencedor(MatchData data)
        {
            string vencedor = "";
            bool azulVenceu = false;

            if (data.IpponBranco > 0 || data.WazaBranco >= 2 || data.ShidoAzul >= 3)
            {
                vencedor = data.NomeBranco.ToUpper();
                HighlightVencedor(PanelBranco, lblNomeBranco, true);
                ResetHighlight(PanelAzul, lblNomeAzul, false);
            }
            else if (data.IpponAzul > 0 || data.WazaAzul >= 2 || data.ShidoBranco >= 3)
            {
                vencedor = data.NomeAzul.ToUpper();
                azulVenceu = true;
                HighlightVencedor(PanelAzul, lblNomeAzul, false);
                ResetHighlight(PanelBranco, lblNomeBranco, true);
            }
            else
            {
                ResetHighlight(PanelBranco, lblNomeBranco, true);
                ResetHighlight(PanelAzul, lblNomeAzul, false);
            }

            if (!string.IsNullOrEmpty(vencedor))
            {
                lblEstado.Text = $"{vencedor}";
                lblEstado.ForeColor = azulVenceu ? Color.Cyan : Color.Gold;
            }
        }

        private void AtualizarShidos(
            Guna.UI2.WinForms.Guna2CircleButton shido1,
            Guna.UI2.WinForms.Guna2CircleButton shido2,
            Guna.UI2.WinForms.Guna2CircleButton shido3,
            int quantidade,
            bool isAzul)
        {
            Color activeColor = Color.FromArgb(255, 220, 0);
            Color inactiveColor = isAzul ? Color.FromArgb(0, 41, 107) : Color.FromArgb(220, 220, 220);
            Color redColor = Color.FromArgb(220, 20, 20);

            // Reset
            shido1.FillColor = inactiveColor;
            shido2.FillColor = inactiveColor;
            shido3.FillColor = inactiveColor;
            shido1.Text = "";
            shido2.Text = "";
            shido3.Text = "";

            if (quantidade >= 1)
            {
                shido1.FillColor = activeColor;
                shido1.Text = "●";
                shido1.Font = new Font("Arial", 32F, FontStyle.Bold);
                shido1.ForeColor = Color.Black;
            }
            if (quantidade >= 2)
            {
                shido2.FillColor = activeColor;
                shido2.Text = "●";
                shido2.Font = new Font("Arial", 32F, FontStyle.Bold);
                shido2.ForeColor = Color.Black;
            }
            if (quantidade >= 3)
            {
                shido3.FillColor = redColor;
                shido3.Text = "H";
                shido3.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold);
                shido3.ForeColor = Color.White;
            }
        }

        private void ResetarShidos()
        {
            Color brancoCor = Color.FromArgb(220, 220, 220);
            Color azulCor = Color.FromArgb(0, 41, 107);

            lblShido1Branco.FillColor = brancoCor;
            lblShido2Branco.FillColor = brancoCor;
            lblShido3Branco.FillColor = brancoCor;
            lblShido1Branco.Text = "";
            lblShido2Branco.Text = "";
            lblShido3Branco.Text = "";

            lblShido1Azul.FillColor = azulCor;
            lblShido2Azul.FillColor = azulCor;
            lblShido3Azul.FillColor = azulCor;
            lblShido1Azul.Text = "";
            lblShido2Azul.Text = "";
            lblShido3Azul.Text = "";
        }

        private void HighlightVencedor(
            Guna.UI2.WinForms.Guna2GradientPanel panel,
            Guna.UI2.WinForms.Guna2HtmlLabel label,
            bool isBranco)
        {
            if (isBranco)
            {
                panel.FillColor = Color.FromArgb(255, 215, 0);
                panel.FillColor2 = Color.FromArgb(255, 180, 0);
                label.ForeColor = Color.Black;
                lblIpponBranco.ForeColor = Color.Black;
                lblWazaBranco.ForeColor = Color.Black;
                lblYukoBranco.ForeColor = Color.Black;
                lblScoreTextBranco.ForeColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                panel.FillColor = Color.FromArgb(0, 180, 255);
                panel.FillColor2 = Color.FromArgb(0, 140, 255);
                label.ForeColor = Color.White;
                lblIpponAzul.ForeColor = Color.White;
                lblWazaAzul.ForeColor = Color.White;
                lblYukoAzul.ForeColor = Color.White;
                lblScoreTextAzul.ForeColor = Color.White;
            }
        }

        private void ResetHighlight(
            Guna.UI2.WinForms.Guna2GradientPanel panel,
            Guna.UI2.WinForms.Guna2HtmlLabel label,
            bool isBranco)
        {
            if (isBranco)
            {
                panel.FillColor = Color.FromArgb(245, 245, 245);
                panel.FillColor2 = Color.White;
                label.ForeColor = Color.FromArgb(40, 40, 40);
                lblIpponBranco.ForeColor = Color.FromArgb(40, 40, 40);
                lblWazaBranco.ForeColor = Color.FromArgb(80, 80, 80);
                lblYukoBranco.ForeColor = Color.FromArgb(120, 120, 120);
                lblScoreTextBranco.ForeColor = Color.Gray;
            }
            else
            {
                panel.FillColor = Color.FromArgb(0, 71, 187);
                panel.FillColor2 = Color.FromArgb(0, 51, 153);
                label.ForeColor = Color.White;
                lblIpponAzul.ForeColor = Color.White;
                lblWazaAzul.ForeColor = Color.FromArgb(200, 200, 200);
                lblYukoAzul.ForeColor = Color.FromArgb(180, 180, 180);
                lblScoreTextAzul.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        public void MostrarMensagem(string mensagem, Color cor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MostrarMensagem(mensagem, cor)));
                return;
            }

            lblEstado.Text = mensagem;
            lblEstado.ForeColor = cor;
        }

        public void IniciarGoldenScore()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(IniciarGoldenScore));
                return;
            }

            isGoldenScore = true;
            lblEstado.Text = "GOLDEN SCORE";
            lblEstado.ForeColor = Color.Yellow;
            animationTimer.Start();
        }

        public void ResetarDisplay()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ResetarDisplay));
                return;
            }

            animationTimer.Stop();
            isGoldenScore = false;

            lblNomeAzul.Text = "BLUE";
            lblNomeBranco.Text = "WHITE";
            lblCategoria.Text = "-81 KG";
            lblTimer.Text = "3:00";
            lblTimer.Font = new Font("Segoe UI Black", 180F, FontStyle.Bold);
            lblEstado.Text = "";

            lblIpponAzul.Text = "0";
            lblWazaAzul.Text = "0";
            lblYukoAzul.Text = "0";
            lblIpponBranco.Text = "0";
            lblWazaBranco.Text = "0";
            lblYukoBranco.Text = "0";

            ResetarShidos();

            // Restaurar cores
            PanelAzul.FillColor = Color.FromArgb(0, 71, 187);
            PanelAzul.FillColor2 = Color.FromArgb(0, 51, 153);
            PanelBranco.FillColor = Color.FromArgb(245, 245, 245);
            PanelBranco.FillColor2 = Color.White;

            lblNomeAzul.ForeColor = Color.White;
            lblNomeBranco.ForeColor = Color.FromArgb(40, 40, 40);
            lblTimer.ForeColor = Color.FromArgb(0, 255, 100);
            lblEstado.ForeColor = Color.White;

            lblIpponAzul.ForeColor = Color.White;
            lblWazaAzul.ForeColor = Color.FromArgb(200, 200, 200);
            lblYukoAzul.ForeColor = Color.FromArgb(180, 180, 180);
            lblScoreTextAzul.ForeColor = Color.FromArgb(200, 200, 200);

            lblIpponBranco.ForeColor = Color.FromArgb(40, 40, 40);
            lblWazaBranco.ForeColor = Color.FromArgb(80, 80, 80);
            lblYukoBranco.ForeColor = Color.FromArgb(120, 120, 120);
            lblScoreTextBranco.ForeColor = Color.Gray;
        }
    }
}