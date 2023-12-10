decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price); //string interpolation

yourDiscount += $"A discount of {(price - salePrice) / price:P2}!"; // not string interpolation -----> A discount of 11.19%!

Console.WriteLine(yourDiscount);

/*

----- OUTPUT -----

You saved $7.56 off the regular $67.55 price. A discount of 11.19%!

*/