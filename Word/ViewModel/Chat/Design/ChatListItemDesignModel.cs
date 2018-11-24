namespace Word.ViewModel.Chat.Design
{
    /// <inheritdoc />
    /// <summary>
    /// The design-time data for a <see cref="T:Word.ViewModel.Chat.ChatListItemViewModel" />.
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A singleton instance of the design model.
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "BC";
            Name = "Bodrul Choudhury";
            Message = "This new chat application is awesome!";
            ProfilePictureRgb = "3099c5";
        }

        #endregion
    }
}
