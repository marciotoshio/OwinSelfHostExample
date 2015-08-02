using System;
using System.Web.Http;
using System.Collections.Generic;

namespace OwinSelfHostExample.WebApi
{
	public class ValuesController : ApiController
	{
		public IEnumerable<string> Get()
		{
			return new[] { "value1", "value2", "value3" };
		}
	}
}

