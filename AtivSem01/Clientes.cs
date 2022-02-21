using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    //Classe sealed não pode ser herdada
    sealed class Clientes : Cadastros
    {
        public string nome;
        public string cpf;

        //construtor de CLientes está preenchendo conexao, nome e cpf a partir de seu construtor
        public Clientes(string Conexao, string nome, string cpf)
        {
            this.Conexao = Conexao;
            this.nome = nome;
            this.cpf = cpf;
        }

        // Deletar está reescrevendo o método Deletar de Cadastros
        public override void Deletar()
        {
            //Chamando Deletar de Cadastros para executar o código escrito na classe base
            base.Deletar();
            // Parte nova de Deletar
            Console.WriteLine("Deseja deletar o nome do cliente (digite 's' para sim e 'n' para nao)");
            string decisao = Console.ReadLine();
            if (decisao == "s") { nome = ""; }
            Console.WriteLine("Deseja deletar o cpf do cliente (digite 's' para sim e 'n' para nao)");
            decisao = Console.ReadLine();
            if (decisao == "s") { cpf = ""; }


        }
    }
}
