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
        // extern NSString *const _Nonnull UABannerAdditionalPaddingKey
        [Field("UABannerAdditionalPaddingKey", "__Internal")]
        NSString UABannerAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UABannerBodyStyleKey
        [Field("UABannerBodyStyleKey", "__Internal")]
        NSString UABannerBodyStyleKey { get; }

        // extern NSString *const _Nonnull UABannerButtonStyleKey
        [Field("UABannerButtonStyleKey", "__Internal")]
        NSString UABannerButtonStyleKey { get; }

        // extern NSString *const _Nonnull UABannerHeaderStyleKey
        [Field("UABannerHeaderStyleKey", "__Internal")]
        NSString UABannerHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UABannerMaxWidthKey
        [Field("UABannerMaxWidthKey", "__Internal")]
        NSString UABannerMaxWidthKey { get; }

        // extern NSString *const _Nonnull UABannerMediaStyleKey
        [Field("UABannerMediaStyleKey", "__Internal")]
        NSString UABannerMediaStyleKey { get; }

        // extern NSString *const _Nonnull UABannerStyleFileName
        [Field("UABannerStyleFileName", "__Internal")]
        NSString UABannerStyleFileName { get; }

        // extern NSString *const _Nonnull UABannerTextStyleKey
        [Field("UABannerTextStyleKey", "__Internal")]
        NSString UABannerTextStyleKey { get; }

        // extern NSString *const _Nonnull UAButtonAdditionalPaddingKey
        [Field("UAButtonAdditionalPaddingKey", "__Internal")]
        NSString UAButtonAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAButtonHeightKey
        [Field("UAButtonHeightKey", "__Internal")]
        NSString UAButtonHeightKey { get; }

        // extern NSString *const UACancelSchedulesActionAll
        [Field("UACancelSchedulesActionAll", "__Internal")]
        NSString UACancelSchedulesActionAll { get; }

        // extern NSString *const UACancelSchedulesActionDefaultRegistryAlias
        [Field("UACancelSchedulesActionDefaultRegistryAlias", "__Internal")]
        NSString UACancelSchedulesActionDefaultRegistryAlias { get; }

        // extern NSString *const UACancelSchedulesActionDefaultRegistryName
        [Field("UACancelSchedulesActionDefaultRegistryName", "__Internal")]
        NSString UACancelSchedulesActionDefaultRegistryName { get; }

        // extern NSString *const UACancelSchedulesActionGroups
        [Field("UACancelSchedulesActionGroups", "__Internal")]
        NSString UACancelSchedulesActionGroups { get; }

        // extern NSString *const UACancelSchedulesActionIDs
        [Field("UACancelSchedulesActionIDs", "__Internal")]
        NSString UACancelSchedulesActionIDs { get; }

        // extern NSString *const _Nonnull UAFullScreenBodyStyleKey
        [Field("UAFullScreenBodyStyleKey", "__Internal")]
        NSString UAFullScreenBodyStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenButtonStyleKey
        [Field("UAFullScreenButtonStyleKey", "__Internal")]
        NSString UAFullScreenButtonStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenDismissIconResourceKey
        [Field("UAFullScreenDismissIconResourceKey", "__Internal")]
        NSString UAFullScreenDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAFullScreenHeaderStyleKey
        [Field("UAFullScreenHeaderStyleKey", "__Internal")]
        NSString UAFullScreenHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenMediaStyleKey
        [Field("UAFullScreenMediaStyleKey", "__Internal")]
        NSString UAFullScreenMediaStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenStyleFileName
        [Field("UAFullScreenStyleFileName", "__Internal")]
        NSString UAFullScreenStyleFileName { get; }

        // extern NSString *const _Nonnull UAFullScreenTextStyleKey
        [Field("UAFullScreenTextStyleKey", "__Internal")]
        NSString UAFullScreenTextStyleKey { get; }

        // extern NSString *const _Nonnull UAHTMLAdditionalPaddingKey
        [Field("UAHTMLAdditionalPaddingKey", "__Internal")]
        NSString UAHTMLAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAHTMLDismissIconResourceKey
        [Field("UAHTMLDismissIconResourceKey", "__Internal")]
        NSString UAHTMLDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAHTMLHideDismissIconKey
        [Field("UAHTMLHideDismissIconKey", "__Internal")]
        NSString UAHTMLHideDismissIconKey { get; }

        // extern NSString *const _Nonnull UAHTMLMaxHeightKey
        [Field("UAHTMLMaxHeightKey", "__Internal")]
        NSString UAHTMLMaxHeightKey { get; }

        // extern NSString *const _Nonnull UAHTMLMaxWidthKey
        [Field("UAHTMLMaxWidthKey", "__Internal")]
        NSString UAHTMLMaxWidthKey { get; }

        // extern NSString *const _Nonnull UAHTMLStyleFileName
        [Field("UAHTMLStyleFileName", "__Internal")]
        NSString UAHTMLStyleFileName { get; }

        // extern NSString *const UAInAppMessageBackgroundColorKey
        [Field("UAInAppMessageBackgroundColorKey", "__Internal")]
        NSString UAInAppMessageBackgroundColorKey { get; }

        // extern const NSUInteger UAInAppMessageBannerMaxButtons
        [Field("UAInAppMessageBannerMaxButtons", "__Internal")]
        nuint UAInAppMessageBannerMaxButtons { get; }

        // extern NSString *const UAInAppMessageBodyKey
        [Field("UAInAppMessageBodyKey", "__Internal")]
        NSString UAInAppMessageBodyKey { get; }

        // extern NSString *const UAInAppMessageBorderRadiusKey
        [Field("UAInAppMessageBorderRadiusKey", "__Internal")]
        NSString UAInAppMessageBorderRadiusKey { get; }

        // extern const NSUInteger UAInAppMessageButtonInfoIDLimit
        [Field("UAInAppMessageButtonInfoIDLimit", "__Internal")]
        nuint UAInAppMessageButtonInfoIDLimit { get; }

        // extern NSString *const UAInAppMessageButtonLayoutJoinedValue
        [Field("UAInAppMessageButtonLayoutJoinedValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutJoinedValue { get; }

        // extern NSString *const UAInAppMessageButtonLayoutKey
        [Field("UAInAppMessageButtonLayoutKey", "__Internal")]
        NSString UAInAppMessageButtonLayoutKey { get; }

        // extern NSString *const UAInAppMessageButtonLayoutSeparateValue
        [Field("UAInAppMessageButtonLayoutSeparateValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutSeparateValue { get; }

        // extern NSString *const UAInAppMessageButtonLayoutStackedValue
        [Field("UAInAppMessageButtonLayoutStackedValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutStackedValue { get; }

        // extern NSString *const UAInAppMessageButtonsKey
        [Field("UAInAppMessageButtonsKey", "__Internal")]
        NSString UAInAppMessageButtonsKey { get; }

        // extern NSString *const UAInAppMessageContentLayoutKey
        [Field("UAInAppMessageContentLayoutKey", "__Internal")]
        NSString UAInAppMessageContentLayoutKey { get; }

        // extern NSString *const UAInAppMessageDismissButtonColorKey
        [Field("UAInAppMessageDismissButtonColorKey", "__Internal")]
        NSString UAInAppMessageDismissButtonColorKey { get; }

        // extern NSString *const _Nonnull UAInAppMessageDisplayBehaviorDefault
        [Field("UAInAppMessageDisplayBehaviorDefault", "__Internal")]
        NSString UAInAppMessageDisplayBehaviorDefault { get; }

        // extern NSString *const _Nonnull UAInAppMessageDisplayBehaviorImmediate
        [Field("UAInAppMessageDisplayBehaviorImmediate", "__Internal")]
        NSString UAInAppMessageDisplayBehaviorImmediate { get; }

        // extern NSString *const UAInAppMessageDisplayCoordinatorIsReadyKey
        [Field("UAInAppMessageDisplayCoordinatorIsReadyKey", "__Internal")]
        NSString UAInAppMessageDisplayCoordinatorIsReadyKey { get; }

        // extern NSString *const UAInAppMessageDurationKey
        [Field("UAInAppMessageDurationKey", "__Internal")]
        NSString UAInAppMessageDurationKey { get; }

        // extern NSString *const UAInAppMessageFooterKey
        [Field("UAInAppMessageFooterKey", "__Internal")]
        NSString UAInAppMessageFooterKey { get; }

        // extern const NSUInteger UAInAppMessageFullScreenMaxButtons
        [Field("UAInAppMessageFullScreenMaxButtons", "__Internal")]
        nuint UAInAppMessageFullScreenMaxButtons { get; }

        // extern NSString *const UAInAppMessageHTMLAllowsFullScreenKey
        [Field("UAInAppMessageHTMLAllowsFullScreenKey", "__Internal")]
        NSString UAInAppMessageHTMLAllowsFullScreenKey { get; }

        // extern NSString *const UAInAppMessageHTMLAspectLockKey
        [Field("UAInAppMessageHTMLAspectLockKey", "__Internal")]
        NSString UAInAppMessageHTMLAspectLockKey { get; }

        // extern NSString *const UAInAppMessageHTMLHeightKey
        [Field("UAInAppMessageHTMLHeightKey", "__Internal")]
        NSString UAInAppMessageHTMLHeightKey { get; }

        // extern NSString *const UAInAppMessageHTMLRequireConnectivityKey
        [Field("UAInAppMessageHTMLRequireConnectivityKey", "__Internal")]
        NSString UAInAppMessageHTMLRequireConnectivityKey { get; }

        // extern NSString *const UAInAppMessageHTMLWidthKey
        [Field("UAInAppMessageHTMLWidthKey", "__Internal")]
        NSString UAInAppMessageHTMLWidthKey { get; }

        // extern NSString *const UAInAppMessageHeadingKey
        [Field("UAInAppMessageHeadingKey", "__Internal")]
        NSString UAInAppMessageHeadingKey { get; }

        // extern NSString *const UAInAppMessageMediaKey
        [Field("UAInAppMessageMediaKey", "__Internal")]
        NSString UAInAppMessageMediaKey { get; }

        // extern NSString *const UAInAppMessageModalAllowsFullScreenKey
        [Field("UAInAppMessageModalAllowsFullScreenKey", "__Internal")]
        NSString UAInAppMessageModalAllowsFullScreenKey { get; }

        // extern const NSUInteger UAInAppMessageModalMaxButtons
        [Field("UAInAppMessageModalMaxButtons", "__Internal")]
        nuint UAInAppMessageModalMaxButtons { get; }

        // extern const NSUInteger UAInAppMessageNameLimit
        [Field("UAInAppMessageNameLimit", "__Internal")]
        nuint UAInAppMessageNameLimit { get; }

        // extern NSString *const UAInAppMessagePlacementKey
        [Field("UAInAppMessagePlacementKey", "__Internal")]
        NSString UAInAppMessagePlacementKey { get; }

        // extern NSString *const UAInAppMessageURLKey
        [Field("UAInAppMessageURLKey", "__Internal")]
        NSString UAInAppMessageURLKey { get; }

        // extern NSString *const _Nonnull UALandingPageActionDefaultRegistryAlias
        [Field("UALandingPageActionDefaultRegistryAlias", "__Internal")]
        NSString UALandingPageActionDefaultRegistryAlias { get; }

        // extern NSString *const _Nonnull UALandingPageActionDefaultRegistryName
        [Field("UALandingPageActionDefaultRegistryName", "__Internal")]
        NSString UALandingPageActionDefaultRegistryName { get; }

        // extern NSString *const _Nonnull UALandingPageAspectLockKey
        [Field("UALandingPageAspectLockKey", "__Internal")]
        NSString UALandingPageAspectLockKey { get; }

        // extern const CGFloat UALandingPageDefaultBorderRadiusPoints
        [Field("UALandingPageDefaultBorderRadiusPoints", "__Internal")]
        nfloat UALandingPageDefaultBorderRadiusPoints { get; }

        // extern NSString *const _Nonnull UALandingPageHeightKey
        [Field("UALandingPageHeightKey", "__Internal")]
        NSString UALandingPageHeightKey { get; }

        // extern NSString *const _Nonnull UALandingPageURLKey
        [Field("UALandingPageURLKey", "__Internal")]
        NSString UALandingPageURLKey { get; }

        // extern NSString *const _Nonnull UALandingPageWidthKey
        [Field("UALandingPageWidthKey", "__Internal")]
        NSString UALandingPageWidthKey { get; }

        // extern NSString *const _Nonnull UALineSpacingKey
        [Field("UALineSpacingKey", "__Internal")]
        NSString UALineSpacingKey { get; }

        // extern NSString *const _Nonnull UAModalAdditionalPaddingKey
        [Field("UAModalAdditionalPaddingKey", "__Internal")]
        NSString UAModalAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAModalBodyStyleKey
        [Field("UAModalBodyStyleKey", "__Internal")]
        NSString UAModalBodyStyleKey { get; }

        // extern NSString *const _Nonnull UAModalButtonStyleKey
        [Field("UAModalButtonStyleKey", "__Internal")]
        NSString UAModalButtonStyleKey { get; }

        // extern NSString *const _Nonnull UAModalDismissIconResourceKey
        [Field("UAModalDismissIconResourceKey", "__Internal")]
        NSString UAModalDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAModalHeaderStyleKey
        [Field("UAModalHeaderStyleKey", "__Internal")]
        NSString UAModalHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UAModalMaxHeightKey
        [Field("UAModalMaxHeightKey", "__Internal")]
        NSString UAModalMaxHeightKey { get; }

        // extern NSString *const _Nonnull UAModalMaxWidthKey
        [Field("UAModalMaxWidthKey", "__Internal")]
        NSString UAModalMaxWidthKey { get; }

        // extern NSString *const _Nonnull UAModalMediaStyleKey
        [Field("UAModalMediaStyleKey", "__Internal")]
        NSString UAModalMediaStyleKey { get; }

        // extern NSString *const _Nonnull UAModalStyleFileName
        [Field("UAModalStyleFileName", "__Internal")]
        NSString UAModalStyleFileName { get; }

        // extern NSString *const _Nonnull UAModalTextStyleKey
        [Field("UAModalTextStyleKey", "__Internal")]
        NSString UAModalTextStyleKey { get; }

        // extern NSString *const UAScheduleActionDefaultRegistryAlias
        [Field("UAScheduleActionDefaultRegistryAlias", "__Internal")]
        NSString UAScheduleActionDefaultRegistryAlias { get; }

        // extern NSString *const UAScheduleActionDefaultRegistryName
        [Field("UAScheduleActionDefaultRegistryName", "__Internal")]
        NSString UAScheduleActionDefaultRegistryName { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateBackgroundName
        [Field("UAScheduleDelayAppStateBackgroundName", "__Internal")]
        NSString UAScheduleDelayAppStateBackgroundName { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateForegroundName
        [Field("UAScheduleDelayAppStateForegroundName", "__Internal")]
        NSString UAScheduleDelayAppStateForegroundName { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateKey
        [Field("UAScheduleDelayAppStateKey", "__Internal")]
        NSString UAScheduleDelayAppStateKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayCancellationTriggersKey
        [Field("UAScheduleDelayCancellationTriggersKey", "__Internal")]
        NSString UAScheduleDelayCancellationTriggersKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayErrorDomain
        [Field("UAScheduleDelayErrorDomain", "__Internal")]
        NSString UAScheduleDelayErrorDomain { get; }

        // extern const NSUInteger UAScheduleDelayMaxCancellationTriggers
        [Field("UAScheduleDelayMaxCancellationTriggers", "__Internal")]
        nuint UAScheduleDelayMaxCancellationTriggers { get; }

        // extern NSString *const _Nonnull UAScheduleDelayRegionKey
        [Field("UAScheduleDelayRegionKey", "__Internal")]
        NSString UAScheduleDelayRegionKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayScreensKey
        [Field("UAScheduleDelayScreensKey", "__Internal")]
        NSString UAScheduleDelayScreensKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelaySecondsKey
        [Field("UAScheduleDelaySecondsKey", "__Internal")]
        NSString UAScheduleDelaySecondsKey { get; }

        // extern const NSUInteger UAScheduleMaxTriggers
        [Field("UAScheduleMaxTriggers", "__Internal")]
        nuint UAScheduleMaxTriggers { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerActiveSessionName
        [Field("UAScheduleTriggerActiveSessionName", "__Internal")]
        NSString UAScheduleTriggerActiveSessionName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppBackgroundName
        [Field("UAScheduleTriggerAppBackgroundName", "__Internal")]
        NSString UAScheduleTriggerAppBackgroundName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppForegroundName
        [Field("UAScheduleTriggerAppForegroundName", "__Internal")]
        NSString UAScheduleTriggerAppForegroundName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppInitName
        [Field("UAScheduleTriggerAppInitName", "__Internal")]
        NSString UAScheduleTriggerAppInitName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerCustomEventCountName
        [Field("UAScheduleTriggerCustomEventCountName", "__Internal")]
        NSString UAScheduleTriggerCustomEventCountName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerCustomEventValueName
        [Field("UAScheduleTriggerCustomEventValueName", "__Internal")]
        NSString UAScheduleTriggerCustomEventValueName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerErrorDomain
        [Field("UAScheduleTriggerErrorDomain", "__Internal")]
        NSString UAScheduleTriggerErrorDomain { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerGoalKey
        [Field("UAScheduleTriggerGoalKey", "__Internal")]
        NSString UAScheduleTriggerGoalKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerPredicateKey
        [Field("UAScheduleTriggerPredicateKey", "__Internal")]
        NSString UAScheduleTriggerPredicateKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerRegionEnterName
        [Field("UAScheduleTriggerRegionEnterName", "__Internal")]
        NSString UAScheduleTriggerRegionEnterName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerRegionExitName
        [Field("UAScheduleTriggerRegionExitName", "__Internal")]
        NSString UAScheduleTriggerRegionExitName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerScreenName
        [Field("UAScheduleTriggerScreenName", "__Internal")]
        NSString UAScheduleTriggerScreenName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerTypeKey
        [Field("UAScheduleTriggerTypeKey", "__Internal")]
        NSString UAScheduleTriggerTypeKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerVersionName
        [Field("UAScheduleTriggerVersionName", "__Internal")]
        NSString UAScheduleTriggerVersionName { get; }

        // extern NSString *const _Nonnull UASeparatedButtonSpacingKey
        [Field("UASeparatedButtonSpacingKey", "__Internal")]
        NSString UASeparatedButtonSpacingKey { get; }

        // extern NSString *const _Nonnull UAStackedButtonSpacingKey
        [Field("UAStackedButtonSpacingKey", "__Internal")]
        NSString UAStackedButtonSpacingKey { get; }

        // extern NSString *const _Nonnull UATextAdditonalPaddingKey
        [Field("UATextAdditonalPaddingKey", "__Internal")]
        NSString UATextAdditonalPaddingKey { get; }
    }

    // @interface UAActionSchedule : UASchedule
    [BaseType(typeof(UASchedule))]
    interface UAActionSchedule
    {
        // @property (nonatomic, readonly) NSDictionary *_Nonnull actions;
        [Export("actions")]
        NSDictionary Actions { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull dataJSONString;
        [Export("dataJSONString")]
        string DataJSONString { get; }

        // + (nonnull instancetype) scheduleWithActions:(nonnull NSDictionary *)actions builderBlock: (nonnull void (^)(UAScheduleBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("scheduleWithActions:builderBlock:")]
        UAActionSchedule Schedule (NSDictionary actions, Action<UAScheduleBuilder> builderBlock);
    }

    // @interface UAAutomationResources : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAutomationResources
    {
        // + (nonnull NSBundle *)bundle;
        [Static]
        [Export("bundle")]
        NSBundle Bundle ();
    }

    // @interface UACancelSchedulesAction : NSObject <UAAction>
    [BaseType(typeof(NSObject))]
    interface UACancelSchedulesAction : IUAAction
    {
    }

    // @interface UADeferredSchedule : UASchedule
    [BaseType(typeof(UASchedule))]
    interface UADeferredSchedule
    {
        // @property (nonatomic, readonly) UAScheduleDeferredData *_Nonnull deferredData;
        [Export("deferredData")]
        UAScheduleDeferredData DeferredData { get; }
    }

    // @interface UAInAppAutomation : NSObject <UAComponent>
    [BaseType(typeof(NSObject))]
    interface UAInAppAutomation : IUAComponent
    {
        // @property (class, nonatomic, readonly, null_unspecified) UAInAppAutomation *shared;
        [Static]
        [Export("shared")]
        UAInAppAutomation Shared { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite, getter=isPaused) BOOL paused;
        [Export("paused")]
        bool Paused { [Bind("isPaused")] get; set; }

        // @property (nonatomic, strong, readonly) UAInAppMessageManager *_Nonnull inAppMessageManager;
        [Export("UAInAppMessageManager", ArgumentSemantic.Strong)]
        UAInAppMessageManager InAppMessageManager { get; }

        // - (void)schedule:(nonnull UASchedule *)schedule completionHandler:(nonnull void (^)(BOOL))completionHandler;
        [Export("schedule:completionHandler:")]
        void Schedule(UASchedule schedule, Action<bool> completionHandler);

        // - (void)scheduleMultiple:(nonnull NSArray<UASchedule *> *)schedules completionHandler:(nonnull void (^)(BOOL))completionHandler;
        [Export("scheduleMultiple:completionHandler:")]
        void ScheduleMultiple (UASchedule[] schedules, Action<bool> completionHandler);

        // - (void)cancelScheduleWithID:(nonnull NSString *)scheduleID completionHandler:(nullable void (^)(BOOL))completionHandler;
        [Export("cancelScheduleWithID:completionHandler:")]
        void CancelSchedule (string scheduleID, [NullAllowed] Action completionHandler);

        // - (void)cancelSchedulesWithGroup:(nonnull NSString *)group completionHandler:(nullable void (^)(BOOL))completionHandler;
        [Export("cancelSchedulesWithGroup:completionHandler:")]
        void CancelSchedules (string group, [NullAllowed] Action completionHandler);

        // - (void)cancelActionSchedulesWithGroup:(nonnull NSString *)group completionHandler: (nullable void (^)(BOOL))completionHandler;
        [Export("cancelActionSchedulesWithGroup:completionHandler:")]
        void CancelActionSchedules (string group, [NullAllowed] Action completionHandler);

        // - (void)cancelMessageSchedulesWithGroup:(nonnull NSString *)group completionHandler: (nullable void (^)(BOOL))completionHandler;
        [Export("cancelMessageSchedulesWithGroup:completionHandler:")]
        void CancelMessageSchedules (string group, [NullAllowed] Action completionHandler);

        // - (void)getActionScheduleWithID:(nonnull NSString *)identifier completionHandler:(nonnull void (^)(UAActionSchedule *_Nullable)) completionHandler;
        [Export("getActionScheduleWithID:completionHandler:")]
        [return: NullAllowed]
        void GetActionSchedule (string identifier, Action<UAActionSchedule> completionHandler);

        // - (void)getActionSchedulesWithGroup:(nonnull NSString *)group completionHandler: (nonnull void (^)(NSArray<UAActionSchedule *> *_Nonnull)) completionHandler;
        [Export("getActionSchedulesWithGroup:completionHandler:")]
        void GetActionSchedules (string group, Action<UAActionSchedule[]> completionHandler);

        // - (void)getActionSchedules: (nonnull void (^)(NSArray<UAActionSchedule *> *_Nonnull))completionHandler;
        [Export("getActionSchedules:")]
        void GetActionSchedules (Action<UAActionSchedule[]> completionHandler);

        // - (void)getMessageScheduleWithID:(nonnull NSString *)identifier completionHandler: (nonnull void (^)(UAInAppMessageSchedule *_Nullable)) completionHandler;
        [Export("getMessageScheduleWithID:completionHandler:")]
        [return: NullAllowed]
        void GetMessageSchedule(string identifier, Action<UAInAppMessageSchedule> completionHandler);

        // - (void)getMessageSchedulesWithGroup:(nonnull NSString *)group completionHandler: (nonnull void (^)(NSArray<UAInAppMessageSchedule *> *_Nonnull))completionHandler;
        [Export("getMessageSchedulesWithGroup:completionHandler:")]
        void GetMessageSchedules(string group, Action<UAInAppMessageSchedule[]> completionHandler);

        // - (void)getMessageSchedules: (nonnull void (^)(NSArray<UAInAppMessageSchedule *> *_Nonnull)) completionHandler;
        [Export("getMessageSchedules:")]
        void GetMessageSchedules(Action<UAInAppMessageSchedule[]> completionHandler);

        // - (void)getSchedules: (nonnull void (^)(NSArray<UASchedule *> *_Nonnull))completionHandler;
        [Export("getSchedules:")]
        void GetSchedules(Action<UASchedule[]> completionHandler);

        // - (void)editScheduleWithID:(nonnull NSString *)identifier edits:(nonnull UAScheduleEdits *)edits completionHandler:(nullable void (^)(BOOL))completionHandler;
        [Export("editScheduleWithID:edits:completionHandler:")]
        void EditSchedule(string identifier, UAScheduleEdits edits, [NullAllowed] Action<bool> completionHandler);
    }

    // @interface UAInAppMessageBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBuilder
    {
        // @property (nonatomic, copy, readwrite, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageDisplayContent *displayContent;
        [NullAllowed, Export("displayContent", ArgumentSemantic.Strong)]
        UAInAppMessageDisplayContent DisplayContent { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *extras;
        [NullAllowed, Export("extras", ArgumentSemantic.Copy)]
        NSDictionary Extras { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *displayBehavior;
        [NullAllowed, Export("displayBehavior")]
        string DisplayBehavior { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL isReportingEnabled;
        [Export("isReportingEnabled")]
        bool IsReportingEnabled { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessage
    {
        // @property (nonatomic, copy, readonly, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (nonatomic, readonly) UAInAppMessageDisplayType displayType;
        [Export("displayType")]
        UAInAppMessageDisplayType DisplayType { get; }

        // @property (nonatomic, readonly) UAInAppMessageDisplayContent *_Nonnull displayContent;
        [Export("displayContent")]
        UAInAppMessageDisplayContent DisplayContent { get; }

        // @property (nonatomic, readonly, nullable) NSDictionary *extras;
        [NullAllowed, Export("extras")]
        NSDictionary Extras { get; }

        // @property (nonatomic, readonly, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // @property (nonatomic, copy, readonly) NSString *_Nonnull displayBehavior;
        [Export("displayBehavior")]
        string DisplayBehavior { get; }

        // @property (nonatomic, assign, unsafe_unretained, readonly) BOOL isReportingEnabled;
        [Export("isReportingEnabled")]
        bool IsReportingEnabled { get; }

        // + (nullable instancetype)messageWithBuilderBlock: (nonnull void (^)(UAInAppMessageBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("messageWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessage Message (Action<UAInAppMessageBuilder> builderBlock);

        // - (nullable UAInAppMessage *)extend: (nonnull void (^)(UAInAppMessageBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessage Extend (Action<UAInAppMessageBuilder> builderBlock);
    }

    // @protocol UAInAppMessageAdapterProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAdapterProtocol
    {
        // + (nonnull instancetype)adapterForMessage:(nonnull UAInAppMessage *)message;
        [Static]
        [Export("adapterForMessage:")]
        UAInAppMessageAdapterProtocol Adapter (UAInAppMessage message);

        // - (void)prepareWithAssets:(nonnull UAInAppMessageAssets *)assets completionHandler: (nonnull void (^)(UAInAppMessagePrepareResult))completionHandler;
        [Abstract]
        [Export("prepareWithAssets:completionHandler:")]
        void Prepare (UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);

        // - (BOOL)isReadyToDisplay;
        [Abstract]
        [Export("isReadyToDisplay")]
        bool IsReadyToDisplay ();

        // - (void)display: (nonnull void (^)(UAInAppMessageResolution *_Nonnull))completionHandler;
        [Abstract]
        [Export("display:")]
        void Display (Action<UAInAppMessageResolution> completionHandler);
    }

    interface IUAInAppMessageAdapterProtocol { }

    // @protocol UAInAppMessageCachePolicyDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageCachePolicyDelegate
    {
        // - (BOOL)shouldCacheOnSchedule:(nonnull UAInAppMessage *)message;
        [Abstract]
        [Export("shouldCacheOnSchedule:")]
        bool ShouldCacheOnSchedule (UAInAppMessage message);

        // - (BOOL)shouldPersistCacheAfterDisplay:(nonnull UAInAppMessage *)message;
        [Abstract]
        [Export("shouldPersistCacheAfterDisplay:")]
        bool ShouldPersistCacheAfterDisplay (UAInAppMessage message);
    }

    interface IUAInAppMessageCachePolicyDelegate { }

    // @protocol UAInAppMessagePrepareAssetsDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessagePrepareAssetsDelegate
    {
        // - (void)onSchedule:(nonnull UAInAppMessage *)message assets:(nonnull UAInAppMessageAssets *)assets completionHandler: (nonnull void (^)(UAInAppMessagePrepareResult))completionHandler;
        [Abstract]
        [Export("onSchedule:assets:completionHandler:")]
        void OnSchedule (UAInAppMessage message, UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);

        // - (void)onPrepare:(nonnull UAInAppMessage *)message assets:(nonnull UAInAppMessageAssets *)assets completionHandler: (nonnull void (^)(UAInAppMessagePrepareResult))completionHandler;
        [Abstract]
        [Export("onPrepare:assets:completionHandler:")]
        void OnPrepare (UAInAppMessage message, UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);
    }

    interface IUAInAppMessagePrepareAssetsDelegate { }

    // @interface UAInAppMessageAssetManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAssetManager
    {
        // @property (nonatomic, strong, readwrite) id<UAInAppMessagePrepareAssetsDelegate> _Nonnull prepareAssetsDelegate;
        [Export("prepareAssetsDelegate", ArgumentSemantic.Strong)]
        NSObject WeakPrepareAssetsDelegate { get; set; }

        [Wrap("WeakPrepareAssetsDelegate")]
        IUAInAppMessagePrepareAssetsDelegate PrepareAssetsDelegate { get; set; }

        // @property (nonatomic, weak, readwrite) id<UAInAppMessageCachePolicyDelegate> _Nullable cachePolicyDelegate;
        [NullAllowed, Export("cachePolicyDelegate", ArgumentSemantic.Assign)]
        NSObject WeakCachePolicyDelegate { get; set; }

        [Wrap("WeakCachePolicyDelegate")]
        [NullAllowed]
        IUAInAppMessageCachePolicyDelegate CachePolicyDelegate { get; set; }
    }

    // @interface UAInAppMessageAssets : NSObject /** * Return URL at which to cache the assetURL * * @param assetURL URL from which the cached data is fetched * @return URL for the cached asset or `nil` if the asset cannot be cached at this time */ - (nullable NSURL *)getCacheURL:(NSURL *)assetURL; /** * Check if data is cached for this asset * * @param assetURL URL from which the data is fetched * @return `YES` if data for the URL is in the cache, `NO` if it is not. */ - (BOOL)isCached:(NSURL *)assetURL; @end
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAssets
    {
        // - (nullable NSURL *)getCacheURL:(nonnull NSURL *)assetURL;
        [Export("getCacheURL:")]
        [return: NullAllowed]
        NSUrl GetCacheURL (NSUrl assetURL);

        // - (BOOL)isCached:(nonnull NSURL *)assetURL;
        [Export("isCached:")]
        bool IsCached (NSUrl assetURL);
    }

    // @interface UAInAppMessageBannerAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageBannerStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageBannerStyle Style { get; set; }
    }

    // @interface UAInAppMessageBannerDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerDisplayContentBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageBannerPlacementType placement;
        [Export("placement", ArgumentSemantic.Assign)]
        UAInAppMessageBannerPlacementType Placement { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageBannerContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageBannerContentLayoutType ContentLayout { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval durationSeconds;
        [Export("durationSeconds", ArgumentSemantic.Assign)]
        double DurationSeconds { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageBannerDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageBannerDisplayContent
    {
        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (nonatomic, readonly) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (nonatomic, readonly) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (nonatomic, readonly) UAInAppMessageBannerPlacementType placement;
        [Export("placement")]
        UAInAppMessageBannerPlacementType Placement { get; }

        // @property (nonatomic, readonly) UAInAppMessageBannerContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageBannerContentLayoutType ContentLayout { get; }

        // @property (nonatomic, readonly) NSTimeInterval durationSeconds;
        [Export("durationSeconds")]
        double DurationSeconds { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (nonatomic, assign, unsafe_unretained, readonly) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; }

        // @property (nonatomic, readonly, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageBannerDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageBannerDisplayContent DisplayContent (Action<UAInAppMessageBannerDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageBannerDisplayContent *)extend: (nonnull void (^)(UAInAppMessageBannerDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageBannerDisplayContent Extend (Action<UAInAppMessageBannerDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageBannerStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerStyle : IUAInAppMessageStyleProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }
    }

    // @interface UAInAppMessageButtonInfoBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonInfoBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *label;
        [NullAllowed, Export("label", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Label { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageButtonInfoBehaviorType behavior;
        [Export("behavior", ArgumentSemantic.Assign)]
        UAInAppMessageButtonInfoBehaviorType Behavior { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageButtonInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonInfo
    {
        // @property (nonatomic, readonly) UAInAppMessageTextInfo *_Nonnull label;
        [Export("label")]
        UAInAppMessageTextInfo Label { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (nonatomic, readonly) UAInAppMessageButtonInfoBehaviorType behavior;
        [Export("behavior")]
        UAInAppMessageButtonInfoBehaviorType Behavior { get; }

        // @property (nonatomic, readonly) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints")]
        nfloat BorderRadiusPoints { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull borderColor;
        [Export("borderColor")]
        UIColor BorderColor { get; }

        // @property (nonatomic, readonly, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nullable instancetype)buttonInfoWithBuilderBlock: (nonnull void (^)(UAInAppMessageButtonInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("buttonInfoWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageButtonInfo ButtonInfo (Action<UAInAppMessageButtonInfoBuilder> builderBlock);

        // - (nullable UAInAppMessageButtonInfo *)extend: (nonnull void (^)(UAInAppMessageButtonInfoBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageButtonInfo Extend (Action<UAInAppMessageButtonInfoBuilder> builderBlock);
    }

    // @interface UAInAppMessageButtonStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonStyle
    {
        // @property (nonatomic, strong, readwrite, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *buttonTextStyle;
        [NullAllowed, Export("buttonTextStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle ButtonTextStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *buttonHeight;
        [NullAllowed, Export("buttonHeight", ArgumentSemantic.Strong)]
        NSNumber ButtonHeight { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *stackedButtonSpacing;
        [NullAllowed, Export("stackedButtonSpacing", ArgumentSemantic.Strong)]
        NSNumber StackedButtonSpacing { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *separatedButtonSpacing;
        [NullAllowed, Export("separatedButtonSpacing", ArgumentSemantic.Strong)]
        NSNumber SeparatedButtonSpacing { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *borderWidth;
        [NullAllowed, Export("borderWidth", ArgumentSemantic.Strong)]
        NSNumber BorderWidth { get; set; }

        // + (nonnull instancetype) styleWithAdditionalPadding:(nullable UAPadding *)additionalPadding buttonTextStyle:(nullable UAInAppMessageTextStyle *)textStyle buttonHeight:(nullable NSNumber *)buttonHeight stackedButtonSpacing:(nullable NSNumber *)stackedButtonSpacing separatedButtonSpacing:(nullable NSNumber *)separatedButtonSpacing borderWidth:(nullable NSNumber *)borderWidth;
        [Static]
        [Export("styleWithAdditionalPadding:buttonTextStyle:buttonHeight:stackedButtonSpacing:separatedButtonSpacing:borderWidth:")]
        UAInAppMessageButtonStyle Style ([NullAllowed] UAPadding additionalPadding, [NullAllowed] UAInAppMessageTextStyle textStyle, [NullAllowed] NSNumber buttonHeight, [NullAllowed] NSNumber stackedButtonSpacing, [NullAllowed] NSNumber separatedButtonSpacing, [NullAllowed] NSNumber borderWidth);

        // + (nonnull instancetype)styleWithDictionary: (nullable NSDictionary *)buttonStyle;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageButtonStyle Style ([NullAllowed] NSDictionary buttonStyle);
    }

    // @interface UAInAppMessageCustomDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageCustomDisplayContent
    {
        // @property (nonatomic, readonly) NSDictionary *_Nonnull value;
        [Export("value")]
        NSDictionary Value { get; }

        // + (nonnull instancetype)displayContentWithValue:(nonnull NSDictionary *)value;
        [Static]
        [Export("displayContentWithValue:")]
        UAInAppMessageCustomDisplayContent DisplayContent (NSDictionary value);
    }

    // @interface UAInAppMessageDefaultDisplayCoordinator : NSObject <UAInAppMessageDisplayCoordinator>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDefaultDisplayCoordinator : IUAInAppMessageDisplayCoordinator
    {
        // @property (nonatomic, readonly) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval displayInterval;
        [Export("displayInterval", ArgumentSemantic.Assign)]
        double DisplayInterval { get; set; }

        // + (nonnull instancetype)coordinator;
        [Static]
        [Export("coordinator")]
        UAInAppMessageDefaultDisplayCoordinator Coordinator ();
    }

    // @interface UAInAppMessageDefaultPrepareAssetsDelegate : NSObject <UAInAppMessagePrepareAssetsDelegate> @end
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDefaultPrepareAssetsDelegate : IUAInAppMessagePrepareAssetsDelegate
    {
    }

    // @interface UAInAppMessageDisplayContent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDisplayContent
    {
        // @property (nonatomic, readonly) UAInAppMessageDisplayType displayType;
        [Export("displayType")]
        UAInAppMessageDisplayType DisplayType { get; }

        // - (NSDictionary *)toJSON;
        [Export("toJSON")]
        NSDictionary ToJSON ();
    }

    // @protocol UAInAppMessageDisplayCoordinator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDisplayCoordinator
    {
        // @property (nonatomic, readonly) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

        // - (void)didBeginDisplayingMessage:(UAInAppMessage *)message;
        [Export("didBeginDisplayingMessage:")]
        void DidBeginDisplayingMessage (UAInAppMessage message);

        // - (void)didFinishDisplayingMessage:(UAInAppMessage *)message;
        [Export("didFinishDisplayingMessage:")]
        void DidFinishDisplayingMessage (UAInAppMessage message);
    }

    interface IUAInAppMessageDisplayCoordinator { }

    // @interface UAInAppMessageFullScreenAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageFullScreenStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageFullScreenStyle Style { get; set; }
    }

    // @interface UAInAppMessageFullScreenDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenDisplayContentBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer", ArgumentSemantic.Strong)]
        UAInAppMessageButtonInfo Footer { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageFullScreenContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageFullScreenContentLayoutType ContentLayout { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageFullScreenDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageFullScreenDisplayContent
    {
        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer")]
        UAInAppMessageButtonInfo Footer { get; }

        // @property (nonatomic, readonly) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (nonatomic, readonly) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (nonatomic, readonly) UAInAppMessageFullScreenContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageFullScreenContentLayoutType ContentLayout { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageFullScreenDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageFullScreenDisplayContent DisplayContent (Action<UAInAppMessageFullScreenDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageFullScreenDisplayContent *)extend: (nonnull void (^)(UAInAppMessageFullScreenDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageFullScreenDisplayContent Extend (Action<UAInAppMessageFullScreenDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageFullScreenStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenStyle : IUAInAppMessageStyleProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }
    }

    // @interface UAInAppMessageHTMLAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageHTMLStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageHTMLStyle Style { get; set; }
    }

    // @interface UAInAppMessageHTMLDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLDisplayContentBuilder
    {
        // @property (nonatomic, copy, readwrite, nullable) NSString *url;
        [NullAllowed, Export("url")]
        string Url { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat height;
        [Export("height", ArgumentSemantic.Assign)]
        nfloat Height { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat width;
        [Export("width", ArgumentSemantic.Assign)]
        nfloat Width { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL aspectLock;
        [Export("aspectLock")]
        bool AspectLock { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL requiresConnectivity;
        [Export("requiresConnectivity")]
        bool RequiresConnectivity { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageHTMLDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageHTMLDisplayContent
    {
        // @property (nonatomic, readonly) NSString *_Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (nonatomic, readonly) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints")]
        nfloat BorderRadiusPoints { get; }

        // @property (nonatomic, readonly) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; }

        // @property (nonatomic, readonly) CGFloat height;
        [Export("height")]
        nfloat Height { get; }

        // @property (nonatomic, readonly) CGFloat width;
        [Export("width")]
        nfloat Width { get; }

        // @property (nonatomic, readonly) BOOL aspectLock;
        [Export("aspectLock")]
        bool AspectLock { get; }

        // @property (nonatomic, readonly) BOOL requireConnectivity;
        [Export("requireConnectivity")]
        bool RequireConnectivity { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageHTMLDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageHTMLDisplayContent DisplayContent (Action<UAInAppMessageHTMLDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageHTMLDisplayContent *)extend: (nonnull void (^)(UAInAppMessageHTMLDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageHTMLDisplayContent Extend (Action<UAInAppMessageHTMLDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageHTMLStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLStyle : IUAInAppMessageStyleProtocol
    {
        // @property (nonatomic, strong, readwrite) UAPadding *_Nonnull additionalPadding;
        [Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *maxHeight;
        [NullAllowed, Export("maxHeight", ArgumentSemantic.Strong)]
        NSNumber MaxHeight { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL hideDismissIcon;
        [Export("hideDismissIcon")]
        bool HideDismissIcon { get; set; }
    }

    // @interface UAInAppMessageImmediateDisplayCoordinator : NSObject <UAInAppMessageDisplayCoordinator>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageImmediateDisplayCoordinator : IUAInAppMessageDisplayCoordinator
    {
        // @property (nonatomic, readonly) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

        // + (nonnull instancetype)coordinator;
        [Static]
        [Export("coordinator")]
        UAInAppMessageImmediateDisplayCoordinator Coordinator ();
    }

    // @protocol UAInAppMessagingDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessagingDelegate
    {
        // - (nullable id<UAInAppMessageDisplayCoordinator>)displayCoordinatorForMessage: (nonnull UAInAppMessage *)message;
        [Export("displayCoordinatorForMessage:")]
        [return: NullAllowed]
        UAInAppMessageDisplayCoordinator DisplayCoordinator (UAInAppMessage message);

        // - (nonnull UAInAppMessage *)extendMessage:(nonnull UAInAppMessage *)message;
        [Export("extendMessage:")]
        UAInAppMessage ExtendMessage (UAInAppMessage message);

        // - (void)messageWillBeDisplayed:(nonnull UAInAppMessage *)message scheduleID:(nonnull NSString *)scheduleID;
        [Export("messageWillBeDisplayed:scheduleID:")]
        void MessageWillBeDisplayed (UAInAppMessage message, string scheduleID);

        // - (void)messageFinishedDisplaying:(nonnull UAInAppMessage *)message scheduleID:(nonnull NSString *)scheduleID resolution: (nonnull UAInAppMessageResolution *)resolution;
        [Export("messageFinishedDisplaying:scheduleID:resolution:")]
        void MessageFinishedDisplaying (UAInAppMessage message, string scheduleID, UAInAppMessageResolution resolution);

        // - (nonnull UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message defaultScene: (nullable UIWindowScene *)defaultScene;
        [Export("sceneForMessage:defaultScene:")]
        UIWindowScene Scene (UAInAppMessage message, [NullAllowed] UIWindowScene defaultScene);
    }

    interface IUAInAppMessagingDelegate { }

    // @interface UAInAppMessageManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageManager
    {
        // @property (nonatomic, weak, readwrite) id<UAInAppMessagingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAInAppMessagingDelegate Delegate { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval displayInterval;
        [Export("displayInterval", ArgumentSemantic.Assign)]
        double DisplayInterval { get; set; }

        // @property (nonatomic, strong, readonly) UAInAppMessageAssetManager *_Nonnull assetManager;
        [Export("assetManager", ArgumentSemantic.Strong)]
        UAInAppMessageAssetManager AssetManager { get; }

        // - (void)setFactoryBlock:(nonnull id<UAInAppMessageAdapterProtocol> _Nonnull (^)( UAInAppMessage *_Nonnull))factory forDisplayType:(UAInAppMessageDisplayType)displayType;
        [Export("setFactoryBlock:forDisplayType:")]
        void SetFactoryBlock (Action<UAInAppMessage> factory, UAInAppMessageDisplayType displayType);
    }

    // @interface UAInAppMessageMediaInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageMediaInfo
    {
        // @property (nonatomic, readonly) NSString *_Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (nonatomic, readonly) UAInAppMessageMediaInfoType type;
        [Export("type")]
        UAInAppMessageMediaInfoType Type { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull contentDescription;
        [Export("contentDescription")]
        string ContentDescription { get; }

        // + (nonnull instancetype)mediaInfoWithURL:(nonnull NSString *)url contentDescription:(nonnull NSString *)contentDescription type:(UAInAppMessageMediaInfoType)type;
        [Static]
        [Export("mediaInfoWithURL:contentDescription:type:")]
        UAInAppMessageMediaInfo MediaInfo (string url, string contentDescription, UAInAppMessageMediaInfoType type);
    }

    // @interface UAInAppMessageMediaStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageMediaStyle
    {
        // @property (nonatomic, strong, readwrite, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // + (nonnull instancetype)styleWithAdditionalPadding: (nullable UAPadding *)additionalPadding;
        [Static]
        [Export("styleWithAdditionalPadding:")]
        UAInAppMessageMediaStyle Style ([NullAllowed] UAPadding additionalPadding);

        // + (nonnull instancetype)styleWithDictionary: (nullable NSDictionary *)mediaStyleDict;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageMediaStyle Style ([NullAllowed] NSDictionary mediaStyleDict);
    }

    // @interface UAInAppMessageModalAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageModalStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageModalStyle Style { get; set; }
    }

    // @interface UAInAppMessageModalDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalDisplayContentBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer", ArgumentSemantic.Strong)]
        UAInAppMessageButtonInfo Footer { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageModalContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageModalContentLayoutType ContentLayout { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageModalDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageModalDisplayContent
    {
        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (nonatomic, readonly, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer")]
        UAInAppMessageButtonInfo Footer { get; }

        // @property (nonatomic, readonly) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (nonatomic, readonly) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (nonatomic, readonly) UAInAppMessageModalContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageModalContentLayoutType ContentLayout { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (nonatomic, readonly) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (nonatomic, assign, unsafe_unretained, readonly) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; }

        // @property (nonatomic, readonly) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageModalDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageModalDisplayContent DisplayContent (Action<UAInAppMessageModalDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageModalDisplayContent *)extend: (nonnull void (^)(UAInAppMessageModalDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageModalDisplayContent Extend (Action<UAInAppMessageModalDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageModalStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalStyle : IUAInAppMessageStyleProtocol
    {
        // @property (nonatomic, strong, readwrite) UAPadding *_Nonnull additionalPadding;
        [Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *maxHeight;
        [NullAllowed, Export("maxHeight", ArgumentSemantic.Strong)]
        NSNumber MaxHeight { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }
    }

    // @interface UAInAppMessageResolution : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageResolution
    {
        // @property (nonatomic, readonly, nullable) UAInAppMessageButtonInfo *buttonInfo;
        [NullAllowed, Export("buttonInfo")]
        UAInAppMessageButtonInfo ButtonInfo { get; }

        // @property (nonatomic, readonly) UAInAppMessageResolutionType type;
        [Export("type")]
        UAInAppMessageResolutionType Type { get; }

        // + (nonnull instancetype)buttonClickResolutionWithButtonInfo: (nonnull UAInAppMessageButtonInfo *)buttonInfo;
        [Static]
        [Export("buttonClickResolutionWithButtonInfo:")]
        UAInAppMessageResolution ButtonClickResolution (UAInAppMessageButtonInfo buttonInfo);

        // + (nonnull instancetype)messageClickResolution;
        [Static]
        [Export("messageClickResolution")]
        UAInAppMessageResolution MessageClickResolution ();

        // + (nonnull instancetype)userDismissedResolution;
        [Static]
        [Export("userDismissedResolution")]
        UAInAppMessageResolution UserDismissedResolution ();

        // + (nonnull instancetype)timedOutResolution;
        [Static]
        [Export("timedOutResolution")]
        UAInAppMessageResolution TimedOutResolution ();
    }

    // @protocol UAInAppMessageSceneDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageSceneDelegate
    {
        // - (nullable UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message defaultScene: (nullable UIWindowScene *)defaultScene;
        [Export("sceneForMessage:defaultScene:")]
        [return: NullAllowed]
        UIWindowScene Scene (UAInAppMessage message, [NullAllowed] UIWindowScene defaultScene);
    }

    interface IUAInAppMessageSceneDelegate { }

    // @interface UAInAppMessageSceneManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageSceneManager
    {
        // @property (nonatomic, weak, readwrite) id<UAInAppMessageSceneDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAInAppMessageSceneDelegate Delegate { get; set; }

        // @property (class, nonatomic, readonly) UAInAppMessageSceneManager *_Nonnull shared;
        [Static]
        [Export("shared")]
        UAInAppMessageSceneManager Shared { get; }

        // - (nullable UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message;
        [Export("sceneForMessage:")]
        [return: NullAllowed]
        UIWindowScene Scene (UAInAppMessage message);
    }

    // @interface UAInAppMessageSchedule : UASchedule
    [BaseType(typeof(UASchedule))]
    interface UAInAppMessageSchedule
    {
        // @property (nonatomic, readonly) UAInAppMessage *_Nonnull message;
        [Export("message")]
        UAInAppMessage Message { get; }

        // + (nonnull instancetype) scheduleWithMessage:(nonnull UAInAppMessage *)message builderBlock: (nonnull void (^)(UAScheduleBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("scheduleWithMessage:builderBlock:")]
        UAInAppMessageSchedule Schedule (UAInAppMessage message, Action<UAScheduleBuilder> builderBlock);
    }

    // @protocol UAInAppMessageStyleProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageStyleProtocol
    {
        // + (nonnull instancetype)style;
        [Static]
        [Export("style")]
        UAInAppMessageStyleProtocol Style ();

        // + (nullable instancetype)styleWithContentsOfFile:(nullable NSString *)path;
        [Static]
        [Export("styleWithContentsOfFile:")]
        [return: NullAllowed]
        UAInAppMessageStyleProtocol Style ([NullAllowed] string path);
    }

    interface IUAInAppMessageStyleProtocol { }

    // @interface UAInAppMessageTextInfoBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextInfoBuilder
    {
        // @property (nonatomic, copy, readwrite, nullable) NSString *text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (nonatomic, strong, readwrite) UIColor *_Nonnull color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) CGFloat sizePoints;
        [Export("sizePoints", ArgumentSemantic.Assign)]
        nfloat SizePoints { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageTextInfoAlignmentType alignment;
        [Export("alignment", ArgumentSemantic.Assign)]
        UAInAppMessageTextInfoAlignmentType Alignment { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAInAppMessageTextInfoStyleType style;
        [Export("style", ArgumentSemantic.Assign)]
        UAInAppMessageTextInfoStyleType Style { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<NSString *> *fontFamilies;
        [NullAllowed, Export("fontFamilies", ArgumentSemantic.Copy)]
        string[] FontFamilies { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAInAppMessageTextInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextInfo
    {
        // @property (nonatomic, readonly, nullable) NSString *text;
        [NullAllowed, Export("text")]
        string Text { get; }

        // @property (nonatomic, readonly, nullable) UIColor *color;
        [NullAllowed, Export("color")]
        UIColor Color { get; }

        // @property (nonatomic, readonly) CGFloat sizePoints;
        [Export("sizePoints")]
        nfloat SizePoints { get; }

        // @property (nonatomic, readonly) UAInAppMessageTextInfoAlignmentType alignment;
        [Export("alignment")]
        UAInAppMessageTextInfoAlignmentType Alignment { get; }

        // @property (nonatomic, readonly) UAInAppMessageTextInfoStyleType style;
        [Export("style")]
        UAInAppMessageTextInfoStyleType Style { get; }

        // @property (nonatomic, readonly, nullable) NSArray<NSString *> *fontFamilies;
        [NullAllowed, Export("fontFamilies")]
        string[] FontFamilies { get; }

        // + (nullable instancetype)textInfoWithBuilderBlock: (nonnull void (^)(UAInAppMessageTextInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("textInfoWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageTextInfo TextInfo (Action<UAInAppMessageTextInfoBuilder> builderBlock);

        // - (nullable UAInAppMessageTextInfo *)extend: (nonnull void (^)(UAInAppMessageTextInfoBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageTextInfo Extend (Action<UAInAppMessageTextInfoBuilder> builderBlock);
    }

    // @interface UAInAppMessageTextStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextStyle
    {
        // @property (nonatomic, strong, readwrite, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *letterSpacing;
        [NullAllowed, Export("letterSpacing", ArgumentSemantic.Strong)]
        NSNumber LetterSpacing { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *lineSpacing;
        [NullAllowed, Export("lineSpacing", ArgumentSemantic.Strong)]
        NSNumber LineSpacing { get; set; }

        // + (nonnull instancetype) styleWithAdditionalPadding:(nullable UAPadding *)additionalPadding letterSpacing:(nullable NSNumber *)letterSpacing lineSpacing:(nullable NSNumber *)lineSpacing;
        [Static]
        [Export("styleWithAdditionalPadding:letterSpacing:lineSpacing:")]
        UAInAppMessageTextStyle Style ([NullAllowed] UAPadding additionalPadding, [NullAllowed] NSNumber letterSpacing, [NullAllowed] NSNumber lineSpacing);

        // + (nonnull instancetype)styleWithDictionary:(nullable NSDictionary *)textStyle;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageTextStyle Style ([NullAllowed] NSDictionary textStyle);
    }

    // @protocol UALandingPageBuilderExtender <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALandingPageBuilderExtender
    {
        // - (void)extendScheduleBuilder:(nonnull UAScheduleBuilder *)builder;
        [Export("extendScheduleBuilder:")]
        void ExtendScheduleBuilder (UAScheduleBuilder builder);

        // - (void)extendMessageBuilder:(nonnull UAInAppMessageBuilder *)builder;
        [Export("extendMessageBuilder:")]
        void ExtendMessageBuilder (UAInAppMessageBuilder builder);
    }

    interface IUALandingPageBuilderExtender { }

    // @interface UALandingPageAction : NSObject <UAAction>
    [BaseType(typeof(NSObject))]
    interface UALandingPageAction : IUAAction
    {
        // @property (nonatomic, assign, unsafe_unretained, readwrite, nullable) NSNumber *borderRadiusPoints;
        [NullAllowed, Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        NSNumber BorderRadiusPoints { get; set; }

        // @property (nonatomic, weak, readwrite) id<UALandingPageBuilderExtender> _Nullable builderExtender;
        [NullAllowed, Export("builderExtender")]
        UALandingPageBuilderExtender BuilderExtender { get; set; }
    }

    // @interface UALegacyInAppMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessage
    {
        // @property (nonatomic, readonly) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (nonatomic, strong, readwrite) NSDate *_Nonnull expiry;
        [Export("expiry", ArgumentSemantic.Strong)]
        NSDate Expiry { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *extra;
        [NullAllowed, Export("extra", ArgumentSemantic.Copy)]
        NSDictionary Extra { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UALegacyInAppMessageDisplayType displayType;
        [Export("displayType", ArgumentSemantic.Assign)]
        UALegacyInAppMessageDisplayType DisplayType { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *alert;
        [NullAllowed, Export("alert")]
        string Alert { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UALegacyInAppMessagePosition position;
        [Export("position", ArgumentSemantic.Assign)]
        UALegacyInAppMessagePosition Position { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval duration;
        [Export("duration", ArgumentSemantic.Assign)]
        double Duration { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UIColor *primaryColor;
        [NullAllowed, Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UIColor *secondaryColor;
        [NullAllowed, Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *buttonGroup;
        [NullAllowed, Export("buttonGroup")]
        string ButtonGroup { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *buttonActions;
        [NullAllowed, Export("buttonActions", ArgumentSemantic.Copy)]
        NSDictionary ButtonActions { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *onClick;
        [NullAllowed, Export("onClick", ArgumentSemantic.Copy)]
        NSDictionary OnClick { get; set; }

        // @property (nonatomic, readonly, nullable) NSArray *notificationActions;
        [NullAllowed, Export("notificationActions")]
        NSObject[] NotificationActions { get; }

        // @property (nonatomic, readonly, nullable) UNNotificationCategory *buttonCategory;
        [NullAllowed, Export("buttonCategory")]
        UNNotificationCategory ButtonCategory { get; }

        // + (nonnull instancetype)message;
        [Static]
        [Export("message")]
        UALegacyInAppMessage Message ();

        // + (nullable instancetype)messageWithPayload:(nonnull NSDictionary *)payload;
        [Static]
        [Export("messageWithPayload:")]
        [return: NullAllowed]
        UALegacyInAppMessage Message (NSDictionary payload);

        // - (BOOL)isEqualToMessage:(nullable UALegacyInAppMessage *)message;
        [Export("isEqualToMessage:")]
        bool IsEqualToMessage ([NullAllowed] UALegacyInAppMessage message);
    }

    // @protocol UALegacyInAppMessageFactoryDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessageFactoryDelegate
    {
        // - (nonnull UASchedule *)scheduleForMessage: (nonnull UALegacyInAppMessage *)message;
        [Abstract]
        [Export("scheduleForMessage:")]
        UASchedule Schedule (UALegacyInAppMessage message);
    }

    interface IUALegacyInAppMessageFactoryDelegate { }

    // @protocol UALegacyInAppMessageBuilderExtender <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessageBuilderExtender
    {
        // - (void)extendScheduleBuilder:(nonnull UAScheduleBuilder *)builder message:(nonnull UALegacyInAppMessage *)message;
        [Export("extendScheduleBuilder:message:")]
        void ExtendScheduleBuilder (UAScheduleBuilder builder, UALegacyInAppMessage message);

        // - (void)extendMessageBuilder:(nonnull UAInAppMessageBuilder *)builder message:(nonnull UALegacyInAppMessage *)message;
        [Export("extendMessageBuilder:message:")]
        void ExtendMessageBuilder (UAInAppMessageBuilder builder, UALegacyInAppMessage message);
    }

    interface IUALegacyInAppMessageBuilderExtender { }

    // @interface UALegacyInAppMessaging : NSObject <UAComponent, UALegacyInAppMessageFactoryDelegate>
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessaging : IUAComponent, IUALegacyInAppMessageFactoryDelegate
    {
        // @property (class, nonatomic, readonly, null_unspecified) UALegacyInAppMessaging *shared;
        [Static]
        [Export("shared")]
        UALegacyInAppMessaging Shared { get; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) BOOL displayASAPEnabled;
        [Export("displayASAPEnabled")]
        bool DisplayASAPEnabled { get; set; }

        // @property (nonatomic, weak, readwrite) id<UALegacyInAppMessageFactoryDelegate> _Nullable factoryDelegate;
        [NullAllowed, Export("factoryDelegate", ArgumentSemantic.Assign)]
        NSObject WeakFactoryDelegate { get; set; }

        [Wrap("WeakFactoryDelegate")]
        [NullAllowed]
        IUALegacyInAppMessageFactoryDelegate FactoryDelegate { get; set; }

        // @property(nonatomic, weak) id<UALegacyInAppMessageBuilderExtender> builderExtender
        [NullAllowed, Export("builderExtender")]
        UALegacyInAppMessageBuilderExtender BuilderExtender { get; set; }
    }

    // @interface UAScheduleBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleBuilder
    {
        // @property (nonatomic, copy, readwrite) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSInteger priority;
        [Export("priority", ArgumentSemantic.Assign)]
        nint Priority { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSUInteger limit;
        [Export("limit")]
        nuint Limit { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<UAScheduleTrigger *> *triggers;
        [NullAllowed, Export("triggers", ArgumentSemantic.Copy)]
        UAScheduleTrigger[] Triggers { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSDate *start;
        [NullAllowed, Export("start", ArgumentSemantic.Strong)]
        NSDate Start { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSDate *end;
        [NullAllowed, Export("end", ArgumentSemantic.Strong)]
        NSDate End { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAScheduleDelay *delay;
        [NullAllowed, Export("delay", ArgumentSemantic.Strong)]
        UAScheduleDelay Delay { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval interval;
        [Export("interval", ArgumentSemantic.Assign)]
        double Interval { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *group;
        [NullAllowed, Export("group")]
        string Group { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval editGracePeriod;
        [Export("editGracePeriod", ArgumentSemantic.Assign)]
        double EditGracePeriod { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAScheduleAudience *audience;
        [NullAllowed, Export("audience", ArgumentSemantic.Strong)]
        UAScheduleAudience Audience { get; set; }
    }

    // @interface UASchedule : NSObject
    [BaseType(typeof(NSObject))]
    interface UASchedule
    {
        // @property (nonatomic, readonly) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (nonatomic, readonly) NSString *_Nonnull group;
        [Export("group")]
        string Group { get; }

        // @property (nonatomic, readonly) NSDictionary *_Nonnull metadata;
        [Export("metadata")]
        NSDictionary Metadata { get; }

        // @property (nonatomic, readonly) NSInteger priority;
        [Export("priority")]
        nint Priority { get; }

        // @property (nonatomic, readonly) NSArray<UAScheduleTrigger *> *_Nonnull triggers;
        [Export("triggers")]
        UAScheduleTrigger[] Triggers { get; }

        // @property (nonatomic, readonly, nullable) UAScheduleAudience *audience;
        [NullAllowed, Export("audience")]
        UAScheduleAudience Audience { get; }

        // @property (nonatomic, readonly) NSUInteger limit;
        [Export("limit")]
        nuint Limit { get; }

        // @property (nonatomic, readonly, nullable) NSDate *start;
        [NullAllowed, Export("start")]
        NSDate Start { get; }

        // @property (nonatomic, readonly, nullable) NSDate *end;
        [NullAllowed, Export("end")]
        NSDate End { get; }

        // @property (nonatomic, readonly, nullable) UAScheduleDelay *delay;
        [NullAllowed, Export("delay")]
        UAScheduleDelay Delay { get; }

        // @property (nonatomic, readonly) NSTimeInterval editGracePeriod;
        [Export("editGracePeriod")]
        double EditGracePeriod { get; }

        // @property (nonatomic, readonly) NSTimeInterval interval;
        [Export("interval")]
        double Interval { get; }

        // @property (nonatomic, readonly) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // - (BOOL)isEqualToSchedule:(nullable UASchedule *)schedule;
        [Export("isEqualToSchedule:")]
        bool IsEqualToSchedule ([NullAllowed] UASchedule schedule);
    }

    // @interface UAScheduleAction : NSObject <UAAction>
    [BaseType(typeof(NSObject))]
    interface UAScheduleAction : IUAAction
    {
    }

    // @interface UAScheduleAudienceBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleAudienceBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) NSNumber *notificationsOptIn;
        [NullAllowed, Export("notificationsOptIn", ArgumentSemantic.Strong)]
        NSNumber NotificationsOptIn { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *locationOptIn;
        [NullAllowed, Export("locationOptIn", ArgumentSemantic.Strong)]
        NSNumber LocationOptIn { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<NSString *> *languageTags;
        [NullAllowed, Export("languageTags", ArgumentSemantic.Copy)]
        string[] LanguageTags { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UATagSelector *tagSelector;
        [NullAllowed, Export("tagSelector", ArgumentSemantic.Strong)]
        UATagSelector TagSelector { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAJSONPredicate *versionPredicate;
        [NullAllowed, Export("versionPredicate", ArgumentSemantic.Strong)]
        UAJSONPredicate VersionPredicate { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAScheduleAudienceMissBehaviorType missBehavior;
        [Export("missBehavior", ArgumentSemantic.Assign)]
        UAScheduleAudienceMissBehaviorType MissBehavior { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // @interface UAScheduleAudience : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleAudience
    {
        // @property (nonatomic, readonly, nullable) NSNumber *notificationsOptIn;
        [NullAllowed, Export("notificationsOptIn")]
        NSNumber NotificationsOptIn { get; }

        // @property (nonatomic, readonly, nullable) NSNumber *locationOptIn;
        [NullAllowed, Export("locationOptIn")]
        NSNumber LocationOptIn { get; }

        // @property (nonatomic, readonly, nullable) NSArray<NSString *> *languageIDs;
        [NullAllowed, Export("languageIDs")]
        string[] LanguageIDs { get; }

        // @property (nonatomic, readonly, nullable) UATagSelector *tagSelector;
        [NullAllowed, Export("tagSelector")]
        UATagSelector TagSelector { get; }

        // @property (nonatomic, readonly, nullable) UAJSONPredicate *versionPredicate;
        [NullAllowed, Export("versionPredicate")]
        UAJSONPredicate VersionPredicate { get; }

        // @property (nonatomic, readonly) UAScheduleAudienceMissBehaviorType missBehavior;
        [Export("missBehavior")]
        UAScheduleAudienceMissBehaviorType MissBehavior { get; }

        // + (nullable instancetype)audienceWithBuilderBlock: (nonnull void (^)(UAScheduleAudienceBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("audienceWithBuilderBlock:")]
        [return: NullAllowed]
        UAScheduleAudience Audience (Action<UAScheduleAudienceBuilder> builderBlock);
    }

    // @interface UAScheduleDeferredData : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleDeferredData
    {
        // @property (nonatomic, readonly) NSURL *_Nonnull URL;
        [Export("URL")]
        NSUrl URL { get; }

        // @property (nonatomic, readonly, getter=isRetriableOnTimeout) BOOL retriableOnTimeout;
        [Export("retriableOnTimeout")]
        bool RetriableOnTimeout { [Bind("isRetriableOnTimeout")] get; }

        // @property (nonatomic, readonly) UAScheduleDataDeferredType type;
        [Export("type")]
        UAScheduleDataDeferredType Type { get; }

        // + (nonnull instancetype)deferredDataWithURL:(nonnull NSURL *)URL retriableOnTimeout:(BOOL)retriableOnTimeout;
        [Static]
        [Export("deferredDataWithURL:retriableOnTimeout:")]
        UAScheduleDeferredData DeferredData (NSUrl URL, bool retriableOnTimeout);

        // + (nonnull instancetype)deferredDataWithURL:(nonnull NSURL *)URL retriableOnTimeout:(BOOL)retriableOnTimeout type:(UAScheduleDataDeferredType)type;
        [Static]
        [Export("deferredDataWithURL:retriableOnTimeout:type:")]
        UAScheduleDeferredData DeferredData (NSUrl URL, bool retriableOnTimeout, UAScheduleDataDeferredType type);

        // + (nullable instancetype)deferredDataWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable) error;
        [Static]
        [Export("deferredDataWithJSON:error:")]
        [return: NullAllowed]
        UAScheduleDeferredData DeferredData (NSObject json, [NullAllowed] out NSError error);

        // - (nonnull NSDictionary *)toJSON;
        [Export("toJSON")]
        NSDictionary ToJSON ();
    }

    // @interface UAScheduleDelayBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleDelayBuilder
    {
        // @property (nonatomic, assign, unsafe_unretained, readwrite) NSTimeInterval seconds;
        [Export("seconds", ArgumentSemantic.Assign)]
        double Seconds { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray *screens;
        [NullAllowed, Export("screens", ArgumentSemantic.Copy)]
        NSObject[] Screens { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSString *regionID;
        [NullAllowed, Export("regionID")]
        string RegionID { get; set; }

        // @property (nonatomic, assign, unsafe_unretained, readwrite) UAScheduleDelayAppState appState;
        [Export("appState", ArgumentSemantic.Assign)]
        UAScheduleDelayAppState AppState { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSArray<UAScheduleTrigger *> *cancellationTriggers;
        [NullAllowed, Export("cancellationTriggers", ArgumentSemantic.Copy)]
        UAScheduleTrigger[] CancellationTriggers { get; set; }
    }

    // @interface UAScheduleDelay : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleDelay
    {
        // @property (nonatomic, readonly) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // @property (nonatomic, readonly) NSTimeInterval seconds;
        [Export("seconds")]
        double Seconds { get; }

        // @property (nonatomic, readonly, nullable) NSArray *screens;
        [NullAllowed, Export("screens")]
        NSObject[] Screens { get; }

        // @property (nonatomic, readonly, nullable) NSString *regionID;
        [NullAllowed, Export("regionID")]
        string RegionID { get; }

        // @property (nonatomic, readonly) UAScheduleDelayAppState appState;
        [Export("appState")]
        UAScheduleDelayAppState AppState { get; }

        // @property (nonatomic, readonly) NSArray<UAScheduleTrigger *> *_Nonnull cancellationTriggers;
        [Export("cancellationTriggers")]
        UAScheduleTrigger[] CancellationTriggers { get; }

        // + (nonnull instancetype)delayWithBuilderBlock: (nonnull void (^)(UAScheduleDelayBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("delayWithBuilderBlock:")]
        UAScheduleDelay Delay (Action<UAScheduleDelayBuilder> builderBlock);

        // + (nullable instancetype)delayWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("delayWithJSON:error:")]
        [return: NullAllowed]
        UAScheduleDelay Delay (NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)isEqualToDelay:(nullable UAScheduleDelay *)delay;
        [Export("isEqualToDelay:")]
        bool IsEqualToDelay ([NullAllowed] UAScheduleDelay delay);
    }

    // @interface UAScheduleEditsBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleEditsBuilder
    {
        // @property (nonatomic, strong, readwrite, nullable) NSNumber *priority;
        [NullAllowed, Export("priority", ArgumentSemantic.Strong)]
        NSNumber Priority { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *limit;
        [NullAllowed, Export("limit", ArgumentSemantic.Strong)]
        NSNumber Limit { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSDate *start;
        [NullAllowed, Export("start", ArgumentSemantic.Strong)]
        NSDate Start { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSDate *end;
        [NullAllowed, Export("end", ArgumentSemantic.Strong)]
        NSDate End { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) NSNumber *interval;
        [NullAllowed, Export("interval", ArgumentSemantic.Strong)]
        NSNumber Interval { get; set; }

        // @property (nonatomic, copy, readwrite, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; set; }

        // @property (nonatomic, strong, readwrite) NSNumber *_Nonnull editGracePeriod;
        [Export("editGracePeriod", ArgumentSemantic.Strong)]
        NSNumber EditGracePeriod { get; set; }

        // @property (nonatomic, strong, readwrite, nullable) UAScheduleAudience *audience;
        [NullAllowed, Export("audience", ArgumentSemantic.Strong)]
        UAScheduleAudience Audience { get; set; }
    }

    // @interface UAScheduleEdits : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleEdits
    {
        // @property (nonatomic, readonly, nullable) NSNumber *priority;
        [NullAllowed, Export("priority")]
        NSNumber Priority { get; }

        // @property (nonatomic, readonly, nullable) NSNumber *limit;
        [NullAllowed, Export("limit")]
        NSNumber Limit { get; }

        // @property (nonatomic, readonly, nullable) NSDate *start;
        [NullAllowed, Export("start")]
        NSDate Start { get; }

        // @property (nonatomic, readonly, nullable) NSDate *end;
        [NullAllowed, Export("end")]
        NSDate End { get; }

        // @property (nonatomic, readonly, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata")]
        NSDictionary Metadata { get; }

        // @property (nonatomic, readonly, nullable) NSNumber *interval;
        [NullAllowed, Export("interval")]
        NSNumber Interval { get; }

        // @property (nonatomic, readonly, nullable) NSNumber *editGracePeriod;
        [NullAllowed, Export("editGracePeriod")]
        NSNumber EditGracePeriod { get; }

        // @property (nonatomic, readonly, nullable) UAScheduleAudience *audience;
        [NullAllowed, Export("audience")]
        UAScheduleAudience Audience { get; }

        // + (nonnull instancetype) editsWithMessage:(nonnull UAInAppMessage *)message builderBlock: (nonnull void (^)(UAScheduleEditsBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("editsWithMessage:builderBlock:")]
        UAScheduleEdits Edits (UAInAppMessage message, Action<UAScheduleEditsBuilder> builderBlock);

        // + (nonnull instancetype) editsWithActions:(nonnull NSDictionary *)actions builderBlock: (nonnull void (^)(UAScheduleEditsBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("editsWithActions:builderBlock:")]
        UAScheduleEdits Edits (NSDictionary actions, Action<UAScheduleEditsBuilder> builderBlock);

        // + (nonnull instancetype)editsWithBuilderBlock: (nonnull void (^)(UAScheduleEditsBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("editsWithBuilderBlock:")]
        UAScheduleEdits Edits (Action<UAScheduleEditsBuilder> builderBlock);
    }

    // @interface UAScheduleTrigger : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface UAScheduleTrigger : INSSecureCoding
    {
        // @property (nonatomic, readonly) UAScheduleTriggerType type;
        [Export("type")]
        UAScheduleTriggerType Type { get; }

        // @property (nonatomic, readonly) NSNumber *_Nonnull goal;
        [Export("goal")]
        NSNumber Goal { get; }

        // + (nonnull instancetype)appInitTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("appInitTriggerWithCount:")]
        UAScheduleTrigger AppInitTrigger (nuint count);

        // + (nonnull instancetype)foregroundTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("foregroundTriggerWithCount:")]
        UAScheduleTrigger ForegroundTrigger (nuint count);

        // + (nonnull instancetype)backgroundTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("backgroundTriggerWithCount:")]
        UAScheduleTrigger BackgroundTrigger (nuint count);

        // + (nonnull instancetype)activeSessionTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("activeSessionTriggerWithCount:")]
        UAScheduleTrigger ActiveSessionTrigger (nuint count);

        // + (nonnull instancetype)regionEnterTriggerForRegionID: (nonnull NSString *)regionID count:(NSUInteger)count;
        [Static]
        [Export("regionEnterTriggerForRegionID:count:")]
        UAScheduleTrigger RegionEnterTrigger (string regionID, nuint count);

        // + (nonnull instancetype)regionExitTriggerForRegionID: (nonnull NSString *)regionID count:(NSUInteger)count;
        [Static]
        [Export("regionExitTriggerForRegionID:count:")]
        UAScheduleTrigger RegionExitTrigger (string regionID, nuint count);

        // + (nonnull instancetype)screenTriggerForScreenName: (nonnull NSString *)screenName count:(NSUInteger)count;
        [Static]
        [Export("screenTriggerForScreenName:count:")]
        UAScheduleTrigger ScreenTrigger (string screenName, nuint count);

        // + (nonnull instancetype)customEventTriggerWithPredicate: (nonnull UAJSONPredicate *)predicate count:(NSUInteger)count;
        [Static]
        [Export("customEventTriggerWithPredicate:count:")]
        UAScheduleTrigger CustomEventTrigger (UAJSONPredicate predicate, nuint count);

        // + (nonnull instancetype) customEventTriggerWithPredicate:(nonnull UAJSONPredicate *)predicate value:(nonnull NSNumber *)value;
        [Static]
        [Export("customEventTriggerWithPredicate:value:")]
        UAScheduleTrigger CustomEventTrigger (UAJSONPredicate predicate, NSNumber value);

        // + (nonnull instancetype)versionTriggerWithConstraint: (nonnull NSString *)versionConstraint count:(NSUInteger)count;
        [Static]
        [Export("versionTriggerWithConstraint:count:")]
        UAScheduleTrigger VersionTrigger (string versionConstraint, nuint count);

        // + (nullable instancetype)triggerWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("triggerWithJSON:error:")]
        [return: NullAllowed]
        UAScheduleTrigger Trigger (NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)isEqualToTrigger:(nullable UAScheduleTrigger *)trigger;
        [Export("isEqualToTrigger:")]
        bool IsEqualToTrigger ([NullAllowed] UAScheduleTrigger trigger);
    }

    // @interface UATagSelector : NSObject
    [BaseType(typeof(NSObject))]
    interface UATagSelector
    {
        // + (nonnull instancetype)and:(nonnull NSArray<UATagSelector *> *)selectors;
        [Static]
        [Export("and:")]
        UATagSelector And (UATagSelector[] selectors);

        // + (nonnull instancetype)or:(nonnull NSArray<UATagSelector *> *)selectors;
        [Static]
        [Export("or:")]
        UATagSelector Or (UATagSelector[] selectors);

        // + (nonnull instancetype)not:(nonnull UATagSelector *)selector;
        [Static]
        [Export("not:")]
        UATagSelector Not (UATagSelector selector);

        // + (nonnull instancetype)tag:(nonnull NSString *)tag;
        [Static]
        [Export("tag:")]
        UATagSelector Tag (string tag);

        // - (BOOL)apply:(nonnull NSArray<NSString *> *)tags;
        [Export("apply:")]
        bool Apply (string[] tags);
    }
}
