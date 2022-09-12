﻿using System;

namespace LINQ_ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review Management");
            List<ProductReview> reviewList = new List<ProductReview>();
            reviewList.Add(new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 1, Rating = 5, Review = "Best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 1, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 2, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 2, Rating = 5, Review = "Best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 2, Rating = 5, Review = "Best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 2, Rating = 5, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 3, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 3, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 3, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 3, Rating = 2, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 4, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 5, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 6, Rating = 2, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 16, UserId = 6, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 17, UserId = 7, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 7, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 7, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 8, Rating = 3, Review = "Average", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 8, Rating = 2, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 8, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 9, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 9, Rating = 5, Review = "Best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 9, Rating = 5, Review = "Best", IsLike = true });
            foreach (var item in reviewList)
            {
                Console.WriteLine(item.ProductId + "\t" + item.UserId + "\t" + item.Rating + "\t" + item.Review + "\t" + item.IsLike);
                Console.WriteLine(" ");
            }
        }
    }
}