using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using static DemoSession01LINQ.ListGenerator;

namespace Task_1_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region LINQ - Element Operators

            var ProductList = ListGenerator.ProductList;

            #region 1

            //1. Get first Product out of Stock
            var outOfStockItem = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            // Console.WriteLine(outOfStockItem);

            #endregion 1

            #region 2

            //Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var moreThan1000 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            // Console.WriteLine(moreThan1000);

            #endregion 2

            #region 3

            //Retrieve the second number greater than 5
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondNumberGreaterThan5 = Arr.Where(n => n > 5).ElementAt(1);
            // Console.WriteLine(secondNumberGreaterThan5);

            #endregion 3

            #endregion LINQ - Element Operators

            #region LINQ - Aggregate Operators

            #region 1

            //. Uses Count to get the number of odd numbers in the array
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var countOfOddNumbers = Arr2.Count(n => n % 2 != 0);
            // Console.WriteLine(countOfOddNumbers);

            #endregion 1

            #region 2

            //Return a list of customers and how many orders each has.
            var Customerlist = ListGenerator.CustomerList;
            var customerList = Customerlist.Select(c => new
            {
                c.CustomerID,
                OrderCount = c.Orders.Count()
            });
            //foreach (var customer in customerList)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, OrderCount: {customer.OrderCount}");
            //}

            #endregion 2

            #region 3

            //Return a list of categories and how many products each has
            var categoryList = ProductList.Select(p => new
            {
                p.Category,
                ProductCount = ProductList.Count(p2 => p2.Category == p.Category)
            });
            //foreach (var category in categoryList.Distinct())
            //{
            //    Console.WriteLine($"Category: {category.Category}, ProductCount: {category.ProductCount}");
            //};

            #endregion 3

            #region 4

            // Get the total of the numbers in an array.
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var totalOfNumbers = Arr3.Sum();
            //Console.WriteLine(totalOfNumbers);

            #endregion 4

            #region 5 to 8 we don't have the file

            //. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // string[] words = System.IO.File.ReadAllLines("dictionary_english.txt"); we don't have this file
            // 6Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //    8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            #endregion 5 to 8 we don't have the file

            #region 9

            //. Get the total units in stock for each product category.
            var totalUnitsInStockByCategory = ProductList.Select(p => new
            {
                p.Category,
                TotalUnitsInStock = ProductList.Where(p2 => p2.Category == p.Category).Sum(p2 => p2.UnitsInStock)
            });
            //foreach (var category in totalUnitsInStockByCategory.Distinct())
            //{
            //    Console.WriteLine($"Category: {category.Category}, TotalUnitsInStock: {category.TotalUnitsInStock}");
            //}

            #endregion 9

            #region 10

            //Get the cheapest price among each category's products
            var cheapestPriceByCategory = ProductList.Select(p => new
            {
                p.Category,
                CheapestPrice = ProductList.Where(p2 => p2.Category == p.Category).Min(p2 => p2.UnitPrice)
            });
            //foreach (var category in cheapestPriceByCategory.Distinct())
            //{
            //    Console.WriteLine($"Category: {category.Category}, CheapestPrice: {category.CheapestPrice}");
            //}

            #endregion 10

            #region 11

            //Get the products with the cheapest price in each category(Use Let)
            var WithCheapestPriceByCategory = from p in ProductList
                                                      let cheapestPrice = ProductList.Where(p2 => p2.Category == p.Category)
                                                      .Min(p2 => p2.UnitPrice)
                                                      where p.UnitPrice == cheapestPrice
                                                      select new
                                                      {
                                                          p.Category,
                                                          p.ProductName,
                                                          p.UnitPrice
                                                      };
            //foreach (var product in WithCheapestPriceByCategory.Distinct())
            //{
            //    Console.WriteLine($"Category: {product.Category}, ProductName: {product.ProductName}, UnitPrice: {product.UnitPrice}");
            //}

            #endregion 11

            #region 12

            //Get the most expensive price among each category's products.
            var mostExpensivePriceByCategory = ProductList.Select(p => new
            {
                p.Category,
                MostExpensivePrice = ProductList.Where(p2 => p2.Category == p.Category).Max(p2 => p2.UnitPrice)
            });

            #endregion 12

            #region 13

            //Get the products with the most expensive price in each category.
            var WithMostExpensivePriceByCategory = ProductList.Where(p => p.UnitPrice == ProductList.Where(p2 => p2.Category == p.Category).Max(p2 => p2.UnitPrice))
                .Select(p => new
                {
                    p.Category,
                    p.ProductName,
                    p.UnitPrice
                });
            //foreach (var product in WithMostExpensivePriceByCategory.Distinct())
            //{
            //    Console.WriteLine($"Category: {product.Category}, ProductName: {product.ProductName}, UnitPrice: {product.UnitPrice}");
            //}

            #endregion 13

            #region 14

            //Get the average price of each category's products.
            var averagePriceByCategory = ProductList.Select(p => new
            {
                p.Category,
                AveragePrice = ProductList.Where(p2 => p2.Category == p.Category).Average(p2 => p2.UnitPrice)
            });
            //foreach (var category in averagePriceByCategory.Distinct())
            //{
            //    Console.WriteLine($"Category: {category.Category}, AveragePrice: {category.AveragePrice}");
            //}

            #endregion 14
            #endregion LINQ - Aggregate Operators
            #region LINQ - Ordering Operators
            #region 1
            //1. Sort a list of products by name
            var productsSortedByName = ProductList.OrderBy(p => p.ProductName);
            //foreach (var product in productsSortedByName)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            #endregion
            #region 2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var SortedWords = Arr4.OrderBy(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in SortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region 3
            //3. Sort a list of products by units in stock from highest to lowest.
            var SortedByUnitsInStock = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in SortedByUnitsInStock)
            //{
            //    Console.WriteLine($"{product.ProductName}: {product.UnitsInStock}");
            //}

            #endregion
            #region 4
            //Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr5 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var sortedDigits = Arr5.OrderBy(s => s.Length).ThenBy(s => s);
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion
            #region 5
            //. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            string[] Arr6 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWordsByLength = Arr6.OrderBy(s => s.Length).ThenBy(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWordsByLength)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion
            #region 6
            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var productsSortedByCategory = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in productsSortedByCategory)
            //{
            //    Console.WriteLine($"{product.Category}: {product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region 7
            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            string[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWordsByLengthThenByCase = Arr7.OrderBy(s => s.Length).ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWordsByLengthThenByCase)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion
            #region 8
            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr9 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            var reverseSecondLetterI = Arr9.Where(s => s.Length > 1 && s[1] == 'i').Reverse();
            //foreach (var digit in reverseSecondLetterI)
            //{
            //    Console.WriteLine(digit);
            //}


            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1
            //1. Return a sequence of just the names of a list of products.
            var productNames = ProductList.Select(p => p.ProductName);
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region 2
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperAndLower = words.Select(s => new { Upper = s.ToUpper(), Lower = s.ToLower() });
            //foreach (var word in upperAndLower)
            // {
            //     Console.WriteLine($"Uppercase: {word.Upper}, Lowercase: {word.Lower}");
            // }


            #endregion
            #region 3
            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var productProperties = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });
            //foreach (var product in productProperties)
            //{
            //    Console.WriteLine($"ProductName: {product.ProductName}, Category: {product.Category}, Price: {product.Price}");
            //}

            #endregion
            #region 4
            //4. Determine if the value of int in an array matches their position in the array.
            int[] Arr10 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var valueMatchesPosition = Arr10.Select((value, index) => new { Value = value, IsMatch = value == index });
            //foreach (var item in valueMatchesPosition)
            //{
            //    Console.WriteLine($"Value: {item.Value}: {item.IsMatch}");
            //}


            #endregion
            #region 5
            //. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var numberPairs = from a in numbersA
                              from b in numbersB
                              where a < b
                              select new { A = a, B = b };
            //foreach (var pair in numberPairs)
            //{
            //    Console.WriteLine($" {pair.A} is less than {pair.B}");
            //}

            #endregion
            #region 6
            //Select all orders where the order total is less than 500.00.
            var ordersLessThan500 = Customerlist.SelectMany(c => c.Orders).Where(o => o.Total < 500.00M);
            //foreach (var order in ordersLessThan500)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total}");
            //}

            #endregion
            #region 7
            //7. Select all orders where the order was made in 1998 or later.
            var ordersFrom1998O = Customerlist.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var order in ordersFrom1998)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate}");
            //}

            #endregion
            #endregion
        }
    }
}