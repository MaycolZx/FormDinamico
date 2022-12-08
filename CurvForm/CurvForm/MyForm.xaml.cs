﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurvForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyForm : ContentPage
    {
        List<string> NacionPList = new List<string>();
        public MyForm()
        {
            InitializeComponent();
            //NacionP.Items.Add("Perú");
            //NacionP.Items.Add("Argentina");
            //NacionP.Items.Add("Colombia");
            //NacionP.Items.Add("Brasil");
            //NacionP.Items.Add("Chile");
            //NacionP.Items.Add("Ecuador");
            //NacionP.Items.Add("El Salvador");
            //NacionP.Items.Add("México");
            NacionPList.Add("Perú");
            NacionPList.Add("Argentina");
            NacionPList.Add("Colombia");
            NacionPList.Add("Brasil");
            NacionPList.Add("Chile");
            NacionPList.Add("Ecuador");
            NacionPList.Add("El Salvador");
            NacionPList.Add("México");
            NacionP.ItemsSource = NacionPList;

            AptitudP.Items.Add("Inteligencia Emocional");
            AptitudP.Items.Add("Creatividad");
            AptitudP.Items.Add("Iniciativa");
            AptitudP.Items.Add("Trabajo en equipo");
            AptitudP.Items.Add("Resolucion de problemas complejos");
            AptitudP.Items.Add("Capacidad de liderazgo");

        }
        
        void ButtonSubmitClicked(object sender, EventArgs e)
        {
            var in_name = name.Text;
            var in_conTelf = contactoTelf.Text;
            var in_conEmail = contactoEmail.Text;
            var in_nacion = NacionPList[0];
            var in_fecha = startFer.Date;
            var in_editor = editor.Text;
                Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(in_name,in_conTelf,in_nacion,in_fecha,in_conEmail,"Nivel de Ingles: Avanzado",in_editor), true);
            //Application.Current.MainPage.Navigation.PushModalAsync(new TeflCont(input_conTelf), true);


        }
        void ButtonOcupationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your occupation" };
            ocupation.Children.Add(entry);
        }
    }
}