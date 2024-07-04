namespace latrel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Email = new TextBox();
            Senha = new TextBox();
            entre = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textTeste = new Label();
            checkHuman = new CheckBox();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(64, 64, 64);
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(139, 225);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "Ex:canal@gmail.com";
            Email.Size = new Size(201, 26);
            Email.TabIndex = 0;
            Email.TextChanged += Email_TextChanged;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(64, 64, 64);
            Senha.BorderStyle = BorderStyle.FixedSingle;
            Senha.Font = new Font("Segoe UI", 12F);
            Senha.Location = new Point(139, 304);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.PasswordChar = '*';
            Senha.PlaceholderText = "12345";
            Senha.Size = new Size(201, 23);
            Senha.TabIndex = 1;
            Senha.TextChanged += Senha_TextChanged;
            // 
            // entre
            // 
            entre.BackColor = Color.Green;
            entre.BackgroundImageLayout = ImageLayout.None;
            entre.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            entre.FlatAppearance.BorderSize = 2;
            entre.FlatStyle = FlatStyle.Popup;
            entre.Location = new Point(139, 380);
            entre.Name = "entre";
            entre.Size = new Size(201, 44);
            entre.TabIndex = 2;
            entre.Text = "Entrar";
            entre.UseVisualStyleBackColor = false;
            entre.Click += entre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(139, 207);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(139, 286);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(242, 330);
            label4.Name = "label4";
            label4.Size = new Size(98, 12);
            label4.TabIndex = 6;
            label4.Text = "Esqueci minha senha";
            label4.Click += label4_Click;
            // 
            // textTeste
            // 
            textTeste.BackColor = Color.Transparent;
            textTeste.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textTeste.ForeColor = Color.FromArgb(192, 0, 0);
            textTeste.Location = new Point(139, 354);
            textTeste.Name = "textTeste";
            textTeste.Size = new Size(201, 23);
            textTeste.TabIndex = 7;
            textTeste.TextAlign = ContentAlignment.MiddleCenter;
            textTeste.Click += textTeste_Click;
            // 
            // checkHuman
            // 
            checkHuman.AutoSize = true;
            checkHuman.BackColor = Color.Transparent;
            checkHuman.BackgroundImageLayout = ImageLayout.Zoom;
            checkHuman.FlatStyle = FlatStyle.Popup;
            checkHuman.ForeColor = Color.Black;
            checkHuman.Location = new Point(170, 453);
            checkHuman.Name = "checkHuman";
            checkHuman.Size = new Size(132, 19);
            checkHuman.TabIndex = 8;
            checkHuman.Text = "você e um humano?";
            checkHuman.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkHuman);
            panel1.Controls.Add(textTeste);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(entre);
            panel1.Controls.Add(Senha);
            panel1.Controls.Add(Email);
            panel1.Cursor = Cursors.PanNorth;
            panel1.Location = new Point(-47, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 649);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(186, 478);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 9;
            button1.Text = "00000000000000000000000000000";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 616);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Email;
        private TextBox Senha;
        private Button entre;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label textTeste;
        private CheckBox checkHuman;
        private Panel panel1;
        private Button button1;
    }
}
