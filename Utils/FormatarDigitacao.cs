using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroDigital.Utils
{
    public class FormatarDigitacao
    {
        private string valor = "";
        public string AdicionarDigito(int digito)
        {
            valor += digito.ToString();

            return ObterTempoFormatado();
        }
        public string ObterTempoFormatado()
        {
            string temp = valor.PadLeft(6, '0');
            int horas = int.Parse(temp.Substring(0, 2));
            int minutos = int.Parse(temp.Substring(2, 2));
            int segundos = int.Parse(temp.Substring(4, 2));
            return $"{horas:00}:{minutos:00}:{segundos:00}";
        }
        public void Limpar()
        {
            valor = "";
        }
    }
}
