using System;
using System.Drawing;
using System.IO;
using NITGEN.SDK.NBioBSP;
using static NITGEN.SDK.NBioBSP.NBioAPI;
using static NITGEN.SDK.NBioBSP.NBioAPI.Type;

namespace FingerprintAuthentication.WindowsForms
{
    public class FingerCapturer
    {
        private static FingerCapturer instance = null;
        public NBioAPI Api { get; private set; }
        public WINDOW_OPTION WindowOptions { get; set; }
        public Color ForeColor { get; set; }
        public Color BackgroundColor { get; set; }

        public static FingerCapturer GetInstance() => instance == null ? instance = new FingerCapturer() : instance;
        private void CheckError(uint ret, string message)
        {
            if (ret != Error.NONE)
                throw new Exception($"[{ret}] {message} - {Error.GetErrorDescription(ret)}");
        }
        private FingerCapturer()
        {
            Api = new NBioAPI();
            WindowOptions = new WINDOW_OPTION();
            WindowOptions.Option2 = new WINDOW_OPTION_2();
        }
        public string CaptureFinger(uint id, Action initializeDevice)
        {
            HFIR capturedFir;
            initializeDevice();
            Api.OpenDevice(DEVICE_ID.AUTO);
            Api.Capture(out capturedFir, TIMEOUT.DEFAULT, WindowOptions);
            Api.CloseDevice(DEVICE_ID.AUTO);
            FIR_TEXTENCODE textEncode;
            CheckError(Api.GetTextFIRFromHandle(capturedFir, out textEncode, true), "Erro ao obter dados do dedo");
            return textEncode.TextFIR;
        }
        public string CaptureToVerify(Action initializeDevice)
        {
            HFIR capturedFir;
            initializeDevice();
            Api.OpenDevice(DEVICE_ID.AUTO);
            Api.Capture(out capturedFir, TIMEOUT.DEFAULT, WindowOptions);
            Api.CloseDevice(DEVICE_ID.AUTO);
            FIR_TEXTENCODE textEncode;
            CheckError(Api.GetTextFIRFromHandle(capturedFir, out textEncode, true), "Erro ao obter dados do dedo");
            return textEncode.TextFIR;
        }
    }
}
