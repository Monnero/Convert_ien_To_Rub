using System;
using System.ServiceModel;

namespace ConverterLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    
    public class Converter : IConverter
    {

        static double ItoR = 0.65;
        static double RtoI = 1.54;


       double IConverter.RtoI(double r)
        {
            if (r >= 0)
            {
                double d = r * RtoI;
                return d;
            }
            else
            {
                ArgumentException exception = new ArgumentException("Введено некорректное значение!");
                throw new FaultException<ArgumentException>(exception, exception.Message);

            }
        }


        double IConverter.ItoR(double d)
        {
            if (d >= 0)
            {
                double r = d * ItoR;
                return r;
            }
            else
            {
                ArgumentException exception = new ArgumentException("Введено некорректное значение!");
                throw new FaultException<ArgumentException>(exception, exception.Message);

            }
        }

        Person IConverter.GetPerson()
        {
            Person person = new Person();
            return person;
        }

        void IConverter.Save()
        {
           
        }
    }
}
