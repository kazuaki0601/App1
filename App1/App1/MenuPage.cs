using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "メニューページ";

          //5*5のグリッド作成
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            this.Content = grid;

            // ボタンイベント
            grid.Children.Add(new Button { Text = "電卓", Command = new Command(() => Navigation.PushAsync(new CalcPage())) }, 0, 1);

            grid.Children.Add(new Button { Text = "ボタン2", }, 1, 1);
            grid.Children.Add(new Button { Text = "ボタン3", }, 2, 1);
            grid.Children.Add(new Button { Text = "ボタン3", }, 3, 1);
            grid.Children.Add(new Button { Text = "ボタン3", }, 4, 1);
            grid.Children.Add(new Button { Text = "ボタン1", }, 0, 2);
            grid.Children.Add(new Button { Text = "ボタン2", }, 1, 2);
            grid.Children.Add(new Button { Text = "ボタン3", }, 2, 2);
            grid.Children.Add(new Button { Text = "ボタン3", }, 3, 2);
            grid.Children.Add(new Button { Text = "ボタン3", }, 4, 2);

        }
    }
}
