using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            this.workLocationDal = workLocationDal;
        }

        public void TDelete(WorkLocation t)
        {
            workLocationDal.Delete(t);
        }

        public List<WorkLocation> TGetAll()
        {
            return workLocationDal.GetAll();
        }

        public WorkLocation TGetByID(int id)
        {
            return workLocationDal.GetByID(id);
        }

        public void TInsert(WorkLocation t)
        {
            workLocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            workLocationDal.Update(t);
        }
    }
}
