using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UrbanAirship
{
	// @interface UAirshipChat
	[BaseType(typeof(NSObject))]
	interface UAirshipChat: IUAComponent
	{
		// @property (class, nonatomic, readonly, null_unspecified) UAMessageCenter *shared;
		[Static]
		[Export("shared")]
		UAirshipChat Shared { get; }

		[Wrap ("WeakOpenChatDelegate")]
		[NullAllowed]
		IUAirshipChatDelegate OpenChatDelegate { get; set; }

		// @property (nonatomic, weak) id<UAirshipChatDelegate> _Nullable openChatDelegate;
		[NullAllowed, Export ("openChatDelegate", ArgumentSemantic.Weak)]
		NSObject WeakOpenChatDelegate { get; set; }

		// @property (nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (nonatomic, strong) UAChatStyle * _Nullable style;
		[NullAllowed, Export ("style", ArgumentSemantic.Strong)]
		UAChatStyle Style { get; set; }

		// @property (readonly, nonatomic, strong) id<UAConversationProtocol> _Nonnull conversation;
		[Export ("conversation", ArgumentSemantic.Strong)]
		IUAConversationProtocol Conversation { get; }

		// -(void)openChat;
		[Export ("openChat")]
		void OpenChat ();

		// -(void)openChatWithMessage:(NSString * _Nullable)message;
		[Export ("openChatWithMessage:")]
		void OpenChatWithMessage ([NullAllowed] string message);
	}

	// @interface UAChatMessage : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAChatMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull messageID;
		[Export ("messageID")]
		string MessageID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable text;
		[NullAllowed, Export ("text")]
		string Text { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull timestamp;
		[Export ("timestamp", ArgumentSemantic.Copy)]
		NSDate Timestamp { get; }

		// @property (readonly, nonatomic) enum UAChatMessageDirection direction;
		[Export ("direction")]
		UAChatMessageDirection Direction { get; }

		// @property (readonly, nonatomic) BOOL isDelivered;
		[Export ("isDelivered")]
		bool IsDelivered { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable attachment;
		[NullAllowed, Export ("attachment", ArgumentSemantic.Copy)]
		NSUrl Attachment { get; }
	}

	// @protocol UAirshipChatDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAirshipChatDelegate
	{
		// @required -(void)openChatWithMessage:(NSString * _Nullable)message;
		[Abstract]
		[Export ("openChatWithMessage:")]
		void OpenChatWithMessage ([NullAllowed] string message);
	}

	interface IUAirshipChatDelegate { }

	// @interface UAChatResources : NSObject
	[BaseType (typeof(NSObject))]
	interface UAChatResources
	{
		// +(NSBundle * _Nullable)bundle __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("bundle")]
		NSBundle Bundle { get; }
	}

	// @interface UAChatStyle : NSObject
	[BaseType (typeof(NSObject))]
	interface UAChatStyle
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable titleFont;
		[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleColor;
		[NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable outgoingTextColor;
		[NullAllowed, Export ("outgoingTextColor", ArgumentSemantic.Strong)]
		UIColor OutgoingTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable incomingTextColor;
		[NullAllowed, Export ("incomingTextColor", ArgumentSemantic.Strong)]
		UIColor IncomingTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable messageTextFont;
		[NullAllowed, Export ("messageTextFont", ArgumentSemantic.Strong)]
		UIFont MessageTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable outgoingChatBubbleColor;
		[NullAllowed, Export ("outgoingChatBubbleColor", ArgumentSemantic.Strong)]
		UIColor OutgoingChatBubbleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable incomingChatBubbleColor;
		[NullAllowed, Export ("incomingChatBubbleColor", ArgumentSemantic.Strong)]
		UIColor IncomingChatBubbleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable dateColor;
		[NullAllowed, Export ("dateColor", ArgumentSemantic.Strong)]
		UIColor DateColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable dateFont;
		[NullAllowed, Export ("dateFont", ArgumentSemantic.Strong)]
		UIFont DateFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable navigationBarColor;
		[NullAllowed, Export ("navigationBarColor", ArgumentSemantic.Strong)]
		UIColor NavigationBarColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable tintColor;
		[NullAllowed, Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }
	}

	// @protocol UAConversationDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAConversationDelegate
	{
		// @required -(void)onMessagesUpdated;
		[Abstract]
		[Export ("onMessagesUpdated")]
		void OnMessagesUpdated ();

		// @required -(void)onConnectionStatusChanged;
		[Abstract]
		[Export ("onConnectionStatusChanged")]
		void OnConnectionStatusChanged ();
	}

	interface IUAConversationDelegate { }

	// @interface UAChatViewController : UIViewController <UAConversationDelegate, UITableViewDataSource, UITableViewDelegate, UITextViewDelegate>
	[BaseType (typeof(UIViewController))]
	interface UAChatViewController : IUAConversationDelegate, IUITableViewDataSource, IUITableViewDelegate, IUITextViewDelegate
	{
		// @property (copy, nonatomic) NSString * _Nullable messageDraft;
		[NullAllowed, Export ("messageDraft")]
		string MessageDraft { get; set; }

		// @property (nonatomic, strong) UAChatStyle * _Nullable chatStyle;
		[NullAllowed, Export ("chatStyle", ArgumentSemantic.Strong)]
		UAChatStyle ChatStyle { get; set; }

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
	}

	// @protocol UAConversationProtocol
	[Protocol]
	interface UAConversationProtocol
	{
		// @required @property (readonly, nonatomic) BOOL isConnected;
		[Abstract]
		[Export ("isConnected")]
		bool IsConnected { get; }

		[Wrap ("WeakDelegate"), Abstract]
		[NullAllowed]
		UAConversationDelegate Delegate { get; set; }

		// @required @property (nonatomic, strong) id<UAConversationDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)sendMessage:(NSString * _Nullable)text attachment:(NSURL * _Nullable)attachment;
		[Abstract]
		[Export ("sendMessage:attachment:")]
		void SendMessage ([NullAllowed] string text, [NullAllowed] NSUrl attachment);

		// @required -(void)sendMessage:(NSString * _Nonnull)text;
		[Abstract]
		[Export ("sendMessage:")]
		void SendMessage (string text);

		// @required -(void)fetchMessagesWithCompletionHandler:(void (^ _Nonnull)(NSArray<UAChatMessage *> * _Nonnull))completionHandler;
		[Abstract]
		[Export ("fetchMessagesWithCompletionHandler:")]
		void FetchMessagesWithCompletionHandler (Action<UAChatMessage[]> completionHandler);
	}

	interface IUAConversationProtocol { }

	// @interface UAOpenChatAction
	[BaseType(typeof(NSObject))]
	interface UAOpenChatAction: IUAAction
	{
	}
}
