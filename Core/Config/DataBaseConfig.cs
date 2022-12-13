using TWJobs.Core.Data.Contetxs;

namespace TWJobs.Core.Config;

public static class DataBaseConfig
{
    public static void RegisterDatabase(this IServiceCollection services)
    {
        services.AddDbContext<TWJobsDbContext>();
    }
}