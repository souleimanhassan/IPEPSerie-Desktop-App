using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPEPSerie.Biz
{
    public class BizRatings : IBizRatings
    {
        Datas.ServiceReference.IPEPSerieServiceClient _serviceClient;

        public BizRatings()
        {
            _serviceClient = new Datas.ServiceReference.IPEPSerieServiceClient();
        }

        public string CallHelloIPEPS()
        {
            return _serviceClient.HelloIPEPS();
        }
    }
}
