using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class RPG
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.Write("Digite seu nome de heroi:");
            heroi = new(Console.ReadLine());
            Info();
            Menu();
        }

        public void Info()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("STATUS");
            Console.WriteLine($"Nome do héroi:{heroi.nome}");
            Console.WriteLine($"Experiencia:{heroi.xp}");
            Console.WriteLine($"Nivel:{heroi.nivel}");
            Console.WriteLine($"Vida:{heroi.vida}");
            Console.WriteLine($"Ataque base:{heroi.ataqueBase}");
            Console.WriteLine("----------------------------");
        }

        public void Menu()
        {
            Console.Clear();
            Info();
            Console.WriteLine("INIMIGOS:");
            Console.WriteLine("1 - Fada");
            Console.WriteLine("2 - Deusa");
            Console.WriteLine("3 - Dêmonio");
            Console.Write("Escolha seu inimigo:");
            switch (Console.ReadLine())
            {
                case "1":
                    Batalhar(new Monstro ("Fada", heroi.vida * 2, heroi.nivel));
                    break;
                case "2":
                    Batalhar(new Monstro("Deusa", heroi.vida * 5, heroi.nivel * 2));
                    break;
                case "3":
                    Batalhar(new Monstro("Dêmonio", heroi.vida * 10, heroi.nivel * 4));
                    break;
                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            }
            if (heroi.vida <=0)
            {
                Console.WriteLine("Heroi foi morto!");
            }
            else
            {
                Menu();
            }
            
        }
        public void Batalhar(Monstro monstro)
        {
            Console.Clear();
            Info();

            Console.WriteLine($"Inimigo selecionado:{monstro.nome} - Ataque:{monstro.ataque} - Vida:{monstro.vida} - Expereriencia:{monstro.experiencia}");
            Console.WriteLine("1 - Ataque ou 2 - Fuja:");
            switch (Console.ReadLine())
            {
                case "1":
                    monstro.vida -= heroi.ataque;
                    Console.WriteLine($"Você causou {heroi.ataque} de ataque no {monstro.nome}");

                    heroi.vida -= monstro.ataque;
                    Console.WriteLine($"Você recebu {monstro.ataque} de dano do {monstro.nome}");

                    if (heroi.vida < 0)
                    {
                        Console.WriteLine("Você morreu!");
                        return;
                    }

                    if(monstro.vida < 0)
                    {
                        Console.WriteLine($"Você derrou o {monstro.nome} e ganhou {monstro.experiencia} de xp");
                        heroi.ganhaXP(monstro.experiencia);
                        return;
                    }
                    break;
                    
            }
            Console.WriteLine("Pressione algo...");
            Console.ReadKey();
            Batalhar(monstro);
        }
    }


}
