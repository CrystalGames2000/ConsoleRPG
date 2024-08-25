using System.Data.SqlClient;

public static class DataManager
{

    private static string connectionString = "Server=DESKTOP-V0MKS35;Database=CrystalGames;Integrated Security=True;";

    public static void ReadDataFromTable(string query) {
        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand _query = new SqlCommand(query, connection)) {
            connection.Open();
            using (SqlDataReader reader = _query.ExecuteReader()) {
                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        Console.WriteLine(reader[i].ToString());
                    }
                }
            }
        }
    }

    public static void UpdatePlayerStatistics(PlayerData player) {
        string query = "INSERT INTO dbo.Players VALUES (@Username, @Password, @PlayerFirstName, @PlayerLastName, @PlayerRace, @PlayerClass, @PlayerLevel, @PlayerXP, @PlayerStrMod, @PlayerDexMod, @PlayerConMod, @PlayerIntMod, @PlayerWisMod, @PlayerChaMod, @PlayerStr, @PlayerDex, @PlayerCon, @PlayerInt, @PlayerWis, @PlayerCha)";
        using var connection = new SqlConnection(connectionString);
        using var cmd = new SqlCommand(query, connection);

        cmd.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 20).Value = player.Username;
        cmd.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 20).Value = player.Password;
        cmd.Parameters.Add("@PlayerFirstName", System.Data.SqlDbType.NVarChar, 20).Value = player.PlayerFirstName;
        cmd.Parameters.Add("@PlayerLastName", System.Data.SqlDbType.NVarChar, 20).Value = player.PlayerLastName;
        cmd.Parameters.Add("@PlayerRace", System.Data.SqlDbType.NVarChar, 11).Value = player.PlayerRace;
        cmd.Parameters.Add("@PlayerClass", System.Data.SqlDbType.NVarChar, 10).Value = player.PlayerClass;
        cmd.Parameters.Add("@PlayerLevel", System.Data.SqlDbType.Int, 21).Value = player.PlayerLevel;
        cmd.Parameters.Add("@PlayerXP", System.Data.SqlDbType.Int, 5350000).Value = player.PlayerXP;
        cmd.Parameters.Add("@PlayerStrMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerStrMod;
        cmd.Parameters.Add("@PlayerDexMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerDexMod;
        cmd.Parameters.Add("@PlayerConMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerConMod;
        cmd.Parameters.Add("@PlayerIntMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerIntMod;
        cmd.Parameters.Add("@PlayerWisMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerWisMod;
        cmd.Parameters.Add("@PlayerChaMod", System.Data.SqlDbType.Int, 42).Value = player.PlayerChaMod;
        cmd.Parameters.Add("@PlayerStr", System.Data.SqlDbType.Int, 42).Value = player.PlayerStr;
        cmd.Parameters.Add("@PlayerDex", System.Data.SqlDbType.Int, 42).Value = player.PlayerDex;
        cmd.Parameters.Add("@PlayerCon", System.Data.SqlDbType.Int, 42).Value = player.PlayerCon;
        cmd.Parameters.Add("@PlayerInt", System.Data.SqlDbType.Int, 42).Value = player.PlayerInt;
        cmd.Parameters.Add("@PlayerWis", System.Data.SqlDbType.Int, 42).Value = player.PlayerWis;
        cmd.Parameters.Add("@PlayerCha", System.Data.SqlDbType.Int, 42).Value = player.PlayerCha;

        connection.Open();
        cmd.ExecuteNonQuery();
    }
}
