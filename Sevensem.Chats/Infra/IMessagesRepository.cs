using System.Threading.Tasks;
using Sevensem.Chats.Infra.Ef;

namespace Sevensem.Chats.Infra
{
    internal interface IMessagesRepository
    {
        Task CreateAsync(ChatMessageDao[] messageDaos);
        Task<ChatMessageDao[]> FindAllAsync(string loginFrom, string loginTo);
        Task UpdateAsync(ChatMessageDao[] messageDaos);
    }
}