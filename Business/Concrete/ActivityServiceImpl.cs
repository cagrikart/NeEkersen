using Business.Abstract;
using DataAccess.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ActivityServiceImpl : IActivityService
    {
        private  IActivityRepository _service;

        public ActivityServiceImpl(IActivityRepository service)
        {
            _service = service;
        }

        public Activity CreateActivity(Activity activity)
        {
            return _service.CreateActivity(activity);
        }

        public void DeleteActivity(Guid id)
        {
            _service.DeleteActivity(id);
        }

        public Activity GetActivityById(Guid id)
        {
           return _service.GetActivityById(id);
        }

        public List<Activity> GetAllActivity()
        {
            return _service.GetAllActivity();
        }

        public Activity UpdateActivity(Activity activity)
        {
            return _service.UpdateActivity(activity);
        }
    }
}
