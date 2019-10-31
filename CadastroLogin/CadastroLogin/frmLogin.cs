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
    public partial class frmLogin : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-5LSHH6H;Initial Catalog=dbContaCadastro;Integrated Security=True");
        Thread t1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFazerCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(OpenWindow);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void OpenWindow(Object obj)
        {
            Application.Run(new frmCadastro());
        }

        private void TxtEmailLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || e.KeyChar == (char)46 || e.KeyChar == (char)8 || e.KeyChar == (char)64))
            {
                e.Handled = true;
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string SelectConta = "select Id_Pessoa from td_Conta where Email = @Email and Senha = @Senha";
            string SelectNome = "select Nome from td_Pessoa where Id_Pessoa = @Id_Pessoa";

            SqlCommand VerificaConta = new SqlCommand(SelectConta, conexao);
            SqlCommand PegaNome = new SqlCommand(SelectNome, conexao);

            VerificaConta.Parameters.Add(new SqlParameter("@Email", txtEmailLogin.Text.TrimEnd()));
            VerificaConta.Parameters.Add(new SqlParameter("@Senha", txtSenhaLogin.Text.ToString()));
            

            conexao.Open();

            try
            {
                string Id_Pessoa = VerificaConta.ExecuteScalar().ToString();
                PegaNome.Parameters.Add(new SqlParameter("@Id_Pessoa", Id_Pessoa));
                lblLoginIncorreto.Visible = false;
                string UserName = PegaNome.ExecuteScalar().ToString();
                string FirstName = UserName.Contains(' ') ? UserName.Remove(UserName.IndexOf(" ")) : UserName;
                MessageBox.Show($"Seja bem vindo(a), {FirstName}!");
            } catch
            {
                lblLoginIncorreto.Visible = true;
            }
            conexao.Close();
        }
    }
}
