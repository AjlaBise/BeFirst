﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Ponude,
        Zahtjev,
        Odgovori
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
