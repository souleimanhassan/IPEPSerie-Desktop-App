using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPEPSerie.Biz
{
    public class BizReferential : IBizReferential
    {
        Datas.ServiceReference.IPEPSerieServiceClient _serviceClient;

        public BizReferential()
        {
            _serviceClient = new Datas.ServiceReference.IPEPSerieServiceClient();
        }

        public string CallHelloIPEPS()
        {
            return _serviceClient.HelloIPEPS();
        }
    }
}
