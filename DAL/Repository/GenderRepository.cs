using DAL.Repository.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenderRepository : BaseContext<Gender>, IGenderRepository
    {

        public Gender GetSingleByName(string name)
        {
            return Where(g => g.Name.Equals(name)).FirstOrDefault();
        }
    }
}
