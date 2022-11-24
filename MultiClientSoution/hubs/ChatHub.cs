using Microsoft.AspNetCore.SignalR;
namespace SignalRChat.hubs
{
    public class ChatHub : Hub
    {
       //Initialize the sum of client number which we use for every request.
        public static int sumOfNumbers = 0;

        //SignalR function is sending the number to the all connected clients
        public async Task SendNumber(string user, string number)
        {
            //Check the number is not null or empty
            if (!String.IsNullOrEmpty(number))
            {
                //Sum of all old numbers
                sumOfNumbers = sumOfNumbers + int.Parse(number);
            }
            //Send the response to the client
            await Clients.All.SendAsync("ReceiveNumber", user, sumOfNumbers);
        }
    }
  


}

