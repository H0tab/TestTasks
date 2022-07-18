int x = 1;
int y = 2;
int z = 3;

Swap(ref x, ref y, ref z);

Console.WriteLine($"x - {x}, y - {y}, z - {z}"); //x - 2, y - 3, z - 1

void Swap(ref int x, ref int y, ref int z)
{
    (x, y, z) = (y, z, x);
}
