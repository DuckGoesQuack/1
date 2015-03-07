using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Creature
    {
        public char Type;
        public int X;
        public int Y;
        public int Lifes;
        public string Name;
        public Creature(char type, string name, int x, int y, int l = 1)
        {
            Type = type;
            X = x;
            Y = y;
            Lifes = l;
            Name = name; 
        }

        public bool IsAlive()
        {
            
            return Lifes > 0;
        }
    }
}
