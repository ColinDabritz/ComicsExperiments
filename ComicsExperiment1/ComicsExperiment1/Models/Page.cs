using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ComicsExperiment1.Models
{
    public class Page
    {
        [Key]
        public int ID { get; set; }
        public String ImageUri { get; set; }
        public int PageNumber { get; set; }
        public string Title { get; set; }
    }

}
