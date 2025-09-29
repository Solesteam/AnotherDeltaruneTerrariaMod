using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnotherDeltaruneTerrariaMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Woodblade : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.AnotherDeltaruneTerrariaMod.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 17;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 3;
			Item.value = Item.sellPrice(silver: 5);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		
		
		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
		
		//I'll be completely honest, I have no idea what I'm doing here, just following ExampleMod blindly.
/*
		public override void AddRecipes(){
			CreateRecipe();
				.AddIngredient(ItemID.WoodenSword, 1);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();

			CreateRecipe();
				.AddIngredient(ItemID.CopperShortsword, 1);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();
		}
*/
	}
}
