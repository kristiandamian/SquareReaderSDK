using System;
using Foundation;
using ObjCRuntime;
using SquareReaderSDK;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDErrorDebugCodeKey;
	[Field ("SQRDErrorDebugCodeKey")]
	unsafe int* SQRDErrorDebugCodeKey { get; }

	// extern int *const _Nonnull SQRDErrorDebugMessageKey;
	[Field ("SQRDErrorDebugMessageKey")]
	unsafe int* SQRDErrorDebugMessageKey { get; }
}

// typedef void (^SQRDAuthorizationHandler)(SQRDLocation * _Nullable, int * _Nullable);
unsafe delegate void SQRDAuthorizationHandler ([NullAllowed] SQRDLocation arg0, [NullAllowed] int* arg1);

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDAuthorizationErrorDomain;
	[Field ("SQRDAuthorizationErrorDomain")]
	unsafe int* SQRDAuthorizationErrorDomain { get; }
}

// typedef void (^SQRDDeauthorizationHandler)(int * _Nullable);
unsafe delegate void SQRDDeauthorizationHandler ([NullAllowed] int* arg0);

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDDeauthorizationErrorDomain;
	[Field ("SQRDDeauthorizationErrorDomain")]
	unsafe int* SQRDDeauthorizationErrorDomain { get; }
}

// @interface SQRDReaderSDK
interface SQRDReaderSDK
{
	// +(void)initializeWithApplicationLaunchOptions:(id)launchOptions;
	[Static]
	[Export ("initializeWithApplicationLaunchOptions:")]
	void InitializeWithApplicationLaunchOptions (NSObject launchOptions);

	// @property (readonly, strong, class) SQRDReaderSDK * _Nonnull sharedSDK;
	[Static]
	[Export ("sharedSDK", ArgumentSemantic.Strong)]
	SQRDReaderSDK SharedSDK { get; }

	// @property (readonly, nonatomic, strong) SQRDLocation * _Nullable authorizedLocation;
	[NullAllowed, Export ("authorizedLocation", ArgumentSemantic.Strong)]
	SQRDLocation AuthorizedLocation { get; }

	// -(void)authorizeWithCode:(id)code completionHandler:(SQRDAuthorizationHandler _Nonnull)completionHandler;
	[Export ("authorizeWithCode:completionHandler:")]
	void AuthorizeWithCode (NSObject code, SQRDAuthorizationHandler completionHandler);

	// @property (readonly, nonatomic) int isAuthorized;
	[Export ("isAuthorized")]
	int IsAuthorized { get; }

	// @property (readonly, nonatomic) int isAuthorizationInProgress;
	[Export ("isAuthorizationInProgress")]
	int IsAuthorizationInProgress { get; }

	// -(void)deauthorizeWithCompletionHandler:(SQRDDeauthorizationHandler _Nonnull)completionHandler;
	[Export ("deauthorizeWithCompletionHandler:")]
	void DeauthorizeWithCompletionHandler (SQRDDeauthorizationHandler completionHandler);

	// @property (readonly, nonatomic) int canDeauthorize;
	[Export ("canDeauthorize")]
	int CanDeauthorize { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDReaderSDK New ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDReaderSettingsControllerErrorDomain;
	[Field ("SQRDReaderSettingsControllerErrorDomain")]
	unsafe int* SQRDReaderSettingsControllerErrorDomain { get; }
}

// @protocol SQRDReaderSettingsControllerDelegate
[Protocol, Model]
interface SQRDReaderSettingsControllerDelegate
{
	// @required -(void)readerSettingsControllerDidPresent:(SQRDReaderSettingsController * _Nonnull)readerSettingsController;
	[Abstract]
	[Export ("readerSettingsControllerDidPresent:")]
	void ReaderSettingsControllerDidPresent (SQRDReaderSettingsController readerSettingsController);

	// @required -(void)readerSettingsController:(SQRDReaderSettingsController * _Nonnull)readerSettingsController didFailToPresentWithError:(id)error;
	[Abstract]
	[Export ("readerSettingsController:didFailToPresentWithError:")]
	void ReaderSettingsController (SQRDReaderSettingsController readerSettingsController, NSObject error);
}

// @interface SQRDReaderSettingsController
interface SQRDReaderSettingsController
{
	// -(instancetype _Nonnull)initWithDelegate:(id<SQRDReaderSettingsControllerDelegate> _Nonnull)delegate;
	[Export ("initWithDelegate:")]
	IntPtr Constructor (SQRDReaderSettingsControllerDelegate @delegate);

