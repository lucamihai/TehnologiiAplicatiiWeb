using System;

namespace Laborator3
{
    public class F : functie<DomeniuW, CodomeniuX>
    {
        public CodomeniuX Calcul(DomeniuW intrare)
        {
            switch (intrare)
            {
                case DomeniuW.W1:
                    return CodomeniuX.X1;
                case DomeniuW.W2:
                    return CodomeniuX.X2;
                case DomeniuW.W3:
                    return CodomeniuX.X3;
                default:
                    throw new ArgumentOutOfRangeException(nameof(intrare), intrare, null);
            }
        }
    }
}