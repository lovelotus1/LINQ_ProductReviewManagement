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
    }
}
