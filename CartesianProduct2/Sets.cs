using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianProduct2
{
    public class Sets
    {
        List<int> elementsOfTheSet;
        public List<int> ElementsOfTheSet
        {
            get
            {
                return elementsOfTheSet;
            }
            set
            {
                elementsOfTheSet = value;
            }
        }
        //Constructor with params
        public Sets(List<int> production)
        {
            elementsOfTheSet = production;
        }
        //Constructor with no params
        public Sets()
        {
            elementsOfTheSet = new List<int>();
        }

        public List<int> SetElementsToTheSet(int TotalNumbers)
        {
            List<int> ElementsOfSet = new List<int>();
            for (int i = 0; i < TotalNumbers; i++)
            {
                Console.WriteLine(" Give element to the set ");
                string element = Console.ReadLine();
                int elementPut = Convert.ToInt32(element);
                ElementsOfSet.Add(elementPut);
            }
            elementsOfTheSet = ElementsOfSet; 
            return elementsOfTheSet;
        }



        public static Sets operator *(Sets first, Sets second)
        {
            Sets set = new Sets();
            foreach (int firstInt in first.ElementsOfTheSet)
            {
                foreach (int secondInt in second.ElementsOfTheSet)
                {

                    set.ElementsOfTheSet.Add(firstInt);
                    set.ElementsOfTheSet.Add(secondInt);

                }
            }
            return set;
        }
        
    }
}
