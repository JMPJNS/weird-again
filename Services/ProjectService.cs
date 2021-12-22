using Microsoft.EntityFrameworkCore;
using Weird_Again.Data;
using Weird_Again.Data.Models;

namespace Weird_Again.Services
{
    public class ProjectService
    {
        private ApplicationDbContext _context;
        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get every Project
        /// </summary>
        /// <returns></returns>
        public Task<List<Project>> GetAll()
        {
            return _context.Projects.ToListAsync();
        }

        public Task<Project?> Get(int id)
        {
            return _context.Projects.SingleOrDefaultAsync(p => p.Id == id);
        }

        /// <summary>
        /// Add a new Project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Task Add(Project project)
        {
            _context.Projects.Add(project);
            return _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update a Project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Task Update(Project project)
        {
            _context.Projects.Update(project);
            return _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete a Project
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Delete(Project project)
        {
            _context.Projects.Remove(project);
            return _context.SaveChangesAsync();
        }
    }
}
