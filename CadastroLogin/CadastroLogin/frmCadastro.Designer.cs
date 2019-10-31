namespace CadastroLogin
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.cboSexoCadastro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaDeNovoCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFazerLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNomeVazio = new System.Windows.Forms.Label();
            this.lblEmailVazio = new System.Windows.Forms.Label();
            this.lblSexoVazio = new System.Windows.Forms.Label();
            this.lblSenhaNVazia = new System.Windows.Forms.Label();
            this.lblSenhaVazia = new System.Windows.Forms.Label();
            this.lblInvalido = new System.Windows.Forms.Label();
            this.lblEmailCadastrado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtNomeCadastro
            // 
            resources.ApplyResources(this.txtNomeCadastro, "txtNomeCadastro");
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeCadastro_KeyPress);
            // 
            // cboSexoCadastro
            // 
            this.cboSexoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoCadastro.FormattingEnabled = true;
            this.cboSexoCadastro.Items.AddRange(new object[] {
            resources.GetString("cboSexoCadastro.Items"),
            resources.GetString("cboSexoCadastro.Items1")});
            resources.ApplyResources(this.cboSexoCadastro, "cboSexoCadastro");
            this.cboSexoCadastro.Name = "cboSexoCadastro";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtEmailCadastro
            // 
            resources.ApplyResources(this.txtEmailCadastro, "txtEmailCadastro");
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailCadastro_KeyPress);
            this.txtEmailCadastro.Leave += new System.EventHandler(this.TxtEmailCadastro_Leave);
            // 
            // txtSenhaCadastro
            // 
            resources.ApplyResources(this.txtSenhaCadastro, "txtSenhaCadastro");
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // txtSenhaDeNovoCadastro
            // 
            resources.ApplyResources(this.txtSenhaDeNovoCadastro, "txtSenhaDeNovoCadastro");
            this.txtSenhaDeNovoCadastro.Name = "txtSenhaDeNovoCadastro";
            this.txtSenhaDeNovoCadastro.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnFazerLogin
            // 
            resources.ApplyResources(this.btnFazerLogin, "btnFazerLogin");
            this.btnFazerLogin.Name = "btnFazerLogin";
            this.btnFazerLogin.UseVisualStyleBackColor = true;
            this.btnFazerLogin.Click += new System.EventHandler(this.BtnFazerLogin_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // dtpDataNascimento
            // 
            resources.ApplyResources(this.dtpDataNascimento, "dtpDataNascimento");
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // lblNomeVazio
            // 
            this.lblNomeVazio.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeVazio.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblNomeVazio, "lblNomeVazio");
            this.lblNomeVazio.Name = "lblNomeVazio";
            // 
            // lblEmailVazio
            // 
            this.lblEmailVazio.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailVazio.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblEmailVazio, "lblEmailVazio");
            this.lblEmailVazio.Name = "lblEmailVazio";
            // 
            // lblSexoVazio
            // 
            this.lblSexoVazio.BackColor = System.Drawing.Color.Transparent;
            this.lblSexoVazio.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblSexoVazio, "lblSexoVazio");
            this.lblSexoVazio.Name = "lblSexoVazio";
            // 
            // lblSenhaNVazia
            // 
            this.lblSenhaNVazia.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaNVazia.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblSenhaNVazia, "lblSenhaNVazia");
            this.lblSenhaNVazia.Name = "lblSenhaNVazia";
            // 
            // lblSenhaVazia
            // 
            this.lblSenhaVazia.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaVazia.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblSenhaVazia, "lblSenhaVazia");
            this.lblSenhaVazia.Name = "lblSenhaVazia";
            // 
            // lblInvalido
            // 
            this.lblInvalido.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblInvalido, "lblInvalido");
            this.lblInvalido.Name = "lblInvalido";
            // 
            // lblEmailCadastrado
            // 
            this.lblEmailCadastrado.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lblEmailCadastrado, "lblEmailCadastrado");
            this.lblEmailCadastrado.Name = "lblEmailCadastrado";
            // 
            // frmCadastro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.lblEmailCadastrado);
            this.Controls.Add(this.lblInvalido);
            this.Controls.Add(this.lblSenhaVazia);
            this.Controls.Add(this.lblSenhaNVazia);
            this.Controls.Add(this.lblSexoVazio);
            this.Controls.Add(this.lblEmailVazio);
            this.Controls.Add(this.lblNomeVazio);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFazerLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenhaDeNovoCadastro);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtEmailCadastro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSexoCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.ComboBox cboSexoCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtSenhaDeNovoCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFazerLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblNomeVazio;
        private System.Windows.Forms.Label lblEmailVazio;
        private System.Windows.Forms.Label lblSexoVazio;
        private System.Windows.Forms.Label lblSenhaNVazia;
        private System.Windows.Forms.Label lblSenhaVazia;
        private System.Windows.Forms.Label lblInvalido;
        private System.Windows.Forms.Label lblEmailCadastrado;
    }
}