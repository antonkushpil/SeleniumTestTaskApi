using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olx.Interfaces;

namespace Olx.Services
{
	class PageService
	{
		public static TPage Create<TPage>() where TPage : IPage, new()
		{
			return new TPage();
		}
	}
}
