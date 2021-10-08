/*
 Copyright Airship and Contributors
*/

using Foundation;
using ObjCRuntime;
using System;
using WebKit;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull UAActionMetadataForegroundPresentationKey
        [Field("UAActionMetadataForegroundPresentationKey", "__Internal")]
        NSString UAActionMetadataForegroundPresentationKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataInboxMessageIDKey
        [Field("UAActionMetadataInboxMessageIDKey", "__Internal")]
        NSString UAActionMetadataInboxMessageIDKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataPushPayloadKey
        [Field("UAActionMetadataPushPayloadKey", "__Internal")]
        NSString UAActionMetadataPushPayloadKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataRegisteredName
        [Field("UAActionMetadataRegisteredName", "__Internal")]
        NSString UAActionMetadataRegisteredName { get; }

        // extern NSString *const _Nonnull UAActionMetadataResponseInfoKey
        [Field("UAActionMetadataResponseInfoKey", "__Internal")]
        NSString UAActionMetadataResponseInfoKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataUserNotificationActionIDKey
        [Field("UAActionMetadataUserNotificationActionIDKey", "__Internal")]
        NSString UAActionMetadataUserNotificationActionIDKey { get; }

        // extern NSInteger uaLogLevel
        [Field("uaLogLevel", "__Internal")]
        nint uaLogLevel { get; }
    }

    // typedef BOOL (^UAActionPredicate)(UAActionArguments *_Nonnull)
    delegate bool UAActionPredicate (UAActionArguments arg0);

    // typedef void (^UAActionCompletionHandler)(UAActionResult *_Nonnull)
    delegate void UAActionCompletionHandler (UAActionResult arg0);

    // typedef void (^UAActionBlock)(UAActionArguments *_Nonnull, UAActionCompletionHandler _Nonnull)
    delegate void UAActionBlock (UAActionArguments arg0, [BlockCallback] UAActionCompletionHandler arg1);

    // @protocol UAAction <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAAction
    {
        // - (BOOL)acceptsArguments:(nonnull UAActionArguments *)arguments;
        [Abstract]
        [Export("acceptsArguments:")]
        bool AcceptsArguments (UAActionArguments arguments);

        // - (void)performWithArguments:(nonnull UAActionArguments *)arguments completionHandler: (nonnull UAActionCompletionHandler)completionHandler;
        [Abstract]
        [Export("performWithArguments:completionHandler:")]
        void Perform (UAActionArguments arguments, UAActionCompletionHandler completionHandler);

        // - (void)willPerformWithArguments:(nonnull UAActionArguments *)arguments;
        [Export("willPerformWithArguments:")]
        void WillPerform (UAActionArguments arguments);

        // - (void)didPerformWithArguments:(nonnull UAActionArguments *)arguments withResult:(nonnull UAActionResult *)result;
        [Export("didPerformWithArguments:withResult:")]
        void DidPerform (UAActionArguments arguments, UAActionResult result);
    }

    interface IUAAction { }

    // @interface UAActionArguments : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionArguments
    {
        // @property (nonatomic, assign, unsafe_unretained, readonly) UASituation situation;
        [Export("situation", ArgumentSemantic.Assign)]
        UASituation Situation { get; }

        // @property (nonatomic, strong, readonly, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (nonatomic, copy, readonly, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; }

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation;
        [Static]
        [Export("argumentsWithValue:withSituation:")]
        UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation);

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation metadata:(nullable NSDictionary *)metadata;
        [Static]
        [Export("argumentsWithValue:withSituation:metadata:")]
        UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);
    }

    // @protocol UAActionPredicateProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAActionPredicateProtocol
    {
        // - (BOOL)applyActionArguments:(nonnull UAActionArguments *)args;
        [Abstract]
        [Export("applyActionArguments:")]
        bool ApplyActionArguments (UAActionArguments args);
    }

    interface IUAActionPredicateProtocol { }

    // @interface UAActionResult : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionResult
    {
        // @property (nonatomic, strong, readonly, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (nonatomic, assign, unsafe_unretained, readonly) UAActionFetchResult fetchResult;
        [Export("fetchResult", ArgumentSemantic.Assign)]
        UAActionFetchResult FetchResult { get; }

        // @property (nonatomic, strong, readonly, nullable) NSError *error;
        [NullAllowed, Export("error", ArgumentSemantic.Strong)]
        NSError Error { get; }

        // @property (nonatomic, assign, unsafe_unretained, readonly) UAActionStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        UAActionStatus Status { get; }

        // + (nonnull instancetype)resultWithValue:(nullable id)value;
        [Static]
        [Export("resultWithValue:")]
        UAActionResult Result ([NullAllowed] NSObject value);

        // + (nonnull instancetype)resultWithValue:(nullable id)result withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithValue:withFetchResult:")]
        UAActionResult Result ([NullAllowed] NSObject result, UAActionFetchResult fetchResult);

        // + (nonnull instancetype)emptyResult;
        [Static]
        [Export("emptyResult")]
        UAActionResult EmptyResult ();

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error;
        [Static]
        [Export("resultWithError:")]
        UAActionResult Result (NSError error);

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithError:withFetchResult:")]
        UAActionResult Result (NSError error, UAActionFetchResult fetchResult);

        // + (nonnull instancetype)rejectedArgumentsResult;
        [Static]
        [Export("rejectedArgumentsResult")]
        UAActionResult RejectedArgumentsResult ();

        // + (nonnull instancetype)actionNotFoundResult;
        [Static]
        [Export("actionNotFoundResult")]
        UAActionResult ActionNotFoundResult ();
    }

    // @protocol UAComponent <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAComponent
    {
        // - (BOOL)deepLink:(nonnull NSURL *)deepLink;
        [Export("deepLink:")]
        bool DeepLink (NSUrl deepLink);
    }

    interface IUAComponent { }

    // @interface UADisposable : NSObject
    [BaseType(typeof(NSObject))]
    interface UADisposable
    {
        // - (nonnull instancetype)init:(nonnull void (^)(void))disposalBlock;
        [Export("init:")]
        IntPtr Constructor (Action disposalBlock);

        // - (void)dispose;
        [Export("dispose")]
        [New]
        void Dispose ();
    }

    // @protocol UAEvent <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAEvent
    {
        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    interface IUAEvent { }

    // @interface UAJavaScriptCommand : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptCommand
    {
        // @property (nonatomic, copy, readonly, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (nonatomic, strong, readonly) NSArray<NSString *> *_Nonnull arguments;
        [Export("arguments", ArgumentSemantic.Strong)]
        string[] Arguments { get; }

        // @property (nonatomic, strong, readonly) NSDictionary *_Nonnull options;
        [Export("options", ArgumentSemantic.Strong)]
        NSDictionary Options { get; }

        // @property (nonatomic, strong, readonly) NSURL *_Nonnull URL;
        [Export("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; }

        // + (nonnull instancetype)commandForURL:(nonnull NSURL *)URL;
        [Static]
        [Export("commandForURL:")]
        UAJavaScriptCommand Command (NSUrl URL);

        // - (instancetype)initWithURL:(NSURL *)URL;
        [Export("initWithURL:")]
        IntPtr Constructor (NSUrl URL);
    }

    // @protocol UAJavaScriptCommandDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptCommandDelegate
    {
        // - (BOOL)performCommand:(nonnull UAJavaScriptCommand *)command webView:(nonnull WKWebView *)webView;
        [Abstract]
        [Export("performCommand:webView:")]
        bool PerformCommand (UAJavaScriptCommand command, WKWebView webView);
    }

    interface IUAJavaScriptCommandDelegate { }

    // @protocol UAJavaScriptEnvironmentProtocol <NSObject> /** * Adds a getter to the `UAirship` JavaScript instance. * @param methodName The getter's name. * @param value The getter's value. */ - (void)addStringGetter:(NSString *)methodName value:(nullable NSString *)value NS_SWIFT_NAME(add(_:string:)); /** * Adds a getter to the `UAirship` JavaScript instance. * @param methodName The getter's name. * @param value The getter's value. A nil value will return `-1` in the JavaScript environment. */ - (void)addNumberGetter:(NSString *)methodName value:(nullable NSNumber *)value NS_SWIFT_NAME(add(_:number:)); /** * Adds a getter to the `UAirship` JavaScript instance. * @param methodName The getter's name. * @param value The getter's value. */ - (void)addDictionaryGetter:(NSString *)methodName value:(nullable NSDictionary *)value NS_SWIFT_NAME(add(_:dictionary:)); /** * Builds the script that can be injected into a web view. * @return The script. */ - (NSString *)build; @end
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptEnvironmentProtocol
    {
        // - (void)addStringGetter:(nonnull NSString *)methodName value:(nullable NSString *)value;
        [Abstract]
        [Export("addStringGetter:value:")]
        void AddStringGetter (string methodName, [NullAllowed] string value);

        // - (void)addNumberGetter:(nonnull NSString *)methodName value:(nullable NSNumber *)value;
        [Abstract]
        [Export("addNumberGetter:value:")]
        void AddNumberGetter (string methodName, [NullAllowed] NSNumber value);

        // - (void)addDictionaryGetter:(nonnull NSString *)methodName value:(nullable NSDictionary *)value;
        [Abstract]
        [Export("addDictionaryGetter:value:")]
        void AddDictionaryGetter (string methodName, [NullAllowed] NSDictionary value);

        // - (nonnull NSString *)build;
        [Abstract]
        [Export("build")]
        string Build ();
    }

    interface IUAJavaScriptEnvironmentProtocol { }

    // @protocol UANativeBridgeExtensionDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UANativeBridgeExtensionDelegate
    {
        // - (nonnull NSDictionary *) actionsMetadataForCommand:(nonnull UAJavaScriptCommand *)command webView:(nonnull WKWebView *)webView;
        [Export("actionsMetadataForCommand:webView:")]
        NSDictionary ActionsMetadata (UAJavaScriptCommand command, WKWebView webView);

        // - (void)extendJavaScriptEnvironment: (nonnull id<UAJavaScriptEnvironmentProtocol>)js webView:(nonnull WKWebView *)webView;
        [Export("extendJavascriptEnvironment:webView:")]
        void ExtendJavaScriptEnvironment(IUAJavaScriptEnvironmentProtocol js, WKWebView webView);
    }

    interface IUANativeBridgeExtensionDelegate { }

    // @interface UAPadding : NSObject
    [BaseType(typeof(NSObject))]
    interface UAPadding
    {
        // @property (nonatomic, strong, readwrite, nullable) NSNumber *top;
        [NullAllowed, Export("top", ArgumentSemantic.Strong)]
        NSNumber Top { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *bottom;
        [NullAllowed, Export("bottom", ArgumentSemantic.Strong)]
        NSNumber Bottom { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *trailing;
        [NullAllowed, Export("trailing", ArgumentSemantic.Strong)]
        NSNumber Trailing { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *leading;
        [NullAllowed, Export("leading", ArgumentSemantic.Strong)]
        NSNumber Leading { get; set; }

        // - (nonnull instancetype)initWithTop:(nullable NSNumber *)top bottom:(nullable NSNumber *)bottom leading:(nullable NSNumber *)leading trailing:(nullable NSNumber *)trailing;
        [Export("initWithTop:bottom:leading:trailing:")]
        IntPtr Constructor ([NullAllowed] NSNumber top, [NullAllowed] NSNumber bottom, [NullAllowed] NSNumber leading, [NullAllowed] NSNumber trailing);

        // + (nonnull instancetype)paddingWithTop:(nullable NSNumber *)top bottom:(nullable NSNumber *)bottom leading:(nullable NSNumber *)leading trailing:(nullable NSNumber *)trailing;
        [Static]
        [Export("paddingWithTop:bottom:leading:trailing:")]
        UAPadding Padding ([NullAllowed] NSNumber top, [NullAllowed] NSNumber bottom, [NullAllowed] NSNumber leading, [NullAllowed] NSNumber trailing);

        // + (nonnull instancetype)paddingWithDictionary: (nullable NSDictionary *)paddingDict;
        [Static]
        [Export("paddingWithDictionary:")]
        UAPadding Padding ([NullAllowed] NSDictionary paddingDict);
    }
}
