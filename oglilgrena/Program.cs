//Скрипников 17 вар 3.1
var k = double.Parse(Console.ReadLine());

double sum = 0;
for (var i = -3; i < k; i++)
{

    if (i == 5) continue;

    double mult = 1;
    for (var n = i; n < 2 * k; n++)
    {
        if (n == 2 || n == -4) continue;

        mult *= (Math.Pow(n, 3) - 8) / (n + 4);
    }

    sum += Math.Pow(-1, i) / Math.Pow(i - 5, 2);
}

Console.WriteLine($"W = {sum}");