using System;
using System.Collections.Generic;
using System.Text;

namespace MedConsult.Common.Constants
{
    public static class Roles
    {
        public static Guid Superadmin { get; } = Guid.Parse("");
        public static Guid Admin { get; } = Guid.Parse("");
        public static Guid User { get; } = Guid.Parse("");

        static readonly IDictionary<string, Guid> RoleNames;

        static Roles()
        {
            RoleNames = new Dictionary<string, Guid> { { "Superadmin", Superadmin }, { "Admin", Admin }, { "User", User } };
        }

        public static Guid? GetRoleByName(string roleName)
        {
            if (RoleNames.ContainsKey(roleName))
            {
                return RoleNames[roleName];
            }

            return null;
        }

        public static string GetRoleNameById(Guid roleId)
        {
            return RoleNames.FirstOrDefault(x => x.Value == roleId).Key;
        }

    }

    public static class StringRoles
    {
        public const string Superadmin = "SuperAdmin";
        public const string User = "User";
    }
}
