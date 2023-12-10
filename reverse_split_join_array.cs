string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);  ----- OUTPUT ----- 321cba
string result = string.Join(",", valueArray); 
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items) {
    Console.WriteLine(item);
}

/*

----- OUTPUT -----

3,2,1,c,b,a
3
2
1
c
b
a

*/