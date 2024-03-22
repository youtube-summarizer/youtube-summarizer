using Microsoft.EntityFrameworkCore;
using YtbSummarizer.Api.Database;
using YtbSummarizer.Api.Interfaces.Services;
using YtbSummarizer.Models.DTOs;
using YtbSummarizer.Models.Entities;

namespace YtbSummarizer.Api.Services;

public class YoutubeVideosService : IYoutubeVideosService
{
	private readonly IUoW _uow;

	public YoutubeVideosService(IUoW uow)
	{
		_uow = uow;
	}

	public async Task<List<Video>> GetAllAsync()
	{
		return await _uow.Videos.ToListAsync();
	}

	public async Task<bool> AddVideoAsync(VideoModel video)
	{
		await _uow.Videos.AddAsync(Video.FromVideoModel(video));

		return await _uow.SaveChangesAsync() > 0;
	}
}