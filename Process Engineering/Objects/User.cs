using Process_Engineering.Service;
using System.Collections.Generic;

namespace Process_Engineering
{

    internal class User
    {
        public static List<User> users = new List<User>();

        public long id { get; set; }
        public string idIntern { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string password { get; set; }

        public void copyFrom(User user)
        {
            id = user.id;
            idIntern = user.idIntern;
            name = user.name;
            role = user.role;
            password = user.password;
        }

        public static bool isScrewingEditingAllowed()
        {
            User user = DataBaseService.user;
            return user != null && (user.role.Equals(ConstStorage.ROLE_ADMIN) || user.role.Equals(ConstStorage.ROLE_SCREWING_SPECIALIST));
        }

        public static bool isToolCheckingAllowed()
        {
            User user = DataBaseService.user;
            return user != null && (user.role.Equals(ConstStorage.ROLE_ADMIN) || user.role.Equals(ConstStorage.ROLE_TOOL_CHECKER)
                || user.role.Equals(ConstStorage.ROLE_SCREWING_SPECIALIST));
        }

        public static bool isCardEditingAllowed()
        {
            User user = DataBaseService.user;
            return user != null && (user.role.Equals(ConstStorage.ROLE_ADMIN) || user.role.Equals(ConstStorage.ROLE_CARD_CREATOR) ||
                user.role.Equals(ConstStorage.ROLE_EDITOR));
        }

        public static bool isParameterEditingAllowed()
        {
            User user = DataBaseService.user;
            return user != null && (user.role.Equals(ConstStorage.ROLE_ADMIN) || user.role.Equals(ConstStorage.ROLE_EDITOR));
        }

        public static bool isAdmin()
        {
            User user = DataBaseService.user;
            return user != null && user.role.Equals(ConstStorage.ROLE_ADMIN);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is User user)
                return idIntern == user.idIntern;
            return false;
        }

        public override int GetHashCode() => id.GetHashCode();

        public override string ToString()
        {
            return $"{idIntern} - {name}";
        }
    }
}
