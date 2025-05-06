using MicroDigital.Entities;
using MicroDigital.Models;
using MicroDigital.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MicroDigital.Utils
{
    public class MicroondasHelper
    {
        private static string TextoVisor = "";

        public static int TratarPower(NumericUpDown power) //Irá limitar a potência para no máximo 10 e evitar que seja passado número negativo. valor padrão será 10.
        {
            if(power.Value > 0 && power.Value <= 10)
            {
                int Power = (int)power.Value;
                return Power;
            }
            else if(power.Value == 0)
            {
                return 10;
            }
            else
            {
                throw new PowerException("Potência precisa ser maior que 0 e menor do que 10");
            }
        }

        public static TimeSpan ObterTimeSpanCustom(TextBox BoxTime)
        {
            return TimeSpan.Parse(BoxTime.Text);
        }
        public static TimeSpan ObterTimeSpan(TextBox BoxTIme)
        {
            if (BoxTIme.Text == "")
            {
                return TimeSpan.FromSeconds(30);
            }
            string temp = BoxTIme.Text.PadLeft(6, '0');
            int horas = int.Parse(temp.Substring(0, 2));
            int minutos = int.Parse(temp.Substring(2, 2));
            int segundos = int.Parse(temp.Substring(4, 2));

            TimeSpan tempo = new TimeSpan(horas, minutos, segundos);

            if (tempo.TotalSeconds > 120 || tempo.TotalSeconds < 1)
            {
                throw new TimerException("Tempo digitado precisa ser maior que 1 segundo e menor do que 2 minutos.");
            }
            else
            {
                return tempo;
            }

        }

        public static async Task TratarAlertAsync(Label label, string msg) //Irá tratar a label de alert com timer e mostrar mensagem.
        {
            label.Text = "Houve um erro: " + msg;
            await Task.Delay(5000);
            label.Text = "";
        }

        public static void TratarStop(Label lblTempo, TextBox BoxTime)
        {
            lblTempo.Text = "00:00:00";
            BoxTime.Text = "";
        }

        public static void IniciarAquecimentoVisor(Label LblAquecimento, Microondas microondas, char CaracterHeat)
        {
            TextoVisor += new string(CaracterHeat, microondas.Power) + ' ';
            LblAquecimento.Text = TextoVisor;
        }
        public static void FinalizarAquecimentoVisor(Label LblAquecimento)
        {
            TextoVisor += "Aquecimento concluído";
            LblAquecimento.Text = TextoVisor;
        }
        public static void LimparAquecimentoVisor(Label LblAquecimento)
        {
            TextoVisor = "";
            LblAquecimento.Text = TextoVisor;
        }

        public static void LimpezaCampos(Label LblAquecimento, Label lblTempo, TextBox BoxTime)
        {
            LimparAquecimentoVisor(LblAquecimento);
            TratarStop(lblTempo, BoxTime);
        }
    }
}
