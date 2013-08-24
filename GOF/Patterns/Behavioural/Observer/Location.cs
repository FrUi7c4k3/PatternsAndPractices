using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Behavioural.Observer
{
	public struct Location
	{
		double _lat, _lon;

		public Location(double latitude, double longitude)
		{
			_lat = latitude;
			_lon = longitude;
		}

		public double Latitude
		{
			get { return _lat; }
			set { _lat = value; }
		}

		public double Longitude
		{
			get { return _lon; }
			set { _lon = value; }
		}
	}
}
