using Library.Misc;

namespace Library.Units
{
	public interface IUnit
	{
		string Name { get; }
		bool IsAlive { get; }

		void Attack(IUnit unit);
		void Defense(float attack);
		void AddInfection(string v);

		void AcceptItem(Item item);
	}
}