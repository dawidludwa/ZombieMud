using System;
using System.Runtime.Serialization;

namespace Library.Misc
{
	[Serializable]
	internal class ItemAlreadyExistException : Exception
	{
		private Item item;
		private Item item1;

		public ItemAlreadyExistException()
		{
		}

		public ItemAlreadyExistException(string message) : base(message)
		{
		}

		public ItemAlreadyExistException(Item item)
		{
			this.item = item;
		}

		public ItemAlreadyExistException(Item item, Item item1) : this(item)
		{
			this.item1 = item1;
		}

		public ItemAlreadyExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ItemAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}