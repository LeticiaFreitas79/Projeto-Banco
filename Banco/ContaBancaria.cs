//Objetivo da Classe: Introdução.

namespace Banco
{
    internal class ContaBancaria
    {
        private readonly string m_nomeCliente; //

        private double m_saldo; //

        private ContaBancaria() //Método Construtor.

        { }
        private ContaBancaria(string nomeCliente, double saldo) //Método Construtor.
        {
            m_nomeCliente = nomeCliente; //Atribui o valor ao parametro.
            m_saldo = saldo; //Atribui o valor ao parametro.
        }

        public string NomeCliente { get { return m_nomeCliente; } } //Forma de chamar a propriedade fora da classe.

        public double Saldo { get { return m_saldo; } } //Chama a propriedade fora da Classe.

        public void Debitar (double montante) //Método vazio (pois não precisa retornar valor) para debitar.
        {
            if(montante > m_saldo) //Se montante for maior que saldo, execute os comandos abaixo.
            {
                throw new ArgumentOutOfRangeException("montante"); //'Montante' causa uma excessão e a futura classe de teste irá capturar esse valor.
            }
            if (montante < 0) //Se montante for menor que 0, execute os comandos abaixo.
            {
                throw new ArgumentOutOfRangeException("montante");
                //Throw é um desvio.
            }
            //função da classe.
            m_saldo += montante; //Errado intencionalmente.
        }

        public void Creditar (double montante) //Método vazio para creditar.
        {
            if(montante<0) //Se o montante for menor que zero, execute os comandos abaixo.
            {
                throw new ArgumentOutOfRangeException("montante");
            }
            m_saldo += montante;
        }

        //
        static void Main(string[] args)
        {
            ContaBancaria conta = new("James MaCgregor", 11.99);
            conta.Creditar(5.77);
            conta.Debitar(11.22);
            Console.WriteLine($"Osaldo atual é R$ {conta.Saldo}"); 
        }
    }
}