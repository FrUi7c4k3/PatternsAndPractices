// Type: System.Reactive.Linq.Observable
// Assembly: System.Reactive.Linq, Version=2.0.20823.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: D:\Users\G90082C\Documents\GitHub\PatternsAndPractices\Data\Querying\packages\Rx-Linq.2.0.21114\lib\Net40\System.Reactive.Linq.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Joins;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace System.Reactive.Linq
{
	/// <summary>
	/// Provides a set of static methods for writing in-memory queries over observable sequences.
	/// 
	/// </summary>
	public static class Observable
	{
		/// <summary>
		/// Invokes an action for each element in the observable sequence, and returns a Task object that will get signaled when the sequence terminates.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param>
		/// <returns>
		/// Task that signals the termination of the sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static Task ForEachAsync<TSource>(this IObservable<TSource> source, Action<TSource> onNext);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, and returns a Task object that will get signaled when the sequence terminates.
		///             The loop can be quit prematurely by setting the specified cancellation token.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="cancellationToken">Cancellation token used to stop the loop.</param>
		/// <returns>
		/// Task that signals the termination of the sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static Task ForEachAsync<TSource>(this IObservable<TSource> source, Action<TSource> onNext, CancellationToken cancellationToken);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, incorporating the element's index, and returns a Task object that will get signaled when the sequence terminates.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param>
		/// <returns>
		/// Task that signals the termination of the sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static Task ForEachAsync<TSource>(this IObservable<TSource> source, Action<TSource, int> onNext);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, incorporating the element's index, and returns a Task object that will get signaled when the sequence terminates.
		///             The loop can be quit prematurely by setting the specified cancellation token.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="cancellationToken">Cancellation token used to stop the loop.</param>
		/// <returns>
		/// Task that signals the termination of the sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static Task ForEachAsync<TSource>(this IObservable<TSource> source, Action<TSource, int> onNext, CancellationToken cancellationToken);

		/// <summary>
		/// Uses <paramref name="selector"/> to determine which source in <paramref name="sources"/> to return, choosing <paramref name="defaultSource"/> if no match is found.
		/// 
		/// </summary>
		/// <typeparam name="TValue">The type of the value returned by the selector function, used to look up the resulting source.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="selector">Selector function invoked to determine the source to lookup in the <paramref name="sources"/> dictionary.</param><param name="sources">Dictionary of sources to select from based on the <paramref name="selector"/> invocation result.</param><param name="defaultSource">Default source to select in case no matching source in <paramref name="sources"/> is found.</param>
		/// <returns>
		/// The observable sequence retrieved from the <paramref name="sources"/> dictionary based on the <paramref name="selector"/> invocation result, or <paramref name="defaultSource"/> if no match is found.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="selector"/> or <paramref name="sources"/> or <paramref name="defaultSource"/> is null.</exception>
		public static IObservable<TResult> Case<TValue, TResult>(Func<TValue> selector, IDictionary<TValue, IObservable<TResult>> sources, IObservable<TResult> defaultSource);

		/// <summary>
		/// Uses <paramref name="selector"/> to determine which source in <paramref name="sources"/> to return, choosing an empty sequence on the specified scheduler if no match is found.
		/// 
		/// </summary>
		/// <typeparam name="TValue">The type of the value returned by the selector function, used to look up the resulting source.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="selector">Selector function invoked to determine the source to lookup in the <paramref name="sources"/> dictionary.</param><param name="sources">Dictionary of sources to select from based on the <paramref name="selector"/> invocation result.</param><param name="scheduler">Scheduler to generate an empty sequence on in case no matching source in <paramref name="sources"/> is found.</param>
		/// <returns>
		/// The observable sequence retrieved from the <paramref name="sources"/> dictionary based on the <paramref name="selector"/> invocation result, or an empty sequence if no match is found.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="selector"/> or <paramref name="sources"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Case<TValue, TResult>(Func<TValue> selector, IDictionary<TValue, IObservable<TResult>> sources, IScheduler scheduler);

		/// <summary>
		/// Uses <paramref name="selector"/> to determine which source in <paramref name="sources"/> to return, choosing an empty sequence if no match is found.
		/// 
		/// </summary>
		/// <typeparam name="TValue">The type of the value returned by the selector function, used to look up the resulting source.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="selector">Selector function invoked to determine the source to lookup in the <paramref name="sources"/> dictionary.</param><param name="sources">Dictionary of sources to select from based on the <paramref name="selector"/> invocation result.</param>
		/// <returns>
		/// The observable sequence retrieved from the <paramref name="sources"/> dictionary based on the <paramref name="selector"/> invocation result, or an empty sequence if no match is found.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="selector"/> or <paramref name="sources"/> is null.</exception>
		public static IObservable<TResult> Case<TValue, TResult>(Func<TValue> selector, IDictionary<TValue, IObservable<TResult>> sources);

		/// <summary>
		/// Repeats the given <paramref name="source"/> as long as the specified <paramref name="condition"/> holds, where the <paramref name="condition"/> is evaluated after each repeated <paramref name="source"/> completed.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source to repeat as long as the <paramref name="condition"/> function evaluates to true.</param><param name="condition">Condition that will be evaluated upon the completion of an iteration through the <paramref name="source"/>, to determine whether repetition of the source is required.</param>
		/// <returns>
		/// The observable sequence obtained by concatenating the <paramref name="source"/> sequence as long as the <paramref name="condition"/> holds.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="condition"/> is null.</exception>
		public static IObservable<TSource> DoWhile<TSource>(this IObservable<TSource> source, Func<bool> condition);

		/// <summary>
		/// Concatenates the observable sequences obtained by running the <paramref name="resultSelector"/> for each element in the given enumerable <paramref name="source"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the enumerable source sequence.</typeparam><typeparam name="TResult">The type of the elements in the observable result sequence.</typeparam><param name="source">Enumerable source for which each element will be mapped onto an observable source that will be concatenated in the result sequence.</param><param name="resultSelector">Function to select an observable source for each element in the <paramref name="source"/>.</param>
		/// <returns>
		/// The observable sequence obtained by concatenating the sources returned by <paramref name="resultSelector"/> for each element in the <paramref name="source"/>.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> For<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IObservable<TResult>> resultSelector);

		/// <summary>
		/// If the specified <paramref name="condition"/> evaluates true, select the <paramref name="thenSource"/> sequence. Otherwise, select the <paramref name="elseSource"/> sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="condition">Condition evaluated to decide which sequence to return.</param><param name="thenSource">Sequence returned in case <paramref name="condition"/> evaluates true.</param><param name="elseSource">Sequence returned in case <paramref name="condition"/> evaluates false.</param>
		/// <returns>
		/// <paramref name="thenSource"/> if <paramref name="condition"/> evaluates true; <paramref name="elseSource"/> otherwise.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="thenSource"/> or <paramref name="elseSource"/> is null.</exception>
		public static IObservable<TResult> If<TResult>(Func<bool> condition, IObservable<TResult> thenSource, IObservable<TResult> elseSource);

		/// <summary>
		/// If the specified <paramref name="condition"/> evaluates true, select the <paramref name="thenSource"/> sequence. Otherwise, return an empty sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="condition">Condition evaluated to decide which sequence to return.</param><param name="thenSource">Sequence returned in case <paramref name="condition"/> evaluates true.</param>
		/// <returns>
		/// <paramref name="thenSource"/> if <paramref name="condition"/> evaluates true; an empty sequence otherwise.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="thenSource"/> is null.</exception>
		public static IObservable<TResult> If<TResult>(Func<bool> condition, IObservable<TResult> thenSource);

		/// <summary>
		/// If the specified <paramref name="condition"/> evaluates true, select the <paramref name="thenSource"/> sequence. Otherwise, return an empty sequence generated on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="condition">Condition evaluated to decide which sequence to return.</param><param name="thenSource">Sequence returned in case <paramref name="condition"/> evaluates true.</param><param name="scheduler">Scheduler to generate an empty sequence on in case <paramref name="condition"/> evaluates false.</param>
		/// <returns>
		/// <paramref name="thenSource"/> if <paramref name="condition"/> evaluates true; an empty sequence otherwise.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="thenSource"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> If<TResult>(Func<bool> condition, IObservable<TResult> thenSource, IScheduler scheduler);

		/// <summary>
		/// Repeats the given <paramref name="source"/> as long as the specified <paramref name="condition"/> holds, where the <paramref name="condition"/> is evaluated before each repeated <paramref name="source"/> is subscribed to.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source to repeat as long as the <paramref name="condition"/> function evaluates to true.</param><param name="condition">Condition that will be evaluated before subscription to the <paramref name="source"/>, to determine whether repetition of the source is required.</param>
		/// <returns>
		/// The observable sequence obtained by concatenating the <paramref name="source"/> sequence as long as the <paramref name="condition"/> holds.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="source"/> is null.</exception>
		public static IObservable<TSource> While<TSource>(Func<bool> condition, IObservable<TSource> source);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<IObservable<TResult>> FromAsyncPattern<TResult>(Func<AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, IObservable<TResult>> FromAsyncPattern<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the begin delegate.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the begin delegate.</typeparam><typeparam name="TResult">The type of the result returned by the end delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<TResult>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<IObservable<Unit>> FromAsyncPattern(Func<AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, IObservable<Unit>> FromAsyncPattern<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4>(Func<TArg1, TArg2, TArg3, TArg4, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Converts a Begin/End invoke function pair into an asynchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the begin delegate.</typeparam><typeparam name="TArg2">The type of the second argument passed to the begin delegate.</typeparam><typeparam name="TArg3">The type of the third argument passed to the begin delegate.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the begin delegate.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the begin delegate.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the begin delegate.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the begin delegate.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the begin delegate.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the begin delegate.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the begin delegate.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the begin delegate.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the begin delegate.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the begin delegate.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the begin delegate.</typeparam><param name="begin">The delegate that begins the asynchronous operation.</param><param name="end">The delegate that ends the asynchronous operation.</param>
		/// <returns>
		/// Function that can be used to start the asynchronous operation and retrieve the result (represented as a Unit value) as an observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="begin"/> or <paramref name="end"/> is null.</exception>
		/// <remarks>
		/// Each invocation of the resulting function will cause the asynchronous operation to be started. Subscription to the resulting sequence has no observable side-effect, and each subscription will produce the asynchronous operation's result.
		/// </remarks>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<Unit>> FromAsyncPattern<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, AsyncCallback, object, IAsyncResult> begin, Action<IAsyncResult> end);

		/// <summary>
		/// Invokes the specified function asynchronously, surfacing the result through an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to run asynchronously.</param>
		/// <returns>
		/// An observable sequence exposing the function's result value, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The function is called immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the function's result.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<TResult> Start<TResult>(Func<TResult> function);

		/// <summary>
		/// Invokes the specified function asynchronously on the specified scheduler, surfacing the result through an observable sequence
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to run asynchronously.</param><param name="scheduler">Scheduler to run the function on.</param>
		/// <returns>
		/// An observable sequence exposing the function's result value, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The function is called immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the function's result.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<TResult> Start<TResult>(Func<TResult> function, IScheduler scheduler);

		/// <summary>
		/// Invokes the asynchronous function, surfacing the result through an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the asynchronous function.</typeparam><param name="functionAsync">Asynchronous function to run.</param>
		/// <returns>
		/// An observable sequence exposing the function's result value, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="functionAsync"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The function is started immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the function's result.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<TResult> StartAsync<TResult>(Func<Task<TResult>> functionAsync);

		/// <summary>
		/// Invokes the asynchronous function, surfacing the result through an observable sequence.
		///             The CancellationToken is shared by all subscriptions on the resulting observable sequence. See the remarks section for more information.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the asynchronous function.</typeparam><param name="functionAsync">Asynchronous function to run.</param>
		/// <returns>
		/// An observable sequence exposing the function's result value, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="functionAsync"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The function is started immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the function's result.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>If any subscription to the resulting sequence is disposed, the CancellationToken is set. The observer associated to the disposed
		///             subscription won't see the TaskCanceledException, but other observers will. You can protect against this using the Catch operator.
		///             Be careful when handing out the resulting sequence because of this behavior. The most common use is to have a single subscription
		///             to the resulting sequence, which controls the CancellationToken state. Alternatively, you can control subscription behavior using
		///             multicast operators.
		///             </description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<TResult> StartAsync<TResult>(Func<CancellationToken, Task<TResult>> functionAsync);

		/// <summary>
		/// Invokes the action asynchronously, surfacing the result through an observable sequence.
		/// 
		/// </summary>
		/// <param name="action">Action to run asynchronously.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The action is called immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the action's outcome.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<Unit> Start(Action action);

		/// <summary>
		/// Invokes the action asynchronously on the specified scheduler, surfacing the result through an observable sequence.
		/// 
		/// </summary>
		/// <param name="action">Action to run asynchronously.</param><param name="scheduler">Scheduler to run the action on.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The action is called immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the action's outcome.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<Unit> Start(Action action, IScheduler scheduler);

		/// <summary>
		/// Invokes the asynchronous action, surfacing the result through an observable sequence.
		/// 
		/// </summary>
		/// <param name="actionAsync">Asynchronous action to run.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="actionAsync"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The action is started immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the action's outcome.</description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<Unit> StartAsync(Func<Task> actionAsync);

		/// <summary>
		/// Invokes the asynchronous action, surfacing the result through an observable sequence.
		///             The CancellationToken is shared by all subscriptions on the resulting observable sequence. See the remarks section for more information.
		/// 
		/// </summary>
		/// <param name="actionAsync">Asynchronous action to run.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="actionAsync"/> is null.</exception>
		/// <remarks>
		/// 
		/// <list type="bullet">
		/// 
		/// <item>
		/// <description>The action is started immediately, not during the subscription of the resulting sequence.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>Multiple subscriptions to the resulting sequence can observe the action's outcome.</description>
		/// </item>
		/// 
		/// <item>
		/// <description>If any subscription to the resulting sequence is disposed, the CancellationToken is set. The observer associated to the disposed
		///             subscription won't see the TaskCanceledException, but other observers will. You can protect against this using the Catch operator.
		///             Be careful when handing out the resulting sequence because of this behavior. The most common use is to have a single subscription
		///             to the resulting sequence, which controls the CancellationToken state. Alternatively, you can control subscription behavior using
		///             multicast operators.
		///             </description>
		/// </item>
		/// 
		/// </list>
		/// 
		/// </remarks>
		public static IObservable<Unit> StartAsync(Func<CancellationToken, Task> actionAsync);

		/// <summary>
		/// Converts to asynchronous function into an observable sequence. Each subscription to the resulting sequence causes the function to be started.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the asynchronous function.</typeparam><param name="functionAsync">Asynchronous function to convert.</param>
		/// <returns>
		/// An observable sequence exposing the result of invoking the function, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="functionAsync"/> is null.</exception>
		public static IObservable<TResult> FromAsync<TResult>(Func<Task<TResult>> functionAsync);

		/// <summary>
		/// Converts to asynchronous function into an observable sequence. Each subscription to the resulting sequence causes the function to be started.
		///             The CancellationToken passed to the asynchronous function is tied to the observable sequence's subscription that triggered the function's invocation and can be used for best-effort cancellation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the asynchronous function.</typeparam><param name="functionAsync">Asynchronous function to convert.</param>
		/// <returns>
		/// An observable sequence exposing the result of invoking the function, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="functionAsync"/> is null.</exception>
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous function will be signaled.
		/// </remarks>
		public static IObservable<TResult> FromAsync<TResult>(Func<CancellationToken, Task<TResult>> functionAsync);

		/// <summary>
		/// Converts to asynchronous action into an observable sequence. Each subscription to the resulting sequence causes the action to be started.
		/// 
		/// </summary>
		/// <param name="actionAsync">Asynchronous action to convert.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="actionAsync"/> is null.</exception>
		public static IObservable<Unit> FromAsync(Func<Task> actionAsync);

		/// <summary>
		/// Converts to asynchronous action into an observable sequence. Each subscription to the resulting sequence causes the action to be started.
		///             The CancellationToken passed to the asynchronous action is tied to the observable sequence's subscription that triggered the action's invocation and can be used for best-effort cancellation.
		/// 
		/// </summary>
		/// <param name="actionAsync">Asynchronous action to convert.</param>
		/// <returns>
		/// An observable sequence exposing a Unit value upon completion of the action, or an exception.
		/// </returns>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous function will be signaled.
		/// </remarks>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="actionAsync"/> is null.</exception>
		public static IObservable<Unit> FromAsync(Func<CancellationToken, Task> actionAsync);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<IObservable<TResult>> ToAsync<TResult>(this Func<TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<IObservable<TResult>> ToAsync<TResult>(this Func<TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, IObservable<TResult>> ToAsync<TArg1, TResult>(this Func<TArg1, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, IObservable<TResult>> ToAsync<TArg1, TResult>(this Func<TArg1, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, IObservable<TResult>> ToAsync<TArg1, TArg2, TResult>(this Func<TArg1, TArg2, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, IObservable<TResult>> ToAsync<TArg1, TArg2, TResult>(this Func<TArg1, TArg2, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TResult>(this Func<TArg1, TArg2, TArg3, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TResult>(this Func<TArg1, TArg2, TArg3, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the function.</typeparam><typeparam name="TArg16">The type of the sixteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function);

		/// <summary>
		/// Converts the function into an asynchronous function. Each invocation of the resulting asynchronous function causes an invocation of the original synchronous function on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the function.</typeparam><typeparam name="TArg2">The type of the second argument passed to the function.</typeparam><typeparam name="TArg3">The type of the third argument passed to the function.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the function.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the function.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the function.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the function.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the function.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the function.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the function.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the function.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the function.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the function.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the function.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the function.</typeparam><typeparam name="TArg16">The type of the sixteenth argument passed to the function.</typeparam><typeparam name="TResult">The type of the result returned by the function.</typeparam><param name="function">Function to convert to an asynchronous function.</param><param name="scheduler">Scheduler to invoke the original function on.</param>
		/// <returns>
		/// Asynchronous function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="function"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, IObservable<TResult>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<IObservable<Unit>> ToAsync(this Action action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<IObservable<Unit>> ToAsync(this Action action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, IObservable<Unit>> ToAsync<TArg1>(this Action<TArg1> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, IObservable<Unit>> ToAsync<TArg1>(this Action<TArg1> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, IObservable<Unit>> ToAsync<TArg1, TArg2>(this Action<TArg1, TArg2> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, IObservable<Unit>> ToAsync<TArg1, TArg2>(this Action<TArg1, TArg2> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3>(this Action<TArg1, TArg2, TArg3> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3>(this Action<TArg1, TArg2, TArg3> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4>(this Action<TArg1, TArg2, TArg3, TArg4> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4>(this Action<TArg1, TArg2, TArg3, TArg4> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> action, IScheduler scheduler);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the default scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the action.</typeparam><typeparam name="TArg16">The type of the sixteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> action);

		/// <summary>
		/// Converts the function into an asynchronous action. Each invocation of the resulting asynchronous action causes an invocation of the original synchronous action on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument passed to the action.</typeparam><typeparam name="TArg2">The type of the second argument passed to the action.</typeparam><typeparam name="TArg3">The type of the third argument passed to the action.</typeparam><typeparam name="TArg4">The type of the fourth argument passed to the action.</typeparam><typeparam name="TArg5">The type of the fifth argument passed to the action.</typeparam><typeparam name="TArg6">The type of the sixth argument passed to the action.</typeparam><typeparam name="TArg7">The type of the seventh argument passed to the action.</typeparam><typeparam name="TArg8">The type of the eighth argument passed to the action.</typeparam><typeparam name="TArg9">The type of the ninth argument passed to the action.</typeparam><typeparam name="TArg10">The type of the tenth argument passed to the action.</typeparam><typeparam name="TArg11">The type of the eleventh argument passed to the action.</typeparam><typeparam name="TArg12">The type of the twelfth argument passed to the action.</typeparam><typeparam name="TArg13">The type of the thirteenth argument passed to the action.</typeparam><typeparam name="TArg14">The type of the fourteenth argument passed to the action.</typeparam><typeparam name="TArg15">The type of the fifteenth argument passed to the action.</typeparam><typeparam name="TArg16">The type of the sixteenth argument passed to the action.</typeparam><param name="action">Action to convert to an asynchronous action.</param><param name="scheduler">Scheduler to invoke the original action on.</param>
		/// <returns>
		/// Asynchronous action.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="action"/> or <paramref name="scheduler"/> is null.</exception>
		public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, IObservable<Unit>> ToAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> action, IScheduler scheduler);

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(Action<EventHandler> addHandler, Action<EventHandler> removeHandler);

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(Action<EventHandler> addHandler, Action<EventHandler> removeHandler, IScheduler scheduler);

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on a supplied event delegate type, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on a supplied event delegate type, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler`1"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="conversion">A function used to convert the given event handler to a delegate compatible with the underlying .NET event. The resulting delegate is used in calls to the addHandler and removeHandler action parameters.</param><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="conversion"/> or <paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Func<EventHandler<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler`1"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="conversion">A function used to convert the given event handler to a delegate compatible with the underlying .NET event. The resulting delegate is used in calls to the addHandler and removeHandler action parameters.</param><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="conversion"/> or <paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TDelegate, TEventArgs>(Func<EventHandler<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on a supplied event delegate type with a strongly typed sender parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TDelegate, TSender, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on a supplied event delegate type with a strongly typed sender parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TDelegate, TSender, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler`1"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// 
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(Action<EventHandler<TEventArgs>> addHandler, Action<EventHandler<TEventArgs>> removeHandler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event, conforming to the standard .NET event pattern based on <see cref="T:System.EventHandler`1"/>, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// 
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(Action<EventHandler<TEventArgs>> addHandler, Action<EventHandler<TEventArgs>> removeHandler, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with an <see cref="T:System.EventArgs"/> parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(object target, string eventName);

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with an <see cref="T:System.EventArgs"/> parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(object target, string eventName, IScheduler scheduler);

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(object target, string eventName) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(object target, string eventName, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with a strongly typed sender and strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's first argument type is not assignable to TSender. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(object target, string eventName) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts an instance .NET event, conforming to the standard .NET event pattern with a strongly typed sender and strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the target object type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="target">Object instance that exposes the event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's first argument type is not assignable to TSender. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(object target, string eventName, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with an <see cref="T:System.EventArgs"/> parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(Type type, string eventName);

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with an <see cref="T:System.EventArgs"/> parameter, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<EventArgs>> FromEventPattern(Type type, string eventName, IScheduler scheduler);

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(Type type, string eventName) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TEventArgs>> FromEventPattern<TEventArgs>(Type type, string eventName, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with a strongly typed sender and strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's first argument type is not assignable to TSender. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEventPattern, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEventPattern, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(Type type, string eventName) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a static .NET event, conforming to the standard .NET event pattern with a strongly typed sender and strongly typed event arguments, to an observable sequence.
		///             Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             Reflection is used to discover the event based on the specified type and the specified event name.
		///             For conversion of events that don't conform to the standard .NET event pattern, use any of the FromEvent overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TSender">The type of the sender that raises the event.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="type">Type that exposes the static event to convert.</param><param name="eventName">Name of the event to convert.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains data representations of invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="eventName"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.InvalidOperationException">The event could not be found. -or- The event does not conform to the standard .NET event pattern. -or- The event's first argument type is not assignable to TSender. -or- The event's second argument type is not assignable to TEventArgs.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEventPattern calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEventPattern that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEventPattern``1(System.IObservable{System.Reactive.EventPattern{``0}})"/>
		public static IObservable<EventPattern<TSender, TEventArgs>> FromEventPattern<TSender, TEventArgs>(Type type, string eventName, IScheduler scheduler) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts a .NET event to an observable sequence, using a conversion function to obtain the event delegate. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="conversion">A function used to convert the given event handler to a delegate compatible with the underlying .NET event. The resulting delegate is used in calls to the addHandler and removeHandler action parameters.</param><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="conversion"/> or <paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEvent, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEvent, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler);

		/// <summary>
		/// Converts a .NET event to an observable sequence, using a conversion function to obtain the event delegate. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="conversion">A function used to convert the given event handler to a delegate compatible with the underlying .NET event. The resulting delegate is used in calls to the addHandler and removeHandler action parameters.</param><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="conversion"/> or <paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEvent that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Func<Action<TEventArgs>, TDelegate> conversion, Action<TDelegate> addHandler, Action<TDelegate> removeHandler, IScheduler scheduler);

		/// <summary>
		/// Converts a .NET event to an observable sequence, using a supplied event delegate type. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEvent, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEvent, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler);

		/// <summary>
		/// Converts a .NET event to an observable sequence, using a supplied event delegate type. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TDelegate">The delegate type of the event to be converted.</typeparam><typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEvent that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TDelegate, TEventArgs>(Action<TDelegate> addHandler, Action<TDelegate> removeHandler, IScheduler scheduler);

		/// <summary>
		/// Converts a generic Action-based .NET event to an observable sequence. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEvent, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEvent, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TEventArgs>(Action<Action<TEventArgs>> addHandler, Action<Action<TEventArgs>> removeHandler);

		/// <summary>
		/// Converts a generic Action-based .NET event to an observable sequence. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEvent that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<TEventArgs> FromEvent<TEventArgs>(Action<Action<TEventArgs>> addHandler, Action<Action<TEventArgs>> removeHandler, IScheduler scheduler);

		/// <summary>
		/// Converts an Action-based .NET event to an observable sequence. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The current <see cref="T:System.Threading.SynchronizationContext"/> is captured during the call to FromEvent, and is used to post add and remove handler invocations.
		///             This behavior ensures add and remove handler operations for thread-affine events are accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// If no SynchronizationContext is present at the point of calling FromEvent, add and remove handler invocations are made synchronously on the thread
		///             making the Subscribe or Dispose call, respectively.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions due to the free-threaded nature of Reactive Extensions. Doing so
		///             makes the captured SynchronizationContext predictable. This best practice also reduces clutter of bridging code inside queries, making the query expressions
		///             more concise and easier to understand.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<Unit> FromEvent(Action<Action> addHandler, Action<Action> removeHandler);

		/// <summary>
		/// Converts an Action-based .NET event to an observable sequence. Each event invocation is surfaced through an OnNext message in the resulting sequence.
		///             For conversion of events conforming to the standard .NET event pattern, use any of the FromEventPattern overloads instead.
		/// 
		/// </summary>
		/// <param name="addHandler">Action that attaches the given event handler to the underlying .NET event.</param><param name="removeHandler">Action that detaches the given event handler from the underlying .NET event.</param><param name="scheduler">The scheduler to run the add and remove event handler logic on.</param>
		/// <returns>
		/// The observable sequence that contains the event argument objects passed to the invocations of the underlying .NET event.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="addHandler"/> or <paramref name="removeHandler"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Add and remove handler invocations are made whenever the number of observers grows beyond zero.
		///             As such, an event handler may be shared by multiple simultaneously active observers, using a subject for multicasting.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Add and remove handler invocations are run on the specified scheduler. This behavior allows add and remove handler operations for thread-affine events to be
		///             accessed from the same context, as required by some UI frameworks.
		/// 
		/// </para>
		/// 
		/// <para>
		/// It's recommended to lift FromEvent calls outside event stream query expressions. This best practice reduces clutter of bridging code inside queries,
		///             making the query expressions more concise and easier to understand. This has additional benefits for overloads of FromEvent that omit the IScheduler
		///             parameter. For more information, see the remarks section on those overloads.
		/// 
		/// </para>
		/// 
		/// </remarks>
		/// <seealso cref="M:System.Reactive.Linq.Observable.ToEvent(System.IObservable{System.Reactive.Unit})"/>
		public static IObservable<Unit> FromEvent(Action<Action> addHandler, Action<Action> removeHandler, IScheduler scheduler);

		/// <summary>
		/// Applies an accumulator function over an observable sequence, returning the result of the aggregation as a single element in the result sequence. The specified seed value is used as the initial accumulator value.
		///             For aggregation behavior with incremental intermediate results, see <see cref="M:System.Reactive.Linq.Observable.Scan``2(System.IObservable{``0},``1,System.Func{``1,``0,``1})"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TAccumulate">The type of the result of the aggregation.</typeparam><param name="source">An observable sequence to aggregate over.</param><param name="seed">The initial accumulator value.</param><param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the final accumulator value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="accumulator"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TAccumulate> Aggregate<TSource, TAccumulate>(this IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator);

		/// <summary>
		/// Applies an accumulator function over an observable sequence, returning the result of the aggregation as a single element in the result sequence. The specified seed value is used as the initial accumulator value,
		///             and the specified result selector function is used to select the result value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TAccumulate">The type of the accumulator value.</typeparam><typeparam name="TResult">The type of the resulting value.</typeparam><param name="source">An observable sequence to aggregate over.</param><param name="seed">The initial accumulator value.</param><param name="accumulator">An accumulator function to be invoked on each element.</param><param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
		/// <returns>
		/// An observable sequence containing a single element with the final accumulator value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="accumulator"/> or <paramref name="resultSelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TResult> Aggregate<TSource, TAccumulate, TResult>(this IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector);

		/// <summary>
		/// Applies an accumulator function over an observable sequence, returning the result of the aggregation as a single element in the result sequence.
		///             For aggregation behavior with incremental intermediate results, see <see cref="M:System.Reactive.Linq.Observable.Scan``1(System.IObservable{``0},System.Func{``0,``0,``0})"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the result of the aggregation.</typeparam><param name="source">An observable sequence to aggregate over.</param><param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the final accumulator value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="accumulator"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource> Aggregate<TSource>(this IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator);

		/// <summary>
		/// Determines whether all elements of an observable sequence satisfy a condition.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence whose elements to apply the predicate to.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether all elements in the source sequence pass the test in the specified predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> All<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Determines whether an observable sequence contains any elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to check for non-emptiness.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether the source sequence contains any elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> Any<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Determines whether any element of an observable sequence satisfies a condition.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence whose elements to apply the predicate to.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether any elements in the source sequence pass the test in the specified predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> Any<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Double"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average(this IObservable<double> source);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Single"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Average(this IObservable<float> source);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Decimal"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Average(this IObservable<decimal> source);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int32"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average(this IObservable<int> source);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int64"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average(this IObservable<long> source);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Double"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Average(this IObservable<double?> source);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Single"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Average(this IObservable<float?> source);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Decimal"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Average(this IObservable<decimal?> source);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int32"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		/// <exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		public static IObservable<double?> Average(this IObservable<int?> source);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int64"/> values to calculate the average of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Average(this IObservable<long?> source);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Decimal"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Average<TSource>(this IObservable<TSource> source, Func<TSource, decimal> selector);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Double"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average<TSource>(this IObservable<TSource> source, Func<TSource, double> selector);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Single"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Average<TSource>(this IObservable<TSource> source, Func<TSource, float> selector);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Int32"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average<TSource>(this IObservable<TSource> source, Func<TSource, int> selector);

		/// <summary>
		/// Computes the average of an observable sequence of <see cref="T:System.Int64"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Average<TSource>(this IObservable<TSource> source, Func<TSource, long> selector);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Decimal"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Average<TSource>(this IObservable<TSource> source, Func<TSource, decimal?> selector);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Double"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Average<TSource>(this IObservable<TSource> source, Func<TSource, double?> selector);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Single"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Average<TSource>(this IObservable<TSource> source, Func<TSource, float?> selector);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Int32"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Average<TSource>(this IObservable<TSource> source, Func<TSource, int?> selector);

		/// <summary>
		/// Computes the average of an observable sequence of nullable <see cref="T:System.Int64"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to calculate the average of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the average of the sequence of values, or null if the source sequence is empty or contains only values that are null.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Average<TSource>(this IObservable<TSource> source, Func<TSource, long?> selector);

		/// <summary>
		/// Determines whether an observable sequence contains a specified element by using the default equality comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence in which to locate a value.</param><param name="value">The value to locate in the source sequence.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether the source sequence contains an element that has the specified value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> Contains<TSource>(this IObservable<TSource> source, TSource value);

		/// <summary>
		/// Determines whether an observable sequence contains a specified element by using a specified System.Collections.Generic.IEqualityComparer&lt;T&gt;.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence in which to locate a value.</param><param name="value">The value to locate in the source sequence.</param><param name="comparer">An equality comparer to compare elements.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether the source sequence contains an element that has the specified value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> Contains<TSource>(this IObservable<TSource> source, TSource value, IEqualityComparer<TSource> comparer);

		/// <summary>
		/// Returns an observable sequence containing an <see cref="T:System.Int32"/> that represents the total number of elements in an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence that contains elements to be counted.</param>
		/// <returns>
		/// An observable sequence containing a single element with the number of elements in the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The number of elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Count<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence containing an <see cref="T:System.Int32"/> that represents how many elements in the specified observable sequence satisfy a condition.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence that contains elements to be counted.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence containing a single element with a number that represents how many elements in the input sequence satisfy the condition in the predicate function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Count<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the element at a specified index in a sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to return the element from.</param><param name="index">The zero-based index of the element to retrieve.</param>
		/// <returns>
		/// An observable sequence that produces the element at the specified position in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than zero.</exception><exception cref="T:System.ArgumentOutOfRangeException">(Asynchronous) <paramref name="index"/> is greater than or equal to the number of elements in the source sequence.</exception>
		public static IObservable<TSource> ElementAt<TSource>(this IObservable<TSource> source, int index);

		/// <summary>
		/// Returns the element at a specified index in a sequence or a default value if the index is out of range.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to return the element from.</param><param name="index">The zero-based index of the element to retrieve.</param>
		/// <returns>
		/// An observable sequence that produces the element at the specified position in the source sequence, or a default value if the index is outside the bounds of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than zero.</exception>
		public static IObservable<TSource> ElementAtOrDefault<TSource>(this IObservable<TSource> source, int index);

		/// <summary>
		/// Returns the first element of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the first element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		public static IObservable<TSource> FirstAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the first element of an observable sequence that satisfies the condition in the predicate.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the first element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) No element satisfies the condition in the predicate. -or- The source sequence is empty.</exception>
		public static IObservable<TSource> FirstAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the first element of an observable sequence, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the first element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> FirstOrDefaultAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the first element of an observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the first element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> FirstOrDefaultAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Determines whether an observable sequence is empty.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to check for emptiness.</param>
		/// <returns>
		/// An observable sequence containing a single element determining whether the source sequence is empty.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<bool> IsEmpty<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the last element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence is empty.</exception>
		public static IObservable<TSource> LastAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence that satisfies the condition in the predicate.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the last element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) No element satisfies the condition in the predicate. -or- The source sequence is empty.</exception>
		public static IObservable<TSource> LastAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the last element of an observable sequence, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the last element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> LastOrDefaultAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the last element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> LastOrDefaultAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns an observable sequence containing an <see cref="T:System.Int64"/> that represents the total number of elements in an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence that contains elements to be counted.</param>
		/// <returns>
		/// An observable sequence containing a single element with the number of elements in the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The number of elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> LongCount<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence containing an <see cref="T:System.Int64"/> that represents how many elements in the specified observable sequence satisfy a condition.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence that contains elements to be counted.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence containing a single element with a number that represents how many elements in the input sequence satisfy the condition in the predicate function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> LongCount<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the maximum element in an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to determine the maximum element of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource> Max<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to determine the maximum element of.</param><param name="comparer">Comparer used to compare elements.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource> Max<TSource>(this IObservable<TSource> source, IComparer<TSource> comparer);

		/// <summary>
		/// Returns the maximum value in an observable sequence of <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Double"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Max(this IObservable<double> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Single"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Max(this IObservable<float> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Decimal"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Max(this IObservable<decimal> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int32"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Max(this IObservable<int> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int64"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Max(this IObservable<long> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of nullable <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Double"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Max(this IObservable<double?> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of nullable <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Single"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Max(this IObservable<float?> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of nullable <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Decimal"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Max(this IObservable<decimal?> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of nullable <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int32"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Max(this IObservable<int?> source);

		/// <summary>
		/// Returns the maximum value in an observable sequence of nullable <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int64"/> values to determine the maximum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Max(this IObservable<long?> source);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the objects derived from the elements in the source sequence to determine the maximum of.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value that corresponds to the maximum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TResult> Max<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum value according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the objects derived from the elements in the source sequence to determine the maximum of.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param><param name="selector">A transform function to apply to each element.</param><param name="comparer">Comparer used to compare elements.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value that corresponds to the maximum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TResult> Max<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector, IComparer<TResult> comparer);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum <see cref="T:System.Double"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Double"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Max<TSource>(this IObservable<TSource> source, Func<TSource, double> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum <see cref="T:System.Single"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Single"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Max<TSource>(this IObservable<TSource> source, Func<TSource, float> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum <see cref="T:System.Decimal"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Decimal"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Max<TSource>(this IObservable<TSource> source, Func<TSource, decimal> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum <see cref="T:System.Int32"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Int32"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Max<TSource>(this IObservable<TSource> source, Func<TSource, int> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum <see cref="T:System.Int64"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Int64"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Max<TSource>(this IObservable<TSource> source, Func<TSource, long> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum nullable <see cref="T:System.Double"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Double>"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Max<TSource>(this IObservable<TSource> source, Func<TSource, double?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum nullable <see cref="T:System.Single"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Single>"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Max<TSource>(this IObservable<TSource> source, Func<TSource, float?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum nullable <see cref="T:System.Decimal"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Decimal>"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Max<TSource>(this IObservable<TSource> source, Func<TSource, decimal?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum nullable <see cref="T:System.Int32"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Int32>"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Max<TSource>(this IObservable<TSource> source, Func<TSource, int?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the maximum nullable <see cref="T:System.Int64"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the maximum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Int64>"/> that corresponds to the maximum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Max<TSource>(this IObservable<TSource> source, Func<TSource, long?> selector);

		/// <summary>
		/// Returns the elements in an observable sequence with the maximum key value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to get the maximum elements for.</param><param name="keySelector">Key selector function.</param>
		/// <returns>
		/// An observable sequence containing a list of zero or more elements that have a maximum key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IList<TSource>> MaxBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Returns the elements in an observable sequence with the maximum key value according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to get the maximum elements for.</param><param name="keySelector">Key selector function.</param><param name="comparer">Comparer used to compare key values.</param>
		/// <returns>
		/// An observable sequence containing a list of zero or more elements that have a maximum key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IList<TSource>> MaxBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);

		/// <summary>
		/// Returns the minimum element in an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource> Min<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the minimum element in an observable sequence according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param><param name="comparer">Comparer used to compare elements.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource> Min<TSource>(this IObservable<TSource> source, IComparer<TSource> comparer);

		/// <summary>
		/// Returns the minimum value in an observable sequence of <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Double"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Min(this IObservable<double> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Single"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Min(this IObservable<float> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Decimal"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Min(this IObservable<decimal> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int32"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Min(this IObservable<int> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int64"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Min(this IObservable<long> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of nullable <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Double"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Min(this IObservable<double?> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of nullable <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Single"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Min(this IObservable<float?> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of nullable <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Decimal"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Min(this IObservable<decimal?> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of nullable <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int32"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Min(this IObservable<int?> source);

		/// <summary>
		/// Returns the minimum value in an observable sequence of nullable <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int64"/> values to determine the minimum value of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Min(this IObservable<long?> source);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the objects derived from the elements in the source sequence to determine the minimum of.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value that corresponds to the minimum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TResult> Min<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum value according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the objects derived from the elements in the source sequence to determine the minimum of.</typeparam><param name="source">An observable sequence to determine the mimimum element of.</param><param name="selector">A transform function to apply to each element.</param><param name="comparer">Comparer used to compare elements.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value that corresponds to the minimum element in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TResult> Min<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector, IComparer<TResult> comparer);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum <see cref="T:System.Double"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Double"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Min<TSource>(this IObservable<TSource> source, Func<TSource, double> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum <see cref="T:System.Single"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Single"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Min<TSource>(this IObservable<TSource> source, Func<TSource, float> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum <see cref="T:System.Decimal"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Decimal"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Min<TSource>(this IObservable<TSource> source, Func<TSource, decimal> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum <see cref="T:System.Int32"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Int32"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Min<TSource>(this IObservable<TSource> source, Func<TSource, int> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum <see cref="T:System.Int64"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Int64"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Min<TSource>(this IObservable<TSource> source, Func<TSource, long> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum nullable <see cref="T:System.Double"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Double>"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Min<TSource>(this IObservable<TSource> source, Func<TSource, double?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum nullable <see cref="T:System.Single"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Single>"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Min<TSource>(this IObservable<TSource> source, Func<TSource, float?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum nullable <see cref="T:System.Decimal"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Decimal>"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Min<TSource>(this IObservable<TSource> source, Func<TSource, decimal?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum nullable <see cref="T:System.Int32"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Int32>"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Min<TSource>(this IObservable<TSource> source, Func<TSource, int?> selector);

		/// <summary>
		/// Invokes a transform function on each element of a sequence and returns the minimum nullable <see cref="T:System.Int64"/> value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values to determine the minimum value of.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the value of type <see cref="T:System.Nullable<System.Int64>"/> that corresponds to the minimum value in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Min<TSource>(this IObservable<TSource> source, Func<TSource, long?> selector);

		/// <summary>
		/// Returns the elements in an observable sequence with the minimum key value.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to get the minimum elements for.</param><param name="keySelector">Key selector function.</param>
		/// <returns>
		/// An observable sequence containing a list of zero or more elements that have a minimum key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IList<TSource>> MinBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Returns the elements in an observable sequence with the minimum key value according to the specified comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to get the minimum elements for.</param><param name="keySelector">Key selector function.</param><param name="comparer">Comparer used to compare key values.</param>
		/// <returns>
		/// An observable sequence containing a list of zero or more elements that have a minimum key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IList<TSource>> MinBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer);

		/// <summary>
		/// Determines whether two sequences are equal by comparing the elements pairwise.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="first">First observable sequence to compare.</param><param name="second">Second observable sequence to compare.</param>
		/// <returns>
		/// An observable sequence that contains a single element which indicates whether both sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> SequenceEqual<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Determines whether two sequences are equal by comparing the elements pairwise using a specified equality comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="first">First observable sequence to compare.</param><param name="second">Second observable sequence to compare.</param><param name="comparer">Comparer used to compare elements of both sequences.</param>
		/// <returns>
		/// An observable sequence that contains a single element which indicates whether both sequences are of equal length and their corresponding elements are equal according to the specified equality comparer.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> SequenceEqual<TSource>(this IObservable<TSource> first, IObservable<TSource> second, IEqualityComparer<TSource> comparer);

		/// <summary>
		/// Determines whether an observable and enumerable sequence are equal by comparing the elements pairwise.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="first">First observable sequence to compare.</param><param name="second">Second observable sequence to compare.</param>
		/// <returns>
		/// An observable sequence that contains a single element which indicates whether both sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> SequenceEqual<TSource>(this IObservable<TSource> first, IEnumerable<TSource> second);

		/// <summary>
		/// Determines whether an observable and enumerable sequence are equal by comparing the elements pairwise using a specified equality comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="first">First observable sequence to compare.</param><param name="second">Second observable sequence to compare.</param><param name="comparer">Comparer used to compare elements of both sequences.</param>
		/// <returns>
		/// An observable sequence that contains a single element which indicates whether both sequences are of equal length and their corresponding elements are equal according to the specified equality comparer.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<bool> SequenceEqual<TSource>(this IObservable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer);

		/// <summary>
		/// Returns the only element of an observable sequence, and reports an exception if there is not exactly one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the single element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence contains more than one element. -or- The source sequence is empty.</exception>
		public static IObservable<TSource> SingleAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the only element of an observable sequence that satisfies the condition in the predicate, and reports an exception if there is not exactly one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the single element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) No element satisfies the condition in the predicate. -or- More than one element satisfies the condition in the predicate. -or- The source sequence is empty.</exception>
		public static IObservable<TSource> SingleAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the only element of an observable sequence, or a default value if the observable sequence is empty; this method reports an exception if there is more than one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// Sequence containing the single element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The source sequence contains more than one element.</exception>
		public static IObservable<TSource> SingleOrDefaultAsync<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the only element of an observable sequence that matches the predicate, or a default value if no such element exists; this method reports an exception if there is more than one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// Sequence containing the single element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">(Asynchronous) The sequence contains more than one element that satisfies the condition in the predicate.</exception>
		public static IObservable<TSource> SingleOrDefaultAsync<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Double"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Sum(this IObservable<double> source);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Single"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Sum(this IObservable<float> source);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Decimal"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Sum(this IObservable<decimal> source);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int32"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int32.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Sum(this IObservable<int> source);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of <see cref="T:System.Int64"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Sum(this IObservable<long> source);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Double"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Double"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Sum(this IObservable<double?> source);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Single"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Single"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Sum(this IObservable<float?> source);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Decimal"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Decimal"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Sum(this IObservable<decimal?> source);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Int32"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int32"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int32.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Sum(this IObservable<int?> source);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Int64"/> values.
		/// 
		/// </summary>
		/// <param name="source">A sequence of nullable <see cref="T:System.Int64"/> values to calculate the sum of.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Sum(this IObservable<long?> source);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Double"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double> Sum<TSource>(this IObservable<TSource> source, Func<TSource, double> selector);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Single"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float> Sum<TSource>(this IObservable<TSource> source, Func<TSource, float> selector);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Decimal"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal> Sum<TSource>(this IObservable<TSource> source, Func<TSource, decimal> selector);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Int32"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int32.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int> Sum<TSource>(this IObservable<TSource> source, Func<TSource, int> selector);

		/// <summary>
		/// Computes the sum of a sequence of <see cref="T:System.Int64"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long> Sum<TSource>(this IObservable<TSource> source, Func<TSource, long> selector);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Double"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<double?> Sum<TSource>(this IObservable<TSource> source, Func<TSource, double?> selector);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Single"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<float?> Sum<TSource>(this IObservable<TSource> source, Func<TSource, float?> selector);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Decimal"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Decimal.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<decimal?> Sum<TSource>(this IObservable<TSource> source, Func<TSource, decimal?> selector);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Int32"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int32.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<int?> Sum<TSource>(this IObservable<TSource> source, Func<TSource, int?> selector);

		/// <summary>
		/// Computes the sum of a sequence of nullable <see cref="T:System.Int64"/> values that are obtained by invoking a transform function on each element of the input sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence of values that are used to calculate a sum.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with the sum of the values in the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.OverflowException">(Asynchronous) The sum of the projected values for the elements in the source sequence is larger than <see cref="M:System.Int64.MaxValue"/>.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<long?> Sum<TSource>(this IObservable<TSource> source, Func<TSource, long?> selector);

		/// <summary>
		/// Creates an array from an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">The source observable sequence to get an array of elements for.</param>
		/// <returns>
		/// An observable sequence containing a single element with an array containing all the elements of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<TSource[]> ToArray<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Creates a dictionary from an observable sequence according to a specified key selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the dictionary key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a dictionary for.</param><param name="keySelector">A function to extract a key from each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with a dictionary mapping unique key values onto the corresponding source sequence's element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IDictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Creates a dictionary from an observable sequence according to a specified key selector function, and a comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the dictionary key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a dictionary for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="comparer">An equality comparer to compare keys.</param>
		/// <returns>
		/// An observable sequence containing a single element with a dictionary mapping unique key values onto the corresponding source sequence's element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IDictionary<TKey, TSource>> ToDictionary<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Creates a dictionary from an observable sequence according to a specified key selector function, and an element selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the dictionary key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the dictionary value computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a dictionary for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with a dictionary mapping unique key values onto the corresponding source sequence's element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IDictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);

		/// <summary>
		/// Creates a dictionary from an observable sequence according to a specified key selector function, a comparer, and an element selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the dictionary key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the dictionary value computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a dictionary for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="elementSelector">A transform function to produce a result element value from each element.</param><param name="comparer">An equality comparer to compare keys.</param>
		/// <returns>
		/// An observable sequence containing a single element with a dictionary mapping unique key values onto the corresponding source sequence's element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IDictionary<TKey, TElement>> ToDictionary<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Creates a list from an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">The source observable sequence to get a list of elements for.</param>
		/// <returns>
		/// An observable sequence containing a single element with a list containing all the elements of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<IList<TSource>> ToList<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Creates a lookup from an observable sequence according to a specified key selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the lookup key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a lookup for.</param><param name="keySelector">A function to extract a key from each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with a lookup mapping unique key values onto the corresponding source sequence's elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Creates a lookup from an observable sequence according to a specified key selector function, and a comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the lookup key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a lookup for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="comparer">An equality comparer to compare keys.</param>
		/// <returns>
		/// An observable sequence containing a single element with a lookup mapping unique key values onto the corresponding source sequence's elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<ILookup<TKey, TSource>> ToLookup<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Creates a lookup from an observable sequence according to a specified key selector function, and an element selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the lookup key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the lookup value computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a lookup for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="elementSelector">A transform function to produce a result element value from each element.</param>
		/// <returns>
		/// An observable sequence containing a single element with a lookup mapping unique key values onto the corresponding source sequence's elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);

		/// <summary>
		/// Creates a lookup from an observable sequence according to a specified key selector function, a comparer, and an element selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the lookup key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the lookup value computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to create a lookup for.</param><param name="keySelector">A function to extract a key from each element.</param><param name="elementSelector">A transform function to produce a result element value from each element.</param><param name="comparer">An equality comparer to compare keys.</param>
		/// <returns>
		/// An observable sequence containing a single element with a lookup mapping unique key values onto the corresponding source sequence's elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// The return type of this operator differs from the corresponding operator on IEnumerable in order to retain asynchronous behavior.
		/// </remarks>
		public static IObservable<ILookup<TKey, TElement>> ToLookup<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Multicasts the source sequence notifications through the specified subject to the resulting connectable observable. Upon connection of the
		///             connectable observable, the subject is subscribed to the source exactly one, and messages are forwarded to the observers registered with
		///             the connectable observable. For specializations with fixed subject types, see Publish, PublishLast, and Replay.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be pushed into the specified subject.</param><param name="subject">Subject to push source elements into.</param>
		/// <returns>
		/// A connectable observable sequence that upon connection causes the source sequence to push results into the specified subject.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="subject"/> is null.</exception>
		public static IConnectableObservable<TResult> Multicast<TSource, TResult>(this IObservable<TSource> source, ISubject<TSource, TResult> subject);

		/// <summary>
		/// Multicasts the source sequence notifications through an instantiated subject into all uses of the sequence within a selector function. Each
		///             subscription to the resulting sequence causes a separate multicast invocation, exposing the sequence resulting from the selector function's
		///             invocation. For specializations with fixed subject types, see Publish, PublishLast, and Replay.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TIntermediate">The type of the elements produced by the intermediate subject.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence which will be multicasted in the specified selector function.</param><param name="subjectSelector">Factory function to create an intermediate subject through which the source sequence's elements will be multicast to the selector function.</param><param name="selector">Selector function which can use the multicasted source sequence subject to the policies enforced by the created subject.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="subjectSelector"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> Multicast<TSource, TIntermediate, TResult>(this IObservable<TSource> source, Func<ISubject<TSource, TIntermediate>> subjectSelector, Func<IObservable<TIntermediate>, IObservable<TResult>> selector);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence.
		///             This operator is a specialization of Multicast using a regular <see cref="T:System.Reactive.Subjects.Subject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Subscribers will receive all notifications of the source from the time of the subscription on.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.Subject`1"/>
		public static IConnectableObservable<TSource> Publish<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence.
		///             This operator is a specialization of Multicast using a regular <see cref="T:System.Reactive.Subjects.Subject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all notifications of the source from the time of the subscription on.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><seealso cref="T:System.Reactive.Subjects.Subject`1"/>
		public static IObservable<TResult> Publish<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence and starts with initialValue.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.BehaviorSubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="initialValue">Initial value received by observers upon subscription.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Subscribers will receive immediately receive the initial value, followed by all notifications of the source from the time of the subscription on.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.BehaviorSubject`1"/>
		public static IConnectableObservable<TSource> Publish<TSource>(this IObservable<TSource> source, TSource initialValue);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence and starts with initialValue.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.BehaviorSubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive immediately receive the initial value, followed by all notifications of the source from the time of the subscription on.</param><param name="initialValue">Initial value received by observers upon subscription.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><seealso cref="T:System.Reactive.Subjects.BehaviorSubject`1"/>
		public static IObservable<TResult> Publish<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, TSource initialValue);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.AsyncSubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Subscribers will only receive the last notification of the source.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.AsyncSubject`1"/>
		public static IConnectableObservable<TSource> PublishLast<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.AsyncSubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will only receive the last notification of the source.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><seealso cref="T:System.Reactive.Subjects.AsyncSubject`1"/>
		public static IObservable<TResult> PublishLast<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector);

		/// <summary>
		/// Returns an observable sequence that stays connected to the source as long as there is at least one subscription to the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Connectable observable sequence.</param>
		/// <returns>
		/// An observable sequence that stays connected to the source as long as there is at least one subscription to the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> RefCount<TSource>(this IConnectableObservable<TSource> source);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source.</param><param name="scheduler">Scheduler where connected observers within the selector function will be invoked on.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="scheduler"/> is null.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, IScheduler scheduler);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="window">Maximum time length of the replay buffer.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, TimeSpan window);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="window">Maximum time length of the replay buffer.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, TimeSpan window);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="window">Maximum time length of the replay buffer.</param><param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, TimeSpan window, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="window">Maximum time length of the replay buffer.</param><param name="scheduler">Scheduler where connected observers within the selector function will be invoked on.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, TimeSpan window, IScheduler scheduler);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying bufferSize notifications.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, int bufferSize, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="scheduler">Scheduler where connected observers within the selector function will be invoked on.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize, IScheduler scheduler);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="bufferSize">Maximum element count of the replay buffer.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, int bufferSize);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="bufferSize">Maximum element count of the replay buffer.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length and element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="window">Maximum time length of the replay buffer.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, int bufferSize, TimeSpan window);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length and element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="window">Maximum time length of the replay buffer.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize, TimeSpan window);

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length and element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="window">Maximum time length of the replay buffer.</param><param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>
		/// A connectable observable sequence that shares a single subscription to the underlying sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Subscribers will receive all the notifications of the source subject to the specified replay buffer trimming policy.
		/// </remarks>
		/// <seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IConnectableObservable<TSource> Replay<TSource>(this IObservable<TSource> source, int bufferSize, TimeSpan window, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence replaying notifications subject to a maximum time length and element count for the replay buffer.
		///             This operator is a specialization of Multicast using a <see cref="T:System.Reactive.Subjects.ReplaySubject`1"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence.</typeparam><param name="source">Source sequence whose elements will be multicasted through a single shared subscription.</param><param name="selector">Selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence. Subscribers to the given source will receive all the notifications of the source subject to the specified replay buffer trimming policy.</param><param name="bufferSize">Maximum element count of the replay buffer.</param><param name="window">Maximum time length of the replay buffer.</param><param name="scheduler">Scheduler where connected observers within the selector function will be invoked on.</param>
		/// <returns>
		/// An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than zero.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="window"/> is less than TimeSpan.Zero.</exception><seealso cref="T:System.Reactive.Subjects.ReplaySubject`1"/>
		public static IObservable<TResult> Replay<TSource, TResult>(this IObservable<TSource> source, Func<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize, TimeSpan window, IScheduler scheduler);

		/// <summary>
		/// Produces an enumerable sequence of consecutive (possibly empty) chunks of the source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The enumerable sequence that returns consecutive (possibly empty) chunks upon each iteration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEnumerable<IList<TSource>> Chunkify<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Produces an enumerable sequence that returns elements collected/aggregated from the source sequence between consecutive iterations.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements produced by the merge operation during collection.</typeparam><param name="source">Source observable sequence.</param><param name="newCollector">Factory to create a new collector object.</param><param name="merge">Merges a sequence element with the current collector.</param>
		/// <returns>
		/// The enumerable sequence that returns collected/aggregated elements from the source sequence upon each iteration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="newCollector"/> or <paramref name="merge"/> is null.</exception>
		public static IEnumerable<TResult> Collect<TSource, TResult>(this IObservable<TSource> source, Func<TResult> newCollector, Func<TResult, TSource, TResult> merge);

		/// <summary>
		/// Produces an enumerable sequence that returns elements collected/aggregated from the source sequence between consecutive iterations.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements produced by the merge operation during collection.</typeparam><param name="source">Source observable sequence.</param><param name="getInitialCollector">Factory to create the initial collector object.</param><param name="merge">Merges a sequence element with the current collector.</param><param name="getNewCollector">Factory to replace the current collector by a new collector.</param>
		/// <returns>
		/// The enumerable sequence that returns collected/aggregated elements from the source sequence upon each iteration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="getInitialCollector"/> or <paramref name="merge"/> or <paramref name="getNewCollector"/> is null.</exception>
		public static IEnumerable<TResult> Collect<TSource, TResult>(this IObservable<TSource> source, Func<TResult> getInitialCollector, Func<TResult, TSource, TResult> merge, Func<TResult, TResult> getNewCollector);

		/// <summary>
		/// Returns the first element of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The first element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.FirstAsync``1(System.IObservable{``0})"/>
		public static TSource First<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the first element of an observable sequence that satisfies the condition in the predicate.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The first element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">No element satisfies the condition in the predicate. -or- The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.FirstAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource First<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the first element of an observable sequence, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The first element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><seealso cref="M:System.Reactive.Linq.Observable.FirstOrDefaultAsync``1(System.IObservable{``0})"/>
		public static TSource FirstOrDefault<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the first element of an observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The first element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><seealso cref="M:System.Reactive.Linq.Observable.FirstOrDefaultAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource FirstOrDefault<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, and blocks until the sequence is terminated.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// Because of its blocking nature, this operator is mainly used for testing.
		/// </remarks>
		public static void ForEach<TSource>(this IObservable<TSource> source, Action<TSource> onNext);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, incorporating the element's index, and blocks until the sequence is terminated.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		/// <remarks>
		/// Because of its blocking nature, this operator is mainly used for testing.
		/// </remarks>
		public static void ForEach<TSource>(this IObservable<TSource> source, Action<TSource, int> onNext);

		/// <summary>
		/// Returns an enumerator that enumerates all values of the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to get an enumerator for.</param>
		/// <returns>
		/// The enumerator that can be used to enumerate over the elements in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEnumerator<TSource> GetEnumerator<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The last element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.LastAsync``1(System.IObservable{``0})"/>
		public static TSource Last<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence that satisfies the condition in the predicate.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The last element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">No element satisfies the condition in the predicate. -or- The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.LastAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource Last<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the last element of an observable sequence, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The last element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><seealso cref="M:System.Reactive.Linq.Observable.LastOrDefaultAsync``1(System.IObservable{``0})"/>
		public static TSource LastOrDefault<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the last element of an observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The last element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><seealso cref="M:System.Reactive.Linq.Observable.LastOrDefaultAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource LastOrDefault<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns an enumerable sequence whose enumeration returns the latest observed element in the source observable sequence.
		///             Enumerators on the resulting sequence will never produce the same element repeatedly, and will block until the next element becomes available.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The enumerable sequence that returns the last sampled element upon each iteration and subsequently blocks until the next element in the observable source sequence becomes available.
		/// </returns>
		public static IEnumerable<TSource> Latest<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an enumerable sequence whose enumeration returns the most recently observed element in the source observable sequence, using the specified initial value in case no element has been sampled yet.
		///             Enumerators on the resulting sequence never block and can produce the same element repeatedly.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="initialValue">Initial value that will be yielded by the enumerable sequence if no element has been sampled yet.</param>
		/// <returns>
		/// The enumerable sequence that returns the last sampled element upon each iteration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEnumerable<TSource> MostRecent<TSource>(this IObservable<TSource> source, TSource initialValue);

		/// <summary>
		/// Returns an enumerable sequence whose enumeration blocks until the next element in the source observable sequence becomes available.
		///             Enumerators on the resulting sequence will block until the next element becomes available.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The enumerable sequence that blocks upon each iteration until the next element in the observable source sequence becomes available.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEnumerable<TSource> Next<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the only element of an observable sequence, and throws an exception if there is not exactly one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The single element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">The source sequence contains more than one element. -or- The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.SingleAsync``1(System.IObservable{``0})"/>
		public static TSource Single<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the only element of an observable sequence that satisfies the condition in the predicate, and throws an exception if there is not exactly one element matching the predicate in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The single element in the observable sequence that satisfies the condition in the predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">No element satisfies the condition in the predicate. -or- More than one element satisfies the condition in the predicate. -or- The source sequence is empty.</exception><seealso cref="M:System.Reactive.Linq.Observable.SingleAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource Single<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns the only element of an observable sequence, or a default value if the observable sequence is empty; this method throws an exception if there is more than one element in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The single element in the observable sequence, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">The source sequence contains more than one element.</exception><seealso cref="M:System.Reactive.Linq.Observable.SingleOrDefaultAsync``1(System.IObservable{``0})"/>
		public static TSource SingleOrDefault<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the only element of an observable sequence that satisfies the condition in the predicate, or a default value if no such element exists; this method throws an exception if there is more than one element matching the predicate in the observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param><param name="predicate">A predicate function to evaluate for elements in the source sequence.</param>
		/// <returns>
		/// The single element in the observable sequence that satisfies the condition in the predicate, or a default value if no such element exists.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception><exception cref="T:System.InvalidOperationException">The sequence contains more than one element that satisfies the condition in the predicate.</exception><seealso cref="M:System.Reactive.Linq.Observable.SingleOrDefaultAsync``1(System.IObservable{``0},System.Func{``0,System.Boolean})"/>
		public static TSource SingleOrDefault<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Waits for the observable sequence to complete and returns the last element of the sequence.
		///             If the sequence terminates with an OnError notification, the exception is throw.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source observable sequence.</param>
		/// <returns>
		/// The last element in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
		public static TSource Wait<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Wraps the source sequence in order to run its observer callbacks on the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="scheduler">Scheduler to notify observers on.</param>
		/// <returns>
		/// The source sequence whose observations happen on the specified scheduler.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// This only invokes observer callbacks on a scheduler. In case the subscription and/or unsubscription actions have side-effects
		///             that require to be run on a scheduler, use <see cref="M:System.Reactive.Linq.Observable.SubscribeOn``1(System.IObservable{``0},System.Reactive.Concurrency.IScheduler)"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> ObserveOn<TSource>(this IObservable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Wraps the source sequence in order to run its observer callbacks on the specified synchronization context.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="context">Synchronization context to notify observers on.</param>
		/// <returns>
		/// The source sequence whose observations happen on the specified synchronization context.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="context"/> is null.</exception>
		/// <remarks>
		/// This only invokes observer callbacks on a synchronization context. In case the subscription and/or unsubscription actions have side-effects
		///             that require to be run on a synchronization context, use <see cref="M:System.Reactive.Linq.Observable.SubscribeOn``1(System.IObservable{``0},System.Threading.SynchronizationContext)"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> ObserveOn<TSource>(this IObservable<TSource> source, SynchronizationContext context);

		/// <summary>
		/// Wraps the source sequence in order to run its subscription and unsubscription logic on the specified scheduler. This operation is not commonly used;
		///             see the remarks section for more information on the distinction between SubscribeOn and ObserveOn.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="scheduler">Scheduler to perform subscription and unsubscription actions on.</param>
		/// <returns>
		/// The source sequence whose subscriptions and unsubscriptions happen on the specified scheduler.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// This only performs the side-effects of subscription and unsubscription on the specified scheduler. In order to invoke observer
		///             callbacks on a scheduler, use <see cref="M:System.Reactive.Linq.Observable.ObserveOn``1(System.IObservable{``0},System.Reactive.Concurrency.IScheduler)"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SubscribeOn<TSource>(this IObservable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Wraps the source sequence in order to run its subscription and unsubscription logic on the specified synchronization context. This operation is not commonly used;
		///             see the remarks section for more information on the distinction between SubscribeOn and ObserveOn.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="context">Synchronization context to perform subscription and unsubscription actions on.</param>
		/// <returns>
		/// The source sequence whose subscriptions and unsubscriptions happen on the specified synchronization context.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="context"/> is null.</exception>
		/// <remarks>
		/// This only performs the side-effects of subscription and unsubscription on the specified synchronization context. In order to invoke observer
		///             callbacks on a synchronization context, use <see cref="M:System.Reactive.Linq.Observable.ObserveOn``1(System.IObservable{``0},System.Threading.SynchronizationContext)"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SubscribeOn<TSource>(this IObservable<TSource> source, SynchronizationContext context);

		/// <summary>
		/// Synchronizes the observable sequence such that observer notifications cannot be delivered concurrently.
		///             This overload is useful to "fix" an observable sequence that exhibits concurrent callbacks on individual observers, which is invalid behavior for the query processor.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param>
		/// <returns>
		/// The source sequence whose outgoing calls to observers are synchronized.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// It's invalid behavior - according to the observer grammar - for a sequence to exhibit concurrent callbacks on a given observer.
		///             This operator can be used to "fix" a source that doesn't conform to this rule.
		/// 
		/// </remarks>
		public static IObservable<TSource> Synchronize<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Synchronizes the observable sequence such that observer notifications cannot be delivered concurrently, using the specified gate object.
		///             This overload is useful when writing n-ary query operators, in order to prevent concurrent callbacks from different sources by synchronizing on a common gate object.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="gate">Gate object to synchronize each observer call on.</param>
		/// <returns>
		/// The source sequence whose outgoing calls to observers are synchronized on the given gate object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="gate"/> is null.</exception>
		public static IObservable<TSource> Synchronize<TSource>(this IObservable<TSource> source, object gate);

		/// <summary>
		/// Subscribes an observer to an enumerable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Enumerable sequence to subscribe to.</param><param name="observer">Observer that will receive notifications from the enumerable sequence.</param>
		/// <returns>
		/// Disposable object that can be used to unsubscribe the observer from the enumerable
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="observer"/> is null.</exception>
		public static IDisposable Subscribe<TSource>(this IEnumerable<TSource> source, IObserver<TSource> observer);

		/// <summary>
		/// Subscribes an observer to an enumerable sequence, using the specified scheduler to run the enumeration loop.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Enumerable sequence to subscribe to.</param><param name="observer">Observer that will receive notifications from the enumerable sequence.</param><param name="scheduler">Scheduler to perform the enumeration on.</param>
		/// <returns>
		/// Disposable object that can be used to unsubscribe the observer from the enumerable
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="observer"/> or <paramref name="scheduler"/> is null.</exception>
		public static IDisposable Subscribe<TSource>(this IEnumerable<TSource> source, IObserver<TSource> observer, IScheduler scheduler);

		/// <summary>
		/// Converts an observable sequence to an enumerable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to convert to an enumerable sequence.</param>
		/// <returns>
		/// The enumerable sequence containing the elements in the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEnumerable<TSource> ToEnumerable<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Exposes an observable sequence as an object with an Action-based .NET event.
		/// 
		/// </summary>
		/// <param name="source">Observable source sequence.</param>
		/// <returns>
		/// The event source object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEventSource<Unit> ToEvent(this IObservable<Unit> source);

		/// <summary>
		/// Exposes an observable sequence as an object with an Action&lt;TSource&gt;-based .NET event.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable source sequence.</param>
		/// <returns>
		/// The event source object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEventSource<TSource> ToEvent<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Exposes an observable sequence as an object with a .NET event, conforming to the standard .NET event pattern.
		/// 
		/// </summary>
		/// <typeparam name="TEventArgs">The type of the event data generated by the event.</typeparam><param name="source">Observable source sequence.</param>
		/// <returns>
		/// The event source object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IEventPatternSource<TEventArgs> ToEventPattern<TEventArgs>(this IObservable<EventPattern<TEventArgs>> source) where TEventArgs : EventArgs;

		/// <summary>
		/// Converts an enumerable sequence to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Enumerable sequence to convert to an observable sequence.</param>
		/// <returns>
		/// The observable sequence whose elements are pulled from the given enumerable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> ToObservable<TSource>(this IEnumerable<TSource> source);

		/// <summary>
		/// Converts an enumerable sequence to an observable sequence, using the specified scheduler to run the enumeration loop.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Enumerable sequence to convert to an observable sequence.</param><param name="scheduler">Scheduler to run the enumeration of the input sequence on.</param>
		/// <returns>
		/// The observable sequence whose elements are pulled from the given enumerable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TSource> ToObservable<TSource>(this IEnumerable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Creates an observable sequence from a specified Subscribe method implementation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribe">Implementation of the resulting observable sequence's Subscribe method.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribe"/> is null.</exception>
		/// <remarks>
		/// Use of this operator is preferred over manual implementation of the IObservable&lt;T&gt; interface. In case
		///             you need a type implementing IObservable&lt;T&gt; rather than an anonymous implementation, consider using
		///             the <see cref="T:System.Reactive.ObservableBase`1"/> abstract base class.
		/// 
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, IDisposable> subscribe);

		/// <summary>
		/// Creates an observable sequence from a specified Subscribe method implementation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribe">Implementation of the resulting observable sequence's Subscribe method, returning an Action delegate that will be wrapped in an IDisposable.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribe"/> is null.</exception>
		/// <remarks>
		/// Use of this operator is preferred over manual implementation of the IObservable&lt;T&gt; interface. In case
		///             you need a type implementing IObservable&lt;T&gt; rather than an anonymous implementation, consider using
		///             the <see cref="T:System.Reactive.ObservableBase`1"/> abstract base class.
		/// 
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, Action> subscribe);

		/// <summary>
		/// Creates an observable sequence from a specified cancellable asynchronous Subscribe method.
		///             The CancellationToken passed to the asynchronous Subscribe method is tied to the returned disposable subscription, allowing best-effort cancellation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to produce elements.</param>
		/// <returns>
		/// The observable sequence surfacing the elements produced by the asynchronous method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous subscribe function will be signaled.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, CancellationToken, Task> subscribeAsync);

		/// <summary>
		/// Creates an observable sequence from a specified asynchronous Subscribe method.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to produce elements.</param>
		/// <returns>
		/// The observable sequence surfacing the elements produced by the asynchronous method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, Task> subscribeAsync);

		/// <summary>
		/// Creates an observable sequence from a specified cancellable asynchronous Subscribe method.
		///             The CancellationToken passed to the asynchronous Subscribe method is tied to the returned disposable subscription, allowing best-effort cancellation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to implemented the resulting sequence's Subscribe method.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous subscribe function will be signaled.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, CancellationToken, Task<IDisposable>> subscribeAsync);

		/// <summary>
		/// Creates an observable sequence from a specified asynchronous Subscribe method.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to implemented the resulting sequence's Subscribe method.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, Task<IDisposable>> subscribeAsync);

		/// <summary>
		/// Creates an observable sequence from a specified cancellable asynchronous Subscribe method.
		///             The CancellationToken passed to the asynchronous Subscribe method is tied to the returned disposable subscription, allowing best-effort cancellation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to implemented the resulting sequence's Subscribe method, returning an Action delegate that will be wrapped in an IDisposable.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous subscribe function will be signaled.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, CancellationToken, Task<Action>> subscribeAsync);

		/// <summary>
		/// Creates an observable sequence from a specified asynchronous Subscribe method.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="subscribeAsync">Asynchronous method used to implemented the resulting sequence's Subscribe method, returning an Action delegate that will be wrapped in an IDisposable.</param>
		/// <returns>
		/// The observable sequence with the specified implementation for the Subscribe method.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="subscribeAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static IObservable<TResult> Create<TResult>(Func<IObserver<TResult>, Task<Action>> subscribeAsync);

		/// <summary>
		/// Returns an observable sequence that invokes the specified factory function whenever a new observer subscribes.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the sequence returned by the factory function, and in the resulting sequence.</typeparam><param name="observableFactory">Observable factory function to invoke for each observer that subscribes to the resulting sequence.</param>
		/// <returns>
		/// An observable sequence whose observers trigger an invocation of the given observable factory function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="observableFactory"/> is null.</exception>
		public static IObservable<TResult> Defer<TResult>(Func<IObservable<TResult>> observableFactory);

		/// <summary>
		/// Returns an observable sequence that starts the specified asynchronous factory function whenever a new observer subscribes.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the sequence returned by the factory function, and in the resulting sequence.</typeparam><param name="observableFactoryAsync">Asynchronous factory function to start for each observer that subscribes to the resulting sequence.</param>
		/// <returns>
		/// An observable sequence whose observers trigger the given asynchronous observable factory function to be started.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="observableFactoryAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		public static IObservable<TResult> Defer<TResult>(Func<Task<IObservable<TResult>>> observableFactoryAsync);

		/// <summary>
		/// Returns an observable sequence that starts the specified cancellable asynchronous factory function whenever a new observer subscribes.
		///             The CancellationToken passed to the asynchronous factory function is tied to the returned disposable subscription, allowing best-effort cancellation.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the sequence returned by the factory function, and in the resulting sequence.</typeparam><param name="observableFactoryAsync">Asynchronous factory function to start for each observer that subscribes to the resulting sequence.</param>
		/// <returns>
		/// An observable sequence whose observers trigger the given asynchronous observable factory function to be started.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="observableFactoryAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous observable factory function will be signaled.
		/// </remarks>
		public static IObservable<TResult> DeferAsync<TResult>(Func<CancellationToken, Task<IObservable<TResult>>> observableFactoryAsync);

		/// <summary>
		/// Returns an empty observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam>
		/// <returns>
		/// An observable sequence with no elements.
		/// </returns>
		public static IObservable<TResult> Empty<TResult>();

		/// <summary>
		/// Returns an empty observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="witness">Object solely used to infer the type of the <typeparamref name="TResult"/> type parameter. This parameter is typically used when creating a sequence of anonymously typed elements.</param>
		/// <returns>
		/// An observable sequence with no elements.
		/// </returns>
		public static IObservable<TResult> Empty<TResult>(TResult witness);

		/// <summary>
		/// Returns an empty observable sequence, using the specified scheduler to send out the single OnCompleted message.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="scheduler">Scheduler to send the termination call on.</param>
		/// <returns>
		/// An observable sequence with no elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Empty<TResult>(IScheduler scheduler);

		/// <summary>
		/// Returns an empty observable sequence, using the specified scheduler to send out the single OnCompleted message.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="scheduler">Scheduler to send the termination call on.</param><param name="witness">Object solely used to infer the type of the <typeparamref name="TResult"/> type parameter. This parameter is typically used when creating a sequence of anonymously typed elements.</param>
		/// <returns>
		/// An observable sequence with no elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Empty<TResult>(IScheduler scheduler, TResult witness);

		/// <summary>
		/// Generates an observable sequence by running a state-driven loop producing the sequence's elements.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector);

		/// <summary>
		/// Generates an observable sequence by running a state-driven loop producing the sequence's elements, using the specified scheduler to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param><param name="scheduler">Scheduler on which to run the generator loop.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector, IScheduler scheduler);

		/// <summary>
		/// Returns a non-terminating observable sequence, which can be used to denote an infinite duration (e.g. when using reactive joins).
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam>
		/// <returns>
		/// An observable sequence whose observers will never get called.
		/// </returns>
		public static IObservable<TResult> Never<TResult>();

		/// <summary>
		/// Returns a non-terminating observable sequence, which can be used to denote an infinite duration (e.g. when using reactive joins).
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="witness">Object solely used to infer the type of the <typeparamref name="TResult"/> type parameter. This parameter is typically used when creating a sequence of anonymously typed elements.</param>
		/// <returns>
		/// An observable sequence whose observers will never get called.
		/// </returns>
		public static IObservable<TResult> Never<TResult>(TResult witness);

		/// <summary>
		/// Generates an observable sequence of integral numbers within a specified range.
		/// 
		/// </summary>
		/// <param name="start">The value of the first integer in the sequence.</param><param name="count">The number of sequential integers to generate.</param>
		/// <returns>
		/// An observable sequence that contains a range of sequential integral numbers.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero. -or- <paramref name="start"/> + <paramref name="count"/> - 1 is larger than <see cref="M:System.Int32.MaxValue"/>.</exception>
		public static IObservable<int> Range(int start, int count);

		/// <summary>
		/// Generates an observable sequence of integral numbers within a specified range, using the specified scheduler to send out observer messages.
		/// 
		/// </summary>
		/// <param name="start">The value of the first integer in the sequence.</param><param name="count">The number of sequential integers to generate.</param><param name="scheduler">Scheduler to run the generator loop on.</param>
		/// <returns>
		/// An observable sequence that contains a range of sequential integral numbers.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero. -or- <paramref name="start"/> + <paramref name="count"/> - 1 is larger than <see cref="M:System.Int32.MaxValue"/>.</exception><exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<int> Range(int start, int count, IScheduler scheduler);

		/// <summary>
		/// Generates an observable sequence that repeats the given element infinitely.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be repeated in the produced sequence.</typeparam><param name="value">Element to repeat.</param>
		/// <returns>
		/// An observable sequence that repeats the given element infinitely.
		/// </returns>
		public static IObservable<TResult> Repeat<TResult>(TResult value);

		/// <summary>
		/// Generates an observable sequence that repeats the given element infinitely, using the specified scheduler to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be repeated in the produced sequence.</typeparam><param name="value">Element to repeat.</param><param name="scheduler">Scheduler to run the producer loop on.</param>
		/// <returns>
		/// An observable sequence that repeats the given element infinitely.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Repeat<TResult>(TResult value, IScheduler scheduler);

		/// <summary>
		/// Generates an observable sequence that repeats the given element the specified number of times.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be repeated in the produced sequence.</typeparam><param name="value">Element to repeat.</param><param name="repeatCount">Number of times to repeat the element.</param>
		/// <returns>
		/// An observable sequence that repeats the given element the specified number of times.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="repeatCount"/> is less than zero.</exception>
		public static IObservable<TResult> Repeat<TResult>(TResult value, int repeatCount);

		/// <summary>
		/// Generates an observable sequence that repeats the given element the specified number of times, using the specified scheduler to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be repeated in the produced sequence.</typeparam><param name="value">Element to repeat.</param><param name="repeatCount">Number of times to repeat the element.</param><param name="scheduler">Scheduler to run the producer loop on.</param>
		/// <returns>
		/// An observable sequence that repeats the given element the specified number of times.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="repeatCount"/> is less than zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Repeat<TResult>(TResult value, int repeatCount, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that contains a single element.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be returned in the produced sequence.</typeparam><param name="value">Single element in the resulting observable sequence.</param>
		/// <returns>
		/// An observable sequence containing the single specified element.
		/// </returns>
		public static IObservable<TResult> Return<TResult>(TResult value);

		/// <summary>
		/// Returns an observable sequence that contains a single element, using the specified scheduler to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the element that will be returned in the produced sequence.</typeparam><param name="value">Single element in the resulting observable sequence.</param><param name="scheduler">Scheduler to send the single element on.</param>
		/// <returns>
		/// An observable sequence containing the single specified element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Return<TResult>(TResult value, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that terminates with an exception.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="exception">Exception object used for the sequence's termination.</param>
		/// <returns>
		/// The observable sequence that terminates exceptionally with the specified exception object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="exception"/> is null.</exception>
		public static IObservable<TResult> Throw<TResult>(Exception exception);

		/// <summary>
		/// Returns an observable sequence that terminates with an exception.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="exception">Exception object used for the sequence's termination.</param><param name="witness">Object solely used to infer the type of the <typeparamref name="TResult"/> type parameter. This parameter is typically used when creating a sequence of anonymously typed elements.</param>
		/// <returns>
		/// The observable sequence that terminates exceptionally with the specified exception object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="exception"/> is null.</exception>
		public static IObservable<TResult> Throw<TResult>(Exception exception, TResult witness);

		/// <summary>
		/// Returns an observable sequence that terminates with an exception, using the specified scheduler to send out the single OnError message.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="exception">Exception object used for the sequence's termination.</param><param name="scheduler">Scheduler to send the exceptional termination call on.</param>
		/// <returns>
		/// The observable sequence that terminates exceptionally with the specified exception object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="exception"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Throw<TResult>(Exception exception, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that terminates with an exception, using the specified scheduler to send out the single OnError message.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type used for the IObservable&lt;T&gt; type parameter of the resulting sequence.</typeparam><param name="exception">Exception object used for the sequence's termination.</param><param name="scheduler">Scheduler to send the exceptional termination call on.</param><param name="witness">Object solely used to infer the type of the <typeparamref name="TResult"/> type parameter. This parameter is typically used when creating a sequence of anonymously typed elements.</param>
		/// <returns>
		/// The observable sequence that terminates exceptionally with the specified exception object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="exception"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Throw<TResult>(Exception exception, IScheduler scheduler, TResult witness);

		/// <summary>
		/// Constructs an observable sequence that depends on a resource object, whose lifetime is tied to the resulting observable sequence's lifetime.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><typeparam name="TResource">The type of the resource used during the generation of the resulting sequence. Needs to implement <see cref="T:System.IDisposable"/>.</typeparam><param name="resourceFactory">Factory function to obtain a resource object.</param><param name="observableFactory">Factory function to obtain an observable sequence that depends on the obtained resource.</param>
		/// <returns>
		/// An observable sequence whose lifetime controls the lifetime of the dependent resource object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="resourceFactory"/> or <paramref name="observableFactory"/> is null.</exception>
		public static IObservable<TResult> Using<TResult, TResource>(Func<TResource> resourceFactory, Func<TResource, IObservable<TResult>> observableFactory) where TResource : IDisposable;

		/// <summary>
		/// Constructs an observable sequence that depends on a resource object, whose lifetime is tied to the resulting observable sequence's lifetime. The resource is obtained and used through asynchronous methods.
		///             The CancellationToken passed to the asynchronous methods is tied to the returned disposable subscription, allowing best-effort cancellation at any stage of the resource acquisition or usage.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><typeparam name="TResource">The type of the resource used during the generation of the resulting sequence. Needs to implement <see cref="T:System.IDisposable"/>.</typeparam><param name="resourceFactoryAsync">Asynchronous factory function to obtain a resource object.</param><param name="observableFactoryAsync">Asynchronous factory function to obtain an observable sequence that depends on the obtained resource.</param>
		/// <returns>
		/// An observable sequence whose lifetime controls the lifetime of the dependent resource object.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="resourceFactoryAsync"/> or <paramref name="observableFactoryAsync"/> is null.</exception>
		/// <remarks>
		/// This operator is especially useful in conjunction with the asynchronous programming features introduced in C# 5.0 and Visual Basic 11.
		/// </remarks>
		/// 
		/// <remarks>
		/// When a subscription to the resulting sequence is disposed, the CancellationToken that was fed to the asynchronous resource factory and observable factory functions will be signaled.
		/// </remarks>
		public static IObservable<TResult> Using<TResult, TResource>(Func<CancellationToken, Task<TResource>> resourceFactoryAsync, Func<TResource, CancellationToken, Task<IObservable<TResult>>> observableFactoryAsync) where TResource : IDisposable;

		/// <summary>
		/// Creates a pattern that matches when both observable sequences have an available element.
		/// 
		/// </summary>
		/// <typeparam name="TLeft">The type of the elements in the left sequence.</typeparam><typeparam name="TRight">The type of the elements in the right sequence.</typeparam><param name="left">Observable sequence to match with the right sequence.</param><param name="right">Observable sequence to match with the left sequence.</param>
		/// <returns>
		/// Pattern object that matches when both observable sequences have an available element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception>
		public static Pattern<TLeft, TRight> And<TLeft, TRight>(this IObservable<TLeft> left, IObservable<TRight> right);

		/// <summary>
		/// Matches when the observable sequence has an available element and projects the element by invoking the selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source">Observable sequence to apply the selector on.</param><param name="selector">Selector that will be invoked for elements in the source sequence.</param>
		/// <returns>
		/// Plan that produces the projected results, to be fed (with other plans) to the When operator.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static Plan<TResult> Then<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector);

		/// <summary>
		/// Joins together the results from several patterns.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the result sequence, obtained from the specified patterns.</typeparam><param name="plans">A series of plans created by use of the Then operator on patterns.</param>
		/// <returns>
		/// An observable sequence with the results from matching several patterns.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="plans"/> is null.</exception>
		public static IObservable<TResult> When<TResult>(params Plan<TResult>[] plans);

		/// <summary>
		/// Joins together the results from several patterns.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type of the elements in the result sequence, obtained from the specified patterns.</typeparam><param name="plans">A series of plans created by use of the Then operator on patterns.</param>
		/// <returns>
		/// An observable sequence with the results form matching several patterns.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="plans"/> is null.</exception>
		public static IObservable<TResult> When<TResult>(this IEnumerable<Plan<TResult>> plans);

		/// <summary>
		/// Propagates the observable sequence that reacts first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="first">First observable sequence.</param><param name="second">Second observable sequence.</param>
		/// <returns>
		/// An observable sequence that surfaces either of the given sequences, whichever reacted first.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		public static IObservable<TSource> Amb<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Propagates the observable sequence that reacts first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sources competing to react first.</param>
		/// <returns>
		/// An observable sequence that surfaces any of the given sequences, whichever reacted first.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Amb<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Propagates the observable sequence that reacts first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sources competing to react first.</param>
		/// <returns>
		/// An observable sequence that surfaces any of the given sequences, whichever reacted first.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Amb<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping buffers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><typeparam name="TBufferClosing">The type of the elements in the sequences indicating buffer closing events.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="bufferClosingSelector">A function invoked to define the boundaries of the produced buffers. A new buffer is started when the previous one is closed.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="bufferClosingSelector"/> is null.</exception>
		public static IObservable<IList<TSource>> Buffer<TSource, TBufferClosing>(this IObservable<TSource> source, Func<IObservable<TBufferClosing>> bufferClosingSelector);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><typeparam name="TBufferOpening">The type of the elements in the sequence indicating buffer opening events, also passed to the closing selector to obtain a sequence of buffer closing events.</typeparam><typeparam name="TBufferClosing">The type of the elements in the sequences indicating buffer closing events.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="bufferOpenings">Observable sequence whose elements denote the creation of new buffers.</param><param name="bufferClosingSelector">A function invoked to define the closing of each produced buffer.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="bufferOpenings"/> or <paramref name="bufferClosingSelector"/> is null.</exception>
		public static IObservable<IList<TSource>> Buffer<TSource, TBufferOpening, TBufferClosing>(this IObservable<TSource> source, IObservable<TBufferOpening> bufferOpenings, Func<TBufferOpening, IObservable<TBufferClosing>> bufferClosingSelector);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping buffers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><typeparam name="TBufferBoundary">The type of the elements in the sequences indicating buffer boundary events.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="bufferBoundaries">Sequence of buffer boundary markers. The current buffer is closed and a new buffer is opened upon receiving a boundary marker.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="bufferBoundaries"/> is null.</exception>
		public static IObservable<IList<TSource>> Buffer<TSource, TBufferBoundary>(this IObservable<TSource> source, IObservable<TBufferBoundary> bufferBoundaries);

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception of the specified type with the observable sequence produced by the handler.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and sequences returned by the exception handler function.</typeparam><typeparam name="TException">The type of the exception to catch and handle. Needs to derive from <see cref="T:System.Exception"/>.</typeparam><param name="source">Source sequence.</param><param name="handler">Exception handler function, producing another observable sequence.</param>
		/// <returns>
		/// An observable sequence containing the source sequence's elements, followed by the elements produced by the handler's resulting observable sequence in case an exception occurred.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="handler"/> is null.</exception>
		public static IObservable<TSource> Catch<TSource, TException>(this IObservable<TSource> source, Func<TException, IObservable<TSource>> handler) where TException : Exception;

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and handler sequence.</typeparam><param name="first">First observable sequence whose exception (if any) is caught.</param><param name="second">Second observable sequence used to produce results when an error occurred in the first sequence.</param>
		/// <returns>
		/// An observable sequence containing the first sequence's elements, followed by the elements of the second sequence in case an exception occurred.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		public static IObservable<TSource> Catch<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source and handler sequences.</typeparam><param name="sources">Observable sequences to catch exceptions for.</param>
		/// <returns>
		/// An observable sequence containing elements from consecutive source sequences until a source sequence terminates successfully.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Catch<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source and handler sequences.</typeparam><param name="sources">Observable sequences to catch exceptions for.</param>
		/// <returns>
		/// An observable sequence containing elements from consecutive source sequences until a source sequence terminates successfully.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Catch<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Merges two observable sequences into one observable sequence by using the selector function whenever one of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="first">First observable source.</param><param name="second">Second observable source.</param><param name="resultSelector">Function to invoke whenever either of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of both sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TResult>(this IObservable<TSource1> first, IObservable<TSource2> second, Func<TSource1, TSource2, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, Func<TSource1, TSource2, TSource3, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, Func<TSource1, TSource2, TSource3, TSource4, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TSource15">The type of the elements in the fifteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="source15">Fifteenth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="source15"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, IObservable<TSource15> source15, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TSource15">The type of the elements in the fifteenth source sequence.</typeparam><typeparam name="TSource16">The type of the elements in the sixteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="source15">Fifteenth observable source.</param><param name="source16">Sixteenth observable source.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="source15"/> or <paramref name="source16"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, IObservable<TSource15> source15, IObservable<TSource16> source16, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="sources">Observable sources.</param><param name="resultSelector">Function to invoke whenever any of the sources produces an element. For efficiency, the input list is reused after the selector returns. Either aggregate or copy the values during the function call.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> CombineLatest<TSource, TResult>(this IEnumerable<IObservable<TSource>> sources, Func<IList<TSource>, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by emitting a list with the latest source elements whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences, and in the lists in the result sequence.</typeparam><param name="sources">Observable sources.</param>
		/// <returns>
		/// An observable sequence containing lists of the latest elements of the sources.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<IList<TSource>> CombineLatest<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by emitting a list with the latest source elements whenever any of the observable sequences produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences, and in the lists in the result sequence.</typeparam><param name="sources">Observable sources.</param>
		/// <returns>
		/// An observable sequence containing lists of the latest elements of the sources.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<IList<TSource>> CombineLatest<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Concatenates the second observable sequence to the first observable sequence upon successful termination of the first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="first">First observable sequence.</param><param name="second">Second observable sequence.</param>
		/// <returns>
		/// An observable sequence that contains the elements of the first sequence, followed by those of the second the sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		public static IObservable<TSource> Concat<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Concatenates all of the specified observable sequences, as long as the previous observable sequence terminated successfully.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences to concatenate.</param>
		/// <returns>
		/// An observable sequence that contains the elements of each given sequence, in sequential order.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Concat<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Concatenates all observable sequences in the given enumerable sequence, as long as the previous observable sequence terminated successfully.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences to concatenate.</param>
		/// <returns>
		/// An observable sequence that contains the elements of each given sequence, in sequential order.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Concat<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Concatenates all inner observable sequences, as long as the previous observable sequence terminated successfully.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequence of inner observable sequences.</param>
		/// <returns>
		/// An observable sequence that contains the elements of each observed inner sequence, in sequential order.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Concat<TSource>(this IObservable<IObservable<TSource>> sources);

		/// <summary>
		/// Concatenates all task results, as long as the previous task terminated successfully.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the results produced by the tasks.</typeparam><param name="sources">Observable sequence of tasks.</param>
		/// <returns>
		/// An observable sequence that contains the results of each task, in sequential order.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		/// <remarks>
		/// If the tasks support cancellation, consider manual conversion of the tasks using <see cref="M:System.Reactive.Linq.Observable.FromAsync``1(System.Func{System.Threading.CancellationToken,System.Threading.Tasks.Task{``0}})"/>, followed by a concatenation operation using <see cref="M:System.Reactive.Linq.Observable.Concat``1(System.IObservable{System.IObservable{``0}})"/>.
		/// </remarks>
		public static IObservable<TSource> Concat<TSource>(this IObservable<Task<TSource>> sources);

		/// <summary>
		/// Merges elements from all inner observable sequences into a single observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequence of inner observable sequences.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the inner sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(this IObservable<IObservable<TSource>> sources);

		/// <summary>
		/// Merges results from all source tasks into a single observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the results produced by the source tasks.</typeparam><param name="sources">Observable sequence of tasks.</param>
		/// <returns>
		/// The observable sequence that merges the results of the source tasks.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		/// <remarks>
		/// If the tasks support cancellation, consider manual conversion of the tasks using <see cref="M:System.Reactive.Linq.Observable.FromAsync``1(System.Func{System.Threading.CancellationToken,System.Threading.Tasks.Task{``0}})"/>, followed by a merge operation using <see cref="M:System.Reactive.Linq.Observable.Merge``1(System.IObservable{System.IObservable{``0}})"/>.
		/// </remarks>
		public static IObservable<TSource> Merge<TSource>(this IObservable<Task<TSource>> sources);

		/// <summary>
		/// Merges elements from all inner observable sequences into a single observable sequence, limiting the number of concurrent subscriptions to inner sequences.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequence of inner observable sequences.</param><param name="maxConcurrent">Maximum number of inner observable sequences being subscribed to concurrently.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the inner sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxConcurrent"/> is less than or equal to zero.</exception>
		public static IObservable<TSource> Merge<TSource>(this IObservable<IObservable<TSource>> sources, int maxConcurrent);

		/// <summary>
		/// Merges elements from all observable sequences in the given enumerable sequence into a single observable sequence, limiting the number of concurrent subscriptions to inner sequences.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Enumerable sequence of observable sequences.</param><param name="maxConcurrent">Maximum number of observable sequences being subscribed to concurrently.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxConcurrent"/> is less than or equal to zero.</exception>
		public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources, int maxConcurrent);

		/// <summary>
		/// Merges elements from all observable sequences in the given enumerable sequence into a single observable sequence, limiting the number of concurrent subscriptions to inner sequences, and using the specified scheduler for enumeration of and subscription to the sources.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Enumerable sequence of observable sequences.</param><param name="maxConcurrent">Maximum number of observable sequences being subscribed to concurrently.</param><param name="scheduler">Scheduler to run the enumeration of the sequence of sources on.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="maxConcurrent"/> is less than or equal to zero.</exception>
		public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources, int maxConcurrent, IScheduler scheduler);

		/// <summary>
		/// Merges elements from two observable sequences into a single observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="first">First observable sequence.</param><param name="second">Second observable sequence.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the given sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Merges elements from two observable sequences into a single observable sequence, using the specified scheduler for enumeration of and subscription to the sources.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="first">First observable sequence.</param><param name="second">Second observable sequence.</param><param name="scheduler">Scheduler used to introduce concurrency for making subscriptions to the given sequences.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the given sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(this IObservable<TSource> first, IObservable<TSource> second, IScheduler scheduler);

		/// <summary>
		/// Merges elements from all of the specified observable sequences into a single observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Merges elements from all of the specified observable sequences into a single observable sequence, using the specified scheduler for enumeration of and subscription to the sources.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences.</param><param name="scheduler">Scheduler to run the enumeration of the sequence of sources on.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> or <paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(IScheduler scheduler, params IObservable<TSource>[] sources);

		/// <summary>
		/// Merges elements from all observable sequences in the given enumerable sequence into a single observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Enumerable sequence of observable sequences.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Merges elements from all observable sequences in the given enumerable sequence into a single observable sequence, using the specified scheduler for enumeration of and subscription to the sources.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Enumerable sequence of observable sequences.</param><param name="scheduler">Scheduler to run the enumeration of the sequence of sources on.</param>
		/// <returns>
		/// The observable sequence that merges the elements of the observable sequences.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TSource> Merge<TSource>(this IEnumerable<IObservable<TSource>> sources, IScheduler scheduler);

		/// <summary>
		/// Concatenates the second observable sequence to the first observable sequence upon successful or exceptional termination of the first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="first">First observable sequence whose exception (if any) is caught.</param><param name="second">Second observable sequence used to produce results after the first sequence terminates.</param>
		/// <returns>
		/// An observable sequence that concatenates the first and second sequence, even if the first sequence terminates exceptionally.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
		public static IObservable<TSource> OnErrorResumeNext<TSource>(this IObservable<TSource> first, IObservable<TSource> second);

		/// <summary>
		/// Concatenates all of the specified observable sequences, even if the previous observable sequence terminated exceptionally.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences to concatenate.</param>
		/// <returns>
		/// An observable sequence that concatenates the source sequences, even if a sequence terminates exceptionally.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> OnErrorResumeNext<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Concatenates all observable sequences in the given enumerable sequence, even if the previous observable sequence terminated exceptionally.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequences to concatenate.</param>
		/// <returns>
		/// An observable sequence that concatenates the source sequences, even if a sequence terminates exceptionally.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> OnErrorResumeNext<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Returns the elements from the source observable sequence only after the other observable sequence produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TOther">The type of the elements in the other sequence that indicates the end of skip behavior.</typeparam><param name="source">Source sequence to propagate elements for.</param><param name="other">Observable sequence that triggers propagation of elements of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing the elements of the source sequence starting from the point the other sequence triggered propagation.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> is null.</exception>
		public static IObservable<TSource> SkipUntil<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other);

		/// <summary>
		/// Switches between the inner observable sequences such that the resulting sequence always produces elements from the most recently received inner observable sequence.
		///             Each time a new inner observable sequence is received, the previous inner observable sequence is unsubscribed from.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><param name="sources">Observable sequence of inner observable sequences.</param>
		/// <returns>
		/// The observable sequence that at any point in time produces the elements of the most recent inner observable sequence that has been received.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<TSource> Switch<TSource>(this IObservable<IObservable<TSource>> sources);

		/// <summary>
		/// Switches between the tasks such that the resulting sequence always produces results from the most recently received task.
		///             Each time a new task is received, the previous task's result is ignored.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the results produced by the source tasks.</typeparam><param name="sources">Observable sequence of tasks.</param>
		/// <returns>
		/// The observable sequence that at any point in time produces the result of the most recent task that has been received.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		/// <remarks>
		/// If the tasks support cancellation, consider manual conversion of the tasks using <see cref="M:System.Reactive.Linq.Observable.FromAsync``1(System.Func{System.Threading.CancellationToken,System.Threading.Tasks.Task{``0}})"/>, followed by a switch operation using <see cref="M:System.Reactive.Linq.Observable.Switch``1(System.IObservable{System.IObservable{``0}})"/>.
		/// </remarks>
		public static IObservable<TSource> Switch<TSource>(this IObservable<Task<TSource>> sources);

		/// <summary>
		/// Returns the elements from the source observable sequence until the other observable sequence produces an element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TOther">The type of the elements in the other sequence that indicates the end of take behavior.</typeparam><param name="source">Source sequence to propagate elements for.</param><param name="other">Observable sequence that terminates propagation of elements of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing the elements of the source sequence up to the point the other sequence interrupted further propagation.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> is null.</exception>
		public static IObservable<TSource> TakeUntil<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping windows.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><typeparam name="TWindowClosing">The type of the elements in the sequences indicating window closing events.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="windowClosingSelector">A function invoked to define the boundaries of the produced windows. A new window is started when the previous one is closed.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="windowClosingSelector"/> is null.</exception>
		public static IObservable<IObservable<TSource>> Window<TSource, TWindowClosing>(this IObservable<TSource> source, Func<IObservable<TWindowClosing>> windowClosingSelector);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><typeparam name="TWindowOpening">The type of the elements in the sequence indicating window opening events, also passed to the closing selector to obtain a sequence of window closing events.</typeparam><typeparam name="TWindowClosing">The type of the elements in the sequences indicating window closing events.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="windowOpenings">Observable sequence whose elements denote the creation of new windows.</param><param name="windowClosingSelector">A function invoked to define the closing of each produced window.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="windowOpenings"/> or <paramref name="windowClosingSelector"/> is null.</exception>
		public static IObservable<IObservable<TSource>> Window<TSource, TWindowOpening, TWindowClosing>(this IObservable<TSource> source, IObservable<TWindowOpening> windowOpenings, Func<TWindowOpening, IObservable<TWindowClosing>> windowClosingSelector);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping windows.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><typeparam name="TWindowBoundary">The type of the elements in the sequences indicating window boundary events.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="windowBoundaries">Sequence of window boundary markers. The current window is closed and a new window is opened upon receiving a boundary marker.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="windowBoundaries"/> is null.</exception>
		public static IObservable<IObservable<TSource>> Window<TSource, TWindowBoundary>(this IObservable<TSource> source, IObservable<TWindowBoundary> windowBoundaries);

		/// <summary>
		/// Merges two observable sequences into one observable sequence by combining their elements in a pairwise fashion.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="first">First observable source.</param><param name="second">Second observable source.</param><param name="resultSelector">Function to invoke for each consecutive pair of elements from the first and second source.</param>
		/// <returns>
		/// An observable sequence containing the result of pairwise combining the elements of the first and second source using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TResult>(this IObservable<TSource1> first, IObservable<TSource2> second, Func<TSource1, TSource2, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, Func<TSource1, TSource2, TSource3, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, Func<TSource1, TSource2, TSource3, TSource4, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TSource15">The type of the elements in the fifteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="source15">Fifteenth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="source15"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, IObservable<TSource15> source15, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second source sequence.</typeparam><typeparam name="TSource3">The type of the elements in the third source sequence.</typeparam><typeparam name="TSource4">The type of the elements in the fourth source sequence.</typeparam><typeparam name="TSource5">The type of the elements in the fifth source sequence.</typeparam><typeparam name="TSource6">The type of the elements in the sixth source sequence.</typeparam><typeparam name="TSource7">The type of the elements in the seventh source sequence.</typeparam><typeparam name="TSource8">The type of the elements in the eighth source sequence.</typeparam><typeparam name="TSource9">The type of the elements in the ninth source sequence.</typeparam><typeparam name="TSource10">The type of the elements in the tenth source sequence.</typeparam><typeparam name="TSource11">The type of the elements in the eleventh source sequence.</typeparam><typeparam name="TSource12">The type of the elements in the twelfth source sequence.</typeparam><typeparam name="TSource13">The type of the elements in the thirteenth source sequence.</typeparam><typeparam name="TSource14">The type of the elements in the fourteenth source sequence.</typeparam><typeparam name="TSource15">The type of the elements in the fifteenth source sequence.</typeparam><typeparam name="TSource16">The type of the elements in the sixteenth source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="source1">First observable source.</param><param name="source2">Second observable source.</param><param name="source3">Third observable source.</param><param name="source4">Fourth observable source.</param><param name="source5">Fifth observable source.</param><param name="source6">Sixth observable source.</param><param name="source7">Seventh observable source.</param><param name="source8">Eighth observable source.</param><param name="source9">Ninth observable source.</param><param name="source10">Tenth observable source.</param><param name="source11">Eleventh observable source.</param><param name="source12">Twelfth observable source.</param><param name="source13">Thirteenth observable source.</param><param name="source14">Fourteenth observable source.</param><param name="source15">Fifteenth observable source.</param><param name="source16">Sixteenth observable source.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source1"/> or <paramref name="source2"/> or <paramref name="source3"/> or <paramref name="source4"/> or <paramref name="source5"/> or <paramref name="source6"/> or <paramref name="source7"/> or <paramref name="source8"/> or <paramref name="source9"/> or <paramref name="source10"/> or <paramref name="source11"/> or <paramref name="source12"/> or <paramref name="source13"/> or <paramref name="source14"/> or <paramref name="source15"/> or <paramref name="source16"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>(this IObservable<TSource1> source1, IObservable<TSource2> source2, IObservable<TSource3> source3, IObservable<TSource4> source4, IObservable<TSource5> source5, IObservable<TSource6> source6, IObservable<TSource7> source7, IObservable<TSource8> source8, IObservable<TSource9> source9, IObservable<TSource10> source10, IObservable<TSource11> source11, IObservable<TSource12> source12, IObservable<TSource13> source13, IObservable<TSource14> source14, IObservable<TSource15> source15, IObservable<TSource16> source16, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever all of the observable sequences have produced an element at a corresponding index.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="sources">Observable sources.</param><param name="resultSelector">Function to invoke for each series of elements at corresponding indexes in the sources.</param>
		/// <returns>
		/// An observable sequence containing the result of combining elements of the sources using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource, TResult>(this IEnumerable<IObservable<TSource>> sources, Func<IList<TSource>, TResult> resultSelector);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by emitting a list with the elements of the observable sequences at corresponding indexes.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences, and in the lists in the result sequence.</typeparam><param name="sources">Observable sources.</param>
		/// <returns>
		/// An observable sequence containing lists of elements at corresponding indexes.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<IList<TSource>> Zip<TSource>(this IEnumerable<IObservable<TSource>> sources);

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by emitting a list with the elements of the observable sequences at corresponding indexes.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequences, and in the lists in the result sequence.</typeparam><param name="sources">Observable sources.</param>
		/// <returns>
		/// An observable sequence containing lists of elements at corresponding indexes.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="sources"/> is null.</exception>
		public static IObservable<IList<TSource>> Zip<TSource>(params IObservable<TSource>[] sources);

		/// <summary>
		/// Merges an observable sequence and an enumerable sequence into one observable sequence by using the selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource1">The type of the elements in the first observable source sequence.</typeparam><typeparam name="TSource2">The type of the elements in the second enumerable source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, returned by the selector function.</typeparam><param name="first">First observable source.</param><param name="second">Second enumerable source.</param><param name="resultSelector">Function to invoke for each consecutive pair of elements from the first and second source.</param>
		/// <returns>
		/// An observable sequence containing the result of pairwise combining the elements of the first and second source using the specified result selector function.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Zip<TSource1, TSource2, TResult>(this IObservable<TSource1> first, IEnumerable<TSource2> second, Func<TSource1, TSource2, TResult> resultSelector);

		/// <summary>
		/// Hides the identity of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence whose identity to hide.</param>
		/// <returns>
		/// An observable sequence that hides the identity of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> AsObservable<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping buffers which are produced based on element count information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="count">Length of each buffer.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than or equal to zero.</exception>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on element count information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="count">Length of each buffer.</param><param name="skip">Number of elements to skip between creation of consecutive buffers.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> or <paramref name="skip"/> is less than or equal to zero.</exception>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, int count, int skip);

		/// <summary>
		/// Dematerializes the explicit notification values of an observable sequence as implicit notifications.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements materialized in the source sequence notification objects.</typeparam><param name="source">An observable sequence containing explicit notification values which have to be turned into implicit notifications.</param>
		/// <returns>
		/// An observable sequence exhibiting the behavior corresponding to the source sequence's notification values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> Dematerialize<TSource>(this IObservable<Notification<TSource>> source);

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct contiguous elements for.</param>
		/// <returns>
		/// An observable sequence only containing the distinct contiguous elements from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> DistinctUntilChanged<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements according to the comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct contiguous elements for.</param><param name="comparer">Equality comparer for source elements.</param>
		/// <returns>
		/// An observable sequence only containing the distinct contiguous elements from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<TSource> DistinctUntilChanged<TSource>(this IObservable<TSource> source, IEqualityComparer<TSource> comparer);

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements according to the keySelector.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the discriminator key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct contiguous elements for, based on a computed key value.</param><param name="keySelector">A function to compute the comparison key for each element.</param>
		/// <returns>
		/// An observable sequence only containing the distinct contiguous elements, based on a computed key value, from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		public static IObservable<TSource> DistinctUntilChanged<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements according to the keySelector and the comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the discriminator key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct contiguous elements for, based on a computed key value.</param><param name="keySelector">A function to compute the comparison key for each element.</param><param name="comparer">Equality comparer for computed key values.</param>
		/// <returns>
		/// An observable sequence only containing the distinct contiguous elements, based on a computed key value, from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<TSource> DistinctUntilChanged<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Invokes an action for each element in the observable sequence, and propagates all observer messages through the result sequence.
		///             This method can be used for debugging, logging, etc. of query behavior by intercepting the message stream to run arbitrary actions for messages on the pipeline.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param>
		/// <returns>
		/// The source sequence with the side-effecting behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		public static IObservable<TSource> Do<TSource>(this IObservable<TSource> source, Action<TSource> onNext);

		/// <summary>
		/// Invokes an action for each element in the observable sequence and invokes an action upon graceful termination of the observable sequence.
		///             This method can be used for debugging, logging, etc. of query behavior by intercepting the message stream to run arbitrary actions for messages on the pipeline.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>
		/// The source sequence with the side-effecting behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onCompleted"/> is null.</exception>
		public static IObservable<TSource> Do<TSource>(this IObservable<TSource> source, Action<TSource> onNext, Action onCompleted);

		/// <summary>
		/// Invokes an action for each element in the observable sequence and invokes an action upon exceptional termination of the observable sequence.
		///             This method can be used for debugging, logging, etc. of query behavior by intercepting the message stream to run arbitrary actions for messages on the pipeline.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param>
		/// <returns>
		/// The source sequence with the side-effecting behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> is null.</exception>
		public static IObservable<TSource> Do<TSource>(this IObservable<TSource> source, Action<TSource> onNext, Action<Exception> onError);

		/// <summary>
		/// Invokes an action for each element in the observable sequence and invokes an action upon graceful or exceptional termination of the observable sequence.
		///             This method can be used for debugging, logging, etc. of query behavior by intercepting the message stream to run arbitrary actions for messages on the pipeline.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>
		/// The source sequence with the side-effecting behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> or <paramref name="onCompleted"/> is null.</exception>
		public static IObservable<TSource> Do<TSource>(this IObservable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted);

		/// <summary>
		/// Invokes the observer's methods for each message in the source sequence.
		///             This method can be used for debugging, logging, etc. of query behavior by intercepting the message stream to run arbitrary actions for messages on the pipeline.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="observer">Observer whose methods to invoke as part of the source sequence's observation.</param>
		/// <returns>
		/// The source sequence with the side-effecting behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="observer"/> is null.</exception>
		public static IObservable<TSource> Do<TSource>(this IObservable<TSource> source, IObserver<TSource> observer);

		/// <summary>
		/// Invokes a specified action after the source observable sequence terminates gracefully or exceptionally.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="finallyAction">Action to invoke after the source observable sequence terminates.</param>
		/// <returns>
		/// Source sequence with the action-invoking termination behavior applied.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="finallyAction"/> is null.</exception>
		public static IObservable<TSource> Finally<TSource>(this IObservable<TSource> source, Action finallyAction);

		/// <summary>
		/// Ignores all elements in an observable sequence leaving only the termination messages.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param>
		/// <returns>
		/// An empty observable sequence that signals termination, successful or exceptional, of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> IgnoreElements<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Materializes the implicit notifications of an observable sequence as explicit notification values.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to get notification values for.</param>
		/// <returns>
		/// An observable sequence containing the materialized notification values from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<Notification<TSource>> Materialize<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Repeats the observable sequence indefinitely.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to repeat.</param>
		/// <returns>
		/// The observable sequence producing the elements of the given sequence repeatedly and sequentially.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> Repeat<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Repeats the observable sequence a specified number of times.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to repeat.</param><param name="repeatCount">Number of times to repeat the sequence.</param>
		/// <returns>
		/// The observable sequence producing the elements of the given sequence repeatedly.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="repeatCount"/> is less than zero.</exception>
		public static IObservable<TSource> Repeat<TSource>(this IObservable<TSource> source, int repeatCount);

		/// <summary>
		/// Repeats the source observable sequence until it successfully terminates.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to repeat until it successfully terminates.</param>
		/// <returns>
		/// An observable sequence producing the elements of the given sequence repeatedly until it terminates successfully.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> Retry<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Repeats the source observable sequence the specified number of times or until it successfully terminates.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to repeat until it successfully terminates.</param><param name="retryCount">Number of times to repeat the sequence.</param>
		/// <returns>
		/// An observable sequence producing the elements of the given sequence repeatedly until it terminates successfully.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="retryCount"/> is less than zero.</exception>
		public static IObservable<TSource> Retry<TSource>(this IObservable<TSource> source, int retryCount);

		/// <summary>
		/// Applies an accumulator function over an observable sequence and returns each intermediate result. The specified seed value is used as the initial accumulator value.
		///             For aggregation behavior with no intermediate results, see <see cref="M:System.Reactive.Linq.Observable.Aggregate``2(System.IObservable{``0},``1,System.Func{``1,``0,``1})"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TAccumulate">The type of the result of the aggregation.</typeparam><param name="source">An observable sequence to accumulate over.</param><param name="seed">The initial accumulator value.</param><param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>
		/// An observable sequence containing the accumulated values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="accumulator"/> is null.</exception>
		public static IObservable<TAccumulate> Scan<TSource, TAccumulate>(this IObservable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator);

		/// <summary>
		/// Applies an accumulator function over an observable sequence and returns each intermediate result.
		///             For aggregation behavior with no intermediate results, see <see cref="M:System.Reactive.Linq.Observable.Aggregate``1(System.IObservable{``0},System.Func{``0,``0,``0})"/>.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the result of the aggregation.</typeparam><param name="source">An observable sequence to accumulate over.</param><param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>
		/// An observable sequence containing the accumulated values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="accumulator"/> is null.</exception>
		public static IObservable<TSource> Scan<TSource>(this IObservable<TSource> source, Func<TSource, TSource, TSource> accumulator);

		/// <summary>
		/// Bypasses a specified number of elements at the end of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="count">Number of elements to bypass at the end of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing the source sequence elements except for the bypassed ones at the end.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		/// <remarks>
		/// This operator accumulates a queue with a length enough to store the first <paramref name="count"/> elements. As more elements are
		///             received, elements are taken from the front of the queue and produced on the result sequence. This causes elements to be delayed.
		/// 
		/// </remarks>
		public static IObservable<TSource> SkipLast<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Prepends a sequence of values to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to prepend values to.</param><param name="values">Values to prepend to the specified sequence.</param>
		/// <returns>
		/// The source sequence prepended with the specified values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="values"/> is null.</exception>
		public static IObservable<TSource> StartWith<TSource>(this IObservable<TSource> source, params TSource[] values);

		/// <summary>
		/// Prepends a sequence of values to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to prepend values to.</param><param name="scheduler">Scheduler to emit the prepended values on.</param><param name="values">Values to prepend to the specified sequence.</param>
		/// <returns>
		/// The source sequence prepended with the specified values.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> or <paramref name="values"/> is null.</exception>
		public static IObservable<TSource> StartWith<TSource>(this IObservable<TSource> source, IScheduler scheduler, params TSource[] values);

		/// <summary>
		/// Returns a specified number of contiguous elements from the end of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="count">Number of elements to take from the end of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing the specified number of elements from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements <paramref name="count"/> elements. Upon completion of
		///             the source sequence, this buffer is drained on the result sequence. This causes the elements to be delayed.
		/// 
		/// </remarks>
		public static IObservable<TSource> TakeLast<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Returns a specified number of contiguous elements from the end of an observable sequence, using the specified scheduler to drain the queue.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="count">Number of elements to take from the end of the source sequence.</param><param name="scheduler">Scheduler used to drain the queue upon completion of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing the specified number of elements from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements <paramref name="count"/> elements. Upon completion of
		///             the source sequence, this buffer is drained on the result sequence. This causes the elements to be delayed.
		/// 
		/// </remarks>
		public static IObservable<TSource> TakeLast<TSource>(this IObservable<TSource> source, int count, IScheduler scheduler);

		/// <summary>
		/// Returns a list with the specified number of contiguous elements from the end of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence.</param><param name="count">Number of elements to take from the end of the source sequence.</param>
		/// <returns>
		/// An observable sequence containing a single list with the specified number of elements from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store <paramref name="count"/> elements. Upon completion of the
		///             source sequence, this buffer is produced on the result sequence.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> TakeLastBuffer<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping windows which are produced based on element count information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="count">Length of each window.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than or equal to zero.</exception>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on element count information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="count">Length of each window.</param><param name="skip">Number of elements to skip between creation of consecutive windows.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> or <paramref name="skip"/> is less than or equal to zero.</exception>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, int count, int skip);

		/// <summary>
		/// Converts the elements of an observable sequence to the specified type.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type to convert the elements in the source sequence to.</typeparam><param name="source">The observable sequence that contains the elements to be converted.</param>
		/// <returns>
		/// An observable sequence that contains each element of the source sequence converted to the specified type.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TResult> Cast<TResult>(this IObservable<object> source);

		/// <summary>
		/// Returns the elements of the specified sequence or the type parameter's default value in a singleton sequence if the sequence is empty.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence (if any), whose default value will be taken if the sequence is empty.</typeparam><param name="source">The sequence to return a default value for if it is empty.</param>
		/// <returns>
		/// An observable sequence that contains the default value for the TSource type if the source is empty; otherwise, the elements of the source itself.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> DefaultIfEmpty<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns the elements of the specified sequence or the specified value in a singleton sequence if the sequence is empty.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence (if any), and the specified default value which will be taken if the sequence is empty.</typeparam><param name="source">The sequence to return the specified value for if it is empty.</param><param name="defaultValue">The value to return if the sequence is empty.</param>
		/// <returns>
		/// An observable sequence that contains the specified default value if the source is empty; otherwise, the elements of the source itself.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> DefaultIfEmpty<TSource>(this IObservable<TSource> source, TSource defaultValue);

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct elements for.</param>
		/// <returns>
		/// An observable sequence only containing the distinct elements from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Usage of this operator should be considered carefully due to the maintenance of an internal lookup structure which can grow large.
		/// </remarks>
		public static IObservable<TSource> Distinct<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements according to the comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct elements for.</param><param name="comparer">Equality comparer for source elements.</param>
		/// <returns>
		/// An observable sequence only containing the distinct elements from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// Usage of this operator should be considered carefully due to the maintenance of an internal lookup structure which can grow large.
		/// </remarks>
		public static IObservable<TSource> Distinct<TSource>(this IObservable<TSource> source, IEqualityComparer<TSource> comparer);

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements according to the keySelector.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the discriminator key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct elements for.</param><param name="keySelector">A function to compute the comparison key for each element.</param>
		/// <returns>
		/// An observable sequence only containing the distinct elements, based on a computed key value, from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		/// <remarks>
		/// Usage of this operator should be considered carefully due to the maintenance of an internal lookup structure which can grow large.
		/// </remarks>
		public static IObservable<TSource> Distinct<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements according to the keySelector and the comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the discriminator key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence to retain distinct elements for.</param><param name="keySelector">A function to compute the comparison key for each element.</param><param name="comparer">Equality comparer for source elements.</param>
		/// <returns>
		/// An observable sequence only containing the distinct elements, based on a computed key value, from the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		/// <remarks>
		/// Usage of this operator should be considered carefully due to the maintenance of an internal lookup structure which can grow large.
		/// </remarks>
		public static IObservable<TSource> Distinct<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="comparer">An equality comparer to compare keys with.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Groups the elements of an observable sequence and selects the resulting elements by using a specified function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the elements within the groups computed for each element in the source sequence.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="elementSelector">A function to map each source element to an element in an observable group.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer and selects the resulting elements by using a specified function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the elements within the groups computed for each element in the source sequence.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="elementSelector">A function to map each source element to an element in an observable group.</param><param name="comparer">An equality comparer to compare keys with.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer and selects the resulting elements by using a specified function.
		///             A duration selector function is used to control the lifetime of groups. When a group expires, it receives an OnCompleted notification. When a new element with the same
		///             key value as a reclaimed group occurs, the group will be reborn with a new lifetime request.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the elements within the groups computed for each element in the source sequence.</typeparam><typeparam name="TDuration">The type of the elements in the duration sequences obtained for each group to denote its lifetime.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="elementSelector">A function to map each source element to an element in an observable group.</param><param name="durationSelector">A function to signal the expiration of a group.</param><param name="comparer">An equality comparer to compare keys with.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		///             If a group's lifetime expires, a new group with the same key value can be created once an element with such a key value is encountered.
		/// 
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> or <paramref name="durationSelector"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<IGroupedObservable<TKey, TElement>, IObservable<TDuration>> durationSelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and selects the resulting elements by using a specified function.
		///             A duration selector function is used to control the lifetime of groups. When a group expires, it receives an OnCompleted notification. When a new element with the same
		///             key value as a reclaimed group occurs, the group will be reborn with a new lifetime request.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TElement">The type of the elements within the groups computed for each element in the source sequence.</typeparam><typeparam name="TDuration">The type of the elements in the duration sequences obtained for each group to denote its lifetime.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="elementSelector">A function to map each source element to an element in an observable group.</param><param name="durationSelector">A function to signal the expiration of a group.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		///             If a group's lifetime expires, a new group with the same key value can be created once an element with such a key value is encoutered.
		/// 
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="elementSelector"/> or <paramref name="durationSelector"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TElement>> GroupByUntil<TSource, TKey, TElement, TDuration>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<IGroupedObservable<TKey, TElement>, IObservable<TDuration>> durationSelector);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer.
		///             A duration selector function is used to control the lifetime of groups. When a group expires, it receives an OnCompleted notification. When a new element with the same
		///             key value as a reclaimed group occurs, the group will be reborn with a new lifetime request.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TDuration">The type of the elements in the duration sequences obtained for each group to denote its lifetime.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="durationSelector">A function to signal the expiration of a group.</param><param name="comparer">An equality comparer to compare keys with.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		///             If a group's lifetime expires, a new group with the same key value can be created once an element with such a key value is encoutered.
		/// 
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="durationSelector"/> or <paramref name="comparer"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<IGroupedObservable<TKey, TSource>, IObservable<TDuration>> durationSelector, IEqualityComparer<TKey> comparer);

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function.
		///             A duration selector function is used to control the lifetime of groups. When a group expires, it receives an OnCompleted notification. When a new element with the same
		///             key value as a reclaimed group occurs, the group will be reborn with a new lifetime request.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TKey">The type of the grouping key computed for each element in the source sequence.</typeparam><typeparam name="TDuration">The type of the elements in the duration sequences obtained for each group to denote its lifetime.</typeparam><param name="source">An observable sequence whose elements to group.</param><param name="keySelector">A function to extract the key for each element.</param><param name="durationSelector">A function to signal the expiration of a group.</param>
		/// <returns>
		/// A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.
		///             If a group's lifetime expires, a new group with the same key value can be created once an element with such a key value is encoutered.
		/// 
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="durationSelector"/> is null.</exception>
		public static IObservable<IGroupedObservable<TKey, TSource>> GroupByUntil<TSource, TKey, TDuration>(this IObservable<TSource> source, Func<TSource, TKey> keySelector, Func<IGroupedObservable<TKey, TSource>, IObservable<TDuration>> durationSelector);

		/// <summary>
		/// Correlates the elements of two sequences based on overlapping durations, and groups the results.
		/// 
		/// </summary>
		/// <typeparam name="TLeft">The type of the elements in the left source sequence.</typeparam><typeparam name="TRight">The type of the elements in the right source sequence.</typeparam><typeparam name="TLeftDuration">The type of the elements in the duration sequence denoting the computed duration of each element in the left source sequence.</typeparam><typeparam name="TRightDuration">The type of the elements in the duration sequence denoting the computed duration of each element in the right source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by invoking the result selector function for source elements with overlapping duration.</typeparam><param name="left">The left observable sequence to join elements for.</param><param name="right">The right observable sequence to join elements for.</param><param name="leftDurationSelector">A function to select the duration of each element of the left observable sequence, used to determine overlap.</param><param name="rightDurationSelector">A function to select the duration of each element of the right observable sequence, used to determine overlap.</param><param name="resultSelector">A function invoked to compute a result element for any element of the left sequence with overlapping elements from the right observable sequence.</param>
		/// <returns>
		/// An observable sequence that contains result elements computed from source elements that have an overlapping duration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> or <paramref name="leftDurationSelector"/> or <paramref name="rightDurationSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> GroupJoin<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, IObservable<TLeftDuration>> leftDurationSelector, Func<TRight, IObservable<TRightDuration>> rightDurationSelector, Func<TLeft, IObservable<TRight>, TResult> resultSelector);

		/// <summary>
		/// Correlates the elements of two sequences based on overlapping durations.
		/// 
		/// </summary>
		/// <typeparam name="TLeft">The type of the elements in the left source sequence.</typeparam><typeparam name="TRight">The type of the elements in the right source sequence.</typeparam><typeparam name="TLeftDuration">The type of the elements in the duration sequence denoting the computed duration of each element in the left source sequence.</typeparam><typeparam name="TRightDuration">The type of the elements in the duration sequence denoting the computed duration of each element in the right source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by invoking the result selector function for source elements with overlapping duration.</typeparam><param name="left">The left observable sequence to join elements for.</param><param name="right">The right observable sequence to join elements for.</param><param name="leftDurationSelector">A function to select the duration of each element of the left observable sequence, used to determine overlap.</param><param name="rightDurationSelector">A function to select the duration of each element of the right observable sequence, used to determine overlap.</param><param name="resultSelector">A function invoked to compute a result element for any two overlapping elements of the left and right observable sequences.</param>
		/// <returns>
		/// An observable sequence that contains result elements computed from source elements that have an overlapping duration.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> or <paramref name="leftDurationSelector"/> or <paramref name="rightDurationSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> Join<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this IObservable<TLeft> left, IObservable<TRight> right, Func<TLeft, IObservable<TLeftDuration>> leftDurationSelector, Func<TRight, IObservable<TRightDuration>> rightDurationSelector, Func<TLeft, TRight, TResult> resultSelector);

		/// <summary>
		/// Filters the elements of an observable sequence based on the specified type.
		/// 
		/// </summary>
		/// <typeparam name="TResult">The type to filter the elements in the source sequence on.</typeparam><param name="source">The observable sequence that contains the elements to be filtered.</param>
		/// <returns>
		/// An observable sequence that contains elements from the input sequence of type TResult.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TResult> OfType<TResult>(this IObservable<object> source);

		/// <summary>
		/// Projects each element of an observable sequence into a new form.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by running the selector function for each element in the source sequence.</typeparam><param name="source">A sequence of elements to invoke a transform function on.</param><param name="selector">A transform function to apply to each source element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the transform function on each element of source.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, TResult> selector);

		/// <summary>
		/// Projects each element of an observable sequence into a new form by incorporating the element's index.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by running the selector function for each element in the source sequence.</typeparam><param name="source">A sequence of elements to invoke a transform function on.</param><param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the transform function on each element of source.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, Func<TSource, int, TResult> selector);

		/// <summary>
		/// Projects each element of the source observable sequence to the other observable sequence and merges the resulting observable sequences into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TOther">The type of the elements in the other sequence and the elements in the result sequence.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="other">An observable sequence to project each element from the source sequence onto.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of projecting each source element onto the other sequence and merging all the resulting sequences together.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> is null.</exception>
		public static IObservable<TOther> SelectMany<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other);

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence and merges the resulting observable sequences into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the projected inner sequences and the elements in the merged result sequence.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IObservable<TResult>> selector);

		/// <summary>
		/// Projects each element of an observable sequence to a task and merges all of the task results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the result produced by the projected tasks and the elements in the merged result sequence.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of the tasks executed for each element of the input sequence.
		/// </returns>
		/// 
		/// <remarks>
		/// This overload supports composition of observable sequences and tasks, without requiring manual conversion of the tasks to observable sequences using <see cref="M:System.Reactive.Threading.Tasks.TaskObservableExtensions.ToObservable``1(System.Threading.Tasks.Task{``0})"/>.
		/// </remarks>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, Task<TResult>> selector);

		/// <summary>
		/// Projects each element of an observable sequence to a task with cancellation support and merges all of the task results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the result produced by the projected tasks and the elements in the merged result sequence.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of the tasks executed for each element of the input sequence.
		/// </returns>
		/// 
		/// <remarks>
		/// This overload supports composition of observable sequences and tasks, without requiring manual conversion of the tasks to observable sequences using <see cref="M:System.Reactive.Threading.Tasks.TaskObservableExtensions.ToObservable``1(System.Threading.Tasks.Task{``0})"/>.
		/// </remarks>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, CancellationToken, Task<TResult>> selector);

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence, invokes the result selector for the source element and each of the corresponding inner sequence's elements, and merges the results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TCollection">The type of the elements in the projected intermediate sequences.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by using the selector to combine source sequence elements with their corresponding intermediate sequence elements.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="collectionSelector">A transform function to apply to each element.</param><param name="resultSelector">A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="collectionSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source, Func<TSource, IObservable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);

		/// <summary>
		/// Projects each element of an observable sequence to a task, invokes the result selector for the source element and the task result, and merges the results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TTaskResult">The type of the results produced by the projected intermediate tasks.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by using the selector to combine source sequence elements with their corresponding intermediate task results.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="taskSelector">A transform function to apply to each element.</param><param name="resultSelector">A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of obtaining a task for each element of the input sequence and then mapping the task's result and its corresponding source element to a result element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="taskSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		/// <remarks>
		/// This overload supports using LINQ query comprehension syntax in C# and Visual Basic to compose observable sequences and tasks, without requiring manual conversion of the tasks to observable sequences using <see cref="M:System.Reactive.Threading.Tasks.TaskObservableExtensions.ToObservable``1(System.Threading.Tasks.Task{``0})"/>.
		/// </remarks>
		public static IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this IObservable<TSource> source, Func<TSource, Task<TTaskResult>> taskSelector, Func<TSource, TTaskResult, TResult> resultSelector);

		/// <summary>
		/// Projects each element of an observable sequence to a task with cancellation support, invokes the result selector for the source element and the task result, and merges the results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TTaskResult">The type of the results produced by the projected intermediate tasks.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by using the selector to combine source sequence elements with their corresponding intermediate task results.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="taskSelector">A transform function to apply to each element.</param><param name="resultSelector">A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of obtaining a task for each element of the input sequence and then mapping the task's result and its corresponding source element to a result element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="taskSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		/// <remarks>
		/// This overload supports using LINQ query comprehension syntax in C# and Visual Basic to compose observable sequences and tasks, without requiring manual conversion of the tasks to observable sequences using <see cref="M:System.Reactive.Threading.Tasks.TaskObservableExtensions.ToObservable``1(System.Threading.Tasks.Task{``0})"/>.
		/// </remarks>
		public static IObservable<TResult> SelectMany<TSource, TTaskResult, TResult>(this IObservable<TSource> source, Func<TSource, CancellationToken, Task<TTaskResult>> taskSelector, Func<TSource, TTaskResult, TResult> resultSelector);

		/// <summary>
		/// Projects each notification of an observable sequence to an observable sequence and merges the resulting observable sequences into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the projected inner sequences and the elements in the merged result sequence.</typeparam><param name="source">An observable sequence of notifications to project.</param><param name="onNext">A transform function to apply to each element.</param><param name="onError">A transform function to apply when an error occurs in the source sequence.</param><param name="onCompleted">A transform function to apply when the end of the source sequence is reached.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the one-to-many transform function corresponding to each notification in the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> or <paramref name="onCompleted"/> is null.</exception>
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IObservable<TResult>> onNext, Func<Exception, IObservable<TResult>> onError, Func<IObservable<TResult>> onCompleted);

		/// <summary>
		/// Projects each element of an observable sequence to an enumerable sequence and concatenates the resulting enumerable sequences into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TResult">The type of the elements in the projected inner enumerable sequences and the elements in the merged result sequence.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="selector">A transform function to apply to each element.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="selector"/> is null.</exception>
		/// <remarks>
		/// The projected sequences are enumerated synchonously within the OnNext call of the source sequence. In order to do a concurrent, non-blocking merge, change the selector to return an observable sequence obtained using the <see cref="M:System.Reactive.Linq.Observable.ToObservable``1(System.Collections.Generic.IEnumerable{``0})"/> conversion.
		/// </remarks>
		public static IObservable<TResult> SelectMany<TSource, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> selector);

		/// <summary>
		/// Projects each element of an observable sequence to an enumerable sequence, invokes the result selector for the source element and each of the corresponding inner sequence's elements, and merges the results into one observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TCollection">The type of the elements in the projected intermediate enumerable sequences.</typeparam><typeparam name="TResult">The type of the elements in the result sequence, obtained by using the selector to combine source sequence elements with their corresponding intermediate sequence elements.</typeparam><param name="source">An observable sequence of elements to project.</param><param name="collectionSelector">A transform function to apply to each element.</param><param name="resultSelector">A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>
		/// An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="collectionSelector"/> or <paramref name="resultSelector"/> is null.</exception>
		/// <remarks>
		/// The projected sequences are enumerated synchonously within the OnNext call of the source sequence. In order to do a concurrent, non-blocking merge, change the selector to return an observable sequence obtained using the <see cref="M:System.Reactive.Linq.Observable.ToObservable``1(System.Collections.Generic.IEnumerable{``0})"/> conversion.
		/// </remarks>
		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);

		/// <summary>
		/// Bypasses a specified number of elements in an observable sequence and then returns the remaining elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">The sequence to take elements from.</param><param name="count">The number of elements to skip before returning the remaining elements.</param>
		/// <returns>
		/// An observable sequence that contains the elements that occur after the specified index in the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		public static IObservable<TSource> Skip<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Bypasses elements in an observable sequence as long as a specified condition is true and then returns the remaining elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to return elements from.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> SkipWhile<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Bypasses elements in an observable sequence as long as a specified condition is true and then returns the remaining elements.
		///             The element's index is used in the logic of the predicate function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence to return elements from.</param><param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <returns>
		/// An observable sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> SkipWhile<TSource>(this IObservable<TSource> source, Func<TSource, int, bool> predicate);

		/// <summary>
		/// Returns a specified number of contiguous elements from the start of an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">The sequence to take elements from.</param><param name="count">The number of elements to return.</param>
		/// <returns>
		/// An observable sequence that contains the specified number of elements from the start of the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		public static IObservable<TSource> Take<TSource>(this IObservable<TSource> source, int count);

		/// <summary>
		/// Returns a specified number of contiguous elements from the start of an observable sequence, using the specified scheduler for the edge case of Take(0).
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">The sequence to take elements from.</param><param name="count">The number of elements to return.</param><param name="scheduler">Scheduler used to produce an OnCompleted message in case <paramref name="count">count</paramref> is set to 0.</param>
		/// <returns>
		/// An observable sequence that contains the specified number of elements from the start of the input sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="count"/> is less than zero.</exception>
		public static IObservable<TSource> Take<TSource>(this IObservable<TSource> source, int count, IScheduler scheduler);

		/// <summary>
		/// Returns elements from an observable sequence as long as a specified condition is true.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence to return elements from.</param><param name="predicate">A function to test each element for a condition.</param>
		/// <returns>
		/// An observable sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> TakeWhile<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Returns elements from an observable sequence as long as a specified condition is true.
		///             The element's index is used in the logic of the predicate function.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">A sequence to return elements from.</param><param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <returns>
		/// An observable sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> TakeWhile<TSource>(this IObservable<TSource> source, Func<TSource, int, bool> predicate);

		/// <summary>
		/// Filters the elements of an observable sequence based on a predicate.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence whose elements to filter.</param><param name="predicate">A function to test each source element for a condition.</param>
		/// <returns>
		/// An observable sequence that contains elements from the input sequence that satisfy the condition.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> Where<TSource>(this IObservable<TSource> source, Func<TSource, bool> predicate);

		/// <summary>
		/// Filters the elements of an observable sequence based on a predicate by incorporating the element's index.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">An observable sequence whose elements to filter.</param><param name="predicate">A function to test each source element for a conditio; the second parameter of the function represents the index of the source element.</param>
		/// <returns>
		/// An observable sequence that contains elements from the input sequence that satisfy the condition.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
		public static IObservable<TSource> Where<TSource>(this IObservable<TSource> source, Func<TSource, int, bool> predicate);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping buffers which are produced based on timing information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Length of each buffer.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             Because all source sequence elements end up in one of the buffers, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current buffer and to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping buffers which are produced based on timing information, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Length of each buffer.</param><param name="scheduler">Scheduler to run buffering timers on.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             Because all source sequence elements end up in one of the buffers, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current buffer and to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, IScheduler scheduler);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on timing information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Length of each buffer.</param><param name="timeShift">Interval between creation of consecutive buffers.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> or <paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers with minimum duration
		///             length. However, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced by the scheduler, where the action to close the
		///             current buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeShift"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             However, this doesn't mean all buffers will start at the beginning of the source sequence. This is a side-effect of the asynchrony introduced by the scheduler,
		///             where the action to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, TimeSpan timeShift);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on timing information, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Length of each buffer.</param><param name="timeShift">Interval between creation of consecutive buffers.</param><param name="scheduler">Scheduler to run buffering timers on.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> or <paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers with minimum duration
		///             length. However, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced by the scheduler, where the action to close the
		///             current buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeShift"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             However, this doesn't mean all buffers will start at the beginning of the source sequence. This is a side-effect of the asynchrony introduced by the scheduler,
		///             where the action to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, TimeSpan timeShift, IScheduler scheduler);

		/// <summary>
		/// Projects each element of an observable sequence into a buffer that's sent out when either it's full or a given amount of time has elapsed.
		///             A useful real-world analogy of this overload is the behavior of a ferry leaving the dock when all seats are taken, or at the scheduled time of departure, whichever event occurs first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Maximum time length of a window.</param><param name="count">Maximum element count of a window.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero. -or- <paramref name="count"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             Because all source sequence elements end up in one of the buffers, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current buffer and to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, int count);

		/// <summary>
		/// Projects each element of an observable sequence into a buffer that's sent out when either it's full or a given amount of time has elapsed, using the specified scheduler to run timers.
		///             A useful real-world analogy of this overload is the behavior of a ferry leaving the dock when all seats are taken, or at the scheduled time of departure, whichever event occurs first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the lists in the result sequence.</typeparam><param name="source">Source sequence to produce buffers over.</param><param name="timeSpan">Maximum time length of a buffer.</param><param name="count">Maximum element count of a buffer.</param><param name="scheduler">Scheduler to run buffering timers on.</param>
		/// <returns>
		/// An observable sequence of buffers.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero. -or- <paramref name="count"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create buffers as fast as it can.
		///             Because all source sequence elements end up in one of the buffers, some buffers won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current buffer and to create a new buffer may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> Buffer<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, int count, IScheduler scheduler);

		/// <summary>
		/// Time shifts the observable sequence by the specified relative time duration.
		///             The relative time intervals between the values are preserved.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="dueTime">Relative time by which to shift the observable sequence. If this value is equal to TimeSpan.Zero, the scheduler will dispatch observer callbacks as soon as possible.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is less efficient than <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.TimeSpan)">DelaySubscription</see> because it records all notifications and time-delays those. This allows for immediate propagation of errors.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Observer callbacks for the resulting sequence will be run on the default scheduler. This effect is similar to using ObserveOn.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Exceptions signaled by the source sequence through an OnError callback are forwarded immediately to the result sequence. Any OnNext notifications that were in the queue at the point of the OnError callback will be dropped.
		///             In order to delay error propagation, consider using the <see cref="M:System.Reactive.Linq.Observable.Materialize``1(System.IObservable{``0})">Observable.Materialize</see> and <see cref="M:System.Reactive.Linq.Observable.Dematerialize``1(System.IObservable{System.Reactive.Notification{``0}})">Observable.Dematerialize</see> operators, or use <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.TimeSpan)">DelaySubscription</see>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Delay<TSource>(this IObservable<TSource> source, TimeSpan dueTime);

		/// <summary>
		/// Time shifts the observable sequence by the specified relative time duration, using the specified scheduler to run timers.
		///             The relative time intervals between the values are preserved.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="dueTime">Relative time by which to shift the observable sequence. If this value is equal to TimeSpan.Zero, the scheduler will dispatch observer callbacks as soon as possible.</param><param name="scheduler">Scheduler to run the delay timers on.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is less efficient than <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.TimeSpan,System.Reactive.Concurrency.IScheduler)">DelaySubscription</see> because it records all notifications and time-delays those. This allows for immediate propagation of errors.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Observer callbacks for the resulting sequence will be run on the specified scheduler. This effect is similar to using ObserveOn.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Exceptions signaled by the source sequence through an OnError callback are forwarded immediately to the result sequence. Any OnNext notifications that were in the queue at the point of the OnError callback will be dropped.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Exceptions signaled by the source sequence through an OnError callback are forwarded immediately to the result sequence. Any OnNext notifications that were in the queue at the point of the OnError callback will be dropped.
		///             In order to delay error propagation, consider using the <see cref="M:System.Reactive.Linq.Observable.Materialize``1(System.IObservable{``0})">Observable.Materialize</see> and <see cref="M:System.Reactive.Linq.Observable.Dematerialize``1(System.IObservable{System.Reactive.Notification{``0}})">Observable.Dematerialize</see> operators, or use <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.TimeSpan,System.Reactive.Concurrency.IScheduler)">DelaySubscription</see>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Delay<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler);

		/// <summary>
		/// Time shifts the observable sequence to start propagating notifications at the specified absolute time.
		///             The relative time intervals between the values are preserved.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="dueTime">Absolute time used to shift the observable sequence; the relative time shift gets computed upon subscription. If this value is less than or equal to DateTimeOffset.UtcNow, the scheduler will dispatch observer callbacks as soon as possible.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is less efficient than <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.DateTimeOffset)">DelaySubscription</see> because it records all notifications and time-delays those. This allows for immediate propagation of errors.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Observer callbacks for the resulting sequence will be run on the default scheduler. This effect is similar to using ObserveOn.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Exceptions signaled by the source sequence through an OnError callback are forwarded immediately to the result sequence. Any OnNext notifications that were in the queue at the point of the OnError callback will be dropped.
		///             In order to delay error propagation, consider using the <see cref="M:System.Reactive.Linq.Observable.Materialize``1(System.IObservable{``0})">Observable.Materialize</see> and <see cref="M:System.Reactive.Linq.Observable.Dematerialize``1(System.IObservable{System.Reactive.Notification{``0}})">Observable.Dematerialize</see> operators, or use <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.DateTimeOffset)">DelaySubscription</see>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Delay<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime);

		/// <summary>
		/// Time shifts the observable sequence to start propagating notifications at the specified absolute time, using the specified scheduler to run timers.
		///             The relative time intervals between the values are preserved.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="dueTime">Absolute time used to shift the observable sequence; the relative time shift gets computed upon subscription. If this value is less than or equal to DateTimeOffset.UtcNow, the scheduler will dispatch observer callbacks as soon as possible.</param><param name="scheduler">Scheduler to run the delay timers on.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is less efficient than <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.DateTimeOffset,System.Reactive.Concurrency.IScheduler)">DelaySubscription</see> because it records all notifications and time-delays those. This allows for immediate propagation of errors.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Observer callbacks for the resulting sequence will be run on the specified scheduler. This effect is similar to using ObserveOn.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Exceptions signaled by the source sequence through an OnError callback are forwarded immediately to the result sequence. Any OnNext notifications that were in the queue at the point of the OnError callback will be dropped.
		///             In order to delay error propagation, consider using the <see cref="M:System.Reactive.Linq.Observable.Materialize``1(System.IObservable{``0})">Observable.Materialize</see> and <see cref="M:System.Reactive.Linq.Observable.Dematerialize``1(System.IObservable{System.Reactive.Notification{``0}})">Observable.Dematerialize</see> operators, or use <see cref="M:System.Reactive.Linq.Observable.DelaySubscription``1(System.IObservable{``0},System.DateTimeOffset,System.Reactive.Concurrency.IScheduler)">DelaySubscription</see>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Delay<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime, IScheduler scheduler);

		/// <summary>
		/// Time shifts the observable sequence based on a delay selector function for each element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TDelay">The type of the elements in the delay sequences used to denote the delay duration of each element in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="delayDurationSelector">Selector function to retrieve a sequence indicating the delay for each given element.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="delayDurationSelector"/> is null.</exception>
		public static IObservable<TSource> Delay<TSource, TDelay>(this IObservable<TSource> source, Func<TSource, IObservable<TDelay>> delayDurationSelector);

		/// <summary>
		/// Time shifts the observable sequence based on a subscription delay and a delay selector function for each element.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TDelay">The type of the elements in the delay sequences used to denote the delay duration of each element in the source sequence.</typeparam><param name="source">Source sequence to delay values for.</param><param name="subscriptionDelay">Sequence indicating the delay for the subscription to the source.</param><param name="delayDurationSelector">Selector function to retrieve a sequence indicating the delay for each given element.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="subscriptionDelay"/> or <paramref name="delayDurationSelector"/> is null.</exception>
		public static IObservable<TSource> Delay<TSource, TDelay>(this IObservable<TSource> source, IObservable<TDelay> subscriptionDelay, Func<TSource, IObservable<TDelay>> delayDurationSelector);

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription with the specified relative time duration.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay subscription for.</param><param name="dueTime">Relative time shift of the subscription.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is more efficient than <see cref="M:System.Reactive.Linq.Observable.Delay``1(System.IObservable{``0},System.TimeSpan)">Delay</see> but postpones all side-effects of subscription and affects error propagation timing.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The side-effects of subscribing to the source sequence will be run on the default scheduler. Observer callbacks will not be affected.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> DelaySubscription<TSource>(this IObservable<TSource> source, TimeSpan dueTime);

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription with the specified relative time duration, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay subscription for.</param><param name="dueTime">Relative time shift of the subscription.</param><param name="scheduler">Scheduler to run the subscription delay timer on.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is more efficient than <see cref="M:System.Reactive.Linq.Observable.Delay``1(System.IObservable{``0},System.TimeSpan,System.Reactive.Concurrency.IScheduler)">Delay</see> but postpones all side-effects of subscription and affects error propagation timing.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The side-effects of subscribing to the source sequence will be run on the specified scheduler. Observer callbacks will not be affected.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> DelaySubscription<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler);

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription to the specified absolute time.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay subscription for.</param><param name="dueTime">Absolute time to perform the subscription at.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is more efficient than <see cref="M:System.Reactive.Linq.Observable.Delay``1(System.IObservable{``0},System.DateTimeOffset)">Delay</see> but postpones all side-effects of subscription and affects error propagation timing.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The side-effects of subscribing to the source sequence will be run on the default scheduler. Observer callbacks will not be affected.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> DelaySubscription<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime);

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription to the specified absolute time, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to delay subscription for.</param><param name="dueTime">Absolute time to perform the subscription at.</param><param name="scheduler">Scheduler to run the subscription delay timer on.</param>
		/// <returns>
		/// Time-shifted sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator is more efficient than <see cref="M:System.Reactive.Linq.Observable.Delay``1(System.IObservable{``0},System.DateTimeOffset,System.Reactive.Concurrency.IScheduler)">Delay</see> but postpones all side-effects of subscription and affects error propagation timing.
		/// 
		/// </para>
		/// 
		/// <para>
		/// The side-effects of subscribing to the source sequence will be run on the specified scheduler. Observer callbacks will not be affected.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> DelaySubscription<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime, IScheduler scheduler);

		/// <summary>
		/// Generates an observable sequence by running a state-driven and temporal loop producing the sequence's elements.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param><param name="timeSelector">Time selector function to control the speed of values being produced each iteration.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> or <paramref name="timeSelector"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector, Func<TState, TimeSpan> timeSelector);

		/// <summary>
		/// Generates an observable sequence by running a state-driven and temporal loop producing the sequence's elements, using the specified scheduler to run timers and to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param><param name="timeSelector">Time selector function to control the speed of values being produced each iteration.</param><param name="scheduler">Scheduler on which to run the generator loop.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> or <paramref name="timeSelector"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector, Func<TState, TimeSpan> timeSelector, IScheduler scheduler);

		/// <summary>
		/// Generates an observable sequence by running a state-driven and temporal loop producing the sequence's elements.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param><param name="timeSelector">Time selector function to control the speed of values being produced each iteration.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> or <paramref name="timeSelector"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector, Func<TState, DateTimeOffset> timeSelector);

		/// <summary>
		/// Generates an observable sequence by running a state-driven and temporal loop producing the sequence's elements, using the specified scheduler to run timers and to send out observer messages.
		/// 
		/// </summary>
		/// <typeparam name="TState">The type of the state used in the generator loop.</typeparam><typeparam name="TResult">The type of the elements in the produced sequence.</typeparam><param name="initialState">Initial state.</param><param name="condition">Condition to terminate generation (upon returning false).</param><param name="iterate">Iteration step function.</param><param name="resultSelector">Selector function for results produced in the sequence.</param><param name="timeSelector">Time selector function to control the speed of values being produced each iteration.</param><param name="scheduler">Scheduler on which to run the generator loop.</param>
		/// <returns>
		/// The generated sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="condition"/> or <paramref name="iterate"/> or <paramref name="resultSelector"/> or <paramref name="timeSelector"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TResult> Generate<TState, TResult>(TState initialState, Func<TState, bool> condition, Func<TState, TState> iterate, Func<TState, TResult> resultSelector, Func<TState, DateTimeOffset> timeSelector, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that produces a value after each period.
		/// 
		/// </summary>
		/// <param name="period">Period for producing the values in the resulting sequence. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param>
		/// <returns>
		/// An observable sequence that produces a value after each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Intervals are measured between the start of subsequent notifications, not between the end of the previous and the start of the next notification.
		///             If the observer takes longer than the interval period to handle the message, the subsequent notification will be delivered immediately after the
		///             current one has been handled. In case you need to control the time between the end and the start of consecutive notifications, consider using the
		///             <see cref="M:System.Reactive.Linq.Observable.Generate``2(``0,System.Func{``0,System.Boolean},System.Func{``0,``0},System.Func{``0,``1},System.Func{``0,System.TimeSpan})"/>
		///             operator instead.
		/// 
		/// </remarks>
		public static IObservable<long> Interval(TimeSpan period);

		/// <summary>
		/// Returns an observable sequence that produces a value after each period, using the specified scheduler to run timers and to send out observer messages.
		/// 
		/// </summary>
		/// <param name="period">Period for producing the values in the resulting sequence. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence that produces a value after each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// Intervals are measured between the start of subsequent notifications, not between the end of the previous and the start of the next notification.
		///             If the observer takes longer than the interval period to handle the message, the subsequent notification will be delivered immediately after the
		///             current one has been handled. In case you need to control the time between the end and the start of consecutive notifications, consider using the
		///             <see cref="M:System.Reactive.Linq.Observable.Generate``2(``0,System.Func{``0,System.Boolean},System.Func{``0,``0},System.Func{``0,``1},System.Func{``0,System.TimeSpan},System.Reactive.Concurrency.IScheduler)"/>
		///             operator instead.
		/// 
		/// </remarks>
		public static IObservable<long> Interval(TimeSpan period, IScheduler scheduler);

		/// <summary>
		/// Samples the observable sequence at each interval.
		///             Upon each sampling tick, the latest element (if any) in the source sequence during the last sampling interval is sent to the resulting sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to sample.</param><param name="interval">Interval at which to sample. If this value is equal to TimeSpan.Zero, the scheduler will continuously sample the stream.</param>
		/// <returns>
		/// Sampled observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="interval"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="interval"/> doesn't guarantee all source sequence elements will be preserved. This is a side-effect
		///             of the asynchrony introduced by the scheduler, where the sampling action may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<TSource> Sample<TSource>(this IObservable<TSource> source, TimeSpan interval);

		/// <summary>
		/// Samples the observable sequence at each interval, using the specified scheduler to run sampling timers.
		///             Upon each sampling tick, the latest element (if any) in the source sequence during the last sampling interval is sent to the resulting sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to sample.</param><param name="interval">Interval at which to sample. If this value is equal to TimeSpan.Zero, the scheduler will continuously sample the stream.</param><param name="scheduler">Scheduler to run the sampling timer on.</param>
		/// <returns>
		/// Sampled observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="interval"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="interval"/> doesn't guarantee all source sequence elements will be preserved. This is a side-effect
		///             of the asynchrony introduced by the scheduler, where the sampling action may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<TSource> Sample<TSource>(this IObservable<TSource> source, TimeSpan interval, IScheduler scheduler);

		/// <summary>
		/// Samples the source observable sequence using a samper observable sequence producing sampling ticks.
		///             Upon each sampling tick, the latest element (if any) in the source sequence during the last sampling interval is sent to the resulting sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TSample">The type of the elements in the sampling sequence.</typeparam><param name="source">Source sequence to sample.</param><param name="sampler">Sampling tick sequence.</param>
		/// <returns>
		/// Sampled observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="sampler"/> is null.</exception>
		public static IObservable<TSource> Sample<TSource, TSample>(this IObservable<TSource> source, IObservable<TSample> sampler);

		/// <summary>
		/// Skips elements for the specified duration from the start of the observable source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="duration">Duration for skipping elements from the start of the sequence.</param>
		/// <returns>
		/// An observable sequence with the elements skipped during the specified duration from the start of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="duration"/> doesn't guarantee no elements will be dropped from the start of the source sequence.
		///             This is a side-effect of the asynchrony introduced by the scheduler, where the action that causes callbacks from the source sequence to be forwarded
		///             may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Errors produced by the source sequence are always forwarded to the result sequence, even if the error occurs before the <paramref name="duration"/>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Skip<TSource>(this IObservable<TSource> source, TimeSpan duration);

		/// <summary>
		/// Skips elements for the specified duration from the start of the observable source sequence, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="duration">Duration for skipping elements from the start of the sequence.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements skipped during the specified duration from the start of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="duration"/> doesn't guarantee no elements will be dropped from the start of the source sequence.
		///             This is a side-effect of the asynchrony introduced by the scheduler, where the action that causes callbacks from the source sequence to be forwarded
		///             may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Errors produced by the source sequence are always forwarded to the result sequence, even if the error occurs before the <paramref name="duration"/>.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Skip<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler scheduler);

		/// <summary>
		/// Skips elements for the specified duration from the end of the observable source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="duration">Duration for skipping elements from the end of the sequence.</param>
		/// <returns>
		/// An observable sequence with the elements skipped during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a queue with a length enough to store elements received during the initial <paramref name="duration"/> window.
		///             As more elements are received, elements older than the specified <paramref name="duration"/> are taken from the queue and produced on the
		///             result sequence. This causes elements to be delayed with <paramref name="duration"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SkipLast<TSource>(this IObservable<TSource> source, TimeSpan duration);

		/// <summary>
		/// Skips elements for the specified duration from the end of the observable source sequence, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="duration">Duration for skipping elements from the end of the sequence.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements skipped during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a queue with a length enough to store elements received during the initial <paramref name="duration"/> window.
		///             As more elements are received, elements older than the specified <paramref name="duration"/> are taken from the queue and produced on the
		///             result sequence. This causes elements to be delayed with <paramref name="duration"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SkipLast<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler scheduler);

		/// <summary>
		/// Skips elements from the observable source sequence until the specified start time.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="startTime">Time to start taking elements from the source sequence. If this value is less than or equal to DateTimeOffset.UtcNow, no elements will be skipped.</param>
		/// <returns>
		/// An observable sequence with the elements skipped until the specified start time.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		/// <remarks>
		/// Errors produced by the source sequence are always forwarded to the result sequence, even if the error occurs before the <paramref name="startTime"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SkipUntil<TSource>(this IObservable<TSource> source, DateTimeOffset startTime);

		/// <summary>
		/// Skips elements from the observable source sequence until the specified start time, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to skip elements for.</param><param name="startTime">Time to start taking elements from the source sequence. If this value is less than or equal to DateTimeOffset.UtcNow, no elements will be skipped.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements skipped until the specified start time.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// Errors produced by the source sequence are always forwarded to the result sequence, even if the error occurs before the <paramref name="startTime"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> SkipUntil<TSource>(this IObservable<TSource> source, DateTimeOffset startTime, IScheduler scheduler);

		/// <summary>
		/// Takes elements for the specified duration from the start of the observable source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the start of the sequence.</param>
		/// <returns>
		/// An observable sequence with the elements taken during the specified duration from the start of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="duration"/> doesn't guarantee an empty sequence will be returned. This is a side-effect
		///             of the asynchrony introduced by the scheduler, where the action that stops forwarding callbacks from the source sequence may not execute
		///             immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<TSource> Take<TSource>(this IObservable<TSource> source, TimeSpan duration);

		/// <summary>
		/// Takes elements for the specified duration from the start of the observable source sequence, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the start of the sequence.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements taken during the specified duration from the start of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="duration"/> doesn't guarantee an empty sequence will be returned. This is a side-effect
		///             of the asynchrony introduced by the scheduler, where the action that stops forwarding callbacks from the source sequence may not execute
		///             immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<TSource> Take<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler scheduler);

		/// <summary>
		/// Returns elements within the specified duration from the end of the observable source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the end of the sequence.</param>
		/// <returns>
		/// An observable sequence with the elements taken during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements for any <paramref name="duration"/> window during the lifetime of
		///             the source sequence. Upon completion of the source sequence, this buffer is drained on the result sequence. This causes the result elements
		///             to be delayed with <paramref name="duration"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> TakeLast<TSource>(this IObservable<TSource> source, TimeSpan duration);

		/// <summary>
		/// Returns elements within the specified duration from the end of the observable source sequence, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the end of the sequence.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements taken during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements for any <paramref name="duration"/> window during the lifetime of
		///             the source sequence. Upon completion of the source sequence, this buffer is drained on the result sequence. This causes the result elements
		///             to be delayed with <paramref name="duration"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> TakeLast<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler scheduler);

		/// <summary>
		/// Returns elements within the specified duration from the end of the observable source sequence, using the specified schedulers to run timers and to drain the collected elements.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the end of the sequence.</param><param name="timerScheduler">Scheduler to run the timer on.</param><param name="loopScheduler">Scheduler to drain the collected elements.</param>
		/// <returns>
		/// An observable sequence with the elements taken during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="timerScheduler"/> or <paramref name="loopScheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements for any <paramref name="duration"/> window during the lifetime of
		///             the source sequence. Upon completion of the source sequence, this buffer is drained on the result sequence. This causes the result elements
		///             to be delayed with <paramref name="duration"/>.
		/// 
		/// </remarks>
		public static IObservable<TSource> TakeLast<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler timerScheduler, IScheduler loopScheduler);

		/// <summary>
		/// Returns a list with the elements within the specified duration from the end of the observable source sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the end of the sequence.</param>
		/// <returns>
		/// An observable sequence containing a single list with the elements taken during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements for any <paramref name="duration"/> window during the lifetime of
		///             the source sequence. Upon completion of the source sequence, this buffer is produced on the result sequence.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> TakeLastBuffer<TSource>(this IObservable<TSource> source, TimeSpan duration);

		/// <summary>
		/// Returns a list with the elements within the specified duration from the end of the observable source sequence, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="duration">Duration for taking elements from the end of the sequence.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence containing a single list with the elements taken during the specified duration from the end of the source sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="duration"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// This operator accumulates a buffer with a length enough to store elements for any <paramref name="duration"/> window during the lifetime of
		///             the source sequence. Upon completion of the source sequence, this buffer is produced on the result sequence.
		/// 
		/// </remarks>
		public static IObservable<IList<TSource>> TakeLastBuffer<TSource>(this IObservable<TSource> source, TimeSpan duration, IScheduler scheduler);

		/// <summary>
		/// Takes elements for the specified duration until the specified end time.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="endTime">Time to stop taking elements from the source sequence. If this value is less than or equal to DateTimeOffset.UtcNow, the result stream will complete immediately.</param>
		/// <returns>
		/// An observable sequence with the elements taken until the specified end time.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TSource> TakeUntil<TSource>(this IObservable<TSource> source, DateTimeOffset endTime);

		/// <summary>
		/// Takes elements for the specified duration until the specified end time, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to take elements from.</param><param name="endTime">Time to stop taking elements from the source sequence. If this value is less than or equal to DateTimeOffset.UtcNow, the result stream will complete immediately.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence with the elements taken until the specified end time.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TSource> TakeUntil<TSource>(this IObservable<TSource> source, DateTimeOffset endTime, IScheduler scheduler);

		/// <summary>
		/// Ignores elements from an observable sequence which are followed by another element within a specified relative time duration.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to throttle.</param><param name="dueTime">Throttling duration for each element.</param>
		/// <returns>
		/// The throttled sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator throttles the source sequence by holding on to each element for the duration specified in <paramref name="dueTime"/>. If another
		///             element is produced within this time window, the element is dropped and a new timer is started for the current element, repeating this whole
		///             process. For streams that never have gaps larger than or equal to <paramref name="dueTime"/> between elements, the resulting stream won't
		///             produce any elements. In order to reduce the volume of a stream whilst guaranteeing the periodic production of elements, consider using the
		///             Observable.Sample set of operators.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing throttling timers to be scheduled
		///             that are due immediately. However, this doesn't guarantee all elements will be retained in the result sequence. This is a side-effect of the
		///             asynchrony introduced by the scheduler, where the action to forward the current element may not execute immediately, despite the TimeSpan.Zero
		///             due time. In such cases, the next element may arrive before the scheduler gets a chance to run the throttling action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime);

		/// <summary>
		/// Ignores elements from an observable sequence which are followed by another element within a specified relative time duration, using the specified scheduler to run throttling timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to throttle.</param><param name="dueTime">Throttling duration for each element.</param><param name="scheduler">Scheduler to run the throttle timers on.</param>
		/// <returns>
		/// The throttled sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// This operator throttles the source sequence by holding on to each element for the duration specified in <paramref name="dueTime"/>. If another
		///             element is produced within this time window, the element is dropped and a new timer is started for the current element, repeating this whole
		///             process. For streams that never have gaps larger than or equal to <paramref name="dueTime"/> between elements, the resulting stream won't
		///             produce any elements. In order to reduce the volume of a stream whilst guaranteeing the periodic production of elements, consider using the
		///             Observable.Sample set of operators.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing throttling timers to be scheduled
		///             that are due immediately. However, this doesn't guarantee all elements will be retained in the result sequence. This is a side-effect of the
		///             asynchrony introduced by the scheduler, where the action to forward the current element may not execute immediately, despite the TimeSpan.Zero
		///             due time. In such cases, the next element may arrive before the scheduler gets a chance to run the throttling action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Throttle<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler);

		/// <summary>
		/// Ignores elements from an observable sequence which are followed by another value within a computed throttle duration.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TThrottle">The type of the elements in the throttle sequences selected for each element in the source sequence.</typeparam><param name="source">Source sequence to throttle.</param><param name="throttleDurationSelector">Selector function to retrieve a sequence indicating the throttle duration for each given element.</param>
		/// <returns>
		/// The throttled sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="throttleDurationSelector"/> is null.</exception>
		/// <remarks>
		/// This operator throttles the source sequence by holding on to each element for the duration denoted by <paramref name="throttleDurationSelector"/>.
		///             If another element is produced within this time window, the element is dropped and a new timer is started for the current element, repeating this
		///             whole process. For streams where the duration computed by applying the <paramref name="throttleDurationSelector"/> to each element overlaps with
		///             the occurrence of the successor element, the resulting stream won't produce any elements. In order to reduce the volume of a stream whilst
		///             guaranteeing the periodic production of elements, consider using the Observable.Sample set of operators.
		/// 
		/// </remarks>
		public static IObservable<TSource> Throttle<TSource, TThrottle>(this IObservable<TSource> source, Func<TSource, IObservable<TThrottle>> throttleDurationSelector);

		/// <summary>
		/// Records the time interval between consecutive elements in an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to record time intervals for.</param>
		/// <returns>
		/// An observable sequence with time interval information on elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Records the time interval between consecutive elements in an observable sequence, using the specified scheduler to compute time intervals.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to record time intervals for.</param><param name="scheduler">Scheduler used to compute time intervals.</param>
		/// <returns>
		/// An observable sequence with time interval information on elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<TimeInterval<TSource>> TimeInterval<TSource>(this IObservable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Applies a timeout policy for each element in the observable sequence.
		///             If the next element isn't received within the specified timeout duration starting from its predecessor, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Maximum duration between values before a timeout occurs.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception><exception cref="T:System.TimeoutException">(Asynchronous) If no element is produced within <paramref name="dueTime"/> from the previous element.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing timeout timers to be scheduled that are due
		///             immediately. However, this doesn't guarantee a timeout will occur, even for the first element. This is a side-effect of the asynchrony introduced by the
		///             scheduler, where the action to propagate a timeout may not execute immediately, despite the TimeSpan.Zero due time. In such cases, the next element may
		///             arrive before the scheduler gets a chance to run the timeout action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, TimeSpan dueTime);

		/// <summary>
		/// Applies a timeout policy for each element in the observable sequence, using the specified scheduler to run timeout timers.
		///             If the next element isn't received within the specified timeout duration starting from its predecessor, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Maximum duration between values before a timeout occurs.</param><param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception><exception cref="T:System.TimeoutException">(Asynchronous) If no element is produced within <paramref name="dueTime"/> from the previous element.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing timeout timers to be scheduled that are due
		///             immediately. However, this doesn't guarantee a timeout will occur, even for the first element. This is a side-effect of the asynchrony introduced by the
		///             scheduler, where the action to propagate a timeout may not execute immediately, despite the TimeSpan.Zero due time. In such cases, the next element may
		///             arrive before the scheduler gets a chance to run the timeout action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IScheduler scheduler);

		/// <summary>
		/// Applies a timeout policy for each element in the observable sequence.
		///             If the next element isn't received within the specified timeout duration starting from its predecessor, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Maximum duration between values before a timeout occurs.</param><param name="other">Sequence to return in case of a timeout.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing timeout timers to be scheduled that are due
		///             immediately. However, this doesn't guarantee a timeout will occur, even for the first element. This is a side-effect of the asynchrony introduced by the
		///             scheduler, where the action to propagate a timeout may not execute immediately, despite the TimeSpan.Zero due time. In such cases, the next element may
		///             arrive before the scheduler gets a chance to run the timeout action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IObservable<TSource> other);

		/// <summary>
		/// Applies a timeout policy for each element in the observable sequence, using the specified scheduler to run timeout timers.
		///             If the next element isn't received within the specified timeout duration starting from its predecessor, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Maximum duration between values before a timeout occurs.</param><param name="other">Sequence to return in case of a timeout.</param><param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="dueTime"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="dueTime"/> is not recommended but supported, causing timeout timers to be scheduled that are due
		///             immediately. However, this doesn't guarantee a timeout will occur, even for the first element. This is a side-effect of the asynchrony introduced by the
		///             scheduler, where the action to propagate a timeout may not execute immediately, despite the TimeSpan.Zero due time. In such cases, the next element may
		///             arrive before the scheduler gets a chance to run the timeout action.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, TimeSpan dueTime, IObservable<TSource> other, IScheduler scheduler);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an absolute time.
		///             If the sequence doesn't terminate before the specified absolute due time, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Time when a timeout occurs. If this value is less than or equal to DateTimeOffset.UtcNow, the timeout occurs immediately.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.TimeoutException">(Asynchronous) If the sequence hasn't terminated before <paramref name="dueTime"/>.</exception>
		/// <remarks>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an absolute time, using the specified scheduler to run timeout timers.
		///             If the sequence doesn't terminate before the specified absolute due time, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Time when a timeout occurs. If this value is less than or equal to DateTimeOffset.UtcNow, the timeout occurs immediately.</param><param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.TimeoutException">(Asynchronous) If the sequence hasn't terminated before <paramref name="dueTime"/>.</exception>
		/// <remarks>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime, IScheduler scheduler);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an absolute time.
		///             If the sequence doesn't terminate before the specified absolute due time, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Time when a timeout occurs. If this value is less than or equal to DateTimeOffset.UtcNow, the timeout occurs immediately.</param><param name="other">Sequence to return in case of a timeout.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> is null.</exception>
		/// <remarks>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime, IObservable<TSource> other);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an absolute time, using the specified scheduler to run timeout timers.
		///             If the sequence doesn't terminate before the specified absolute due time, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="dueTime">Time when a timeout occurs. If this value is less than or equal to DateTimeOffset.UtcNow, the timeout occurs immediately.</param><param name="other">Sequence to return in case of a timeout.</param><param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="other"/> or <paramref name="scheduler"/> is null.</exception>
		/// <remarks>
		/// In case you only want to timeout on the first element, consider using the <see cref="M:System.Reactive.Linq.Observable.Amb``1(System.IObservable{``0},System.IObservable{``0})"/>
		///             operator applied to the source sequence and a delayed <see cref="M:System.Reactive.Linq.Observable.Throw``1(System.Exception)"/> sequence. Alternatively, the general-purpose overload
		///             of Timeout, <see cref="M:System.Reactive.Linq.Observable.Timeout``2(System.IObservable{``0},System.IObservable{``1},System.Func{``0,System.IObservable{``1}})"/> can be used.
		/// 
		/// </remarks>
		public static IObservable<TSource> Timeout<TSource>(this IObservable<TSource> source, DateTimeOffset dueTime, IObservable<TSource> other, IScheduler scheduler);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on a timeout duration computed for each element.
		///             If the next element isn't received within the computed duration starting from its predecessor, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TTimeout">The type of the elements in the timeout sequences used to indicate the timeout duration for each element in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="timeoutDurationSelector"/> is null.</exception>
		public static IObservable<TSource> Timeout<TSource, TTimeout>(this IObservable<TSource> source, Func<TSource, IObservable<TTimeout>> timeoutDurationSelector);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on a timeout duration computed for each element.
		///             If the next element isn't received within the computed duration starting from its predecessor, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><typeparam name="TTimeout">The type of the elements in the timeout sequences used to indicate the timeout duration for each element in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param><param name="other">Sequence to return in case of a timeout.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="timeoutDurationSelector"/> or <paramref name="other"/> is null.</exception>
		public static IObservable<TSource> Timeout<TSource, TTimeout>(this IObservable<TSource> source, Func<TSource, IObservable<TTimeout>> timeoutDurationSelector, IObservable<TSource> other);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an initial timeout duration for the first element, and a timeout duration computed for each subsequent element.
		///             If the next element isn't received within the computed duration starting from its predecessor, a TimeoutException is propagated to the observer.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><typeparam name="TTimeout">The type of the elements in the timeout sequences used to indicate the timeout duration for each element in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="firstTimeout">Observable sequence that represents the timeout for the first element.</param><param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param>
		/// <returns>
		/// The source sequence with a TimeoutException in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="firstTimeout"/> or <paramref name="timeoutDurationSelector"/> is null.</exception>
		public static IObservable<TSource> Timeout<TSource, TTimeout>(this IObservable<TSource> source, IObservable<TTimeout> firstTimeout, Func<TSource, IObservable<TTimeout>> timeoutDurationSelector);

		/// <summary>
		/// Applies a timeout policy to the observable sequence based on an initial timeout duration for the first element, and a timeout duration computed for each subsequent element.
		///             If the next element isn't received within the computed duration starting from its predecessor, the other observable sequence is used to produce future messages from that point on.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence and the other sequence used upon a timeout.</typeparam><typeparam name="TTimeout">The type of the elements in the timeout sequences used to indicate the timeout duration for each element in the source sequence.</typeparam><param name="source">Source sequence to perform a timeout for.</param><param name="firstTimeout">Observable sequence that represents the timeout for the first element.</param><param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param><param name="other">Sequence to return in case of a timeout.</param>
		/// <returns>
		/// The source sequence switching to the other sequence in case of a timeout.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="firstTimeout"/> or <paramref name="timeoutDurationSelector"/> or <paramref name="other"/> is null.</exception>
		public static IObservable<TSource> Timeout<TSource, TTimeout>(this IObservable<TSource> source, IObservable<TTimeout> firstTimeout, Func<TSource, IObservable<TTimeout>> timeoutDurationSelector, IObservable<TSource> other);

		/// <summary>
		/// Returns an observable sequence that produces a single value after the specified relative due time has elapsed.
		/// 
		/// </summary>
		/// <param name="dueTime">Relative time at which to produce the value. If this value is less than or equal to TimeSpan.Zero, the timer will fire as soon as possible.</param>
		/// <returns>
		/// An observable sequence that produces a value after the due time has elapsed.
		/// </returns>
		public static IObservable<long> Timer(TimeSpan dueTime);

		/// <summary>
		/// Returns an observable sequence that produces a single value at the specified absolute due time.
		/// 
		/// </summary>
		/// <param name="dueTime">Absolute time at which to produce the value. If this value is less than or equal to DateTimeOffset.UtcNow, the timer will fire as soon as possible.</param>
		/// <returns>
		/// An observable sequence that produces a value at due time.
		/// </returns>
		public static IObservable<long> Timer(DateTimeOffset dueTime);

		/// <summary>
		/// Returns an observable sequence that periodically produces a value after the specified initial relative due time has elapsed.
		/// 
		/// </summary>
		/// <param name="dueTime">Relative time at which to produce the first value. If this value is less than or equal to TimeSpan.Zero, the timer will fire as soon as possible.</param><param name="period">Period to produce subsequent values. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param>
		/// <returns>
		/// An observable sequence that produces a value after due time has elapsed and then after each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception>
		public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period);

		/// <summary>
		/// Returns an observable sequence that periodically produces a value starting at the specified initial absolute due time.
		/// 
		/// </summary>
		/// <param name="dueTime">Absolute time at which to produce the first value. If this value is less than or equal to DateTimeOffset.UtcNow, the timer will fire as soon as possible.</param><param name="period">Period to produce subsequent values. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param>
		/// <returns>
		/// An observable sequence that produces a value at due time and then after each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception>
		public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period);

		/// <summary>
		/// Returns an observable sequence that produces a single value after the specified relative due time has elapsed, using the specified scheduler to run the timer.
		/// 
		/// </summary>
		/// <param name="dueTime">Relative time at which to produce the value. If this value is less than or equal to TimeSpan.Zero, the timer will fire as soon as possible.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence that produces a value after the due time has elapsed.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<long> Timer(TimeSpan dueTime, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that produces a single value at the specified absolute due time, using the specified scheduler to run the timer.
		/// 
		/// </summary>
		/// <param name="dueTime">Absolute time at which to produce the value. If this value is less than or equal to DateTimeOffset.UtcNow, the timer will fire as soon as possible.</param><param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>
		/// An observable sequence that produces a value at due time.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<long> Timer(DateTimeOffset dueTime, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that periodically produces a value after the specified initial relative due time has elapsed, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <param name="dueTime">Relative time at which to produce the first value. If this value is less than or equal to TimeSpan.Zero, the timer will fire as soon as possible.</param><param name="period">Period to produce subsequent values. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param><param name="scheduler">Scheduler to run timers on.</param>
		/// <returns>
		/// An observable sequence that produces a value after due time has elapsed and then each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period, IScheduler scheduler);

		/// <summary>
		/// Returns an observable sequence that periodically produces a value starting at the specified initial absolute due time, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <param name="dueTime">Absolute time at which to produce the first value. If this value is less than or equal to DateTimeOffset.UtcNow, the timer will fire as soon as possible.</param><param name="period">Period to produce subsequent values. If this value is equal to TimeSpan.Zero, the timer will recur as fast as possible.</param><param name="scheduler">Scheduler to run timers on.</param>
		/// <returns>
		/// An observable sequence that produces a value at due time and then after each period.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="period"/> is less than TimeSpan.Zero.</exception><exception cref="T:System.ArgumentNullException"><paramref name="scheduler"/> is null.</exception>
		public static IObservable<long> Timer(DateTimeOffset dueTime, TimeSpan period, IScheduler scheduler);

		/// <summary>
		/// Timestamps each element in an observable sequence using the local system clock.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to timestamp elements for.</param>
		/// <returns>
		/// An observable sequence with timestamp information on elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IObservable<Timestamped<TSource>> Timestamp<TSource>(this IObservable<TSource> source);

		/// <summary>
		/// Timestamp each element in an observable sequence using the clock of the specified scheduler.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence.</typeparam><param name="source">Source sequence to timestamp elements for.</param><param name="scheduler">Scheduler used to compute timestamps.</param>
		/// <returns>
		/// An observable sequence with timestamp information on elements.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception>
		public static IObservable<Timestamped<TSource>> Timestamp<TSource>(this IObservable<TSource> source, IScheduler scheduler);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping windows which are produced based on timing information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Length of each window.</param>
		/// <returns>
		/// The sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             Because all source sequence elements end up in one of the windows, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current window and to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan);

		/// <summary>
		/// Projects each element of an observable sequence into consecutive non-overlapping windows which are produced based on timing information, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Length of each window.</param><param name="scheduler">Scheduler to run windowing timers on.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             Because all source sequence elements end up in one of the windows, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current window and to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, IScheduler scheduler);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on timing information.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Length of each window.</param><param name="timeShift">Interval between creation of consecutive windows.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> or <paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows with minimum duration
		///             length. However, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced by the scheduler, where the action to close the
		///             current window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeShift"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             However, this doesn't mean all windows will start at the beginning of the source sequence. This is a side-effect of the asynchrony introduced by the scheduler,
		///             where the action to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, TimeSpan timeShift);

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on timing information, using the specified scheduler to run timers.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Length of each window.</param><param name="timeShift">Interval between creation of consecutive windows.</param><param name="scheduler">Scheduler to run windowing timers on.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> or <paramref name="timeSpan"/> is less than TimeSpan.Zero.</exception>
		/// <remarks>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows with minimum duration
		///             length. However, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced by the scheduler, where the action to close the
		///             current window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// <para>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeShift"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             However, this doesn't mean all windows will start at the beginning of the source sequence. This is a side-effect of the asynchrony introduced by the scheduler,
		///             where the action to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </para>
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, TimeSpan timeShift, IScheduler scheduler);

		/// <summary>
		/// Projects each element of an observable sequence into a window that is completed when either it's full or a given amount of time has elapsed.
		///             A useful real-world analogy of this overload is the behavior of a ferry leaving the dock when all seats are taken, or at the scheduled time of departure, whichever event occurs first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Maximum time length of a window.</param><param name="count">Maximum element count of a window.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero. -or- <paramref name="count"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             Because all source sequence elements end up in one of the windows, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current window and to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, int count);

		/// <summary>
		/// Projects each element of an observable sequence into a window that is completed when either it's full or a given amount of time has elapsed, using the specified scheduler to run timers.
		///             A useful real-world analogy of this overload is the behavior of a ferry leaving the dock when all seats are taken, or at the scheduled time of departure, whichever event occurs first.
		/// 
		/// </summary>
		/// <typeparam name="TSource">The type of the elements in the source sequence, and in the windows in the result sequence.</typeparam><param name="source">Source sequence to produce windows over.</param><param name="timeSpan">Maximum time length of a window.</param><param name="count">Maximum element count of a window.</param><param name="scheduler">Scheduler to run windowing timers on.</param>
		/// <returns>
		/// An observable sequence of windows.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="scheduler"/> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeSpan"/> is less than TimeSpan.Zero. -or- <paramref name="count"/> is less than or equal to zero.</exception>
		/// <remarks>
		/// Specifying a TimeSpan.Zero value for <paramref name="timeSpan"/> is not recommended but supported, causing the scheduler to create windows as fast as it can.
		///             Because all source sequence elements end up in one of the windows, some windows won't have a zero time span. This is a side-effect of the asynchrony introduced
		///             by the scheduler, where the action to close the current window and to create a new window may not execute immediately, despite the TimeSpan.Zero due time.
		/// 
		/// </remarks>
		public static IObservable<IObservable<TSource>> Window<TSource>(this IObservable<TSource> source, TimeSpan timeSpan, int count, IScheduler scheduler);
	}
}
