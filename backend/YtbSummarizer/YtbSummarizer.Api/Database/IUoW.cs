using Microsoft.EntityFrameworkCore;
using YtbSummarizer.Models.Entities;

namespace YtbSummarizer.Api.Database;

public interface IUoW : IDisposable
{
	DbSet<Video> Videos { get; set; }

	Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess = true, CancellationToken cancellationToken = default);
	int SaveChanges();
}