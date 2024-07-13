internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("All tasks are done perfectly:)");
    }

    //Amocana 1.
    public static void NickNames()
    {
        string s = Console.ReadLine();
        if (s.Length < 5 || s.Length > 20 || char.IsLower(s[0]))
        {
            throw new ArgumentException("Surname  is not valid!");
        }
        if (s.Contains("adze"))
        {
            string result = s.Remove(s.Length - 3);
            Console.WriteLine(result);
        }
        else if (s.Contains("idze"))
        {
            string result = s.Remove(s.Length - 4);
            char charToAdd = 'o';
            result = result + charToAdd;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(s);
        }
    }
    //Amocana 3.
    public static int Kaladze(int n)
    {
        if (n <= 1 || n >= 23)
        {
            throw new ArgumentException("N is not valid number!");
        }
        List<int> sequence = new();
        int current = 4;
        for (int i = 1; i <= n; i++)
        {
            sequence.Add(current);
            if (current == 34)
            {
                current = 40;
            }
            else if (current == 49)
            {
                current = 54;
            }
            else if (current % 10 == 4 && current >= 54 || current < 40)
            {
                current += 10;
            }
            else
            {
                current++;
            }
        }
        if (sequence.Any(x => x > 99))
        {
            Console.WriteLine(-1);
            return -1;
        }
        int sum = sequence.Sum();
        Console.WriteLine(sum);
        return 0;
    }

    //Amocana 10.
    public static string Sheamokle(string s)
    {
        if (s.Any(char.IsUpper))
        {
            throw new ArgumentException("String contains upper characters!");
        }
        var alphabetDictionary = new Dictionary<int, char>
        {
            { 1, 'A' },
            { 2, 'B' },
            { 3, 'C' },
            { 4, 'D' },
            { 5, 'E' },
            { 6, 'F' },
            { 7, 'G' },
            { 8, 'H' },
            { 9, 'I' },
            { 10, 'J' },
            { 11, 'K' },
            { 12, 'L' },
            { 13, 'M' },
            { 14, 'N' },
            { 15, 'O' },
            { 16, 'P' },
            { 17, 'Q' },
            { 18, 'R' },
            { 19, 'S' },
            { 20, 'T' },
            { 21, 'U' },
            { 22, 'V' },
            { 23, 'W' },
            { 24, 'X' },
            { 25, 'Y' },
            { 26, 'Z' }
        };

        int count = 1;
        char previousChar = s[0];
        string result = "";

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == previousChar)
            {
                count++;
            }
            else
            {
                result += previousChar;
                if (alphabetDictionary.ContainsKey(count))
                {
                    result += alphabetDictionary[count];
                }
                previousChar = s[i];
                count = 1;
            }
        }
        result += previousChar;
        if (alphabetDictionary.ContainsKey(count))
        {
            result += alphabetDictionary[count];
        }
        return result;
    }
    public static string MiigeOriginali(string s)
    {
        var alphabetDictionary = new Dictionary<char, int>
    {
        { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 },
        { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 }, { 'J', 10 },
        { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 },
        { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 },
        { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 },
        { 'Z', 26 }
    };

        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (i + 1 < s.Length && alphabetDictionary.ContainsKey(s[i + 1]))
            {
                int repetitions = alphabetDictionary[s[i + 1]];
                result += new string(currentChar, repetitions);
                i++;
            }
            else
            {
                result += currentChar;
            }
        }
        return result;
    }

    //Amocana 5.
    public static int Football(string[] gundebi)
    {
        var points = gundebi.Select(team =>
        {
            var parts = team.Split(' ');
            var teamName = string.Join("", parts.Take(parts.Length - 1));
            var stringPoints = (parts[parts.Length - 1]);
            if (teamName.Length > 20)
            {
                throw new ArgumentException("Team name should be less than 20 characters!");
            }
            if (!int.TryParse(stringPoints, out int teamPoints))
            {
                throw new ArgumentException("Points format is not valid!");
            }
            if (teamPoints > 100)
            {
                throw new ArgumentException("Points quantity is not valid!");
            }
            return teamPoints;
        }).ToList();
        int maxPoints = points.Max();
        return points.Count(p => p == maxPoints);
    }

    //Amocana 8.
    public static int Roman(string roman)
    {
        foreach (var c in roman)
        {
            if (char.IsLower(c))
            {
                throw new ArgumentException("Roman number is not in correct format!");
            }
        }
        if (roman.Length > 50)
        {
            throw new ArgumentException("Roman number is not valid!");
        }
        int result = 0;
        var romanNumbers = new Dictionary<char, int>
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };
        foreach (var c in roman)
        {
            result += romanNumbers[c];
        }
        return result;
    }

    //Amocana 6.
    public static int Reciepet(int n, int t)
    {
        if (t < 1 || t > 50 || n < 1 || n > 100)
        {
            throw new ArgumentException("One ofe the numbers is not correct!");
        }
        double priceLarebshi = (t * 5);
        double priceTetrebshi = priceLarebshi / 100;
        double overalPrice = n * priceTetrebshi;
        int quantity = (int)overalPrice;
        return quantity;
    }
}
