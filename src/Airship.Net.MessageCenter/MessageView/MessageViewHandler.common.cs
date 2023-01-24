using System;
using Microsoft.Maui.Handlers;

namespace AirshipDotNet.MessageCenter;

public partial class MessageViewHandler
{

    public static IPropertyMapper<IMessageView, MessageViewHandler> PropertyMapper = new PropertyMapper<IMessageView, MessageViewHandler>(ViewHandler.ViewMapper)
    {
        [nameof(IMessageView.MessageId)] = MapMessageId,
    };

    //public static CommandMapper<IMessageView, MessageViewHandler> CommandMapper = new(ViewCommandMapper)
    //{
    //    [nameof(IMessageView.UpdateStatus)] = UpdateStatus,
    //};


    public MessageViewHandler() : base(PropertyMapper)
    {

    }
}


