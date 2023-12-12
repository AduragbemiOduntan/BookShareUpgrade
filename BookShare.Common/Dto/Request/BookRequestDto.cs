﻿using BookShare.Common.Enum;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShare.Common.Dto.Request
{
    public class BookRequestDto
    {
        [Required(ErrorMessage = "Book name is required")]
        public string BookName { get; set; }
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? BookDescription { get; set; }
        public BookCategory? BookCategory { get; set; }
        [Column(TypeName = "money")]
        public decimal MarketPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? SellingPrice { get; set; }
        public ListingType? ListingType { get; set; }
        public IFormFile ImageUrl { get; set; }
        /*
                [Required(ErrorMessage = "Book name is required")]
                public string BookName{ get; set; }
                [Required(ErrorMessage = "Author name is required")]
                public string Author{ get; set; }

                public string? Publisher { get; set; }
                [Required(ErrorMessage = "Education level is required")]
                public EducationLevel? EducationLevel { get; set; }
                [Required(ErrorMessage = "Book category is required")]
                public BookCategory? BookCategory { get; set; }
                [Required(ErrorMessage = "Subject is required")]
                public Subject Subject { get; set; }
                [Range(0.01, double.MaxValue, ErrorMessage = "Market price must be greater than zero")]
                public decimal MarketPrice { get; set; }
           *//*     [Range(0.01, double.MaxValue, ErrorMessage = "Selling price must be greater than zero")]*//*
                public decimal SellingPrice { get; set; }
                [DataType(DataType.Date), Required(ErrorMessage = "Listed date is required")]
                public BookCondition BookCondition { get; set; }
                [MaxLength(200, ErrorMessage = "Image URL cannot exceed 200 characters")]
                public string? ImageUrl { get; set; }
        *//*        [MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters")]
                public string? ISBN { get; set; }*//*
                [Required(ErrorMessage = "Listing type is required")]
                public ListingType ListingType { get; set; }*/
    }
}
