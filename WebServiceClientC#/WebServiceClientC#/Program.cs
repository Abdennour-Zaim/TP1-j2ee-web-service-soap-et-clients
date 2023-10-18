 using System;
using ServiceReference1;
class Program
{
    static void Main(string[] args)
    {
        BanqueServiceClient proxy = new BanqueServiceClient();
        ConvertRequest request = new ConvertRequest(7600);
        ConvertResponse response = proxy.Convert(request);
        Console.WriteLine("le résultat de la conversion : "+response.@return);

        getCompteRequest compteRequest=new getCompteRequest(5);
        getCompteResponse compteResponse=proxy.getCompte(compteRequest);
        
        Console.WriteLine("le code du compte est "+compteResponse.@return.code);
        Console.WriteLine("le solde de ce compte est "+compteResponse.@return.solde);









        //  Console.WriteLine("the response is : "+request.ToString());
    }
}