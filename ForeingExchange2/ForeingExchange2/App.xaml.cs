﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ForeingExchange2
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new Views.LabelGirando();
		}

		 
	}
}
