using Cryptofy.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using YtbSummarizer.Api.Interfaces.Services;
using YtbSummarizer.Models.DTOs;

namespace YtbSummarizer.Api.Controllers;

public class VideosController : BaseController
{
	private readonly IYoutubeVideosService _youtubeVideosService;
	public VideosController(IYoutubeVideosService youtubeVideosService)
	{
		_youtubeVideosService = youtubeVideosService;
	}

	[HttpGet("all")]
	public async Task<IActionResult> GetAll()
	{
		return Ok(await _youtubeVideosService.GetAllAsync());
	}

	[HttpPost("add")]
	public async Task<ActionResult<bool>> AddVideo(VideoModel video)
	{
		return Ok(await _youtubeVideosService.AddVideoAsync(video));
	}
}