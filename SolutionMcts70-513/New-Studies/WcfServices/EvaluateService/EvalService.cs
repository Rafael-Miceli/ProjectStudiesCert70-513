using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvaluateService
{
    [DataContract]
    public class Eval
    {
        public Eval()
        {
            
        }

        public Eval(string submitter,  string comments)
        {
            Submitter = submitter;
            Comments = comments;
            Timesent = DateTime.Now;
        }

        [DataMember]
        public string Submitter;
        [DataMember]
        public DateTime Timesent;
        [DataMember]
        public string Comments;
    }

    [ServiceContract]
    public interface IEvalService
    {
        [OperationContract]
        void SubmitEval(Eval eval);
        [OperationContract]
        List<Eval> GetEvals();
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService: IEvalService
    {
        readonly List<Eval> _evals = new List<Eval>();
        public void SubmitEval(Eval eval)
        {
            if (eval.Submitter.Equals("Throw"))
                throw new FaultException("Error when submit eval.");
            _evals.Add(eval);
        }

        public List<Eval> GetEvals()
        {
            Thread.Sleep(30000);
            return _evals;
        }
    }
}
