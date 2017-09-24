using Simple_MasterDetail_Example.Models;
using Simple_MasterDetail_Example.Services;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_MasterDetail_Example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityFeedPage : ContentPage
    {
        private ActivityService _activityService;

        public ActivityFeedPage()
        {
            _activityService = new ActivityService();

            InitializeComponent();

            PopulateActivityFeed(_activityService.GetActivities());
        }

        private void PopulateActivityFeed(IEnumerable<Activity> activities)
        {
            ActivityFeed.ItemsSource = activities;
        }

        private async void ActivityFeed_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var userService = new UserService();

            // to stop item selected loop after setting it to null
            if (e.SelectedItem == null)
                return;

            if (e.SelectedItem is Activity activity)
                await Navigation.PushAsync(new ProfilePage(userService.GetUser(activity.UserId)));

            ActivityFeed.SelectedItem = null;
        }
    }


}