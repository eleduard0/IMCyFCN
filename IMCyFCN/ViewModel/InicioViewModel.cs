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
        public bool _imc;
        public bool _fcn;
        public string _latidos;
        public string _altura;
        public string _peso;
        public string _resultado;
        public bool _comprobar;
        public bool _crisis;
        


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
        public string Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public string Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public bool Comprobar
        {
            get { return _comprobar; }
            set { SetValue(ref _comprobar, value); }
        }
        public bool Crisis
        {
            get { return _crisis; }
            set { SetValue(ref _crisis, value); }
        }
        
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Calcular()
        {
            if (FCN == true)
            {
                int latidos = (int.Parse(Latidos) * 4);
                if (latidos >60 && latidos < 100)
                {
                    Resultado = $"Tu frecuencia de {latidos} cardiaca es normal";
                    Crisis = false;
                    Comprobar = true;
                    
                }
                else if (latidos > 100)
                {
                    Resultado = $"Tu frecuencia de {latidos} cardiaca es alta";
                    Crisis = true;
                    Comprobar = false;
                }
                else
                {
                    Resultado = $"Tu frecuencia de {latidos} cardiaca es baja";
                    Crisis = true;
                    Comprobar = false;
                }
            }
            if (IMC == true)
            {
                double altura = double.Parse(Altura);
                double peso = double.Parse(Peso);
                double resultado = peso /(altura * altura);
                if (resultado < 18.5)
                {
                    Resultado = $"Su índice de {resultado} es insuficiente";
                }
                else if (resultado >= 18.5 && resultado < 24.9)
                {
                    Resultado = $"Su índice de {resultado} es saludable";
                }
                else if (resultado > 25 && resultado < 29.9)
                {
                    Resultado = $"Su índice de {resultado} indica que tiene sobre peso";
                }
                else
                {
                    Resultado = $"Su índice de {resultado} indica que tienes obesidad";
                }

            }
                
           
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Calcularcomand => new Command(Calcular);
        #endregion
    }
}
