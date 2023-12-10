Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to {int.MinValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");

Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)");

/*
----- OUTPUT -----

Signed integral types:
sbyte   : -128 to 127
short   : -32768 to 32767
int     : -2147483648 to 2147483647
long    : -9223372036854775808 to -2147483648

Unsigned integral types:
byte    : 0 to 255
ushort  : 0 to 65535
uint    : 0 to 4294967295
ulong   : 0 to 18446744073709551615

Floating point types:
float   : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
double  : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
decimal : -79228162514264337593543950335 to 79228162514264337593543950335 (with ~28-29 digits of precision)
*/