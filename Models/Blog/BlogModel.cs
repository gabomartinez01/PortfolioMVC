using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PortfolioMVC.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

        [Required, StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long"), DataType(DataType.Text)]
        public string Title { get; set; }
        public string Author { get; set; }

        [Required, MinLength(100, ErrorMessage = "Blog posts must be at least 100 characters long"), Display(Name = "Content"), DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
    }
}