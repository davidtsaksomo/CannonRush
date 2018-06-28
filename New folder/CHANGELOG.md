Unity Change Log
================

Version 5.1.1 *(2015-01-16)*
----------------------------
>- *Android: Version 5.1.0*
>- *iOS: Version 5.1.3*

Features:

Fixes:
- Disabled request retries by default, fix for multithreaded crashes 
- Fix for when the device is in an orientation we do not have assets for. Instead of failing silently a CBLoadError is now called.  

Improvements:

- Better inplay caching  
- Added orientation information to api-click, and video-complete calls. Allows for better analytics 
- Remove hardcoded affiliate token. Now pulled from the server 
- Added example usage of isAnyViewVisible: delegate method into the sample project 
- Added inplay button to the chartboost example app 
- Improved logging for when someone tries to show a rewarded video with prefetching disabled. Instead of failing silently a CBLoadError is called. 


Version 5.1.0 *(2014-12-09)*
----------------------------
>- *Android: Version 5.1.0*
>- *iOS: Version 5.1.2*

Features:

Fixes:
- Fix race condition between actions for video on replay. 
- Fix loading screen causing issues with video and app sheet. 
- Fix interstitial video close button appearing at incorrect time in portrait orientation. 
- Fix rewarded video autoplays when previous display of video is dismissed instead of watched. 
- Fix api/config not executing on soft bootups. 
- Fix close button clipping the video player in corner. 
- Fix api/install not being sent for soft bootups. 
- Fix for various crashes due to memory pressure and concurrency. 
- Fix for api/track executing on hidden files for older devices. 
- Fix for rotating iPhone 6/6+ can cause video to display off screen. 
- Fix for incorrect error code enumerations being used. 
- Fix loading view not appearing for more apps page on slow connections. 
- Fix crash in CBAnalytics if sent an invalid NSDecimalNumber. 
- Fix age gate with More Apps so that it is not behind the More Apps view. 
- Fix SKStoreProductViewController rotation issue with Unity. 
- Fix build for armv7s architectures. 
- Fix CBAppCall crash if no resource path sent with URL. 
- Fix bug with SKStoreProductViewController crashing due to race condition. 
- Fix SKStoreProductViewController rotation issue with Unity. 
- Fix concurrency issue in CBConfig. 
- Fix Android SDK 5.0.3 crashing on Video Interstitial due to NullPointerException. 
- Fix Android SDK: Proper error enum names. 
- Fix MoreApps Unity 5.0.2 and 5.0 for Android doesn't work. 
- Fix Unity: Parity Android error enum. 
- Fix SDK sends "custom-id" but ad server expects "custom_id" field. 
- Fix See black screen and not video when reward/get has been modified. 
- Fix Android Video: Black screen for invalid response. 
- Fix Rewarded Video request freezes app if pre-roll popup gets closed after watching at least one video. 

Improvements:

- Added new framework tracking values for Cordova and CocoonJS. 
- Added new API to check visibility of Chartboost UI. 
- Changed delegate callbacks for click and close to be sent after closing or clicking the impression. 
- Changed autocache calls to delay execution for better performance. 

Version 5.0.3 *(2014-09-22)*
----------------------------

- Bugfixes and stability improvements.

Version 5.0.2 *(2014-09-12)*
----------------------------

- Higher eCPM for Android.
- Bugfixes and stability improvements.

Version 5.0.1 *(2014-09-09)*
----------------------------

- Compatibility with various third party packages.
- Post processing will remove legacy Chartboost files.
- Bugfixes and stability improvements.

Version 5.0 *(2014-08-07)*
----------------------------

- Rewrote the whole SDK to organize the code in a much better way
- Android and iOS parity has been achieved
- The SDK has become much much easier to use, one can simply import a prefab in their scene and they are done
- Added features like InPlay and Video
- The delegates work properly now, they return the value we expect them to return by asking the game instead of default values

Version 4.1.0 *(2014-05-15)*
----------------------------

 - iOS: Updated to iOS library version 4.4
 - iOS: Added rewarded video impressions
 - iOS: Added age gate feature
 - iOS: Added control over first session interstitials and a few other small features from native SDK
 - Added named locations for impressions, see CBLocation
 
Version 4.0.1 *(2014-04-22)*
----------------------------

 - Android: Fix for a crash due to Google Play Services security permission check

Version 4.0.0 *(2014-04-17)*
----------------------------
 
 - Updated Android SDK to 4.0.0 (Compatible with Android versions 2.3+)
 - Updated iOS SDK to 4.1 (Compatible with iOS versions 5.1+)
 - Added CBImpressionError parameters to "didFailToLoad" EventListener methods
 - Simplified plugin in Android, does not override main activity -- this should eliminate conflicts with other plugins
 - Initialize the Android plugin almost entirely in code -- use the setup dialog from the file menu and call `CBBinding.init(appID, appSignature)`
 - Android: Removed option to use activities for Chartboost Impressions
 - iOS: Removed unused iOS methods

Version 3.4.0 *(2014-02-25)*
----------------------------

 - Updated Android SDK to 3.4.0
 
Version 3.3.0 *(2013-09-12)*
----------------------------

 - Merged iOS and Android plugins - now just one almost identical API intelligently works on both platforms
 - Repackaged all Chartboost C
 - Android: Renamed `ChartBoostAndroid` to `CBBinding` and `ChartBoostAndroidManager` to `CBManager`
 - Android: Fixed issues related to touch input passing through Chartboost impressions
 - Android: Added ability to customize pause behavior while Chartboost impressions are visible
 - iOS: Renamed `ChartBoostBinding` to `CBBinding` and `ChartBoostManager` to `CBManager`
 - iOS: Updated plugin to avoid possible Xcode build error with Unity 4.2
 - Unity meta files added to allow test scene to find scripts on import
