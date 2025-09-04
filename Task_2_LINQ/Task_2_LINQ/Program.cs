namespace Task_2_LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ProductList = ListGenerator.ProductList;
            var CustomerList = ListGenerator.CustomerList;
            string[] words = File.ReadAllLines("dictionary_english.txt");

            #region LINQ - Element Operators

            #region 1

            //Get first Product out of Stock
            var result1 = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result1);

            #endregion 1

            #region 2

            //Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var result2 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result2);

            #endregion 2

            #region 3

            //Retrieve the second number greater than 5
            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result3 = Arr1.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine(result3);

            #endregion 3

            #endregion LINQ - Element Operators

            #region LINQ - Aggregate Operators

            #region 1

            //Uses Count to get the number of odd numbers in the array
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result4 = Arr2.Count(a => a % 2 != 0);
            //Console.WriteLine(result4);

            #endregion 1

            #region 2

            //Return a list of customers and how many orders each has.
            var result5 = CustomerList.Select(c => new
            {
                c.CustomerID,
                OrderCount = c.Orders.Count()
            });
            //foreach (var customer in result5)
            //{
            //    Console.WriteLine($"CustomerID: {customer.CustomerID}, OrderCount: {customer.OrderCount}");
            //}

            #endregion 2

            #region 3

            //Return a list of categories and how many products each has.
            var result6 = ProductList.Select(p => new
            {
                p.Category,
                ProductCount = ProductList.Count(p2 => p2.Category == p.Category)
            });
            //foreach (var category in result6.Distinct())
            //{
            //    Console.WriteLine($"Category: {category.Category}, ProductCount: {category.ProductCount}");
            //};

            #endregion 3

            #region 4

            // Get the total of the numbers in an array.
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result7 = Arr3.Sum(n => n);
            //Console.WriteLine(result7);

            #endregion 4

            #region 5

            //Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            var result8 = words.Sum(w => w.Length);
            //Console.WriteLine($"Total characters = {result8}");

            #endregion 5

            #region 6

            //Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            var result9 = words.Min(w => w.Length);
            //Console.WriteLine(result9);

            #endregion 6

            #region 7

            // Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            var result10 = words.Max(w => w.Length);
            //Console.WriteLine(result10);

            #endregion 7

            #region 8

            // Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            var result11 = words.Average(w => w.Length);
            //Console.WriteLine(result11);

            #endregion 8

            #region 9

            // Get the total units in stock for each product category.

            var result12 = ProductList.GroupBy(c => c.Category).Select(u => new
            {
                Category = u.Key,
                TotalUnitsInStock = u.Sum(p => p.UnitsInStock),
            });

            //foreach (var category in result12)
            //{
            //    Console.WriteLine($"Category: {category.Category}, TotalUnitsInStock: {category.TotalUnitsInStock}");
            //}

            #endregion 9

            #region 10

            // Get the cheapest price among each category's products

            var result13 = ProductList.GroupBy(c => c.Category).Select(u => new
            {
                Category = u.Key,
                CheapestPrice = u.Min(p => p.UnitPrice),
            });
            //foreach (var category in result13)
            //{
            //    Console.WriteLine($"Category: {category.Category}, CheapestPrice: {category.CheapestPrice}");
            //}

            #endregion 10

            #region 11

            //Get the products with the cheapest price in each category(Use Let)
            var result14 = from p in ProductList
                           let cheapestPrice = ProductList.Where(p2 => p2.Category == p.Category)
                           .Min(p2 => p2.UnitPrice)
                           where p.UnitPrice == cheapestPrice
                           select new
                           {
                               p.Category,
                               p.ProductName,
                               p.UnitPrice
                           };
            //foreach (var product in result14)
            //{
            //    Console.WriteLine($"Category: {product.Category}, ProductName: {product.ProductName}, UnitPrice: {product.UnitPrice}");
            //}

            #endregion 11

            #region 12

            // Get the most expensive price among each category's products.
            var result15 = ProductList.GroupBy(c => c.Category).Select(e => new
            {
                Category = e.Key,
                ExpensiveProduct = e.Max(p => p.UnitPrice)
            });
            //foreach (var category in result15)
            //{
            //    Console.WriteLine($"Category: {category.Category}, MostExpensivePrice: {category.ExpensiveProduct}");
            //}

            #endregion 12

            Console.WriteLine("______________________________________");

            #region 13

            // Get the products with the most expensive price in each category
            var result16 = from p in ProductList
                           let mostExpensivePrice = ProductList.Where(p2 => p2.Category == p.Category).Max(p2 => p2.UnitPrice)
                           where p.UnitPrice == mostExpensivePrice
                           select new
                           {
                               p.Category,
                               p.ProductName,
                               p.ProductID,
                               p.UnitPrice
                           };
            //foreach (var category in result16)
            //{
            //    Console.WriteLine($"Category: {category.Category}, ProductID: {category.ProductID}, ProductName: {category.ProductName}, MostExpensivePrice: {category.UnitPrice}");
            //}

            #endregion 13

            #region 14

            //. Get the average price of each category's products.

            var result17 = ProductList.GroupBy(c => c.Category).Select(avg => new
            {
                Category = avg.Key,
                AvragePrice = avg.Average(p => p.UnitPrice)
            });
            //foreach (var category in result17)
            //{
            //    Console.WriteLine($"Category: {category.Category}, AvragePrice: {category.AvragePrice}");
            //}

            #endregion 14

            #endregion LINQ - Aggregate Operators

            #region LINQ - Set Operators

            #region 1

            // Find the unique Category names from Product List
            var result18 = ProductList.Select(p => p.Category).Distinct();
            //foreach (var c in result18)
            //    Console.WriteLine(c);

            #endregion 1

            #region 2

            // Produce a Sequence containing the unique first letter from both product and customer names.
            var result19 = ProductList.Select(p => p.ProductName[0])
                    .Union(CustomerList.Select(c => c.CustomerName[0]))
                    .OrderBy(chars => chars);

            //foreach (var chars in result19)
            //    Console.WriteLine(chars);

            #endregion 2

            #region 3

            // Create one sequence that contains the common first letter from both product and customer names.
            var result20 = ProductList.Select(p => p.ProductName[0])
                    .Intersect(CustomerList.Select(c => c.CustomerName[0]))
                    .OrderBy(c => c);
            //foreach (var chars in result20)
            //    Console.WriteLine(chars);

            #endregion 3

            #region 4

            // Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            var result21 = ProductList.Select(p => p.ProductName[0])
                            .Except(CustomerList.Select(c => c.CustomerName[0]))
                            .OrderBy(c => c);
            //foreach (var chars in result21)
            //    Console.WriteLine(chars);

            #endregion 4

            #region 5

            //Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            var result22 = CustomerList.Select(c => string.Concat(c.CustomerName.TakeLast(3)))
                                     .Concat(ProductList.Select(p => string.Concat(p.ProductName.TakeLast(3))));

            //foreach (var str in result22)
            //    Console.WriteLine(str);

            #endregion 5

            #endregion LINQ - Set Operators

            #region LINQ - Quantifiers

            #region 1

            // Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            var result23 = words.Any(w => w.Contains("ei"));
            //Console.WriteLine(result23);

            #endregion 1

            #region 2

            // Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var result24 = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0))
                         .Select(g => new
                         {
                             category = g.Key,
                             products = g.ToList()
                         });
            //foreach (var g in result24)
            //{
            //    Console.WriteLine($"Category: {g.category}");
            //    foreach (var p in g.products)
            //        Console.WriteLine($"prduct: {p.ProductName}, units in stock: {p.UnitsInStock}");
            //}

            #endregion 2

            #region 3

            //Return a grouped list of products only for categories that have all of their products in stock.

            var result25 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0))
                                        .Select(g => new
                                        {
                                            category = g.Key,
                                            products = g.ToList()
                                        });

            //foreach (var g in result25)
            //{
            //    Console.WriteLine($"Category: {g.category}");
            //    foreach (var p in g.products)
            //    {
            //        Console.WriteLine($"prduct: {p.ProductName}, units in stock: {p.UnitsInStock}");
            //    }
            //}

            #endregion 3

            #endregion LINQ - Quantifiers

            #region LINQ – Grouping Operators

            #region 1

            //Use group by to partition a list of numbers by their remainder when divided by 5

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result26 = from n in numbers
                           group n by n % 5 into g
                           select g;

            //foreach (var g in result26)
            //{
            //    Console.WriteLine($"Numbers with remainder of {g.Key} when divided by 5:");
            //    foreach (var num in g)
            //    {
            //        Console.WriteLine($"{num}");
            //    }
            //}

            #endregion 1

            #region 2

            //Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            var result27 = words.GroupBy(w => w[0]).OrderBy(g => g.Key);

            //foreach (var g in result27)
            //{
            //    Console.Write($"Words with {g.Key} ");
            //    Console.WriteLine("{");
            //    for (int i = 0; i < Math.Min(5, g.Count()); i++)
            //    {
            //        Console.WriteLine($" {i} : {g.ElementAt(i)}");
            //    }
            //   Console.WriteLine("   }");
            //}

            #endregion 2

            #region 3

            //Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            string[] Arr4 = { "from", "salt", "earn", "last", "near", "form" };

            var result28 = Arr4.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

            //foreach (var g in result28)
            //{
            //    Console.WriteLine("----------");
            //    foreach (var word in g)
            //    {
            //        Console.WriteLine($"  {word}");
            //    }
            //}

            #endregion 3

            #endregion LINQ – Grouping Operators
        }
    }
}