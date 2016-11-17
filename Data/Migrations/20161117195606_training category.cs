using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetStarter.Data.Migrations
{
    public partial class trainingcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingCategores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TrainerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCategores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCategores_AspNetUsers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<long>(
                name: "TrainingCategoryId",
                table: "LiveEvents",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileDescription",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrainerId",
                table: "LiveEvents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LiveEvents_TrainerId",
                table: "LiveEvents",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_LiveEvents_TrainingCategoryId",
                table: "LiveEvents",
                column: "TrainingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCategores_TrainerId",
                table: "TrainingCategores",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveEvents_AspNetUsers_TrainerId",
                table: "LiveEvents",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveEvents_TrainingCategores_TrainingCategoryId",
                table: "LiveEvents",
                column: "TrainingCategoryId",
                principalTable: "TrainingCategores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveEvents_AspNetUsers_TrainerId",
                table: "LiveEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_LiveEvents_TrainingCategores_TrainingCategoryId",
                table: "LiveEvents");

            migrationBuilder.DropIndex(
                name: "IX_LiveEvents_TrainerId",
                table: "LiveEvents");

            migrationBuilder.DropIndex(
                name: "IX_LiveEvents_TrainingCategoryId",
                table: "LiveEvents");

            migrationBuilder.DropColumn(
                name: "TrainingCategoryId",
                table: "LiveEvents");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileDescription",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TrainingCategores");

            migrationBuilder.AlterColumn<string>(
                name: "TrainerId",
                table: "LiveEvents",
                nullable: true);
        }
    }
}
