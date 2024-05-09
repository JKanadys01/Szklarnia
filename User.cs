using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GreenHouse
{
    /*Generalnie User będzie taką klasą zawierającą informacje o naszym użytkowniku potrzebne do komunikacji z bazą i to jego będziemy
    Przekazywać między okienkami, Wydaje mi się też, że później tutaj będziemy przechowywać jakieś wiesz dane o alarmach itp zanim zostaną przekazane
    do bazy albo z niej pobrane. A userManager będzie zbędny bo i tak tylko jeden na raz może być zalogowany Ewentualnie wykorzystamy to później
    jak będziemy robić menu admina
    */
    public class User
    {
        string mysqlconn;//polecenie do łączenia z bazą
        string name;
        public User() { }
        public User(string login, string password) 
        { mysqlconn = "server=127.0.0.1;user=" + login + ";database=szklarnia_v3;password=" + password;name = login; }
        public string get_mysqlconn() { return mysqlconn; }
        public string get_name() { return name;}
    }
}
