using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Vendas
    {
        private static int codigoVen;
        private static int codigoCliFK;
        private static int codigoFunFK;
        private static int codigoPacFK;
        private static int pagoVen;
        private static string retorno;

        public static int CodigoVen { get => codigoVen; set => codigoVen = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
        public static int CodigoPacFK { get => codigoPacFK; set => codigoPacFK = value; }
        public static int PagoVen { get => pagoVen; set => pagoVen = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
