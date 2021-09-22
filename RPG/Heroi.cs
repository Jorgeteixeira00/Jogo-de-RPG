using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Heroi
    {
        Random aleatorio = new Random();

        public string nome { get; set; }
        public int xp { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        public int ataqueBase { get; set; }
        public int ataque { get; set; }

        public Heroi(string nome)
        {
            this.nome = nome;
            this.xp = 0;
            this.nivel = 1;
            this.vida = 10;
            this.ataqueBase = aleatorio.Next(1, 11);
            this.ataque = this.ataqueBase;
        }
        public void ganhaXP(int experiencia)
        {
            xp += experiencia;
            int novo_nivel = (xp / 10) + 1;
            if (novo_nivel > nivel)
            {
                Console.WriteLine("\n\nVocê aumentou de nível!");
                vida = novo_nivel * 10;
            }
            nivel = novo_nivel;
            ataque = ataqueBase + nivel;
        }
    }
}
