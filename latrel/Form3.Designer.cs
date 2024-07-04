namespace latrel
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            checkHuman = new CheckBox();
            textTeste = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            entre = new Button();
            Senha = new TextBox();
            Email = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(checkHuman);
            panel1.Controls.Add(textTeste);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(entre);
            panel1.Controls.Add(Senha);
            panel1.Controls.Add(Email);
            panel1.Cursor = Cursors.PanNorth;
            panel1.Location = new Point(-50, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 622);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(139, 318);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "12345";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 300);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 11;
            label3.Text = "Confirma senha";
            label3.Click += label3_Click;
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
            checkHuman.CheckedChanged += this.checkHuman_CheckedChanged;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(214, 354);
            label4.Name = "label4";
            label4.Size = new Size(98, 12);
            label4.TabIndex = 6;
            label4.Text = "Esqueci minha senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(139, 235);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(139, 169);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
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
            entre.Text = "Cadastrar";
            entre.UseVisualStyleBackColor = false;
            entre.Click += entre_Click;
            // 
            // Senha
            // 
            Senha.BackColor = Color.FromArgb(64, 64, 64);
            Senha.BorderStyle = BorderStyle.FixedSingle;
            Senha.Font = new Font("Segoe UI", 12F);
            Senha.Location = new Point(139, 253);
            Senha.Multiline = true;
            Senha.Name = "Senha";
            Senha.PasswordChar = '*';
            Senha.PlaceholderText = "12345";
            Senha.Size = new Size(201, 23);
            Senha.TabIndex = 1;
            Senha.TextChanged += Senha_TextChanged;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(64, 64, 64);
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(139, 187);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "Ex:canal@gmail.com";
            Email.Size = new Size(201, 26);
            Email.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 577);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkHuman;
        private Label textTeste;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button entre;
        private TextBox Senha;
        private TextBox Email;
        private Label label3;
        private TextBox textBox1;
    }
}