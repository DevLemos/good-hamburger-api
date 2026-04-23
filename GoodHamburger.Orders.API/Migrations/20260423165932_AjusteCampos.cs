using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodHamburger.Orders.API.Migrations
{
    /// <inheritdoc />
    public partial class AjusteCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedidos_Pedidos_PedidoId",
                table: "ItensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedidos_Produtos_ProdutoId",
                table: "ItensPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensPedidos",
                table: "ItensPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "SubDesconto",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "ItensPedidos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "tbl_Produtos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "tbl_Pedidos");

            migrationBuilder.RenameTable(
                name: "ItensPedidos",
                newName: "tbl_Pedido_Itens");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "tbl_Clientes");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "tbl_Produtos",
                newName: "tp_Produto");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "tbl_Produtos",
                newName: "vl_Preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tbl_Produtos",
                newName: "ds_Nome");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "tbl_Produtos",
                newName: "id_Produto");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "tbl_Pedidos",
                newName: "vl_Total");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "tbl_Pedidos",
                newName: "tp_Status");

            migrationBuilder.RenameColumn(
                name: "Desconto",
                table: "tbl_Pedidos",
                newName: "vl_Desconto");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "tbl_Pedidos",
                newName: "dt_Criacao");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "tbl_Pedidos",
                newName: "id_Cliente");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "tbl_Pedidos",
                newName: "id_Pedido");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "tbl_Pedidos",
                newName: "IX_tbl_Pedidos_id_Cliente");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "tbl_Pedido_Itens",
                newName: "nr_Quantidade");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "tbl_Pedido_Itens",
                newName: "id_Produto");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "tbl_Pedido_Itens",
                newName: "id_Pedido");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tbl_Pedido_Itens",
                newName: "ds_Nome");

            migrationBuilder.RenameColumn(
                name: "ItemPedidoId",
                table: "tbl_Pedido_Itens",
                newName: "id_Pedido_Item");

            migrationBuilder.RenameIndex(
                name: "IX_ItensPedidos_ProdutoId",
                table: "tbl_Pedido_Itens",
                newName: "IX_tbl_Pedido_Itens_id_Produto");

            migrationBuilder.RenameIndex(
                name: "IX_ItensPedidos_PedidoId",
                table: "tbl_Pedido_Itens",
                newName: "IX_tbl_Pedido_Itens_id_Pedido");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "tbl_Clientes",
                newName: "nr_Telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tbl_Clientes",
                newName: "ds_Nome");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "tbl_Clientes",
                newName: "id_Cliente");

            migrationBuilder.AlterColumn<decimal>(
                name: "vl_Preco",
                table: "tbl_Produtos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "ds_Nome",
                table: "tbl_Produtos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "vl_Total",
                table: "tbl_Pedidos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "vl_Desconto",
                table: "tbl_Pedidos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dt_Criacao",
                table: "tbl_Pedidos",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "vl_SubTotal",
                table: "tbl_Pedidos",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "ds_Nome",
                table: "tbl_Pedido_Itens",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "vl_Preco",
                table: "tbl_Pedido_Itens",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "nr_Telefone",
                table: "tbl_Clientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ds_Nome",
                table: "tbl_Clientes",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Produtos",
                table: "tbl_Produtos",
                column: "id_Produto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Pedidos",
                table: "tbl_Pedidos",
                column: "id_Pedido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Pedido_Itens",
                table: "tbl_Pedido_Itens",
                column: "id_Pedido_Item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Clientes",
                table: "tbl_Clientes",
                column: "id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pedido_Itens_tbl_Pedidos_id_Pedido",
                table: "tbl_Pedido_Itens",
                column: "id_Pedido",
                principalTable: "tbl_Pedidos",
                principalColumn: "id_Pedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pedido_Itens_tbl_Produtos_id_Produto",
                table: "tbl_Pedido_Itens",
                column: "id_Produto",
                principalTable: "tbl_Produtos",
                principalColumn: "id_Produto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Pedidos_tbl_Clientes_id_Cliente",
                table: "tbl_Pedidos",
                column: "id_Cliente",
                principalTable: "tbl_Clientes",
                principalColumn: "id_Cliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pedido_Itens_tbl_Pedidos_id_Pedido",
                table: "tbl_Pedido_Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pedido_Itens_tbl_Produtos_id_Produto",
                table: "tbl_Pedido_Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Pedidos_tbl_Clientes_id_Cliente",
                table: "tbl_Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Produtos",
                table: "tbl_Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Pedidos",
                table: "tbl_Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Pedido_Itens",
                table: "tbl_Pedido_Itens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Clientes",
                table: "tbl_Clientes");

            migrationBuilder.DropColumn(
                name: "vl_SubTotal",
                table: "tbl_Pedidos");

            migrationBuilder.DropColumn(
                name: "vl_Preco",
                table: "tbl_Pedido_Itens");

            migrationBuilder.RenameTable(
                name: "tbl_Produtos",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "tbl_Pedidos",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "tbl_Pedido_Itens",
                newName: "ItensPedidos");

            migrationBuilder.RenameTable(
                name: "tbl_Clientes",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "vl_Preco",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "tp_Produto",
                table: "Produtos",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "ds_Nome",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id_Produto",
                table: "Produtos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "vl_Total",
                table: "Pedidos",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "vl_Desconto",
                table: "Pedidos",
                newName: "Desconto");

            migrationBuilder.RenameColumn(
                name: "tp_Status",
                table: "Pedidos",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id_Cliente",
                table: "Pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "dt_Criacao",
                table: "Pedidos",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "id_Pedido",
                table: "Pedidos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Pedidos_id_Cliente",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "nr_Quantidade",
                table: "ItensPedidos",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "id_Produto",
                table: "ItensPedidos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "id_Pedido",
                table: "ItensPedidos",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "ds_Nome",
                table: "ItensPedidos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id_Pedido_Item",
                table: "ItensPedidos",
                newName: "ItemPedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Pedido_Itens_id_Produto",
                table: "ItensPedidos",
                newName: "IX_ItensPedidos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Pedido_Itens_id_Pedido",
                table: "ItensPedidos",
                newName: "IX_ItensPedidos_PedidoId");

            migrationBuilder.RenameColumn(
                name: "nr_Telefone",
                table: "Clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "ds_Nome",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id_Cliente",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Desconto",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Pedidos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<decimal>(
                name: "SubDesconto",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "ItensPedidos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "ItensPedidos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensPedidos",
                table: "ItensPedidos",
                column: "ItemPedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedidos_Pedidos_PedidoId",
                table: "ItensPedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedidos_Produtos_ProdutoId",
                table: "ItensPedidos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
