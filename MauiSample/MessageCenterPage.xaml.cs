using AirshipDotNet;
using AirshipDotNet.MessageCenter;
using AirshipDotNet.MessageCenter.Controls;

namespace MauiSample;

public partial class MessageCenterPage : ContentPage
{
	public MessageCenterPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        var messages = Airship.Instance.InboxMessages;
        listView.ItemsSource = messages;
    }

    void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var message = e.SelectedItem as Message;
        Console.WriteLine("MessageCenterPage onSelected: '" + message.MessageId + "'");

        var messagePage = new MessagePage();
        messagePage.MessageId = message.MessageId;
        messagePage.LoadStarted += onLoadStarted;
        messagePage.LoadFinished += onLoadFinished;
        messagePage.Closed += onClosed;
        messagePage.LoadFailed += onLoadFailed;

        Navigation.PushAsync(messagePage);
    }

    private void onLoadStarted(object sender, MessageLoadStartedEventArgs e)
    {
        Console.WriteLine("MessageCenterPage onLoadStarted was reached.");
    }

    private void onLoadFinished(object sender, MessageLoadFinishedEventArgs e)
    {
        Console.WriteLine("MessageCenterPage onLoaded was reached.");
    }

    private void onClosed(object sender, MessageClosedEventArgs e)
    {
        Console.WriteLine("MessageCenterPage onClosed was reached.");
        Navigation.PopAsync();
    }

    private void onLoadFailed(object sender, MessageLoadFailedEventArgs e)
    {
        Console.WriteLine("MessageCenterPage onLoadFailed was reached.");
    }
}
