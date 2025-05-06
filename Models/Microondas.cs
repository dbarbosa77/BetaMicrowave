using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MicroDigital.Entities
{
    public class Microondas
    {
        public TimeSpan Time { get; set; }
        public int Power { get; set; }

        public Microondas() 
        {
        }
        public Microondas(TimeSpan time, int power) 
        {
            Time = time;
            Power = power;
        }

        public void AumentarIniciar()
        {
            Time = Time.Add(TimeSpan.FromSeconds(30));
            if (Time.TotalSeconds > 120)
            {
                Time = new TimeSpan(0,02,00);
            }
        }

        public void Diminuir()
        {
            Time = Time.Subtract(TimeSpan.FromSeconds(1));
        }

        public void Cancelar()
        {
            Time = TimeSpan.Zero;
        }

        public override string ToString()
        {
            return Time.ToString(@"hh\:mm\:ss");
        }
    }
}
