using System;
using System.Text;

namespace Laboratorio.Web.Api.Utils
{
    public static class Utils
    {
        public static bool IsBase64String(this string value)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    return false;
                }

                Convert.FromBase64String(value);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }

        public static T GetFromBase64<T>(this string value)
        {
            T ret = default;

            try
            {
                if(IsBase64String(value))
                {
                    ret = (T)Convert.ChangeType( 
                        Encoding.UTF8.GetString(Convert.FromBase64String(value)),
                        typeof(T)
                    );
                }
            }
            catch(FormatException)
            {
                ret = default;
            }
            return ret;
        }

        public static string ConvertToBase64(this string value)
        {
            try
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
            }
            catch(FormatException)
            {
                return null;
            }
        }
    }
}
