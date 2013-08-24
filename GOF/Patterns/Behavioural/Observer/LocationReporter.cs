using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Behavioural.Observer
{
	public class LocationReporter : IObserver<Location>
	{
		private IDisposable _unsubscriber;
		private string _instName;

		public LocationReporter(string name)
		{
			_instName = name;
		}

		public string Name
		{ 
			get { return _instName; } 
		}

		public virtual void Subscribe(IObservable<Location> provider)
		{
			if (provider != null)
				_unsubscriber = provider.Subscribe(this);
		}

		public void OnCompleted()
		{
			Console.WriteLine("The Location Tracker has completed transmitting data to {0}.", this.Name);
			Unsubscribe();
		}

		public void OnError(Exception error)
		{
			Console.WriteLine("{0}: The location cannot be determined.", this.Name);
		}

		public void OnNext(Location value)
		{
			Console.WriteLine("{2}: The current location is {0}, {1}", value.Latitude, value.Longitude, this.Name);
		}

		public virtual void Unsubscribe()
		{
			_unsubscriber.Dispose();
		}
	}
}
