using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Spyder.Controls.Toggle
{
    public class RoundToggleButton : ToggleButton
    {
        #region Constructor

        /// <summary>
        /// Initializes a static instance of the <see cref="RoundToggleButton"/> control.
        /// </summary>
        static RoundToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundToggleButton),
                new FrameworkPropertyMetadata(
                    typeof(RoundToggleButton)));
        }

        #endregion

        #region Checked Color

        /// <summary>
        /// Gets or sets the checked color dependency backing property.
        /// </summary>
        public Color? CheckedColor
        {
            get => (Color?)GetValue(CheckedColorProperty);
            set => SetValue(CheckedColorProperty, value);
        }

        /// <summary>
        /// Register the Checked Color dependency property. This enables animation, styling, binding, etc...
        /// </summary>
        public static readonly DependencyProperty CheckedColorProperty = DependencyProperty.Register(
            nameof(CheckedColor),
            typeof(Color?),
            typeof(RoundToggleButton),
            new PropertyMetadata(default(Color?)));

        #endregion
    }
}