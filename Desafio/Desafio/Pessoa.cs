using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Pessoa
    {
        string nome;
        string rg;
        string cpf;
        string cidade;
        string telefone;
        public string id;
        public string curso;
        public string codCurso;

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getCurso()
        {
            return curso;
        }
        public void setCurso(string curso)
        {
            this.curso = curso;
        }
        public string getCodCurso()
        {
            return codCurso;
        }
        public void setCodCurso(string codCurso)
        {
            this.codCurso = codCurso;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getRg()
        {
            return rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getCidade()
        {
            return cidade;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        
    }
}
