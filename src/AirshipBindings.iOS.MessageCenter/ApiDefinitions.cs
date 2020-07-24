/*
 Copyright Airship and Contributors
*/
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System;
using UIKit;
using UserNotifications;
using WebKit;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull UAInboxMessageListUpdatedNotification
        [Field("UAInboxMessageListUpdatedNotification", "__Internal")]
        NSString UAInboxMessageListUpdatedNotification { get; }

        // extern NSString *const _Nonnull UAInboxMessageListWillUpdateNotification
        [Field("UAInboxMessageListWillUpdateNotification", "__Internal")]
        NSString UAInboxMessageListWillUpdateNotification { get; }

        // extern NSString *const _Nonnull UAMessageCenterMessageLoadErrorDomain
        [Field("UAMessageCenterMessageLoadErrorDomain", "__Internal")]
        NSString UAMessageCenterMessageLoadErrorDomain { get; }

        // extern NSString *const _Nonnull UAMessageCenterMessageLoadErrorHTTPStatusKey
        [Field("UAMessageCenterMessageLoadErrorHTTPStatusKey", "__Internal")]
        NSString UAMessageCenterMessageLoadErrorHTTPStatusKey { get; }

        // extern NSString *const UAMessageDataScheme
        [Field("UAMessageDataScheme", "__Internal")]
        NSString UAMessageDataScheme { get; }

        // extern NSString *const UANavigationBarStyleBlackKey
        [Field("UANavigationBarStyleBlackKey", "__Internal")]
        NSString UANavigationBarStyleBlackKey { get; }

        // extern NSString *const UANavigationBarStyleDefaultKey
        [Field("UANavigationBarStyleDefaultKey", "__Internal")]
        NSString UANavigationBarStyleDefaultKey { get; }

        // extern NSString * const UAUserCreatedNotification
        [Field("UAUserCreatedNotification", "__Internal")]
        NSString UAUserCreatedNotification { get; }
    }

    // @interface UADefaultMessageCenterListViewController : UIViewController <UITableViewDelegate, UITableViewDataSource, UIScrollViewDelegate>
    [BaseType(typeof(UIViewController))]
    interface UADefaultMessageCenterListViewController : IUITableViewDelegate, IUITableViewDataSource, IUIScrollViewDelegate
    {
        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *_Nonnull messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, strong, readwrite) NSPredicate *_Nonnull filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (nonatomic, weak, readwrite) id<UAMessageCenterListViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAMessageCenterListViewDelegate Delegate { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSIndexPath *selectedIndexPath;
        [NullAllowed, Export("selectedIndexPath", ArgumentSemantic.Strong)]
        NSIndexPath SelectedIndexPath { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *selectedMessageID;
        [NullAllowed, Export("selectedMessageID")]
        string SelectedMessageID { get; set; }
    }

    // @interface UADefaultMessageCenterMessageViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface UADefaultMessageCenterMessageViewController
    {
        // @property (nonatomic, weak, readwrite, nullable) id<UAMessageCenterMessageViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAMessageCenterMessageViewDelegate Delegate { get; set; }

        // @property (nonatomic, readonly, nullable) UAInboxMessage *message;
        [NullAllowed, Export("message")]
        UAInboxMessage Message { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL disableMessageLinkPreviewAndCallouts;
        [Export("disableMessageLinkPreviewAndCallouts")]
        bool DisableMessageLinkPreviewAndCallouts { get; set; }

        // - (void)loadMessageForID:(nullable NSString *)messageID;
        [Export("loadMessageForID:")]
        void LoadMessage ([NullAllowed] string messageID);

        // - (void)clearMessage;
        [Export("clearMessage")]
        void ClearMessage ();
    }

    // @interface UADefaultMessageCenterSplitViewController : UISplitViewController <UAMessageCenterListViewDelegate, UAMessageCenterMessageViewDelegate>
    [BaseType(typeof(UISplitViewController))]
    interface UADefaultMessageCenterSplitViewController : IUAMessageCenterListViewDelegate, IUAMessageCenterMessageViewDelegate
    {
        // @property (nonatomic, strong, readwrite) NSPredicate *_Nonnull filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *_Nonnull messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, readonly) UADefaultMessageCenterListViewController *_Nonnull listViewController;
        [Export("listViewController")]
        UADefaultMessageCenterListViewController ListViewController { get; }

        // @property (nonatomic, readonly) UADefaultMessageCenterMessageViewController *_Nonnull messageViewController;
        [Export("messageViewController")]
        UADefaultMessageCenterMessageViewController MessageViewController { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL disableMessageLinkPreviewAndCallouts;
        [Export("disableMessageLinkPreviewAndCallouts")]
        bool DisableMessageLinkPreviewAndCallouts { get; set; }

        // - (void)displayMessageForID:(nonnull NSString *)messageID;
        [Export("displayMessageForID:")]
        void DisplayMessage (string messageID);
    }

    // @interface UADefaultMessageCenterSplitViewDelegate : NSObject <UISplitViewControllerDelegate>
    [BaseType(typeof(NSObject))]
    interface UADefaultMessageCenterSplitViewDelegate : IUISplitViewControllerDelegate
    {
        // - (instancetype)initWithListViewController:(UADefaultMessageCenterListViewController *)listViewController;
        [Export("initWithListViewController:")]
        IntPtr Constructor (UADefaultMessageCenterListViewController listViewController);
    }

    // @interface UADefaultMessageCenterUI : NSObject <UAMessageCenterDisplayDelegate>
    [BaseType(typeof(NSObject))]
    interface UADefaultMessageCenterUI : IUAMessageCenterDisplayDelegate
    {
        // @property (nonatomic, copy, readwrite) NSString *_Nonnull title;
        [Export("title")]
        string Title { get; set; }

        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *_Nonnull messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, strong, readwrite) NSPredicate *_Nonnull filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL disableMessageLinkPreviewAndCallouts;
        [Export("disableMessageLinkPreviewAndCallouts")]
        bool DisableMessageLinkPreviewAndCallouts { get; set; }
    }

    // typedef void (^UAInboxMessageCallbackBlock)(UAInboxMessage *message)
    delegate void UAInboxMessageCallbackBlock (UAInboxMessage arg0);

    // @interface UAInboxMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxMessage
    {
        // @property (nonatomic, readonly) NSString *_Nonnull messageID;
        [Export("messageID")]
        string MessageID { get; }

        // @property (nonatomic, readonly) NSURL *_Nonnull messageBodyURL;
        [Export("messageBodyURL")]
        NSUrl MessageBodyURL { get; }

        // @property (nonatomic, readonly) NSURL *_Nonnull messageURL;
        [Export("messageURL")]
        NSUrl MessageURL { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (nonatomic, readonly) BOOL unread;
        [Export("unread")]
        bool Unread { get; }

        // @property (nonatomic, readonly) BOOL deleted;
        [Export("deleted")]
        bool Deleted { get; }

        // @property (nonatomic, readonly) NSDate *_Nonnull messageSent;
        [Export("messageSent")]
        NSDate MessageSent { get; }

        // @property (nonatomic, readonly, nullable) NSDate *messageExpiration;
        [NullAllowed, Export("messageExpiration")]
        NSDate MessageExpiration { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (nonatomic, readonly) NSDictionary *_Nonnull extra;
        [Export("extra")]
        NSDictionary Extra { get; }

        // @property (nonatomic, readonly) NSDictionary *_Nonnull rawMessageObject;
        [Export("rawMessageObject")]
        NSDictionary RawMessageObject { get; }

        // @property (nonatomic, weak, readonly) UAInboxMessageList *_Nullable messageList;
        [NullAllowed, Export("messageList")]
        UAInboxMessageList MessageList { get; }

        // - (nullable UADisposable *)markMessageReadWithCompletionHandler: (nullable UAInboxMessageCallbackBlock)completionHandler;
        [Export("markMessageReadWithCompletionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessageRead ([NullAllowed] UAInboxMessageCallbackBlock completionHandler);

        // - (BOOL)isExpired;
        [Export("isExpired")]
        bool IsExpired ();
    }

    // typedef void (^UAInboxMessageListCallbackBlock)(void)
    delegate void UAInboxMessageListCallbackBlock ();

    // @interface UAInboxMessageList : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxMessageList
    {
        // @property (nonatomic, copy, readonly) NSArray<UAInboxMessage *> *_Nonnull messages;
        [Export("messages", ArgumentSemantic.Copy)]
        UAInboxMessage[] Messages { get; }

        // @property (atomic, assign, unsafe_unretained, readwrite) NSInteger unreadCount;
        [Export("unreadCount", ArgumentSemantic.Assign)]
        nint UnreadCount { get; set; }

        // @property (atomic, readonly) BOOL isRetrieving;
        [Export("isRetrieving")]
        bool IsRetrieving { get; }

        // @property (atomic, readonly) BOOL isBatchUpdating;
        [Export("isBatchUpdating")]
        bool IsBatchUpdating { get; }

        // - (nullable UADisposable *) retrieveMessageListWithSuccessBlock: (nullable UAInboxMessageListCallbackBlock)successBlock withFailureBlock: (nullable UAInboxMessageListCallbackBlock) failureBlock;
        [Export("retrieveMessageListWithSuccessBlock:withFailureBlock:")]
        [return: NullAllowed]
        UADisposable RetrieveMessageList ([NullAllowed] UAInboxMessageListCallbackBlock successBlock, [NullAllowed] UAInboxMessageListCallbackBlock failureBlock);

        // - (nullable UADisposable *)markMessagesRead:(nonnull NSArray *)messages completionHandler: (nullable UAInboxMessageListCallbackBlock) completionHandler;
        [Export("markMessagesRead:completionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessagesRead (NSObject[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

        // - (nullable UADisposable *)markMessagesDeleted:(nonnull NSArray *)messages completionHandler: (nullable UAInboxMessageListCallbackBlock) completionHandler;
        [Export("markMessagesDeleted:completionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessagesDeleted (NSObject[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

        // - (nonnull NSArray<UAInboxMessage *> *)messagesFilteredUsingPredicate: (nonnull NSPredicate *)predicate;
        [Export("messagesFilteredUsingPredicate:")]
        UAInboxMessage[] MessagesFilteredUsingPredicate (NSPredicate predicate);

        // - (NSUInteger)messageCount;
        [Export("messageCount")]
        nuint MessageCount ();

        // - (nullable UAInboxMessage *)messageForBodyURL:(nonnull NSURL *)url;
        [Export("messageForBodyURL:")]
        [return: NullAllowed]
        UAInboxMessage Message (NSUrl url);

        // - (nullable UAInboxMessage *)messageForID:(nonnull NSString *)messageID;
        [Export("messageForID:")]
        [return: NullAllowed]
        UAInboxMessage Message (string messageID);
    }

    // @interface UAInboxUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxUtils
    {
        // + (nullable NSString *)inboxMessageIDFromNotification: (nonnull NSDictionary *)notification;
        [Static]
        [Export("inboxMessageIDFromNotification:")]
        [return: NullAllowed]
        string InboxMessageID (NSDictionary notification);

        // + (nullable NSString *)inboxMessageIDFromValue:(nonnull id)values;
        [Static]
        [Export("inboxMessageIDFromValue:")]
        [return: NullAllowed]
        string InboxMessageID (NSObject values);

        // + (nonnull NSString *)userAuthHeaderString:(nonnull UAUserData *)userData;
        [Static]
        [Export("userAuthHeaderString:")]
        string UserAuthHeaderString (UAUserData userData);
    }

    // @protocol UAMessageCenterDisplayDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterDisplayDelegate
    {
        // - (void)displayMessageCenterForMessageID:(NSString *)messageID animated:(BOOL)animated;
        [Abstract]
        [Export("displayMessageCenterForMessageID:animated:")]
        void DisplayMessageCenter (string messageID, bool animated);

        // - (void)displayMessageCenterAnimated:(BOOL)animated;
        [Abstract]
        [Export("displayMessageCenterAnimated:")]
        void DisplayMessageCenterAnimated (bool animated);

        // - (void)dismissMessageCenterAnimated:(BOOL)animated;
        [Abstract]
        [Export("dismissMessageCenterAnimated:")]
        void DismissMessageCenterAnimated (bool animated);
    }

    interface IUAMessageCenterDisplayDelegate { }

    // @interface UAMessageCenter : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAMessageCenter
    {
        // @property (nonatomic, weak, readwrite) id<UAMessageCenterDisplayDelegate> displayDelegate;
        [Export("displayDelegate", ArgumentSemantic.Assign)]
        NSObject WeakDisplayDelegate { get; set; }

        [Wrap("WeakDisplayDelegate")]
        IUAMessageCenterDisplayDelegate DisplayDelegate { get; set; }

        // @property (nonatomic, readonly) UADefaultMessageCenterUI *defaultUI;
        [Export("defaultUI")]
        UADefaultMessageCenterUI DefaultUI { get; }

        // @property (nonatomic, readonly) UAInboxMessageList *messageList;
        [Export("messageList")]
        UAInboxMessageList MessageList { get; }

        // @property (nonatomic, readonly) UAUser *user;
        [Export("user")]
        UAUser User { get; }

        // + (null_unspecified instancetype)shared;
        [Static]
        [New]
        [Export("shared")]
        UAMessageCenter Shared ();

        // - (void)display:(BOOL)animated;
        [Export("display:")]
        void Display (bool animated);

        // - (void)display;
        [Export("display")]
        void Display ();

        // - (void)displayMessageForID:(NSString *)messageID animated:(BOOL)animated;
        [Export("displayMessageForID:animated:")]
        void DisplayMessage (string messageID, bool animated);

        // - (void)displayMessageForID:(NSString *)messageID;
        [Export("displayMessageForID:")]
        void DisplayMessage (string messageID);

        // - (void)dismiss:(BOOL)animated;
        [Export("dismiss:")]
        void Dismiss (bool animated);

        // - (void)dismiss;
        [Export("dismiss")]
        void Dismiss ();
    }

    // @interface UAMessageCenterAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAMessageCenterAction
    {
    }

    // @interface UAMessageCenterDateUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterDateUtils
    {
        // + (NSString *)formattedDateRelativeToNow:(NSDate *)date;
        [Static]
        [Export("formattedDateRelativeToNow:")]
        string FormattedDateRelativeToNow (NSDate date);
    }

    // @interface UAMessageCenterListCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    interface UAMessageCenterListCell
    {
        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, weak, readwrite) UILabel *date;
        [Export("date")]
        UILabel Date { get; set; }

        // @property (nonatomic, weak, readwrite) UILabel *title;
        [Export("title")]
        UILabel Title { get; set; }

        // @property (nonatomic, weak, readwrite) UIView *unreadIndicator;
        [Export("unreadIndicator")]
        UIView UnreadIndicator { get; set; }

        // @property (nonatomic, weak, readwrite) UIImageView *listIconView;
        [Export("listIconView")]
        UIImageView ListIconView { get; set; }

        // - (void)setData:(UAInboxMessage *)message;
        [Export("setData:")]
        void SetData (UAInboxMessage message);
    }

    // @interface UAMessageCenterListViewController : UIViewController <UITableViewDelegate, UITableViewDataSource, UIScrollViewDelegate, UISplitViewControllerDelegate>
    [Obsolete("Deprecated – to be removed in SDK version 14.0. Instead use UADefaultMessageCenterListViewController.")]
    [BaseType(typeof(UIViewController))]
    interface UAMessageCenterListViewController : IUITableViewDelegate, IUITableViewDataSource, IUIScrollViewDelegate, IUISplitViewControllerDelegate
    {
        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, strong, readwrite) NSPredicate *filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (nonatomic, strong, readwrite) UIViewController<UAMessageCenterMessageViewProtocol> *messageViewController;
        [Export("messageViewController", ArgumentSemantic.Strong)]
        UAMessageCenterMessageViewProtocol MessageViewController { get; set; }

        // @property (nonatomic, copy, readwrite) void (^)(BOOL) closeBlock;
        [Export("closeBlock", ArgumentSemantic.Copy)]
        Action CloseBlock { get; set; }

        // - (void)displayMessageForID:(NSString *)messageID;
        [Export("displayMessageForID:")]
        void DisplayMessage (string messageID);

        // - (void)displayMessageForID:(NSString *)messageID onError:(void (^)(void))completion;
        [Export("displayMessageForID:onError:")]
        void DisplayMessage (string messageID, Action completion);

        // - (instancetype)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil splitViewController:(UISplitViewController *)splitViewController;
        [Export("initWithNibName:bundle:splitViewController:")]
        IntPtr Constructor (string nibNameOrNil, NSBundle nibBundleOrNil, UISplitViewController splitViewController);
    }

    // @protocol UAMessageCenterListViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterListViewDelegate
    {
        // - (BOOL)shouldClearSelectionOnViewWillAppear;
        [Abstract]
        [Export("shouldClearSelectionOnViewWillAppear")]
        NSObject ShouldClearSelectionOnViewWillAppear ();

        // - (void)didSelectMessageWithID:(nullable NSString *)messageID;
        [Abstract]
        [Export("didSelectMessageWithID:")]
        void DidSelectMessage (NSObject messageID);
    }

    interface IUAMessageCenterListViewDelegate { }

    // @interface UAMessageCenterMessageViewController : UIViewController <UAMessageCenterMessageViewProtocol>
    [Obsolete("Deprecated – to be removed in SDK version 14.0. Instead use UADefaultMessageCenterMessageViewController.")]
    [BaseType(typeof(UIViewController))]
    interface UAMessageCenterMessageViewController : IUAMessageCenterMessageViewProtocol
    {
    }

    // @protocol UAMessageCenterMessageViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterMessageViewDelegate
    {
        // - (void)messageLoadStarted:(nonnull NSString *)messageID;
        [Abstract]
        [Export("messageLoadStarted:")]
        void MessageLoadStarted (string messageID);

        // - (void)messageLoadSucceeded:(nonnull NSString *)messageID;
        [Abstract]
        [Export("messageLoadSucceeded:")]
        void MessageLoadSucceeded (string messageID);

        // - (void)messageLoadFailed:(nonnull NSString *)messageID error:(nonnull NSError *)error;
        [Abstract]
        [Export("messageLoadFailed:error:")]
        void MessageLoadFailed (string messageID, NSError error);

        // - (void)messageClosed:(nonnull NSString *)messageID;
        [Abstract]
        [Export("messageClosed:")]
        void MessageClosed (string messageID);
    }

    interface IUAMessageCenterMessageViewDelegate { }

    // @protocol UAMessageCenterMessageViewProtocol
    [Protocol, Model]
    [Obsolete("Deprecated – to be removed in SDK version 14.0. Instead use the UAMessageCenterMessageViewController directly.")]
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterMessageViewProtocol
    {
        // @property (nonatomic, strong, readonly) UAInboxMessage *_Nonnull message;
        [Export("message", ArgumentSemantic.Strong)]
        UAInboxMessage Message { get; }

        // @property (nonatomic, copy, readwrite) void (^_Nonnull)(BOOL) closeBlock;
        [Export("closeBlock", ArgumentSemantic.Copy)]
        Action CloseBlock { get; set; }

        // - (void)loadMessageForID:(nullable NSString *)messageID onlyIfChanged:(BOOL)onlyIfChanged onError:(nullable void (^)(void))errorCompletion;
        [Abstract]
        [Export("loadMessageForID:onlyIfChanged:onError:")]
        void LoadMessage ([NullAllowed] string messageID, bool onlyIfChanged, [NullAllowed] Action errorCompletion);

        // - (void)setLoadingIndicatorView:(nonnull UIView *)loadingIndicatorView animations:(nonnull void (^)(void))animations;
        [Export("setLoadingIndicatorView:animations:")]
        void SetLoadingIndicatorView (UIView loadingIndicatorView, Action animations);
    }

    interface IUAMessageCenterMessageViewProtocol { }

    // @interface UAMessageCenterNativeBridgeExtension : NSObject <UANativeBridgeExtensionDelegate>
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterNativeBridgeExtension : IUANativeBridgeExtensionDelegate
    {
    }

    // @interface UAMessageCenterResources : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterResources
    {
        // + (nonnull NSBundle *)bundle;
        [Static]
        [Export("bundle")]
        NSBundle Bundle ();
    }

    // @interface UAMessageCenterSplitViewController : UISplitViewController
    [Obsolete("Deprecated – to be removed in SDK version 14.0. Instead use UADefaultMessageCenterSplitViewController.")]
    [BaseType(typeof(UISplitViewController))]
    interface UAMessageCenterSplitViewController
    {
        // @property (nonatomic, strong, readwrite) NSPredicate *filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (nonatomic, strong, readwrite) UAMessageCenterStyle *messageCenterStyle;
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle MessageCenterStyle { get; set; }

        // @property(nonatomic, strong) UAMessageCenterStyle *style
        [Export("messageCenterStyle", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (nonatomic, readonly) UAMessageCenterListViewController *listViewController;
        [Export("listViewController")]
        UAMessageCenterListViewController ListViewController { get; }
    }

    // @interface UAMessageCenterStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterStyle
    {
        // @property (nonatomic, strong, readwrite) UIFont *titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *navigationBarColor;
        [Export("navigationBarColor", ArgumentSemantic.Strong)]
        UIColor NavigationBarColor { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL navigationBarOpaque;
        [Export("navigationBarOpaque")]
        bool NavigationBarOpaque { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UANavigationBarStyle navigationBarStyle;
        [Export("navigationBarStyle", ArgumentSemantic.Assign)]
        UANavigationBarStyle NavigationBarStyle { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *listColor;
        [Export("listColor", ArgumentSemantic.Strong)]
        UIColor ListColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *refreshTintColor;
        [Export("refreshTintColor", ArgumentSemantic.Strong)]
        UIColor RefreshTintColor { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL iconsEnabled;
        [Export("iconsEnabled")]
        bool IconsEnabled { get; set; }

        // @property (nonatomic, strong, readwrite) UIImage *placeholderIcon;
        [Export("placeholderIcon", ArgumentSemantic.Strong)]
        UIImage PlaceholderIcon { get; set; }

        // @property (nonatomic, strong, readwrite) UIFont *cellTitleFont;
        [Export("cellTitleFont", ArgumentSemantic.Strong)]
        UIFont CellTitleFont { get; set; }

        // @property (nonatomic, strong, readwrite) UIFont *cellDateFont;
        [Export("cellDateFont", ArgumentSemantic.Strong)]
        UIFont CellDateFont { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellColor;
        [Export("cellColor", ArgumentSemantic.Strong)]
        UIColor CellColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellHighlightedColor;
        [Export("cellHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellHighlightedColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellTitleColor;
        [Export("cellTitleColor", ArgumentSemantic.Strong)]
        UIColor CellTitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellTitleHighlightedColor;
        [Export("cellTitleHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellTitleHighlightedColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellDateColor;
        [Export("cellDateColor", ArgumentSemantic.Strong)]
        UIColor CellDateColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellDateHighlightedColor;
        [Export("cellDateHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellDateHighlightedColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellSeparatorColor;
        [Export("cellSeparatorColor", ArgumentSemantic.Strong)]
        UIColor CellSeparatorColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cellTintColor;
        [Export("cellTintColor", ArgumentSemantic.Strong)]
        UIColor CellTintColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *unreadIndicatorColor;
        [Export("unreadIndicatorColor", ArgumentSemantic.Strong)]
        UIColor UnreadIndicatorColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *selectAllButtonTitleColor;
        [Export("selectAllButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor SelectAllButtonTitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *deleteButtonTitleColor;
        [Export("deleteButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor DeleteButtonTitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *markAsReadButtonTitleColor;
        [Export("markAsReadButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor MarkAsReadButtonTitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *editButtonTitleColor;
        [Export("editButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor EditButtonTitleColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonTitleColor { get; set; }

        // + (instancetype)style;
        [Static]
        [Export("style")]
        UAMessageCenterStyle Style ();

        // + (instancetype)styleWithContentsOfFile:(NSString *)path;
        [Static]
        [Export("styleWithContentsOfFile:")]
        UAMessageCenterStyle Style (string path);
    }

    // @interface UAUser : NSObject
    [BaseType(typeof(NSObject))]
    interface UAUser
    {
        // - (void)getUserData:(nonnull void (^)(UAUserData *_Nonnull))completionHandler queue:(nullable dispatch_queue_t)queue;
        [Export("getUserData:queue:")]
        void GetUserData (Action<UAUserData> completionHandler, [NullAllowed] DispatchQueue queue);

        // - (void)getUserData:(nonnull void (^)(UAUserData *_Nonnull))completionHandler;
        [Export("getUserData:")]
        void GetUserData (Action<UAUserData> completionHandler);

        // - (nullable UAUserData *)getUserDataSync;
        [Export("getUserDataSync")]
        [return: NullAllowed]
        UAUserData GetUserDataSync ();
    }

    // @interface UAUserData : NSObject
    [BaseType(typeof(NSObject))]
    interface UAUserData
    {
        // @property (nonatomic, copy, readonly) NSString *_Nonnull username;
        [Export("username")]
        string Username { get; }

        // @property (nonatomic, copy, readonly) NSString *_Nonnull password;
        [Export("password")]
        string Password { get; }
    }
}
