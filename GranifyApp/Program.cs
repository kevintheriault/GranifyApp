using System;

namespace GranifyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();

            Console.WriteLine("Name is currently " + cat.Name);

            cat.Name = "Garfield";

            Console.WriteLine("Name has been changed to " + cat.Name);

            Data data = new Data("database");

            data.insert("Cat", cat);

            Console.WriteLine(cat.getAverageNameLength());

            PetShop petShop = new PetShop(data);
            petShop.saveTest();
            petShop.savePetShop();

            petShop.logStats();
        }
    }
}
