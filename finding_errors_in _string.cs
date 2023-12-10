string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
int letterCounter = 0;

string[] orderID = orderStream.Split(",");


for(int i = 0; i < orderID.Length; i++) {
    if (orderID[i].Length != 4) {
        orderID[i] += "\t- ERROR";
    }
    Console.WriteLine(orderID[i]);
}

/*

----- OUTPUT -----

B123
C234
A345
C15 - ERROR
B177
G3003   - ERROR
C235
B179

*/