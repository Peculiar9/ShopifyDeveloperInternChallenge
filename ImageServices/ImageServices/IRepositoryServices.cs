using ImagierWebDomain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageServices.ImageServices
{
    public interface IRepositoryServices
    {
        Task<IEnumerable<ImageAsset>> GetImageAssets();
        Task<ImageAsset> GetAssetById(Guid id);
        void CreateAsset(ImageAsset asset);
        void RemoveAsset(ImageAsset asset);
        bool SaveChanges();
    }
}
