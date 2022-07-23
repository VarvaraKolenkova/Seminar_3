// See https://aka.ms/new-console-template for more information
void printDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z2 - z1;
    double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
    Console.WriteLine(distance);
}
printDistance(5, 8, 5, 6, 9, 12);