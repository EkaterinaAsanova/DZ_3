// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double ab = 0;
double [] point1 = new double[3];
double [] point2 = new double[3];

Console.WriteLine("Введите координаты точки А: (в формате x, y, z)");
for (int i=0; i< point1.Length; i++)
point1[i]=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: (в формате x, y, z)");
for (int i=0; i< point2.Length; i++)
point2[i]=Convert.ToDouble(Console.ReadLine());

ab = Math.Sqrt( (Math.Pow ((point1[0]-point2[0]), 2)) + (Math.Pow ((point1[1]-point2[1]),2))+ (Math.Pow ((point1[2]-point2[2]),2)));
Console.WriteLine("Расстояние между точками А и В равно: " +ab); 
