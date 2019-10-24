using System;

namespace Laborator3
{
    public class G : functie<DomeniuW, CodomeniuY>
    {
        public CodomeniuY Calcul(DomeniuW intrare)
        {
            switch (intrare)
            {
                case DomeniuW.W1:
                    return CodomeniuY.Y1;
                case DomeniuW.W2:
                case DomeniuW.W3:
                    return CodomeniuY.Y2;
                default:
                    throw new ArgumentOutOfRangeException(nameof(intrare), intrare, null);
            }
        }
    }
}