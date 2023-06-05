using System.Data;
using MySql.Data.MySqlClient;
namespace dal;
public class Dbutil
{ 

   private static string connection=@"server=aws.connect.psdb.cloud;uid=9789pwgqp7m7yu815j7c;password=pscale_pw_NrKJvG6zamhjylT57XxFBd2mTYl27ABFOIWj47NoPDd;database=jingle";
 
    public static MySqlConnection conn =null;
       
   public  static MySqlConnection connect(){
       if(conn==null){
        conn=new MySqlConnection(connection);
    
       }
     return conn;
       
    }  

    
   

}
