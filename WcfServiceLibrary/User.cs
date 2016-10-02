using System.Runtime.Serialization;

namespace WcfServiceLibrary
{
	[DataContract]
	public class User
	{
		[DataMember]
		public string Name{ get; set; }
	}
}