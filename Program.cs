using System;

namespace Exam_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Finish")
                {
                    //ToDo
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string comand = parts[0];

                if (comand == "Replace")    // Replace currChar newChar
                {
                    string currChar = parts[1];
                    string charReplacement = parts[2];

                    if (inputText.Contains(currChar))
                    {
                        inputText = inputText.Replace(currChar, charReplacement);
                        Console.WriteLine(inputText);
                    }
                }
                else if (comand == "Cut") // Cut startIdx endIdx
                {
                    int startIdx = int.Parse(parts[1]);
                    int endIdx = int.Parse(parts[2]);

                    if (startIdx >= 0 && startIdx <= inputText.Length - 1
                        && endIdx >= 0 && endIdx <= inputText.Length - 1)
                    {
                        //string substrToRemove = inputText.Substring(startIdx, endIdx);
                        inputText = inputText.Remove(startIdx, endIdx - startIdx + 1);
                        Console.WriteLine(inputText);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (comand == "Make") // Make uppr/lower case
                {
                    string upperOrLower = parts[1];

                    if (upperOrLower == "Upper")
                    {
                        inputText = inputText.ToUpper();
                    }
                    else // if ( == "Lower")
                    {
                        inputText = inputText.ToLower();
                    }

                    Console.WriteLine(inputText);
                }
                else if (comand == "Check") // Check string
                {
                    string str = parts[1];

                    if (inputText.Contains(str))
                    {
                        Console.WriteLine($"Message contains {str}");
                    }
                    else  //does not contain
                    {
                        Console.WriteLine($"Message doesn't contain {str}");
                    }

                }
                else // if (comand == "Sum") //Sum startIdx endIdx
                {
                    int startIdx = int.Parse(parts[1]);
                    int endIdx = int.Parse(parts[2]);

                    if (startIdx >= 0 && startIdx <= inputText.Length - 1
                        && endIdx >= 0 && endIdx <= inputText.Length - 1)
                    {
                        int sum = 0;
                        string substr = inputText.Substring(startIdx, endIdx);

                        foreach (var letter in substr)
                        {                           
                           sum += letter;                            
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }
    }
}