	// -(void)presentFromViewController:(id)viewController;
	[Export ("presentFromViewController:")]
	void PresentFromViewController (NSObject viewController);

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDReaderSettingsController New ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDStoreCustomerCardControllerErrorDomain;
	[Field ("SQRDStoreCustomerCardControllerErrorDomain")]
	unsafe int* SQRDStoreCustomerCardControllerErrorDomain { get; }
}

// @protocol SQRDStoreCustomerCardControllerDelegate
[Protocol, Model]
interface SQRDStoreCustomerCardControllerDelegate
{
	// @required -(void)storeCustomerCardController:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController didFinishWithCard:(SQRDCard * _Nonnull)card;
	[Abstract]
	[Export ("storeCustomerCardController:didFinishWithCard:")]
	void StoreCustomerCardController (SQRDStoreCustomerCardController storeCustomerCardController, SQRDCard card);

	// @required -(void)storeCustomerCardController:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController didFailWithError:(id)error;
	[Abstract]
	[Export ("storeCustomerCardController:didFailWithError:")]
	void StoreCustomerCardController (SQRDStoreCustomerCardController storeCustomerCardController, NSObject error);

	// @required -(void)storeCustomerCardControllerDidCancel:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController;
	[Abstract]
	[Export ("storeCustomerCardControllerDidCancel:")]
	void StoreCustomerCardControllerDidCancel (SQRDStoreCustomerCardController storeCustomerCardController);
}

// @interface SQRDStoreCustomerCardController
interface SQRDStoreCustomerCardController
{
	// -(instancetype _Nonnull)initWithCustomerID:(id)customerID delegate:(id<SQRDStoreCustomerCardControllerDelegate> _Nonnull)delegate;
	[Export ("initWithCustomerID:delegate:")]
	IntPtr Constructor (NSObject customerID, SQRDStoreCustomerCardControllerDelegate @delegate);

	// -(void)presentFromViewController:(id)viewController;
	[Export ("presentFromViewController:")]
	void PresentFromViewController (NSObject viewController);

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDStoreCustomerCardController New ();
}

// @interface SQRDCard
interface SQRDCard
{
	// @property (readonly, nonatomic) int brand;
	[Export ("brand")]
	int Brand { get; }

	// @property (readonly, nonatomic) int * _Nonnull lastFourDigits;
	[Export ("lastFourDigits")]
	unsafe int* LastFourDigits { get; }

	// @property (readonly, nonatomic) int * _Nullable expirationMonth;
	[NullAllowed, Export ("expirationMonth")]
	unsafe int* ExpirationMonth { get; }

	// @property (readonly, nonatomic) int * _Nullable expirationYear;
	[NullAllowed, Export ("expirationYear")]
	unsafe int* ExpirationYear { get; }

	// @property (readonly, nonatomic) int * _Nullable cardID;
	[NullAllowed, Export ("cardID")]
	unsafe int* CardID { get; }

	// @property (readonly, nonatomic) int * _Nullable cardholderName;
	[NullAllowed, Export ("cardholderName")]
	unsafe int* CardholderName { get; }

	// -(id)isEqual:(SQRDCard * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDCard @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDCard New ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern int *const _Nonnull SQRDCheckoutControllerErrorDomain;
	[Field ("SQRDCheckoutControllerErrorDomain")]
	unsafe int* SQRDCheckoutControllerErrorDomain { get; }
}

// @protocol SQRDCheckoutControllerDelegate
[Protocol, Model]
interface SQRDCheckoutControllerDelegate
{
	// @required -(void)checkoutController:(SQRDCheckoutController * _Nonnull)checkoutController didFinishCheckoutWithResult:(SQRDCheckoutResult * _Nonnull)result;
	[Abstract]
	[Export ("checkoutController:didFinishCheckoutWithResult:")]
	void CheckoutController (SQRDCheckoutController checkoutController, SQRDCheckoutResult result);

	// @required -(void)checkoutController:(SQRDCheckoutController * _Nonnull)checkoutController didFailWithError:(id)error;
	[Abstract]
	[Export ("checkoutController:didFailWithError:")]
	void CheckoutController (SQRDCheckoutController checkoutController, NSObject error);

