using Model;

namespace Business.Abstract
{
    public interface IActivityService
    {
        List<Activity> GetAllActivity();

        Activity GetActivityById(Guid id);

        Activity CreateActivity(Activity activity);

        Activity UpdateActivity(Activity activity);

        void DeleteActivity(Guid id);
    }
}