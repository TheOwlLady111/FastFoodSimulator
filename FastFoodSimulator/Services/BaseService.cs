namespace FastFoodSimulator.Services
{
    public class BaseService
    {
        private static ManagerService _managerService;

        static BaseService()
        {
            _managerService = new ManagerService();
        }
    }
}