	// @required -(void)checkoutControllerDidCancel:(SQRDCheckoutController * _Nonnull)checkoutController;
	[Abstract]
	[Export ("checkoutControllerDidCancel:")]
	void CheckoutControllerDidCancel (SQRDCheckoutController checkoutController);
}

// @interface SQRDCheckoutController
interface SQRDCheckoutController
{
	// -(instancetype _Nonnull)initWithParameters:(SQRDCheckoutParameters * _Nonnull)parameters delegate:(id<SQRDCheckoutControllerDelegate> _Nonnull)delegate;
	[Export ("initWithParameters:delegate:")]
	IntPtr Constructor (SQRDCheckoutParameters parameters, SQRDCheckoutControllerDelegate @delegate);

	// -(void)presentFromViewController:(id)viewController;
	[Export ("presentFromViewController:")]
	void PresentFromViewController (NSObject viewController);

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDCheckoutController New ();
}

// @interface SQRDLocation
interface SQRDLocation
{
	// @property (readonly, nonatomic, strong) int * _Nonnull locationID;
	[Export ("locationID", ArgumentSemantic.Strong)]
	unsafe int* LocationID { get; }

	// @property (readonly, nonatomic, strong) int * _Nonnull name;
	[Export ("name", ArgumentSemantic.Strong)]
	unsafe int* Name { get; }

	// @property (readonly, nonatomic, strong) int * _Nonnull businessName;
	[Export ("businessName", ArgumentSemantic.Strong)]
	unsafe int* BusinessName { get; }

	// @property (readonly, nonatomic) int isCardProcessingActivated;
	[Export ("isCardProcessingActivated")]
	int IsCardProcessingActivated { get; }

	// @property (readonly, nonatomic, strong) SQRDMoney * _Nonnull minimumCardPaymentAmountMoney;
	[Export ("minimumCardPaymentAmountMoney", ArgumentSemantic.Strong)]
	SQRDMoney MinimumCardPaymentAmountMoney { get; }

	// @property (readonly, nonatomic, strong) SQRDMoney * _Nonnull maximumCardPaymentAmountMoney;
	[Export ("maximumCardPaymentAmountMoney", ArgumentSemantic.Strong)]
	SQRDMoney MaximumCardPaymentAmountMoney { get; }

	// @property (readonly, nonatomic) int currencyCode;
	[Export ("currencyCode")]
	int CurrencyCode { get; }

	// -(id)isEqual:(SQRDMoney * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDMoney @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDLocation New ();
}

// @interface SQRDMoney
interface SQRDMoney
{
	// -(instancetype _Nonnull)initWithAmount:(id)amount;
	[Export ("initWithAmount:")]
	IntPtr Constructor (NSObject amount);

	// -(instancetype _Nonnull)initWithAmount:(id)amount currencyCode:(id)currencyCode;
	[Export ("initWithAmount:currencyCode:")]
	IntPtr Constructor (NSObject amount, NSObject currencyCode);

	// @property (readonly, nonatomic) int amount;
	[Export ("amount")]
	int Amount { get; }

	// @property (readonly, nonatomic) int currencyCode;
	[Export ("currencyCode")]
	int CurrencyCode { get; }

	// -(id)isEqual:(SQRDMoney * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDMoney @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDMoney New ();
}

// @interface SQRDTender
interface SQRDTender
{
	// @property (readonly, nonatomic) int * _Nullable tenderID;
	[NullAllowed, Export ("tenderID")]
	unsafe int* TenderID { get; }

	// @property (readonly, nonatomic) int * _Nonnull createdAt;
	[Export ("createdAt")]
	unsafe int* CreatedAt { get; }

	// @property (readonly, nonatomic) int type;
	[Export ("type")]
	int Type { get; }

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull totalMoney;
	[Export ("totalMoney")]
	SQRDMoney TotalMoney { get; }

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull tipMoney;
	[Export ("tipMoney")]
	SQRDMoney TipMoney { get; }

	// @property (readonly, nonatomic) SQRDTenderCardDetails * _Nullable cardDetails;
	[NullAllowed, Export ("cardDetails")]
	SQRDTenderCardDetails CardDetails { get; }

	// @property (readonly, nonatomic) SQRDTenderCashDetails * _Nullable cashDetails;
	[NullAllowed, Export ("cashDetails")]
	SQRDTenderCashDetails CashDetails { get; }

	// -(id)isEqual:(SQRDTender * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDTender @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDTender New ();
}

// @interface SQRDTenderCardDetails
interface SQRDTenderCardDetails
{
	// @property (readonly, nonatomic) SQRDCard * _Nonnull card;
	[Export ("card")]
	SQRDCard Card { get; }

