using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XlsxImport.Models;

namespace XlsxImport.Services
{
    internal interface IStoreInfoService
    {
        List<StoreInfo> GetAll();
        List<StoreInfo> GetByPage(int page, int count);
        void Add(StoreInfo si);
        void AddRange(IEnumerable<StoreInfo> si);
    }
}
