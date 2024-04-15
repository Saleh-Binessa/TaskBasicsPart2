// See https://aka.ms/new-console-template for more information

//C# Control Flow
// Challenge 1:-
int currentHour = DateTime.Now.Hour;

if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for lunch!");
}
else { Console.WriteLine("You missed the lunch time!"); }

Console.WriteLine("-------------------------------");

// Challenge 2:-
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------------");
// Bonus:-
int countdown = 5;

        while (countdown > 0)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

// C# Arrays**
Console.WriteLine("-------------------------------");
// Challenge 1:-

string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}

Console.WriteLine("-------------------------------");

// Challenge 2:-

int[] numbers = { 1, 2, 3, 4, 5 };

int sum = 0;

foreach (int number in numbers)
{
    Console.WriteLine(number + "\n");
    sum += number;
}
Console.WriteLine("The sum of the array elements is: " + sum);

Console.WriteLine("-------------------------------");

// Bonus:-
        char[,] ticTacToeBoard = new char[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                ticTacToeBoard[i, j] = ' ';
            }
        }

        ticTacToeBoard[0, 0] = 'X';
        ticTacToeBoard[1, 1] = 'O';
        ticTacToeBoard[2, 2] = 'X';

for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(ticTacToeBoard[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---------");
        }
