using System;
using System.Collections.Generic;

namespace c_sharp_linq
{
    partial class Program
    {
        static void Main()
        {
            var productTypes = ProductStore.GetProductTypes();
            var products = ProductStore.GetProducts();

            #region Display Data
            //ProductStore.ShowDummyData<string>(productTypes, "Product Types");
            //ProductStore.ShowDummyData<Product>(products, "\nProducts");
            #endregion

            #region Simple Queries

            //DisplayResult("Simple Queries", QueryManager.ExecuteOrderByClause(products));

            //DisplayResult("Simple Queries", QueryManager.ExecuteOrderByClause(products));

            //DisplayResult("Simple Queries", QueryManager.ExecuteWhereAndOrderByClause(products));

            //DisplayResult("Simple Queries", QueryManager.ExecuteThenByClause(products));

            //QueryManager.ExecuteGroupByClause();

            //QueryManager.ExecuteToLookUp();

            #endregion

            #region Inner Join
            //DisplayResult("Inner Join", QueryManager.ExecuteInnerJoin(in productTypes, in products));
            #endregion

            #region Group Join            
            //var result = QueryManager.ExecuteGroupJoin(in productTypes, in products);

            //"Group Join.PrintHeader();
            //Console.WriteLine("-------------\n");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}");
            //    foreach(var p in item.Products)
            //    {
            //        Console.WriteLine($"\t{p.Name}");
            //    }
            //}            
            #endregion

            #region Left Outer Join
            //DisplayResult("Left Join", QueryManager.ExecuteLeftJoin(in productTypes, in products));
            #endregion

            #region Select & SelectMany Clauses
            /*
            IList<Student> studentList = StudentData.GetStudentData();
            
            "List of Students".PrintHeader();

            foreach (Student student in studentList)
            {
                Console.WriteLine($"{student.Id}: {student.Name}");
                Console.WriteLine("Skills:");
                foreach (var item in student.Skills)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }
            */

            //QueryManager.ExecuteSelectClause();
            //QueryManager.ExecuteSelectManyClause();

            #endregion

            #region Quantifier Operators
            //QueryManager.ExecuteOperator_All();
            //QueryManager.ExecuteOperator_Any();

            //QueryManager.ExecuteOperator_ContainsUsingCollections();
            //QueryManager.ExecuteOperator_Contains(products);

            #endregion

            #region Aggregation Functions

            //QueryManager.ExecuteAggregateMethod();
            //QueryManager.ExecuteAggregateMethodWithSeed();
            //QueryManager.ExecuteAggregateMethodForAddition();
            //QueryManager.ExecuteAggregateMethodWithResult();

            //QueryManager.ExecuteAverageMethod();

            //QueryManager.ExecuteCountMethod();
            //QueryManager.ExecuteCountMethodWithCondition();

            //QueryManager.ExecuteMinMaxMethod();
            //QueryManager.ExecuteSumMethod();

            #endregion

            #region Element Operators
            //QueryManager.ExecuteElementAt(5);
            //QueryManager.ExecuteElementAt(10);      // index out of range

            //QueryManager.ExecuteFirstOp();
            //QueryManager.ExecuteLastOp();
            //QueryManager.ExecuteSingleOp();
            QueryManager.ExecuteSingleOrDefaultOp();

            #endregion

            Console.ReadLine();
        }


        /// <summary>
        /// Method to display result of the query
        /// </summary>
        /// <param name="result">Result of the LINQ</param>
        private static void DisplayResult(string header, dynamic result)
        {
            header.PrintHeader();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Category} : {item.Name}");
            }
            Console.WriteLine();
        }
    }
}







