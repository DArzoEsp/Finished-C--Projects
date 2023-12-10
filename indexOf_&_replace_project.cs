const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";

string inputReplacement = input.Replace("&trade", "&reg");

int findOpen = input.IndexOf(openSpan);
int findClose = input.IndexOf(closeSpan);

findOpen += openSpan.Length;

int length = findClose - findOpen;

quantity = input.Substring(findOpen, length);  // finding the number 5000 with the code above

findOpen = inputReplacement.IndexOf(openDiv);
findClose = inputReplacement.IndexOf(closeDiv);

findOpen += openDiv.Length;

length = findClose - findOpen;

output = inputReplacement.Substring(findOpen, length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");