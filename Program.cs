using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;

Random random = new Random();
char[] board = {'0', '1', '2', '3', '4', '5', '6', '7', '8'};

bool isRunning = true;
bool isPlayerTurn = true;

int comNum;

string[] line = 
{
    "your turn. enter which number to place X-",
    "computer turn-"
};

while (isRunning)
{
    Console.Clear();
    DrawBoard();

    if (isPlayerTurn)
    {
        Console.WriteLine(line[0]);
        GetPlayerInput();
    }
    else
    {
        Console.WriteLine(line[1]);
        ComTurn();
    }

    CheckWin();
}

void DrawBoard()
{
    
    Console.WriteLine("  --- TicTacToe ---\n");
    Console.WriteLine("  You are Player X \n");
    Console.Write($"      {board[0]} | {board[1]} | {board[2]}\n");
    Console.Write("     ---+---+---\n");
    Console.Write($"      {board[3]} | {board[4]} | {board[5]}\n");
    Console.Write("     ---+---+---\n");
    Console.Write($"      {board[6]} | {board[7]} | {board[8]}\n");
    Console.WriteLine("");
    Console.WriteLine("");

}

void GetPlayerInput()
{
    string input;
    input = Console.ReadLine();

    if (input != null)
    {
        if (int.TryParse(input, out int result))
        {
            if (result >= 0 && result <= 8)
            {
                board[result] = 'X';
                isPlayerTurn = false;
            }
            else
            {
                input = Console.ReadLine();
            }
        }
        else
        {
            GetPlayerInput();
        }
    }
    
}

void ComTurn() // !
{
    comNum = random.Next(1, 9);

    if (board[comNum] != 'X')
    {
        board[comNum] = 'O';

        Console.WriteLine("press to continue-");
        Console.ReadKey();
        isPlayerTurn = true;
    }       
    
}

void CheckWin()
{
    if (board[0] == 'X' && board[1] == 'X' && board[2] == 'X')
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') // X
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[6] == 'X' && board[7] == 'X' && board[8] == 'X')
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[0] == 'X' && board[3] == 'X' && board[6] == 'X')
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[1] == 'X' && board[4] == 'X' && board[7] == 'X')
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[2] == 'X' && board[5] == 'X' && board[8] == 'X')
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[0] == 'X' && board[4] == 'X' && board[8] == 'X') // diagonal
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[2] == 'X' && board[4] == 'X' && board[6] == 'X') // diagonal
    {
        DrawBoard();
        Console.WriteLine("You Win");
        isRunning = false;
    }
    else if (board[0] == 'O' && board[1] == 'O' && board[2] == 'O') // O
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[3] == 'O' && board[4] == 'O' && board[5] == 'O')
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[6] == 'O' && board[7] == 'O' && board[8] == 'O')
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[0] == 'O' && board[3] == 'O' && board[6] == 'O')
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[1] == 'O' && board[4] == 'O' && board[7] == 'O')
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[2] == 'O' && board[5] == 'O' && board[8] == 'O')
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[0] == 'O' && board[4] == 'O' && board[8] == 'O') // diagonal
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
    else if (board[2] == 'O' && board[4] == 'O' && board[6] == 'O') // diagonal
    {
        DrawBoard();
        Console.WriteLine("Computer Win");
        isRunning = false;
    }
}

void Quit()
{
    int quit;
    quit = Convert.ToInt32(Console.ReadLine());

    if (quit == 0)
    {
        isRunning = false;
    }
    else if (quit == 1)
    {
        isPlayerTurn = false;
    }
}