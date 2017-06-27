using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HelloBot.Dialogs;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using HelloBot.Models;
using Microsoft.Bot.Builder.FormFlow;

namespace HelloBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, BuildDialog);
                //() => new Dialogs.RootDialog()
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
                
            }
            else if (message.Type == ActivityTypes.Ping)
            {

            }

            return null;
        }

        private static IDialog<BoyFriendSelection> BuildDialog()
        {
            return Chain.From(() => FormDialog.FromForm(BuildForm));
        }

        private static IForm<BoyFriendSelection> BuildForm()
        {
            return new FormBuilder<BoyFriendSelection>()
                .Message("Hello! I'm Jarvis, an AI assistant built by Mr. Cao The Toan. I'm here to help you.")
                .Build();
        }
    }
}