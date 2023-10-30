using System;
using System.Collections.Generic;

internal class Program
{

    static void Main(string[] args)
    {
        MyInfo();
        Console.WriteLine("Assignment 02-Pet");
        Console.WriteLine();

        //question number 1 answer:
        Pet pet1 = new Pet("Losi", 3, "german");
        Pet pet2 = new Pet("Sami", 1, "Samoyed");
        Pet pet3 = new Pet("Jack", 2, "Chow Chow");
        Pet pet4 = new Pet("Pami", 4, "Pomeranian");

        //question number 2 answer:
        List<Pet> petList = new List<Pet>();
        petList.Add(pet1);
        petList.Add(pet2);
        petList.Add(pet3);
        petList.Add(pet4);


        //question number 3 answer:
        pet1.SetOwner("Marjan");
        pet2.SetOwner("Marjan");
        pet4.SetOwner("Mona");

        pet2.Train();
        pet3.Train();

        //question number 4 answer:
        foreach (Pet pet in petList)
        {
            Console.WriteLine(pet);
            Console.WriteLine();
        }

        //question number 5 answer:
        Console.Write("Please enter the pet owner's name: ");
        string ownerName = Console.ReadLine();
        Console.WriteLine();

        foreach (Pet pet in petList)
        {
            if (pet.Owner == ownerName)
            {
                Console.WriteLine(pet);
            }
        }

        Console.ReadKey();
    }
    public static void MyInfo()
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** This program is written by Marjan Jafari **");
        Console.WriteLine("**** My Student ID: XXXX1020               ****");
        Console.WriteLine("**** Assignment 02-Method (Solution)       ****");
        Console.WriteLine("**** Solution for Questions 05             ****");
        Console.WriteLine("***********************************************");
    }

}
class Pet
{
    public string Name { get; set; }
    public string Owner { get; private set; }
    public int Age { get; set; }
    public string Description { get; set; }
    public bool IsHouseTrained { get; private set; }

    public Pet(string name, int age, string description)
    {
        Name = name;
        Age = age;
        Description = description;
        Owner = "no one";
        IsHouseTrained = false;
    }



    public override string ToString()
    {
        return $"The name of this pet is {Name}, the owner is {Owner}, it has {Age} years old, it is {Description} and the status of house trained is {IsHouseTrained} ";
    }

    public void SetOwner(string owner)
    {
        Owner = owner;
    }
    public void Train()
    {
        IsHouseTrained = true;
    }
}