//using NUnit.Framework;
//using Remotion.Linq.Parsing;
//using Rql.Linq;
//using System.Linq;

//namespace Rql.Tests
//{
//	public class Email
//	{
//		public int Id { get; set; }
//		public string Sender { get; set; }
//	}

//	[TestFixture]
//	public class RqlQueryTests
//	{
//		[TestCase]
//		public void TestMethod1()
//		{
//			var query = new RqlQueryable<Email>("/api/emails")
//				.Where(x => x.Sender == "reegan.layzell@workshare.com");

//			query.ToList();
//		}

//		[TestCase]
//		public void TestMethod2()
//		{
//			var query = new RqlQueryable<Email>("/api/emails")
//				.Where(x => x.Id < 10 && x.Id > 1);

//			query.ToList();
//		}
//	}
//}
