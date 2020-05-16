using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace relc.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamAttemptAnswers");

            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "ExamAttempts");

            migrationBuilder.CreateTable(
                name: "Attempts",
                columns: table => new
                {
                    AttemptId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamId = table.Column<int>(nullable: false),
                    LoginId = table.Column<int>(nullable: false),
                    TimeTaken = table.Column<short>(nullable: false),
                    Score = table.Column<short>(nullable: false),
                    Grade = table.Column<decimal>(nullable: false),
                    GradeRounded = table.Column<short>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempts", x => x.AttemptId);
                    table.ForeignKey(
                        name: "FK_Attempts_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attempts_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Options = table.Column<string>(maxLength: 1000, nullable: true),
                    Answer = table.Column<string>(maxLength: 100, nullable: false),
                    Score = table.Column<short>(nullable: false),
                    IsOptional = table.Column<bool>(nullable: false),
                    AlwaysAppear = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttemptAnswers",
                columns: table => new
                {
                    AttemptAnswerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttemptId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(maxLength: 100, nullable: false),
                    Score = table.Column<short>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttemptAnswers", x => x.AttemptAnswerId);
                    table.ForeignKey(
                        name: "FK_AttemptAnswers_Attempts_AttemptId",
                        column: x => x.AttemptId,
                        principalTable: "Attempts",
                        principalColumn: "AttemptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttemptAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOKFVzPJ3//0d2Z1VRuhyLtmvsDGMWkiPxIUWQFIlr/UnmnpQi/BCLNmxw2jbAF9KQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELA8IP0JWL2um0wawfSguydOQJH/k975bEnCrxYhKNPUHbh5wsDGCFue9xHhIRX8bg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIjrOIfeY9GfS8m8n8CPa81l5XTkIS9jMrjZYX5HKrAla7ddhHJTy+RIfxe0qWhllA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAhPSm7hyqEes3GGtfq8kpzgoNn1PE6AJOfzc2xqqqQPKloeWXIiaanT/cEVnTy94Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 5,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIkDWmj04hs7nsb/wi1iM7Ncw4pzGXFioVCUhG05cO43GznhZAz/M4p67LbsitfjvQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 6,
                column: "Password",
                value: "AQAAAAEAACcQAAAAED5jC8s1ZZi9XPZfKDURR36t4Y1KaO2k7qKiiSYlcAHD+2a8S/yGnjdPe6pDNomycg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 7,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELVv1kPE/8nNwkcAsVvjqSd4lhb3LJ4tfyOYKn8+Agj1iGtBHXVmr7dMrwRcKJEsoQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 8,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENp3Yo7P/PCD6j+cGdRIuW09poc0gz7WEW63o+6hsIbet+Ik60XKS0hKrrz6w6BKrg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 9,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHA1buzuCM9+f4T5pPz+GaV5wxkaUBUoXxIu0mKpmzF6w3Gf2v7ghXj2JrYO6V7Log==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 10,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFeQP8ayR4dwCjofjlQD7Fwii9+LmeT/IxdXQEVn1dYLBkrMxexBYv47aUlMhlJcSQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 11,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEpuPiqoetqrwFOEhgrAZMHXvBx2/etwi5FX2ikV6RmTpe2jeGCTElcA5L3jfDsqzQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 12,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPkHUyJ9+XhJHa/n6vy5KhgXEe5c61HiCOqqhWPAL6KJxD1VuHNhCvK7lUVUPIzWEw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 13,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEB8DnSFWFnS5cfMKagX313emIWiVQgz44Zs6HCy2Bh6VNBCyViWF6excuemOre11OQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 14,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKjGg64F9yQXOxfD6QZF8hjSrzi44w0bPHTaFaFOmDxO3vYMmq2uYnaEVApnl/BIBg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 15,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEC7NxagWsqQTG42LOcIKqlPo+MBgLS5zDnnWSuL3TShd6erI+7FZRl3szycgN+IYUQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 16,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOQc2Fh1BReXYpa9SxfiFFORIuuGAQhSBKhMV5cklSMJsLJuhgBJe72f92KPsJy6eg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 17,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFueaRAXByY4RMhdWULiv9aPIZ7v+nPXWPf3unpeQnU83pmdE6kXvnm0Qqc/BOq3Zg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 18,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMvpJ6+016MVmuf0Tv3A/PC87t/npL0ilbrCjCEsGW6f8iefXaFfQj/2xoGTe2az+w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 19,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEApVv9zXIuTsoXW0zyqNlqVW/bemgmHNU06OEpabq4nTwLYyxJzh2gyhxhMYIn2fmg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 20,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEP20TwpT3MmufLXK5fhuuddUu6puEgkA4kHwLYA1cPekj7RbT57ylLZHUR4I9dfbOA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 21,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAqtU3+3hV1Zz1+rMjlsVRY6/PB1barq4qeHultADNMKMeFwNxRJaub6msg3t2Dadw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 22,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAb+R0ZSI6yWN9chtV1r8HhpRpLPXsEuOQfPBSgVw5O1GydyO0HK9+gIUSC4pXP0pw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 23,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELNukqtdmUGsAo3B/xx4YfE98JOZQa7mq4O9sk8R4rPm02oPGE+h4nBEKXgdj2yi4Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 24,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECGp60lwzXijOpp62f6r27I1mQProJbjM7+Wii89xS35DyoqflyEwuFbDM5EQRQEmA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 25,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEN00sK9CQUrBIV1ThwLH1Y+eGn8holwe+iJcJ7sy62EzeQpYoHXE0WJQA53VaNBF/A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 26,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBhdv5r7tesfRi4oqwDiY2bmXaO07LN4oMEC5RpvT9Q/F7WKEgpu6DomxI+V5XvPmw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 27,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEIctbJ6+yDnzy2qokbbEkWHDn/+jlp83HG0rbuk3KP34tIZ9L5fqStAUFo2AbsZhQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 28,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIFCPTJPPnFXcmOlOmy42ScYj+IBHCwlqRVDV+JCeyxZR94pMvBwusUptaMWTAWKsA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 29,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDb3U2/m0mtsW2eQfD6gmuqv3H2/0Tu3IKAe+aoC94raBd6ZUE2gqjtLecEv2uek7A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 30,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAg2Nj9ejHxoTbNKau7bw2B7xUiAlNlmikusi4GZLCFxjd4R8pP9NGsu7m/Ni3aADg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 31,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEA6mlPROOgnJ9tlO38f7IBqLl3B5v3GPpKAkZgY4Y3tkLH8/JLZiDTUhd48KJWccYA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 32,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHy3V35XlQbY6DP3qFYSuRBDjrzu53mS0FzX7CFWkWvAfLWhMi24JZ9/43h4gmlsAA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 33,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFb9ILd7bawXiZFITp8z4ScrUeDu10hfpxEIA6hws/BhmTVp8+M0nIiHD+vdgfAQVQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 34,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGXu/WWsxcksDY0e0IqQ/BkHaDhe+CKjp9z2v4kPmohoRNbKYEfAMAOR/w3ApWEESQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 35,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJfO17qPT7orKzVLfDbwCOkrPp0wWX4ajmM/BJpTYXzvcVeDsG16FrmU3agtHz+srg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 36,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMIlf9gGNp9A7tER1Gb5v5Y4bVUzyZdwr8d+WtLr28z9R2t0h18VlUFvkBZZG1PrLw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 37,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECrY+LX5Qw8vdGLUUC0FQzqi9MrC/jhd/uu9JFKiKhRyZgblC8amtHzNJAaxOfnHSw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 38,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEP1g8EymjYZiS3wCv7G1VF4HC9ReBT9Ivhx/sW31pMZlhaL/Y1zuQQznBCxESVe/8Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 39,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOhzMLwlHRObARs4/URsUC6+3iR/wI36wvA2jkT9T2BzzVc6V6kvb29uIAkGt0U9fQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 40,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAT+s5taeCtF69fOkHw1LZa06O2ZIFM4hE7QnOnrMoLFfGchtAU1x+1O7PN/gptLlg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 41,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECp0mn6wuBoc45sWMq+oPiF6tu89aE+elTZtwad2uRe2jQQh6qk4HOZ2DskLCRIo6w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 42,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHiO2cuJfdg6l3NnpeSQ9VmE09bUME/L5EZ55ET/UPjb7gw4mDrwMxMdpbBpCS5aDA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 43,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJBUzdVsJUL2+gCl/dIz1mE2aEIXwTH3l/64yJRI4ONvzIah/GcIPMWOI4hTD2/BEw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 44,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJN/CcuTNrAqb/6JAzQNapHFpbsXYKJnsUgWSlecplyFHh1AmxTTZicTjWLA2EMnqw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 45,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPourr1KxlAZZrAKmYerGxP75Db6S22T+6sdv0vwMmNe5r/WYoNhs5JxLhokajoMXQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 46,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKaOS6xXrnA42S/UQK6e57Iqb4nwOec3/M2W9QNtDycxtl/cFjirtvYgG9bPEHH7kA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 47,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEINA8dxlUPvUeRB3UUgcFFWt15OM58vVy5tyaP6Xlg7gYIE/7gh8QSj0BizgPj12qQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 48,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJo6UKcNcBVjKtEhhbrIHgAGAPw8GKiWRjm6yj5+724x9Jz+P8TLy5sekI3KcxxloA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 49,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOyaY2OVUrM89Tz/lkPBvPzb0llUCIOl5LYoGh/ACvmU8GGqD82BB6VvUIpY2hn6Iw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 50,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEM924LqSFyNGyOT+2CmTLygrZO0U/uHpLol6MrM11MoIFmUHNfA+aQix1z02nqjB4Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 51,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELYJ+RP0WEQSqGnDv8aM6/CWVHgtTH3xNhft+4ZoFMKAZ4M9zLGE9eEJ7MBbP88tBA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 52,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJcKe2PNnPalUV5BcpTMO5dDvwWerk3E7c1BGVaNB//RoEoSpjGsnGPVbOLyYTk8fA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 53,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELXfWaYkY0mrluRub5jru7IjIOCawBi6+/JYaEl3fp7NFZ6dwk4TRUoYAJckI4bGdw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 54,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGg7C1bz+v0eWIXdxu7oFtPsd3p9e+4clwCJVxVDVaon8IoImJAlFv3lP0+ucEfCrA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 55,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBiiA/w9GLK535a5lsSpA7u3ziIy4fSiAzGnH6D+duMwk5055NL8E69kIVhzr0uLvA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 56,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPdmFpojyWt90i1YXAMIUfcAtkiI0n6dfeCLJqfyJBN9M8poeclh9x8noCucWb1WpA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 57,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPq5YYD1htDnZhWT5WlHxRcMbiMY37Y5RmcAtFgkEJ0bGogbzFC3AB8/E3cIZe0wvQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 58,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGG+Zfq55gpntsa0lFidmQo7t5fi1FRAIog/LRe8HIlK4WvZJJho03XBbqC98wyVGw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 59,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECRRAtJiqN6uym4cBVXaZM0VZFa+P4GGO5w16DyweL4dJvYgI8gqhK1C74b62Dng5A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 60,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKkX0T8xNJqKSXEVG31KnpPAil2MHc7ZEc262Zg6qBgYthte8HgatslZMSNi1OELAQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 61,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEA5oiGaFxWh+TmxFvfsHAyJ4+lJjAfzvEDFYSIQtdsmGCmNFPxi73f9A3RcZ9tbEXA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 62,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIvlaO5fmOUIT9q63vpugnQCeDrmbYv+Z/RLCE/ePJkDxRPYI4Z4kekSTcQghdOnHw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 63,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHPJ3KmR9I7+ubh3brunDgrCSpyqzc964zFAsG6XHCo/2WbFftges0Y75pd4/ovNow==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 64,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEChUEF/gUSsw21S9sPF3oNuXmAdM5dNFkTC4JwTeg9IOUtTqOi4GlrpJGAYi/XpS+g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 65,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKC60qMVEKjS3HRDc6LoPpuRHmRAaxnK5IPATa1DFGiKy/KAj6jrh6C3zhwGMN0BkQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 66,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKXXwtIl/jJ7DCoXISZ5cZudGkjpz0X7gK2JMsI1vqhpsFjjIYiUh/ACdGWno3kP9A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 67,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFOXXX/kDjDfgzM5rRIObYmKpEXY48r9TcMZgfycYT7F674TUVrDMnr4+WaFRkxm/w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 68,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEORmOPmZ+UmTXoF36KhHRcg2ft82Xrpl0AZIX0gVYKbPenPcI45vFn+5JYgqdGMrUA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 69,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENmp66qV3wHfa7kSye1e87m+dhJdMKFPWns3Noi9Qx4pMFpP3r2KLppE5P1NAPYbng==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 70,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAgJoEgU4Ekr9ZPlbtXMxH56OI56KjegFKD0182rKcReUf6E6NzuLapHCL8al5Mvhg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 71,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGLwqvnN0nTz1KcEtw6Kw4E01v6XFMnWoxu1rxcEtT43iEkiumimGn4MdJ3ojf2EVg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 72,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEG12rRREN8WCuwg/XEIV5rPBuHguc21f/hLxiD7MU9TqqlaBGFko6Icd4cbXJhTTlg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 73,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDLapdWAmjdhdvvJFc0F74rqn5qc/XmyFzhISQxRQubcGi/TBD7noejWAfGQzMB5kQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 74,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBo4J7B0pOspuGCzrGwuWUekFHgj0VkrKMgZ7xadXfrRjrsapL6HBKft8JoSHpZrgg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 75,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAePNwkTTuCz23jb9F6gb9S0OW5goU2D5d6VlrI90d7DlDzIScYBwd8x+j8FMy3TBw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 76,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMbu3i/TPM+BZl9UEMRbkEV1c6nSHRFhYz0RCxNMwrfJplA1Agu8H1jvD1m2YWeSwQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 77,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBl0BUpcELAOY0tsn00V+Gf7MFe/lnAedBpMJobymJqrZfEdBokpxlXh9hbHytCs+g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 78,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKESqR/F1OBCvt6iVbbwAWWKcx06885UAEGaGHPjVSYGPWn4Wf5fhnD5k7dNIccWXg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 79,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBte/BVNcsfD/YRCwK+ssH5W5m1q+GbG9iaWgFHt18a/C7V/5F8VEfCFE6YrjeX2ag==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 80,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECUq+KHUj3xu+WL8vHZkQ2L3+cBFfFGKAIRUJunZR9pCLlnddFAHjO2qKTVKi1AtaA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 81,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENWNUMkIiZH9E0OfHco/cj4hCfW0QncBn6e+EaUm/ysYHnRC72PVKPDNZXQ7Tyb/LA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 82,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELam2zoDHE3znKzQ/clobKdKGmnk1mpy42AlsK5dHIcMnIUA0FM5UTQ3kGvbnImv2g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 83,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPL8kodyCUtBg22OkhomxMBH2uzHilVQTblPnQeeA/nNPSEIYrkwFKbi/0o7MLww1A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 84,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEE314/RhMzglI4pF0FVRm5bqQxjqGdKmZDhkSsiUwmxZMlP80rnZh3wk8uDgIIKr0A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 85,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHzTQM56Ej/luYHM2J+zYm4hY+Vmbgqi8RAg0nidvG3vW/9B6eLhoeyniJTrBQhlPw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 86,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJ13SySnYdF0Bi0/qKKIVl8lUOzpBbzOcTUH152BUHBqvgLPFnY8oLKW+m6b3qr81g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 87,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDE5FSLPx55wOXdyHswxHgjifIxTnWEytjfTNm10yW/AXprE2Y3n6+JVd1h1Fd2U3g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 88,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKTx4a7IHzpNcDXhQR9aT/8JxffCWW7QhlXLIK8TJHKgwVitC9KMExSehfR5yVW8cQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 89,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEI+yHgLDe1W6w9+0MlJIaeWzDtE0cOSZdWWTwAgW8Cka2FHK+gqC/TahQex7fKJmrg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 90,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGsfRRbLaXZ+8yiLW6iXBRM+V+9dRPKWX4pNID0BBlrJloTjjgLm53vs0FjSEx0TaA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 91,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECNo3hT3NvxoBab1ya6zmpcOrbXGLI6TEw8qEyNN8JT3N1BnGrg4rugc94RVwCwXqw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 92,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHBxSGvjs18l0dd0Y6AyIuKU+wavUYSzkCnzRc6zmcmlUndBBy8trp70rX1ICDyZSw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 93,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENnvquPX6mNUXjRZVFewMSsv/j1RfAR98m2NYdKt15HwuUIZs8m0zXoru6lVUorRSg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 94,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIIWlnLy+DVR4KAfAn6TOZZaivbNrjSate5lbpttiE6sgcng8TU3vXd2o4ruJPUccQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 95,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEChWNgBZw2Bb6dGxd8LcIkcmZf6qgs/tA+JNanGQvvIxGrMOxhm+njxMJ7OU+D6WCw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 96,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAmquInC+q2c5Ri+m0P1UEQkx4ISm+9tU5GTks95Qu0KkKTjrdBVhAMLbHEXlJjN7g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 97,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGPEAApYDW49DB/NOGLCcHDz4YMZEPcAdIx4TtoJCI4F7vLgNuYiTWDP1uAx+zfZkQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 98,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEG6cKOwOJPp9zgugXhC6DeM3q2zqf3VdFuQTUIdyb+p9T6KqdWLqNL/6qPn3EotA8Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 99,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEP+YNAukPkL+Oc06TYlIA+DnTPvxv6ZsBJtEPE3Q/ypUod7njYQlnM71XkkzagD8mQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 100,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELIIJSL4xPoSv9KUbqa4aj8pYXb4SqAdRHqO4vxQ3BHXgQq5iqGaYiV5oyfU6UIBWw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 101,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEApxTOLwEixQUGR2RaOFM2l1ctLOanH+Mnx91lirGI7BgthAUZ25EGF60lq2nZNmvA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 102,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBlaGnzUanPcRc8FvVRcFCl/NMGJTPCigq1blt1uteusGf5AGsZajqMpYpitrLXxPw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 103,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOZYCI/XcKaNrMGH5wOVVwJ+1jzlZw63Mx4eYABPf24/yQj1V8DJ6C+O9Hy7J8A2pQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 104,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMt/pHnmQqfyYdjYfZNCoQ2cG1cMATEBpCSYiA9KxF1OoCZKZp/uyoUi9v0RIlSkAA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 105,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEcHO/RjuM5gchhMd198hKGc9qeeGiswVWP+5i85lGyZntWwUbv6SPonWvFVF6MaDA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 106,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKYNVtcZkvxGnGJm7AeyUm8oxySJw9ia9bhGgLPI6TOK11NNoa3JLrpLg+uvrLQlsQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 107,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMoNMh+GcPjFG/B+yIe2bNufooaTCKa9KGzFBof0hGAEkJUmSaX5A5O8XBlCmHk5GA==");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswers_AttemptId",
                table: "AttemptAnswers",
                column: "AttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswers_QuestionId",
                table: "AttemptAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_ExamId",
                table: "Attempts",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_LoginId",
                table: "Attempts",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttemptAnswers");

            migrationBuilder.DropTable(
                name: "Attempts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.CreateTable(
                name: "ExamAttempts",
                columns: table => new
                {
                    ExamAttemptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<short>(type: "smallint", nullable: false),
                    LoginId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<short>(type: "smallint", nullable: false),
                    TimeTaken = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAttempts", x => x.ExamAttemptId);
                    table.ForeignKey(
                        name: "FK_ExamAttempts_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamAttempts_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamQuestions",
                columns: table => new
                {
                    ExamQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlwaysAppear = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Answer = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    IsOptional = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Options = table.Column<string>(type: "varchar(1000) CHARACTER SET utf8mb4", maxLength: 1000, nullable: true),
                    Question = table.Column<string>(type: "varchar(200) CHARACTER SET utf8mb4", maxLength: 200, nullable: false),
                    Score = table.Column<short>(type: "smallint", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestions", x => x.ExamQuestionId);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamAttemptAnswers",
                columns: table => new
                {
                    ExamAttemptAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamAttemptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAttemptAnswers", x => x.ExamAttemptAnswerId);
                    table.ForeignKey(
                        name: "FK_ExamAttemptAnswers_ExamAttempts_ExamAttemptId",
                        column: x => x.ExamAttemptId,
                        principalTable: "ExamAttempts",
                        principalColumn: "ExamAttemptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFAWFYUxquWvCgdzWeH/NDOnLw3vJyOy6DO8zYF9VJCvZ7HFJvmJtA91I6TnAky6wA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJf1/MsEncLqhaChHnVZ5dC2ecBKyXYA+oKDYUifoR6j8f8Dkb+LDMFBRLxHCpV/eA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPyhGb6W5WNXz6L0SxcB3oKFQy1XMkRuS/YOv2Z3Y44/DoyvtJFQu/9sNIvV8TgHqQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 4,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEL/5nxybA2qcXRsj31zi8+5PYL93JPLzf/Jo3B+rXtXAN96FwrK0J26MeadR7HZZQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 5,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMRYioSUZvxcisQZuv4Jomt31Bl4qmJJmMZLlqq+4sU/+uuY9sS0XXFji93jG/2MuQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 6,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJYPTwlILgWmJ3EbaGrX3wICFQxaF42Gt6XRqIqX0lChRYTOODgpcqqFIDgUjw1F5Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 7,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELH8KoeE6Na7R/YswBcREbiEKi31hi9gnItkr3yOr+OROyQM96n/0/JA+TYolSY9AA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 8,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIKwmJwZ5WN3QDg/u3CMG8rNvrBGh5mnubWmYtMB3wPfp2H3RSQIHoUUrCzOFHSGaA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 9,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGfkHeTWROOpkukTGX4NlLTpGIjmX2KJDYlS1QSJT+Fi/Uh0ZDtpv6RiyJsjGsFaVw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 10,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIoXME+RiYW22VbYQLNYzG8v2mZfdYLZb4d4jF158VMBxfYuNSfaZU+5X5RzF3W7+A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 11,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPoxEF/jLH7wPXF2aT+in6Qv3Ch/bTbfM0itZDEXx1thj4csv6C7On1uPtt9hbtHgw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 12,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECMTAn0leBi0B6tVVg0rE+kDsWHXumsQRnitkBwWrtNEfsQQUpX3pZ+3bEjoFbRTVg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 13,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMMnWh93xiUq0KnztRCuV+r/JR27N1PzbJ+fch6jrTvwQofv/8FTvEwS8ujKVMFX0g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 14,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHz9M9f9HBXe8LiueBa6yKypyt2zsKHvjZ4rbHLmCkW3N/VVWh0zdoyV7EvUA0uvLQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 15,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEG46c1yOJYugIgj4++Nm3qnCjS5MaeOiBrv3CEHE4GVNNFfiUIVigPx+fZtnzRsWNQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 16,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEK4tNF7W1hwpFwo0gkE/yq7M2oSioVHKaw9LuP2K+D8YAQbfiPGAouvtMY6/3KSQrw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 17,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPE1RhcMTgtyvZBnba9K0UCQiHIApvJTBejqh7QjaxmL+Nxcl7aHBi42uyzNN4vcUQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 18,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEUZARLtZ9XG/cVmUdHnL6MFapItGNFRAVtTbgLVg8SmymY13REyx1tdN9rcLtkQJA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 19,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAhtAwM8e8pZkILTptIqGqcV78g+QeVkPmaK4UYyjCiAyqpYHkRSygM/b5Lwxnppxg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 20,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEL5oAnkV1YEdFoBpICebyYVXvaKXHuLt5GX8g0b6l/8ykBkRf91ReLCaP2fJuUQEdw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 21,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKc6s6vBfdW8L9PewYwo5yBvXYSP2/Dn7slWxE/bkxGDDzjELUC5Jqu+HbYCvINy9w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 22,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEsF3iWzLDEv48Zp6a3vKnPEaoMupH4P0K/IXnjGKZCW172TNnQdiaOSa/LE8ehItg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 23,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKSt5dwLdtsPvKjfTjEzHYoINDBUd3m6G0kcUFk0bdeWq/5ohzmyPPcXMRH52j3nOw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 24,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEC4Tf4acOJpF0IkNE6Nm0cIkM/uWpLFjSJ85IU3SMbFeI3o5/nhHm1ty8WMw5d6idQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 25,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEP2OPW3D7yBvrqEGDGlLeO7Rfu9wRqPRIpqvp2e3o1OOHTQAJrozlcSQEmJdywvlaw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 26,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAPVbblQJwMcCiyFKd6+sBVjROlBNOXKrWE6UlaiEx0BGvKnfxQKcNVCaFz9byAodA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 27,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPEC2uBR8ZyIPq/3Xel8jw/e+tFb6VTTjooiqS8Pz0jZrvvIUfN9SMRT6hYdQCZQLQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 28,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEN1jymFfv6CAXJozUnMXJXRtPkOXqCr8qZV2TxG043Q28CTNbXP6fIy43+9w+drQWg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 29,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKRI3nCyysvB12Z6QEyEswtAc+P3FWMXnAUiLsxld6JICTDgpUtJ3rBUdrLYzfAQeg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 30,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMTlsJbvjMHkeI1SShTkhJFJWJuQHO+tGdDin0/oBKKYHXoe660RxOUXkEzYf+BF3A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 31,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKvG5V8zyYQiqDBhv9Of7syZi1sxo4bG944liHKoMMlYcvRX5hR1Mh1tibP4sY+e7A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 32,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEA+/W56Gah3aQhZs9RNyCVXetJQJg7rCr/lzhzwcg4w5zDPGaNlMIREJohgm478Qww==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 33,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHQ+L46PwgeOX+YSKU4TwIId6cgaqdQduw+vKvqHwfKQnTbL+8eHirru8ePAelJWqg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 34,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECOs2EpEry/umfGtvCYo0wf1Y2YdvovO9UF2swSdsETHxFO16whdPCFmPEvI7YbCxQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 35,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEK1JS9max6klilHDN5LB9h9ec/3EOJwOOHODMSNu5wqJ4ymVNlwzAM3xjPnn9x1MXg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 36,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEI/EFce0MJY4oJQD5mdkZUGNfC+HQ0V2SBm0DqlSwACvJkhLyvmJOsAyQpIBcRrWvQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 37,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOEoN8XLAXrKwccYZarC5fb1jGUdA6CVqQg3+FQOLyc/EpGytqOEwxznUhQNRlZGQQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 38,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMltFeusunQjiTZSWglu/WeiIcxiPf9cNDWzh0GCTDtkms1OSc28LuuNaARte0PGXA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 39,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDaq3RYTiWZW0kCMeg4E8PIPdnO9O4KyMpNTOp0JvvR2kLYhQ418Z5iudK5yV0D0MA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 40,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEDS2pkLJciaqs2/UWGfBJDtm+PQc2fzEDL03mVdIsGDMQufXAFRdUL8JCvp48kk/fw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 41,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGXSz4PAR/YjZSKgBe2yX4LDc+lENAszFEZXD1U6Q/TF2zauieBBrnioMMet9aNqdQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 42,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAyo1dHA4/Ov08JCmO/LKTHEshfDAuYDEZJLFpchMw4m+jsZpLMJPJ/1J3CYi4G3Fg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 43,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMiABuymILKfMjywLvYq4DKy37w/xJIFvhnXOVQAv7F6gLoaPYml7aAF1Vub1WeV4g==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 44,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJneXmlxN3cHZBCbLX0qgPGHcN/av4oZ+j6twxajrfrrxcR6eq/zh6O+7ieuSYS0Nw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 45,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBsLYU/20liydPoq1HSzkh3VBVnpouPHYRtzgiYmN8VS5dzemDCRvDhPmWXWAR1Sqw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 46,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBlyMVSSScPI6JRXByZNAY4whsU2DRrD4Si/8LSNyA7VAK+McKnKAtfBfPHOe18tRA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 47,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPPPfmXHdrd9VuY2CBq+zEq4dV0SrQw0Ebnldgd7f6oxzrMDFk2kQuA4epE9nMjhLA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 48,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPAcnx+5CeLnVu5T6wUULbwd0FS2sFKrmFfb4mAQwSUwrtni7z6kWb6nvJ5go0uk8Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 49,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEEffkUXk+DElTjg4FWZ11t32DyTJpQUVY8arnQHJ455Ioelov6G83sZedLp6xKVSw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 50,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEPAg8O7leCQWJDvI/M+mXnH4mZqvASGv4/JE9P1hTSJRZM/6sNg0QnxPvncUav2RqQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 51,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMiYgI5jFKh5Xrt+/KTRCxgVQke31AdJGfP0OBvVk1A6cowAruPA32uYSD82uIkMRw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 52,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBnrcwd7ZgVp7l4cjSV3DqjvFR9+yiYNF2eWbCkwfxwVhlf9h0n0vSjXuXhbWvDBcA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 53,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELQQYCBtrDV39vKAICcL9L7WEv0zc7/S5hWubhMDJpvGpY61ZQZGcGE92Z1kqYg+wA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 54,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKhBbwdVZyF8dc+93FD+MiGJg/4V4WPfw6/4i1sutB+44qT8SvbGDr5zRFqwTq4Llg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 55,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEId5TLVKbrXrrLfGFNdPvbSxWK6xyIVC8pLTg6ypmhTLfT9syiq+fsEHJ5O1Qj3ZtA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 56,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEL52CDJazxr0EfsFYH56QUsOYpU+y9io9AJCdRiGCninneKtSEmSQPkkHKHGoF2XEA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 57,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHuUF/savqJS+wO7pzb+tpBXOZJjqSCEYfCDnFhryS1vSzG1G3tR400FEKKOPBQPSw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 58,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEF1UwJlyRfJ8xTvxkLDCkDwFnWxMZSq92VvY0t/nAK3mzNqNpbSEUjdgP3/hBCLt0Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 59,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGM7X49O7YKJ5CmY5HU9hQGO2d01XJliYPSvOyIwitX53IVL1n12u1DZxKHxXRAVhg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 60,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMDJfgutzyb2I5t3CabFlUadPiD6WEBu4CcVsn81Wt6GKzBGQFWLjDvCz6jFcfofhg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 61,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEI0/Q91WG6e2CybIlwC015sF8GqHr8t1NsYbe0tFBuIhmYwCcFOlopVKIRkzgMwr8A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 62,
                column: "Password",
                value: "AQAAAAEAACcQAAAAED9WP+s92ZOobBxxwXJvh4QdV03N4Q93O8FOxsCNhVSpaR4J6kR+eedLn2xtzd6wDg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 63,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKwBL4gLDig6aPqO0Byp9bOdnSaWYDZSFIOxJkjl452DtQERr6HK7+hd8r26Ym3WVA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 64,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFUAR52Bry61YsKbCo+xnIbE068YQMTuqteiS3P9i/vCBhX6ndeeSrEHYK6W1QgACA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 65,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOecEPpsl6352ELqZcrwhXKV3/XBIMloUc1TQ8WsB/fwLlriQPK1GGlelWv6LMIffA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 66,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHQIDcf1tkH77YgVe5b0EnFY7zR9zLhXCp3ldo4sLdQb/EmibFUZq9YL1GlZZOGHww==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 67,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBpG1xdqbQAuKdbum2JFvPyJ3NEnEeAkCwxultyJ5gupRu4YI3FGzFDh1C1Z5td4oQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 68,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEC/H0n+RmEZFirZ9ZSWy7I7LCZHADa5G6kfgVdBbp+VwBhlYgvuIc2J2qww6YVJSXg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 69,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECiIhQ9XslLlt1S8BGIYygIC4Gfd9fo8+9ZCPZut8BJuG2VA/+zD6hG15Zh30zzhJQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 70,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEK5ZE+eGdYGaZ7YGsophxovl75phSrTvPP8wewuUwJiWP+H8D8mqmcinDEbykOQezA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 71,
                column: "Password",
                value: "AQAAAAEAACcQAAAAECI4lP8ZGi7xOpXIYhKkX/ohqyehSRhxA4JjCYuhA4JtCEHw48KzCb9DptAROGohKA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 72,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELOSCKNOjuNBasBXGE+je1WI8oqHk+wKodrTgGehzUvf2V9Z6YJSTU4pYTel1RXgsA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 73,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIYvGSwDC0J+jK1lCS2pg22C8aO+2MY5TVC7+6LzGFLPKDF8eqk1NAuYdSSX1wkDAg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 74,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMcIjyjbUJGOKN1+7pPG5cpxGTRHdfYxDQIcPfZ8V5vhwQCOwe2g6oUXUHWVK4/kTA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 75,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEF/WymKpUgjTQZRuFmOOZsA6juFf8gsLA563ZwGIdCa199qP/7Uz9lnnN8eZWvCGSQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 76,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENeGiJ9YQoTnxWvyqhs675e5LD14RXXRh/3InB2uMnYxf+mUZwqaXGVDRHpAv6MYTg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 77,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAmeV8vwT1Ni0EkRnNwo1pjXoRlU6BJhHcQOWvBBTP4BirsCNnMN12KlyIpq1qZ9Dg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 78,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBng96RSci48IhFyz9FWNNgtH7upAeoT971rdmPLYZ6jX7veNZb0QGcqPwbbYHAYBw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 79,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGRfrONjKcrx2rw6ryWRQGoWT26bUnQyD0ZnzxR5Tb7bzwEP2SeGquaqDvpMdEgCoQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 80,
                column: "Password",
                value: "AQAAAAEAACcQAAAAENuUlI7d0cfuI8tYD8h+MhIdsAYS08C3GYluqOWsFuCl3VttuU4D9L/jiY3JNUzPcA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 81,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEO3UbnJGJPCMzkHQKgWAi0/knumBAFKHFwlVRYxLNrbNnaNm9/WE+ijq6st2F1ns2w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 82,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBPCOK7rh7VpfKjy9z4Zqegoh6AxvRZr2NtdB8vlg7J1ggnKqhAkChWdVEAdG1w23Q==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 83,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFAkWL6Kf1hOiRS9HmikLEyaBLFEv1toOi2AhnEeerx5a06d0i4fDb0hMwdb2HXmQw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 84,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHaAulfc9+SBtkWt3QeFvzTaDS8ib0lqMPlGLEEjU6vtDgeQTIX4n6Ts+9DhGPVeag==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 85,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEO0CIg0ydHpMX6YfU0b09tmpY9sxnpzDpFMihM4hQtjknIXTONO1nS3/m5TCCg8bLA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 86,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJQYEf7/NKNwyJ3gHmRAhx1/U5hxW74fOw0sok6uB8iIwS4qjGlKRXsiDQ7dXQ6ydg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 87,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFzOT7awG2ohqtltrfDwkMkEyMgYaS9WzJthaWBAZss7VG0yP4tk24ARTDwSBB56uQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 88,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJHxRa8g7iFU6nnWnmU9Ky8YrPX+/8Sr/S3F/uCpdHI0HPQmLx1J4E9PVQACf+fBqg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 89,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOVJpCTmG2wX7yxjTCsiQb8IXE6iz+vhThnqxFuyFjR8ax/sHvg9CyRwfQ+If8n0hg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 90,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEID0mqIlpbwDh5sYCQ7F4QphD97jjp7/Yf+0eSW/oJYrvUp1l+jl/ifR/EpZBol5Fw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 91,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHtnSJOjA9oyZKKty3R22YSwe8pe90ydIfFSEvvU4WiQLFumw2wOKfaUbVcmaR397A==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 92,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEKQfjDZgxGhxQlb4YdW4P3kj2t+cUXlW8Qm1UO3aB5zhEFiOAmUiIP+sg+w821zpSw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 93,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAodLGoZvQ47eKIzAN97ibg3wtodec1mm9Hpa1K2yY84FGBJ9hb9+CegiwI9Xyv6jw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 94,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAyN9sgs0xtrXDpqiO47NnTMmEWanwp1LDq0uxhaGoOud1qkV5kULWCNyB0j8fY7nw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 95,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEP6UtnDECWcci1yVXrfvW5/bCjmrYfwOB8AqfAOcfzwdk5ByjMGGn77euGkjzX6iIQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 96,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEBvqavIU9xuPQgMJjcJeXtxNUtHGqzcT4Qe+Vd3kU4WtnIx1xsuQRhFlrAkX+eHctw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 97,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEFckg1xCRqpIJxUIXWjSpqwKTzp8ELsROWUSz8d37BE2ftnmzMe1PlVj2oGKhvkbmQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 98,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEC4HwK+CiS3ZoFLDb0hJCaWkHahPsnT1ukKXTIUl/AIllC2PjTJTn4l+LwEgkrZR4w==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 99,
                column: "Password",
                value: "AQAAAAEAACcQAAAAELEI1ucrSbMXGW7Qop3RkEUHh/0I1dEuLWFTp2Tbefe3inwXk2oe7W03vUyL5804oQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 100,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJYAP2qAzFvx3rBgImLHbgF+zLZea67IXsCxbu8mnDg/XOXVCsyjSe5Vv4vk2ld+cQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 101,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMJB+1swI+BaKlPPw/o2NBUkXY+EbGjg+KPYz79luRVjsG4YTKyWYO/+/mmKEkXXKw==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 102,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIg0VWJE7tUTVHj37XeaDLRvNdxHScNa5rv+a4o7NgeU+rWJwNYcUdsxcHcG2qDGkA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 103,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOsi6u7xmsobWcd+M2ilPB/Gr3RzHHZtvkrfxSenG/BLw4uV34ETK/RBBos6hgl9ww==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 104,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEL90bUvRNv1NZNUsHmOx67tABYasjwKA9WlBbogTcsd2oG+aUpdFtPH2ha3oUqEdvA==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 105,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEhsWgJugHqk7Dsm3V+ph7l3vWcbmYpR9KgT/MxfRicG17FOQ9kSMfEe1C6lRb9BRQ==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 106,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEGa/e2zDqubK4q6kO6gHkmHUmdvuXtItsX+Ix4wBojOeE3FuDnBEzbdb3eaguYfLPg==");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: 107,
                column: "Password",
                value: "AQAAAAEAACcQAAAAEI0L5fIKCz9HBt8M1ezzUyTslX0QzT389w6DTm17UIuqrikddZG5DpcehFm/INbEjA==");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttemptAnswers_ExamAttemptId",
                table: "ExamAttemptAnswers",
                column: "ExamAttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttempts_ExamId",
                table: "ExamAttempts",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttempts_LoginId",
                table: "ExamAttempts",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_ExamId",
                table: "ExamQuestions",
                column: "ExamId");
        }
    }
}
