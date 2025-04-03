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

namespace CadastroDeClientes
{
    public partial class frmCadastroDeClientes : Form
    {
        int CPF;
        string NomeCompleto;
        string NomeSocial;
        string Email;

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
                NomeCompleto = txtNomeCompleto.Text.Trim();
                if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
                {
                    MessageBox.Show("Email inválido, Certifique-se que você digitou certo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //Validação do E-mail
                Email = txtEmail.Text.Trim();
                if (!isValidEmail(Email))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
