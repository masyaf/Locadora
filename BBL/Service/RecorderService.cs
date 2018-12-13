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
   public  class RecorderService : IRecorderService
    {
       RecorderRepository UnitOfWorkRecorder { get; set; }

       public RecorderService()
       {
           UnitOfWorkRecorder = new RecorderRepository();
       }

       public void Save(Recorder recorder)
       {
           UnitOfWorkRecorder.Save(recorder);
       }

       public void Delete(int code)
       {
           UnitOfWorkRecorder.Delete(code);
       }
       public void Update(Recorder recorder)
       {
           UnitOfWorkRecorder.Update(recorder);
       }

       public Recorder GetByCode(int code)
       {
          return  UnitOfWorkRecorder.GetByCode(code);
       }
       public List<Recorder> findByName(string name)
       {
           return UnitOfWorkRecorder.Where(r => r.Name.ToLower().Contains(name.ToLower())).ToList();
       }

       public IEnumerable<Recorder> All()
       {
           return UnitOfWorkRecorder.GetAll();
       }

       public Recorder GetSingleByName(string name)
       {
          return  UnitOfWorkRecorder.GetSingleByName(name);
       }
    }
}
