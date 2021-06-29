using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will
    /// not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot
    /// must be an administrator in the chat for this to work and must have the appropriate admin rights.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BanChatMemberRequest : RequestBase<bool>
    {
        /// <summary>
        /// Unique identifier for the target group or username of the target supergroup or channel
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public ChatId ChatId { get; }

        /// <summary>
        /// Unique identifier of the target user
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public long UserId { get; }

        /// <summary>
        /// Date when the user will be unbanned, unix time. If user is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UntilDate { get; set; }

        /// <summary>
        /// Pass True to delete all messages from the chat for the user that is being removed. If False, the user will be able to see messages in the group that were sent before the user was removed. Always True for supergroups and channels.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? RevokeMessages { get; set; }

        /// <summary>
        /// Initializes a new request with chatId and userId
        /// </summary>
        /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel</param>
        /// <param name="userId">Unique identifier of the target user</param>
        public BanChatMemberRequest(ChatId chatId, long userId)
            : base("banChatMember")
        {
            ChatId = chatId;
            UserId = userId;
        }
    }
}
