string message = "(What if) I am (only interested) in the last (set of parentheses)?";

/*

int openingPosition = message.LastIndexOf('(');

openingPosition += 1;                           ----- OUTPUT -----> set of parentheses
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

*/

while (true)
{
    int openingPosition = message.IndexOf('(');
    if(openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

/*

----- OUTPUT -----

What if
only interested
set of parentheses

*/