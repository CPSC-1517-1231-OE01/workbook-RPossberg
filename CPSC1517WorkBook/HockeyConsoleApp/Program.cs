using HockeyData;

Console.WriteLine("Welcome to the HockeyPlayer Test App");

// default 
//HockeyPlayer player1 = new HockeyPlayer();
//player1.FirstName = "Stewart";
//player1.LastName = "Skinner";

//// object-initializer
//HockeyPlayer player2 = new HockeyPlayer()
//{
//    FirstName = "Connor",
//    LastName = "Brown",
//};

// greedy 
HockeyPlayer player2 = new HockeyPlayer("Bobby", "Orr", "Parry Sound, ON", new DateOnly(1948, 3, 20),
    196, 73, 28, Position.Defense, Shot.Right);

// Testing overloaded IsInTheFuture
Console.WriteLine($"Date in future? {Util.Utilities.IsDateInFuture(new DateTime(2023, 9, 12))}");

// Everything but the Age can be done day one of week two
// Console.WriteLine($"The player's name is {player1.ToString()}, they are born {player1.DateOfBirth} and are {player1.Age} years old.");
// Call to .ToString() is unnecessary, using the variable in this context will automatically call ToString()
Console.WriteLine($"The player's name is {player2}, they are born {player2.DateOfBirth} and are {player2.Age} years old.");
// Console.WriteLine($"The player's name is {player3}, they are born {player3.DateOfBirth} and are {player3.Age} years old.");