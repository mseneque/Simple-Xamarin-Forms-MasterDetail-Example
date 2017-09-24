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
    }


}