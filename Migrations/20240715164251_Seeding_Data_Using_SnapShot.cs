using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Data_Using_SnapShot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Students(Name,RegisteredOn)
                                    values('Amr Medhat',GETDATE())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from Students where Name = 'Amr Medhat'");
        }
    }
}
