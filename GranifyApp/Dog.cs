using System;
namespace GranifyApp
{
    public class Dog : Pet
    {
        private int counter = 1;
        Random rand = new Random();

        public Dog(string name = "")
        {
            this.Name = name;
            this.Age = rand.Next(5, 11);
            this.FavoriteFood = "Kibble";
        }

        override
        public void speak(string output = "Woof")
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

