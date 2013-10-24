using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppClient.EvaluateServiceReference;

namespace ConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cf = new ChannelFactory<IEvalServiceChannel>("End4");
            //var service = cf.CreateChannel();

            var service = new EvalServiceClient("End4");

            try
            {
                var newEval = new Eval
                {
                    Comments = "Testing",
                    Submitter = "Rafael",
                    Timesent = DateTime.Now
                };

                service.SubmitEval(newEval);
                service.SubmitEval(newEval);

                var evals = service.GetEvals();

                foreach (var eval in evals)
                {
                    Console.WriteLine(eval.Submitter + " " + eval.Comments);
                }

                service.Close();
            }
            catch (FaultException exception)
            {
                Console.WriteLine("Ops... Something went wrong");
                Console.WriteLine(exception);
                service.Abort();
            }
            catch (CommunicationException exception)
            {
                Console.WriteLine("Ops... Something went wrong");
                Console.WriteLine(exception);
                service.Abort();
            }
            catch (TimeoutException exception)
            {
                Console.WriteLine("Ops... Something went wrong");
                Console.WriteLine(exception);
                service.Abort();
            }

            Console.ReadLine();
        }
    }
}
