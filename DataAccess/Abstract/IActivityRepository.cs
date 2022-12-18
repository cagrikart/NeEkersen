using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IActivityRepository
    {
        List<Activity> GetAllActivity();

        Activity GetActivityById(Guid id);

        Activity CreateActivity(Activity activity); 

        Activity UpdateActivity(Activity activity); 

        void  DeleteActivity(Guid id);
    

    }
}
