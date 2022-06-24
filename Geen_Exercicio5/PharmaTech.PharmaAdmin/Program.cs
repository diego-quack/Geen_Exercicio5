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

            Medicamento paracetamol = new Medicamento
            {
                Codigo = 101010,
                Nome = "Paracetamol",
                Preco = 4.75,
                Tipo = TipoMedicamento.Generico
            };

            Medicamento dipirona = new Medicamento
            {
                Codigo = 202020,
                Nome = "Dipirona",
                Preco = 6.30,
                Tipo = TipoMedicamento.Generico
            };

            //Console.WriteLine(MedicamentoService.CadastrarMedicamento(listaMedicamento, paracetamol, paracetamol.Tipo));
            //Console.WriteLine(MedicamentoService.CadastrarMedicamento(listaMedicamento, dipirona, dipirona.Tipo));

            MedicamentoService.ImprimirMedicamento(paracetamol);
            MedicamentoService.ImprimirMedicamento(dipirona);
            Console.WriteLine();

            MedicamentoService.AlterarPreco(paracetamol, 11.35);
            MedicamentoService.AlterarPreco(dipirona, 4.45);

            MedicamentoService.ImprimirMedicamento(paracetamol);
            MedicamentoService.ImprimirMedicamento(dipirona);
            Console.WriteLine();
        }
    }
}
