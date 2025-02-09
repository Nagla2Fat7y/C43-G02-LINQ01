using Day_01_G01;
using static Day_01_G01.ListGenerator;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Var Vs Dynamic
            #region Var
            // var X = "Ahmed";

            //// X = 10;  Not Valid 
            #endregion

            #region Dynamic
            //dynamic X = "Ahmed";

            //X = 10;
            //X = 3.3; 
            #endregion
            #endregion

            #region Extension Method
            //int X = 12345;
            //int Y=IntExtensions.Reverse(X);

            //Y=X.Reverse();

            //Console.WriteLine(Y); 
            #endregion

            #region AnonymousType
            //    var employee = new { Id = 10, Name = "Ali", Salary = 6000 }; //AnonymousType0`3
            //    Console.WriteLine(employee.GetType().Name);

            //    var employee02 = new { Id = 20, Name = "Aya", Salary = 8000 }; //AnonymousType1`3

            //    // employee.Id = 30;  Invalid
            //    employee = new { Id = 30, employee.Name, employee.Salary };
            //    employee = employee with { Id = 30 };  // Syntax Sugar C# 10.0 Feature 

            //    var Product = new { ProductName = "Meat", Price = 120 }; // AnonymousType2`2
            //} 
            #endregion

            #region What is LINQ
            //// LINQ : +40 Extension Methods to the Built-in Interface "IEnumerable<T>"
            ////      : Named as "LINQ Operators" Existed in class "Enumerable"
            ////      : Categorized in 13 Category

            //// Use "LINQ Operators" against Data (Stored in Sequence), Regardless DataBase Provider (SQL Server,MySQL,...)
            //// Sequence: the object from class Implementing "IEnumerable<T>" (Collections: List,Array,...)
            //// 1. Local Sequence
            //// 2. Remote Sequence

            //List<int> Numbers=new List<int>() {1,2,3,4,5,6,7,8,9 };
            //List<int> OddNumbers = Numbers.Where((N)=>N%2==1).ToList(); 
            #endregion

            #region LINQ Syntax

            // List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            #region Fluent Syntax
            //// 1.1 Call "LINQ Operator" as => Static Method through "Enumerable" Class
            //var Odd = Enumerable.Where(Numbers, (N) => N % 2== 1);

            //// 1.1 Call "LINQ Operator" as => Extension Method through "Recommended"
            // Odd = Numbers.Where((N) => N % 2 == 1);

            #endregion

            #region Query Syntax
            /// Starting with Keyword "from"
            /// Introducing Range Variable (N): Represent each and every Element in the input Sequence
            /// Ending with Keyword "select" OR "group by"

            //var odd=from N in Numbers
            //        where N%2==1
            //        select N; 
            #endregion

            #endregion

            #region LINQ Execution Ways
            #region Differed Executio
            //// 1. Differed Execution (Latest Version of Data)
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var Result = Numbers.Where((N) =>N% 2 == 1);
            //Numbers.AddRange(new int[] { 11, 12, 13, });

            //foreach (int item in Result)
            //    Console.WriteLine(item); 
            #endregion

            #region Immediate Execution
            //// 1. Immediate Execution (Element Operators, Casting Operators, Aggregate Operators)
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var Result = Numbers.Where((N) => N % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, });

            //foreach (int item in Result)
            //    Console.WriteLine(item); 
            #endregion
            #endregion

            #region Flteration (Restrection) Operators - Where, OfType
            // First Overload
            //var Result = ProductList.Where((P) => P.UnitsInStock == 0);
            //Result= from P in ProductList
            //        where P.UnitsInStock == 0
            //        select P;

            //var Result = ProductList.Where((P) => P.UnitsInStock == 0 && P.Category=="Meat/Poultry");
            //Result = from P in ProductList
            //         where P.UnitsInStock == 0 && P.Category == "Meat/Poultry"
            //         select P;

            // Second Overload Indexed Where 
            // Valid Only in Fluency Syntax
            // var Result = ProductList.Where((P,I) => I<10 && P.UnitsInStock == 0);

            //OfType
            // var Result = ProductList.OfType<Product02>();
            #endregion

            #region Transformation (Projection) Operators - Select,SelectMany

            #region Select
            //// First Overload
            //var Result = ProductList.Select((P) => P.ProductName);
            //Result= from P in ProductList
            //        select P.ProductName;

            //// Second Overload
            //Result = ProductList.Where((P) => P.UnitsInStock == 0)
            //                   .Select((P, I) => $"{I} : {P.ProductName}");


            ///////////////

            //var Result = ProductList.Where((P) => P.UnitsInStock > 0)
            //                        .Select(P => new
            //                        {
            //                            ID = P.ProductID,
            //                            Name = P.ProductName,
            //                            Price = P.UnitPrice - (P.UnitPrice * .1M)
            //                        });
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0
            //         select new
            //         {
            //             ID = P.ProductID,
            //             Name = P.ProductName,
            //             Price = P.UnitPrice - (P.UnitPrice * .1M)
            //         };

            #endregion

            #region SelectMany
            //var Result01 = CustomerList.SelectMany((C) => C.Orders);
            //var Result02 = CustomerList.SelectMany((C,I) => C.Orders);
           // var Result03 = CustomerList.SelectMany((C) => C.Orders,(C,Order)=>new {C,Order});
            //var Result04 = CustomerList.SelectMany((C,I) => C.Orders, (C, Order) => new { C, Order });

            //Result01 = from C in CustomerList
            //           from O in C.Orders
            //           select O;

            //Result03 = from C in CustomerList
            //           from Order in C.Orders
            //           select new { C, Order }; 
            #endregion

            #endregion

            #region Ordering Operators

            //var Result01 = ProductList.Order();
            //var Result02 = ProductList.OrderDescending();
            //var Result03 = ProductList.OrderBy(P => P.UnitsInStock);
            //var Result04 = ProductList.OrderByDescending(P => P.UnitsInStock);
            //var Result05 = ProductList.OrderBy(P => P.UnitsInStock).ThenBy(P=>P.UnitPrice);
            //var Result06 = ProductList.OrderByDescending(P => P.UnitsInStock).ThenByDescending(P => P.UnitPrice);

            //Result03 = from P in ProductList
            //             orderby P.UnitsInStock
            //             select P;

            //Result04 = from P in ProductList
            //           orderby P.UnitsInStock descending
            //           select P;

            //Result05 = from P in ProductList
            //           orderby P.UnitsInStock,P.UnitPrice
            //           select P;

            //Result06 = from P in ProductList
            //           orderby P.UnitsInStock descending, P.UnitPrice descending
            //           select P;

            //// Fluency Syntax Only
            //var Result07 = ProductList.Where(P => P.UnitsInStock == 0).Reverse();
            #endregion

        }
    }
}
