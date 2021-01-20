using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen pol = new Citizen("Pol", 1);
            Citizen sam = new Citizen("Sam", 2);

            Citizen[] children =
            {
                new Citizen("Klara", 1),
                new Citizen("Sara", 1),
                new Citizen("Rima", 1)
            };

            pol.SetChildren(children);

        }

        public static bool CheckValidity(Citizen x) 
        {
            if (HasChildren(x))
            {
                foreach (var item in x.children)
                {
                    if (item.fatherID != x.id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool HasChildren(Citizen x)
        {
            if (x.children.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
