using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputData = "2343-ggh-1233-wtw-0g5k";
        Console.WriteLine($"Our string looks like---> {inputData}");
        StringMethods.ReplaceLettersToStars(inputData);
        StringMethods.CheckIfTheStringContainsTheABC(inputData);
        StringMethods.CheckIfAStringStartingWithA555(inputData);
        StringMethods.CheckIfAStringEndsWithA1a2b(inputData);
        StringMethods.OnlyLowerCaseLettersInFormat(inputData);
        StringMethods.OnlyUpperCaseLettersInFormat(inputData);
        StringMethods.FirstTwoBlocks(inputData);


    }

    class StringMethods()
    {
        public static void FirstTwoBlocks(string inputData)
        {
            string twoBlocks = string.Empty;
            foreach (char c in twoBlocks)
            {
                if (char.IsDigit(c) && twoBlocks.Length < 8)
                {
                    twoBlocks += c;
                }
            }
            Console.WriteLine(twoBlocks);
        }

        public static void ReplaceLettersToStars(string inputData)
        {
            string replaceLettersToStars = string.Empty;
            string[] temp = inputData.Split("-");
            for (int i = 0; i < temp.Length; i++)
            {
                if (int.TryParse(temp[i], out var value))
                {
                    continue;
                }
                else if (temp[i].Length <= 3)
                {
                    temp[i] = "***";
                }
            }
            replaceLettersToStars = string.Join("-", temp);
            Console.WriteLine($"Block letters replaced with stars {replaceLettersToStars}");
        }

        public static void OnlyLowerCaseLettersInFormat(string str)
        {
            string lowerCaseLetters = string.Empty;
            string[] temp2 = str.Split("-");
            for (int i = 0; i < temp2.Length; i++)
            {
                if (int.TryParse(temp2[i], out var val))
                {
                    continue;
                }
                else
                {
                    foreach (char c in temp2[i])
                    {
                        if (char.IsDigit(c))
                        {
                            temp2[i] = temp2[i].Replace(c, ' ');
                        }

                    }
                    temp2[i] = temp2[i].Trim();
                    lowerCaseLetters += temp2[i] + "/";
                }
            }
            lowerCaseLetters = lowerCaseLetters.Replace(' ', '/');
            lowerCaseLetters = lowerCaseLetters.Remove(lowerCaseLetters.Length - 1);
            Console.WriteLine(lowerCaseLetters.ToLower());
        }

        public static void OnlyUpperCaseLettersInFormat(string str)
        {
            string lowerCaseLetters = string.Empty;
            string[] temp2 = str.Split("-");
            for (int i = 0; i < temp2.Length; i++)
            {
                if (int.TryParse(temp2[i], out var val))
                {
                    continue;
                }
                else
                {
                    foreach (char c in temp2[i])
                    {
                        if (char.IsDigit(c))
                        {
                            temp2[i] = temp2[i].Replace(c, ' ');
                        }

                    }
                    temp2[i] = temp2[i].Trim();
                    lowerCaseLetters += temp2[i] + "/";
                }
            }
            lowerCaseLetters = lowerCaseLetters.Replace(' ', '/');
            lowerCaseLetters = lowerCaseLetters.Remove(lowerCaseLetters.Length - 1);
            StringBuilder sb = new StringBuilder(lowerCaseLetters);
            Console.WriteLine(sb.ToString().ToUpper());
        }

        public static void CheckIfTheStringContainsTheABC(string str)
        {
            string temp = str.ToLower();
            bool contains = temp.Contains("abc");
            if (contains)
            {
                Console.WriteLine("String constains ABC or abc");
            }
            else
            {
                Console.WriteLine("String not contains ABC or abc");
            }
        }

        public static void CheckIfAStringStartingWithA555(string str)
        {
            bool startWith = str.StartsWith("555");
            if (startWith)
            {
                Console.WriteLine("String starts with 555");
            }
            else
            {
                Console.WriteLine("String not starts with с 555");
            }
        }
        public static void CheckIfAStringEndsWithA1a2b(string str)
        {
            bool endsWith = str.EndsWith("1a2b");
            if (endsWith)
            {
                Console.WriteLine("String ends on 1a2b");
            }
            else
            {
                Console.WriteLine("String not ends on 1a2b");
            }
        }
    }


}