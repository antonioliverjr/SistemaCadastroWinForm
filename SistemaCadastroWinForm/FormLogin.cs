using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastroWinForm
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_usuario.Text.ToLower();
            string pass = txt_senha.Text;
            
            if (CadastroUsuario.Login(user, pass))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e Senha não conferem!");
                txt_usuario.Text = "";
                txt_senha.Text = "";
                txt_usuario.Focus();
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            this.Close();
        }
    }
}
