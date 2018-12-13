using BLL.Service.Interfaces;
using DAL;
using DAL.Repository;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public  class GenderService : IGenderService
    {
        private GenderRepository IUnitOfWork;

        public GenderService(){
            IUnitOfWork = new GenderRepository();
      }

        public void Save(Gender entity)
        {
            IUnitOfWork.Save(entity);
        }

        public void Delete(int code)
        {
            IUnitOfWork.Delete(code);
        }

        public void Update(Gender entity)
        {
            IUnitOfWork.Update(entity);
        }

        public Gender GetByCode(int code)
        {
            return IUnitOfWork.GetByCode(code);
        }

        public List<Gender> findByName(string name)
        {
            return IUnitOfWork.Where(g => g.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public IEnumerable<Gender> All()
        {
            return IUnitOfWork.GetAll();
        }

        public Gender GetSingleByName(string name)
        {
            return IUnitOfWork.GetSingleByName(name);
        }
    }
}
