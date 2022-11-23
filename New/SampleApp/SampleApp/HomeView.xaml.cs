namespace SampleApp;

public partial class HomeView : ContentPage
{
    public HomeView()
    {
        InitializeComponent();
    }

    void openSettings(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SettingsView());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        refreshView();
    }

    void OnButtonClicked(object sender, EventArgs e)
    {
        //if (!Airship.Instance.UserNotificationsEnabled)
        //{
        //    Airship.Instance.UserNotificationsEnabled = true;
        //    //FIXME: Need to be improved
        //    do
        //    {
        //    } while (Airship.Instance.ChannelId == null);
        //    refreshView();

        //    return;
        //}

        //if (Airship.Instance.ChannelId != null)
        //{
        //    //CrossClipboard.Current.SetText(Airship.Instance.ChannelId);
        //    //DisplayAlert(AppResources.alert_title, AppResources.alert_copied_channel_id, AppResources.ok);
        //}
    }

    void MessageCenterBtnClicked(object sender, EventArgs e)
    {
        //Airship.Instance.DisplayMessageCenter();
    }

    void refreshView()
    {
        //if (Airship.Instance.UserNotificationsEnabled && Airship.Instance.ChannelId != null)
        //{
        //    enablePushButton.Text = Airship.Instance.ChannelId;
        //}
    }
}
