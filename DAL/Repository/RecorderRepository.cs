using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RecorderRepository : BaseContext<Recorder>, IRecorderRepository
    {
        public Recorder GetSingleByName(string name)
        {
            return Where(r => r.Name.Equals(name)).FirstOrDefault();
        }
    }
}
