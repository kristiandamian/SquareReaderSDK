using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SquareBinding
{
    [Static]
    ////[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDErrorDebugCodeKey;
        [Field("SQRDErrorDebugCodeKey", "__Internal")]
        NSString SQRDErrorDebugCodeKey { get; }

        // extern NSString *const _Nonnull SQRDErrorDebugMessageKey;
        [Field("SQRDErrorDebugMessageKey", "__Internal")]
        NSString SQRDErrorDebugMessageKey { get; }
    }

    // typedef void (^SQRDAuthorizationHandler)(SQRDLocation * _Nullable, NSError * _Nullable);
    delegate void SQRDAuthorizationHandler([NullAllowed] SQRDLocation arg0, [NullAllowed] NSError arg1);

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDAuthorizationErrorDomain;
        [Field("SQRDAuthorizationErrorDomain", "__Internal")]
        NSString SQRDAuthorizationErrorDomain { get; }
    }

    // typedef void (^SQRDDeauthorizationHandler)(NSError * _Nullable);
    delegate void SQRDDeauthorizationHandler([NullAllowed] NSError arg0);

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDDeauthorizationErrorDomain;
        [Field("SQRDDeauthorizationErrorDomain", "__Internal")]
        NSString SQRDDeauthorizationErrorDomain { get; }
    }

    // @interface SQRDReaderSDK : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDReaderSDK
    {
        // +(void)initializeWithApplicationLaunchOptions:(NSDictionary<UIApplicationLaunchOptionsKey,id> * _Nullable)launchOptions;
        [Static]
        [Export("initializeWithApplicationLaunchOptions:")]
        void InitializeWithApplicationLaunchOptions([NullAllowed] NSDictionary<NSString, NSObject> launchOptions);

        // @property (readonly, strong, class) SQRDReaderSDK * _Nonnull sharedSDK;
        [Static]
        [Export("sharedSDK", ArgumentSemantic.Strong)]
        SQRDReaderSDK SharedSDK { get; }

        // @property (readonly, nonatomic, strong) SQRDLocation * _Nullable authorizedLocation;
        [NullAllowed, Export("authorizedLocation", ArgumentSemantic.Strong)]
        SQRDLocation AuthorizedLocation { get; }

        // -(void)authorizeWithCode:(NSString * _Nonnull)code completionHandler:(SQRDAuthorizationHandler _Nonnull)completionHandler;
        [Export("authorizeWithCode:completionHandler:")]
        void AuthorizeWithCode(string code, SQRDAuthorizationHandler completionHandler);

        // @property (readonly, nonatomic) BOOL isAuthorized;
        [Export("isAuthorized")]
        bool IsAuthorized { get; }

        // @property (readonly, nonatomic) BOOL isAuthorizationInProgress;
        [Export("isAuthorizationInProgress")]
        bool IsAuthorizationInProgress { get; }

        // -(void)deauthorizeWithCompletionHandler:(SQRDDeauthorizationHandler _Nonnull)completionHandler;
        [Export("deauthorizeWithCompletionHandler:")]
        void DeauthorizeWithCompletionHandler(SQRDDeauthorizationHandler completionHandler);

        // @property (readonly, nonatomic) BOOL canDeauthorize;
        [Export("canDeauthorize")]
        bool CanDeauthorize { get; }
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDReaderSettingsControllerErrorDomain;
        [Field("SQRDReaderSettingsControllerErrorDomain", "__Internal")]
        NSString SQRDReaderSettingsControllerErrorDomain { get; }
    }

    // @protocol SQRDReaderSettingsControllerDelegate
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface SQRDReaderSettingsControllerDelegate
    {
        // @required -(void)readerSettingsControllerDidPresent:(SQRDReaderSettingsController * _Nonnull)readerSettingsController;
        [Abstract]
        [Export("readerSettingsControllerDidPresent:")]
        void ReaderSettingsControllerDidPresent(SQRDReaderSettingsController readerSettingsController);

        // @required -(void)readerSettingsController:(SQRDReaderSettingsController * _Nonnull)readerSettingsController didFailToPresentWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("readerSettingsController:didFailToPresentWithError:")]
        void ReaderSettingsController(SQRDReaderSettingsController readerSettingsController, NSError error);
    }

    // @interface SQRDReaderSettingsController : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDReaderSettingsController
    {
        // -(instancetype _Nonnull)initWithDelegate:(id<SQRDReaderSettingsControllerDelegate> _Nonnull)delegate;
        [Export("initWithDelegate:")]
        IntPtr Constructor(SQRDReaderSettingsControllerDelegate @delegate);

        // -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDStoreCustomerCardControllerErrorDomain;
        [Field("SQRDStoreCustomerCardControllerErrorDomain", "__Internal")]
        NSString SQRDStoreCustomerCardControllerErrorDomain { get; }
    }

    // @protocol SQRDStoreCustomerCardControllerDelegate
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    public interface SQRDStoreCustomerCardControllerDelegate
    {
        // @required -(void)storeCustomerCardController:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController didFinishWithCard:(SQRDCard * _Nonnull)card;
        [Abstract]
        [Export("storeCustomerCardController:didFinishWithCard:")]
         void StoreCustomerCardController(SQRDStoreCustomerCardController storeCustomerCardController, SQRDCard card);

        // @required -(void)storeCustomerCardController:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController didFailWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("storeCustomerCardController:didFailWithError:")]
         void StoreCustomerCardController(SQRDStoreCustomerCardController storeCustomerCardController, NSError error);

        // @required -(void)storeCustomerCardControllerDidCancel:(SQRDStoreCustomerCardController * _Nonnull)storeCustomerCardController;
        [Abstract]
        [Export("storeCustomerCardControllerDidCancel:")]
         void StoreCustomerCardControllerDidCancel(SQRDStoreCustomerCardController storeCustomerCardController);
    }

    // @interface SQRDStoreCustomerCardController : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    public interface SQRDStoreCustomerCardController
    {
        // -(instancetype _Nonnull)initWithCustomerID:(NSString * _Nonnull)customerID delegate:(id<SQRDStoreCustomerCardControllerDelegate> _Nonnull)delegate;
        [Export("initWithCustomerID:delegate:")]
         IntPtr Constructor(string customerID, SQRDStoreCustomerCardControllerDelegate @delegate);

        // -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
        [Export("presentFromViewController:")]
         void PresentFromViewController(UIViewController viewController);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull SQRDCheckoutControllerErrorDomain;
        [Field("SQRDCheckoutControllerErrorDomain", "__Internal")]
        NSString SQRDCheckoutControllerErrorDomain { get; }
    }

    // @protocol SQRDCheckoutControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SQRDCheckoutControllerDelegate
    {
        // @required -(void)checkoutController:(SQRDCheckoutController * _Nonnull)checkoutController didFinishCheckoutWithResult:(SQRDCheckoutResult * _Nonnull)result;
        [Abstract]
        [Export("checkoutController:didFinishCheckoutWithResult:")]
        void CheckoutController(SQRDCheckoutController checkoutController, SQRDCheckoutResult result);

        // @required -(void)checkoutController:(SQRDCheckoutController * _Nonnull)checkoutController didFailWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("checkoutController:didFailWithError:")]
        void CheckoutController(SQRDCheckoutController checkoutController, NSError error);

        // @required -(void)checkoutControllerDidCancel:(SQRDCheckoutController * _Nonnull)checkoutController;
        [Abstract]
        [Export("checkoutControllerDidCancel:")]
        void CheckoutControllerDidCancel(SQRDCheckoutController checkoutController);
    }

    // @interface SQRDCheckoutController : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDCheckoutController
    {
        // -(instancetype _Nonnull)initWithParameters:(SQRDCheckoutParameters * _Nonnull)parameters delegate:(id<SQRDCheckoutControllerDelegate> _Nonnull)delegate;
        [Export("initWithParameters:delegate:")]
        IntPtr Constructor(SQRDCheckoutParameters parameters, SQRDCheckoutControllerDelegate @delegate);

        // -(void)presentFromViewController:(UIViewController * _Nonnull)viewController;
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);
    }

    // @interface SQRDLocation : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDLocation : INSCopying
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull locationID;
        [Export("locationID", ArgumentSemantic.Strong)]
        string LocationID { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull businessName;
        [Export("businessName", ArgumentSemantic.Strong)]
        string BusinessName { get; }

        // @property (readonly, nonatomic) BOOL isCardProcessingActivated;
        [Export("isCardProcessingActivated")]
        bool IsCardProcessingActivated { get; }

        // @property (readonly, nonatomic, strong) SQRDMoney * _Nonnull minimumCardPaymentAmountMoney;
        [Export("minimumCardPaymentAmountMoney", ArgumentSemantic.Strong)]
        SQRDMoney MinimumCardPaymentAmountMoney { get; }

        // @property (readonly, nonatomic, strong) SQRDMoney * _Nonnull maximumCardPaymentAmountMoney;
        [Export("maximumCardPaymentAmountMoney", ArgumentSemantic.Strong)]
        SQRDMoney MaximumCardPaymentAmountMoney { get; }

        // @property (readonly, nonatomic) SQRDCurrencyCode currencyCode;
        [Export("currencyCode")]
        SQRDCurrencyCode CurrencyCode { get; }

        // -(BOOL)isEqual:(SQRDMoney * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDMoney @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDMoney : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDMoney : INSCopying
    {
        // -(instancetype _Nonnull)initWithAmount:(NSInteger)amount;
        [Export("initWithAmount:")]
        IntPtr Constructor(nint amount);

        // -(instancetype _Nonnull)initWithAmount:(NSInteger)amount currencyCode:(SQRDCurrencyCode)currencyCode;
        [Export("initWithAmount:currencyCode:")]
        IntPtr Constructor(nint amount, SQRDCurrencyCode currencyCode);

        // @property (readonly, nonatomic) NSInteger amount;
        [Export("amount")]
        nint Amount { get; }

        // @property (readonly, nonatomic) SQRDCurrencyCode currencyCode;
        [Export("currencyCode")]
        SQRDCurrencyCode CurrencyCode { get; }

        // -(BOOL)isEqual:(SQRDMoney * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDMoney @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDTender : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDTender : INSCopying
    {
        // @property (readonly, nonatomic) NSString * _Nullable tenderID;
        [NullAllowed, Export("tenderID")]
        string TenderID { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull createdAt;
        [Export("createdAt")]
        NSDate CreatedAt { get; }

        // @property (readonly, nonatomic) SQRDTenderType type;
        [Export("type")]
        SQRDTenderType Type { get; }

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull totalMoney;
        [Export("totalMoney")]
        SQRDMoney TotalMoney { get; }

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull tipMoney;
        [Export("tipMoney")]
        SQRDMoney TipMoney { get; }

        // @property (readonly, nonatomic) SQRDTenderCardDetails * _Nullable cardDetails;
        [NullAllowed, Export("cardDetails")]
        SQRDTenderCardDetails CardDetails { get; }

        // @property (readonly, nonatomic) SQRDTenderCashDetails * _Nullable cashDetails;
        [NullAllowed, Export("cashDetails")]
        SQRDTenderCashDetails CashDetails { get; }

        // -(BOOL)isEqual:(SQRDTender * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDTender @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDTenderCardDetails : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDTenderCardDetails : INSCopying
    {
        // @property (readonly, nonatomic) SQRDCard * _Nonnull card;
        [Export("card")]
        SQRDCard Card { get; }

        // @property (readonly, nonatomic) SQRDTenderCardDetailsEntryMethod entryMethod;
        [Export("entryMethod")]
        SQRDTenderCardDetailsEntryMethod EntryMethod { get; }

        // -(BOOL)isEqual:(SQRDTenderCardDetails * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDTenderCardDetails @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDTenderCashDetails : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDTenderCashDetails : INSCopying
    {
        // @property (readonly, nonatomic) SQRDMoney * _Nonnull buyerTenderedMoney;
        [Export("buyerTenderedMoney")]
        SQRDMoney BuyerTenderedMoney { get; }

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull changeBackMoney;
        [Export("changeBackMoney")]
        SQRDMoney ChangeBackMoney { get; }

        // -(BOOL)isEqual:(SQRDTenderCashDetails * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDTenderCashDetails @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDTipSettings : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface SQRDTipSettings : INSCopying
    {
        // @property (assign, nonatomic) BOOL showSeparateTipScreen;
        [Export("showSeparateTipScreen")]
        bool ShowSeparateTipScreen { get; set; }

        // @property (assign, nonatomic) BOOL showCustomTipField;
        [Export("showCustomTipField")]
        bool ShowCustomTipField { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull tipPercentages;
        [Export("tipPercentages", ArgumentSemantic.Copy)]
        NSNumber[] TipPercentages { get; set; }

        // -(BOOL)isEqual:(SQRDTipSettings * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDTipSettings @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @interface SQRDCheckoutParameters : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDCheckoutParameters : INSCopying
    {
        // -(instancetype _Nonnull)initWithAmountMoney:(SQRDMoney * _Nonnull)amountMoney;
        [Export("initWithAmountMoney:")]
        IntPtr Constructor(SQRDMoney amountMoney);

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull amountMoney;
        [Export("amountMoney")]
        SQRDMoney AmountMoney { get; }

        // @property (copy, nonatomic) NSString * _Nullable note;
        [NullAllowed, Export("note")]
        string Note { get; set; }

        // @property (assign, nonatomic) SQRDAdditionalPaymentTypes additionalPaymentTypes;
        [Export("additionalPaymentTypes", ArgumentSemantic.Assign)]
        SQRDAdditionalPaymentTypes AdditionalPaymentTypes { get; set; }

        // @property (copy, nonatomic) SQRDTipSettings * _Nullable tipSettings;
        [NullAllowed, Export("tipSettings", ArgumentSemantic.Copy)]
        SQRDTipSettings TipSettings { get; set; }

        // @property (assign, nonatomic) BOOL skipReceipt;
        [Export("skipReceipt")]
        bool SkipReceipt { get; set; }

        // @property (assign, nonatomic) BOOL collectSignature;
        [Export("collectSignature")]
        bool CollectSignature { get; set; }

        // @property (assign, nonatomic) BOOL allowSplitTender;
        [Export("allowSplitTender")]
        bool AllowSplitTender { get; set; }

        // @property (assign, nonatomic) BOOL alwaysRequireSignature __attribute__((deprecated("Use collectSignature instead. alwaysRequireSignature will be removed in a future major release.")));
        [Export("alwaysRequireSignature")]
        bool AlwaysRequireSignature { get; set; }
    }

    // @interface SQRDCheckoutResult : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface SQRDCheckoutResult : INSCopying
    {
        // @property (readonly, nonatomic) NSString * _Nullable transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull transactionClientID;
        [Export("transactionClientID")]
        string TransactionClientID { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull locationID;
        [Export("locationID")]
        string LocationID { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull createdAt;
        [Export("createdAt")]
        NSDate CreatedAt { get; }

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull totalMoney;
        [Export("totalMoney")]
        SQRDMoney TotalMoney { get; }

        // @property (readonly, nonatomic) SQRDMoney * _Nonnull totalTipMoney;
        [Export("totalTipMoney")]
        SQRDMoney TotalTipMoney { get; }

        // @property (readonly, nonatomic) NSSet<SQRDTender *> * _Nonnull tenders;
        [Export("tenders")]
        NSSet<SQRDTender> Tenders { get; }

        // -(BOOL)isEqual:(SQRDCheckoutResult * _Nullable)object;
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] SQRDCheckoutResult @object);

        // @property (readonly) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }



    // @interface  (SQRDCheckoutResult)
    //[Category]
    [BaseType(typeof(SQRDCheckoutResult))]
    interface SQRDCheckoutResult_
    {
        // -(instancetype _Nonnull)initWithTransactionID:(NSString * _Nullable)transactionID transactionClientID:(NSString * _Nonnull)transactionClientID locationID:(NSString * _Nonnull)locationID createdAt:(NSDate * _Nonnull)createdAt tenders:(NSArray<SQRDTender *> * _Nonnull)tenders totalMoney:(SQRDMoney * _Nonnull)totalMoney totalTipMoney:(SQRDMoney * _Nonnull)totalTipMoney;
        [Export("initWithTransactionID:transactionClientID:locationID:createdAt:tenders:totalMoney:totalTipMoney:")]
        IntPtr Constructor([NullAllowed] string transactionID, string transactionClientID, string locationID, NSDate createdAt, SQRDTender[] tenders, SQRDMoney totalMoney, SQRDMoney totalTipMoney);
    }


   
}
