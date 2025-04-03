using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_correnteConsoleApp
{
    class ContaCorrente
    {                     
        //ID da Conta, saldo e limite
        int numero = numero;
        decimal saldo = saldo;
        decimal limite = limite;        
        

        //Array para histórico de movimentações
        private string[] movimentacoes = new string[100];
        private int contadorMovimentacoes = 0;

        public void Sacar(decimal valor)
        {
            
            if (saldo + limite >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} efetuado com sucesso");
                movimentacoes[contadorMovimentacoes] = ($"Saque de R$ {valor} efetuado com sucesso");
                contadorMovimentacoes += 1;

            }
            else
            {
                Console.WriteLine("Você não tem limite disponível para realizar estar operação");
            }

        }
        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Deposito de R${valor} foi efetuado com sucesso");
            movimentacoes[contadorMovimentacoes] = ($"Deposito de R$ {valor} efetuado com sucesso");
            contadorMovimentacoes += 1;
        }
        

    }
}
