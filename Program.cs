using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static LINQ.ListGenerators;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  - Element Operators
            #region Q1
            //var result = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result); 
            #endregion
            #region Q2
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice>1000);
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p % 2 == 1).Count();
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = CustomerList.Select(c => new {c.CustomerName,OrderCount=c.Orders.Count()}).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var items = ProductList.GroupBy(c => c.Category).Select(c => new {c.Key,counter=c.Count()}).ToList();
            //foreach (var item in items)
            //{ Console.WriteLine(item); } 
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Sum(x => x);
            //Console.WriteLine(result);
            #endregion
            #region Q5
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary.Sum(d => d.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q6
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary.Max(d => d.Length);
            //Console.WriteLine(result);



            #endregion
            #region Q7
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary.Min(d => d.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q8
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary.Average(d => d.Length);
            //Console.WriteLine(result);
            #endregion
            #region Q9
            //var result = ProductList.GroupBy(c => c.Category).Select(y => new {category=y.Key,total=y.Sum(c=>c.UnitsInStock)}).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q10
            //var result = ProductList.GroupBy(c => c.Category).Select(y => new { category = y.Key, Cheapestprice = y.Min(c => c.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q11
            //var result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestProducts = g
            //            .Let(items => new
            //            {
            //                MinPrice = items.Min(p => p.UnitPrice)
            //            })
            //            .Let(minInfo => items
            //                .Where(p => p.UnitPrice == minInfo.MinPrice)
            //                .ToList()
            //            )
            //    })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion
            #region Q12
            //var result = ProductList.GroupBy(p => p.Category).Select(p => new { category = p.Key, maxprice = p.Max(c => c.UnitPrice) }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"category{item.category},Maxprice{item.maxprice}");
            //}
            #endregion
            #region Q13
            //var result = ProductList.GroupBy(p => p.Category).Select(categoryinfo => new { category = categoryinfo.Key, MostExpensive = categoryinfo.Where(cat => cat.UnitPrice == categoryinfo.Max(s => s.UnitPrice)) });
            //foreach (var item in result)
            //{
            //    foreach(var items in item.MostExpensive)
            //    {
            //        Console.WriteLine($"{items.ProductName},{items.UnitPrice}");
            //    }
            //}
            #endregion
            #region Q14
            //var result = ProductList.GroupBy(p => p.Category).Select(categoryinfo => new { category = categoryinfo.Key, AVGExpensive = categoryinfo.Where(cat => cat.UnitPrice == categoryinfo.Max(s => s.UnitPrice)) });
            //foreach (var item in result)
            //{
            //    foreach(var items in item.MostExpensive)
            //    {
            //        Console.WriteLine($"{items.ProductName},{items.UnitPrice}");
            //    }
            //}
            #endregion
            #endregion
            #region LINQ - Set Operators
            #region Q1
            //var result = ProductList.Select(p => p.Category).Distinct().ToList();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);

            //var uniqueFirstLetters = productFirstLetters.Concat(customerFirstLetters)
            //                                           .Distinct()
            //                                           .OrderBy(letter => letter);

            //Console.WriteLine("Unique first letters:");
            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}


            #endregion
            #region Q3
            //var Common = ProductList.Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c=>c.CustomerName[0])).OrderBy(letter=>letter);
            //foreach (var item in Common)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region q4
            //var Common = ProductList.Select(p => p.ProductName[0])
            //    .Except(CustomerList.Select(c => c.CustomerName[0])).OrderBy(letter => letter);
            //foreach (var item in Common)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q5
            //var plastcharachter = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName);
            //var clastcharachter = CustomerList.Select(p => p.CustomerName.Length >= 3 ? p.CustomerName.Substring(p.CustomerName.Length - 3) : p.CustomerName);
            //var con=plastcharachter.Concat(clastcharachter).ToList();
            //foreach (var c in con)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion
            #endregion
            #region LINQ - Partitioning Operators
            #region Q1
            //var result = CustomerList.Where(c=>c.Country=="Washington").Select(c=>c.Orders).Take(3).ToList();
            #endregion
            #region Q2
            //var result = CustomerList.Where(c=>c.Country=="Washington").Select(c=>c.Orders).Skip(2).ToList();
            #endregion
            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((numbers, Index)=>numbers>=Index);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(numbers => numbers %3!=0).ToList();
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var RESULT = numbers.SkipWhile((numbers, index) => numbers < index));
            #endregion
            #endregion
        }
    }
}