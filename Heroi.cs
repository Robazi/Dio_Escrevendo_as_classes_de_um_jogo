using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escrevendo_as_Classes_de_Um_Jogo
{
    public class Heroi
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Tipo { get; set; }
        public string? Ataque;

        public Heroi(string tipo)
        {
            Tipo = tipo;            

            switch (tipo)
            {
                case "Mago":
                    Ataque = "Magia";
                System.Console.WriteLine($"O {tipo} atacou usando {Ataque}");
                break;

                case "Guerreiro":
                    Ataque = "Espada";
                System.Console.WriteLine($"O {tipo} atacou usando {Ataque}.");
                break;

                case "Monge":
                    Ataque = "Artes Marciais";
                System.Console.WriteLine($"O {tipo} atacou usando {Ataque}.");
                break;

                case "Ninja":
                    Ataque = "Shuriken";
                System.Console.WriteLine($"O {tipo} atacou usando {Ataque}.");
                break;

                default:
                System.Console.WriteLine($"O Heroi {tipo} não foi encontrado!");
                break;
            }
        }
        
    }
}