using ImageServices.ImageServices;
using ImagierWebDomain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagierAPI.ServiceRepo
{
    public class ImageServiceRepo : IRepositoryServices
    {
        private readonly ImageDbContext _context;

        public ImageServiceRepo(ImageDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ImageAsset>> GetImageAssets()
        {
            return _context.ImageAssets.ToList();
        }

        public async Task<ImageAsset> GetAssetById(Guid id)
        {
            return  _context.ImageAssets.FirstOrDefault(p => p.Id == id);
        }

        public void CreateAsset(ImageAsset asset)
        {
            if (asset != null)
            {
                _context.ImageAssets.Add(asset);
            }
            throw new ArgumentNullException(nameof(asset));
        }




        public void RemoveAsset(ImageAsset asset)
        {
            if (asset == null)
            {
                throw new ArgumentNullException(nameof(asset));
            }
            _context.ImageAssets.Remove(asset);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
