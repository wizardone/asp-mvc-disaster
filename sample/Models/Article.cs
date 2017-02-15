using System;
using System.Data.Design;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace sample
{
	public class Article
	{
		public int ID { get; set; }
		public string Title { get; set; }
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
