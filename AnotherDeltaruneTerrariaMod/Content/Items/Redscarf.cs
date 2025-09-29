using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnotherDeltaruneTerrariaMod.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Redscarf : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.AnotherDeltaruneTerrariaMod.hjson' file.
		/*
		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Magic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 5);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			
			Item.noMelee = true;  // This makes sure the item does not deal damage from the swinging animation
			Item.noUseGraphic = true; // This makes sure the item does not get shown when the player swings his hand
			
			//ScarfProjectile
			Item.shoot = ModContent.ProjectileType<Scarfwhip>();

		}
		*/
		
		public override void SetDefaults() {
			// Call this method to quickly set some of the properties below.
			//Item.DefaultToWhip(ModContent.ProjectileType<ScarfProjectile>(), 20, 2, 4);

			Item.DamageType = DamageClass.Magic;
			Item.damage = 10;
			Item.knockBack = 2;

			//It's supposed to swing the scarf projectile as a whip but... "It could not be found"
			Item.shoot = ModContent.ProjectileType<Scarfprojectile>();
			Item.shootSpeed = 1;
			Item.value = Item.sellPrice(silver: 5);
			Item.rare = ItemRarityID.Green;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 60;
			Item.UseSound = SoundID.Item152;
			Item.channel = false; // This is used for the charging functionality. Remove it if your whip shouldn't be chargeable.
			Item.noMelee = true;
			Item.noUseGraphic = true;
		}
		
		
		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WhiteString, 1);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
			//I couldn't get this to work. Either, the crafting recipie
/*
		public override void AddRecipes(){
			CreateRecipe();
				.AddIngredient(ItemID.WhiteString, 1);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();
				
			CreateRecipe();
				.AddIngredient(ItemID.Silk, 5);
				.AddIngredient(ItemID.RottenChunk, 5);
				.AddTile(TileID.Anvils);
				.Register();
		}
*/
	}
}
