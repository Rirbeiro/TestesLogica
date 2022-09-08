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

            if (IsCheckCoordenatesReached(xStart, yStart, xEnd, yEnd))
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

        private static bool? RulesCheckIsReached(double xStart, double yStart, double xEnd, double yEnd)
        {
            if (xStart == 0 && xEnd > 0 || yStart == 0 && yEnd > 0)
                return false;
            if (xStart > xEnd || yStart > yEnd)
                return false;
            if (xStart == xEnd && yStart == yEnd)
                return true;

            return null;
        }

        private static bool IsCheckCoordenatesReached(double xStart, double yStart, double xEnd, double yEnd)
        {
            // Move de cima para baixo, até deixar xEnd = xStart ou yEnd = yStart, fazendo a decomposição das coordenadas finais
            while (xEnd > xStart && yEnd > yStart)
                if (yEnd > xEnd)
                    yEnd = yEnd - xEnd; //subtraí yEnd até encontrar yStart
                else
                    xEnd = xEnd - yEnd; //subtraí xEnd até encontrar xStart

            if (xStart == xEnd && yStart == yEnd) return true;
            if (yStart > yEnd || xStart > xEnd) return false;

            if (xStart == xEnd && (yEnd - yStart) % xStart == 0) //Verifica se as coordenadas X são iguais e faz o cálculo para verificar Yinicial  será alcançado 
                return true;

            return yStart == yEnd && (xEnd - xStart) % yStart == 0; //Verifica se as coordenadas Y são iguais e faz o cálculo para verificar Xinicial  será alcançado 
        }


    }
}
