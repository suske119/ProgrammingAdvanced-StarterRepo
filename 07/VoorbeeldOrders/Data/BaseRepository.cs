namespace VoorbeeldOrders;

public abstract class BaseRepository
{
    protected string ConnectionString { get; }

    public BaseRepository()
    {


        ConnectionString = DatabaseConnection.Connectionstring("OrdersConnectionString");
    }
}
