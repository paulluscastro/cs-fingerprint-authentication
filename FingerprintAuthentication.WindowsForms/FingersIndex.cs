using System;
using System.Drawing;
using System.IO;
using NITGEN.SDK.NBioBSP;
using static NITGEN.SDK.NBioBSP.NBioAPI;
using static NITGEN.SDK.NBioBSP.NBioAPI.Type;

namespace FingerprintAuthentication.WindowsForms
{
    public class FingersIndex
    {
        private static string filePath = @"C:\temp\P21\20181126 - eNBioBSP\db.isdb";
        private static FingersIndex instance = null;
        private IndexSearch index;
        public NBioAPI Api { get; private set; }
        public WINDOW_OPTION WindowOptions { get; set; }
        public Color ForeColor { get; set; }
        public Color BackgroundColor { get; set; }

        public static FingersIndex GetInstance() => instance == null ? instance = new FingersIndex() : instance;
        private void CheckError(uint ret, string message)
        {
            if (ret != Error.NONE)
                throw new Exception($"[{ret}] {message} - {Error.GetErrorDescription(ret)}");
        }
        private void LoadDB()
        {
            // Load SearchDB from File
            if (File.Exists(filePath))
                CheckError(index.LoadDBFromFile(filePath), "Erro ao carregar banco de dados.");
        }
        private void saveDB()
        {
            CheckError(index.SaveDBToFile(filePath), "Erro ao salvar banco de dados.");
        }
        private FingersIndex()
        {
            Api = new NBioAPI();
            index = new IndexSearch(Api);
            index.ClearDB();
            LoadDB();
        }
        public HFIR CaptureFinger(uint id, Action initializeDevice, Action success)
        {
            HFIR capturedFir;
            initializeDevice();
            Api.OpenDevice(DEVICE_ID.AUTO);
            Api.Enroll(null, out capturedFir, null, TIMEOUT.DEFAULT, null, WindowOptions);
            Api.CloseDevice(DEVICE_ID.AUTO);

            IndexSearch.FP_INFO[] fpInfo;
            CheckError(index.AddFIR(capturedFir, id, out fpInfo), "Erro ao capturar dedo");
            saveDB();
            success();
            return capturedFir;
        }
    }
}
