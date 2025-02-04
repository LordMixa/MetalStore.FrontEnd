﻿using MetalStore.FrontEnd.Core.Enums;

namespace MetalStore.FrontEnd.UI.ViewModels;

public class ClothingItemViewModel
{
    public int PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Brand { get; set; }
}
