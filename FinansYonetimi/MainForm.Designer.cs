
namespace FinansYonetimi
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnBilling = new Button();
            btnPayable = new Button();
            btnReceivable = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelTitleBar = new Panel();
            button1 = new Button();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnBilling);
            panelMenu.Controls.Add(btnPayable);
            panelMenu.Controls.Add(btnReceivable);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 699);
            panelMenu.TabIndex = 0;
            // 
            // btnBilling
            // 
            btnBilling.Dock = DockStyle.Top;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 11F);
            btnBilling.ForeColor = Color.Gainsboro;
            btnBilling.Location = new Point(0, 230);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(220, 75);
            btnBilling.TabIndex = 4;
            btnBilling.Text = "Hesap Kesimi";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnPayable
            // 
            btnPayable.Dock = DockStyle.Top;
            btnPayable.FlatAppearance.BorderSize = 0;
            btnPayable.FlatStyle = FlatStyle.Flat;
            btnPayable.Font = new Font("Segoe UI", 11F);
            btnPayable.ForeColor = Color.Gainsboro;
            btnPayable.Location = new Point(0, 155);
            btnPayable.Name = "btnPayable";
            btnPayable.Size = new Size(220, 75);
            btnPayable.TabIndex = 3;
            btnPayable.Text = "Verilecekler";
            btnPayable.UseVisualStyleBackColor = true;
            btnPayable.Click += btnPayable_Click;
            // 
            // btnReceivable
            // 
            btnReceivable.Dock = DockStyle.Top;
            btnReceivable.FlatAppearance.BorderSize = 0;
            btnReceivable.FlatStyle = FlatStyle.Flat;
            btnReceivable.Font = new Font("Segoe UI", 11F);
            btnReceivable.ForeColor = Color.Gainsboro;
            btnReceivable.Location = new Point(0, 80);
            btnReceivable.Name = "btnReceivable";
            btnReceivable.Size = new Size(220, 75);
            btnReceivable.TabIndex = 2;
            btnReceivable.Text = "Alınacaklar";
            btnReceivable.UseVisualStyleBackColor = true;
            btnReceivable.Click += btnReceivable_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 86, 103);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblLogo.ForeColor = Color.Gainsboro;
            lblLogo.Location = new Point(48, 33);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(116, 23);
            lblLogo.TabIndex = 0;
            lblLogo.Text = " Ercan Global";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 122, 146);
            panelTitleBar.Controls.Add(button1);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(992, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(6, 12);
            button1.Name = "button1";
            button1.Size = new Size(44, 45);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(438, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ana Sayfa";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(992, 619);
            panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 699);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panelMenu;
        private Button btnReceivable;
        private Panel panelLogo;
        private Button btnBilling;
        private Button btnPayable;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private Panel panelDesktop;
        private Button button1;
    }
}
