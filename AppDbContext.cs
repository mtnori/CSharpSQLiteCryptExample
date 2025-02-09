using CSharpSQLiteCryptExample.domain;
using Microsoft.EntityFrameworkCore;

namespace CSharpSQLiteCryptExample
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // SQLite3 Multiple Ciphers用の C#/.NET バインディングを使用する
            // https://www.nuget.org/packages/SQLitePCLRaw.bundle_e_sqlite3mc

            // Password で暗号化キーを指定する (このサンプルでは直接指定しているが、実際には環境変数などから取得する)
            options.UseSqlite($"Data Source=sample.db;Password=Key");
        }
    }
}
