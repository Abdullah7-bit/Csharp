// string customerName = "Ms. Barros";
// var customerNameLength = customerName.Length + 1;

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here
// customerName = customerName.PadRight(customerNameLength, ',');
// Console.WriteLine("Dear {0}", customerName);
// Console.WriteLine("As a customer of our {0} offering we are excited to tell you about a new financial product that would dramatically increase your return.", currentProduct);
// Console.WriteLine("\nCurrently, you own {0:N2} shares at a return of {1:P2}", currentShares,currentReturn);
// Console.WriteLine("\nOur new product, {0} offers a return of {1:P2}. Given your current volume, your potential profit would be {2:C2}.", newProduct, newReturn, newProfit);
// Console.WriteLine("\nHere's a quick comparison:\n");

// string comparisonMessage = "";

// // Your logic here
// comparisonMessage += currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);