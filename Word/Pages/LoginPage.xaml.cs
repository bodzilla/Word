using Word.ViewModel;
using Word.ViewModel.Base;

namespace Word.Pages
{
    /// <inheritdoc cref="BaseViewModel" />
    /// <summary>
    /// Interaction logic for ChatPage.xaml
    /// </summary>
    public partial class ChatPage : BasePage<LoginViewModel>
    {
        public ChatPage()
        {
            InitializeComponent();
        }
    }
}
