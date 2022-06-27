using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Enum;
using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Model;
using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medicamento> listaMedicamento = new List<Medicamento>();

            Medicamento remedio1 = new Medicamento
            {
                Codigo = 101010,
                Nome = "Paracetamol",
                Preco = 4.75,
                Tipo = TipoMedicamento.Generico
            };

            Medicamento remedio2 = new Medicamento
            {
                Codigo = 202020,
                Nome = "Dipirona",
                Preco = 6.30,
                Tipo = TipoMedicamento.Similar
            };

            listaMedicamento.Add(remedio1);
            listaMedicamento.Add(remedio2);

            //Console.WriteLine(MedicamentoService.CadastrarMedicamento(listaMedicamento, paracetamol, paracetamol.Tipo));
            //Console.WriteLine(MedicamentoService.CadastrarMedicamento(listaMedicamento, dipirona, dipirona.Tipo));

            Medicamento.Imprimir(remedio1);
            Medicamento.Imprimir(remedio2);
            Console.WriteLine();

            MedicamentoService.AlterarPreco(remedio1, 11.35);
            MedicamentoService.AlterarPreco(remedio2, 4.45);

            Medicamento.Imprimir(remedio1);
            Medicamento.Imprimir(remedio2);
            Console.WriteLine();

            Console.WriteLine(MedicamentoService.BuscarCodigoPorNome(listaMedicamento, "Paracetamol"));
            Console.WriteLine(MedicamentoService.BuscarCodigoPorNome(listaMedicamento, "Dipirona"));
            Console.WriteLine();

            //MedicamentoService.ImprimirMedicamentoPorTipo(listaMedicamento, TipoMedicamento.Generico);
        }
    }
}
