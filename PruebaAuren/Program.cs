using Newtonsoft.Json;
using PruebaAuren.Entities;
using System;
using System.Collections.Generic;


namespace PruebaAuren
{
    internal class Program
    {
         static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            var usuarios = userRepository.GetUsers();
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario.email);
            }
        }

    }
}
