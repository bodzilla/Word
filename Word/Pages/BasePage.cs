using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Word.Animation;
using Word.ViewModel.Base;

namespace Word.Pages
{
    /// <inheritdoc />
    /// <summary>
    /// A base page for all pages to gain functionality.
    /// </summary>
    public class BasePage<T> : Page where T : BaseViewModel, new()
    {
        #region Private Members

        /// <summary>
        /// View Model associated with this page.
        /// </summary>
        private T _viewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The animation when page is first loaded.
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        /// <summary>
        /// The animation when page is unloaded.
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete.
        /// </summary>
        public float SlideSeconds { get; set; } = 0.4f;

        /// <summary>
        /// View Model associated with this page.
        /// </summary>
        public T ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != null && _viewModel == value) return;
                _viewModel = value;
                DataContext = _viewModel;
            }
        }

        #endregion

        #region Constructor

        /// <inheritdoc />
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BasePage()
        {
            // If we are animating in, hide to begin with.
            if (PageLoadAnimation != PageAnimation.None) Visibility = Visibility.Collapsed;

            // Listen out for page loading.
            Loaded += BasePage_Loaded;

            // Create the default view model.
            ViewModel = new T();
        }

        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// Once the page is loaded, perform any required animation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            // Animate the page in.
            await AnimateIn();
        }

        /// <summary>
        /// Animates this page in.
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // Start the animation.
                    await this.SlideAndFadeInFromRight(SlideSeconds);
                    break;
            }
        }

        /// <summary>
        /// Animates this page out.
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // Start the animation.
                    await this.SlideAndFadeOutToLeft(SlideSeconds);
                    break;
            }
        }

        #endregion
    }
}
