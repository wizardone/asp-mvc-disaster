using System;
using System.Data.Design;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace sample
{
	public class Article
	{
		[Required]
		public int ID { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Data { get; set; }
	}

	public class ArticleContex : DbContext
	{
		public ArticleContex() : base("Article")
		{
		}
		public virtual DbSet<Article> Articles { get; set; }

	}
}
