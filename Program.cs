using System;

class Program {
  static void Main() {
    int numberLength, powerInitialValue, secondDigitIndex, digitsToRemoveCount;

    numberLength = 2;
    powerInitialValue = 1;
    secondDigitIndex = 1;
    digitsToRemoveCount = 1;

    while (true) {
      Console.WriteLine("Select Task:\n1 - Exponentiation\n2 - Second Digit Permutation");
      Console.Write("Your Choice: ");

      string userChoice;
      userChoice = Console.ReadLine();

      if (userChoice == "1") {
        Console.Write("a: ");
        int baseNumber;
        baseNumber = int.Parse(Console.ReadLine());
        Console.Write("n: ");
        int exponentValue;
        exponentValue = int.Parse(Console.ReadLine());
        long calculationResult;
        calculationResult = powerInitialValue;
        for (int loopCounter = 0; loopCounter < exponentValue; ++loopCounter) {
          calculationResult *= baseNumber;
        }

        Console.WriteLine($"Calculation Result: {calculationResult}");
      }
      else if (userChoice == "2") {
        Console.Write("x: ");
        string inputNumber;
        inputNumber = Console.ReadLine();

        if (inputNumber.Length <= numberLength) {
          Console.WriteLine("Number Must Contain At Least 3 Digits!");
          continue;
        }

        char secondDigit;
        secondDigit = inputNumber[secondDigitIndex];
        string newNumber;
        newNumber = inputNumber.Remove(secondDigitIndex, digitsToRemoveCount) + secondDigit;

        Console.WriteLine($"n: {newNumber}");
      } else {
        Console.WriteLine("Invalid Choice!");
      }
    }
  }
}