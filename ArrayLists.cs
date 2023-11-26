using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class ArrayLists
    {
        public void listArrays(){
            //We use array lists to store elements of different data types
            ArrayList employee= new ArrayList(); // Creating an arrayList
            employee.Add("Kelvin");              //Adding an element to an array list we use Add() method
            employee.Add(6);
            for(int i=0; i < employee.Count;i++){
                Console.WriteLine(employee[i]);
            }
            //Declaring an array and initializing it.
            ArrayList age=new ArrayList(){"Ngeiywa", 23, "kellyngeiywa@gmail.com"};
            age.Insert(2,"Software developer");  // Adding element at a specified index or position 
                                                 // we use Insert() method.

           
            

            var second=age[3]; // Accessing array at a specified index
            Console.WriteLine(second);

            
            age[2]="Software Engineer"; //Changing the value of an arrayList element at a specified index.
            Console.WriteLine(age[2]);

            age.Remove("Ngeiywa");    //Removing an arrayList element
            age.RemoveAt(1);         //Removing element at a specified index position

             foreach(var el in age){          //Iterating through an arrayList
                Console.WriteLine($"{el}");
                
            }

        }
    }
}