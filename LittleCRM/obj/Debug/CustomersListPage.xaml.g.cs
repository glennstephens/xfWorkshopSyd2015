// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LittleCRM {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class CustomersListPage : ContentPage {
        
        private ToolbarItem addCustomer;
        
        private ListView allCustomers;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(CustomersListPage));
            addCustomer = this.FindByName <ToolbarItem>("addCustomer");
            allCustomers = this.FindByName <ListView>("allCustomers");
        }
    }
}
