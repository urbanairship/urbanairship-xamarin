using System;
using System.Collections.Generic;
using UrbanAirship.NETStandard;
using Xamarin.Forms;

namespace SampleApp
{	
	public partial class FeaturesViewController : ContentPage
	{	
		public FeaturesViewController ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            enabledPushFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.Push);
            enableMessageCenterFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.MessageCenter);
            enableInAppAutomationFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.InAppAutomation);
            EnableAnalyticsFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.Analytics);
            enableTagsAndAttributesFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.TagsAndAttributes);
            enableContactsFeatureSwitch.On = Airship.Instance.IsFeatureEnabled(Features.Contacts);
        }

        void enablePushFeature_OnChanged(object sender, EventArgs e)
        {
            if (enabledPushFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.Push);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.Push);
            }
        }

        void enableMessageCenterFeature_OnChanged(object sender, EventArgs e)
        {
            if (enableMessageCenterFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.MessageCenter);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.MessageCenter);
            }
        }

        void enableInAppAutomationFeature_OnChanged(object sender, EventArgs e)
        {
            if (enableInAppAutomationFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.InAppAutomation);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.InAppAutomation);
            }
        }

        void enableAnalyticsFeature_OnChanged(object sender, EventArgs e)
        {
            if (EnableAnalyticsFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.Analytics);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.Analytics);
            }
        }

        void enableTagsAndAttributesFeature_OnChanged(object sender, EventArgs e)
        {
            if (enableTagsAndAttributesFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.TagsAndAttributes);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.TagsAndAttributes);
            }
        }

        void enableContactsFeature_OnChanged(object sender, EventArgs e)
        {
            if (enableContactsFeatureSwitch.On)
            {
                Airship.Instance.EnableFeatures(Features.Contacts);
            }
            else
            {
                Airship.Instance.DisableFeatures(Features.Contacts);
            }
        }

    }
}

