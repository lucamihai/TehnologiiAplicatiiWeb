namespace ConsoleApp1
{
    class Src : IFunction<string, string>
    {
        public string Calcul(string intrare)
        {
            var rez = intrare switch
            {
                "f" => "v",
                "g" => "w",
                "h" => "w",
                "i" => "y",
                "j" => "y",
                "k" => "z",
                _ => "0"
            };
            return rez;
        }
    }
}