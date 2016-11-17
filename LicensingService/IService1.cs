 using System.Runtime.Serialization;
using System.ServiceModel;
 
namespace LicensingService {
 [ServiceContract]
  public interface IService1 {

 [OperationContract]
    string GetNewSerial( );

    [OperationContract]
    bool GenerateSerials( int number);

    [OperationContract]
    bool isValidSerial(string serial);

    [OperationContract]
    bool AddSubscription(SubscribeViewModel model);
  }

  [DataContract]
  public class SubscribeViewModel {
    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public int Users { get; set; }

    [DataMember]
    public int Features { get; set; }

    [DataMember]
    public int Databases { get; set; }

    [DataMember]
    public string Serial { get; set; }
  }

 
}
