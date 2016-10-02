using System;
using System.Runtime.Serialization;

namespace Library.Misc
{
	[Serializable]
	internal class ItemNotExistException : Exception
	{
		private Item item;
		private Item item1;

		public ItemNotExistException()
		{
		}

		public ItemNotExistException(string message) : base(message)
		{
		}

		public ItemNotExistException(Item item)
		{
			this.item = item;
		}

		public ItemNotExistException(Item item, Item item1) : this(item)
		{
			this.item1 = item1;
		}

		public ItemNotExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ItemNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}