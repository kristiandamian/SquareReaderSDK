using System.Runtime.InteropServices;

public enum SQRDAuthorizationError
{
	UsageError = 1,
	NoNetworkConnection
}

public enum SQRDDeauthorizationError
{
	SQRDDeauthorizationErrorUsageError = 1
}

public enum SQRDReaderSettingsControllerError
{
	UsageError = 1,
	SDKNotAuthorized
}

public enum SQRDStoreCustomerCardControllerError
{
	UsageError = 1,
	NoNetworkConnection,
	SDKNotAuthorized,
	InvalidCustomerID
}

static class CFunctions
{
	// extern int NS_ENUM (int NSInteger, int SQRDCardBrand);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int NS_ENUM (int NSInteger, int SQRDCardBrand);

	// extern int NS_ENUM (int NSUInteger, int SQRDCurrencyCode);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int NS_ENUM (int NSUInteger, int SQRDCurrencyCode);

	// extern int NS_ENUM (int NSInteger, int SQRDTenderType);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int NS_ENUM (int NSInteger, int SQRDTenderType);

	// extern int NS_ENUM (int NSInteger, int SQRDTenderCardDetailsEntryMethod);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int NS_ENUM (int NSInteger, int SQRDTenderCardDetailsEntryMethod);

	// extern int NS_OPTIONS (int NSUInteger, int SQRDAdditionalPaymentTypes);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int NS_OPTIONS (int NSUInteger, int SQRDAdditionalPaymentTypes);

	// extern int DEPRECATED_MSG_ATTRIBUTE ();
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern int DEPRECATED_MSG_ATTRIBUTE ();
}

public enum SQRDCheckoutControllerError
{
	UsageError = 1,
	SDKNotAuthorized
}
