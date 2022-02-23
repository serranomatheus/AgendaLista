using System;

namespace AgendaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaTelefone listaTelefone = new ListaTelefone();
            ListaContato listaContato = new ListaContato();
            string op;

            do
            {
                Console.Clear();
                op = Menu();
                switch (op)
                {
                    case "1":
                        InserirContato();
                        break;
                    case "2":
                        BuscarPop();
                        break;
                    case "3":
                        Buscar();
                        break;
                    case "4":
                        listaContato.print();
                        break;
                    case "5":
                        EditarContato();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("*******  Nenhuma opcao selecionado  ********");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                        Console.WriteLine("--------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
            } while (op != "0");



            string Menu()
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine("[1]Adicionar Contato");
                Console.WriteLine("[2]Remover Contato");
                Console.WriteLine("[3]Buscar Contato");
                Console.WriteLine("[4]Imprimir Contato");
                Console.WriteLine("[5]Editar Contato");
                Console.WriteLine("[0]Sair");
                return Console.ReadLine();
            }


           /* void BuscarEditar()
            {
                Console.Clear();
                if (listaContato.Quantidade == 0)
                {
                    Console.WriteLine("Agenda vazia");
                    return;
                }
                Console.WriteLine("Qual contato deseja editar");
                string busca = Console.ReadLine();
                listaContato.buscarEditar(busca);
            }*/

            void BuscarPop()
            {
                Console.Clear();
                if (listaContato.Quantidade == 0)
                {
                    Console.WriteLine("Agenda vazia");
                    return;
                }
                Console.WriteLine("Qual nome deseja remover");
                string busca = Console.ReadLine();
                listaContato.buscarPop(busca);
            }

            void Buscar()
            {
                Console.Clear();
                if (listaContato.Quantidade == 0)
                {
                    Console.WriteLine("Agenda vazia");
                    return;
                }
                Console.WriteLine("Qual nome deseja buscar");
                string busca = Console.ReadLine();
                listaContato.buscar(busca);
            }
            void InserirContato()
            {
                Console.Clear();
                Console.WriteLine("Nome:\t");
                string nome = Console.ReadLine();
                Console.WriteLine("E-mail:\t");
                string email = Console.ReadLine();

                ListaTelefone listaTelefone = InserirTelefone();
                listaContato.push(new Contato(nome, email, listaTelefone));
            }
            ListaTelefone InserirTelefone()
            {
                ListaTelefone listaTelefone = new ListaTelefone();
                string opcao;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Deseja inserir um novo telefone?");
                    Console.WriteLine("[1]SIM | [2]NAO");
                    opcao = Console.ReadLine();
                    if (opcao == "1")
                    {
                        Telefone telefone = NovoTelefone();
                        listaTelefone.push(telefone);
                    }
                } while (opcao != "2");
                return listaTelefone;
            }
            Telefone NovoTelefone()
            {
                Console.Clear();
                Console.WriteLine("Tipo:\t");
                string tipo = Console.ReadLine();
                Console.WriteLine("DDD:\t");
                string ddd = Console.ReadLine();
                Console.WriteLine("Numero:\t");
                string numero = Console.ReadLine();
                return new Telefone(tipo, ddd, numero);
            }
            void EditarContato()
            {
                Console.Clear();
                if (listaContato.Quantidade == 0)
                {
                    Console.WriteLine("Agenda vazia");
                    return;
                }
                Console.WriteLine("Qual nome deseja editar");
                string busca = Console.ReadLine();
                listaContato.buscarEditar(busca);

            }

        }
    }
}
