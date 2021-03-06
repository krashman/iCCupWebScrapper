﻿using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace iCCup.DATA.Models
{
    public class PersonalGameDetails
    {
        public string MatchUrl { get; set; } //+
        public string GameName { get; set; } //+
        public string DateTime { get; set; } //+
        public string GameTime { get; set; } //+

        public int Kills { get; set; } //+
        public int Deaths { get; set; } //+
        public int Assists { get; set; } //+

        public int CreepStats { get; set; } //+
        public int TowersDestroyed { get; set; } //+
        public int GoldLeft { get; set; } //+

        public MatchResult MatchResult { get; set; } //+
        public GameSide GameSide { get; set; } //+
        public int Pts { get; set; } //+
        public int? BonusPts { get; set; }

        public BitmapImage Hero { get; set; } //+
        public string HeroName { get; set; } //+
        public List<Item> Items { get; set; } //+
    }

    public class Item
    {
        public BitmapImage Image { get; set; }

        public Item(BitmapImage image)
        {
            this.Image = image;
        }
    }
}
