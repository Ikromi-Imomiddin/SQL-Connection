var sql = new SQLConection( "abc", TimeSpan.FromSeconds(20));
sql.Open();
sql.Closed();
var oracle = new OracleConnection("bca",TimeSpan.FromSeconds(20));
oracle.Open();
oracle.Closed();