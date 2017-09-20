using FluentAssertions;
using NUnit.Framework;
using Rql.Core;
using Rql.Parser;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Rql.Tests
{
	[TestFixture]
    public class RqlUriParserTests
    {
		[TestCase("http://locahost/api/emails", "id=1")]
		public void RqlUriParserConstructor_WithUri_ShouldSplitResourceUri(string uri, string query)
		{
			//var node = new BinaryOperatorNode(BinaryOperatorKind.And,
			//	new ConstantNode(1, "1"),
			//	new BinaryOperatorNode(BinaryOperatorKind.And,
			//		new ConstantNode(2, "2"),
			//		new ConstantNode(3, "3")));
		}
    }
}
