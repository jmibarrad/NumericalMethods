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
            if (EmptyNorNullInputs())
                SelectAlgorithm(_currentItem);
            else
                MessageBox.Show("¡Entradas vacías o nulas!", "Input Error Handler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



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