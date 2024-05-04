namespace DIP.After
{
    public class NotificationService
    {
        private readonly List<IMessageService> _messageServices;

        public NotificationService(List<IMessageService> _services)
        {
            _messageServices = _services;
        }
        public void Notify()
        {

            foreach (var messageService in _messageServices)
            {
                messageService.Send();

            }
        }
    }
}
