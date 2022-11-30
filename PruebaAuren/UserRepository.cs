using Newtonsoft.Json;
using PruebaAuren.Entities;
using System;
using System.Collections.Generic;


namespace PruebaAuren
{
    public class UserRepository
    {
        public  List<User> GetUsers()
        {
            
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("https://jsonplaceholder.typicode.com/users");
                    List<User> usuarios = JsonConvert.DeserializeObject<List<User>>(json);

                    return usuarios;
                }         

        }
    }
}
