using System.Collections.Generic;
using Word.ViewModel.Base;

namespace Word.ViewModel.Chat
{
    /// <summary>
    /// A view model for the chat list in the overview chat list.
    /// </summary>
    public class ChatListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat list items for the list.
        /// </summary>
        public IList<ChatListItemViewModel> Items { get; set; }
    }
}
