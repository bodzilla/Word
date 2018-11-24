using Word.ViewModel.Base;

namespace Word.ViewModel.Chat
{
    /// <summary>
    /// A view model for each chat list item in the overview chat list.
    /// </summary>
    public class ChatListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The display name of the message sender.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The latest message from this chat.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials of the message sender's display name.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture.
        /// </summary>
        public string ProfilePictureRgb { get; set; }
    }
}
