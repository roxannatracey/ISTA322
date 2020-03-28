using System.Collections.Generic;
namespace PartyInvites.Models
{
    public static class Repository
    {
        // the below line creates a private field that you can only use with the class, list type but since 
        // it is a generic list it is going to contain GuesetResponse responses. then the new (goes to the heap
        // allocates memory and creates a new list 
        private static List<GuestResponse> responses = new List<GuestResponse>(); 
        // the below line creates a public property which returns responses  ( which is a list)  
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}