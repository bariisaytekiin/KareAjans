using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Kareajans.MVC.Utils
{
    public static class SessionHelper
    {

        //string değerleri Json formatına dönüştürmek için package manager'dan NewtonSoft.Json kütüphanesi içerisinde bulunan JsonConvert isimli classa ihtiyacımız bulunmaktadır.

        //Set
        public static void SetJsonProduct(this ISession _session, string _key, object _value)
        {
            _session.SetString(_key, JsonConvert.SerializeObject(_value));
        }
        

        //Get
        public static T GetProductFromJson<T>(this ISession session, string key)
        {
            var result = session.GetString(key);

            if(result == null)
            {
                return default(T);
            }
            else
            {
                var deserialize=JsonConvert.DeserializeObject<T>(result);
                return deserialize;
            }

        }

        //Remove

        public static void RemoveSession(this ISession session, string key)
        {
            session.Remove(key);
        }

    }
}
