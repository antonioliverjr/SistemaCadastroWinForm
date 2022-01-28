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
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();
            txt_estado_civil.Items.Add(EstadoCivil.Casado.ToString());
            txt_estado_civil.Items.Add(EstadoCivil.Solteiro.ToString());
            txt_estado_civil.Items.Add(EstadoCivil.Separado.ToString());
            txt_estado_civil.Items.Add(EstadoCivil.Viuvo.ToString());

            txt_estado_civil.SelectedIndex = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"C:\Workspace\SistemaCadastroWinForm\SistemaCadastroWinForm\htc.ico");
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
            else if (txt_telefone.Text == "")
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
            pessoa.EstadoCivil = txt_estado_civil.Items.ToString();
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

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

    }
}
