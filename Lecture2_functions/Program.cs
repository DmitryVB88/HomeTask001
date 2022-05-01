// int Max(int arg1, int arg2, int arg3);
// {
//     int resalt = arg1;
//     if (arg2 > resalt) resalt = arg2;
//     if (arg3 > resalt) resalt = arg3;
//     return resalt;
// }

int a1 = 12;
int b1 = 14;
int c1 = 23;
int a2 = 24;
int b2 = 30;
int c2 = 40;
int a3 = 388;
int b3 = 29;
int c3 = 2;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
