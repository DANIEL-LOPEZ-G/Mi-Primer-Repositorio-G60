using Microsoft.EntityFrameworkCore.Migrations;

namespace computerMaintenance.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tablaPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroIdentificacion = table.Column<int>(type: "int", nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Administrador_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuarioAdministrador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TecnicoId = table.Column<int>(type: "int", nullable: true),
                    nroTarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablaPersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablaPersona_tablaPersona_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tablaNuevaSolicitud",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    TecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablaNuevaSolicitud", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablaNuevaSolicitud_tablaPersona_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tablaNuevaSolicitud_tablaPersona_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoriaTecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecnicoId = table.Column<int>(type: "int", nullable: true),
                    NuevaSolicitudId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaTecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoriaTecnico_tablaNuevaSolicitud_NuevaSolicitudId",
                        column: x => x.NuevaSolicitudId,
                        principalTable: "tablaNuevaSolicitud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaTecnico_tablaPersona_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tablaGestionarServicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministradorId = table.Column<int>(type: "int", nullable: true),
                    NuevaSolicitudId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablaGestionarServicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablaGestionarServicio_tablaNuevaSolicitud_NuevaSolicitudId",
                        column: x => x.NuevaSolicitudId,
                        principalTable: "tablaNuevaSolicitud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tablaGestionarServicio_tablaPersona_AdministradorId",
                        column: x => x.AdministradorId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tablaHistoriaCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    NuevaSolicitudId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablaHistoriaCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablaHistoriaCliente_tablaNuevaSolicitud_NuevaSolicitudId",
                        column: x => x.NuevaSolicitudId,
                        principalTable: "tablaNuevaSolicitud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tablaHistoriaCliente_tablaPersona_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tablaPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaTecnico_NuevaSolicitudId",
                table: "HistoriaTecnico",
                column: "NuevaSolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaTecnico_TecnicoId",
                table: "HistoriaTecnico",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaGestionarServicio_AdministradorId",
                table: "tablaGestionarServicio",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaGestionarServicio_NuevaSolicitudId",
                table: "tablaGestionarServicio",
                column: "NuevaSolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaHistoriaCliente_ClienteId",
                table: "tablaHistoriaCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaHistoriaCliente_NuevaSolicitudId",
                table: "tablaHistoriaCliente",
                column: "NuevaSolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaNuevaSolicitud_ClienteId",
                table: "tablaNuevaSolicitud",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaNuevaSolicitud_TecnicoId",
                table: "tablaNuevaSolicitud",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tablaPersona_TecnicoId",
                table: "tablaPersona",
                column: "TecnicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriaTecnico");

            migrationBuilder.DropTable(
                name: "tablaGestionarServicio");

            migrationBuilder.DropTable(
                name: "tablaHistoriaCliente");

            migrationBuilder.DropTable(
                name: "tablaNuevaSolicitud");

            migrationBuilder.DropTable(
                name: "tablaPersona");
        }
    }
}
