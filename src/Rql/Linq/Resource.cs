using Rql.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Linq.Expressions;

namespace Rql.Linq
{
	public interface IUriFactory
	{

	}

    public abstract class Resource<TEntity> : IQueryable<TEntity> 
	where TEntity : class
    {
		private readonly string _name;
		private readonly IHttpClient _httpClient;
		private readonly IUriFactory _uriFactory;
		
		public Resource(string name, string uri) : this(name, new Uri(uri))
		{
		}

		public Resource(string name, Uri uri)
		{
			Check.IsNotNullOrEmpty(name, nameof(name));
			_name = name;
		}
	}
}
