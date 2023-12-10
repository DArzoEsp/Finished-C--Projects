string message = "(What if) I have [different symbols] but every {open symbols} needs a [matching closing symbol]";
Console.WriteLine($"Searching THIS MEssage: {message}");

// The IndexOfAny() helper method requires a char array of characters.
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through
// the characters in the string. This time, use the closing
// position of the precious iteration as the starting index for the
// next open symbol. So, you need to initialize the closingPosition
// variable to zero:

int closingPosition = 0;

while (true)
{

    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break; // condition: if IndexOfAny() has no such char in message then it will equal -1;

    string currentSymbol = message.Substring(openingPosition, 1); // (start position, length)

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOF method to specify
    // that the search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

}

/*

----- OUTPUT -----

Searching THIS MEssage: (What if) I have [different symbols] but every {open symbols} needs a [matching closing symbol]
What if
different symbols
open symbols
matching closing symbol

*/