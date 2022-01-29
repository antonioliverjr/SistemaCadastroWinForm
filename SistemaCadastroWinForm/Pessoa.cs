using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroWinForm
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }

        private int idade {
            get
            {
                var ano = DateTime.Now;
                var data = Convert.ToDateTime(DataNascimento);
                return ano.Year - data.Year;
            }
        }

        public string print()
        {
            return $"{Nome} - {EstadoCivil} - {idade} Idade";
        }
    }
}
