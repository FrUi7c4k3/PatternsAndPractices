using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Functional
{
	public class Monads
	{
		delegate T OnDemand<T>();
		
		static Nullable<T> CreateSimpleNullable<T>(T item) where T : struct
		{ 
			return new Nullable<T>(item); 
		}

		static OnDemand<T> CreateSimpleOnDemand<T>(T item)
		{ 
			return () => item; 
		}
		
		static IEnumerable<T> CreateSimpleSequence<T>(T item)
		{ 
			yield return item; 
		}

		static Lazy<T> CreateSimpleLazy<T>(Func<T> item)
		{
			return new Lazy<T>(item);
		}

		static Task<T> CreateSimpleLazy<T>(Func<T> item)
		{
			return new Task<T>(item);
		}
	}
}
