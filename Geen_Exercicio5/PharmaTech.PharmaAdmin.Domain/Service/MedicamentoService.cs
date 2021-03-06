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
        public static long CadastrarMedicamento(List<Medicamento> listaMedicamento, string nome, double preco, long codigo, TipoMedicamento tipo)
        {
            List<Medicamento> listaTemp = new List<Medicamento>();
            Medicamento novoMedicamento = new Medicamento(codigo, nome, preco, tipo);
            listaTemp.Add(novoMedicamento);

            foreach (Medicamento cadastrado in listaMedicamento)
            {
                if (codigo == cadastrado.Codigo)
                {
                    return 0;
                }
            }
            return codigo;
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
            foreach (var codigo in dados)
            {
                medicamento.Codigo = codigo;
            }
            return medicamento.Codigo;
        }

        public static List<Medicamento> ImprimirMedicamentoPorTipo(List<Medicamento> listaMedicamento, TipoMedicamento tipo)
        {
            var dados = listaMedicamento.Where(md => md.Tipo.Equals(tipo));
            foreach (var remedio in dados)
            {
                Console.WriteLine(remedio);
            }
            return null;
        }
    }
}
