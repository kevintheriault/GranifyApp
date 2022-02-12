using System;
using System.Collections.Generic;

namespace GranifyApp
{
    public class PetShop
    {
        private Data database;

        public PetShop(Data database)
        {
            this.database = database;
        }

        public void saveTest()
        {
            Cat cat = new Cat("Kevin");
            database.insert("Cat", cat);

            Dog dog = new Dog("Dawn");
            database.insert("Dog", dog);
        }

        public void savePetShop()
        {
            Cat cat1 = new Cat();
            database.insert("Cat", cat1);
            Cat cat2 = new Cat();
            database.insert("Cat", cat2);
            Cat cat3 = new Cat();
            database.insert("Cat", cat3);
            Dog dog1 = new Dog();
            database.insert("Dog", dog1);
            Dog dog2 = new Dog();
            database.insert("Dog", dog2);
            Dog dog3 = new Dog();
            database.insert("Dog", dog3);
        }

        // Just prints information about what was executed adding to the 'database'
        public void logStats()
        {
            int storedPetCount = 0;

            foreach (List<Pet> pet in database.MockDatabase.Values)
            {
                storedPetCount += pet.Count;
            }

            Console.WriteLine("Pet Tables Persisting: " + database.MockDatabase.Count);

            foreach (string key in database.MockDatabase.Keys)
            {
                Console.WriteLine("Pet type database created: " + key);
            }
            Console.WriteLine("Total Pets Inserted: " + storedPetCount);

        }
    }
}
