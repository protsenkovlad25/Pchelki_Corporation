using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pchelki_Corporation.Migrations
{
    public partial class Pchelki_Corporation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bee_Gardens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Home = table.Column<int>(type: "int", nullable: false),
                    Square = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bee_Gardens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Second_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Father_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Home = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Second_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Father_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date_of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Home = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Healings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Square = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Signs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types_of_Beehives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Size_Beehive = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Size_Frame = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Amount_Frame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_of_Beehives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types_of_Bees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Productivity_of_Bees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_of_Bees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types_of_Work",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_of_Work", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Healings_of_Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealingId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healings_of_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Healings_of_Diseases_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Healings_of_Diseases_Healings_HealingId",
                        column: x => x.HealingId,
                        principalTable: "Healings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees_by_Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_by_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_by_Posts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_by_Posts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signs_of_Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signs_of_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signs_of_Diseases_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signs_of_Diseases_Signs_SignId",
                        column: x => x.SignId,
                        principalTable: "Signs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reproduction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Productivity = table.Column<int>(type: "int", nullable: false),
                    Bee_GardenId = table.Column<int>(type: "int", nullable: false),
                    Type_of_BeesId = table.Column<int>(type: "int", nullable: false),
                    Type_of_BeehivesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Families_Bee_Gardens_Bee_GardenId",
                        column: x => x.Bee_GardenId,
                        principalTable: "Bee_Gardens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_Types_of_Beehives_Type_of_BeehivesId",
                        column: x => x.Type_of_BeehivesId,
                        principalTable: "Types_of_Beehives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_Types_of_Bees_Type_of_BeesId",
                        column: x => x.Type_of_BeesId,
                        principalTable: "Types_of_Bees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type_of_WorkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Types_of_Work_Type_of_WorkId",
                        column: x => x.Type_of_WorkId,
                        principalTable: "Types_of_Work",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Solds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Solds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Solds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Solds_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sicks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseId = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sicks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sicks_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sicks_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tabels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Amount_Product = table.Column<int>(type: "int", nullable: false),
                    Date_Event = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabels_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabels_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabels_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabels_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabels_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tabels_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_by_Posts_EmployeeId",
                table: "Employees_by_Posts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_by_Posts_PostId",
                table: "Employees_by_Posts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_Bee_GardenId",
                table: "Families",
                column: "Bee_GardenId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_Type_of_BeehivesId",
                table: "Families",
                column: "Type_of_BeehivesId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_Type_of_BeesId",
                table: "Families",
                column: "Type_of_BeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Healings_of_Diseases_DiseaseId",
                table: "Healings_of_Diseases",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Healings_of_Diseases_HealingId",
                table: "Healings_of_Diseases",
                column: "HealingId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Solds_ProductId",
                table: "Product_Solds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Solds_SaleId",
                table: "Product_Solds",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientId",
                table: "Sales",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sicks_DiseaseId",
                table: "Sicks",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sicks_FamilyId",
                table: "Sicks",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Signs_of_Diseases_DiseaseId",
                table: "Signs_of_Diseases",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Signs_of_Diseases_SignId",
                table: "Signs_of_Diseases",
                column: "SignId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_EmployeeId",
                table: "Tabels",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_EquipmentId",
                table: "Tabels",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_FamilyId",
                table: "Tabels",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_ProductId",
                table: "Tabels",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_RoomId",
                table: "Tabels",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tabels_WorkId",
                table: "Tabels",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_Type_of_WorkId",
                table: "Works",
                column: "Type_of_WorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees_by_Posts");

            migrationBuilder.DropTable(
                name: "Healings_of_Diseases");

            migrationBuilder.DropTable(
                name: "Product_Solds");

            migrationBuilder.DropTable(
                name: "Sicks");

            migrationBuilder.DropTable(
                name: "Signs_of_Diseases");

            migrationBuilder.DropTable(
                name: "Tabels");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Healings");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Signs");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Bee_Gardens");

            migrationBuilder.DropTable(
                name: "Types_of_Beehives");

            migrationBuilder.DropTable(
                name: "Types_of_Bees");

            migrationBuilder.DropTable(
                name: "Types_of_Work");
        }
    }
}
