using MySql.Data.MySqlClient;
using System.Data;

class Reservation{
    string connectionString = "Server=localhost;Database=hotel_manage;User ID=root;Password=michal;";

    public List<IDataRecord> ReadData(){
        string queryString = "SELECT * FROM Reservations;";
        List<IDataRecord> res = new List<IDataRecord>();
        using (MySqlConnection connection = new MySqlConnection(this.connectionString))
        {
            MySqlCommand command = new MySqlCommand(queryString, connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
                res.Add((IDataRecord)reader);
            }
            reader.Close();
        }
        return res;
    }
    private static void ReadSingleRow(IDataRecord d){
        Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", d[0], d[1], d[2], d[3], d[4], d[5]));
    }
}
