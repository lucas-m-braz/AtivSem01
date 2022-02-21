using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcoes func = new Funcoes();
            Clientes client = new Clientes("123.456", "Lucas", "654321");
            Pedidos pedido = new Pedidos("321.123");

            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int soma = func.Soma(matriz);
            float maior = func.maior(123, 5, 65, 321);

            Console.WriteLine($"A soma é: {soma}\nO maior número é: {maior}");

            client.Pesquisar();
            client.Alterar();
            client.Pesquisar();
            pedido.Pesquisar();
            pedido.Deletar();
            pedido.Pesquisar();
            pedido.Inserir();
            pedido.Pesquisar();
            Console.WriteLine($"quantidade: {pedido.quantidade}");
            Console.ReadKey();


        }
    }
}
