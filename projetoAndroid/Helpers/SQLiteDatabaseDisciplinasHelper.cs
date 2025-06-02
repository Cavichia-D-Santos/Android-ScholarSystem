using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projetoAndroid.Model;
using SQLite;

namespace projetoAndroid.Helpers
{
    public class SQLiteDatabaseDisciplinasHelper
    {
        readonly SQLiteAsyncConnection connection;
        public SQLiteDatabaseDisciplinasHelper(string path)
        {
            connection = new SQLiteAsyncConnection(path);
            connection.CreateTableAsync<Disciplina>().Wait();
        }
        public Task<int> Insert(Disciplina p)
        {
            return connection.InsertAsync(p); //Forma 1 com a biblioteca
        }
        public Task<List<Disciplina>> Update(Disciplina p)
        {
            string sql = "UPDATE Disciplina SET Id=?, Nome=?, Sigla=?, Obs=? WHERE Id=?"; //Forma 2 escrevendo a mao
            return connection.QueryAsync<Disciplina>(sql, p.Id, p.Nome, p.Sigla, p.Obs, p.Id);
        }
        public Task<List<Disciplina>> Delete(int Id)
        {
            string sql = "DELETE FROM Disciplina WHERE Id=?";
            return connection.QueryAsync<Disciplina>(sql, Id);
        }
        public Task<List<Disciplina>> GetAll()
        {
            return connection.Table<Disciplina>().ToListAsync();
        }
        public Task<List<Disciplina>> Search(string p)
        {
            string sql = "SELECT * FROM Disciplina WHERE Nome LIKE '%" + p + "%'";
            return connection.QueryAsync<Disciplina>(sql, p);
        }
    }
}