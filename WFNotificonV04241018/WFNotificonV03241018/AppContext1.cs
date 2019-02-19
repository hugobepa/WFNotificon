using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://www.codeproject.com/Tips/627796/Doing-a-NotifyIcon-program-the-right-way
//https://stackoverflow.com/questions/44093384/notifyicon-not-responsing-to-changes-in-its-contextmenu

namespace WFNotificonV03241018
{
    class AppContext1 : ApplicationContext
    {

        #region variablesGlobales
            NotifyIcon ni;
            ContextMenuStrip cms;
            ToolStripMenuItem cmi;

            MenuItem mi = new MenuItem();
            Container cp = new Container();
        ContextMenu cm = new ContextMenu();
        logs lg = new logs();

        #endregion

        #region Constructor
             public AppContext1()
             {
                // crear un evento en aplicacion
                //evento de cerrar y apagar App
                Application.ApplicationExit += new EventHandler(this.Cerrar);
            //Inicilizar Estructura del WF
            Inicio();
                ni.Visible = true;
            }


        #endregion

        #region Inicio

            private void Inicio()
            {
                //inicilizar Notifyicon
                ni = new NotifyIcon();


                //minimo Funciona
                ni.Icon = Properties.Resources.info2;
                //Texto ayuda de Icono
                ni.Text = "AppContext1- un notifyIcon de verdad";

            

            //Mostrar pantalla Presentacion
            ni.Visible = true;
            ni.ShowBalloonTip(5, "Welcome", "Hello Usuario" , ToolTipIcon.Info);
          

            //Cuando marcamos 1 click -aparace pantalla
            ni.Click += new EventHandler(ni_m1Clk);

            CrearOpciones();
            ni.ContextMenu = cm;




        }


        #endregion


        #region accio2CL

               

        #endregion


        #region Cerrar
        private void Cerrar(object sender, EventArgs e)
        {
            ni.Visible = false;
            Application.Exit();
        }
        #endregion

        #region BalloonTIPV2

        //apaarcePantalla
        private void ni_m1Clk(object sender, EventArgs e)
        {
            
            ni.Icon = SystemIcons.Exclamation; //SystemIcons.Exclamation;
            ni.BalloonTipIcon = ToolTipIcon.Error;
            ni.BalloonTipText = "Haz un doble click sobre Mi";
            ni.BalloonTipTitle = "AppContext1";
            //prueba
           
            
            
           
            ni.ContextMenu = cm;
            
            

            ni.Visible = true;
            ni.ShowBalloonTip(500);

        }

        private void Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (MessageBox.Show("Do you really want to close me?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        public void CrearOpciones()
        {
            cm.MenuItems.Add(new MenuItem("First", Click));
            cm.MenuItems.Add(new MenuItem("Second", Click));
            cm.MenuItems.Add(new MenuItem("Third", Click));

        }

        #endregion

    }
}
