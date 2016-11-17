using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetStarter.Data.Migrations
{
    public partial class trainingcategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveEvents_TrainingCategores_TrainingCategoryId",
                table: "LiveEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingCategores_AspNetUsers_TrainerId",
                table: "TrainingCategores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingCategores",
                table: "TrainingCategores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingCategories",
                table: "TrainingCategores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveEvents_TrainingCategories_TrainingCategoryId",
                table: "LiveEvents",
                column: "TrainingCategoryId",
                principalTable: "TrainingCategores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingCategories_AspNetUsers_TrainerId",
                table: "TrainingCategores",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_TrainingCategores_TrainerId",
                table: "TrainingCategores",
                newName: "IX_TrainingCategories_TrainerId");

            migrationBuilder.RenameTable(
                name: "TrainingCategores",
                newName: "TrainingCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveEvents_TrainingCategories_TrainingCategoryId",
                table: "LiveEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingCategories_AspNetUsers_TrainerId",
                table: "TrainingCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingCategories",
                table: "TrainingCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingCategores",
                table: "TrainingCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveEvents_TrainingCategores_TrainingCategoryId",
                table: "LiveEvents",
                column: "TrainingCategoryId",
                principalTable: "TrainingCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingCategores_AspNetUsers_TrainerId",
                table: "TrainingCategories",
                column: "TrainerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameIndex(
                name: "IX_TrainingCategories_TrainerId",
                table: "TrainingCategories",
                newName: "IX_TrainingCategores_TrainerId");

            migrationBuilder.RenameTable(
                name: "TrainingCategories",
                newName: "TrainingCategores");
        }
    }
}
