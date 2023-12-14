﻿using MediatR;

namespace CQRSMediator.Notifications
{
    public class DeleteProductNotification : INotification
    {
        public int ProductId { get; set; }
    }

    public class EmailHandler : INotificationHandler<DeleteProductNotification>
    {
        public Task Handle(DeleteProductNotification notification, CancellationToken cancellationToken)
        {
            int id = notification.ProductId;
            // send email to customers
            return Task.CompletedTask;
        }
    }

    public class SMSHandler : INotificationHandler<DeleteProductNotification>
    {
        public Task Handle(DeleteProductNotification notification, CancellationToken cancellationToken)
        {
            int id = notification.ProductId;
            //send sms to sales team
            return Task.CompletedTask;
        }
    }
}
