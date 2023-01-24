using System;
namespace AirshipDotNet.MessageCenter;

public class MessageView : View, IMessageView
{
    public string? MessageId { get; set; }
}

