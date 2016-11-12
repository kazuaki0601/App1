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
            var label = new Label();
            var btnNext = new Button()
            {
                Text = "次へ"
            };
            btnNext.Clicked += btnNext_Clicked;
            label.HorizontalTextAlignment = TextAlignment.Center;

            // The root page of your application

            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },btnNext,
                        label
                    }
            };
            
            this.Content = stackLayout;
        }


        void btnNext_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
