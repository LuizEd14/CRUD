using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroDeClientes
{
    public partial class frmCadastroDeClientes : Form
    {

        //Conexão com o MySQL
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        public frmCadastroDeClientes()
        {
            InitializeComponent();
            ArredondarBotao(btnSalvar, 50);
        }

        //função para validar o CPF
        private bool isValidCPFLegth(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        //função para validar o E-mail
        private bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string.IsNullOrEmpty(txtNomeCompleto.Text.Trim())) ||
                    (string.IsNullOrEmpty(txtEmail.Text.Trim())) ||
                    (string.IsNullOrEmpty(txtCPF.Text.Trim())))
                {
                    MessageBox.Show("Preencha todos os campos!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Validação do Nome completo
                string nomecompleto = txtNomeCompleto.Text.Trim();
                if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
                {
                    MessageBox.Show("Email inválido, Certifique-se que você digitou certo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Validação do E-mail
                string email = txtEmail.Text.Trim();
                if (!isValidEmail(email))
                {
                    MessageBox.Show("Email inválido, Certifique-se que você digitou certo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Validação do CPF
                string cpf = txtCPF.Text.Trim();
                if (!isValidCPFLegth(cpf))
                {
                    MessageBox.Show("CPF inválido, Certifique-se que voçê digitou certo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Criando uma conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um Cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();

                cmd.CommandText = "INSERT INTO dadosdecliente(nomecompleto, nomesocial, email, cpf) " + ("VALUES (@nomecompleto, @nomesocial, @email, @cpf)");

                //Adicionar parametros com o dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                //execulta o comando acima
                cmd.ExecuteNonQuery();

                //mensagem de sucesso
                MessageBox.Show("Salvo com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomeCompleto.Text = "";
                txtNomeSocial.Text = "";
                txtEmail.Text = "";
                txtCPF.Text = "";

            }
            catch(MySqlException er)
            {
                MessageBox.Show("Erro" + er.Number + "Ocorreu: " + er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Garantir que a conexão com o banco será fechada, mesmo se ocorrer um erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }


        public void ArredondarBotao(Control ctrl, int borderRadius)
        {

            if (ctrl == null || borderRadius <= 0 || ctrl.Width <= 0 || ctrl.Height <= 0) return;

            int raio = Math.Min(borderRadius, Math.Min(ctrl.Width, ctrl.Height) / 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, raio * 2, raio * 2, 180, 90);
                path.AddArc(ctrl.Width - (raio * 2), 0, raio * 2, raio * 2, 270, 90);
                path.AddArc(ctrl.Width - (raio * 2), ctrl.Height - (raio * 2), raio * 2, raio * 2, 0, 90);
                path.AddArc(0, ctrl.Height - (raio * 2), raio * 2, raio * 2, 90, 90);
                path.CloseFigure();

                ctrl.Region?.Dispose();
                ctrl.Region = new Region(path);
                ctrl.Invalidate();
            }

        }
    }
}
