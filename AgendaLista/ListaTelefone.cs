using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLista
{
    internal class ListaTelefone
    {
        public Telefone Head { get; set; }
        public Telefone Tail { get; set; }
        public int Quantidade { get; set; }
        public ListaTelefone()
        {
            Head = Tail = null;
            Quantidade = 0;
        }



        public void editar()
        {
            int opc;
            if (vazia())
            {
                Console.WriteLine("Agenda vazia");
                Console.ReadKey();
            }
            else
            {

                Telefone aux10 = Head;
                do
                {
                    Console.WriteLine(aux10.ToString());
                    aux10 = aux10.Proximo;
                } while (aux10 != null);


                do
                {
                    Console.WriteLine("Qual telefone deseja editar? (1º..2º..3º");
                    opc = int.Parse(Console.ReadLine()); //opc do quer remover
                } while (opc < 1 || opc > Quantidade);

                Telefone aux = Head;           

               


                for (int i = 0; i < Quantidade; i++)
                {
                    if (i + 1 == opc)
                    {
                        Console.Clear();
                        Console.WriteLine("Tipo:\t");
                        aux.Tipo = Console.ReadLine();
                        Console.WriteLine("DDD:\t");
                        aux.Ddd = Console.ReadLine();
                        Console.WriteLine("Numero:\t");
                        aux.Numero = Console.ReadLine();

                        break;

                    }
                    aux = aux.Proximo;

                }

            }
           
        }
    
    public void print()
    {
        if (vazia())
        {
            Console.WriteLine("Agenda vazia");
            return; 
        }


        Telefone aux10 = Head;
        do
        {
            Console.WriteLine(aux10.ToString());
            aux10 = aux10.Proximo;
        } while (aux10 != null);


    }

    public void pop()
    {
        int opc;
        if (vazia())
        {
            Console.WriteLine("Agenda vazia");
            Console.ReadKey();
        }
        else
        {

            Telefone aux10 = Head;
            do
            {
                Console.WriteLine(aux10.ToString());
                aux10 = aux10.Proximo;
            } while (aux10 != null);


            do
            {
                Console.WriteLine("Qual telefone deseja remover? (1º..2º..3º");
                opc = int.Parse(Console.ReadLine()); //opc do quer remover
            } while (opc < 1 || opc > Quantidade);

            Telefone aux = Head;
            Telefone aux1 = Head.Proximo;


            int cont = 1; // conta ate chegar ao que quer remover



            if (cont == opc)
            {
                Head = Head.Proximo;

            }
            else
            {
                cont++;
                for (int i = 1; i < Quantidade; i++)
                {
                    if (cont == opc)
                    {
                        aux.Proximo = aux1.Proximo;



                    }
                    else
                    {
                        aux1 = aux1.Proximo;
                        aux = aux.Proximo;

                    }
                    cont++;

                }

            }
            Quantidade--;
            if (Head == null)
            {
                Tail = null;
            }

        }
    }



    public void push(Telefone aux)
    {
        if (vazia())
        {
            Head = aux;
            Tail = aux;

        }
        else
        {

            Tail.Proximo = aux;
            Tail = aux;
        }
        Quantidade++;


    }

    public bool vazia()
    {
        if (Head == null & Tail == null)
        {
            return true;
        }
        else
        {
            return false;

        }

    }
}

}

