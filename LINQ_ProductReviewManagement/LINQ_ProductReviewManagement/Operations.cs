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
    }
}
