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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            PanelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            PanelBranco = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblNomeBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblIpponBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblShido1Branco = new Guna.UI2.WinForms.Guna2CircleButton();
            lblShido2Branco = new Guna.UI2.WinForms.Guna2CircleButton();
            lblShido3Branco = new Guna.UI2.WinForms.Guna2CircleButton();
            lblScoreTextBranco = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelAzul = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblNomeAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblIpponAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWazaAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYukoAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblShido1Azul = new Guna.UI2.WinForms.Guna2CircleButton();
            lblShido2Azul = new Guna.UI2.WinForms.Guna2CircleButton();
            lblShido3Azul = new Guna.UI2.WinForms.Guna2CircleButton();
            lblScoreTextAzul = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelCentro = new Guna.UI2.WinForms.Guna2Panel();
            PanelTimerContainer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCategoria = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblEstado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            PanelPrincipal.SuspendLayout();
            PanelBranco.SuspendLayout();
            PanelAzul.SuspendLayout();
            PanelCentro.SuspendLayout();
            PanelTimerContainer.SuspendLayout();
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
            PanelPrincipal.BackColor = Color.FromArgb(15, 15, 15);
            PanelPrincipal.Controls.Add(PanelBranco);
            PanelPrincipal.Controls.Add(PanelAzul);
            PanelPrincipal.Controls.Add(PanelCentro);
            PanelPrincipal.CustomizableEdges = customizableEdges13;
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.ShadowDecoration.CustomizableEdges = customizableEdges14;
            PanelPrincipal.Size = new Size(1920, 1080);
            PanelPrincipal.TabIndex = 0;
            // 
            // PanelBranco
            // 
            PanelBranco.BackColor = Color.Transparent;
            PanelBranco.BorderRadius = 15;
            PanelBranco.Controls.Add(lblNomeBranco);
            PanelBranco.Controls.Add(lblIpponBranco);
            PanelBranco.Controls.Add(lblWazaBranco);
            PanelBranco.Controls.Add(lblYukoBranco);
            PanelBranco.Controls.Add(lblShido1Branco);
            PanelBranco.Controls.Add(lblShido2Branco);
            PanelBranco.Controls.Add(lblShido3Branco);
            PanelBranco.Controls.Add(lblScoreTextBranco);
            PanelBranco.CustomizableEdges = customizableEdges4;
            PanelBranco.FillColor = Color.FromArgb(245, 245, 245);
            PanelBranco.FillColor2 = Color.White;
            PanelBranco.Location = new Point(30, 30);
            PanelBranco.Name = "PanelBranco";
            PanelBranco.ShadowDecoration.CustomizableEdges = customizableEdges5;
            PanelBranco.ShadowDecoration.Enabled = true;
            PanelBranco.ShadowDecoration.Shadow = new Padding(0, 5, 0, 5);
            PanelBranco.Size = new Size(850, 480);
            PanelBranco.TabIndex = 0;
            // 
            // lblNomeBranco
            // 
            lblNomeBranco.BackColor = Color.Transparent;
            lblNomeBranco.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold);
            lblNomeBranco.ForeColor = Color.FromArgb(40, 40, 40);
            lblNomeBranco.Location = new Point(40, 30);
            lblNomeBranco.Name = "lblNomeBranco";
            lblNomeBranco.Size = new Size(167, 67);
            lblNomeBranco.TabIndex = 0;
            lblNomeBranco.Text = "WHITE";
            // 
            // lblIpponBranco
            // 
            lblIpponBranco.BackColor = Color.Transparent;
            lblIpponBranco.Font = new Font("Segoe UI Black", 120F, FontStyle.Bold);
            lblIpponBranco.ForeColor = Color.FromArgb(40, 40, 40);
            lblIpponBranco.Location = new Point(490, 120);
            lblIpponBranco.Name = "lblIpponBranco";
            lblIpponBranco.Size = new Size(99, 214);
            lblIpponBranco.TabIndex = 1;
            lblIpponBranco.Text = "0";
            lblIpponBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblWazaBranco
            // 
            lblWazaBranco.BackColor = Color.Transparent;
            lblWazaBranco.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold);
            lblWazaBranco.ForeColor = Color.FromArgb(80, 80, 80);
            lblWazaBranco.Location = new Point(625, 150);
            lblWazaBranco.Name = "lblWazaBranco";
            lblWazaBranco.Size = new Size(61, 130);
            lblWazaBranco.TabIndex = 2;
            lblWazaBranco.Text = "0";
            lblWazaBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblYukoBranco
            // 
            lblYukoBranco.BackColor = Color.Transparent;
            lblYukoBranco.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold);
            lblYukoBranco.ForeColor = Color.FromArgb(120, 120, 120);
            lblYukoBranco.Location = new Point(720, 175);
            lblYukoBranco.Name = "lblYukoBranco";
            lblYukoBranco.Size = new Size(41, 88);
            lblYukoBranco.TabIndex = 3;
            lblYukoBranco.Text = "0";
            lblYukoBranco.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblShido1Branco
            // 
            lblShido1Branco.BackColor = Color.Transparent;
            lblShido1Branco.DisabledState.BorderColor = Color.DarkGray;
            lblShido1Branco.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido1Branco.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido1Branco.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido1Branco.FillColor = Color.FromArgb(220, 220, 220);
            lblShido1Branco.Font = new Font("Segoe UI", 9F);
            lblShido1Branco.ForeColor = Color.White;
            lblShido1Branco.Location = new Point(40, 370);
            lblShido1Branco.Name = "lblShido1Branco";
            lblShido1Branco.ShadowDecoration.CustomizableEdges = customizableEdges1;
            lblShido1Branco.ShadowDecoration.Enabled = true;
            lblShido1Branco.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido1Branco.Size = new Size(80, 80);
            lblShido1Branco.TabIndex = 4;
            // 
            // lblShido2Branco
            // 
            lblShido2Branco.BackColor = Color.Transparent;
            lblShido2Branco.DisabledState.BorderColor = Color.DarkGray;
            lblShido2Branco.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido2Branco.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido2Branco.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido2Branco.FillColor = Color.FromArgb(220, 220, 220);
            lblShido2Branco.Font = new Font("Segoe UI", 9F);
            lblShido2Branco.ForeColor = Color.White;
            lblShido2Branco.Location = new Point(140, 370);
            lblShido2Branco.Name = "lblShido2Branco";
            lblShido2Branco.ShadowDecoration.CustomizableEdges = customizableEdges2;
            lblShido2Branco.ShadowDecoration.Enabled = true;
            lblShido2Branco.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido2Branco.Size = new Size(80, 80);
            lblShido2Branco.TabIndex = 5;
            // 
            // lblShido3Branco
            // 
            lblShido3Branco.BackColor = Color.Transparent;
            lblShido3Branco.DisabledState.BorderColor = Color.DarkGray;
            lblShido3Branco.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido3Branco.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido3Branco.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido3Branco.FillColor = Color.FromArgb(220, 220, 220);
            lblShido3Branco.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblShido3Branco.ForeColor = Color.White;
            lblShido3Branco.Location = new Point(240, 370);
            lblShido3Branco.Name = "lblShido3Branco";
            lblShido3Branco.ShadowDecoration.CustomizableEdges = customizableEdges3;
            lblShido3Branco.ShadowDecoration.Enabled = true;
            lblShido3Branco.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido3Branco.Size = new Size(80, 80);
            lblShido3Branco.TabIndex = 6;
            lblShido3Branco.Text = "H";
            // 
            // lblScoreTextBranco
            // 
            lblScoreTextBranco.BackColor = Color.Transparent;
            lblScoreTextBranco.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblScoreTextBranco.ForeColor = Color.Gray;
            lblScoreTextBranco.Location = new Point(40, 110);
            lblScoreTextBranco.Name = "lblScoreTextBranco";
            lblScoreTextBranco.Size = new Size(62, 27);
            lblScoreTextBranco.TabIndex = 7;
            lblScoreTextBranco.Text = "SCORE";
            // 
            // PanelAzul
            // 
            PanelAzul.BackColor = Color.Transparent;
            PanelAzul.BorderRadius = 15;
            PanelAzul.Controls.Add(lblNomeAzul);
            PanelAzul.Controls.Add(lblIpponAzul);
            PanelAzul.Controls.Add(lblWazaAzul);
            PanelAzul.Controls.Add(lblYukoAzul);
            PanelAzul.Controls.Add(lblShido1Azul);
            PanelAzul.Controls.Add(lblShido2Azul);
            PanelAzul.Controls.Add(lblShido3Azul);
            PanelAzul.Controls.Add(lblScoreTextAzul);
            PanelAzul.CustomizableEdges = customizableEdges9;
            PanelAzul.FillColor = Color.FromArgb(0, 71, 187);
            PanelAzul.FillColor2 = Color.FromArgb(0, 51, 153);
            PanelAzul.Location = new Point(30, 570);
            PanelAzul.Name = "PanelAzul";
            PanelAzul.ShadowDecoration.CustomizableEdges = customizableEdges10;
            PanelAzul.ShadowDecoration.Enabled = true;
            PanelAzul.ShadowDecoration.Shadow = new Padding(0, 5, 0, 5);
            PanelAzul.Size = new Size(850, 480);
            PanelAzul.TabIndex = 1;
            // 
            // lblNomeAzul
            // 
            lblNomeAzul.BackColor = Color.Transparent;
            lblNomeAzul.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold);
            lblNomeAzul.ForeColor = Color.White;
            lblNomeAzul.Location = new Point(40, 30);
            lblNomeAzul.Name = "lblNomeAzul";
            lblNomeAzul.Size = new Size(124, 67);
            lblNomeAzul.TabIndex = 0;
            lblNomeAzul.Text = "BLUE";
            // 
            // lblIpponAzul
            // 
            lblIpponAzul.BackColor = Color.Transparent;
            lblIpponAzul.Font = new Font("Segoe UI Black", 120F, FontStyle.Bold);
            lblIpponAzul.ForeColor = Color.White;
            lblIpponAzul.Location = new Point(490, 120);
            lblIpponAzul.Name = "lblIpponAzul";
            lblIpponAzul.Size = new Size(99, 214);
            lblIpponAzul.TabIndex = 1;
            lblIpponAzul.Text = "0";
            lblIpponAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblWazaAzul
            // 
            lblWazaAzul.BackColor = Color.Transparent;
            lblWazaAzul.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold);
            lblWazaAzul.ForeColor = Color.FromArgb(200, 200, 200);
            lblWazaAzul.Location = new Point(625, 150);
            lblWazaAzul.Name = "lblWazaAzul";
            lblWazaAzul.Size = new Size(61, 130);
            lblWazaAzul.TabIndex = 2;
            lblWazaAzul.Text = "0";
            lblWazaAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblYukoAzul
            // 
            lblYukoAzul.BackColor = Color.Transparent;
            lblYukoAzul.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold);
            lblYukoAzul.ForeColor = Color.FromArgb(180, 180, 180);
            lblYukoAzul.Location = new Point(720, 175);
            lblYukoAzul.Name = "lblYukoAzul";
            lblYukoAzul.Size = new Size(41, 88);
            lblYukoAzul.TabIndex = 3;
            lblYukoAzul.Text = "0";
            lblYukoAzul.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblShido1Azul
            // 
            lblShido1Azul.BackColor = Color.Transparent;
            lblShido1Azul.DisabledState.BorderColor = Color.DarkGray;
            lblShido1Azul.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido1Azul.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido1Azul.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido1Azul.FillColor = Color.FromArgb(0, 41, 107);
            lblShido1Azul.Font = new Font("Segoe UI", 9F);
            lblShido1Azul.ForeColor = Color.White;
            lblShido1Azul.Location = new Point(40, 370);
            lblShido1Azul.Name = "lblShido1Azul";
            lblShido1Azul.ShadowDecoration.CustomizableEdges = customizableEdges6;
            lblShido1Azul.ShadowDecoration.Enabled = true;
            lblShido1Azul.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido1Azul.Size = new Size(80, 80);
            lblShido1Azul.TabIndex = 4;
            // 
            // lblShido2Azul
            // 
            lblShido2Azul.BackColor = Color.Transparent;
            lblShido2Azul.DisabledState.BorderColor = Color.DarkGray;
            lblShido2Azul.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido2Azul.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido2Azul.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido2Azul.FillColor = Color.FromArgb(0, 41, 107);
            lblShido2Azul.Font = new Font("Segoe UI", 9F);
            lblShido2Azul.ForeColor = Color.White;
            lblShido2Azul.Location = new Point(140, 370);
            lblShido2Azul.Name = "lblShido2Azul";
            lblShido2Azul.ShadowDecoration.CustomizableEdges = customizableEdges7;
            lblShido2Azul.ShadowDecoration.Enabled = true;
            lblShido2Azul.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido2Azul.Size = new Size(80, 80);
            lblShido2Azul.TabIndex = 5;
            // 
            // lblShido3Azul
            // 
            lblShido3Azul.BackColor = Color.Transparent;
            lblShido3Azul.DisabledState.BorderColor = Color.DarkGray;
            lblShido3Azul.DisabledState.CustomBorderColor = Color.DarkGray;
            lblShido3Azul.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblShido3Azul.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblShido3Azul.FillColor = Color.FromArgb(0, 41, 107);
            lblShido3Azul.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblShido3Azul.ForeColor = Color.White;
            lblShido3Azul.Location = new Point(240, 370);
            lblShido3Azul.Name = "lblShido3Azul";
            lblShido3Azul.ShadowDecoration.CustomizableEdges = customizableEdges8;
            lblShido3Azul.ShadowDecoration.Enabled = true;
            lblShido3Azul.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            lblShido3Azul.Size = new Size(80, 80);
            lblShido3Azul.TabIndex = 6;
            lblShido3Azul.Text = "H";
            // 
            // lblScoreTextAzul
            // 
            lblScoreTextAzul.BackColor = Color.Transparent;
            lblScoreTextAzul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblScoreTextAzul.ForeColor = Color.FromArgb(200, 200, 200);
            lblScoreTextAzul.Location = new Point(40, 110);
            lblScoreTextAzul.Name = "lblScoreTextAzul";
            lblScoreTextAzul.Size = new Size(62, 27);
            lblScoreTextAzul.TabIndex = 7;
            lblScoreTextAzul.Text = "SCORE";
            // 
            // PanelCentro
            // 
            PanelCentro.BackColor = Color.Transparent;
            PanelCentro.Controls.Add(PanelTimerContainer);
            PanelCentro.Controls.Add(lblCategoria);
            PanelCentro.Controls.Add(lblEstado);
            PanelCentro.CustomizableEdges = customizableEdges11;
            PanelCentro.Dock = DockStyle.Right;
            PanelCentro.Location = new Point(920, 0);
            PanelCentro.Name = "PanelCentro";
            PanelCentro.ShadowDecoration.CustomizableEdges = customizableEdges12;
            PanelCentro.Size = new Size(1000, 1080);
            PanelCentro.TabIndex = 2;
            // 
            // PanelTimerContainer
            // 
            PanelTimerContainer.BackColor = Color.Transparent;
            PanelTimerContainer.Controls.Add(lblTimer);
            PanelTimerContainer.FillColor = Color.FromArgb(25, 25, 25);
            PanelTimerContainer.Location = new Point(100, 350);
            PanelTimerContainer.Name = "PanelTimerContainer";
            PanelTimerContainer.Radius = 20;
            PanelTimerContainer.ShadowColor = Color.Black;
            PanelTimerContainer.ShadowDepth = 50;
            PanelTimerContainer.Size = new Size(800, 380);
            PanelTimerContainer.TabIndex = 3;
            // 
            // lblTimer
            // 
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Dock = DockStyle.Fill;
            lblTimer.Font = new Font("Segoe UI Black", 180F, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(0, 255, 100);
            lblTimer.Location = new Point(0, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(512, 320);
            lblTimer.TabIndex = 1;
            lblTimer.Text = "3:00";
            lblTimer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Segoe UI Black", 42F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(255, 220, 0);
            lblCategoria.Location = new Point(100, 100);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(3, 2);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = null;
            // 
            // lblEstado
            // 
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold);
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(100, 800);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(3, 2);
            lblEstado.TabIndex = 2;
            lblEstado.Text = null;
            lblEstado.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1920, 1080);
            Controls.Add(PanelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Judo Scoreboard";
            WindowState = FormWindowState.Maximized;
            PanelPrincipal.ResumeLayout(false);
            PanelBranco.ResumeLayout(false);
            PanelBranco.PerformLayout();
            PanelAzul.ResumeLayout(false);
            PanelAzul.PerformLayout();
            PanelCentro.ResumeLayout(false);
            PanelCentro.PerformLayout();
            PanelTimerContainer.ResumeLayout(false);
            PanelTimerContainer.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Panel PanelPrincipal;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBranco;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelAzul;
        private Guna.UI2.WinForms.Guna2Panel PanelCentro;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelTimerContainer;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaBranco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoBranco;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido1Branco;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido2Branco;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido3Branco;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScoreTextBranco;

        private Guna.UI2.WinForms.Guna2HtmlLabel lblNomeAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIpponAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWazaAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYukoAzul;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido1Azul;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido2Azul;
        private Guna.UI2.WinForms.Guna2CircleButton lblShido3Azul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScoreTextAzul;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEstado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
    }
}