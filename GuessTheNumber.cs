using System;
class GuessTheNumber {
  static void Main() {
      
     string input; 
     int num, userGuess = 0;
     
    Random rnd = new Random();
    num = rnd.Next(1,11);
      
    Console.WriteLine("Welcome to Guess The Number!");
    Console.WriteLine("Guess a number 1-10.");
    
    
    while (userGuess != num) {
        Console.WriteLine("Enter your guess: ");
        input = Console.ReadLine();
        userGuess = Convert.ToInt32(input);
        
        if (userGuess < num) {
            Console.WriteLine("Too low! Try again.");
        }
        else if (userGuess > num)
        {
            Console.WriteLine("Too high! Try Again.");
        }
        else {
            Console.WriteLine("Correct! Good job.");
        }
    }
    Console.WriteLine("Thanks for playing!");
    }
    
  }
