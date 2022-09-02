

public class DBCommand
{
    DBConnection _connection;
    string _command; 

    public DBCommand(DBConnection connection, string command){
        _connection = connection;
        _command = command;
    }

    public void Execute(){
        _connection.Open();
        System.Console.WriteLine("Execute command: " + _command);
        _connection.Closed();
    }
}