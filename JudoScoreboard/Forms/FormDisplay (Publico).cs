using JudoScoreboard.Core;

namespace JudoScoreboard.Forms
{
    public partial class FormDisplay : Form
    {
        private bool isGoldenScore = false;

        public FormDisplay()
        {
            InitializeComponent();
            this.Load += FormDisplay_Load;
            this.KeyPreview = true;
            this.KeyDown += FormDisplay_KeyDown;
        }

        private void FormDisplay_Load(object? sender, EventArgs e)
        {
            lblEstado.Text = "";
            ResetarShidos();
        }

        private void FormDisplay_KeyDown(object? sender, KeyEventArgs e)
        {
            // Pressionar ESC para sair do fullscreen
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            // F11 para fullscreen
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
            lblNomeBranco.Text = data.NomeBranco.ToUpper();
            lblNomeAzul.Text = data.NomeAzul.ToUpper();
            lblCategoria.Text = data.Categoria.ToUpper();

            // Atualizar timer
            if (data.IsGoldenScore && data.TempoRestante == 0)
            {
                lblTimer.Text = "G.S.";
                lblTimer.ForeColor = Color.Gold;
            }
            else
            {
                int minutos = data.TempoRestante / 60;
                int segundos = data.TempoRestante % 60;
                lblTimer.Text = $"{minutos}:{segundos:D2}";

                if (data.TempoRestante <= 30 && data.IsRunning && data.TempoRestante > 0)
                {
                    lblTimer.ForeColor = Color.Orange;
                }
                else if (data.IsRunning)
                {
                    lblTimer.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else
                {
                    lblTimer.ForeColor = Color.Red;
                }
            }

            // Detectar Golden Score
            isGoldenScore = data.IsGoldenScore;

            // Estado
            if (isGoldenScore && data.IsRunning)
            {
                lblEstado.Text = "Continue";
                lblEstado.ForeColor = Color.Gold;
            }
            else if (isGoldenScore && !data.IsRunning)
            {
                lblEstado.Text = "Golden Score";
                lblEstado.ForeColor = Color.Yellow;
            }
            else if (!data.IsRunning && data.TempoRestante > 0)
            {
                lblEstado.Text = "Matte";
                lblEstado.ForeColor = Color.Orange;
            }
            else
            {
                lblEstado.Text = "";
            }

            // Atualizar pontuações
            lblIpponBranco.Text = data.IpponBranco.ToString();
            lblWazaBranco.Text = data.WazaBranco.ToString();
            lblYukoBranco.Text = data.YukoBranco.ToString();
            lblIpponAzul.Text = data.IpponAzul.ToString();
            lblWazaAzul.Text = data.WazaAzul.ToString();
            lblYukoAzul.Text = data.YukoAzul.ToString();

            // Atualizar Shidos com indicador visual
            AtualizarShidos(lblShido1Branco, lblShido2Branco, lblShido3Branco, data.ShidoBranco, false);
            AtualizarShidos(lblShido1Azul, lblShido2Azul, lblShido3Azul, data.ShidoAzul, true);

            // Verificar vencedor
            string vencedor = "";
            if (data.IpponBranco > 0 || data.WazaBranco >= 2 || data.ShidoAzul >= 3)
            {
                vencedor = "WHITE";
                HighlightVencedor(PanelBranco, lblNomeBranco, true);
                ResetHighlight(PanelAzul, lblNomeAzul, false);
            }
            else if (data.IpponAzul > 0 || data.WazaAzul >= 2 || data.ShidoBranco >= 3)
            {
                vencedor = "BLUE";
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
                lblEstado.Text = $"Winner {vencedor}";
                lblEstado.ForeColor = vencedor == "BLUE" ? Color.Cyan : Color.White;
            }

            this.Refresh();
        }

        private void AtualizarShidos(Label shido1, Label shido2, Label shido3, int quantidade, bool isAzul)
        {
            Color activeColor = Color.Yellow;
            Color inactiveColor = isAzul ? Color.FromArgb(0, 51, 153) : Color.White;
            Color redColor = Color.Red;

            // Resetar todos
            shido1.BackColor = inactiveColor;
            shido2.BackColor = inactiveColor;
            shido3.BackColor = inactiveColor;
            shido1.Text = "";
            shido2.Text = "";
            shido3.Text = "";
            shido1.ForeColor = Color.Black;
            shido2.ForeColor = Color.Black;
            shido3.ForeColor = Color.Black;

            // Ativar os shidos necessários
            if (quantidade >= 1)
            {
                shido1.BackColor = activeColor;
            }
            if (quantidade >= 2)
            {
                shido2.BackColor = activeColor;
            }
            if (quantidade >= 3)
            {
                shido3.BackColor = redColor;
                shido3.Text = "H";
                shido3.Font = new Font("Arial Black", 20F, FontStyle.Bold);
                shido3.ForeColor = Color.White;
                shido3.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void ResetarShidos()
        {
            // Branco
            lblShido1Branco.BackColor = Color.White;
            lblShido2Branco.BackColor = Color.White;
            lblShido3Branco.BackColor = Color.White;
            lblShido1Branco.Text = "";
            lblShido2Branco.Text = "";
            lblShido3Branco.Text = "";

            // Azul
            lblShido1Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido2Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido3Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido1Azul.Text = "";
            lblShido2Azul.Text = "";
            lblShido3Azul.Text = "";
        }

        private void HighlightVencedor(Guna.UI2.WinForms.Guna2Panel panel, Guna.UI2.WinForms.Guna2HtmlLabel label, bool isBranco)
        {
            if (isBranco)
            {
                panel.BackColor = Color.FromArgb(255, 215, 0); // Dourado
                label.ForeColor = Color.Black;
                lblIpponBranco.ForeColor = Color.Black;
                lblWazaBranco.ForeColor = Color.Black;
                lblYukoBranco.ForeColor = Color.Black;
            }
            else
            {
                panel.BackColor = Color.FromArgb(0, 200, 255); // Azul claro
                label.ForeColor = Color.Black;
                lblIpponAzul.ForeColor = Color.Black;
                lblWazaAzul.ForeColor = Color.Black;
                lblYukoAzul.ForeColor = Color.Black;
            }
        }

        private void ResetHighlight(Guna.UI2.WinForms.Guna2Panel panel, Guna.UI2.WinForms.Guna2HtmlLabel label, bool isBranco)
        {
            if (isBranco)
            {
                panel.BackColor = Color.White;
                label.ForeColor = Color.Black;
                lblIpponBranco.ForeColor = Color.Black;
                lblWazaBranco.ForeColor = Color.Black;
                lblYukoBranco.ForeColor = Color.Black;
            }
            else
            {
                panel.BackColor = Color.FromArgb(0, 51, 153);
                label.ForeColor = Color.White;
                lblIpponAzul.ForeColor = Color.White;
                lblWazaAzul.ForeColor = Color.White;
                lblYukoAzul.ForeColor = Color.White;
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
            lblEstado.Text = "Golden Score";
            lblEstado.ForeColor = Color.Yellow;
            lblTimer.Text = "G.S.";
            lblTimer.ForeColor = Color.Gold;
        }

        public void ResetarDisplay()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ResetarDisplay));
                return;
            }

            isGoldenScore = false;

            lblNomeAzul.Text = "BLUE";
            lblNomeBranco.Text = "WHITE";
            lblCategoria.Text = "-81 kg";
            lblTimer.Text = "0:00";
            lblEstado.Text = "";

            lblIpponAzul.Text = "0";
            lblWazaAzul.Text = "0";
            lblYukoAzul.Text = "0";
            lblIpponBranco.Text = "0";
            lblWazaBranco.Text = "0";
            lblYukoBranco.Text = "0";

            ResetarShidos();

            // Restaurar cores
            PanelAzul.BackColor = Color.FromArgb(0, 51, 153);
            PanelBranco.BackColor = Color.White;
            lblNomeAzul.ForeColor = Color.White;
            lblNomeBranco.ForeColor = Color.Black;
            lblTimer.ForeColor = Color.FromArgb(0, 255, 0);
            lblEstado.ForeColor = Color.White;

            lblIpponAzul.ForeColor = Color.White;
            lblWazaAzul.ForeColor = Color.White;
            lblYukoAzul.ForeColor = Color.White;
            lblIpponBranco.ForeColor = Color.Black;
            lblWazaBranco.ForeColor = Color.Black;
            lblYukoBranco.ForeColor = Color.Black;
        }
    }
}