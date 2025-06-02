using projetoAndroid.Helpers;

namespace projetoAndroid
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelpers _db;
        static SQLiteDatabaseDisciplinasHelper _dbdisc;
        public static SQLiteDatabaseHelpers Db
        {
            get
            {
                if(_db == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_sysceapp.db3");

                    _db = new SQLiteDatabaseHelpers(path);
                }
                return _db;
            }
        }
        public static SQLiteDatabaseDisciplinasHelper DbDisc
        {
            get
            {
                if(_dbdisc == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_sysceapp.db3");

                    _dbdisc = new SQLiteDatabaseDisciplinasHelper(path);
                }
                return _dbdisc;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}