namespace Laborator1
{
    public abstract class MealyAutomatonAbstract
    {
        protected IFunction ff;
        protected IFunction gg;

        protected MealyAutomatonAbstract(IFunction ff, IFunction gg)
        {
            this.ff = ff;
            this.gg = gg;
        }

        public abstract string f(string state, string input);
        public abstract string g(string state, string input);
        public abstract string Evolution(string initialState, string inputString);
    }
}
