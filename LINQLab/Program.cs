
int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };


//1. Find the Minimum value 

int minResult = nums.Min();
Console.WriteLine($"The minimum value is {minResult}\n");


//2. Find the Maximum value

int maxResult = nums.Max();
Console.WriteLine($"The maximum value is {maxResult}\n");


//3. Find the Maximum value less than 10000

var listFromQuery3 = from item in nums
                     where item < 10000
                     select item;

Console.WriteLine($"The maximum value less than 10,000 is {listFromQuery3.Max()}\n");


//4. Find all the values between 10 and 100

var listFromQuery4 = nums.Where(item => item >= 10 && item <= 100);
Console.WriteLine("Here are the values between 10 and 100:");

foreach (var item in listFromQuery4)
{
    Console.WriteLine(item);
}
Console.WriteLine();


//5. Find all the Values between 100000 and 999999 inclusive

var listFromQuery5 = nums.Where(item => item >= 100000 && item <= 999999);
Console.WriteLine("Here are values between 100,000 and 999,999:");

foreach (var item in listFromQuery5)
{
    Console.WriteLine(item);
}
Console.WriteLine();


//6. Count all the even numbers

var listFromQuery6 = nums.Where(item => item % 2 == 0).Count();

Console.WriteLine($"There are a total of {listFromQuery6} even numbers");