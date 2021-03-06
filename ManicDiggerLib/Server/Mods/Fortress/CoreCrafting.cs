﻿using System;

namespace ManicDigger.Mods
{
    /// <summary>
    /// This class contains all crafting recipes
    /// </summary>
    public class CoreCrafting : IMod
    {
        public void PreStart(ModManager m)
        {
            m.RequireMod("CoreBlocks");
        }
        public void Start(ModManager m)
        {
            /* Crafting recipes are given in the following style:
             * 
             * m.AddCraftingRecipe ("Result", 1, "Ingredient_1", 1);
             * m.AddCraftingRecipe2("Result", 1, "Ingredient_1", 1, "Ingredient_2", 1);
             * m.AddCraftingRecipe3("Result", 1, "Ingredient_1", 1, "Ingredient_2", 1, "Ingredient_3", 1);
             */
            
            m.AddCraftingRecipe("Cobblestone", 1, "Stone", 2);
            m.AddCraftingRecipe("Stone", 2, "Cobblestone", 1);
            m.AddCraftingRecipe("Wood", 2, "TreeTrunk", 1);
            m.AddCraftingRecipe("Brick", 1, "Stone", 4);
            m.AddCraftingRecipe("CraftingTable", 1, "Wood", 3);
            m.AddCraftingRecipe("Stair", 1, "Stone", 2);
            m.AddCraftingRecipe("DoubleStair", 1, "Stone", 2);
            m.AddCraftingRecipe("Glass", 1, "Sand", 2);
            m.AddCraftingRecipe("RedRoseDecorations", 1, "Leaves", 10);
            m.AddCraftingRecipe("YellowFlowerDecorations", 1, "Leaves", 10);
            m.AddCraftingRecipe("Sapling", 1, "Leaves", 3);
            m.AddCraftingRecipe("RedMushroom", 1, "Dirt", 10);
            m.AddCraftingRecipe("BrownMushroom", 1, "Dirt", 10);
            m.AddCraftingRecipe("RedMushroom", 1, "Grass", 10);
            m.AddCraftingRecipe("BrownMushroom", 1, "Grass", 10);
            m.AddCraftingRecipe("Bookcase", 1, "Wood", 2);
            m.AddCraftingRecipe("MossyCobblestone", 1, "Cobblestone", 1);
            m.AddCraftingRecipe("Cobblestone", 1, "MossyCobblestone", 1);
            m.AddCraftingRecipe("Sponge", 1, "GoldBlock", 1);
            m.AddCraftingRecipe("RedCloth", 1, "GoldBlock", 1);
            m.AddCraftingRecipe("OrangeCloth", 1, "RedCloth", 1);
            m.AddCraftingRecipe("YellowCloth", 1, "OrangeCloth", 1);
            m.AddCraftingRecipe("LightGreenCloth", 1, "YellowCloth", 1);
            m.AddCraftingRecipe("GreenCloth", 1, "LightGreenCloth", 1);
            m.AddCraftingRecipe("AquaGreenCloth", 1, "GreenCloth", 1);
            m.AddCraftingRecipe("CyanCloth", 1, "AquaGreenCloth", 1);
            m.AddCraftingRecipe("BlueCloth", 1, "CyanCloth", 1);
            m.AddCraftingRecipe("PurpleCloth", 1, "BlueCloth", 1);
            m.AddCraftingRecipe("IndigoCloth", 1, "PurpleCloth", 1);
            m.AddCraftingRecipe("VioletCloth", 1, "IndigoCloth", 1);
            m.AddCraftingRecipe("MagentaCloth", 1, "VioletCloth", 1);
            m.AddCraftingRecipe("PinkCloth", 1, "MagentaCloth", 1);
            m.AddCraftingRecipe("BlackCloth", 1, "PinkCloth", 1);
            m.AddCraftingRecipe("GrayCloth", 1, "BlackCloth", 1);
            m.AddCraftingRecipe("WhiteCloth", 1, "GrayCloth", 1);
            m.AddCraftingRecipe("RedCloth", 1, "WhiteCloth", 1);
            m.AddCraftingRecipe("Roof", 1, "Brick", 2);
            m.AddCraftingRecipe("ChemicalGreen", 1, "GoldBlock", 1);
            m.AddCraftingRecipe("Camouflage", 1, "GoldBlock", 1);
            m.AddCraftingRecipe("DirtForFarming", 1, "Dirt", 2);
            m.AddCraftingRecipe("DirtForFarming", 1, "Grass", 2);
            m.AddCraftingRecipe("Crops1", 2, "Crops4", 1);
            m.AddCraftingRecipe("Minecart", 1, "BrushedMetal", 5);
            m.AddCraftingRecipe("Salt", 1, "Crops4", 2);
            m.AddCraftingRecipe("LuxuryRoof", 1, "Roof", 2);
            m.AddCraftingRecipe("Fence", 1, "TreeTrunk", 2);
            m.AddCraftingRecipe("Hay", 1, "Crops4", 4);
            m.AddCraftingRecipe("SilverCoin", 1, "SilverOre", 1);
            m.AddCraftingRecipe("SilverCoin", 30, "GoldCoin", 1);
            m.AddCraftingRecipe("GoldCoin", 30, "GoldBar", 1);
            m.AddCraftingRecipe("Ladder", 1, "Wood", 4);
            
            m.AddCraftingRecipe2("GoldBlock", 1, "CoalOre", 1, "GoldOre", 1);
            m.AddCraftingRecipe2("IronBlock", 1, "CoalOre", 1, "IronOre", 1);
            m.AddCraftingRecipe2("Rail3", 4, "Wood", 1, "IronBlock", 1);
            m.AddCraftingRecipe2("Rail60", 2, "Wood", 1, "IronBlock", 1);
            m.AddCraftingRecipe2("Trampoline", 1, "BrushedMetal", 1, "Wood", 1);
            m.AddCraftingRecipe2("Torch", 1, "Wood", 1, "CoalOre", 1);
            m.AddCraftingRecipe2("GrassTrap", 1, "Dirt", 10, "Camouflage", 5);
            m.AddCraftingRecipe2("Sapling", 10, "Apples", 5, "DirtForFarming", 1);
            m.AddCraftingRecipe2("DirtBrick", 1, "Dirt", 2, "Stone", 1);
            m.AddCraftingRecipe2("BrushedMetal", 1, "IronBlock", 1, "CoalOre", 1);
            m.AddCraftingRecipe2("SandBrick", 1, "Sand", 1, "Stone", 2);
            m.AddCraftingRecipe2("FakeBookcase", 1, "Bookcase", 1, "Camouflage", 5);
            m.AddCraftingRecipe2("WoodDesk", 1, "Wood", 2, "TreeTrunk", 1);
            m.AddCraftingRecipe2("GlassDesk", 1, "Glass", 2, "TreeTrunk", 1);
            m.AddCraftingRecipe2("Asphalt", 1, "CoalOre", 1, "Gravel", 2);
            m.AddCraftingRecipe2("Cake", 1, "Salt", 2, "Crops4", 4);
            m.AddCraftingRecipe2("Fire", 1, "TreeTrunk", 1, "Torch", 1);
            m.AddCraftingRecipe2("GoldBar", 1, "GoldCoin", 25, "GoldBlock", 5);
            m.AddCraftingRecipe2("GoldCoin", 1, "SilverCoin", 25, "GoldOre", 5);
            
            m.AddCraftingRecipe3("Mosaik", 1, "Sand", 2, "Gravel", 1, "Stone", 1);
        }
    }
}