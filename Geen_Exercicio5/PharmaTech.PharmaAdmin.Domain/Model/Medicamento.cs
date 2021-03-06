using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Enum;
using System;

namespace Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Model
{
    class Medicamento
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
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

        public static void Imprimir(Medicamento medicamento)
        {
            Console.WriteLine(medicamento);
        }

        public override string ToString()
        {
            return $"O medicamento {Nome}, de código {Codigo}, " +
                   $"é do tipo {Tipo} e custa R$: {Preco.ToString("F2")}";
        }
    }
}
