using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch_and_Shift.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_USERS",
                table: "USERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_USERREVIEW",
                table: "USERREVIEW");

            migrationBuilder.DropPrimaryKey(
                name: "PK_REPORTS_ADMIN",
                table: "REPORTS_ADMIN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_REPORT",
                table: "REPORT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCTS",
                table: "PRODUCTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CATEGORIES",
                table: "CATEGORIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ADMIN",
                table: "ADMIN");

            migrationBuilder.RenameTable(
                name: "USERS",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "USERREVIEW",
                newName: "UserReview");

            migrationBuilder.RenameTable(
                name: "REPORTS_ADMIN",
                newName: "Reports_Admin");

            migrationBuilder.RenameTable(
                name: "REPORT",
                newName: "Report");

            migrationBuilder.RenameTable(
                name: "PRODUCTS",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "CATEGORIES",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "ADMIN",
                newName: "Admin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserReview",
                table: "UserReview",
                column: "review_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports_Admin",
                table: "Reports_Admin",
                column: "report_admin_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                column: "report_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Product_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "categories_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "Admin_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserReview",
                table: "UserReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports_Admin",
                table: "Reports_Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "USERS");

            migrationBuilder.RenameTable(
                name: "UserReview",
                newName: "USERREVIEW");

            migrationBuilder.RenameTable(
                name: "Reports_Admin",
                newName: "REPORTS_ADMIN");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "REPORT");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "PRODUCTS");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CATEGORIES");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "ADMIN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USERS",
                table: "USERS",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_USERREVIEW",
                table: "USERREVIEW",
                column: "review_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_REPORTS_ADMIN",
                table: "REPORTS_ADMIN",
                column: "report_admin_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_REPORT",
                table: "REPORT",
                column: "report_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCTS",
                table: "PRODUCTS",
                column: "Product_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CATEGORIES",
                table: "CATEGORIES",
                column: "categories_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADMIN",
                table: "ADMIN",
                column: "Admin_ID");
        }
    }
}
