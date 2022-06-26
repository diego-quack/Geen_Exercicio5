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
        public static void ImprimirMedicamento(List<Medicamento> lista, Medicamento medicamento)
        {
            Medicamento.Imprimir(medicamento);
        }
        public static long BuscarCodigoPorNome(List<Medicamento> listaMedicamento, Medicamento nome)
        {
            var dados = listaMedicamento.Where(md => md.Nome.Equals(nome));
            foreach (var remedio in dados)
            {
                if(remedio.Codigo > 0)
                {
                    return remedio.Codigo;
                }
                return 0;
            }
            return nome.Codigo;
        }
        public static List<Medicamento> ImprimirMedicamentoPorTipo(List<Medicamento> listaMedicamento, TipoMedicamento tipo)
        {
            var dados = listaMedicamento.Where(md => md.Tipo.Equals(tipo));
            foreach (var remedio in dados)
            {
                if (remedio.Tipo.Equals(tipo))
                {
                    listaMedicamento.Add(remedio);
                    ImprimirMedicamento(listaMedicamento, remedio);
                }
                return null;
            }
            return listaMedicamento;
        }
    }
}
