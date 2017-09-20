using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rql.Linq.Internal
{
	/// <summary>
	///		This API supports the RQL LINQ infrastructure and is not intended to be used
	///		directly from you code.  This API may change or be removed in future releases.
	/// </summary>
	public interface IAsyncQueryProvider : IQueryProvider
	{
		/// <summary>
		///		This API supports the RQL LINQ infrastructure and is not intended to be used
		///		directly from you code.  This API may change or be removed in future releases.
		/// </summary>
		IAsyncEnumerable<TResult> ExecuteAsync<TResult>(Expression expression);

		/// <summary>
		///		This API supports the RQL LINQ infrastructure and is not intended to be used
		///		directly from you code.  This API may change or be removed in future releases.
		/// </summary>
		Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken);
	}
}
