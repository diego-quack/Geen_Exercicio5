using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Model
{
    class Medicamento
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double  Preco { get; set; }
        public TipoMedicamento Tipo { get; set; }

        public Medicamento()
        {
        }

        public Medicamento(long codigo, string nome, double preco, TipoMedicamento tipo)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"O medicamento {Nome} de código {Codigo} " +
                              $"é do tipo {Tipo} e custa R$: {Preco.ToString("F2")}");
        }
    }
}
