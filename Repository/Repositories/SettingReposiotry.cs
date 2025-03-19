using DataAccessObject.Models;
using Repository.GenericRepository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class SettingReposiotry : GenericRepository<Setting>, ISettingRepository
    {
        public SettingReposiotry(HomeDecorDBContext context) : base(context)
        {
        }
    }
}
