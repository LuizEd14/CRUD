﻿
namespace CadastroDeClientes
{
    partial class frmCadastroDeClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.plTopo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTopo
            // 
            this.plTopo.BackColor = System.Drawing.SystemColors.Highlight;
            this.plTopo.Controls.Add(this.lblTitulo);
            this.plTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopo.Location = new System.Drawing.Point(0, 0);
            this.plTopo.Name = "plTopo";
            this.plTopo.Size = new System.Drawing.Size(425, 45);
            this.plTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbCadastro);
            this.tabControl1.Controls.Add(this.tbConsulta);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 332);
            this.tabControl1.TabIndex = 1;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.txtCPF);
            this.tbCadastro.Controls.Add(this.lblCPF);
            this.tbCadastro.Controls.Add(this.txtEmail);
            this.tbCadastro.Controls.Add(this.lblEmail);
            this.tbCadastro.Controls.Add(this.txtNomeSocial);
            this.tbCadastro.Controls.Add(this.lblNomeSocial);
            this.tbCadastro.Controls.Add(this.txtNomeCompleto);
            this.tbCadastro.Controls.Add(this.lblNomeCompleto);
            this.tbCadastro.Location = new System.Drawing.Point(4, 29);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(393, 299);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Dados de Clientes";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 233);
            this.txtCPF.Mask = "###,###,###-##";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(119, 26);
            this.txtCPF.TabIndex = 7;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCPF.Location = new System.Drawing.Point(6, 204);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(6, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(6, 105);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(270, 26);
            this.txtNomeSocial.TabIndex = 3;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeSocial.Location = new System.Drawing.Point(6, 76);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(98, 20);
            this.lblNomeSocial.TabIndex = 2;
            this.lblNomeSocial.Text = "Nome Social";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(6, 41);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(270, 26);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 12);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(123, 20);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.lstCliente);
            this.tbConsulta.Controls.Add(this.btnPesquisar);
            this.tbConsulta.Controls.Add(this.txtBuscar);
            this.tbConsulta.Location = new System.Drawing.Point(4, 29);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(393, 299);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // lstCliente
            // 
            this.lstCliente.ContextMenuStrip = this.contextMenuStrip1;
            this.lstCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCliente.HideSelection = false;
            this.lstCliente.Location = new System.Drawing.Point(3, 56);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(387, 240);
            this.lstCliente.TabIndex = 3;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            this.lstCliente.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstCliente_ItemSelectionChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(308, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(21, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(272, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(26, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 40);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNovoCliente.Location = new System.Drawing.Point(137, 400);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(105, 40);
            this.btnNovoCliente.TabIndex = 3;
            this.btnNovoCliente.Text = "Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem1.Text = "Excluir Cliente";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Red;
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCliente.Location = new System.Drawing.Point(301, 400);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(105, 40);
            this.btnExcluirCliente.TabIndex = 5;
            this.btnExcluirCliente.Text = "Excluir Cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // frmCadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 461);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.plTopo);
            this.Name = "frmCadastroDeClientes";
            this.Text = "Cadastro";
            this.plTopo.ResumeLayout(false);
            this.plTopo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnExcluirCliente;
    }
}

