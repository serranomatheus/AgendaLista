using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLista
{
    internal class ListaContato
    {
        public Contato Head { get; set; }
        public Contato Tail { get; set; }
        public int Quantidade { get; set; }

        public ListaContato()
        {
            Head = Tail = null;
        }

        public void buscar(string busca)
        {


            Contato aux = Head;
            int rept = 0;
            bool cont = false;
            int opc;


            do
            {
                if (aux.Nome.ToLower().Contains(busca))
                {
                    Console.WriteLine(aux.ToString());
                    aux.Telefones.print();
                    cont = true;
                    rept++;
                }
                aux = aux.Proximo;
            } while (aux != null);

            if (!cont)
            {
                Console.WriteLine("Nenhum Contato encontrado");
            }



        }
        public void buscarEditar(string busca)
        {

            Contato contato = Head;
            Contato aux = Head;
            int rept = 0;
            bool cont = false;
            int opc;



            do
            {
                if (string.Compare(aux.Nome.ToLower(), busca) == 0)
                {
                    Console.WriteLine(aux.ToString());
                    cont = true;
                    contato = aux;
                    rept++;
                }
                aux = aux.Proximo;
            } while (aux != null);

            if (!cont)
            {
                Console.WriteLine("Nenhum Contato encontrado");
                return;
            }

            if (rept >= 2)
            {
                aux = Head;
                int contador=1;
                do
                {
                    Console.WriteLine($"Qual voce deseja editar ?(1 a {rept})");
                    opc = int.Parse(Console.ReadLine());
                } while (opc < 1 || opc > rept);
                for (int i = 1; i < Quantidade; i++)
                {
                    if (String.Compare(busca, aux.Nome) == 0)
                    {
                        if (opc == contador)
                        {
                            contato = aux;
                            break;
                        }
                        else
                        {
                            contador++;
                        }
                    }

                    aux = aux.Proximo;
                }
                aux = EditarContatos(contato);
               Editar(contato, aux, opc);
               // pop(contato.Nome,opc);
               // push(contato);
            }
            else
            {
                aux = EditarContatos(contato);
              Editar(contato, aux);
                //pop(contato);
               // push(contato);

            }

        }
        public void buscarPop(string busca)
        {
            Contato aux = Head;
            Contato contato = Head;

            int rept = 0;
            bool cont = false;
            int opc;

            do
            {
                if (string.Compare(aux.Nome, busca) == 0)
                {
                    Console.WriteLine(aux.ToString());
                    cont = true;
                    contato = aux;
                    rept++;
                }
                aux = aux.Proximo;
            } while (aux != null);

            if (!cont)
            {
                Console.WriteLine("Nenhum Contato encontrado");
                return;
            }

            if (rept >= 2)
            {
                do
                {
                    Console.WriteLine($"Qual voce deseja remover ?(1 a {rept})");
                    opc = int.Parse(Console.ReadLine());
                } while (opc < 1 || opc > rept);
                pop(busca, opc);
            }
            else
            {
                pop(contato); //funcao pop
            }

        }

        public void Editar(Contato contato, Contato contatoEditado)
        {
            Contato aux = Head;
            for (int i = 0; i < Quantidade; i++)
            {
                if (string.Compare(contato.Nome, aux.Nome) == 0)
                {
                    aux = contato;
                    break;
                }
                aux = aux.Proximo;
            }
        }
        public void Editar(Contato contato, Contato contatoEditado, int opcao)
        {
            int contador = 1;
            Contato aux = Head;
            for (int i = 0; i < Quantidade; i++)
            {
                if (string.Compare(contato.Nome, aux.Nome) == 0)
                {
                    if (opcao == contador)
                    {
                        aux = contato;
                        break;
                    }
                    else
                    {
                        contador++;
                    }

                }

                aux = aux.Proximo;
            }
        }


        public void pop(Contato contato)
        {


            if (contato.Nome == Head.Nome)
            {
                Head = Head.Proximo;
            }
            else
            {
                Contato aux = Head;
                Contato aux1 = Head.Proximo;

                for (int i = 1; i < Quantidade; i++)
                {
                    if (string.Compare(contato.Nome, aux1.Nome) == 0)
                    {
                        aux.Proximo = aux1.Proximo;
                        if (aux1.Proximo == null)
                        {
                            Tail = aux;
                        }
                    }
                    else
                    {
                        aux = aux1;
                        aux1 = aux1.Proximo;

                    }

                }
            }
            if (Head == null)
            {
                Tail = null;
            }
            Quantidade--;
        }
    
       

        public void pop(string nome, int remover)
        {
            int cont = 1;
            if (string.Compare(nome, Head.Nome) == 0 && remover == cont)
            {
                Head = Head.Proximo;
            }
            else
            {
                if (Head.Nome == nome)
                {
                    cont++;
                }

                Contato aux = Head;
                Contato aux1 = Head.Proximo;

                for (int i = 1; i < Quantidade; i++)
                {
                    if (string.Compare(nome, aux1.Nome) == 0)
                    {
                        if (cont == remover)
                        {
                            aux.Proximo = aux1.Proximo;
                            if (aux1.Proximo == null)
                            {
                                Tail = aux;
                            }
                            break;
                        }
                        else
                        {
                            cont++;
                        }
                    }
                    aux = aux1;
                    aux1 = aux1.Proximo;

                }
            }
            if (Head == null)
            {
                Tail = null;
            }
            Quantidade--;
        }

        
        public Contato EditarContatos(Contato contato)
        {
            string opcao;
            Contato aux = contato;

            do
            {
                Console.Clear();
                Console.WriteLine(contato.ToString());
                Console.WriteLine("O que deseja editar?");
                Console.WriteLine("[1] Nome");
                Console.WriteLine("[2] E-mail");
                Console.WriteLine("[3] Excluir Telefones");
                Console.WriteLine("[4] Editar Telefones");
                Console.WriteLine("[5] Adicionar telefone");
                Console.WriteLine("[6] Voltar");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Nome:\t");
                        aux.Nome = Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("E-mail:\t");
                        aux.Email = Console.ReadLine();
                        break;

                    case "3": aux.Telefones.pop();

                        break;

                    case "4": aux.Telefones.editar();
                        break;
                    case "5":                      
                        Console.Clear();
                        Console.WriteLine("Tipo:\t");
                        string tipo = Console.ReadLine();
                        Console.WriteLine("DDD:\t");
                        string ddd = Console.ReadLine();
                        Console.WriteLine("Numero:\t");
                        string numero = Console.ReadLine();
                        contato.Telefones.push(new Telefone(tipo, ddd, numero));
                        contato.Telefones.Quantidade++;
                        
                        break;
                    case "6":

                    default:
                        break;
                }


            } while (opcao != "6");

            return aux;
        }
        public void print()
        {
            if (vazia())
            {
                Console.WriteLine("Agenda vazia");
                return; //nao testa o else quebra o print
            }


            Contato aux = Head;
            do
            {

                Console.WriteLine(aux.ToString());
                aux.Telefones.print();
                Console.ReadKey();
                aux = aux.Proximo;
            } while (aux != null);

        }

        public void push(Contato aux)
        {
            if (vazia())
            {
                Head = aux;
                Tail = aux;

            }
            else
            {
                if (String.Compare(aux.Nome, Head.Nome) == -1) 
                {
                    aux.Proximo = Head;
                    Head = aux;

                }
                else
                {
                    if (String.Compare(aux.Nome, Tail.Nome) >= 0) 
                    {
                        Tail.Proximo = aux;
                        Tail = aux;

                    }
                    else
                    {
                        Contato aux1 = Head;
                        Contato aux2 = Head;
                        for (int i = 0; i < Quantidade; i++)
                        {
                            if (String.Compare(aux.Nome, aux1.Nome) == -1) 
                            {
                                aux2.Proximo = aux;
                                aux.Proximo = aux1;
                                break;
                            }
                            else
                                aux2 = aux1;
                            aux1 = aux2.Proximo;
                        }
                    }
                }


            }
            Quantidade++;
        }

        public bool vazia()
        {
            if (Head == null & Tail == null)
                return true;
            else
                return false;

        }








    }

}




