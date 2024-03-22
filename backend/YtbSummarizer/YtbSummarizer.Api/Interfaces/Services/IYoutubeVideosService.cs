using YtbSummarizer.Models.DTOs;
using YtbSummarizer.Models.Entities;

namespace YtbSummarizer.Api.Interfaces.Services;

public interface IYoutubeVideosService
{
	Task<List<Video>> GetAllAsync();
	Task<bool> AddVideoAsync(VideoModel video);
}