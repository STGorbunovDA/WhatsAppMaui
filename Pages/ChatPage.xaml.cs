using System.Collections.ObjectModel;
using WhatsAppMaui.Models;

namespace WhatsAppMaui.Pages;

public partial class ChatPage : ContentPage
{
    public ChatPage()
    {
        InitializeComponent();
        Chats = new ObservableCollection<ChatModel>(LoadChats());

        BindingContext = this;
    }

    public ObservableCollection<ChatModel> Chats { get; set; }

    private static IEnumerable<ChatModel> LoadChats()
    {
        return new List<ChatModel>
        {
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
            new ChatModel("avatar1.svg","AkpTech", DateTime.UtcNow.AddDays(-2),"Just a test message", 0),
            new ChatModel("avatar2.svg","Espenses", DateTime.Now,"Grocery 500", 0),
            new ChatModel("avatar3.svg","Baby", DateTime.UtcNow.AddMinutes(-2),"Money, when will you", 1),
            new ChatModel("avatar2.svg","Office", DateTime.UtcNow.AddDays(-1),"Ready to launch", 10),
        };
    }
}