
string input = "29535123p48723487597645723645";

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i]; // Char för nuvarande iteration av loopen.

    if (char.IsDigit(currentChar)) // Om char är en siffra:
    {
        int firstIndex = i; // Så variabeln firstIndex = i
        int lastIndex = input.IndexOf(currentChar, i + 1); // Så börjar variabeln lastIndex leta från i + 1.

        if (lastIndex != -1) // Om lastIndex hittar en dublett av firstIndex så händer detta:
        {
            string inputSubstring = input.Substring(0, lastIndex); // Gör en substring från index 0 till lastIndex.
            Console.WriteLine(inputSubstring); // Skriv ut denna substring.
        }

        if (lastIndex == -1 || char.IsLetter(currentChar))
        {
            continue;
        }
    }
    
    
}


Console.ReadLine();