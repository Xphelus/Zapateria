namespace Zapateria.Code
{
    internal class LoginService
    {
        public static bool CreateUser(string userId, string name, string password, bool isAdmin)
        {
            var service = new DataService();

            var adminBit = isAdmin ? 1 : 0;

            // Obtiene del server los usuarios que tengan ese ID.
            // User_ID es un Primary Key, entonces siempre va a ser o 1 usuario, o ninguno, ya que el Primary Key es único.
            var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";
            var ds = service.FetchData(query);

            // Verifica si el usuario existe desde antes para no intentar crear uno nuevo con el mismo ID.
            if (ds.Tables[0].Rows.Count > 0)
                return false;

            query = $"INSERT INTO Users VALUES ('{userId}','{name}', '{password}', {adminBit})";
            service.SendData(query);

            return true;
        }

        public static bool Authenticate(string userId, string password)
        {
            var service = new DataService();

            // Obtiene del server los usuarios que tengan ese ID.
            // User_ID es un Primary Key, entonces siempre va a ser o 1 usuario, o ninguno, ya que el Primary Key es único.
            var query = $"SELECT * FROM Users WHERE User_ID = '{userId}'";
            var ds = service.FetchData(query);

            try
            {
                var tablePassword = ds.Tables[0].Rows[0]["Password"].ToString();

                return password.Equals(tablePassword);
            }
            catch (IndexOutOfRangeException)
            {
                // El programa tira IndexOutOfRangeException si Rows[0] no existe, lo que significa que el usuario tampoco. Retorna falso.
                return false;
            }
        }

        public static bool IsUserAdmin(string userId)
        {
            var service = new DataService();

            var query = $"SELECT IsAdmin FROM Users WHERE User_ID = '{userId}'";

            var ds = service.FetchData(query);

            var stringBool = ds.Tables[0].Rows[0]["IsAdmin"].ToString();

            return stringBool is not (null or "") && stringBool.Equals("True");
        }
    }
}
