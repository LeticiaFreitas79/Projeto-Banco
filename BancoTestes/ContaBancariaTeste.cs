//Objetivo da Classe: Realizar os testes da classe Banco.cs

using Banco; //Torna poss�vel usar as classes de outro arquivo. 
namespace BancoTestes
{
    [TestClass] //Os colchetes fazem o C# interpretar como uma classe de teste Atributo de teste.

    public class ContaBancariaTeste
    {
        [TestMethod] //Atributo do mecanismo de testes.
                     //Sem os atributos de teste, as classes n�o s�o consideradas 'classes de teste'.

        public void Debito_ComMontanteValido_AtualizandoSaldo() //M�todos de testes retornam void, n�o possuem parametros e [...]
                                                                //As classes de teste devem ser detalhadas, afinal, s�o criadas atrav�s das regras de neg�cio.
                                                                //Void n�o retorna nenhum valor, pois � vazio. 
        {
            double saldoInicial = 11.99; //Propriedade + Atribui��o de valor.
            double montanteDebitado = 4.55; //Propriedade + Atribui��o de valor.
            double esperado = 7.44; //Propriedade + Atribui��o de valor.
            ContaBancaria conta = new("Miss Cristine", saldoInicial); //Atribuindo as propriedades acima a um novo 'usu�rio'.

            //A��o
            conta.Debitar(montanteDebitado);

            double atual = conta.Saldo; //
            Assert.AreEqual(esperado, atual, 0.001, "O d�bito n�o ocorreu corretamente :("); //
                //Assert � um acole��o que testa v�rias condi��es em teste unit�rio (? pesquisar sobre)
                //0.001 � a precis�o requerida.
        }

        //Criando nova classe de teste.
        [TestMethod]
        public void Debito_QuantoMontanteMenorQueZero_InterceptadoPorExcecao()
        {
            double saldoInicial = 11.99; //Propriedade + Atribui��o de valor.
            double montanteDebitado = -100.00; //Propriedade + Atribui��o de valor.
            ContaBancaria conta = new("Miss Cristine",saldoInicial); //Atribuindo valor a uma nova conta.

            //A��o
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>conta.Debitar(montanteDebitado));
                //ThrowsException se refere ao tipo de excess�o que ser� puxado.

        }
    }
}