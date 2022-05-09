namespace DigiVisio2030.DA.Cities
{
    internal static class CitiesQueries
    {
        const string schemaName = "public.\"City\"";
        public static string GetAllCities()
        {
            return $@"
SELECT ""Id"", ""Name""
FROM {schemaName};";
        }
    }

}
