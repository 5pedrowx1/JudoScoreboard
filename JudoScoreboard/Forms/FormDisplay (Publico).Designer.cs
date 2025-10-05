namespace JudoScoreboard.Forms
{
    partial class FormDisplay
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            PanelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            PanelBranco = new Guna.UI2.WinForms.Guna2Panel();
            PictureIJFWhite = new PictureBox();
            lblNomeBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblIpponBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelShidoBranco = new Panel();
            lblShido1Branco = new Label();
            lblShido2Branco = new Label();
            lblShido3Branco = new Label();
            PanelAzul = new Guna.UI2.WinForms.Guna2Panel();
            PictureIJFBlue = new PictureBox();
            lblNomeAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblIpponAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelShidoAzul = new Panel();
            lblShido1Azul = new Label();
            lblShido2Azul = new Label();
            lblShido3Azul = new Label();
            PanelCentro = new Guna.UI2.WinForms.Guna2Panel();
            lblCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelPrincipal.SuspendLayout();
            PanelBranco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureIJFWhite).BeginInit();
            PanelShidoBranco.SuspendLayout();
            PanelAzul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureIJFBlue).BeginInit();
            PanelShidoAzul.SuspendLayout();
            PanelCentro.SuspendLayout();
            SuspendLayout();
            // 
            // DragControl
            // 
            DragControl.DockForm = true;
            DragControl.DockIndicatorTransparencyValue = 0.6D;
            DragControl.TargetControl = this;
            DragControl.UseTransparentDrag = true;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.Black;
            PanelPrincipal.Controls.Add(PanelBranco);
            PanelPrincipal.Controls.Add(PanelAzul);
            PanelPrincipal.Controls.Add(PanelCentro);
            PanelPrincipal.CustomizableEdges = customizableEdges7;
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PanelPrincipal.Size = new Size(1920, 1080);
            PanelPrincipal.TabIndex = 0;
            // 
            // PanelBranco
            // 
            PanelBranco.Anchor = AnchorStyles.None;
            PanelBranco.BackColor = Color.White;
            PanelBranco.BorderColor = Color.Black;
            PanelBranco.BorderThickness = 4;
            PanelBranco.Controls.Add(PictureIJFWhite);
            PanelBranco.Controls.Add(lblNomeBranco);
            PanelBranco.Controls.Add(lblIpponBranco);
            PanelBranco.Controls.Add(lblWazaBranco);
            PanelBranco.Controls.Add(lblYukoBranco);
            PanelBranco.Controls.Add(PanelShidoBranco);
            PanelBranco.CustomizableEdges = customizableEdges1;
            PanelBranco.Location = new Point(0, 0);
            PanelBranco.Name = "PanelBranco";
            PanelBranco.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PanelBranco.Size = new Size(914, 555);
            PanelBranco.TabIndex = 0;
            // 
            // PictureIJFWhite
            // 
            PictureIJFWhite.BackColor = Color.Transparent;
            PictureIJFWhite.Location = new Point(69, 153);
            PictureIJFWhite.Name = "PictureIJFWhite";
            PictureIJFWhite.Size = new Size(80, 80);
            PictureIJFWhite.SizeMode = PictureBoxSizeMode.Zoom;
            PictureIJFWhite.TabIndex = 0;
            PictureIJFWhite.TabStop = false;
            // 
            // lblNomeBranco
            // 
            lblNomeBranco.BackColor = Color.Transparent;
            lblNomeBranco.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            lblNomeBranco.ForeColor = Color.Black;
            lblNomeBranco.Location = new Point(169, 173);
            lblNomeBranco.Name = "lblNomeBranco";
            lblNomeBranco.Size = new Size(120, 47);
            lblNomeBranco.TabIndex = 1;
            lblNomeBranco.Text = "WHITE";
            // 
            // lblIpponBranco
            // 
            lblIpponBranco.BackColor = Color.Transparent;
            lblIpponBranco.Font = new Font("Arial Black", 90F, FontStyle.Bold);
            lblIpponBranco.ForeColor = Color.Black;
            lblIpponBranco.Location = new Point(529, 177);
            lblIpponBranco.Name = "lblIpponBranco";
            lblIpponBranco.Size = new Size(83, 171);
            lblIpponBranco.TabIndex = 2;
            lblIpponBranco.Text = "0";
            lblIpponBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblWazaBranco
            // 
            lblWazaBranco.BackColor = Color.Transparent;
            lblWazaBranco.Font = new Font("Arial Black", 60F, FontStyle.Bold);
            lblWazaBranco.ForeColor = Color.Black;
            lblWazaBranco.Location = new Point(649, 197);
            lblWazaBranco.Name = "lblWazaBranco";
            lblWazaBranco.Size = new Size(56, 115);
            lblWazaBranco.TabIndex = 3;
            lblWazaBranco.Text = "0";
            lblWazaBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblYukoBranco
            // 
            lblYukoBranco.BackColor = Color.Transparent;
            lblYukoBranco.Font = new Font("Arial Black", 40F, FontStyle.Bold);
            lblYukoBranco.ForeColor = Color.Black;
            lblYukoBranco.Location = new Point(739, 217);
            lblYukoBranco.Name = "lblYukoBranco";
            lblYukoBranco.Size = new Size(38, 76);
            lblYukoBranco.TabIndex = 4;
            lblYukoBranco.Text = "0";
            lblYukoBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PanelShidoBranco
            // 
            PanelShidoBranco.BackColor = Color.FromArgb(230, 230, 230);
            PanelShidoBranco.Controls.Add(lblShido1Branco);
            PanelShidoBranco.Controls.Add(lblShido2Branco);
            PanelShidoBranco.Controls.Add(lblShido3Branco);
            PanelShidoBranco.Location = new Point(69, 297);
            PanelShidoBranco.Name = "PanelShidoBranco";
            PanelShidoBranco.Size = new Size(450, 60);
            PanelShidoBranco.TabIndex = 5;
            // 
            // lblShido1Branco
            // 
            lblShido1Branco.BackColor = Color.White;
            lblShido1Branco.BorderStyle = BorderStyle.FixedSingle;
            lblShido1Branco.Location = new Point(20, 10);
            lblShido1Branco.Name = "lblShido1Branco";
            lblShido1Branco.Size = new Size(120, 40);
            lblShido1Branco.TabIndex = 0;
            // 
            // lblShido2Branco
            // 
            lblShido2Branco.BackColor = Color.White;
            lblShido2Branco.BorderStyle = BorderStyle.FixedSingle;
            lblShido2Branco.Location = new Point(165, 10);
            lblShido2Branco.Name = "lblShido2Branco";
            lblShido2Branco.Size = new Size(120, 40);
            lblShido2Branco.TabIndex = 1;
            // 
            // lblShido3Branco
            // 
            lblShido3Branco.BackColor = Color.White;
            lblShido3Branco.BorderStyle = BorderStyle.FixedSingle;
            lblShido3Branco.Location = new Point(310, 10);
            lblShido3Branco.Name = "lblShido3Branco";
            lblShido3Branco.Size = new Size(120, 40);
            lblShido3Branco.TabIndex = 2;
            // 
            // PanelAzul
            // 
            PanelAzul.Anchor = AnchorStyles.None;
            PanelAzul.BackColor = Color.FromArgb(0, 51, 153);
            PanelAzul.BorderColor = Color.Black;
            PanelAzul.BorderThickness = 4;
            PanelAzul.Controls.Add(PictureIJFBlue);
            PanelAzul.Controls.Add(lblNomeAzul);
            PanelAzul.Controls.Add(lblIpponAzul);
            PanelAzul.Controls.Add(lblWazaAzul);
            PanelAzul.Controls.Add(lblYukoAzul);
            PanelAzul.Controls.Add(PanelShidoAzul);
            PanelAzul.CustomizableEdges = customizableEdges3;
            PanelAzul.Location = new Point(3, 553);
            PanelAzul.Name = "PanelAzul";
            PanelAzul.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PanelAzul.Size = new Size(911, 527);
            PanelAzul.TabIndex = 1;
            // 
            // PictureIJFBlue
            // 
            PictureIJFBlue.BackColor = Color.Transparent;
            PictureIJFBlue.Location = new Point(66, 167);
            PictureIJFBlue.Name = "PictureIJFBlue";
            PictureIJFBlue.Size = new Size(80, 80);
            PictureIJFBlue.SizeMode = PictureBoxSizeMode.Zoom;
            PictureIJFBlue.TabIndex = 0;
            PictureIJFBlue.TabStop = false;
            // 
            // lblNomeAzul
            // 
            lblNomeAzul.BackColor = Color.Transparent;
            lblNomeAzul.Font = new Font("Arial Black", 24F, FontStyle.Bold);
            lblNomeAzul.ForeColor = Color.White;
            lblNomeAzul.Location = new Point(166, 187);
            lblNomeAzul.Name = "lblNomeAzul";
            lblNomeAzul.Size = new Size(99, 47);
            lblNomeAzul.TabIndex = 1;
            lblNomeAzul.Text = "BLUE";
            // 
            // lblIpponAzul
            // 
            lblIpponAzul.BackColor = Color.Transparent;
            lblIpponAzul.Font = new Font("Arial Black", 90F, FontStyle.Bold);
            lblIpponAzul.ForeColor = Color.White;
            lblIpponAzul.Location = new Point(526, 197);
            lblIpponAzul.Name = "lblIpponAzul";
            lblIpponAzul.Size = new Size(83, 171);
            lblIpponAzul.TabIndex = 2;
            lblIpponAzul.Text = "0";
            lblIpponAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblWazaAzul
            // 
            lblWazaAzul.BackColor = Color.Transparent;
            lblWazaAzul.Font = new Font("Arial Black", 60F, FontStyle.Bold);
            lblWazaAzul.ForeColor = Color.White;
            lblWazaAzul.Location = new Point(646, 217);
            lblWazaAzul.Name = "lblWazaAzul";
            lblWazaAzul.Size = new Size(56, 115);
            lblWazaAzul.TabIndex = 3;
            lblWazaAzul.Text = "0";
            lblWazaAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblYukoAzul
            // 
            lblYukoAzul.BackColor = Color.Transparent;
            lblYukoAzul.Font = new Font("Arial Black", 40F, FontStyle.Bold);
            lblYukoAzul.ForeColor = Color.White;
            lblYukoAzul.Location = new Point(736, 237);
            lblYukoAzul.Name = "lblYukoAzul";
            lblYukoAzul.Size = new Size(38, 76);
            lblYukoAzul.TabIndex = 4;
            lblYukoAzul.Text = "0";
            lblYukoAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PanelShidoAzul
            // 
            PanelShidoAzul.BackColor = Color.FromArgb(0, 30, 100);
            PanelShidoAzul.Controls.Add(lblShido1Azul);
            PanelShidoAzul.Controls.Add(lblShido2Azul);
            PanelShidoAzul.Controls.Add(lblShido3Azul);
            PanelShidoAzul.Location = new Point(66, 317);
            PanelShidoAzul.Name = "PanelShidoAzul";
            PanelShidoAzul.Size = new Size(450, 60);
            PanelShidoAzul.TabIndex = 5;
            // 
            // lblShido1Azul
            // 
            lblShido1Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido1Azul.BorderStyle = BorderStyle.FixedSingle;
            lblShido1Azul.Location = new Point(20, 10);
            lblShido1Azul.Name = "lblShido1Azul";
            lblShido1Azul.Size = new Size(120, 40);
            lblShido1Azul.TabIndex = 0;
            // 
            // lblShido2Azul
            // 
            lblShido2Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido2Azul.BorderStyle = BorderStyle.FixedSingle;
            lblShido2Azul.Location = new Point(165, 10);
            lblShido2Azul.Name = "lblShido2Azul";
            lblShido2Azul.Size = new Size(120, 40);
            lblShido2Azul.TabIndex = 1;
            // 
            // lblShido3Azul
            // 
            lblShido3Azul.BackColor = Color.FromArgb(0, 51, 153);
            lblShido3Azul.BorderStyle = BorderStyle.FixedSingle;
            lblShido3Azul.Location = new Point(310, 10);
            lblShido3Azul.Name = "lblShido3Azul";
            lblShido3Azul.Size = new Size(120, 40);
            lblShido3Azul.TabIndex = 2;
            // 
            // PanelCentro
            // 
            PanelCentro.Anchor = AnchorStyles.None;
            PanelCentro.BackColor = Color.Black;
            PanelCentro.Controls.Add(lblCategoria);
            PanelCentro.Controls.Add(lblTimer);
            PanelCentro.Controls.Add(lblEstado);
            PanelCentro.CustomizableEdges = customizableEdges5;
            PanelCentro.Location = new Point(920, 200);
            PanelCentro.Name = "PanelCentro";
            PanelCentro.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PanelCentro.Size = new Size(900, 680);
            PanelCentro.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Arial Black", 32F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.Yellow;
            lblCategoria.Location = new Point(50, 50);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(147, 62);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = " -81 kg";
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.None;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Microsoft Sans Serif", 200F, FontStyle.Bold);
            lblTimer.ForeColor = Color.Red;
            lblTimer.Location = new Point(100, 200);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(525, 304);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "0:00";
            lblTimer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.None;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Arial Black", 40F, FontStyle.Bold);
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(150, 520);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(390, 76);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Golden Score";
            lblEstado.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(PanelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Judo Scoreboard - IJF Style";
            WindowState = FormWindowState.Maximized;
            PanelPrincipal.ResumeLayout(false);
            PanelBranco.ResumeLayout(false);
            PanelBranco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureIJFWhite).EndInit();
            PanelShidoBranco.ResumeLayout(false);
            PanelAzul.ResumeLayout(false);
            PanelAzul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureIJFBlue).EndInit();
            PanelShidoAzul.ResumeLayout(false);
            PanelCentro.ResumeLayout(false);
            PanelCentro.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipal;
        private Guna.UI2.WinForms.Guna2Panel PanelBranco;
        private Guna.UI2.WinForms.Guna2Panel PanelAzul;
        private Guna.UI2.WinForms.Guna2Panel PanelCentro;

        private PictureBox PictureIJFWhite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoBranco;
        private Panel PanelShidoBranco;
        private Label lblShido1Branco;
        private Label lblShido2Branco;
        private Label lblShido3Branco;

        private PictureBox PictureIJFBlue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoAzul;
        private Panel PanelShidoAzul;
        private Label lblShido1Azul;
        private Label lblShido2Azul;
        private Label lblShido3Azul;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstado;
    }
}