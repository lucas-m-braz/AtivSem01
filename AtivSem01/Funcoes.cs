using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public class Funcoes
    {
        // função que soma os numeros da matriz
        public int Soma(int[] matriz)
        {
            // inicializa a variavel soma que será necessaria
            int soma = 0;
            // protege a função de tratamento de erro
            try
            {
                // percorre o array matriz para saber cada número
                foreach (int num in matriz)
                {
                    // coma cada número e armazena a soma na variavel criada anteriormente
                    soma += num;
                }
            }
            catch (Exception e)
            {
                //exibe o erro e retorna 0 se houver algum erro
                Console.WriteLine(e);
                return 0;
            }
            // retorna a soma dos números na matriz
            return soma;
        }

        // função que retorna o maior número inserido
        public float maior(float n1, float n2, float n3, float n4)

        { 
            // inicializa uma variavel de apoio
            float maior;
            // protege a função de tratamento de erro
            try
            {      
                // verifica se o primeiro número é o maior
                if(n1 > n2 && n1 > n3 && n1 > n4)
                {
                    maior = n1;
                }
                // verifica se o segundo número é o maior
                else if(n2 > n3 && n2 > n4)
                {
                    maior = n2;
                }
                //verifica se o terceiro número é o maior
                else if (n3 > n4)
                {
                    maior = n3;
                }
                // se os outros números não são os maiores o maior é o quarto
                else
                {
                    maior = n4;
                }
            }
            catch(Exception e)
            {
                //exibe o erro e retorna 0 se houver algum erro
                Console.WriteLine(e);
                return 0;
            }
            return maior;
        }

    }
}
