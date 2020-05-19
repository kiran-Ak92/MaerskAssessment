using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PromotionEngine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
            
        }

        private void SKU_A_Click(object sender, RoutedEventArgs e)
        {
            var AcurVal = Int32.Parse(Aval.Text);
            var AsetVal = AcurVal + 1;
            Aval.Text = AsetVal.ToString();
            
        }

        private void SKU_B_Click(object sender, RoutedEventArgs e)
        {
            var BcurVal = Int32.Parse(Bval.Text);
            var BsetVal = BcurVal + 1;
            Bval.Text = BsetVal.ToString();
        }

        private void SKU_C_Click(object sender, RoutedEventArgs e)
        {
            var CcurVal = Int32.Parse(Cval.Text);
            var CsetVal = CcurVal + 1;
            Cval.Text = CsetVal.ToString();
        }

        private void SKU_D_Click(object sender, RoutedEventArgs e)
        {
            var DcurVal = Int32.Parse(Dval.Text);
            var DsetVal = DcurVal + 1;
            Dval.Text = DsetVal.ToString();
        }

        private void A_Ls_Click(object sender, RoutedEventArgs e)
        {
            var AcurVal = Int32.Parse(Aval.Text);
            if (AcurVal != 0)
            {
                var AsetVal = AcurVal - 1;
                Aval.Text = AsetVal.ToString();
            }
        }

        private void B_Ls_Click(object sender, RoutedEventArgs e)
        {
            var BcurVal = Int32.Parse(Bval.Text);
            if (BcurVal != 0)
            {
                var BsetVal = BcurVal - 1;
                Bval.Text = BsetVal.ToString();
            }
        }

        private void C_Ls_Click(object sender, RoutedEventArgs e)
        {
            var CcurVal = Int32.Parse(Cval.Text);
            if (CcurVal != 0)
            {
                var CsetVal = CcurVal - 1;
                Cval.Text = CsetVal.ToString();
            }
        }

        private void D_Ls_Click(object sender, RoutedEventArgs e)
        {
            var DcurVal = Int32.Parse(Dval.Text);
            if (DcurVal != 0)
            {
                var DsetVal = DcurVal - 1;
                Dval.Text = DsetVal.ToString();
            }
        }

        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            var A = 50;
            var B = 30;
            var C = 20;
            var D = 15;
            var A3 = 130;
            var B2 = 45;
            var CD = 30;
            var A_Order = Int32.Parse(Aval.Text);
            var B_Order = Int32.Parse(Bval.Text);
            var C_Order = Int32.Parse(Cval.Text);
            var D_Order = Int32.Parse(Dval.Text);
            var TotPrice = 0;
            if(A_Order != 0)
            {
                if(A_Order>=3)
                {
                    var aoffer = A_Order / 3;
                    var abal = A_Order % 3;
                    var aoffprice = aoffer * A3;
                    var A_Total = aoffprice + (abal * A);
                    Aorder.Content = A_Order.ToString() + " *    A     " + A_Total.ToString();
                    TotPrice += A_Total;
                }

                else
                {
                    var Aprice = A_Order * A;
                    Aorder.Content= A_Order.ToString() + " *    A     " + Aprice.ToString();
                    TotPrice += Aprice;
                }
            }

            if (B_Order != 0)
            {
                if (B_Order >= 2)
                {
                    var boffer = B_Order / 2;
                    var bbal = B_Order % 2;
                    var boffprice = boffer * B2;
                    var B_Total = boffprice + (bbal * B);
                    Border.Content = B_Order.ToString() + " *    B     " + B_Total.ToString();
                    TotPrice += B_Total;
                }

                else
                {
                    var Bprice = B_Order * B;
                    Border.Content = B_Order.ToString() + " *    B     " + Bprice.ToString();
                    TotPrice += Bprice;
                }
            }
            if (C_Order != 0 && D_Order==0)
            {
                
                    var Cprice = C_Order * C;
                    Corder.Content = C_Order.ToString() + " *    C     " + Cprice.ToString();
                TotPrice += Cprice;
               
            }
            else if (C_Order == 0 && D_Order != 0)
            {

                var Dprice = D_Order * D;
                Dorder.Content = D_Order.ToString() + " *    D     " + Dprice.ToString();
                TotPrice += Dprice;
            }
            else if(C_Order != 0 && D_Order != 0)
            {
                var CD_total = 0;
                if(C_Order==D_Order)
                {
                   
                    CD_total = C_Order * CD;
                    Corder.Content = C_Order.ToString() + " *    CD     " + CD_total.ToString();
                    TotPrice += CD_total;
                }
                else if(C_Order>D_Order)
                {
                    var diff = C_Order - D_Order;
                    var D_total = D_Order * CD;
                    var C_total = diff * C;
                     CD_total = D_total + C_total;
                    Corder.Content = C_Order.ToString() + " * C" + C_total.ToString();
                    Corder.Content = D_Order.ToString() + " * D" + D_total.ToString();
                    TotPrice = CD_total;
                }
                else if(D_Order>C_Order)
                {
                    var diff = D_Order - C_Order;
                    var D_total = diff * D; 
                    var C_total = C_Order * CD;
                    CD_total = D_total + C_total;
                    Corder.Content = C_Order.ToString() + " * C" + C_total.ToString();
                    Corder.Content = D_Order.ToString() + " * D" + D_total.ToString();
                    TotPrice = CD_total;
                }

            }

            TotalOrder.Content = TotPrice.ToString();

        }
    }
}
