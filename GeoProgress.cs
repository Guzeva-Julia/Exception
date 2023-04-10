using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huzeva_lab20
{
    public partial class GeoProgress : Form
    {
        public GeoProgress()
        {
            InitializeComponent();
        }
        private void CalculateGP()
        {
            try
            {
                double b1 = Convert.ToDouble(txtB1.Text);//перший член прогресії
                double q = Convert.ToDouble(txtQ.Text); //знаменник
                int n = Convert.ToInt32(txtN.Text);    //число членів прогресії

                // check for common ratio of 1
                if (q == 1)
                {
                    throw new Exception("Знаменник повинен бути більше 1");
                }

                // calculate sum of geometric progression
                double sum = (b1 * Math.Pow(q, n - 1)); //формула геометричної прогресії

                // display result
                lblRes.Text = $"Сума геометричної прогресії дорівнює {sum}";
            }
            catch (FormatException) //обробка формату
            {
                MessageBox.Show("Будь ласка, введіть дійсні числа");
            }
            catch (OverflowException) //обробка виключення для дуже великих чисел
            {
                MessageBox.Show("Введені числа завеликі");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateGP(); // обчислення суми геометричної прогресії

        }
    }
}
