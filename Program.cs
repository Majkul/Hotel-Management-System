using MySql.Data.MySqlClient;
using System.Data;
class Program{
    static void Main(){
        Reservation res = new Reservation();
        List<IDataRecord> data = res.ReadData();
    }
}