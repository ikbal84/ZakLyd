using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakLyd.Infrastructure.DAL
{
    public class ZakLydDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ZakLydContext>
    {
        protected override void Seed(ZakLydContext context)
        {
            //init date here...
        }
    }
}
