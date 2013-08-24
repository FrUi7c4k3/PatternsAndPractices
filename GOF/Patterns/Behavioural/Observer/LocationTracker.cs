using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Behavioural.Observer
{
	public class LocationTracker : IObservable<Location>
	{
		private IList<IObserver<Location>> _observers;

		public LocationTracker()
		{
			_observers = new List<IObserver<Location>>();
		}

		public IDisposable Subscribe(IObserver<Location> observer)
		{
			if (!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}

			return new Unsubscriber(_observers, observer);
		}

		public void TrackLocation(Nullable<Location> loc)
		{
			foreach (var observer in _observers)
			{
				if (!loc.HasValue)
					observer.OnError(new LocationUnknownException());
				else
					observer.OnNext(loc.Value);
			}
		}

		public void EndTransmission()
		{
			foreach (var observer in _observers.ToArray())
			{
				if (_observers.Contains(observer))
					observer.OnCompleted();
			}

			_observers.Clear();
		}
	
		private class Unsubscriber : IDisposable
		{
			private IList<IObserver<Location>> _observers;
			private IObserver<Location> _observer;
			
			public Unsubscriber(IList<IObserver<Location>> observers, IObserver<Location> observer)
			{
				_observers = observers;
				_observer = observer;
			}

			public void Dispose()
			{
				if (_observer != null && _observers.Contains(_observer))
				{
					_observers.Remove(_observer);
				}
			}
		}
	}
}
