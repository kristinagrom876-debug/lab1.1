using System;

class Program {
  static void Main() {
    int numberLength, powerInitialValue, secondDigitIndex, digitsToRemoveCount, baseNumber, loopCounter;
    string userChoice, exponentValue, newNumber, inputNumber;
    long calculationResult;
    char secondDigit;

    numberLength = 2;
    powerInitialValue = 1;
    secondDigitIndex = 1;
    digitsToRemoveCount = 1;

    while (true) { 
      Console.WriteLine("Select Task:\n1 - Exponentiation\n2 - Second Digit Permutation\nYour Choice:");

      userChoice = Console.ReadLine();

      if (userChoice == "1") {
        Console.Write("a: ");
        baseNumber = int.Parse(Console.ReadLine());
        Console.Write("n: ");
        exponentValue = int.Parse(Console.ReadLine());
        calculationResult = powerInitialValue;
        for (loopCounter = 0; loopCounter < exponentValue; ++loopCounter) {
          calculationResult *= baseNumber;
        }

        Console.WriteLine($"Calculation Result: {calculationResult}");
      }
      else if (userChoice == "2") {
        Console.Write("x: ");
        inputNumber = Console.ReadLine();

        if (inputNumber.Length <= numberLength) {
          Console.WriteLine("Number Must Contain At Least 3 Digits!");
          continue;
        }

        secondDigit = inputNumber[secondDigitIndex];
        newNumber = inputNumber.Remove(secondDigitIndex, digitsToRemoveCount) + secondDigit;

        Console.WriteLine($"n: {newNumber}");
      } else {
        Console.WriteLine("Invalid Choice!");
      }
    }
  }
}