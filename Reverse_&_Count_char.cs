string msg = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = msg.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);

int ctr = 0;

// count the o's
foreach (char letter in charMessage) {
    if (letter == 'o') {
        ctr++;
    }
}

// convert it back to a string
string newMessage = new String(charMessage);

// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {ctr} times.");