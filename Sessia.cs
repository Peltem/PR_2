using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_7
{
    public class Sessia
    {
        private int _sem;
        private int _ekz;
        private int _sdanzach;

        public Sessia(int ekz, int sdanzach, int sem)
        {
            Ekz = ekz;
            Sdanzach = sdanzach;
            Sem = sem;
        }

        public int Sem
        {
            get => _sem;
            set
            {
                _sem = value;
            }
        }
        public int Zach
        {
            get {

                if (Sem == 3 || Sem == 7)
                { 
                    return 3;
                }
                if (Sem == 5 || Sem == 6)
                {
                    return 4;
                }
                else { 
                    return 5;
                }
            }
        }
        public int Ekz
        {
            get => _ekz;
            set
            {
                _ekz = value;
            }
        }
        public int Sdanzach
        {
            get => _sdanzach;
            set
            {
                _sdanzach = value;
            }
        }
        public string Sdan
        {
            get
            {
                if (Sdanzach >= Zach)
                {
                    return "Сдана";
                }
                return "Не зачет";
            }
        }

    }
}
