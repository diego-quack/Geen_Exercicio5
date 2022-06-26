using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Enum;
using System;

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

        public static void Imprimir(Medicamento medicamento)
        {
            Console.WriteLine($"O medicamento {medicamento.Nome}, de código {medicamento.Codigo}, " +
                              $"é do tipo {medicamento.Tipo} e custa R$: {medicamento.Preco.ToString("F2")}");
        }
    }
}
