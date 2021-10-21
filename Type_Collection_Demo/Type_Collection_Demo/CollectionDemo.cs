using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_Demo
{
    class CollectionDemo
    {
        static void Main(string[] args)      
        {
            //datatype[] name = new datatype[size];

            //int[] numberArray = new int[3];
            //numberArray[0] = 369;
            //numberArray[1] = 3699;
            //numberArray[2] = 26;

            // for (int i = 0; i < numberArray.Length; i++)
            // {
            //    Console.WriteLine(numberArray[i]);
            //}


            /* #region System.Collection classes



             ArrayList countyList = new ArrayList();
             countyList.Add("India");
             countyList.Add("USA");
             countyList.Insert(1, "France");



             countyList.Add("100");
             countyList.Add("true");



             //object
             Person person = new Person() { FirstName = "sandhya", LastName = "sai" };

             Console.WriteLine(person.FirstName + " " + person.LastName);

             Console.WriteLine("-------\n");


             countyList.Add(person);



             //from countyLIst collection for item no 5
             //type conversion
             Console.WriteLine(((Person)countyList[5]).FirstName);



             for (int i = 0; i < countyList.Count; i++)
             {
                 Console.WriteLine(countyList[i]);
             }
             #endregion */


            /* #region Generic Collection class
             //generic collection is a type safe collection

             List<string> countryList = new List<string>();
             countryList.Add("India");
             //countryList.Add(100);

             List<int> numbers = new List<int>();
             numbers.Add(100);

             List<Person> personList = new List<Person>();
             personList.Add(new Person() { FirstName = "sandhya", LastName = "sai" });
             Console.WriteLine(personList[0].FirstName);




             #endregion */

            #region Nullable Type
            // int i = null;
            Nullable<int> x = 100;
            x = 100;
            x = null;

            //datatype?   -----nullable type
            int? y = null;



            #endregion




        }
    }
}
        
