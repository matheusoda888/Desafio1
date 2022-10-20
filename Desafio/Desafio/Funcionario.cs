using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Funcionario : Pessoa
    {
        public Funcionario(string nome, string telefone, string cidade, string rg, string cpf)
        {
            
            setNome(nome);
            setCpf(cpf);
            setCidade(cidade);
            setRg(rg);
            setTelefone(telefone);
        }
        public void mostrarDados()
        {
            Console.WriteLine("Nome: " + getNome());
            Console.WriteLine("CPF: " + getCpf());
            Console.WriteLine("Telefone: " + getTelefone());
            Console.WriteLine("Cidade: " + getCidade());
            Console.WriteLine("RG: " + getRg());
        }
    }
}
