using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ProductReviewManagement
{
    public class Operations
    {

        DataTable dataTable = new DataTable();
        public void GetTop3Records(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void Display(List<ProductReview> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductId + "\t" + item.UserId + "\t" + item.Rating + "\t" + item.Review + "\t" + item.IsLike);
                Console.WriteLine(" ");
            }
        }
        //Create Method to Retrive Records with rating and Product ID (UC3)
        public void RetriveRecordsWithRatingAndProductID(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).Take(3).ToList();
            Display(result);
        }
        //Create Method to Retrive Records Count of review (UC4)
        public void RetriveRecordsCount(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductID + " " + item.Count);
            }
        }
        //Create Method to Retrive Product ID And Review Of AllRecords (UC5)
        public void RetriveProductIDAndReviewOfAllRecords(List<ProductReview> list)
        {
            var result = list.OrderBy(x => x.ProductId).Select(x => new { productId = x.ProductId, Review = x.Review });
            foreach (var item in result)
            {
                Console.WriteLine(item.productId + " " + item.Review);
            }
        }
        //Create Method to Skip Top 5 (UC6)
        public void SkipTop5Records(List<ProductReview> list)
        {
            var result = list.OrderBy(x => x.Rating).Skip(5).ToList();
            Display(result);
        }
        /// <summary>
        /// UC5 7 UC7 - Retrieves the product id and review.
        /// </summary>
        /// <param name="productReviewList">The product review list.</param>
        public void RetrieveProductIDandReview(List<ProductReview> productReviewList)
        {
            var recordData = productReviewList.Select(r => new { r.ProductId, r.Review });
            foreach (var list in recordData)
            {
                Console.WriteLine("product Id:-" + list.ProductId + " Review :-" + list.Review);
            }
        }
        public void CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Review");
            table.Columns.Add("Rating");
            table.Columns.Add("IsLike");

            table.Rows.Add("1", "1", "Best", "5", "True");
            table.Rows.Add("2", "1", "Good", "4", "True");
            table.Rows.Add("3", "1", "Average", "3", "True");
            table.Rows.Add("4", "2", "Bad", "2", "False");
            table.Rows.Add("5", "2", "Best", "5", "True");
            table.Rows.Add("6", "2", "Good", "4", "True");
            table.Rows.Add("7", "3", "Average", "3", "True");
            table.Rows.Add("8", "3", "Bad", "2", "False");
            table.Rows.Add("9", "3", "Best", "5", "True");
            table.Rows.Add("10", "4", "Good", "4", "True");
            table.Rows.Add("11", "4", "Average", "3", "True");
            table.Rows.Add("12", "4", "Bad", "2", "False");
            table.Rows.Add("13", "5", "Best", "5", "True");
            table.Rows.Add("14", "5", "Good", "4", "True");
            table.Rows.Add("15", "5", "Average", "3", "True");
            table.Rows.Add("16", "6", "Bad", "2", "False");
            table.Rows.Add("17", "6", "Best", "5", "True");
            table.Rows.Add("18", "6", "Good", "4", "True");
            table.Rows.Add("19", "7", "Average", "3", "True");
            table.Rows.Add("20", "7", "Bad", "2", "False");
            table.Rows.Add("21", "7", "Best", "5", "True");
            table.Rows.Add("22", "8", "Good", "4", "True");
            table.Rows.Add("23", "8", "Average", "3", "True");
            table.Rows.Add("24", "9", "Bad", "2", "False");
            table.Rows.Add("25", "9", "Best", "5", "True");
            foreach (DataRow data in table.Rows)
            {
                Console.WriteLine("==================================================================================");
                Console.WriteLine("ProductID: {0}\t UserID: {1}\t Review: {2}\t Rating: {3}\t IsLike: {4}\t", data[0], data[1], data[2], data[3], data[4]);
            }
        }
        //Create Method to create table (UC8)
        public void CreateDataTable(List<ProductReview> list)
        {
            //Adding columns to data table and their type
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));

            //Adding values to datatable from the list
            foreach (var data in list)
            {
                dataTable.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }
            Console.WriteLine("Successfully added values to datatable");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("ProductID: {0}\t UserID: {1}\t Review: {2}\t Rating: {3}\t IsLike: {4}\t", row[0], row[1], row[2], row[3], row[4]);
            }
        }
        //Create Method to Retrive Records for is True (UC9)
        public void RetriveRecordsForIsTrue(List<ProductReview> list)
        {
            CreateDataTable(list);
            var result = from table in dataTable.AsEnumerable() where table.Field<bool>("IsLike") == true select table;
            Console.WriteLine($"ProductId,  UserId,  Rating,  Review,  IsLike");
            foreach (var row in result)
            {
                Console.WriteLine($"{row["ProductId"]},  {row["UserId"]},  {row["Rating"]},  {row["Review"]},  {row["IsLike"]}");
            }
        }
    }
}