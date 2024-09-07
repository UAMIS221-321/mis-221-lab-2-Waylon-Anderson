//Initialized Variables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost = 0;

//initialize constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

// prompt user for the # of sandwiches
System.Console.WriteLine("How many sandwiches? ");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches "+numberOfSandwiches);

// prompt user for amount of toppings
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Number of toppings: "+numberOfToppings);

// prompt user for tip
System.Console.WriteLine("How much would you like to tip?");
tip = int.Parse(Console.ReadLine());
System.Console.WriteLine("Tip: "+tip);

// calculation of toppings, sandwiches, discount, and tip combined

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;
orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

// displaying the final cost

System.Console.WriteLine(orderCost);
