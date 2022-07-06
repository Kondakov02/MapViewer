// Форма просмотра и редактирования маршрутов.
using GMap.NET;
using GMap.NET.ObjectModel;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VGSCHmap
{
    public partial class RoutesForm : Form
    {
        private void InitVariables()
        {
            AddingMode = false;
            ShowingMode = false;
            RouteListChanged = false;
        }

        public RoutesForm()
        {
            InitializeComponent();
            RouteList = new ObservableCollectionThreadSafe<GMapRoute>();
            InitVariables();
        }

        public RoutesForm(ObservableCollectionThreadSafe<GMapRoute> routes)
        {
            InitializeComponent();
            InitVariables();
            RouteList = routes;
            foreach (var route in routes)
            {
                RoutesListBox.Items.Add(route.Name);
            }
        }

        public ObservableCollectionThreadSafe<GMapRoute> RouteList { get; private set; }
        public bool AddingMode { get; private set; }
        public bool ShowingMode { get; private set; }
        public bool RouteListChanged { get; private set; }
        public PointLatLng RoutePoint { get; private set; }

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите левой кнопкой мыши по маркеру на карте, " +
                "чтобы добавить его в путь. Нажмите правой кнопкой мыши, чтобы " +
                "удалить маркер из маршрута. Когда закончите, нажмите кнопку " +
                "\"Далее\" в правом нижнем углу карты.");

            AddingMode = true;
            Close();
        }

        private GMapRoute FindRoute(string routeName)
        {
            GMapRoute output = null;
            foreach(var route in RouteList)
            {
                if (route.Name == routeName)
                {
                    output = route;
                    break;
                }
            }
            return output;
        }

        private void ShowRouteButton_Click(object sender, EventArgs e)
        {
            if (RoutesListBox.SelectedIndex < 0) return;

            var route = FindRoute((string)RoutesListBox.SelectedItem);
            if (route is null) return;

            ShowingMode = true;
            RoutePoint = route.Points[0];
            Close();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            if (RoutesListBox.SelectedIndex < 0) return;

            GMapRoute route = FindRoute((string)RoutesListBox.SelectedItem);
            if (route is null) return;

            RouteDialogForm form = new RouteDialogForm(route.Name, route.Stroke.Color);

            if (form.ShowDialog() != DialogResult.OK) return;

            RouteListChanged = true;

            string newName = form.GetName();
            if (newName != route.Name)
            {
                route.Name = newName;
                RoutesListBox.Items[RoutesListBox.SelectedIndex] = newName;
            }

            Color newColor = form.GetColor();
            if (newColor != route.Stroke.Color)
            {
                route.Stroke.Color = newColor;
            }
        }

        private void DeleteRouteButton_Click(object sender, EventArgs e)
        {
            if (RoutesListBox.SelectedIndex < 0) return;

            var dialogResult = MessageBox.Show("Вы точно хотите удалить этот маршрут?",
                "Подтверждение удаления", MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes) return;

            for (int i = 0; i < RouteList.Count; i++)
            {
                if (RouteList[i].Name == (string)RoutesListBox.SelectedItem)
                {
                    RouteList.RemoveAt(i);
                    RoutesListBox.Items.RemoveAt(RoutesListBox.SelectedIndex);
                    break;
                }
            }

            RouteListChanged = true;
        }
    }
}
