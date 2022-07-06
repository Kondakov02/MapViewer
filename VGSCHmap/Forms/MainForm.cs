using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MapViewer.Helpers;
using MapViewer.Misc;

namespace VGSCHmap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        enum InfoPanelState
        {
            Idle,
            CreatingMarker,
            EditingMarker
        }

        private const int ConstMinZoom = 2, ConstMaxZoom = 15, ConstDefaultZoom = 4;
        private GMapOverlay MainOverlay = new GMapOverlay("MainOverlay");
        private DataFileManagement fileManager = new DataFileManagement();
        private SearchBarFunctions searchHintsManager = new SearchBarFunctions();
        private InfoPanelState panelState;
        private GMapRoute temporaryRoute;
        private GMapMarker focusedMarker;

        private void MainForm_Load(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.GoogleMap;
            MapControl.Position = new PointLatLng(55.78, 37.61);    // Москва
            MapControl.MinZoom = ConstMinZoom;
            MapControl.MaxZoom = ConstMaxZoom;
            MapControl.Zoom = ConstDefaultZoom;
            MapControl.DragButton = MouseButtons.Left;
            MapControl.ShowCenter = false;
            GMapProvider.Language = LanguageType.Russian;

            MapControl.Overlays.Add(MainOverlay);

            SaveImageDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            LoadMarkersDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveMarkersDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            panelState = InfoPanelState.Idle;
            focusedMarker = null;
        }

        private void DisplayInfoPanel(bool display, string name, string description)
        {
            MarkerNameBox.Text = name;
            MarkerDescBox.Text = description;
            MarkerInfoPanel.Enabled = display;
            MarkerInfoPanel.Visible = display;
            // Необходимо отключить кнопки "Маркеры", "Маршруты" и "Снимок", чтобы не помешать
            // процессу создания маркера.
            MarkersButton.Enabled = !display;
            RoutesButton.Enabled = !display;
            PrintButton.Enabled = !display;
        }

        private void CreateNewMarker(int mouseXposition, int mouseYposition)
        {
            DisplayInfoPanel(true, "", "");
            panelState = InfoPanelState.CreatingMarker;

            double X = MapControl.FromLocalToLatLng(mouseXposition, mouseYposition).Lat;
            double Y = MapControl.FromLocalToLatLng(mouseXposition, mouseYposition).Lng;

            MainOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(X, Y), GMarkerGoogleType.red));
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (temporaryRoute != null) return;     // Во время создания маршрута функции добавления маркеров отключена
            int lastMarker = MainOverlay.Markers.Count - 1;
            string markerName = MarkerNameBox.Text;
            string markerDescription = MarkerDescBox.Text;
            MarkerInfo newInfo;
            switch (panelState)
            {
                case InfoPanelState.Idle:
                    if (e.Button != MouseButtons.Right) break;
                    CreateNewMarker(e.X, e.Y);
                    break;

                case InfoPanelState.CreatingMarker:
                    if (String.IsNullOrEmpty(markerName))
                    {
                        MainOverlay.Markers.RemoveAt(lastMarker);
                    }
                    else
                    {
                        newInfo = new MarkerInfo(markerName, markerDescription,
                            MainOverlay.Markers[lastMarker].Position);
                        MainOverlay.Markers[lastMarker].Tag = newInfo;
                        MainOverlay.Markers[lastMarker].ToolTipText = markerName;
                        SearchBox.AutoCompleteCustomSource.Add(markerName);
                    }

                    if (e.Button == MouseButtons.Right)
                    {
                        CreateNewMarker(e.X, e.Y);
                    }
                    else
                    {
                        DisplayInfoPanel(false, "", "");
                        panelState = InfoPanelState.Idle;
                    }
                    break;

                case InfoPanelState.EditingMarker:
                    if (!String.IsNullOrEmpty(markerName))
                    {
                        MarkerInfo oldInfo = focusedMarker.Tag as MarkerInfo;
                        newInfo = new MarkerInfo(markerName, markerDescription, focusedMarker.Position);
                        foreach(var marker in MainOverlay.Markers)
                        {
                            if (marker.Equals(focusedMarker) )
                            {
                                marker.Tag = newInfo;
                                marker.ToolTipText = markerName;
                                break;
                            }
                        }
                        SearchBox.AutoCompleteCustomSource.Remove(oldInfo.Name);
                        SearchBox.AutoCompleteCustomSource.Add(markerName);
                    }

                    focusedMarker = null;
                    if (e.Button == MouseButtons.Right)
                    {
                        CreateNewMarker(e.X, e.Y);
                    }
                    else
                    {
                        DisplayInfoPanel(false, "", "");
                        panelState = InfoPanelState.Idle;
                    }
                    break;
            }
        }

        private void DeleteInfoButton_Click(object sender, EventArgs e)
        {
            if (focusedMarker is null) return;

            int i = 0;
            while (i < MainOverlay.Markers.Count && focusedMarker != null)
            {
                if (MainOverlay.Markers[i].Equals(focusedMarker))
                {
                    MainOverlay.Markers.RemoveAt(i);
                    focusedMarker = null;
                    DisplayInfoPanel(false, "", "");
                    panelState = InfoPanelState.Idle;
                }
                i++;
            }
        }

        private void LoadMarkersButton_Click(object sender, EventArgs e)
        {
            if (LoadMarkersDialog.ShowDialog() != DialogResult.OK) return;

            List<MarkerInfo> markersInfo;
            try
            {
                markersInfo = fileManager.LoadMarkerData(LoadMarkersDialog.FileName);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл. " +
                    "Проверьте, что загружаете правильный файл, " +
                    "или попробуйте загрузить другой резерв. ", "Ошибка");
                return;
            }

            MainOverlay.Markers.Clear();
            foreach (var item in markersInfo)
            {
                MainOverlay.Markers.Add(new GMarkerGoogle(item.Position, GMarkerGoogleType.red)
                {
                    ToolTipText = item.Name,
                    Tag = item
                });
            }
            SearchBox.AutoCompleteCustomSource = searchHintsManager.GetNewList(markersInfo);
        }

        private void SaveMarkersButton_Click(object sender, EventArgs e)
        {
            if (MainOverlay.Markers.Count < 1)
            {
                MessageBox.Show("На карте нет маркеров.", "Ошибка");
                return;
            }
            SaveMarkersDialog.FileName = "Маркеры " + DateTime.Now.ToString("dd_MM_yyyy");
            if (SaveMarkersDialog.ShowDialog() != DialogResult.OK) return;

            List<MarkerInfo> markersInfo = new List<MarkerInfo>();
            foreach (var marker in MainOverlay.Markers)
            {
                markersInfo.Add(marker.Tag as MarkerInfo);
            }

            try
            {
                fileManager.SaveData(SaveMarkersDialog.FileName, markersInfo);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл. " +
                    "Измените место сохранения и попробуйте ещё раз.", "Ошибка");
                return;
            }
        }

        private void DeleteMarkersButton_Click(object sender, EventArgs e)
        {
            if (MainOverlay.Markers.Count < 1) return;
            MainOverlay.Markers.Clear();
            SearchBox.AutoCompleteCustomSource.Clear();
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            RoutesForm window = new RoutesForm(MainOverlay.Routes);
            window.ShowDialog();

            // После закрытия формы проверяются её публичные свойства.
            if (window.RouteListChanged)
            {
                MapControl.Refresh();
            }
            if (window.ShowingMode)
            {
                MapControl.Position = window.RoutePoint;                // Показать в центре карты начальную точку маршрута.
            }
            if (window.AddingMode)
            {
                ChangeComponentsForRouteAddingMode(true, false);        // Активация режима добавления маршрута.
                temporaryRoute = new GMapRoute("")
                {
                    Stroke = new Pen(Brushes.Red, 3)
                    {
                        DashPattern = new float[2] {3, 3}
                    },
                };
                MainOverlay.Routes.Add(temporaryRoute);
            }

            window.Dispose();
        }

        /* Активация и деактивация различных компонентов главного окна
         * для режима добавления маршрута.
         */
        private void ChangeComponentsForRouteAddingMode(bool modeComponentsEnabled, bool toolBarComponentsEnabled)
        {
            /* Кнопки "Далее", "Отмена" в нижнем правом углу карты, а также визуальный индикатор
             * активированного режима добавления маршрута.
             */
            RouteAddModeLabel.Enabled = modeComponentsEnabled;
            RouteAddModeLabel.Visible = modeComponentsEnabled;
            AddRouteButton.Enabled = modeComponentsEnabled;
            AddRouteButton.Visible = modeComponentsEnabled;
            CancelRouteButton.Enabled = modeComponentsEnabled;
            CancelRouteButton.Visible = modeComponentsEnabled;

            // Кнопки "Маршруты", "Маркеры", "Снимок карты" вверху окна.
            MarkersButton.Enabled = toolBarComponentsEnabled;
            RoutesButton.Enabled = toolBarComponentsEnabled;
            PrintButton.Enabled = toolBarComponentsEnabled;
        }

        private void MapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (temporaryRoute is null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    panelState = InfoPanelState.EditingMarker;
                    focusedMarker = item;
                    MarkerInfo markerInfo = item.Tag as MarkerInfo;
                    DisplayInfoPanel(true, markerInfo.Name, markerInfo.Description);
                }
            }
            else
            {
                bool PointsChanged = false;
                int lastPoint = temporaryRoute.Points.Count - 1;

                if (e.Button == MouseButtons.Left)
                {
                    if (lastPoint < 0 || temporaryRoute.Points[lastPoint] != item.Position)     // Нельзя внести точку в путь два раза подряд
                    {
                        temporaryRoute.Points.Add(item.Position);
                        PointsChanged = true;
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    for (int i = lastPoint; i >= 0; i--)                                        // Удаление последнего вхождения точки в путь
                    {
                        if (temporaryRoute.Points[i] == item.Position)
                        {
                            temporaryRoute.Points.RemoveAt(i);
                            PointsChanged = true;
                            break;
                        }
                    }
                }

                if (PointsChanged)
                {
                    /* При внесении новой точки в путь или удалении старой, необходимо это отобразить,
                     * и перестроить маршрут. В этом случае маршрут заново добавляется на карту.
                     * Возможно, есть более элегантный способ отображать изменения, но я не смог придумать.
                     */
                    MainOverlay.Routes.RemoveAt(MainOverlay.Routes.Count - 1);
                    MainOverlay.Routes.Add(temporaryRoute);
                }
            }
        }

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            if (temporaryRoute.Points.Count < 2)
            {
                MessageBox.Show("В маршруте должны быть хотя бы 2 точки.");
                return;
            }

            string defaultName = String.Format("Маршрут #{0}", MainOverlay.Routes.Count);
            using (RouteDialogForm inputDialog = new RouteDialogForm(defaultName))
            {
                if (inputDialog.ShowDialog() != DialogResult.OK) return;

                string routeName = inputDialog.GetName();
                Color routeColor = inputDialog.GetColor();
                if (String.IsNullOrEmpty(routeName))
                {
                    routeName = defaultName;
                }
                foreach(var route in MainOverlay.Routes) 
                {
                    if (route.Name == routeName)
                    {
                        MessageBox.Show(String.Format("Маршрут с таким названием ({0}) уже есть.", routeName));
                        return;
                    }
                }
                temporaryRoute.Name = routeName;
                temporaryRoute.Stroke.Color = routeColor;
                ChangeComponentsForRouteAddingMode(false, true);
                temporaryRoute = null;
                MessageBox.Show("Маршрут был добавлен");
                MapControl.Refresh();
            }
        }

        private void CancelRouteButton_Click(object sender, EventArgs e)
        {
            ChangeComponentsForRouteAddingMode(false, true);
            MainOverlay.Routes.RemoveAt(MainOverlay.Routes.Count - 1);
            temporaryRoute = null;
        }

        private void ShowMarkersButton_Click(object sender, EventArgs e)
        {
            var visible = ShowMarkersButton.Checked;
            foreach (var marker in MainOverlay.Markers)
            {
                marker.IsVisible = visible;
                marker.IsHitTestVisible = visible;
            }
        }

        private void ShowRoutesButton_Click(object sender, EventArgs e)
        {
            var visible = ShowRoutesButton.Checked;
            foreach (var route in MainOverlay.Routes)
            {
                route.IsVisible = visible;
                route.IsHitTestVisible = visible;
            }
        }

        private void AppHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите и удерживайте левую кнопку мыши, чтобы перемещаться по карте.\n" +
                   "Чтобы изменить масштаб, крутите колёсико мыши или нажимайте кнопки + - в левом нижнем углу.\n" +
                   "Нажмите правой кнопкой мыши по области, чтобы добавить новый маркер. Введите название в левом верхнем " +
                   "поле, чтобы оставить его на карте. Во время создания маршрута добавлять новые маркеры нельзя.\n" +
                   "Нажмите левой кнопкой мыши по маркеру, чтобы открыть его описание. " +
                   "Чтобы убрать окно информации, необходимо нажать по пустому месту левой кнопкой мыши. " +
                   "Изменения автоматически сохраняются.", "Помощь");
        }

        /* Операция поиска маркера на карте начинается, когда пользователь нажимает Enter
         * или выбирает подсказку. Если маркер был найден, центр карты оказывается на
         * этой точке и масштаб увеличивается, если он недостаточно большой. В противном
         * случае пользователя уведомляют о том, что объекта с таким названием нет на карте.
         */
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (String.IsNullOrEmpty(SearchBox.Text)) return;

            const int ZoomFocus = 10;   // Минимальный желаемый масштаб при нахождении объекта
            string ObjectName = SearchBox.Text;
            foreach (var marker in MainOverlay.Markers)
            {
                if (marker.ToolTipText == ObjectName)
                {
                    MapControl.Position = marker.Position;
                    if (MapControl.Zoom < ZoomFocus)
                    {
                        MapControl.Zoom = ZoomFocus;
                    }
                    return;
                }
            }
            MessageBox.Show("Такого объекта нет на карте. Проверьте, правильно ли написано название, и попробуйте снова.");
        }

        /* Сохраняет текущее изображение карты.
         * Пользователь может выбрать, куда сохранить файл и с каким названием.
         */
        private void PrintButton_Click(object sender, EventArgs e)
        {
            Image temp = MapControl.ToImage();
            string ImageName = "Снимок карты " + DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss");
            SaveImageDialog.FileName = ImageName;
            if (SaveImageDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    temp.Save(SaveImageDialog.FileName);
                    MessageBox.Show("Изображение было сохранено.");
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить изображение. Измените место сохранения и попробуйте ещё раз.");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            MapControl.Zoom--;
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            MapControl.Zoom++;
        }
    }
}
