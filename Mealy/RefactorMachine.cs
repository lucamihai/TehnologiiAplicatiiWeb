namespace Mealy
{
    public class RefactorMachine : IFunction
    {
        public string Process(string state, string input)
        {
            return input.ToUpper();
        }
    }
}
