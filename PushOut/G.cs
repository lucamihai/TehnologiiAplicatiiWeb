namespace ConsoleApp1
{
    public class G : IFunction<string, string>
    {
        public string Calcul(string intrare)
        {
            var rez = intrare switch
            {
                "W1" => "Y1",
                "W2" => "Y2",
                "W3" => "Y1",
                "W4" => "Y2",
                _ => "0"
            };
            return rez;
        }
    }
}