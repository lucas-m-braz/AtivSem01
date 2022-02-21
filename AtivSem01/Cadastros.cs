using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public abstract class Cadastros : IOperacoesBD
    {
        // iniciando uma propriedade protegida conexao
        protected string Conexao;

        // Altera a conexao informada
        public void Alterar()
        {
            Console.WriteLine("deseja alterar a conexâo para: ");
            Conexao = Console.ReadLine();
        }

        // Deleta a conexão colocando uma string vazia no lugar
        public virtual void Deletar()
        {
            Console.WriteLine("Deseja deletar a conexâo (digite 's' para sim e 'n' para nao)");
            string decisao = Console.ReadLine();
            if (decisao == "s") { Conexao = ""; }
        }

        // Insere uma nova conexão se a propriedade estiver vazia, caso contrario escreve para o usuario que ja existe uma conexao
        public virtual void Inserir()
        {
            if (Conexao == "")
            {
                Console.WriteLine("Insira a conexâo desejada: ");
                Conexao = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Conexão já inserida");
            }
        }

        // Como conexao é uma variavel protegida, não seria possivel o acesso a ela, a função pesquisa mostra ao usuario qual a conexao atual
        public void Pesquisar()
        {
            Console.WriteLine($"A conexão é: {Conexao}");
        }


    }
}
