using Newtonsoft.Json.Linq;

namespace Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           dynamic myVariable = "";
           
            string jsonString = @"{""menu"": {
                                      ""id"": ""file"",
                                      ""value"": ""File"",
                                      ""popup"": {
                                        ""menuitem"": [
                                          {""value"": ""New"", ""onclick"": ""CreateNewDoc()""},
                                          {""value"": ""Open"", ""onclick"": ""OpenDoc()""},
                                          {""value"": ""Close"", ""onclick"": ""CloseDoc()""}
                                        ]
                                      }
                                    }}";
            
            myVariable = JObject.Parse(jsonString);
            Console.WriteLine(myVariable.menu.id);
            Console.WriteLine(" ");
            Console.WriteLine(myVariable.menu.popup);
        }
    }
}