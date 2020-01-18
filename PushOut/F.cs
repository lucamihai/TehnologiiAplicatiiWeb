namespace ConsoleApp1
{
    public class F : IFunction<string, string>
    {
        public string Calcul(string intrare)
        {
            var rez = intrare switch
            {
                "W1" => "X1",
                "W2" => "X2",
                "W3" => "X3",
                "W4" => "X3",
                _ => "0"
            };

            return rez;
        }
    }
}