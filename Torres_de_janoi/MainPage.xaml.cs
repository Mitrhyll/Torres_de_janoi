﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using Torres_de_janoi.MOVS;

namespace Torres_de_janoi
{
    public partial class MainPage : ContentPage
    {
        List<Movimiento> movimiento;
        Stack<Button> to1, to2, to3;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Step_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            movs = new List<Movimiento>();
            to1 = new Stack<Button>();
            to2 = new Stack<Button>();
            to3 = new Stack<Button>();
            t1.Children.Clear();
            t2.Children.Clear();
            t3.Children.Clear();
            to1.Clear();
            to2.Clear();
            to3.Clear();
            for (int a = (int)this.Step.Value; a> 0; a--)
            {
                Button item = new Button();
                float porce= (float) (a/(this.Step.Value+1));
                porce = (float) ((this.Width / 3)* porce);
                porce = (float) ((this.Height - porce)/ 2);
                item.Margin = new Thickness (porce, 3,porce, 3);
                item.WidthRequest = (this.Width /3) * (a/ this.Step.Value);
                switch (a)
                {
                    case 1: item.Background = Brush.Black; break;
                    case 2: item.Background = Brush.Black; break;
                    case 3: item.Background = Brush.Black; break;
                    case 4: item.Background = Brush.Black; break;
                    case 5: item.Background = Brush.Black; break;
                    case 6: item.Background = Brush.Black; break;
                    case 7: item.Background = Brush.Black; break;
                    case 8: item.Background = Brush.Black; break;
  
                }
                to1.Push(item);
            }
            showTower();


        }

        public void showTower()
        {
            t1.Children.Clear();
            t2.Children.Clear();
            t3.Children.Clear();
            foreach (var disco in to1)
            {
                t1.Children.Add(disco);
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        public void hanoi(int disco, int ori, int des, int aux)
        {
            if(disco == 0)
            {
                this.movs.Add(new Movimiento { ori = ori, des = des });
            }
        }
    }
}
