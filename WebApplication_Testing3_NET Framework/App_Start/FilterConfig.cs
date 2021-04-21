using System.Web;
using System.Web.Mvc;

namespace WebApplication_Testing3_NET_Framework
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
