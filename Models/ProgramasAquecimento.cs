using MicroDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroDigital.Models
{
    public class ProgramasAquecimento
    {
        public string Name { get; set; }
        public string Food { get; set; }

        public Microondas Microondas { get; set; }
        public char CaracterHeat { get; set; }
        public string Instructions { get; set; }
        public bool isCustom { get; set; }

        public ProgramasAquecimento() 
        {
        }

        public ProgramasAquecimento(string name, string food, Microondas microondas, char caracterHeat, string instructions, bool custom)
        {
            Name = name;
            Food = food;
            Microondas = microondas;
            CaracterHeat = caracterHeat;
            Instructions = instructions;
            isCustom = custom;
        }

        public static List<ProgramasAquecimento> ObterProgramasPreDefinidos()
        {
            return new List<ProgramasAquecimento>
            {
                new ProgramasAquecimento("Pipoca", "Pipoca (de micro-ondas)", new Microondas(TimeSpan.FromMinutes(3), 7), '*', "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.", false),
                new ProgramasAquecimento("Leite", "Leite", new Microondas(TimeSpan.FromMinutes(5), 5), '#', "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.",false),
                new ProgramasAquecimento("Carnes de boi", "Carne em pedaço ou fatias", new Microondas(TimeSpan.FromMinutes(14), 4), '~', "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",false),
                new ProgramasAquecimento("Frango", "Frango (qualquer corte)", new Microondas(TimeSpan.FromMinutes(8), 7), '+', "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",false),
                new ProgramasAquecimento("Feijão", "Feijão congelado", new Microondas(TimeSpan.FromMinutes(8), 9), '@', "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.",false)
            };
        }
    }
}
