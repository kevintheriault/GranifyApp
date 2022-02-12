### Read me for Granify Assignment

1. Language: C# with NuGet as the package manager.
2. IDE Used: Visual Studio 2019
3. Packages used: For the unit tests I used Xunit in a separate assembled project.

I chose to write this in C# because on the job posting this was listed as a main component of the
stack Granify uses and I like how C# easily handles LinkedLists and Dictionaries.  I used
the Xunit package to demonstrate familiarity with unit tests.  I tried to make "Good", "Bad" and
"Border" cases for tests but it was hard to think of ways to for the required tests.

To use:

The project can be run as any other C# project.  It will output to STDOUT the requested lines
and information starting from task 1.

FOR CLI: just run 'dotnet restore', 'dotnet build', 'dotnet run --project GranifyApp' from the base solution directory (Where the .sln file is located).
Otherwise just run in IDE.

The mock database is created in Program.cs and persists.  I used a simple Dictionary with
Listed values to emulate a database.  This has the advantage that items can be searched for easily.

In order to make both cat and dog I thought it would be simpler to use a "Pet" abstract class.
To add a cat: Cat catName = new Cat("Name here is optional");
To add a dog: Dog dogName = new Dog("Name here is optional");

Both also have the speak method implemented which overrides the abstract method,
cats say 'Meow' or whatever you input dogs say 'Woof' or whatever you input.
(to use: petName.speak("Optional text here for output");

The pets can then be inserted into the database using:
data.insert("Table name", petObjectName);

This will create a new 'table' if it does not exist with the pet type and add the pet as a 'row'.
I chose this because I felt it represented a database accurately.

### TESTS
In the 'Tests' project you can write in your terminal:
dotnet restore 
While in the path of the solution.  This will restore dependencies (Xunit and requirments for it).

The tests can be run in terminal by typing 'dotnet test'.

All tests should show as passed.  I have tested the age multiple times (to ensure it's in range),
tested both dog and cat default and optional 'speak' methods, and tested the creation of tables,
and insertion of 'rows'.

The required SQL file can be found in the 'GranifyAssignment/GranifyAssignment' project.

I would probably change this assignment to use a real memory/small file database like SQLite or H2.
Simply because I think it would have been more demonstrative.
