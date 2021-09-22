using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Monstro
    {
        public Monstro(string nome, int vida, int ataque)
        {
            this.nome = nome;
            this.vida = vida;
            this.ataque = ataque;
            this.experiencia = vida + ataque;
        }

        public string nome { get; set; }
        public int vida { get; set; }
        public int ataque { get; set; }
        public int experiencia { get; set; }
    }
}
