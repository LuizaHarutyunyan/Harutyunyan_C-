
namespace Harutyunyan_C_
{
    internal class Task2
    {
        public Boolean IsBracketSequenceCorrect(string sequence)
        {
            Stack<char> stack = new Stack<char>();
            Boolean isValid = true;
            List<string> errors = new List<string>();
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(' || sequence[i] == '[' || sequence[i] == '{')
                {
                    stack.Push(sequence[i]);
                }
                else if (sequence[i] == ')' || sequence[i] == ']' || sequence[i] == '}')
                {
                    if (stack.Count == 0)
                    {
                        string errorInMiddle = $"Need to open {sequence[i]}";
                        errors.Add(errorInMiddle);
                        isValid = false;
                    }
                    else
                    {
                        char topBracket = stack.Pop();
                        if ((sequence[i] == ')' && topBracket != '(') ||
                       (sequence[i] == ']' && topBracket != '[') ||
                       (sequence[i] == '}' && topBracket != '{'))
                        {                           
                                string errorAtTheEnd = $"Need to chnage {sequence[i]} to close  {topBracket}";
                                errors.Add(errorAtTheEnd);

                            isValid = false;

                        }

                    }
                }

            }

            if(stack.Count > 0)
            {
                foreach (char c in stack)
                {
                    string errorAtTheEnd = $"Need to close {c}";
                    errors.Add(errorAtTheEnd);
                }
            }
            LoggErrorMessages(errors);
            return isValid && stack.Count == 0;
        }
           
        public void LoggErrorMessages(List<string> errors)
        {
            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
            //Need to add Logger here intead of Console print
        }

      
    }
}
