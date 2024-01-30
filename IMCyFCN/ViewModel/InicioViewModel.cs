using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IMCyFCN.ViewModel
{
    public class InicioViewModel : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public bool _imc;
        public bool _fcn;
        public string _latidos

        #endregion
        #region CONSTRUCTOR
        public InicioViewModel(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public bool FCN
        {
            get { return _fcn; }
            set { SetValue(ref _fcn, value); }
        }
        public bool IMC
        {
            get { return _imc; }
            set { SetValue(ref _imc, value);}
        }
        public string Latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularFCN()
        {
            int bpm = int.Parse(Latidos);
                
           
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(Opcion);
        #endregion
    }
}
