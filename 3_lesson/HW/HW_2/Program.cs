// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 3D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

double Line3D(float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine(Line3D(3, 6, 8, 2, 1, -7));
Console.WriteLine(Line3D(7, -5, 0, 1, -1, 9));