using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStoreRewards.Data.Migrations
{
    public partial class seedInformationWithShoppingListAddedIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "ShoppingLists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "ShoppingLists");
        }
    }
}
