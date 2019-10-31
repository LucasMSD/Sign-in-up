using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CadastroLogin
{
    public partial class frmCadastro : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-5LSHH6H;Initial Catalog=dbContaCadastro;Integrated Security=True");
        Thread t2;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFazerLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(OpenWindow);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void OpenWindow()
        {
            Application.Run(new frmLogin());
        }

        private void TxtNomeCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)46))
            {
                e.Handled = true;
            }
        }

        private void TxtEmailCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || e.KeyChar == (char)46 || e.KeyChar == (char)64 || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            SetTextBoxVisibility();
            if (TestTextBoxContent())
            {
                ManageDataBase();
            }
        }

        private void SetTextBoxVisibility()
        {
            lblSenhaVazia.Visible = false;
            lblSenhaNVazia.Visible = false;
            lblInvalido.Visible = false;
            lblNomeVazio.Visible = false;
            lblEmailVazio.Visible = false;
            lblSexoVazio.Visible = false;
        }

        bool IsEveryThingOk;
        bool IsEveryThingOk2;
        private bool TestTextBoxContent()
        {
            IsEveryThingOk2 = true;
            if (txtNomeCadastro.Text.Trim() == "")
            {
                lblNomeVazio.Visible = true;
                IsEveryThingOk2 = false;
            }

            string Email = txtEmailCadastro.Text.Trim();

            if (Email == "")
            {
                lblEmailVazio.Visible = true;
                IsEveryThingOk2 = false;
            }

            if (!(Email.EndsWith(".com") && Email.IndexOf("@") > 0))
            {
                lblInvalido.Visible = true;
                IsEveryThingOk2 = false;
            }

            if (cboSexoCadastro.Text == "")
            {
                lblSexoVazio.Visible = true;
                IsEveryThingOk2 = false;
            }

            if (txtSenhaCadastro.Text == "")
            {
                lblSenhaVazia.Visible = true;
                IsEveryThingOk2 = false;
            }

            if (txtSenhaDeNovoCadastro.Text == "")
            {
                lblSenhaNVazia.Visible = true;
                IsEveryThingOk2 = false;
            }

            if (txtSenhaCadastro.Text != txtSenhaDeNovoCadastro.Text && (lblSenhaNVazia.Visible == false && lblSenhaVazia.Visible == false))
            {
                MessageBox.Show("Senhas diferentes");
                IsEveryThingOk2 = false;
            }

            if (IsEveryThingOk && IsEveryThingOk2)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void ManageDataBase()
        {
            // Dados do form
            string Nome = txtNomeCadastro.Text.TrimEnd();
            string Email = txtEmailCadastro.Text.TrimEnd();
            string Sexo = cboSexoCadastro.Text.Trim() == "Masculino" ? "M" : "F";
            string Senha = txtSenhaCadastro.Text;
            string DataDeNascimento = FormatarData(dtpDataNascimento.Text);
            // Criando string de conexão

            

            // Criando string de comando sql

            string SqlInsertPessoa = "insert into td_Pessoa (Nome, Email, Data_Nascimento, Sexo) values (@Nome, @Email, @DataDeNascimento, @Sexo);";
            string SqlInsertConta = "insert into td_Conta (Id_Pessoa, Senha, Email) values (@Id_Pessoa, @Senha, @Email);";
            string SqlSelectPessoa = "select Id_Pessoa from td_Pessoa where Email = @Email";

            try
            {
                // Criando um objeto da classe SqlCommand passando como parâmetro
                // a string SqlComando e conexao

                SqlCommand InsertPessoa = new SqlCommand(SqlInsertPessoa, conexao);
                SqlCommand SelectPessoa = new SqlCommand(SqlSelectPessoa, conexao);
                SqlCommand InsertConta = new SqlCommand(SqlInsertConta, conexao);
                // Abrindo a conexão com o banco de dados

                conexao.Open();

                // Inserindo os valores das variáveis para o InsertPessoa
                InsertPessoa.Parameters.Add(new SqlParameter("@Nome", Nome));
                InsertPessoa.Parameters.Add(new SqlParameter("@Email", Email));
                InsertPessoa.Parameters.Add(new SqlParameter("@DataDeNascimento", DataDeNascimento));
                InsertPessoa.Parameters.Add(new SqlParameter("@Sexo", Sexo));

                // Executando os comandos InsertPessoa
                InsertPessoa.ExecuteNonQuery();

                // Inserindo os valores das variáveis para o SelectPessoa
                SelectPessoa.Parameters.Add(new SqlParameter("@Email", Email));
                int IdPessoa = Convert.ToInt32(SelectPessoa.ExecuteScalar());

                // Inserindo os valores das variáveis para o InsertConta 
                InsertConta.Parameters.Add(new SqlParameter("@Id_Pessoa", IdPessoa));
                InsertConta.Parameters.Add(new SqlParameter("@Senha", Senha));
                InsertConta.Parameters.Add(new SqlParameter("@Email", Email));
     
                // Executando os comandos InsertConta;
                InsertConta.ExecuteNonQuery();

                // Fechando conexão

                conexao.Close();

                MessageBox.Show("Cadastro feito!!");

                this.Close();
                t2 = new Thread(OpenWindow);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();

            } catch (SqlException sqlex)
            {
                MessageBox.Show($"Ocorreu um erro {sqlex}");
            } finally
            {
                conexao.Close();
            }
        }

        private string FormatarData(string dtpDataNascimento)
        {
            string data = dtpDataNascimento.Remove(2, 1).Remove(4, 1);
            string ano = data.Remove(0, 4);
            string mes = data.Remove(4).Remove(0, 2);
            string dia = data.Remove(2);
            return ano + mes + dia;
        }

        private void TxtEmailCadastro_Leave(object sender, EventArgs e)
        {
            string SqlEmailSelect = "select Email from td_Pessoa where Email = @Email";

            SqlCommand select = new SqlCommand(SqlEmailSelect, conexao);

            select.Parameters.Add(new SqlParameter("@Email", txtEmailCadastro.Text.TrimEnd()));

            conexao.Open();

            try
            {
                string Email = select.ExecuteScalar().ToString();
                lblEmailVazio.Visible = false;
                lblInvalido.Visible = false;
                lblEmailCadastrado.Visible = true;
                IsEveryThingOk = false;
            } catch
            {
                lblEmailCadastrado.Visible = false;
                IsEveryThingOk = true;
            }
            conexao.Close();
        }
    }
}
