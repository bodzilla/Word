using System.Collections.Generic;

namespace Word.ViewModel.Chat.Design
{
    /// <inheritdoc />
    /// <summary>
    /// The design-time data for a <see cref="T:Word.ViewModel.Chat.ChatListViewModel" />.
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A singleton instance of the design model.
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "BC",
                    Name = "Bodrul Choudhury",
                    Message = "This new chat application is awesome!",
                    ProfilePictureRgb = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "HR",
                    Name = "Harry Robinson",
                    Message = "Hey dude, can we go shops today?",
                    ProfilePictureRgb = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "JK",
                    Name = "Jerry King",
                    Message = "Let's go camping next Summer.",
                    ProfilePictureRgb = "00d405"
                }
            };
        }

        #endregion
    }
}
