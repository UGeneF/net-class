using System.Threading.Tasks;
using Sevensem.Chats.Abstract.Model;

namespace Sevensem.Chats.Abstract
{
    public interface IMessagesService
    {
        Task MarkReadAsync(string loginFrom, string loginTo);
        Task SaveMessages(ChatMessage[] msgs);
        Task<ChatMessage[]> GetMessagesAsync(string loginFrom, string loginTo);
    }
}