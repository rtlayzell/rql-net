using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rql.Tests.Linq
{
	public class Email
	{
		public int Id { get; set; }
		public string Sender { get; set; }
		public string Subject { get; set; }

		public ICollection<string> To { get; set; }
	}

	[TestFixture]
    public class ResourceTests
    {
		[TestCase]
		public void TestMethod1()
		{
			var query = new Resource<Email>();
			
		}
    }
}
