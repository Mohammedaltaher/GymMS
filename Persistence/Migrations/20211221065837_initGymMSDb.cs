using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initGymMSDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFeatureTypeNews_AdditionalFeatures_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNews");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFeatureTypeNews_AspNetUsers_CreatedById",
                table: "AdditionalFeatureTypeNews");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_AspNetUsers_CreatedById",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_AspNetUsers_CreatedById",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_FreeRequirements_AspNetUsers_CreatedById",
                table: "FreeRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_Halls_AspNetUsers_CreatedById",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Parties_AspNetUsers_CreatedById",
                table: "Parties");

            migrationBuilder.DropForeignKey(
                name: "FK_Periods_AspNetUsers_CreatedById",
                table: "Periods");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirements_AspNetUsers_CreatedById",
                table: "Requirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatureRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_Requirements_RequirementId",
                table: "ReservationAdditionalFeatureRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_ReservationAdditionalFeatures_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatures_AdditionalFeatures_AdditionalFeatureId",
                table: "ReservationAdditionalFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatures_AdditionalFeatureTypeNews_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatures_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatures_Reservations_ReservationId",
                table: "ReservationAdditionalFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationConditions_AspNetUsers_CreatedById",
                table: "ReservationConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationConditions_Conditions_ConditionId",
                table: "ReservationConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationConditions_Reservations_ReservationId",
                table: "ReservationConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirements_AspNetUsers_CreatedById",
                table: "ReservationFreeRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirements_FreeRequirements_FreeRequirementId",
                table: "ReservationFreeRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirements_Reservations_ReservationId",
                table: "ReservationFreeRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationReceipts_AspNetUsers_CreatedById",
                table: "ReservationReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationReceipts_Reservations_ReservationId",
                table: "ReservationReceipts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_CreatedById",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Clients_ClientId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Parties_PartyId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Periods_PeriodId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Receivables");

            migrationBuilder.DropTable(
                name: "Vats");

            migrationBuilder.DropTable(
                name: "Withdraws");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Nationalitys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationReceipts",
                table: "ReservationReceipts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationFreeRequirements",
                table: "ReservationFreeRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationConditions",
                table: "ReservationConditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationAdditionalFeatures",
                table: "ReservationAdditionalFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationAdditionalFeatureRequirements",
                table: "ReservationAdditionalFeatureRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requirements",
                table: "Requirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Periods",
                table: "Periods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parties",
                table: "Parties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Halls",
                table: "Halls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreeRequirements",
                table: "FreeRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalFeatureTypeNews",
                table: "AdditionalFeatureTypeNews");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "ReservationReceipts",
                newName: "ReservationReceipt");

            migrationBuilder.RenameTable(
                name: "ReservationFreeRequirements",
                newName: "ReservationFreeRequirement");

            migrationBuilder.RenameTable(
                name: "ReservationConditions",
                newName: "ReservationCondition");

            migrationBuilder.RenameTable(
                name: "ReservationAdditionalFeatures",
                newName: "ReservationAdditionalFeature");

            migrationBuilder.RenameTable(
                name: "ReservationAdditionalFeatureRequirements",
                newName: "ReservationAdditionalFeatureRequirement");

            migrationBuilder.RenameTable(
                name: "Requirements",
                newName: "Requirement");

            migrationBuilder.RenameTable(
                name: "Periods",
                newName: "Period");

            migrationBuilder.RenameTable(
                name: "Parties",
                newName: "Party");

            migrationBuilder.RenameTable(
                name: "Halls",
                newName: "Hall");

            migrationBuilder.RenameTable(
                name: "FreeRequirements",
                newName: "FreeRequirement");

            migrationBuilder.RenameTable(
                name: "Conditions",
                newName: "Condition");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameTable(
                name: "AdditionalFeatureTypeNews",
                newName: "AdditionalFeatureTypeNew");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PeriodId",
                table: "Reservation",
                newName: "IX_Reservation_PeriodId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_PartyId",
                table: "Reservation",
                newName: "IX_Reservation_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_HallId",
                table: "Reservation",
                newName: "IX_Reservation_HallId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_CreatedById",
                table: "Reservation",
                newName: "IX_Reservation_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservation",
                newName: "IX_Reservation_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationReceipts_ReservationId",
                table: "ReservationReceipt",
                newName: "IX_ReservationReceipt_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationReceipts_CreatedById",
                table: "ReservationReceipt",
                newName: "IX_ReservationReceipt_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirements_ReservationId",
                table: "ReservationFreeRequirement",
                newName: "IX_ReservationFreeRequirement_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirements_FreeRequirementId",
                table: "ReservationFreeRequirement",
                newName: "IX_ReservationFreeRequirement_FreeRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirements_CreatedById",
                table: "ReservationFreeRequirement",
                newName: "IX_ReservationFreeRequirement_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationConditions_ReservationId",
                table: "ReservationCondition",
                newName: "IX_ReservationCondition_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationConditions_CreatedById",
                table: "ReservationCondition",
                newName: "IX_ReservationCondition_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationConditions_ConditionId",
                table: "ReservationCondition",
                newName: "IX_ReservationCondition_ConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatures_ReservationId",
                table: "ReservationAdditionalFeature",
                newName: "IX_ReservationAdditionalFeature_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatures_CreatedById",
                table: "ReservationAdditionalFeature",
                newName: "IX_ReservationAdditionalFeature_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatures_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeature",
                newName: "IX_ReservationAdditionalFeature_AdditionalFeatureTypeNewId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatures_AdditionalFeatureId",
                table: "ReservationAdditionalFeature",
                newName: "IX_ReservationAdditionalFeature_AdditionalFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirements_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirement",
                newName: "IX_ReservationAdditionalFeatureRequirement_ReservationAdditionalFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirements_RequirementId",
                table: "ReservationAdditionalFeatureRequirement",
                newName: "IX_ReservationAdditionalFeatureRequirement_RequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirements_CreatedById",
                table: "ReservationAdditionalFeatureRequirement",
                newName: "IX_ReservationAdditionalFeatureRequirement_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Requirements_CreatedById",
                table: "Requirement",
                newName: "IX_Requirement_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Periods_CreatedById",
                table: "Period",
                newName: "IX_Period_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Parties_CreatedById",
                table: "Party",
                newName: "IX_Party_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Halls_CreatedById",
                table: "Hall",
                newName: "IX_Hall_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_FreeRequirements_CreatedById",
                table: "FreeRequirement",
                newName: "IX_FreeRequirement_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Conditions_CreatedById",
                table: "Condition",
                newName: "IX_Condition_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_CreatedById",
                table: "Client",
                newName: "IX_Client_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalFeatureTypeNews_CreatedById",
                table: "AdditionalFeatureTypeNew",
                newName: "IX_AdditionalFeatureTypeNew_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalFeatureTypeNews_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNew",
                newName: "IX_AdditionalFeatureTypeNew_AdditionalFeatureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationReceipt",
                table: "ReservationReceipt",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationFreeRequirement",
                table: "ReservationFreeRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationCondition",
                table: "ReservationCondition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationAdditionalFeature",
                table: "ReservationAdditionalFeature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationAdditionalFeatureRequirement",
                table: "ReservationAdditionalFeatureRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requirement",
                table: "Requirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Period",
                table: "Period",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Party",
                table: "Party",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hall",
                table: "Hall",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreeRequirement",
                table: "FreeRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condition",
                table: "Condition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalFeatureTypeNew",
                table: "AdditionalFeatureTypeNew",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFeatureTypeNew_AdditionalFeatures_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNew",
                column: "AdditionalFeatureId",
                principalTable: "AdditionalFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFeatureTypeNew_AspNetUsers_CreatedById",
                table: "AdditionalFeatureTypeNew",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_AspNetUsers_CreatedById",
                table: "Client",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Condition_AspNetUsers_CreatedById",
                table: "Condition",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FreeRequirement_AspNetUsers_CreatedById",
                table: "FreeRequirement",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_AspNetUsers_CreatedById",
                table: "Hall",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Party_AspNetUsers_CreatedById",
                table: "Party",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Period_AspNetUsers_CreatedById",
                table: "Period",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirement_AspNetUsers_CreatedById",
                table: "Requirement",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_CreatedById",
                table: "Reservation",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Client_ClientId",
                table: "Reservation",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Hall_HallId",
                table: "Reservation",
                column: "HallId",
                principalTable: "Hall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Party_PartyId",
                table: "Reservation",
                column: "PartyId",
                principalTable: "Party",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Period_PeriodId",
                table: "Reservation",
                column: "PeriodId",
                principalTable: "Period",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeature_AdditionalFeatures_AdditionalFeatureId",
                table: "ReservationAdditionalFeature",
                column: "AdditionalFeatureId",
                principalTable: "AdditionalFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeature_AdditionalFeatureTypeNew_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeature",
                column: "AdditionalFeatureTypeNewId",
                principalTable: "AdditionalFeatureTypeNew",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeature_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeature",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeature_Reservation_ReservationId",
                table: "ReservationAdditionalFeature",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatureRequirement",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_Requirement_RequirementId",
                table: "ReservationAdditionalFeatureRequirement",
                column: "RequirementId",
                principalTable: "Requirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_ReservationAdditionalFeature_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirement",
                column: "ReservationAdditionalFeatureId",
                principalTable: "ReservationAdditionalFeature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationCondition_AspNetUsers_CreatedById",
                table: "ReservationCondition",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationCondition_Condition_ConditionId",
                table: "ReservationCondition",
                column: "ConditionId",
                principalTable: "Condition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationCondition_Reservation_ReservationId",
                table: "ReservationCondition",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirement_AspNetUsers_CreatedById",
                table: "ReservationFreeRequirement",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirement_FreeRequirement_FreeRequirementId",
                table: "ReservationFreeRequirement",
                column: "FreeRequirementId",
                principalTable: "FreeRequirement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirement_Reservation_ReservationId",
                table: "ReservationFreeRequirement",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationReceipt_AspNetUsers_CreatedById",
                table: "ReservationReceipt",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationReceipt_Reservation_ReservationId",
                table: "ReservationReceipt",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFeatureTypeNew_AdditionalFeatures_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNew");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFeatureTypeNew_AspNetUsers_CreatedById",
                table: "AdditionalFeatureTypeNew");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_AspNetUsers_CreatedById",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Condition_AspNetUsers_CreatedById",
                table: "Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_FreeRequirement_AspNetUsers_CreatedById",
                table: "FreeRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_AspNetUsers_CreatedById",
                table: "Hall");

            migrationBuilder.DropForeignKey(
                name: "FK_Party_AspNetUsers_CreatedById",
                table: "Party");

            migrationBuilder.DropForeignKey(
                name: "FK_Period_AspNetUsers_CreatedById",
                table: "Period");

            migrationBuilder.DropForeignKey(
                name: "FK_Requirement_AspNetUsers_CreatedById",
                table: "Requirement");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_CreatedById",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Client_ClientId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Hall_HallId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Party_PartyId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Period_PeriodId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeature_AdditionalFeatures_AdditionalFeatureId",
                table: "ReservationAdditionalFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeature_AdditionalFeatureTypeNew_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeature_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeature_Reservation_ReservationId",
                table: "ReservationAdditionalFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatureRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_Requirement_RequirementId",
                table: "ReservationAdditionalFeatureRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirement_ReservationAdditionalFeature_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationCondition_AspNetUsers_CreatedById",
                table: "ReservationCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationCondition_Condition_ConditionId",
                table: "ReservationCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationCondition_Reservation_ReservationId",
                table: "ReservationCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirement_AspNetUsers_CreatedById",
                table: "ReservationFreeRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirement_FreeRequirement_FreeRequirementId",
                table: "ReservationFreeRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationFreeRequirement_Reservation_ReservationId",
                table: "ReservationFreeRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationReceipt_AspNetUsers_CreatedById",
                table: "ReservationReceipt");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservationReceipt_Reservation_ReservationId",
                table: "ReservationReceipt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationReceipt",
                table: "ReservationReceipt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationFreeRequirement",
                table: "ReservationFreeRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationCondition",
                table: "ReservationCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationAdditionalFeatureRequirement",
                table: "ReservationAdditionalFeatureRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationAdditionalFeature",
                table: "ReservationAdditionalFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requirement",
                table: "Requirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Period",
                table: "Period");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Party",
                table: "Party");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hall",
                table: "Hall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreeRequirement",
                table: "FreeRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condition",
                table: "Condition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdditionalFeatureTypeNew",
                table: "AdditionalFeatureTypeNew");

            migrationBuilder.RenameTable(
                name: "ReservationReceipt",
                newName: "ReservationReceipts");

            migrationBuilder.RenameTable(
                name: "ReservationFreeRequirement",
                newName: "ReservationFreeRequirements");

            migrationBuilder.RenameTable(
                name: "ReservationCondition",
                newName: "ReservationConditions");

            migrationBuilder.RenameTable(
                name: "ReservationAdditionalFeatureRequirement",
                newName: "ReservationAdditionalFeatureRequirements");

            migrationBuilder.RenameTable(
                name: "ReservationAdditionalFeature",
                newName: "ReservationAdditionalFeatures");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "Requirement",
                newName: "Requirements");

            migrationBuilder.RenameTable(
                name: "Period",
                newName: "Periods");

            migrationBuilder.RenameTable(
                name: "Party",
                newName: "Parties");

            migrationBuilder.RenameTable(
                name: "Hall",
                newName: "Halls");

            migrationBuilder.RenameTable(
                name: "FreeRequirement",
                newName: "FreeRequirements");

            migrationBuilder.RenameTable(
                name: "Condition",
                newName: "Conditions");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "AdditionalFeatureTypeNew",
                newName: "AdditionalFeatureTypeNews");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationReceipt_ReservationId",
                table: "ReservationReceipts",
                newName: "IX_ReservationReceipts_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationReceipt_CreatedById",
                table: "ReservationReceipts",
                newName: "IX_ReservationReceipts_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirement_ReservationId",
                table: "ReservationFreeRequirements",
                newName: "IX_ReservationFreeRequirements_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirement_FreeRequirementId",
                table: "ReservationFreeRequirements",
                newName: "IX_ReservationFreeRequirements_FreeRequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationFreeRequirement_CreatedById",
                table: "ReservationFreeRequirements",
                newName: "IX_ReservationFreeRequirements_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationCondition_ReservationId",
                table: "ReservationConditions",
                newName: "IX_ReservationConditions_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationCondition_CreatedById",
                table: "ReservationConditions",
                newName: "IX_ReservationConditions_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationCondition_ConditionId",
                table: "ReservationConditions",
                newName: "IX_ReservationConditions_ConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirement_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirements",
                newName: "IX_ReservationAdditionalFeatureRequirements_ReservationAdditionalFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirement_RequirementId",
                table: "ReservationAdditionalFeatureRequirements",
                newName: "IX_ReservationAdditionalFeatureRequirements_RequirementId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeatureRequirement_CreatedById",
                table: "ReservationAdditionalFeatureRequirements",
                newName: "IX_ReservationAdditionalFeatureRequirements_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeature_ReservationId",
                table: "ReservationAdditionalFeatures",
                newName: "IX_ReservationAdditionalFeatures_ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeature_CreatedById",
                table: "ReservationAdditionalFeatures",
                newName: "IX_ReservationAdditionalFeatures_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeature_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeatures",
                newName: "IX_ReservationAdditionalFeatures_AdditionalFeatureTypeNewId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservationAdditionalFeature_AdditionalFeatureId",
                table: "ReservationAdditionalFeatures",
                newName: "IX_ReservationAdditionalFeatures_AdditionalFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PeriodId",
                table: "Reservations",
                newName: "IX_Reservations_PeriodId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_PartyId",
                table: "Reservations",
                newName: "IX_Reservations_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_HallId",
                table: "Reservations",
                newName: "IX_Reservations_HallId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_CreatedById",
                table: "Reservations",
                newName: "IX_Reservations_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ClientId",
                table: "Reservations",
                newName: "IX_Reservations_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Requirement_CreatedById",
                table: "Requirements",
                newName: "IX_Requirements_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Period_CreatedById",
                table: "Periods",
                newName: "IX_Periods_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Party_CreatedById",
                table: "Parties",
                newName: "IX_Parties_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Hall_CreatedById",
                table: "Halls",
                newName: "IX_Halls_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_FreeRequirement_CreatedById",
                table: "FreeRequirements",
                newName: "IX_FreeRequirements_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Condition_CreatedById",
                table: "Conditions",
                newName: "IX_Conditions_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Client_CreatedById",
                table: "Clients",
                newName: "IX_Clients_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalFeatureTypeNew_CreatedById",
                table: "AdditionalFeatureTypeNews",
                newName: "IX_AdditionalFeatureTypeNews_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_AdditionalFeatureTypeNew_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNews",
                newName: "IX_AdditionalFeatureTypeNews_AdditionalFeatureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationReceipts",
                table: "ReservationReceipts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationFreeRequirements",
                table: "ReservationFreeRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationConditions",
                table: "ReservationConditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationAdditionalFeatureRequirements",
                table: "ReservationAdditionalFeatureRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationAdditionalFeatures",
                table: "ReservationAdditionalFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requirements",
                table: "Requirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Periods",
                table: "Periods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parties",
                table: "Parties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Halls",
                table: "Halls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreeRequirements",
                table: "FreeRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdditionalFeatureTypeNews",
                table: "AdditionalFeatureTypeNews",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsReceived = table.Column<bool>(type: "bit", nullable: false),
                    Lost = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurances_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nationalitys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalitys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nationalitys_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CollectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ReceiptDate = table.Column<double>(type: "float", nullable: false),
                    ReceiptType = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vats_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Withdraws",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdraws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Withdraws_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalary = table.Column<double>(type: "float", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DaySalary = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    JobPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobType = table.Column<int>(type: "int", nullable: false),
                    LeaveDaySalary = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Nationalitys_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receivables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivableDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivableType = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivables_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receivables_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankId",
                table: "BankAccounts",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CreatedById",
                table: "BankAccounts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_CreatedById",
                table: "Banks",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CreatedById",
                table: "Employees",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CreatedById",
                table: "Expenses",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_CreatedById",
                table: "Insurances",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_CreatedById",
                table: "Leaves",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalitys_CreatedById",
                table: "Nationalitys",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_CreatedById",
                table: "Receipts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Receivables_CreatedById",
                table: "Receivables",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Receivables_EmployeeId",
                table: "Receivables",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vats_CreatedById",
                table: "Vats",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Withdraws_CreatedById",
                table: "Withdraws",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFeatureTypeNews_AdditionalFeatures_AdditionalFeatureId",
                table: "AdditionalFeatureTypeNews",
                column: "AdditionalFeatureId",
                principalTable: "AdditionalFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFeatureTypeNews_AspNetUsers_CreatedById",
                table: "AdditionalFeatureTypeNews",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_AspNetUsers_CreatedById",
                table: "Clients",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditions_AspNetUsers_CreatedById",
                table: "Conditions",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FreeRequirements_AspNetUsers_CreatedById",
                table: "FreeRequirements",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_AspNetUsers_CreatedById",
                table: "Halls",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parties_AspNetUsers_CreatedById",
                table: "Parties",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Periods_AspNetUsers_CreatedById",
                table: "Periods",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requirements_AspNetUsers_CreatedById",
                table: "Requirements",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatureRequirements",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_Requirements_RequirementId",
                table: "ReservationAdditionalFeatureRequirements",
                column: "RequirementId",
                principalTable: "Requirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatureRequirements_ReservationAdditionalFeatures_ReservationAdditionalFeatureId",
                table: "ReservationAdditionalFeatureRequirements",
                column: "ReservationAdditionalFeatureId",
                principalTable: "ReservationAdditionalFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatures_AdditionalFeatures_AdditionalFeatureId",
                table: "ReservationAdditionalFeatures",
                column: "AdditionalFeatureId",
                principalTable: "AdditionalFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatures_AdditionalFeatureTypeNews_AdditionalFeatureTypeNewId",
                table: "ReservationAdditionalFeatures",
                column: "AdditionalFeatureTypeNewId",
                principalTable: "AdditionalFeatureTypeNews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatures_AspNetUsers_CreatedById",
                table: "ReservationAdditionalFeatures",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationAdditionalFeatures_Reservations_ReservationId",
                table: "ReservationAdditionalFeatures",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationConditions_AspNetUsers_CreatedById",
                table: "ReservationConditions",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationConditions_Conditions_ConditionId",
                table: "ReservationConditions",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationConditions_Reservations_ReservationId",
                table: "ReservationConditions",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirements_AspNetUsers_CreatedById",
                table: "ReservationFreeRequirements",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirements_FreeRequirements_FreeRequirementId",
                table: "ReservationFreeRequirements",
                column: "FreeRequirementId",
                principalTable: "FreeRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationFreeRequirements_Reservations_ReservationId",
                table: "ReservationFreeRequirements",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationReceipts_AspNetUsers_CreatedById",
                table: "ReservationReceipts",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationReceipts_Reservations_ReservationId",
                table: "ReservationReceipts",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_CreatedById",
                table: "Reservations",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Clients_ClientId",
                table: "Reservations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Halls_HallId",
                table: "Reservations",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Parties_PartyId",
                table: "Reservations",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Periods_PeriodId",
                table: "Reservations",
                column: "PeriodId",
                principalTable: "Periods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
