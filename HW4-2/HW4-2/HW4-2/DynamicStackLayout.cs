using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HW4_2
{
  public class DynamicStackLayout : StackLayout
  {
    public DynamicStackLayout() : base() { }

    public IEnumerable ItemsSource
    {
      get { return (IEnumerable)GetValue(ItemsSourceProperty); }
      set { SetValue(ItemsSourceProperty, value); }
    }
    public static readonly BindableProperty ItemsSourceProperty =
      BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(DynamicStackLayout),
                              propertyChanged: (bindable, oldValue, newValue) => ((DynamicStackLayout)bindable).PopulateItems());

    public DataTemplate ItemDataTemplate
    {
      get { return (DataTemplate)GetValue(ItemDataTemplateProperty); }
      set { SetValue(ItemDataTemplateProperty, value); }
    }
    public static readonly BindableProperty ItemDataTemplateProperty =
      BindableProperty.Create(nameof(ItemDataTemplate), typeof(DataTemplate), typeof(DynamicStackLayout));

    private void PopulateItems()
    {
      Children.Clear();

      if (ItemsSource == null) return;

      foreach (var item in ItemsSource)
      {
        var itemTemplate = ItemDataTemplate.CreateContent() as View;
        itemTemplate.BindingContext = item;
        Children.Add(itemTemplate);
      }
    }
  }
}
