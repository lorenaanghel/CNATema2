using Generated;
using Grpc.Core;
using System.Threading.Tasks;
using Model;
using System;
using System.Globalization;

namespace Server
{
    internal class NameOperationService : Generated.SignOperationService.NameOperationServiceBase
    {
        private Repo repo;
        public NameOperationService(Repo rp)
        {
            this.repo = rp;
        }
        public override Task<OperationResponse> SayHello(SignRequest request, ServerCallContext context)
        {
            var date = request.Sign;
            CultureInfo provider = CultureInfo.InvariantCulture;
            

            System.Console.Write("Date: ");
            System.Console.WriteLine(date);

            DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            System.Collections.Generic.List<Zodie> lista = repo.GetAll();
            foreach(Zodie zodie in lista)
            {
                zodie.ChangeYear(dt);
                //Console.WriteLine(zodie.Date1.ToString(),zodie.Date2.ToString());
            }

            string sign = "";

            foreach (Zodie zodie in lista)
            {
                if (dt.CompareTo(zodie.Date2) <= 0 && dt.CompareTo(zodie.Date1) >= 0)
                {
                    sign = zodie.Sign;
                    break;
                }
            }

            if (sign == "")
                sign = "Capricorn";

            return Task.FromResult(new OperationResponse() { Message = sign 
            });
        }
    }
}
