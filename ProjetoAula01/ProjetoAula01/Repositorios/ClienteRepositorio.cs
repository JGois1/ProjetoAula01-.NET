using ProjetoAula01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Repositorios
{
    public class ClienteRepositorio
    {
        /// <summary>
        /// Rotina/metodo pra gravar dados do cliente em txt
        /// </summary>
        /// <param name="cliente">Objeto contendo os dados da classe Cliente</param>
        public void ExportarDados(Cliente cliente)
        {
            var streamWriter = new StreamWriter("c:\\temp\\clientes.txt", true);

            streamWriter.WriteLine("ID         :" + cliente.Id);
            streamWriter.WriteLine("Nome       :" + cliente.Nome);
            streamWriter.WriteLine("Email      :" + cliente.Email);
            streamWriter.WriteLine("CPF        :" + cliente.Cpf);
            streamWriter.WriteLine("Telefone   :" + cliente.Telefone);
            streamWriter.WriteLine("Incluido em:" + cliente.DataInclusao);
            streamWriter.WriteLine("...");

            streamWriter.Close();
        }
    }
}
