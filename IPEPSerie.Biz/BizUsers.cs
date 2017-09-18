   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPEPSerie.Biz
{
    public class BizUsers : IBizUsers
    {
        Datas.ServiceReference.IPEPSerieServiceClient _serviceClient;

        public BizUsers()
        {
            _serviceClient = new Datas.ServiceReference.IPEPSerieServiceClient();
        }

        public string CallHelloIPEPS()
        {
            return _serviceClient.HelloIPEPS();
        }
    }
}
