#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Algorithms;
using Algorithms.Services;
using Syncfusion.Windows.Forms;

namespace GroupBarDemo_2005
{
    public partial class Form1 : MetroForm
    {
        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
          
            //Initial settings for item icons in groupBar
            imageListAdv1.ToImageList().ColorDepth = ColorDepth.Depth32Bit;
            for(var i=0; i<22; i++){
                gbAlgorithm.GroupBarItems[i].Image = imageListAdv1.Images[i];
            }
       

        }
  
        #endregion

        private int _currentItem;
        private void gbAlgorithm_GroupBarItemSelected(object sender, EventArgs e)
        {
            _currentItem = gbAlgorithm.SelectedItem;

            //Clear inputs && outputs
            rtbProcess.Clear(); txtA.Clear(); txtB.Clear(); txtC.Clear(); txtEquation.Clear(); txtIteration.Clear(); txtTolerance.Clear();

            lblAlgorithm.Text = gbAlgorithm.GroupBarItems[_currentItem].Text;
            SetLabelsText(_currentItem);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {  
            rtbProcess.Clear();
            txtAns.Clear();
                SelectAlgorithm(_currentItem);
           /* else
                MessageBox.Show("¡Entradas vacías o nulas!", "Input Error Handler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            */


        }

        public void SelectAlgorithm(int index)
        {
            switch (index)
            {
                case 0:
                    var mBiseccion = new MetodoDeBiseccion();
                    txtAns.Text = mBiseccion.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), 
                                                       txtTolerance.Text.ToDouble(), txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(mBiseccion.StepsLog);
                    break;
                case 1:
                    var puntoFijo = new PuntoFijo();
                    txtAns.Text = puntoFijo.Calculate(txtEquation.Text, txtA.Text, txtB.Text.ToDouble(), txtTolerance.Text.ToDouble(), 
                                                      txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(puntoFijo.StepsLog);
                    break;
                case 2:
                    var mNewton = new MetodoNewton();
                    txtAns.Text = mNewton.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtTolerance.Text.ToDouble(), 
                                                    txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(mNewton.StepsLog);
                    break;
                case 3:
                    var mSecante = new MetodoSecante();
                    txtAns.Text = mSecante.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(),
                                                     txtTolerance.Text.ToDouble(), txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(mSecante.StepsLog);
                    break;
                case 4:
                    var posicionFalsa = new PosicionFalsa();
                    txtAns.Text = posicionFalsa.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(),
                                                     txtTolerance.Text.ToDouble(), txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(posicionFalsa.StepsLog);
                    break;
                case 5:
                    var mMuller = new Muller();
                    txtAns.Text = mMuller.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtC.Text.ToDouble(),
                                                    txtTolerance.Text.ToDouble(), txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(mMuller.StepsLog);
                    break;
                case 6:
                     var laGrange = new InterpolacionLaGrange();
                     txtAns.Text = laGrange.Calculate(txtEquation.Text.ToDouble(), txtA.Text.ToDoubleList().ToArray(), 
                                                     txtIteration.Text.ToDoubleList().ToArray());
                    FillRichTextProcessBox(laGrange.StepsLog);
                    break;
                case 7:
                    var interNewton = new InterpolanteDeNewton();
                    txtAns.Text = interNewton.Calculate(txtEquation.Text.ToDouble(), txtA.Text.ToDoubleList().ToArray()
                                                        ,txtIteration.Text.ToDoubleList().ToArray()).ToString(CultureInfo.InvariantCulture);
                    break;
                case 8:
                    var trazadorCubicoNatural = new TrazadorCubicoNatural();
                    trazadorCubicoNatural.Calculate(txtEquation.Text.ToDoubleList().ToArray(), txtA.Text.ToDoubleList().ToArray());
                    FillRichTextProcessBox(trazadorCubicoNatural.StepsLog);
                    break;
                case 9:
                    var interMedianteTrazador = new InterpolacionMedianteTrazadores();
                    interMedianteTrazador.Calculate(txtEquation.Text.ToDoubleList().ToArray(),txtA.Text.ToDoubleList().ToArray(),txtIteration.Text.ToDouble(),txtC.Text.ToDouble());
                    FillRichTextProcessBox(interMedianteTrazador.StepsLog);
                    break;
                case 10:
                    var diffNumerica = new DiffNumerica();
                    txtAns.Text = diffNumerica.Calculate(txtEquation.Text.ToDoubleList().ToArray(), txtA.Text.ToDoubleList().ToArray(), 
                                                         txtB.Text.ToDouble(), txtIteration.Text.ToInt32());
                    break;
                case 11:
                    var trapecio = new ReglaTrapecio();
                    txtAns.Text = trapecio.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(trapecio.StepsLog);
                    break;
                case 12:
                    var simpson = new Simpson();
                    txtAns.Text = simpson.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtIteration.Text.ToInt32());
                    break;
                case 13:
                    var cuadraturaGauss = new CuadraturaGauss();
                    txtAns.Text = cuadraturaGauss.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), 
                                                            txtIteration.Text.ToInt32());
                    break;
                case 14:
                    var metodoEuler = new MetodoEuler();
                    txtAns.Text = metodoEuler.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtC.Text.ToDouble(), 
                                                        txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(metodoEuler.StepsLog);
                    break;
                case 15:
                    var rungeKutta = new RungeKutta();
                    txtAns.Text = rungeKutta.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtC.Text.ToDouble(),
                                                       txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(rungeKutta.StepsLog);
                    break;
                case 16:
                   var kutta = new RungeKutta();
                    txtAns.Text = kutta.Calculate(txtEquation.Text, txtA.Text.ToDouble(), txtB.Text.ToDouble(), txtC.Text.ToDouble(),
                                                       txtIteration.Text.ToInt32());
                    FillRichTextProcessBox(kutta.StepsLog);
                    break;
                case 17:
                    var gauss = new Gauss();
                    gauss.Calculate(txtEquation.Text.ToDoubleArrayOfArrays(), txtA.Text.ToDoubleList().ToArray());
                    break;
                case 18:
                    var gaussJordan = new GaussJordan();
                    gaussJordan.Calculate(txtEquation.Text.ToDoubleBidimensionalArray(), txtA.Text.ToInt32());
                    break;
                case 19:
                    var descLU = new DescomposicionLU();
                    descLU.Calculate(txtEquation.Text.ToDoubleBidimensionalArray());
                    FillRichTextProcessBox(descLU.StepsLog);
                    break;
                case 20:
                    var inversa = new Inversa();
                    inversa.Calculate(txtEquation.Text.ToDoubleBidimensionalArray(), txtA.Text.ToDoubleList().ToArray());
                    FillRichTextProcessBox(inversa.StepsLog);
                    break;
                case 21:
                    var regresionLineal = new RegresionLineal();
                    txtAns.Text = regresionLineal.Calculate(txtEquation.Text.ToDoubleList().ToArray(), txtA.Text.ToDoubleList().ToArray(),
                                             txtIteration.Text.ToDouble()).ToString();
                    break;
                case 22:
                    var lineasFinitas = new LineasFinitas();
                    var list = txtB.Text.ToDoubleList().ToArray();
                    lineasFinitas.Calculate(txtEquation.Text, txtA.Text, txtIteration.Text, 
                                             list[0], list[1], list[2], list[3], txtTolerance.Text.ToInt32());
                    FillRichTextProcessBox(lineasFinitas.StepsLog);
                    break;
            }
        }

        public void SetLabelsText(int index)
        {
            switch (index)
            {
                case 0:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "a:";
                    lblB.Text = "b:";      lblB.Visible = true;  txtB.Visible = true;
                    lblC.Visible = false;  txtC.Visible = false;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    
                    break;
                case 1:
                    lblA.Text = "Ecuación 2da:";
                    lblB.Text = "p0:"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Visible = false; txtC.Visible = false;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;

                    break;
                case 2:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "p0:"; 
                    lblB.Visible = false; txtB.Visible = false; txtB.Text = "0";
                    lblC.Visible = false; txtC.Visible = false;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    
                    break;
                case 3:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "p0:";
                    lblB.Text = "p1"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Visible = false; txtC.Visible = false;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    
                    break;
                case 4:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "p0:"; 
                    lblB.Text = "p1"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Visible = false; txtC.Visible = false;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;

                    break;
                case 5:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "x1:"; 
                    lblB.Text = "x2"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "x3"; lblC.Visible = true; txtC.Visible = true;
                    lblTol.Text = "Tol:"; lblTol.Visible = true; txtTolerance.Visible = true;
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;


                    break;
                case 6:
                    lblEquation.Text = "XINT:"; 
                    lblA.Text = "x[]:";
                    lblIteration.Text = "f(x)[]:";
                    lblIteration.Visible = true;
                    txtIteration.Visible = true;
                    txtB.Text = "0";
                    txtTolerance.Text = "0";
                    txtTolerance.Visible = false;
                    txtB.Visible = false;
                    txtC.Visible = false;
                    lblB.Visible = false;
                    lblC.Visible = false;
                    lblTol.Visible = false;

                    break;
                case 7:
                    lblEquation.Text = "XINT:"; 
                    lblA.Text = "x[]:";
                    lblIteration.Text = "f(x)[]:";
                    lblIteration.Visible = true;
                    txtIteration.Visible = true;
                    txtB.Text = "0";
                    txtTolerance.Text = "0";
                    txtTolerance.Visible = false;
                    txtB.Visible = false;
                    txtC.Visible = false;
                    lblB.Visible = false;
                    lblC.Visible = false;
                    lblTol.Visible = false;
                    break;
                case 8:
                    lblEquation.Text = "f(a):";
                    lblA.Text = "x[]:";
                    txtB.Text = "0";
                    txtC.Text = "0";
                    txtIteration.Text = "0";
                    txtTolerance.Text = "0";
                    txtIteration.Visible = false;
                    txtTolerance.Visible = false;
                    txtB.Visible = false;
                    txtC.Visible = false;
                    lblB.Visible = false;
                    lblC.Visible = false;
                    lblTol.Visible = false;
                    lblIteration.Visible = false;
                    break;
                case 9:
                    lblEquation.Text = "x[]:";
                    lblA.Text = "f(x)[]:"; 
                    lblB.Visible = false; txtB.Visible = false; txtB.Text = "0";
                    lblC.Text = "fpN:"; lblC.Visible = true; txtC.Visible = true;
                    lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "fp0::"; txtIteration.Visible = true; lblIteration.Visible = true;  
                    break;

                case 10:
                    lblEquation.Text = "x[]:";
                    lblA.Text = "f(x)[]:";
                    txtC.Text = "0";
                    txtTolerance.Text = "0";
                    txtIteration.Visible = true;
                    txtTolerance.Visible = false;
                    txtB.Visible = true;
                    txtC.Visible = false;
                    lblB.Visible = true;
                    lblB.Text = "XD";
                    lblC.Visible = false;
                    lblTol.Visible = false;
                    lblIteration.Visible = true;
                    lblIteration.Text = "Nº."; 
                    break;
                case 11:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "a:"; 
                    lblB.Text = "b"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "x3"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 12:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "a:"; 
                    lblB.Text = "b"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "x3"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 13:
                     lblEquation.Text = "Ecuacion:";
                    lblA.Text = "a:"; 
                    lblB.Text = "b"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "x3"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 14:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "X0:"; 
                    lblB.Text = "XF:"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "Y0:"; lblC.Visible = true; txtC.Visible = true;
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 15:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "X0:"; 
                    lblB.Text = "XF:"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "Y0:"; lblC.Visible = true; txtC.Visible = true;
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 16:
                    lblEquation.Text = "Ecuacion:";
                    lblA.Text = "X0:"; 
                    lblB.Text = "XF:"; lblB.Visible = true; txtB.Visible = true;
                    lblC.Text = "Y0:"; lblC.Visible = true; txtC.Visible = true;
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 17:
                    lblEquation.Text = "Matrix[][]:";
                    lblA.Text = "vector[]:"; 
                    lblB.Text = "XF:"; lblB.Visible = false; txtB.Visible = false;
                    lblC.Text = "Y0:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = false; lblIteration.Visible = false; txtIteration.Text = "0";
                    break;
                case 18:
                    lblEquation.Text = "Matrix[,]:";
                    lblA.Text = "dimension:"; 
                    lblB.Text = "XF:"; lblB.Visible = false; txtB.Visible = false;
                    lblC.Text = "Y0:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = false; lblIteration.Visible = false; txtIteration.Text = "0";
                    break;
                case 19:
                    lblEquation.Text = "Matrix[,]:";
                    lblA.Text = ""; 
                    lblB.Text = "XF:"; lblB.Visible = false; txtB.Visible = false;
                    lblC.Text = "Y0:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = false; lblIteration.Visible = false; txtIteration.Text = "0";
                    break;
                case 20:
                    lblEquation.Text = "Matrix[,]:";
                    lblA.Text = "vector[]:"; 
                    lblB.Text = "XF:"; lblB.Visible = false; txtB.Visible = false;
                    lblC.Text = "Y0:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = false; lblIteration.Visible = false; txtIteration.Text = "0";
                    break;
                case 21:
                    lblEquation.Text = "x[]:";
                    lblA.Text = "f(x)[]:"; 
                    lblB.Text = "XF:"; lblB.Visible = false; txtB.Visible = false;
                    lblC.Text = "Y0:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Tol:"; lblTol.Visible = false; txtTolerance.Visible = false; txtTolerance.Text = "0";
                    lblIteration.Text = "Nº:"; txtIteration.Visible = true; lblIteration.Visible = true;
                    break;
                case 22:
                    //string px, string qx, string rx, double a, double b, double alpha, double beta, int N
                    lblEquation.Text = "px[]:";
                    lblA.Text = "qx[]:";
                    lblB.Text = "a, b, alpha, beta"; lblB.Visible = true; txtB.Visible = true; txtB.Text = "0,0,0,0";
                    lblC.Text = "fpN:"; lblC.Visible = false; txtC.Visible = false; txtC.Text = "0";
                    lblTol.Text = "Nº:";  lblTol.Visible = true; txtTolerance.Visible = true; txtTolerance.Text = "0";
                    lblIteration.Text = "rx::"; txtIteration.Visible = true; lblIteration.Visible = true;  

                    break;
            }
        }

        public void FillRichTextProcessBox(IEnumerable<string> stepsLog)
        {
            foreach (var step in stepsLog)
            {
               rtbProcess.AppendText(step + Environment.NewLine);
            }        
        }

        public bool EmptyNorNullInputs()
        {
            var equation = txtEquation.Text.Trim();
            var a = txtA.Text.Trim();
            var b = txtB.Text.Trim();
            var tolerance = txtTolerance.Text.Trim();
            var iterator = txtIteration.Text.Trim();

            if (string.IsNullOrEmpty(equation)  ||
                string.IsNullOrEmpty(a)         ||
                string.IsNullOrEmpty(b)         ||
                string.IsNullOrEmpty(tolerance) ||
                string.IsNullOrEmpty(iterator))
                return false;
            return true;
        } 
    }
}