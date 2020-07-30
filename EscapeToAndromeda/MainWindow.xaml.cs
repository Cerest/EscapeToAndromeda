using System;
using System.Media;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using WMPLib;

namespace EscapeToAndromeda
{
	/// <summary>
	///     Interaction logic for MainWindow.xaml
	/// </summary>
	public sealed partial class MainWindow
	{
		private readonly DispatcherTimer _gameTimer = new DispatcherTimer();

		public MainWindow()
		{
			InitializeComponent();

			var stryPlanetRotation = TryFindResource("PlanetRotation") as Storyboard;
			stryPlanetRotation.Begin();

			PlayMusic("Interstellar");

			//this._gameTimer.Interval = TimeSpan.FromMilliseconds(20);
			//// link the game engine event to the timer
			//this._gameTimer.Tick += this.GameEngine;
			//// start the timer
			//this._gameTimer.Start();
		}

		private static void PlayMusic(string strSoundFileName)
		{
			//var player = new WindowsMediaPlayer
			//			 {
			//				 URL = $@"{Environment.CurrentDirectory}/Resources/{strSoundFileName}.mp3"
			//			 };

			//player.controls.play();

			var player = new MediaPlayer();
			player.Open(new Uri($@"Resources/{strSoundFileName}.mp3", UriKind.Relative));
			player.Play();

			//var player = new SoundPlayer
			//			 {
			//				 SoundLocation = $@"{Environment.CurrentDirectory}/Resources/{strSoundFileName}.wav"
			//			 };
			//player.PlayLooping();
		}

		private void GameEngine(object sender, EventArgs e)
		{
		}

		private void BtnExit_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}