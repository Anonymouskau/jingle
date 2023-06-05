using System.Data;
using MySql.Data.MySqlClient;
namespace dal;
public class Dbutil
{ 

   private static string connection=@"server=aws.connect.psdb.cloud;uid=f8cgfxmygeykkj1q2umm;pwd=pscale_pw_gEBwQ58iYSb81CzK08dKl6o94V2yewcvvNsS0IE6ipV;database=jingle";
 
    public static MySqlConnection conn =null;
       
   public  static MySqlConnection connect(){
       if(conn==null){
        conn=new MySqlConnection(connection);
    
       }
     return conn;
       
    }  

    
   

}
