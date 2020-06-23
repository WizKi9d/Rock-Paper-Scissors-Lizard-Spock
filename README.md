# Rock-Paper-Scissors-Lizard-Spock
My version of the game written in C# .Net

The game follows the rules of:
 * Uses 1 (rock), 2 (paper), 3 (scissors), 4 (lizard) and 5 (spock) to choose your move.
 * Uses user input of 'yes' to play another game.
 * Uses || or check for 2 different results in order for the player (you) to win a round.
 * Uses Console.Clear() to make the game cleaner and easier to play.
 * Uses Connsole.CursonVisible() to make sure the cursor highlight is hidden during the start of the game where the start screen opens.
 * Uses Random new Random() so the computer can choose their move.

The game displays the following at the end:
 * The winner.
 * How many turns the game took.
 * Most used move during the game.
 
Added:
 * Enum for choices.
 * Removed the need for Switch when getting the most used move (call: (enum)position)
 * Static class responses for getting back response text


# QUESTIONS: (Explained in a way my girlfriends mum understood)

**Purpose of an interface (in real english):**
Let's imagine cooking a dinner.
You have class that stores all your dinners where you give each one: ingredients, prep time and cooking time. You then know that each dinner has to be cooked. This makes 'Cooking dinner' a general idea. However, It's different for each dinner. So now you make an interface that has the generalised idea of 'cooking dinner' and then each dinner in the class then has a way to 'cook dinner' in it's own way because it's different for each one. For example some take longer than others or have different ingredients and steps.
Now when you want to cook dinner, imagine that you have a robot that cooks dinner for you and he already has a class with all the dinners and their properties (e.g ingredients, prep and cooking time. 
All you have to tell the robot now is to cook dinner and what dinner you want to cook because he knows that cooking dinner is an option and that each dinner is different to cook, he can find how to cook the dinner by looking at the dinner you gave him (known as a child class).

**What is encapsulation (in real english):**
Encapsulation is exactly what it sounds like. It's like boxing off something that shouldn't be changed or touched by the user.
If you think of an oven. It has settings such as the temperature and the oven settings. The manufacturer encapsulates them in a way that makes it so you cannot change them. For example the oven will never get hotten than it has been set to by the manufacturer. They have done this for safety and so the product works as it's intended to do so.

**What are access modifiers (in real english):**
Access modifiers are used to make sure that access to data is only given where it should be. For example referring back to encapsulation, any data that's encapsulated would be private so it cannot be modified from the ouside.
All the access modifiers in c# are: private, public, protected, internal, protected internal, private protected.
 * So if we use the word 'private' we won't be able to access the data from anywhere else in the project. It can only be used within the part that the data was made and declared private.
 * If we use the word 'public' we can access the data everywhere within the project.
 * If we use the word 'protected' we can only see the data thats "protected" in the part where the data was made and set to this and anything that calls the part that the data is in. So using a class where we have a protected bit of data, if a child class inherits the class where the data is then it can access it. Otherwise access is denied.
 * If we use the word 'internal' this means that the data can only be seen inside this project. A .dll file is the 'assembly' of the project and any files that are not defined in the .dll will not be able to access the 'internal' data.
 * If we use 'protected internal' we can then see the data between different (what we call) assemblies (basically meaning different projects). As long as the class inherits from the class with the data in the other assembly.
 * If we use 'private protected' it's once again a combination meaning the data cannot be accessed from a different assembly (different project) but it can be accessed where the data is defined and from anywhere that inherits the class the data was defined.
 
**What is circular dependancy (in real english):**
 A circular dependancy means that there are two things. Each depends on the other to work. 
 If you think about a chicken. It lays an egg. So the chicken is one thing and the egg is the second. The egg depends on the chicken and the chicken depends on the egg because if it's never an egg then it can't be a chicken. This is an issue because if you get a circular dependancy somewhere in your code you can't run it as they will both depend on each other and neither will work. 

