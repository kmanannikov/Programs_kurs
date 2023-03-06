int aX, aY, aZ;
int bX, bY, bZ;
double resultDoub;

Console.WriteLine("Поочередно введите координаты точек: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
bZ = Convert.ToInt32(Console.ReadLine());

resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
resultDoub = Math.Sqrt(resultDoub);
resultDoub = Math.Round(resultDoub, 2);
Console.WriteLine($"A({aX},{aY},{aZ}); B({bX},{bY},{bZ}), -> {resultDoub}");
