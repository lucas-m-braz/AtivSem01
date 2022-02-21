using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    sealed class Pedidos: Cadastros
    {
        public int quantidade;
        //construtor de CLientes está preenchendo conexao partir de seu construtor
        public Pedidos(string Conexao)
        {
            this.Conexao = Conexao;
        }
        // Deletar está reescrevendo o método Deletar de Cadastros
        public override void Deletar()
        {
            //Chamando Deletar de Cadastros para executar o código escrito na classe base
            base.Deletar();
            // Parte nova de Deletar
            Console.WriteLine("Deseja deletar a quantidade (digite 's' para sim e 'n' para nao)");
            string decisao = Console.ReadLine();
            if (decisao == "s") { quantidade = 0; }
        }
        // Iserir está reescrevendo o método Inserir de Cadastros
        public override void Inserir()
        {
            // Como não foi chamado a inserir da classe base ela irá reescrever e desconsiderar o metodo da classe base
            Console.WriteLine("O que deseja inserir:\n1-Conexâo\n2-quantidade");
            string decisao = Console.ReadLine();
            //Tomando a decisão do que será inserido a partir de ifs
            if (decisao == "1")
            {
                //Verificando se já existe alguma conexão inserida
                if (Conexao == "")
                {
                    // Se não houver nenhuma conexão irá iserir a conexão
                    Console.WriteLine("Insira a conexâo desejada: ");
                    Conexao = Console.ReadLine();
                }
                else
                {
                    // Se já houver alguma conexao vai imprimir uma mensagem 
                    Console.WriteLine("Conexão já inserida");
                }
            }
            else if(decisao == "2")
            {
                Console.WriteLine("Insira a quantidade desejada: ");
                quantidade = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
