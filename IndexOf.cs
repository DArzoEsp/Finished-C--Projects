string message = "What is the value <span>between the tags</span>";

const string openSpan = "<span>"; // use const almost as insurance to see errors or identify errors better in the complier depending on how complex your code is
const string closeSpan = "</span>";


int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length; // increment by x (length of closingPosition) because of the undesired '(' in the output

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

/*

----- OUTPUT -----

between the tags

*/