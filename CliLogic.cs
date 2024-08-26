using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKy_SD2_RPN
{
    public static class CliLogic
    {

        public static void MainLoop()
        {
            String userInput = "";
            Int32 previousResult = 0;
            Int32 result = 0;
            Int32 operand = 0;
            Int32 inputInt = 0;
            bool errorFlag = false;
            do
            {
                Console.WriteLine("Enter an Integer and an Operator, or Enter an Expression or 'exit' to quit: ");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "exit") break;
                
                List<String> operators = new List<String> { "+", "-", "*", "/", "=" };
                foreach (var op in operators) userInput = userInput.Replace(op, " " + op + " ");

                List<String> words = userInput.Split("", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).ToList();
                errorFlag = false;
                foreach (var word in words)
                {
                    if (errorFlag) break;
                    if (Int32.TryParse(word, out inputInt))
                    {
                        operand = inputInt;
                    }
                    else
                    {
                        switch (word)
                        {
                            case "+":
                                result += operand;
                                break;
                            case "-":
                                result -= operand;
                                break;
                            case "*":
                                result *= operand;
                                break;
                            case "/":
                                result /= operand;
                                break;
                            case "=":
                                result = previousResult;
                                break;
                            default:
                                errorFlag = true;
                                break;
                        }
                        Console.WriteLine($"{(word != "=" ? previousResult : "_")} {operand} {word} := {result}");
                        previousResult = result;
                        if (errorFlag) Console.WriteLine("Invalid Syntax or Operator: " + word);
                    }

                }

            } while (true);
        }
    }
}
