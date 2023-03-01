using AirshipDotNet.MessageCenter.Controls;

namespace MauiSample;

public partial class MessagePage : ContentPage
{
    public event EventHandler<MessageLoadStartedEventArgs> LoadStarted;
    public event EventHandler<MessageLoadFinishedEventArgs> LoadFinished;
    public event EventHandler<MessageLoadFailedEventArgs> LoadFailed;
    public event EventHandler<MessageClosedEventArgs> Closed;

    public MessagePage()
    {
        InitializeComponent();
    }

    public string MessageId
    {
        get => messageView.MessageId;
        set
        {
            if (value != messageView.MessageId)
            {
                messageView.MessageId = value;
            }
        }
    }

    void MessageView_LoadStarted(object sender, MessageLoadStartedEventArgs args) =>
        LoadStarted?.Invoke(this, args);

    void MessageView_LoadFailed(object sender, MessageLoadFailedEventArgs args) =>
        LoadFailed?.Invoke(this, args);

    void MessageView_LoadFinished(object sender, MessageLoadFinishedEventArgs args) =>
        LoadFinished?.Invoke(this, args);

    void MessageView_Closed(object sender, MessageClosedEventArgs args) =>
        Closed?.Invoke(this, args);
}
