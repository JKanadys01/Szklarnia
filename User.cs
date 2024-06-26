﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreenHouse
{
    /*Generalnie User będzie taką klasą zawierającą informacje o naszym użytkowniku potrzebne do komunikacji z bazą i to jego będziemy
    Przekazywać między okienkami, Wydaje mi się też, że później tutaj będziemy przechowywać jakieś wiesz dane o alarmach itp zanim zostaną przekazane
    do bazy albo z niej pobrane. A userManager będzie zbędny bo i tak tylko jeden na raz może być zalogowany Ewentualnie wykorzystamy to później
    jak będziemy robić menu admina
    */
    public class User
    {
        int id;
       public string login{ get; set; }
        string password{ get; set; }
       public int token {  get; set; }

        public string descripiton { get; set; }
        public User() { }
        public User(string log, string pass) 
        { login = log; password = pass; token = 0; }
       public User(int id, string login, string password, int token, string descripiton)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.token = token;
            this.descripiton = descripiton;
        }

        public override string ToString()
        {
            return $"ID: {id}\nLogin: {login}\nToken: {token}\nDescription:{descripiton}";
        }
    }
}
