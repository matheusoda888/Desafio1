using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Util
    {
        
        
        public static void popular(List<Pessoa> pessoas, string nomeArquivo)
        {
            try
            {

                string linha;
                string[] dadosLinha = null;
                string[] dadosPessoa =null;
                Pessoa pessoa;
                int cont = 0;
                
                StreamReader reader = new StreamReader(nomeArquivo);
                do
                {
                    linha = reader.ReadLine();
                    if (linha.StartsWith("Z"))
                    {
                        dadosLinha = linha.Split("-");

                        dadosPessoa = dadosLinha;

                        cont++;
                        if (cont == 2||(cont==1&&reader.EndOfStream))
                        {

                            pessoa = new Funcionario(dadosPessoa[1], dadosPessoa[2], dadosPessoa[3], dadosPessoa[4], dadosPessoa[5]);
                            pessoas.Add(pessoa);
                            //cont = 0;
                            
                        }
                    }

                    else if (linha.StartsWith("Y"))
                    {
                        dadosLinha = linha.Split("-");
                        pessoa = new Aluno(dadosPessoa[1], dadosPessoa[2], dadosPessoa[3], dadosPessoa[4], dadosPessoa[5], dadosLinha[1], dadosLinha[2], dadosLinha[3]);
                        pessoas.Add(pessoa);
                        cont = 0;
                        
                        

                    }
                } while (!reader.EndOfStream);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
