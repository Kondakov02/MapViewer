// Форма ввода названия и цвета маршрута.
using System.Windows.Forms;

namespace VGSCHmap
{
    public partial class RouteDialogForm : Form
    {
        private void UpdateButtonColor()
        {
            button3.BackColor = ColorPickDialog.Color;
        }

        public RouteDialogForm()
        {
            InitializeComponent();
            ColorPickDialog.Color = System.Drawing.Color.Red;
            UpdateButtonColor();
        }     

        public RouteDialogForm(string defaultInput) : this()
        {
            textBox1.Text = defaultInput;
        }

        public RouteDialogForm(string routeName, System.Drawing.Color routeColor) : this()
        {
            textBox1.Text = routeName;
            ColorPickDialog.Color = routeColor;
            UpdateButtonColor();
        }

        public string GetName()
        {
            return textBox1.Text;
        }

        public System.Drawing.Color GetColor()
        {
            return ColorPickDialog.Color;
        }

        // Функция для изменения цвета
        private void button3_Click(object sender, System.EventArgs e)
        {
            if (ColorPickDialog.ShowDialog() == DialogResult.OK)
            {
                UpdateButtonColor();
            }
        }
    }
}
