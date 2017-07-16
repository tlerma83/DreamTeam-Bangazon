using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("He boo how you been?!");

            Eliza eliza = new Eliza();
            Jordan jordan = new Jordan();
            Ryan ryan = new Ryan();
            Jackie jackie = new Jackie();
            Ollie ollie = new Ollie();
            Tamela tamela = new Tamela();

            List<Iteammate> serverTeam = new List<Iteammate>()
            {
                eliza, jordan, ryan
            };
            
            List<Iteammate> clientTeam = new List<Iteammate>()
            {
                jackie, ollie, tamela
            };

            foreach (Iteammate member in serverTeam)
            {
                member.Work();
            }

            foreach (Iteammate member in clientTeam)
            {
                member.Work();
            }

        }
    }
}
