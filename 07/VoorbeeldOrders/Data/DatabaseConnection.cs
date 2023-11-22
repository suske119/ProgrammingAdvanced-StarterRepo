using System.Configuration;

namespace VoorbeeldOrders;

public static class DatabaseConnection
{
    public static string Connectionstring(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }

}
