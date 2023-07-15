var numbers = new List<double> { 4d, 5d, 10.4d, 12d, 0.5d, 20d };
//find the sum
var sum = numbers.Sum(c => c);
Console.WriteLine("Sum :");
Console.WriteLine(sum);
//find Average
Console.WriteLine("Average :");
var avg=numbers.Average(c => c);
Console.WriteLine(avg);
//total number of items
Console.WriteLine("Total number of items:");
var total = numbers.Count();
Console.WriteLine(total);