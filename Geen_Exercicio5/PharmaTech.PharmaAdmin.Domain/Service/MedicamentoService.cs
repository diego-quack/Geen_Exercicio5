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
            listaMedicamento.Add(medicamento);

            foreach(Medicamento remedio in listaMedicamento)
            {
                if(remedio.Codigo == medicamento.Codigo)
                {
                    return 0;
                }
            }
            return medicamento.Codigo;
        }
        public static void AlterarPreco(Medicamento medicamento, double preco)
        {
            if(preco > 0)
            {
                medicamento.Preco = preco;
            }
        }
        public static void ImprimirMedicamento(Medicamento medicamento)
        {
            medicamento.Imprimir();
        }
        public static long BuscarCodigoPorNome(List<Medicamento> listaMedicamento, Medicamento medicamento)
        {
            foreach(Medicamento remedio in listaMedicamento)
            {
                return remedio.Codigo;
            }
            return 0;
        }
        public static void ImprimirMedicamentoPorTipo(List<Medicamento> listaMedicamento, TipoMedicamento tipo)
        {
            foreach(Medicamento remedio in listaMedicamento)
            {
                remedio.Imprimir();
            }
        }
    }
}
