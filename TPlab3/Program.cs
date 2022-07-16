using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ChannelFactory<ConverterLibrary.IConverter> factory = new ChannelFactory<ConverterLibrary.IConverter>("converterTCP");
            ConverterLibrary.IConverter converterService = factory.CreateChannel();

            // ChannelFactory<ConverterLibrary.IConverter> factory = new ChannelFactory<ConverterLibrary.IConverter>("converterHTTP");
            //ConverterLibrary.IConverter converterService = factory.CreateChannel();


            Application.Run(new Form1(converterService));
        }
    }
}
