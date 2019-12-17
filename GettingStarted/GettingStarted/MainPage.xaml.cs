using Syncfusion.XForms.Accordion;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
	public partial class MainPage : ContentPage
	{
        SfAccordion accordion;
		public MainPage()
		{
			InitializeComponent();
            accordion = new SfAccordion();
		}
	}
}
