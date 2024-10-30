//Objetivo da Classe: Realizar os testes da classe Banco.cs

using Banco; //Torna possível usar as classes de outro arquivo. 
namespace BancoTestes
{
    [TestClass] //Os colchetes fazem o C# interpretar como uma classe de teste Atributo de teste.

    public class ContaBancariaTeste
    {
        [TestMethod] //Atributo do mecanismo de testes.
                     //Sem os atributos de teste, as classes não são consideradas 'classes de teste'.

        public void Debito_ComMontanteValido_AtualizandoSaldo() //Métodos de testes retornam void, não possuem parametros e [...]
                                                                //As classes de teste devem ser detalhadas, afinal, são criadas através das regras de negócio.
                                                                //Void não retorna nenhum valor, pois é vazio. 
        {
            double saldoInicial = 11.99; //Propriedade + Atribuição de valor.
            double montanteDebitado = 4.55; //Propriedade + Atribuição de valor.
            double esperado = 7.44; //Propriedade + Atribuição de valor.
            ContaBancaria conta = new("Miss Cristine", saldoInicial); //Atribuindo as propriedades acima a um novo 'usuário'.

            //Ação
            conta.Debitar(montanteDebitado);

            double atual = conta.Saldo; //
            Assert.AreEqual(esperado, atual, 0.001, "O débito não ocorreu corretamente :("); //
                //Assert é um acoleção que testa várias condições em teste unitário (? pesquisar sobre)
                //0.001 é a precisão requerida.
        }

        //Criando nova classe de teste.
        [TestMethod]
        public void Debito_QuantoMontanteMenorQueZero_InterceptadoPorExcecao()
        {
            double saldoInicial = 11.99; //Propriedade + Atribuição de valor.
            double montanteDebitado = -100.00; //Propriedade + Atribuição de valor.
            ContaBancaria conta = new("Miss Cristine",saldoInicial); //Atribuindo valor a uma nova conta.

            //Ação
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=>conta.Debitar(montanteDebitado));
                //ThrowsException se refere ao tipo de excessão que será puxado.

        }
    }
}