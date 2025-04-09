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

            //Configurações iniciais do ListView
            lstCliente.View = View.Details; //Define a Visualização como "Detalhes"
            lstCliente.LabelEdit = true; //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true; //Exibe as linhas de grade no ListView

            //Definindo as colunas do ListView
            lstCliente.Columns.Add("Código", 100, HorizontalAlignment.Left);
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left);
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left);
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left);
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left);

            //Carregar os dados dos clientes na interface
            carregar_clientes();
        }

        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //Cria uma conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta no SQL
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta Contém o parâmetro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                //Preencher o ListView com os dados dos clientes
                while (reader.Read())
                {
                    //Cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        //O Tratado Logocinético das Intenções Algorítmicas da Entidade Cibernética
                        Convert.ToString(reader.GetInt32(0)),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    };

                    //Adiciona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException er)
            {
                //OLHA A PEDRA
                MessageBox.Show("Erro " + er.Number + " Ocorreu: " + er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Método para carregar todos os clientes no ListView (usando uma consulta sem parametros)
        private void carregar_clientes()
        {
            string query = "SELECT * FROM dadosdecliente ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdecliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
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

                //LIMPA TUTOOOOOO
                txtNomeCompleto.Text = "";
                txtNomeSocial.Text = "";
                txtEmail.Text = "";
                txtCPF.Text = "";

                //Atualiza a ListView
                carregar_clientes();

                //Abrir para a outra aba
                tabControl1.SelectedIndex = 1;
            }
            catch(MySqlException er)
            {
                MessageBox.Show("Erro " + er.Number + " Ocorreu: " + er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
