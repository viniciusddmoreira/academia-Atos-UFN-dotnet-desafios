namespace Desafio01Arquivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();

            Util.PopularArquivoNasListas(pessoas, alunos, "Desafio01.txt");

            Console.WriteLine("Foram criados {0} objetos Pessoa e {1} objetos Aluno.\n", pessoas.Count, alunos.Count );

            Console.WriteLine("Os cursos referentes aos {0} alunos estão listados abaixo:\n", alunos.Count);
            Util.MostrarListaAluno(alunos);
        }
    }
}