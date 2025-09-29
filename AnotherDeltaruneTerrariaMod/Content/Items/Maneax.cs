using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnotherDeltaruneTerrariaMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Maneax : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.AnotherDeltaruneTerrariaMod.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 22;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 8;
			Item.value = Item.sellPrice(silver: 5);
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		
		
		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CopperAxe, 1);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
		
		
		//I couldn't get this to work. It's the crafting recipie
/*
		public override void AddRecipes(){
			CreateRecipe();
				.AddIngredient(ItemID.Paintbrush, 1);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();
			
			CreateRecipe();
				.AddIngredient(ItemID.CopperAxe, 1);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();
		}
*/
	}
}
