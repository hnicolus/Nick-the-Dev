using Microsoft.EntityFrameworkCore;
using Nick_the_Dev.Data;
using Nick_the_Dev.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nick_the_Dev.Services.ProjectsService
{

    public class ProjectService
    {
        private readonly PortfolioDbContext _dbContext;

        public ProjectService(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Project>> GetEmployees()
        {
            return await _dbContext.Projects.ToListAsync();
        }
        public async Task<bool> CreateProject(Project Project)
        {
           
            _dbContext.Add(Project);
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }

        }
        public async Task<Project> SingleEmployee(string id)
        {
            return await _dbContext.Projects.FindAsync(id);
        }
        public async Task<bool> EditEmployee(string id, Project  project)
        {
            if (id != project.Id.ToString())
            {
                return false;
            }

            _dbContext.Entry(project).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteEmployee(string id)
        {
            var patient = await _dbContext.Projects.FindAsync(id);
            if (patient == null)
            {
                return false;
            }

            _dbContext.Projects.Remove(patient);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
    
}
