using System;
namespace ZXing.Net.Mobile.Core
{
	public interface IScannerSessionHost
	{
		MobileBarcodeScanningOptions ScanningOptions { get; }
	}
}
