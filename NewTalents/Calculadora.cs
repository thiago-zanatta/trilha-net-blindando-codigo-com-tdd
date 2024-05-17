using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _lista;
        private string _data;

        public Calculadora(string data)
        {
            _lista = new List<string>();
            _data = data;
        }

        public int somar(int num1, int num2)
        {
            var resultado = num1 + num2;
            _lista.Insert(0, $"{num1} + {num2} = {resultado}");
            return resultado;
        }
        public int subtrair(int num1, int num2)
        {
            var resultado = num1 - num2;
            _lista.Insert(0, $"{num1} - {num2} = {resultado}");
            return resultado;
        }

        public int multiplicar(int num1, int num2)
        {
            var resultado = num1 * num2;
            _lista.Insert(0, $"{num1} * {num2} = {resultado}");
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            var resultado = num1 / num2;
            _lista.Insert(0, $"{num1} / {num2} = {resultado}");
            return resultado;
        }

        public List<string> historico()
        {
            _lista.RemoveRange(3, _lista.Count-3);
            return _lista;
        }
    }
}
