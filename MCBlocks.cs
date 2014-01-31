using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace ManicDigger.Mods
{
    public class MCBlocks : IMod
    {
        public void PreStart(ModManager m)
        {
		
        }
        public void Start(ModManager m)
        {
            this.m = m;
			m.RegisterOnLoad(OnLoad);
			m.SetBlockType(380, "MC_Brick", new BlockType()
            {
                AllTextures = "MC_Brick",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(381, "MC_CoalOre", new BlockType()
            {
                AllTextures = "MC_CoalOre",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(382, "MC_CobbleStone", new BlockType()
            {
                AllTextures = "MC_CobbleStone",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(383, "MC_DiamondBlock", new BlockType()
            {
                AllTextures = "MC_DiamondBlock",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(384, "MC_DoubleStair", new BlockType()
                    {
                        TextureIdTop = "MC_Stair",
                        TextureIdBack = "MC_DoubleStairSide",
                        TextureIdFront = "MC_DoubleStairSide",
                        TextureIdLeft = "MC_DoubleStairSide",
                        TextureIdRight = "MC_DoubleStairSide",
                        TextureIdForInventory = "MC_DoubleStairSide",
                        TextureIdBottom = "MC_Stair",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(385, "MC_EndStone", new BlockType()
            {
                AllTextures = "MC_EndStone",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(386, "MC_GoldOre", new BlockType()
            {
                AllTextures = "MC_GoldOre",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(387, "MC_Grass", new BlockType()
                    {
                        TextureIdTop = "MC_Grass",
                        TextureIdBack = "MC_GrassSide",
                        TextureIdFront = "MC_GrassSide",
                        TextureIdLeft = "MC_GrassSide",
                        TextureIdRight = "MC_GrassSide",
                        TextureIdForInventory = "MC_GrassSide",
                        TextureIdBottom = "MC_Dirt",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(388, "MC_Gravel", new BlockType()
            {
                AllTextures = "MC_Gravel",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(389, "MC_IronBars", new BlockType()
                    {
                        TextureIdBack = "MC_IronBars",
                        TextureIdFront = "MC_IronBars",
                        TextureIdLeft = "MC_IronBars",
                        TextureIdRight = "MC_IronBars",
                        TextureIdForInventory = "MC_IronBars",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(390, "MC_IronBlock", new BlockType()
            {
                AllTextures = "MC_IronBlock",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(391, "ProtectiveGlass", new BlockType()
            {
                AllTextures = "MC_Glass",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                IsBuildable = false,
                
            });
			m.SetBlockType(392, "MC_MossyCobblestone", new BlockType()
            {
                AllTextures = "MC_MossyCobblestone",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(393, "MC_NetherBrick", new BlockType()
            {
                AllTextures = "MC_NetherBrick",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(394, "MC_NetherRack", new BlockType()
            {
                AllTextures = "MC_NetherRack",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(395, "MC_Obsidian", new BlockType()
            {
                AllTextures = "MC_Obsidian",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(396, "MC_Sand", new BlockType()
            {
                AllTextures = "MC_Sand",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(397, "MC_Sandstone", new BlockType()
            {
                AllTextures = "MC_Sandstone",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(398, "MC_Stair", new BlockType()
            {
                AllTextures = "MC_Stair",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(399, "MC_Stone", new BlockType()
            {
                AllTextures = "MC_Stone",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(400, "MC_StoneBrick", new BlockType()
            {
                AllTextures = "MC_StoneBrick",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(401, "MC_TNT", new BlockType()
                    {
                        TextureIdTop = "MC_TNTTop",
                        TextureIdBack = "MC_TNT",
                        TextureIdFront = "MC_TNT",
                        TextureIdLeft = "MC_TNT",
                        TextureIdRight = "MC_TNT",
                        TextureIdForInventory = "MC_TNT",
                        TextureIdBottom = "MC_TNTBottom",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(402, "MC_TreeTrunk", new BlockType()
                    {
                        TextureIdTop = "MC_TreeTrunkTopBottom",
                        TextureIdBack = "MC_TreeTrunk",
                        TextureIdFront = "MC_TreeTrunk",
                        TextureIdLeft = "MC_TreeTrunk",
                        TextureIdRight = "MC_TreeTrunk",
                        TextureIdForInventory = "MC_TreeTrunk",
                        TextureIdBottom = "MC_TreeTrunkTopBottom",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(403, "MC_WinterGrass", new BlockType()
            {
                AllTextures = "MC_WinterGrass",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(404, "MC_Wood", new BlockType()
            {
                AllTextures = "MC_Wood",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(405, "MC_Dirt", new BlockType()
                    {
                        TextureIdTop = "MC_Dirt",
                        TextureIdBack = "MC_Dirt",
                        TextureIdFront = "MC_Dirt",
                        TextureIdLeft = "MC_Dirt",
                        TextureIdRight = "MC_Dirt",
                        TextureIdForInventory = "MC_Dirt",
                        TextureIdBottom = "MC_Dirt",
                        DrawType = DrawType.Solid,
                        WalkableType = WalkableType.Solid,
                        
                    });
			m.SetBlockType(406, "MC_CraftingTable", new BlockType()
            {
                AllTextures = "MC_CraftingTable",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(407, "MC_Glass", new BlockType()
            {
                AllTextures = "MC_Glass",
                DrawType = DrawType.Transparent,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(408, "MC_GoldBlock", new BlockType()
            {
                AllTextures = "MC_GoldBlock",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(409, "MC_Adminium", new BlockType()
            {
                AllTextures = "MC_Adminium",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			m.SetBlockType(410, "MC_Bookcase", new BlockType()
            {
                AllTextures = "MC_Bookcase",
                DrawType = DrawType.Solid,
                WalkableType = WalkableType.Solid,
                
            });
			
			m.AddToCreativeInventory("MC_Adminium");
			m.AddToCreativeInventory("MC_Bookcase");
			m.AddToCreativeInventory("MC_Brick");
			m.AddToCreativeInventory("MC_CoalOre");
			m.AddToCreativeInventory("MC_CobbleStone");
			m.AddToCreativeInventory("MC_CraftingTable");
			m.AddToCreativeInventory("MC_DiamondBlock");
			m.AddToCreativeInventory("MC_Dirt");
			m.AddToCreativeInventory("MC_DoubleStair");
			m.AddToCreativeInventory("MC_EndStone");
			m.AddToCreativeInventory("MC_Glass");
			m.AddToCreativeInventory("MC_GoldBlock");
			m.AddToCreativeInventory("MC_GoldOre");
			m.AddToCreativeInventory("MC_Grass");
			m.AddToCreativeInventory("MC_MossyCobblestone");
			m.AddToCreativeInventory("MC_NetherBrick");
			m.AddToCreativeInventory("MC_Obsidian");
			m.AddToCreativeInventory("MC_Sand");
			m.AddToCreativeInventory("MC_Sandstone");
			m.AddToCreativeInventory("MC_Stair");
			m.AddToCreativeInventory("MC_Stone");
			m.AddToCreativeInventory("MC_StoneBrick");
			m.AddToCreativeInventory("MC_TNT");
			m.AddToCreativeInventory("MC_TreeTrunk");
			m.AddToCreativeInventory("MC_WinterGrass");
			m.AddToCreativeInventory("MC_Wood");
			m.AddToCreativeInventory("MC_IronBlock");
			
            m.AddCraftingRecipe("MC_WinterGrass", 5, "Dirt", 1);
			m.AddCraftingRecipe("MC_Dirt", 10, "Dirt", 1);
			m.AddCraftingRecipe("MC_Grass", 5, "Dirt", 1);
			m.AddCraftingRecipe("MC_CobbleStone", 1, "Stone", 2);
			m.AddCraftingRecipe("MC_TNT", 1, "Stone", 2);
			//m.AddCraftingRecipe("water", 5, "ChemicalGreen", 1);
            m.AddCraftingRecipe2("MC_Obsidian", 1, "Lava", 1, "Water", 1);
			m.AddCraftingRecipe("MC_EndStone", 1, "Stone", 2);
            m.AddCraftingRecipe("MC_Stone", 2, "Cobblestone", 1);
            m.AddCraftingRecipe("MC_Wood", 2, "TreeTrunk", 1);
            m.AddCraftingRecipe("MC_Brick", 1, "Stone", 4);
			m.AddCraftingRecipe("MC_Stone", 1, "Stone", 1);
			m.AddCraftingRecipe("MC_Adminium", 1, "Stone", 1);
			m.AddCraftingRecipe("MC_StoneBrick", 1, "Stone", 4);
			m.AddCraftingRecipe("MC_NetherBrick", 1, "Stone", 4);
            m.AddCraftingRecipe2("MC_GoldBlock", 1, "CoalOre", 1, "GoldOre", 1);
            m.AddCraftingRecipe2("MC_IronBlock", 1, "CoalOre", 1, "IronOre", 1);
			m.AddCraftingRecipe2("MC_DiamondBlock", 1, "CoalOre", 1, "IronOre", 1);
            m.AddCraftingRecipe("MC_CraftingTable", 1, "Wood", 3);
            m.AddCraftingRecipe("MC_Stair", 1, "Stone", 2);
            m.AddCraftingRecipe("MC_DoubleStair", 1, "Stone", 2);
            m.AddCraftingRecipe("MC_Glass", 1, "Sand", 2);
			m.AddCraftingRecipe("MC_Sandstone", 10, "Sand", 2);
            m.AddCraftingRecipe("MC_Bookcase", 1, "Wood", 2);
            m.AddCraftingRecipe("MC_CobbleStone", 1, "Cobblestone", 1);
            m.AddCraftingRecipe("MC_MossyCobblestone", 1, "MossyCobblestone", 1);
			m.AddCraftingRecipe("Sign", 1, "Wood", 2);
        }
        ModManager m;
		void OnLoad ()
		{
			m.SendMessageToAll("&eReady Freddy!");
		}
	}
}
