using AirshipDotNet;
using AirshipDotNet.MessageCenter;

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

    void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var message = e.SelectedItem as Message;
        var messagePage = new MessagePage();
        Console.WriteLine("MessageCenterPage onSelected: '" + message.MessageId + "'");
        messagePage.MessageId = message.MessageId;
        //messagePage.LoadStarted += onLoadStarted;
        //messagePage.LoadFinished += onLoadFinished;
        //messagePage.Closed += onClosed;
        //messagePage.LoadFailed += onLoadFailed;
        Navigation.PushAsync(messagePage);
    }

    //private void onLoadStarted(object sender, MessageLoadStartedEventArgs e)
    //{
    //    Console.WriteLine("onLoadStarted was reached.");
    //}

    //private void onLoadFinished(object sender, MessageLoadFinishedEventArgs e)
    //{
    //    Console.WriteLine("onLoaded was reached.");
    //}

    //private void onClosed(object sender, MessageClosedEventArgs e)
    //{
    //    Console.WriteLine("onClosed was reached.");
    //    Navigation.PopAsync();
    //}

    //private void onLoadFailed(object sender, MessageLoadFailedEventArgs e)
    //{
    //    Console.WriteLine("onLoadFailed was reached.");
    //}
}
