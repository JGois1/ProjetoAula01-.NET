//declarando a localização da classe dentro do projeto
using ProjetoAula01.Entidades;
using ProjetoAula01.Repositorios;

namespace ProjetoAula01
{
    //definindo o nome da classe
    public class Program
    {
        //método para execução da classe, esse é o metodo/rotina 
        //utilizando para executar o projeto.
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSISTEMA PARA CADASTRO DE CLIENTES:\n");

            var cliente = new Cliente();

            //set:

            cliente.Id = Guid.NewGuid();
            cliente.DataInclusao = DateTime.Now;

            Console.Write("INFORME O NOME DO CLIENTE:");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O CPF DO CLIENTE:");
            cliente.Cpf = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE:");
            cliente.Email = Console.ReadLine();

            Console.Write("INFORME O TELEFONE DO CLIENTE:");
            cliente.Telefone = Console.ReadLine();
            
            //get:

            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine("\tID              :" + cliente.Id);
            Console.WriteLine("\tNome            :" + cliente.Nome);
            Console.WriteLine("\tEmail           :" + cliente.Email);
            Console.WriteLine("\tCpf             :" + cliente.Cpf);
            Console.WriteLine("\tTelefone        :" + cliente.Telefone);
            Console.WriteLine("\tIncluido em     :" + cliente.DataInclusao);

            //criando um objeto / variavel de instancia para ClienteRepositorio
            var clienteRepositorio = new ClienteRepositorio();

            //exportar os dados do cliente para arquivo
            clienteRepositorio.ExportarDados(cliente);

            //imprimindo mensagem..
            Console.WriteLine("\nDados gravados com sucesso");

        }
    }
}