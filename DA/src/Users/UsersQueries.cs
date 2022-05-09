namespace DigiVisio2030.DA.Users
{
    internal class UsersQueries
    {
        const string schemaName = "public.\"User\"";
        public static string GetAllUsers()
        {
            return $@"
SELECT ""Id"", ""FirstName"", ""LastName"", ""CityId""
FROM {schemaName};";
        }

        public static string GetAllUsersWithCities()
        {
            return $@"
SELECT usrs.""Id"", ""FirstName"", ""LastName"", ""CityId"", cts.""Id"", cts.""Name""
FROM {schemaName} usrs
JOIN public.""City"" cts on usrs.""CityId"" = cts.""Id""
; ";
        }
    }
}
