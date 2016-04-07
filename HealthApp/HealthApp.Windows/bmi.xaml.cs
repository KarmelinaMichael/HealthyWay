using HealthApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using Windows.UI.Popups;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace HealthApp
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class bmi : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public bmi()
        {

            this.InitializeComponent(); 
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            
           
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private async void  Button_Click(object sender, RoutedEventArgs e)
        {   float text;
        float n;
        bool isNumeric = float.TryParse(txtb1.Text, out n);
        
        bool isNumeric1 = float.TryParse(txtb2.Text, out n);
        var messageDialog = new MessageDialog("");
        if (txtb1.Text.Equals("") || txtb2.Text.Equals("") || txtb1.Text.Equals("0") || txtb2.Text.Equals("0") || 
            !isNumeric || !isNumeric1 ){
            messageDialog.Content = "Error! Please enter the 2 fields correctly";
        bleep.Play();

        }

        else { 
        text = float.Parse(txtb1.Text) / float.Parse(txtb2.Text);
        text = text / float.Parse(txtb2.Text);
        String text1="Your BMI = " + text;
        if(text<15)
            messageDialog.Content = (text1 + "\n(Warning!) Very severely underweight");
           
        else if (text <= 18.5 && text>=16)
            messageDialog.Content = (text1 + "\nUnderweight");
        else if (text >= 18.5 && text <= 25)
        {
            
            messageDialog.Content = (text1 + "\nNormal");
           
        }
        else if (text >= 30 && text<40)
            messageDialog.Content = (text1 + "\nOverweight");
        else if (text >= 40)
            messageDialog.Content = (text1 + "\n(Warning!) Very severely obese");
            } 
        await messageDialog.ShowAsync();
       
           
        }

        
    }
}
