
using System;

namespace GranifyApp
{
    public class Cat : Pet
    {
        private int counter = 1;
        Random rand = new Random();

        public Cat(string name = "")
        {
            this.Name = name;
            this.Age = rand.Next(5, 11);
            this.FavoriteFood = "Tuna";
        }

        override
        public void speak(string output = "Meow")
        {
            if (counter == 5)
            {
                this.Age++;
                counter = 1;
            }
            else
            {
                counter++;
            }

            Console.WriteLine(output);
        }
    }
}
