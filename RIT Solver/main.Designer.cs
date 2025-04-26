using CefSharp;
using CefSharp.WinForms;
using FlowControls;

namespace RIT_Solver
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mis Proyectos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Actividades");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Pendientes por hacer");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Historico de Estadisticas Mensuales", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Seguimiento de Guias", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Solicitudes de Viaticos");
            this.contextMenuStripNodos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tableLayoutPanelFondoGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Pages = new flCustomTabControl();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelProyectos = new System.Windows.Forms.TableLayoutPanel();
            this.MDI_RIT_Panel = new System.Windows.Forms.Panel();
            this.pgrssbarAbrirFormularios = new System.Windows.Forms.ProgressBar();
            this.lblProyectos_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanelProyectos_Nodos = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewProyectos = new System.Windows.Forms.TreeView();
            this.imageList_RIT = new System.Windows.Forms.ImageList(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNombreDeNodoSeleccionado = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNodoDeProyectosSeleccionado = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolNuevoProyecto = new System.Windows.Forms.ToolStripButton();
            this.toolAbrirProyectoExistente = new System.Windows.Forms.ToolStripButton();
            this.toolEliminarProyecto = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnCerrarProyectoActual = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpBtn_AbrirSegun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrpBtnGuardarTodosLosProyectosActuales = new System.Windows.Forms.ToolStripButton();
            this.toolMinimizarTodosLosReportes = new System.Windows.Forms.ToolStripButton();
            this.toolStrpBtnCerrarTodosLosRitsAbiertos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.toolGeneracionRapidaDeReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolLblActualMDIReporteName = new System.Windows.Forms.ToolStripLabel();
            this.tabFormCompusof = new System.Windows.Forms.TabPage();
            this.webView_CompusofForms = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.statusStripForms = new System.Windows.Forms.StatusStrip();
            this.toolBtnRecargarForms = new System.Windows.Forms.ToolStripButton();
            this.URL_RIT_Forms_Label = new System.Windows.Forms.ToolStripLabel();
            this.tabServiceDeskGMXT = new System.Windows.Forms.TabPage();
            chromiumWebBrowserSASGMXT = new CefSharp.WinForms.ChromiumWebBrowser();
            this.statusStripSDPGMXT = new System.Windows.Forms.StatusStrip();
            this.toolBtnRecargarSAS = new System.Windows.Forms.ToolStripButton();
            this.URL_GMXT_SAS_Label = new System.Windows.Forms.ToolStripLabel();
            this.tabServiceDeskCompusof = new System.Windows.Forms.TabPage();
            this.webView_ServiceDeskCompusof = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.statusStripEndPointcentral = new System.Windows.Forms.StatusStrip();
            this.toolBtnRecargarSDPCompusof = new System.Windows.Forms.ToolStripButton();
            this.URL_SDP_Compusof_Label = new System.Windows.Forms.ToolStripLabel();
            this.tabEndpointCentral = new System.Windows.Forms.TabPage();
            this.chromiumWebBrowserEndPointCentral = new CefSharp.WinForms.ChromiumWebBrowser();
            this.statusStripSDPCompusof = new System.Windows.Forms.StatusStrip();
            this.toolBtnRecargarServiceDeskCompusof = new System.Windows.Forms.ToolStripButton();
            this.URL_EndPoint_Central_Label = new System.Windows.Forms.ToolStripLabel();
            this.tabCentroDeControl = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCentroDeControl = new System.Windows.Forms.TableLayoutPanel();
            this.MDI_ACT_Panel = new System.Windows.Forms.Panel();
            this.lblCentroControl_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanelCentroDeControl_Nodos = new System.Windows.Forms.TableLayoutPanel();
            this.treeViewCentroDeControl = new System.Windows.Forms.TreeView();
            this.imageList_Actividades = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDescripcionDeNodo = new System.Windows.Forms.Label();
            this.lblNombreNodoSeleccionado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreSeccion = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCrearActividad = new System.Windows.Forms.ToolStripButton();
            this.toolAbrirActividad = new System.Windows.Forms.ToolStripButton();
            this.toolEliminarActividad = new System.Windows.Forms.ToolStripButton();
            this.toolCerrarActividad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolImportarActividad = new System.Windows.Forms.ToolStripButton();
            this.toolExportarActividad = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolNuevoPendientePorHacer = new System.Windows.Forms.ToolStripButton();
            this.toolImportarListaDePendientes = new System.Windows.Forms.ToolStripButton();
            this.toolEliminarListaDePendientesPorHacer = new System.Windows.Forms.ToolStripButton();
            this.toolCerrarListaDePendientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNuevaSeccion = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrpBtnMinimizarTodasLasVentanas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolLblActualMDIActividadName = new System.Windows.Forms.ToolStripLabel();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuOpcionesActividades = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.maximizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.enviarAvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarPermanentementeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcionesAnuncios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearAnuncioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAnuncioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.maximizarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minizarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDeLaVistaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.borrarPermanentementeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda = new System.Windows.Forms.TableLayoutPanel();
            this.btnFuncion2 = new System.Windows.Forms.Button();
            this.btnFuncion1 = new System.Windows.Forms.Button();
            this.lblContactoFallos = new System.Windows.Forms.LinkLabel();
            this.btnFuncion3 = new System.Windows.Forms.Button();
            this.tableLayoutPanelBarraMultifuncion = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuOpcionesDeProyectos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAnuncioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarActualizacionesBETAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sistemaDeInventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeHistorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoDeGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirRITEnBlancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.herramientaDeReparacionAvanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarFallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarSASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarManageDeskCompusofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarEndpointCentralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionesWebMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarRefaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarTonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escaladoDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organigramaDeContactoCompusofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pCIETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarEnCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omisorDeComprobacionesDeOracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarEnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarEnCarpetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalDiskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gtrabrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_StartScreen = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_WaitScreen = new System.ComponentModel.BackgroundWorker();
            this.bgworker_RitSolverUpdater = new System.ComponentModel.BackgroundWorker();
            this.bgworkerMDIsFormsLoader = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStripNodos.SuspendLayout();
            this.tableLayoutPanelFondoGeneral.SuspendLayout();
            this.tabControl_Pages.SuspendLayout();
            this.tabProyectos.SuspendLayout();
            this.tableLayoutPanelProyectos.SuspendLayout();
            this.MDI_RIT_Panel.SuspendLayout();
            this.tableLayoutPanelProyectos_Nodos.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabFormCompusof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_CompusofForms)).BeginInit();
            this.statusStripForms.SuspendLayout();
            this.tabServiceDeskGMXT.SuspendLayout();
            this.statusStripSDPGMXT.SuspendLayout();
            this.tabServiceDeskCompusof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_ServiceDeskCompusof)).BeginInit();
            this.statusStripEndPointcentral.SuspendLayout();
            this.tabEndpointCentral.SuspendLayout();
            this.statusStripSDPCompusof.SuspendLayout();
            this.tabCentroDeControl.SuspendLayout();
            this.tableLayoutPanelCentroDeControl.SuspendLayout();
            this.MDI_ACT_Panel.SuspendLayout();
            this.tableLayoutPanelCentroDeControl_Nodos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuOpcionesActividades.SuspendLayout();
            this.menuOpcionesAnuncios.SuspendLayout();
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.SuspendLayout();
            this.tableLayoutPanelBarraMultifuncion.SuspendLayout();
            this.panel7.SuspendLayout();
            this.menuOpcionesDeProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripNodos
            // 
            this.contextMenuStripNodos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.cerrarProyectoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripSeparator19,
            this.minimizarProyectoToolStripMenuItem});
            this.contextMenuStripNodos.Name = "contextMenuStripNodos";
            this.contextMenuStripNodos.Size = new System.Drawing.Size(291, 140);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::RIT_Solver.Properties.Resources.project;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(290, 26);
            this.toolStripMenuItem2.Text = "Nuevo proyecto";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::RIT_Solver.Properties.Resources.project_delete;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 26);
            this.toolStripMenuItem1.Text = "Eliminar proyecto seleccionado";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolEliminarProyecto_Click);
            // 
            // cerrarProyectoToolStripMenuItem
            // 
            this.cerrarProyectoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.cerrarProyectoToolStripMenuItem.Name = "cerrarProyectoToolStripMenuItem";
            this.cerrarProyectoToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.cerrarProyectoToolStripMenuItem.Text = "Cerrar proyecto";
            this.cerrarProyectoToolStripMenuItem.Click += new System.EventHandler(this.cerrarProyectoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(290, 26);
            this.toolStripMenuItem3.Text = "Enviar por correo";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(287, 6);
            // 
            // minimizarProyectoToolStripMenuItem
            // 
            this.minimizarProyectoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.minimize_window_32;
            this.minimizarProyectoToolStripMenuItem.Name = "minimizarProyectoToolStripMenuItem";
            this.minimizarProyectoToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.minimizarProyectoToolStripMenuItem.Text = "Minimizar proyecto";
            this.minimizarProyectoToolStripMenuItem.Click += new System.EventHandler(this.minimizarProyectoToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // tableLayoutPanelFondoGeneral
            // 
            this.tableLayoutPanelFondoGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelFondoGeneral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanelFondoGeneral.ColumnCount = 1;
            this.tableLayoutPanelFondoGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFondoGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFondoGeneral.Controls.Add(this.tabControl_Pages, 0, 1);
            this.tableLayoutPanelFondoGeneral.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanelFondoGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFondoGeneral.Name = "tableLayoutPanelFondoGeneral";
            this.tableLayoutPanelFondoGeneral.RowCount = 2;
            this.tableLayoutPanelFondoGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5020914F));
            this.tableLayoutPanelFondoGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.91939F));
            this.tableLayoutPanelFondoGeneral.Size = new System.Drawing.Size(1339, 614);
            this.tableLayoutPanelFondoGeneral.TabIndex = 2;
            // 
            // tabControl_Pages
            // 
            this.tabControl_Pages.Controls.Add(this.tabProyectos);
            this.tabControl_Pages.Controls.Add(this.tabFormCompusof);
            this.tabControl_Pages.Controls.Add(this.tabServiceDeskGMXT);
            this.tabControl_Pages.Controls.Add(this.tabServiceDeskCompusof);
            this.tabControl_Pages.Controls.Add(this.tabEndpointCentral);
            this.tabControl_Pages.Controls.Add(this.tabCentroDeControl);
            this.tabControl_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Pages.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Pages.HotTrack = true;
            this.tabControl_Pages.ItemSize = new System.Drawing.Size(200, 35);
            this.tabControl_Pages.Location = new System.Drawing.Point(0, 3);
            this.tabControl_Pages.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_Pages.Name = "tabControl_Pages";
            this.tabControl_Pages.SelectedIndex = 0;
            this.tabControl_Pages.Size = new System.Drawing.Size(1339, 611);
            this.tabControl_Pages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Pages.TabIndex = 3;
            this.tabControl_Pages.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabProyectos
            // 
            this.tabProyectos.BackColor = System.Drawing.Color.DimGray;
            this.tabProyectos.Controls.Add(this.tableLayoutPanelProyectos);
            this.tabProyectos.Controls.Add(this.toolStrip2);
            this.tabProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProyectos.Location = new System.Drawing.Point(4, 39);
            this.tabProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Size = new System.Drawing.Size(1331, 568);
            this.tabProyectos.TabIndex = 5;
            this.tabProyectos.Text = "Proyectos";
            // 
            // tableLayoutPanelProyectos
            // 
            this.tableLayoutPanelProyectos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelProyectos.ColumnCount = 2;
            this.tableLayoutPanelProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.47059F));
            this.tableLayoutPanelProyectos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.52941F));
            this.tableLayoutPanelProyectos.Controls.Add(this.MDI_RIT_Panel, 0, 0);
            this.tableLayoutPanelProyectos.Controls.Add(this.tableLayoutPanelProyectos_Nodos, 0, 0);
            this.tableLayoutPanelProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProyectos.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanelProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelProyectos.Name = "tableLayoutPanelProyectos";
            this.tableLayoutPanelProyectos.RowCount = 1;
            this.tableLayoutPanelProyectos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProyectos.Size = new System.Drawing.Size(1331, 541);
            this.tableLayoutPanelProyectos.TabIndex = 1;
            // 
            // MDI_RIT_Panel
            // 
            this.MDI_RIT_Panel.BackColor = System.Drawing.Color.DarkGray;
            this.MDI_RIT_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MDI_RIT_Panel.Controls.Add(this.pgrssbarAbrirFormularios);
            this.MDI_RIT_Panel.Controls.Add(this.lblProyectos_Text);
            this.MDI_RIT_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDI_RIT_Panel.Location = new System.Drawing.Point(223, 3);
            this.MDI_RIT_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.MDI_RIT_Panel.Name = "MDI_RIT_Panel";
            this.MDI_RIT_Panel.Size = new System.Drawing.Size(1105, 535);
            this.MDI_RIT_Panel.TabIndex = 1;
            this.MDI_RIT_Panel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MDI_RIT_Panel_ControlAdded);
            this.MDI_RIT_Panel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MDI_RIT_Panel_ControlRemoved);
            // 
            // pgrssbarAbrirFormularios
            // 
            this.pgrssbarAbrirFormularios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgrssbarAbrirFormularios.Location = new System.Drawing.Point(0, 526);
            this.pgrssbarAbrirFormularios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgrssbarAbrirFormularios.Name = "pgrssbarAbrirFormularios";
            this.pgrssbarAbrirFormularios.Size = new System.Drawing.Size(1101, 5);
            this.pgrssbarAbrirFormularios.TabIndex = 3;
            // 
            // lblProyectos_Text
            // 
            this.lblProyectos_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProyectos_Text.Font = new System.Drawing.Font("Microsoft New Tai Lue", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectos_Text.Location = new System.Drawing.Point(0, 0);
            this.lblProyectos_Text.Name = "lblProyectos_Text";
            this.lblProyectos_Text.Size = new System.Drawing.Size(1101, 531);
            this.lblProyectos_Text.TabIndex = 2;
            this.lblProyectos_Text.Text = "Bienvenido a RIT Solver!";
            this.lblProyectos_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelProyectos_Nodos
            // 
            this.tableLayoutPanelProyectos_Nodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelProyectos_Nodos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelProyectos_Nodos.ColumnCount = 1;
            this.tableLayoutPanelProyectos_Nodos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelProyectos_Nodos.Controls.Add(this.treeViewProyectos, 0, 1);
            this.tableLayoutPanelProyectos_Nodos.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanelProyectos_Nodos.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanelProyectos_Nodos.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelProyectos_Nodos.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelProyectos_Nodos.Name = "tableLayoutPanelProyectos_Nodos";
            this.tableLayoutPanelProyectos_Nodos.RowCount = 3;
            this.tableLayoutPanelProyectos_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelProyectos_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelProyectos_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelProyectos_Nodos.Size = new System.Drawing.Size(217, 535);
            this.tableLayoutPanelProyectos_Nodos.TabIndex = 0;
            // 
            // treeViewProyectos
            // 
            this.treeViewProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProyectos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold);
            this.treeViewProyectos.ImageIndex = 0;
            this.treeViewProyectos.ImageList = this.imageList_RIT;
            this.treeViewProyectos.ItemHeight = 32;
            this.treeViewProyectos.Location = new System.Drawing.Point(3, 47);
            this.treeViewProyectos.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewProyectos.Name = "treeViewProyectos";
            treeNode1.Name = "nodeMisProyectos";
            treeNode1.Text = "Mis Proyectos";
            this.treeViewProyectos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewProyectos.SelectedImageIndex = 0;
            this.treeViewProyectos.Size = new System.Drawing.Size(216, 313);
            this.treeViewProyectos.TabIndex = 0;
            this.treeViewProyectos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProyectos_AfterSelect);
            this.treeViewProyectos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProyectos_NodeMouseDoubleClick);
            // 
            // imageList_RIT
            // 
            this.imageList_RIT.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_RIT.ImageStream")));
            this.imageList_RIT.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_RIT.Images.SetKeyName(0, "open-folder.png");
            this.imageList_RIT.Images.SetKeyName(1, "project-128.png");
            this.imageList_RIT.Images.SetKeyName(2, "project-comprobado.png");
            this.imageList_RIT.Images.SetKeyName(3, "project-printed.png");
            this.imageList_RIT.Images.SetKeyName(4, "project-signed.png");
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.lblNombreDeNodoSeleccionado);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 363);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 169);
            this.panel6.TabIndex = 2;
            // 
            // lblNombreDeNodoSeleccionado
            // 
            this.lblNombreDeNodoSeleccionado.BackColor = System.Drawing.Color.Gray;
            this.lblNombreDeNodoSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombreDeNodoSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreDeNodoSeleccionado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNombreDeNodoSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.lblNombreDeNodoSeleccionado.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lblNombreDeNodoSeleccionado.Name = "lblNombreDeNodoSeleccionado";
            this.lblNombreDeNodoSeleccionado.Size = new System.Drawing.Size(216, 169);
            this.lblNombreDeNodoSeleccionado.TabIndex = 3;
            this.lblNombreDeNodoSeleccionado.Text = "";
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.lblNodoDeProyectosSeleccionado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 41);
            this.panel4.TabIndex = 0;
            // 
            // lblNodoDeProyectosSeleccionado
            // 
            this.lblNodoDeProyectosSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNodoDeProyectosSeleccionado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNodoDeProyectosSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNodoDeProyectosSeleccionado.Location = new System.Drawing.Point(0, 0);
            this.lblNodoDeProyectosSeleccionado.Margin = new System.Windows.Forms.Padding(0);
            this.lblNodoDeProyectosSeleccionado.Name = "lblNodoDeProyectosSeleccionado";
            this.lblNodoDeProyectosSeleccionado.Size = new System.Drawing.Size(216, 41);
            this.lblNodoDeProyectosSeleccionado.TabIndex = 1;
            this.lblNodoDeProyectosSeleccionado.Text = "Ejemplo de seccion de";
            this.lblNodoDeProyectosSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevoProyecto,
            this.toolAbrirProyectoExistente,
            this.toolEliminarProyecto,
            this.toolStrpBtnCerrarProyectoActual,
            this.toolStripSeparator16,
            this.toolStrpBtn_AbrirSegun,
            this.toolStripSeparator8,
            this.toolStrpBtnGuardarTodosLosProyectosActuales,
            this.toolMinimizarTodosLosReportes,
            this.toolStrpBtnCerrarTodosLosRitsAbiertos,
            this.toolStripSeparator18,
            this.toolGeneracionRapidaDeReporte,
            this.toolStripLabel4,
            this.toolStripLabel3,
            this.toolLblActualMDIReporteName});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1331, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolNuevoProyecto
            // 
            this.toolNuevoProyecto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevoProyecto.Image = global::RIT_Solver.Properties.Resources.project;
            this.toolNuevoProyecto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevoProyecto.Name = "toolNuevoProyecto";
            this.toolNuevoProyecto.Size = new System.Drawing.Size(29, 24);
            this.toolNuevoProyecto.Text = "Crear un nuevo proyecto RIT";
            this.toolNuevoProyecto.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // toolAbrirProyectoExistente
            // 
            this.toolAbrirProyectoExistente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbrirProyectoExistente.Image = global::RIT_Solver.Properties.Resources.project_open;
            this.toolAbrirProyectoExistente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbrirProyectoExistente.Name = "toolAbrirProyectoExistente";
            this.toolAbrirProyectoExistente.Size = new System.Drawing.Size(29, 24);
            this.toolAbrirProyectoExistente.Text = "Abrir proyecto existente";
            this.toolAbrirProyectoExistente.Click += new System.EventHandler(this.abrirTicketToolStripMenuItem_Click);
            // 
            // toolEliminarProyecto
            // 
            this.toolEliminarProyecto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminarProyecto.Enabled = false;
            this.toolEliminarProyecto.Image = global::RIT_Solver.Properties.Resources.project_delete;
            this.toolEliminarProyecto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminarProyecto.Name = "toolEliminarProyecto";
            this.toolEliminarProyecto.Size = new System.Drawing.Size(29, 24);
            this.toolEliminarProyecto.Text = "Eliminar este proyecto";
            this.toolEliminarProyecto.Click += new System.EventHandler(this.toolEliminarProyecto_Click);
            // 
            // toolStrpBtnCerrarProyectoActual
            // 
            this.toolStrpBtnCerrarProyectoActual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtnCerrarProyectoActual.Enabled = false;
            this.toolStrpBtnCerrarProyectoActual.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.toolStrpBtnCerrarProyectoActual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnCerrarProyectoActual.Name = "toolStrpBtnCerrarProyectoActual";
            this.toolStrpBtnCerrarProyectoActual.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtnCerrarProyectoActual.Text = "Cerrar proyecto actual...";
            this.toolStrpBtnCerrarProyectoActual.Click += new System.EventHandler(this.toolStrpBtnCerrarProyectoActual_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrpBtn_AbrirSegun
            // 
            this.toolStrpBtn_AbrirSegun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtn_AbrirSegun.Image = global::RIT_Solver.Properties.Resources.selection_items_32;
            this.toolStrpBtn_AbrirSegun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtn_AbrirSegun.Name = "toolStrpBtn_AbrirSegun";
            this.toolStrpBtn_AbrirSegun.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtn_AbrirSegun.Text = "Abrir solo segun...";
            this.toolStrpBtn_AbrirSegun.Click += new System.EventHandler(this.toolStrpBtn_AbrirSegun_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrpBtnGuardarTodosLosProyectosActuales
            // 
            this.toolStrpBtnGuardarTodosLosProyectosActuales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Enabled = false;
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Image = global::RIT_Solver.Properties.Resources.save_all2;
            this.toolStrpBtnGuardarTodosLosProyectosActuales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Name = "toolStrpBtnGuardarTodosLosProyectosActuales";
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Text = "Guardar todos los proyectos abiertos";
            this.toolStrpBtnGuardarTodosLosProyectosActuales.Click += new System.EventHandler(this.toolStrpBtnGuardarTodosLosProyectosActuales_Click);
            // 
            // toolMinimizarTodosLosReportes
            // 
            this.toolMinimizarTodosLosReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMinimizarTodosLosReportes.Enabled = false;
            this.toolMinimizarTodosLosReportes.Image = global::RIT_Solver.Properties.Resources.minimize_all_windows;
            this.toolMinimizarTodosLosReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMinimizarTodosLosReportes.Name = "toolMinimizarTodosLosReportes";
            this.toolMinimizarTodosLosReportes.Size = new System.Drawing.Size(29, 24);
            this.toolMinimizarTodosLosReportes.Text = "Minimizar todos los proyectos abiertos";
            this.toolMinimizarTodosLosReportes.Click += new System.EventHandler(this.toolMinimizarTodosLosReportes_Click);
            // 
            // toolStrpBtnCerrarTodosLosRitsAbiertos
            // 
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Enabled = false;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Image = global::RIT_Solver.Properties.Resources.close_all_38;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Name = "toolStrpBtnCerrarTodosLosRitsAbiertos";
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Text = "Cerrar todos los proyectos abiertos...";
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Click += new System.EventHandler(this.toolStrpBtnCerrarTodosLosRitsAbiertos_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 27);
            // 
            // toolGeneracionRapidaDeReporte
            // 
            this.toolGeneracionRapidaDeReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGeneracionRapidaDeReporte.Enabled = false;
            this.toolGeneracionRapidaDeReporte.Image = global::RIT_Solver.Properties.Resources.fast_64;
            this.toolGeneracionRapidaDeReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGeneracionRapidaDeReporte.Name = "toolGeneracionRapidaDeReporte";
            this.toolGeneracionRapidaDeReporte.Size = new System.Drawing.Size(29, 24);
            this.toolGeneracionRapidaDeReporte.Text = "Generacion rapida de RIT";
            this.toolGeneracionRapidaDeReporte.Click += new System.EventHandler(this.toolGeneracionRapidaDeReporte_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel4.Text = "       ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(86, 24);
            this.toolStripLabel3.Text = "Actual MDI:";
            // 
            // toolLblActualMDIReporteName
            // 
            this.toolLblActualMDIReporteName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolLblActualMDIReporteName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolLblActualMDIReporteName.Name = "toolLblActualMDIReporteName";
            this.toolLblActualMDIReporteName.Size = new System.Drawing.Size(15, 24);
            this.toolLblActualMDIReporteName.Text = "-";
            // 
            // tabFormCompusof
            // 
            this.tabFormCompusof.Controls.Add(this.webView_CompusofForms);
            this.tabFormCompusof.Controls.Add(this.statusStripForms);
            this.tabFormCompusof.Location = new System.Drawing.Point(4, 39);
            this.tabFormCompusof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormCompusof.Name = "tabFormCompusof";
            this.tabFormCompusof.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormCompusof.Size = new System.Drawing.Size(1331, 568);
            this.tabFormCompusof.TabIndex = 3;
            this.tabFormCompusof.Text = "Compusof Forms";
            this.tabFormCompusof.UseVisualStyleBackColor = true;
            // 
            // webView_CompusofForms
            // 
            this.webView_CompusofForms.AllowExternalDrop = true;
            this.webView_CompusofForms.CreationProperties = null;
            this.webView_CompusofForms.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_CompusofForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_CompusofForms.Location = new System.Drawing.Point(3, 2);
            this.webView_CompusofForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView_CompusofForms.Name = "webView_CompusofForms";
            this.webView_CompusofForms.Size = new System.Drawing.Size(1325, 538);
            this.webView_CompusofForms.TabIndex = 1;
            this.webView_CompusofForms.ZoomFactor = 1D;
            this.webView_CompusofForms.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView_CompusofForms_CoreWebView2InitializationCompleted);
            this.webView_CompusofForms.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_CompusofForms_NavigationStarting);
            // 
            // statusStripForms
            // 
            this.statusStripForms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRecargarForms,
            this.URL_RIT_Forms_Label});
            this.statusStripForms.Location = new System.Drawing.Point(3, 540);
            this.statusStripForms.Name = "statusStripForms";
            this.statusStripForms.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripForms.Size = new System.Drawing.Size(1325, 26);
            this.statusStripForms.TabIndex = 0;
            // 
            // toolBtnRecargarForms
            // 
            this.toolBtnRecargarForms.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolBtnRecargarForms.Name = "toolBtnRecargarForms";
            this.toolBtnRecargarForms.Size = new System.Drawing.Size(92, 24);
            this.toolBtnRecargarForms.Text = "Recargar";
            this.toolBtnRecargarForms.Click += new System.EventHandler(this.recargarFormsToolStripMenuItem_Click);
            // 
            // URL_RIT_Forms_Label
            // 
            this.URL_RIT_Forms_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.URL_RIT_Forms_Label.Name = "URL_RIT_Forms_Label";
            this.URL_RIT_Forms_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabServiceDeskGMXT
            // 
            this.tabServiceDeskGMXT.AutoScroll = true;
            this.tabServiceDeskGMXT.Controls.Add(chromiumWebBrowserSASGMXT);
            this.tabServiceDeskGMXT.Controls.Add(this.statusStripSDPGMXT);
            this.tabServiceDeskGMXT.Location = new System.Drawing.Point(4, 39);
            this.tabServiceDeskGMXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabServiceDeskGMXT.Name = "tabServiceDeskGMXT";
            this.tabServiceDeskGMXT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabServiceDeskGMXT.Size = new System.Drawing.Size(1331, 568);
            this.tabServiceDeskGMXT.TabIndex = 1;
            this.tabServiceDeskGMXT.Text = "ServiceDesk GMXT";
            this.tabServiceDeskGMXT.UseVisualStyleBackColor = true;
            // 
            // chromiumWebBrowserSASGMXT
            // 
            chromiumWebBrowserSASGMXT.ActivateBrowserOnCreation = false;
            chromiumWebBrowserSASGMXT.Dock = System.Windows.Forms.DockStyle.Fill;
            chromiumWebBrowserSASGMXT.Location = new System.Drawing.Point(3, 2);
            chromiumWebBrowserSASGMXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chromiumWebBrowserSASGMXT.Name = "chromiumWebBrowserSASGMXT";
            chromiumWebBrowserSASGMXT.Size = new System.Drawing.Size(1325, 538);
            chromiumWebBrowserSASGMXT.TabIndex = 0;
            chromiumWebBrowserSASGMXT.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumWebBrowserSASGMXT_AddressChanged);
            // 
            // statusStripSDPGMXT
            // 
            this.statusStripSDPGMXT.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripSDPGMXT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRecargarSAS,
            this.URL_GMXT_SAS_Label});
            this.statusStripSDPGMXT.Location = new System.Drawing.Point(3, 540);
            this.statusStripSDPGMXT.Name = "statusStripSDPGMXT";
            this.statusStripSDPGMXT.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripSDPGMXT.Size = new System.Drawing.Size(1325, 26);
            this.statusStripSDPGMXT.TabIndex = 0;
            // 
            // toolBtnRecargarSAS
            // 
            this.toolBtnRecargarSAS.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolBtnRecargarSAS.Name = "toolBtnRecargarSAS";
            this.toolBtnRecargarSAS.Size = new System.Drawing.Size(92, 24);
            this.toolBtnRecargarSAS.Text = "Recargar";
            this.toolBtnRecargarSAS.Click += new System.EventHandler(this.recargarSASToolStripMenuItem_Click);
            // 
            // URL_GMXT_SAS_Label
            // 
            this.URL_GMXT_SAS_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.URL_GMXT_SAS_Label.Name = "URL_GMXT_SAS_Label";
            this.URL_GMXT_SAS_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabServiceDeskCompusof
            // 
            this.tabServiceDeskCompusof.Controls.Add(this.webView_ServiceDeskCompusof);
            this.tabServiceDeskCompusof.Controls.Add(this.statusStripEndPointcentral);
            this.tabServiceDeskCompusof.Location = new System.Drawing.Point(4, 39);
            this.tabServiceDeskCompusof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabServiceDeskCompusof.Name = "tabServiceDeskCompusof";
            this.tabServiceDeskCompusof.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabServiceDeskCompusof.Size = new System.Drawing.Size(1331, 568);
            this.tabServiceDeskCompusof.TabIndex = 4;
            this.tabServiceDeskCompusof.Text = "ServiceDesk Compusof";
            this.tabServiceDeskCompusof.UseVisualStyleBackColor = true;
            // 
            // webView_ServiceDeskCompusof
            // 
            this.webView_ServiceDeskCompusof.AllowExternalDrop = true;
            this.webView_ServiceDeskCompusof.CreationProperties = null;
            this.webView_ServiceDeskCompusof.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_ServiceDeskCompusof.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView_ServiceDeskCompusof.Location = new System.Drawing.Point(3, 2);
            this.webView_ServiceDeskCompusof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webView_ServiceDeskCompusof.Name = "webView_ServiceDeskCompusof";
            this.webView_ServiceDeskCompusof.Size = new System.Drawing.Size(1325, 538);
            this.webView_ServiceDeskCompusof.TabIndex = 1;
            this.webView_ServiceDeskCompusof.ZoomFactor = 1D;
            this.webView_ServiceDeskCompusof.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.webView_ManageEngineEndpointCentral_CoreWebView2InitializationCompleted);
            this.webView_ServiceDeskCompusof.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_ManageEngineEndpointCentral_NavigationStarting);
            // 
            // statusStripEndPointcentral
            // 
            this.statusStripEndPointcentral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripEndPointcentral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRecargarSDPCompusof,
            this.URL_SDP_Compusof_Label});
            this.statusStripEndPointcentral.Location = new System.Drawing.Point(3, 540);
            this.statusStripEndPointcentral.Name = "statusStripEndPointcentral";
            this.statusStripEndPointcentral.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripEndPointcentral.Size = new System.Drawing.Size(1325, 26);
            this.statusStripEndPointcentral.TabIndex = 0;
            // 
            // toolBtnRecargarSDPCompusof
            // 
            this.toolBtnRecargarSDPCompusof.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolBtnRecargarSDPCompusof.Name = "toolBtnRecargarSDPCompusof";
            this.toolBtnRecargarSDPCompusof.Size = new System.Drawing.Size(92, 24);
            this.toolBtnRecargarSDPCompusof.Text = "Recargar";
            this.toolBtnRecargarSDPCompusof.Click += new System.EventHandler(this.recargarEndpointCentralToolStripMenuItem_Click);
            // 
            // URL_SDP_Compusof_Label
            // 
            this.URL_SDP_Compusof_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.URL_SDP_Compusof_Label.Name = "URL_SDP_Compusof_Label";
            this.URL_SDP_Compusof_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabEndpointCentral
            // 
            this.tabEndpointCentral.Controls.Add(this.chromiumWebBrowserEndPointCentral);
            this.tabEndpointCentral.Controls.Add(this.statusStripSDPCompusof);
            this.tabEndpointCentral.Location = new System.Drawing.Point(4, 39);
            this.tabEndpointCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEndpointCentral.Name = "tabEndpointCentral";
            this.tabEndpointCentral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEndpointCentral.Size = new System.Drawing.Size(1331, 568);
            this.tabEndpointCentral.TabIndex = 2;
            this.tabEndpointCentral.Text = "Endpoint Central";
            this.tabEndpointCentral.UseVisualStyleBackColor = true;
            // 
            // chromiumWebBrowserEndPointCentral
            // 
            this.chromiumWebBrowserEndPointCentral.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowserEndPointCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowserEndPointCentral.Location = new System.Drawing.Point(3, 2);
            this.chromiumWebBrowserEndPointCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chromiumWebBrowserEndPointCentral.Name = "chromiumWebBrowserEndPointCentral";
            this.chromiumWebBrowserEndPointCentral.Size = new System.Drawing.Size(1325, 538);
            this.chromiumWebBrowserEndPointCentral.TabIndex = 2;
            this.chromiumWebBrowserEndPointCentral.AddressChanged += new System.EventHandler<CefSharp.AddressChangedEventArgs>(this.chromiumWebBrowserCompusofServiceDesk_AddressChanged);
            // 
            // statusStripSDPCompusof
            // 
            this.statusStripSDPCompusof.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripSDPCompusof.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRecargarServiceDeskCompusof,
            this.URL_EndPoint_Central_Label});
            this.statusStripSDPCompusof.Location = new System.Drawing.Point(3, 540);
            this.statusStripSDPCompusof.Name = "statusStripSDPCompusof";
            this.statusStripSDPCompusof.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripSDPCompusof.Size = new System.Drawing.Size(1325, 26);
            this.statusStripSDPCompusof.TabIndex = 1;
            // 
            // toolBtnRecargarServiceDeskCompusof
            // 
            this.toolBtnRecargarServiceDeskCompusof.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolBtnRecargarServiceDeskCompusof.Name = "toolBtnRecargarServiceDeskCompusof";
            this.toolBtnRecargarServiceDeskCompusof.Size = new System.Drawing.Size(92, 24);
            this.toolBtnRecargarServiceDeskCompusof.Text = "Recargar";
            this.toolBtnRecargarServiceDeskCompusof.Click += new System.EventHandler(this.recargarManageDeskCompusofToolStripMenuItem_Click);
            // 
            // URL_EndPoint_Central_Label
            // 
            this.URL_EndPoint_Central_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.URL_EndPoint_Central_Label.Name = "URL_EndPoint_Central_Label";
            this.URL_EndPoint_Central_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabCentroDeControl
            // 
            this.tabCentroDeControl.BackColor = System.Drawing.Color.DimGray;
            this.tabCentroDeControl.Controls.Add(this.tableLayoutPanelCentroDeControl);
            this.tabCentroDeControl.Controls.Add(this.toolStrip1);
            this.tabCentroDeControl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCentroDeControl.Location = new System.Drawing.Point(4, 39);
            this.tabCentroDeControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCentroDeControl.Name = "tabCentroDeControl";
            this.tabCentroDeControl.Size = new System.Drawing.Size(1331, 568);
            this.tabCentroDeControl.TabIndex = 6;
            this.tabCentroDeControl.Text = "Centro de Control";
            // 
            // tableLayoutPanelCentroDeControl
            // 
            this.tableLayoutPanelCentroDeControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelCentroDeControl.ColumnCount = 2;
            this.tableLayoutPanelCentroDeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86275F));
            this.tableLayoutPanelCentroDeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.13725F));
            this.tableLayoutPanelCentroDeControl.Controls.Add(this.MDI_ACT_Panel, 1, 0);
            this.tableLayoutPanelCentroDeControl.Controls.Add(this.tableLayoutPanelCentroDeControl_Nodos, 0, 0);
            this.tableLayoutPanelCentroDeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCentroDeControl.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanelCentroDeControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCentroDeControl.Name = "tableLayoutPanelCentroDeControl";
            this.tableLayoutPanelCentroDeControl.RowCount = 1;
            this.tableLayoutPanelCentroDeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.04655F));
            this.tableLayoutPanelCentroDeControl.Size = new System.Drawing.Size(1331, 541);
            this.tableLayoutPanelCentroDeControl.TabIndex = 1;
            // 
            // MDI_ACT_Panel
            // 
            this.MDI_ACT_Panel.BackColor = System.Drawing.Color.DarkGray;
            this.MDI_ACT_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MDI_ACT_Panel.Controls.Add(this.lblCentroControl_Text);
            this.MDI_ACT_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDI_ACT_Panel.Location = new System.Drawing.Point(228, 3);
            this.MDI_ACT_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.MDI_ACT_Panel.Name = "MDI_ACT_Panel";
            this.MDI_ACT_Panel.Size = new System.Drawing.Size(1100, 535);
            this.MDI_ACT_Panel.TabIndex = 0;
            this.MDI_ACT_Panel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelMDIContainerActividades_ControlAdded);
            this.MDI_ACT_Panel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelMDIContainerActividades_ControlRemoved);
            // 
            // lblCentroControl_Text
            // 
            this.lblCentroControl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCentroControl_Text.Font = new System.Drawing.Font("Microsoft New Tai Lue", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroControl_Text.Location = new System.Drawing.Point(0, 0);
            this.lblCentroControl_Text.Name = "lblCentroControl_Text";
            this.lblCentroControl_Text.Size = new System.Drawing.Size(1096, 531);
            this.lblCentroControl_Text.TabIndex = 1;
            this.lblCentroControl_Text.Text = "Bienvenido a RIT Solver!";
            this.lblCentroControl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCentroDeControl_Nodos
            // 
            this.tableLayoutPanelCentroDeControl_Nodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCentroDeControl_Nodos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelCentroDeControl_Nodos.ColumnCount = 1;
            this.tableLayoutPanelCentroDeControl_Nodos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCentroDeControl_Nodos.Controls.Add(this.treeViewCentroDeControl, 0, 1);
            this.tableLayoutPanelCentroDeControl_Nodos.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanelCentroDeControl_Nodos.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelCentroDeControl_Nodos.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCentroDeControl_Nodos.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCentroDeControl_Nodos.Name = "tableLayoutPanelCentroDeControl_Nodos";
            this.tableLayoutPanelCentroDeControl_Nodos.RowCount = 3;
            this.tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.59375F));
            this.tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.40625F));
            this.tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanelCentroDeControl_Nodos.Size = new System.Drawing.Size(222, 535);
            this.tableLayoutPanelCentroDeControl_Nodos.TabIndex = 1;
            // 
            // treeViewCentroDeControl
            // 
            this.treeViewCentroDeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewCentroDeControl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCentroDeControl.ImageIndex = 0;
            this.treeViewCentroDeControl.ImageList = this.imageList_Actividades;
            this.treeViewCentroDeControl.ItemHeight = 32;
            this.treeViewCentroDeControl.Location = new System.Drawing.Point(8, 43);
            this.treeViewCentroDeControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.treeViewCentroDeControl.Name = "treeViewCentroDeControl";
            treeNode2.Name = "nodeActividades";
            treeNode2.Text = "Actividades";
            treeNode2.ToolTipText = "Gestion de actividades programadas";
            treeNode3.Name = "nodePendientesPorHacer";
            treeNode3.Text = "Pendientes por hacer";
            treeNode3.ToolTipText = "Seccion de Pendientes por Realizar";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "nodeEstadisticasMensualesAnteriores";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Historico de Estadisticas Mensuales";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "nodeSeguimientoDeGuias";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Seguimiento de Guias";
            treeNode5.ToolTipText = "Da seguimiento a guias trackeaas en el sistema para saber con mayor efectividad y" +
    " facilidad su ubicacion actual";
            treeNode6.Name = "nodeSolicitudesDeViaticos";
            treeNode6.Text = "Solicitudes de Viaticos";
            this.treeViewCentroDeControl.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeViewCentroDeControl.SelectedImageIndex = 0;
            this.treeViewCentroDeControl.Size = new System.Drawing.Size(206, 326);
            this.treeViewCentroDeControl.TabIndex = 0;
            this.treeViewCentroDeControl.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCentroDeControl_AfterSelect);
            this.treeViewCentroDeControl.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCentroDeControl_NodeMouseDoubleClick);
            // 
            // imageList_Actividades
            // 
            this.imageList_Actividades.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Actividades.ImageStream")));
            this.imageList_Actividades.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Actividades.Images.SetKeyName(0, "open-folder.png");
            this.imageList_Actividades.Images.SetKeyName(1, "checklist-64.png");
            this.imageList_Actividades.Images.SetKeyName(2, "estadisticas-64.png");
            this.imageList_Actividades.Images.SetKeyName(3, "estadisticas-anteriores.png");
            this.imageList_Actividades.Images.SetKeyName(4, "pack-list-track.png");
            this.imageList_Actividades.Images.SetKeyName(5, "to-do-32.png");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDescripcionDeNodo);
            this.panel3.Controls.Add(this.lblNombreNodoSeleccionado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 378);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Size = new System.Drawing.Size(216, 154);
            this.panel3.TabIndex = 2;
            // 
            // lblDescripcionDeNodo
            // 
            this.lblDescripcionDeNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescripcionDeNodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescripcionDeNodo.Location = new System.Drawing.Point(5, 57);
            this.lblDescripcionDeNodo.Name = "lblDescripcionDeNodo";
            this.lblDescripcionDeNodo.Size = new System.Drawing.Size(203, 94);
            this.lblDescripcionDeNodo.TabIndex = 2;
            this.lblDescripcionDeNodo.Text = "Ejemplo de texto de descrpcion de un nodo de la actividad seleccionada.";
            // 
            // lblNombreNodoSeleccionado
            // 
            this.lblNombreNodoSeleccionado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreNodoSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreNodoSeleccionado.Location = new System.Drawing.Point(5, 6);
            this.lblNombreNodoSeleccionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombreNodoSeleccionado.Name = "lblNombreNodoSeleccionado";
            this.lblNombreNodoSeleccionado.Size = new System.Drawing.Size(203, 47);
            this.lblNombreNodoSeleccionado.TabIndex = 1;
            this.lblNombreNodoSeleccionado.Text = "Ejemplo de titulo de un nodo para  secciones del programa ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblNombreSeccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 31);
            this.panel1.TabIndex = 0;
            // 
            // lblNombreSeccion
            // 
            this.lblNombreSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreSeccion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNombreSeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreSeccion.Location = new System.Drawing.Point(0, 0);
            this.lblNombreSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNombreSeccion.Name = "lblNombreSeccion";
            this.lblNombreSeccion.Size = new System.Drawing.Size(216, 31);
            this.lblNombreSeccion.TabIndex = 0;
            this.lblNombreSeccion.Text = "Ejemplo de seccion de";
            this.lblNombreSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCrearActividad,
            this.toolAbrirActividad,
            this.toolEliminarActividad,
            this.toolCerrarActividad,
            this.toolStripSeparator2,
            this.toolImportarActividad,
            this.toolExportarActividad,
            this.toolStripLabel2,
            this.toolNuevoPendientePorHacer,
            this.toolImportarListaDePendientes,
            this.toolEliminarListaDePendientesPorHacer,
            this.toolCerrarListaDePendientes,
            this.toolStripSeparator9,
            this.toolNuevaSeccion,
            this.toolStripLabel1,
            this.toolStrpBtnMinimizarTodasLasVentanas,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolLblActualMDIActividadName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1331, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolCrearActividad
            // 
            this.toolCrearActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCrearActividad.Image = global::RIT_Solver.Properties.Resources.lista_de_verificacion1;
            this.toolCrearActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCrearActividad.Name = "toolCrearActividad";
            this.toolCrearActividad.Size = new System.Drawing.Size(29, 24);
            this.toolCrearActividad.Text = "Nueva actividad";
            this.toolCrearActividad.Click += new System.EventHandler(this.toolCrearActividad_Click);
            // 
            // toolAbrirActividad
            // 
            this.toolAbrirActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbrirActividad.Image = global::RIT_Solver.Properties.Resources.activity_open;
            this.toolAbrirActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbrirActividad.Name = "toolAbrirActividad";
            this.toolAbrirActividad.Size = new System.Drawing.Size(29, 24);
            this.toolAbrirActividad.Text = "Abrir actividad";
            this.toolAbrirActividad.Click += new System.EventHandler(this.toolAbrirActividad_Click);
            // 
            // toolEliminarActividad
            // 
            this.toolEliminarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminarActividad.Image = global::RIT_Solver.Properties.Resources.activity_delete;
            this.toolEliminarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminarActividad.Name = "toolEliminarActividad";
            this.toolEliminarActividad.Size = new System.Drawing.Size(29, 24);
            this.toolEliminarActividad.Text = "Eliminar actividad";
            this.toolEliminarActividad.Click += new System.EventHandler(this.toolEliminarActividad_Click);
            // 
            // toolCerrarActividad
            // 
            this.toolCerrarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCerrarActividad.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.toolCerrarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrarActividad.Name = "toolCerrarActividad";
            this.toolCerrarActividad.Size = new System.Drawing.Size(29, 24);
            this.toolCerrarActividad.Text = "Cerrar actividad actual";
            this.toolCerrarActividad.Click += new System.EventHandler(this.toolCerrarActividad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolImportarActividad
            // 
            this.toolImportarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImportarActividad.Enabled = false;
            this.toolImportarActividad.Image = global::RIT_Solver.Properties.Resources.importar_16;
            this.toolImportarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImportarActividad.Name = "toolImportarActividad";
            this.toolImportarActividad.Size = new System.Drawing.Size(29, 24);
            this.toolImportarActividad.Text = "Importar actividad";
            this.toolImportarActividad.Click += new System.EventHandler(this.toolImportarActividad_Click);
            // 
            // toolExportarActividad
            // 
            this.toolExportarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExportarActividad.Image = global::RIT_Solver.Properties.Resources.exportar_16;
            this.toolExportarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportarActividad.Name = "toolExportarActividad";
            this.toolExportarActividad.Size = new System.Drawing.Size(29, 24);
            this.toolExportarActividad.Text = "Exportar actividad";
            this.toolExportarActividad.Click += new System.EventHandler(this.toolExportarActividad_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel2.Text = "       ";
            // 
            // toolNuevoPendientePorHacer
            // 
            this.toolNuevoPendientePorHacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevoPendientePorHacer.Image = global::RIT_Solver.Properties.Resources.to_do_32;
            this.toolNuevoPendientePorHacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevoPendientePorHacer.Name = "toolNuevoPendientePorHacer";
            this.toolNuevoPendientePorHacer.Size = new System.Drawing.Size(29, 24);
            this.toolNuevoPendientePorHacer.Text = "Nuevo pendiente por hacer";
            this.toolNuevoPendientePorHacer.ToolTipText = "Nuevo pendiente por hacer";
            this.toolNuevoPendientePorHacer.Click += new System.EventHandler(this.toolNuevoPendientePorHacer_Click);
            // 
            // toolImportarListaDePendientes
            // 
            this.toolImportarListaDePendientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolImportarListaDePendientes.Image = global::RIT_Solver.Properties.Resources.to_do_open;
            this.toolImportarListaDePendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImportarListaDePendientes.Name = "toolImportarListaDePendientes";
            this.toolImportarListaDePendientes.Size = new System.Drawing.Size(29, 24);
            this.toolImportarListaDePendientes.Text = "Importar una lista de pendientes...";
            this.toolImportarListaDePendientes.Click += new System.EventHandler(this.toolImportarListaDePendientes_Click);
            // 
            // toolEliminarListaDePendientesPorHacer
            // 
            this.toolEliminarListaDePendientesPorHacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminarListaDePendientesPorHacer.Image = global::RIT_Solver.Properties.Resources.to_do_delete;
            this.toolEliminarListaDePendientesPorHacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminarListaDePendientesPorHacer.Name = "toolEliminarListaDePendientesPorHacer";
            this.toolEliminarListaDePendientesPorHacer.Size = new System.Drawing.Size(29, 24);
            this.toolEliminarListaDePendientesPorHacer.Text = "Eliminar lista de pendientes";
            this.toolEliminarListaDePendientesPorHacer.Click += new System.EventHandler(this.toolEliminarListaDePendientesPorHacer_Click);
            // 
            // toolCerrarListaDePendientes
            // 
            this.toolCerrarListaDePendientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCerrarListaDePendientes.Image = global::RIT_Solver.Properties.Resources.close1_32;
            this.toolCerrarListaDePendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCerrarListaDePendientes.Name = "toolCerrarListaDePendientes";
            this.toolCerrarListaDePendientes.Size = new System.Drawing.Size(29, 24);
            this.toolCerrarListaDePendientes.Text = "Cerrar lista de pendientes";
            this.toolCerrarListaDePendientes.Click += new System.EventHandler(this.toolCerrarListaDePendientes_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolNuevaSeccion
            // 
            this.toolNuevaSeccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevaSeccion.Enabled = false;
            this.toolNuevaSeccion.Image = global::RIT_Solver.Properties.Resources.new_section_32;
            this.toolNuevaSeccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevaSeccion.Name = "toolNuevaSeccion";
            this.toolNuevaSeccion.Size = new System.Drawing.Size(29, 24);
            this.toolNuevaSeccion.Text = "Nueva seccion";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel1.Text = "       ";
            // 
            // toolStrpBtnMinimizarTodasLasVentanas
            // 
            this.toolStrpBtnMinimizarTodasLasVentanas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrpBtnMinimizarTodasLasVentanas.Image = global::RIT_Solver.Properties.Resources.minimize_all_windows;
            this.toolStrpBtnMinimizarTodasLasVentanas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrpBtnMinimizarTodasLasVentanas.Name = "toolStrpBtnMinimizarTodasLasVentanas";
            this.toolStrpBtnMinimizarTodasLasVentanas.Size = new System.Drawing.Size(29, 24);
            this.toolStrpBtnMinimizarTodasLasVentanas.Text = "Minimizar todas las ventanas";
            this.toolStrpBtnMinimizarTodasLasVentanas.Click += new System.EventHandler(this.toolStrpBtnMinimizarTodasLasVentanas_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel5.Text = "       ";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(86, 24);
            this.toolStripLabel6.Text = "Actual MDI:";
            // 
            // toolLblActualMDIActividadName
            // 
            this.toolLblActualMDIActividadName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolLblActualMDIActividadName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolLblActualMDIActividadName.Name = "toolLblActualMDIActividadName";
            this.toolLblActualMDIActividadName.Size = new System.Drawing.Size(15, 24);
            this.toolLblActualMDIActividadName.Text = "-";
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(250, 250);
            this.webBrowser4.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuOpcionesActividades
            // 
            this.menuOpcionesActividades.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpcionesActividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearActividadToolStripMenuItem,
            this.abrirActividadToolStripMenuItem,
            this.toolStripSeparator10,
            this.maximizaToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator12,
            this.enviarAvanceToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.borrarPermanentementeToolStripMenuItem,
            this.toolStripSeparator11,
            this.cerrarToolStripMenuItem});
            this.menuOpcionesActividades.Name = "menuOpcionesActividades";
            this.menuOpcionesActividades.Size = new System.Drawing.Size(246, 238);
            // 
            // crearActividadToolStripMenuItem
            // 
            this.crearActividadToolStripMenuItem.Name = "crearActividadToolStripMenuItem";
            this.crearActividadToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.crearActividadToolStripMenuItem.Text = "Crear nueva actividad";
            // 
            // abrirActividadToolStripMenuItem
            // 
            this.abrirActividadToolStripMenuItem.Name = "abrirActividadToolStripMenuItem";
            this.abrirActividadToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.abrirActividadToolStripMenuItem.Text = "Abrir actividad existente";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(242, 6);
            // 
            // maximizaToolStripMenuItem
            // 
            this.maximizaToolStripMenuItem.Name = "maximizaToolStripMenuItem";
            this.maximizaToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.maximizaToolStripMenuItem.Text = "Maximizar";
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar de la vista";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(242, 6);
            // 
            // enviarAvanceToolStripMenuItem
            // 
            this.enviarAvanceToolStripMenuItem.Name = "enviarAvanceToolStripMenuItem";
            this.enviarAvanceToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.enviarAvanceToolStripMenuItem.Text = "Enviar avance";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.importarToolStripMenuItem.Text = "Exportar actividad";
            // 
            // borrarPermanentementeToolStripMenuItem
            // 
            this.borrarPermanentementeToolStripMenuItem.Name = "borrarPermanentementeToolStripMenuItem";
            this.borrarPermanentementeToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.borrarPermanentementeToolStripMenuItem.Text = "Borrar permanentemente";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(242, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // menuOpcionesAnuncios
            // 
            this.menuOpcionesAnuncios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpcionesAnuncios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAnuncioStripMenuItem,
            this.abrirAnuncioStripMenuItem,
            this.toolStripSeparator13,
            this.maximizarStripMenuItem,
            this.minizarStripMenuItem,
            this.eliminarDeLaVistaStripMenuItem,
            this.toolStripSeparator14,
            this.borrarPermanentementeStripMenuItem,
            this.toolStripSeparator15,
            this.cerrarStripMenuItem});
            this.menuOpcionesAnuncios.Name = "menuOpcionesActividades";
            this.menuOpcionesAnuncios.Size = new System.Drawing.Size(246, 190);
            // 
            // crearAnuncioStripMenuItem
            // 
            this.crearAnuncioStripMenuItem.Name = "crearAnuncioStripMenuItem";
            this.crearAnuncioStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.crearAnuncioStripMenuItem.Text = "Crear nuevo anuncio";
            // 
            // abrirAnuncioStripMenuItem
            // 
            this.abrirAnuncioStripMenuItem.Name = "abrirAnuncioStripMenuItem";
            this.abrirAnuncioStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.abrirAnuncioStripMenuItem.Text = "Abrir anuncio existente";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(242, 6);
            // 
            // maximizarStripMenuItem
            // 
            this.maximizarStripMenuItem.Name = "maximizarStripMenuItem";
            this.maximizarStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.maximizarStripMenuItem.Text = "Maximizar";
            // 
            // minizarStripMenuItem
            // 
            this.minizarStripMenuItem.Name = "minizarStripMenuItem";
            this.minizarStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.minizarStripMenuItem.Text = "Minimizar";
            // 
            // eliminarDeLaVistaStripMenuItem
            // 
            this.eliminarDeLaVistaStripMenuItem.Name = "eliminarDeLaVistaStripMenuItem";
            this.eliminarDeLaVistaStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.eliminarDeLaVistaStripMenuItem.Text = "Eliminar de la vista";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(242, 6);
            // 
            // borrarPermanentementeStripMenuItem
            // 
            this.borrarPermanentementeStripMenuItem.Name = "borrarPermanentementeStripMenuItem";
            this.borrarPermanentementeStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.borrarPermanentementeStripMenuItem.Text = "Borrar permanentemente";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(242, 6);
            // 
            // cerrarStripMenuItem
            // 
            this.cerrarStripMenuItem.Name = "cerrarStripMenuItem";
            this.cerrarStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.cerrarStripMenuItem.Text = "Cerrar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(604, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 40);
            this.linkLabel1.TabIndex = 53;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "RIT Solver Info";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // tableLayoutPanelBarraMultifuncion_BotonesIzquierda
            // 
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnCount = 2;
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Controls.Add(this.btnFuncion2, 0, 0);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Controls.Add(this.btnFuncion1, 0, 0);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Name = "tableLayoutPanelBarraMultifuncion_BotonesIzquierda";
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.RowCount = 1;
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Size = new System.Drawing.Size(372, 40);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.TabIndex = 11;
            // 
            // btnFuncion2
            // 
            this.btnFuncion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncion2.Location = new System.Drawing.Point(189, 2);
            this.btnFuncion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncion2.Name = "btnFuncion2";
            this.btnFuncion2.Size = new System.Drawing.Size(180, 36);
            this.btnFuncion2.TabIndex = 52;
            this.btnFuncion2.Text = "Limpiar campos";
            this.btnFuncion2.UseVisualStyleBackColor = true;
            this.btnFuncion2.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnFuncion1
            // 
            this.btnFuncion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncion1.Location = new System.Drawing.Point(3, 2);
            this.btnFuncion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFuncion1.Name = "btnFuncion1";
            this.btnFuncion1.Size = new System.Drawing.Size(180, 36);
            this.btnFuncion1.TabIndex = 51;
            this.btnFuncion1.Text = "Cargar datos de SAS";
            this.btnFuncion1.UseVisualStyleBackColor = true;
            this.btnFuncion1.Click += new System.EventHandler(this.btnCargarDatosDeSAS_Click);
            // 
            // lblContactoFallos
            // 
            this.lblContactoFallos.AutoSize = true;
            this.lblContactoFallos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContactoFallos.Location = new System.Drawing.Point(697, 3);
            this.lblContactoFallos.Name = "lblContactoFallos";
            this.lblContactoFallos.Size = new System.Drawing.Size(256, 40);
            this.lblContactoFallos.TabIndex = 54;
            this.lblContactoFallos.TabStop = true;
            this.lblContactoFallos.Text = "¿Presentas fallos con el programa? ¡Reportalos aqui!";
            this.lblContactoFallos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactoFallos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblContactoFallos_LinkClicked);
            // 
            // btnFuncion3
            // 
            this.btnFuncion3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncion3.Location = new System.Drawing.Point(0, 0);
            this.btnFuncion3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFuncion3.Name = "btnFuncion3";
            this.btnFuncion3.Size = new System.Drawing.Size(151, 36);
            this.btnFuncion3.TabIndex = 55;
            this.btnFuncion3.Text = "Guardar RIT";
            this.btnFuncion3.UseVisualStyleBackColor = true;
            this.btnFuncion3.Click += new System.EventHandler(this.btnGuardarDatos_Click_1);
            // 
            // tableLayoutPanelBarraMultifuncion
            // 
            this.tableLayoutPanelBarraMultifuncion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBarraMultifuncion.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelBarraMultifuncion.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelBarraMultifuncion.ColumnCount = 6;
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73244F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25573F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.866615F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8895F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91792F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33781F));
            this.tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBarraMultifuncion.Controls.Add(this.lblContactoFallos, 3, 0);
            this.tableLayoutPanelBarraMultifuncion.Controls.Add(this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda, 1, 0);
            this.tableLayoutPanelBarraMultifuncion.Controls.Add(this.linkLabel1, 2, 0);
            this.tableLayoutPanelBarraMultifuncion.Controls.Add(this.panel7, 4, 0);
            this.tableLayoutPanelBarraMultifuncion.Location = new System.Drawing.Point(0, 645);
            this.tableLayoutPanelBarraMultifuncion.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBarraMultifuncion.Name = "tableLayoutPanelBarraMultifuncion";
            this.tableLayoutPanelBarraMultifuncion.RowCount = 1;
            this.tableLayoutPanelBarraMultifuncion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBarraMultifuncion.Size = new System.Drawing.Size(1339, 46);
            this.tableLayoutPanelBarraMultifuncion.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnFuncion3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(962, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(151, 36);
            this.panel7.TabIndex = 56;
            // 
            // menuOpcionesDeProyectos
            // 
            this.menuOpcionesDeProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(63)))));
            this.menuOpcionesDeProyectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpcionesDeProyectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.webToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.utilidadesToolStripMenuItem});
            this.menuOpcionesDeProyectos.Location = new System.Drawing.Point(0, 0);
            this.menuOpcionesDeProyectos.Name = "menuOpcionesDeProyectos";
            this.menuOpcionesDeProyectos.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuOpcionesDeProyectos.Size = new System.Drawing.Size(1339, 28);
            this.menuOpcionesDeProyectos.TabIndex = 1;
            this.menuOpcionesDeProyectos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProyectoToolStripMenuItem,
            this.abrirTicketToolStripMenuItem,
            this.archivosRecientesToolStripMenuItem,
            this.toolStripSeparator3,
            this.nuevaActividadToolStripMenuItem,
            this.importarActividadToolStripMenuItem,
            this.exportarActividadesToolStripMenuItem,
            this.nuevoAnuncioToolStripMenuItem,
            this.toolStripSeparator5,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.buscar_archivo1;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            this.nuevoProyectoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.project;
            this.nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            this.nuevoProyectoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.nuevoProyectoToolStripMenuItem.Text = "Nuevo proyecto de ticket";
            this.nuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // abrirTicketToolStripMenuItem
            // 
            this.abrirTicketToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.project_open;
            this.abrirTicketToolStripMenuItem.Name = "abrirTicketToolStripMenuItem";
            this.abrirTicketToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirTicketToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.abrirTicketToolStripMenuItem.Text = "Abrir proyecto de ticket";
            this.abrirTicketToolStripMenuItem.Click += new System.EventHandler(this.abrirTicketToolStripMenuItem_Click);
            // 
            // archivosRecientesToolStripMenuItem
            // 
            this.archivosRecientesToolStripMenuItem.Name = "archivosRecientesToolStripMenuItem";
            this.archivosRecientesToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.archivosRecientesToolStripMenuItem.Text = "Archivos recientes";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(309, 6);
            // 
            // nuevaActividadToolStripMenuItem
            // 
            this.nuevaActividadToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.lista_de_verificacion1;
            this.nuevaActividadToolStripMenuItem.Name = "nuevaActividadToolStripMenuItem";
            this.nuevaActividadToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.nuevaActividadToolStripMenuItem.Text = "Nueva actividad";
            this.nuevaActividadToolStripMenuItem.Click += new System.EventHandler(this.nuevaActividadToolStripMenuItem_Click);
            // 
            // importarActividadToolStripMenuItem
            // 
            this.importarActividadToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.activity_open;
            this.importarActividadToolStripMenuItem.Name = "importarActividadToolStripMenuItem";
            this.importarActividadToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.importarActividadToolStripMenuItem.Text = "Abrir actividad";
            this.importarActividadToolStripMenuItem.Click += new System.EventHandler(this.importarActividadToolStripMenuItem_Click);
            // 
            // exportarActividadesToolStripMenuItem
            // 
            this.exportarActividadesToolStripMenuItem.Enabled = false;
            this.exportarActividadesToolStripMenuItem.Name = "exportarActividadesToolStripMenuItem";
            this.exportarActividadesToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.exportarActividadesToolStripMenuItem.Text = "Exportar actividades";
            // 
            // nuevoAnuncioToolStripMenuItem
            // 
            this.nuevoAnuncioToolStripMenuItem.Enabled = false;
            this.nuevoAnuncioToolStripMenuItem.Name = "nuevoAnuncioToolStripMenuItem";
            this.nuevoAnuncioToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.nuevoAnuncioToolStripMenuItem.Text = "Nuevo anuncio";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(309, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.cerrar;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarActualizacionesToolStripMenuItem,
            this.buscarActualizacionesBETAToolStripMenuItem,
            this.toolStripSeparator4,
            this.sistemaDeInventariosToolStripMenuItem,
            this.seleccionarUsuarioToolStripMenuItem,
            this.listadoDeHistorialesToolStripMenuItem,
            this.seguimientoDeGuiaToolStripMenuItem,
            this.toolStripSeparator7,
            this.imprimirRITEnBlancoToolStripMenuItem,
            this.toolStripSeparator6,
            this.herramientaDeReparacionAvanzadaToolStripMenuItem,
            this.reportarFallaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.technical_support;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.configuraciones;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(335, 6);
            // 
            // buscarActualizacionesToolStripMenuItem
            // 
            this.buscarActualizacionesToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.mantenimiento_web;
            this.buscarActualizacionesToolStripMenuItem.Name = "buscarActualizacionesToolStripMenuItem";
            this.buscarActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.buscarActualizacionesToolStripMenuItem.Text = "Buscar actualizaciones";
            this.buscarActualizacionesToolStripMenuItem.Click += new System.EventHandler(this.buscarActualizacionesToolStripMenuItem_Click);
            // 
            // buscarActualizacionesBETAToolStripMenuItem
            // 
            this.buscarActualizacionesBETAToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.mantenimiento_web__1_;
            this.buscarActualizacionesBETAToolStripMenuItem.Name = "buscarActualizacionesBETAToolStripMenuItem";
            this.buscarActualizacionesBETAToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.buscarActualizacionesBETAToolStripMenuItem.Text = "Buscar actualizaciones BETA";
            this.buscarActualizacionesBETAToolStripMenuItem.Click += new System.EventHandler(this.buscarActualizacionesBETAToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(335, 6);
            // 
            // sistemaDeInventariosToolStripMenuItem
            // 
            this.sistemaDeInventariosToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.inventory;
            this.sistemaDeInventariosToolStripMenuItem.Name = "sistemaDeInventariosToolStripMenuItem";
            this.sistemaDeInventariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.sistemaDeInventariosToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.sistemaDeInventariosToolStripMenuItem.Text = "Sistema de Inventarios";
            this.sistemaDeInventariosToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeInventariosToolStripMenuItem_Click);
            // 
            // seleccionarUsuarioToolStripMenuItem
            // 
            this.seleccionarUsuarioToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.businessman;
            this.seleccionarUsuarioToolStripMenuItem.Name = "seleccionarUsuarioToolStripMenuItem";
            this.seleccionarUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.seleccionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.seleccionarUsuarioToolStripMenuItem.Text = "Listado de Usuarios";
            this.seleccionarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.seleccionarUsuarioToolStripMenuItem_Click);
            // 
            // listadoDeHistorialesToolStripMenuItem
            // 
            this.listadoDeHistorialesToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.computer_historial;
            this.listadoDeHistorialesToolStripMenuItem.Name = "listadoDeHistorialesToolStripMenuItem";
            this.listadoDeHistorialesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.listadoDeHistorialesToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.listadoDeHistorialesToolStripMenuItem.Text = "Listado de Historiales";
            this.listadoDeHistorialesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeHistorialesToolStripMenuItem_Click);
            // 
            // seguimientoDeGuiaToolStripMenuItem
            // 
            this.seguimientoDeGuiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dHLToolStripMenuItem,
            this.paqueteToolStripMenuItem,
            this.fedexToolStripMenuItem});
            this.seguimientoDeGuiaToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.tour;
            this.seguimientoDeGuiaToolStripMenuItem.Name = "seguimientoDeGuiaToolStripMenuItem";
            this.seguimientoDeGuiaToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.seguimientoDeGuiaToolStripMenuItem.Text = "Seguimiento de Guia Rapida";
            // 
            // dHLToolStripMenuItem
            // 
            this.dHLToolStripMenuItem.Name = "dHLToolStripMenuItem";
            this.dHLToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.dHLToolStripMenuItem.Text = "DHL";
            this.dHLToolStripMenuItem.Click += new System.EventHandler(this.dHLToolStripMenuItem_Click);
            // 
            // paqueteToolStripMenuItem
            // 
            this.paqueteToolStripMenuItem.Name = "paqueteToolStripMenuItem";
            this.paqueteToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.paqueteToolStripMenuItem.Text = "Paquetexpress";
            this.paqueteToolStripMenuItem.Click += new System.EventHandler(this.paqueteToolStripMenuItem_Click);
            // 
            // fedexToolStripMenuItem
            // 
            this.fedexToolStripMenuItem.Name = "fedexToolStripMenuItem";
            this.fedexToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.fedexToolStripMenuItem.Text = "Fedex";
            this.fedexToolStripMenuItem.Click += new System.EventHandler(this.fedexToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(335, 6);
            // 
            // imprimirRITEnBlancoToolStripMenuItem
            // 
            this.imprimirRITEnBlancoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.paper;
            this.imprimirRITEnBlancoToolStripMenuItem.Name = "imprimirRITEnBlancoToolStripMenuItem";
            this.imprimirRITEnBlancoToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.imprimirRITEnBlancoToolStripMenuItem.Text = "Imprimir RIT en blanco";
            this.imprimirRITEnBlancoToolStripMenuItem.Click += new System.EventHandler(this.imprimirRITEnBlancoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(335, 6);
            // 
            // herramientaDeReparacionAvanzadaToolStripMenuItem
            // 
            this.herramientaDeReparacionAvanzadaToolStripMenuItem.Enabled = false;
            this.herramientaDeReparacionAvanzadaToolStripMenuItem.Name = "herramientaDeReparacionAvanzadaToolStripMenuItem";
            this.herramientaDeReparacionAvanzadaToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.herramientaDeReparacionAvanzadaToolStripMenuItem.Text = "Herramienta de reparacion avanzada";
            // 
            // reportarFallaToolStripMenuItem
            // 
            this.reportarFallaToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.bug_report;
            this.reportarFallaToolStripMenuItem.Name = "reportarFallaToolStripMenuItem";
            this.reportarFallaToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.reportarFallaToolStripMenuItem.Text = "Reportar falla";
            this.reportarFallaToolStripMenuItem.Click += new System.EventHandler(this.reportarFallaToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recargarSASToolStripMenuItem,
            this.recargarFormsToolStripMenuItem,
            this.recargarManageDeskCompusofToolStripMenuItem,
            this.recargarEndpointCentralToolStripMenuItem,
            this.toolStripSeparator17,
            this.funcionesWebMacroToolStripMenuItem});
            this.webToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.red_mundial;
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.webToolStripMenuItem.Text = "Webs";
            // 
            // recargarSASToolStripMenuItem
            // 
            this.recargarSASToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.recargarSASToolStripMenuItem.Name = "recargarSASToolStripMenuItem";
            this.recargarSASToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.recargarSASToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.recargarSASToolStripMenuItem.Text = "Recargar SAS";
            this.recargarSASToolStripMenuItem.Click += new System.EventHandler(this.recargarSASToolStripMenuItem_Click);
            // 
            // recargarFormsToolStripMenuItem
            // 
            this.recargarFormsToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.recargarFormsToolStripMenuItem.Name = "recargarFormsToolStripMenuItem";
            this.recargarFormsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.recargarFormsToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.recargarFormsToolStripMenuItem.Text = "Recargar Forms";
            this.recargarFormsToolStripMenuItem.Click += new System.EventHandler(this.recargarFormsToolStripMenuItem_Click);
            // 
            // recargarManageDeskCompusofToolStripMenuItem
            // 
            this.recargarManageDeskCompusofToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.recargarManageDeskCompusofToolStripMenuItem.Name = "recargarManageDeskCompusofToolStripMenuItem";
            this.recargarManageDeskCompusofToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.recargarManageDeskCompusofToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.recargarManageDeskCompusofToolStripMenuItem.Text = "Recargar Manage Desk Compusof";
            this.recargarManageDeskCompusofToolStripMenuItem.Click += new System.EventHandler(this.recargarManageDeskCompusofToolStripMenuItem_Click);
            // 
            // recargarEndpointCentralToolStripMenuItem
            // 
            this.recargarEndpointCentralToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.recargarEndpointCentralToolStripMenuItem.Name = "recargarEndpointCentralToolStripMenuItem";
            this.recargarEndpointCentralToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.recargarEndpointCentralToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.recargarEndpointCentralToolStripMenuItem.Text = "Recargar Endpoint Central";
            this.recargarEndpointCentralToolStripMenuItem.Click += new System.EventHandler(this.recargarEndpointCentralToolStripMenuItem_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(419, 6);
            // 
            // funcionesWebMacroToolStripMenuItem
            // 
            this.funcionesWebMacroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem,
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem,
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem});
            this.funcionesWebMacroToolStripMenuItem.Name = "funcionesWebMacroToolStripMenuItem";
            this.funcionesWebMacroToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.funcionesWebMacroToolStripMenuItem.Text = "Macro Funciones Web";
            // 
            // ejecutarMacroFuncionWeb1ToolStripMenuItem
            // 
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb1ToolStripMenuItem";
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 1";
            this.ejecutarMacroFuncionWeb1ToolStripMenuItem.Click += new System.EventHandler(this.ejecutarMacroFuncionWeb1ToolStripMenuItem_Click);
            // 
            // ejecutarMacroFuncionWeb2ToolStripMenuItem
            // 
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb2ToolStripMenuItem";
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 2";
            this.ejecutarMacroFuncionWeb2ToolStripMenuItem.Click += new System.EventHandler(this.ejecutarMacroFuncionWeb2ToolStripMenuItem_Click);
            // 
            // ejecutarMacroFuncionWeb3ToolStripMenuItem
            // 
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb3ToolStripMenuItem";
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 3";
            this.ejecutarMacroFuncionWeb3ToolStripMenuItem.Click += new System.EventHandler(this.ejecutarMacroFuncionWeb3ToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarRefaccionesToolStripMenuItem,
            this.solicitarTonerToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.solicitud;
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // solicitarRefaccionesToolStripMenuItem
            // 
            this.solicitarRefaccionesToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.spare_parts;
            this.solicitarRefaccionesToolStripMenuItem.Name = "solicitarRefaccionesToolStripMenuItem";
            this.solicitarRefaccionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.solicitarRefaccionesToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.solicitarRefaccionesToolStripMenuItem.Text = "Solicitar refacciones";
            this.solicitarRefaccionesToolStripMenuItem.Click += new System.EventHandler(this.solicitarRefaccionesToolStripMenuItem_Click);
            // 
            // solicitarTonerToolStripMenuItem
            // 
            this.solicitarTonerToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.toner;
            this.solicitarTonerToolStripMenuItem.Name = "solicitarTonerToolStripMenuItem";
            this.solicitarTonerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.solicitarTonerToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.solicitarTonerToolStripMenuItem.Text = "Solicitar toner";
            this.solicitarTonerToolStripMenuItem.Click += new System.EventHandler(this.solicitarTonerToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escaladoDeReportesToolStripMenuItem,
            this.organigramaDeContactoCompusofToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem,
            this.herramientasToolStripMenuItem1});
            this.utilidadesToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.utilities;
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // escaladoDeReportesToolStripMenuItem
            // 
            this.escaladoDeReportesToolStripMenuItem.Enabled = false;
            this.escaladoDeReportesToolStripMenuItem.Name = "escaladoDeReportesToolStripMenuItem";
            this.escaladoDeReportesToolStripMenuItem.Size = new System.Drawing.Size(335, 26);
            this.escaladoDeReportesToolStripMenuItem.Text = "Escalado de reportes";
            this.escaladoDeReportesToolStripMenuItem.Click += new System.EventHandler(this.escaladoDeReportesToolStripMenuItem_Click);
            // 
            // organigramaDeContactoCompusofToolStripMenuItem
            // 
            this.organigramaDeContactoCompusofToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.contacts;
            this.organigramaDeContactoCompusofToolStripMenuItem.Name = "organigramaDeContactoCompusofToolStripMenuItem";
            this.organigramaDeContactoCompusofToolStripMenuItem.Size = new System.Drawing.Size(335, 26);
            this.organigramaDeContactoCompusofToolStripMenuItem.Text = "Organigrama de contacto Compusof";
            this.organigramaDeContactoCompusofToolStripMenuItem.Click += new System.EventHandler(this.organigramaDeContactoCompusofToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.user_guide;
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(335, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem1
            // 
            this.herramientasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCIETToolStripMenuItem,
            this.omisorDeComprobacionesDeOracleToolStripMenuItem,
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem,
            this.crystalDiskInfoToolStripMenuItem});
            this.herramientasToolStripMenuItem1.Image = global::RIT_Solver.Properties.Resources.toolbox;
            this.herramientasToolStripMenuItem1.Name = "herramientasToolStripMenuItem1";
            this.herramientasToolStripMenuItem1.Size = new System.Drawing.Size(335, 26);
            this.herramientasToolStripMenuItem1.Text = "Herramientas";
            // 
            // pCIETToolStripMenuItem
            // 
            this.pCIETToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.grabarEnCarpetaToolStripMenuItem});
            this.pCIETToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.settings;
            this.pCIETToolStripMenuItem.Name = "pCIETToolStripMenuItem";
            this.pCIETToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.pCIETToolStripMenuItem.Text = "PCIET";
            this.pCIETToolStripMenuItem.ToolTipText = "Extractor de informacion de un equipo para crear carta de resguardo en el program" +
    "a.";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.play;
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // grabarEnCarpetaToolStripMenuItem
            // 
            this.grabarEnCarpetaToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.folder_move;
            this.grabarEnCarpetaToolStripMenuItem.Name = "grabarEnCarpetaToolStripMenuItem";
            this.grabarEnCarpetaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grabarEnCarpetaToolStripMenuItem.Text = "Grabar en carpeta ...";
            this.grabarEnCarpetaToolStripMenuItem.Click += new System.EventHandler(this.grabarEnCarpetaToolStripMenuItem_Click);
            // 
            // omisorDeComprobacionesDeOracleToolStripMenuItem
            // 
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem1,
            this.grabarEnToolStripMenuItem});
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.oracle;
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.Name = "omisorDeComprobacionesDeOracleToolStripMenuItem";
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.Text = "Omisor de Comprobaciones de Oracle";
            this.omisorDeComprobacionesDeOracleToolStripMenuItem.ToolTipText = "Herramienta omisora de comprobaciones de instalacion de Oracle. Solo hay que ejec" +
    "uta el archivo como administrador en la misma carpeta que se encuentra el instal" +
    "ador de Oracle.";
            // 
            // ejecutarToolStripMenuItem1
            // 
            this.ejecutarToolStripMenuItem1.Image = global::RIT_Solver.Properties.Resources.play;
            this.ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
            this.ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ejecutarToolStripMenuItem1.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem1.Click += new System.EventHandler(this.ejecutarToolStripMenuItem1_Click);
            // 
            // grabarEnToolStripMenuItem
            // 
            this.grabarEnToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.folder_move;
            this.grabarEnToolStripMenuItem.Name = "grabarEnToolStripMenuItem";
            this.grabarEnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grabarEnToolStripMenuItem.Text = "Grabar en carpeta ...";
            this.grabarEnToolStripMenuItem.Click += new System.EventHandler(this.grabarEnToolStripMenuItem_Click);
            // 
            // instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem
            // 
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.AutoSize = false;
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem2,
            this.grabarEnCarpetaToolStripMenuItem1});
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.libros;
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Name = "instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem";
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Text = "Instalador de Librerias y Registros de MIIT 7.0";
            this.instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.ToolTipText = "Instalador de librerias y registros para MiitCat 7. Solo hay que planchar el arch" +
    "ivo en la raiz de MiitCat y ejecutar como admin.";
            // 
            // ejecutarToolStripMenuItem2
            // 
            this.ejecutarToolStripMenuItem2.Image = global::RIT_Solver.Properties.Resources.play;
            this.ejecutarToolStripMenuItem2.Name = "ejecutarToolStripMenuItem2";
            this.ejecutarToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.ejecutarToolStripMenuItem2.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem2.Click += new System.EventHandler(this.ejecutarToolStripMenuItem2_Click);
            // 
            // grabarEnCarpetaToolStripMenuItem1
            // 
            this.grabarEnCarpetaToolStripMenuItem1.Image = global::RIT_Solver.Properties.Resources.folder_move;
            this.grabarEnCarpetaToolStripMenuItem1.Name = "grabarEnCarpetaToolStripMenuItem1";
            this.grabarEnCarpetaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.grabarEnCarpetaToolStripMenuItem1.Text = "Grabar en carpeta ...";
            this.grabarEnCarpetaToolStripMenuItem1.Click += new System.EventHandler(this.grabarEnCarpetaToolStripMenuItem1_Click);
            // 
            // crystalDiskInfoToolStripMenuItem
            // 
            this.crystalDiskInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem3,
            this.gtrabrToolStripMenuItem});
            this.crystalDiskInfoToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.storage;
            this.crystalDiskInfoToolStripMenuItem.Name = "crystalDiskInfoToolStripMenuItem";
            this.crystalDiskInfoToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.crystalDiskInfoToolStripMenuItem.Text = "CrystalDiskInfo 8";
            this.crystalDiskInfoToolStripMenuItem.ToolTipText = "Herramienta para diagnosticar unidades de almacenamiento.";
            // 
            // ejecutarToolStripMenuItem3
            // 
            this.ejecutarToolStripMenuItem3.Image = global::RIT_Solver.Properties.Resources.play;
            this.ejecutarToolStripMenuItem3.Name = "ejecutarToolStripMenuItem3";
            this.ejecutarToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.ejecutarToolStripMenuItem3.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem3.Click += new System.EventHandler(this.ejecutarToolStripMenuItem3_Click);
            // 
            // gtrabrToolStripMenuItem
            // 
            this.gtrabrToolStripMenuItem.Image = global::RIT_Solver.Properties.Resources.folder_move;
            this.gtrabrToolStripMenuItem.Name = "gtrabrToolStripMenuItem";
            this.gtrabrToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gtrabrToolStripMenuItem.Text = "Grabar en carpeta ...";
            this.gtrabrToolStripMenuItem.Click += new System.EventHandler(this.gtrabrToolStripMenuItem_Click);
            // 
            // backgroundWorker_StartScreen
            // 
            this.backgroundWorker_StartScreen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_StartScreen_DoWork);
            // 
            // backgroundWorker_WaitScreen
            // 
            this.backgroundWorker_WaitScreen.WorkerSupportsCancellation = true;
            this.backgroundWorker_WaitScreen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_WaitScreen_DoWork);
            // 
            // bgworker_RitSolverUpdater
            // 
            this.bgworker_RitSolverUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworker_RitSolverUpdater_DoWork);
            this.bgworker_RitSolverUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworker_RitSolverUpdater_RunWorkerCompleted);
            // 
            // bgworkerMDIsFormsLoader
            // 
            this.bgworkerMDIsFormsLoader.WorkerReportsProgress = true;
            this.bgworkerMDIsFormsLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworkerMDIsFormsLoader_DoWork);
            this.bgworkerMDIsFormsLoader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgworkerMDIsFormsLoader_ProgressChanged);
            this.bgworkerMDIsFormsLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworkerMDIsFormsLoader_RunWorkerCompleted);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1339, 689);
            this.Controls.Add(this.tableLayoutPanelFondoGeneral);
            this.Controls.Add(this.tableLayoutPanelBarraMultifuncion);
            this.Controls.Add(this.menuOpcionesDeProyectos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpcionesDeProyectos;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIT Solver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.Shown += new System.EventHandler(this.main_Shown);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.contextMenuStripNodos.ResumeLayout(false);
            this.tableLayoutPanelFondoGeneral.ResumeLayout(false);
            this.tabControl_Pages.ResumeLayout(false);
            this.tabProyectos.ResumeLayout(false);
            this.tabProyectos.PerformLayout();
            this.tableLayoutPanelProyectos.ResumeLayout(false);
            this.MDI_RIT_Panel.ResumeLayout(false);
            this.tableLayoutPanelProyectos_Nodos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabFormCompusof.ResumeLayout(false);
            this.tabFormCompusof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_CompusofForms)).EndInit();
            this.statusStripForms.ResumeLayout(false);
            this.statusStripForms.PerformLayout();
            this.tabServiceDeskGMXT.ResumeLayout(false);
            this.tabServiceDeskGMXT.PerformLayout();
            this.statusStripSDPGMXT.ResumeLayout(false);
            this.statusStripSDPGMXT.PerformLayout();
            this.tabServiceDeskCompusof.ResumeLayout(false);
            this.tabServiceDeskCompusof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView_ServiceDeskCompusof)).EndInit();
            this.statusStripEndPointcentral.ResumeLayout(false);
            this.statusStripEndPointcentral.PerformLayout();
            this.tabEndpointCentral.ResumeLayout(false);
            this.tabEndpointCentral.PerformLayout();
            this.statusStripSDPCompusof.ResumeLayout(false);
            this.statusStripSDPCompusof.PerformLayout();
            this.tabCentroDeControl.ResumeLayout(false);
            this.tabCentroDeControl.PerformLayout();
            this.tableLayoutPanelCentroDeControl.ResumeLayout(false);
            this.MDI_ACT_Panel.ResumeLayout(false);
            this.tableLayoutPanelCentroDeControl_Nodos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuOpcionesActividades.ResumeLayout(false);
            this.menuOpcionesAnuncios.ResumeLayout(false);
            this.tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ResumeLayout(false);
            this.tableLayoutPanelBarraMultifuncion.ResumeLayout(false);
            this.tableLayoutPanelBarraMultifuncion.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.menuOpcionesDeProyectos.ResumeLayout(false);
            this.menuOpcionesDeProyectos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFondoGeneral;
        private flCustomTabControl tabControl_Pages;
        private System.Windows.Forms.TabPage tabFormCompusof;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TabPage tabServiceDeskGMXT;
        private System.Windows.Forms.TabPage tabEndpointCentral;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TabPage tabServiceDeskCompusof;
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabCentroDeControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentroDeControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentroDeControl_Nodos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolCrearActividad;
        private System.Windows.Forms.ToolStripButton toolAbrirActividad;
        private System.Windows.Forms.ToolStripButton toolEliminarActividad;
        private System.Windows.Forms.ToolStripButton toolCerrarActividad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProyectos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolNuevoProyecto;
        private System.Windows.Forms.ToolStripButton toolAbrirProyectoExistente;
        private System.Windows.Forms.Panel MDI_RIT_Panel;
        private System.Windows.Forms.ToolStripButton toolEliminarProyecto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolImportarActividad;
        private System.Windows.Forms.ToolStripButton toolExportarActividad;
        private System.Windows.Forms.Label lblNombreSeccion;
        private System.Windows.Forms.Label lblNombreNodoSeleccionado;
        private System.Windows.Forms.ToolStripButton toolNuevaSeccion;
        private System.Windows.Forms.Label lblDescripcionDeNodo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cerrarProyectoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripSDPCompusof;
        private System.Windows.Forms.StatusStrip statusStripSDPGMXT;
        private System.Windows.Forms.StatusStrip statusStripForms;
        private System.Windows.Forms.StatusStrip statusStripEndPointcentral;


        private System.Windows.Forms.ToolStripLabel URL_EndPoint_Central_Label;         // Label Compusof
        private System.Windows.Forms.ToolStripLabel URL_GMXT_SAS_Label;             // Label Ferromex   
        private System.Windows.Forms.ToolStripLabel URL_RIT_Forms_Label;            // Label RIT Forms
        private System.Windows.Forms.ToolStripLabel URL_SDP_Compusof_Label;     // Label EndPoint Central

        private System.Windows.Forms.ToolStripButton toolBtnRecargarForms;                  // Recargar RIT Forms
        private System.Windows.Forms.ToolStripButton toolBtnRecargarSAS;                    // Recargar SAS Ferromex
        private System.Windows.Forms.ToolStripButton toolBtnRecargarServiceDeskCompusof;    // Recargar SDP Compusof
        private System.Windows.Forms.ToolStripButton toolBtnRecargarSDPCompusof;        // Recargar EndPoint Central
        private System.Windows.Forms.ToolStripButton toolNuevoPendientePorHacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ContextMenuStrip menuOpcionesActividades;
        private System.Windows.Forms.ToolStripMenuItem crearActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem maximizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem enviarAvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarPermanentementeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuOpcionesAnuncios;
        private System.Windows.Forms.ToolStripMenuItem crearAnuncioStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirAnuncioStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem maximizarStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minizarStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDeLaVistaStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem borrarPermanentementeStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem cerrarStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBarraMultifuncion_BotonesIzquierda;
        private System.Windows.Forms.Button btnFuncion2;
        private System.Windows.Forms.Button btnFuncion1;
        private System.Windows.Forms.LinkLabel lblContactoFallos;
        private System.Windows.Forms.Button btnFuncion3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBarraMultifuncion;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosRecientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem nuevaActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAnuncioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarActualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarActualizacionesBETAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeInventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguimientoDeGuiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dHLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem imprimirRITEnBlancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem herramientaDeReparacionAvanzadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarFallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarSASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarManageDeskCompusofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarEndpointCentralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarRefaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarTonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escaladoDeReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organigramaDeContactoCompusofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pCIETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarEnCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omisorDeComprobacionesDeOracleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarEnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem grabarEnCarpetaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crystalDiskInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gtrabrToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuOpcionesDeProyectos;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label lblProyectos_Text;
        private System.ComponentModel.BackgroundWorker backgroundWorker_StartScreen;
        public System.ComponentModel.BackgroundWorker backgroundWorker_WaitScreen;
        private System.Windows.Forms.ToolStripButton toolGeneracionRapidaDeReporte;
        private System.ComponentModel.BackgroundWorker bgworker_RitSolverUpdater;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripNodos;
        private ChromiumWebBrowser chromiumWebBrowserEndPointCentral;
        public System.Windows.Forms.Panel MDI_ACT_Panel;
        public System.Windows.Forms.TreeView treeViewCentroDeControl;
        private System.Windows.Forms.ImageList imageList_Actividades;
        private System.Windows.Forms.ImageList imageList_RIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem funcionesWebMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarMacroFuncionWeb1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarMacroFuncionWeb2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarMacroFuncionWeb3ToolStripMenuItem;
        private System.Windows.Forms.Label lblCentroControl_Text;
        private System.ComponentModel.BackgroundWorker bgworkerMDIsFormsLoader;
        private System.Windows.Forms.ProgressBar pgrssbarAbrirFormularios;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_CompusofForms;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView_ServiceDeskCompusof;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProyectos_Nodos;
        public System.Windows.Forms.TreeView treeViewProyectos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox lblNombreDeNodoSeleccionado;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblNodoDeProyectosSeleccionado;
        private System.Windows.Forms.ToolStripButton toolMinimizarTodosLosReportes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem minimizarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolImportarListaDePendientes;
        private System.Windows.Forms.ToolStripButton toolCerrarListaDePendientes;
        private System.Windows.Forms.ToolStripButton toolEliminarListaDePendientesPorHacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStrpBtnCerrarProyectoActual;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStrpBtnMinimizarTodasLasVentanas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        public System.Windows.Forms.ToolStripLabel toolLblActualMDIReporteName;
        private System.Windows.Forms.ToolStripButton toolStrpBtnGuardarTodosLosProyectosActuales;
        private System.Windows.Forms.ToolStripButton toolStrpBtnCerrarTodosLosRitsAbiertos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        public System.Windows.Forms.ToolStripLabel toolLblActualMDIActividadName;
        private System.Windows.Forms.ToolStripButton toolStrpBtn_AbrirSegun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem listadoDeHistorialesToolStripMenuItem;
        public static ChromiumWebBrowser chromiumWebBrowserSASGMXT;
    }
}