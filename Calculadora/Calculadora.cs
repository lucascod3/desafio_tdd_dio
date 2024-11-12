using System;
using System.Collections.Generic;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private List<string> historicoOperacoes;
        private readonly string dataOperacao;

        public Calculadora(string data)
        {
            historicoOperacoes = new List<string>();
            this.dataOperacao = data;
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            AdicionarAoHistorico(resultado);
            return resultado;
        }
        
        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            AdicionarAoHistorico(resultado);
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            AdicionarAoHistorico(resultado);
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisão por zero não permitida.");

            int resultado = a / b;
            AdicionarAoHistorico(resultado);
            return resultado;
        }

        public List<string> ObterHistorico()
        {
            if (historicoOperacoes.Count > 3)
                historicoOperacoes.RemoveRange(3, historicoOperacoes.Count - 3);

            return historicoOperacoes;
        } 

        private void AdicionarAoHistorico(int resultado)
        {
            historicoOperacoes.Insert(0, $"Resultado: {resultado} Data: {dataOperacao}");
        }
    }
}

