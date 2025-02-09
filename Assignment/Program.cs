using Day_01_G01;
using static Day_01_G01.ListGenerator;

namespace Assignment
{
    class CustomComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.ToLower().CompareTo(y.ToLower());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Question01

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //Result= from P in ProductList
            //        where P.UnitsInStock == 0
            //        select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question02

            //var Result = ProductList.Where(P => P.UnitsInStock == 0 && P.UnitPrice > 3.00M);

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0 && P.UnitPrice > 3.00M
            //         select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question03

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((P, I) => I < Arr.Length && P.Length < I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Question01

            //var Result = ProductList.OrderBy(P => P.ProductName);

            //    Result = from P in ProductList
            //             orderby P.ProductName
            //             select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);


            #endregion

            #region Question02

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.Order(new CustomComparer());

            //    Result= from P in Arr
            //            orderby P.ToLower()
            //            select P;


            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question03

            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);

            //Result = from P in ProductList
            //         orderby P.UnitsInStock descending
            //         select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question04

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(P => P.Length).ThenBy(P => P);

            //    Result = from P in Arr
            //             orderby P.Length, P
            //             select P;


            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question05

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = words.OrderBy(P => P.Length).ThenBy(P => P, new CustomComparer());

            //    Result = from P in words
            //             orderby P.Length, P.ToLower()
            //             select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question06

            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //Result = from P in ProductList
            //         orderby P.Category, P.UnitPrice descending
            //         select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question07

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(P => P.Length).ThenByDescending(P => P, new CustomComparer());

            //Result = from P in Arr
            //         orderby P.Length, P.ToLower() descending
            //         select P;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question08

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(P => P[1]=='i').Reverse();

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region Question01

            //var Result = ProductList.Select((P) => P.ProductName);

            //    Result = from P in ProductList
            //             select P.ProductName;

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region Question02

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(C => new { Lower = C.ToLower(), Upper = C.ToUpper() });

            //Result = from C in words
            //         select new { Lower = C.ToLower(), Upper = C.ToUpper() };

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question03

            //var Result = ProductList.Select(P => new
            //                        {
            //                            ID = P.ProductID,
            //                            Name = P.ProductName,
            //                            Price = P.UnitPrice 
            //                        });

            //Result = from P in ProductList
            //         select new
            //         {
            //             ID = P.ProductID,
            //             Name = P.ProductName,
            //             Price = P.UnitPrice
            //         };

            //foreach (var item in Result)
            //    Console.WriteLine(item);


            #endregion

            #region Question04

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((P, I) => P == I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question05

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = numbersA.SelectMany((C) => numbersB, (C,D) => new { C, D }).Where(Result=>Result.C < Result.D);

            //Result =from C in numbersA
            //        from D in numbersB
            //        where C<D
            //        select new { C, D };

            //foreach (var item in Result)
            //    Console.WriteLine($"{item.C} is less than {item.D}");

            #endregion

            #region Question06

            //var Result = CustomerList.SelectMany((C) => C.Orders, (C, order) => new { C, order })
            //                         .Where(Result => Result.order.Total <500.00M);

            //Result = from C in CustomerList
            //         from order in C.Orders
            //         where order.Total < 500.00M
            //         select new { C, order };

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Question07

            //var Result = CustomerList.SelectMany((C) => C.Orders, (C, order) => new { C, order })
            //                         .Where(Result => Result.order.OrderDate.Year <= 1998);

            //Result = from C in CustomerList
            //         from order in C.Orders
            //         where order.OrderDate.Year <= 1998
            //         select new { C, order };

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

        }
    }
}
