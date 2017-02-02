using System;
using System.Text;

namespace AddingRows
{
    class Action
    {
        private double _value1;
        private double _value2;

        public bool Method(string text)
        {
            Console.OutputEncoding = Encoding.UTF7;
            string[] afterSeparStrings = text.Split(new char[] {'+', '-', '*', '/', ' '},
                StringSplitOptions.RemoveEmptyEntries);

            if (afterSeparStrings.Length != 2)
            {
                ShowInformation($"Строка содержит больше двух операндов: {text}");
                Console.ReadLine();

                return false;
            }

            if (Double.TryParse(afterSeparStrings[0], out _value1))
            {
                if (Double.TryParse(afterSeparStrings[1], out _value2))
                {
                    afterSeparStrings = text.Split(new char[] {' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}, 
                        StringSplitOptions.RemoveEmptyEntries);
                    if (afterSeparStrings.Length != 1)
                    {
                        ShowInformation("");
                        return false;
                    }

                    double sum = 0;
                    switch (afterSeparStrings[0])
                    {
                        case ("+"):
                            sum = _value1 + _value2;
                            break;
                        case ("-"):
                            sum = _value1 - _value2;
                            break;
                        case ("*"):
                            sum = _value1 * _value2;
                            break;
                        case ("/"):
                            sum = _value1 / _value2;
                            break;
                    }
                    ShowInformation($"Результат: {sum}");
                    Console.ReadLine();
                    return true;
                }
            }

            ShowInformation($"Не верный формат: {text}");
            Console.ReadLine();
            return false;
        }

        public void ShowInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}
