string input = "29535123p48723487597645723645";
int firstLetter = input[0];

for (int i = 1; i < input.Length; i++)
{
    if (i == input[0])
    {
        break;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(input[i]);
}

Console.ReadLine();