using draftdreamz.Components.Model;
using draftdreamz.Data;
using Microsoft.EntityFrameworkCore;

namespace draftdreamz.Service
{
    public class ContentInfoService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ContentInfoService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ContentInfo>> GetAllContentInfo()
        {
            return await _applicationDbContext.ContentDbSet.ToListAsync();
        }
        public async Task<bool> AddNewContent(ContentInfo contentInfo)
        {
            await _applicationDbContext.ContentDbSet.AddAsync(contentInfo);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<ContentInfo> GetContentById(Guid id)
        {
            ContentInfo contentInfo = await _applicationDbContext.ContentDbSet.FirstOrDefaultAsync(x => x.ContentId == id);
            return contentInfo;
        }

        public async Task<bool> UpdateContent(ContentInfo contentInfo)
        {
            _applicationDbContext.ContentDbSet.Update(contentInfo);
            await _applicationDbContext.SaveChangesAsync(true);
            return true;
        }

        public async Task<bool> DeleteContentById(ContentInfo contentInfo)
        {
            _applicationDbContext.ContentDbSet.Remove(contentInfo);
            await _applicationDbContext.SaveChangesAsync(true);
            return true;
        }
    }
}