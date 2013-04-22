using System;
using System.Collections.Generic;

using System.Reactive.Linq;

namespace Querying
{
	public class ObservableSequences
	{
		public void Test()
		{
			IObservable<int> source = Observable.Range(0, 10);

			
			//Observable.Empty<int>(); // OnCompleted
			//Observable.Return(42);	// OnNext, OnCompleted
			//Observable.Range(5, 3);	// OnNext(5), OnNext(6), OnNext(7), OnCompleted
			//Observable.Never<int>(); // Never executes OnCompleted / Never terminates
			//Observable.Generate(0, i => i < 5, i => i + 1, i => i * i);
			
			// Cold run
			IDisposable subscription = source.Subscribe(x => Console.WriteLine("OnNext: {0}", x),
			                                            ex => Console.WriteLine("OnError: {0}", ex.Message),
			                                            () => Console.WriteLine("OnCompleted"));

			Console.WriteLine("Press ENTER to unsubscribe...");
			Console.ReadLine();
			subscription.Dispose();
		}
	}
}
