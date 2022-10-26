using Desafio01Arquivos.Models;
using System.Text;

namespace Desafio01Arquivos.Helpers
{
    internal class Util
    {
        public static void PopularArquivoNasListas(List<Pessoa> listaPessoa, List<Aluno> listaAluno, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                try
                {
                    string? linha;
                    string linhaAnterior;
                    string[] dadosLinhaAnterior;
                    string[] dadosLinha;
                    Pessoa pessoa;
                    Aluno aluno;
                    StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);

                    do
                    {
                        linha = leitor.ReadLine();

                        if (linha.First() == 'Z')
                        {
                            if (leitor.Peek() == 'Y')
                            {
                                linhaAnterior = linha;
                                linha = leitor.ReadLine();
                                dadosLinha = linha.Split("-");
                                dadosLinhaAnterior = linhaAnterior.Split("-");                            
                                aluno = new Aluno(dadosLinhaAnterior[1], dadosLinhaAnterior[2], dadosLinhaAnterior[3], dadosLinhaAnterior[4], dadosLinhaAnterior[5], int.Parse(dadosLinha[1]), int.Parse(dadosLinha[2]), dadosLinha[3]);
                                listaAluno.Add(aluno);
                            }
                            else
                            {
                                dadosLinha = linha.Split("-");                              
                                pessoa = new Pessoa(dadosLinha[1], dadosLinha[2], dadosLinha[3], dadosLinha[4], dadosLinha[5]);
                                listaPessoa.Add(pessoa);
                            }
                        }
                        else if (linha.First() == 'X')
                        {
                            Console.Write("Cabeçalho do arquivo: ");
                            Console.WriteLine(linha + Environment.NewLine);
                        }
                    } while (!leitor.EndOfStream);

                    leitor.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exceção: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("O arquivo {0} não foi encontrado!", nomeArquivo);
            }
        }

        public static void MostrarListaAluno(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine("Nome: {0} \nCurso: {1}\n", aluno.Nome, aluno.NomeCurso);
            }
        }
    }
}
