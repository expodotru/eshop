using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;

namespace EShop.Models
{
    
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyWords { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public int Position { get; set; }
        public int Level { get; set; }
        public int ChildrenCount { get; set; }
    }
}