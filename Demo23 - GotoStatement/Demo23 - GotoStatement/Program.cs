/*
 *  Demo23 - Goto Statement
 *  CSharp Master Class (TOSINSO)
 *  Hossein Ahmadi
 */

Console.WriteLine("Printing numbers between 1 to 10...");

int counter = 1;

START:
if (counter > 10)
{
    goto END;
}
Console.WriteLine(counter);
counter++;
goto START;

END:
return;