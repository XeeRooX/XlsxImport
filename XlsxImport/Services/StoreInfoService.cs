using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsxImport.Models;

namespace XlsxImport.Services
{
    internal class StoreInfoService : IStoreInfoService
    {
        private readonly ApplicationDbContext _dbContext;
        public StoreInfoService(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public void Add(StoreInfo si)
        {
            _dbContext.StoreInfos.Add(si);
            _dbContext.SaveChanges();
        }

        public void AddRange(IEnumerable<StoreInfo> si)
        {
            _dbContext.StoreInfos.AddRange(si);
            _dbContext.SaveChanges();
        }

        public List<StoreInfo> GetAll()
        {
            return _dbContext.StoreInfos.ToList();
        }

        public List<StoreInfo> GetByPage(int page, int count)
        {
            return _dbContext.StoreInfos.Skip(10 * page).Take(count).ToList();
        }
    }
}
