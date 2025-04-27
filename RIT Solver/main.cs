using CustomMessageBox;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using iTextSharp.text.pdf.codec;


//using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using Flow_Solver.Centro_de_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Flow_Solver
{
    public partial class main : Form
    {
        #region BANDERAS Y VARIABLES GLOBALES
        bool flag_config_open = false;

        string URL_FORMS_ACTUAL = Properties.Settings.Default.SYSDATA_URL_FORMS.Trim();
        string URL_GMXT_SAS_ACTUAL = Properties.Settings.Default.SYSDATA_URL_SERVICEDESK.Trim();
        string URL_COMPUSOF_SAS_ACTUAL = Properties.Settings.Default.SYSDATA_URL_COMPUSOF.Trim();
        string URL_ENDPOINT_ACTUAL = Properties.Settings.Default.SYSDATA_URL_ENDPOINT.Trim();

        internal string defaultProjectName = "Nuevo proyecto RIT %COUNT%...";


        public static string CEF_CACHE_PATH;
        public static int mdi_counter = 0;

        public static string SERVER_NAME;
        public static string SERVER_ID;
        public static string SERVER_MACHINENAME;
        public static string SERVER_ROOTKEY;
        public static string SERVER_PORT;


        /** BANDERAS DE COLORES PARA EL TEMA **/
        public static Color BG_COLOR;
        public static Color SECONDARY_COLOR;
        public static Color TERTIARY_COLOR;
        public static Color FOURSOME_COLOR;

        public static Color PRIMARY_TEXT_COLOR;
        public static Color SECONDARY_TEXT_COLOR;
        #endregion

        #region METODO DE TEMAS PARA EL PROGRAMA
        public void saveThemeColors()
        {
            /** Guardamos la configuracion de colores del tema seleccionado **/

            // Colores de fondo
            Properties.Settings.Default.THEME_BACKGROUND_COLOR = BG_COLOR;
            Properties.Settings.Default.THEME_SECONDARY_COLOR = SECONDARY_COLOR;
            Properties.Settings.Default.THEME_TERTIARY_COLOR = TERTIARY_COLOR;
            Properties.Settings.Default.THEME_FOURSOME_COLOR = FOURSOME_COLOR;

            // Colores de texto
            Properties.Settings.Default.THEME_TEXT_PRIMARY = PRIMARY_TEXT_COLOR;
            Properties.Settings.Default.THEME_TEXT_SECONDARY = SECONDARY_TEXT_COLOR;

            Properties.Settings.Default.Save(); // Guardamos configuracion
        }

        public void themeLoad()
        {
            /* DATOS A MODIFICAR:
             * 1 - color de fondo de la cinta de opciones
             * 2 - color de fuente de la cinta de opciones
             * 3 - color de fondo de la app (tablelayoutpanel1)
             * 4 - color de fondo de tabpage3
             * 5 - texto de tabpage3
             * */
            try
            {

                /* IMPLEMENTAR TEMAS EN EL SISTEMA DE INVENTARIOS */
            }
            catch (Exception ex) { }

            switch (Properties.Settings.Default.SYSDATA_TEMA_APLICADO)
            {
                case "RIT Solver Theme (Default)":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromKnownColor(KnownColor.ActiveCaption);
                    SECONDARY_COLOR = Color.FromKnownColor(KnownColor.ControlLight);
                    TERTIARY_COLOR = Color.FromKnownColor(KnownColor.Gray);
                    FOURSOME_COLOR = Color.FromKnownColor(KnownColor.Control);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.ControlText);
                    SECONDARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);


                    /** Tema default **/
                    //
                    // Establecemos colores de la primera seccion
                    //
                    menuOpcionesDeProyectos.BackColor = BG_COLOR;
                    menuOpcionesDeProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = FOURSOME_COLOR;
                    this.lblContactoFallos.LinkColor = PRIMARY_TEXT_COLOR;
                    this.linkLabel1.LinkColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = Color.FromKnownColor(KnownColor.LightGray);
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = SECONDARY_TEXT_COLOR;
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = SECONDARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = Color.FromKnownColor(KnownColor.LightGray);
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = SECONDARY_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = SECONDARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "GMXT Theme (High Contrast)":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(107, 129, 142);           // Gris FXE
                    SECONDARY_COLOR = Color.FromArgb(233, 1, 1);        // Rojo FXE
                    TERTIARY_COLOR = Color.FromKnownColor(KnownColor.DarkGray);
                    FOURSOME_COLOR = Color.FromKnownColor(KnownColor.ControlLight);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.ControlText);
                    SECONDARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);


                    /** Tema GMXT **/
                    menuOpcionesDeProyectos.BackColor = SECONDARY_COLOR;
                    menuOpcionesDeProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.LightGray);
                    linkLabel1.LinkColor = PRIMARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;    // Si afectamos esto, se cambia color de fuente en MDI
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = Color.Gray;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;  // Si afectamos esto, se cambia color de fuente en MDI
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = SECONDARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = Color.Gray;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = SECONDARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "GMXT Theme":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(107, 129, 142);           // Gris FXE
                    SECONDARY_COLOR = Color.FromArgb(233, 1, 1);        // Rojo FXE
                    TERTIARY_COLOR = Color.FromKnownColor(KnownColor.DarkGray);
                    FOURSOME_COLOR = Color.FromKnownColor(KnownColor.ControlLight);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.ControlText);
                    SECONDARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);

                    /** Tema GMXT (Bajo contraste) **/
                    menuOpcionesDeProyectos.BackColor = SECONDARY_COLOR;
                    menuOpcionesDeProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;//
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = BG_COLOR;
                    linkLabel1.LinkColor = SECONDARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;    // Si afectamos esto, se cambia color de fuente en MDI
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = Color.Gray;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;  // Si afectamos esto, se cambia color de fuente en MDI
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = SECONDARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = Color.Gray;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = SECONDARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "Dark":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(45, 59, 67);
                    SECONDARY_COLOR = Color.FromArgb(66, 76, 82);
                    TERTIARY_COLOR = Color.FromArgb(76, 85, 90);
                    FOURSOME_COLOR = Color.FromArgb(97, 102, 105);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);


                    /** Tema oscuro (Dark) **/
                    //
                    // Establecemos colores de la primera seccion
                    //
                    menuOpcionesDeProyectos.BackColor = BG_COLOR;
                    menuOpcionesDeProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = BG_COLOR;
                    linkLabel1.LinkColor = PRIMARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;    // Si afectamos esto, se cambia color de fuente en MDI
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;  // Si afectamos esto, se cambia color de fuente en MDI
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = SECONDARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = SECONDARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = SECONDARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = SECONDARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = SECONDARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = SECONDARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "Light":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(224, 224, 224);
                    SECONDARY_COLOR = Color.FromKnownColor(KnownColor.ControlLightLight);
                    TERTIARY_COLOR = Color.FromKnownColor(KnownColor.ControlLight);
                    FOURSOME_COLOR = Color.FromArgb(207, 207, 207);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.ControlText);

                    /** Tema luminoso (Light) **/
                    //
                    // Establecemos los colores de la primera seccion
                    //
                    menuOpcionesDeProyectos.BackColor = BG_COLOR;
                    menuOpcionesDeProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = SECONDARY_COLOR;
                    linkLabel1.LinkColor = PRIMARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = PRIMARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = PRIMARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "Dark Blue":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(0, 77, 121);
                    SECONDARY_COLOR = Color.FromArgb(32, 90, 123);
                    TERTIARY_COLOR = Color.FromArgb(64, 102, 124);
                    FOURSOME_COLOR = Color.FromArgb(96, 115, 126);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);

                    /** Tema Blue (oscuro) **/
                    //
                    // Establecemos los colores de la primera seccion
                    //
                    menuOpcionesDeProyectos.BackColor = BG_COLOR;
                    menuOpcionesDeProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = SECONDARY_COLOR;
                    linkLabel1.LinkColor = PRIMARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = PRIMARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = PRIMARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
                case "Light Blue":
                    #region CODIGO
                    // Colores de fondo
                    BG_COLOR = Color.FromArgb(58, 163, 222);
                    SECONDARY_COLOR = Color.FromKnownColor(KnownColor.ControlLight);
                    TERTIARY_COLOR = Color.FromArgb(81, 151, 191);
                    FOURSOME_COLOR = Color.FromArgb(104, 139, 159);
                    // Colores de texto
                    PRIMARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.Snow);
                    SECONDARY_TEXT_COLOR = Color.FromKnownColor(KnownColor.ControlText);

                    /** Tema Blue (luminoso) **/
                    //
                    // Establecemos los colores de la primera seccion
                    //
                    menuOpcionesDeProyectos.BackColor = BG_COLOR;
                    menuOpcionesDeProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    tableLayoutPanelFondoGeneral.BackColor = BG_COLOR;
                    //
                    // Establecemos colores de fondo
                    //
                    //panelCentroAbajo.BackColor = SECONDARY_COLOR;
                    //
                    // Establecemos los colores de la barra multifuncional
                    //
                    tableLayoutPanelBarraMultifuncion.BackColor = SECONDARY_COLOR;
                    linkLabel1.LinkColor = SECONDARY_TEXT_COLOR;
                    lblContactoFallos.LinkColor = SECONDARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de proyectos
                    //
                    tabProyectos.BackColor = TERTIARY_COLOR;
                    tabProyectos.ForeColor = SECONDARY_TEXT_COLOR;
                    panel4.BackColor = Color.Transparent;   // Titulo
                    lblNodoDeProyectosSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    panel6.BackColor = Color.Transparent;   // Descripcion
                    lblNombreDeNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_RIT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewProyectos.BackColor = TERTIARY_COLOR;
                    treeViewProyectos.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Establecemos los colores del panel de centro de control
                    //
                    tabCentroDeControl.BackColor = TERTIARY_COLOR;
                    //tabCentroDeControl.ForeColor = SECONDARY_TEXT_COLOR;
                    panel1.BackColor = Color.Transparent;   // Titulo
                    lblNombreSeccion.ForeColor = PRIMARY_TEXT_COLOR;
                    panel3.BackColor = Color.Transparent;   // Descripcion
                    lblNombreNodoSeleccionado.ForeColor = PRIMARY_TEXT_COLOR;
                    lblDescripcionDeNodo.ForeColor = PRIMARY_TEXT_COLOR;
                    MDI_ACT_Panel.BackColor = FOURSOME_COLOR;
                    treeViewCentroDeControl.BackColor = TERTIARY_COLOR;
                    treeViewCentroDeControl.ForeColor = PRIMARY_TEXT_COLOR;
                    //
                    // Colores de los StatusStrips de los navegadores
                    //
                    statusStripForms.BackColor = TERTIARY_COLOR;
                    statusStripForms.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPGMXT.BackColor = TERTIARY_COLOR;
                    statusStripSDPGMXT.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripSDPCompusof.BackColor = TERTIARY_COLOR;
                    statusStripSDPCompusof.ForeColor = PRIMARY_TEXT_COLOR;
                    statusStripEndPointcentral.BackColor = TERTIARY_COLOR;
                    statusStripEndPointcentral.ForeColor = PRIMARY_TEXT_COLOR;
                    #endregion

                    saveThemeColors();
                    break;
            }
        }
        #endregion

        internal BackgroundWorker splashBackground = new BackgroundWorker();
        private bool MainThreadHaveToClose = false;
        public static main Instance { get; private set; }


        private void StartForm()
        {
            Application.Run(new splash_screen());
        }        

        void _CommonsAppertureMethods()
        {
            #region Proceso de splash screen
            // Metodo Experimental
            /*
            splashBackground.WorkerSupportsCancellation = true;
            splashBackground.DoWork += backgroundWorker_StartScreen_DoWork;
            this.splashBackground.RunWorkerAsync();
            */

            // Metodo Estable Funcional
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                Thread t = new Thread(new ThreadStart(StartForm));
                t.Start();
                Thread.Sleep(8000);
                t.Abort();
            }
            catch (Exception ex) { }
            #endregion

            /* 
             * Proceso de actualizacion del registro con las entradas correspondientes
             * 
             * - Entrada de actualizacion
             * - Entrada de archivos
             * */
            #region CODIGO DE REGISTROS DEL PROGRAMA
            // Cargamos la entrada de los detalles de la version actual
            // Archivo de entrada: SoftwareRegUpdater.reg
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationDataUpdate.Make());
            // Cargamos la entrada de los archivos .actproj
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_ActProj.Make());
            // Cargamos la entrada de los archivos .card
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_Card.Make());
            // Cargamos la entrada de los archivos .historial
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_EventHistorial.Make());
            // Cargamos la entrada de los archivos .todolist
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_ToDoList.Make());
            // Cargamos la entrada de los archivos .tracklist
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_TrackFile.Make());
            // Cargamos la entrada de los archivos .ritproj
            WindowsRegisterUpdater.LoadEntry(WindowsRegisterUpdater.ApplicationFile_RitProj.Make());
            #endregion

            //CheckForIllegalCrossThreadCalls = false;

            if (Properties.Settings.Default.FIRST_INITIALIZE == true)
            {
                configuracion_inicial frm = new configuracion_inicial();
                //frm.TopMost = true;
                //frm.TopLevel = true;
                frm.ShowDialog();   // Tiene que establecerse por defecto como ShowDialog, de lo contrario no abre

                if (frm.DialogResult == DialogResult.OK)
                {
                    // Cuando se inicializa la app hacer...
                    InitializeComponent();
                    MainThreadHaveToClose = false;
                }
                else if (frm.DialogResult == DialogResult.Cancel)
                {
                    MainThreadHaveToClose = true;
                }
            }
            else
            {
                // Cuando se inicializa la app hacer...
                InitializeComponent();
                MainThreadHaveToClose = false;
            }

            Instance = this;

            /* 
             * Evaluamos si debemos continuar o si debemos cerrar
             * */
            if (MainThreadHaveToClose == true)
            {
                CommonMethodsLibrary.OutMessage("out", "main.cs", "FINALIZANDO DE HILO PRINCIPAL DE LA APLICACION...", "INF");
                Application.Exit();
                Environment.Exit(0);    // Cerramos el hilo principal
            }

            // Lanzamos pantalla inicial para inciar la carga
            //this.backgroundWorker_StartScreen.RunWorkerAsync();


            this.TopMost = true;
            this.Focus();
            this.tabProyectos.Select();

            /** Inicializacion del tema aplicado **/
            themeLoad();

            #region CONFIGURACION ORIGINAL AL ABRIR FORMULARIO
            this.MinimumSize = this.Size;
            this.pgrssbarAbrirFormularios.Visible = false;

            this.btnFuncion1.Text = "Importar datos de SAS (Ctrl + F1)";
            this.btnFuncion3.Text = "Guardar PDF e imprimir (Ctrl + F3)";

            this.lblContactoFallos.Text = "¿Presentas fallos con el programa? ¡Reportalos aqui!";

            this.toolEliminarProyecto.Enabled = false;

            #region PARAMETROS DE APERTURA DE LOS EXPLORADORES CHROMIUM Y EDGE
            // Cargamos las paginas

            // FORM COMPUSOF
            this.webView_CompusofForms.EnsureCoreWebView2Async(null);
            this.URL_RIT_Forms_Label.Text = URL_FORMS_ACTUAL;

            // SAS COMPUSOF
            this.webView_ServiceDeskCompusof.EnsureCoreWebView2Async(null);
            this.URL_SDP_Compusof_Label.Text = URL_COMPUSOF_SAS_ACTUAL;

            /*
            Cef.Initialize(new cef);
            CefSharpSettings asettings = new CefSharpSettings();

            string cache_dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            asettings.CachePath = cache_dir;
            asettings.CefCommandLineArgs.Add("persist_session_cookies", "1");
            */
            #endregion
            #endregion

            this.DoubleBuffered = true;
            this.IsMdiContainer = true;

            this.FormClosed += MainForm_FormClosed;

            #region REGISTRAMOS EL MODDULO DE POWERSHELL DE LA APLICACION
            string dllModulePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RitSolver.PowerShell.dll");
            MessageBox.Show(dllModulePath);
            //PowershellModuleInstaller.LoadModule(dllModulePath);
            #endregion
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Llamar al método para finalizar los procesos relacionados
            FinalizarProcesosRelacionados();
        }

        private void FinalizarProcesosRelacionados()
        {
            // Obtener el nombre del proceso actual
            string processName = Process.GetCurrentProcess().ProcessName;

            // Obtener todos los procesos con el mismo nombre
            var processes = Process.GetProcessesByName(processName);

            // Finalizar cada proceso
            foreach (var process in processes)
            {
                if (process.Id != Process.GetCurrentProcess().Id) // Evitar finalizar el proceso actual
                {
                    process.Kill();
                }
            }
        }

        /// <summary>
        /// Constructor de aplicacion normal
        /// </summary>
        public main()
        {
            _CommonsAppertureMethods();
        }

        /// <summary>
        /// Constructor de aplicacion si se abrio desde uno o varios archivos
        /// </summary>
        public main(List<Tuple<AppertureType, string>> _filesToOpen)
        {
            _CommonsAppertureMethods();

            //
            // Clasificamos las listas
            //
            List<string> ritFiles = new List<string>(); // LISTA DE PROYECTOS DE ACTIVIDADES
            foreach (Tuple<AppertureType, string>  i in _filesToOpen)
            {
                if (i.Item1 == AppertureType.BY_RIT_PROJECT_FILE)
                {
                    ritFiles.Add(i.Item2);
                }
            }

            List<string> actFiles = new List<string>(); // LISTA DE PROYECTOS DE ACTIVIDADES
            foreach (Tuple<AppertureType, string> i in _filesToOpen)
            {
                if (i.Item1 == AppertureType.BY_ACTIVITY_PROJECT_FILE)
                {
                    actFiles.Add(i.Item2);
                }
            }

            //
            // Abrimos los archivos de cada lista
            //
            /* Archivos de Proyectos de RITs */
            OpenFileByRit(ritFiles.ToArray());
            OpenFileByAct(actFiles.ToArray());
        }

        public void OpenFileByRit(string[] filePaths)
        {
            _RitFileNamesQueue = filePaths;

            this.pgrssbarAbrirFormularios.Visible = true;
            this.pgrssbarAbrirFormularios.Maximum = _RitFileNamesQueue.Length;
            this.bgworkerMDIsFormsLoader.RunWorkerAsync();
        }

        public void OpenFileByAct(string[] filePaths)
        {
            this.tabControl_Pages.SelectedTab = tabCentroDeControl;

            foreach (string act in filePaths)
            {
                this.Cursor = Cursors.WaitCursor;

                actividades_mdi_form frm = new actividades_mdi_form(this, act);
                frm.TopLevel = false;
                this.MDI_ACT_Panel.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BringToFront();

                this.Cursor = Cursors.Default;
            }

            // Seleccionamos y abrimos automaticamente el ultimo proyecto de actividad cargado
            if (this.treeViewCentroDeControl.Nodes["nodeActividades"].Nodes.Count > 0)
            {
                TreeNode lastProjCharged = this.treeViewCentroDeControl.Nodes["nodeActividades"].Nodes
                                                    .Cast<TreeNode>()
                                                    .LastOrDefault();
                this.treeViewCentroDeControl.SelectedNode = lastProjCharged;
            }
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            acera_de frm = new acera_de();
            frm.ShowDialog();
        }

        private void btnGuardarDatos_Click_1(object sender, EventArgs e)
        {
            /* BOTON MULTIUSO 
             * SE OTORGAN LOS COMANDOS SEGUN SEA EL TABPAGE SELECCIONADO
             */

            if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabProyectos"])
            {
                #region CODIGO FUERA DE SERVICIO
                ///* EN CASO DE QUE SE ESTE TRABAJANDO EN LA TABPAGE3 ("LLENAR RIT") */

                //string AÑO;
                //string MES;
                //string path;

                //DateTime fechaActual = DateTime.Now;
                //AÑO = fechaActual.Year.ToString();
                //MES = fechaActual.ToString("MMMM");
                //path = Properties.Settings.Default.RITFormPathDestiny + $@"\RITs\{AÑO}\{MES}\";

                //if (!Directory.Exists(path))
                //{
                //    Directory.CreateDirectory(path);
                //}

                //path_rit_destiny = path;

                //// Impresion de RIT en base a datos guardados
                //if (string.IsNullOrEmpty(this.txtFallaReportada.Text) | string.IsNullOrEmpty(this.txtUsuariofinal.Text))
                //{
                //    RJMessageBox.Show("No se puede asignar los datos! favor de llenar el campo de falla reportada y/o usuario final.", "Error - campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //else
                //{
                //    FillPDFForm();
                //    printPDFWithAcrobat(); // Imprimimos el archivo
                //}
                #endregion
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabFormCompusof"])
            {
                /* EN CASO DE QUE SE ESTE TRABAJANDO EN LA TABPAGE4 ("SUBIR RIT") */

                webView_CompusofForms.Focus();

                project_selector_form frm = new project_selector_form(this, project_selector_form.ProjectSelectorSenders.SOLVE_FORM_TICKET);
                frm.ShowDialog();

                //Forms_Methods.FillCompusofForms(this.txtUsuariofinal.Text, this.txtNoDeEmpleado.Text, this.txtNoDeReporteDelCliente.Text, this.txtTecnico.Text, this.txtPoblacion.Text, mes_reporte, dia_reporte, año_reporte);
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabServiceDeskGMXT"])
            {
                /*  EN CASO DE QUE SE ESTE TRABAJANDO EN LA TABPAGE4 (MESA DE GMXT)*/
                /* CREAR MACRO PARA ACCESO AUTOMATICO A SAS GMXT */
                SAS_Methods.EnterAccessSAS();
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabServiceDeskCompusof"])
            {
                /* MESA DE COMPUSOF */
            }
        }


        // FUNCION TERMINADA
        private void lblContactoFallos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            informar_bug frm = new informar_bug();
            frm.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Focus();
            this.TopMost = false;
            this.Text = $"RIT Solver 2024 - v{Properties.Settings.Default.SYS_VERSION}";

            this.btnFuncion1.Visible = false;
            this.btnFuncion2.Visible = false;
            this.btnFuncion3.Visible = false;

            // Configuracion de Proyectos
            this.lblNodoDeProyectosSeleccionado.Text = "Mis Proyectos";
            this.lblNombreDeNodoSeleccionado.Text = "";

            /* Inicializacion de TreeViews */
            // Arbol "Mis Proyectos"
            this.treeViewProyectos.Nodes["nodeMisProyectos"].ContextMenuStrip = this.contextMenuStripNodos;

            this.treeViewProyectos.Nodes["nodeMisProyectos"].ImageIndex = 0;


            #region VALIDADOR DE CONTRASEÑA VIGENTE
            /* PROCESO DE VALIDACION DE CONTRASEÑA ACTUAL */
            try
            {
                PrincipalContext adContext = new PrincipalContext(ContextType.Domain);

                using (adContext)
                {
                    var result = adContext.ValidateCredentials(Properties.Settings.Default.UsuarioDeRedIDC, Properties.Settings.Default.EmailPasswordIDC);
                    if (result == false)
                    {
                        DialogResult pass_change = RJMessageBox.Show("Su contraseña de red ya no es valida en el dominio, ¿desea cambiarla de inmediato?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (pass_change == DialogResult.Yes)
                        {
                            configuracion_usuario frm = new configuracion_usuario(this);
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("in", "main.cs", $"OCURRIO UN ERROR INESPERADO AL MOMENTO DE INTENTAR VALIDAR LA CONTRASEÑA ACTUAL EN EL AD! {ex.Message}", "WAR");
            }
            #endregion


            /* 
             * Iniciamos el proceso de busqueda de actualizaciones
             * */
            this.bgworker_RitSolverUpdater.RunWorkerAsync();

            #region CONFIGURACION DE PROPIEDADES
            /** ASIGANCION AUTOMATICA DE VALORES **/
            // PATH DE ACTA RESPONSIVA
            if (string.IsNullOrEmpty(Properties.Settings.Default.ActaResponsivaPath))
            {
                Properties.Settings.Default.ActaResponsivaPath = $@"{Application.StartupPath}\FORMULARIO ACTARESPONSIVA HQ.pdf";
            }

            // ==NOTA: EL VALOR DEL PATH DEL FORMULARIO RIT SE ASIGNA POR DEFECTO EN LA CONFIGURACION INICIAL
            // PERO AUN ASI POR SI ACASO SE DEBE AGREGAR INSTANCIA
            if (string.IsNullOrEmpty(Properties.Settings.Default.RITFormPath))
            {
                Properties.Settings.Default.ActaResponsivaPath = $@"{Application.StartupPath}\FORMULARIO RIT HQ.pdf";
            }
            #endregion


            // En caso de que no exista la libreta de direcciones de localidades, la crea en automatico
            // segun los datos guardados en la config. local

            #region VALIDADOR DE EXISTENCIA DE DIRECCIONES LOCALES
            AddressSite.DirsValidator();
            string ADDRESES_PATH = $@"{Application.StartupPath}\Addresses\Localidades";

            if (Properties.Settings.Default.SYSDATA_LOCALIDAD_DEFAULT == String.Empty || File.Exists($@"{ADDRESES_PATH}\Direccion_default.json") == false)
            {
                #region CREACION DE LOCALIDAD DEFAULT EN CASO DE NO EXISTIR
                AddressesManager.ValidateDefaultAddressExists();
                #endregion
            }
            #endregion

            #region ACTUALIZA LOS DATOS DE LOS JSON DE USUARIOS
            // (V.1 -> V.2)
            //MessageBox.Show("Abriendo");
            string UserCards_Path = $@"{Application.StartupPath}\UsersCard";

            if (Directory.Exists(UserCards_Path))
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(UserCards_Path);
                    FileInfo[] files = di.GetFiles("*.card");

                    foreach (FileInfo file in files)
                    {
                        string json_card = File.ReadAllText($@"{file.FullName}");
                        JObject json = JObject.Parse(json_card);

                        if (!json.ContainsKey("localidad_asignada"))
                        {
                            // Les incrustamos la clave { "localidad_asignada" : "No asignada" }
                            //MessageBox.Show($"El usuario {json["nombre"]} no cuenta con localidad asignada");

                            json.Add("localidad_asignada", "No asignada");
                        }
                        //MessageBox.Show(json.ToString());
                        File.WriteAllText(file.FullName, json.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }
            #endregion


            // Iniciamos la ultima sesion registrada por el programa
            if (Properties.Settings.Default.SYSDATA_RECORDAR_ULTIMA_SESION)
            {

            }

            // Iniciamos nuevo proyecto en blanco
            if (Properties.Settings.Default.SYSDATA_CREAR_PROYECTO_BLANCO_AL_INICIAR)
            {
                this.toolNuevoProyecto.PerformClick();
            }

            #region VALIDADOR DE COMPONENTES INSTALADOS
            string ToolComponentPath = $@"{Application.StartupPath}\tools";
            if (Directory.Exists(ToolComponentPath))
            {
                herramientasToolStripMenuItem1.Enabled = true;
            }
            else
            {
                herramientasToolStripMenuItem1.Enabled = false;
                herramientasToolStripMenuItem1.ToolTipText = "No cuenta con el componente instalado!";
            }
            #endregion

            this.treeViewCentroDeControl.SelectedNode = treeViewCentroDeControl.Nodes[0];

            // GUARDAMOS CAMBIOS REALIZADOS A LA CONFIGURACION
            Properties.Settings.Default.Save();
        }



        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* INSTANCIA PARA CAMBIO DE TEXTO EN EL BOTON */
            if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabFormCompusof"])
            {
                /* FORMULARIO RIT DE COMPUSOF */
                // BOTON MULTIUSO GENERAL
                this.btnFuncion3.Visible = true;
                this.btnFuncion3.Enabled = true;
                this.btnFuncion3.Text = "Llenar Forms (Ctrl + F3)";
                this.btnFuncion1.Visible = false;
                this.btnFuncion1.Enabled = false;
                this.btnFuncion2.Visible = false;
                this.btnFuncion2.Enabled = false;
                this.btnFuncion2.Text = "Limpiar  (Ctrl + F2)";
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabProyectos"])
            {
                /* LLENADOR DE RIT */
                // BOTON MULTIUSO GENERAL
                this.btnFuncion3.Text = "Guardar PDF e imprimir  (Ctrl + F3)";
                this.btnFuncion3.Visible = false;
                this.btnFuncion1.Visible = false;
                this.btnFuncion1.Text = "Importar datos de SAS  (Ctrl + F1)";
                this.btnFuncion2.Visible = false;
                this.btnFuncion2.Text = "Limpiar (Ctrl + F2)";
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabServiceDeskCompusof"])
            {
                /* MESA COMPUSOF */
                // BOTON MULTIUSO GENERAL
                this.btnFuncion3.Visible = false;
                this.btnFuncion1.Visible = false;
                this.btnFuncion2.Visible = false;
                this.btnFuncion2.Text = "Limpiar (Ctrl + F2)";
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabServiceDeskGMXT"])
            {
                /* MESA GMXT */
                // BOTON MULTIUSO GENERAL
                this.btnFuncion3.Visible = true;
                this.btnFuncion3.Text = "Entrar  (Ctrl + F3)";
                this.btnFuncion2.Visible = true;
                this.btnFuncion2.Text = "Resolver (Ctrl + F2)";

                // BOTON DE CARGAR DATOS
                // EN ESTE CONTEXTO: CARGAR DATOS A SAS
                // FORM -> GMXT SAS
                this.btnFuncion1.Visible = true;
                this.btnFuncion1.Text = "Importar datos del Form (Ctrl + F1)";
            }
        }

        private async void btnCargarDatosDeSAS_Click(object sender, EventArgs e)
        {
            if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabProyectos"])
            {
                /* FUNCION DE BOTON EN FORM */
                #region CODIGO FUERA DE SERVICIO
                // CONTEXTO: TRAER DATOS DE UN REPORTE ABIERTO EN SAS AL FORM

                //#region IMPORTA DATOS DEL SAS AL FORM PRINCIPAL = F/T
                //try
                //{
                //    string NOMBRE_DEL_REPORTE = "";

                //    const string ascript = "document.getElementById('req_subject').innerHTML";
                //    JavascriptResponse arespuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(ascript);

                //    if (arespuesta.Result != null)
                //    {
                //        if (!string.IsNullOrEmpty(arespuesta.Result.ToString()))
                //        {
                //            NOMBRE_DEL_REPORTE = arespuesta.Result.ToString();
                //        }
                //    }

                //    if (string.IsNullOrEmpty(NOMBRE_DEL_REPORTE)) {
                //        RJMessageBox.Show("¡Ningun reporte se ha seleccionado en la pagina de SAS! por favor, entra a un reporte para poder importar sus datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    } else
                //    {
                //        if (RJMessageBox.Show($"¿Desea importar los datos del reporte < {NOMBRE_DEL_REPORTE} > abierto en SAS al formulario?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //        {
                //            #region NUEVO METODO PARA OBTENCION
                //            // NUMERO DE REPORTE
                //            try
                //            {
                //                if (this.txtNoDeReporteDelCliente.Text == string.Empty)
                //                {
                //                    const string script = "document.getElementById('request-id').innerHTML";
                //                    JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script); if (respuesta.Result != null) { this.txtNoDeReporteDelCliente.Text = respuesta.Result.ToString(); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }

                //            // FALLA REPORTADA
                //            try
                //            {
                //                if (this.txtFallaReportada.Text == string.Empty)
                //                {
                //                    const string script = "document.getElementById('req_subject').innerHTML";
                //                    JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script); if (respuesta.Result != null) { this.txtFallaReportada.Text = respuesta.Result.ToString(); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }

                //            // DEPARTAMENTO DEL USUARIO
                //            try
                //            {
                //                if (this.txtDepartamento.Text == string.Empty)
                //                {
                //                    const string script = "document.getElementsByClassName('spot-static-content').item(1).textContent";
                //                    JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script); if (respuesta.Result != null) { this.txtDepartamento.Text = respuesta.Result.ToString(); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }

                //            // TELFONO DEL USUARIO
                //            try
                //            {
                //                if (this.txtTelefono.Text == string.Empty)
                //                {
                //                    const string script = "document.getElementsByClassName('spot-static-content').item(2).textContent";
                //                    JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script); if (respuesta.Result != null) { this.txtTelefono.Text = respuesta.Result.ToString(); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }

                //            // NUMERO DE EMPLEADO
                //            try
                //            {
                //                if (this.txtNoDeEmpleado.Text == string.Empty)
                //                {
                //                    const string script = "document.getElementsByClassName('spot-static-content').item(5).textContent";
                //                    JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script); if (respuesta.Result != null) { this.txtNoDeEmpleado.Text = respuesta.Result.ToString(); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }


                //            // NOMBRE DEL USUARIO
                //            try
                //            {
                //                if (this.txtUsuariofinal.Text == string.Empty)
                //                {
                //                    try
                //                    {
                //                        const string script = "document.getElementById('userName').innerHTML";
                //                        JavascriptResponse respuesta = await this.chromiumWebBrowserSASGMXT.EvaluateScriptAsync(script);

                //                        if (!string.IsNullOrEmpty(respuesta.Result.ToString()))
                //                        {
                //                            this.txtUsuariofinal.Text = respuesta.Result.ToString();
                //                        }
                //                    } catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }
                //                }
                //            }
                //            catch (Exception ex) { RJMessageBox.Show(ex.ToString()); }

                //            #endregion
                //        }
                //    }

                //}catch (Exception ex) { RJMessageBox.Show("La pagina de SAS aun no esta cargada, ingrese a SAS y vuelva a intentarlo. " + Environment.NewLine + Environment.NewLine + "El programa indica:" + Environment.NewLine + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                //#endregion
                #endregion
            }
            else if (tabControl_Pages.SelectedTab == tabControl_Pages.TabPages["tabServiceDeskGMXT"])
            {
                /* FUNCION DE BOTON EN SAS */
                // CONTEXTO: IMPORTAR DATOS DEL FORM AL SAS

                #region CREAR REPORTE EN SAS CON DATOS DE FORM PRINCIPAL = F/ND

                project_selector_form frm = new project_selector_form(this, project_selector_form.ProjectSelectorSenders.MAKE_TICKET);
                frm.ShowDialog();
                #endregion
            }
        }

        private void abrirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.bgworkerMDIsFormsLoader.IsBusy == false)
            {
                this.tabControl_Pages.SelectedTab = tabProyectos;

                openFileDialog1.Title = "Abrir proyecto de ticket...";
                openFileDialog1.Filter = "Archivo de Formulario RIT | *.ritproj|Archivo JSON | *.json";
                openFileDialog1.Multiselect = true;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _RitFileNamesQueue = openFileDialog1.FileNames;

                    this.pgrssbarAbrirFormularios.Visible = true;
                    this.pgrssbarAbrirFormularios.Maximum = openFileDialog1.FileNames.Length;
                    this.bgworkerMDIsFormsLoader.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("El canal de proceso secundario para la tarea indicada se encuentra ocupado en este momento!");
            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracion_usuario frm = new configuracion_usuario(this);
            frm.ShowDialog();
        }

        private void buscarActualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Busqueda de actualizaciones

            if (UpdaterManager.Update.SearchUpdates(Properties.Settings.Default.SERVER_ROUTE, true, Properties.Settings.Default.SYS_VERSION) == true)
            {
                // Se encontraron nuevas actualizaciones estables disponibles
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ENCONTRO UNA NUEVA ACTUALIZACION PARA LA VERSION ACTUAL: '{Properties.Settings.Default.SYS_VERSION}'", "inf");

                if (RJMessageBox.Show("¡Se han encontrado nuevas actualizaciones disponibles! ¿Desea instalar la actualizacion?", "Gestor de actualizaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    /* INICIAR PROCESO DE DESCARGA */
                    actualizador frm_actualizador = new actualizador();
                    frm_actualizador.ShowDialog();
                    CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ABRIO E INICIO LA DESCARGA DE LA NUEVA ACTUALIZACION", "oka");

                }
            }
            else
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO UNA NUEVA ACTUALIZACION PARA LA VERSION ACTUAL: '{Properties.Settings.Default.SYS_VERSION}'", "inf");
                // No se encontraron nuevas actualizaciones estables disponibles
                RJMessageBox.Show("¡No se han encontrado nuevas actualizaciones disponibles! ya cuentas con la ultima version disponible", "Gestor de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void buscarActualizacionesBETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UpdaterManager.Update.SearchUpdates(Properties.Settings.Default.SERVER_ROUTE, true, Properties.Settings.Default.SYS_VERSION))
                {
                    //=========[BUSQUEDA DE ACTUALIZACIONES BETA]=========
                    if (Beta_Updates.SearchBETAUpdate() == true)
                    {
                        // Se encontraron nuevas versiones BETA disponibles
                        if (RJMessageBox.Show("¡Se han encontrado nuevas actualizaciones del canal BETA disponibles! ¿Desea instalar la actualizacion?" + Environment.NewLine + Environment.NewLine + "Recuerda que al ser actualizaciones BETA, pueden presentar bugs que se solucionaran en la version final de produccion.", "Gestor de actualizaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            actualizador_beta frm_actualizador = new actualizador_beta();
                            frm_actualizador.ShowDialog();
                            CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ABRIO E INICIO LA DESCARGA DE LA NUEVA ACTUALIZACION", "oka");
                        }
                    }
                    else
                    {
                        // No se encontraron nuevas versiones BETA estables disponibles
                        RJMessageBox.Show("¡No se han encontrado nuevas actualizaciones del canal BETA disponibles! ya cuentas con la ultima version disponible", "Gestor de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE HA PRODUCIDO UN ERROR INESPERADO CON LA CONEXION. EL PROGRAMA INDICA: '{ex.ToString()}'", "exc");

                RJMessageBox.Show("Ha ocurrido un error inesperado de conexion." + Environment.NewLine + Environment.NewLine + "El programa indica:" + Environment.NewLine + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region METODOS PARA LA RECARGA DE LOS FORMULARIOS
        private void recargarSASToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void recargarFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.webView_CompusofForms.CoreWebView2 != null)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE RECARGO LA URL '{URL_FORMS_ACTUAL}' DE 'chromiumWebBrowserRITForms'", "OKA");

                this.webView_CompusofForms.CoreWebView2.Reload();
            }
        }

        // SE RENOMBRO EL CONTROL DEL EVENTO DE SERVICEDESK COMPUSOF => ENDPOINTCENTRAL
        private void recargarManageDeskCompusofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // SE RENOMBRO EL CONTROL DEL EVENTO DE ENDPOINTCENTRAL => SERVICEDESK COMPUSOF
        private void recargarEndpointCentralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.webView_ServiceDeskCompusof.CoreWebView2 != null)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE RECARGO LA URL '{URL_COMPUSOF_SAS_ACTUAL}' DE 'chromiumWebBrowserManageEngineEndPoint'", "OKA");

                this.webView_ServiceDeskCompusof.CoreWebView2.Reload();
            }
        }
        #endregion

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RJMessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"CIERRE DE LA APLICACION", "INF");

                Application.Exit();
            }
        }

        private void sistemaDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventarios frm = new inventarios(this);
            bool openFormsCount = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "inventarios")
                {
                    openFormsCount = true;

                    if (f.WindowState == FormWindowState.Minimized)
                    {
                        f.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        f.BringToFront();
                    }
                }
                else
                {
                    openFormsCount = false;
                }
            }

            if (!openFormsCount)
            {
                CommonMethodsLibrary.OutMessage("out", this.Name, $"SE ABRE EL FORMS DE INVENTARIOS", "INF");
                this.backgroundWorker_WaitScreen.RunWorkerAsync();
                frm.Show();
            }
        }

        private void solicitarRefaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project_selector_form frm = new project_selector_form(this, project_selector_form.ProjectSelectorSenders.REQUEST_SPARE_PARTS);
            frm.Show();

            //solicitar_refaccion frm = new solicitar_refaccion();
            //frm.Show();
        }

        private void solicitarTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitar_toner frm = new solicitar_toner();
            frm.Show();
        }

        private void reportarFallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informar_bug frm = new informar_bug();
            frm.Show();
        }

        private void seleccionarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.backgroundWorker_WaitScreen.RunWorkerAsync();

            lista_usuarios frm = new lista_usuarios(this);
            bool openFormsCount = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "lista_usuarios")
                {
                    openFormsCount = true;

                    if (f.WindowState == FormWindowState.Minimized)
                    {
                        f.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        f.BringToFront();
                    }
                }
                else
                {
                    openFormsCount = false;
                }
            }

            if (!openFormsCount)
            {
                frm.Show();
            }
        }

        private void conectarConSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region CODIGO FUERA DE SERVICIO
            /*
            RJMessageBox.Show("Base de datos deshabilitada por el momento", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            configuracion_inicial frm = new configuracion_inicial();
            frm.Show();
            */

            //try
            //{
            //    string SERVER = "SVRHMOTEST";
            //    string DATA_BASE = "RIT Solver Database";
            //    string USER = "sa";
            //    string PASSWORD = "F3rr0m3x2020";

            //    string cadena1 = $"server={SERVER}; database={DATA_BASE} ; User Id = {USER} ; Password = {PASSWORD} ; integrated security = false";
            //    string cadena2 = $"Data Source = {SERVER}; Initial Catalog = {DATA_BASE}; Integrated Security = False; User Id = {USER} ; Password = {PASSWORD}";


            //    SqlConnection conexion = new SqlConnection(cadena2);
            //    conexion.Open();
            //    RJMessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            //    string query = "SELECT ACTUAL_SERVER_KEY FROM System_Config";

            //    SqlCommand cmd = new SqlCommand(query, conexion);
            //    SqlDataReader rdr = cmd.ExecuteReader();

            //    while (rdr.Read())
            //    {
            //        Console.WriteLine(rdr.GetString(0));
            //    }

            //    rdr.Close();

            //    conexion.Close();
            //    RJMessageBox.Show("Se cerró la conexión.");

            //} catch (Exception ex)
            //{
            //    RJMessageBox.Show(ex.Message);
            //}
            #endregion
        }

        private void imprimirRITEnBlancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RIT_FORMAT_PATH = $@"{Properties.Settings.Default.RITFormPath}";

            PrinterForm frm = new PrinterForm(RIT_FORMAT_PATH, "main_IMPRIMIR RIT EN BLANCO", this);
            frm.ShowDialog();
        }

        private void organigramaDeContactoCompusofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf_viewer frm = new pdf_viewer("organigrama_compusof");
            frm.Show();
        }

        private void escaladoDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf_viewer frm = new pdf_viewer("organigrama_de_escalado");
            frm.Show();

        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            /** PROCESOS A REALIZAR CUANDO SE CIERRE EL PROGRAMA **/
            /* GUARDADO DE CONFIGURACION LOG */
            CommonMethodsLibrary.OutMessage("out", this.Name, $@"ESCRIBIENDO ARCHIVO LOG EN '{Application.StartupPath}\LastExecutionLogFile.log'", "inf");
            CommonMethodsLibrary.OutMessage("out", this.Name, $"CERRANDO LA APLICACION", "INF");

            CommonMethodsLibrary.CreateLogFile();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf_viewer frm = new pdf_viewer("manual_de_usuario");
            frm.Show();
        }


        #region METODOS DE EJECUCION Y GRABADO DE UTILIDADES
        /** HERRAMIENTA PCINFOEXTRACTORTOOL **/
        private void grabarEnCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrimos la aplicacion PCIET localizada en 'tools\'
            string path = $@"{Application.StartupPath}\tools\PCInfoExtractorTool.exe";

            if (File.Exists(path))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(path, $@"{folderBrowserDialog1.SelectedPath}\PCInfoExtractorTool.exe", true);
                    RJMessageBox.Show($@"Herramienta 'PC Info Extractor Tool' guardada con exito en: '{folderBrowserDialog1.SelectedPath}\PCInfoExtractorTool.exe' con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\PCInfoExtractorTool.exe";

            if (File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("in", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }


        /** HERRAMIENTA OMISORA DE COMPROBACION DE ORACLE **/
        private void ejecutarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\Omisor de Comprobacion de Oracle.bat";

            if (File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("in", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }

        private void grabarEnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\Omisor de Comprobacion de Oracle.bat";

            if (File.Exists(path))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(path, $@"{folderBrowserDialog1.SelectedPath}\Omisor de Comprobacion de Oracle.bat", true);
                    RJMessageBox.Show($@"Herramienta 'Omisor de Comprobaciones de Oracle' guardada con exito en: '{folderBrowserDialog1.SelectedPath}\Omisor de Comprobacion de Oracle.bat' con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }


        /** HERRAMIENTA REGISTRO DE LIBRERIAS DE MIITCAT 7 **/
        private void ejecutarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\REGISTRO DE LIBRERIAS DE MIITCAT 7.0.bat";

            if (File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("in", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }

        private void grabarEnCarpetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\REGISTRO DE LIBRERIAS DE MIITCAT 7.0.bat";

            if (File.Exists(path))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(path, $@"{folderBrowserDialog1.SelectedPath}\REGISTRO DE LIBRERIAS DE MIITCAT 7.0.bat", true);
                    RJMessageBox.Show($@"Herramienta 'Registro de Librerias de MiitCat 7' guardada con exito en: '{folderBrowserDialog1.SelectedPath}\REGISTRO DE LIBRERIAS DE MIITCAT 7.0.bat' con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }


        /** HERRAMIENTA CRYSTALDISKINFO **/
        private void ejecutarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\CrystalDiskInfo8_12_12.exe";

            if (File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("in", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }

        private void gtrabrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\tools\CrystalDiskInfo8_12_12.exe";

            if (File.Exists(path))
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(path, $@"{folderBrowserDialog1.SelectedPath}\CrystalDiskInfo8_12_12.exe", true);
                    RJMessageBox.Show($@"Herramienta 'CrystalDiskInfo' guardada con exito en: '{folderBrowserDialog1.SelectedPath}\CrystalDiskInfo8_12_12.exe' con exito!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje de error
                RJMessageBox.Show($"No se encontro el archivo {path}, ejecute la Herramienta de reparacion para intentar solucionar el problema", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CommonMethodsLibrary.OutMessage("out", this.Name, $"NO SE ENCONTRO EL ARCHIVO '{path}'", "err");
            }
        }
        #endregion

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl_Pages.SelectedTab = tabProyectos;
            rit_mdi_form child_form = new rit_mdi_form(this);
            child_form.TopLevel = false;
            //child_form.Parent = MDI_RIT_Panel;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.WindowState = FormWindowState.Maximized;
            child_form.MdiParent = this;
            MDI_RIT_Panel.Controls.Add(child_form);
            actualRitMdiSelected = child_form;


            /*
            treeViewProyectos.SelectedNode = treeViewProyectos.Nodes["nodeMisProyectos"];

            //treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[child_form.Text].Tag = child_form.MDI_ID;
            treeViewProyectos.SelectedNode.Nodes.Add(child_form.MDI_ID.ToString(), child_form.Text);         // POR FACILIDAD SE ASIGNA EL MISMO VALOR DE NOMBRE Y CLAVE
            treeViewProyectos.Nodes["nodeMisProyectos"].Expand();
            treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[child_form.MDI_ID.ToString()].ContextMenuStrip = this.contextMenuStripNodos;
            treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[child_form.MDI_ID.ToString()].ImageIndex = 1;
            treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[child_form.MDI_ID.ToString()].SelectedImageIndex = 1;
            */


            // Mostramos el formulario
            child_form.Show();
            Application.DoEvents();

            mdi_counter++;
            //this.panelComandos.Visible = false;
            _MinimizeAllExceptActualMDIReport();
        }

        private void dHLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waybill_tracking frm = new waybill_tracking(Paqueteria.DHL);
            frm.Show();
        }

        private void paqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waybill_tracking frm = new waybill_tracking(Paqueteria.PAQUETEXPRESS);
            frm.Show();
        }

        private void fedexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waybill_tracking frm = new waybill_tracking(Paqueteria.FEDEX);
            frm.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //this.lblNombreSeccion.Text = this.treeView1.SelectedNode.Text;
        }

        private void toolEliminarProyecto_Click(object sender, EventArgs e)
        {
            // Elimina un proyecto

            /* Procedimento:
             * Por definir, probablemente tambien elimina el archivo si es que tambien existe
             */
            if (node_select != null)
            {
                DialogResult delete_ans = RJMessageBox.Show($"¿Seguro que deseas eliminar de forma permanente el proyecto {node_select.Text}?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete_ans == DialogResult.Yes)
                {
                    // 1. Cerramos le formulario MDI
                    try
                    {
                        int ID = Int32.Parse(this.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[node_select.Name].Name.ToString());
                        //MessageBox.Show(ID.ToString());

                        rit_mdi_form target = new rit_mdi_form(this);

                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Name == "rit_mdi_form")
                            {
                                rit_mdi_form frm = (rit_mdi_form)form;

                                if (frm.MDI_ID == ID)
                                {
                                    target = (rit_mdi_form)form;
                                }
                            }
                        }
                        target.Close();

                        // 2. Eliminamos el archivo PDF (En csao de estar guardado)
                        if (!string.IsNullOrEmpty(target.ActualProject.PdfPath))
                        {
                            try
                            {
                                if (File.Exists(target.ActualProject.PdfPath))
                                {
                                    File.Delete(target.ActualProject.PdfPath);
                                }
                            }
                            catch (Exception ex)
                            {
                                RJMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show(ex.Message);
                    }

                }
            }
        }

        TreeNode node_select;
        public string ACTUAL_PROJ_SELECT = "";

        private void toolCerrarEsteProyecto_Click(object sender, EventArgs e)
        {
            // Cierra la pestañana del proyecto
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Enviar proyecto por correo

        }

        private void treeViewProyectos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }


        private void cerrarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (node_select != null)
            {
                DialogResult delete_ans = RJMessageBox.Show($"¿Estas seguro que deseas cerrar el proyecto '{node_select.Text}' - {node_select.Name} sin guardar antes los cambios?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete_ans == DialogResult.Yes)
                {
                    // 1. Cerramos le formulario MDI
                    try
                    {
                        int ID = Int32.Parse(this.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[node_select.Name].Name.ToString());
                        //MessageBox.Show(ID.ToString());

                        rit_mdi_form target = new rit_mdi_form(this);

                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Name == "rit_mdi_form")
                            {
                                rit_mdi_form frm = (rit_mdi_form)form;

                                if (frm.MDI_ID == ID)
                                {
                                    target = (rit_mdi_form)form;
                                }
                            }
                        }
                        target.Close();
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show(ex.Message);

                    }
                }
            }
        }

        rit_mdi_form actualRitMdiSelected = null;
        public void treeViewProyectos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "rit_mdi_form")
                    {
                        rit_mdi_form formulario = (rit_mdi_form)frm;
                        actualRitMdiSelected = formulario;
                        if (formulario.MDI_ID.ToString() == e.Node.Name)
                        {
                            if (formulario.WindowState == FormWindowState.Minimized)
                            {                               
                                formulario.WindowState = FormWindowState.Maximized;
                                formulario.BringToFront();

                                this.toolLblActualMDIReporteName.Text = formulario.Text;
                            }
                            else
                            {
                                //formulario.WindowState = FormWindowState.Minimized;
                                this.toolLblActualMDIReporteName.Text = formulario.Text;
                                formulario.BringToFront();
                            }

                            _MinimizeAllExceptActualMDIReport();
                        }
                    }
                }
            }
        }

        void _MinimizeAllExceptActualMDIReport()
        {
            #region MINIMIZAMOS TODOS LOS FORMULARIO ABIERTOS, EXCEPTO EL QUE ESTAMOS VISUALIZANDO ACTUALMENTE
            int count = 0;
            foreach (Control c in this.MDI_RIT_Panel.Controls)
            {
                if (c is Form)
                {
                    rit_mdi_form r = (rit_mdi_form)c;
                    if (r.MDI_ID != actualRitMdiSelected.MDI_ID && r.WindowState == FormWindowState.Maximized)
                    {
                        r.WindowState = FormWindowState.Normal;
                        r.WindowState = FormWindowState.Minimized;
                        count++;
                    }
                }
            }
            #endregion
        }

        #region CAMBIO DE DIRECCION URL DE LOS NAVEGADORES
        private void webView_CompusofForms_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            this.URL_RIT_Forms_Label.Text = e.Uri;
        }

        private void webView_ManageEngineEndpointCentral_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            this.URL_SDP_Compusof_Label.Text = e.Uri;
        }
        #endregion

        private void toolCrearActividad_Click(object sender, EventArgs e)
        {
             // Creamos una nueva actividad
            this.Cursor = Cursors.WaitCursor;

            Centro_de_Control.crear_actividad frm = new Centro_de_Control.crear_actividad(this);
            frm.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void toolAbrirActividad_Click(object sender, EventArgs e)
        {
            // Abre una actividad existente
            try
            {
                this.openFileDialog1.Title = "Abrir proyecto de Actividad...";
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.Filter = "Proyecto de Actividad (*.actproj) |*.actproj";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;

                    actividades_mdi_form frm = new actividades_mdi_form(this, openFileDialog1.FileName);
                    frm.TopLevel = false;
                    this.MDI_ACT_Panel.Controls.Add(frm);
                    frm.Show();
                    frm.BringToFront();

                    this.toolLblActualMDIActividadName.Text = frm.Text;
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de abrir el archivo de proyecto! {ex.Message}", $"{Application.ProductName} - Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolEliminarActividad_Click(object sender, EventArgs e)
        {

        }

        private void toolCerrarActividad_Click(object sender, EventArgs e)
        {

        }

        private void toolImportarActividad_Click(object sender, EventArgs e)
        {

        }

        private void toolExportarActividad_Click(object sender, EventArgs e)
        {
            /*
             * Importamos la actividad actualmente seleccionada
             */
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        splash_screen StartScreen;
        private void backgroundWorker_StartScreen_DoWork(object sender, DoWorkEventArgs e)
        {
            StartScreen = new splash_screen();
            StartScreen.Show();
        }

        private void main_Shown(object sender, EventArgs e)
        {
            //StartScreen.Close();
            //this.splashBackground.CancelAsync();

            ////this.Focus();
        }

        public TaskLoadingForm loadingForm;
        private void backgroundWorker_WaitScreen_DoWork(object sender, DoWorkEventArgs e)
        {
            // Cargamos la ventana de carga para un formulario
            loadingForm = new TaskLoadingForm(this, "Leyendo y extrayendo los datos requeridos", "Cargando", false);
            loadingForm.ShowDialog();
        }

        private void toolGeneracionRapidaDeReporte_Click(object sender, EventArgs e)
        {
            // Generacion rapida de Reporte
            string aFallaReportada = Interaction.InputBox("¿Cual es la falla reportada?", "Paso 1");
            string aUsuarioSolicitante = Interaction.InputBox("¿Quien es el usuario solicitante del servicio?", "Paso 2");

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            
        }

        void _LaunchPushNotification()
        {
            
        }

        private void bgworker_RitSolverUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            #region DETECCION DE ACTUALIZACIONES AUTOMATICAS
            string server = Properties.Settings.Default.SERVER_ROUTE;
            bool upFlag = Properties.Settings.Default.SYSDATA_UPDATES_ACTIVATE;
            string actualVersion = Properties.Settings.Default.SYS_VERSION;

            /* BUSQUEDA DE ACTUALIZACIONES DISPONIBLES */

            /* PROCESO
             * EL PROGRAMA PRIMERO BUSCARA:
             * 
             * -> ACTUALIZACIONES DE PRODUCCION
             * -> ACTUALIZACIONES BETA 
             * 
             */
            if (Properties.Settings.Default.SYSDATA_UPDATES_ACTIVATE == true)
            {
                NotifyIcon notifyIcon_StableUpdate = new NotifyIcon();
                notifyIcon_StableUpdate.Visible = true;
                notifyIcon_StableUpdate.Icon = SystemIcons.Question;
                notifyIcon_StableUpdate.BalloonTipTitle = "Asistente de Actualizaciones";
                notifyIcon_StableUpdate.Click += NotifyIconEstableUpdate_Click;
                notifyIcon_StableUpdate.BalloonTipText = "Se ha encontrado una nueva version disponible para instalar en el canal de Produccion! Haz click aqui si la deseas instalar.";

                NotifyIcon notifyIcon_BetaUpdate = new NotifyIcon();
                notifyIcon_BetaUpdate.Visible = true;
                notifyIcon_BetaUpdate.Icon = SystemIcons.Question;
                notifyIcon_BetaUpdate.BalloonTipTitle = "Asistente de Actualizaciones";
                notifyIcon_BetaUpdate.Click += NotifyIconBetaUpdate_Click;
                notifyIcon_BetaUpdate.BalloonTipText = "Se ha encontrado una nueva version BETA disponible para instalar en el canal de Prueba! Haz click aqui si la deseas instalar.";

                NotifyIcon notifyIcon_AlreadyIsUptoDate = new NotifyIcon();
                notifyIcon_AlreadyIsUptoDate.Visible = true;
                notifyIcon_AlreadyIsUptoDate.Icon = SystemIcons.Information;
                notifyIcon_AlreadyIsUptoDate.BalloonTipTitle = "Asistente de Actualizaciones";
                notifyIcon_AlreadyIsUptoDate.BalloonTipText = "No se ha encontrado nuevas versiones disponibles para actualizar! Actualmente ya cuentas con la ultima version.";

                try
                {
                    /*
                     * Actualizaciones en el canal de produccion
                     */
                    CommonMethodsLibrary.OutMessage("out", "main.cs", "BUSCANDO ACTUALIZACIONES EN EL CANAL PRINCIPAL...", "INF");
                    if (UpdaterManager.Update.SearchUpdates(server, upFlag, actualVersion) == true)
                    {
                        if (Properties.Settings.Default.SYSDATA_DESCARGAR_E_INSTALAR_AUTOMATICAMENTE)
                        {
                            actualizador frm_actualizador = new actualizador();
                            frm_actualizador.ShowDialog();
                        }
                        else
                        {
                            notifyIcon_StableUpdate.ShowBalloonTip(30000); // duración en milisegundos
                        }
                    }
                    /*
                     * Actualizaciones en el canal BETA
                     */
                    else if (Properties.Settings.Default.SYSDATA_BETA_UPDATES == true)
                    {
                        CommonMethodsLibrary.OutMessage("out", "main.cs", "BUSCANDO ACTUALIZACIONES EN EL CANAL BETA...", "INF");
                        // =========[ BUSQUEDA DE ACTUALIZACIONES BETA ]=========
                        if (Beta_Updates.SearchBETAUpdate() == true)
                        {
                            if (Properties.Settings.Default.SYSDATA_DESCARGAR_E_INSTALAR_AUTOMATICAMENTE)
                            {
                                actualizador_beta frm_actualizador = new actualizador_beta();
                                frm_actualizador.ShowDialog();
                            }
                            else
                            {
                                notifyIcon_BetaUpdate.ShowBalloonTip(30000);
                            }
                        }
                    }
                    else
                    {
                        CommonMethodsLibrary.OutMessage("out", "main.cs", $"NO SE ENCONTRARON ACTUALIZACIONES MAYORES A LA VERSION {actualVersion}", "INF");
                        notifyIcon_AlreadyIsUptoDate.ShowBalloonTip(15000); // duración en milisegundos
                    }
                }
                catch (Exception ex)
                {
                    //RJMessageBox.Show("Ha ocurrido un error inesperado de conexion." + Environment.NewLine + Environment.NewLine + "El programa indica:" + Environment.NewLine + ex.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NotifyIcon notifyIcon_UpdateSearchFailure = new NotifyIcon();
                    notifyIcon_UpdateSearchFailure.Visible = true;
                    notifyIcon_UpdateSearchFailure.Icon = SystemIcons.Error;
                    notifyIcon_UpdateSearchFailure.BalloonTipTitle = "Asistente de Actualizaciones";
                    notifyIcon_UpdateSearchFailure.BalloonTipText = $"Ocurrio un error inesperado durante la busqueda de actualizaciones! {ex.Message}";
                    notifyIcon_UpdateSearchFailure.ShowBalloonTip(15000);
                }
            }

            /* CINTA DE OPCIONES DE INVENTARIOS
             * 
             * - TODOS FORMAN PARTES DEL MISMO LIBRO PERO DIFERENTES HOJAS
             */

            // Eliminacion de Archivo residual de actualizacion
            try
            {
                //UpdaterManager.Update.DeleteUpdater();
                if (File.Exists(Application.StartupPath + @"\RIT_UpdaterUtility.exe"))
                {
                    File.Delete(Application.StartupPath + @"\RIT_UpdaterUtility.exe");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Gestor de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Eliminacion de Archivo residual de actualizacion BETA
            try
            {
                if (File.Exists($@"{Application.StartupPath}\RIT_BETA_UpdaterUtility.exe"))
                {
                    File.Delete($@"{Application.StartupPath}\RIT_BETA_UpdaterUtility.exe");
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Gestor de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void NotifyIconEstableUpdate_Click(object sender, EventArgs e)
        {
            // Validamos si queremos realizar la instalacion de la actualizacion
            if (RJMessageBox.Show("¡Se han encontrado nuevas actualizaciones disponibles! ¿Desea instalar la actualizacion?", "Gestor de actualizaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /* INICIAR PROCESO DE DESCARGA */
                actualizador frm_actualizador = new actualizador();
                frm_actualizador.ShowDialog();
            }
        }

        private void NotifyIconBetaUpdate_Click(object sender, EventArgs e)
        {
            // Validamos si queremos realizar la instalacion de la actualizacion
            if (RJMessageBox.Show("¡Se han encontrado nuevas actualizaciones BETA disponibles! ¿Desea instalar la actualizacion?\n\nRecuerda que al ser una actualizacion BETA puede contener fallos inesperados.", "Gestor de actualizaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /* INICIAR PROCESO DE DESCARGA */
                actualizador frm_actualizador = new actualizador();
                frm_actualizador.ShowDialog();
            }
        }

        private void bgworker_RitSolverUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("busqueda de updates terminada");
            /* 
             * MOSTRAMOS LA NOTIFICACION DE ACTUALIZACION ENCONTRADAS
             * */
        }

        private void webView_ManageEngineEndpointCentral_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webView_ServiceDeskCompusof.CoreWebView2.Navigate(URL_COMPUSOF_SAS_ACTUAL);
        }

        private void webView_CompusofForms_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webView_CompusofForms.CoreWebView2.Navigate(URL_FORMS_ACTUAL);
        }

        private void panelMDIContainerActividades_ControlAdded(object sender, ControlEventArgs e)
        {
            this.lblCentroControl_Text.Visible = false;
        }

        private void panelMDIContainerActividades_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (this.MDI_ACT_Panel.Controls.Count == 0)
            {
                this.lblCentroControl_Text.Visible = true;
            }

            int formsCounter = 0;
            foreach (Control c in this.MDI_ACT_Panel.Controls)
            {
                if (c is Form)
                {
                    formsCounter++;
                }
            }

            bool aState = false;

            if (formsCounter == 0)
            {
                this.toolLblActualMDIActividadName.Text = "-";
                aState = false;
            }
            else if (formsCounter >= 1)
            {
                aState = true;
            }
        }

        private void nuevaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl_Pages.SelectedTab = tabCentroDeControl;
            this.toolCrearActividad.PerformClick();
        }

        private void importarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl_Pages.SelectedTab = tabCentroDeControl;
            this.toolAbrirActividad.PerformClick();
        }

        private void treeViewCentroDeControl_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodeSeleccionado = this.treeViewCentroDeControl.SelectedNode;
            TreeNode parent = nodeSeleccionado.Parent;

            this.lblNombreNodoSeleccionado.Text = "";
            this.lblDescripcionDeNodo.Text = "";

            if (parent != null)
            {
                this.lblNombreSeccion.Text = parent.Text;
                if (parent.Text == "Actividades")
                {
                    this.lblNombreNodoSeleccionado.Text = nodeSeleccionado.Text;
                    this.lblDescripcionDeNodo.Text = nodeSeleccionado.ToolTipText;
                }
                else if (parent.Text == "Anuncios")
                {

                }
            }
            else
            {
                // Esto porque por logica estamos seleccionando los nodos padre
                this.lblNombreSeccion.Text = nodeSeleccionado.Text;
            }
        }

        actividades_mdi_form _ActualActividadOnTop = null;
        internal actividades_mdi_form ActualActividadOnTop {
            get
            {
                return _ActualActividadOnTop;
            }
            set
            {
                _ActualActividadOnTop = value;
                value.Show();
                value.BringToFront();
                this.toolLblActualMDIActividadName.Text = value.Text;
            }
        }

        private void treeViewCentroDeControl_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodeSeleccionado = e.Node;
            TreeNode parent = nodeSeleccionado.Parent;

            if (parent != null)
            {
                this.toolLblActualMDIActividadName.Text = "-";
                this.lblNombreSeccion.Text = parent.Text;

                if (parent.Text == "Actividades")
                {
                    // Casteamos los controles abiertos actualmente, solo las actividades
                    List<actividades_mdi_form> actividadesAbiertas = new List<actividades_mdi_form>();
                    foreach (Control control in this.MDI_ACT_Panel.Controls)
                    {
                        if (control is actividades_mdi_form)
                        {
                            actividadesAbiertas.Add((actividades_mdi_form)control);
                        }
                    }

                    // Maximizamos o minimizamos el form seleccionado
                    foreach (actividades_mdi_form i in actividadesAbiertas)
                    {
                        if (i.ActualProject._Actividad.HASH == Int32.Parse(nodeSeleccionado.Tag.ToString()))
                        {
                            if (i.WindowState == FormWindowState.Minimized)
                            {
                                i.WindowState = FormWindowState.Maximized;
                                i.BringToFront();

                                ActualActividadOnTop = i;
                                //this.toolLblActualMDIActividadName.Text = i.Text;
                            }
                            else
                            {
                                //i.WindowState = FormWindowState.Maximized;
                                //this.toolLblActualMDIActividadName.Text = i.Text;
                                ActualActividadOnTop = i;
                                i.BringToFront();
                            }
                        }
                    }
                } 
                else if (parent.Text == "Pendientes por hacer")
                {
                    // Casteamos los controles abiertos actualmente, solo las actividades
                    List<pendientes_mdi_form> pendientesAbiertos = new List<pendientes_mdi_form>();
                    foreach (Control control in this.MDI_ACT_Panel.Controls)
                    {
                        if (control is pendientes_mdi_form)
                        {
                            pendientesAbiertos.Add((pendientes_mdi_form)control);
                        }
                    }

                    // Maximizamos o minimizamos el form seleccionado
                    foreach (pendientes_mdi_form i in pendientesAbiertos)
                    {
                        if (i.actualList.HASH == Int32.Parse(nodeSeleccionado.Tag.ToString()))
                        {
                            if (i.WindowState == FormWindowState.Minimized)
                            {
                                i.WindowState = FormWindowState.Maximized;
                                i.BringToFront();

                                //ActualActividadOnTop = i;
                                //this.toolLblActualMDIActividadName.Text = i.Text;
                            }
                            else
                            {
                                //i.WindowState = FormWindowState.Maximized;
                                //this.toolLblActualMDIActividadName.Text = i.Text;
                                //ActualActividadOnTop = i;
                                i.BringToFront();
                            }
                        }
                    }
                }
            }
            else if (nodeSeleccionado.Text == "Seguimiento de Guias")
            {
                bool areOpen = false;
                tabla_seguimiento_guias_mdi_form targetForm = null;

                foreach (Control i in this.MDI_ACT_Panel.Controls)
                {
                    if (i is Form && (Form)i is tabla_seguimiento_guias_mdi_form)
                    {
                        areOpen = true;
                        targetForm = (tabla_seguimiento_guias_mdi_form)i;
                        break;
                    }
                }

                if (areOpen)
                {
                    targetForm.WindowState = FormWindowState.Normal;
                    targetForm.WindowState = FormWindowState.Maximized;
                    targetForm.BringToFront();
                    this.toolLblActualMDIActividadName.Text = targetForm.Text;
                } else
                {
                    tabla_seguimiento_guias_mdi_form frm = new tabla_seguimiento_guias_mdi_form(this);
                    frm.TopLevel = false;
                    this.MDI_ACT_Panel.Controls.Add(frm);
                    frm.Show();
                    frm.BringToFront();
                    this.toolLblActualMDIActividadName.Text = frm.Text;
                }
            } else if (nodeSeleccionado.Text == "Historico de Estadisticas Mensuales")
            {
                bool areOpen = false;
                estadisticas_mensuales targetForm = null;

                foreach (Control i in this.MDI_ACT_Panel.Controls)
                {
                    if (i is Form && (Form)i is estadisticas_mensuales)
                    {
                        areOpen = true;
                        targetForm = (estadisticas_mensuales)i;
                        break;
                    }
                }

                if (areOpen)
                {
                    targetForm.WindowState = FormWindowState.Normal;
                    targetForm.WindowState = FormWindowState.Maximized;
                    targetForm.BringToFront();
                    this.toolLblActualMDIActividadName.Text = targetForm.Text;
                }
                else
                {
                    estadisticas_mensuales frm = new estadisticas_mensuales(this);
                    frm.TopLevel = false;
                    this.MDI_ACT_Panel.Controls.Add(frm);
                    frm.Show();
                    frm.BringToFront();
                    this.toolLblActualMDIActividadName.Text = frm.Text;
                }
            }
        }

        private void ejecutarMacroFuncionWeb1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFuncion1.PerformClick();
        }

        private void ejecutarMacroFuncionWeb2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFuncion2.PerformClick();
        }

        private void ejecutarMacroFuncionWeb3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnFuncion3.PerformClick();
        }

        int totalMdisAbiertos = 0;
        string[] _RitFileNamesQueue = new string[] { "" };
        private void bgworkerMDIsFormsLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            // Procesar los archivos seleccionados
            foreach (string file in _RitFileNamesQueue)
            {
                // Abrir cada archivo en un nuevo MDI hijo
                this.Invoke((MethodInvoker)delegate
                {
                    OpenMdiProject(file);

                    totalMdisAbiertos++;
                    this.bgworkerMDIsFormsLoader.ReportProgress(totalMdisAbiertos);
                });
            }
        }

        private void OpenMdiProject(string filePath)
        {
            /*
            rit_mdi_form child_form = new rit_mdi_form(this, filePath);
            child_form.TopLevel = false;
            child_form.Parent = MDI_RIT_Panel;
            MDI_RIT_Panel.Controls.Add(child_form);
            */

            rit_mdi_form child_form = new rit_mdi_form(this, filePath);
            child_form.TopLevel = false;
            //child_form.Parent = MDI_RIT_Panel;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.WindowState = FormWindowState.Maximized;
            child_form.MdiParent = this;
            MDI_RIT_Panel.Controls.Add(child_form);
            actualRitMdiSelected = child_form;

            // MOSTRAMOS FORM 
            child_form.Show();

            // LA ADICION DE LOS NODOS SE REALIZA EN EL EVENTO LOAD, DEL FORMULARIO MDI
            mdi_counter++;

            _MinimizeAllExceptActualMDIReport();
        }

        private void bgworkerMDIsFormsLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Reestablecemos los valores a 0
            totalMdisAbiertos = 0;
            this.pgrssbarAbrirFormularios.Visible = false;
            _RitFileNamesQueue = new string[] { "" };
        }

        private void bgworkerMDIsFormsLoader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Actualizamos el progreso informado
            this.pgrssbarAbrirFormularios.Value = e.ProgressPercentage;
        }

        private void main_Resize(object sender, EventArgs e)
        {
            /* 
             * Reajustamos los formularios MDI de RITs
             * */
            foreach (Control i in this.MDI_RIT_Panel.Controls)
            {
                if (i is Form)
                {
                    Form frm = (Form)i;

                    if (frm.WindowState == FormWindowState.Maximized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                        frm.WindowState = FormWindowState.Maximized;
                    }
                }
            }

            /*
             * Reajustamos los formularios MDI de Actividades
             * */
            foreach (Control i in this.MDI_ACT_Panel.Controls)
            {
                if (i is Form)
                {
                    Form frm = (Form)i;

                    if (frm.WindowState == FormWindowState.Maximized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                        frm.WindowState = FormWindowState.Maximized;
                    }
                }
            }
        }

        private void toolMinimizarTodosLosReportes_Click(object sender, EventArgs e)
        {
            foreach (Control i in this.MDI_RIT_Panel.Controls)
            {
                if (i is Form)
                {
                    rit_mdi_form frm = (rit_mdi_form)(Form)i;
                    /*
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Minimized;
                    */
                    frm.toolMinimizarReporte.PerformClick();
                }
            }
        }

        private void minimizarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (node_select != null)
            {
                try
                {
                    int ID = Int32.Parse(this.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[node_select.Name].Name.ToString());
                    //MessageBox.Show(ID.ToString());

                    rit_mdi_form target = new rit_mdi_form(this);

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "rit_mdi_form")
                        {
                            rit_mdi_form frm = (rit_mdi_form)form;

                            if (frm.MDI_ID == ID)
                            {
                                target = (rit_mdi_form)form;
                            }
                        }
                    }

                    target.WindowState = FormWindowState.Normal;
                    target.WindowState = FormWindowState.Minimized;
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message);
                }
            }
        }

        private void toolNuevoPendientePorHacer_Click(object sender, EventArgs e)
        {
            string titulo = Interaction.InputBox("Debes ingresar un titulo para la lista de pendientes para poder continuar con la creacion de la misma", "Titulo de la Lista");

            if (!String.IsNullOrEmpty(titulo.Trim())) {
                pendientes_mdi_form frm = new pendientes_mdi_form(this, "", titulo);
                frm.TopLevel = false;
                this.MDI_ACT_Panel.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                frm.BringToFront();
            }

        }

        private void toolImportarListaDePendientes_Click(object sender, EventArgs e)
        {
            // Importa y abre una lista de pendientes existente
            try
            {
                this.openFileDialog1.Title = "Importar lista de Pendientes...";
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.Filter = "Listado de pendientes (*.todolist) |*.todolist";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;

                    pendientes_mdi_form frm = new pendientes_mdi_form(this, openFileDialog1.FileName);
                    frm.TopLevel = false;
                    this.MDI_ACT_Panel.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    frm.BringToFront();

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado a la hora de abrir el archivo de listado de pendientes! {ex.Message}", $"{Application.ProductName} - Error de apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolCerrarListaDePendientes_Click(object sender, EventArgs e)
        {
            // Cerramos la lista de pendientes seleccionada
        }

        private void toolEliminarListaDePendientesPorHacer_Click(object sender, EventArgs e)
        {
            // Eliminamos la lista de pendientes seleccionada
        }

        private void toolStrpBtnCerrarProyectoActual_Click(object sender, EventArgs e)
        {
            if (actualRitMdiSelected != null)
            {
                if (MessageBox.Show($"¿Estas seguro que deseas cerrar el proyecto '{actualRitMdiSelected.txtFallaReportada.Text}' - {actualRitMdiSelected.MDI_ID} sin guardar antes los cambios?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    actualRitMdiSelected.Close();
                }
            }
        }

        private void toolStrpBtnMinimizarTodasLasVentanas_Click(object sender, EventArgs e)
        {
            foreach (Control i in this.MDI_ACT_Panel.Controls)
            {
                if (i is Form)
                {
                    Form frm = (Form)i;
                    frm.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void treeViewProyectos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                this.toolEliminarProyecto.Enabled = true;
                this.toolStrpBtnCerrarProyectoActual.Enabled = true;

                //this.lblNodoDeProyectosSeleccionado.Text = e.Node.Parent.Text;
                this.lblNombreDeNodoSeleccionado.Text = e.Node.Text;

                node_select = e.Node;

                string RIT_STATUS = "";
                string RIT_ATENCION = "";
                string TICKET_GENERADO = "";
                string RIT_IMPRESO = "";
                string RIT_FIRMADO = "";
                string RIT_COMPROBADO = "";

                if (node_select != null)
                {
                    try
                    {
                        int ID = Int32.Parse(this.treeViewProyectos.Nodes["nodeMisProyectos"].Nodes[node_select.Name].Name.ToString());
                        //MessageBox.Show(ID.ToString());

                        rit_mdi_form target = new rit_mdi_form(this);

                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Name == "rit_mdi_form")
                            {
                                rit_mdi_form frm = (rit_mdi_form)form;

                                if (frm.MDI_ID == ID)
                                {
                                    target = (rit_mdi_form)form;
                                }
                            }
                        }

                        if (target.rbtnReporteCerradoSi.Checked)
                        {
                            RIT_STATUS = "RESUELTO";
                        }
                        else
                        {
                            RIT_STATUS = "NO RESUELTO";
                        }

                        TICKET_GENERADO = target.IsAlreadyTicketGenerated.ToString();
                        RIT_IMPRESO = target.IsRitAlreadyPrinted.ToString();
                        RIT_FIRMADO = target.IsRitAlreadySigned.ToString();
                        RIT_COMPROBADO = target.IsRitAlreadyComprobado.ToString();

                        RIT_ATENCION = target.lblFechaDeReporte.Text;
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show(ex.Message);

                    }
                }

                this.lblNombreDeNodoSeleccionado.Text = $@"
{e.Node.Text}
Estado: {RIT_STATUS}
Generado: {RIT_ATENCION}

**** [ VALORES EN BRUTO ] ****
- Ticket en SAS: {TICKET_GENERADO}
- RIT Impreso: {RIT_IMPRESO}
- RIT Firmado: {RIT_FIRMADO}
- RIT Comprobado: {RIT_COMPROBADO}
";
            }
            else
            {
                this.toolEliminarProyecto.Enabled = false;
                this.toolStrpBtnCerrarProyectoActual.Enabled = false;

                this.lblNombreDeNodoSeleccionado.Text = String.Empty;
            }
        }

        private void MDI_RIT_Panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            int formsCounter = 0;
            foreach (Control c in this.MDI_RIT_Panel.Controls)
            {
                if (c is Form)
                {
                    if (c is rit_mdi_form)
                    {
                        formsCounter++;
                    }
                }
            }

            bool aState = false;

            if (formsCounter == 0)
            {
                this.toolLblActualMDIReporteName.Text = "-";
                aState = false;
            } else if (formsCounter >= 1)
            {
                aState = true;
            }

            this.toolStrpBtnGuardarTodosLosProyectosActuales.Enabled = aState;
            this.toolMinimizarTodosLosReportes.Enabled = aState;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Enabled = aState;
        }

        private void MDI_RIT_Panel_ControlAdded(object sender, ControlEventArgs e)
        {
            bool aState = false;
            int formsCounter = 0;
            foreach (Control c in this.MDI_RIT_Panel.Controls)
            {
                if (c is Form)
                {
                    if (c is rit_mdi_form)
                    {
                        formsCounter++;
                    }
                }
            }

            if (formsCounter == 0)
            {
                aState = false;
            }
            else if (formsCounter >= 1)
            {
                aState = true;
            }

            this.toolStrpBtnGuardarTodosLosProyectosActuales.Enabled = aState;
            this.toolMinimizarTodosLosReportes.Enabled = aState;
            this.toolStrpBtnCerrarTodosLosRitsAbiertos.Enabled = aState;
        }

        private void toolStrpBtnGuardarTodosLosProyectosActuales_Click(object sender, EventArgs e)
        {
            foreach (Control i in this.MDI_RIT_Panel.Controls)
            {
                if (i is Form)
                {
                    rit_mdi_form frm = (rit_mdi_form)(Form)i;
                    frm.toolGuardarProyecto.PerformClick();
                }
            }
        }

        private void toolStrpBtnCerrarTodosLosRitsAbiertos_Click(object sender, EventArgs e)
        {
            int totalForms = this.MDI_RIT_Panel.Controls
                                                .Cast<Control>()
                                                .Where(c => c is rit_mdi_form)
                                                .Count();


            int eliminationCount = 0;
            
            eliminationprocess:
            
            foreach (Control i in this.MDI_RIT_Panel.Controls)
            {
                if (i is Form)
                {
                    rit_mdi_form frm = (rit_mdi_form)i;
                    frm.toolStrpBtnCerrarProyecto.PerformClick();
                    eliminationCount++;
                }
            }

            if (totalForms != eliminationCount)
            {
                goto eliminationprocess;
            }
        }

        private void toolStrpBtn_AbrirSegun_Click(object sender, EventArgs e)
        {
            exAbrirSoloSegun frm = new exAbrirSoloSegun();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _RitFileNamesQueue = frm.Response.Cast<RitJsonProject>()
                                                    .Select(r => r.FilePath)
                                                    .ToArray();

                this.pgrssbarAbrirFormularios.Visible = true;
                this.pgrssbarAbrirFormularios.Maximum = _RitFileNamesQueue.Length;
                this.bgworkerMDIsFormsLoader.RunWorkerAsync();
            }
        }

        private void listadoDeHistorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exListadoHistoriales frm = new exListadoHistoriales();
            frm.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que deseas salir del programa?\nNo se grabaran los cambios realizados sin guardar", $"{Application.ProductName} - Confirmacion de Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            } else
            {
                e.Cancel = true;
            }
        }
    }
}