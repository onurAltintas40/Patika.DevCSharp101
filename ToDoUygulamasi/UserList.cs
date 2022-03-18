
using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class UserList
    {
        public List<User> user = new List<User>();

        public UserList()
        {
            user.Add(new User { Id = 1, Isim = "Onur", Soyisim = "Altıntaş" });
            user.Add(new User { Id = 2, Isim = "Carol", Soyisim = "Place" });
            user.Add(new User { Id = 3, Isim = "Jane", Soyisim = "Lorem" });
            user.Add(new User { Id = 4, Isim = "John", Soyisim = "Doe" });
            user.Add(new User { Id = 5, Isim = "Jess", Soyisim = "Ipsum" });
        }
    }
}
