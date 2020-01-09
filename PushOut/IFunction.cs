namespace ConsoleApp1
{
    public interface IFunction<Td,Tc>
    {
        Tc Calcul(Td intrare);
    }
}