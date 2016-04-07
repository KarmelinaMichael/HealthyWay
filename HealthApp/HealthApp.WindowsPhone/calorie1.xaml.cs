using HealthApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace HealthApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class calorie1 : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public calorie1()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
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
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        static int s = 0;
        private void listbox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (listbox1.SelectedItem != null)
            {
                if (listbox1.SelectedItem.Equals(d5))
                {
                    s += 59;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d1))
                {
                    s += 60;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d2))
                {
                    s += 72;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d3))
                {
                    s += 78;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d4))
                {
                    s += 3;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d6))
                {
                    s += 52;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d7))
                {
                    s += 58;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d8))
                {
                    s += 47;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d9))
                {
                    s += 67;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d10))
                {
                    s += 75;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d11))
                {
                    s += 70;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d12))
                {
                    s += 21;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d13))
                {
                    s += 175;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d14))
                {
                    s += 110;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d15))
                {
                    s += 5;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d16))
                {
                    s += 5;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d17))
                {
                    s += 1;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d18))
                {
                    s += 5;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d19))
                {
                    s += 100;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d20))
                {
                    s += 0;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d21))
                {
                    s += 90;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d22))
                {
                    s += 96;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d23))
                {
                    s += 119;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d24))
                {
                    s += 97;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d25))
                {
                    s += 1;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d26))
                {
                    s += 126;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox1.SelectedItem.Equals(d27))
                {
                    s += 107;
                    txtb4.Text = "Calories = " + s;
                }
            }

            else if (listbox.SelectedItem != null)
            {
                if (listbox.SelectedItem.Equals(milk1))
                {
                    s += 150;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk2))
                {
                    s += 102;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk3))
                {
                    s += 157;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk4))
                {
                    s += 264;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk5))
                {
                    s += 123;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk6))
                {
                    s += 435;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk7))
                {
                    s += 208;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk8))
                {
                    s += 244;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk9))
                {
                    s += 114;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk10))
                {
                    s += 101;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk11))
                {
                    s += 80;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk12))
                {
                    s += 80;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk13))
                {
                    s += 52;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk14))
                {
                    s += 37;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk15))
                {
                    s += 141;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk16))
                {
                    s += 114;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk17))
                {
                    s += 240;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk18))
                {
                    s += 280;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox.SelectedItem.Equals(milk19))
                {
                    s += 220;
                    txtb4.Text = "Calories = " + s;
                }
            }
            else if (listbox2.SelectedItem != null)
            {
                if (listbox2.SelectedItem.Equals(m1))
                {
                    s += 167;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m2))
                {
                    s += 223;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m3))
                {
                    s += 142;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m4))
                {
                    s += 193;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m5))
                {
                    s += 161;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m6))
                {
                    s += 99;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m7))
                {
                    s += 290;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m8))
                {
                    s += 173;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m9))
                {
                    s += 161;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m10))
                {
                    s += 190;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m11))
                {
                    s += 135;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox2.SelectedItem.Equals(m12))
                {
                    s += 169;
                    txtb4.Text = "Calories = " + s;
                }
            }
            else if (listbox3.SelectedItem != null)
            {
                if (listbox3.SelectedItem.Equals(f1))
                {
                    s += 58;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f2))
                {
                    s += 42;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f3))
                {
                    s += 104;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f4))
                {
                    s += 169;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f5))
                {
                    s += 99;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f6))
                {
                    s += 136;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f7))
                {
                    s += 228;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f8))
                {
                    s += 206;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f9))
                {
                    s += 84;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f10))
                {
                    s += 83;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f11))
                {
                    s += 23;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f12))
                {
                    s += 46;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f13))
                {
                    s += 84;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox3.SelectedItem.Equals(f14))
                {
                    s += 40;
                    txtb4.Text = "Calories = " + s;
                }
            }
            else if (listbox4.SelectedItem != null)
            {
                if (listbox4.SelectedItem.Equals(l1))
                {
                    s += 187;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l2))
                {
                    s += 349;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l3))
                {
                    s += 37;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l4))
                {
                    s += 339;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l5))
                {
                    s += 170;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l6))
                {
                    s += 175;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l7))
                {
                    s += 170;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l8))
                {
                    s += 175;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l9))
                {
                    s += 357;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l10))
                {
                    s += 165;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l11))
                {
                    s += 170;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l12))
                {
                    s += 95;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l13))
                {
                    s += 100;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l14))
                {
                    s += 174;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox4.SelectedItem.Equals(l15))
                {
                    s += 173;
                    txtb4.Text = "Calories = " + s;
                }

            }
            else if (listbox5.SelectedItem != null)
            {
                if (listbox5.SelectedItem.Equals(v1))
                {
                    s += 31;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v2))
                {
                    s += 35;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v3))
                {
                    s += 15;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v3))
                {
                    s += 12;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v4))
                {
                    s += 7;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v5))
                {
                    s += 100;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v6))
                {
                    s += 13;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v7))
                {
                    s += 20;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v8))
                {
                    s += 25;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v9))
                {
                    s += 16;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v10))
                {
                    s += 8;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v11))
                {
                    s += 8;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v12))
                {
                    s += 77;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v13))
                {
                    s += 9;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v14))
                {
                    s += 19;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v15))
                {
                    s += 4;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v16))
                {
                    s += 54;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v17))
                {
                    s += 25;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v18))
                {
                    s += 27;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v19))
                {
                    s += 16;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v20))
                {
                    s += 67;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v21))
                {
                    s += 12;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v22))
                {
                    s += 18;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v23))
                {
                    s += 220;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v24))
                {
                    s += 158;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v25))
                {
                    s += 41;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v26))
                {
                    s += 7;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v27))
                {
                    s += 6;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v28))
                {
                    s += 18;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v29))
                {
                    s += 111;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v30))
                {
                    s += 26;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v31))
                {
                    s += 73;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v32))
                {
                    s += 73;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v33))
                {
                    s += 7;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v34))
                {
                    s += 146;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v35))
                {
                    s += 84;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v36))
                {
                    s += 95;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v37))
                {
                    s += 66;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v38))
                {
                    s += 34;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v39))
                {
                    s += 58;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v40))
                {
                    s += 50;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v41))
                {
                    s += 82;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v42))
                {
                    s += 81;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v43))
                {
                    s += 17;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v44))
                {
                    s += 105;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v45))
                {
                    s += 37;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v46))
                {
                    s += 38;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v47))
                {
                    s += 49;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v48))
                {
                    s += 162;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v49))
                {
                    s += 53;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v50))
                {
                    s += 45;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v51))
                {
                    s += 46;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v52))
                {
                    s += 68;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v53))
                {
                    s += 62;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v54))
                {
                    s += 117;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v55))
                {
                    s += 37;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v56))
                {
                    s += 98;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v57))
                {
                    s += 42;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v58))
                {
                    s += 36;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v59))
                {
                    s += 110;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v60))
                {
                    s += 67;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v61))
                {
                    s += 26;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v62))
                {
                    s += 33;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v63))
                {
                    s += 23;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v64))
                {
                    s += 37;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v65))
                {
                    s += 122;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v66))
                {
                    s += 150;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v67))
                {
                    s += 49;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v68))
                {
                    s += 17;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v69))
                {
                    s += 53;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v70))
                {
                    s += 117;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v71))
                {
                    s += 9;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v72))
                {
                    s += 60;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v73))
                {
                    s += 82;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v74))
                {
                    s += 26;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v75))
                {
                    s += 288;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v76))
                {
                    s += 109;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v77))
                {
                    s += 113;
                    txtb4.Text = "Calories = " + s;
                }
                else if (listbox5.SelectedItem.Equals(v78))
                {
                    s += 169;
                    txtb4.Text = "Calories = " + s;
                }

            }

        }


        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
