﻿using System.Web.Mvc;

namespace VisualCaptchaNet.Mvc5
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
