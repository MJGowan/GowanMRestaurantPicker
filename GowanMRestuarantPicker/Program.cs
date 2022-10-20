//Madeline Gowan
//10-19-2022
//Restuarant Picker
//Create three categories, with ten restuarants in each category.
//Allow the user to generate a random restuarant. Alternatively,
//allow the user to pick a category before generating a random eatery

//Peer reviewed by Harrison Busby: "The code looks pretty good, just a couple of
//minor errors. When you are asked to pick or to randomize, if you input a response
//that isnt one of those two, the program kills itself. Other than that the data
//validation on the other responses were unbreakable(at least to my knowledge).
//Overall good code, just a couple of things to fix and then its great!
//Good job Maddie! :)


Console.Clear();

string[] pickCoffee = { "Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup" };
string[] pickBurger = { "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's" };
string[] pickPizza = { "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza" };
Random rnd = new Random();
string[] pickRandom = {"Starbucks", "Dutch Bros", "Poppy Coffee", "Scooter's", "Empresso", "Terra Coffee", "House of Shaw", "Cafe Acacia", "Color Me Coffee", "Lollicup", "Squeeze Burger", "The Habit", "Flip's Burgers", "Victory Grill", "In-n-Out Burger", "Burger King", "Midnightrue at Burnie's", "Five Star Burger", "Super Burger", "Wendy's", "Little Caesar's", "Round Table", "Domino's", "Pizza Hut", "Mountain Mike's", "David's Pizza", "BJ's", "Eddie's Pizza", "VIP Pizza", "Michael's New York Style Pizza"};


Console.Write("Do you want to pick a restuarant? Y or N: ");
string pickFood = Console.ReadLine().ToUpper();

if (pickFood != "Y" && pickFood != "N")
{
    Console.WriteLine("This is an invalid response. Try again.");
    Console.Write("Do you want to pick a restuarant? Y or N: ");
    pickFood = Console.ReadLine().ToUpper();
}

if (pickFood == "Y")
{
    Console.WriteLine("Okay, would you like to pick a category, or would");
    Console.Write("you like a random restaurant? Type pick or random: ");
    string pickCategory = Console.ReadLine().ToLower();

    if (pickCategory == "pick")
    {
        Console.WriteLine("Okay, then pick a category. Do you want...");
        Console.WriteLine("coffee, a burger, or pizza: ");
        string pickedIt = Console.ReadLine().ToLower();

        if (pickedIt == "coffee")
        {
            int indexC = rnd.Next(pickCoffee.Length);
            Console.WriteLine(pickCoffee[indexC]);

            Console.Write("Want to pick something else instead? Y or N: ");
            pickFood = Console.ReadLine().ToUpper();
        }

        if (pickedIt == "burger")
        {
            int indexB = rnd.Next(pickBurger.Length);
            Console.WriteLine(pickBurger[indexB]);

            Console.Write("Want to pick something else instead? Y or N: ");
            pickFood = Console.ReadLine().ToUpper();
        }

        if (pickedIt == "pizza")
        {
                int indexP = rnd.Next(pickPizza.Length);
                Console.WriteLine(pickPizza[indexP]);

                Console.Write("Want to pick something else instead? Y or N: ");
                pickFood = Console.ReadLine().ToUpper();
        }

        if (pickedIt != "pizza" && pickedIt != "burger" && pickedIt != "coffee"){
            Console.WriteLine("That isn't one of the choices... try again: ");
            pickedIt = Console.ReadLine().ToLower();
        }


    }

    else if (pickCategory == "random")
    {
        int indexR = rnd.Next(pickRandom.Length);
        Console.WriteLine(pickRandom[indexR]);

        Console.Write("Want to pick something else instead? Y or N: ");
        pickFood = Console.ReadLine().ToUpper();
    }
    else{
        Console.WriteLine("Please enter a valid response. ");
        Console.WriteLine("Would you like to pick a category, or would");
        Console.Write("you like a random restaurant? Type pick or random: ");
        pickCategory = Console.ReadLine().ToLower();
    }


}

if (pickFood == "N")
{
    Console.WriteLine("Okay, goodbye.");
}
