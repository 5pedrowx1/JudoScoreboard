using JudoScoreboard.Forms.Controls;

namespace JudoScoreboard.Forms
{
    public partial class FormDisplay : Form
    {
        private Label lblNomeAzul;
        private Label lblNomeBranco;
        private Label lblCategoria;
        private Label lblTimer;
        private Label lblIpponAzul;
        private Label lblWazaAzul;
        private Label lblShidoAzul;
        private Label lblIpponBranco;
        private Label lblWazaBranco;
        private Label lblShidoBranco;
        private Panel panelAzul;
        private Panel panelBranco;
        private Panel panelCentro;

        public FormDisplay()
        {
            InitializeComponent();
            InicializarComponentesDisplay();
        }

        private void InicializarComponentesDisplay()
        {
            this.BackColor = Color.FromArgb(15, 15, 15);

            // Panel Azul (Esquerda)
            panelAzul = new Panel
            {
                BackColor = Color.FromArgb(0, 51, 102),
                Dock = DockStyle.Left,
                Width = (int)(this.Width * 0.35)
            };
            this.Controls.Add(panelAzul);

            // Panel Branco (Direita)
            panelBranco = new Panel
            {
                BackColor = Color.FromArgb(240, 240, 240),
                Dock = DockStyle.Right,
                Width = (int)(this.Width * 0.35)
            };
            this.Controls.Add(panelBranco);

            // Panel Centro
            panelCentro = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 25),
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panelCentro);

            // ===== AZUL =====
            lblNomeAzul = new Label
            {
                Text = "LUTADOR AZUL",
                Font = new Font("Arial Black", 32, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.Transparent
            };
            panelAzul.Controls.Add(lblNomeAzul);

            // Pontuações Azul
            int yPos = 150;
            lblIpponAzul = CriarLabelPontuacao("0", Color.White, panelAzul, yPos, "IPPON");
            lblWazaAzul = CriarLabelPontuacao("0", Color.White, panelAzul, yPos + 180, "WAZA-ARI");
            lblShidoAzul = CriarLabelPontuacao("0", Color.Yellow, panelAzul, yPos + 360, "SHIDO");

            // ===== BRANCO =====
            lblNomeBranco = new Label
            {
                Text = "LUTADOR BRANCO",
                Font = new Font("Arial Black", 32, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.Transparent
            };
            panelBranco.Controls.Add(lblNomeBranco);

            // Pontuações Branco
            lblIpponBranco = CriarLabelPontuacao("0", Color.Black, panelBranco, yPos, "IPPON");
            lblWazaBranco = CriarLabelPontuacao("0", Color.Black, panelBranco, yPos + 180, "WAZA-ARI");
            lblShidoBranco = CriarLabelPontuacao("0", Color.Orange, panelBranco, yPos + 360, "SHIDO");

            // ===== CENTRO =====
            lblCategoria = new Label
            {
                Text = "CATEGORIA",
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 50),
                Size = new Size(panelCentro.Width, 50),
                BackColor = Color.Transparent
            };
            panelCentro.Controls.Add(lblCategoria);

            lblTimer = new Label
            {
                Text = "00:00",
                Font = new Font("Digital-7", 120, FontStyle.Bold),
                ForeColor = Color.LightGreen,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 200),
                Size = new Size(panelCentro.Width, 200),
                BackColor = Color.Transparent
            };
            panelCentro.Controls.Add(lblTimer);

            // Ajustar ao redimensionar
            this.Resize += FormDisplay_Resize;
        }

        private Label CriarLabelPontuacao(string texto, Color cor, Panel parent, int y, string titulo)
        {
            // Label do título
            Label lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Arial Black", 18, FontStyle.Bold),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, y - 40),
                Size = new Size(parent.Width - 40, 40),
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblTitulo);

            // Label da pontuação
            Label lbl = new Label
            {
                Text = texto,
                Font = new Font("Arial Black", 80, FontStyle.Bold),
                ForeColor = cor,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, y),
                Size = new Size(parent.Width - 40, 120),
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lbl);

            return lbl;
        }

        private void FormDisplay_Resize(object? sender, EventArgs e)
        {
            if (panelCentro != null)
            {
                lblCategoria.Size = new Size(panelCentro.Width, 50);
                lblTimer.Size = new Size(panelCentro.Width, 200);
            }
        }

        public void AtualizarDisplay(MatchData data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AtualizarDisplay(data)));
                return;
            }

            lblNomeAzul.Text = data.NomeAzul.ToUpper();
            lblNomeBranco.Text = data.NomeBranco.ToUpper();
            lblCategoria.Text = data.Categoria.ToUpper();

            int minutos = data.TempoRestante / 60;
            int segundos = data.TempoRestante % 60;
            lblTimer.Text = $"{minutos:D2}:{segundos:D2}";

            // Mudar cor do timer
            if (data.TempoRestante <= 30 && data.TempoRestante > 0)
                lblTimer.ForeColor = Color.Orange;
            else if (data.TempoRestante == 0)
                lblTimer.ForeColor = Color.Red;
            else
                lblTimer.ForeColor = Color.LightGreen;

            lblIpponAzul.Text = data.IpponAzul.ToString();
            lblWazaAzul.Text = data.WazaAzul.ToString();
            lblShidoAzul.Text = data.ShidoAzul.ToString();

            lblIpponBranco.Text = data.IpponBranco.ToString();
            lblWazaBranco.Text = data.WazaBranco.ToString();
            lblShidoBranco.Text = data.ShidoBranco.ToString();
        }
    }
}