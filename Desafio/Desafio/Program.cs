namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contFuncionarios = 0;
            int contAlunos = 0;
            List<Pessoa> pessoas = new List<Pessoa>();
            Util.popular(pessoas, "Texto.txt");
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.GetType() == typeof(Aluno))
                {
                    contAlunos++;
                    
                }
                else
                {
                    contFuncionarios++;
                    
                }

            }
            Console.WriteLine("Alunos: " + contAlunos);
            Console.WriteLine("Funcionarios: " + contFuncionarios);
            foreach(Pessoa pessoa in pessoas)
            {
                if (pessoa.GetType() == typeof(Aluno))
                {
                    Console.WriteLine(pessoa.curso);
                }
            }
        }
    }
}