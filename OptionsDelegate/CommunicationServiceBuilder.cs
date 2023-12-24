namespace OptionsDelegate
{
    public static class CommunicationServiceBuilder
    {
        private static CommunicationService svc = new CommunicationService { Options = new CommunicationOptions()};
      
        public static CommunicationService CreateService(Action<CommunicationOptions> action)
        {
           if (action is null)
                throw new ArgumentNullException("options", "Options must be set when creating the communications service");

           action(svc.Options);

            if (string.IsNullOrEmpty(svc.Options.Mechanism))
                throw new ArgumentException(nameof(svc.Options.Mechanism));

            return svc;
        }
    }

}
