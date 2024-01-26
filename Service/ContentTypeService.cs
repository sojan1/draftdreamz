using draftdreamz.Components.Model;
using draftdreamz.Data;
using Microsoft.EntityFrameworkCore;

namespace draftdreamz.Service
{
    public class ContentTypeService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ContentTypeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ContentType>> GetAllContentType()
        {
            return await _applicationDbContext.ContentTypeDbSet.ToListAsync();
        }
    }
}
