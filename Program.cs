﻿long n = 541;
bool[] b = new bool[n + 1];
for(long i = 2; i*i <= n; i++)
{  
    if ((!b[i]))
    {
        for(long j = 2*i; j <= n; j += i)
        {
            b[j] = true; 
        }
    }
}
for (long i = 2; i <= n; i++)
{
    if (!b[i])
        Console.WriteLine("{0}",i.ToString());
}