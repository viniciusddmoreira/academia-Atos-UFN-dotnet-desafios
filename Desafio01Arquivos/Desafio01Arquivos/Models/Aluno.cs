namespace Desafio01Arquivos.Models
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public int CodigoCurso { get; set; }
        public string NomeCurso { get; set; }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, int matricula, int codigoCurso, string nomeCurso) : base(nome, telefone, cidade, rg, cpf)
        {

            Matricula = matricula;
            CodigoCurso = codigoCurso;
            NomeCurso = nomeCurso;
        }
        public Aluno()
        {
        }
    }
}
