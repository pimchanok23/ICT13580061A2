﻿using ICT13580061A2.Helpers;
using Xamarin.Forms;

namespace ICT13580061A2
{
	public partial class App : Application
	{
		public static DbHelper DbHelper { get; set; }

		public App(string dbPath)
		{
			InitializeComponent();

			DbHelper = new DbHelper(dbPath);

			MainPage = new NavigationPage(new MainPage());
		}

        public App()
        {
        }

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
