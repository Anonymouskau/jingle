using System.Data;
using MySql.Data.MySqlClient;
namespace dal;
public class Dbutil
{ 

   private static string connection=@"Server=aws.connect.psdb.cloud;Database=jingle;user=jchrphuqsa27rylnv5fy;password=pscale_pw_id0EmrVJLSjVu0377BZEnFUaQdxvVfNDAiIjtqGcd4A;SslMode=VerifyFull";
 
    public static MySqlConnection conn =null;
       
   public  static MySqlConnection connect(){
       if(conn==null){
        conn=new MySqlConnection(connection);
    
       }
     return conn;
       
    }  

    
   

}
