using System.Runtime.Serialization;


namespace ConverterLibrary
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string LastName { set; get; }
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string Otch { set; get; }

        
    }
}
