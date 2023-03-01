using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_7
{
    public class SessiaDatabase
    {
        private Random _rnd = new Random();

        public List<Sessia> Sessias { get; private set; }

        public SessiaDatabase()
        {
            Sessias = new List<Sessia>();
        }

        public void Initialize()
        {
            for (int i = 0; i < 10; i++)
            {
                var ekz = _rnd.Next(1, 4);
                var sdanzach = _rnd.Next(1, 5);
                var sem = _rnd.Next(1, 8);
                Sessias.Add(new Sessia(ekz, sdanzach, sem));
            }
        }
    }
}
