using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AbsoluteLayout_Exercise
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new AbsoluteLayout_Exercise.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts4
		    AppCenter.Start("android=c7b985b6-3946-4f52-8165-9b902a6435d4;" + "uwp={Your UWP App secret here};" +
		                    "ios={Your iOS App secret here}",
		        typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
