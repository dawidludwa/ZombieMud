using System;
using System.Runtime.Serialization;

namespace Library.Locations
{
	[Serializable]
	internal class LocationAlreadyExistsException : Exception
	{
		private ILocation guest;
		private ILocation host;
		private static string mgs = "Location {0} already exists in {1}";

		public LocationAlreadyExistsException()
		{
		}

		public LocationAlreadyExistsException(string message) : base(message)
		{
		}

		public LocationAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public LocationAlreadyExistsException(ILocation host, ILocation guest) : base(string.Format(mgs, guest.Name, host.Name))
		{
			this.host = host;
			this.guest = guest;
		}

		protected LocationAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}