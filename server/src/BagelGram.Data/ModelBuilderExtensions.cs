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
            var sourceCaptionData = new List<(string source, string caption)>() {
                ($"{uploadDir}2019-11-19-at-5.17.46.png", "Probably almost Bagel's first day home"),
                ($"{uploadDir}2019-11-19-at-5.18.30.png", "Chew toy on the head"),
                ($"{uploadDir}2019-11-19-at-5.19.01.png", "Smushed head dog"),
                ($"{uploadDir}2019-11-19-at-5.19.40.png", "First lazy sit captured"),
                ($"{uploadDir}2019-11-19-at-5.20.02.png", "And onto her second collar"),
                ($"{uploadDir}2019-11-19-at-5.20.28.png", "Frowning head bagel"),
                ($"{uploadDir}2019-11-19-at-5.20.45.png", "World's most forlorn dog"),
                ($"{uploadDir}2019-11-19-at-5.21.00.png", "Needy ass dog"),
                ($"{uploadDir}2019-11-19-at-5.21.26.png", "She used to fit on a chair"),
                ($"{uploadDir}2019-11-19-at-5.21.52.png", "Deer-ear dog")
            };

            var startDate = DateTime.Now.AddDays(sourceCaptionData.Count * -1);

            var imageData = new List<Image>();
            var id = 1;
            sourceCaptionData.ForEach(scd =>
            {
                imageData.Add(new Image
                {
                    Id = id,
                    UserId = 1,
                    Source = scd.source,
                    Caption = scd.caption,
                    Uploaded = startDate
                });
                id++;
                startDate.AddDays(1);
            });

            return imageData.ToArray();
        }
    }
}