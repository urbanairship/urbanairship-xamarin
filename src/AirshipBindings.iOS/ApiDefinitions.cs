/*
 Copyright Airship and Contributors
*/
using CoreGraphics;
using CoreLocation;
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
        // extern NSString *const _Nonnull UAActionMetadataPushPayloadKey
        [Field("UAActionMetadataPushPayloadKey", "__Internal")]
        NSString UAActionMetadataPushPayloadKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataForegroundPresentationKey
        [Field("UAActionMetadataForegroundPresentationKey", "__Internal")]
        NSString UAActionMetadataForegroundPresentationKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataInboxMessageKey
        [Field("UAActionMetadataInboxMessageKey", "__Internal")]
        NSString UAActionMetadataInboxMessageKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataUserNotificationActionIDKey
        [Field("UAActionMetadataUserNotificationActionIDKey", "__Internal")]
        NSString UAActionMetadataUserNotificationActionIDKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataResponseInfoKey
        [Field("UAActionMetadataResponseInfoKey", "__Internal")]
        NSString UAActionMetadataResponseInfoKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataRegisteredName
        [Field("UAActionMetadataRegisteredName", "__Internal")]
        NSString UAActionMetadataRegisteredName { get; }

        // extern NSString *const _Nonnull UAActionScheduleInfoActionsKey
        [Field("UAActionScheduleInfoActionsKey", "__Internal")]
        NSString UAActionScheduleInfoActionsKey { get; }

        // extern NSString *const _Nonnull UAAddCustomEventActionErrorDomain
        [Field("UAAddCustomEventActionErrorDomain", "__Internal")]
        NSString UAAddCustomEventActionErrorDomain { get; }

        // extern const NSUInteger UAAssociatedIdentifiersMaxCount
        [Field("UAAssociatedIdentifiersMaxCount", "__Internal")]
        nuint UAAssociatedIdentifiersMaxCount { get; }

        // extern const NSUInteger UAAssociatedIdentifiersMaxCharacterCount
        [Field("UAAssociatedIdentifiersMaxCharacterCount", "__Internal")]
        nuint UAAssociatedIdentifiersMaxCharacterCount { get; }

        // extern const NSUInteger UAAutomationScheduleLimit
        [Field("UAAutomationScheduleLimit", "__Internal")]
        nuint UAAutomationScheduleLimit { get; }

        // extern NSString *const UACancelSchedulesActionAll
        [Field("UACancelSchedulesActionAll", "__Internal")]
        NSString UACancelSchedulesActionAll { get; }

        // extern NSString *const UACancelSchedulesActionIDs
        [Field("UACancelSchedulesActionIDs", "__Internal")]
        NSString UACancelSchedulesActionIDs { get; }

        // extern NSString *const UACancelSchedulesActionGroups
        [Field("UACancelSchedulesActionGroups", "__Internal")]
        NSString UACancelSchedulesActionGroups { get; }

        // extern NSString *const UAChannelCreatedEvent
        [Field("UAChannelCreatedEvent", "__Internal")]
        NSString UAChannelCreatedEvent { get; }

        // extern NSString *const UAChannelUpdatedEvent
        [Field("UAChannelUpdatedEvent", "__Internal")]
        NSString UAChannelUpdatedEvent { get; }

        // extern NSString *const UAChannelRegistrationFailedEvent
        [Field("UAChannelRegistrationFailedEvent", "__Internal")]
        NSString UAChannelRegistrationFailedEvent { get; }

        // extern NSString *const UAChannelCreatedEventChannelKey
        [Field("UAChannelCreatedEventChannelKey", "__Internal")]
        NSString UAChannelCreatedEventChannelKey { get; }

        // extern NSString *const UAChannelUpdatedEventChannelKey
        [Field("UAChannelUpdatedEventChannelKey", "__Internal")]
        NSString UAChannelUpdatedEventChannelKey { get; }

        // extern NSString *const UAChannelCreatedEventExistingKey
        [Field("UAChannelCreatedEventExistingKey", "__Internal")]
        NSString UAChannelCreatedEventExistingKey { get; }

        // extern const NSUInteger UACustomEventCharacterLimit
        [Field("UACustomEventCharacterLimit", "__Internal")]
        nuint UACustomEventCharacterLimit { get; }

        // extern const NSUInteger UACustomEventMaxPropertiesCount
        [Field("UACustomEventMaxPropertiesCount", "__Internal")]
        nuint UACustomEventMaxPropertiesCount { get; }

        // extern NSString *const UACustomEventNameKey
        [Field("UACustomEventNameKey", "__Internal")]
        NSString UACustomEventNameKey { get; }

        // extern NSString *const UACustomEventValueKey
        [Field("UACustomEventValueKey", "__Internal")]
        NSString UACustomEventValueKey { get; }

        // extern NSString *const UACustomEventPropertiesKey
        [Field("UACustomEventPropertiesKey", "__Internal")]
        NSString UACustomEventPropertiesKey { get; }

        // extern NSString *const UACustomEventTransactionIDKey
        [Field("UACustomEventTransactionIDKey", "__Internal")]
        NSString UACustomEventTransactionIDKey { get; }

        // extern NSString *const UACustomEventInteractionIDKey
        [Field("UACustomEventInteractionIDKey", "__Internal")]
        NSString UACustomEventInteractionIDKey { get; }

        // extern NSString *const UACustomEventInteractionTypeKey
        [Field("UACustomEventInteractionTypeKey", "__Internal")]
        NSString UACustomEventInteractionTypeKey { get; }

        // extern NSString *const UAEnableUserNotificationsActionValue
        [Field("UAEnableUserNotificationsActionValue", "__Internal")]
        NSString UAEnableUserNotificationsActionValue { get; }

        // extern NSString *const UAEnableLocationActionValue
        [Field("UAEnableLocationActionValue", "__Internal")]
        NSString UAEnableLocationActionValue { get; }

        // extern NSString *const UAEnableBackgroundLocationActionValue
        [Field("UAEnableBackgroundLocationActionValue", "__Internal")]
        NSString UAEnableBackgroundLocationActionValue { get; }

        // extern BOOL uaLoggingEnabled
        [Field("uaLoggingEnabled", "__Internal")]
        nuint uaLoggingEnabled { get; }

        // extern UALogLevel uaLogLevel
        [Field("uaLogLevel", "__Internal")]
        UALogLevel uaLogLevel { get; }

        // extern BOOL uaLoudImpErrorLoggingEnabled
        [Field("uaLoudImpErrorLoggingEnabled", "__Internal")]
        nuint uaLoudImpErrorLoggingEnabled { get; }

        // extern NSString *const _Nonnull UAJSONMatcherErrorDomain
        [Field("UAJSONMatcherErrorDomain", "__Internal")]
        NSString UAJSONMatcherErrorDomain { get; }

        // extern NSString *const _Nonnull UAJSONPredicateErrorDomain
        [Field("UAJSONPredicateErrorDomain", "__Internal")]
        NSString UAJSONPredicateErrorDomain { get; }

        // extern NSString *const _Nonnull UAJSONValueMatcherErrorDomain
        [Field("UAJSONValueMatcherErrorDomain", "__Internal")]
        NSString UAJSONValueMatcherErrorDomain { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventForegroundKey
        [Field("UALocationEventForegroundKey", "__Internal")]
        NSString UALocationEventForegroundKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventLatitudeKey
        [Field("UALocationEventLatitudeKey", "__Internal")]
        NSString UALocationEventLatitudeKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventLongitudeKey
        [Field("UALocationEventLongitudeKey", "__Internal")]
        NSString UALocationEventLongitudeKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventDesiredAccuracyKey
        [Field("UALocationEventDesiredAccuracyKey", "__Internal")]
        NSString UALocationEventDesiredAccuracyKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventUpdateTypeKey
        [Field("UALocationEventUpdateTypeKey", "__Internal")]
        NSString UALocationEventUpdateTypeKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventProviderKey
        [Field("UALocationEventProviderKey", "__Internal")]
        NSString UALocationEventProviderKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventDistanceFilterKey
        [Field("UALocationEventDistanceFilterKey", "__Internal")]
        NSString UALocationEventDistanceFilterKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventHorizontalAccuracyKey
        [Field("UALocationEventHorizontalAccuracyKey", "__Internal")]
        NSString UALocationEventHorizontalAccuracyKey { get; }

        // extern UALocationEventAnalyticsKey * const UALocationEventVerticalAccuracyKey
        [Field("UALocationEventVerticalAccuracyKey", "__Internal")]
        NSString UALocationEventVerticalAccuracyKey { get; }

        // extern UALocationEventUpdateType * const UALocationEventAnalyticsType
        [Field("UALocationEventAnalyticsType", "__Internal")]
        NSString UALocationEventAnalyticsType { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeChange
        [Field("UALocationEventUpdateTypeChange", "__Internal")]
        NSString UALocationEventUpdateTypeChange { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeContinuous
        [Field("UALocationEventUpdateTypeContinuous", "__Internal")]
        NSString UALocationEventUpdateTypeContinuous { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeSingle
        [Field("UALocationEventUpdateTypeSingle", "__Internal")]
        NSString UALocationEventUpdateTypeSingle { get; }

        // extern UALocationEventUpdateType * const UALocationEventUpdateTypeNone
        [Field("UALocationEventUpdateTypeNone", "__Internal")]
        NSString UALocationEventUpdateTypeNone { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderGps
        [Field("UALocationServiceProviderGps", "__Internal")]
        NSString UALocationServiceProviderGps { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderNetwork
        [Field("UALocationServiceProviderNetwork", "__Internal")]
        NSString UALocationServiceProviderNetwork { get; }

        // extern UALocationServiceProviderType *const UALocationServiceProviderUnknown
        [Field("UALocationServiceProviderUnknown", "__Internal")]
        NSString UALocationServiceProviderUnknown { get; }

        // extern NSString * const UAAnalyticsValueNone
        [Field("UAAnalyticsValueNone", "__Internal")]
        NSString UAAnalyticsValueNone { get; }

        // extern NSString *const _Nonnull UAModulesPush
        [Field("UAModulesPush", "__Internal")]
        NSString UAModulesPush { get; }

        // extern NSString *const _Nonnull UAModulesAnalytics
        [Field("UAModulesAnalytics", "__Internal")]
        NSString UAModulesAnalytics { get; }

        // extern NSString *const _Nonnull UAModulesMessageCenter
        [Field("UAModulesMessageCenter", "__Internal")]
        NSString UAModulesMessageCenter { get; }

        // extern NSString *const _Nonnull UAModulesInAppMessaging
        [Field("UAModulesInAppMessaging", "__Internal")]
        NSString UAModulesInAppMessaging { get; }

        // extern NSString *const _Nonnull UAModulesAutomation
        [Field("UAModulesAutomation", "__Internal")]
        NSString UAModulesAutomation { get; }

        // extern NSString *const _Nonnull UAModulesNamedUser
        [Field("UAModulesNamedUser", "__Internal")]
        NSString UAModulesNamedUser { get; }

        // extern NSString *const _Nonnull UAModulesLocation
        [Field("UAModulesLocation", "__Internal")]
        NSString UAModulesLocation { get; }

        // extern NSString *const _Nonnull UANotificationDefaultActionIdentifier
        [Field("UANotificationDefaultActionIdentifier", "__Internal")]
        NSString UANotificationDefaultActionIdentifier { get; }

        // extern NSString *const _Nonnull UANotificationDismissActionIdentifier
        [Field("UANotificationDismissActionIdentifier", "__Internal")]
        NSString UANotificationDismissActionIdentifier { get; }

        // extern NSString *const _Nonnull UAOpenExternalURLActionErrorDomain
        [Field("UAOpenExternalURLActionErrorDomain", "__Internal")]
        NSString UAOpenExternalURLActionErrorDomain { get; }

        // extern NSString *const _Nonnull UAPaddingTopKey
        [Field("UAPaddingTopKey", "__Internal")]
        NSString UAPaddingTopKey { get; }

        // extern NSString *const _Nonnull UAPaddingBottomKey
        [Field("UAPaddingBottomKey", "__Internal")]
        NSString UAPaddingBottomKey { get; }

        // extern NSString *const _Nonnull UAPaddingTrailingKey
        [Field("UAPaddingTrailingKey", "__Internal")]
        NSString UAPaddingTrailingKey { get; }

        // extern NSString *const _Nonnull UAPaddingLeadingKey
        [Field("UAPaddingLeadingKey", "__Internal")]
        NSString UAPaddingLeadingKey { get; }

        // extern NSString *const _Nonnull UAReceivedNotificationResponseEvent
        [Field("UAReceivedNotificationResponseEvent", "__Internal")]
        NSString UAReceivedNotificationResponseEvent { get; }

        // extern NSString *const _Nonnull UAReceivedForegroundNotificationEvent
        [Field("UAReceivedForegroundNotificationEvent", "__Internal")]
        NSString UAReceivedForegroundNotificationEvent { get; }

        // extern NSString *const _Nonnull UAReceivedBackgroundNotificationEvent
        [Field("UAReceivedBackgroundNotificationEvent", "__Internal")]
        NSString UAReceivedBackgroundNotificationEvent { get; }

        // static const UANotificationOptions UANotificationOptionNone = 0
        [Field("UANotificationOptionNone", "__Internal")]
        UANotificationOptions UANotificationOptionNone { get; }

        // extern NSString *const _Nonnull UAScheduleDelayErrorDomain
        [Field("UAScheduleDelayErrorDomain", "__Internal")]
        NSString UAScheduleDelayErrorDomain { get; }

        // extern NSString *const _Nonnull UAScheduleDelaySecondsKey
        [Field("UAScheduleDelaySecondsKey", "__Internal")]
        NSString UAScheduleDelaySecondsKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayRegionKey
        [Field("UAScheduleDelayRegionKey", "__Internal")]
        NSString UAScheduleDelayRegionKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayScreensKey
        [Field("UAScheduleDelayScreensKey", "__Internal")]
        NSString UAScheduleDelayScreensKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayCancellationTriggersKey
        [Field("UAScheduleDelayCancellationTriggersKey", "__Internal")]
        NSString UAScheduleDelayCancellationTriggersKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateKey
        [Field("UAScheduleDelayAppStateKey", "__Internal")]
        NSString UAScheduleDelayAppStateKey { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateForegroundName
        [Field("UAScheduleDelayAppStateForegroundName", "__Internal")]
        NSString UAScheduleDelayAppStateForegroundName { get; }

        // extern NSString *const _Nonnull UAScheduleDelayAppStateBackgroundName
        [Field("UAScheduleDelayAppStateBackgroundName", "__Internal")]
        NSString UAScheduleDelayAppStateBackgroundName { get; }

        // extern const NSUInteger UAScheduleDelayMaxCancellationTriggers
        [Field("UAScheduleDelayMaxCancellationTriggers", "__Internal")]
        nuint UAScheduleDelayMaxCancellationTriggers { get; }

        // extern const NSUInteger UAScheduleInfoMaxTriggers
        [Field("UAScheduleInfoMaxTriggers", "__Internal")]
        nuint UAScheduleInfoMaxTriggers { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerErrorDomain
        [Field("UAScheduleTriggerErrorDomain", "__Internal")]
        NSString UAScheduleTriggerErrorDomain { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerTypeKey
        [Field("UAScheduleTriggerTypeKey", "__Internal")]
        NSString UAScheduleTriggerTypeKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerPredicateKey
        [Field("UAScheduleTriggerPredicateKey", "__Internal")]
        NSString UAScheduleTriggerPredicateKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerGoalKey
        [Field("UAScheduleTriggerGoalKey", "__Internal")]
        NSString UAScheduleTriggerGoalKey { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppInitName
        [Field("UAScheduleTriggerAppInitName", "__Internal")]
        NSString UAScheduleTriggerAppInitName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppForegroundName
        [Field("UAScheduleTriggerAppForegroundName", "__Internal")]
        NSString UAScheduleTriggerAppForegroundName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerAppBackgroundName
        [Field("UAScheduleTriggerAppBackgroundName", "__Internal")]
        NSString UAScheduleTriggerAppBackgroundName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerRegionEnterName
        [Field("UAScheduleTriggerRegionEnterName", "__Internal")]
        NSString UAScheduleTriggerRegionEnterName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerRegionExitName
        [Field("UAScheduleTriggerRegionExitName", "__Internal")]
        NSString UAScheduleTriggerRegionExitName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerCustomEventCountName
        [Field("UAScheduleTriggerCustomEventCountName", "__Internal")]
        NSString UAScheduleTriggerCustomEventCountName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerCustomEventValueName
        [Field("UAScheduleTriggerCustomEventValueName", "__Internal")]
        NSString UAScheduleTriggerCustomEventValueName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerScreenName
        [Field("UAScheduleTriggerScreenName", "__Internal")]
        NSString UAScheduleTriggerScreenName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerActiveSessionName
        [Field("UAScheduleTriggerActiveSessionName", "__Internal")]
        NSString UAScheduleTriggerActiveSessionName { get; }

        // extern NSString *const _Nonnull UAScheduleTriggerVersionName
        [Field("UAScheduleTriggerVersionName", "__Internal")]
        NSString UAScheduleTriggerVersionName { get; }

        // extern NSString * const UAUserCreatedNotification
        [Field("UAUserCreatedNotification", "__Internal")]
        NSString UAUserCreatedNotification { get; }

        // extern NSString *const _Nonnull UAirshipTakeOffBackgroundThreadException
        [Field("UAirshipTakeOffBackgroundThreadException", "__Internal")]
        NSString UAirshipTakeOffBackgroundThreadException { get; }

        // extern const NSUInteger UAInAppMessageIDLimit
        [Field("UAInAppMessageIDLimit", "__Internal")]
        nuint UAInAppMessageIDLimit { get; }

        // extern const NSUInteger UAInAppMessageNameLimit
        [Field("UAInAppMessageNameLimit", "__Internal")]
        nuint UAInAppMessageNameLimit { get; }

        // extern NSString *const _Nonnull UAInAppMessageDisplayBehaviorDefault
        [Field("UAInAppMessageDisplayBehaviorDefault", "__Internal")]
        NSString UAInAppMessageDisplayBehaviorDefault { get; }

        // extern NSString *const _Nonnull UAInAppMessageDisplayBehaviorImmediate
        [Field("UAInAppMessageDisplayBehaviorImmediate", "__Internal")]
        NSString UAInAppMessageDisplayBehaviorImmediate { get; }

        // extern NSString *const _Nonnull UABannerStyleFileName
        [Field("UABannerStyleFileName", "__Internal")]
        NSString UABannerStyleFileName { get; }

        // extern const NSUInteger UAInAppMessageBannerMaxButtons
        [Field("UAInAppMessageBannerMaxButtons", "__Internal")]
        nuint UAInAppMessageBannerMaxButtons { get; }

        // extern NSString *const _Nonnull UABannerAdditionalPaddingKey
        [Field("UABannerAdditionalPaddingKey", "__Internal")]
        NSString UABannerAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UABannerTextStyleKey
        [Field("UABannerTextStyleKey", "__Internal")]
        NSString UABannerTextStyleKey { get; }

        // extern NSString *const _Nonnull UABannerHeaderStyleKey
        [Field("UABannerHeaderStyleKey", "__Internal")]
        NSString UABannerHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UABannerBodyStyleKey
        [Field("UABannerBodyStyleKey", "__Internal")]
        NSString UABannerBodyStyleKey { get; }

        // extern NSString *const _Nonnull UABannerButtonStyleKey
        [Field("UABannerButtonStyleKey", "__Internal")]
        NSString UABannerButtonStyleKey { get; }

        // extern NSString *const _Nonnull UABannerMediaStyleKey
        [Field("UABannerMediaStyleKey", "__Internal")]
        NSString UABannerMediaStyleKey { get; }

        // extern NSString *const _Nonnull UABannerMaxWidthKey
        [Field("UABannerMaxWidthKey", "__Internal")]
        NSString UABannerMaxWidthKey { get; }

        // extern const NSUInteger UAInAppMessageButtonInfoIDLimit
        [Field("UAInAppMessageButtonInfoIDLimit", "__Internal")]
        nuint UAInAppMessageButtonInfoIDLimit { get; }

        // extern NSString *const _Nonnull UAButtonAdditionalPaddingKey
        [Field("UAButtonAdditionalPaddingKey", "__Internal")]
        NSString UAButtonAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAButtonStyleKey
        [Field("UAButtonStyleKey", "__Internal")]
        NSString UAButtonStyleKey { get; }

        // extern NSString *const _Nonnull UAStackedButtonSpacingKey
        [Field("UAStackedButtonSpacingKey", "__Internal")]
        NSString UAStackedButtonSpacingKey { get; }

        // extern NSString *const _Nonnull UASeparatedButtonSpacingKey
        [Field("UASeparatedButtonSpacingKey", "__Internal")]
        NSString UASeparatedButtonSpacingKey { get; }

        // extern NSString *const _Nonnull UAButtonHeightKey
        [Field("UAButtonHeightKey", "__Internal")]
        NSString UAButtonHeightKey { get; }

        // extern NSString *const UAInAppMessageBodyKey
        [Field("UAInAppMessageBodyKey", "__Internal")]
        NSString UAInAppMessageBodyKey { get; }

        // extern NSString *const UAInAppMessageHeadingKey
        [Field("UAInAppMessageHeadingKey", "__Internal")]
        NSString UAInAppMessageHeadingKey { get; }

        // extern NSString *const UAInAppMessageBackgroundColorKey
        [Field("UAInAppMessageBackgroundColorKey", "__Internal")]
        NSString UAInAppMessageBackgroundColorKey { get; }

        // extern NSString *const UAInAppMessagePlacementKey
        [Field("UAInAppMessagePlacementKey", "__Internal")]
        NSString UAInAppMessagePlacementKey { get; }

        // extern NSString *const UAInAppMessageContentLayoutKey
        [Field("UAInAppMessageContentLayoutKey", "__Internal")]
        NSString UAInAppMessageContentLayoutKey { get; }

        // extern NSString *const UAInAppMessageBorderRadiusKey
        [Field("UAInAppMessageBorderRadiusKey", "__Internal")]
        NSString UAInAppMessageBorderRadiusKey { get; }

        // extern NSString *const UAInAppMessageButtonLayoutKey
        [Field("UAInAppMessageButtonLayoutKey", "__Internal")]
        NSString UAInAppMessageButtonLayoutKey { get; }

        // extern NSString *const UAInAppMessageButtonsKey
        [Field("UAInAppMessageButtonsKey", "__Internal")]
        NSString UAInAppMessageButtonsKey { get; }

        // extern NSString *const UAInAppMessageMediaKey
        [Field("UAInAppMessageMediaKey", "__Internal")]
        NSString UAInAppMessageMediaKey { get; }

        // extern NSString *const UAInAppMessageURLKey
        [Field("UAInAppMessageURLKey", "__Internal")]
        NSString UAInAppMessageURLKey { get; }

        // extern NSString *const UAInAppMessageDismissButtonColorKey
        [Field("UAInAppMessageDismissButtonColorKey", "__Internal")]
        NSString UAInAppMessageDismissButtonColorKey { get; }

        // extern NSString *const UAInAppMessageFooterKey
        [Field("UAInAppMessageFooterKey", "__Internal")]
        NSString UAInAppMessageFooterKey { get; }

        // extern NSString *const UAInAppMessageDurationKey
        [Field("UAInAppMessageDurationKey", "__Internal")]
        NSString UAInAppMessageDurationKey { get; }

        // extern NSString *const UAInAppMessageModalAllowsFullScreenKey
        [Field("UAInAppMessageModalAllowsFullScreenKey", "__Internal")]
        NSString UAInAppMessageModalAllowsFullScreenKey { get; }

        // extern NSString *const UAInAppMessageHTMLAllowsFullScreenKey
        [Field("UAInAppMessageHTMLAllowsFullScreenKey", "__Internal")]
        NSString UAInAppMessageHTMLAllowsFullScreenKey { get; }

        // extern NSString *const UAInAppMessageHTMLHeightKey
        [Field("UAInAppMessageHTMLHeightKey", "__Internal")]
        NSString UAInAppMessageHTMLHeightKey { get; }

        // extern NSString *const UAInAppMessageHTMLWidthKey
        [Field("UAInAppMessageHTMLWidthKey", "__Internal")]
        NSString UAInAppMessageHTMLWidthKey { get; }

        // extern NSString *const UAInAppMessageHTMLAspectLockKey
        [Field("UAInAppMessageHTMLAspectLockKey", "__Internal")]
        NSString UAInAppMessageHTMLAspectLockKey { get; }

        // extern NSString *const UAInAppMessageHTMLRequireConnectivityKey
        [Field("UAInAppMessageHTMLRequireConnectivityKey", "__Internal")]
        NSString UAInAppMessageHTMLRequireConnectivityKey { get; }

        // extern NSString *const UAInAppMessageButtonLayoutStackedValue
        [Field("UAInAppMessageButtonLayoutStackedValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutStackedValue { get; }

        // extern NSString *const UAInAppMessageButtonLayoutSeparateValue
        [Field("UAInAppMessageButtonLayoutSeparateValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutSeparateValue { get; }

        // extern NSString *const UAInAppMessageButtonLayoutJoinedValue
        [Field("UAInAppMessageButtonLayoutJoinedValue", "__Internal")]
        NSString UAInAppMessageButtonLayoutJoinedValue { get; }

        // static NSString *const UAInAppMessageDisplayCoordinatorIsReadyKey = @"isReady"
        [Field("UAInAppMessageDisplayCoordinatorIsReadyKey", "__Internal")]
        NSString UAInAppMessageDisplayCoordinatorIsReadyKey { get; }

        // extern NSString *const _Nonnull UAFullScreenStyleFileName
        [Field("UAFullScreenStyleFileName", "__Internal")]
        NSString UAFullScreenStyleFileName { get; }

        // extern const NSUInteger UAInAppMessageFullScreenMaxButtons
        [Field("UAInAppMessageFullScreenMaxButtons", "__Internal")]
        nuint UAInAppMessageFullScreenMaxButtons { get; }

        // extern NSString *const _Nonnull UAFullScreenDismissIconResourceKey
        [Field("UAFullScreenDismissIconResourceKey", "__Internal")]
        NSString UAFullScreenDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAFullScreenAdditonalPaddingKey
        [Field("UAFullScreenAdditonalPaddingKey", "__Internal")]
        NSString UAFullScreenAdditonalPaddingKey { get; }

        // extern NSString *const _Nonnull UAFullScreenTextStyleKey
        [Field("UAFullScreenTextStyleKey", "__Internal")]
        NSString UAFullScreenTextStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenHeaderStyleKey
        [Field("UAFullScreenHeaderStyleKey", "__Internal")]
        NSString UAFullScreenHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenBodyStyleKey
        [Field("UAFullScreenBodyStyleKey", "__Internal")]
        NSString UAFullScreenBodyStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenButtonStyleKey
        [Field("UAFullScreenButtonStyleKey", "__Internal")]
        NSString UAFullScreenButtonStyleKey { get; }

        // extern NSString *const _Nonnull UAFullScreenMediaStyleKey
        [Field("UAFullScreenMediaStyleKey", "__Internal")]
        NSString UAFullScreenMediaStyleKey { get; }

        // extern NSString *const _Nonnull UAHTMLStyleFileName
        [Field("UAHTMLStyleFileName", "__Internal")]
        NSString UAHTMLStyleFileName { get; }

        // extern NSString *const _Nonnull UAHTMLDismissIconResourceKey
        [Field("UAHTMLDismissIconResourceKey", "__Internal")]
        NSString UAHTMLDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAHTMLAdditionalPaddingKey
        [Field("UAHTMLAdditionalPaddingKey", "__Internal")]
        NSString UAHTMLAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAHTMLMaxWidthKey
        [Field("UAHTMLMaxWidthKey", "__Internal")]
        NSString UAHTMLMaxWidthKey { get; }

        // extern NSString *const _Nonnull UAHTMLMaxHeightKey
        [Field("UAHTMLMaxHeightKey", "__Internal")]
        NSString UAHTMLMaxHeightKey { get; }

        // extern NSString *const _Nonnull UAHTMLHideDismissIconKey
        [Field("UAHTMLHideDismissIconKey", "__Internal")]
        NSString UAHTMLHideDismissIconKey { get; }

        // extern NSString *const _Nonnull UAMediaAdditionalPaddingKey
        [Field("UAMediaAdditionalPaddingKey", "__Internal")]
        NSString UAMediaAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAModalStyleFileName
        [Field("UAModalStyleFileName", "__Internal")]
        NSString UAModalStyleFileName { get; }

        // extern const NSUInteger UAInAppMessageModalMaxButtons
        [Field("UAInAppMessageModalMaxButtons", "__Internal")]
        nuint UAInAppMessageModalMaxButtons { get; }

        // extern NSString *const _Nonnull UAModalDismissIconResourceKey
        [Field("UAModalDismissIconResourceKey", "__Internal")]
        NSString UAModalDismissIconResourceKey { get; }

        // extern NSString *const _Nonnull UAModalAdditionalPaddingKey
        [Field("UAModalAdditionalPaddingKey", "__Internal")]
        NSString UAModalAdditionalPaddingKey { get; }

        // extern NSString *const _Nonnull UAModalTextStyleKey
        [Field("UAModalTextStyleKey", "__Internal")]
        NSString UAModalTextStyleKey { get; }

        // extern NSString *const _Nonnull UAModalHeaderStyleKey
        [Field("UAModalHeaderStyleKey", "__Internal")]
        NSString UAModalHeaderStyleKey { get; }

        // extern NSString *const _Nonnull UAModalBodyStyleKey
        [Field("UAModalBodyStyleKey", "__Internal")]
        NSString UAModalBodyStyleKey { get; }

        // extern NSString *const _Nonnull UAModalButtonStyleKey
        [Field("UAModalButtonStyleKey", "__Internal")]
        NSString UAModalButtonStyleKey { get; }

        // extern NSString *const _Nonnull UAModalMediaStyleKey
        [Field("UAModalMediaStyleKey", "__Internal")]
        NSString UAModalMediaStyleKey { get; }

        // extern NSString *const _Nonnull UAModalMaxWidthKey
        [Field("UAModalMaxWidthKey", "__Internal")]
        NSString UAModalMaxWidthKey { get; }

        // extern NSString *const _Nonnull UAModalMaxHeightKey
        [Field("UAModalMaxHeightKey", "__Internal")]
        NSString UAModalMaxHeightKey { get; }

        // extern NSString *const _Nonnull UAScheduleInfoInAppMessageKey
        [Field("UAScheduleInfoInAppMessageKey", "__Internal")]
        NSString UAScheduleInfoInAppMessageKey { get; }

        // extern NSString *const _Nonnull UATextAdditonalPaddingKey
        [Field("UATextAdditonalPaddingKey", "__Internal")]
        NSString UATextAdditonalPaddingKey { get; }

        // extern NSString *const _Nonnull UATextSpacingKey
        [Field("UATextSpacingKey", "__Internal")]
        NSString UATextSpacingKey { get; }

        // extern NSString *const _Nonnull UALineSpacingKey
        [Field("UALineSpacingKey", "__Internal")]
        NSString UALineSpacingKey { get; }

        // extern NSString *const _Nonnull UAInboxMessageListWillUpdateNotification
        [Field("UAInboxMessageListWillUpdateNotification", "__Internal")]
        NSString UAInboxMessageListWillUpdateNotification { get; }

        // extern NSString *const _Nonnull UAInboxMessageListUpdatedNotification
        [Field("UAInboxMessageListUpdatedNotification", "__Internal")]
        NSString UAInboxMessageListUpdatedNotification { get; }

        // extern NSString *const _Nonnull UALandingPageURLKey
        [Field("UALandingPageURLKey", "__Internal")]
        NSString UALandingPageURLKey { get; }

        // extern NSString *const _Nonnull UALandingPageHeightKey
        [Field("UALandingPageHeightKey", "__Internal")]
        NSString UALandingPageHeightKey { get; }

        // extern NSString *const _Nonnull UALandingPageWidthKey
        [Field("UALandingPageWidthKey", "__Internal")]
        NSString UALandingPageWidthKey { get; }

        // extern NSString *const _Nonnull UALandingPageAspectLockKey
        [Field("UALandingPageAspectLockKey", "__Internal")]
        NSString UALandingPageAspectLockKey { get; }

        // extern NSString *const _Nonnull UALandingPageFill
        [Field("UALandingPageFill", "__Internal")]
        NSString UALandingPageFill { get; }

        // extern const CGFloat defaultBorderRadiusPoints
        [Field("defaultBorderRadiusPoints", "__Internal")]
        nfloat defaultBorderRadiusPoints { get; }

        // extern NSString *const UAMessageDataScheme
        [Field("UAMessageDataScheme", "__Internal")]
        NSString UAMessageDataScheme { get; }

        // extern NSString *const UANavigationBarStyleDefaultKey
        [Field("UANavigationBarStyleDefaultKey", "__Internal")]
        NSString UANavigationBarStyleDefaultKey { get; }

        // extern NSString *const UANavigationBarStyleBlackKey
        [Field("UANavigationBarStyleBlackKey", "__Internal")]
        NSString UANavigationBarStyleBlackKey { get; }

        // extern NSString *const _Nonnull UAOverlayInboxMessageActionErrorDomain
        [Field("UAOverlayInboxMessageActionErrorDomain", "__Internal")]
        NSString UAOverlayInboxMessageActionErrorDomain { get; }

        // extern NSString *const UARateAppShowLinkPromptKey
        [Field("UARateAppShowLinkPromptKey", "__Internal")]
        NSString UARateAppShowLinkPromptKey { get; }

        // extern NSString *const UARateAppLinkPromptTitleKey
        [Field("UARateAppLinkPromptTitleKey", "__Internal")]
        NSString UARateAppLinkPromptTitleKey { get; }

        // extern NSString *const UARateAppLinkPromptBodyKey
        [Field("UARateAppLinkPromptBodyKey", "__Internal")]
        NSString UARateAppLinkPromptBodyKey { get; }

        // extern NSString *const UARateAppItunesIDKey
        [Field("UARateAppItunesIDKey", "__Internal")]
        NSString UARateAppItunesIDKey { get; }

    }

    // @interface UAAccountEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAccountEventTemplate
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // + (nonnull instancetype)registeredTemplate;
        [Static]
        [Export("registeredTemplate")]
        UAAccountEventTemplate RegisteredTemplate();

        // + (nonnull instancetype)registeredTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("registeredTemplateWithValueFromString:")]
        UAAccountEventTemplate RegisteredTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)registeredTemplateWithValue:(nullable NSNumber *)eventValue;
        [Static]
        [Export("registeredTemplateWithValue:")]
        UAAccountEventTemplate RegisteredTemplate([NullAllowed] NSNumber eventValue);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent();
    }

    // typedef BOOL (^UAActionPredicate)(UAActionArguments *_Nonnull)
    delegate bool UAActionPredicate(UAActionArguments arg0);

    // typedef void (^UAActionCompletionHandler)(UAActionResult *_Nonnull)
    delegate void UAActionCompletionHandler(UAActionResult arg0);

    // typedef void (^UAActionBlock)(UAActionArguments *_Nonnull, UAActionCompletionHandler _Nonnull)
    delegate void UAActionBlock(UAActionArguments arg0, [BlockCallback] UAActionCompletionHandler arg1);

    // @interface UAAction : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAction
    {

        // - (BOOL)acceptsArguments:(nonnull UAActionArguments *)arguments;
        [Export("acceptsArguments:")]
        bool AcceptsArguments(UAActionArguments arguments);

        // - (void)willPerformWithArguments:(nonnull UAActionArguments *)arguments;
        [Export("willPerformWithArguments:")]
        void WillPerform(UAActionArguments arguments);

        // - (void)didPerformWithArguments:(nonnull UAActionArguments *)arguments withResult:(nonnull UAActionResult *)result;
        [Export("didPerformWithArguments:withResult:")]
        void DidPerform(UAActionArguments arguments, UAActionResult result);

        // - (void)performWithArguments:(nonnull UAActionArguments *)arguments completionHandler:(nonnull UAActionCompletionHandler)completionHandler;
        [Export("performWithArguments:completionHandler:")]
        void Perform(UAActionArguments arguments, UAActionCompletionHandler completionHandler);

        // + (nonnull instancetype)actionWithBlock:(nonnull UAActionBlock)actionBlock;
        [Static]
        [Export("actionWithBlock:")]
        UAAction Action(UAActionBlock actionBlock);

        // + (nonnull instancetype)actionWithBlock:(nonnull UAActionBlock)actionBlock acceptingArguments:(nullable UAActionPredicate)predicateBlock;
        [Static]
        [Export("actionWithBlock:acceptingArguments:")]
        UAAction Action(UAActionBlock actionBlock, [NullAllowed] UAActionPredicate predicateBlock);
    }

    // @interface UAActionArguments : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionArguments
    {
        // @property (readonly, assign, nonatomic) UASituation situation;
        [Export("situation", ArgumentSemantic.Assign)]
        UASituation Situation { get; }

        // @property (readonly, strong, nonatomic, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; }

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation;
        [Static]
        [Export("argumentsWithValue:withSituation:")]
        UAActionArguments Arguments([NullAllowed] NSObject value, UASituation situation);

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation metadata:(nullable NSDictionary *)metadata;
        [Static]
        [Export("argumentsWithValue:withSituation:metadata:")]
        UAActionArguments Arguments([NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);
    }

    // @interface UAActionRegistry : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRegistry
    {
        // @property (readonly, nonatomic) NSSet<NSMutableDictionary *> *_Nonnull registeredEntries;
        [Export("registeredEntries")]
        NSSet<NSMutableDictionary> RegisteredEntries { get; }

        // + (nonnull instancetype)defaultRegistry;
        [Static]
        [Export("defaultRegistry")]
        UAActionRegistry DefaultRegistry();

        // - (BOOL)registerAction:(nonnull UAAction *)action name:(nonnull NSString *)name predicate:(nullable UAActionPredicate)predicate;
        [Export("registerAction:name:predicate:")]
        bool RegisterAction(UAAction action, string name, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass name:(nonnull NSString *)name predicate:(nullable UAActionPredicate)predicate;
        [Export("registerActionClass:name:predicate:")]
        bool RegisterActionClass(Class actionClass, string name, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerAction:(nonnull UAAction *)action names:(nonnull NSArray *)names predicate:(nullable UAActionPredicate)predicate;
        [Export("registerAction:names:predicate:")]
        bool RegisterAction(UAAction action, NSObject[] names, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass names:(nonnull NSArray *)names predicate:(nullable UAActionPredicate)predicate;
        [Export("registerActionClass:names:predicate:")]
        bool RegisterActionClass(Class actionClass, NSObject[] names, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerAction:(nonnull UAAction *)action name:(nonnull NSString *)name;
        [Export("registerAction:name:")]
        bool RegisterAction(UAAction action, string name);

        // - (BOOL)registerAction:(nonnull UAAction *)action names:(nonnull NSArray *)names;
        [Export("registerAction:names:")]
        bool RegisterAction(UAAction action, NSObject[] names);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass name:(nonnull NSString *)name;
        [Export("registerActionClass:name:")]
        bool RegisterActionClass(Class actionClass, string name);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass names:(nonnull NSArray *)names;
        [Export("registerActionClass:names:")]
        bool RegisterActionClass(Class actionClass, NSObject[] names);

        // - (nullable UAActionRegistryEntry *)registryEntryWithName:(nonnull NSString *)name;
        [Export("registryEntryWithName:")]
        [return: NullAllowed]
        UAActionRegistryEntry RegistryEntry(string name);

        // - (BOOL)addSituationOverride:(UASituation)situation forEntryWithName:(nonnull NSString *)name action:(nullable UAAction *)action;
        [Export("addSituationOverride:forEntryWithName:action:")]
        bool AddSituationOverride(UASituation situation, string name, [NullAllowed] UAAction action);

        // - (BOOL)updatePredicate:(nullable UAActionPredicate)predicate forEntryWithName:(nonnull NSString *)name;
        [Export("updatePredicate:forEntryWithName:")]
        bool UpdatePredicate([NullAllowed] UAActionPredicate predicate, string name);

        // - (BOOL)updateAction:(nonnull UAAction *)action forEntryWithName:(nonnull NSString *)name;
        [Export("updateAction:forEntryWithName:")]
        bool UpdateAction(UAAction action, string name);

        // - (BOOL)updateActionClass:(nonnull Class)actionClass forEntryWithName:(nonnull NSString *)name;
        [Export("updateActionClass:forEntryWithName:")]
        bool UpdateActionClass(Class actionClass, string name);

        // - (BOOL)removeName:(nonnull NSString *)name;
        [Export("removeName:")]
        bool RemoveName(string name);

        // - (BOOL)removeEntryWithName:(nonnull NSString *)name;
        [Export("removeEntryWithName:")]
        bool RemoveEntry(string name);

        // - (BOOL)addName:(nonnull NSString *)name forEntryWithName:(nonnull NSString *)entryName;
        [Export("addName:forEntryWithName:")]
        bool AddName(string name, string entryName);
    }

    // @interface UAActionRegistryEntry : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRegistryEntry
    {
        // @property (readwrite, strong, nonatomic) UAAction *_Nonnull action;
        [Export("action", ArgumentSemantic.Strong)]
        UAAction Action { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) UAActionPredicate predicate;
        [NullAllowed, Export("predicate", ArgumentSemantic.Copy)]
        UAActionPredicate Predicate { get; set; }

        // @property (readonly, nonatomic) NSArray<NSString *> *_Nonnull names;
        [Export("names")]
        string[] Names { get; }

        // + (nonnull instancetype)entryForAction:(nonnull UAAction *)action predicate:(nonnull UAActionPredicate)predicate;
        [Static]
        [Export("entryForAction:predicate:")]
        UAActionRegistryEntry Entry(UAAction action, UAActionPredicate predicate);

        // + (nonnull instancetype)entryForActionClass:(nonnull Class)actionClass predicate:(nonnull UAActionPredicate)predicate;
        [Static]
        [Export("entryForActionClass:predicate:")]
        UAActionRegistryEntry Entry(Class actionClass, UAActionPredicate predicate);

        // - (nonnull UAAction *)actionForSituation:(UASituation)situation;
        [Export("actionForSituation:")]
        UAAction ActionForSituation(UASituation situation);
    }

    // @interface UAActionResult : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionResult
    {
        // @property (readonly, strong, nonatomic, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (readonly, assign, nonatomic) UAActionFetchResult fetchResult;
        [Export("fetchResult", ArgumentSemantic.Assign)]
        UAActionFetchResult FetchResult { get; }

        // @property (readonly, strong, nonatomic, nullable) NSError *error;
        [NullAllowed, Export("error", ArgumentSemantic.Strong)]
        NSError Error { get; }

        // @property (readonly, assign, nonatomic) UAActionStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        UAActionStatus Status { get; }

        // + (nonnull instancetype)resultWithValue:(nullable id)value;
        [Static]
        [Export("resultWithValue:")]
        UAActionResult Result([NullAllowed] NSObject value);

        // + (nonnull instancetype)resultWithValue:(nullable id)result withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithValue:withFetchResult:")]
        UAActionResult Result([NullAllowed] NSObject result, UAActionFetchResult fetchResult);

        // + (nonnull instancetype)emptyResult;
        [Static]
        [Export("emptyResult")]
        UAActionResult EmptyResult();

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error;
        [Static]
        [Export("resultWithError:")]
        UAActionResult Result(NSError error);

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithError:withFetchResult:")]
        UAActionResult Result(NSError error, UAActionFetchResult fetchResult);
    }

    // @interface UAActionRunner : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRunner
    {

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation;
        [Static]
        [Export("runActionWithName:value:situation:")]
        void RunAction(string actionName, [NullAllowed] NSObject value, UASituation situation);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation metadata:(nonnull NSDictionary *)metadata;
        [Static]
        [Export("runActionWithName:value:situation:metadata:")]
        void RunAction(string actionName, [NullAllowed] NSObject value, UASituation situation, NSDictionary metadata);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation completionHandler:(nonnull UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runActionWithName:value:situation:completionHandler:")]
        void RunAction(string actionName, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata completionHandler:(nullable UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runActionWithName:value:situation:metadata:completionHandler:")]
        void RunAction(string actionName, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation;
        [Static]
        [Export("runAction:value:situation:")]
        void RunAction(UAAction action, [NullAllowed] NSObject value, UASituation situation);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata;
        [Static]
        [Export("runAction:value:situation:metadata:")]
        void RunAction(UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation completionHandler:(nonnull UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runAction:value:situation:completionHandler:")]
        void RunAction(UAAction action, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata completionHandler:(nullable UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runAction:value:situation:metadata:completionHandler:")]
        void RunAction(UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);
    }

    // @interface UAActionScheduleEditsBuilder : UAScheduleEditsBuilder
    [BaseType(typeof(UAScheduleEditsBuilder))]
    interface UAActionScheduleEditsBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Strong)]
        NSDictionary Actions { get; set; }

    }

    // @interface UAActionScheduleEdits : UAScheduleEdits
    [BaseType(typeof(UAScheduleEdits))]
    interface UAActionScheduleEdits
    {
        // @property (readonly, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nonnull instancetype)editsWithBuilderBlock:(nonnull void (^)(UAActionScheduleEditsBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("editsWithBuilderBlock:")]
        UAActionScheduleEdits Edits(Action<UAActionScheduleEditsBuilder> builderBlock);
    }

    // @interface UAActionScheduleInfoBuilder : UAScheduleInfoBuilder
    [BaseType(typeof(UAScheduleInfoBuilder))]
    interface UAActionScheduleInfoBuilder
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *group;
        [NullAllowed, Export("group")]
        string Group { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Strong)]
        NSDictionary Actions { get; set; }

    }

    // @interface UAActionScheduleInfo : UAScheduleInfo
    [BaseType(typeof(UAScheduleInfo))]
    interface UAActionScheduleInfo
    {
        // @property (readonly, nonatomic, nullable) NSString *group;
        [NullAllowed, Export("group")]
        string Group { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nonnull instancetype)scheduleInfoWithBuilderBlock:(nonnull void (^)(UAActionScheduleInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("scheduleInfoWithBuilderBlock:")]
        UAActionScheduleInfo ScheduleInfo(Action<UAActionScheduleInfoBuilder> builderBlock);

        // + (nullable instancetype)scheduleInfoWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable) error;
        [Static]
        [Export("scheduleInfoWithJSON:error:")]
        [return: NullAllowed]
        UAActionScheduleInfo ScheduleInfo(NSObject json, [NullAllowed] out NSError error);
    }

    // @interface UAAddCustomEventAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAAddCustomEventAction
    {

    }

    // @interface UAAddTagsAction : UAModifyTagsAction
    [BaseType(typeof(UAModifyTagsAction))]
    interface UAAddTagsAction
    {

    }

    // @interface UAAggregateActionResult : UAActionResult
    [BaseType(typeof(UAActionResult))]
    interface UAAggregateActionResult
    {

        // - (void)addResult:(nonnull UAActionResult *)result forAction:(nonnull NSString *)actionName;
        [Export("addResult:forAction:")]
        void AddResult(UAActionResult result, string actionName);

        // - (nonnull UAActionResult *)resultForAction:(nonnull NSString *)actionName;
        [Export("resultForAction:")]
        UAActionResult Result(string actionName);
    }

    // @interface UAAnalytics : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAAnalytics
    {
        // @property (readonly, copy, nonatomic, nullable) NSString *conversionSendID;
        [NullAllowed, Export("conversionSendID")]
        string ConversionSendID { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *conversionPushMetadata;
        [NullAllowed, Export("conversionPushMetadata")]
        string ConversionPushMetadata { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *conversionRichPushID;
        [NullAllowed, Export("conversionRichPushID")]
        string ConversionRichPushID { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull sessionID;
        [Export("sessionID")]
        string SessionID { get; }

        // @property (readonly, strong, nonatomic) NSDate *_Nonnull lastSendTime;
        [Export("lastSendTime", ArgumentSemantic.Strong)]
        NSDate LastSendTime { get; }

        // @property (readwrite, strong, nonatomic, nullable) id<UAAnalyticsEventConsumerProtocol> eventConsumer;
        [NullAllowed, Export("eventConsumer", ArgumentSemantic.Strong)]
        UAAnalyticsEventConsumerProtocol EventConsumer { get; set; }

        // @property (getter=isEnabled, assign, readwrite, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // - (void)addEvent:(nonnull UAEvent *)event;
        [Export("addEvent:")]
        void AddEvent(UAEvent @event);

        // - (void)associateDeviceIdentifiers:(nonnull UAAssociatedIdentifiers *)associatedIdentifiers;
        [Export("associateDeviceIdentifiers:")]
        void AssociateDeviceIdentifiers(UAAssociatedIdentifiers associatedIdentifiers);

        // - (nonnull UAAssociatedIdentifiers *)currentAssociatedDeviceIdentifiers;
        [Export("currentAssociatedDeviceIdentifiers")]
        UAAssociatedIdentifiers CurrentAssociatedDeviceIdentifiers();

        // - (void)trackScreen:(nullable NSString *)screen;
        [Export("trackScreen:")]
        void TrackScreen([NullAllowed] string screen);

        // - (void)scheduleUpload;
        [Export("scheduleUpload")]
        void ScheduleUpload();
    }

    // @protocol UAAnalyticsEventConsumerProtocol
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAAnalyticsEventConsumerProtocol
    {

        // - (void)eventAdded:(nonnull UAEvent *)event;
        [Abstract]
        [Export("eventAdded:")]
        void EventAdded(UAEvent @event);
    }

    interface IUAAnalyticsEventConsumerProtocol { }

    // @interface UAAppIntegration : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAppIntegration
    {

        // + (void)userNotificationCenter:(nonnull UNUserNotificationCenter *)center didReceiveNotificationResponse:(nonnull UNNotificationResponse *)response withCompletionHandler:(nonnull void (^)(void))completionHandler;
        [Static]
        [Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
        void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

        // + (void)userNotificationCenter:(nonnull UNUserNotificationCenter *)center willPresentNotification:(nonnull UNNotification *)notification withCompletionHandler:(nonnull void (^)(UNNotificationPresentationOptions)) completionHandler;
        [Static]
        [Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
        void UserNotificationCenter(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

        // + (void)application:(nonnull UIApplication *)application performFetchWithCompletionHandler: (nonnull void (^)(UIBackgroundFetchResult))completionHandler;
        [Static]
        [Export("application:performFetchWithCompletionHandler:")]
        void Application(UIApplication application, Action<UIBackgroundFetchResult> completionHandler);

        // + (void)application:(nonnull UIApplication *)application didRegisterForRemoteNotificationsWithDeviceToken:(nonnull NSData *)deviceToken;
        [Static]
        [Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
        void Application(UIApplication application, NSData deviceToken);

        // + (void)application:(nonnull UIApplication *)application didFailToRegisterForRemoteNotificationsWithError:(nonnull NSError *)error;
        [Static]
        [Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
        void Application(UIApplication application, NSError error);

        // + (void)application:(nonnull UIApplication *)application didReceiveRemoteNotification:(nonnull NSDictionary *)userInfo fetchCompletionHandler:(nonnull void (^)(UIBackgroundFetchResult))completionHandler;
        [Static]
        [Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
        void Application(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);
    }

    // @interface UAApplicationMetrics : NSObject
    [BaseType(typeof(NSObject))]
    interface UAApplicationMetrics
    {
        // @property (readonly, strong, nonatomic, nullable) NSDate *lastApplicationOpenDate;
        [NullAllowed, Export("lastApplicationOpenDate", ArgumentSemantic.Strong)]
        NSDate LastApplicationOpenDate { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull currentAppVersion;
        [Export("currentAppVersion")]
        string CurrentAppVersion { get; }

        // @property (readonly, nonatomic) BOOL isAppVersionUpdated;
        [Export("isAppVersionUpdated")]
        bool IsAppVersionUpdated { get; }

    }

    // @interface UAAssociatedIdentifiers : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAssociatedIdentifiers
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *advertisingID;
        [NullAllowed, Export("advertisingID")]
        string AdvertisingID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *vendorID;
        [NullAllowed, Export("vendorID")]
        string VendorID { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL advertisingTrackingEnabled;
        [Export("advertisingTrackingEnabled")]
        bool AdvertisingTrackingEnabled { get; set; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull allIDs;
        [Export("allIDs")]
        NSDictionary AllIDs { get; }

        // + (nonnull instancetype)identifiersWithDictionary:(nonnull NSDictionary<NSString *, NSString *> *)identifiers;
        [Static]
        [Export("identifiersWithDictionary:")]
        UAAssociatedIdentifiers Identifiers(NSDictionary<NSString, NSString> identifiers);

        // - (void)setIdentifier:(nullable NSString *)identifier forKey:(nonnull NSString *)key;
        [Export("setIdentifier:forKey:")]
        void SetIdentifier([NullAllowed] string identifier, string key);
    }

    // @interface UAAutomation : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAAutomation
    {

        // - (void)scheduleActions:(nonnull UAActionScheduleInfo *)scheduleInfo completionHandler:(nullable void (^)(UASchedule *_Nullable))completionHandler;
        [Export("scheduleActions:completionHandler:")]
        void ScheduleActions(UAActionScheduleInfo scheduleInfo, [NullAllowed] Action completionHandler);

        // - (void)scheduleActions:(nonnull UAActionScheduleInfo *)scheduleInfo metadata:(nonnull NSDictionary *)metadata completionHandler:(nullable void (^)(UASchedule *_Nullable))completionHandler;
        [Export("scheduleActions:metadata:completionHandler:")]
        void ScheduleActions(UAActionScheduleInfo scheduleInfo, NSDictionary metadata, [NullAllowed] Action completionHandler);

        // - (void)cancelScheduleWithID:(nonnull NSString *)identifier;
        [Export("cancelScheduleWithID:")]
        void CancelSchedule(string identifier);

        // - (void)cancelSchedulesWithGroup:(nonnull NSString *)group;
        [Export("cancelSchedulesWithGroup:")]
        void CancelSchedules(string group);

        // - (void)cancelAll;
        [Export("cancelAll")]
        void CancelAll();

        // - (void)getScheduleWithID:(nonnull NSString *)identifier completionHandler:(nonnull void (^)(UASchedule *_Nullable))completionHandler;
        [Export("getScheduleWithID:completionHandler:")]
        void GetSchedule(string identifier, Action<UASchedule> completionHandler);

        // - (void)getSchedules:(nonnull void (^)(NSArray<UASchedule *> *_Nonnull))completionHandler;
        [Export("getSchedules:")]
        void GetSchedules(UASchedule[] completionHandler);

        // - (void)getSchedulesWithGroup:(nonnull NSString *)group completionHandler:(nonnull void (^)(NSArray<UASchedule *> *_Nonnull)) completionHandler;
        [Export("getSchedulesWithGroup:completionHandler:")]
        void GetSchedules(string group, UASchedule[] completionHandler);

        // - (void)editScheduleWithID:(nonnull NSString *)identifier edits:(nonnull UAActionScheduleEdits *)edits completionHandler:(nonnull void (^)(UASchedule *_Nullable))completionHandler;
        [Export("editScheduleWithID:edits:completionHandler:")]
        void EditSchedule(string identifier, UAActionScheduleEdits edits, Action<UASchedule> completionHandler);
    }

    // @interface UABespokeCloseView : UIView
    [BaseType(typeof(UIView))]
    interface UABespokeCloseView
    {

    }

    // @interface UABeveledLoadingIndicator : UIView
    [BaseType(typeof(UIView))]
    interface UABeveledLoadingIndicator
    {

        // - (void)show;
        [Export("show")]
        void Show();

        // - (void)hide;
        [Export("hide")]
        void Hide();
    }

    // @interface UACancelSchedulesAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UACancelSchedulesAction
    {

    }

    // @interface UAChannel : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAChannel
    {
        // @property (readonly, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // @property (readwrite, copy, nonatomic) NSArray<NSString *> *_Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; set; }

        // @property (getter=isChannelTagRegistrationEnabled, assign, readwrite, nonatomic) BOOL channelTagRegistrationEnabled;
        [Export("channelTagRegistrationEnabled")]
        bool ChannelTagRegistrationEnabled { [Bind("isChannelTagRegistrationEnabled")] get; set; }

        // - (void)addTag:(nonnull NSString *)tag;
        [Export("addTag:")]
        void AddTag(string tag);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags;
        [Export("addTags:")]
        void AddTags(string[] tags);

        // - (void)removeTag:(nonnull NSString *)tag;
        [Export("removeTag:")]
        void RemoveTag(string tag);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags;
        [Export("removeTags:")]
        void RemoveTags(string[] tags);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        void AddTags(string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        void RemoveTags(string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        void SetTags(string[] tags, string tagGroupID);

        // - (void)enableChannelCreation;
        [Export("enableChannelCreation")]
        void EnableChannelCreation();

        // - (void)updateRegistration;
        [Export("updateRegistration")]
        void UpdateRegistration();
    }

    // @interface UACircularRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface UACircularRegion
    {

        // + (nullable instancetype)circularRegionWithRadius:(nonnull NSNumber *)radius latitude:(nonnull NSNumber *)latitude longitude:(nonnull NSNumber *)longitude;
        [Static]
        [Export("circularRegionWithRadius:latitude:longitude:")]
        [return: NullAllowed]
        UACircularRegion CircularRegion(NSNumber radius, NSNumber latitude, NSNumber longitude);
    }

    // @interface UAComponent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAComponent
    {

        // - (nonnull instancetype)initWithDataStore: (nonnull UAPreferenceDataStore *)dataStore;
        [Export("initWithDataStore:")]
        IntPtr Constructor(UAPreferenceDataStore dataStore);

        // - (void)airshipReady:(nonnull UAirship *)airship;
        [Export("airshipReady:")]
        void AirshipReady(UAirship airship);

        // - (BOOL)componentEnabled;
        [Export("componentEnabled")]
        bool ComponentEnabled();
    }

    // @interface UAConfig : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface UAConfig : INSCopying
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *developmentAppKey;
        [NullAllowed, Export("developmentAppKey")]
        string DevelopmentAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *developmentAppSecret;
        [NullAllowed, Export("developmentAppSecret")]
        string DevelopmentAppSecret { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *productionAppKey;
        [NullAllowed, Export("productionAppKey")]
        string ProductionAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *productionAppSecret;
        [NullAllowed, Export("productionAppSecret")]
        string ProductionAppSecret { get; set; }

        // @property (assign, readwrite, nonatomic) UALogLevel developmentLogLevel;
        [Export("developmentLogLevel", ArgumentSemantic.Assign)]
        UALogLevel DevelopmentLogLevel { get; set; }

        // @property (assign, readwrite, nonatomic) UALogLevel productionLogLevel;
        [Export("productionLogLevel", ArgumentSemantic.Assign)]
        UALogLevel ProductionLogLevel { get; set; }

        // @property (nonatomic, assign) UACloudSite site
        [Export("site", ArgumentSemantic.Assign)]
        UACloudSite Site { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *defaultAppKey;
        [NullAllowed, Export("defaultAppKey")]
        string DefaultAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *defaultAppSecret;
        [NullAllowed, Export("defaultAppSecret")]
        string DefaultAppSecret { get; set; }

        // @property (getter=isInProduction, assign, readwrite, nonatomic) BOOL inProduction;
        [Export("inProduction")]
        bool InProduction { [Bind("isInProduction")] get; set; }

        // @property (getter=isAutomaticSetupEnabled, assign, readwrite, nonatomic) BOOL automaticSetupEnabled;
        [Export("automaticSetupEnabled")]
        bool AutomaticSetupEnabled { [Bind("isAutomaticSetupEnabled")] get; set; }

        // @property (readwrite, strong, nonatomic) NSArray<NSString *> *_Nonnull whitelist;
        [Export("whitelist", ArgumentSemantic.Strong)]
        string[] Whitelist { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull itunesID;
        [Export("itunesID")]
        string ItunesID { get; set; }

        // @property (getter=isAnalyticsEnabled, assign, readwrite, nonatomic) BOOL analyticsEnabled;
        [Export("analyticsEnabled")]
        bool AnalyticsEnabled { [Bind("isAnalyticsEnabled")] get; set; }

        // @property (assign, readwrite, nonatomic) BOOL detectProvisioningMode;
        [Export("detectProvisioningMode")]
        bool DetectProvisioningMode { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull messageCenterStyleConfig;
        [Export("messageCenterStyleConfig")]
        string MessageCenterStyleConfig { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL clearUserOnAppRestore;
        [Export("clearUserOnAppRestore")]
        bool ClearUserOnAppRestore { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL clearNamedUserOnAppRestore;
        [Export("clearNamedUserOnAppRestore")]
        bool ClearNamedUserOnAppRestore { get; set; }

        // @property (getter=isChannelCaptureEnabled, assign, readwrite, nonatomic) BOOL channelCaptureEnabled;
        [Export("channelCaptureEnabled")]
        bool ChannelCaptureEnabled { [Bind("isChannelCaptureEnabled")] get; set; }

        // @property (getter=isOpenURLWhitelistingEnabled, assign, readwrite, nonatomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { [Bind("isOpenURLWhitelistingEnabled")] get; set; }

        // @property (getter=isChannelCreationDelayEnabled, assign, readwrite, nonatomic) BOOL channelCreationDelayEnabled;
        [Export("channelCreationDelayEnabled")]
        bool ChannelCreationDelayEnabled { [Bind("isChannelCreationDelayEnabled")] get; set; }

        // @property (readwrite, copy, nonatomic) NSDictionary *_Nonnull customConfig;
        [Export("customConfig", ArgumentSemantic.Copy)]
        NSDictionary CustomConfig { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL requestAuthorizationToUseNotifications;
        [Export("requestAuthorizationToUseNotifications")]
        bool RequestAuthorizationToUseNotifications { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull deviceAPIURL;
        [Export("deviceAPIURL")]
        string DeviceAPIURL { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull analyticsURL;
        [Export("analyticsURL")]
        string AnalyticsURL { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull remoteDataAPIURL;
        [Export("remoteDataAPIURL")]
        string RemoteDataAPIURL { get; set; }

        // @property (readonly, atomic, nonnull) NSString *appKey;
        [Export("appKey")]
        string AppKey { get; }

        // @property (readonly, atomic, nonnull) NSString *appSecret;
        [Export("appSecret")]
        string AppSecret { get; }

        // @property (readonly, atomic) UALogLevel logLevel;
        [Export("logLevel")]
        UALogLevel LogLevel { get; }

        // + (nonnull UAConfig *)defaultConfig;
        [Static]
        [Export("defaultConfig")]
        UAConfig DefaultConfig();

        // + (nonnull UAConfig *)configWithContentsOfFile:(nonnull NSString *)path;
        [Static]
        [Export("configWithContentsOfFile:")]
        UAConfig Config(string path);

        // - (BOOL)validate;
        [Export("validate")]
        bool Validate();
    }

    // @interface UACustomEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UACustomEvent
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull eventName;
        [Export("eventName")]
        string EventName { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *interactionID;
        [NullAllowed, Export("interactionID")]
        string InteractionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *interactionType;
        [NullAllowed, Export("interactionType")]
        string InteractionType { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary *_Nonnull properties;
        [Export("properties", ArgumentSemantic.Copy)]
        NSDictionary Properties { get; }

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName;
        [Static]
        [Export("eventWithName:")]
        UACustomEvent Event(string eventName);

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName valueFromString:(nullable NSString *)eventValue;
        [Static]
        [Export("eventWithName:valueFromString:")]
        UACustomEvent Event(string eventName, [NullAllowed] string eventValue);

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName value:(nullable NSNumber *)eventValue;
        [Static]
        [Export("eventWithName:value:")]
        UACustomEvent Event(string eventName, [NullAllowed] NSNumber eventValue);

        // - (void)setInteractionFromMessage:(nonnull UAInboxMessage *)message;
        [Export("setInteractionFromMessage:")]
        void SetInteraction(UAInboxMessage message);

        // - (void)setBoolProperty:(BOOL)value forKey:(nonnull NSString *)key;
        [Export("setBoolProperty:forKey:")]
        void SetBoolProperty(bool value, string key);

        // - (void)setStringProperty:(nonnull NSString *)value forKey:(nonnull NSString *)key;
        [Export("setStringProperty:forKey:")]
        void SetStringProperty(string value, string key);

        // - (void)setNumberProperty:(nonnull NSNumber *)value forKey:(nonnull NSString *)key;
        [Export("setNumberProperty:forKey:")]
        void SetNumberProperty(NSNumber value, string key);

        // - (void)track;
        [Export("track")]
        void Track();

        // - (void)setStringArrayProperty:(nonnull NSArray<NSString *> *)value forKey:(nonnull NSString *)key;
        [Export("setStringArrayProperty:forKey:")]
        void SetStringArrayProperty(string[] value, string key);
    }

    // @interface UADeepLinkAction : UAOpenExternalURLAction
    [BaseType(typeof(UAOpenExternalURLAction))]
    interface UADeepLinkAction
    {

    }

    // typedef void (^UADisposalBlock)(void)
    delegate void UADisposalBlock();

    // @interface UADisposable : NSObject
    [BaseType(typeof(NSObject))]
    interface UADisposable
    {

        // + (nonnull instancetype)disposableWithBlock: (nonnull UADisposalBlock)disposalBlock;
        [Static]
        [Export("disposableWithBlock:")]
        UADisposable Disposable(UADisposalBlock disposalBlock);

        // - (void)dispose;
        [Export("dispose")]
        [New]
        void Dispose();
    }

    // @interface UAEnableFeatureAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAEnableFeatureAction
    {

    }

    // @interface UAEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAEvent
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull time;
        [Export("time")]
        string Time { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull eventID;
        [Export("eventID")]
        string EventID { get; }

        // @property (readonly, strong, nonatomic) NSDictionary *_Nonnull data;
        [Export("data", ArgumentSemantic.Strong)]
        NSDictionary Data { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull eventType;
        [Export("eventType")]
        string EventType { get; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAFetchDeviceInfoAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAFetchDeviceInfoAction
    {

    }

    // @interface UAInstallAttributionEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UAInstallAttributionEvent
    {

        // + (nonnull instancetype) eventWithAppPurchaseDate:(nonnull NSDate *)appPurchaseDate iAdImpressionDate:(nonnull NSDate *)iAdImpressionDate;
        [Static]
        [Export("eventWithAppPurchaseDate:iAdImpressionDate:")]
        UAInstallAttributionEvent Event(NSDate appPurchaseDate, NSDate iAdImpressionDate);
    }

    // @interface UAJSONMatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONMatcher
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)matcherWithValueMatcher: (nonnull UAJSONValueMatcher *)valueMatcher;
        [Static]
        [Export("matcherWithValueMatcher:")]
        UAJSONMatcher Matcher(UAJSONValueMatcher valueMatcher);

        // + (nonnull instancetype) matcherWithValueMatcher:(nonnull UAJSONValueMatcher *)valueMatcher scope:(nonnull NSArray<NSString *> *)scope;
        [Static]
        [Export("matcherWithValueMatcher:scope:")]
        UAJSONMatcher Matcher(UAJSONValueMatcher valueMatcher, string[] scope);

        // + (nullable instancetype)matcherWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("matcherWithJSON:error:")]
        [return: NullAllowed]
        UAJSONMatcher Matcher(NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject([NullAllowed] NSObject @object);
    }

    // @interface UAJSONPredicate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONPredicate
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)predicateWithJSONMatcher: (nonnull UAJSONMatcher *)matcher;
        [Static]
        [Export("predicateWithJSONMatcher:")]
        UAJSONPredicate Predicate(UAJSONMatcher matcher);

        // + (nonnull instancetype)andPredicateWithSubpredicates: (nonnull NSArray<UAJSONPredicate *> *)subpredicates;
        [Static]
        [Export("andPredicateWithSubpredicates:")]
        UAJSONPredicate AndPredicate(UAJSONPredicate[] subpredicates);

        // + (nonnull instancetype)orPredicateWithSubpredicates: (nonnull NSArray<UAJSONPredicate *> *)subpredicates;
        [Static]
        [Export("orPredicateWithSubpredicates:")]
        UAJSONPredicate OrPredicate(UAJSONPredicate[] subpredicates);

        // + (nonnull instancetype)notPredicateWithSubpredicate: (nonnull UAJSONPredicate *)subpredicate;
        [Static]
        [Export("notPredicateWithSubpredicate:")]
        UAJSONPredicate NotPredicate(UAJSONPredicate subpredicate);

        // + (nullable instancetype)predicateWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("predicateWithJSON:error:")]
        [return: NullAllowed]
        UAJSONPredicate Predicate(NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject([NullAllowed] NSObject @object);
    }

    // @interface UAJSONValueMatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONValueMatcher
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)matcherWhereNumberAtLeast:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberAtLeast:")]
        UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber number);

        // + (nonnull instancetype) matcherWhereNumberAtLeast:(nonnull NSNumber *)lowerNumber atMost:(nonnull NSNumber *)higherNumber;
        [Static]
        [Export("matcherWhereNumberAtLeast:atMost:")]
        UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber lowerNumber, NSNumber higherNumber);

        // + (nonnull instancetype)matcherWhereNumberAtMost:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberAtMost:")]
        UAJSONValueMatcher MatcherWhereNumberAtMost(NSNumber number);

        // + (nonnull instancetype)matcherWhereNumberEquals:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberEquals:")]
        UAJSONValueMatcher MatcherWhereNumberEquals(NSNumber number);

        // + (nonnull instancetype)matcherWhereBooleanEquals:(BOOL)boolean;
        [Static]
        [Export("matcherWhereBooleanEquals:")]
        UAJSONValueMatcher MatcherWhereBooleanEquals(bool boolean);

        // + (nonnull instancetype)matcherWhereStringEquals:(nonnull NSString *)string;
        [Static]
        [Export("matcherWhereStringEquals:")]
        UAJSONValueMatcher MatcherWhereStringEquals(string @string);

        // + (nonnull instancetype)matcherWhereValueIsPresent:(BOOL)present;
        [Static]
        [Export("matcherWhereValueIsPresent:")]
        UAJSONValueMatcher MatcherWhereValueIsPresent(bool present);

        // + (nullable instancetype)matcherWithVersionConstraint: (nonnull NSString *)versionConstraint;
        [Static]
        [Export("matcherWithVersionConstraint:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher(string versionConstraint);

        // + (nullable instancetype)matcherWithArrayContainsPredicate: (nonnull UAJSONPredicate *)predicate;
        [Static]
        [Export("matcherWithArrayContainsPredicate:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher(UAJSONPredicate predicate);

        // + (nullable instancetype)matcherWithArrayContainsPredicate: (nonnull UAJSONPredicate *)predicate atIndex:(NSUInteger)index;
        [Static]
        [Export("matcherWithArrayContainsPredicate:atIndex:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher(UAJSONPredicate predicate, nuint index);

        // + (nullable instancetype)matcherWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("matcherWithJSON:error:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher(NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject([NullAllowed] NSObject @object);

        // - (BOOL)evaluateObject:(nullable id)object ignoreCase:(BOOL)ignoreCase;
        [Export("evaluateObject:ignoreCase:")]
        bool EvaluateObject([NullAllowed] NSObject @object, bool ignoreCase);
    }

    // typedef void (^UAJavaScriptDelegateCompletionHandler)(NSString *_Nullable)
    delegate void UAJavaScriptDelegateCompletionHandler([NullAllowed] string arg0);

    // @protocol UAJavaScriptDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptDelegate
    {

        // - (void)callWithData:(nonnull UAWebViewCallData *)data withCompletionHandler: (nonnull UAJavaScriptDelegateCompletionHandler)completionHandler;
        [Abstract]
        [Export("callWithData:withCompletionHandler:")]
        void Call(UAWebViewCallData data, UAJavaScriptDelegateCompletionHandler completionHandler);
    }

    interface IUAJavaScriptDelegate { }

    // @interface UALocationInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UALocationInfo
    {
        // @property (readonly, nonatomic) double latitude;
        [Export("latitude")]
        double Latitude { get; }

        // @property (readonly, nonatomic) double longitude;
        [Export("longitude")]
        double Longitude { get; }

        // @property (readonly, nonatomic) double horizontalAccuracy;
        [Export("horizontalAccuracy")]
        double HorizontalAccuracy { get; }

        // @property (readonly, nonatomic) double verticalAccuracy;
        [Export("verticalAccuracy")]
        double VerticalAccuracy { get; }

        // + (nonnull instancetype)infoWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy verticalAccuracy:(double)verticalAccuracy;
        [Static]
        [Export("infoWithLatitude:longitude:horizontalAccuracy:verticalAccuracy:")]
        UALocationInfo Info(double latitude, double longitude, double horizontalAccuracy, double verticalAccuracy);
    }

    // @interface UALocationEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UALocationEvent
    {

        // + (nonnull UALocationEvent *) locationEventWithInfo:(nonnull UALocationInfo *)info providerType:(nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("locationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent LocationEvent(UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

        // + (nonnull UALocationEvent *) singleLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("singleLocationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent SingleLocationEvent(UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

        // + (nonnull UALocationEvent *) significantChangeLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *) providerType;
        [Static]
        [Export("significantChangeLocationEventWithInfo:providerType:")]
        UALocationEvent SignificantChangeLocationEvent(UALocationInfo info, [NullAllowed] string providerType);

        // + (nonnull UALocationEvent *) standardLocationEventWithInfo:(nonnull UALocationInfo *)info providerType: (nullable UALocationServiceProviderType *)providerType desiredAccuracy:(nullable NSNumber *)desiredAccuracy distanceFilter:(nullable NSNumber *)distanceFilter;
        [Static]
        [Export("standardLocationEventWithInfo:providerType:desiredAccuracy:distanceFilter:")]
        UALocationEvent StandardLocationEvent(UALocationInfo info, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);
    }

    // @protocol UALocationProviderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALocationProviderDelegate
    {
        // @property (getter=isLocationUpdatesEnabled, assign, readwrite, nonatomic) BOOL locationUpdatesEnabled;
        [Export("locationUpdatesEnabled")]
        bool LocationUpdatesEnabled { [Bind("isLocationUpdatesEnabled")] get; set; }

        // @property (getter=isBackgroundLocationUpdatesAllowed, assign, readwrite, nonatomic) BOOL backgroundLocationUpdatesAllowed;
        [Export("backgroundLocationUpdatesAllowed")]
        bool BackgroundLocationUpdatesAllowed { [Bind("isBackgroundLocationUpdatesAllowed")] get; set; }

        // - (BOOL)isLocationOptedIn;
        [Abstract]
        [Export("isLocationOptedIn")]
        bool IsLocationOptedIn();

        // - (BOOL)isLocationDeniedOrRestricted;
        [Abstract]
        [Export("isLocationDeniedOrRestricted")]
        bool IsLocationDeniedOrRestricted();

        // - (UALocationProviderPermissionStatus)locationPermissionStatus;
        [Abstract]
        [Export("locationPermissionStatus")]
        UALocationProviderPermissionStatus LocationPermissionStatus();
    }

    interface IUALocationProviderDelegate { }

    // @interface UAMediaEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaEventTemplate
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *type;
        [NullAllowed, Export("type")]
        string Type { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *eventDescription;
        [NullAllowed, Export("eventDescription")]
        string EventDescription { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL isFeature;
        [Export("isFeature")]
        bool IsFeature { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *author;
        [NullAllowed, Export("author")]
        string Author { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *publishedDate;
        [NullAllowed, Export("publishedDate")]
        string PublishedDate { get; set; }

        // + (nonnull instancetype)browsedTemplate;
        [Static]
        [Export("browsedTemplate")]
        UAMediaEventTemplate BrowsedTemplate();

        // + (nonnull instancetype)starredTemplate;
        [Static]
        [Export("starredTemplate")]
        UAMediaEventTemplate StarredTemplate();

        // + (nonnull instancetype)sharedTemplate;
        [Static]
        [Export("sharedTemplate")]
        UAMediaEventTemplate SharedTemplate();

        // + (nonnull instancetype)sharedTemplateWithSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedTemplateWithSource:withMedium:")]
        UAMediaEventTemplate SharedTemplate([NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype)consumedTemplate;
        [Static]
        [Export("consumedTemplate")]
        UAMediaEventTemplate ConsumedTemplate();

        // + (nonnull instancetype)consumedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("consumedTemplateWithValueFromString:")]
        UAMediaEventTemplate ConsumedTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)consumedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("consumedTemplateWithValue:")]
        UAMediaEventTemplate ConsumedTemplate([NullAllowed] NSNumber eventValue);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent();
    }

    // @interface UAModifyTagsAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAModifyTagsAction
    {

        // - (void)applyChannelTags:(NSArray *)tags;
        [Export("applyChannelTags:")]
        void ApplyChannelTags(NSObject[] tags);

        // - (void)applyChannelTags:(NSArray *)tags group:(NSString *)group;
        [Export("applyChannelTags:group:")]
        void ApplyChannelTags(NSObject[] tags, string group);

        // - (void)applyNamedUserTags:(NSArray *)tags group:(NSString *)group;
        [Export("applyNamedUserTags:group:")]
        void ApplyNamedUserTags(NSObject[] tags, string group);
    }

    // @interface UAModules : NSObject
    [BaseType(typeof(NSObject))]
    interface UAModules
    {

        // - (nonnull NSArray<NSString *> *)allModuleNames;
        [Export("allModuleNames")]
        string[] AllModuleNames();

        // - (nullable UAComponent *)componentForModuleName:(nonnull NSString *)moduleName;
        [Export("componentForModuleName:")]
        [return: NullAllowed]
        UAComponent Component(string moduleName);
    }

    // @interface UANamedUser : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UANamedUser
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // - (void)forceUpdate;
        [Export("forceUpdate")]
        void ForceUpdate();

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        void AddTags(string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        void RemoveTags(string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        void SetTags(string[] tags, string tagGroupID);

        // - (void)updateTags;
        [Export("updateTags")]
        void UpdateTags();
    }

    // @interface UANotificationAction : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationAction
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, assign, nonatomic) UANotificationActionOptions options;
        [Export("options", ArgumentSemantic.Assign)]
        UANotificationActionOptions Options { get; }

        // - (nonnull instancetype)initWithIdentifier:(nonnull NSString *)identifier title:(nonnull NSString *)title options:(UANotificationActionOptions)options;
        [Export("initWithIdentifier:title:options:")]
        IntPtr Constructor(string identifier, string title, UANotificationActionOptions options);

        // - (nonnull UNNotificationAction *)asUNNotificationAction;
        [Export("asUNNotificationAction")]
        UNNotificationAction AsUNNotificationAction();

        // - (BOOL)isEqualToUNNotificationAction: (nonnull UNNotificationAction *)notificationAction;
        [Export("isEqualToUNNotificationAction:")]
        bool IsEqualToUNNotificationAction(UNNotificationAction notificationAction);
    }

    // @interface UANotificationCategories : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationCategories
    {

        // + (nonnull NSSet *)createCategoriesFromFile:(nonnull NSString *)filePath;
        [Static]
        [Export("createCategoriesFromFile:")]
        NSSet CreateCategories(string filePath);

        // + (nullable UANotificationCategory *) createCategory:(nonnull NSString *)categoryId actions:(nonnull NSArray *)actionDefinitions;
        [Static]
        [Export("createCategory:actions:")]
        [return: NullAllowed]
        UANotificationCategory CreateCategory(string categoryId, NSObject[] actionDefinitions);

        // + (UANotificationCategory *_Nullable) createCategory:(nonnull NSString *)categoryId actions:(nonnull NSArray *)actionDefinitions hiddenPreviewsBodyPlaceholder:(nonnull NSString *)hiddenPreviewsBodyPlaceholder;
        [Static]
        [Export("createCategory:actions:hiddenPreviewsBodyPlaceholder:")]
        [return: NullAllowed]
        UANotificationCategory CreateCategory(string categoryId, NSObject[] actionDefinitions, string hiddenPreviewsBodyPlaceholder);
    }

    // @interface UANotificationCategory : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationCategory
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSArray<UANotificationAction *> *_Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        UANotificationAction[] Actions { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> *_Nonnull intentIdentifiers;
        [Export("intentIdentifiers", ArgumentSemantic.Copy)]
        string[] IntentIdentifiers { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *hiddenPreviewsBodyPlaceholder;
        [NullAllowed, Export("hiddenPreviewsBodyPlaceholder")]
        string HiddenPreviewsBodyPlaceholder { get; }

        // @property (readonly, nonatomic, nullable) NSString *categorySummaryFormat;
        [NullAllowed, Export("categorySummaryFormat")]
        string CategorySummaryFormat { get; }

        // @property (readonly, assign, nonatomic) UANotificationCategoryOptions options;
        [Export("options", ArgumentSemantic.Assign)]
        UANotificationCategoryOptions Options { get; }

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions:(nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers:(nonnull NSArray<NSString *> *)intentIdentifiers options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:options:")]
        UANotificationCategory Category(string identifier, UANotificationAction[] actions, string[] intentIdentifiers, UANotificationCategoryOptions options);

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions:(nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers:(nonnull NSArray<NSString *> *)intentIdentifiers hiddenPreviewsBodyPlaceholder:(nullable NSString *)hiddenPreviewsBodyPlaceholder options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:")]
        UANotificationCategory Category(string identifier, UANotificationAction[] actions, string[] intentIdentifiers, [NullAllowed] string hiddenPreviewsBodyPlaceholder, UANotificationCategoryOptions options);

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions:(nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers:(nonnull NSArray<NSString *> *)intentIdentifiers hiddenPreviewsBodyPlaceholder:(nullable NSString *)hiddenPreviewsBodyPlaceholder categorySummaryFormat:(nullable NSString *)format options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:categorySummaryFormat:options:")]
        UANotificationCategory Category(string identifier, UANotificationAction[] actions, string[] intentIdentifiers, [NullAllowed] string hiddenPreviewsBodyPlaceholder, [NullAllowed] string format, UANotificationCategoryOptions options);

        // - (null_unspecified UNNotificationCategory *)asUNNotificationCategory;
        [Export("asUNNotificationCategory")]
        UNNotificationCategory AsUNNotificationCategory();

        // - (BOOL)isEqualToUNNotificationCategory:(nonnull UNNotificationCategory *)category;
        [Export("isEqualToUNNotificationCategory:")]
        bool IsEqualToUNNotificationCategory(UNNotificationCategory category);
    }

    // @interface UANotificationContent : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationContent
    {
        // @property (readonly, copy, nonatomic, nullable) NSString *alertTitle;
        [NullAllowed, Export("alertTitle")]
        string AlertTitle { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *alertBody;
        [NullAllowed, Export("alertBody")]
        string AlertBody { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *sound;
        [NullAllowed, Export("sound")]
        string Sound { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *badge;
        [NullAllowed, Export("badge", ArgumentSemantic.Strong)]
        NSNumber Badge { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *contentAvailable;
        [NullAllowed, Export("contentAvailable", ArgumentSemantic.Strong)]
        NSNumber ContentAvailable { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *summaryArgument;
        [NullAllowed, Export("summaryArgument")]
        string SummaryArgument { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *summaryArgumentCount;
        [NullAllowed, Export("summaryArgumentCount", ArgumentSemantic.Strong)]
        NSNumber SummaryArgumentCount { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *threadIdentifier;
        [NullAllowed, Export("threadIdentifier")]
        string ThreadIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *targetContentIdentifier;
        [NullAllowed, Export("targetContentIdentifier")]
        string TargetContentIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *categoryIdentifier;
        [NullAllowed, Export("categoryIdentifier")]
        string CategoryIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *launchImage;
        [NullAllowed, Export("launchImage")]
        string LaunchImage { get; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *localizationKeys;
        [NullAllowed, Export("localizationKeys", ArgumentSemantic.Copy)]
        NSDictionary LocalizationKeys { get; }

        // @property (readonly, copy, nonatomic) NSDictionary *_Nonnull notificationInfo;
        [Export("notificationInfo", ArgumentSemantic.Copy)]
        NSDictionary NotificationInfo { get; }

        // @property (readonly, strong, nonatomic, nullable) UNNotification *notification;
        [NullAllowed, Export("notification", ArgumentSemantic.Strong)]
        UNNotification Notification { get; }

        // + (nonnull instancetype)notificationWithNotificationInfo:(nonnull NSDictionary *)notificationInfo;
        [Static]
        [Export("notificationWithNotificationInfo:")]
        UANotificationContent NotificationWithNotificationInfo(NSDictionary notificationInfo);

        // + (nonnull instancetype)notificationWithUNNotification:(nonnull UNNotification *)notification;
        [Static]
        [Export("notificationWithUNNotification:")]
        UANotificationContent NotificationWithUNNotification(UNNotification notification);
    }

    // @interface UANotificationResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationResponse
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull actionIdentifier;
        [Export("actionIdentifier")]
        string ActionIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull responseText;
        [Export("responseText")]
        string ResponseText { get; }

        // @property (readonly, strong, nonatomic) UANotificationContent *_Nonnull notificationContent;
        [Export("notificationContent", ArgumentSemantic.Strong)]
        UANotificationContent NotificationContent { get; }

        // @property (readonly, strong, nonatomic, nullable) UNNotificationResponse *response;
        [NullAllowed, Export("response", ArgumentSemantic.Strong)]
        UNNotificationResponse Response { get; }

        // + (nonnull instancetype) notificationResponseWithNotificationInfo:(nonnull NSDictionary *)notificationInfo actionIdentifier:(nonnull NSString *)actionIdentifier responseText:(nullable NSString *)responseText;
        [Static]
        [Export("notificationResponseWithNotificationInfo:actionIdentifier:responseText:")]
        UANotificationResponse NotificationResponse(NSDictionary notificationInfo, string actionIdentifier, [NullAllowed] string responseText);

        // + (nonnull instancetype)notificationResponseWithUNNotificationResponse:(nonnull UNNotificationResponse *)response;
        [Static]
        [Export("notificationResponseWithUNNotificationResponse:")]
        UANotificationResponse NotificationResponse(UNNotificationResponse response);
    }

    // @interface UAOpenExternalURLAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAOpenExternalURLAction
    {

        // + (nullable NSURL *)parseURLFromArguments:(nonnull UAActionArguments *)arguments;
        [Static]
        [Export("parseURLFromArguments:")]
        [return: NullAllowed]
        NSUrl ParseURL(UAActionArguments arguments);
    }

    // @interface UAPadding : NSObject
    [BaseType(typeof(NSObject))]
    interface UAPadding
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *top;
        [NullAllowed, Export("top", ArgumentSemantic.Strong)]
        NSNumber Top { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *bottom;
        [NullAllowed, Export("bottom", ArgumentSemantic.Strong)]
        NSNumber Bottom { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *trailing;
        [NullAllowed, Export("trailing", ArgumentSemantic.Strong)]
        NSNumber Trailing { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *leading;
        [NullAllowed, Export("leading", ArgumentSemantic.Strong)]
        NSNumber Leading { get; set; }

        // + (nonnull instancetype)paddingWithTop:(nullable NSNumber *)top bottom:(nullable NSNumber *)bottom leading:(nullable NSNumber *)leading trailing:(nullable NSNumber *)trailing;
        [Static]
        [Export("paddingWithTop:bottom:leading:trailing:")]
        UAPadding Padding([NullAllowed] NSNumber top, [NullAllowed] NSNumber bottom, [NullAllowed] NSNumber leading, [NullAllowed] NSNumber trailing);

        // + (nonnull instancetype)paddingWithDictionary: (nullable NSDictionary *)paddingDict;
        [Static]
        [Export("paddingWithDictionary:")]
        UAPadding Padding([NullAllowed] NSDictionary paddingDict);
    }

    // @interface UAPreferenceDataStore : NSObject
    [BaseType(typeof(NSObject))]
    interface UAPreferenceDataStore
    {

        // - (BOOL)keyExists:(nonnull NSString *)key;
        [Export("keyExists:")]
        bool KeyExists(string key);

        // - (nonnull id)objectForKey:(nonnull NSString *)key;
        [Export("objectForKey:")]
        NSObject Object(string key);

        // - (void)removeObjectForKey:(nonnull NSString *)key;
        [Export("removeObjectForKey:")]
        void RemoveObject(string key);

        // - (nullable NSString *)stringForKey:(nonnull NSString *)key;
        [Export("stringForKey:")]
        [return: NullAllowed]
        string String(string key);

        // - (nullable NSArray *)arrayForKey:(nonnull NSString *)key;
        [Export("arrayForKey:")]
        [return: NullAllowed]
        NSObject[] Array(string key);

        // - (nullable NSDictionary *)dictionaryForKey:(nonnull NSString *)key;
        [Export("dictionaryForKey:")]
        [return: NullAllowed]
        NSDictionary Dictionary(string key);

        // - (nullable NSData *)dataForKey:(nonnull NSString *)key;
        [Export("dataForKey:")]
        [return: NullAllowed]
        NSData Data(string key);

        // - (nullable NSArray *)stringArrayForKey:(nonnull NSString *)key;
        [Export("stringArrayForKey:")]
        [return: NullAllowed]
        NSObject[] StringArray(string key);

        // - (NSInteger)integerForKey:(nonnull NSString *)key;
        [Export("integerForKey:")]
        nint Integer(string key);

        // - (float)floatForKey:(nonnull NSString *)key;
        [Export("floatForKey:")]
        nfloat Float(string key);

        // - (double)doubleForKey:(nonnull NSString *)key;
        [Export("doubleForKey:")]
        double Double(string key);

        // - (double)doubleForKey:(nonnull NSString *)key defaultValue:(double)defaultValue;
        [Export("doubleForKey:defaultValue:")]
        double Double(string key, double defaultValue);

        // - (BOOL)boolForKey:(nonnull NSString *)key;
        [Export("boolForKey:")]
        bool Bool(string key);

        // - (BOOL)boolForKey:(nonnull NSString *)key defaultValue:(BOOL)defaultValue;
        [Export("boolForKey:defaultValue:")]
        bool Bool(string key, bool defaultValue);

        // - (nullable NSURL *)URLForKey:(nonnull NSString *)key;
        [Export("URLForKey:")]
        [return: NullAllowed]
        NSUrl URL(string key);

        // - (void)setInteger:(NSInteger)value forKey:(nonnull NSString *)key;
        [Export("setInteger:forKey:")]
        void SetInteger(nint value, string key);

        // - (void)setFloat:(float)value forKey:(nonnull NSString *)key;
        [Export("setFloat:forKey:")]
        void SetFloat(nfloat value, string key);

        // - (void)setDouble:(double)value forKey:(nonnull NSString *)key;
        [Export("setDouble:forKey:")]
        void SetDouble(double value, string key);

        // - (void)setBool:(BOOL)value forKey:(nonnull NSString *)key;
        [Export("setBool:forKey:")]
        void SetBool(bool value, string key);

        // - (void)setURL:(nullable NSURL *)url forKey:(nonnull NSString *)key;
        [Export("setURL:forKey:")]
        void SetURL([NullAllowed] NSUrl url, string key);

        // - (void)setObject:(nullable id)value forKey:(nonnull NSString *)key;
        [Export("setObject:forKey:")]
        void SetObject([NullAllowed] NSObject value, string key);

        // - (void)removeAll;
        [Export("removeAll")]
        void RemoveAll();
    }

    // @interface UAProximityRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface UAProximityRegion
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Strong)]
        NSNumber Latitude { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Strong)]
        NSNumber Longitude { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *RSSI;
        [NullAllowed, Export("RSSI", ArgumentSemantic.Strong)]
        NSNumber RSSI { get; set; }

        // + (nullable instancetype)proximityRegionWithID:(nonnull NSString *)proximityID major:(nonnull NSNumber *)major minor:(nonnull NSNumber *)minor;
        [Static]
        [Export("proximityRegionWithID:major:minor:")]
        [return: NullAllowed]
        UAProximityRegion ProximityRegion(string proximityID, NSNumber major, NSNumber minor);
    }

    // @protocol UARegistrationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UARegistrationDelegate
    {

        // - (void)registrationSucceededForChannelID:(nonnull NSString *)channelID deviceToken:(nonnull NSString *)deviceToken;
        [Export("registrationSucceededForChannelID:deviceToken:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the UAChannelUpdatedEvent NSNotification.")]
        void RegistrationSucceeded(string channelID, string deviceToken);

        // - (void)registrationFailed;
        [Export("registrationFailed")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the UAChannelRegistrationFailedEvent NSNotification.")]
        void RegistrationFailed();

        // - (void) notificationRegistrationFinishedWithAuthorizedSettings: (UAAuthorizedNotificationSettings)authorizedSettings categories: (nonnull NSSet< UANotificationCategory *> *)categories status: (UAAuthorizationStatus) status;
        [Export("notificationRegistrationFinishedWithAuthorizedSettings:categories:status:")]
        void NotificationRegistrationFinished(UAAuthorizedNotificationSettings authorizedSettings, NSSet categories, UAAuthorizationStatus status);

        // - (void) notificationRegistrationFinishedWithAuthorizedSettings: (UAAuthorizedNotificationSettings)authorizedSettings categories: (nonnull NSSet< UANotificationCategory *> *)categories;
        [Export("notificationRegistrationFinishedWithAuthorizedSettings:categories:")]
        void NotificationRegistrationFinished(UAAuthorizedNotificationSettings authorizedSettings, NSSet categories);

        // - (void)notificationAuthorizedSettingsDidChange: (UAAuthorizedNotificationSettings)authorizedSettings;
        [Export("notificationAuthorizedSettingsDidChange:")]
        void NotificationAuthorizedSettingsDidChange(UAAuthorizedNotificationSettings authorizedSettings);

        // - (void)apnsRegistrationSucceededWithDeviceToken:(nonnull NSData *)deviceToken;
        [Export("apnsRegistrationSucceededWithDeviceToken:")]
        void ApnsRegistrationSucceeded(NSData deviceToken);

        // - (void)apnsRegistrationFailedWithError:(nonnull NSError *)error;
        [Export("apnsRegistrationFailedWithError:")]
        void ApnsRegistrationFailed(NSError error);
    }

    interface IUARegistrationDelegate { }

    // @protocol UAPushNotificationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPushNotificationDelegate
    {

        // - (void)receivedForegroundNotification: (nonnull UANotificationContent *)notificationContent completionHandler: (nonnull void (^)(void))completionHandler;
        [Export("receivedForegroundNotification:completionHandler:")]
        void ReceivedForegroundNotification(UANotificationContent notificationContent, Action completionHandler);

        // - (void)receivedBackgroundNotification: (nonnull UANotificationContent *)notificationContent completionHandler: (nonnull void (^)(UIBackgroundFetchResult)) completionHandler;
        [Export("receivedBackgroundNotification:completionHandler:")]
        void ReceivedBackgroundNotification(UANotificationContent notificationContent, Action<UIBackgroundFetchResult> completionHandler);

        // - (void)receivedNotificationResponse: (nonnull UANotificationResponse *)notificationResponse completionHandler:(nonnull void (^)(void))completionHandler;
        [Export("receivedNotificationResponse:completionHandler:")]
        void ReceivedNotificationResponse(UANotificationResponse notificationResponse, Action completionHandler);

        // - (UNNotificationPresentationOptions)presentationOptionsForNotification: (nonnull UNNotification *)notification;
        [Export("presentationOptionsForNotification:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use extendPresentationOptions:notification:")]
        UNNotificationPresentationOptions PresentationOptions(UNNotification notification);

        // - (UNNotificationPresentationOptions) extendPresentationOptions:(UNNotificationPresentationOptions)options notification:(nonnull UNNotification *)notification;
        [Export("extendPresentationOptions:notification:")]
        UNNotificationPresentationOptions ExtendPresentationOptions(UNNotificationPresentationOptions options, UNNotification notification);
    }

    interface IUAPushNotificationDelegate { }

    // @interface UAPush : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAPush
    {
        // @property (assign, readwrite, nonatomic) BOOL backgroundPushNotificationsEnabled;
        [Export("backgroundPushNotificationsEnabled")]
        bool BackgroundPushNotificationsEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL backgroundPushNotificationsEnabledByDefault;
        [Export("backgroundPushNotificationsEnabledByDefault")]
        bool BackgroundPushNotificationsEnabledByDefault { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL userPushNotificationsEnabled;
        [Export("userPushNotificationsEnabled")]
        bool UserPushNotificationsEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL pushTokenRegistrationEnabled;
        [Export("pushTokenRegistrationEnabled")]
        bool PushTokenRegistrationEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL userPushNotificationsEnabledByDefault;
        [Export("userPushNotificationsEnabledByDefault")]
        bool UserPushNotificationsEnabledByDefault { get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSString *deviceToken;
        [NullAllowed, Export("deviceToken")]
        string DeviceToken { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *channelID;
        [NullAllowed, Export("channelID")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the identifier property on UAChannel.")]
        string ChannelID { get; }

        // @property (assign, readwrite, nonatomic) UANotificationOptions notificationOptions;
        [Export("notificationOptions", ArgumentSemantic.Assign)]
        UANotificationOptions NotificationOptions { get; set; }

        // @property (readwrite, strong, nonatomic) NSSet<UANotificationCategory *> *_Nonnull customCategories;
        [Export("customCategories", ArgumentSemantic.Strong)]
        NSSet CustomCategories { get; set; }

        // @property (readonly, nonatomic) NSSet<UANotificationCategory *> *_Nonnull combinedCategories;
        [Export("combinedCategories")]
        NSSet CombinedCategories { get; }

        // @property (assign, readwrite, nonatomic) BOOL requireAuthorizationForDefaultCategories;
        [Export("requireAuthorizationForDefaultCategories")]
        bool RequireAuthorizationForDefaultCategories { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAPushNotificationDelegate> pushNotificationDelegate;
        [NullAllowed, Export("pushNotificationDelegate", ArgumentSemantic.Assign)]
        NSObject WeakPushNotificationDelegate { get; set; }

        [Wrap("WeakPushNotificationDelegate")]
        [NullAllowed]
        IUAPushNotificationDelegate PushNotificationDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UARegistrationDelegate> registrationDelegate;
        [NullAllowed, Export("registrationDelegate", ArgumentSemantic.Assign)]
        NSObject WeakRegistrationDelegate { get; set; }

        [Wrap("WeakRegistrationDelegate")]
        [NullAllowed]
        IUARegistrationDelegate RegistrationDelegate { get; set; }

        // @property (readonly, strong, nonatomic, nullable) UANotificationResponse *launchNotificationResponse;
        [NullAllowed, Export("launchNotificationResponse", ArgumentSemantic.Strong)]
        UANotificationResponse LaunchNotificationResponse { get; }

        // @property (readonly, nonatomic) UAAuthorizedNotificationSettings authorizedNotificationSettings;
        [Export("authorizedNotificationSettings")]
        UAAuthorizedNotificationSettings AuthorizedNotificationSettings { get; }

        // @property (readonly, nonatomic) UAAuthorizationStatus authorizationStatus;
        [Export("authorizationStatus")]
        UAAuthorizationStatus AuthorizationStatus { get; }

        // @property (readonly, assign, nonatomic) BOOL userPromptedForNotifications;
        [Export("userPromptedForNotifications")]
        bool UserPromptedForNotifications { get; }

        // @property (assign, readwrite, nonatomic) UNNotificationPresentationOptions defaultPresentationOptions;
        [Export("defaultPresentationOptions", ArgumentSemantic.Assign)]
        UNNotificationPresentationOptions DefaultPresentationOptions { get; set; }

        // @property (assign, readwrite, nonatomic) NSInteger badgeNumber;
        [Export("badgeNumber", ArgumentSemantic.Assign)]
        nint BadgeNumber { get; set; }

        // @property (getter=isAutobadgeEnabled, assign, readwrite, nonatomic) BOOL autobadgeEnabled;
        [Export("autobadgeEnabled")]
        bool AutobadgeEnabled { [Bind("isAutobadgeEnabled")] get; set; }

        // @property (readwrite, copy, nonatomic) NSArray<NSString *> *_Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent property on UAChannel.")]
        string[] Tags { get; set; }

        // @property (getter=isChannelTagRegistrationEnabled, assign, readwrite, nonatomic) BOOL channelTagRegistrationEnabled;
        [Export("channelTagRegistrationEnabled")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent property on UAChannel.")]
        bool ChannelTagRegistrationEnabled { [Bind("isChannelTagRegistrationEnabled")] get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *quietTime;
        [NullAllowed, Export("quietTime", ArgumentSemantic.Copy)]
        NSDictionary QuietTime { get; }

        // @property (readwrite, strong, nonatomic) NSTimeZone *_Nonnull timeZone;
        [Export("timeZone", ArgumentSemantic.Strong)]
        NSTimeZone TimeZone { get; set; }

        // @property (getter=isQuietTimeEnabled, assign, readwrite, nonatomic) BOOL quietTimeEnabled;
        [Export("quietTimeEnabled")]
        bool QuietTimeEnabled { [Bind("isQuietTimeEnabled")] get; set; }

        // - (void)resetBadge;
        [Export("resetBadge")]
        void ResetBadge();

        // - (void)enableUserPushNotifications:(nonnull void (^)(BOOL))completionHandler;
        [Export("enableUserPushNotifications:")]
        void EnableUserPushNotifications(Action<bool> completionHandler);

        // - (void)addTag:(nonnull NSString *)tag;
        [Export("addTag:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void AddTag(string tag);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags;
        [Export("addTags:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void AddTags(string[] tags);

        // - (void)removeTag:(nonnull NSString *)tag;
        [Export("removeTag:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void RemoveTag(string tag);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags;
        [Export("removeTags:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void RemoveTags(string[] tags);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void AddTags(string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void RemoveTags(string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void SetTags(string[] tags, string tagGroupID);

        // - (void)setQuietTimeStartHour:(NSUInteger)startHour startMinute:(NSUInteger)startMinute endHour:(NSUInteger)endHour endMinute:(NSUInteger)endMinute;
        [Export("setQuietTimeStartHour:startMinute:endHour:endMinute:")]
        void SetQuietTimeStartHour(nuint startHour, nuint startMinute, nuint endHour, nuint endMinute);

        // - (void)enableChannelCreation;
        [Export("enableChannelCreation")]
        [Obsolete("Deprecated - to be removed in SDK version 13.0. Please use the equivalent method on UAChannel.")]
        void EnableChannelCreation();

        // - (void)updateRegistration;
        [Export("updateRegistration")]
        void UpdateRegistration();
    }

    // @protocol UAPushProviderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPushProviderDelegate
    {
        // @property (assign, readwrite, nonatomic) BOOL pushTokenRegistrationEnabled;
        [Export("pushTokenRegistrationEnabled")]
        bool PushTokenRegistrationEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL userPushNotificationsAllowed;
        [Export("userPushNotificationsAllowed")]
        bool UserPushNotificationsAllowed { get; }

        // @property (readonly, nonatomic) BOOL backgroundPushNotificationsAllowed;
        [Export("backgroundPushNotificationsAllowed")]
        bool BackgroundPushNotificationsAllowed { get; }

        // @property (getter=isAutobadgeEnabled, assign, readwrite, nonatomic) BOOL autobadgeEnabled;
        [Export("autobadgeEnabled")]
        bool AutobadgeEnabled { [Bind("isAutobadgeEnabled")] get; set; }

        // @property (assign, readwrite, nonatomic) NSInteger badgeNumber;
        [Export("badgeNumber", ArgumentSemantic.Assign)]
        nint BadgeNumber { get; set; }

        // @property (getter=isQuietTimeEnabled, assign, readwrite, nonatomic) BOOL quietTimeEnabled;
        [Export("quietTimeEnabled")]
        bool QuietTimeEnabled { [Bind("isQuietTimeEnabled")] get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *quietTime;
        [NullAllowed, Export("quietTime", ArgumentSemantic.Copy)]
        NSDictionary QuietTime { get; }

        // @property (readwrite, strong, nonatomic) NSTimeZone *_Nonnull timeZone;
        [Export("timeZone", ArgumentSemantic.Strong)]
        NSTimeZone TimeZone { get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSString *deviceToken;
        [NullAllowed, Export("deviceToken")]
        string DeviceToken { get; }

    }

    interface IUAPushProviderDelegate { }

    // @interface UARegionEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UARegionEvent
    {
        // @property (readwrite, strong, nonatomic, nullable) UAProximityRegion *proximityRegion;
        [NullAllowed, Export("proximityRegion", ArgumentSemantic.Strong)]
        UAProximityRegion ProximityRegion { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UACircularRegion *circularRegion;
        [NullAllowed, Export("circularRegion", ArgumentSemantic.Strong)]
        UACircularRegion CircularRegion { get; set; }

        // + (nullable instancetype)regionEventWithRegionID:(nonnull NSString *)regionID source:(nonnull NSString *)source boundaryEvent:(UABoundaryEvent)boundaryEvent;
        [Static]
        [Export("regionEventWithRegionID:source:boundaryEvent:")]
        [return: NullAllowed]
        UARegionEvent RegionEvent(string regionID, string source, UABoundaryEvent boundaryEvent);
    }

    // @interface UARemoveTagsAction : UAModifyTagsAction
    [BaseType(typeof(UAModifyTagsAction))]
    interface UARemoveTagsAction
    {

    }

    // @interface UARetailEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UARetailEventTemplate
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *eventDescription;
        [NullAllowed, Export("eventDescription")]
        string EventDescription { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *brand;
        [NullAllowed, Export("brand")]
        string Brand { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL isNewItem;
        [Export("isNewItem")]
        bool IsNewItem { get; set; }

        // + (nonnull instancetype)browsedTemplate;
        [Static]
        [Export("browsedTemplate")]
        UARetailEventTemplate BrowsedTemplate();

        // + (nonnull instancetype)browsedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("browsedTemplateWithValueFromString:")]
        UARetailEventTemplate BrowsedTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)browsedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("browsedTemplateWithValue:")]
        UARetailEventTemplate BrowsedTemplate([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)addedToCartTemplate;
        [Static]
        [Export("addedToCartTemplate")]
        UARetailEventTemplate AddedToCartTemplate();

        // + (nonnull instancetype)addedToCartTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("addedToCartTemplateWithValueFromString:")]
        UARetailEventTemplate AddedToCartTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)addedToCartTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("addedToCartTemplateWithValue:")]
        UARetailEventTemplate AddedToCartTemplate([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)starredProductTemplate;
        [Static]
        [Export("starredProductTemplate")]
        UARetailEventTemplate StarredProductTemplate();

        // + (nonnull instancetype)starredProductTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("starredProductTemplateWithValueFromString:")]
        UARetailEventTemplate StarredProductTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)starredProductTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("starredProductTemplateWithValue:")]
        UARetailEventTemplate StarredProductTemplate([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)purchasedTemplate;
        [Static]
        [Export("purchasedTemplate")]
        UARetailEventTemplate PurchasedTemplate();

        // + (nonnull instancetype)purchasedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("purchasedTemplateWithValueFromString:")]
        UARetailEventTemplate PurchasedTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)purchasedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("purchasedTemplateWithValue:")]
        UARetailEventTemplate PurchasedTemplate([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)sharedProductTemplate;
        [Static]
        [Export("sharedProductTemplate")]
        UARetailEventTemplate SharedProductTemplate();

        // + (nonnull instancetype)sharedProductTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("sharedProductTemplateWithValueFromString:")]
        UARetailEventTemplate SharedProductTemplate([NullAllowed] string eventValue);

        // + (nonnull instancetype)sharedProductTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("sharedProductTemplateWithValue:")]
        UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype) sharedProductTemplateWithSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate([NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype) sharedProductTemplateWithValueFromString:(nullable NSString *)eventValue withSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithValueFromString:withSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate([NullAllowed] string eventValue, [NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype) sharedProductTemplateWithValue:(nullable NSNumber *)eventValue withSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithValue:withSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber eventValue, [NullAllowed] string source, [NullAllowed] string medium);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent();
    }

    // @interface UARuntimeConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface UARuntimeConfig
    {
        // @property (readonly, getter=isAutomaticSetupEnabled, atomic) BOOL automaticSetupEnabled;
        [Export("automaticSetupEnabled")]
        bool AutomaticSetupEnabled { get; }

        // @property (readonly, atomic) NSArray<NSString *> *_Nonnull whitelist;
        [Export("whitelist")]
        string[] Whitelist { get; }

        // @property (readonly, getter=isAnalyticsEnabled, atomic) BOOL analyticsEnabled;
        [Export("analyticsEnabled")]
        bool AnalyticsEnabled { get; }

        // @property (readonly, atomic) NSString *_Nonnull deviceAPIURL;
        [Export("deviceAPIURL")]
        string DeviceAPIURL { get; }

        // @property (readonly, atomic) NSString *_Nonnull analyticsURL;
        [Export("analyticsURL")]
        string AnalyticsURL { get; }

        // @property (readonly, atomic) NSString *_Nonnull remoteDataAPIURL;
        [Export("remoteDataAPIURL")]
        string RemoteDataAPIURL { get; }

        // @property (readonly, atomic) NSString *_Nonnull messageCenterStyleConfig;
        [Export("messageCenterStyleConfig")]
        string MessageCenterStyleConfig { get; }

        // @property (readonly, atomic) NSString *_Nonnull itunesID;
        [Export("itunesID")]
        string ItunesID { get; }

        // @property (readonly, atomic) BOOL clearUserOnAppRestore;
        [Export("clearUserOnAppRestore")]
        bool ClearUserOnAppRestore { get; }

        // @property (readonly, atomic) BOOL clearNamedUserOnAppRestore;
        [Export("clearNamedUserOnAppRestore")]
        bool ClearNamedUserOnAppRestore { get; }

        // @property (readonly, getter=isChannelCaptureEnabled, atomic) BOOL channelCaptureEnabled;
        [Export("channelCaptureEnabled")]
        bool ChannelCaptureEnabled { get; }

        // @property (readonly, getter=isOpenURLWhitelistingEnabled, atomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { get; }

        // @property (readonly, getter=isChannelCreationDelayEnabled, atomic) BOOL channelCreationDelayEnabled;
        [Export("channelCreationDelayEnabled")]
        bool ChannelCreationDelayEnabled { get; }

        // @property (readonly, atomic) BOOL requestAuthorizationToUseNotifications;
        [Export("requestAuthorizationToUseNotifications")]
        bool RequestAuthorizationToUseNotifications { get; }

        // @property (readonly, atomic, nonnull) NSString *appKey;
        [Export("appKey")]
        string AppKey { get; }

        // @property (readonly, atomic, nonnull) NSString *appSecret;
        [Export("appSecret")]
        string AppSecret { get; }

        // @property (readonly, atomic) UALogLevel logLevel;
        [Export("logLevel")]
        UALogLevel LogLevel { get; }

        // @property (readonly, getter=isInProduction, atomic) BOOL inProduction;
        [Export("inProduction")]
        bool InProduction { get; }

        // @property (readonly, atomic) NSDictionary *_Nonnull customConfig;
        [Export("customConfig")]
        NSDictionary CustomConfig { get; }

    }

    // @interface UASchedule : NSObject
    [BaseType(typeof(NSObject))]
    interface UASchedule
    {
        // @property (readonly, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic) UAScheduleInfo *_Nonnull info;
        [Export("info")]
        UAScheduleInfo Info { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata")]
        NSDictionary Metadata { get; }

        // - (BOOL)isEqualToSchedule:(nullable UASchedule *)schedule;
        [Export("isEqualToSchedule:")]
        bool IsEqualToSchedule([NullAllowed] UASchedule schedule);
    }

    // @interface UAScheduleAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAScheduleAction
    {

    }

    // @interface UAScheduleDelayBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleDelayBuilder
    {
        // @property (assign, readwrite, nonatomic) NSTimeInterval seconds;
        [Export("seconds", ArgumentSemantic.Assign)]
        double Seconds { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray *screens;
        [NullAllowed, Export("screens", ArgumentSemantic.Copy)]
        NSObject[] Screens { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *regionID;
        [NullAllowed, Export("regionID")]
        string RegionID { get; set; }

        // @property (assign, readwrite, nonatomic) UAScheduleDelayAppState appState;
        [Export("appState", ArgumentSemantic.Assign)]
        UAScheduleDelayAppState AppState { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<UAScheduleTrigger *> *cancellationTriggers;
        [NullAllowed, Export("cancellationTriggers", ArgumentSemantic.Copy)]
        UAScheduleTrigger[] CancellationTriggers { get; set; }

    }

    // @interface UAScheduleDelay : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleDelay
    {
        // @property (readonly, nonatomic) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // @property (readonly, nonatomic) NSTimeInterval seconds;
        [Export("seconds")]
        double Seconds { get; }

        // @property (readonly, nonatomic, nullable) NSArray *screens;
        [NullAllowed, Export("screens")]
        NSObject[] Screens { get; }

        // @property (readonly, nonatomic, nullable) NSString *regionID;
        [NullAllowed, Export("regionID")]
        string RegionID { get; }

        // @property (readonly, nonatomic) UAScheduleDelayAppState appState;
        [Export("appState")]
        UAScheduleDelayAppState AppState { get; }

        // @property (readonly, nonatomic) NSArray<UAScheduleTrigger *> *_Nonnull cancellationTriggers;
        [Export("cancellationTriggers")]
        UAScheduleTrigger[] CancellationTriggers { get; }

        // + (nonnull instancetype)delayWithBuilderBlock: (nonnull void (^)(UAScheduleDelayBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("delayWithBuilderBlock:")]
        UAScheduleDelay Delay(Action<UAScheduleDelayBuilder> builderBlock);

        // + (nullable instancetype)delayWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("delayWithJSON:error:")]
        [return: NullAllowed]
        UAScheduleDelay Delay(NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)isEqualToDelay:(nullable UAScheduleDelay *)delay;
        [Export("isEqualToDelay:")]
        bool IsEqualToDelay([NullAllowed] UAScheduleDelay delay);
    }

    // @interface UAScheduleEditsBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleEditsBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *priority;
        [NullAllowed, Export("priority", ArgumentSemantic.Strong)]
        NSNumber Priority { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *limit;
        [NullAllowed, Export("limit", ArgumentSemantic.Strong)]
        NSNumber Limit { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDate *start;
        [NullAllowed, Export("start", ArgumentSemantic.Strong)]
        NSDate Start { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDate *end;
        [NullAllowed, Export("end", ArgumentSemantic.Strong)]
        NSDate End { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *editGracePeriod;
        [NullAllowed, Export("editGracePeriod", ArgumentSemantic.Strong)]
        NSNumber EditGracePeriod { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *interval;
        [NullAllowed, Export("interval", ArgumentSemantic.Strong)]
        NSNumber Interval { get; set; }

    }

    // @interface UAScheduleEdits : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleEdits
    {
        // @property (readonly, nonatomic, nullable) NSNumber *priority;
        [NullAllowed, Export("priority")]
        NSNumber Priority { get; }

        // @property (readonly, nonatomic, nullable) NSNumber *limit;
        [NullAllowed, Export("limit")]
        NSNumber Limit { get; }

        // @property (readonly, nonatomic, nullable) NSDate *start;
        [NullAllowed, Export("start")]
        NSDate Start { get; }

        // @property (readonly, nonatomic, nullable) NSDate *end;
        [NullAllowed, Export("end")]
        NSDate End { get; }

        // @property (readonly, nonatomic, nullable) NSNumber *editGracePeriod;
        [NullAllowed, Export("editGracePeriod")]
        NSNumber EditGracePeriod { get; }

        // @property (readonly, nonatomic, nullable) NSNumber *interval;
        [NullAllowed, Export("interval")]
        NSNumber Interval { get; }

    }

    // @interface UAScheduleInfoBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleInfoBuilder
    {
        // @property (assign, readwrite, nonatomic) NSInteger priority;
        [Export("priority", ArgumentSemantic.Assign)]
        nint Priority { get; set; }

        // @property (assign, readwrite, nonatomic) NSUInteger limit;
        [Export("limit")]
        nuint Limit { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<UAScheduleTrigger *> *triggers;
        [NullAllowed, Export("triggers", ArgumentSemantic.Copy)]
        UAScheduleTrigger[] Triggers { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDate *start;
        [NullAllowed, Export("start", ArgumentSemantic.Strong)]
        NSDate Start { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDate *end;
        [NullAllowed, Export("end", ArgumentSemantic.Strong)]
        NSDate End { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAScheduleDelay *delay;
        [NullAllowed, Export("delay", ArgumentSemantic.Strong)]
        UAScheduleDelay Delay { get; set; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval editGracePeriod;
        [Export("editGracePeriod", ArgumentSemantic.Assign)]
        double EditGracePeriod { get; set; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval interval;
        [Export("interval", ArgumentSemantic.Assign)]
        double Interval { get; set; }

    }

    // @interface UAScheduleInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleInfo
    {
        // @property (readonly, nonatomic) NSInteger priority;
        [Export("priority")]
        nint Priority { get; }

        // @property (readonly, nonatomic) NSArray<UAScheduleTrigger *> *_Nonnull triggers;
        [Export("triggers")]
        UAScheduleTrigger[] Triggers { get; }

        // @property (readonly, nonatomic) NSUInteger limit;
        [Export("limit")]
        nuint Limit { get; }

        // @property (readonly, nonatomic, nullable) NSDate *start;
        [NullAllowed, Export("start")]
        NSDate Start { get; }

        // @property (readonly, nonatomic, nullable) NSDate *end;
        [NullAllowed, Export("end")]
        NSDate End { get; }

        // @property (readonly, nonatomic, nullable) UAScheduleDelay *delay;
        [NullAllowed, Export("delay")]
        UAScheduleDelay Delay { get; }

        // @property (readonly, nonatomic) NSTimeInterval editGracePeriod;
        [Export("editGracePeriod")]
        double EditGracePeriod { get; }

        // @property (readonly, nonatomic) NSTimeInterval interval;
        [Export("interval")]
        double Interval { get; }

        // @property (readonly, nonatomic) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // - (BOOL)isEqualToScheduleInfo:(nullable UAScheduleInfo *)scheduleInfo;
        [Export("isEqualToScheduleInfo:")]
        bool IsEqualToScheduleInfo([NullAllowed] UAScheduleInfo scheduleInfo);
    }

    // @interface UAScheduleTrigger : NSObject
    [BaseType(typeof(NSObject))]
    interface UAScheduleTrigger
    {
        // @property (readonly, nonatomic) UAScheduleTriggerType type;
        [Export("type")]
        UAScheduleTriggerType Type { get; }

        // @property (readonly, nonatomic) NSNumber *_Nonnull goal;
        [Export("goal")]
        NSNumber Goal { get; }

        // + (nonnull instancetype)appInitTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("appInitTriggerWithCount:")]
        UAScheduleTrigger AppInitTrigger(nuint count);

        // + (nonnull instancetype)foregroundTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("foregroundTriggerWithCount:")]
        UAScheduleTrigger ForegroundTrigger(nuint count);

        // + (nonnull instancetype)backgroundTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("backgroundTriggerWithCount:")]
        UAScheduleTrigger BackgroundTrigger(nuint count);

        // + (nonnull instancetype)activeSessionTriggerWithCount:(NSUInteger)count;
        [Static]
        [Export("activeSessionTriggerWithCount:")]
        UAScheduleTrigger ActiveSessionTrigger(nuint count);

        // + (nonnull instancetype)regionEnterTriggerForRegionID: (nonnull NSString *)regionID count:(NSUInteger)count;
        [Static]
        [Export("regionEnterTriggerForRegionID:count:")]
        UAScheduleTrigger RegionEnterTrigger(string regionID, nuint count);

        // + (nonnull instancetype)regionExitTriggerForRegionID: (nonnull NSString *)regionID count:(NSUInteger)count;
        [Static]
        [Export("regionExitTriggerForRegionID:count:")]
        UAScheduleTrigger RegionExitTrigger(string regionID, nuint count);

        // + (nonnull instancetype)screenTriggerForScreenName: (nonnull NSString *)screenName count:(NSUInteger)count;
        [Static]
        [Export("screenTriggerForScreenName:count:")]
        UAScheduleTrigger ScreenTrigger(string screenName, nuint count);

        // + (nonnull instancetype)customEventTriggerWithPredicate: (nonnull UAJSONPredicate *)predicate count:(NSUInteger)count;
        [Static]
        [Export("customEventTriggerWithPredicate:count:")]
        UAScheduleTrigger CustomEventTrigger(UAJSONPredicate predicate, nuint count);

        // + (nonnull instancetype) customEventTriggerWithPredicate:(nonnull UAJSONPredicate *)predicate value:(nonnull NSNumber *)value;
        [Static]
        [Export("customEventTriggerWithPredicate:value:")]
        UAScheduleTrigger CustomEventTrigger(UAJSONPredicate predicate, NSNumber value);

        // + (nonnull instancetype)versionTriggerWithConstraint: (nonnull NSString *)versionConstraint count:(NSUInteger)count;
        [Static]
        [Export("versionTriggerWithConstraint:count:")]
        UAScheduleTrigger VersionTrigger(string versionConstraint, nuint count);

        // + (nullable instancetype)triggerWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("triggerWithJSON:error:")]
        [return: NullAllowed]
        UAScheduleTrigger Trigger(NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)isEqualToTrigger:(nullable UAScheduleTrigger *)trigger;
        [Export("isEqualToTrigger:")]
        bool IsEqualToTrigger([NullAllowed] UAScheduleTrigger trigger);
    }

    // @interface UASystemVersion : NSObject
    [BaseType(typeof(NSObject))]
    interface UASystemVersion
    {

        // - (nonnull NSString *)currentSystemVersion;
        [Export("currentSystemVersion")]
        string CurrentSystemVersion();

        // - (BOOL)isGreaterOrEqualToVersion:(nonnull NSString *)version;
        [Export("isGreaterOrEqualToVersion:")]
        bool IsGreaterOrEqualToVersion(string version);
    }

    // @interface UATextInputNotificationAction : UANotificationAction
    [BaseType(typeof(UANotificationAction))]
    interface UATextInputNotificationAction
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull textInputButtonTitle;
        [Export("textInputButtonTitle")]
        string TextInputButtonTitle { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull textInputPlaceholder;
        [Export("textInputPlaceholder")]
        string TextInputPlaceholder { get; }

        // - (nonnull instancetype) initWithIdentifier:(nonnull NSString *)identifier title:(nonnull NSString *)title textInputButtonTitle:(nonnull NSString *)textInputButtonTitle textInputPlaceholder:(nonnull NSString *)textInputPlaceholder options:(UANotificationActionOptions)options;
        [Export("initWithIdentifier:title:textInputButtonTitle:textInputPlaceholder:options:")]
        IntPtr Constructor(string identifier, string title, string textInputButtonTitle, string textInputPlaceholder, UANotificationActionOptions options);

    }

    // @interface UAUser : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAUser
    {
        // - (void)getUserData:(nonnull void (^)(UAUserData *_Nonnull))completionHandler;
        [Export("getUserData:")]
        void GetUserData(Action<UAUserData> completionHandler);

        // - (nullable UAUserData *)getUserDataSync;
        [Export("getUserDataSync")]
        [return: NullAllowed]
        UAUserData GetUserDataSync();
    }

    // @interface UAUserData : NSObject
    [BaseType(typeof(NSObject))]
    interface UAUserData
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull username;
        [Export("username")]
        string Username { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull password;
        [Export("password")]
        string Password { get; }

    }

    // @interface UAUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAUtils
    {

        // + (nonnull NSString *)deviceModelName;
        [Static]
        [Export("deviceModelName")]
        string DeviceModelName();

        // + (nonnull NSString *)userAuthHeaderString:(nonnull UAUserData *)userData;
        [Static]
        [Export("userAuthHeaderString:")]
        string UserAuthHeaderString(UAUserData userData);

        // + (nonnull NSString *)appAuthHeaderString;
        [Static]
        [Export("appAuthHeaderString")]
        string AppAuthHeaderString();

        // + (nonnull NSString *)pluralize:(int)count singularForm:(nonnull NSString *)singular pluralForm:(nonnull NSString *)plural;
        [Static]
        [Export("pluralize:singularForm:pluralForm:")]
        string Pluralize(nint count, string singular, string plural);

        // + (NSString *)getReadableFileSizeFromBytes:(double)bytes;
        [Static]
        [Export("getReadableFileSizeFromBytes:")]
        string GetReadableFileSize(double bytes);

        // + (nonnull NSDateFormatter *)ISODateFormatterUTC;
        [Static]
        [Export("ISODateFormatterUTC")]
        NSDateFormatter ISODateFormatterUTC();

        // + (nonnull NSDateFormatter *)ISODateFormatterUTCWithDelimiter;
        [Static]
        [Export("ISODateFormatterUTCWithDelimiter")]
        NSDateFormatter ISODateFormatterUTCWithDelimiter();

        // + (nullable NSDate *)parseISO8601DateFromString:(nonnull NSString *)timestamp;
        [Static]
        [Export("parseISO8601DateFromString:")]
        [return: NullAllowed]
        NSDate ParseISO8601Date(string timestamp);

        // + (BOOL)addSkipBackupAttributeToItemAtURL:(nonnull NSURL *)url;
        [Static]
        [Export("addSkipBackupAttributeToItemAtURL:")]
        bool AddSkipBackupAttributeToItemAtURL(NSUrl url);

        // + (nullable UIWindow *)mainWindow;
        [Static]
        [Export("mainWindow")]
        [return: NullAllowed]
        UIWindow MainWindow();

        // + (nullable UIWindow *)mainWindow:(nullable UIWindowScene *)scene;
        [Static]
        [Export("mainWindow:")]
        [return: NullAllowed]
        UIWindow MainWindow([NullAllowed] UIWindowScene scene);

        // + (nullable UIWindow *)windowForView:(nonnull UIView *)view;
        [Static]
        [Export("windowForView:")]
        [return: NullAllowed]
        UIWindow Window(UIView view);

        // + (nullable UIViewController *)topController;
        [Static]
        [Export("topController")]
        [return: NullAllowed]
        UIViewController TopController();

        // + (nonnull NSString *)connectionType;
        [Static]
        [Export("connectionType")]
        string ConnectionType();

        // + (BOOL)isSilentPush:(nonnull NSDictionary *)notification;
        [Static]
        [Export("isSilentPush:")]
        bool IsSilentPush(NSDictionary notification);

        // + (BOOL)isAlertingPush:(nonnull NSDictionary *)notification;
        [Static]
        [Export("isAlertingPush:")]
        bool IsAlertingPush(NSDictionary notification);

        // + (UIBackgroundFetchResult)mergeFetchResults:(nonnull NSArray *)fetchResults;
        [Static]
        [Export("mergeFetchResults:")]
        UIBackgroundFetchResult MergeFetchResults(NSObject[] fetchResults);

        // + (nonnull NSString *)deviceTokenStringFromDeviceToken: (nonnull NSData *)deviceToken;
        [Static]
        [Export("deviceTokenStringFromDeviceToken:")]
        string DeviceTokenString(NSData deviceToken);

        // + (NSComparisonResult)compareVersion:(nonnull NSString *)version1 toVersion:(nonnull NSString *)version2;
        [Static]
        [Export("compareVersion:toVersion:")]
        NSComparisonResult CompareVersion(string version1, string version2);
    }

    // @protocol UAWhitelistDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAWhitelistDelegate
    {

        // - (BOOL)acceptWhitelisting:(nonnull NSURL *)url scope:(UAWhitelistScope)scope;
        [Export("acceptWhitelisting:scope:")]
        bool AcceptWhitelisting(NSUrl url, UAWhitelistScope scope);
    }

    interface IUAWhitelistDelegate { }

    // @interface UAWhitelist : NSObject
    [BaseType(typeof(NSObject))]
    interface UAWhitelist
    {
        // @property (getter=isOpenURLWhitelistingEnabled, assign, readwrite, nonatomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { [Bind("isOpenURLWhitelistingEnabled")] get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAWhitelistDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAWhitelistDelegate Delegate { get; set; }

        // + (nonnull instancetype)whitelistWithConfig:(nonnull UARuntimeConfig *)config;
        [Static]
        [Export("whitelistWithConfig:")]
        UAWhitelist Whitelist(UARuntimeConfig config);

        // - (BOOL)addEntry:(nonnull NSString *)patternString;
        [Export("addEntry:")]
        bool AddEntry(string patternString);

        // - (BOOL)addEntry:(nonnull NSString *)patternString scope:(UAWhitelistScope)scope;
        [Export("addEntry:scope:")]
        bool AddEntry(string patternString, UAWhitelistScope scope);

        // - (BOOL)isWhitelisted:(nonnull NSURL *)url;
        [Export("isWhitelisted:")]
        bool IsWhitelisted(NSUrl url);

        // - (BOOL)isWhitelisted:(nonnull NSURL *)url scope:(UAWhitelistScope)scope;
        [Export("isWhitelisted:scope:")]
        bool IsWhitelisted(NSUrl url, UAWhitelistScope scope);
    }

    // @protocol UADeepLinkDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UADeepLinkDelegate
    {

        // - (void)receivedDeepLink:(NSURL *_Nonnull)url completionHandler:(void (^_Nonnull)(void))completionHandler;
        [Export("receivedDeepLink:completionHandler:")]
        void ReceivedDeepLink(NSUrl url, Action completionHandler);
    }

    interface IUADeepLinkDelegate { }

    // @interface UAirship : NSObject
    [BaseType(typeof(NSObject))]
    interface UAirship
    {
        // @property (readonly, strong, nonatomic) UARuntimeConfig *_Nonnull config;
        [Export("config", ArgumentSemantic.Strong)]
        UARuntimeConfig Config { get; }

        // @property (readonly, strong, nonatomic) UAActionRegistry *_Nonnull actionRegistry;
        [Export("actionRegistry", ArgumentSemantic.Strong)]
        UAActionRegistry ActionRegistry { get; }

        // @property (readonly, strong, nonatomic) UAApplicationMetrics *_Nonnull applicationMetrics;
        [Export("applicationMetrics", ArgumentSemantic.Strong)]
        UAApplicationMetrics ApplicationMetrics { get; }

        // @property (readonly, assign, nonatomic) BOOL remoteNotificationBackgroundModeEnabled;
        [Export("remoteNotificationBackgroundModeEnabled")]
        bool RemoteNotificationBackgroundModeEnabled { get; }

        // @property (readwrite, nonatomic, nullable) id<UAJavaScriptDelegate> jsDelegate;
        [NullAllowed, Export("jsDelegate", ArgumentSemantic.Assign)]
        NSObject WeakJsDelegate { get; set; }

        [Wrap("WeakJsDelegate")]
        [NullAllowed]
        IUAJavaScriptDelegate JsDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UADeepLinkDelegate> deepLinkDelegate;
        [NullAllowed, Export("deepLinkDelegate", ArgumentSemantic.Assign)]
        NSObject WeakDeepLinkDelegate { get; set; }

        [Wrap("WeakDeepLinkDelegate")]
        [NullAllowed]
        IUADeepLinkDelegate DeepLinkDelegate { get; set; }

        // @property (nonatomic, weak, nullable) id<UALocationProviderDelegate> locationProviderDelegate
        [NullAllowed, Export("locationProviderDelegate", ArgumentSemantic.Assign)]
        NSObject WeakLocationProviderDelegate { get; set; }

        [Wrap("WeakLocationProviderDelegate")]
        [NullAllowed]
        IUALocationProviderDelegate LocationProviderDelegate { get; set; }

        // @property (readonly, strong, nonatomic) UAWhitelist *_Nonnull whitelist;
        [Export("whitelist", ArgumentSemantic.Strong)]
        UAWhitelist Whitelist { get; }

        // @property (readonly, strong, nonatomic) UAChannelCapture *_Nonnull channelCapture;
        [Export("channelCapture", ArgumentSemantic.Strong)]
        UAChannelCapture ChannelCapture { get; }

        // + (void)setLogging:(BOOL)enabled;
        [Static]
        [Export("setLogging:")]
        void SetLogging(bool enabled);

        // + (void)setLogLevel:(UALogLevel)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(UALogLevel level);

        // + (void)setLoudImpErrorLogging:(BOOL)enabled;
        [Static]
        [Export("setLoudImpErrorLogging:")]
        void SetLoudImpErrorLogging(bool enabled);

        // + (void)takeOff:(nullable UAConfig *)config;
        [Static]
        [Export("takeOff:")]
        void TakeOff([NullAllowed] UAConfig config);

        // + (void)takeOff;
        [Static]
        [Export("takeOff")]
        void TakeOff();

        // + (null_unspecified UAirship *)shared;
        [Static]
        [Export("shared")]
        UAirship Shared();

        // + (null_unspecified UAChannel *)channel;
        [Static]
        [Export("channel")]
        UAChannel Channel();

        // + (null_unspecified UAPush *)push;
        [Static]
        [Export("push")]
        UAPush Push();

        // + (null_unspecified UAInbox *)inbox;
        [Static]
        [Export("inbox")]
        UAInbox Inbox();

        // + (null_unspecified UAUser *)inboxUser;
        [Static]
        [Export("inboxUser")]
        UAUser InboxUser();

        // + (null_unspecified UAInAppMessageManager *)inAppMessageManager;
        [Static]
        [Export("inAppMessageManager")]
        UAInAppMessageManager InAppMessageManager();

        // + (null_unspecified UALegacyInAppMessaging *)legacyInAppMessaging;
        [Static]
        [Export("legacyInAppMessaging")]
        UALegacyInAppMessaging LegacyInAppMessaging();

        // + (null_unspecified UAMessageCenter *)messageCenter;
        [Static]
        [Export("messageCenter")]
        UAMessageCenter MessageCenter();

        // + (null_unspecified UANamedUser *)namedUser;
        [Static]
        [Export("namedUser")]
        UANamedUser NamedUser();

        // + (nullable NSBundle *)resources;
        [Static]
        [Export("resources")]
        [return: NullAllowed]
        NSBundle Resources();

        // + (null_unspecified UAAutomation *)automation;
        [Static]
        [Export("automation")]
        UAAutomation Automation();

        // + (null_unspecified UAAnalytics *)analytics;
        [Static]
        [Export("analytics")]
        UAAnalytics Analytics();

        // + (null_unspecified UAModules *)modules;
        [Static]
        [Export("modules")]
        UAModules Modules();
    }

    // @interface UAirshipVersion : NSObject
    [BaseType(typeof(NSObject))]
    interface UAirshipVersion
    {

        // + (nonnull NSString *)get;
        [Static]
        [Export("get")]
        string Get();
    }

    // @interface UAActionJSDelegate : NSObject <UAJavaScriptDelegate>
    [BaseType(typeof(NSObject))]
    interface UAActionJSDelegate : IUAJavaScriptDelegate
    {

    }

    // @interface UAActivityViewController : UIActivityViewController <UIPopoverPresentationControllerDelegate, UIPopoverControllerDelegate>
    [BaseType(typeof(UIActivityViewController))]
    interface UAActivityViewController : IUIPopoverPresentationControllerDelegate, IUIPopoverControllerDelegate
    {
        // @property (readwrite, copy, nonatomic, nullable) void (^)(void) dismissalBlock;
        [NullAllowed, Export("dismissalBlock", ArgumentSemantic.Copy)]
        Action DismissalBlock { get; set; }

        // - (CGRect)sourceRect;
        [Export("sourceRect")]
        CGRect SourceRect();
    }

    // @interface UABaseNativeBridge : NSObject
    [BaseType(typeof(NSObject))]
    interface UABaseNativeBridge
    {

    }

    // @interface UAChannelCapture : NSObject
    [BaseType(typeof(NSObject))]
    interface UAChannelCapture
    {

        // - (void)enable:(NSTimeInterval)duration;
        [Export("enable:")]
        void Enable(double duration);

        // - (void)disable;
        [Export("disable")]
        void Disable();
    }

    // @interface UAChannelCaptureAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAChannelCaptureAction
    {

    }

    // @interface UADisplayInboxAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UADisplayInboxAction
    {

        // - (void)displayInboxMessage:(nonnull UAInboxMessage *)message situation:(UASituation)situation;
        [Export("displayInboxMessage:situation:")]
        void DisplayInboxMessage(UAInboxMessage message, UASituation situation);

        // - (void)displayInboxWithSituation:(UASituation)situation;
        [Export("displayInboxWithSituation:")]
        void DisplayInbox(UASituation situation);
    }

    // @interface UAInAppMessageBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBuilder
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageDisplayContent *displayContent;
        [NullAllowed, Export("displayContent", ArgumentSemantic.Strong)]
        UAInAppMessageDisplayContent DisplayContent { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *extras;
        [NullAllowed, Export("extras", ArgumentSemantic.Copy)]
        NSDictionary Extras { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageAudience *audience;
        [NullAllowed, Export("audience", ArgumentSemantic.Strong)]
        UAInAppMessageAudience Audience { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *displayBehavior;
        [NullAllowed, Export("displayBehavior")]
        string DisplayBehavior { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL isReportingEnabled;
        [Export("isReportingEnabled")]
        bool IsReportingEnabled { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessage
    {
        // @property (readonly, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) UAInAppMessageDisplayType displayType;
        [Export("displayType")]
        UAInAppMessageDisplayType DisplayType { get; }

        // @property (readonly, nonatomic) UAInAppMessageDisplayContent *_Nonnull displayContent;
        [Export("displayContent")]
        UAInAppMessageDisplayContent DisplayContent { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *extras;
        [NullAllowed, Export("extras")]
        NSDictionary Extras { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageAudience *audience;
        [NullAllowed, Export("audience")]
        UAInAppMessageAudience Audience { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull displayBehavior;
        [Export("displayBehavior")]
        string DisplayBehavior { get; }

        // @property (readonly, assign, nonatomic) BOOL isReportingEnabled;
        [Export("isReportingEnabled")]
        bool IsReportingEnabled { get; }

        // + (nullable instancetype)messageWithBuilderBlock: (nonnull void (^)(UAInAppMessageBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("messageWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessage Message(Action<UAInAppMessageBuilder> builderBlock);

        // - (nullable UAInAppMessage *)extend: (nonnull void (^)(UAInAppMessageBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessage Extend(Action<UAInAppMessageBuilder> builderBlock);
    }

    // @protocol UAInAppMessageAdapterProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAdapterProtocol
    {

        // + (nonnull instancetype)adapterForMessage:(nonnull UAInAppMessage *)message;
        [Static]
        [Export("adapterForMessage:")]
        UAInAppMessageAdapterProtocol Adapter(UAInAppMessage message);

        // - (void)prepareWithAssets:(nonnull UAInAppMessageAssets *)assets completionHandler: (nonnull void (^)(UAInAppMessagePrepareResult))completionHandler;
        [Abstract]
        [Export("prepareWithAssets:completionHandler:")]
        void Prepare(UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);

        // - (BOOL)isReadyToDisplay;
        [Abstract]
        [Export("isReadyToDisplay")]
        bool IsReadyToDisplay();

        // - (void)display: (nonnull void (^)(UAInAppMessageResolution *_Nonnull))completionHandler;
        [Abstract]
        [Export("display:")]
        void Display(Action<UAInAppMessageResolution> completionHandler);
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
        bool ShouldCacheOnSchedule(UAInAppMessage message);

        // - (BOOL)shouldPersistCacheAfterDisplay:(nonnull UAInAppMessage *)message;
        [Abstract]
        [Export("shouldPersistCacheAfterDisplay:")]
        bool ShouldPersistCacheAfterDisplay(UAInAppMessage message);
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
        void OnSchedule(UAInAppMessage message, UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);

        // - (void)onPrepare:(nonnull UAInAppMessage *)message assets:(nonnull UAInAppMessageAssets *)assets completionHandler: (nonnull void (^)(UAInAppMessagePrepareResult))completionHandler;
        [Abstract]
        [Export("onPrepare:assets:completionHandler:")]
        void OnPrepare(UAInAppMessage message, UAInAppMessageAssets assets, Action<UAInAppMessagePrepareResult> completionHandler);
    }

    interface IUAInAppMessagePrepareAssetsDelegate { }

    // @interface UAInAppMessageAssetManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAssetManager
    {
        // @property (readwrite, strong, nonatomic) id<UAInAppMessagePrepareAssetsDelegate> _Nonnull prepareAssetsDelegate;
        [Export("prepareAssetsDelegate", ArgumentSemantic.Strong)]
        NSObject WeakPrepareAssetsDelegate { get; set; }

        [Wrap("WeakPrepareAssetsDelegate")]
        IUAInAppMessagePrepareAssetsDelegate PrepareAssetsDelegate { get; set; }

        // @property (readwrite, nonatomic) id<UAInAppMessageCachePolicyDelegate> _Nullable cachePolicyDelegate;
        [NullAllowed, Export("cachePolicyDelegate", ArgumentSemantic.Assign)]
        NSObject WeakCachePolicyDelegate { get; set; }

        [Wrap("WeakCachePolicyDelegate")]
        [NullAllowed]
        IUAInAppMessageCachePolicyDelegate CachePolicyDelegate { get; set; }

    }

    // @interface UAInAppMessageAssets : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAssets
    {

        // - (nullable NSURL *)getCacheURL:(nonnull NSURL *)assetURL;
        [Export("getCacheURL:")]
        [return: NullAllowed]
        NSUrl GetCacheURL(NSUrl assetURL);

        // - (BOOL)isCached:(nonnull NSURL *)assetURL;
        [Export("isCached:")]
        bool IsCached(NSUrl assetURL);
    }

    // @interface UAInAppMessageAudienceBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAudienceBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *notificationsOptIn;
        [NullAllowed, Export("notificationsOptIn", ArgumentSemantic.Strong)]
        NSNumber NotificationsOptIn { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *locationOptIn;
        [NullAllowed, Export("locationOptIn", ArgumentSemantic.Strong)]
        NSNumber LocationOptIn { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<NSString *> *languageTags;
        [NullAllowed, Export("languageTags", ArgumentSemantic.Copy)]
        string[] LanguageTags { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTagSelector *tagSelector;
        [NullAllowed, Export("tagSelector", ArgumentSemantic.Strong)]
        UAInAppMessageTagSelector TagSelector { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAJSONPredicate *versionPredicate;
        [NullAllowed, Export("versionPredicate", ArgumentSemantic.Strong)]
        UAJSONPredicate VersionPredicate { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageAudienceMissBehaviorType missBehavior;
        [Export("missBehavior", ArgumentSemantic.Assign)]
        UAInAppMessageAudienceMissBehaviorType MissBehavior { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageAudience : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageAudience
    {
        // @property (readonly, nonatomic, nullable) NSNumber *notificationsOptIn;
        [NullAllowed, Export("notificationsOptIn")]
        NSNumber NotificationsOptIn { get; }

        // @property (readonly, nonatomic, nullable) NSNumber *locationOptIn;
        [NullAllowed, Export("locationOptIn")]
        NSNumber LocationOptIn { get; }

        // @property (readonly, nonatomic, nullable) NSArray<NSString *> *languageIDs;
        [NullAllowed, Export("languageIDs")]
        string[] LanguageIDs { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageTagSelector *tagSelector;
        [NullAllowed, Export("tagSelector")]
        UAInAppMessageTagSelector TagSelector { get; }

        // @property (readonly, nonatomic, nullable) UAJSONPredicate *versionPredicate;
        [NullAllowed, Export("versionPredicate")]
        UAJSONPredicate VersionPredicate { get; }

        // @property (readonly, nonatomic) UAInAppMessageAudienceMissBehaviorType missBehavior;
        [Export("missBehavior")]
        UAInAppMessageAudienceMissBehaviorType MissBehavior { get; }

        // + (nullable instancetype)audienceWithBuilderBlock: (nonnull void (^)(UAInAppMessageAudienceBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("audienceWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageAudience Audience(Action<UAInAppMessageAudienceBuilder> builderBlock);
    }

    // @interface UAInAppMessageBannerAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageBannerStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageBannerStyle Style { get; set; }

    }

    // @interface UAInAppMessageBannerDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerDisplayContentBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageBannerPlacementType placement;
        [Export("placement", ArgumentSemantic.Assign)]
        UAInAppMessageBannerPlacementType Placement { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageBannerContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageBannerContentLayoutType ContentLayout { get; set; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval durationSeconds;
        [Export("durationSeconds", ArgumentSemantic.Assign)]
        double DurationSeconds { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageBannerDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageBannerDisplayContent
    {
        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (readonly, nonatomic) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (readonly, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (readonly, nonatomic) UAInAppMessageBannerPlacementType placement;
        [Export("placement")]
        UAInAppMessageBannerPlacementType Placement { get; }

        // @property (readonly, nonatomic) UAInAppMessageBannerContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageBannerContentLayoutType ContentLayout { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationSeconds;
        [Export("durationSeconds")]
        double DurationSeconds { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (readonly, assign, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageBannerDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageBannerDisplayContent DisplayContent(Action<UAInAppMessageBannerDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageBannerDisplayContent *)extend: (nonnull void (^)(UAInAppMessageBannerDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageBannerDisplayContent Extend(Action<UAInAppMessageBannerDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageBannerStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageBannerStyle : IUAInAppMessageStyleProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }

    }

    // @interface UAInAppMessageButtonInfoBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonInfoBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *label;
        [NullAllowed, Export("label", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Label { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageButtonInfoBehaviorType behavior;
        [Export("behavior", ArgumentSemantic.Assign)]
        UAInAppMessageButtonInfoBehaviorType Behavior { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        NSDictionary Actions { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageButtonInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonInfo
    {
        // @property (readonly, nonatomic) UAInAppMessageTextInfo *_Nonnull label;
        [Export("label")]
        UAInAppMessageTextInfo Label { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic) UAInAppMessageButtonInfoBehaviorType behavior;
        [Export("behavior")]
        UAInAppMessageButtonInfoBehaviorType Behavior { get; }

        // @property (readonly, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints")]
        nfloat BorderRadiusPoints { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull borderColor;
        [Export("borderColor")]
        UIColor BorderColor { get; }

        // @property (readonly, nonatomic, nullable) NSDictionary *actions;
        [NullAllowed, Export("actions")]
        NSDictionary Actions { get; }

        // + (nullable instancetype)buttonInfoWithBuilderBlock: (nonnull void (^)(UAInAppMessageButtonInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("buttonInfoWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageButtonInfo ButtonInfo(Action<UAInAppMessageButtonInfoBuilder> builderBlock);

        // - (nullable UAInAppMessageButtonInfo *)extend: (nonnull void (^)(UAInAppMessageButtonInfoBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageButtonInfo Extend(Action<UAInAppMessageButtonInfoBuilder> builderBlock);
    }

    // @interface UAInAppMessageButtonStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageButtonStyle
    {
        // @property (readwrite, strong, nonatomic, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *buttonTextStyle;
        [NullAllowed, Export("buttonTextStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle ButtonTextStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *buttonHeight;
        [NullAllowed, Export("buttonHeight", ArgumentSemantic.Strong)]
        NSNumber ButtonHeight { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *stackedButtonSpacing;
        [NullAllowed, Export("stackedButtonSpacing", ArgumentSemantic.Strong)]
        NSNumber StackedButtonSpacing { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *separatedButtonSpacing;
        [NullAllowed, Export("separatedButtonSpacing", ArgumentSemantic.Strong)]
        NSNumber SeparatedButtonSpacing { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *borderWidth;
        [NullAllowed, Export("borderWidth", ArgumentSemantic.Strong)]
        NSNumber BorderWidth { get; set; }

        // + (nonnull instancetype) styleWithAdditionalPadding:(nullable UAPadding *)additionalPadding buttonTextStyle:(nullable UAInAppMessageTextStyle *)textStyle buttonHeight:(nullable NSNumber *)buttonHeight stackedButtonSpacing:(nullable NSNumber *)stackedButtonSpacing separatedButtonSpacing:(nullable NSNumber *)separatedButtonSpacing borderWidth:(nullable NSNumber *)borderWidth;
        [Static]
        [Export("styleWithAdditionalPadding:buttonTextStyle:buttonHeight:stackedButtonSpacing:separatedButtonSpacing:borderWidth:")]
        UAInAppMessageButtonStyle Style([NullAllowed] UAPadding additionalPadding, [NullAllowed] UAInAppMessageTextStyle textStyle, [NullAllowed] NSNumber buttonHeight, [NullAllowed] NSNumber stackedButtonSpacing, [NullAllowed] NSNumber separatedButtonSpacing, [NullAllowed] NSNumber borderWidth);

        // + (nonnull instancetype)styleWithDictionary: (nullable NSDictionary *)buttonStyle;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageButtonStyle Style([NullAllowed] NSDictionary buttonStyle);
    }

    // @interface UAInAppMessageCustomDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageCustomDisplayContent
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull value;
        [Export("value")]
        NSDictionary Value { get; }

        // + (nonnull instancetype)displayContentWithValue:(nonnull NSDictionary *)value;
        [Static]
        [Export("displayContentWithValue:")]
        UAInAppMessageCustomDisplayContent DisplayContent(NSDictionary value);
    }

    // @interface UAInAppMessageDefaultDisplayCoordinator : NSObject <UAInAppMessageDisplayCoordinator>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDefaultDisplayCoordinator : IUAInAppMessageDisplayCoordinator
    {
        // @property (readonly, nonatomic) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval displayInterval;
        [Export("displayInterval", ArgumentSemantic.Assign)]
        double DisplayInterval { get; set; }

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
        // @property (readonly, nonatomic) UAInAppMessageDisplayType displayType;
        [Export("displayType")]
        UAInAppMessageDisplayType DisplayType { get; }

        // - (NSDictionary *)toJSON;
        [Export("toJSON")]
        NSDictionary ToJSON();
    }

    // @protocol UAInAppMessageDisplayCoordinator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageDisplayCoordinator
    {
        // @property (readonly, nonatomic) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

        // - (void)didBeginDisplayingMessage:(UAInAppMessage *)message;
        [Export("didBeginDisplayingMessage:")]
        void DidBeginDisplayingMessage(UAInAppMessage message);

        // - (void)didFinishDisplayingMessage:(UAInAppMessage *)message;
        [Export("didFinishDisplayingMessage:")]
        void DidFinishDisplayingMessage(UAInAppMessage message);
    }

    interface IUAInAppMessageDisplayCoordinator { }

    // @interface UAInAppMessageFullScreenAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageFullScreenStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageFullScreenStyle Style { get; set; }

    }

    // @interface UAInAppMessageFullScreenDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenDisplayContentBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer", ArgumentSemantic.Strong)]
        UAInAppMessageButtonInfo Footer { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageFullScreenContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageFullScreenContentLayoutType ContentLayout { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageFullScreenDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageFullScreenDisplayContent
    {
        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer")]
        UAInAppMessageButtonInfo Footer { get; }

        // @property (readonly, nonatomic) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (readonly, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (readonly, nonatomic) UAInAppMessageFullScreenContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageFullScreenContentLayoutType ContentLayout { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageFullScreenDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageFullScreenDisplayContent DisplayContent(Action<UAInAppMessageFullScreenDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageFullScreenDisplayContent *)extend: (nonnull void (^)(UAInAppMessageFullScreenDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageFullScreenDisplayContent Extend(Action<UAInAppMessageFullScreenDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageFullScreenStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageFullScreenStyle : IUAInAppMessageStyleProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }

    }

    // @interface UAInAppMessageHTMLAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageHTMLStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageHTMLStyle Style { get; set; }

    }

    // @interface UAInAppMessageHTMLDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLDisplayContentBuilder
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *url;
        [NullAllowed, Export("url")]
        string Url { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat height;
        [Export("height", ArgumentSemantic.Assign)]
        nfloat Height { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat width;
        [Export("width", ArgumentSemantic.Assign)]
        nfloat Width { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL aspectLock;
        [Export("aspectLock")]
        bool AspectLock { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL requiresConnectivity;
        [Export("requiresConnectivity")]
        bool RequiresConnectivity { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageHTMLDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageHTMLDisplayContent
    {
        // @property (readonly, nonatomic) NSString *_Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (readonly, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints")]
        nfloat BorderRadiusPoints { get; }

        // @property (readonly, nonatomic) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; }

        // @property (readonly, nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; }

        // @property (readonly, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; }

        // @property (readonly, nonatomic) BOOL aspectLock;
        [Export("aspectLock")]
        bool AspectLock { get; }

        // @property (readonly, nonatomic) BOOL requireConnectivity;
        [Export("requireConnectivity")]
        bool RequireConnectivity { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageHTMLDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageHTMLDisplayContent DisplayContent(Action<UAInAppMessageHTMLDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageHTMLDisplayContent *)extend: (nonnull void (^)(UAInAppMessageHTMLDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageHTMLDisplayContent Extend(Action<UAInAppMessageHTMLDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageHTMLStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageHTMLStyle : IUAInAppMessageStyleProtocol
    {
        // @property (readwrite, strong, nonatomic) UAPadding *_Nonnull additionalPadding;
        [Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *maxHeight;
        [NullAllowed, Export("maxHeight", ArgumentSemantic.Strong)]
        NSNumber MaxHeight { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL hideDismissIcon;
        [Export("hideDismissIcon")]
        bool HideDismissIcon { get; set; }

    }

    // @interface UAInAppMessageImmediateDisplayCoordinator : NSObject <UAInAppMessageDisplayCoordinator>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageImmediateDisplayCoordinator : IUAInAppMessageDisplayCoordinator
    {
        // @property (readonly, nonatomic) BOOL isReady;
        [Export("isReady")]
        bool IsReady { get; }

    }

    // @protocol UAInAppMessagingDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessagingDelegate
    {

        // - (nullable id<UAInAppMessageDisplayCoordinator>)displayCoordinatorForMessage: (nonnull UAInAppMessage *)message;
        [Export("displayCoordinatorForMessage:")]
        [return: NullAllowed]
        UAInAppMessageDisplayCoordinator DisplayCoordinator(UAInAppMessage message);

        // - (nonnull UAInAppMessage *)extendMessage:(nonnull UAInAppMessage *)message;
        [Export("extendMessage:")]
        UAInAppMessage ExtendMessage(UAInAppMessage message);

        // - (void)messageWillBeDisplayed:(nonnull UAInAppMessage *)message scheduleID:(nonnull NSString *)scheduleID;
        [Export("messageWillBeDisplayed:scheduleID:")]
        void MessageWillBeDisplayed(UAInAppMessage message, string scheduleID);

        // - (void)messageFinishedDisplaying:(nonnull UAInAppMessage *)message scheduleID:(nonnull NSString *)scheduleID resolution: (nonnull UAInAppMessageResolution *)resolution;
        [Export("messageFinishedDisplaying:scheduleID:resolution:")]
        void MessageFinishedDisplaying(UAInAppMessage message, string scheduleID, UAInAppMessageResolution resolution);

        // - (nonnull UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message defaultScene: (nullable UIWindowScene *)defaultScene;
        [Export("sceneForMessage:defaultScene:")]
        UIWindowScene Scene(UAInAppMessage message, [NullAllowed] UIWindowScene defaultScene);
    }

    interface IUAInAppMessagingDelegate { }

    // @interface UAInAppMessageManager : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAInAppMessageManager
    {
        // @property (getter=isEnabled, assign, readwrite, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (getter=isPaused, assign, readwrite, nonatomic) BOOL paused;
        [Export("paused")]
        bool Paused { [Bind("isPaused")] get; set; }

        // @property (readwrite, nonatomic) id<UAInAppMessagingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAInAppMessagingDelegate Delegate { get; set; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval displayInterval;
        [Export("displayInterval", ArgumentSemantic.Assign)]
        double DisplayInterval { get; set; }

        // @property (readonly, strong, nonatomic) UAInAppMessageAssetManager *_Nonnull assetManager;
        [Export("assetManager", ArgumentSemantic.Strong)]
        UAInAppMessageAssetManager AssetManager { get; }

        // - (void)setFactoryBlock:(nonnull id<UAInAppMessageAdapterProtocol> _Nonnull (^)( UAInAppMessage *_Nonnull))factory forDisplayType:(UAInAppMessageDisplayType)displayType;
        [Export("setFactoryBlock:forDisplayType:")]
        void SetFactoryBlock(Action<UAInAppMessage> factory, UAInAppMessageDisplayType displayType);

        // - (void)scheduleMessageWithScheduleInfo: (nonnull UAInAppMessageScheduleInfo *)scheduleInfo completionHandler:(nonnull void (^)(UASchedule *_Nonnull)) completionHandler;
        [Export("scheduleMessageWithScheduleInfo:completionHandler:")]
        void ScheduleMessage(UAInAppMessageScheduleInfo scheduleInfo, Action<UASchedule> completionHandler);

        // - (void)scheduleMessageWithScheduleInfo: (nonnull UAInAppMessageScheduleInfo *)scheduleInfo metadata:(nullable NSDictionary *)metadata completionHandler:(nonnull void (^)(UASchedule *_Nonnull)) completionHandler;
        [Export("scheduleMessageWithScheduleInfo:metadata:completionHandler:")]
        void ScheduleMessage(UAInAppMessageScheduleInfo scheduleInfo, [NullAllowed] NSDictionary metadata, Action<UASchedule> completionHandler);

        // - (void)scheduleMessagesWithScheduleInfo: (nonnull NSArray<UAInAppMessageScheduleInfo *> *)scheduleInfos metadata:(nullable NSDictionary *)metadata completionHandler: (nonnull void (^)(NSArray<UASchedule *> *_Nonnull)) completionHandler;
        [Export("scheduleMessagesWithScheduleInfo:metadata:completionHandler:")]
        void ScheduleMessages(UAInAppMessageScheduleInfo[] scheduleInfos, [NullAllowed] NSDictionary metadata, UASchedule[] completionHandler);

        // - (void)cancelScheduleWithID:(nonnull NSString *)scheduleID;
        [Export("cancelScheduleWithID:")]
        void CancelSchedule(string scheduleID);

        // - (void)cancelMessagesWithID:(nonnull NSString *)identifier;
        [Export("cancelMessagesWithID:")]
        void CancelMessages(string identifier);

        // - (void)getScheduleWithID:(nonnull NSString *)identifier completionHandler: (nonnull void (^)(UASchedule *_Nonnull))completionHandler;
        [Export("getScheduleWithID:completionHandler:")]
        void GetSchedule(string identifier, Action<UASchedule> completionHandler);

        // - (void)getSchedulesWithMessageID:(nonnull NSString *)messageID completionHandler: (nonnull void (^)(NSArray<UASchedule *> *_Nonnull)) completionHandler;
        [Export("getSchedulesWithMessageID:completionHandler:")]
        void GetSchedules(string messageID, UASchedule[] completionHandler);

        // - (void)getAllSchedules: (nonnull void (^)(NSArray<UASchedule *> *_Nonnull))completionHandler;
        [Export("getAllSchedules:")]
        void GetAllSchedules(UASchedule[] completionHandler);

        // - (void)editScheduleWithID:(nonnull NSString *)identifier edits:(nonnull UAInAppMessageScheduleEdits *)edits completionHandler: (nonnull void (^)(UASchedule *_Nullable))completionHandler;
        [Export("editScheduleWithID:edits:completionHandler:")]
        void EditSchedule(string identifier, UAInAppMessageScheduleEdits edits, Action<UASchedule> completionHandler);

        // - (void)checkAudience:(nonnull UAInAppMessageAudience *)audience completionHandler: (nonnull void (^)(BOOL, NSError *_Nullable))completionHandler;
        [Export("checkAudience:completionHandler:")]
        void CheckAudience(UAInAppMessageAudience audience, Action<bool, NSError> completionHandler);
    }

    // @interface UAInAppMessageMediaInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageMediaInfo
    {
        // @property (readonly, nonatomic) NSString *_Nonnull url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, nonatomic) UAInAppMessageMediaInfoType type;
        [Export("type")]
        UAInAppMessageMediaInfoType Type { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull contentDescription;
        [Export("contentDescription")]
        string ContentDescription { get; }

        // + (nonnull instancetype)mediaInfoWithURL:(nonnull NSString *)url contentDescription:(nonnull NSString *)contentDescription type:(UAInAppMessageMediaInfoType)type;
        [Static]
        [Export("mediaInfoWithURL:contentDescription:type:")]
        UAInAppMessageMediaInfo MediaInfo(string url, string contentDescription, UAInAppMessageMediaInfoType type);
    }

    // @interface UAInAppMessageMediaStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageMediaStyle
    {
        // @property (readwrite, strong, nonatomic, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // + (nonnull instancetype)styleWithAdditionalPadding: (nullable UAPadding *)additionalPadding;
        [Static]
        [Export("styleWithAdditionalPadding:")]
        UAInAppMessageMediaStyle Style([NullAllowed] UAPadding additionalPadding);

        // + (nonnull instancetype)styleWithDictionary: (nullable NSDictionary *)mediaStyleDict;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageMediaStyle Style([NullAllowed] NSDictionary mediaStyleDict);
    }

    // @interface UAInAppMessageModalAdapter : NSObject <UAInAppMessageAdapterProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalAdapter : IUAInAppMessageAdapterProtocol
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageModalStyle *style;
        [NullAllowed, Export("style", ArgumentSemantic.Strong)]
        UAInAppMessageModalStyle Style { get; set; }

    }

    // @interface UAInAppMessageModalDisplayContentBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalDisplayContentBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Heading { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body", ArgumentSemantic.Strong)]
        UAInAppMessageTextInfo Body { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media", ArgumentSemantic.Strong)]
        UAInAppMessageMediaInfo Media { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer", ArgumentSemantic.Strong)]
        UAInAppMessageButtonInfo Footer { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<UAInAppMessageButtonInfo *> *buttons;
        [NullAllowed, Export("buttons", ArgumentSemantic.Copy)]
        UAInAppMessageButtonInfo[] Buttons { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout", ArgumentSemantic.Assign)]
        UAInAppMessageButtonLayoutType ButtonLayout { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageModalContentLayoutType contentLayout;
        [Export("contentLayout", ArgumentSemantic.Assign)]
        UAInAppMessageModalContentLayoutType ContentLayout { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor", ArgumentSemantic.Strong)]
        UIColor DismissButtonColor { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageModalDisplayContent : UAInAppMessageDisplayContent
    [BaseType(typeof(UAInAppMessageDisplayContent))]
    interface UAInAppMessageModalDisplayContent
    {
        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *heading;
        [NullAllowed, Export("heading")]
        UAInAppMessageTextInfo Heading { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageTextInfo *body;
        [NullAllowed, Export("body")]
        UAInAppMessageTextInfo Body { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageMediaInfo *media;
        [NullAllowed, Export("media")]
        UAInAppMessageMediaInfo Media { get; }

        // @property (readonly, nonatomic, nullable) UAInAppMessageButtonInfo *footer;
        [NullAllowed, Export("footer")]
        UAInAppMessageButtonInfo Footer { get; }

        // @property (readonly, nonatomic) NSArray<UAInAppMessageButtonInfo *> *_Nonnull buttons;
        [Export("buttons")]
        UAInAppMessageButtonInfo[] Buttons { get; }

        // @property (readonly, nonatomic) UAInAppMessageButtonLayoutType buttonLayout;
        [Export("buttonLayout")]
        UAInAppMessageButtonLayoutType ButtonLayout { get; }

        // @property (readonly, nonatomic) UAInAppMessageModalContentLayoutType contentLayout;
        [Export("contentLayout")]
        UAInAppMessageModalContentLayoutType ContentLayout { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor *_Nonnull dismissButtonColor;
        [Export("dismissButtonColor")]
        UIColor DismissButtonColor { get; }

        // @property (readonly, assign, nonatomic) CGFloat borderRadiusPoints;
        [Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        nfloat BorderRadiusPoints { get; }

        // @property (readonly, nonatomic) BOOL allowFullScreenDisplay;
        [Export("allowFullScreenDisplay")]
        bool AllowFullScreenDisplay { get; }

        // + (nullable instancetype)displayContentWithBuilderBlock: (nonnull void (^)(UAInAppMessageModalDisplayContentBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("displayContentWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageModalDisplayContent DisplayContent(Action<UAInAppMessageModalDisplayContentBuilder> builderBlock);

        // - (nullable UAInAppMessageModalDisplayContent *)extend: (nonnull void (^)(UAInAppMessageModalDisplayContentBuilder *_Nonnull)) builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageModalDisplayContent Extend(Action<UAInAppMessageModalDisplayContentBuilder> builderBlock);
    }

    // @interface UAInAppMessageModalStyle : NSObject <UAInAppMessageStyleProtocol>
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageModalStyle : IUAInAppMessageStyleProtocol
    {
        // @property (readwrite, strong, nonatomic) UAPadding *_Nonnull additionalPadding;
        [Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSString *dismissIconResource;
        [NullAllowed, Export("dismissIconResource")]
        string DismissIconResource { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *maxWidth;
        [NullAllowed, Export("maxWidth", ArgumentSemantic.Strong)]
        NSNumber MaxWidth { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *maxHeight;
        [NullAllowed, Export("maxHeight", ArgumentSemantic.Strong)]
        NSNumber MaxHeight { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *headerStyle;
        [NullAllowed, Export("headerStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle HeaderStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageTextStyle *bodyStyle;
        [NullAllowed, Export("bodyStyle", ArgumentSemantic.Strong)]
        UAInAppMessageTextStyle BodyStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageButtonStyle *buttonStyle;
        [NullAllowed, Export("buttonStyle", ArgumentSemantic.Strong)]
        UAInAppMessageButtonStyle ButtonStyle { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessageMediaStyle *mediaStyle;
        [NullAllowed, Export("mediaStyle", ArgumentSemantic.Strong)]
        UAInAppMessageMediaStyle MediaStyle { get; set; }

    }

    // @interface UAInAppMessageResolution : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageResolution
    {
        // @property (readonly, nonatomic, nullable) UAInAppMessageButtonInfo *buttonInfo;
        [NullAllowed, Export("buttonInfo")]
        UAInAppMessageButtonInfo ButtonInfo { get; }

        // @property (readonly, nonatomic) UAInAppMessageResolutionType type;
        [Export("type")]
        UAInAppMessageResolutionType Type { get; }

        // + (nonnull instancetype)buttonClickResolutionWithButtonInfo: (nonnull UAInAppMessageButtonInfo *)buttonInfo;
        [Static]
        [Export("buttonClickResolutionWithButtonInfo:")]
        UAInAppMessageResolution ButtonClickResolution(UAInAppMessageButtonInfo buttonInfo);

        // + (nonnull instancetype)messageClickResolution;
        [Static]
        [Export("messageClickResolution")]
        UAInAppMessageResolution MessageClickResolution();

        // + (nonnull instancetype)userDismissedResolution;
        [Static]
        [Export("userDismissedResolution")]
        UAInAppMessageResolution UserDismissedResolution();

        // + (nonnull instancetype)timedOutResolution;
        [Static]
        [Export("timedOutResolution")]
        UAInAppMessageResolution TimedOutResolution();
    }

    // @protocol UAInAppMessageSceneDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageSceneDelegate
    {

        // - (nullable UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message defaultScene: (nullable UIWindowScene *)defaultScene;
        [Export("sceneForMessage:defaultScene:")]
        [return: NullAllowed]
        UIWindowScene Scene(UAInAppMessage message, [NullAllowed] UIWindowScene defaultScene);
    }

    interface IUAInAppMessageSceneDelegate { }

    // @interface UAInAppMessageSceneManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageSceneManager
    {
        // @property (readwrite, nonatomic) id<UAInAppMessageSceneDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAInAppMessageSceneDelegate Delegate { get; set; }

        // + (nonnull instancetype)shared;
        [Static]
        [Export("shared")]
        UAInAppMessageSceneManager Shared();

        // - (nullable UIWindowScene *)sceneForMessage:(nonnull UAInAppMessage *)message;
        [Export("sceneForMessage:")]
        [return: NullAllowed]
        UIWindowScene Scene(UAInAppMessage message);
    }

    // @interface UAInAppMessageScheduleEditsBuilder : UAScheduleEditsBuilder
    [BaseType(typeof(UAScheduleEditsBuilder))]
    interface UAInAppMessageScheduleEditsBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessage *message;
        [NullAllowed, Export("message", ArgumentSemantic.Strong)]
        UAInAppMessage Message { get; set; }

    }

    // @interface UAInAppMessageScheduleEdits : UAScheduleEdits
    [BaseType(typeof(UAScheduleEdits))]
    interface UAInAppMessageScheduleEdits
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessage *message;
        [NullAllowed, Export("message", ArgumentSemantic.Strong)]
        UAInAppMessage Message { get; set; }

        // + (nonnull instancetype)editsWithBuilderBlock: (nonnull void (^)(UAInAppMessageScheduleEditsBuilder *_Nonnull)) builderBlock;
        [Static]
        [Export("editsWithBuilderBlock:")]
        UAInAppMessageScheduleEdits Edits(Action<UAInAppMessageScheduleEditsBuilder> builderBlock);
    }

    // @interface UAInAppMessageScheduleInfoBuilder : UAScheduleInfoBuilder
    [BaseType(typeof(UAScheduleInfoBuilder))]
    interface UAInAppMessageScheduleInfoBuilder
    {
        // @property (readwrite, strong, nonatomic, nullable) UAInAppMessage *message;
        [NullAllowed, Export("message", ArgumentSemantic.Strong)]
        UAInAppMessage Message { get; set; }

    }

    // @interface UAInAppMessageScheduleInfo : UAScheduleInfo
    [BaseType(typeof(UAScheduleInfo))]
    interface UAInAppMessageScheduleInfo
    {
        // @property (readonly, nonatomic) UAInAppMessage *_Nonnull message;
        [Export("message")]
        UAInAppMessage Message { get; }

        // + (nullable instancetype)scheduleInfoWithBuilderBlock: (nonnull void (^)(UAInAppMessageScheduleInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("scheduleInfoWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageScheduleInfo ScheduleInfo(Action<UAInAppMessageScheduleInfoBuilder> builderBlock);

        // + (nullable NSString *)parseMessageID:(nonnull id)json;
        [Static]
        [Export("parseMessageID:")]
        [return: NullAllowed]
        string ParseMessageID(NSObject json);
    }

    // @protocol UAInAppMessageStyleProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageStyleProtocol
    {

        // + (nonnull instancetype)style;
        [Static]
        [Export("style")]
        UAInAppMessageStyleProtocol Style();

        // + (nullable instancetype)styleWithContentsOfFile:(nullable NSString *)path;
        [Static]
        [Export("styleWithContentsOfFile:")]
        [return: NullAllowed]
        UAInAppMessageStyleProtocol Style([NullAllowed] string path);
    }

    interface IUAInAppMessageStyleProtocol { }

    // @interface UAInAppMessageTagSelector : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTagSelector
    {

        // + (nonnull instancetype) and:(nonnull NSArray<UAInAppMessageTagSelector *> *)selectors;
        [Static]
        [Export("and:")]
        UAInAppMessageTagSelector And(UAInAppMessageTagSelector[] selectors);

        // + (nonnull instancetype) or:(nonnull NSArray<UAInAppMessageTagSelector *> *)selectors;
        [Static]
        [Export("or:")]
        UAInAppMessageTagSelector Or(UAInAppMessageTagSelector[] selectors);

        // + (nonnull instancetype) not:(nonnull UAInAppMessageTagSelector *)selector;
        [Static]
        [Export("not:")]
        UAInAppMessageTagSelector Not(UAInAppMessageTagSelector selector);

        // + (nonnull instancetype)tag:(nonnull NSString *)tag;
        [Static]
        [Export("tag:")]
        UAInAppMessageTagSelector Tag(string tag);

        // - (BOOL)apply:(nonnull NSArray<NSString *> *)tags;
        [Export("apply:")]
        bool Apply(string[] tags);
    }

    // @interface UAInAppMessageTextInfoBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextInfoBuilder
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *_Nonnull color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (assign, readwrite, nonatomic) CGFloat sizePoints;
        [Export("sizePoints", ArgumentSemantic.Assign)]
        nfloat SizePoints { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageTextInfoAlignmentType alignment;
        [Export("alignment", ArgumentSemantic.Assign)]
        UAInAppMessageTextInfoAlignmentType Alignment { get; set; }

        // @property (assign, readwrite, nonatomic) UAInAppMessageTextInfoStyleType style;
        [Export("style", ArgumentSemantic.Assign)]
        UAInAppMessageTextInfoStyleType Style { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSArray<NSString *> *fontFamilies;
        [NullAllowed, Export("fontFamilies", ArgumentSemantic.Copy)]
        string[] FontFamilies { get; set; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid();
    }

    // @interface UAInAppMessageTextInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextInfo
    {
        // @property (readonly, nonatomic, nullable) NSString *text;
        [NullAllowed, Export("text")]
        string Text { get; }

        // @property (readonly, nonatomic, nullable) UIColor *color;
        [NullAllowed, Export("color")]
        UIColor Color { get; }

        // @property (readonly, nonatomic) CGFloat sizePoints;
        [Export("sizePoints")]
        nfloat SizePoints { get; }

        // @property (readonly, nonatomic) UAInAppMessageTextInfoAlignmentType alignment;
        [Export("alignment")]
        UAInAppMessageTextInfoAlignmentType Alignment { get; }

        // @property (readonly, nonatomic) UAInAppMessageTextInfoStyleType style;
        [Export("style")]
        UAInAppMessageTextInfoStyleType Style { get; }

        // @property (readonly, nonatomic, nullable) NSArray<NSString *> *fontFamilies;
        [NullAllowed, Export("fontFamilies")]
        string[] FontFamilies { get; }

        // + (nullable instancetype)textInfoWithBuilderBlock: (nonnull void (^)(UAInAppMessageTextInfoBuilder *_Nonnull))builderBlock;
        [Static]
        [Export("textInfoWithBuilderBlock:")]
        [return: NullAllowed]
        UAInAppMessageTextInfo TextInfo(Action<UAInAppMessageTextInfoBuilder> builderBlock);

        // - (nullable UAInAppMessageTextInfo *)extend: (nonnull void (^)(UAInAppMessageTextInfoBuilder *_Nonnull))builderBlock;
        [Export("extend:")]
        [return: NullAllowed]
        UAInAppMessageTextInfo Extend(Action<UAInAppMessageTextInfoBuilder> builderBlock);
    }

    // @interface UAInAppMessageTextStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInAppMessageTextStyle
    {
        // @property (readwrite, strong, nonatomic, nullable) UAPadding *additionalPadding;
        [NullAllowed, Export("additionalPadding", ArgumentSemantic.Strong)]
        UAPadding AdditionalPadding { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *letterSpacing;
        [NullAllowed, Export("letterSpacing", ArgumentSemantic.Strong)]
        NSNumber LetterSpacing { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *lineSpacing;
        [NullAllowed, Export("lineSpacing", ArgumentSemantic.Strong)]
        NSNumber LineSpacing { get; set; }

        // + (nonnull instancetype) styleWithAdditionalPadding:(nullable UAPadding *)additionalPadding letterSpacing:(nullable NSNumber *)letterSpacing lineSpacing:(nullable NSNumber *)lineSpacing;
        [Static]
        [Export("styleWithAdditionalPadding:letterSpacing:lineSpacing:")]
        UAInAppMessageTextStyle Style([NullAllowed] UAPadding additionalPadding, [NullAllowed] NSNumber letterSpacing, [NullAllowed] NSNumber lineSpacing);

        // + (nonnull instancetype)styleWithDictionary:(nullable NSDictionary *)textStyle;
        [Static]
        [Export("styleWithDictionary:")]
        UAInAppMessageTextStyle Style([NullAllowed] NSDictionary textStyle);
    }

    // @protocol UAInboxDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAInboxDelegate
    {

        // - (void)richPushMessageAvailable:(nonnull UAInboxMessage *)richPushMessage;
        [Export("richPushMessageAvailable:")]
        void RichPushMessageAvailable(UAInboxMessage richPushMessage);

        // - (void)showMessageForID:(nonnull NSString *)messageID;
        [Export("showMessageForID:")]
        void ShowMessage(string messageID);

        // - (void)showInbox;
        [Abstract]
        [Export("showInbox")]
        void ShowInbox();
    }

    interface IUAInboxDelegate { }

    // @interface UAInbox : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAInbox
    {
        // @property (readwrite, strong, nonatomic) UAInboxMessageList *_Nonnull messageList;
        [Export("messageList", ArgumentSemantic.Strong)]
        UAInboxMessageList MessageList { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAInboxDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAInboxDelegate Delegate { get; set; }

    }

    // typedef void (^UAInboxMessageCallbackBlock)(UAInboxMessage *message)
    delegate void UAInboxMessageCallbackBlock(UAInboxMessage arg0);

    // @interface UAInboxMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxMessage
    {
        // @property (readonly, nonatomic) NSString *_Nonnull messageID;
        [Export("messageID")]
        string MessageID { get; }

        // @property (readonly, nonatomic) NSURL *_Nonnull messageBodyURL;
        [Export("messageBodyURL")]
        NSUrl MessageBodyURL { get; }

        // @property (readonly, nonatomic) NSURL *_Nonnull messageURL;
        [Export("messageURL")]
        NSUrl MessageURL { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (readonly, nonatomic) BOOL unread;
        [Export("unread")]
        bool Unread { get; }

        // @property (readonly, nonatomic) BOOL deleted;
        [Export("deleted")]
        bool Deleted { get; }

        // @property (readonly, nonatomic) NSDate *_Nonnull messageSent;
        [Export("messageSent")]
        NSDate MessageSent { get; }

        // @property (readonly, nonatomic, nullable) NSDate *messageExpiration;
        [NullAllowed, Export("messageExpiration")]
        NSDate MessageExpiration { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull extra;
        [Export("extra")]
        NSDictionary Extra { get; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull rawMessageObject;
        [Export("rawMessageObject")]
        NSDictionary RawMessageObject { get; }

        // @property (readonly, nonatomic) UAInboxMessageList *_Nullable messageList;
        [NullAllowed, Export("messageList")]
        UAInboxMessageList MessageList { get; }

        // - (nullable UADisposable *)markMessageReadWithCompletionHandler: (nullable UAInboxMessageCallbackBlock)completionHandler;
        [Export("markMessageReadWithCompletionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessageRead([NullAllowed] UAInboxMessageCallbackBlock completionHandler);

        // - (BOOL)isExpired;
        [Export("isExpired")]
        bool IsExpired();
    }

    // typedef void (^UAInboxMessageListCallbackBlock)(void)
    delegate void UAInboxMessageListCallbackBlock();

    // @interface UAInboxMessageList : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxMessageList
    {
        // @property (readonly, strong, nonatomic) NSArray<UAInboxMessage *> *_Nonnull messages;
        [Export("messages", ArgumentSemantic.Strong)]
        UAInboxMessage[] Messages { get; }

        // @property (assign, readwrite, atomic) NSInteger unreadCount;
        [Export("unreadCount", ArgumentSemantic.Assign)]
        nint UnreadCount { get; set; }

        // @property (readonly, atomic) BOOL isRetrieving;
        [Export("isRetrieving")]
        bool IsRetrieving { get; }

        // @property (readonly, atomic) BOOL isBatchUpdating;
        [Export("isBatchUpdating")]
        bool IsBatchUpdating { get; }

        // - (nullable UADisposable *) retrieveMessageListWithSuccessBlock: (nullable UAInboxMessageListCallbackBlock)successBlock withFailureBlock: (nullable UAInboxMessageListCallbackBlock)failureBlock;
        [Export("retrieveMessageListWithSuccessBlock:withFailureBlock:")]
        [return: NullAllowed]
        UADisposable RetrieveMessageList([NullAllowed] UAInboxMessageListCallbackBlock successBlock, [NullAllowed] UAInboxMessageListCallbackBlock failureBlock);

        // - (nullable UADisposable *) markMessagesRead:(nonnull NSArray *)messages completionHandler:(nullable UAInboxMessageListCallbackBlock)completionHandler;
        [Export("markMessagesRead:completionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessagesRead(NSObject[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

        // - (nullable UADisposable *) markMessagesDeleted:(nonnull NSArray *)messages completionHandler:(nullable UAInboxMessageListCallbackBlock)completionHandler;
        [Export("markMessagesDeleted:completionHandler:")]
        [return: NullAllowed]
        UADisposable MarkMessagesDeleted(NSObject[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

        // - (nonnull NSArray<UAInboxMessage *> *)messagesFilteredUsingPredicate: (nonnull NSPredicate *)predicate;
        [Export("messagesFilteredUsingPredicate:")]
        UAInboxMessage[] MessagesFilteredUsingPredicate(NSPredicate predicate);

        // - (NSUInteger)messageCount;
        [Export("messageCount")]
        nuint MessageCount();

        // - (nullable UAInboxMessage *)messageForBodyURL:(nonnull NSURL *)url;
        [Export("messageForBodyURL:")]
        [return: NullAllowed]
        UAInboxMessage Message(NSUrl url);

        // - (nullable UAInboxMessage *)messageForID:(nonnull NSString *)messageID;
        [Export("messageForID:")]
        [return: NullAllowed]
        UAInboxMessage Message(string messageID);
    }

    // @interface UAInboxUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAInboxUtils
    {

        // + (nullable NSString *)inboxMessageIDFromNotification: (nonnull NSDictionary *)notification;
        [Static]
        [Export("inboxMessageIDFromNotification:")]
        [return: NullAllowed]
        string InboxMessageID(NSDictionary notification);

        // + (nullable NSString *)inboxMessageIDFromValue:(nonnull id)values;
        [Static]
        [Export("inboxMessageIDFromValue:")]
        [return: NullAllowed]
        string InboxMessageID(NSObject values);
    }

    // @protocol UALandingPageBuilderExtender <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALandingPageBuilderExtender
    {

        // - (void)extendScheduleInfoBuilder: (nonnull UAInAppMessageScheduleInfoBuilder *)builder;
        [Export("extendScheduleInfoBuilder:")]
        void ExtendScheduleInfoBuilder(UAInAppMessageScheduleInfoBuilder builder);

        // - (void)extendMessageBuilder:(nonnull UAInAppMessageBuilder *)builder;
        [Export("extendMessageBuilder:")]
        void ExtendMessageBuilder(UAInAppMessageBuilder builder);
    }

    interface IUALandingPageBuilderExtender { }

    // @interface UALandingPageAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UALandingPageAction
    {
        // @property (assign, readwrite, nonatomic, nullable) NSNumber *borderRadiusPoints;
        [NullAllowed, Export("borderRadiusPoints", ArgumentSemantic.Assign)]
        NSNumber BorderRadiusPoints { get; set; }

        // @property (readwrite, nonatomic) id<UALandingPageBuilderExtender> _Nullable builderExtender;
        [NullAllowed, Export("builderExtender")]
        UALandingPageBuilderExtender BuilderExtender { get; set; }

    }

    // @interface UALegacyInAppMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessage
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, strong, nonatomic) NSDate *_Nonnull expiry;
        [Export("expiry", ArgumentSemantic.Strong)]
        NSDate Expiry { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *extra;
        [NullAllowed, Export("extra", ArgumentSemantic.Copy)]
        NSDictionary Extra { get; set; }

        // @property (assign, readwrite, nonatomic) UALegacyInAppMessageDisplayType displayType;
        [Export("displayType", ArgumentSemantic.Assign)]
        UALegacyInAppMessageDisplayType DisplayType { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *alert;
        [NullAllowed, Export("alert")]
        string Alert { get; set; }

        // @property (assign, readwrite, nonatomic) UALegacyInAppMessagePosition position;
        [Export("position", ArgumentSemantic.Assign)]
        UALegacyInAppMessagePosition Position { get; set; }

        // @property (assign, readwrite, nonatomic) NSTimeInterval duration;
        [Export("duration", ArgumentSemantic.Assign)]
        double Duration { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UIColor *primaryColor;
        [NullAllowed, Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UIColor *secondaryColor;
        [NullAllowed, Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *buttonGroup;
        [NullAllowed, Export("buttonGroup")]
        string ButtonGroup { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *buttonActions;
        [NullAllowed, Export("buttonActions", ArgumentSemantic.Copy)]
        NSDictionary ButtonActions { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSDictionary *onClick;
        [NullAllowed, Export("onClick", ArgumentSemantic.Copy)]
        NSDictionary OnClick { get; set; }

        // @property (readonly, nonatomic, nullable) NSArray *notificationActions;
        [NullAllowed, Export("notificationActions")]
        NSObject[] NotificationActions { get; }

        // @property (readonly, nonatomic, nullable) UANotificationCategory *buttonCategory;
        [NullAllowed, Export("buttonCategory")]
        UANotificationCategory ButtonCategory { get; }

        // + (nullable instancetype)messageWithPayload:(nonnull NSDictionary *)payload;
        [Static]
        [Export("messageWithPayload:")]
        [return: NullAllowed]
        UALegacyInAppMessage Message(NSDictionary payload);

        // - (BOOL)isEqualToMessage:(nullable UALegacyInAppMessage *)message;
        [Export("isEqualToMessage:")]
        bool IsEqualToMessage([NullAllowed] UALegacyInAppMessage message);
    }

    // @protocol UALegacyInAppMessageFactoryDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessageFactoryDelegate
    {

        // - (nonnull UAInAppMessageScheduleInfo *)scheduleInfoForMessage: (nonnull UALegacyInAppMessage *)message;
        [Abstract]
        [Export("scheduleInfoForMessage:")]
        UAInAppMessageScheduleInfo ScheduleInfo(UALegacyInAppMessage message);
    }

    interface IUALegacyInAppMessageFactoryDelegate { }

    // @protocol UALegacyInAppMessageBuilderExtender <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessageBuilderExtender
    {

        // - (void)extendScheduleInfoBuilder: (nonnull UAInAppMessageScheduleInfoBuilder *)builder message:(nonnull UALegacyInAppMessage *)message;
        [Export("extendScheduleInfoBuilder:message:")]
        void ExtendScheduleInfoBuilder(UAInAppMessageScheduleInfoBuilder builder, UALegacyInAppMessage message);

        // - (void)extendMessageBuilder:(nonnull UAInAppMessageBuilder *)builder message:(nonnull UALegacyInAppMessage *)message;
        [Export("extendMessageBuilder:message:")]
        void ExtendMessageBuilder(UAInAppMessageBuilder builder, UALegacyInAppMessage message);
    }

    interface IUALegacyInAppMessageBuilderExtender { }

    // @interface UALegacyInAppMessaging : NSObject <UALegacyInAppMessageFactoryDelegate>
    [BaseType(typeof(NSObject))]
    interface UALegacyInAppMessaging : IUALegacyInAppMessageFactoryDelegate
    {
        // @property (assign, readwrite, nonatomic) BOOL displayASAPEnabled;
        [Export("displayASAPEnabled")]
        bool DisplayASAPEnabled { get; set; }

        // @property (readwrite, nonatomic) id<UALegacyInAppMessageFactoryDelegate> _Nullable factoryDelegate;
        [NullAllowed, Export("factoryDelegate", ArgumentSemantic.Assign)]
        NSObject WeakFactoryDelegate { get; set; }

        [Wrap("WeakFactoryDelegate")]
        [NullAllowed]
        IUALegacyInAppMessageFactoryDelegate FactoryDelegate { get; set; }

        // @property(nonatomic, weak) id<UALegacyInAppMessageBuilderExtender> builderExtender
        [NullAllowed, Export("builderExtender")]
        UALegacyInAppMessageBuilderExtender BuilderExtender { get; set; }

    }

    // @interface UAMessageCenter : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenter
    {
        // @property (readwrite, strong, nonatomic) NSString *title;
        [Export("title")]
        string Title { get; set; }

        // @property (readwrite, strong, nonatomic) UAMessageCenterStyle *style;
        [Export("style", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (readwrite, strong, nonatomic) NSPredicate *filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL disableMessageLinkPreviewAndCallouts;
        [Export("disableMessageLinkPreviewAndCallouts")]
        bool DisableMessageLinkPreviewAndCallouts { get; set; }

        // + (instancetype)messageCenterWithConfig:(UARuntimeConfig *)config;
        [Static]
        [Export("messageCenterWithConfig:")]
        UAMessageCenter MessageCenter(UARuntimeConfig config);

        // - (void)display:(BOOL)animated;
        [Export("display:")]
        void Display(bool animated);

        // - (void)display;
        [Export("display")]
        void Display();

        // - (void)displayMessageForID:(NSString *)messageID animated:(BOOL)animated;
        [Export("displayMessageForID:animated:")]
        void DisplayMessage(string messageID, bool animated);

        // - (void)displayMessageForID:(NSString *)messageID;
        [Export("displayMessageForID:")]
        void DisplayMessage(string messageID);

        // - (void)dismiss:(BOOL)animated;
        [Export("dismiss:")]
        void Dismiss(bool animated);

        // - (void)dismiss;
        [Export("dismiss")]
        void Dismiss();
    }

    // @interface UAMessageCenterDateUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterDateUtils
    {

        // + (NSString *)formattedDateRelativeToNow:(NSDate *)date;
        [Static]
        [Export("formattedDateRelativeToNow:")]
        string FormattedDateRelativeToNow(NSDate date);
    }

    // @interface UAMessageCenterListCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    interface UAMessageCenterListCell
    {
        // @property (readwrite, strong, nonatomic) UAMessageCenterStyle *style;
        [Export("style", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (readwrite, nonatomic) UILabel *date;
        [Export("date")]
        UILabel Date { get; set; }

        // @property (readwrite, nonatomic) UILabel *title;
        [Export("title")]
        UILabel Title { get; set; }

        // @property (readwrite, nonatomic) UIView *unreadIndicator;
        [Export("unreadIndicator")]
        UIView UnreadIndicator { get; set; }

        // @property (readwrite, nonatomic) UIImageView *listIconView;
        [Export("listIconView")]
        UIImageView ListIconView { get; set; }

        // - (void)setData:(UAInboxMessage *)message;
        [Export("setData:")]
        void SetData(UAInboxMessage message);
    }

    // @interface UAMessageCenterListViewController : UIViewController <UITableViewDelegate, UITableViewDataSource, UIScrollViewDelegate, UISplitViewControllerDelegate>
    [BaseType(typeof(UIViewController))]
    interface UAMessageCenterListViewController : IUITableViewDelegate, IUITableViewDataSource, IUIScrollViewDelegate, IUISplitViewControllerDelegate
    {
        // @property (readwrite, strong, nonatomic) UAMessageCenterStyle *style;
        [Export("style", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (readwrite, strong, nonatomic) NSPredicate *filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (readwrite, strong, nonatomic) UIViewController<UAMessageCenterMessageViewProtocol> *messageViewController;
        [Export("messageViewController", ArgumentSemantic.Strong)]
        UAMessageCenterMessageViewProtocol MessageViewController { get; set; }

        // @property (readwrite, copy, nonatomic) void (^)(BOOL) closeBlock;
        [Export("closeBlock", ArgumentSemantic.Copy)]
        Action CloseBlock { get; set; }

        // - (void)displayMessageForID:(NSString *)messageID;
        [Export("displayMessageForID:")]
        void DisplayMessage(string messageID);

        // - (void)displayMessageForID:(NSString *)messageID onError:(void (^)(void))completion;
        [Export("displayMessageForID:onError:")]
        void DisplayMessage(string messageID, Action completion);

        // - (instancetype)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil splitViewController:(UISplitViewController *)splitViewController;
        [Export("initWithNibName:bundle:splitViewController:")]
        IntPtr Constructor(string nibNameOrNil, NSBundle nibBundleOrNil, UISplitViewController splitViewController);
    }

    // @interface UAMessageCenterMessageViewController : UIViewController <UAWKWebViewDelegate, UAMessageCenterMessageViewProtocol>
    [BaseType(typeof(UIViewController))]
    interface UAMessageCenterMessageViewController : IUAWKWebViewDelegate, IUAMessageCenterMessageViewProtocol
    {

    }

    // @protocol UAMessageCenterMessageViewProtocol
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterMessageViewProtocol
    {
        // @property (readonly, strong, nonatomic) UAInboxMessage *_Nonnull message;
        [Export("message", ArgumentSemantic.Strong)]
        UAInboxMessage Message { get; }

        // @property (readwrite, copy, nonatomic) void (^_Nonnull)(BOOL) closeBlock;
        [Export("closeBlock", ArgumentSemantic.Copy)]
        Action CloseBlock { get; set; }

        // - (void)loadMessageForID:(nullable NSString *)messageID onlyIfChanged:(BOOL)onlyIfChanged onError:(nullable void (^)(void))errorCompletion;
        [Abstract]
        [Export("loadMessageForID:onlyIfChanged:onError:")]
        void LoadMessage([NullAllowed] string messageID, bool onlyIfChanged, [NullAllowed] Action errorCompletion);

        // - (void)setLoadingIndicatorView:(nonnull UIView *)loadingIndicatorView animations:(nonnull void (^)(void))animations;
        [Export("setLoadingIndicatorView:animations:")]
        void SetLoadingIndicatorView(UIView loadingIndicatorView, Action animations);
    }

    interface IUAMessageCenterMessageViewProtocol { }

    // @interface UAMessageCenterSplitViewController : UISplitViewController
    [BaseType(typeof(UISplitViewController))]
    interface UAMessageCenterSplitViewController
    {
        // @property (readwrite, strong, nonatomic) NSPredicate *filter;
        [Export("filter", ArgumentSemantic.Strong)]
        NSPredicate Filter { get; set; }

        // @property (readwrite, strong, nonatomic) UAMessageCenterStyle *style;
        [Export("style", ArgumentSemantic.Strong)]
        UAMessageCenterStyle Style { get; set; }

        // @property (readonly, nonatomic) UAMessageCenterListViewController *listViewController;
        [Export("listViewController")]
        UAMessageCenterListViewController ListViewController { get; }

    }

    // @interface UAMessageCenterStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMessageCenterStyle
    {
        // @property (readwrite, strong, nonatomic) UIFont *titleFont;
        [Export("titleFont", ArgumentSemantic.Strong)]
        UIFont TitleFont { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *titleColor;
        [Export("titleColor", ArgumentSemantic.Strong)]
        UIColor TitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *navigationBarColor;
        [Export("navigationBarColor", ArgumentSemantic.Strong)]
        UIColor NavigationBarColor { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL navigationBarOpaque;
        [Export("navigationBarOpaque")]
        bool NavigationBarOpaque { get; set; }

        // @property (assign, readwrite, nonatomic) UANavigationBarStyle navigationBarStyle;
        [Export("navigationBarStyle", ArgumentSemantic.Assign)]
        UANavigationBarStyle NavigationBarStyle { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *listColor;
        [Export("listColor", ArgumentSemantic.Strong)]
        UIColor ListColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *refreshTintColor;
        [Export("refreshTintColor", ArgumentSemantic.Strong)]
        UIColor RefreshTintColor { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL iconsEnabled;
        [Export("iconsEnabled")]
        bool IconsEnabled { get; set; }

        // @property (readwrite, strong, nonatomic) UIImage *placeholderIcon;
        [Export("placeholderIcon", ArgumentSemantic.Strong)]
        UIImage PlaceholderIcon { get; set; }

        // @property (readwrite, strong, nonatomic) UIFont *cellTitleFont;
        [Export("cellTitleFont", ArgumentSemantic.Strong)]
        UIFont CellTitleFont { get; set; }

        // @property (readwrite, strong, nonatomic) UIFont *cellDateFont;
        [Export("cellDateFont", ArgumentSemantic.Strong)]
        UIFont CellDateFont { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellColor;
        [Export("cellColor", ArgumentSemantic.Strong)]
        UIColor CellColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellHighlightedColor;
        [Export("cellHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellHighlightedColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellTitleColor;
        [Export("cellTitleColor", ArgumentSemantic.Strong)]
        UIColor CellTitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellTitleHighlightedColor;
        [Export("cellTitleHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellTitleHighlightedColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellDateColor;
        [Export("cellDateColor", ArgumentSemantic.Strong)]
        UIColor CellDateColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellDateHighlightedColor;
        [Export("cellDateHighlightedColor", ArgumentSemantic.Strong)]
        UIColor CellDateHighlightedColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellSeparatorColor;
        [Export("cellSeparatorColor", ArgumentSemantic.Strong)]
        UIColor CellSeparatorColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cellTintColor;
        [Export("cellTintColor", ArgumentSemantic.Strong)]
        UIColor CellTintColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *unreadIndicatorColor;
        [Export("unreadIndicatorColor", ArgumentSemantic.Strong)]
        UIColor UnreadIndicatorColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *selectAllButtonTitleColor;
        [Export("selectAllButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor SelectAllButtonTitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *deleteButtonTitleColor;
        [Export("deleteButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor DeleteButtonTitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *markAsReadButtonTitleColor;
        [Export("markAsReadButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor MarkAsReadButtonTitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *editButtonTitleColor;
        [Export("editButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor EditButtonTitleColor { get; set; }

        // @property (readwrite, strong, nonatomic) UIColor *cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonTitleColor { get; set; }

        // + (instancetype)styleWithContentsOfFile:(NSString *)path;
        [Static]
        [Export("styleWithContentsOfFile:")]
        UAMessageCenterStyle Style(string path);
    }

    // @interface UAOverlayInboxMessageAction : UALandingPageAction
    [BaseType(typeof(UALandingPageAction))]
    interface UAOverlayInboxMessageAction
    {

    }

    // @interface UAPasteboardAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAPasteboardAction
    {

    }

    // @interface UARateAppAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UARateAppAction
    {

        // - (NSArray *)rateAppLinkPromptTimestamps;
        [Export("rateAppLinkPromptTimestamps")]
        NSObject[] RateAppLinkPromptTimestamps();

        // - (NSArray *)rateAppPromptTimestamps;
        [Export("rateAppPromptTimestamps")]
        NSObject[] RateAppPromptTimestamps();
    }

    // @interface UAShareAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAShareAction
    {

    }

    // @protocol UAWKWebViewDelegate <WKNavigationDelegate>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAWKWebViewDelegate : IWKNavigationDelegate
    {

        // - (void)closeWindowAnimated:(BOOL)animated;
        [Export("closeWindowAnimated:")]
        void CloseWindowAnimated(bool animated);
    }

    interface IUAWKWebViewDelegate { }

    // @interface UAWKWebViewNativeBridge : UABaseNativeBridge <UAWKWebViewDelegate>
    [BaseType(typeof(UABaseNativeBridge))]
    interface UAWKWebViewNativeBridge : IUAWKWebViewDelegate
    {
        // @property (readwrite, nonatomic, nullable) id<UAWKWebViewDelegate> forwardDelegate;
        [NullAllowed, Export("forwardDelegate", ArgumentSemantic.Assign)]
        NSObject WeakForwardDelegate { get; set; }

        [Wrap("WeakForwardDelegate")]
        [NullAllowed]
        IUAWKWebViewDelegate ForwardDelegate { get; set; }

    }

    // @interface UAWalletAction : UAOpenExternalURLAction
    [BaseType(typeof(UAOpenExternalURLAction))]
    interface UAWalletAction
    {

    }

    // @interface UAWebViewCallData : NSObject
    [BaseType(typeof(NSObject))]
    interface UAWebViewCallData
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSArray<NSString *> *arguments;
        [NullAllowed, Export("arguments", ArgumentSemantic.Strong)]
        string[] Arguments { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSDictionary *options;
        [NullAllowed, Export("options", ArgumentSemantic.Strong)]
        NSDictionary Options { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAWKWebViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAWKWebViewDelegate Delegate { get; set; }

        // @property (readwrite, strong, nonatomic) NSURL *_Nonnull url;
        [Export("url", ArgumentSemantic.Strong)]
        NSUrl Url { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UAInboxMessage *message;
        [NullAllowed, Export("message", ArgumentSemantic.Strong)]
        UAInboxMessage Message { get; set; }

        // + (nonnull UAWebViewCallData *)callDataForURL:(nonnull NSURL *)url delegate:(nonnull id<UAWKWebViewDelegate>) delegate;
        [Static]
        [Export("callDataForURL:delegate:")]
        UAWebViewCallData CallData(NSUrl url, UAWKWebViewDelegate @delegate);

        // + (nonnull UAWebViewCallData *) callDataForURL:(nonnull NSURL *)url delegate:(nonnull id<UAWKWebViewDelegate>)delegate message:(nullable UAInboxMessage *)message;
        [Static]
        [Export("callDataForURL:delegate:message:")]
        UAWebViewCallData CallData(NSUrl url, UAWKWebViewDelegate @delegate, [NullAllowed] UAInboxMessage message);
    }


}
