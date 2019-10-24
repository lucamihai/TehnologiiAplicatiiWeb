using System;

namespace Laborator1
{
    public class StateMachine : IFunction
    {
        public string Process(string state, string input)
        {
            switch (state)
            {
                case "1":
                {
                    return "2";
                }

                case "2":
                {
                    return ((byte)input[0] - (byte)'a' + 3).ToString();
                }

                case "3":
                {
                    return ((byte)input[0] - (byte)'a' + Convert.ToInt32(state)).ToString();
                }

                case "4":
                {
                    return ((byte)input[0] - (byte)'b' + Convert.ToInt32(state)).ToString();
                }

                case "5":
                {
                    throw new ArgumentOutOfRangeException();
                }

                default:
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
