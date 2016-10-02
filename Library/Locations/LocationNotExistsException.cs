using System;
using System.Runtime.Serialization;

namespace Library.Locations
{
	[Serializable]
	internal class LocationNotExistsException : Exception
	{
		private ILocation guest;
		private ILocation host;
		private static string mgs = "Location {0} not exists in {1}";
		private string guestName;

		public LocationNotExistsException()
		{
		}

		public LocationNotExistsException(string message) : base(message)
		{
		}

		public LocationNotExistsException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public LocationNotExistsException(ILocation host, ILocation guest) : base(string.Format(mgs, guest.Name, host.Name))
		{
			this.host = host;
			this.guest = guest;
		}

		protected LocationNotExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public LocationNotExistsException(ILocation host, string guest) : base(string.Format(mgs, guest, host.Name))
		{
			this.host = host;
			guestName = guest;
		}
	}
}