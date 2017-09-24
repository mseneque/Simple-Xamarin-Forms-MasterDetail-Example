using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_MasterDetail_Example.Models;
using Simple_MasterDetail_Example.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_MasterDetail_Example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        
        public ProfilePage(User user)
        {
            // Null-coalescing operator,
            // It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.
            BindingContext = user ?? throw new ArgumentNullException();

            InitializeComponent();

        }
    }
}