string[] input = Console.ReadLine().Split(' ');
List<double> data = new List<double>();

for (int i = 0; i < input.Length; i++)
{
    data.Add(double.Parse(input[i]));
}

double sum = 0;
for (int i = 0; i < data.Count; i++)
{
    sum += data[i];
}
double average = sum / data.Count;

data.Sort();
int n = data.Count;
double median;

if (n % 2 == 0)
{
    median = (data[n / 2 - 1] + data[n / 2]) / 2;
}
else
{
    median = data[n / 2];
}

double mode = data[0];
int maxCount = 1;

for (int i = 0; i < data.Count; i++)
{
    int count = 0;
    for (int j = 0; j < data.Count; j++)
    {
        if (data[i] == data[j])
        {
            count++;
        }
    }

    if (count > maxCount)
    {
        maxCount = count;
        mode = data[i];
    }
}

Console.WriteLine("Average: " + average);
Console.WriteLine("Median: " + median);
Console.WriteLine("Mode: " + mode);