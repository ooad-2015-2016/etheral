﻿#pragma checksum "C:\Users\User\Desktop\Plizzzz\ethereal\ProjektniZadatak4ethereal\KinoProjekat\KinoProjekat\Kino\Views\OdabirFilma.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D7A51D442D233713F5FC2424435B9867"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinoProjekat.Kino.Views
{
    partial class OdabirFilma : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        private class OdabirFilma_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IOdabirFilma_Bindings
        {
            private global::KinoProjekat.Kino.Models.Film dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;

            public OdabirFilma_obj5_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::KinoProjekat.Kino.Models.Film data = args.NewValue as global::KinoProjekat.Kino.Models.Film;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::KinoProjekat.Kino.Models.Film was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::KinoProjekat.Kino.Models.Film);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::KinoProjekat.Kino.Models.Film) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IOdabirFilma_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // OdabirFilma_obj5_Bindings

            public void SetDataRoot(global::KinoProjekat.Kino.Models.Film newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::KinoProjekat.Kino.Models.Film obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Slika(obj.Slika, phase);
                        this.Update_Naziv(obj.Naziv, phase);
                        this.Update_Link(obj.Link, phase);
                        this.Update_Zanr(obj.Zanr, phase);
                        this.Update_Uloge(obj.Uloge, phase);
                        this.Update_Reziser(obj.Reziser, phase);
                        this.Update_OrginalniNaziv(obj.OrginalniNaziv, phase);
                    }
                }
            }
            private void Update_Slika(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj6, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_Naziv(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                }
            }
            private void Update_Link(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj8, obj, null);
                }
            }
            private void Update_Zanr(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                }
            }
            private void Update_Uloge(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
            private void Update_Reziser(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                }
            }
            private void Update_OrginalniNaziv(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }
        }

        private class OdabirFilma_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IOdabirFilma_Bindings
        {
            private global::KinoProjekat.Kino.Views.OdabirFilma dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj4;

            public OdabirFilma_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IOdabirFilma_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // OdabirFilma_obj1_Bindings

            public void SetDataRoot(global::KinoProjekat.Kino.Views.OdabirFilma newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::KinoProjekat.Kino.Views.OdabirFilma obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Filmovi(obj.Filmovi, phase);
                    }
                }
            }
            private void Update_Filmovi(global::System.Collections.Generic.List<global::KinoProjekat.Kino.Models.Film> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 21 "..\..\..\..\Kino\Views\OdabirFilma.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element2).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 3:
                {
                    this.flipViewPremijere = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 4:
                {
                    this.gridViewPonuda = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 59 "..\..\..\..\Kino\Views\OdabirFilma.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gridViewPonuda).SelectionChanged += this.gridViewPonuda_SelectionChanged;
                    #line default
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 23 "..\..\..\..\Kino\Views\OdabirFilma.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadioButton_Checked_1;
                    #line default
                }
                break;
            case 14:
                {
                    this.checkBoxFilmPoZelji = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 24 "..\..\..\..\Kino\Views\OdabirFilma.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.checkBoxFilmPoZelji).Click += this.checkBoxFilmPoZelji_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    OdabirFilma_obj1_Bindings bindings = new OdabirFilma_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    OdabirFilma_obj5_Bindings bindings = new OdabirFilma_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::KinoProjekat.Kino.Models.Film) element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

