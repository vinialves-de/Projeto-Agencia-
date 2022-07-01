using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Controller
{
    class ConexaoBanco
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mateus.fxavier\source\repos\ProjetoAgenciaTI11T\bdagenciaviagem.mdf;Integrated Security=True";
        }
    }
}
