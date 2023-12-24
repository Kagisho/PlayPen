namespace OptionsDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display(() =>
            {
                Console.WriteLine("Line 1");
                Console.WriteLine("Line 2");
            });

            var svc = CommunicationServiceBuilder.CreateService(options =>
            {
                options.Mechanism = "In-App";
                options.ShouldRetry = true;
            });

            svc.SendMessage("Message from fancy delegate");
        }

        public static void Display(Action action)
        {
            action();
        }
    }
}