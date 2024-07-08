namespace Application
{
    public class Trapecio
    {
        public static double Area(double baseMenor, double baseMayor, double altura)
        {
            return ((baseMayor + baseMenor) / 2) * altura;
        }
    }
}


double baseMenor = 3;
double baseMayor = 5;
double alturaTrapecio = 4;
double alturaPrisma = 10;

double areaTrapecio = Application.Trapecio.Area(baseMenor, baseMayor, alturaTrapecio);
double volumen = Application.PrismaCuadrangular.Volumen(areaTrapecio, alturaPrisma);

Console.WriteLine($"El área de la base de un Prisma Trapecial con bases {baseMenor}cm y {baseMayor}cm y altura de {alturaTrapecio}cm es {areaTrapecio}cm2");
Console.WriteLine($"El volumen de un Prisma Trapecial con un área de la base de {areaTrapecio}cm2 y {alturaPrisma}cm de altura es {volumen}cm3");
