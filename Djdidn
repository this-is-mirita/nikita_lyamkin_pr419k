public partial class MainWindow : Window 
 { 
 Model1 model = new Model1(); 
 public MainWindow() 
 { 
 InitializeComponent(); 
 
 var fd = model.user.ToList(); 
 data.ItemsSource = fd; 
 var cr = fd[0]; 
 } 
 
 private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) 
 { 
 string searchtext = SearchTextBox.Text; 
 ICollectionView view = CollectionViewSource.GetDefaultView(data.ItemsSource); 
 if (string.IsNullOrEmpty(searchtext)) 
 { 
 view.Filter = null; 
 } 
 else 
 { 
 if ( searchtext != null && data != null && data.ItemsSource != null) 
 { 
 view.Filter = item => 
 { 
 if ( item is user user) 
 { 
 return (user.login?.IndexOf(searchtext) >= 0) || 
 (user.pass?.IndexOf(searchtext) >= 0); 
 } 
 return false; 
 }; 
 } 
 } 
 } 
 private void add_btn_Click(object sender, RoutedEventArgs e) 
 { 
 user newuser = new user(); 
 #region 
 newuser.login = txt_log.Text; 
 newuser.pass = txt_pass.Text; 
 #endregion 
 model.user.Add(newuser); 
 try 
 { 
 model.SaveChanges(); 
 data.ItemsSource = model.user.ToList(); 
 } 
 catch (Exception ex) { } 
 } 
 }
