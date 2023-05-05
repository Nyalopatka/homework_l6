void Tochka(double b1,double k1,double b2,double k2)
{
 
 double cordinateX = (b2 - b1)/(k1-k2);
 double cordinateY = k1 * cordinateX + b1;
 Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2},k2 = {k2} ->({cordinateX};{cordinateY})");
}
Console.Clear();
Console.Write("введите b1:");
double b1  = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Tochka(b1,k1,b2,k2);



