using Microsoft.EntityFrameworkCore;
using TWJobs.Core.Data.Contetxs;
using TWJobs.Core.Models;

namespace TWJobs.Core.Repositories.Jobs;

public class JobRepository : IJobRepository
{
    private readonly TWJobsDbContext _context;

    public JobRepository(TWJobsDbContext context)
    {
        _context = context;
    }

    public Job Create(Job model)
    {
        _context.jobs.Add(model);
        _context.SaveChanges();
        return model;
    }

    public void DeleteById(int id)
    {
        var job = _context.jobs.Find(id);
        if (job is not null)
        {
            _context.jobs.Remove(job);
            _context.SaveChanges();
        }
    }

    public bool ExistsById(int id)
    {
        return _context.jobs.Any(j => j.Id == id);
    }

    public ICollection<Job> FindAll()
    {
        return _context.jobs.AsNoTracking().ToList();
    }

    public Job? FindById(int id)
    {
        return _context.jobs.AsNoTracking().FirstOrDefault(j => j.Id == id);
    }

    public Job Update(Job model)
    {
        _context.jobs.Update(model);
        _context.SaveChanges();
        return model;
    }
}