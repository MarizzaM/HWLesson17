using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson17
{
    class Citizen
    {
        public string name;
        public Citizen[] children;
        public readonly int fatherID;
        public readonly int id;
        public static int numberOfCurrentCitizens;
        public const int maximumNumberOfCitizens=10000;

        public Citizen(string name, int fatherID)
        {
            this.name = name;
            this.fatherID = fatherID;
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"Number of current citizens: {numberOfCurrentCitizens}");
        }

        public static bool ReachedHalfOfMaximumSize() 
        {
            if (numberOfCurrentCitizens > maximumNumberOfCitizens)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void PrintID()
        {
            Console.WriteLine($"Id: {this.id}");
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine($"Gap between my ID and father{ this.id - this.fatherID}");
        }
/*
        public void SetChildren(Citizen[] children)
        {
            this.children = children;
            foreach (var item in children)
            {
                if (item.fatherID != this.id)
                {
                    throw new ArgumentException("father id does not match child");
                }
            }
        }
*/
        public void SetChildren(Citizen[] children)
        {

            for (int i = 0; i < children.Length; i++)
            {
                children[i] = this.children[i];            
            }
        }

        public override string ToString()
        {
            return $"name: {this.name}, ID: {this.id}, father ID: {this.fatherID}, amount of children: {this.children.Length}";
        }
    }
}
