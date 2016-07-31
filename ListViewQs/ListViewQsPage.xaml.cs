using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListViewQs
{
	public partial class ListViewQsPage : ContentPage
	{
		public ListViewQsPage()
		{
			InitializeComponent();

			var vm = new ListViewQsViewModel()
			{
				Items = new ListItemModel[] { 
					new ListItemModel {
						Title = "Title 1"
					},
					new ListItemModel {
						Title = "Title 2"
					},
					new ListItemModel {
						Title = "Title 3"
					},
					new ListItemModel {
						Title = "Title 4"
					},
					new ListItemModel {
						Title = "Title 5"
					},
					new ListItemModel {
						Title = "Title 6"
					},
					new ListItemModel {
						Title = "Title 7"
					}
				}
			};

			BindingContext = vm;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var clickedButton = sender as Button;

			var item = clickedButton.BindingContext as ListItemModel;

			//Handle item clicked on button inside template
		}
	}

	public class ListViewQsViewModel
	{
		public ListItemModel[] Items
		{
			get;
			set;
		}

		public Command<ListItemModel> ItemClickCommand { 
			get {
				return new Command<ListItemModel>((item) => { 
					//Handle item clicked on button inside template
				});
			}
		}
	}

	public class ListItemModel
	{
		public string Title
		{
			get;
			set;
		}
	}
}

