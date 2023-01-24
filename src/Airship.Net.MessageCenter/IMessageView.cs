using System;
namespace AirshipDotNet.MessageCenter;

public interface IMessageView : IView
{
    public string? MessageId { get; }
}


