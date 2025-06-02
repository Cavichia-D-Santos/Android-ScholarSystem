using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace projetoAndroid.Model
{
    public class Disciplina
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Obs { get; set; }
    }
}
