using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace latrel
{
    public partial class Form3 : Form
    {
        private string emailCadastrado;
        private string senhaCadastrada;
        private bool senhaInvalidaMostrada = false;

        public Form3()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Verificar se a senha confirmada é diferente da senha original
            if (textBox1.Text != Senha.Text)
            {
                // Se a mensagem não foi mostrada antes, mostramos agora
                if (!senhaInvalidaMostrada)
                {
                    MessageBox.Show("Senhas não coincidem. Por favor, insira novamente.", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhaInvalidaMostrada = true; // Marcamos que a mensagem foi mostrada
                }
            }
            else
            {
                // Se as senhas coincidirem, resetamos o estado para permitir exibir a mensagem novamente se necessário
                senhaInvalidaMostrada = false;
            }
        }

        private void Senha_TextChanged(object sender, EventArgs e)
        {
            // Não precisamos de lógica específica aqui além da validação em textBox1_TextChanged
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Verificar se a senha confirmada é diferente da senha original
            if (textBox1.Text != Senha.Text)
            {
                // Se a mensagem não foi mostrada antes, mostramos agora
                if (!senhaInvalidaMostrada)
                {
                    MessageBox.Show("Senhas não coincidem. Por favor, insira novamente.", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhaInvalidaMostrada = true; // Marcamos que a mensagem foi mostrada
                }
            }
            else
            {
                // Se as senhas coincidirem, resetamos o estado para permitir exibir a mensagem novamente se necessário
                senhaInvalidaMostrada = false;
            }
        }

        private void entre_Click(object sender, EventArgs e)
        {
            // Armazenar os dados cadastrados pelo usuário
            emailCadastrado = Email.Text;
            senhaCadastrada = Senha.Text;

            // Exibir mensagem de confirmação (opcional)
            MessageBox.Show("Credenciais cadastradas com sucesso!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar campos após cadastro
            LimparCampos();

            // Criar uma instância do Form3
            Form1 form1 = new Form1();

            // Exibir o Form3
            form1.Show();

            // Opcional: Ocultar o Form1 após abrir o Form3
            this.Hide();
        }

        private void LimparCampos()
        {
            Email.Text = "";
            Senha.Text = "";
            textBox1.Text = "";
        }

        public string GetEmailCadastrado()
        {
            return emailCadastrado;
        }

        public string GetSenhaCadastrada()
        {
            return senhaCadastrada;
        }

        public bool ValidarCredenciais(string email, string senha)
        {
            // Definir aqui as credenciais válidas (exemplo)
            string emailCorreto = "admin";
            string senhaCorreta = "12345";

            // Verificar se as credenciais fornecidas correspondem às cadastradas
            return email == emailCorreto && senha == senhaCorreta;
        }


    private void checkHuman_CheckedChanged(object sender, EventArgs e)
            {

            }
    }
}