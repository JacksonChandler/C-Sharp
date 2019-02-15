using System;

namespace Override
{
    public class TextInput
    {
        string value;
        public void Add(char c)
        {
            value += c;
        }

        public string GetValue()
        {

            return value.ToString();
        }
    }

    public class NumericInput : TextInput
    {
        string value;
        public new void Add(char c)
        {
            if (char.IsDigit(c))
            {
                value += c;
            }
        }
    }

    public class UserInput
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadKey();
        }
    }
}
