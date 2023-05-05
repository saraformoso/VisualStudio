using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco //aplicar estas funcionalidades de emcapsulamento...
{
    internal class Conta
    { 
        //Defenição de propriedades
        public int Numero_Conta { get;} //obtenho o numero de conta...mas não posso alterar
        public string Titular { get; set; } //posso obter e alterar
        public double Saldo { get; private set; } //private set->interessa alterar o saldo mas dentro da classe atraves de operações matematicas
        
        
        //Construtores

        
        //este construtor permite instanciar contas bancarias apenas com o numero de conta e o seu titular
        public Conta(int NumeroConta, string NomeTitular)
        {
            Numero_Conta = NumeroConta;
            Titular = NomeTitular;

        }
        //este construtor permite instanciar contas bancarias  com o numero de conta, seu titular e saldo
        public Conta(int NumeroConta, string NomeTitular, double Saldo):this(NumeroConta, NomeTitular) 
        {
            Numero_Conta = NumeroConta;
            Titular = NomeTitular;
            Saldo = Saldo;
        }


        //Secção de Metodos

        //metodo que permite depositar dinheiro na conta

        public void Deposito(double quantia) 
        {
        Saldo += quantia;
        }

        // metodo que permite levantar dinheiro da conta

        public void Levantamento(double quantia) 
        {
        Saldo -= quantia + 5.00;

        }

      //este metodo imprime na tela os dados pretendidos

        public override string ToString()
        {
            return "Conta Bancaria numero"
                + Numero_Conta
                + ", Titular da conta: "
                + Titular
                + ", Saldo:"
                + Saldo.ToString("F2")
                +"euros.";


        }



    }
}
