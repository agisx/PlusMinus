// See https://aka.ms/new-console-template for more information
//List<int> a = Console.ReadLine().Trim().Split(' ').ToList().Select(tempStr => Convert.ToInt32(tempStr)).ToList();
//List<int> b = Console.ReadLine().Trim().Split(' ').ToList().Select(tempStr => Convert.ToInt32(tempStr)).ToList();

void plusMinus(List<int> arr)
{
    float positif = 0, negatif = 0, zero = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] == 0) zero++;
        else if (arr[i] > 0) positif++;
        else if (arr[i] < 0) negatif++;
    }
    Console.WriteLine(Math.Round(positif/arr.Count, arr.Count));
    Console.WriteLine(Math.Round(negatif/arr.Count, arr.Count));
    Console.WriteLine(Math.Round(zero/arr.Count, arr.Count));
}
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

plusMinus(arr);