using System;

namespace BlazorApplication1.Client.Helpers
{
    public class CustomGreeting
    {
        public static string customGreeting(string value){
            
            return value.ToUpper() + " Hoje é " + DateTime.Now;
        }
    }
}