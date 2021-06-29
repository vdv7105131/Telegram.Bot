using Newtonsoft.Json;
using Telegram.Bot.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// The type of a <see cref="Message"/>
    /// </summary>
    [JsonConverter(typeof(MessageTypeConverter))]
    public enum MessageType
    {
        /// <summary>
        /// The <see cref="Message"/> is unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The <see cref="Message"/> contains text
        /// </summary>
        Text,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.PhotoSize"/>
        /// </summary>
        Photo,

        /// <summary>
        /// The <see cref="Message"/> contains an <see cref="Types.Audio"/>
        /// </summary>
        Audio,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Video"/>
        /// </summary>
        Video,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Voice"/>
        /// </summary>
        Voice,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Document"/>
        /// </summary>
        Document,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Sticker"/>
        /// </summary>
        Sticker,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Location"/>
        /// </summary>
        Location,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Contact"/>
        /// </summary>
        Contact,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Venue"/>
        /// </summary>
        Venue,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Game"/>
        /// </summary>
        Game,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.VideoNote"/>
        /// </summary>
        VideoNote,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Payments.Invoice"/>
        /// </summary>
        Invoice,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Types.Payments.SuccessfulPayment"/>
        /// </summary>
        SuccessfulPayment,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.ConnectedWebsite"/>
        /// </summary>
        WebsiteConnected,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatMembers"/>
        /// </summary>
        ChatMembersAdded,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.LeftChatMember"/>
        /// </summary>
        ChatMemberLeft,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatTitle"/>
        /// </summary>
        ChatTitleChanged,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.NewChatPhoto"/>
        /// </summary>
        ChatPhotoChanged,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.PinnedMessage"/>
        /// </summary>
        MessagePinned,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.DeleteChatPhoto"/>
        /// </summary>
        ChatPhotoDeleted,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.GroupChatCreated"/>
        /// </summary>
        GroupCreated,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.SupergroupChatCreated"/>
        /// </summary>
        SupergroupCreated,

        /// <summary>
        /// The <see cref="Message"/> contains a <see cref="Message.ChannelChatCreated"/>
        /// </summary>
        ChannelCreated,

        /// <summary>
        /// The <see cref="Message"/> contains non-default <see cref="Message.MigrateFromChatId"/>
        /// </summary>
        MigratedToSupergroup,

        /// <summary>
        /// The <see cref="Message"/> contains non-default <see cref="Message.MigrateToChatId"/>
        /// </summary>
        MigratedFromGroup,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.Poll"/>
        /// </summary>
        Poll,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.Dice"/>
        /// </summary>
        Dice,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.MessageAutoDeleteTimerChanged"/>
        /// </summary>
        MessageAutoDeleteTimerChanged,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.ProximityAlertTriggered"/>
        /// </summary>
        ProximityAlertTriggered,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.VoiceChatScheduled"/>
        /// </summary>
        VoiceChatScheduled,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.VoiceChatStarted"/>
        /// </summary>
        VoiceChatStarted,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.VoiceChatEnded"/>
        /// </summary>
        VoiceChatEnded,

        /// <summary>
        /// The <see cref="Message"/> contains <see cref="Message.VoiceChatParticipantsInvited"/>
        /// </summary>
        VoiceChatParticipantsInvited,
    }
}
