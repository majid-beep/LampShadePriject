namespace _0_FrameWork.Infrastructure
{
    public static class Roles
    {
        public const string Administrator = "1";
        public const string ContentProvider = "3";
        public const string SystemUser = "2";

        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 1:
                    return "مدیر سیستم";
                case 2:
                    return "محتواگذار";
                default:
                    return "";



            }
        }
    }
}
