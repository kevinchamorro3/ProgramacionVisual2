using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "corrientes",
                columns: table => new
                {
                    CorrienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_corrientes", x => x.CorrienteId);
                });

            migrationBuilder.CreateTable(
                name: "fijos",
                columns: table => new
                {
                    FijoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fijos", x => x.FijoId);
                });

            migrationBuilder.CreateTable(
                name: "patrimonios",
                columns: table => new
                {
                    PatrimonioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patrimonios", x => x.PatrimonioID);
                });

            migrationBuilder.CreateTable(
                name: "plazoCortos",
                columns: table => new
                {
                    PlazoCortoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plazoCortos", x => x.PlazoCortoId);
                });

            migrationBuilder.CreateTable(
                name: "plazoLargos",
                columns: table => new
                {
                    PlazoLargoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plazoLargos", x => x.PlazoLargoId);
                });

            migrationBuilder.CreateTable(
                name: "bancos",
                columns: table => new
                {
                    BancoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancos", x => x.BancoId);
                    table.ForeignKey(
                        name: "FK_bancos_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cajaChicas",
                columns: table => new
                {
                    CajaChicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cajaChicas", x => x.CajaChicaId);
                    table.ForeignKey(
                        name: "FK_cajaChicas_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cajas",
                columns: table => new
                {
                    CajaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cajas", x => x.CajaId);
                    table.ForeignKey(
                        name: "FK_cajas_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_clientes_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "documentosCobrars",
                columns: table => new
                {
                    DocumentosCobrarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentosCobrars", x => x.DocumentosCobrarId);
                    table.ForeignKey(
                        name: "FK_documentosCobrars_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventarios", x => x.InventarioId);
                    table.ForeignKey(
                        name: "FK_inventarios_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ivaPagados",
                columns: table => new
                {
                    IvaPagadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ivaPagados", x => x.IvaPagadoId);
                    table.ForeignKey(
                        name: "FK_ivaPagados_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "suministros",
                columns: table => new
                {
                    SuministrosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    CorrienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suministros", x => x.SuministrosId);
                    table.ForeignKey(
                        name: "FK_suministros_corrientes_CorrienteID",
                        column: x => x.CorrienteID,
                        principalTable: "corrientes",
                        principalColumn: "CorrienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "edificios",
                columns: table => new
                {
                    EdificioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepreciacionEdificioId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    FijoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edificios", x => x.EdificioId);
                    table.ForeignKey(
                        name: "FK_edificios_fijos_FijoID",
                        column: x => x.FijoID,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "equiposOficinas",
                columns: table => new
                {
                    EquiposOficinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepreciacionEquiposId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    FijoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equiposOficinas", x => x.EquiposOficinaId);
                    table.ForeignKey(
                        name: "FK_equiposOficinas_fijos_FijoID",
                        column: x => x.FijoID,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "terrenos",
                columns: table => new
                {
                    TerrenoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    FijoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_terrenos", x => x.TerrenoId);
                    table.ForeignKey(
                        name: "FK_terrenos_fijos_FijoID",
                        column: x => x.FijoID,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    FijoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_vehiculos_fijos_FijoID",
                        column: x => x.FijoID,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "capitals",
                columns: table => new
                {
                    CapitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PatrimonioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capitals", x => x.CapitalId);
                    table.ForeignKey(
                        name: "FK_capitals_patrimonios_PatrimonioID",
                        column: x => x.PatrimonioID,
                        principalTable: "patrimonios",
                        principalColumn: "PatrimonioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "utilidadEjercicios",
                columns: table => new
                {
                    UtilidadEjercicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PatrimonioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilidadEjercicios", x => x.UtilidadEjercicioId);
                    table.ForeignKey(
                        name: "FK_utilidadEjercicios_patrimonios_PatrimonioID",
                        column: x => x.PatrimonioID,
                        principalTable: "patrimonios",
                        principalColumn: "PatrimonioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "documentosPagars",
                columns: table => new
                {
                    DocumentosPagarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentosPagars", x => x.DocumentosPagarId);
                    table.ForeignKey(
                        name: "FK_documentosPagars_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ieesPagars",
                columns: table => new
                {
                    IeesPagarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ieesPagars", x => x.IeesPagarId);
                    table.ForeignKey(
                        name: "FK_ieesPagars_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "impuestosPagars",
                columns: table => new
                {
                    ImpuestosPagarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_impuestosPagars", x => x.ImpuestosPagarId);
                    table.ForeignKey(
                        name: "FK_impuestosPagars_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "interesesPagars",
                columns: table => new
                {
                    InteresesPagarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interesesPagars", x => x.InteresesPagarId);
                    table.ForeignKey(
                        name: "FK_interesesPagars_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ivaCobrados",
                columns: table => new
                {
                    IvaCobradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ivaCobrados", x => x.IvaCobradoId);
                    table.ForeignKey(
                        name: "FK_ivaCobrados_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proveedors",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoCortoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedors", x => x.ProveedorId);
                    table.ForeignKey(
                        name: "FK_proveedors_plazoCortos_PlazoCortoID",
                        column: x => x.PlazoCortoID,
                        principalTable: "plazoCortos",
                        principalColumn: "PlazoCortoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prestamosBancarios",
                columns: table => new
                {
                    PrestamosBancariosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debe = table.Column<double>(type: "float", nullable: false),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    Deudor = table.Column<double>(type: "float", nullable: false),
                    PlazoLargoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamosBancarios", x => x.PrestamosBancariosId);
                    table.ForeignKey(
                        name: "FK_prestamosBancarios_plazoLargos_PlazoLargoID",
                        column: x => x.PlazoLargoID,
                        principalTable: "plazoLargos",
                        principalColumn: "PlazoLargoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "depreciacionEdificios",
                columns: table => new
                {
                    DepreciacionEdificioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EdificioID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    FijoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depreciacionEdificios", x => x.DepreciacionEdificioId);
                    table.ForeignKey(
                        name: "FK_depreciacionEdificios_edificios_EdificioID",
                        column: x => x.EdificioID,
                        principalTable: "edificios",
                        principalColumn: "EdificioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_depreciacionEdificios_fijos_FijoId",
                        column: x => x.FijoId,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "depreciacionEquipos",
                columns: table => new
                {
                    DepreciacionEquiposId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquiposOficinaID = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haber = table.Column<double>(type: "float", nullable: false),
                    Acreedor = table.Column<double>(type: "float", nullable: false),
                    FijoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depreciacionEquipos", x => x.DepreciacionEquiposId);
                    table.ForeignKey(
                        name: "FK_depreciacionEquipos_equiposOficinas_EquiposOficinaID",
                        column: x => x.EquiposOficinaID,
                        principalTable: "equiposOficinas",
                        principalColumn: "EquiposOficinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_depreciacionEquipos_fijos_FijoId",
                        column: x => x.FijoId,
                        principalTable: "fijos",
                        principalColumn: "FijoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bancos_CorrienteID",
                table: "bancos",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_cajaChicas_CorrienteID",
                table: "cajaChicas",
                column: "CorrienteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cajas_CorrienteID",
                table: "cajas",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_capitals_PatrimonioID",
                table: "capitals",
                column: "PatrimonioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_CorrienteID",
                table: "clientes",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_depreciacionEdificios_EdificioID",
                table: "depreciacionEdificios",
                column: "EdificioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_depreciacionEdificios_FijoId",
                table: "depreciacionEdificios",
                column: "FijoId");

            migrationBuilder.CreateIndex(
                name: "IX_depreciacionEquipos_EquiposOficinaID",
                table: "depreciacionEquipos",
                column: "EquiposOficinaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_depreciacionEquipos_FijoId",
                table: "depreciacionEquipos",
                column: "FijoId");

            migrationBuilder.CreateIndex(
                name: "IX_documentosCobrars_CorrienteID",
                table: "documentosCobrars",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_documentosPagars_PlazoCortoID",
                table: "documentosPagars",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_edificios_FijoID",
                table: "edificios",
                column: "FijoID");

            migrationBuilder.CreateIndex(
                name: "IX_equiposOficinas_FijoID",
                table: "equiposOficinas",
                column: "FijoID");

            migrationBuilder.CreateIndex(
                name: "IX_ieesPagars_PlazoCortoID",
                table: "ieesPagars",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_impuestosPagars_PlazoCortoID",
                table: "impuestosPagars",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_interesesPagars_PlazoCortoID",
                table: "interesesPagars",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_inventarios_CorrienteID",
                table: "inventarios",
                column: "CorrienteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ivaCobrados_PlazoCortoID",
                table: "ivaCobrados",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_ivaPagados_CorrienteID",
                table: "ivaPagados",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_prestamosBancarios_PlazoLargoID",
                table: "prestamosBancarios",
                column: "PlazoLargoID");

            migrationBuilder.CreateIndex(
                name: "IX_proveedors_PlazoCortoID",
                table: "proveedors",
                column: "PlazoCortoID");

            migrationBuilder.CreateIndex(
                name: "IX_suministros_CorrienteID",
                table: "suministros",
                column: "CorrienteID");

            migrationBuilder.CreateIndex(
                name: "IX_terrenos_FijoID",
                table: "terrenos",
                column: "FijoID");

            migrationBuilder.CreateIndex(
                name: "IX_utilidadEjercicios_PatrimonioID",
                table: "utilidadEjercicios",
                column: "PatrimonioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_FijoID",
                table: "vehiculos",
                column: "FijoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bancos");

            migrationBuilder.DropTable(
                name: "cajaChicas");

            migrationBuilder.DropTable(
                name: "cajas");

            migrationBuilder.DropTable(
                name: "capitals");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "depreciacionEdificios");

            migrationBuilder.DropTable(
                name: "depreciacionEquipos");

            migrationBuilder.DropTable(
                name: "documentosCobrars");

            migrationBuilder.DropTable(
                name: "documentosPagars");

            migrationBuilder.DropTable(
                name: "ieesPagars");

            migrationBuilder.DropTable(
                name: "impuestosPagars");

            migrationBuilder.DropTable(
                name: "interesesPagars");

            migrationBuilder.DropTable(
                name: "inventarios");

            migrationBuilder.DropTable(
                name: "ivaCobrados");

            migrationBuilder.DropTable(
                name: "ivaPagados");

            migrationBuilder.DropTable(
                name: "prestamosBancarios");

            migrationBuilder.DropTable(
                name: "proveedors");

            migrationBuilder.DropTable(
                name: "suministros");

            migrationBuilder.DropTable(
                name: "terrenos");

            migrationBuilder.DropTable(
                name: "utilidadEjercicios");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "edificios");

            migrationBuilder.DropTable(
                name: "equiposOficinas");

            migrationBuilder.DropTable(
                name: "plazoLargos");

            migrationBuilder.DropTable(
                name: "plazoCortos");

            migrationBuilder.DropTable(
                name: "corrientes");

            migrationBuilder.DropTable(
                name: "patrimonios");

            migrationBuilder.DropTable(
                name: "fijos");
        }
    }
}
