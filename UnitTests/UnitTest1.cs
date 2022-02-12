using System;
using System.IO;
using System.Text;
using GranifyApp;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        //Testing that a new cats age is within the range 5 and 10.
        [Fact]
        public void AgeTest()
        {
            Assert.InRange(new Cat().Age, 5, 10);
            Assert.InRange(new Cat().Age, 5, 10);
            Assert.InRange(new Cat().Age, 5, 10);
            Assert.InRange(new Cat().Age, 5, 10);
            Assert.InRange(new Cat().Age, 5, 10);
            Assert.InRange(new Cat().Age, 5, 10);
        }

        // Testing the speak method
        [Fact]
        public void SpeakTestCat()
        {
            StringWriter output = new StringWriter();
            var tempOut = Console.Out;
            Console.SetOut(output);

            new Cat().speak();
            Assert.Equal("Meow" + Environment.NewLine, output.ToString());

            StringBuilder toDelete = output.GetStringBuilder();
            toDelete.Remove(0, toDelete.Length);

            new Cat().speak("Test");
            Assert.Equal("Test" + Environment.NewLine, output.ToString());

            toDelete = output.GetStringBuilder();
            toDelete.Remove(0, toDelete.Length);

            new Cat().speak("");
            Assert.Equal(Environment.NewLine, output.ToString());

        }

        [Fact]
        public void SpeakTestDog()
        {
            StringWriter output = new StringWriter();
            var tempOut = Console.Out;
            Console.SetOut(output);

            new Dog().speak();
            Assert.Equal("Woof" + Environment.NewLine, output.ToString());

            StringBuilder toDelete = output.GetStringBuilder();
            toDelete.Remove(0, toDelete.Length);

            new Dog().speak("Test");
            Assert.Equal("Test" + Environment.NewLine, output.ToString());

            toDelete = output.GetStringBuilder();
            toDelete.Remove(0, toDelete.Length);

            new Dog().speak("");
            Assert.Equal(Environment.NewLine, output.ToString());
        }

        // This shows that the 'mock database' object is inserting items AND persisting them.
        [Fact]
        public void databaseInsert()
        {
            Cat cat = new Cat("Kevin");
            Data db = new Data("db");
            Assert.False(db.MockDatabase.ContainsKey("Cat"));
            db.insert("Cat", cat);

            Assert.Equal("Kevin", db.MockDatabase["Cat"][0].Name);

            Assert.False(db.MockDatabase.ContainsKey("Dog"));
            Dog dog = new Dog("Louis");
            db.insert("Dog", dog);

            Assert.Equal("Louis", db.MockDatabase["Dog"][0].Name);

        }
    }
}
