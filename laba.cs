using System;

class Program {
  static void Main() {
    int numberLength;
    int powerInitialValue;
    int secondDigitIndex;
    int digitsToRemoveCount;

    numberLength = 2;
    powerInitialValue = 1;
    secondDigitIndex = 1;
    digitsToRemoveCount = 1;

    while (true) {
      Console.WriteLine("Select Task:");
      Console.WriteLine("1 - Exponentiation");
      Console.WriteLine("2 - Second Digit Permutation");
      Console.Write("Your Choice: ");

      string userChoice = Console.ReadLine();

      if (userChoice == "1") {
        Console.Write("a: ");
        int baseNumber = int.Parse(Console.ReadLine());
        Console.Write("n: ");
        int exponentValue = int.Parse(Console.ReadLine());

        long calculationResult = powerInitialValue;
        for (int loopCounter = 0; loopCounter < exponentValue; ++loopCounter) {
          calculationResult *= baseNumber;
        }

        Console.WriteLine($"Calculation Result: {calculationResult}");
      }
      else if (userChoice == "2") {
        Console.Write("x: ");
        string inputNumber = Console.ReadLine();

        if (inputNumber.Length <= numberLength) {
          Console.WriteLine("Number Must Contain At Least 3 Digits!");
          continue;
        }

        char secondDigit = inputNumber[secondDigitIndex];
        string newNumber = inputNumber.Remove(secondDigitIndex, digitsToRemoveCount) + secondDigit;

        Console.WriteLine($"n: {newNumber}");
      } else {
          Console.WriteLine("Invalid Choice!");
      }
    }
  }
}