using Avalonia.Controls;
using ControlCatalog.Models;

namespace ControlCatalog.Pages
{
    public partial class LabelsPage : UserControl
    {
        public LabelsPage()
        {
            CreateDefaultPerson();
            this.InitializeComponent();
        }

        private void CreateDefaultPerson()
        {
            DataContext = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                IsBanned = true,
            };
        }

        public void DoSave()
        {
            
        }
        public void DoCancel()
        {
            CreateDefaultPerson();
        }
    }
}
