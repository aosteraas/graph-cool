using System;
using System.Collections.Generic;
using BagelGram.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace BagelGram.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var imageData = GenerateImageData();

            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Id = 1,
                    UserName = "bagel",
                    BirthDate = new DateTime(2018, 9, 5)
                });

            modelBuilder.Entity<Image>()
                .HasData(imageData);
        }

        private static Image[] GenerateImageData()
        {
            const string uploadDir = "/uploads/";
            var sources = new List<string>() {
                $"{uploadDir}2019-11-19-at-5.17.46.png",
                $"{uploadDir}2019-11-19-at-5.18.30.png",
                $"{uploadDir}2019-11-19-at-5.19.01.png",
                $"{uploadDir}2019-11-19-at-5.19.40.png",
                $"{uploadDir}2019-11-19-at-5.20.02.png",
                $"{uploadDir}2019-11-19-at-5.20.28.png",
                $"{uploadDir}2019-11-19-at-5.20.45.png",
                $"{uploadDir}2019-11-19-at-5.21.00.png",
                $"{uploadDir}2019-11-19-at-5.21.26.png",
                $"{uploadDir}2019-11-19-at-5.21.52.png"
            };

            var startDate = DateTime.Now.AddDays(sources.Count * -1);

            var imageData = new List<Image>();
            var id = 1;
            sources.ForEach(source =>
            {
                imageData.Add(new Image
                {
                    Id = id,
                    UserId = 1,
                    Source = source,
                    Uploaded = startDate
                });
                id++;
                startDate.AddDays(1);
            });

            return imageData.ToArray();
        }
    }

}