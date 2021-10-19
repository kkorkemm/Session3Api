using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session3Api.Base
{
    public class AppData
    {
        private static KazanNeftSession3DBEntities context;
        public static KazanNeftSession3DBEntities GetContext()
        {
            if (context == null)
                context = new KazanNeftSession3DBEntities();
            return context;
        }
    }
}