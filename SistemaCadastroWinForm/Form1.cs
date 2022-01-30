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
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        List<EstadoCivil> estadoCivils;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();
            estadoCivils = new List<EstadoCivil>();
            foreach (var estado in Enum.GetValues(typeof(EstadoCivil)))
            {
                estadoCivils.Add((EstadoCivil) estado);
            }

            foreach (var civ in estadoCivils)
            {
                txt_estado_civil.Items.Add(civ);
            }

            txt_estado_civil.SelectedIndex = 1;
            radioO.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"C:\Workspace\SistemaCadastroWinForm\SistemaCadastroWinForm\htc.ico");

            FormLogin login = new FormLogin();

            while (CadastroUsuario.UsuarioLogado == null)
            {
                Visible = false;
                login.ShowDialog();

                if (FormLogin.Cancelar)
                {
                    this.Close();
                    Application.ExitThread();
                    return;
                }
            }

            Visible = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Pessoa p in pessoas)
            {
                if (p.Nome == txt_nome.Text)
                {
                    index = pessoas.IndexOf(p);
                }
            }

            if (txt_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!");
                txt_nome.Focus();
                return;
            }
            else if (txt_telefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone!");
                txt_telefone.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txt_nome.Text;
            pessoa.DataNascimento = txt_data.Text;
            pessoa.EstadoCivil =  txt_estado_civil.SelectedItem.ToString();
            pessoa.Telefone = txt_telefone.Text;
            pessoa.CasaPropria = check_casa.Checked;
            pessoa.Veiculo = check_veiculo.Checked;
            pessoa.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(pessoa);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                pessoas[index] = pessoa;
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }

            btn_limpar_Click(btn_limpar, EventArgs.Empty);
            Listar();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_data.Text = "";
            txt_estado_civil.SelectedIndex = 1;
            txt_telefone.Text = "";
            check_casa.Checked = false;
            check_veiculo.Checked = false;
            radioM.Checked = false;
            radioF.Checked = false;
            radioO.Checked = true;
            txt_nome.Focus();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Selecione um cadastro primeiro!");
                lista.Focus();
                return;
            }
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.print());
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            if (indice != -1)
            {
                Pessoa p = pessoas[indice];
                txt_nome.Text = p.Nome;
                txt_data.Text = p.DataNascimento;
                txt_estado_civil.SelectedIndex = txt_estado_civil.FindStringExact(p.EstadoCivil);
                txt_telefone.Text = p.Telefone;
                check_casa.Checked = p.CasaPropria;
                check_veiculo.Checked = p.Veiculo;
                radioO.Checked = false;
                switch (p.Sexo)
                {
                    case 'M':
                        radioM.Checked = true;
                        break;
                    case 'F':
                        radioF.Checked = true;
                        break;
                    default:
                        radioO.Checked = true;
                        break;
                }

            }
        }
    }
}
