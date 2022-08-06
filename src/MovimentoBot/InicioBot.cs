using System;

namespace MovimentoBot
{
    public static class InicioBot
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com as coordenadas iniciais.");
            Console.Write("X1: ");
            double.TryParse(Console.ReadLine(), out double xStart);
            Console.Write("Y1: ");
            double.TryParse(Console.ReadLine(), out double yStart);
            Console.WriteLine("Entre com as coordenadas finais.");
            Console.Write("X2: ");
            double.TryParse(Console.ReadLine(), out double xEnd);
            Console.Write("Y2: ");
            double.TryParse(Console.ReadLine(), out double yEnd);

            if (IsCheckCoordenatesReachedRecursively(xStart, yStart, xEnd, yEnd))
                Console.WriteLine("Alcançou coordenadas.");
            else
                Console.WriteLine("Não alcançou coordenadas.");

            Console.ReadLine();
        }

        private static bool IsCheckCoordenatesReachedRecursively(double xStart, double yStart, double xEnd, double yEnd)
        {
            try
            {
                if (xStart == 0 && xEnd > 0 || yStart == 0 && yEnd > 0)
                    return false;
                if (xStart > xEnd || yStart > yEnd)
                    return false;
                if (xStart == xEnd && yStart == yEnd)
                    return true;

                return IsCheckCoordenatesReachedRecursively(xStart + yStart, yStart, xEnd, yEnd)
                    || IsCheckCoordenatesReachedRecursively(xStart, yStart + xStart, xEnd, yEnd);
            }
            catch
            {
                return false;
            }
        }
        private static bool IsCheckCoordenatesReached(double xStart, double yStart, double xEnd, double yEnd)
        {
            // Continue se movendo de baixo para cima para alcançar (xStart , yStart) 
            while (xEnd > xStart && yEnd > yStart)
                if (yEnd > xEnd) // o que for maior - mantenha o decremento igual
                    yEnd = yEnd - xEnd;
                else
                    xEnd = xEnd - yEnd;

            // se chegarmos onde xStart == xEnd or yEnd == yStart
            if (xStart == xEnd && yStart == yEnd) return true;
            // yStart < yEnd
            if (xStart == xEnd && yStart < yEnd && (yEnd - yStart) % xStart == 0)
                return true;
            return yStart == yEnd && xStart < xEnd && (xEnd - xStart) % yStart == 0;
        }


    }
}
