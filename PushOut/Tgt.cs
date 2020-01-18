namespace ConsoleApp1
{
    class Tgt : IFunction<string, string>
    {
        public string Calcul(string intrare)
        {
            var rez = intrare switch
            {
                "f" => "w",
                "g" => "x",
                "h" => "x",
                "i" => "y",
                "j" => "z",
                "k" => "y",
                _ => "0"
            };
            return rez;
        }
    }
}