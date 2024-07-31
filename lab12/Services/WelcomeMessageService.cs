namespace lab12.Services
{
    public class WelcomeMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello this is the  demonstrate of  dependency injection !";
        }
    }
}
