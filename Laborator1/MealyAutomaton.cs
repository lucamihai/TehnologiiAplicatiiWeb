using System;

namespace Laborator1
{
    public class MealyAutomaton : MealyAutomatonAbstract
    {
        public MealyAutomaton(IFunction ff, IFunction gg) : base(ff, gg)
        {
        }

        public override string f(string state, string input)
        {
            return ff.Process(state, input);
        }

        public override string g(string state, string input)
        {
            return gg.Process(state, input);
        }

        public override string Evolution(string initialState, string inputString)
        {
            var finalStuff = string.Empty;
            var currentState = initialState;
            if (initialState.Equals("5"))
            {
                throw new ArgumentException();
            }

            while (!currentState.Equals("5"))
            {
                if (inputString.Length == 0)
                {
                    throw new IndexOutOfRangeException();
                }

                var currentChar = inputString[0];
                inputString = inputString.Substring(1);
                var nextStep = f(currentState, currentChar.ToString());
                var refactoredInput = g(currentState, currentChar.ToString());

                finalStuff += $"({currentState}, {currentChar}, {nextStep}, {refactoredInput}){Environment.NewLine}";
                currentState = nextStep;
            }

            return finalStuff;
        }
    }
}
