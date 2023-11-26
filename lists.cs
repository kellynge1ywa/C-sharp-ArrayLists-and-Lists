using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Lists
    {
        public void Towns()
        {
            //We use lists to store elements of the same data types.
            List<string> Towns=new List<string>(){"Kitale","Eldoret","Thika","Voi"}; //Creating a list
            Towns.Add("Nakuru"); //Adding an element to C# 
            Towns.Add("Nyeri");
            Towns.Add("Nyeri");


            Towns.Insert(3,"Lodwar"); //Adding an element at a specified index.

            Towns.Remove("Nyeri");  //Removes the first occurence of an element

            Towns.RemoveAt(3); //Removes an element at a specified index position
            Towns.RemoveRange(1,3);


            foreach(var town in Towns)
            {
                 Console.WriteLine($"{town}");
    
            }

        }
    }
}