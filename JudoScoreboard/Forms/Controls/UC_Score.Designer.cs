namespace JudoScoreboard.Forms.Controls
{
    partial class UC_Score
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            // Timer
            timer = new System.Windows.Forms.Timer(components);

            // Labels - Nomes
            lblNomeAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNomeBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();

            // Pontuações Azul
            lblIpponAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblShidoAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();

            // Pontuações Branco
            lblIpponBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblShidoBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();

            // Botões Azul
            btnIpponAzul = new Guna.UI2.WinForms.Guna2Button();
            btnWazaAzul = new Guna.UI2.WinForms.Guna2Button();
            btnYukoAzul = new Guna.UI2.WinForms.Guna2Button();
            btnShidoAzul = new Guna.UI2.WinForms.Guna2Button();
            btnRemoveAzul = new Guna.UI2.WinForms.Guna2Button();

            // Botões Branco
            btnIpponBranco = new Guna.UI2.WinForms.Guna2Button();
            btnWazaBranco = new Guna.UI2.WinForms.Guna2Button();
            btnYukoBranco = new Guna.UI2.WinForms.Guna2Button();
            btnShidoBranco = new Guna.UI2.WinForms.Guna2Button();
            btnRemoveBranco = new Guna.UI2.WinForms.Guna2Button();

            // Botões Controle
            btnPlayPause = new Guna.UI2.WinForms.Guna2Button();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            btnVoltar = new Guna.UI2.WinForms.Guna2Button();

            SuspendLayout();

            // Timer
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // lblNomeAzul
            lblNomeAzul.BackColor = Color.Transparent;
            lblNomeAzul.Font = new Font("MV Boli", 16F, FontStyle.Bold);
            lblNomeAzul.ForeColor = Color.DarkBlue;
            lblNomeAzul.Location = new Point(50, 20);
            lblNomeAzul.Name = "lblNomeAzul";
            lblNomeAzul.Size = new Size(200, 30);
            lblNomeAzul.TabIndex = 0;
            lblNomeAzul.Text = "Lutador Azul";

            // lblNomeBranco
            lblNomeBranco.BackColor = Color.Transparent;
            lblNomeBranco.Font = new Font("MV Boli", 16F, FontStyle.Bold);
            lblNomeBranco.ForeColor = Color.White;
            lblNomeBranco.Location = new Point(550, 20);
            lblNomeBranco.Name = "lblNomeBranco";
            lblNomeBranco.Size = new Size(200, 30);
            lblNomeBranco.TabIndex = 1;
            lblNomeBranco.Text = "Lutador Branco";

            // lblCategoria
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("MV Boli", 12F);
            lblCategoria.ForeColor = Color.Gray;
            lblCategoria.Location = new Point(330, 25);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(140, 25);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            lblCategoria.TextAlignment = ContentAlignment.MiddleCenter;

            // lblTimer
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Digital-7", 48F, FontStyle.Bold);
            lblTimer.ForeColor = Color.Red;
            lblTimer.Location = new Point(310, 70);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(180, 70);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "03:00";
            lblTimer.TextAlignment = ContentAlignment.MiddleCenter;

            // AZUL - Pontuações
            lblIpponAzul.BackColor = Color.Transparent;
            lblIpponAzul.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblIpponAzul.ForeColor = Color.DarkBlue;
            lblIpponAzul.Location = new Point(70, 80);
            lblIpponAzul.Name = "lblIpponAzul";
            lblIpponAzul.Size = new Size(60, 50);
            lblIpponAzul.TabIndex = 4;
            lblIpponAzul.Text = "0";

            lblWazaAzul.BackColor = Color.Transparent;
            lblWazaAzul.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblWazaAzul.ForeColor = Color.DarkBlue;
            lblWazaAzul.Location = new Point(70, 150);
            lblWazaAzul.Name = "lblWazaAzul";
            lblWazaAzul.Size = new Size(60, 50);
            lblWazaAzul.TabIndex = 5;
            lblWazaAzul.Text = "0";

            lblYukoAzul.BackColor = Color.Transparent;
            lblYukoAzul.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblYukoAzul.ForeColor = Color.DarkBlue;
            lblYukoAzul.Location = new Point(70, 220);
            lblYukoAzul.Name = "lblYukoAzul";
            lblYukoAzul.Size = new Size(60, 50);
            lblYukoAzul.TabIndex = 6;
            lblYukoAzul.Text = "0";

            lblShidoAzul.BackColor = Color.Transparent;
            lblShidoAzul.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblShidoAzul.ForeColor = Color.Yellow;
            lblShidoAzul.Location = new Point(70, 290);
            lblShidoAzul.Name = "lblShidoAzul";
            lblShidoAzul.Size = new Size(60, 50);
            lblShidoAzul.TabIndex = 7;
            lblShidoAzul.Text = "0";

            // BRANCO - Pontuações
            lblIpponBranco.BackColor = Color.Transparent;
            lblIpponBranco.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblIpponBranco.ForeColor = Color.White;
            lblIpponBranco.Location = new Point(670, 80);
            lblIpponBranco.Name = "lblIpponBranco";
            lblIpponBranco.Size = new Size(60, 50);
            lblIpponBranco.TabIndex = 8;
            lblIpponBranco.Text = "0";

            lblWazaBranco.BackColor = Color.Transparent;
            lblWazaBranco.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblWazaBranco.ForeColor = Color.White;
            lblWazaBranco.Location = new Point(670, 150);
            lblWazaBranco.Name = "lblWazaBranco";
            lblWazaBranco.Size = new Size(60, 50);
            lblWazaBranco.TabIndex = 9;
            lblWazaBranco.Text = "0";

            lblYukoBranco.BackColor = Color.Transparent;
            lblYukoBranco.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblYukoBranco.ForeColor = Color.White;
            lblYukoBranco.Location = new Point(670, 220);
            lblYukoBranco.Name = "lblYukoBranco";
            lblYukoBranco.Size = new Size(60, 50);
            lblYukoBranco.TabIndex = 10;
            lblYukoBranco.Text = "0";

            lblShidoBranco.BackColor = Color.Transparent;
            lblShidoBranco.Font = new Font("MV Boli", 32F, FontStyle.Bold);
            lblShidoBranco.ForeColor = Color.Yellow;
            lblShidoBranco.Location = new Point(670, 290);
            lblShidoBranco.Name = "lblShidoBranco";
            lblShidoBranco.Size = new Size(60, 50);
            lblShidoBranco.TabIndex = 11;
            lblShidoBranco.Text = "0";

            // AZUL - Botões
            btnIpponAzul.BorderRadius = 5;
            btnIpponAzul.CustomizableEdges = customizableEdges1;
            btnIpponAzul.FillColor = Color.DarkBlue;
            btnIpponAzul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIpponAzul.ForeColor = Color.White;
            btnIpponAzul.Location = new Point(150, 80);
            btnIpponAzul.Name = "btnIpponAzul";
            btnIpponAzul.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnIpponAzul.Size = new Size(100, 45);
            btnIpponAzul.TabIndex = 12;
            btnIpponAzul.Text = "IPPON";
            btnIpponAzul.Click += BtnIpponAzul_Click;

            btnWazaAzul.BorderRadius = 5;
            btnWazaAzul.CustomizableEdges = customizableEdges3;
            btnWazaAzul.FillColor = Color.DarkBlue;
            btnWazaAzul.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWazaAzul.ForeColor = Color.White;
            btnWazaAzul.Location = new Point(150, 150);
            btnWazaAzul.Name = "btnWazaAzul";
            btnWazaAzul.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnWazaAzul.Size = new Size(100, 45);
            btnWazaAzul.TabIndex = 13;
            btnWazaAzul.Text = "WAZA-ARI";
            btnWazaAzul.Click += BtnWazaAzul_Click;

            btnYukoAzul.BorderRadius = 5;
            btnYukoAzul.CustomizableEdges = customizableEdges5;
            btnYukoAzul.FillColor = Color.DarkBlue;
            btnYukoAzul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYukoAzul.ForeColor = Color.White;
            btnYukoAzul.Location = new Point(150, 220);
            btnYukoAzul.Name = "btnYukoAzul";
            btnYukoAzul.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnYukoAzul.Size = new Size(100, 45);
            btnYukoAzul.TabIndex = 14;
            btnYukoAzul.Text = "YUKO";
            btnYukoAzul.Click += BtnYukoAzul_Click;

            btnShidoAzul.BorderRadius = 5;
            btnShidoAzul.CustomizableEdges = customizableEdges7;
            btnShidoAzul.FillColor = Color.Orange;
            btnShidoAzul.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShidoAzul.ForeColor = Color.White;
            btnShidoAzul.Location = new Point(150, 290);
            btnShidoAzul.Name = "btnShidoAzul";
            btnShidoAzul.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnShidoAzul.Size = new Size(100, 45);
            btnShidoAzul.TabIndex = 15;
            btnShidoAzul.Text = "SHIDO";
            btnShidoAzul.Click += BtnShidoAzul_Click;

            btnRemoveAzul.BorderRadius = 5;
            btnRemoveAzul.CustomizableEdges = customizableEdges9;
            btnRemoveAzul.FillColor = Color.Red;
            btnRemoveAzul.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveAzul.ForeColor = Color.White;
            btnRemoveAzul.Location = new Point(150, 350);
            btnRemoveAzul.Name = "btnRemoveAzul";
            btnRemoveAzul.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnRemoveAzul.Size = new Size(100, 35);
            btnRemoveAzul.TabIndex = 16;
            btnRemoveAzul.Text = "Remover";
            btnRemoveAzul.Click += BtnRemoveAzul_Click;

            // BRANCO - Botões
            btnIpponBranco.BorderRadius = 5;
            btnIpponBranco.CustomizableEdges = customizableEdges11;
            btnIpponBranco.FillColor = Color.White;
            btnIpponBranco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIpponBranco.ForeColor = Color.Black;
            btnIpponBranco.Location = new Point(550, 80);
            btnIpponBranco.Name = "btnIpponBranco";
            btnIpponBranco.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnIpponBranco.Size = new Size(100, 45);
            btnIpponBranco.TabIndex = 17;
            btnIpponBranco.Text = "IPPON";
            btnIpponBranco.Click += BtnIpponBranco_Click;

            btnWazaBranco.BorderRadius = 5;
            btnWazaBranco.CustomizableEdges = customizableEdges13;
            btnWazaBranco.FillColor = Color.White;
            btnWazaBranco.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWazaBranco.ForeColor = Color.Black;
            btnWazaBranco.Location = new Point(550, 150);
            btnWazaBranco.Name = "btnWazaBranco";
            btnWazaBranco.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnWazaBranco.Size = new Size(100, 45);
            btnWazaBranco.TabIndex = 18;
            btnWazaBranco.Text = "WAZA-ARI";
            btnWazaBranco.Click += BtnWazaBranco_Click;

            btnYukoBranco.BorderRadius = 5;
            btnYukoBranco.FillColor = Color.White;
            btnYukoBranco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnYukoBranco.ForeColor = Color.Black;
            btnYukoBranco.Location = new Point(550, 220);
            btnYukoBranco.Name = "btnYukoBranco";
            btnYukoBranco.Size = new Size(100, 45);
            btnYukoBranco.TabIndex = 19;
            btnYukoBranco.Text = "YUKO";
            btnYukoBranco.Click += BtnYukoBranco_Click;

            btnShidoBranco.BorderRadius = 5;
            btnShidoBranco.FillColor = Color.Orange;
            btnShidoBranco.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShidoBranco.ForeColor = Color.White;
            btnShidoBranco.Location = new Point(550, 290);
            btnShidoBranco.Name = "btnShidoBranco";
            btnShidoBranco.Size = new Size(100, 45);
            btnShidoBranco.TabIndex = 20;
            btnShidoBranco.Text = "SHIDO";
            btnShidoBranco.Click += BtnShidoBranco_Click;

            btnRemoveBranco.BorderRadius = 5;
            btnRemoveBranco.FillColor = Color.Red;
            btnRemoveBranco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveBranco.ForeColor = Color.White;
            btnRemoveBranco.Location = new Point(550, 350);
            btnRemoveBranco.Name = "btnRemoveBranco";
            btnRemoveBranco.Size = new Size(100, 35);
            btnRemoveBranco.TabIndex = 21;
            btnRemoveBranco.Text = "Remover";
            btnRemoveBranco.Click += BtnRemoveBranco_Click;

            // Controles
            btnPlayPause.BorderRadius = 5;
            btnPlayPause.CustomizableEdges = customizableEdges15;
            btnPlayPause.FillColor = Color.Green;
            btnPlayPause.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnPlayPause.ForeColor = Color.White;
            btnPlayPause.Location = new Point(310, 160);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnPlayPause.Size = new Size(180, 55);
            btnPlayPause.TabIndex = 22;
            btnPlayPause.Text = "▶ INICIAR";
            btnPlayPause.Click += BtnPlayPause_Click;

            btnReset.BorderRadius = 5;
            btnReset.BorderColor = Color.Gray;
            btnReset.BorderThickness = 2;
            btnReset.FillColor = Color.FromArgb(25, 25, 25);
            btnReset.Font = new Font("Segoe UI", 11F);
            btnReset.ForeColor = Color.Gray;
            btnReset.Location = new Point(310, 235);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(180, 45);
            btnReset.TabIndex = 23;
            btnReset.Text = "↻ RESET";
            btnReset.Click += BtnReset_Click;

            btnVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltar.BorderRadius = 5;
            btnVoltar.BorderColor = Color.Gray;
            btnVoltar.BorderThickness = 1;
            btnVoltar.FillColor = Color.FromArgb(25, 25, 25);
            btnVoltar.Font = new Font("Segoe UI", 9F);
            btnVoltar.ForeColor = Color.Gray;
            btnVoltar.Location = new Point(20, 400);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 35);
            btnVoltar.TabIndex = 24;
            btnVoltar.Text = "← Voltar";
            btnVoltar.Click += BtnVoltar_Click;

            // UC_Score
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            Controls.Add(btnVoltar);
            Controls.Add(btnReset);
            Controls.Add(btnPlayPause);
            Controls.Add(btnRemoveBranco);
            Controls.Add(btnShidoBranco);
            Controls.Add(btnYukoBranco);
            Controls.Add(btnWazaBranco);
            Controls.Add(btnIpponBranco);
            Controls.Add(btnRemoveAzul);
            Controls.Add(btnShidoAzul);
            Controls.Add(btnYukoAzul);
            Controls.Add(btnWazaAzul);
            Controls.Add(btnIpponAzul);
            Controls.Add(lblShidoBranco);
            Controls.Add(lblYukoBranco);
            Controls.Add(lblWazaBranco);
            Controls.Add(lblIpponBranco);
            Controls.Add(lblShidoAzul);
            Controls.Add(lblYukoAzul);
            Controls.Add(lblWazaAzul);
            Controls.Add(lblIpponAzul);
            Controls.Add(lblTimer);
            Controls.Add(lblCategoria);
            Controls.Add(lblNomeBranco);
            Controls.Add(lblNomeAzul);
            Name = "UC_Score";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShidoAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShidoBranco;
        private Guna.UI2.WinForms.Guna2Button btnIpponAzul;
        private Guna.UI2.WinForms.Guna2Button btnWazaAzul;
        private Guna.UI2.WinForms.Guna2Button btnYukoAzul;
        private Guna.UI2.WinForms.Guna2Button btnShidoAzul;
        private Guna.UI2.WinForms.Guna2Button btnRemoveAzul;
        private Guna.UI2.WinForms.Guna2Button btnIpponBranco;
        private Guna.UI2.WinForms.Guna2Button btnWazaBranco;
        private Guna.UI2.WinForms.Guna2Button btnYukoBranco;
        private Guna.UI2.WinForms.Guna2Button btnShidoBranco;
        private Guna.UI2.WinForms.Guna2Button btnRemoveBranco;
        private Guna.UI2.WinForms.Guna2Button btnPlayPause;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
    }
}