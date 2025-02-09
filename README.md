# CSharp SQLite Crypt Example
C# から暗号化された SQLite3 DB ファイルを扱うサンプルプログラム

# 概要
SQLite3 Multiple Ciphers用 C#/.NET バインディングとして、SQLitePCLRaw.bundle_e_sqlite3mc を使用する。 
https://www.nuget.org/packages/SQLitePCLRaw.bundle_e_sqlite3mc

## EF Core
DB アクセスには、EF Core (https://learn.microsoft.com/ja-jp/ef/core/) を使用する。  
複数バンドルの使用を避けるため、メインパッケージではなく、Microsoft.EntityFrameworkCore.Sqlite.Core (https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite.Core) を使用する。

DB アクセス時は、以下のスニペットのように Password で暗号化キーを指定する。
```
options.UseSqlite("Data Source=example.db;Password=Password12!");
```

# 補足
このプログラムを動かす場合、SQLite3 の DB ファイルを出力フォルダへコピーする設定を行っておくこと。
これを設定しないと、接続に失敗したというエラーではなく、テーブルが見つからないというエラーになり、わかりにくいので記載。

## 参考 URL
https://stackoverflow.com/questions/46769384/sqlite-error-1-no-such-table-in-asp-net-core-console-app