	// @property (readonly, nonatomic) int entryMethod;
	[Export ("entryMethod")]
	int EntryMethod { get; }

	// -(id)isEqual:(SQRDTenderCardDetails * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDTenderCardDetails @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDTenderCardDetails New ();
}

// @interface SQRDTenderCashDetails
interface SQRDTenderCashDetails
{
	// @property (readonly, nonatomic) SQRDMoney * _Nonnull buyerTenderedMoney;
	[Export ("buyerTenderedMoney")]
	SQRDMoney BuyerTenderedMoney { get; }

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull changeBackMoney;
	[Export ("changeBackMoney")]
	SQRDMoney ChangeBackMoney { get; }

	// -(id)isEqual:(SQRDTenderCashDetails * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDTenderCashDetails @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDTenderCashDetails New ();
}

// @interface SQRDTipSettings
interface SQRDTipSettings
{
	// @property (assign, nonatomic) int showSeparateTipScreen;
	[Export ("showSeparateTipScreen")]
	int ShowSeparateTipScreen { get; set; }

	// @property (assign, nonatomic) int showCustomTipField;
	[Export ("showCustomTipField")]
	int ShowCustomTipField { get; set; }

	// -(id)isEqual:(SQRDTipSettings * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDTipSettings @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }
}

// @interface SQRDCheckoutParameters
interface SQRDCheckoutParameters
{
	// -(instancetype _Nonnull)initWithAmountMoney:(SQRDMoney * _Nonnull)amountMoney;
	[Export ("initWithAmountMoney:")]
	IntPtr Constructor (SQRDMoney amountMoney);

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull amountMoney;
	[Export ("amountMoney")]
	SQRDMoney AmountMoney { get; }

	// @property (copy, nonatomic) int * _Nullable note;
	[NullAllowed, Export ("note", ArgumentSemantic.Copy)]
	unsafe int* Note { get; set; }

	// @property (assign, nonatomic) int additionalPaymentTypes;
	[Export ("additionalPaymentTypes")]
	int AdditionalPaymentTypes { get; set; }

	// @property (copy, nonatomic) SQRDTipSettings * _Nullable tipSettings;
	[NullAllowed, Export ("tipSettings", ArgumentSemantic.Copy)]
	SQRDTipSettings TipSettings { get; set; }

	// @property (assign, nonatomic) int skipReceipt;
	[Export ("skipReceipt")]
	int SkipReceipt { get; set; }

	// @property (assign, nonatomic) int collectSignature;
	[Export ("collectSignature")]
	int CollectSignature { get; set; }

	// @property (assign, nonatomic) int allowSplitTender;
	[Export ("allowSplitTender")]
	int AllowSplitTender { get; set; }

	// @property (assign, nonatomic) int alwaysRequireSignature;
	[Export ("alwaysRequireSignature")]
	int AlwaysRequireSignature { get; set; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDCheckoutParameters New ();
}

// @interface SQRDCheckoutResult
interface SQRDCheckoutResult
{
	// @property (readonly, nonatomic) int * _Nullable transactionID;
	[NullAllowed, Export ("transactionID")]
	unsafe int* TransactionID { get; }

	// @property (readonly, nonatomic) int * _Nonnull transactionClientID;
	[Export ("transactionClientID")]
	unsafe int* TransactionClientID { get; }

	// @property (readonly, nonatomic) int * _Nonnull locationID;
	[Export ("locationID")]
	unsafe int* LocationID { get; }

	// @property (readonly, nonatomic) int * _Nonnull createdAt;
	[Export ("createdAt")]
	unsafe int* CreatedAt { get; }

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull totalMoney;
	[Export ("totalMoney")]
	SQRDMoney TotalMoney { get; }

	// @property (readonly, nonatomic) SQRDMoney * _Nonnull totalTipMoney;
	[Export ("totalTipMoney")]
	SQRDMoney TotalTipMoney { get; }

	// -(id)isEqual:(SQRDCheckoutResult * _Nullable)object;
	[Export ("isEqual:")]
	NSObject IsEqual ([NullAllowed] SQRDCheckoutResult @object);

	// @property (readonly) int hash;
	[Export ("hash")]
	int Hash { get; }

	// +(instancetype _Nonnull)new;
	[Static]
	[Export ("new")]
	SQRDCheckoutResult New ();
}
