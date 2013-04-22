// Type: System.IObservable`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

namespace System
{
	/// <summary>
	/// Defines a provider for push-based notification.
	/// </summary>
	/// <typeparam name="T">The object that provides notification information.This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
	public interface IObservable<out T>
	{
		/// <summary>
		/// Notifies the provider that an observer is to receive notifications.
		/// </summary>
		/// 
		/// <returns>
		/// The observer's interface that enables resources to be disposed.
		/// </returns>
		/// <param name="observer">The object that is to receive notifications.</param>
		IDisposable Subscribe(IObserver<T> observer);
	}
}
