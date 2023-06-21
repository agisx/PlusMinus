# [Plus Minus](https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true)

## Problem
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to $10^{-4}$ are acceptable.

Example
arr = [1, 1, 0, -1, -1]

There are $n = 5$ elements, two positive, two negative and one zero. Their ratios are $\frac{2}{5} = 0.400000$, $\frac{2}{5} = 0.400000$ and $\frac{1}{5} = 0.200000$. Results are printed as:
```
0.400000
0.400000
0.200000
```
## Solution
```
static void plusMinus(List<int> arr)
{
    float positif = 0, negatif = 0, zero = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] == 0) zero++;
        else if (arr[i] > 0) positif++;
        else if (arr[i] < 0) negatif++;
    }
    Console.WriteLine(Math.Round(positif/arr.Count, 6));
    Console.WriteLine(Math.Round(negatif/arr.Count, 6));
    Console.WriteLine(Math.Round(zero/arr.Count, 6));
}
```

## 🚀 About Me
I'm a full stack developer and IT enthusiast. Skilled in Programming, Teamwork, Software Development, and Project Management. Strong information technology professional with a Bachelor of Technology - BTech focused in Information Technology from Institut Teknologi Telkom Surabaya.




## Authors

- [@me](https://github.com/agisx)
