using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {


        }

        private void btnEntrar_Click(object sender, EventArgs e)

        //objeto é uma instância da classe
        {
            Usuario usuario = new Usuario();
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;

            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Login Obrigatorio");
                txtLogin.Focus();
            }
            else if (usuario.Senha.Equals(""))
            {
                MessageBox.Show("Usuario ou senha invalido");
                txtSenha.Focus();
            }
            else
            {
                MessageBox.Show("Sucesso!");
            }
        }
    }
}


