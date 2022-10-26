bool validNum;
int num;
bool playAgain = true;

    while(playAgain == true)
    {

        string[] Mexican = {"Juanitas", "El Pollo Loco", "Chipotle", "Taco Bell", "El Senor", "Tapatio", "Guadalajara", "La Dona", "La Plaza", "Senor Frogs"};
        string[] Italian = {"Olive Garden", "Firenze", "Tuscany Food", "Pizza Hut", "Il Teatro", "Joes Italian", "Macaroni Grill", "Romanos", "Little Ceasars", "Little Italy"};
        string[] Japanese = {"Mikasa", "Blue Fin", "Tempura", "Sakura", "Little Tokyo", "Benihana", "Okinawa", "Yumi Sushi", "Sushi Boat", "Udon and More"};
        string[] Random= {"Juanitas", "El Pollo Loco", "Chipotle", "Taco Bell", "El Senor", "Tapatio", "Guadalajara", "La Dona", "La Plaza", "Senor Frogs", "Olive Garden", "Firenze", 
        "Tuscany Food", "Pizza Hut", "Il Teatro", "Joes Italian", "Macaroni Grill", "Romanos", "Little Ceasars", "Little Italy", "Mikasa", "Blue Fin", "Tempura", "Sakura", "Little Tokyo", 
        "Benihana", "Okinawa", "Yumi Sushi", "Sushi Boat", "Udon and More"};

        Console.WriteLine("Enter 1 for Mexican OR 2 for Italian OR 3 for Japanese OR 4 for Any/Random");

        do
        {
            validNum = int.TryParse(Console.ReadLine(), out num);
            if(validNum == false)
            {
                Console.WriteLine("Try again. Enter a valid number");
            }
        }while(validNum == false);


        Random num2 = new Random();
        if(num == 1)
        {
            int newNum = num2.Next(Mexican.Length);

            Console.WriteLine($"You should try: {Mexican[newNum]}");
        }

        if(num == 2)
        {
            int newNum = num2.Next(Italian.Length);

            Console.WriteLine($"You should try: {Italian[newNum]}");
        }

        if(num== 3)
        {
            int newNum = num2.Next(Japanese.Length);

            Console.WriteLine($"You should try: {Japanese[newNum]}");
        }
        if(num== 4)
        {
            int newNum = num2.Next(Random.Length);

            Console.WriteLine($"You should try: {Random[newNum]}");
        }

        string choice = "";
	    Console.WriteLine("Enter Y to play again or N to exit");
        while(choice != "Y" & choice != "N")
        {
            choice = Console.ReadLine().ToUpper();
        }
        
        if(choice == "Y")
        {
            playAgain = true;
        }
        else if(choice == "N")
        {
            playAgain = false;
            Console.WriteLine("Goodbye!");
        }
    }