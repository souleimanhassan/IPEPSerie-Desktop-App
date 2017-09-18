using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPEPSerie.Datas;

namespace IPEPSerie.Biz
{
    public class BizLogin : IBizLogin
    {
        Datas.ServiceReference.IPEPSerieServiceClient _serviceClient;

        public BizLogin()
        {
            _serviceClient = new Datas.ServiceReference.IPEPSerieServiceClient();
        }

        public string CallHelloIPEPS()
        {
            return _serviceClient.HelloIPEPS();
        }
    }
}
