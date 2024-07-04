using System.Security.Cryptography.X509Certificates;

namespace latrel
{
    public partial class Form1 : Form
    {
        private string admin = "admin";
        private string senhac = "12345";

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string email = entre.Text;

        }
        private void entre_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string senha = Senha.Text;

            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
            {
                // Criar uma instância do Form3 para verificar as credenciais
                using (Form3 form3 = new Form3())
                {
                    // Verificar se as credenciais digitadas correspondem às cadastradas no Form3
                    if (form3.ValidarCredenciais(email, senha))
                    {
                        // Armazenar os dados cadastrados no Form3
                        string emailCadastrado = form3.GetEmailCadastrado();
                        string senhaCadastrada = form3.GetSenhaCadastrada();

                        // Exibir mensagem de sucesso
                        MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Exibir o próximo formulário (Form2, por exemplo)
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        // Exibir mensagem de erro
                        MessageBox.Show("Email ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Exibir mensagem de erro
                MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textTeste_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir o Form3 quando o botão for clicado
            Form3 form3 = new Form3();
            form3.Show();

            // Opcional: Ocultar o Form1 após abrir o Form3
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir o Form3 quando o LinkLabel for clicado

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Criar uma instância do Form3
            Form3 form3 = new Form3();

            // Exibir o Form3
            form3.Show();

            // Opcional: Ocultar o Form1 após abrir o Form3
            this.Hide();
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
