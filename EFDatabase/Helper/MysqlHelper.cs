using EFDatabase.Factory;

namespace EFDatabase.Helper
{
    public static class MysqlHelper
    {
        public static void CreateDatabase()
        {
            using (new DataContext())
            {
                
            }
        }
    }
}