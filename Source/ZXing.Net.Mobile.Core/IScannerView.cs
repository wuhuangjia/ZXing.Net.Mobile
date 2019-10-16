﻿using System;

namespace ZXing.Net.Mobile.Core
{
    public interface IScannerView
    {        
        void StartScanning (Action<Result> scanResultHandler, MobileBarcodeScanningOptions options = null);
        void StopScanning ();

        void PauseAnalysis();
        void ResumeAnalysis();

        void Torch(bool on);
        void AutoFocus();
        void AutoFocus(int x, int y);
        void ToggleTorch();
        bool IsTorchOn { get; }
        bool IsAnalyzing { get; }

        bool HasTorch { get; }
    }
}

