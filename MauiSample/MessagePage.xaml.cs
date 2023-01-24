namespace MauiSample;

public partial class MessagePage : ContentPage
{
    public MessagePage()
    {
        InitializeComponent();
    }

    private string _messageId = null;

    public string MessageId
    {
        get => _messageId;
        set
        {
            if (value != _messageId)
            {
                _messageId = value;
                message.MessageId = value;
            }
        }
    }
}
