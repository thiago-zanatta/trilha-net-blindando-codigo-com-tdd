using NewTalents;

namespace TestsNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirCalculadora(string data)
        {
            return new Calculadora(data);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0) 
            );
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirCalculadora("17/05/2024");

            calc.somar(1, 2);
            calc.subtrair(1, 2);
            calc.dividir(2, 2);
            calc.multiplicar(1, 1);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}