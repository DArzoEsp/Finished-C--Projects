string program = "The quick brown fox jumps over the lazy dog";
string newProgram = "";

Console.WriteLine("");
Console.WriteLine($"Converting the following string \"{program}\":");

string[] myProgram = program.Split(' ');

foreach (var word in myProgram) {
    char[] reverseWord = word.ToCharArray();
    Array.Reverse(reverseWord);
    string joinWord = string.Join("", reverseWord);
    newProgram += joinWord  + " ";
};

Console.WriteLine("");
Console.WriteLine("Converting each word to reverse...");
Console.WriteLine($"{newProgram}");

/*

----- OUTPUT -----

Converting the following string "The quick brown fox jumps over the lazy dog":

Converting each word to reverse...
ehT kciuq nworb xof spmuj revo eht yzal god

*/