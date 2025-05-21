using SQLite;

namespace projetoAndroid.Model
{
	public class Periodo
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nome { get; set; }
	}
}