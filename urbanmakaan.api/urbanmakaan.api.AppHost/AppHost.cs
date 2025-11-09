var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.urbanmakaan_api_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.Build().Run();
