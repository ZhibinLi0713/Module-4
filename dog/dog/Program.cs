using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        //Start from creating enum type..//
        public enum Gender
        {
            Male, Female
        };
        //public properties declare//
        public string name;
        public string owner;
        public int age;
        public Gender gender;

        //initialize all of the properties//
        public Dog(string nameRl, string ownerRl, int ageRl, Gender genderRl)
        {
            name = nameRl;
            owner = ownerRl;
            age = ageRl;
            gender = genderRl;
        }

        //define Bark method, VS suggests me to make it capital. lol//
        public void bark(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("Woof!");

            }
            Console.WriteLine();
        }

        //I failed to check gender within getTag method, my friend suggests me to
        //create a checkGender method to return a string//
        public static string getGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "isHis";
            }
            else {
                    return "isHer";
                }
           
        }

        //define getTag method//
        public string getTag()
        {
            // call the method getGender"//
            string hisOrher = getGender(gender);
            // declare variable to store//
            string mOrF;

            // check and give
            if (hisOrher == "isHis")
            {
                mOrF = "he";
            }
            else
            {
                mOrF = "she";
            }
            // return as string//
            return "If lost, call " + owner + ". " + hisOrher + " name is " + name + " and " + mOrF + " is " + age + " old.";
        }
    }
    //class dog over//

    class Program
    {
        static void Main(string[] args)
        {   
            Dog puppy = new Dog("Orion", "Shawn", 1, Dog.Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Dog.Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
            Console.Read();
        }
    }
}
