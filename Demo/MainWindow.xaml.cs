using System.Windows;
using System.Windows.Media;

namespace Demo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			Close.Source    = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.Close     ];
			Minimize.Source = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.Minimize  ];
			Maximize.Source = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.Maximize  ];
			Restore.Source  = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.Restore   ];
			Help.Source     = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.Help      ];
			Up.Source       = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.UpArrow   ];
			Down.Source     = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.DownArrow ];
			Left.Source     = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.LeftArrow ];
			Right.Source    = Bitmaps.Instance[32, Colors.Black, Colors.White, BitmapType.RightArrow];
		}
	}
}
