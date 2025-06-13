
int[,] a;

a = new int[2, 2];

a[0, 0] = 10;
a[0, 1] = 20;
a[1, 0] = 30;
a[1, 1] = 40;

Console.WriteLine(a[0,0]);
Console.WriteLine(a[0,1]);
Console.WriteLine(a[1,0]);
Console.WriteLine(a[1,1]);

int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };

Console.ReadKey();