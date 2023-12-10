bool validNumber = false;
string? num;
int numberRep = 0;

Console.WriteLine("Input a value between 5 and 10: ");

do {
    num = Console.ReadLine();
    if (num != null) {
        validNumber = int.TryParse(num, out numberRep);

        if (numberRep < 5 || numberRep > 10) {
            Console.WriteLine("Invalid input. Try again. Has to be between 5 and 10.");
            validNumber = false;
        }
        else if (validNumber == false) {    
            Console.WriteLine("Invalid input. Try again. Has to be a number.");
        }
    }
} while (validNumber == false);

Console.WriteLine($"Your input as an integer: {num}");