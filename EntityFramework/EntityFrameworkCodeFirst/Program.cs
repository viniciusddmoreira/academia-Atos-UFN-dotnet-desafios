using EntityFrameworkCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq.Expressions;

namespace EntityFrameworkCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Inserir Pessoa");
            Console.WriteLine("2 - Alterar Pessoa");
            Console.WriteLine("3 - Inserir Email");
            Console.WriteLine("4 - Excluir Pessoa");
            Console.WriteLine("5 - Consultar Tudo");
            Console.WriteLine("6 - Consultar pelo ID");


            int opcao = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Informe o nome da pessoa:");
                        Pessoa pessoa = new Pessoa();
                        pessoa.nome = Console.ReadLine();

                        Console.WriteLine("Informe um email:");
                        string emailTemp = Console.ReadLine();
                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(pessoa);
                        contexto.SaveChanges();
                        Console.WriteLine("pessoa inserida com sucesso.");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o nome correto:");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int idEmail = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.Pessoas.Find(idEmail);

                        Console.WriteLine("Informe o novo email:");
                        string emailTemp = Console.ReadLine();
                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(pessoa);
                        contexto.SaveChanges();
                        Console.WriteLine("\nPessoa inserida com sucesso.");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o Id da pessoa");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + pessoa.nome);
                        Console.WriteLine("E dos seus emails:");

                        foreach (Email item in pessoa.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                        Console.WriteLine("1 para SIM e outra tecla para NÃO");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(pessoa);
                            contexto.SaveChanges();
                            Console.WriteLine(pessoa.nome + "excluída com sucesso!");
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        List<Pessoa> lista = (from Pessoa pessoa in contexto.Pessoas select pessoa)
                            .Include(pes => pes.Emails).ToList<Pessoa>();

                        foreach (Pessoa item in lista)
                        {
                            Console.WriteLine(item.nome);

                            foreach (Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int idFiltro = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails).FirstOrDefault(pessoa => pessoa.id == idFiltro);

                        Console.WriteLine("Nome: " + p.nome);

                        if(p.Emails != null)
                        {
                            foreach (Email item in p.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;

                default:
                    break;
            }
        }
    }
}