// Type: System.IObserver`1
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

namespace System
{
	/// <summary>
	/// Provides a mechanism for receiving push-based notifications.
	/// </summary>
	/// <typeparam name="T">The object that provides notification information.This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
	public interface IObserver<in T>
	{
		/// <summary>
		/// Provides the observer with new data.
		/// </summary>
		/// <param name="value">The current notification information.</param>
		void OnNext(T value);

		/// <summary>
		/// Notifies the observer that the provider has experienced an error condition.
		/// </summary>
		/// <param name="error">An object that provides additional information about the error.</param>
		void OnError(Exception error);

		/// <summary>
		/// Notifies the observer that the provider has finished sending push-based notifications.
		/// </summary>
		void OnCompleted();
	}
}
