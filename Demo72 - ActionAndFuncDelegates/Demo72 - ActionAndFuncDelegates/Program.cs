// Demo72 - Action and Func Delegates
// TOSINSO C# Mega Course

using Demo72___ActionAndFuncDelegates;

Action<string> displayMessage = Logics.DisplayMessage;

displayMessage("Welcome to TOSINSO.COM");

Action<string,int> repeatMessage = Logics.RepeatMessage;

repeatMessage("C# Mega Course", 10);

Func<decimal, decimal, decimal> mlpFunc = Logics.Multiply;

Console.WriteLine(mlpFunc(2.5m,3.1m));

Func<int, int, int> sumFunc = Logics.Sum;

Console.WriteLine(sumFunc(2,8));