﻿using BLL.Service.Interfaces;
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
    public class TypeMovieService : ITypeMovieService
    {
        private TypeMovieRepository IUnitOfWork;

        public TypeMovieService()
        {
            IUnitOfWork = new TypeMovieRepository();
        }
        public void Save(TypeMovie entity)
        {
            IUnitOfWork.Save(entity);
        }

        public void Delete(int code)
        {
            IUnitOfWork.Delete(code);
        }

        public void Update(TypeMovie entity)
        {
            IUnitOfWork.Update(entity);
        }

        public TypeMovie GetByCode(int code)
        {
            return IUnitOfWork.GetByCode(code);
        }

        public List<TypeMovie> findByName(string name)
        {
            return IUnitOfWork.Where(t => t.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public IEnumerable<TypeMovie> All()
        {
            return IUnitOfWork.GetAll();
        }

        public TypeMovie GetSingleByName(string name)
        {
            return IUnitOfWork.GetSingleByName(name);
        }
    }
}
