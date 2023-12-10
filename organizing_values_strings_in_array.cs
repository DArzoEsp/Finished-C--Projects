string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
float result = 0;

foreach(string value1 in values) {
    float total;
    if(float.TryParse(value1, out total)) {
        result += total;
    } else {
        message += value1;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {result}");

/*

----- OUTPUT -----

Message: ABCDEF
Total: 68.3

*/