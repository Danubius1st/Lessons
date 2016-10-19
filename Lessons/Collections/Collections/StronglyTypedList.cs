using System;
using System.Collections.Generic;

namespace Collections
{
    public class Pet
    {
        private string _name;
        private int _age;
        private string _animal;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        public Pet(string name, string animal, int age)
        {
            Age = age;
            Animal = animal;
            Name = name;
        }
    }

    public class StronglyTypedList
    {
        private string _msg;
        public StronglyTypedList(string[] msg)
        {
            Pet dog = new Pet("Max", "the dog", 5);
            Pet cat = new Pet("Tom", "the cat", 3);

            List<Pet> Pets = new List<Pet>();
            Pets.Add(dog);
            Pets.Add(cat);
            _msg = string.Format("{0} (Capacity:{1})", msg[0], Pets.Capacity.ToString());
            List<Pet>.Enumerator e1 = Pets.GetEnumerator();
            DisplayPets(e1);

            Dictionary<int, Pet> PetsDict = new Dictionary<int, Pet>();
            PetsDict.Add(0, dog);
            PetsDict.Add(1, cat);
            _msg = string.Format("{0} (Capacity:{1})", msg[1], Pets.Capacity.ToString());
            Dictionary<int, Pet>.Enumerator e2 = PetsDict.GetEnumerator();
            DisplayPetsDict(e2);
        }

        private void DisplayPets(IEnumerator<Pet> e)
        {
            Console.WriteLine(_msg + ":");
            while (e.MoveNext())
            {
                DisplayPet(e.Current);
            }
            //Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
        }

        private void DisplayPetsDict(Dictionary<int, Pet>.Enumerator e)
        {
            Console.WriteLine(_msg + ":");
            while (e.MoveNext())
            {
                DisplayPetDict(e.Current);
            }
            //Console.WriteLine(Environment.NewLine);
            Console.ReadLine();
        }

        private void DisplayPet(Pet pet)
        {
            Console.WriteLine("\t{0} {1} has {2} years old", pet.Name, pet.Animal, pet.Age);
        }

        private void DisplayPetDict(KeyValuePair<int, Pet> petDict)
        {
            Console.WriteLine("\tNo.{0}: {1} {2} has {3} years old", petDict.Key, petDict.Value.Name, petDict.Value.Animal, petDict.Value.Age);
        }
    }
}
