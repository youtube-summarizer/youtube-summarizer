using Microsoft.EntityFrameworkCore;
using YtbSummarizer.Models.Entities;

namespace YtbSummarizer.Api.Database;

public class UoW : DbContext, IUoW
{
	public UoW(DbContextOptions<UoW> options) : base(options)
	{
	}

	public virtual DbSet<Video> Videos { get; set; }
}