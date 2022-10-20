using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
     class Aluno : Pessoa
    {
        

        public Aluno(string nome, string telefone,  string cidade, string rg,string cpf, string id, string codCurso, string curso)
        {
            setId(id);
            setCurso(curso);
            setCodCurso(codCurso);
            setNome(nome);
            setCpf(cpf);
            setCidade(cidade);
            setRg(rg);
            setTelefone(telefone);
        }
        public void mostraDados()
        {
            Console.WriteLine("Nome: " + getNome());
            Console.WriteLine("CPF: " + getCpf());
            Console.WriteLine("Telefone: " + getTelefone());
            Console.WriteLine("Cidade: " + getCidade());
            Console.WriteLine("RG: " + getRg());
            Console.WriteLine("Matricula:" +id);
            Console.WriteLine("Curso: " + curso);

        }
        
        
}
}
