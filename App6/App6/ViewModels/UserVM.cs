using App6.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App6.ViewModels
{
    public class UserVM
    {
        public ObservableCollection<UserGroupM> UserList { get; set; }

        public UserVM() 
        {
            this.UserList = new ObservableCollection<UserGroupM>();
            var group1 = new List<UserM>
            {
                new UserM("Eduardo", "Black", 24),
                new UserM("Enrique", "Ferruzo", 32),
                new UserM("Carlos", "Carranza", 18),
            };

            UserList.Add(new UserGroupM("Desarrollo de Software", group1));

            var group2 = new List<UserM>
            {
                new UserM("Jaime", "Torres", 23),
                new UserM("Pablo", "Perez", 17),
            };

            UserList.Add(new UserGroupM("Desarrollo de Videojuegos", group2));

            var group3 = new List<UserM>
            {
                new UserM("Fabrizio", "Porras", 25),
                new UserM("Fernando", "Guerra", 24),
                new UserM("Elena", "Torres", 24),
            };

            UserList.Add(new UserGroupM("Diseño Industrial", group3));
        }
    }
}
