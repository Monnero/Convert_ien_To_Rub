using System;
using System.ServiceModel;

namespace ConverterLibrary
{
    [ServiceContract]
    public interface IConverter
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        double RtoI(double r);


        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        double ItoR(double d);


        [OperationContract]
        Person GetPerson();


        [OperationContract]
        void Save();

    }
}
