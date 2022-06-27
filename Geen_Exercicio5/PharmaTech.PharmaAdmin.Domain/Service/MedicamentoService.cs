using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Enum;
using Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio5.PharmaTech.PharmaAdmin.Domain.Service
{
    class MedicamentoService
    {
        public static long CadastrarMedicamento(List<Medicamento> listaMedicamento, Medicamento medicamento, TipoMedicamento tipo)
        {
            foreach (Medicamento remedio in listaMedicamento)
            {
                listaMedicamento.Add(medicamento);
                if (remedio.Codigo == medicamento.Codigo)
                {
                    return medicamento.Codigo;
                }
            }
            return 0;
        }
        public static void AlterarPreco(Medicamento medicamento, double preco)
        {
            if (preco > 0)
            {
                medicamento.Preco = preco;
            }
        }

        public static long BuscarCodigoPorNome(List<Medicamento> listaMedicamento, string nome)
        {
            Medicamento medicamento = new Medicamento();

            var dados = listaMedicamento.Where(md => md.Nome.Equals(nome)).Select(md => md.Codigo).DefaultIfEmpty(0);
            foreach(var codigo in dados)
            {
                medicamento.Codigo = codigo;
            }
            return medicamento.Codigo;
        }
        public static void ImprimirMedicamentoPorTipo(List<Medicamento> listaMedicamento, TipoMedicamento tipo)
        {
            var dados = listaMedicamento.Where(md => md.Tipo.Equals(tipo));
            foreach (var remedio in dados)
            {
                listaMedicamento.Add(remedio);
            }
            Console.WriteLine(listaMedicamento);
        }
    }
}
