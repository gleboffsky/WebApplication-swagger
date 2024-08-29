namespace AuthService.Services
{
    public interface IStringService 
    {
        public string GetString();
        public int GetInt(int value);
    }
    public class StringService : IStringService
    {
        public int GetInt(int value)
        {
            return value * value;
        }

        public string GetString()
        {
            return "Vanya ne loh";
        }
    }
}
