using Remotion.Linq;
using Rql.Core;
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Remotion.Linq.Parsing.Structure;

namespace Rql.Linq.Internal
{
	/// <summary>
	///		This API supports the RQL LINQ infrastructure and is not intended to be used 
	///		directly from your code. This API may change or be removed in future releases.
	/// </summary>
	internal class RqlQueryable<TResult> : QueryableBase<TResult>
	{
		private readonly Uri _resourceUri;

		private static IQueryExecutor CreateExecutor(Uri uri, IHttpClient client)
		{
			return new RqlQueryExecutor(uri, client);
		}

		/// <summary>
		///		Gets the target resource URI of this queryable.
		/// </summary>
		public Uri ResourceUri
		{
			get { return _resourceUri; }
		}

		/// <summary>
		///		Initializes a new instance of <see cref="RqlQueryable{TResult}"/> with the specified resource URI.
		/// </summary>
		/// <param name="resourceUri">
		///		An absolute URI and path to a resource.
		/// </param>
		public RqlQueryable(string resourceUri) : this(new Uri(resourceUri, UriKind.RelativeOrAbsolute))
		{
		}

		/// <summary>
		///		Initializes a new instance of <see cref="RqlQueryable{TResult}"/> with the specified resource URI.
		/// </summary>
		/// <param name="resourceUri">
		///		An absolute URI and path to a resource.
		/// </param>
		public RqlQueryable(Uri resourceUri) : base(QueryParser.CreateDefault(), CreateExecutor(resourceUri, null))
		{
		}

		/// <summary>
		///		This constructor is called indirectly by LINQ's query methods.
		/// </summary>
		public RqlQueryable(IQueryProvider queryProvider, Expression expression) : base(queryProvider, expression)
		{
		}
	}
}
