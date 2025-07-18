using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal struct Zoo
    {
        private string name;
        private int animalCount;

        public string Name
        {
            set
            {
                if (value is null || value.Length == 0)
                    return;

                name = value;
            }
            get
            {
                return name;
            }
        }

        public int AnimalCount
        {
            set
            {
                if(value < 0)
                    return;

                animalCount = value;
            }
            get
            {
                return animalCount;
            }
        }

        public override string ToString()
        {
            return $"Zoo name: {Name}, Animal count: {AnimalCount}";
        }
    }
}
