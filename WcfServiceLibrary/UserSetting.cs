using System.Runtime.Serialization;

namespace WcfServiceLibrary
{
	[DataContract]
	public class UserSetting
	{
		[DataMember]
		public string HeroName { get; set; }
		[DataMember]
		public string LocationName { get; set; }
	}
}