string input = "Pad this";
// Console.WriteLine(input.PadLeft(12)); ----- adds 4 spaces to the left and makes it look like it is indented(tabbed) 1 time
// Console.WriteLine(input.PadRight(12)); ----- puts it in its original place and has added characters of blank spaces

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

/*

----- OUTPUT -----

----Pad this
Pad this----

*/