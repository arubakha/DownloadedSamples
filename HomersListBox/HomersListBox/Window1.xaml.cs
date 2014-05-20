using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace HomersListBox
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : System.Windows.Window
    {

        public Window1()
        {
            InitializeComponent();
        }

    }

public class CharacterTemplateSelector : DataTemplateSelector
{
    private DataTemplate _childTemplate = null;
    public DataTemplate ChildTemplate
    {
        get { return _childTemplate; }
        set { _childTemplate = value; }
    }

    private DataTemplate _adultTemplate = null;
    public DataTemplate AdultTemplate
    {
        get { return _adultTemplate; }
        set { _adultTemplate = value; }
    }
    
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (item is Character)
        {
            return (item as Character).Age >= 21 ? _adultTemplate : _childTemplate;
        }
        return base.SelectTemplate(item, container);
    }
}
}