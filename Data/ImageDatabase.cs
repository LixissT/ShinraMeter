﻿using System;
using System.Drawing;
using System.Windows.Media.Imaging;
using Image = System.Windows.Controls.Image;

namespace Data
{
    public class ImageDatabase
    {
        public ImageDatabase(string folder)
        {
            EntityStats = new Image {Source = new BitmapImage(new Uri(folder + "stats.png"))};
            EntityStatsClickThrou = new Image {Source = new BitmapImage(new Uri(folder + "stats_click_throu.png"))};
            Chrono = new Image {Source = new BitmapImage(new Uri(folder + "chrono.png"))};
            Chronobar = new Image {Source = new BitmapImage(new Uri(folder + "chronobar.png"))};
            Close = new Image {Source = new BitmapImage(new Uri(folder + "close.png"))};
            History = new Image {Source = new BitmapImage(new Uri(folder + "historic.png"))};
            Copy = new Image {Source = new BitmapImage(new Uri(folder + "copy.png"))};
            Config = new Image {Source = new BitmapImage(new Uri(folder + "config.png"))};
            Chat = new Image {Source = new BitmapImage(new Uri(folder + "chat.png"))};
            Link = new Image {Source = new BitmapImage(new Uri(folder + "link.png"))};
            Enraged = new Image {Source = new BitmapImage(new Uri(folder + "enraged.png"))};
            BossGage = new Image {Source = new BitmapImage(new Uri(folder + "eye.png"))};
            Whisper = new Image { Source = new BitmapImage(new Uri(folder + "whisper.png")) };
            Info = new Image { Source = new BitmapImage(new Uri(folder + "info.png")) };
            DoneCircle = new Image { Source = new BitmapImage(new Uri(folder + "done_circle.png")) };
            Group = new Image { Source = new BitmapImage(new Uri(folder + "group.png")) };
            GroupAdd = new Image { Source = new BitmapImage(new Uri(folder + "group_add.png")) };
            Money = new Image { Source = new BitmapImage(new Uri(folder + "money.png")) };
            Credits = new Image { Source = new BitmapImage(new Uri(folder + "credits.png")) };


            Icon = new BitmapImage(new Uri(folder + "shinra.ico"));

            Tray = new Icon(folder + "shinra.ico");
        }

        public BitmapImage Icon { get; }
        public Image Chrono { get; }
        public Image Link { get; }

        public Image Copy { get; }
        public Image Config { get; }
        public Image Chat { get; }
        public Image BossGage { get; }

        public Image History { get; }
        public Image Close { get; }

        public Image Chronobar { get; }

        public Image EntityStats { get; }
        public Image Enraged { get; }
        public Image EntityStatsClickThrou { get; }

        public Image Whisper { get; }
        public Image Info { get; }
        public Image DoneCircle { get; }
        public Image Group { get; }
        public Image GroupAdd { get; }
        public Image Money { get; }
        public Image Credits { get; }

        public Icon Tray { get; }
    }
}