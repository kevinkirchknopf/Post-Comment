using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Post_Comment_Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Post_Comment_Wpf
{
    /// <summary>
    /// Interaction logic for Posts.xaml
    /// </summary>
    public partial class Posts : UserControl
    {
        public Posts()
        {
            postslist.DataContext = App.Current.Services.GetRequiredService<AppServices>().GetPosts();
            InitializeComponent();
        }
    }
}
