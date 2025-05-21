using projetoAndroid.Model;
using SQLite;

namespace projetoAndroid.Helpers
{
	public class SQLiteDatabaseHelpers
	{
		readonly SQLiteAsyncConnection connection;
		public SQLiteDatabaseHelpers(string path) //Metodo construtor da classe
		{
			connection = new SQLiteAsyncConnection(path);
			connection.CreateTableAsync<Periodo>().Wait();
		}
		public Task<int> Insert(Periodo p)
		{
			return connection.InsertAsync(p); //Forma 1 com a biblioteca
		}
		public Task<List<Periodo>> Update(Periodo p)
		{
			string sql = "UPDATE Periodo SET Id=?, Nome=? WHERE Id=?"; //Forma 2 escrevendo a mao
			return connection.QueryAsync<Periodo>(sql, p.Id, p.Nome, p.Id);
		}
		public Task <List<Periodo>> Delete(int Id)
		{
			string sql = "DELETE FROM Periodo WHERE Id=?";
			return connection.QueryAsync<Periodo>(sql, Id);
		}
        public Task<List<Periodo>> GetAll()
		{
			return connection.Table<Periodo>().ToListAsync();
		}
        public Task<List<Periodo>> Search(string p)
		{
			string sql = "SELECT * FROM Periodo WHERE Nome LIKE '%" + p + "%'";
			return connection.QueryAsync<Periodo>(sql, p);
		}
    }
}