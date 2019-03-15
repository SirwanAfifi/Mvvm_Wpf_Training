### WpfApp:
	- Models
	- Views
	- ViewModels


### MVVM:
	- Binding
	- Commanding
	- ,...

### MVVMLight, Prism

### Connecting ViewModel to View
```csharp
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
```
