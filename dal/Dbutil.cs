using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.Json;
namespace dal;
public class Dbutil
{ 
  public static string getString1(){
   string filename="appsettings.json";
   string json=File.ReadAllText(filename); 
   JsonDocument jdoc=JsonDocument.Parse(json);
   JsonElement jele =jdoc.RootElement;
   string defaultstring= jele.GetProperty("ConnectionStrings").GetProperty("Default").GetString();
   return defaultstring;
  } 
  private static string connection=getString1();

 
    public static MySqlConnection conn =null;
       
   public  static MySqlConnection connect(){
       if(conn==null){
        conn=new MySqlConnection(connection);
    
       }
     return conn;
       
    }  

    
   

}
