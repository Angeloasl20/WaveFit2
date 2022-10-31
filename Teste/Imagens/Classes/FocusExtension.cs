using System.Windows;

namespace WaveFit.Classes
{
    /// <summary>
    /// Classe usada para gerenciar o foco nos controles
    /// </summary>
    public static class FocusExtension
    {
        /// <summary>
        /// Verifica se o objeto possui o foco
        /// </summary>
        /// <param name="obj">Objeto a ser verificado</param>
        /// <returns></returns>
        public static bool GetIsFocused(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsFocusedProperty);
        }

        /// <summary>
        /// Seta/reseta o foco em um objeto
        /// </summary>
        /// <param name="obj">Objeto a ser modificado</param>
        /// <param name="value">True para setar, false para resetar</param>
        public static void SetIsFocused(DependencyObject obj, bool value)
        {
            obj.SetValue(IsFocusedProperty, value);
        }

        /// <summary>
        /// Cria uma DependencyProperty para lidar com o foco no elemento
        /// </summary>
        public static readonly DependencyProperty IsFocusedProperty =
            DependencyProperty.RegisterAttached(
             "IsFocused", typeof(bool), typeof(FocusExtension),
             new UIPropertyMetadata(false, OnIsFocusedPropertyChanged));

        /// <summary>
        /// Evento que lida com a mudança de foco
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnIsFocusedPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            var uie = (UIElement)d;
            if ((bool)e.NewValue)
            {
                uie.Focus(); // Don't care about false values.
            }
        }
    }
}
