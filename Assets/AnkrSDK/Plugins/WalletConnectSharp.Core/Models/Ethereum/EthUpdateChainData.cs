namespace AnkrSDK.WalletConnectSharp.Core.Models.Ethereum
{
	public class EthUpdateChainData : EthChain
	{
		public string chainName;
		public string rpcUrl;
		public NativeCurrency nativeCurrency;
		public string blockExplorerUrl;
	}
}