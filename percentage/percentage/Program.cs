using System;
using System.Windows.Forms;

namespace percentage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TrayIcon trayIcon = new TrayIcon();

            if(args!=null)
            {
                if(args.Length == 4){
                    try{
                        trayIcon.setColor(int.Parse(args[0])%256,int.Parse(args[1])%256,int.Parse(args[2])%256,int.Parse(args[3])%256);
                    }
                    catch(Exception e){}
                }else if(args.Length == 5){
                    try{
                        trayIcon.setColor(int.Parse(args[0])%256,int.Parse(args[1])%256,int.Parse(args[2])%256,int.Parse(args[3])%256);
                        trayIcon.setFont(args[4]);
                    }
                    catch(Exception e){}
                        
                }else{

                }
                
            }else{
                
            }


            Application.Run();
        }
    }
}

