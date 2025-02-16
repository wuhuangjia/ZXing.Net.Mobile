using System;

using UIKit;
using ZXing.Net.Mobile.Core;

namespace ZXing.Net.Mobile.iOS
{
	public interface IScannerViewController
	{
		void Torch(bool on);

		void ToggleTorch();
		void Cancel();

		bool IsTorchOn { get; }
        bool ContinuousScanning { get;set; }

        void PauseAnalysis ();
        void ResumeAnalysis ();

		event Action<ZXing.Result> OnScannedResult;

		MobileBarcodeScanningOptions ScanningOptions { get;set; }
		MobileBarcodeScanner Scanner { get;set; }

		UIViewController AsViewController();
	}
}

