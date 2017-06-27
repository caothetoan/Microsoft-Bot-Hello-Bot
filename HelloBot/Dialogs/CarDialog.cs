using System;
using System.Threading.Tasks;
using HelloBot.Models;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;

namespace HelloBot.Dialogs
{

    [Serializable]
    public class CarDialog : IDialog<CarSelection>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            //BuildDialog();
            // calculate something for us to return
            //int length = (activity.Text ?? string.Empty).Length;

           
            //await context.SayAsync(text: "Thank you for your order!", speak: "Thank you for your order!");

            ////Activity reply = activity.CreateReply("This is the text that will be displayed.");
            ////reply.Speak = "This is the text that will be spoken.";
            ////reply.InputHint = InputHints.AcceptingInput;
            ////await connector.Conversations.ReplyToActivityAsync(reply);

            //// return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            context.Wait(MessageReceivedAsync);
        }
        public static IDialog<CarSelection> BuildDialog()
        {
            return Chain.From(() => FormDialog.FromForm(BuildForm));
        }
        public static IForm<CarSelection> BuildForm()
        {
            return new FormBuilder<CarSelection>()
                .Message("Hello! I'm Jarvis, an AI assistant built by Mr. Cao The Toan. I'm here to help you.")
                .Build();
        }
    }
}