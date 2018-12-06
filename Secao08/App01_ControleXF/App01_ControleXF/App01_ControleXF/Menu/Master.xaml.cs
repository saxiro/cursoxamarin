using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App01_ControleXF.Controles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}
        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new ActivityIndicatorPage();
        }
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new ProgressBarPage();
        }
        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new BoxViewPage();
        }
        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new LabelPage();
        }
        private void GoButtonPage(object sender, EventArgs args)
        {
            Detail = new ButtonPage();
        }
        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new EntryEditorPage();
        }
        private void GoDatePickerPage(object sender, EventArgs args)
        {
            Detail = new DatePickerPage();
        }
        private void GoTimePickerPage(object sender, EventArgs args)
        {
            Detail = new TimePickerPage();
        }
        private void GoPickerPage(object sender, EventArgs args)
        {
            Detail = new PickerPage();
        }
        private void GoSearchBarPage(object sender, EventArgs args)
        {
            Detail = new SearchBarPage();
        }
        private void GoSliderStepperPage(object sender, EventArgs args)
        {
            Detail = new SliderStepperPage();
        }
        private void GoSwitchPage(object sender, EventArgs args)
        {
            Detail = new SwitchPage();
        }
        private void GoImagePage(object sender, EventArgs args)
        {
            Detail = new ImagePage();
        }
        private void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new ListViewPage();
        }
        private void GoTableViewPage(object sender, EventArgs args)
        {
            Detail = new TableViewPage();
        }
        

    }
}