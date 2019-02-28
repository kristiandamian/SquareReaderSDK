using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace SquareBinding
{
    [Native]
    public enum SQRDAuthorizationError : long
    {
        UsageError = 1,
        NoNetworkConnection
    }

    [Native]
    public enum SQRDDeauthorizationError : long
    {
        SQRDDeauthorizationErrorUsageError = 1
    }

    [Native]
    public enum SQRDReaderSettingsControllerError : long
    {
        UsageError = 1,
        SDKNotAuthorized
    }

    [Native]
    public enum SQRDStoreCustomerCardControllerError : long
    {
        UsageError = 1,
        NoNetworkConnection,
        SDKNotAuthorized,
        InvalidCustomerID
    }

    [Native]
    public enum SQRDCheckoutControllerError : long
    {
        UsageError = 1,
        SDKNotAuthorized
    }

    [Native]
    public enum SQRDCurrencyCode : long
    {
        Unknown = 0,
        Automatic = -1,
        Aed = 784,
        All = 8,
        Amd = 51,
        Aoa = 973,
        Ars = 32,
        Aud = 36,
        Awg = 533,
        Azn = 944,
        Bam = 977,
        Bbd = 52,
        Bdt = 50,
        Bgn = 975,
        Bhd = 48,
        Bmd = 60,
        Bnd = 96,
        Bob = 68,
        Brl = 986,
        Bsd = 44,
        Btn = 64,
        Bwp = 72,
        Byr = 974,
        Bzd = 84,
        Cad = 124,
        Cdf = 976,
        Chf = 756,
        Clp = 152,
        Cny = 156,
        Cop = 170,
        Crc = 188,
        Cve = 132,
        Czk = 203,
        Dkk = 208,
        Dop = 214,
        Dzd = 12,
        Egp = 818,
        Etb = 230,
        Eur = 978,
        Fjd = 242,
        Gbp = 826,
        Gel = 981,
        Ghs = 936,
        Gip = 292,
        Gmd = 270,
        Gtq = 320,
        Gyd = 328,
        Hkd = 344,
        Hnl = 340,
        Hrk = 191,
        Htg = 332,
        Huf = 348,
        Idr = 360,
        Ils = 376,
        Inr = 356,
        Isk = 352,
        Jmd = 388,
        Jod = 400,
        Jpy = 392,
        Kes = 404,
        Kgs = 417,
        Khr = 116,
        Krw = 410,
        Kwd = 414,
        Kyd = 136,
        Kzt = 398,
        Lak = 418,
        Lbp = 422,
        Lkr = 144,
        Lrd = 430,
        Ltl = 440,
        Mad = 504,
        Mdl = 498,
        Mga = 969,
        Mkd = 807,
        Mmk = 104,
        Mnt = 496,
        Mop = 446,
        Mro = 478,
        Mur = 480,
        Mwk = 454,
        Mxn = 484,
        Myr = 458,
        Mzn = 943,
        Nad = 516,
        Ngn = 566,
        Nio = 558,
        Nok = 578,
        Npr = 524,
        Nzd = 554,
        Omr = 512,
        Pab = 590,
        Pen = 604,
        Pgk = 598,
        Php = 608,
        Pkr = 586,
        Pln = 985,
        Pyg = 600,
        Qar = 634,
        Ron = 946,
        Rsd = 941,
        Rub = 643,
        Rwf = 646,
        Sar = 682,
        Sbd = 90,
        Scr = 690,
        Sek = 752,
        Sgd = 702,
        Sll = 694,
        Srd = 968,
        Std = 678,
        Svc = 222,
        Szl = 748,
        Thb = 764,
        Tjs = 972,
        Tmt = 934,
        Tnd = 788,
        Try = 949,
        Ttd = 780,
        Twd = 901,
        Tzs = 834,
        Uah = 980,
        Ugx = 800,
        Usd = 840,
        Uyu = 858,
        Uzs = 860,
        Vef = 937,
        Vnd = 704,
        Xaf = 950,
        Xcd = 951,
        Xof = 952,
        Yer = 886,
        Zar = 710,
        Zmw = 967
    }

    static class CFunctions
    {
        // extern SQRDCurrencyCode SQRDCurrencyCodeMake (NSString * _Nonnull ISOCurrencyCode);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern SQRDCurrencyCode SQRDCurrencyCodeMake (NSString ISOCurrencyCode);

        // extern NSString * _Nonnull SQRDCurrencyCodeGetISOCurrencyCode (SQRDCurrencyCode currencyCode);
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern NSString SQRDCurrencyCodeGetISOCurrencyCode (SQRDCurrencyCode currencyCode);
    }

    [Native]
    public enum SQRDTenderType : long
    {
        Other = 0,
        Card,
        Cash
    }

    [Native]
    public enum SQRDTenderCardDetailsEntryMethod : long
    {
        Unknown = 0,
        Swipe,
        Chip,
        Contactless,
        ManuallyEntered
    }

    [Native]
    public enum SQRDAdditionalPaymentTypes : long
    {
        ManualCardEntry = 1 << 0,
        Cash = 1 << 1,
        Other = 1 << 2
    }
    [Native]
    public enum SQRDCard : long
    {
        /** An unidentified brand. */
        BrandOtherBrand = 0,

        /** Visa */
        BrandVisa,

        /** Mastercard */
        BrandMastercard,

        /** Discover */
        BrandDiscover,

        /** American Express */
        BrandAmericanExpress,

        /** Diners Club International */
        BrandDiscoverDiners,

        /** Interac */
        BrandInterac,

        /** JCB */
        BrandJCB,

        /** China UnionPay */
        BrandChinaUnionPay,

        /** Square Gift Card */
        BrandSquareGiftCard,

        /** EFTPos */
        BrandEftpos
    }
}
