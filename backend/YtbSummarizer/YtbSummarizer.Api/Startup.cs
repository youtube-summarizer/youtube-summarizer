﻿using Microsoft.AspNetCore.Mvc;
using YtbSummarizer.Api.Installers;

namespace YtbSummarizer.Api;

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public IConfiguration Configuration { get; }

	// This method gets called by the runtime. Use this method to add services to the container.
	public void ConfigureServices(IServiceCollection services)
	{
		services.Configure<ApiBehaviorOptions>(options =>
			options.SuppressModelStateInvalidFilter = true);

		services.AddHttpClient();

		services.InstallDatabase(Configuration);

		services.AddBusinessServices();

		services.AddControllers();

		services.AddEndpointsApiExplorer();
		services.AddSwaggerGen();
	}

	// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
			app.UseDeveloperExceptionPage();
		}

		app.UseCors(x => x
			.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader());

		app.UseRouting();

		app.UseHttpsRedirection();

		app.UseRouting();

		app.UseAuthentication(); //NOTE: This should come before app.UseAuthorization
		app.UseAuthorization();

		app.UseEndpoints(endpoints =>
		{
			endpoints.MapControllers();
			endpoints.MapGet("/", async context =>
			{
				await context.Response.WriteAsync("Welcome to YtbSummarizer API!");
			});
		});
	}
}
