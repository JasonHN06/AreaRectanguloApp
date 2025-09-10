using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaRectanguloApp.ViewModels
{
    public partial class AreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double baseRectangulo;

        [ObservableProperty]
        private double alturaRectangulo;

        [ObservableProperty]
        private double resultado;

        [RelayCommand]
        private void CalcularArea()
        {
            Resultado = BaseRectangulo * AlturaRectangulo;
        }

        [RelayCommand]
        private void LimpiarArea()
        {
            BaseRectangulo = 0;
            AlturaRectangulo = 0;
            Resultado = 0;
        }
    }
}
