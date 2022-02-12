
using System.Collections.Generic;

namespace GranifyApp
{
    abstract public class Pet
    {
        // params for Pets
        private LinkedList<string> namesLog = new LinkedList<string>();
        private string name;
        private int age;
        private string favoriteFood;

        // Generic speak command.  Can be overridden for specific animals.
        public abstract void speak(string output);

        // Getters/Setters using expression body.
        public int Age { get => age; set => age = value; }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                namesLog.AddFirst(value);
            }
        }

        public LinkedList<string> getNames()
        {
            return namesLog;
        }

        public double getAverageNameLength()
        {
            double totalCharacters = 0;

            foreach (string element in namesLog)
            {
                totalCharacters += element.Length;
            }
            return (totalCharacters / namesLog.Count);
        }


        public string FavoriteFood { get => favoriteFood; set => favoriteFood = value; }
    }
}
