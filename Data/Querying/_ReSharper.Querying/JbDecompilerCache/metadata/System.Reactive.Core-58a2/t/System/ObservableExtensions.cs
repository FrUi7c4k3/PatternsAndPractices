// Type: System.ObservableExtensions
// Assembly: System.Reactive.Core, Version=2.0.20823.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: D:\Users\G90082C\Documents\GitHub\PatternsAndPractices\Data\Querying\packages\Rx-Core.2.0.21114\lib\Net40\System.Reactive.Core.dll

using System.ComponentModel;
using System.Threading;

namespace System
{
	/// <summary>
	/// Provides a set of static methods for subscribing delegates to observables.
	/// 
	/// </summary>
	public static class ObservableExtensions
	{
		/// <summary>
		/// Subscribes to the observable sequence without specifying any handlers.
		///             This method can be used to evaluate the observable sequence for its side-effects only.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static IDisposable Subscribe<T>(this IObservable<T> source);

		/// <summary>
		/// Subscribes an element handler to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext);

		/// <summary>
		/// Subscribes an element handler and an exception handler to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> is null.</exception>
		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError);

		/// <summary>
		/// Subscribes an element handler and a completion handler to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onCompleted"/> is null.</exception>
		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action onCompleted);

		/// <summary>
		/// Subscribes an element handler, an exception handler, and a completion handler to an observable sequence.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> or <paramref name="onCompleted"/> is null.</exception>
		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted);

		/// <summary>
		/// Subscribes an observer to an observable sequence, using a CancellationToken to support unsubscription.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="observer">Observer to subscribe to the sequence.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="observer"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, IObserver<T> observer, CancellationToken token);

		/// <summary>
		/// Subscribes to the observable sequence without specifying any handlers, using a CancellationToken to support unsubscription.
		///             This method can be used to evaluate the observable sequence for its side-effects only.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, CancellationToken token);

		/// <summary>
		/// Subscribes an element handler to an observable sequence, using a CancellationToken to support unsubscription.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, Action<T> onNext, CancellationToken token);

		/// <summary>
		/// Subscribes an element handler and an exception handler to an observable sequence, using a CancellationToken to support unsubscription.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError, CancellationToken token);

		/// <summary>
		/// Subscribes an element handler and a completion handler to an observable sequence, using a CancellationToken to support unsubscription.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onCompleted"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action onCompleted, CancellationToken token);

		/// <summary>
		/// Subscribes an element handler, an exception handler, and a completion handler to an observable sequence, using a CancellationToken to support unsubscription.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="onNext">Action to invoke for each element in the observable sequence.</param><param name="onError">Action to invoke upon exceptional termination of the observable sequence.</param><param name="onCompleted">Action to invoke upon graceful termination of the observable sequence.</param><param name="token">CancellationToken that can be signaled to unsubscribe from the source sequence.</param><exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="onNext"/> or <paramref name="onError"/> or <paramref name="onCompleted"/> is null.</exception>
		public static void Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted, CancellationToken token);

		/// <summary>
		/// Subscribes to the specified source, re-routing synchronous exceptions during invocation of the Subscribe method to the observer's OnError channel.
		///             This method is typically used when writing query operators.
		/// 
		/// </summary>
		/// <typeparam name="T">The type of the elements in the source sequence.</typeparam><param name="source">Observable sequence to subscribe to.</param><param name="observer">Observer that will be passed to the observable sequence, and that will be used for exception propagation.</param>
		/// <returns>
		/// IDisposable object used to unsubscribe from the observable sequence.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="observer"/> is null.</exception>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static IDisposable SubscribeSafe<T>(this IObservable<T> source, IObserver<T> observer);
	}
}
