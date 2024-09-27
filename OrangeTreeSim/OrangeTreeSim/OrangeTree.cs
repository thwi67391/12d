using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetTreeAlive(bool treeAlive)
        { this.treeAlive = treeAlive; }

        public bool GetTreeAlive()
        {
            return treeAlive;
        }

        public void SetNumOranges(int NumOranges)
        {
            this.numOranges = NumOranges;
        }
        public int GetNumOranges()
        { return numOranges; }

        public void SetOrangesEaten(int OrangesEaten)
        { this.orangesEaten = OrangesEaten; }

        public int GetOrangesEaten()
        { return orangesEaten; }

        public void OneYearPasses()
        {
            age++;
            if (age < 80)
            {
                height += 2;
            }
            treeAlive = age < 80;
            if (age > 1)
            { numOranges += 5; }
        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            { numOranges -= count; }

            else
            { numOranges = 1; }
        }


    }
}
