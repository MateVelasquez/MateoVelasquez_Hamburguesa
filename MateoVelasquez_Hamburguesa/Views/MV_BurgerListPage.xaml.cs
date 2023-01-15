
using MateoVelasquez_Hamburguesa.Models;
using System.Collections.Generic;

namespace MateoVelasquez_Hamburguesa.Views;

public partial class MV_BurgerListPage : ContentPage
{
	public MV_BurgerListPage()
	{
		InitializeComponent();
        List<MV_Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerListMV.ItemsSource = burger;
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MV_BurgerItemPage));
    }
}