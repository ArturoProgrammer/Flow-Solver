using FlowControls;

namespace Flow_Solver
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mis Proyectos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Actividades");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pendientes por hacer");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Historico de Estadisticas Mensuales", 3, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Seguimiento de Guias", 4, 4);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Solicitudes de Viaticos");
            contextMenuStripNodos = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cerrarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            minimizarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            tableLayoutPanelFondoGeneral = new System.Windows.Forms.TableLayoutPanel();
            tabControl_Pages = new flExtendedTabControl();
            tabProyectos = new System.Windows.Forms.TabPage();
            splitContainer_TabPageBack = new System.Windows.Forms.SplitContainer();
            splitContainer_HeaderTreeViewProyectos = new System.Windows.Forms.SplitContainer();
            splitContainer_ProyectosInformacion = new System.Windows.Forms.SplitContainer();
            treeViewProyectos = new System.Windows.Forms.TreeView();
            imageList_RIT = new System.Windows.Forms.ImageList(components);
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            MDI_RIT_Panel = new System.Windows.Forms.Panel();
            toolStrip_Proyectos = new flCustomToolStrip();
            toolNuevoProyecto = new System.Windows.Forms.ToolStripButton();
            toolAbrirProyectoExistente = new System.Windows.Forms.ToolStripButton();
            toolEliminarProyecto = new System.Windows.Forms.ToolStripButton();
            toolStrpBtnCerrarProyectoActual = new System.Windows.Forms.ToolStripButton();
            flCustomToolStripSeparator3 = new flCustomToolStripSeparator();
            toolStrpBtn_AbrirSegun = new System.Windows.Forms.ToolStripButton();
            flCustomToolStripSeparator4 = new flCustomToolStripSeparator();
            toolStrpBtnGuardarTodosLosProyectosActuales = new System.Windows.Forms.ToolStripButton();
            toolMinimizarTodosLosReportes = new System.Windows.Forms.ToolStripButton();
            toolStrpBtnCerrarTodosLosRitsAbiertos = new System.Windows.Forms.ToolStripButton();
            flCustomToolStripSeparator2 = new flCustomToolStripSeparator();
            toolGeneracionRapidaDeReporte = new System.Windows.Forms.ToolStripButton();
            toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            toolLblActualMDIReporteName = new System.Windows.Forms.ToolStripLabel();
            tabServiceDesk = new System.Windows.Forms.TabPage();
            tabServiceDeskCompusof = new System.Windows.Forms.TabPage();
            statusStripEndPointcentral = new System.Windows.Forms.StatusStrip();
            toolBtnRecargarSDPCompusof = new System.Windows.Forms.ToolStripButton();
            URL_SDP_Compusof_Label = new System.Windows.Forms.ToolStripLabel();
            tabEndpointCentral = new System.Windows.Forms.TabPage();
            statusStripSDPCompusof = new System.Windows.Forms.StatusStrip();
            toolBtnRecargarServiceDeskCompusof = new System.Windows.Forms.ToolStripButton();
            URL_EndPoint_Central_Label = new System.Windows.Forms.ToolStripLabel();
            tabCentroDeControl = new System.Windows.Forms.TabPage();
            tableLayoutPanelCentroDeControl = new System.Windows.Forms.TableLayoutPanel();
            MDI_ACT_Panel = new System.Windows.Forms.Panel();
            lblCentroControl_Text = new System.Windows.Forms.Label();
            tableLayoutPanelCentroDeControl_Nodos = new System.Windows.Forms.TableLayoutPanel();
            treeViewCentroDeControl = new System.Windows.Forms.TreeView();
            imageList_Actividades = new System.Windows.Forms.ImageList(components);
            panel3 = new System.Windows.Forms.Panel();
            lblDescripcionDeNodo = new System.Windows.Forms.Label();
            lblNombreNodoSeleccionado = new flCustomLabel();
            panel1 = new System.Windows.Forms.Panel();
            lblNombreSeccion = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolCrearActividad = new System.Windows.Forms.ToolStripButton();
            toolAbrirActividad = new System.Windows.Forms.ToolStripButton();
            toolEliminarActividad = new System.Windows.Forms.ToolStripButton();
            toolCerrarActividad = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolImportarActividad = new System.Windows.Forms.ToolStripButton();
            toolExportarActividad = new System.Windows.Forms.ToolStripButton();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolNuevoPendientePorHacer = new System.Windows.Forms.ToolStripButton();
            toolImportarListaDePendientes = new System.Windows.Forms.ToolStripButton();
            toolEliminarListaDePendientesPorHacer = new System.Windows.Forms.ToolStripButton();
            toolCerrarListaDePendientes = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            toolNuevaSeccion = new System.Windows.Forms.ToolStripButton();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStrpBtnMinimizarTodasLasVentanas = new System.Windows.Forms.ToolStripButton();
            toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            toolLblActualMDIActividadName = new System.Windows.Forms.ToolStripLabel();
            webBrowser4 = new System.Windows.Forms.WebBrowser();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            menuOpcionesActividades = new System.Windows.Forms.ContextMenuStrip(components);
            crearActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            maximizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            enviarAvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            borrarPermanentementeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuOpcionesAnuncios = new System.Windows.Forms.ContextMenuStrip(components);
            crearAnuncioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirAnuncioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            maximizarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            minizarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarDeLaVistaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            borrarPermanentementeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            cerrarStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda = new System.Windows.Forms.TableLayoutPanel();
            btnFuncion2 = new flCustomButton();
            btnFuncion1 = new flCustomButton();
            lblContactoFallos = new System.Windows.Forms.LinkLabel();
            btnFuncion3 = new flCustomButton();
            tableLayoutPanelBarraMultifuncion = new System.Windows.Forms.TableLayoutPanel();
            panel7 = new System.Windows.Forms.Panel();
            menuOpcionesDeProyectos = new System.Windows.Forms.MenuStrip();
            archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            abrirTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            archivosRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            nuevaActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nuevoAnuncioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            buscarActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buscarActualizacionesBETAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            sistemaDeInventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seleccionarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listadoDeHistorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            seguimientoDeGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dHLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            paqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fedexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            imprimirRITEnBlancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            herramientaDeReparacionAvanzadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportarFallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            recargarSASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            recargarFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            recargarManageDeskCompusofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            recargarEndpointCentralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            funcionesWebMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarMacroFuncionWeb1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarMacroFuncionWeb2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarMacroFuncionWeb3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            solicitarRefaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            solicitarTonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            escaladoDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            organigramaDeContactoCompusofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            herramientasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            pCIETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            grabarEnCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            omisorDeComprobacionesDeOracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            grabarEnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            grabarEnCarpetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            crystalDiskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejecutarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            gtrabrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backgroundWorker_StartScreen = new System.ComponentModel.BackgroundWorker();
            backgroundWorker_WaitScreen = new System.ComponentModel.BackgroundWorker();
            bgworker_RitSolverUpdater = new System.ComponentModel.BackgroundWorker();
            bgworkerMDIsFormsLoader = new System.ComponentModel.BackgroundWorker();
            miniToolStrip = new System.Windows.Forms.StatusStrip();
            toolBtnRecargarSAS = new System.Windows.Forms.ToolStripButton();
            URL_GMXT_SAS_Label = new System.Windows.Forms.ToolStripLabel();
            statusStripSDPGMXT = new System.Windows.Forms.StatusStrip();
            panel2 = new System.Windows.Forms.Panel();
            lblNodoDeProyectosSeleccionado = new flCustomLabel();
            contextMenuStripNodos.SuspendLayout();
            tableLayoutPanelFondoGeneral.SuspendLayout();
            tabControl_Pages.SuspendLayout();
            tabProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_TabPageBack).BeginInit();
            splitContainer_TabPageBack.Panel1.SuspendLayout();
            splitContainer_TabPageBack.Panel2.SuspendLayout();
            splitContainer_TabPageBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_HeaderTreeViewProyectos).BeginInit();
            splitContainer_HeaderTreeViewProyectos.Panel1.SuspendLayout();
            splitContainer_HeaderTreeViewProyectos.Panel2.SuspendLayout();
            splitContainer_HeaderTreeViewProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ProyectosInformacion).BeginInit();
            splitContainer_ProyectosInformacion.Panel1.SuspendLayout();
            splitContainer_ProyectosInformacion.Panel2.SuspendLayout();
            splitContainer_ProyectosInformacion.SuspendLayout();
            toolStrip_Proyectos.SuspendLayout();
            tabServiceDeskCompusof.SuspendLayout();
            statusStripEndPointcentral.SuspendLayout();
            tabEndpointCentral.SuspendLayout();
            statusStripSDPCompusof.SuspendLayout();
            tabCentroDeControl.SuspendLayout();
            tableLayoutPanelCentroDeControl.SuspendLayout();
            MDI_ACT_Panel.SuspendLayout();
            tableLayoutPanelCentroDeControl_Nodos.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuOpcionesActividades.SuspendLayout();
            menuOpcionesAnuncios.SuspendLayout();
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.SuspendLayout();
            tableLayoutPanelBarraMultifuncion.SuspendLayout();
            panel7.SuspendLayout();
            menuOpcionesDeProyectos.SuspendLayout();
            statusStripSDPGMXT.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStripNodos
            // 
            contextMenuStripNodos.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStripNodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem1, cerrarProyectoToolStripMenuItem, toolStripMenuItem3, toolStripSeparator19, minimizarProyectoToolStripMenuItem });
            contextMenuStripNodos.Name = "contextMenuStripNodos";
            contextMenuStripNodos.Size = new System.Drawing.Size(244, 140);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.project;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(243, 26);
            toolStripMenuItem2.Text = "Nuevo proyecto";
            toolStripMenuItem2.Click += nuevoProyectoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.project_delete;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            toolStripMenuItem1.Text = "Eliminar proyecto seleccionado";
            toolStripMenuItem1.Click += toolEliminarProyecto_Click;
            // 
            // cerrarProyectoToolStripMenuItem
            // 
            cerrarProyectoToolStripMenuItem.Image = Properties.Resources.close1_32;
            cerrarProyectoToolStripMenuItem.Name = "cerrarProyectoToolStripMenuItem";
            cerrarProyectoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            cerrarProyectoToolStripMenuItem.Text = "Cerrar proyecto";
            cerrarProyectoToolStripMenuItem.Click += cerrarProyectoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(243, 26);
            toolStripMenuItem3.Text = "Enviar por correo";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripSeparator19
            // 
            toolStripSeparator19.Name = "toolStripSeparator19";
            toolStripSeparator19.Size = new System.Drawing.Size(240, 6);
            // 
            // minimizarProyectoToolStripMenuItem
            // 
            minimizarProyectoToolStripMenuItem.Image = Properties.Resources.minimize_window_32;
            minimizarProyectoToolStripMenuItem.Name = "minimizarProyectoToolStripMenuItem";
            minimizarProyectoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            minimizarProyectoToolStripMenuItem.Text = "Minimizar proyecto";
            minimizarProyectoToolStripMenuItem.Click += minimizarProyectoToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.UseEXDialog = true;
            // 
            // tableLayoutPanelFondoGeneral
            // 
            tableLayoutPanelFondoGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelFondoGeneral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            tableLayoutPanelFondoGeneral.ColumnCount = 1;
            tableLayoutPanelFondoGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanelFondoGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            tableLayoutPanelFondoGeneral.Controls.Add(tabControl_Pages, 0, 1);
            tableLayoutPanelFondoGeneral.Location = new System.Drawing.Point(0, 28);
            tableLayoutPanelFondoGeneral.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelFondoGeneral.Name = "tableLayoutPanelFondoGeneral";
            tableLayoutPanelFondoGeneral.RowCount = 2;
            tableLayoutPanelFondoGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.5020914F));
            tableLayoutPanelFondoGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.91939F));
            tableLayoutPanelFondoGeneral.Size = new System.Drawing.Size(1172, 576);
            tableLayoutPanelFondoGeneral.TabIndex = 2;
            // 
            // tabControl_Pages
            // 
            tabControl_Pages.CanCloseTabs = false;
            tabControl_Pages.CloseButtonHoverColor = System.Drawing.Color.Red;
            tabControl_Pages.ControlBackColor = System.Drawing.SystemColors.ActiveCaption;
            tabControl_Pages.Controls.Add(tabProyectos);
            tabControl_Pages.Controls.Add(tabServiceDesk);
            tabControl_Pages.Controls.Add(tabServiceDeskCompusof);
            tabControl_Pages.Controls.Add(tabEndpointCentral);
            tabControl_Pages.Controls.Add(tabCentroDeControl);
            tabControl_Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl_Pages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl_Pages.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabControl_Pages.ForeSelectionColor = System.Drawing.Color.White;
            tabControl_Pages.ForeUnselectedColor = System.Drawing.Color.DimGray;
            tabControl_Pages.HotTrack = true;
            tabControl_Pages.HoverColor = System.Drawing.Color.FromArgb(50, 200, 200, 200);
            tabControl_Pages.ItemSize = new System.Drawing.Size(200, 35);
            tabControl_Pages.Location = new System.Drawing.Point(0, 2);
            tabControl_Pages.Margin = new System.Windows.Forms.Padding(0);
            tabControl_Pages.Name = "tabControl_Pages";
            tabControl_Pages.SelectedIndex = 0;
            tabControl_Pages.SelectionColor = System.Drawing.Color.DeepSkyBlue;
            tabControl_Pages.Size = new System.Drawing.Size(1172, 574);
            tabControl_Pages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl_Pages.TabIndex = 3;
            tabControl_Pages.UnselectionColor = System.Drawing.Color.LightGray;
            tabControl_Pages.SelectedIndexChanged += tabControl2_SelectedIndexChanged;
            // 
            // tabProyectos
            // 
            tabProyectos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            tabProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabProyectos.Controls.Add(splitContainer_TabPageBack);
            tabProyectos.Controls.Add(toolStrip_Proyectos);
            tabProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabProyectos.Location = new System.Drawing.Point(4, 39);
            tabProyectos.Margin = new System.Windows.Forms.Padding(0);
            tabProyectos.Name = "tabProyectos";
            tabProyectos.Size = new System.Drawing.Size(1164, 531);
            tabProyectos.TabIndex = 5;
            tabProyectos.Text = "Proyectos";
            // 
            // splitContainer_TabPageBack
            // 
            splitContainer_TabPageBack.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_TabPageBack.Location = new System.Drawing.Point(0, 42);
            splitContainer_TabPageBack.Margin = new System.Windows.Forms.Padding(6);
            splitContainer_TabPageBack.Name = "splitContainer_TabPageBack";
            // 
            // splitContainer_TabPageBack.Panel1
            // 
            splitContainer_TabPageBack.Panel1.Controls.Add(splitContainer_HeaderTreeViewProyectos);
            // 
            // splitContainer_TabPageBack.Panel2
            // 
            splitContainer_TabPageBack.Panel2.Controls.Add(MDI_RIT_Panel);
            splitContainer_TabPageBack.Size = new System.Drawing.Size(1162, 487);
            splitContainer_TabPageBack.SplitterDistance = 264;
            splitContainer_TabPageBack.SplitterWidth = 6;
            splitContainer_TabPageBack.TabIndex = 2;
            // 
            // splitContainer_HeaderTreeViewProyectos
            // 
            splitContainer_HeaderTreeViewProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_HeaderTreeViewProyectos.Location = new System.Drawing.Point(0, 0);
            splitContainer_HeaderTreeViewProyectos.Margin = new System.Windows.Forms.Padding(0);
            splitContainer_HeaderTreeViewProyectos.Name = "splitContainer_HeaderTreeViewProyectos";
            splitContainer_HeaderTreeViewProyectos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_HeaderTreeViewProyectos.Panel1
            // 
            splitContainer_HeaderTreeViewProyectos.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            splitContainer_HeaderTreeViewProyectos.Panel1.Controls.Add(panel2);
            // 
            // splitContainer_HeaderTreeViewProyectos.Panel2
            // 
            splitContainer_HeaderTreeViewProyectos.Panel2.Controls.Add(splitContainer_ProyectosInformacion);
            splitContainer_HeaderTreeViewProyectos.Size = new System.Drawing.Size(264, 487);
            splitContainer_HeaderTreeViewProyectos.SplitterDistance = 38;
            splitContainer_HeaderTreeViewProyectos.SplitterWidth = 6;
            splitContainer_HeaderTreeViewProyectos.TabIndex = 0;
            // 
            // splitContainer_ProyectosInformacion
            // 
            splitContainer_ProyectosInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_ProyectosInformacion.Location = new System.Drawing.Point(0, 0);
            splitContainer_ProyectosInformacion.Margin = new System.Windows.Forms.Padding(0);
            splitContainer_ProyectosInformacion.Name = "splitContainer_ProyectosInformacion";
            splitContainer_ProyectosInformacion.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_ProyectosInformacion.Panel1
            // 
            splitContainer_ProyectosInformacion.Panel1.Controls.Add(treeViewProyectos);
            // 
            // splitContainer_ProyectosInformacion.Panel2
            // 
            splitContainer_ProyectosInformacion.Panel2.Controls.Add(propertyGrid1);
            splitContainer_ProyectosInformacion.Size = new System.Drawing.Size(264, 443);
            splitContainer_ProyectosInformacion.SplitterDistance = 327;
            splitContainer_ProyectosInformacion.SplitterWidth = 6;
            splitContainer_ProyectosInformacion.TabIndex = 0;
            // 
            // treeViewProyectos
            // 
            treeViewProyectos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            treeViewProyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            treeViewProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            treeViewProyectos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold);
            treeViewProyectos.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            treeViewProyectos.ImageIndex = 0;
            treeViewProyectos.ImageList = imageList_RIT;
            treeViewProyectos.ItemHeight = 32;
            treeViewProyectos.Location = new System.Drawing.Point(0, 0);
            treeViewProyectos.Margin = new System.Windows.Forms.Padding(0);
            treeViewProyectos.Name = "treeViewProyectos";
            treeNode2.Name = "nodeMisProyectos";
            treeNode2.Text = "Mis Proyectos";
            treeViewProyectos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode2 });
            treeViewProyectos.SelectedImageIndex = 0;
            treeViewProyectos.Size = new System.Drawing.Size(264, 327);
            treeViewProyectos.TabIndex = 1;
            // 
            // imageList_RIT
            // 
            imageList_RIT.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList_RIT.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList_RIT.ImageStream");
            imageList_RIT.TransparentColor = System.Drawing.Color.Transparent;
            imageList_RIT.Images.SetKeyName(0, "open-folder.png");
            imageList_RIT.Images.SetKeyName(1, "project-128.png");
            imageList_RIT.Images.SetKeyName(2, "project-comprobado.png");
            imageList_RIT.Images.SetKeyName(3, "project-printed.png");
            imageList_RIT.Images.SetKeyName(4, "project-signed.png");
            // 
            // propertyGrid1
            // 
            propertyGrid1.CommandsVisibleIfAvailable = false;
            propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyGrid1.HelpVisible = false;
            propertyGrid1.Location = new System.Drawing.Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new System.Drawing.Size(264, 110);
            propertyGrid1.TabIndex = 0;
            propertyGrid1.ViewBackColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // MDI_RIT_Panel
            // 
            MDI_RIT_Panel.BackColor = System.Drawing.Color.LightBlue;
            MDI_RIT_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            MDI_RIT_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            MDI_RIT_Panel.Location = new System.Drawing.Point(0, 0);
            MDI_RIT_Panel.Margin = new System.Windows.Forms.Padding(0);
            MDI_RIT_Panel.Name = "MDI_RIT_Panel";
            MDI_RIT_Panel.Size = new System.Drawing.Size(892, 487);
            MDI_RIT_Panel.TabIndex = 2;
            // 
            // toolStrip_Proyectos
            // 
            toolStrip_Proyectos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip_Proyectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip_Proyectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolNuevoProyecto, toolAbrirProyectoExistente, toolEliminarProyecto, toolStrpBtnCerrarProyectoActual, flCustomToolStripSeparator3, toolStrpBtn_AbrirSegun, flCustomToolStripSeparator4, toolStrpBtnGuardarTodosLosProyectosActuales, toolMinimizarTodosLosReportes, toolStrpBtnCerrarTodosLosRitsAbiertos, flCustomToolStripSeparator2, toolGeneracionRapidaDeReporte, toolStripLabel4, toolStripLabel3, toolLblActualMDIReporteName });
            toolStrip_Proyectos.Location = new System.Drawing.Point(0, 0);
            toolStrip_Proyectos.Name = "toolStrip_Proyectos";
            toolStrip_Proyectos.Size = new System.Drawing.Size(1162, 42);
            toolStrip_Proyectos.TabIndex = 0;
            toolStrip_Proyectos.Text = "toolStrip2";
            // 
            // toolNuevoProyecto
            // 
            toolNuevoProyecto.Image = Properties.Resources.project;
            toolNuevoProyecto.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolNuevoProyecto.Name = "toolNuevoProyecto";
            toolNuevoProyecto.Size = new System.Drawing.Size(46, 39);
            toolNuevoProyecto.Text = "Nuevo";
            toolNuevoProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolNuevoProyecto.Click += nuevoProyectoToolStripMenuItem_Click;
            // 
            // toolAbrirProyectoExistente
            // 
            toolAbrirProyectoExistente.Image = Properties.Resources.project_open;
            toolAbrirProyectoExistente.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolAbrirProyectoExistente.Name = "toolAbrirProyectoExistente";
            toolAbrirProyectoExistente.Size = new System.Drawing.Size(37, 39);
            toolAbrirProyectoExistente.Text = "Abrir";
            toolAbrirProyectoExistente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolAbrirProyectoExistente.Click += abrirTicketToolStripMenuItem_Click;
            // 
            // toolEliminarProyecto
            // 
            toolEliminarProyecto.Enabled = false;
            toolEliminarProyecto.Image = Properties.Resources.project_delete;
            toolEliminarProyecto.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolEliminarProyecto.Name = "toolEliminarProyecto";
            toolEliminarProyecto.Size = new System.Drawing.Size(54, 39);
            toolEliminarProyecto.Text = "Eliminar";
            toolEliminarProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolEliminarProyecto.Click += toolEliminarProyecto_Click;
            // 
            // toolStrpBtnCerrarProyectoActual
            // 
            toolStrpBtnCerrarProyectoActual.Enabled = false;
            toolStrpBtnCerrarProyectoActual.Image = Properties.Resources.close1_32;
            toolStrpBtnCerrarProyectoActual.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStrpBtnCerrarProyectoActual.Name = "toolStrpBtnCerrarProyectoActual";
            toolStrpBtnCerrarProyectoActual.Size = new System.Drawing.Size(43, 39);
            toolStrpBtnCerrarProyectoActual.Text = "Cerrar";
            toolStrpBtnCerrarProyectoActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStrpBtnCerrarProyectoActual.Click += toolStrpBtnCerrarProyectoActual_Click;
            // 
            // flCustomToolStripSeparator3
            // 
            flCustomToolStripSeparator3.AutoSize = false;
            flCustomToolStripSeparator3.LineColor = System.Drawing.Color.DimGray;
            flCustomToolStripSeparator3.LineMargin = 2;
            flCustomToolStripSeparator3.Name = "flCustomToolStripSeparator3";
            flCustomToolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStrpBtn_AbrirSegun
            // 
            toolStrpBtn_AbrirSegun.Image = Properties.Resources.selection_items_32;
            toolStrpBtn_AbrirSegun.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStrpBtn_AbrirSegun.Name = "toolStrpBtn_AbrirSegun";
            toolStrpBtn_AbrirSegun.Size = new System.Drawing.Size(46, 39);
            toolStrpBtn_AbrirSegun.Text = "Abrir...";
            toolStrpBtn_AbrirSegun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStrpBtn_AbrirSegun.Click += toolStrpBtn_AbrirSegun_Click;
            // 
            // flCustomToolStripSeparator4
            // 
            flCustomToolStripSeparator4.AutoSize = false;
            flCustomToolStripSeparator4.LineColor = System.Drawing.Color.DimGray;
            flCustomToolStripSeparator4.LineMargin = 2;
            flCustomToolStripSeparator4.Name = "flCustomToolStripSeparator4";
            flCustomToolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStrpBtnGuardarTodosLosProyectosActuales
            // 
            toolStrpBtnGuardarTodosLosProyectosActuales.Enabled = false;
            toolStrpBtnGuardarTodosLosProyectosActuales.Image = Properties.Resources.save_all2;
            toolStrpBtnGuardarTodosLosProyectosActuales.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStrpBtnGuardarTodosLosProyectosActuales.Name = "toolStrpBtnGuardarTodosLosProyectosActuales";
            toolStrpBtnGuardarTodosLosProyectosActuales.Size = new System.Drawing.Size(81, 39);
            toolStrpBtnGuardarTodosLosProyectosActuales.Text = "Guardar todo";
            toolStrpBtnGuardarTodosLosProyectosActuales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStrpBtnGuardarTodosLosProyectosActuales.Click += toolStrpBtnGuardarTodosLosProyectosActuales_Click;
            // 
            // toolMinimizarTodosLosReportes
            // 
            toolMinimizarTodosLosReportes.Enabled = false;
            toolMinimizarTodosLosReportes.Image = Properties.Resources.minimize_all_windows;
            toolMinimizarTodosLosReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolMinimizarTodosLosReportes.Name = "toolMinimizarTodosLosReportes";
            toolMinimizarTodosLosReportes.Size = new System.Drawing.Size(92, 39);
            toolMinimizarTodosLosReportes.Text = "Minimizar todo";
            toolMinimizarTodosLosReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolMinimizarTodosLosReportes.Click += toolMinimizarTodosLosReportes_Click;
            // 
            // toolStrpBtnCerrarTodosLosRitsAbiertos
            // 
            toolStrpBtnCerrarTodosLosRitsAbiertos.Enabled = false;
            toolStrpBtnCerrarTodosLosRitsAbiertos.Image = Properties.Resources.close_all_38;
            toolStrpBtnCerrarTodosLosRitsAbiertos.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStrpBtnCerrarTodosLosRitsAbiertos.Name = "toolStrpBtnCerrarTodosLosRitsAbiertos";
            toolStrpBtnCerrarTodosLosRitsAbiertos.Size = new System.Drawing.Size(71, 39);
            toolStrpBtnCerrarTodosLosRitsAbiertos.Text = "Cerrar todo";
            toolStrpBtnCerrarTodosLosRitsAbiertos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolStrpBtnCerrarTodosLosRitsAbiertos.Click += toolStrpBtnCerrarTodosLosRitsAbiertos_Click;
            // 
            // flCustomToolStripSeparator2
            // 
            flCustomToolStripSeparator2.AutoSize = false;
            flCustomToolStripSeparator2.LineColor = System.Drawing.Color.DimGray;
            flCustomToolStripSeparator2.LineMargin = 2;
            flCustomToolStripSeparator2.Name = "flCustomToolStripSeparator2";
            flCustomToolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolGeneracionRapidaDeReporte
            // 
            toolGeneracionRapidaDeReporte.Enabled = false;
            toolGeneracionRapidaDeReporte.Image = Properties.Resources.fast_64;
            toolGeneracionRapidaDeReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolGeneracionRapidaDeReporte.Name = "toolGeneracionRapidaDeReporte";
            toolGeneracionRapidaDeReporte.Size = new System.Drawing.Size(58, 39);
            toolGeneracionRapidaDeReporte.Text = "Gen. rap.";
            toolGeneracionRapidaDeReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolGeneracionRapidaDeReporte.Click += toolGeneracionRapidaDeReporte_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new System.Drawing.Size(10, 39);
            toolStripLabel4.Text = " ";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new System.Drawing.Size(69, 39);
            toolStripLabel3.Text = "Actual MDI:";
            // 
            // toolLblActualMDIReporteName
            // 
            toolLblActualMDIReporteName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            toolLblActualMDIReporteName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            toolLblActualMDIReporteName.Name = "toolLblActualMDIReporteName";
            toolLblActualMDIReporteName.Size = new System.Drawing.Size(12, 39);
            toolLblActualMDIReporteName.Text = "-";
            // 
            // tabServiceDesk
            // 
            tabServiceDesk.AutoScroll = true;
            tabServiceDesk.BackColor = System.Drawing.Color.LightBlue;
            tabServiceDesk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabServiceDesk.Location = new System.Drawing.Point(4, 39);
            tabServiceDesk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabServiceDesk.Name = "tabServiceDesk";
            tabServiceDesk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabServiceDesk.Size = new System.Drawing.Size(1164, 531);
            tabServiceDesk.TabIndex = 1;
            tabServiceDesk.Text = "ServiceDesk";
            // 
            // tabServiceDeskCompusof
            // 
            tabServiceDeskCompusof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabServiceDeskCompusof.Controls.Add(statusStripEndPointcentral);
            tabServiceDeskCompusof.Location = new System.Drawing.Point(4, 39);
            tabServiceDeskCompusof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabServiceDeskCompusof.Name = "tabServiceDeskCompusof";
            tabServiceDeskCompusof.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabServiceDeskCompusof.Size = new System.Drawing.Size(1164, 531);
            tabServiceDeskCompusof.TabIndex = 4;
            tabServiceDeskCompusof.Text = "ServiceDesk Compusof";
            tabServiceDeskCompusof.UseVisualStyleBackColor = true;
            // 
            // statusStripEndPointcentral
            // 
            statusStripEndPointcentral.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStripEndPointcentral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBtnRecargarSDPCompusof, URL_SDP_Compusof_Label });
            statusStripEndPointcentral.Location = new System.Drawing.Point(3, 501);
            statusStripEndPointcentral.Name = "statusStripEndPointcentral";
            statusStripEndPointcentral.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            statusStripEndPointcentral.Size = new System.Drawing.Size(1156, 26);
            statusStripEndPointcentral.TabIndex = 0;
            // 
            // toolBtnRecargarSDPCompusof
            // 
            toolBtnRecargarSDPCompusof.Image = Properties.Resources.refresh;
            toolBtnRecargarSDPCompusof.Name = "toolBtnRecargarSDPCompusof";
            toolBtnRecargarSDPCompusof.Size = new System.Drawing.Size(77, 24);
            toolBtnRecargarSDPCompusof.Text = "Recargar";
            toolBtnRecargarSDPCompusof.Click += recargarEndpointCentralToolStripMenuItem_Click;
            // 
            // URL_SDP_Compusof_Label
            // 
            URL_SDP_Compusof_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            URL_SDP_Compusof_Label.Name = "URL_SDP_Compusof_Label";
            URL_SDP_Compusof_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabEndpointCentral
            // 
            tabEndpointCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabEndpointCentral.Controls.Add(statusStripSDPCompusof);
            tabEndpointCentral.Location = new System.Drawing.Point(4, 39);
            tabEndpointCentral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabEndpointCentral.Name = "tabEndpointCentral";
            tabEndpointCentral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabEndpointCentral.Size = new System.Drawing.Size(1164, 531);
            tabEndpointCentral.TabIndex = 2;
            tabEndpointCentral.Text = "Endpoint Central";
            tabEndpointCentral.UseVisualStyleBackColor = true;
            // 
            // statusStripSDPCompusof
            // 
            statusStripSDPCompusof.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStripSDPCompusof.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBtnRecargarServiceDeskCompusof, URL_EndPoint_Central_Label });
            statusStripSDPCompusof.Location = new System.Drawing.Point(3, 501);
            statusStripSDPCompusof.Name = "statusStripSDPCompusof";
            statusStripSDPCompusof.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            statusStripSDPCompusof.Size = new System.Drawing.Size(1156, 26);
            statusStripSDPCompusof.TabIndex = 1;
            // 
            // toolBtnRecargarServiceDeskCompusof
            // 
            toolBtnRecargarServiceDeskCompusof.Image = Properties.Resources.refresh;
            toolBtnRecargarServiceDeskCompusof.Name = "toolBtnRecargarServiceDeskCompusof";
            toolBtnRecargarServiceDeskCompusof.Size = new System.Drawing.Size(77, 24);
            toolBtnRecargarServiceDeskCompusof.Text = "Recargar";
            toolBtnRecargarServiceDeskCompusof.Click += recargarManageDeskCompusofToolStripMenuItem_Click;
            // 
            // URL_EndPoint_Central_Label
            // 
            URL_EndPoint_Central_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            URL_EndPoint_Central_Label.Name = "URL_EndPoint_Central_Label";
            URL_EndPoint_Central_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // tabCentroDeControl
            // 
            tabCentroDeControl.BackColor = System.Drawing.Color.DimGray;
            tabCentroDeControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tabCentroDeControl.Controls.Add(tableLayoutPanelCentroDeControl);
            tabCentroDeControl.Controls.Add(toolStrip1);
            tabCentroDeControl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabCentroDeControl.Location = new System.Drawing.Point(4, 39);
            tabCentroDeControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabCentroDeControl.Name = "tabCentroDeControl";
            tabCentroDeControl.Size = new System.Drawing.Size(1164, 531);
            tabCentroDeControl.TabIndex = 6;
            tabCentroDeControl.Text = "Centro de Control";
            // 
            // tableLayoutPanelCentroDeControl
            // 
            tableLayoutPanelCentroDeControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanelCentroDeControl.ColumnCount = 2;
            tableLayoutPanelCentroDeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86275F));
            tableLayoutPanelCentroDeControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.13725F));
            tableLayoutPanelCentroDeControl.Controls.Add(MDI_ACT_Panel, 1, 0);
            tableLayoutPanelCentroDeControl.Controls.Add(tableLayoutPanelCentroDeControl_Nodos, 0, 0);
            tableLayoutPanelCentroDeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelCentroDeControl.Location = new System.Drawing.Point(0, 27);
            tableLayoutPanelCentroDeControl.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelCentroDeControl.Name = "tableLayoutPanelCentroDeControl";
            tableLayoutPanelCentroDeControl.RowCount = 1;
            tableLayoutPanelCentroDeControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.04655F));
            tableLayoutPanelCentroDeControl.Size = new System.Drawing.Size(1162, 502);
            tableLayoutPanelCentroDeControl.TabIndex = 1;
            // 
            // MDI_ACT_Panel
            // 
            MDI_ACT_Panel.BackColor = System.Drawing.Color.DarkGray;
            MDI_ACT_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            MDI_ACT_Panel.Controls.Add(lblCentroControl_Text);
            MDI_ACT_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            MDI_ACT_Panel.Location = new System.Drawing.Point(200, 3);
            MDI_ACT_Panel.Margin = new System.Windows.Forms.Padding(0);
            MDI_ACT_Panel.Name = "MDI_ACT_Panel";
            MDI_ACT_Panel.Size = new System.Drawing.Size(959, 496);
            MDI_ACT_Panel.TabIndex = 0;
            MDI_ACT_Panel.ControlAdded += panelMDIContainerActividades_ControlAdded;
            MDI_ACT_Panel.ControlRemoved += panelMDIContainerActividades_ControlRemoved;
            // 
            // lblCentroControl_Text
            // 
            lblCentroControl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCentroControl_Text.Font = new System.Drawing.Font("Microsoft New Tai Lue", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCentroControl_Text.Location = new System.Drawing.Point(0, 0);
            lblCentroControl_Text.Name = "lblCentroControl_Text";
            lblCentroControl_Text.Size = new System.Drawing.Size(955, 492);
            lblCentroControl_Text.TabIndex = 1;
            lblCentroControl_Text.Text = "Bienvenido a RIT Solver!";
            lblCentroControl_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCentroDeControl_Nodos
            // 
            tableLayoutPanelCentroDeControl_Nodos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelCentroDeControl_Nodos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanelCentroDeControl_Nodos.ColumnCount = 1;
            tableLayoutPanelCentroDeControl_Nodos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelCentroDeControl_Nodos.Controls.Add(treeViewCentroDeControl, 0, 1);
            tableLayoutPanelCentroDeControl_Nodos.Controls.Add(panel3, 0, 2);
            tableLayoutPanelCentroDeControl_Nodos.Controls.Add(panel1, 0, 0);
            tableLayoutPanelCentroDeControl_Nodos.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanelCentroDeControl_Nodos.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelCentroDeControl_Nodos.Name = "tableLayoutPanelCentroDeControl_Nodos";
            tableLayoutPanelCentroDeControl_Nodos.RowCount = 3;
            tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.59375F));
            tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.40625F));
            tableLayoutPanelCentroDeControl_Nodos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            tableLayoutPanelCentroDeControl_Nodos.Size = new System.Drawing.Size(194, 496);
            tableLayoutPanelCentroDeControl_Nodos.TabIndex = 1;
            // 
            // treeViewCentroDeControl
            // 
            treeViewCentroDeControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeViewCentroDeControl.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            treeViewCentroDeControl.ImageIndex = 0;
            treeViewCentroDeControl.ImageList = imageList_Actividades;
            treeViewCentroDeControl.ItemHeight = 32;
            treeViewCentroDeControl.Location = new System.Drawing.Point(7, 41);
            treeViewCentroDeControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            treeViewCentroDeControl.Name = "treeViewCentroDeControl";
            treeNode3.Name = "nodeActividades";
            treeNode3.Text = "Actividades";
            treeNode3.ToolTipText = "Gestion de actividades programadas";
            treeNode4.Name = "nodePendientesPorHacer";
            treeNode4.Text = "Pendientes por hacer";
            treeNode4.ToolTipText = "Seccion de Pendientes por Realizar";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "nodeEstadisticasMensualesAnteriores";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Historico de Estadisticas Mensuales";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "nodeSeguimientoDeGuias";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "Seguimiento de Guias";
            treeNode6.ToolTipText = "Da seguimiento a guias trackeaas en el sistema para saber con mayor efectividad y facilidad su ubicacion actual";
            treeNode7.Name = "nodeSolicitudesDeViaticos";
            treeNode7.Text = "Solicitudes de Viaticos";
            treeViewCentroDeControl.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 });
            treeViewCentroDeControl.SelectedImageIndex = 0;
            treeViewCentroDeControl.Size = new System.Drawing.Size(180, 299);
            treeViewCentroDeControl.TabIndex = 0;
            treeViewCentroDeControl.AfterSelect += treeViewCentroDeControl_AfterSelect;
            treeViewCentroDeControl.NodeMouseDoubleClick += treeViewCentroDeControl_NodeMouseDoubleClick;
            // 
            // imageList_Actividades
            // 
            imageList_Actividades.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList_Actividades.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList_Actividades.ImageStream");
            imageList_Actividades.TransparentColor = System.Drawing.Color.Transparent;
            imageList_Actividades.Images.SetKeyName(0, "open-folder.png");
            imageList_Actividades.Images.SetKeyName(1, "checklist-64.png");
            imageList_Actividades.Images.SetKeyName(2, "estadisticas-64.png");
            imageList_Actividades.Images.SetKeyName(3, "estadisticas-anteriores.png");
            imageList_Actividades.Images.SetKeyName(4, "pack-list-track.png");
            imageList_Actividades.Images.SetKeyName(5, "to-do-32.png");
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Gray;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(lblDescripcionDeNodo);
            panel3.Controls.Add(lblNombreNodoSeleccionado);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(3, 349);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel3.Size = new System.Drawing.Size(188, 144);
            panel3.TabIndex = 2;
            // 
            // lblDescripcionDeNodo
            // 
            lblDescripcionDeNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            lblDescripcionDeNodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblDescripcionDeNodo.Location = new System.Drawing.Point(4, 53);
            lblDescripcionDeNodo.Name = "lblDescripcionDeNodo";
            lblDescripcionDeNodo.Size = new System.Drawing.Size(178, 88);
            lblDescripcionDeNodo.TabIndex = 2;
            lblDescripcionDeNodo.Text = "Ejemplo de texto de descrpcion de un nodo de la actividad seleccionada.";
            // 
            // lblNombreNodoSeleccionado
            // 
            lblNombreNodoSeleccionado.AutoSize = true;
            lblNombreNodoSeleccionado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold);
            lblNombreNodoSeleccionado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblNombreNodoSeleccionado.ImagePadding = 5;
            lblNombreNodoSeleccionado.LeftImage = null;
            lblNombreNodoSeleccionado.Location = new System.Drawing.Point(4, 6);
            lblNombreNodoSeleccionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblNombreNodoSeleccionado.Name = "lblNombreNodoSeleccionado";
            lblNombreNodoSeleccionado.Size = new System.Drawing.Size(378, 17);
            lblNombreNodoSeleccionado.TabIndex = 1;
            lblNombreNodoSeleccionado.Text = "Ejemplo de titulo de un nodo para  secciones del programa ";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gray;
            panel1.Controls.Add(lblNombreSeccion);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(188, 29);
            panel1.TabIndex = 0;
            // 
            // lblNombreSeccion
            // 
            lblNombreSeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNombreSeccion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblNombreSeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblNombreSeccion.Location = new System.Drawing.Point(0, 0);
            lblNombreSeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lblNombreSeccion.Name = "lblNombreSeccion";
            lblNombreSeccion.Size = new System.Drawing.Size(188, 29);
            lblNombreSeccion.TabIndex = 0;
            lblNombreSeccion.Text = "Ejemplo de seccion de";
            lblNombreSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolCrearActividad, toolAbrirActividad, toolEliminarActividad, toolCerrarActividad, toolStripSeparator2, toolImportarActividad, toolExportarActividad, toolStripLabel2, toolNuevoPendientePorHacer, toolImportarListaDePendientes, toolEliminarListaDePendientesPorHacer, toolCerrarListaDePendientes, toolStripSeparator9, toolNuevaSeccion, toolStripLabel1, toolStrpBtnMinimizarTodasLasVentanas, toolStripLabel5, toolStripLabel6, toolLblActualMDIActividadName });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1162, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolCrearActividad
            // 
            toolCrearActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolCrearActividad.Image = Properties.Resources.lista_de_verificacion1;
            toolCrearActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolCrearActividad.Name = "toolCrearActividad";
            toolCrearActividad.Size = new System.Drawing.Size(24, 24);
            toolCrearActividad.Text = "Nueva actividad";
            toolCrearActividad.Click += toolCrearActividad_Click;
            // 
            // toolAbrirActividad
            // 
            toolAbrirActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolAbrirActividad.Image = Properties.Resources.activity_open;
            toolAbrirActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolAbrirActividad.Name = "toolAbrirActividad";
            toolAbrirActividad.Size = new System.Drawing.Size(24, 24);
            toolAbrirActividad.Text = "Abrir actividad";
            toolAbrirActividad.Click += toolAbrirActividad_Click;
            // 
            // toolEliminarActividad
            // 
            toolEliminarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolEliminarActividad.Image = Properties.Resources.activity_delete;
            toolEliminarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolEliminarActividad.Name = "toolEliminarActividad";
            toolEliminarActividad.Size = new System.Drawing.Size(24, 24);
            toolEliminarActividad.Text = "Eliminar actividad";
            toolEliminarActividad.Click += toolEliminarActividad_Click;
            // 
            // toolCerrarActividad
            // 
            toolCerrarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolCerrarActividad.Image = Properties.Resources.close1_32;
            toolCerrarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolCerrarActividad.Name = "toolCerrarActividad";
            toolCerrarActividad.Size = new System.Drawing.Size(24, 24);
            toolCerrarActividad.Text = "Cerrar actividad actual";
            toolCerrarActividad.Click += toolCerrarActividad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolImportarActividad
            // 
            toolImportarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolImportarActividad.Enabled = false;
            toolImportarActividad.Image = Properties.Resources.importar_16;
            toolImportarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolImportarActividad.Name = "toolImportarActividad";
            toolImportarActividad.Size = new System.Drawing.Size(24, 24);
            toolImportarActividad.Text = "Importar actividad";
            toolImportarActividad.Click += toolImportarActividad_Click;
            // 
            // toolExportarActividad
            // 
            toolExportarActividad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolExportarActividad.Image = Properties.Resources.exportar_16;
            toolExportarActividad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolExportarActividad.Name = "toolExportarActividad";
            toolExportarActividad.Size = new System.Drawing.Size(24, 24);
            toolExportarActividad.Text = "Exportar actividad";
            toolExportarActividad.Click += toolExportarActividad_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(28, 24);
            toolStripLabel2.Text = "       ";
            // 
            // toolNuevoPendientePorHacer
            // 
            toolNuevoPendientePorHacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolNuevoPendientePorHacer.Image = Properties.Resources.to_do_32;
            toolNuevoPendientePorHacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolNuevoPendientePorHacer.Name = "toolNuevoPendientePorHacer";
            toolNuevoPendientePorHacer.Size = new System.Drawing.Size(24, 24);
            toolNuevoPendientePorHacer.Text = "Nuevo pendiente por hacer";
            toolNuevoPendientePorHacer.ToolTipText = "Nuevo pendiente por hacer";
            toolNuevoPendientePorHacer.Click += toolNuevoPendientePorHacer_Click;
            // 
            // toolImportarListaDePendientes
            // 
            toolImportarListaDePendientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolImportarListaDePendientes.Image = Properties.Resources.to_do_open;
            toolImportarListaDePendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolImportarListaDePendientes.Name = "toolImportarListaDePendientes";
            toolImportarListaDePendientes.Size = new System.Drawing.Size(24, 24);
            toolImportarListaDePendientes.Text = "Importar una lista de pendientes...";
            toolImportarListaDePendientes.Click += toolImportarListaDePendientes_Click;
            // 
            // toolEliminarListaDePendientesPorHacer
            // 
            toolEliminarListaDePendientesPorHacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolEliminarListaDePendientesPorHacer.Image = Properties.Resources.to_do_delete;
            toolEliminarListaDePendientesPorHacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolEliminarListaDePendientesPorHacer.Name = "toolEliminarListaDePendientesPorHacer";
            toolEliminarListaDePendientesPorHacer.Size = new System.Drawing.Size(24, 24);
            toolEliminarListaDePendientesPorHacer.Text = "Eliminar lista de pendientes";
            toolEliminarListaDePendientesPorHacer.Click += toolEliminarListaDePendientesPorHacer_Click;
            // 
            // toolCerrarListaDePendientes
            // 
            toolCerrarListaDePendientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolCerrarListaDePendientes.Image = Properties.Resources.close1_32;
            toolCerrarListaDePendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolCerrarListaDePendientes.Name = "toolCerrarListaDePendientes";
            toolCerrarListaDePendientes.Size = new System.Drawing.Size(24, 24);
            toolCerrarListaDePendientes.Text = "Cerrar lista de pendientes";
            toolCerrarListaDePendientes.Click += toolCerrarListaDePendientes_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolNuevaSeccion
            // 
            toolNuevaSeccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolNuevaSeccion.Enabled = false;
            toolNuevaSeccion.Image = Properties.Resources.new_section_32;
            toolNuevaSeccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolNuevaSeccion.Name = "toolNuevaSeccion";
            toolNuevaSeccion.Size = new System.Drawing.Size(24, 24);
            toolNuevaSeccion.Text = "Nueva seccion";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(28, 24);
            toolStripLabel1.Text = "       ";
            // 
            // toolStrpBtnMinimizarTodasLasVentanas
            // 
            toolStrpBtnMinimizarTodasLasVentanas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStrpBtnMinimizarTodasLasVentanas.Image = Properties.Resources.minimize_all_windows;
            toolStrpBtnMinimizarTodasLasVentanas.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStrpBtnMinimizarTodasLasVentanas.Name = "toolStrpBtnMinimizarTodasLasVentanas";
            toolStrpBtnMinimizarTodasLasVentanas.Size = new System.Drawing.Size(24, 24);
            toolStrpBtnMinimizarTodasLasVentanas.Text = "Minimizar todas las ventanas";
            toolStrpBtnMinimizarTodasLasVentanas.Click += toolStrpBtnMinimizarTodasLasVentanas_Click;
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new System.Drawing.Size(28, 24);
            toolStripLabel5.Text = "       ";
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new System.Drawing.Size(69, 24);
            toolStripLabel6.Text = "Actual MDI:";
            // 
            // toolLblActualMDIActividadName
            // 
            toolLblActualMDIActividadName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            toolLblActualMDIActividadName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            toolLblActualMDIActividadName.Name = "toolLblActualMDIActividadName";
            toolLblActualMDIActividadName.Size = new System.Drawing.Size(12, 24);
            toolLblActualMDIActividadName.Text = "-";
            // 
            // webBrowser4
            // 
            webBrowser4.Location = new System.Drawing.Point(0, 0);
            webBrowser4.Name = "webBrowser4";
            webBrowser4.Size = new System.Drawing.Size(250, 250);
            webBrowser4.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(200, 100);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1178, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1178, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuOpcionesActividades
            // 
            menuOpcionesActividades.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuOpcionesActividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { crearActividadToolStripMenuItem, abrirActividadToolStripMenuItem, toolStripSeparator10, maximizaToolStripMenuItem, minimizarToolStripMenuItem, eliminarToolStripMenuItem, toolStripSeparator12, enviarAvanceToolStripMenuItem, importarToolStripMenuItem, borrarPermanentementeToolStripMenuItem, toolStripSeparator11, cerrarToolStripMenuItem });
            menuOpcionesActividades.Name = "menuOpcionesActividades";
            menuOpcionesActividades.Size = new System.Drawing.Size(208, 220);
            // 
            // crearActividadToolStripMenuItem
            // 
            crearActividadToolStripMenuItem.Name = "crearActividadToolStripMenuItem";
            crearActividadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            crearActividadToolStripMenuItem.Text = "Crear nueva actividad";
            // 
            // abrirActividadToolStripMenuItem
            // 
            abrirActividadToolStripMenuItem.Name = "abrirActividadToolStripMenuItem";
            abrirActividadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            abrirActividadToolStripMenuItem.Text = "Abrir actividad existente";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new System.Drawing.Size(204, 6);
            // 
            // maximizaToolStripMenuItem
            // 
            maximizaToolStripMenuItem.Name = "maximizaToolStripMenuItem";
            maximizaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            maximizaToolStripMenuItem.Text = "Maximizar";
            // 
            // minimizarToolStripMenuItem
            // 
            minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            minimizarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            minimizarToolStripMenuItem.Text = "Minimizar";
            minimizarToolStripMenuItem.Click += minimizarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            eliminarToolStripMenuItem.Text = "Eliminar de la vista";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new System.Drawing.Size(204, 6);
            // 
            // enviarAvanceToolStripMenuItem
            // 
            enviarAvanceToolStripMenuItem.Name = "enviarAvanceToolStripMenuItem";
            enviarAvanceToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            enviarAvanceToolStripMenuItem.Text = "Enviar avance";
            // 
            // importarToolStripMenuItem
            // 
            importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            importarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            importarToolStripMenuItem.Text = "Exportar actividad";
            // 
            // borrarPermanentementeToolStripMenuItem
            // 
            borrarPermanentementeToolStripMenuItem.Name = "borrarPermanentementeToolStripMenuItem";
            borrarPermanentementeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            borrarPermanentementeToolStripMenuItem.Text = "Borrar permanentemente";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(204, 6);
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // menuOpcionesAnuncios
            // 
            menuOpcionesAnuncios.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuOpcionesAnuncios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { crearAnuncioStripMenuItem, abrirAnuncioStripMenuItem, toolStripSeparator13, maximizarStripMenuItem, minizarStripMenuItem, eliminarDeLaVistaStripMenuItem, toolStripSeparator14, borrarPermanentementeStripMenuItem, toolStripSeparator15, cerrarStripMenuItem });
            menuOpcionesAnuncios.Name = "menuOpcionesActividades";
            menuOpcionesAnuncios.Size = new System.Drawing.Size(208, 176);
            // 
            // crearAnuncioStripMenuItem
            // 
            crearAnuncioStripMenuItem.Name = "crearAnuncioStripMenuItem";
            crearAnuncioStripMenuItem.Size = new System.Drawing.Size(207, 22);
            crearAnuncioStripMenuItem.Text = "Crear nuevo anuncio";
            // 
            // abrirAnuncioStripMenuItem
            // 
            abrirAnuncioStripMenuItem.Name = "abrirAnuncioStripMenuItem";
            abrirAnuncioStripMenuItem.Size = new System.Drawing.Size(207, 22);
            abrirAnuncioStripMenuItem.Text = "Abrir anuncio existente";
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new System.Drawing.Size(204, 6);
            // 
            // maximizarStripMenuItem
            // 
            maximizarStripMenuItem.Name = "maximizarStripMenuItem";
            maximizarStripMenuItem.Size = new System.Drawing.Size(207, 22);
            maximizarStripMenuItem.Text = "Maximizar";
            // 
            // minizarStripMenuItem
            // 
            minizarStripMenuItem.Name = "minizarStripMenuItem";
            minizarStripMenuItem.Size = new System.Drawing.Size(207, 22);
            minizarStripMenuItem.Text = "Minimizar";
            // 
            // eliminarDeLaVistaStripMenuItem
            // 
            eliminarDeLaVistaStripMenuItem.Name = "eliminarDeLaVistaStripMenuItem";
            eliminarDeLaVistaStripMenuItem.Size = new System.Drawing.Size(207, 22);
            eliminarDeLaVistaStripMenuItem.Text = "Eliminar de la vista";
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new System.Drawing.Size(204, 6);
            // 
            // borrarPermanentementeStripMenuItem
            // 
            borrarPermanentementeStripMenuItem.Name = "borrarPermanentementeStripMenuItem";
            borrarPermanentementeStripMenuItem.Size = new System.Drawing.Size(207, 22);
            borrarPermanentementeStripMenuItem.Text = "Borrar permanentemente";
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new System.Drawing.Size(204, 6);
            // 
            // cerrarStripMenuItem
            // 
            cerrarStripMenuItem.Name = "cerrarStripMenuItem";
            cerrarStripMenuItem.Size = new System.Drawing.Size(207, 22);
            cerrarStripMenuItem.Text = "Cerrar";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            linkLabel1.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new System.Drawing.Point(529, 1);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(73, 41);
            linkLabel1.TabIndex = 53;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "RIT Solver Info";
            linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // tableLayoutPanelBarraMultifuncion_BotonesIzquierda
            // 
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnCount = 2;
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Controls.Add(btnFuncion2, 0, 0);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Controls.Add(btnFuncion1, 0, 0);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Location = new System.Drawing.Point(196, 1);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Name = "tableLayoutPanelBarraMultifuncion_BotonesIzquierda";
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.RowCount = 1;
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.Size = new System.Drawing.Size(329, 41);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.TabIndex = 11;
            // 
            // btnFuncion2
            // 
            btnFuncion2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnFuncion2.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFuncion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFuncion2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFuncion2.Location = new System.Drawing.Point(167, 2);
            btnFuncion2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFuncion2.Name = "btnFuncion2";
            btnFuncion2.Size = new System.Drawing.Size(159, 37);
            btnFuncion2.TabIndex = 52;
            btnFuncion2.Text = "Limpiar campos";
            btnFuncion2.UseVisualStyleBackColor = false;
            btnFuncion2.Click += btnLimpiarCampos_Click;
            // 
            // btnFuncion1
            // 
            btnFuncion1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnFuncion1.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFuncion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFuncion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFuncion1.Location = new System.Drawing.Point(3, 2);
            btnFuncion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFuncion1.Name = "btnFuncion1";
            btnFuncion1.Size = new System.Drawing.Size(158, 37);
            btnFuncion1.TabIndex = 51;
            btnFuncion1.Text = "Cargar datos de SAS";
            btnFuncion1.UseVisualStyleBackColor = false;
            btnFuncion1.Click += btnCargarDatosDeSAS_Click;
            // 
            // lblContactoFallos
            // 
            lblContactoFallos.AutoSize = true;
            lblContactoFallos.Dock = System.Windows.Forms.DockStyle.Fill;
            lblContactoFallos.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblContactoFallos.Location = new System.Drawing.Point(609, 1);
            lblContactoFallos.Name = "lblContactoFallos";
            lblContactoFallos.Size = new System.Drawing.Size(225, 41);
            lblContactoFallos.TabIndex = 54;
            lblContactoFallos.TabStop = true;
            lblContactoFallos.Text = "¿Presentas fallos con el programa? ¡Reportalos aqui!";
            lblContactoFallos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblContactoFallos.VisitedLinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblContactoFallos.LinkClicked += lblContactoFallos_LinkClicked;
            // 
            // btnFuncion3
            // 
            btnFuncion3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnFuncion3.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFuncion3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFuncion3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFuncion3.Location = new System.Drawing.Point(0, 0);
            btnFuncion3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnFuncion3.Name = "btnFuncion3";
            btnFuncion3.Size = new System.Drawing.Size(132, 37);
            btnFuncion3.TabIndex = 55;
            btnFuncion3.Text = "Guardar RIT";
            btnFuncion3.UseVisualStyleBackColor = false;
            btnFuncion3.Click += btnGuardarDatos_Click_1;
            // 
            // tableLayoutPanelBarraMultifuncion
            // 
            tableLayoutPanelBarraMultifuncion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelBarraMultifuncion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            tableLayoutPanelBarraMultifuncion.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelBarraMultifuncion.ColumnCount = 6;
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73244F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.25573F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.866615F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.8895F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.91792F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33781F));
            tableLayoutPanelBarraMultifuncion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            tableLayoutPanelBarraMultifuncion.Controls.Add(lblContactoFallos, 3, 0);
            tableLayoutPanelBarraMultifuncion.Controls.Add(tableLayoutPanelBarraMultifuncion_BotonesIzquierda, 1, 0);
            tableLayoutPanelBarraMultifuncion.Controls.Add(linkLabel1, 2, 0);
            tableLayoutPanelBarraMultifuncion.Controls.Add(panel7, 4, 0);
            tableLayoutPanelBarraMultifuncion.Location = new System.Drawing.Point(0, 605);
            tableLayoutPanelBarraMultifuncion.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelBarraMultifuncion.Name = "tableLayoutPanelBarraMultifuncion";
            tableLayoutPanelBarraMultifuncion.RowCount = 1;
            tableLayoutPanelBarraMultifuncion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelBarraMultifuncion.Size = new System.Drawing.Size(1172, 43);
            tableLayoutPanelBarraMultifuncion.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnFuncion3);
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            panel7.Location = new System.Drawing.Point(841, 3);
            panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(132, 37);
            panel7.TabIndex = 56;
            // 
            // menuOpcionesDeProyectos
            // 
            menuOpcionesDeProyectos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            menuOpcionesDeProyectos.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuOpcionesDeProyectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { archivoToolStripMenuItem, herramientasToolStripMenuItem, webToolStripMenuItem, solicitudesToolStripMenuItem, utilidadesToolStripMenuItem });
            menuOpcionesDeProyectos.Location = new System.Drawing.Point(0, 0);
            menuOpcionesDeProyectos.Name = "menuOpcionesDeProyectos";
            menuOpcionesDeProyectos.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuOpcionesDeProyectos.Size = new System.Drawing.Size(1172, 28);
            menuOpcionesDeProyectos.TabIndex = 1;
            menuOpcionesDeProyectos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { nuevoProyectoToolStripMenuItem, abrirTicketToolStripMenuItem, archivosRecientesToolStripMenuItem, toolStripSeparator3, nuevaActividadToolStripMenuItem, importarActividadToolStripMenuItem, exportarActividadesToolStripMenuItem, nuevoAnuncioToolStripMenuItem, toolStripSeparator5, salirToolStripMenuItem });
            archivoToolStripMenuItem.Image = Properties.Resources.buscar_archivo1;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            nuevoProyectoToolStripMenuItem.Image = Properties.Resources.project;
            nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            nuevoProyectoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            nuevoProyectoToolStripMenuItem.Text = "Nuevo proyecto de ticket";
            nuevoProyectoToolStripMenuItem.Click += nuevoProyectoToolStripMenuItem_Click;
            // 
            // abrirTicketToolStripMenuItem
            // 
            abrirTicketToolStripMenuItem.Image = Properties.Resources.project_open;
            abrirTicketToolStripMenuItem.Name = "abrirTicketToolStripMenuItem";
            abrirTicketToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A;
            abrirTicketToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            abrirTicketToolStripMenuItem.Text = "Abrir proyecto de ticket";
            abrirTicketToolStripMenuItem.Click += abrirTicketToolStripMenuItem_Click;
            // 
            // archivosRecientesToolStripMenuItem
            // 
            archivosRecientesToolStripMenuItem.Name = "archivosRecientesToolStripMenuItem";
            archivosRecientesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            archivosRecientesToolStripMenuItem.Text = "Archivos recientes";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(247, 6);
            // 
            // nuevaActividadToolStripMenuItem
            // 
            nuevaActividadToolStripMenuItem.Image = Properties.Resources.lista_de_verificacion1;
            nuevaActividadToolStripMenuItem.Name = "nuevaActividadToolStripMenuItem";
            nuevaActividadToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            nuevaActividadToolStripMenuItem.Text = "Nueva actividad";
            nuevaActividadToolStripMenuItem.Click += nuevaActividadToolStripMenuItem_Click;
            // 
            // importarActividadToolStripMenuItem
            // 
            importarActividadToolStripMenuItem.Image = Properties.Resources.activity_open;
            importarActividadToolStripMenuItem.Name = "importarActividadToolStripMenuItem";
            importarActividadToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            importarActividadToolStripMenuItem.Text = "Abrir actividad";
            importarActividadToolStripMenuItem.Click += importarActividadToolStripMenuItem_Click;
            // 
            // exportarActividadesToolStripMenuItem
            // 
            exportarActividadesToolStripMenuItem.Enabled = false;
            exportarActividadesToolStripMenuItem.Name = "exportarActividadesToolStripMenuItem";
            exportarActividadesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            exportarActividadesToolStripMenuItem.Text = "Exportar actividades";
            // 
            // nuevoAnuncioToolStripMenuItem
            // 
            nuevoAnuncioToolStripMenuItem.Enabled = false;
            nuevoAnuncioToolStripMenuItem.Name = "nuevoAnuncioToolStripMenuItem";
            nuevoAnuncioToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            nuevoAnuncioToolStripMenuItem.Text = "Nuevo anuncio";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(247, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = Properties.Resources.cerrar;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            salirToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { configuracionToolStripMenuItem, toolStripSeparator1, buscarActualizacionesToolStripMenuItem, buscarActualizacionesBETAToolStripMenuItem, toolStripSeparator4, sistemaDeInventariosToolStripMenuItem, seleccionarUsuarioToolStripMenuItem, listadoDeHistorialesToolStripMenuItem, seguimientoDeGuiaToolStripMenuItem, toolStripSeparator7, imprimirRITEnBlancoToolStripMenuItem, toolStripSeparator6, herramientaDeReparacionAvanzadaToolStripMenuItem, reportarFallaToolStripMenuItem });
            herramientasToolStripMenuItem.Image = Properties.Resources.technical_support;
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.Image = Properties.Resources.configuraciones;
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            configuracionToolStripMenuItem.Text = "Configuracion";
            configuracionToolStripMenuItem.Click += configuracionToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // buscarActualizacionesToolStripMenuItem
            // 
            buscarActualizacionesToolStripMenuItem.Image = Properties.Resources.mantenimiento_web;
            buscarActualizacionesToolStripMenuItem.Name = "buscarActualizacionesToolStripMenuItem";
            buscarActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            buscarActualizacionesToolStripMenuItem.Text = "Buscar actualizaciones";
            buscarActualizacionesToolStripMenuItem.Click += buscarActualizacionesToolStripMenuItem_Click;
            // 
            // buscarActualizacionesBETAToolStripMenuItem
            // 
            buscarActualizacionesBETAToolStripMenuItem.Image = Properties.Resources.mantenimiento_web__1_;
            buscarActualizacionesBETAToolStripMenuItem.Name = "buscarActualizacionesBETAToolStripMenuItem";
            buscarActualizacionesBETAToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            buscarActualizacionesBETAToolStripMenuItem.Text = "Buscar actualizaciones BETA";
            buscarActualizacionesBETAToolStripMenuItem.Click += buscarActualizacionesBETAToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(264, 6);
            // 
            // sistemaDeInventariosToolStripMenuItem
            // 
            sistemaDeInventariosToolStripMenuItem.Image = Properties.Resources.inventory;
            sistemaDeInventariosToolStripMenuItem.Name = "sistemaDeInventariosToolStripMenuItem";
            sistemaDeInventariosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I;
            sistemaDeInventariosToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            sistemaDeInventariosToolStripMenuItem.Text = "Sistema de Inventarios";
            sistemaDeInventariosToolStripMenuItem.Click += sistemaDeInventariosToolStripMenuItem_Click;
            // 
            // seleccionarUsuarioToolStripMenuItem
            // 
            seleccionarUsuarioToolStripMenuItem.Image = Properties.Resources.businessman;
            seleccionarUsuarioToolStripMenuItem.Name = "seleccionarUsuarioToolStripMenuItem";
            seleccionarUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U;
            seleccionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            seleccionarUsuarioToolStripMenuItem.Text = "Listado de Usuarios";
            seleccionarUsuarioToolStripMenuItem.Click += seleccionarUsuarioToolStripMenuItem_Click;
            // 
            // listadoDeHistorialesToolStripMenuItem
            // 
            listadoDeHistorialesToolStripMenuItem.Image = Properties.Resources.computer_historial;
            listadoDeHistorialesToolStripMenuItem.Name = "listadoDeHistorialesToolStripMenuItem";
            listadoDeHistorialesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H;
            listadoDeHistorialesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            listadoDeHistorialesToolStripMenuItem.Text = "Listado de Historiales";
            listadoDeHistorialesToolStripMenuItem.Click += listadoDeHistorialesToolStripMenuItem_Click;
            // 
            // seguimientoDeGuiaToolStripMenuItem
            // 
            seguimientoDeGuiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dHLToolStripMenuItem, paqueteToolStripMenuItem, fedexToolStripMenuItem });
            seguimientoDeGuiaToolStripMenuItem.Image = Properties.Resources.tour;
            seguimientoDeGuiaToolStripMenuItem.Name = "seguimientoDeGuiaToolStripMenuItem";
            seguimientoDeGuiaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            seguimientoDeGuiaToolStripMenuItem.Text = "Seguimiento de Guia Rapida";
            // 
            // dHLToolStripMenuItem
            // 
            dHLToolStripMenuItem.Name = "dHLToolStripMenuItem";
            dHLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            dHLToolStripMenuItem.Text = "DHL";
            dHLToolStripMenuItem.Click += dHLToolStripMenuItem_Click;
            // 
            // paqueteToolStripMenuItem
            // 
            paqueteToolStripMenuItem.Name = "paqueteToolStripMenuItem";
            paqueteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            paqueteToolStripMenuItem.Text = "Paquetexpress";
            paqueteToolStripMenuItem.Click += paqueteToolStripMenuItem_Click;
            // 
            // fedexToolStripMenuItem
            // 
            fedexToolStripMenuItem.Name = "fedexToolStripMenuItem";
            fedexToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            fedexToolStripMenuItem.Text = "Fedex";
            fedexToolStripMenuItem.Click += fedexToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(264, 6);
            // 
            // imprimirRITEnBlancoToolStripMenuItem
            // 
            imprimirRITEnBlancoToolStripMenuItem.Image = Properties.Resources.paper;
            imprimirRITEnBlancoToolStripMenuItem.Name = "imprimirRITEnBlancoToolStripMenuItem";
            imprimirRITEnBlancoToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            imprimirRITEnBlancoToolStripMenuItem.Text = "Imprimir RIT en blanco";
            imprimirRITEnBlancoToolStripMenuItem.Click += imprimirRITEnBlancoToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(264, 6);
            // 
            // herramientaDeReparacionAvanzadaToolStripMenuItem
            // 
            herramientaDeReparacionAvanzadaToolStripMenuItem.Enabled = false;
            herramientaDeReparacionAvanzadaToolStripMenuItem.Name = "herramientaDeReparacionAvanzadaToolStripMenuItem";
            herramientaDeReparacionAvanzadaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            herramientaDeReparacionAvanzadaToolStripMenuItem.Text = "Herramienta de reparacion avanzada";
            // 
            // reportarFallaToolStripMenuItem
            // 
            reportarFallaToolStripMenuItem.Image = Properties.Resources.bug_report;
            reportarFallaToolStripMenuItem.Name = "reportarFallaToolStripMenuItem";
            reportarFallaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            reportarFallaToolStripMenuItem.Text = "Reportar falla";
            reportarFallaToolStripMenuItem.Click += reportarFallaToolStripMenuItem_Click;
            // 
            // webToolStripMenuItem
            // 
            webToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { recargarSASToolStripMenuItem, recargarFormsToolStripMenuItem, recargarManageDeskCompusofToolStripMenuItem, recargarEndpointCentralToolStripMenuItem, toolStripSeparator17, funcionesWebMacroToolStripMenuItem });
            webToolStripMenuItem.Image = Properties.Resources.red_mundial;
            webToolStripMenuItem.Name = "webToolStripMenuItem";
            webToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            webToolStripMenuItem.Text = "Webs";
            // 
            // recargarSASToolStripMenuItem
            // 
            recargarSASToolStripMenuItem.Image = Properties.Resources.refresh;
            recargarSASToolStripMenuItem.Name = "recargarSASToolStripMenuItem";
            recargarSASToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D1;
            recargarSASToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            recargarSASToolStripMenuItem.Text = "Recargar SAS";
            recargarSASToolStripMenuItem.Click += recargarSASToolStripMenuItem_Click;
            // 
            // recargarFormsToolStripMenuItem
            // 
            recargarFormsToolStripMenuItem.Image = Properties.Resources.refresh;
            recargarFormsToolStripMenuItem.Name = "recargarFormsToolStripMenuItem";
            recargarFormsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D2;
            recargarFormsToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            recargarFormsToolStripMenuItem.Text = "Recargar Forms";
            recargarFormsToolStripMenuItem.Click += recargarFormsToolStripMenuItem_Click;
            // 
            // recargarManageDeskCompusofToolStripMenuItem
            // 
            recargarManageDeskCompusofToolStripMenuItem.Image = Properties.Resources.refresh;
            recargarManageDeskCompusofToolStripMenuItem.Name = "recargarManageDeskCompusofToolStripMenuItem";
            recargarManageDeskCompusofToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D3;
            recargarManageDeskCompusofToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            recargarManageDeskCompusofToolStripMenuItem.Text = "Recargar Manage Desk Compusof";
            recargarManageDeskCompusofToolStripMenuItem.Click += recargarManageDeskCompusofToolStripMenuItem_Click;
            // 
            // recargarEndpointCentralToolStripMenuItem
            // 
            recargarEndpointCentralToolStripMenuItem.Image = Properties.Resources.refresh;
            recargarEndpointCentralToolStripMenuItem.Name = "recargarEndpointCentralToolStripMenuItem";
            recargarEndpointCentralToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.D4;
            recargarEndpointCentralToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            recargarEndpointCentralToolStripMenuItem.Text = "Recargar Endpoint Central";
            recargarEndpointCentralToolStripMenuItem.Click += recargarEndpointCentralToolStripMenuItem_Click;
            // 
            // toolStripSeparator17
            // 
            toolStripSeparator17.Name = "toolStripSeparator17";
            toolStripSeparator17.Size = new System.Drawing.Size(360, 6);
            // 
            // funcionesWebMacroToolStripMenuItem
            // 
            funcionesWebMacroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ejecutarMacroFuncionWeb1ToolStripMenuItem, ejecutarMacroFuncionWeb2ToolStripMenuItem, ejecutarMacroFuncionWeb3ToolStripMenuItem });
            funcionesWebMacroToolStripMenuItem.Name = "funcionesWebMacroToolStripMenuItem";
            funcionesWebMacroToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            funcionesWebMacroToolStripMenuItem.Text = "Macro Funciones Web";
            // 
            // ejecutarMacroFuncionWeb1ToolStripMenuItem
            // 
            ejecutarMacroFuncionWeb1ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb1ToolStripMenuItem";
            ejecutarMacroFuncionWeb1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1;
            ejecutarMacroFuncionWeb1ToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            ejecutarMacroFuncionWeb1ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 1";
            ejecutarMacroFuncionWeb1ToolStripMenuItem.Click += ejecutarMacroFuncionWeb1ToolStripMenuItem_Click;
            // 
            // ejecutarMacroFuncionWeb2ToolStripMenuItem
            // 
            ejecutarMacroFuncionWeb2ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb2ToolStripMenuItem";
            ejecutarMacroFuncionWeb2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2;
            ejecutarMacroFuncionWeb2ToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            ejecutarMacroFuncionWeb2ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 2";
            ejecutarMacroFuncionWeb2ToolStripMenuItem.Click += ejecutarMacroFuncionWeb2ToolStripMenuItem_Click;
            // 
            // ejecutarMacroFuncionWeb3ToolStripMenuItem
            // 
            ejecutarMacroFuncionWeb3ToolStripMenuItem.Name = "ejecutarMacroFuncionWeb3ToolStripMenuItem";
            ejecutarMacroFuncionWeb3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3;
            ejecutarMacroFuncionWeb3ToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            ejecutarMacroFuncionWeb3ToolStripMenuItem.Text = "Ejecutar Macro Funcion Web 3";
            ejecutarMacroFuncionWeb3ToolStripMenuItem.Click += ejecutarMacroFuncionWeb3ToolStripMenuItem_Click;
            // 
            // solicitudesToolStripMenuItem
            // 
            solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { solicitarRefaccionesToolStripMenuItem, solicitarTonerToolStripMenuItem });
            solicitudesToolStripMenuItem.Image = Properties.Resources.solicitud;
            solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            solicitudesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // solicitarRefaccionesToolStripMenuItem
            // 
            solicitarRefaccionesToolStripMenuItem.Image = Properties.Resources.spare_parts;
            solicitarRefaccionesToolStripMenuItem.Name = "solicitarRefaccionesToolStripMenuItem";
            solicitarRefaccionesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R;
            solicitarRefaccionesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            solicitarRefaccionesToolStripMenuItem.Text = "Solicitar refacciones";
            solicitarRefaccionesToolStripMenuItem.Click += solicitarRefaccionesToolStripMenuItem_Click;
            // 
            // solicitarTonerToolStripMenuItem
            // 
            solicitarTonerToolStripMenuItem.Image = Properties.Resources.toner;
            solicitarTonerToolStripMenuItem.Name = "solicitarTonerToolStripMenuItem";
            solicitarTonerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T;
            solicitarTonerToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            solicitarTonerToolStripMenuItem.Text = "Solicitar toner";
            solicitarTonerToolStripMenuItem.Click += solicitarTonerToolStripMenuItem_Click;
            // 
            // utilidadesToolStripMenuItem
            // 
            utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { escaladoDeReportesToolStripMenuItem, organigramaDeContactoCompusofToolStripMenuItem, manualDeUsuarioToolStripMenuItem, herramientasToolStripMenuItem1 });
            utilidadesToolStripMenuItem.Image = Properties.Resources.utilities;
            utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            utilidadesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // escaladoDeReportesToolStripMenuItem
            // 
            escaladoDeReportesToolStripMenuItem.Enabled = false;
            escaladoDeReportesToolStripMenuItem.Name = "escaladoDeReportesToolStripMenuItem";
            escaladoDeReportesToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            escaladoDeReportesToolStripMenuItem.Text = "Escalado de reportes";
            escaladoDeReportesToolStripMenuItem.Click += escaladoDeReportesToolStripMenuItem_Click;
            // 
            // organigramaDeContactoCompusofToolStripMenuItem
            // 
            organigramaDeContactoCompusofToolStripMenuItem.Image = Properties.Resources.contacts;
            organigramaDeContactoCompusofToolStripMenuItem.Name = "organigramaDeContactoCompusofToolStripMenuItem";
            organigramaDeContactoCompusofToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            organigramaDeContactoCompusofToolStripMenuItem.Text = "Organigrama de contacto Compusof";
            organigramaDeContactoCompusofToolStripMenuItem.Click += organigramaDeContactoCompusofToolStripMenuItem_Click;
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            manualDeUsuarioToolStripMenuItem.Image = Properties.Resources.user_guide;
            manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            manualDeUsuarioToolStripMenuItem.Click += manualDeUsuarioToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem1
            // 
            herramientasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pCIETToolStripMenuItem, omisorDeComprobacionesDeOracleToolStripMenuItem, instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem, crystalDiskInfoToolStripMenuItem });
            herramientasToolStripMenuItem1.Image = Properties.Resources.toolbox;
            herramientasToolStripMenuItem1.Name = "herramientasToolStripMenuItem1";
            herramientasToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            herramientasToolStripMenuItem1.Text = "Herramientas";
            // 
            // pCIETToolStripMenuItem
            // 
            pCIETToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ejecutarToolStripMenuItem, grabarEnCarpetaToolStripMenuItem });
            pCIETToolStripMenuItem.Image = Properties.Resources.settings;
            pCIETToolStripMenuItem.Name = "pCIETToolStripMenuItem";
            pCIETToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            pCIETToolStripMenuItem.Text = "PCIET";
            pCIETToolStripMenuItem.ToolTipText = "Extractor de informacion de un equipo para crear carta de resguardo en el programa.";
            // 
            // ejecutarToolStripMenuItem
            // 
            ejecutarToolStripMenuItem.Image = Properties.Resources.play;
            ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            ejecutarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            ejecutarToolStripMenuItem.Text = "Ejecutar";
            ejecutarToolStripMenuItem.Click += ejecutarToolStripMenuItem_Click;
            // 
            // grabarEnCarpetaToolStripMenuItem
            // 
            grabarEnCarpetaToolStripMenuItem.Image = Properties.Resources.folder_move;
            grabarEnCarpetaToolStripMenuItem.Name = "grabarEnCarpetaToolStripMenuItem";
            grabarEnCarpetaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            grabarEnCarpetaToolStripMenuItem.Text = "Grabar en carpeta ...";
            grabarEnCarpetaToolStripMenuItem.Click += grabarEnCarpetaToolStripMenuItem_Click;
            // 
            // omisorDeComprobacionesDeOracleToolStripMenuItem
            // 
            omisorDeComprobacionesDeOracleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ejecutarToolStripMenuItem1, grabarEnToolStripMenuItem });
            omisorDeComprobacionesDeOracleToolStripMenuItem.Image = Properties.Resources.oracle;
            omisorDeComprobacionesDeOracleToolStripMenuItem.Name = "omisorDeComprobacionesDeOracleToolStripMenuItem";
            omisorDeComprobacionesDeOracleToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            omisorDeComprobacionesDeOracleToolStripMenuItem.Text = "Omisor de Comprobaciones de Oracle";
            omisorDeComprobacionesDeOracleToolStripMenuItem.ToolTipText = "Herramienta omisora de comprobaciones de instalacion de Oracle. Solo hay que ejecuta el archivo como administrador en la misma carpeta que se encuentra el instalador de Oracle.";
            // 
            // ejecutarToolStripMenuItem1
            // 
            ejecutarToolStripMenuItem1.Image = Properties.Resources.play;
            ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
            ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            ejecutarToolStripMenuItem1.Text = "Ejecutar";
            ejecutarToolStripMenuItem1.Click += ejecutarToolStripMenuItem1_Click;
            // 
            // grabarEnToolStripMenuItem
            // 
            grabarEnToolStripMenuItem.Image = Properties.Resources.folder_move;
            grabarEnToolStripMenuItem.Name = "grabarEnToolStripMenuItem";
            grabarEnToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            grabarEnToolStripMenuItem.Text = "Grabar en carpeta ...";
            grabarEnToolStripMenuItem.Click += grabarEnToolStripMenuItem_Click;
            // 
            // instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem
            // 
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.AutoSize = false;
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ejecutarToolStripMenuItem2, grabarEnCarpetaToolStripMenuItem1 });
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Image = Properties.Resources.libros;
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Name = "instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem";
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.Text = "Instalador de Librerias y Registros de MIIT 7.0";
            instaladorDeLibreriasYRegistrosDeMIIT70ToolStripMenuItem.ToolTipText = "Instalador de librerias y registros para MiitCat 7. Solo hay que planchar el archivo en la raiz de MiitCat y ejecutar como admin.";
            // 
            // ejecutarToolStripMenuItem2
            // 
            ejecutarToolStripMenuItem2.Image = Properties.Resources.play;
            ejecutarToolStripMenuItem2.Name = "ejecutarToolStripMenuItem2";
            ejecutarToolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
            ejecutarToolStripMenuItem2.Text = "Ejecutar";
            ejecutarToolStripMenuItem2.Click += ejecutarToolStripMenuItem2_Click;
            // 
            // grabarEnCarpetaToolStripMenuItem1
            // 
            grabarEnCarpetaToolStripMenuItem1.Image = Properties.Resources.folder_move;
            grabarEnCarpetaToolStripMenuItem1.Name = "grabarEnCarpetaToolStripMenuItem1";
            grabarEnCarpetaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            grabarEnCarpetaToolStripMenuItem1.Text = "Grabar en carpeta ...";
            grabarEnCarpetaToolStripMenuItem1.Click += grabarEnCarpetaToolStripMenuItem1_Click;
            // 
            // crystalDiskInfoToolStripMenuItem
            // 
            crystalDiskInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ejecutarToolStripMenuItem3, gtrabrToolStripMenuItem });
            crystalDiskInfoToolStripMenuItem.Image = Properties.Resources.storage;
            crystalDiskInfoToolStripMenuItem.Name = "crystalDiskInfoToolStripMenuItem";
            crystalDiskInfoToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
            crystalDiskInfoToolStripMenuItem.Text = "CrystalDiskInfo 8";
            crystalDiskInfoToolStripMenuItem.ToolTipText = "Herramienta para diagnosticar unidades de almacenamiento.";
            // 
            // ejecutarToolStripMenuItem3
            // 
            ejecutarToolStripMenuItem3.Image = Properties.Resources.play;
            ejecutarToolStripMenuItem3.Name = "ejecutarToolStripMenuItem3";
            ejecutarToolStripMenuItem3.Size = new System.Drawing.Size(179, 22);
            ejecutarToolStripMenuItem3.Text = "Ejecutar";
            ejecutarToolStripMenuItem3.Click += ejecutarToolStripMenuItem3_Click;
            // 
            // gtrabrToolStripMenuItem
            // 
            gtrabrToolStripMenuItem.Image = Properties.Resources.folder_move;
            gtrabrToolStripMenuItem.Name = "gtrabrToolStripMenuItem";
            gtrabrToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            gtrabrToolStripMenuItem.Text = "Grabar en carpeta ...";
            gtrabrToolStripMenuItem.Click += gtrabrToolStripMenuItem_Click;
            // 
            // backgroundWorker_StartScreen
            // 
            backgroundWorker_StartScreen.DoWork += backgroundWorker_StartScreen_DoWork;
            // 
            // backgroundWorker_WaitScreen
            // 
            backgroundWorker_WaitScreen.WorkerSupportsCancellation = true;
            backgroundWorker_WaitScreen.DoWork += backgroundWorker_WaitScreen_DoWork;
            // 
            // bgworker_RitSolverUpdater
            // 
            bgworker_RitSolverUpdater.DoWork += bgworker_RitSolverUpdater_DoWork;
            bgworker_RitSolverUpdater.RunWorkerCompleted += bgworker_RitSolverUpdater_RunWorkerCompleted;
            // 
            // bgworkerMDIsFormsLoader
            // 
            bgworkerMDIsFormsLoader.WorkerReportsProgress = true;
            bgworkerMDIsFormsLoader.DoWork += bgworkerMDIsFormsLoader_DoWork;
            bgworkerMDIsFormsLoader.ProgressChanged += bgworkerMDIsFormsLoader_ProgressChanged;
            bgworkerMDIsFormsLoader.RunWorkerCompleted += bgworkerMDIsFormsLoader_RunWorkerCompleted;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            miniToolStrip.Location = new System.Drawing.Point(68, 3);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            miniToolStrip.Size = new System.Drawing.Size(1158, 26);
            miniToolStrip.TabIndex = 0;
            // 
            // toolBtnRecargarSAS
            // 
            toolBtnRecargarSAS.Image = Properties.Resources.refresh;
            toolBtnRecargarSAS.Name = "toolBtnRecargarSAS";
            toolBtnRecargarSAS.Size = new System.Drawing.Size(77, 24);
            toolBtnRecargarSAS.Text = "Recargar";
            toolBtnRecargarSAS.Click += recargarSASToolStripMenuItem_Click;
            // 
            // URL_GMXT_SAS_Label
            // 
            URL_GMXT_SAS_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            URL_GMXT_SAS_Label.Name = "URL_GMXT_SAS_Label";
            URL_GMXT_SAS_Label.Size = new System.Drawing.Size(0, 24);
            // 
            // statusStripSDPGMXT
            // 
            statusStripSDPGMXT.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStripSDPGMXT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBtnRecargarSAS, URL_GMXT_SAS_Label });
            statusStripSDPGMXT.Location = new System.Drawing.Point(3, 503);
            statusStripSDPGMXT.Name = "statusStripSDPGMXT";
            statusStripSDPGMXT.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            statusStripSDPGMXT.Size = new System.Drawing.Size(1158, 26);
            statusStripSDPGMXT.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(lblNodoDeProyectosSeleccionado);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(264, 38);
            panel2.TabIndex = 0;
            // 
            // lblNodoDeProyectosSeleccionado
            // 
            lblNodoDeProyectosSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNodoDeProyectosSeleccionado.AutoSize = true;
            lblNodoDeProyectosSeleccionado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            lblNodoDeProyectosSeleccionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblNodoDeProyectosSeleccionado.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblNodoDeProyectosSeleccionado.ImagePadding = 5;
            lblNodoDeProyectosSeleccionado.LeftImage = Properties.Resources.project_24;
            lblNodoDeProyectosSeleccionado.Location = new System.Drawing.Point(7, 6);
            lblNodoDeProyectosSeleccionado.Margin = new System.Windows.Forms.Padding(0);
            lblNodoDeProyectosSeleccionado.Name = "lblNodoDeProyectosSeleccionado";
            lblNodoDeProyectosSeleccionado.Size = new System.Drawing.Size(164, 24);
            lblNodoDeProyectosSeleccionado.TabIndex = 3;
            lblNodoDeProyectosSeleccionado.Text = "Mis proyectos (0)";
            // 
            // main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1172, 646);
            Controls.Add(tableLayoutPanelFondoGeneral);
            Controls.Add(tableLayoutPanelBarraMultifuncion);
            Controls.Add(menuOpcionesDeProyectos);
            ForeColor = System.Drawing.SystemColors.ControlText;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuOpcionesDeProyectos;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RIT Solver";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += main_FormClosing;
            FormClosed += main_FormClosed;
            Load += main_Load;
            Shown += main_Shown;
            Resize += main_Resize;
            contextMenuStripNodos.ResumeLayout(false);
            tableLayoutPanelFondoGeneral.ResumeLayout(false);
            tabControl_Pages.ResumeLayout(false);
            tabProyectos.ResumeLayout(false);
            tabProyectos.PerformLayout();
            splitContainer_TabPageBack.Panel1.ResumeLayout(false);
            splitContainer_TabPageBack.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_TabPageBack).EndInit();
            splitContainer_TabPageBack.ResumeLayout(false);
            splitContainer_HeaderTreeViewProyectos.Panel1.ResumeLayout(false);
            splitContainer_HeaderTreeViewProyectos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_HeaderTreeViewProyectos).EndInit();
            splitContainer_HeaderTreeViewProyectos.ResumeLayout(false);
            splitContainer_ProyectosInformacion.Panel1.ResumeLayout(false);
            splitContainer_ProyectosInformacion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_ProyectosInformacion).EndInit();
            splitContainer_ProyectosInformacion.ResumeLayout(false);
            toolStrip_Proyectos.ResumeLayout(false);
            toolStrip_Proyectos.PerformLayout();
            tabServiceDeskCompusof.ResumeLayout(false);
            tabServiceDeskCompusof.PerformLayout();
            statusStripEndPointcentral.ResumeLayout(false);
            statusStripEndPointcentral.PerformLayout();
            tabEndpointCentral.ResumeLayout(false);
            tabEndpointCentral.PerformLayout();
            statusStripSDPCompusof.ResumeLayout(false);
            statusStripSDPCompusof.PerformLayout();
            tabCentroDeControl.ResumeLayout(false);
            tabCentroDeControl.PerformLayout();
            tableLayoutPanelCentroDeControl.ResumeLayout(false);
            MDI_ACT_Panel.ResumeLayout(false);
            tableLayoutPanelCentroDeControl_Nodos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuOpcionesActividades.ResumeLayout(false);
            menuOpcionesAnuncios.ResumeLayout(false);
            tableLayoutPanelBarraMultifuncion_BotonesIzquierda.ResumeLayout(false);
            tableLayoutPanelBarraMultifuncion.ResumeLayout(false);
            tableLayoutPanelBarraMultifuncion.PerformLayout();
            panel7.ResumeLayout(false);
            menuOpcionesDeProyectos.ResumeLayout(false);
            menuOpcionesDeProyectos.PerformLayout();
            statusStripSDPGMXT.ResumeLayout(false);
            statusStripSDPGMXT.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFondoGeneral;
        private flExtendedTabControl tabControl_Pages;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TabPage tabEndpointCentral;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
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
        private flCustomToolStrip toolStrip_Proyectos;
        private System.Windows.Forms.ToolStripButton toolNuevoProyecto;
        private System.Windows.Forms.ToolStripButton toolAbrirProyectoExistente;
        private System.Windows.Forms.ToolStripButton toolEliminarProyecto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolImportarActividad;
        private System.Windows.Forms.ToolStripButton toolExportarActividad;
        private System.Windows.Forms.Label lblNombreSeccion;
        private flCustomLabel lblNombreNodoSeleccionado;
        private System.Windows.Forms.ToolStripButton toolNuevaSeccion;
        private System.Windows.Forms.Label lblDescripcionDeNodo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cerrarProyectoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripSDPCompusof;
        private System.Windows.Forms.StatusStrip statusStripEndPointcentral;


        private System.Windows.Forms.ToolStripLabel URL_EndPoint_Central_Label;         // Label Compusof
        private System.Windows.Forms.ToolStripLabel URL_SDP_Compusof_Label;     // Label EndPoint Central
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
        private flCustomButton btnFuncion2;
        private flCustomButton btnFuncion1;
        private System.Windows.Forms.LinkLabel lblContactoFallos;
        private flCustomButton btnFuncion3;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker_StartScreen;
        public System.ComponentModel.BackgroundWorker backgroundWorker_WaitScreen;
        private System.Windows.Forms.ToolStripButton toolGeneracionRapidaDeReporte;
        private System.ComponentModel.BackgroundWorker bgworker_RitSolverUpdater;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripNodos;
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
        private System.Windows.Forms.ToolStripButton toolMinimizarTodosLosReportes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem minimizarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolImportarListaDePendientes;
        private System.Windows.Forms.ToolStripButton toolCerrarListaDePendientes;
        private System.Windows.Forms.ToolStripButton toolEliminarListaDePendientesPorHacer;
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
        private System.Windows.Forms.ToolStripMenuItem listadoDeHistorialesToolStripMenuItem;
        private System.Windows.Forms.TabPage tabServiceDesk;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnRecargarSAS;
        private System.Windows.Forms.ToolStripLabel URL_GMXT_SAS_Label;
        private System.Windows.Forms.StatusStrip statusStripSDPGMXT;
        private System.Windows.Forms.SplitContainer splitContainer_TabPageBack;
        private System.Windows.Forms.SplitContainer splitContainer_HeaderTreeViewProyectos;
        private System.Windows.Forms.SplitContainer splitContainer_ProyectosInformacion;
        public System.Windows.Forms.TreeView treeViewProyectos;
        private System.Windows.Forms.Panel MDI_RIT_Panel;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private flCustomToolStripSeparator flCustomToolStripSeparator3;
        private flCustomToolStripSeparator flCustomToolStripSeparator4;
        private flCustomToolStripSeparator flCustomToolStripSeparator2;
        private System.Windows.Forms.Panel panel2;
        public flCustomLabel lblNodoDeProyectosSeleccionado;
    }
}