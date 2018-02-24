using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianProduct2
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Sets> AllSets = new List<Sets>();

            Console.WriteLine(" How many sets do you want to have? ");
            string numberOfSets = Console.ReadLine();
            int NumberOfSets = Convert.ToInt32(numberOfSets);

            for (int j = 0; j< NumberOfSets; j++)
            {
                Sets set = new Sets();

                Console.WriteLine(" How many numbers do you want to put in set {0}? ", j);
                string numbersTotal = Console.ReadLine();
                int TotalNumbers = Convert.ToInt32(numbersTotal);

                set.SetElementsToTheSet(TotalNumbers);

                AllSets.Add(set);
            }
            List<List<int>> tmpList = new List<List<int>>();

            Sets CartesianProductionTemp = new Sets();
            CartesianProductionTemp = AllSets[0];
            List<Sets> CartesianProduction = new List<Sets>();
           
            for ( int l=1; l< AllSets.Count; l+=1)
            {
                CartesianProductionTemp = CartesianProductionTemp*AllSets[l];
            }
            Console.WriteLine(" The cartesian product of the sets is : ");
            var cartesian = CartesianProductionTemp.ElementsOfTheSet;
            for(int i=0;i< cartesian.Count; i += 2)
            {
                Console.Write("("+cartesian[i]+";");
                Console.WriteLine(cartesian[i + 1]+")");
                
            }
          
            Console.ReadKey();
        }
        
    }
    
}
