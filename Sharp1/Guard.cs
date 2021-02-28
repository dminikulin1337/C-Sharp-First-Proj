using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Guard : Employee
    {
        public WatchObject watchOBJ;
        public GuardRank guardRank;
        public Guard() : base()
        {

        }
        public Guard(string name, string surname, string patron,
                            DateTime birth, Gender gen, Nationality nat, EducationLevel edlevel,
                            float mani, int ages, WatchObject watch, GuardRank rank)
            : base(name, surname, patron, birth, gen, nat, edlevel, mani, ages)
        {
            this.watchOBJ = watch;
            this.guardRank = rank;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\n\tGuard." +
                $"\n\tWatching: {watchOBJ}" +
                $"\n\tRank: {guardRank}";
        }
    }
}
