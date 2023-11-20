// See https://aka.ms/new-console-template for more information
using Harutyunyan_C_;


Task2 task2 = new Task2();

bool case1 = task2.IsBracketSequenceCorrect("[(()]]");
bool case2 = task2.IsBracketSequenceCorrect("[((())()(())]]");
bool case3 = task2.IsBracketSequenceCorrect("[(");
bool case4 = task2.IsBracketSequenceCorrect("((([[[((");

Console.WriteLine(case1);
Console.WriteLine(case2);
Console.WriteLine(case3);
Console.WriteLine(case4);








