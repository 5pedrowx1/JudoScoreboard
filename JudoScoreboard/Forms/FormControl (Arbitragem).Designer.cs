namespace JudoScoreboard.Forms
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Panel_UC = new Guna.UI2.WinForms.Guna2Panel();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            BtnClose = new Guna.UI2.WinForms.Guna2Button();
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            PanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_UC
            // 
            Panel_UC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_UC.BackColor = Color.FromArgb(25, 25, 25);
            Panel_UC.CustomizableEdges = customizableEdges1;
            Panel_UC.Location = new Point(0, 39);
            Panel_UC.Name = "Panel_UC";
            Panel_UC.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Panel_UC.Size = new Size(800, 411);
            Panel_UC.TabIndex = 0;
            // 
            // DragControl
            // 
            DragControl.DockForm = true;
            DragControl.DockIndicatorTransparencyValue = 0.6D;
            DragControl.TargetControl = PanelTop;
            DragControl.UseTransparentDrag = true;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(30, 30, 30);
            PanelTop.Controls.Add(BtnClose);
            PanelTop.CustomizableEdges = customizableEdges5;
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PanelTop.Size = new Size(800, 40);
            PanelTop.TabIndex = 1;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BorderColor = Color.Red;
            BtnClose.BorderRadius = 5;
            BtnClose.BorderThickness = 1;
            BtnClose.CustomizableEdges = customizableEdges3;
            BtnClose.DisabledState.BorderColor = Color.DarkGray;
            BtnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnClose.FillColor = Color.FromArgb(30, 30, 30);
            BtnClose.Font = new Font("Segoe UI", 9F);
            BtnClose.ForeColor = Color.Red;
            BtnClose.Location = new Point(755, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnClose.Size = new Size(39, 31);
            BtnClose.TabIndex = 0;
            BtnClose.Text = "X";
            BtnClose.Click += BtnClose_Click;
            // 
            // Elipse
            // 
            Elipse.TargetControl = this;
            // 
            // FormControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(PanelTop);
            Controls.Add(Panel_UC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormControl";
            Text = "FormControl";
            Load += FormControl_Load;
            PanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_UC;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
    }
}