### Upgrading to Chartboost SDK 5.0 for Unity

This document will guide how to update existing projects with legacy Chartboost SDKs to the 5.0+ versions. If you're looking for a basic guide to integration from scratch, please see the README.md file or the Chartboost Help Site (https://answers.chartboost.com/hc/en-us/articles/200780379).


#### Requirements

Please note that Chartboost supports Android 2.3+ and iOS 5.1.1+, so make sure to set the minimum OS versions of your Unity project accordingly.


#### Key differences

1. Initialization is handled by the SDK
 - To simplify the integration and decrease possible issues post launch

2. Chartboost Menu item
 - Easier setup and control of AppID/AppSignature pairs

3. `namespace Chartboost` renamed to `namespace ChartboostSDK`
 - In C#, it is not recommended to have the same name for the namespace as well as for a class (class `Chartboost` provides the public API functions)

4. `null` / `()` no longer accepted as a location - you can pass in `CBLocation.Default` instead
 - Though we still have a default location, we encourage the use of more descriptive location names via the CBLocation class in order to provide more meaningful analytics

5. All locations are now passed in via the CBLocation class
 - The CBLocation class has several common location preset values available for use
 - Custom location strings are now passed in via the CBLocation class' locationFromName(string) method

6. MoreApps calls now use locations `public static void showMoreApps(CBLocation location)`
 - More granular control over MoreApps (has existed in native SDKs)

7. Chartboost SDK event names and method signatures have been significantly updated and improved
 - Brings API and functionality more in parity with Native SDKs
 - For more about the event functionality available, both old and new, please see the README.md file or the Chartboost Help Site (https://answers.chartboost.com/hc/en-us/articles/200780379)

#### Upgrading to 5.0+

 1. Delete old plugin folders

  ```
  *\Plugins\Android //Android SDK files
  *\Plugins\iOS //iOS SDK files
  *\Plugins\Chartboost //Sample project
  ```
 2. Import the new SDK package
  * Assets > Import Package > Custom Package
  * Navigate to the .unitypackage file you downloaded from Chartboost and use that
  * Select Import to complete the action (by default all package assets are marked for import)
 3. Drag and drop the Chartboost prefab to your game scene from `/Assets/Chartboost/Chartboost`
 4. Select menu item `Chartboost > Edit Settings`
  * Press the `Setup Android SDK` button in ChartboostSettings in the Inspector window
  * Edit the AppID & AppSignature settings with your current values for each platform
 5. Rename all `using Chartboost;` lines to `using ChartboostSDK;`
 6. Rename all `CBManager.CBImpressionError` references to `CBImpressionError`
 7. Remove the following chartboost init code in `OnEnable()`

  ```
  void OnEnable() {
        // Initialize the Chartboost plugin
  #if UNITY_ANDROID
        // Replace these with your own Android app ID and signature from the Chartboost web portal
        CBBinding.init("CB_APP_ID_ANDROID", "CB_APP_SIG_ANDROID");
  #elif UNITY_IPHONE
        // Replace these with your own iOS app ID and signature from the Chartboost web portal
        CBBinding.init("CB_APP_ID_IOS", "CB_APP_SIG_IOS");
  #endif
  }
  ```
 8. Remove any Android-specific Chartboost lifecycle code (Back button handling, pause, destroy, etc.) as found in the following Unity functions

  ```
  #if UNITY_ANDROID
  public void Update() {
        if (Input.GetKeyUp(KeyCode.Escape)) {
                if (CBBinding.onBackPressed())
                        return;
                else
                        Application.Quit();
        }
  }
  
  void OnApplicationPause(bool paused) {
        // Manage Chartboost plugin lifecycle
        CBBinding.pause(paused);
  }

  void OnDisable() {
        // Shut down the Chartboost plugin
        CBBinding.destroy();
  }
  #endif
  ```
       
 9. Edit old Chartboost calls from `CBBinding.showInterstitial(YOURLOCATIONHERE);` to `Chartboost.showInterstitial(YOURLOCATIONHERE);`
  * `CBBinding` renamed to `Chartboost`
  * For all `null` and `()` empty locations use `CBLocation.Default` instead
  * Consider using one of CBLocation's many preset values, for example `CBLocation.Startup`, `CBLocation.LevelComplete`, or `CBLocation.MainMenu`
  * If still using custom location strings, pass them in via CBLocation: `CBBinding.showInterstitial("customLocation");` becomes `Chartboost.showInterstitial(CBLocation.locationFromName("customLocation"));`
 10. If you're listening to Chartboost events, these use `Chartboost` instead of `CBManager` and no longer have "Event" at the end of their names:
  * For example, `CBManager.didDismissInterstitialEvent += didDismissInterstitialEvent;` becomes `Chartboost.didDismissInterstitial += didDismissInterstitial;`
 11. If you're listening to Chartboost events, two events received more significant name changes that you'll need to update with:
  * `didShowInterstitialEvent` should be replaced with `didDisplayInterstitial`
  * `didShowMoreAppsEvent` should be replaced with `didDisplayMoreApps`
 12. If you're listening to Chartboost events, More Apps related methods now take in an additional `string location` parameter, which affects:
  * `didFailToLoadMoreApps`
  * `didDismissMoreApps`
  * `didCloseMoreApps`
  * `didClickMoreApps`
  * `didCacheMoreApps`
  * For example, `void didFailToLoadMoreAppsEvent(CBManager.CBImpressionError error)` should be replaced with `void didFailToLoadMoreApps(string location, CBImpressionError error)`
