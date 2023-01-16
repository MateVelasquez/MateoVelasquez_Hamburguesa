namespace MateoVelasquez_Hamburguesa.Views;
using MateoVelasquez_Hamburguesa.Models;
using System.Collections.Generic;


public partial class MV_BurgerItemPage : ContentPage
{
    MV_Burger Item = new MV_Burger();
    bool _flag;

    public MV_BurgerItemPage()
	{
        InitializeComponent();
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.MV_Name = MV_Name.Text;
        Item.MV_Description = MV_Description.Text;
        Item.MV_WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    
    private void OnCheckBoxCheckedChanged(object sender,CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
}