using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public const string LibraryName = "SDL3";

    public const uint AudioMaskBitsize = (0xFFU);
    public const uint AudioMaskFloat = (1U << 8);
    public const uint AudioMaskBigEndian = (1U << 12);
    public const uint AudioMaskSigned = (1U << 15);
    public const uint AudioDeviceDefaultPlayback = ((uint)(0xFFFFFFFFU));
    public const uint AudioDeviceDefaultRecording = ((uint)(0xFFFFFFFEU));
    public const string PropAudiostreamAutoCleanupBoolean = "SDL.audiostream.auto_cleanup";
    public const uint BlendmodeNone = 0x00000000U;
    public const uint BlendmodeBlend = 0x00000001U;
    public const uint BlendmodeBlendPremultiplied = 0x00000010U;
    public const uint BlendmodeAdd = 0x00000002U;
    public const uint BlendmodeAddPremultiplied = 0x00000020U;
    public const uint BlendmodeMod = 0x00000004U;
    public const uint BlendmodeMul = 0x00000008U;
    public const uint BlendmodeInvalid = 0x7FFFFFFFU;
    public const int CachelineSize = 128;
    public const string PropFileDialogFiltersPointer = "SDL.filedialog.filters";
    public const string PropFileDialogNfiltersNumber = "SDL.filedialog.nfilters";
    public const string PropFileDialogWindowPointer = "SDL.filedialog.window";
    public const string PropFileDialogLocationString = "SDL.filedialog.location";
    public const string PropFileDialogManyBoolean = "SDL.filedialog.many";
    public const string PropFileDialogTitleString = "SDL.filedialog.title";
    public const string PropFileDialogAcceptString = "SDL.filedialog.accept";
    public const string PropFileDialogCancelString = "SDL.filedialog.cancel";
    public const uint GlobCaseinsensitive = (1U << 0);
    public const string PropGamepadCapMonoLedBoolean = "SDL.joystick.cap.mono_led";
    public const string PropGamepadCapRgbLedBoolean = "SDL.joystick.cap.rgb_led";
    public const string PropGamepadCapPlayerLedBoolean = "SDL.joystick.cap.player_led";
    public const string PropGamepadCapRumbleBoolean = "SDL.joystick.cap.rumble";
    public const string PropGamepadCapTriggerRumbleBoolean = "SDL.joystick.cap.trigger_rumble";
    public const uint GpuColorcomponentR = (1U << 0);
    public const uint GpuColorcomponentG = (1U << 1);
    public const uint GpuColorcomponentB = (1U << 2);
    public const uint GpuColorcomponentA = (1U << 3);
    public const string PropGpuDeviceCreateDebugmodeBoolean = "SDL.gpu.device.create.debugmode";
    public const string PropGpuDeviceCreatePreferlowpowerBoolean = "SDL.gpu.device.create.preferlowpower";
    public const string PropGpuDeviceCreateVerboseBoolean = "SDL.gpu.device.create.verbose";
    public const string PropGpuDeviceCreateNameString = "SDL.gpu.device.create.name";
    public const string PropGpuDeviceCreateFeatureClipDistanceBoolean = "SDL.gpu.device.create.feature.clip_distance";
    public const string PropGpuDeviceCreateFeatureDepthClampingBoolean = "SDL.gpu.device.create.feature.depth_clamping";
    public const string PropGpuDeviceCreateFeatureIndirectDrawFirstInstanceBoolean = "SDL.gpu.device.create.feature.indirect_draw_first_instance";
    public const string PropGpuDeviceCreateFeatureAnisotropyBoolean = "SDL.gpu.device.create.feature.anisotropy";
    public const string PropGpuDeviceCreateShadersPrivateBoolean = "SDL.gpu.device.create.shaders.private";
    public const string PropGpuDeviceCreateShadersSpirvBoolean = "SDL.gpu.device.create.shaders.spirv";
    public const string PropGpuDeviceCreateShadersDxbcBoolean = "SDL.gpu.device.create.shaders.dxbc";
    public const string PropGpuDeviceCreateShadersDxilBoolean = "SDL.gpu.device.create.shaders.dxil";
    public const string PropGpuDeviceCreateShadersMslBoolean = "SDL.gpu.device.create.shaders.msl";
    public const string PropGpuDeviceCreateShadersMetallibBoolean = "SDL.gpu.device.create.shaders.metallib";
    public const string PropGpuDeviceCreateD3d12AllowFewerResourceSlotsBoolean = "SDL.gpu.device.create.d3d12.allowtier1resourcebinding";
    public const string PropGpuDeviceCreateD3d12SemanticNameString = "SDL.gpu.device.create.d3d12.semantic";
    public const string PropGpuDeviceCreateD3d12AgilitySdkVersionNumber = "SDL.gpu.device.create.d3d12.agility_sdk_version";
    public const string PropGpuDeviceCreateD3d12AgilitySdkPathString = "SDL.gpu.device.create.d3d12.agility_sdk_path";
    public const string PropGpuDeviceCreateVulkanRequireHardwareAccelerationBoolean = "SDL.gpu.device.create.vulkan.requirehardwareacceleration";
    public const string PropGpuDeviceCreateVulkanOptionsPointer = "SDL.gpu.device.create.vulkan.options";
    public const string PropGpuDeviceCreateMetalAllowMacfamily1Boolean = "SDL.gpu.device.create.metal.allowmacfamily1";
    public const string PropGpuDeviceNameString = "SDL.gpu.device.name";
    public const string PropGpuDeviceDriverNameString = "SDL.gpu.device.driver_name";
    public const string PropGpuDeviceDriverVersionString = "SDL.gpu.device.driver_version";
    public const string PropGpuDeviceDriverInfoString = "SDL.gpu.device.driver_info";
    public const string PropGpuComputepipelineCreateNameString = "SDL.gpu.computepipeline.create.name";
    public const string PropGpuGraphicspipelineCreateNameString = "SDL.gpu.graphicspipeline.create.name";
    public const string PropGpuSamplerCreateNameString = "SDL.gpu.sampler.create.name";
    public const string PropGpuShaderCreateNameString = "SDL.gpu.shader.create.name";
    public const string PropGpuTextureCreateD3d12ClearRFloat = "SDL.gpu.texture.create.d3d12.clear.r";
    public const string PropGpuTextureCreateD3d12ClearGFloat = "SDL.gpu.texture.create.d3d12.clear.g";
    public const string PropGpuTextureCreateD3d12ClearBFloat = "SDL.gpu.texture.create.d3d12.clear.b";
    public const string PropGpuTextureCreateD3d12ClearAFloat = "SDL.gpu.texture.create.d3d12.clear.a";
    public const string PropGpuTextureCreateD3d12ClearDepthFloat = "SDL.gpu.texture.create.d3d12.clear.depth";
    public const string PropGpuTextureCreateD3d12ClearStencilNumber = "SDL.gpu.texture.create.d3d12.clear.stencil";
    public const string PropGpuTextureCreateNameString = "SDL.gpu.texture.create.name";
    public const string PropGpuBufferCreateNameString = "SDL.gpu.buffer.create.name";
    public const string PropGpuTransferbufferCreateNameString = "SDL.gpu.transferbuffer.create.name";
    public const uint HapticInfinity = 4294967295U;
    // todo public const uint HapticConstant = (1U << 0);
    public const uint HapticSine = (1U << 1);
    public const uint HapticSquare = (1U << 2);
    public const uint HapticTriangle = (1U << 3);
    public const uint HapticSawtoothup = (1U << 4);
    public const uint HapticSawtoothdown = (1U << 5);
    // todo public const uint HapticRamp = (1U << 6);
    public const uint HapticSpring = (1U << 7);
    public const uint HapticDamper = (1U << 8);
    public const uint HapticInertia = (1U << 9);
    public const uint HapticFriction = (1U << 10);
    public const uint HapticLeftright = (1U << 11);
    public const uint HapticReserved1 = (1U << 12);
    public const uint HapticReserved2 = (1U << 13);
    public const uint HapticReserved3 = (1U << 14);
    // todo public const uint HapticCustom = (1U << 15);
    public const uint HapticGain = (1U << 16);
    public const uint HapticAutocenter = (1U << 17);
    public const uint HapticStatus = (1U << 18);
    public const uint HapticPause = (1U << 19);
    public const int HapticPolar = 0;
    public const int HapticCartesian = 1;
    public const int HapticSpherical = 2;
    public const int HapticSteeringAxis = 3;
    public const string PropHidapiLibusbDeviceHandlePointer = "SDL.hidapi.libusb.device.handle";
    public const string HintAllowAltTabWhileGrabbed = "SDL_ALLOW_ALT_TAB_WHILE_GRABBED";
    public const string HintAndroidAllowRecreateActivity = "SDL_ANDROID_ALLOW_RECREATE_ACTIVITY";
    public const string HintAndroidBlockOnPause = "SDL_ANDROID_BLOCK_ON_PAUSE";
    public const string HintAndroidLowLatencyAudio = "SDL_ANDROID_LOW_LATENCY_AUDIO";
    public const string HintAndroidTrapBackButton = "SDL_ANDROID_TRAP_BACK_BUTTON";
    public const string HintAppId = "SDL_APP_ID";
    public const string HintAppName = "SDL_APP_NAME";
    public const string HintAppleTvControllerUiEvents = "SDL_APPLE_TV_CONTROLLER_UI_EVENTS";
    public const string HintAppleTvRemoteAllowRotation = "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";
    public const string HintAudioAlsaDefaultDevice = "SDL_AUDIO_ALSA_DEFAULT_DEVICE";
    public const string HintAudioAlsaDefaultPlaybackDevice = "SDL_AUDIO_ALSA_DEFAULT_PLAYBACK_DEVICE";
    public const string HintAudioAlsaDefaultRecordingDevice = "SDL_AUDIO_ALSA_DEFAULT_RECORDING_DEVICE";
    public const string HintAudioCategory = "SDL_AUDIO_CATEGORY";
    public const string HintAudioChannels = "SDL_AUDIO_CHANNELS";
    public const string HintAudioDeviceAppIconName = "SDL_AUDIO_DEVICE_APP_ICON_NAME";
    public const string HintAudioDeviceSampleFrames = "SDL_AUDIO_DEVICE_SAMPLE_FRAMES";
    public const string HintAudioDeviceStreamName = "SDL_AUDIO_DEVICE_STREAM_NAME";
    public const string HintAudioDeviceStreamRole = "SDL_AUDIO_DEVICE_STREAM_ROLE";
    public const string HintAudioDeviceRawStream = "SDL_AUDIO_DEVICE_RAW_STREAM";
    public const string HintAudioDiskInputFile = "SDL_AUDIO_DISK_INPUT_FILE";
    public const string HintAudioDiskOutputFile = "SDL_AUDIO_DISK_OUTPUT_FILE";
    public const string HintAudioDiskTimescale = "SDL_AUDIO_DISK_TIMESCALE";
    public const string HintAudioDriver = "SDL_AUDIO_DRIVER";
    public const string HintAudioDummyTimescale = "SDL_AUDIO_DUMMY_TIMESCALE";
    public const string HintAudioFormat = "SDL_AUDIO_FORMAT";
    public const string HintAudioFrequency = "SDL_AUDIO_FREQUENCY";
    public const string HintAudioIncludeMonitors = "SDL_AUDIO_INCLUDE_MONITORS";
    public const string HintAutoUpdateJoysticks = "SDL_AUTO_UPDATE_JOYSTICKS";
    public const string HintAutoUpdateSensors = "SDL_AUTO_UPDATE_SENSORS";
    public const string HintBmpSaveLegacyFormat = "SDL_BMP_SAVE_LEGACY_FORMAT";
    public const string HintCameraDriver = "SDL_CAMERA_DRIVER";
    public const string HintCpuFeatureMask = "SDL_CPU_FEATURE_MASK";
    public const string HintJoystickDirectinput = "SDL_JOYSTICK_DIRECTINPUT";
    public const string HintFileDialogDriver = "SDL_FILE_DIALOG_DRIVER";
    public const string HintDisplayUsableBounds = "SDL_DISPLAY_USABLE_BOUNDS";
    public const string HintInvalidParamChecks = "SDL_INVALID_PARAM_CHECKS";
    public const string HintEmscriptenAsyncify = "SDL_EMSCRIPTEN_ASYNCIFY";
    public const string HintEmscriptenCanvasSelector = "SDL_EMSCRIPTEN_CANVAS_SELECTOR";
    public const string HintEmscriptenKeyboardElement = "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT";
    public const string HintEnableScreenKeyboard = "SDL_ENABLE_SCREEN_KEYBOARD";
    public const string HintEnableSteamScreenKeyboard = "SDL_ENABLE_STEAM_SCREEN_KEYBOARD";
    public const string HintEvdevDevices = "SDL_EVDEV_DEVICES";
    public const string HintEventLogging = "SDL_EVENT_LOGGING";
    public const string HintForceRaisewindow = "SDL_FORCE_RAISEWINDOW";
    public const string HintFramebufferAcceleration = "SDL_FRAMEBUFFER_ACCELERATION";
    public const string HintGamecontrollerconfig = "SDL_GAMECONTROLLERCONFIG";
    public const string HintGamecontrollerconfigFile = "SDL_GAMECONTROLLERCONFIG_FILE";
    public const string HintGamecontrollertype = "SDL_GAMECONTROLLERTYPE";
    public const string HintGamecontrollerIgnoreDevices = "SDL_GAMECONTROLLER_IGNORE_DEVICES";
    public const string HintGamecontrollerIgnoreDevicesExcept = "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT";
    public const string HintGamecontrollerSensorFusion = "SDL_GAMECONTROLLER_SENSOR_FUSION";
    public const string HintGdkTextinputDefaultText = "SDL_GDK_TEXTINPUT_DEFAULT_TEXT";
    public const string HintGdkTextinputDescription = "SDL_GDK_TEXTINPUT_DESCRIPTION";
    public const string HintGdkTextinputMaxLength = "SDL_GDK_TEXTINPUT_MAX_LENGTH";
    public const string HintGdkTextinputScope = "SDL_GDK_TEXTINPUT_SCOPE";
    public const string HintGdkTextinputTitle = "SDL_GDK_TEXTINPUT_TITLE";
    public const string HintHidapiLibusb = "SDL_HIDAPI_LIBUSB";
    public const string HintHidapiLibusbGamecube = "SDL_HIDAPI_LIBUSB_GAMECUBE";
    public const string HintHidapiLibusbWhitelist = "SDL_HIDAPI_LIBUSB_WHITELIST";
    public const string HintHidapiUdev = "SDL_HIDAPI_UDEV";
    public const string HintGpuDriver = "SDL_GPU_DRIVER";
    public const string HintHidapiEnumerateOnlyControllers = "SDL_HIDAPI_ENUMERATE_ONLY_CONTROLLERS";
    public const string HintHidapiIgnoreDevices = "SDL_HIDAPI_IGNORE_DEVICES";
    public const string HintImeImplementedUi = "SDL_IME_IMPLEMENTED_UI";
    public const string HintIosHideHomeIndicator = "SDL_IOS_HIDE_HOME_INDICATOR";
    public const string HintJoystickAllowBackgroundEvents = "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS";
    public const string HintJoystickArcadestickDevices = "SDL_JOYSTICK_ARCADESTICK_DEVICES";
    public const string HintJoystickArcadestickDevicesExcluded = "SDL_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED";
    public const string HintJoystickBlacklistDevices = "SDL_JOYSTICK_BLACKLIST_DEVICES";
    public const string HintJoystickBlacklistDevicesExcluded = "SDL_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED";
    public const string HintJoystickDevice = "SDL_JOYSTICK_DEVICE";
    public const string HintJoystickEnhancedReports = "SDL_JOYSTICK_ENHANCED_REPORTS";
    public const string HintJoystickFlightstickDevices = "SDL_JOYSTICK_FLIGHTSTICK_DEVICES";
    public const string HintJoystickFlightstickDevicesExcluded = "SDL_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED";
    public const string HintJoystickGameinput = "SDL_JOYSTICK_GAMEINPUT";
    public const string HintJoystickGameinputRaw = "SDL_JOYSTICK_GAMEINPUT_RAW";
    public const string HintJoystickGamecubeDevices = "SDL_JOYSTICK_GAMECUBE_DEVICES";
    public const string HintJoystickGamecubeDevicesExcluded = "SDL_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED";
    public const string HintJoystickHidapi = "SDL_JOYSTICK_HIDAPI";
    public const string HintJoystickHidapiCombineJoyCons = "SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS";
    public const string HintJoystickHidapiGamecube = "SDL_JOYSTICK_HIDAPI_GAMECUBE";
    public const string HintJoystickHidapiGamecubeRumbleBrake = "SDL_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE";
    public const string HintJoystickHidapiJoyCons = "SDL_JOYSTICK_HIDAPI_JOY_CONS";
    public const string HintJoystickHidapiJoyconHomeLed = "SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED";
    public const string HintJoystickHidapiLuna = "SDL_JOYSTICK_HIDAPI_LUNA";
    public const string HintJoystickHidapiNintendoClassic = "SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC";
    public const string HintJoystickHidapiPs3 = "SDL_JOYSTICK_HIDAPI_PS3";
    public const string HintJoystickHidapiPs3SixaxisDriver = "SDL_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER";
    public const string HintJoystickHidapiPs4 = "SDL_JOYSTICK_HIDAPI_PS4";
    public const string HintJoystickHidapiPs4ReportInterval = "SDL_JOYSTICK_HIDAPI_PS4_REPORT_INTERVAL";
    public const string HintJoystickHidapiPs5 = "SDL_JOYSTICK_HIDAPI_PS5";
    public const string HintJoystickHidapiPs5PlayerLed = "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED";
    public const string HintJoystickHidapiShield = "SDL_JOYSTICK_HIDAPI_SHIELD";
    public const string HintJoystickHidapiStadia = "SDL_JOYSTICK_HIDAPI_STADIA";
    public const string HintJoystickHidapiSteam = "SDL_JOYSTICK_HIDAPI_STEAM";
    public const string HintJoystickHidapiSteamHomeLed = "SDL_JOYSTICK_HIDAPI_STEAM_HOME_LED";
    public const string HintJoystickHidapiSteamdeck = "SDL_JOYSTICK_HIDAPI_STEAMDECK";
    public const string HintJoystickHidapiSteamHori = "SDL_JOYSTICK_HIDAPI_STEAM_HORI";
    public const string HintJoystickHidapiLg4ff = "SDL_JOYSTICK_HIDAPI_LG4FF";
    public const string HintJoystickHidapi8bitdo = "SDL_JOYSTICK_HIDAPI_8BITDO";
    public const string HintJoystickHidapiSinput = "SDL_JOYSTICK_HIDAPI_SINPUT";
    public const string HintJoystickHidapiZuiki = "SDL_JOYSTICK_HIDAPI_ZUIKI";
    public const string HintJoystickHidapiFlydigi = "SDL_JOYSTICK_HIDAPI_FLYDIGI";
    public const string HintJoystickHidapiSwitch = "SDL_JOYSTICK_HIDAPI_SWITCH";
    public const string HintJoystickHidapiSwitchHomeLed = "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED";
    public const string HintJoystickHidapiSwitchPlayerLed = "SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED";
    public const string HintJoystickHidapiSwitch2 = "SDL_JOYSTICK_HIDAPI_SWITCH2";
    public const string HintJoystickHidapiVerticalJoyCons = "SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS";
    public const string HintJoystickHidapiWii = "SDL_JOYSTICK_HIDAPI_WII";
    public const string HintJoystickHidapiWiiPlayerLed = "SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED";
    public const string HintJoystickHidapiXbox = "SDL_JOYSTICK_HIDAPI_XBOX";
    public const string HintJoystickHidapiXbox360 = "SDL_JOYSTICK_HIDAPI_XBOX_360";
    public const string HintJoystickHidapiXbox360PlayerLed = "SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED";
    public const string HintJoystickHidapiXbox360Wireless = "SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS";
    public const string HintJoystickHidapiXboxOne = "SDL_JOYSTICK_HIDAPI_XBOX_ONE";
    public const string HintJoystickHidapiXboxOneHomeLed = "SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED";
    public const string HintJoystickHidapiGip = "SDL_JOYSTICK_HIDAPI_GIP";
    public const string HintJoystickHidapiGipResetForMetadata = "SDL_JOYSTICK_HIDAPI_GIP_RESET_FOR_METADATA";
    public const string HintJoystickIokit = "SDL_JOYSTICK_IOKIT";
    public const string HintJoystickLinuxClassic = "SDL_JOYSTICK_LINUX_CLASSIC";
    public const string HintJoystickLinuxDeadzones = "SDL_JOYSTICK_LINUX_DEADZONES";
    public const string HintJoystickLinuxDigitalHats = "SDL_JOYSTICK_LINUX_DIGITAL_HATS";
    public const string HintJoystickLinuxHatDeadzones = "SDL_JOYSTICK_LINUX_HAT_DEADZONES";
    public const string HintJoystickMfi = "SDL_JOYSTICK_MFI";
    public const string HintJoystickRawinput = "SDL_JOYSTICK_RAWINPUT";
    public const string HintJoystickRawinputCorrelateXinput = "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT";
    public const string HintJoystickRogChakram = "SDL_JOYSTICK_ROG_CHAKRAM";
    public const string HintJoystickThread = "SDL_JOYSTICK_THREAD";
    public const string HintJoystickThrottleDevices = "SDL_JOYSTICK_THROTTLE_DEVICES";
    public const string HintJoystickThrottleDevicesExcluded = "SDL_JOYSTICK_THROTTLE_DEVICES_EXCLUDED";
    public const string HintJoystickWgi = "SDL_JOYSTICK_WGI";
    public const string HintJoystickWheelDevices = "SDL_JOYSTICK_WHEEL_DEVICES";
    public const string HintJoystickWheelDevicesExcluded = "SDL_JOYSTICK_WHEEL_DEVICES_EXCLUDED";
    public const string HintJoystickZeroCenteredDevices = "SDL_JOYSTICK_ZERO_CENTERED_DEVICES";
    public const string HintJoystickHapticAxes = "SDL_JOYSTICK_HAPTIC_AXES";
    public const string HintKeycodeOptions = "SDL_KEYCODE_OPTIONS";
    public const string HintKmsdrmDeviceIndex = "SDL_KMSDRM_DEVICE_INDEX";
    public const string HintKmsdrmRequireDrmMaster = "SDL_KMSDRM_REQUIRE_DRM_MASTER";
    public const string HintKmsdrmAtomic = "SDL_KMSDRM_ATOMIC";
    public const string HintLogging = "SDL_LOGGING";
    public const string HintMacBackgroundApp = "SDL_MAC_BACKGROUND_APP";
    public const string HintMacCtrlClickEmulateRightClick = "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK";
    public const string HintMacOpenglAsyncDispatch = "SDL_MAC_OPENGL_ASYNC_DISPATCH";
    public const string HintMacOptionAsAlt = "SDL_MAC_OPTION_AS_ALT";
    public const string HintMacScrollMomentum = "SDL_MAC_SCROLL_MOMENTUM";
    public const string HintMacPressAndHold = "SDL_MAC_PRESS_AND_HOLD";
    public const string HintMainCallbackRate = "SDL_MAIN_CALLBACK_RATE";
    public const string HintMouseAutoCapture = "SDL_MOUSE_AUTO_CAPTURE";
    public const string HintMouseDoubleClickRadius = "SDL_MOUSE_DOUBLE_CLICK_RADIUS";
    public const string HintMouseDoubleClickTime = "SDL_MOUSE_DOUBLE_CLICK_TIME";
    public const string HintMouseDefaultSystemCursor = "SDL_MOUSE_DEFAULT_SYSTEM_CURSOR";
    public const string HintMouseDpiScaleCursors = "SDL_MOUSE_DPI_SCALE_CURSORS";
    public const string HintMouseEmulateWarpWithRelative = "SDL_MOUSE_EMULATE_WARP_WITH_RELATIVE";
    public const string HintMouseFocusClickthrough = "SDL_MOUSE_FOCUS_CLICKTHROUGH";
    public const string HintMouseNormalSpeedScale = "SDL_MOUSE_NORMAL_SPEED_SCALE";
    public const string HintMouseRelativeModeCenter = "SDL_MOUSE_RELATIVE_MODE_CENTER";
    public const string HintMouseRelativeSpeedScale = "SDL_MOUSE_RELATIVE_SPEED_SCALE";
    public const string HintMouseRelativeSystemScale = "SDL_MOUSE_RELATIVE_SYSTEM_SCALE";
    public const string HintMouseRelativeWarpMotion = "SDL_MOUSE_RELATIVE_WARP_MOTION";
    public const string HintMouseRelativeCursorVisible = "SDL_MOUSE_RELATIVE_CURSOR_VISIBLE";
    public const string HintMouseTouchEvents = "SDL_MOUSE_TOUCH_EVENTS";
    public const string HintMuteConsoleKeyboard = "SDL_MUTE_CONSOLE_KEYBOARD";
    public const string HintNoSignalHandlers = "SDL_NO_SIGNAL_HANDLERS";
    public const string HintOpenglLibrary = "SDL_OPENGL_LIBRARY";
    public const string HintEglLibrary = "SDL_EGL_LIBRARY";
    public const string HintOpenglEsDriver = "SDL_OPENGL_ES_DRIVER";
    public const string HintOpenglForceSrgbFramebuffer = "SDL_OPENGL_FORCE_SRGB_FRAMEBUFFER";
    public const string HintOpenvrLibrary = "SDL_OPENVR_LIBRARY";
    public const string HintOrientations = "SDL_ORIENTATIONS";
    public const string HintPollSentinel = "SDL_POLL_SENTINEL";
    public const string HintPreferredLocales = "SDL_PREFERRED_LOCALES";
    public const string HintQuitOnLastWindowClose = "SDL_QUIT_ON_LAST_WINDOW_CLOSE";
    public const string HintRenderDirect3dThreadsafe = "SDL_RENDER_DIRECT3D_THREADSAFE";
    public const string HintRenderDirect3d11Debug = "SDL_RENDER_DIRECT3D11_DEBUG";
    public const string HintRenderDirect3d11Warp = "SDL_RENDER_DIRECT3D11_WARP";
    public const string HintRenderVulkanDebug = "SDL_RENDER_VULKAN_DEBUG";
    public const string HintRenderGpuDebug = "SDL_RENDER_GPU_DEBUG";
    public const string HintRenderGpuLowPower = "SDL_RENDER_GPU_LOW_POWER";
    public const string HintRenderDriver = "SDL_RENDER_DRIVER";
    public const string HintRenderLineMethod = "SDL_RENDER_LINE_METHOD";
    public const string HintRenderMetalPreferLowPowerDevice = "SDL_RENDER_METAL_PREFER_LOW_POWER_DEVICE";
    public const string HintRenderVsync = "SDL_RENDER_VSYNC";
    public const string HintReturnKeyHidesIme = "SDL_RETURN_KEY_HIDES_IME";
    public const string HintRogGamepadMice = "SDL_ROG_GAMEPAD_MICE";
    public const string HintRogGamepadMiceExcluded = "SDL_ROG_GAMEPAD_MICE_EXCLUDED";
    public const string HintPs2GsWidth = "SDL_PS2_GS_WIDTH";
    public const string HintPs2GsHeight = "SDL_PS2_GS_HEIGHT";
    public const string HintPs2GsProgressive = "SDL_PS2_GS_PROGRESSIVE";
    public const string HintPs2GsMode = "SDL_PS2_GS_MODE";
    public const string HintRpiVideoLayer = "SDL_RPI_VIDEO_LAYER";
    public const string HintScreensaverInhibitActivityName = "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME";
    public const string HintShutdownDbusOnQuit = "SDL_SHUTDOWN_DBUS_ON_QUIT";
    public const string HintStorageTitleDriver = "SDL_STORAGE_TITLE_DRIVER";
    public const string HintStorageUserDriver = "SDL_STORAGE_USER_DRIVER";
    public const string HintThreadForceRealtimeTimeCritical = "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL";
    public const string HintThreadPriorityPolicy = "SDL_THREAD_PRIORITY_POLICY";
    public const string HintTimerResolution = "SDL_TIMER_RESOLUTION";
    public const string HintTouchMouseEvents = "SDL_TOUCH_MOUSE_EVENTS";
    public const string HintTrackpadIsTouchOnly = "SDL_TRACKPAD_IS_TOUCH_ONLY";
    public const string HintTvRemoteAsJoystick = "SDL_TV_REMOTE_AS_JOYSTICK";
    public const string HintVideoAllowScreensaver = "SDL_VIDEO_ALLOW_SCREENSAVER";
    public const string HintVideoDisplayPriority = "SDL_VIDEO_DISPLAY_PRIORITY";
    public const string HintVideoDoubleBuffer = "SDL_VIDEO_DOUBLE_BUFFER";
    public const string HintVideoDriver = "SDL_VIDEO_DRIVER";
    public const string HintVideoDummySaveFrames = "SDL_VIDEO_DUMMY_SAVE_FRAMES";
    public const string HintVideoEglAllowGetdisplayFallback = "SDL_VIDEO_EGL_ALLOW_GETDISPLAY_FALLBACK";
    public const string HintVideoForceEgl = "SDL_VIDEO_FORCE_EGL";
    public const string HintVideoMacFullscreenSpaces = "SDL_VIDEO_MAC_FULLSCREEN_SPACES";
    public const string HintVideoMacFullscreenMenuVisibility = "SDL_VIDEO_MAC_FULLSCREEN_MENU_VISIBILITY";
    public const string HintVideoMetalAutoResizeDrawable = "SDL_VIDEO_METAL_AUTO_RESIZE_DRAWABLE";
    public const string HintVideoMatchExclusiveModeOnMove = "SDL_VIDEO_MATCH_EXCLUSIVE_MODE_ON_MOVE";
    public const string HintVideoMinimizeOnFocusLoss = "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS";
    public const string HintVideoOffscreenSaveFrames = "SDL_VIDEO_OFFSCREEN_SAVE_FRAMES";
    public const string HintVideoSyncWindowOperations = "SDL_VIDEO_SYNC_WINDOW_OPERATIONS";
    public const string HintVideoWaylandAllowLibdecor = "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR";
    public const string HintVideoWaylandModeEmulation = "SDL_VIDEO_WAYLAND_MODE_EMULATION";
    public const string HintVideoWaylandModeScaling = "SDL_VIDEO_WAYLAND_MODE_SCALING";
    public const string HintVideoWaylandPreferLibdecor = "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR";
    public const string HintVideoWaylandScaleToDisplay = "SDL_VIDEO_WAYLAND_SCALE_TO_DISPLAY";
    public const string HintVideoWinD3dcompiler = "SDL_VIDEO_WIN_D3DCOMPILER";
    public const string HintVideoX11EnableXsyncExt = "SDL_VIDEO_X11_ENABLE_XSYNC_EXT";
    public const string HintVideoX11ExternalWindowInput = "SDL_VIDEO_X11_EXTERNAL_WINDOW_INPUT";
    public const string HintVideoX11NetWmBypassCompositor = "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR";
    public const string HintVideoX11NetWmPing = "SDL_VIDEO_X11_NET_WM_PING";
    public const string HintVideoX11Nodirectcolor = "SDL_VIDEO_X11_NODIRECTCOLOR";
    public const string HintVideoX11ScalingFactor = "SDL_VIDEO_X11_SCALING_FACTOR";
    public const string HintVideoX11Visualid = "SDL_VIDEO_X11_VISUALID";
    public const string HintVideoX11WindowVisualid = "SDL_VIDEO_X11_WINDOW_VISUALID";
    public const string HintVideoX11Xrandr = "SDL_VIDEO_X11_XRANDR";
    public const string HintVitaEnableBackTouch = "SDL_VITA_ENABLE_BACK_TOUCH";
    public const string HintVitaEnableFrontTouch = "SDL_VITA_ENABLE_FRONT_TOUCH";
    public const string HintVitaModulePath = "SDL_VITA_MODULE_PATH";
    public const string HintVitaPvrInit = "SDL_VITA_PVR_INIT";
    public const string HintVitaResolution = "SDL_VITA_RESOLUTION";
    public const string HintVitaPvrOpengl = "SDL_VITA_PVR_OPENGL";
    public const string HintVitaTouchMouseDevice = "SDL_VITA_TOUCH_MOUSE_DEVICE";
    public const string HintVulkanDisplay = "SDL_VULKAN_DISPLAY";
    public const string HintVulkanLibrary = "SDL_VULKAN_LIBRARY";
    public const string HintWaveFactChunk = "SDL_WAVE_FACT_CHUNK";
    public const string HintWaveChunkLimit = "SDL_WAVE_CHUNK_LIMIT";
    public const string HintWaveRiffChunkSize = "SDL_WAVE_RIFF_CHUNK_SIZE";
    public const string HintWaveTruncation = "SDL_WAVE_TRUNCATION";
    public const string HintWindowActivateWhenRaised = "SDL_WINDOW_ACTIVATE_WHEN_RAISED";
    public const string HintWindowActivateWhenShown = "SDL_WINDOW_ACTIVATE_WHEN_SHOWN";
    public const string HintWindowAllowTopmost = "SDL_WINDOW_ALLOW_TOPMOST";
    public const string HintWindowFrameUsableWhileCursorHidden = "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";
    public const string HintWindowsCloseOnAltF4 = "SDL_WINDOWS_CLOSE_ON_ALT_F4";
    public const string HintWindowsEnableMenuMnemonics = "SDL_WINDOWS_ENABLE_MENU_MNEMONICS";
    public const string HintWindowsEnableMessageloop = "SDL_WINDOWS_ENABLE_MESSAGELOOP";
    public const string HintWindowsGameinput = "SDL_WINDOWS_GAMEINPUT";
    public const string HintWindowsRawKeyboard = "SDL_WINDOWS_RAW_KEYBOARD";
    public const string HintWindowsRawKeyboardExcludeHotkeys = "SDL_WINDOWS_RAW_KEYBOARD_EXCLUDE_HOTKEYS";
    public const string HintWindowsRawKeyboardInputsink = "SDL_WINDOWS_RAW_KEYBOARD_INPUTSINK";
    public const string HintWindowsForceSemaphoreKernel = "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL";
    public const string HintWindowsIntresourceIcon = "SDL_WINDOWS_INTRESOURCE_ICON";
    public const string HintWindowsIntresourceIconSmall = "SDL_WINDOWS_INTRESOURCE_ICON_SMALL";
    public const string HintWindowsUseD3d9ex = "SDL_WINDOWS_USE_D3D9EX";
    public const string HintWindowsEraseBackgroundMode = "SDL_WINDOWS_ERASE_BACKGROUND_MODE";
    public const string HintX11ForceOverrideRedirect = "SDL_X11_FORCE_OVERRIDE_REDIRECT";
    public const string HintX11WindowType = "SDL_X11_WINDOW_TYPE";
    public const string HintX11XcbLibrary = "SDL_X11_XCB_LIBRARY";
    public const string HintXinputEnabled = "SDL_XINPUT_ENABLED";
    public const string HintAssert = "SDL_ASSERT";
    public const string HintPenMouseEvents = "SDL_PEN_MOUSE_EVENTS";
    public const string HintPenTouchEvents = "SDL_PEN_TOUCH_EVENTS";
    public const string PropAppMetadataNameString = "SDL.app.metadata.name";
    public const string PropAppMetadataVersionString = "SDL.app.metadata.version";
    public const string PropAppMetadataIdentifierString = "SDL.app.metadata.identifier";
    public const string PropAppMetadataCreatorString = "SDL.app.metadata.creator";
    public const string PropAppMetadataCopyrightString = "SDL.app.metadata.copyright";
    public const string PropAppMetadataUrlString = "SDL.app.metadata.url";
    public const string PropAppMetadataTypeString = "SDL.app.metadata.type";
    public const string PropIostreamWindowsHandlePointer = "SDL.iostream.windows.handle";
    public const string PropIostreamStdioFilePointer = "SDL.iostream.stdio.file";
    public const string PropIostreamFileDescriptorNumber = "SDL.iostream.file_descriptor";
    public const string PropIostreamAndroidAassetPointer = "SDL.iostream.android.aasset";
    public const string PropIostreamMemoryPointer = "SDL.iostream.memory.base";
    public const string PropIostreamMemorySizeNumber = "SDL.iostream.memory.size";
    public const string PropIostreamMemoryFreeFuncPointer = "SDL.iostream.memory.free";
    public const string PropIostreamDynamicMemoryPointer = "SDL.iostream.dynamic.memory";
    public const string PropIostreamDynamicChunksizeNumber = "SDL.iostream.dynamic.chunksize";
    public const int JoystickAxisMax = 32767;
    public const int JoystickAxisMin = -32768;
    public const string PropJoystickCapMonoLedBoolean = "SDL.joystick.cap.mono_led";
    public const string PropJoystickCapRgbLedBoolean = "SDL.joystick.cap.rgb_led";
    public const string PropJoystickCapPlayerLedBoolean = "SDL.joystick.cap.player_led";
    public const string PropJoystickCapRumbleBoolean = "SDL.joystick.cap.rumble";
    public const string PropJoystickCapTriggerRumbleBoolean = "SDL.joystick.cap.trigger_rumble";
    public const uint HatCentered = 0x00U;
    public const uint HatUp = 0x01U;
    public const uint HatRight = 0x02U;
    public const uint HatDown = 0x04U;
    public const uint HatLeft = 0x08U;
    public const uint HatRightup = (0x02U | 0x01U);
    public const uint HatRightdown = (0x02U | 0x04U);
    public const uint HatLeftup = (0x08U | 0x01U);
    public const uint HatLeftdown = (0x08U | 0x04U);
    public const string PropTextinputTypeNumber = "SDL.textinput.type";
    public const string PropTextinputCapitalizationNumber = "SDL.textinput.capitalization";
    public const string PropTextinputAutocorrectBoolean = "SDL.textinput.autocorrect";
    public const string PropTextinputMultilineBoolean = "SDL.textinput.multiline";
    public const string PropTextinputAndroidInputtypeNumber = "SDL.textinput.android.inputtype";
    public const uint SdlkExtendedMask = (1U << 29);
    public const uint SdlkScancodeMask = (1U << 30);
    public const uint SdlkUnknown = 0x00000000U;
    public const uint SdlkReturn = 0x0000000dU;
    public const uint SdlkEscape = 0x0000001bU;
    public const uint SdlkBackspace = 0x00000008U;
    public const uint SdlkTab = 0x00000009U;
    public const uint SdlkSpace = 0x00000020U;
    public const uint SdlkExclaim = 0x00000021U;
    public const uint SdlkDblapostrophe = 0x00000022U;
    public const uint SdlkHash = 0x00000023U;
    public const uint SdlkDollar = 0x00000024U;
    public const uint SdlkPercent = 0x00000025U;
    public const uint SdlkAmpersand = 0x00000026U;
    public const uint SdlkApostrophe = 0x00000027U;
    public const uint SdlkLeftparen = 0x00000028U;
    public const uint SdlkRightparen = 0x00000029U;
    public const uint SdlkAsterisk = 0x0000002aU;
    public const uint SdlkPlus = 0x0000002bU;
    public const uint SdlkComma = 0x0000002cU;
    public const uint SdlkMinus = 0x0000002dU;
    public const uint SdlkPeriod = 0x0000002eU;
    public const uint SdlkSlash = 0x0000002fU;
    public const uint Sdlk0 = 0x00000030U;
    public const uint Sdlk1 = 0x00000031U;
    public const uint Sdlk2 = 0x00000032U;
    public const uint Sdlk3 = 0x00000033U;
    public const uint Sdlk4 = 0x00000034U;
    public const uint Sdlk5 = 0x00000035U;
    public const uint Sdlk6 = 0x00000036U;
    public const uint Sdlk7 = 0x00000037U;
    public const uint Sdlk8 = 0x00000038U;
    public const uint Sdlk9 = 0x00000039U;
    public const uint SdlkColon = 0x0000003aU;
    public const uint SdlkSemicolon = 0x0000003bU;
    public const uint SdlkLess = 0x0000003cU;
    public const uint SdlkEquals = 0x0000003dU;
    public const uint SdlkGreater = 0x0000003eU;
    public const uint SdlkQuestion = 0x0000003fU;
    public const uint SdlkAt = 0x00000040U;
    public const uint SdlkLeftbracket = 0x0000005bU;
    public const uint SdlkBackslash = 0x0000005cU;
    public const uint SdlkRightbracket = 0x0000005dU;
    public const uint SdlkCaret = 0x0000005eU;
    public const uint SdlkUnderscore = 0x0000005fU;
    public const uint SdlkGrave = 0x00000060U;
    public const uint SdlkA = 0x00000061U;
    public const uint SdlkB = 0x00000062U;
    public const uint SdlkC = 0x00000063U;
    public const uint SdlkD = 0x00000064U;
    public const uint SdlkE = 0x00000065U;
    public const uint SdlkF = 0x00000066U;
    public const uint SdlkG = 0x00000067U;
    public const uint SdlkH = 0x00000068U;
    public const uint SdlkI = 0x00000069U;
    public const uint SdlkJ = 0x0000006aU;
    public const uint SdlkK = 0x0000006bU;
    public const uint SdlkL = 0x0000006cU;
    public const uint SdlkM = 0x0000006dU;
    public const uint SdlkN = 0x0000006eU;
    public const uint SdlkO = 0x0000006fU;
    public const uint SdlkP = 0x00000070U;
    public const uint SdlkQ = 0x00000071U;
    public const uint SdlkR = 0x00000072U;
    public const uint SdlkS = 0x00000073U;
    public const uint SdlkT = 0x00000074U;
    public const uint SdlkU = 0x00000075U;
    public const uint SdlkV = 0x00000076U;
    public const uint SdlkW = 0x00000077U;
    public const uint SdlkX = 0x00000078U;
    public const uint SdlkY = 0x00000079U;
    public const uint SdlkZ = 0x0000007aU;
    public const uint SdlkLeftbrace = 0x0000007bU;
    public const uint SdlkPipe = 0x0000007cU;
    public const uint SdlkRightbrace = 0x0000007dU;
    public const uint SdlkTilde = 0x0000007eU;
    public const uint SdlkDelete = 0x0000007fU;
    public const uint SdlkPlusminus = 0x000000b1U;
    public const uint SdlkCapslock = 0x40000039U;
    public const uint SdlkF1 = 0x4000003aU;
    public const uint SdlkF2 = 0x4000003bU;
    public const uint SdlkF3 = 0x4000003cU;
    public const uint SdlkF4 = 0x4000003dU;
    public const uint SdlkF5 = 0x4000003eU;
    public const uint SdlkF6 = 0x4000003fU;
    public const uint SdlkF7 = 0x40000040U;
    public const uint SdlkF8 = 0x40000041U;
    public const uint SdlkF9 = 0x40000042U;
    public const uint SdlkF10 = 0x40000043U;
    public const uint SdlkF11 = 0x40000044U;
    public const uint SdlkF12 = 0x40000045U;
    public const uint SdlkPrintscreen = 0x40000046U;
    public const uint SdlkScrolllock = 0x40000047U;
    public const uint SdlkPause = 0x40000048U;
    public const uint SdlkInsert = 0x40000049U;
    public const uint SdlkHome = 0x4000004aU;
    public const uint SdlkPageup = 0x4000004bU;
    public const uint SdlkEnd = 0x4000004dU;
    public const uint SdlkPagedown = 0x4000004eU;
    public const uint SdlkRight = 0x4000004fU;
    public const uint SdlkLeft = 0x40000050U;
    public const uint SdlkDown = 0x40000051U;
    public const uint SdlkUp = 0x40000052U;
    public const uint SdlkNumlockclear = 0x40000053U;
    public const uint SdlkKpDivide = 0x40000054U;
    public const uint SdlkKpMultiply = 0x40000055U;
    public const uint SdlkKpMinus = 0x40000056U;
    public const uint SdlkKpPlus = 0x40000057U;
    public const uint SdlkKpEnter = 0x40000058U;
    public const uint SdlkKp1 = 0x40000059U;
    public const uint SdlkKp2 = 0x4000005aU;
    public const uint SdlkKp3 = 0x4000005bU;
    public const uint SdlkKp4 = 0x4000005cU;
    public const uint SdlkKp5 = 0x4000005dU;
    public const uint SdlkKp6 = 0x4000005eU;
    public const uint SdlkKp7 = 0x4000005fU;
    public const uint SdlkKp8 = 0x40000060U;
    public const uint SdlkKp9 = 0x40000061U;
    public const uint SdlkKp0 = 0x40000062U;
    public const uint SdlkKpPeriod = 0x40000063U;
    public const uint SdlkApplication = 0x40000065U;
    public const uint SdlkPower = 0x40000066U;
    public const uint SdlkKpEquals = 0x40000067U;
    public const uint SdlkF13 = 0x40000068U;
    public const uint SdlkF14 = 0x40000069U;
    public const uint SdlkF15 = 0x4000006aU;
    public const uint SdlkF16 = 0x4000006bU;
    public const uint SdlkF17 = 0x4000006cU;
    public const uint SdlkF18 = 0x4000006dU;
    public const uint SdlkF19 = 0x4000006eU;
    public const uint SdlkF20 = 0x4000006fU;
    public const uint SdlkF21 = 0x40000070U;
    public const uint SdlkF22 = 0x40000071U;
    public const uint SdlkF23 = 0x40000072U;
    public const uint SdlkF24 = 0x40000073U;
    public const uint SdlkExecute = 0x40000074U;
    public const uint SdlkHelp = 0x40000075U;
    public const uint SdlkMenu = 0x40000076U;
    public const uint SdlkSelect = 0x40000077U;
    public const uint SdlkStop = 0x40000078U;
    public const uint SdlkAgain = 0x40000079U;
    public const uint SdlkUndo = 0x4000007aU;
    public const uint SdlkCut = 0x4000007bU;
    public const uint SdlkCopy = 0x4000007cU;
    public const uint SdlkPaste = 0x4000007dU;
    public const uint SdlkFind = 0x4000007eU;
    public const uint SdlkMute = 0x4000007fU;
    public const uint SdlkVolumeup = 0x40000080U;
    public const uint SdlkVolumedown = 0x40000081U;
    public const uint SdlkKpComma = 0x40000085U;
    public const uint SdlkKpEqualsas400 = 0x40000086U;
    public const uint SdlkAlterase = 0x40000099U;
    public const uint SdlkSysreq = 0x4000009aU;
    public const uint SdlkCancel = 0x4000009bU;
    public const uint SdlkClear = 0x4000009cU;
    public const uint SdlkPrior = 0x4000009dU;
    public const uint SdlkReturn2 = 0x4000009eU;
    public const uint SdlkSeparator = 0x4000009fU;
    public const uint SdlkOut = 0x400000a0U;
    public const uint SdlkOper = 0x400000a1U;
    public const uint SdlkClearagain = 0x400000a2U;
    public const uint SdlkCrsel = 0x400000a3U;
    public const uint SdlkExsel = 0x400000a4U;
    public const uint SdlkKp00 = 0x400000b0U;
    public const uint SdlkKp000 = 0x400000b1U;
    public const uint SdlkThousandsseparator = 0x400000b2U;
    public const uint SdlkDecimalseparator = 0x400000b3U;
    public const uint SdlkCurrencyunit = 0x400000b4U;
    public const uint SdlkCurrencysubunit = 0x400000b5U;
    public const uint SdlkKpLeftparen = 0x400000b6U;
    public const uint SdlkKpRightparen = 0x400000b7U;
    public const uint SdlkKpLeftbrace = 0x400000b8U;
    public const uint SdlkKpRightbrace = 0x400000b9U;
    public const uint SdlkKpTab = 0x400000baU;
    public const uint SdlkKpBackspace = 0x400000bbU;
    public const uint SdlkKpA = 0x400000bcU;
    public const uint SdlkKpB = 0x400000bdU;
    public const uint SdlkKpC = 0x400000beU;
    public const uint SdlkKpD = 0x400000bfU;
    public const uint SdlkKpE = 0x400000c0U;
    public const uint SdlkKpF = 0x400000c1U;
    public const uint SdlkKpXor = 0x400000c2U;
    public const uint SdlkKpPower = 0x400000c3U;
    public const uint SdlkKpPercent = 0x400000c4U;
    public const uint SdlkKpLess = 0x400000c5U;
    public const uint SdlkKpGreater = 0x400000c6U;
    public const uint SdlkKpAmpersand = 0x400000c7U;
    public const uint SdlkKpDblampersand = 0x400000c8U;
    public const uint SdlkKpVerticalbar = 0x400000c9U;
    public const uint SdlkKpDblverticalbar = 0x400000caU;
    public const uint SdlkKpColon = 0x400000cbU;
    public const uint SdlkKpHash = 0x400000ccU;
    public const uint SdlkKpSpace = 0x400000cdU;
    public const uint SdlkKpAt = 0x400000ceU;
    public const uint SdlkKpExclam = 0x400000cfU;
    public const uint SdlkKpMemstore = 0x400000d0U;
    public const uint SdlkKpMemrecall = 0x400000d1U;
    public const uint SdlkKpMemclear = 0x400000d2U;
    public const uint SdlkKpMemadd = 0x400000d3U;
    public const uint SdlkKpMemsubtract = 0x400000d4U;
    public const uint SdlkKpMemmultiply = 0x400000d5U;
    public const uint SdlkKpMemdivide = 0x400000d6U;
    public const uint SdlkKpPlusminus = 0x400000d7U;
    public const uint SdlkKpClear = 0x400000d8U;
    public const uint SdlkKpClearentry = 0x400000d9U;
    public const uint SdlkKpBinary = 0x400000daU;
    public const uint SdlkKpOctal = 0x400000dbU;
    public const uint SdlkKpDecimal = 0x400000dcU;
    public const uint SdlkKpHexadecimal = 0x400000ddU;
    public const uint SdlkLctrl = 0x400000e0U;
    public const uint SdlkLshift = 0x400000e1U;
    public const uint SdlkLalt = 0x400000e2U;
    public const uint SdlkLgui = 0x400000e3U;
    public const uint SdlkRctrl = 0x400000e4U;
    public const uint SdlkRshift = 0x400000e5U;
    public const uint SdlkRalt = 0x400000e6U;
    public const uint SdlkRgui = 0x400000e7U;
    public const uint SdlkMode = 0x40000101U;
    public const uint SdlkSleep = 0x40000102U;
    public const uint SdlkWake = 0x40000103U;
    public const uint SdlkChannelIncrement = 0x40000104U;
    public const uint SdlkChannelDecrement = 0x40000105U;
    public const uint SdlkMediaPlay = 0x40000106U;
    public const uint SdlkMediaPause = 0x40000107U;
    public const uint SdlkMediaRecord = 0x40000108U;
    public const uint SdlkMediaFastForward = 0x40000109U;
    public const uint SdlkMediaRewind = 0x4000010aU;
    public const uint SdlkMediaNextTrack = 0x4000010bU;
    public const uint SdlkMediaPreviousTrack = 0x4000010cU;
    public const uint SdlkMediaStop = 0x4000010dU;
    public const uint SdlkMediaEject = 0x4000010eU;
    public const uint SdlkMediaPlayPause = 0x4000010fU;
    public const uint SdlkMediaSelect = 0x40000110U;
    public const uint SdlkAcNew = 0x40000111U;
    public const uint SdlkAcOpen = 0x40000112U;
    public const uint SdlkAcClose = 0x40000113U;
    public const uint SdlkAcExit = 0x40000114U;
    public const uint SdlkAcSave = 0x40000115U;
    public const uint SdlkAcPrint = 0x40000116U;
    public const uint SdlkAcProperties = 0x40000117U;
    public const uint SdlkAcSearch = 0x40000118U;
    public const uint SdlkAcHome = 0x40000119U;
    public const uint SdlkAcBack = 0x4000011aU;
    public const uint SdlkAcForward = 0x4000011bU;
    public const uint SdlkAcStop = 0x4000011cU;
    public const uint SdlkAcRefresh = 0x4000011dU;
    public const uint SdlkAcBookmarks = 0x4000011eU;
    public const uint SdlkSoftleft = 0x4000011fU;
    public const uint SdlkSoftright = 0x40000120U;
    public const uint SdlkCall = 0x40000121U;
    public const uint SdlkEndcall = 0x40000122U;
    public const uint SdlkLeftTab = 0x20000001U;
    public const uint SdlkLevel5Shift = 0x20000002U;
    public const uint SdlkMultiKeyCompose = 0x20000003U;
    public const uint SdlkLmeta = 0x20000004U;
    public const uint SdlkRmeta = 0x20000005U;
    public const uint SdlkLhyper = 0x20000006U;
    public const uint SdlkRhyper = 0x20000007U;
    public const uint KmodNone = 0x0000U;
    public const uint KmodLshift = 0x0001U;
    public const uint KmodRshift = 0x0002U;
    public const uint KmodLevel5 = 0x0004U;
    public const uint KmodLctrl = 0x0040U;
    public const uint KmodRctrl = 0x0080U;
    public const uint KmodLalt = 0x0100U;
    public const uint KmodRalt = 0x0200U;
    public const uint KmodLgui = 0x0400U;
    public const uint KmodRgui = 0x0800U;
    public const uint KmodNum = 0x1000U;
    public const uint KmodCaps = 0x2000U;
    public const uint KmodMode = 0x4000U;
    public const uint KmodScroll = 0x8000U;
    public const uint KmodCtrl = (0x0040U | 0x0080U);
    public const uint KmodShift = (0x0001U | 0x0002U);
    public const uint KmodAlt = (0x0100U | 0x0200U);
    public const uint KmodGui = (0x0400U | 0x0800U);
    public const uint MessageboxError = 0x00000010U;
    public const uint MessageboxWarning = 0x00000020U;
    public const uint MessageboxInformation = 0x00000040U;
    public const uint MessageboxButtonsLeftToRight = 0x00000080U;
    public const uint MessageboxButtonsRightToLeft = 0x00000100U;
    public const uint MessageboxButtonReturnkeyDefault = 0x00000001U;
    public const uint MessageboxButtonEscapekeyDefault = 0x00000002U;
    public const int ButtonLeft = 1;
    public const int ButtonMiddle = 2;
    public const int ButtonRight = 3;
    public const int ButtonX1 = 4;
    public const int ButtonX2 = 5;
    public const uint ButtonLmask = (1U << ((1) - 1));
    public const uint ButtonMmask = (1U << ((2) - 1));
    public const uint ButtonRmask = (1U << ((3) - 1));
    public const uint ButtonX1mask = (1U << ((4) - 1));
    public const uint ButtonX2mask = (1U << ((5) - 1));
    public const uint PenInputDown = (1U << 0);
    public const uint PenInputButton1 = (1U << 1);
    public const uint PenInputButton2 = (1U << 2);
    public const uint PenInputButton3 = (1U << 3);
    public const uint PenInputButton4 = (1U << 4);
    public const uint PenInputButton5 = (1U << 5);
    public const uint PenInputEraserTip = (1U << 30);
    public const uint PenInputInProximity = (1U << 31);
    public const int AlphaOpaque = 255;
    public const float AlphaOpaqueFloat = 1.0f;
    public const int AlphaTransparent = 0;
    public const float AlphaTransparentFloat = 0.0f;
    public const string PropProcessCreateArgsPointer = "SDL.process.create.args";
    public const string PropProcessCreateEnvironmentPointer = "SDL.process.create.environment";
    public const string PropProcessCreateWorkingDirectoryString = "SDL.process.create.working_directory";
    public const string PropProcessCreateStdinNumber = "SDL.process.create.stdin_option";
    public const string PropProcessCreateStdinPointer = "SDL.process.create.stdin_source";
    public const string PropProcessCreateStdoutNumber = "SDL.process.create.stdout_option";
    public const string PropProcessCreateStdoutPointer = "SDL.process.create.stdout_source";
    public const string PropProcessCreateStderrNumber = "SDL.process.create.stderr_option";
    public const string PropProcessCreateStderrPointer = "SDL.process.create.stderr_source";
    public const string PropProcessCreateStderrToStdoutBoolean = "SDL.process.create.stderr_to_stdout";
    public const string PropProcessCreateBackgroundBoolean = "SDL.process.create.background";
    public const string PropProcessCreateCmdlineString = "SDL.process.create.cmdline";
    public const string PropProcessPidNumber = "SDL.process.pid";
    public const string PropProcessStdinPointer = "SDL.process.stdin";
    public const string PropProcessStdoutPointer = "SDL.process.stdout";
    public const string PropProcessStderrPointer = "SDL.process.stderr";
    public const string PropProcessBackgroundBoolean = "SDL.process.background";
    public const string PropNameString = "SDL.name";
    public const string SoftwareRenderer = "software";
    public const string GpuRenderer = "gpu";
    public const string PropRendererCreateNameString = "SDL.renderer.create.name";
    public const string PropRendererCreateWindowPointer = "SDL.renderer.create.window";
    public const string PropRendererCreateSurfacePointer = "SDL.renderer.create.surface";
    public const string PropRendererCreateOutputColorspaceNumber = "SDL.renderer.create.output_colorspace";
    public const string PropRendererCreatePresentVsyncNumber = "SDL.renderer.create.present_vsync";
    public const string PropRendererCreateGpuDevicePointer = "SDL.renderer.create.gpu.device";
    public const string PropRendererCreateGpuShadersSpirvBoolean = "SDL.renderer.create.gpu.shaders_spirv";
    public const string PropRendererCreateGpuShadersDxilBoolean = "SDL.renderer.create.gpu.shaders_dxil";
    public const string PropRendererCreateGpuShadersMslBoolean = "SDL.renderer.create.gpu.shaders_msl";
    public const string PropRendererCreateVulkanInstancePointer = "SDL.renderer.create.vulkan.instance";
    public const string PropRendererCreateVulkanSurfaceNumber = "SDL.renderer.create.vulkan.surface";
    public const string PropRendererCreateVulkanPhysicalDevicePointer = "SDL.renderer.create.vulkan.physical_device";
    public const string PropRendererCreateVulkanDevicePointer = "SDL.renderer.create.vulkan.device";
    public const string PropRendererCreateVulkanGraphicsQueueFamilyIndexNumber = "SDL.renderer.create.vulkan.graphics_queue_family_index";
    public const string PropRendererCreateVulkanPresentQueueFamilyIndexNumber = "SDL.renderer.create.vulkan.present_queue_family_index";
    public const string PropRendererNameString = "SDL.renderer.name";
    public const string PropRendererWindowPointer = "SDL.renderer.window";
    public const string PropRendererSurfacePointer = "SDL.renderer.surface";
    public const string PropRendererVsyncNumber = "SDL.renderer.vsync";
    public const string PropRendererMaxTextureSizeNumber = "SDL.renderer.max_texture_size";
    public const string PropRendererTextureFormatsPointer = "SDL.renderer.texture_formats";
    public const string PropRendererTextureWrappingBoolean = "SDL.renderer.texture_wrapping";
    public const string PropRendererOutputColorspaceNumber = "SDL.renderer.output_colorspace";
    public const string PropRendererHdrEnabledBoolean = "SDL.renderer.HDR_enabled";
    public const string PropRendererSdrWhitePointFloat = "SDL.renderer.SDR_white_point";
    public const string PropRendererHdrHeadroomFloat = "SDL.renderer.HDR_headroom";
    public const string PropRendererD3d9DevicePointer = "SDL.renderer.d3d9.device";
    public const string PropRendererD3d11DevicePointer = "SDL.renderer.d3d11.device";
    public const string PropRendererD3d11SwapchainPointer = "SDL.renderer.d3d11.swap_chain";
    public const string PropRendererD3d12DevicePointer = "SDL.renderer.d3d12.device";
    public const string PropRendererD3d12SwapchainPointer = "SDL.renderer.d3d12.swap_chain";
    public const string PropRendererD3d12CommandQueuePointer = "SDL.renderer.d3d12.command_queue";
    public const string PropRendererVulkanInstancePointer = "SDL.renderer.vulkan.instance";
    public const string PropRendererVulkanSurfaceNumber = "SDL.renderer.vulkan.surface";
    public const string PropRendererVulkanPhysicalDevicePointer = "SDL.renderer.vulkan.physical_device";
    public const string PropRendererVulkanDevicePointer = "SDL.renderer.vulkan.device";
    public const string PropRendererVulkanGraphicsQueueFamilyIndexNumber = "SDL.renderer.vulkan.graphics_queue_family_index";
    public const string PropRendererVulkanPresentQueueFamilyIndexNumber = "SDL.renderer.vulkan.present_queue_family_index";
    public const string PropRendererVulkanSwapchainImageCountNumber = "SDL.renderer.vulkan.swapchain_image_count";
    public const string PropRendererGpuDevicePointer = "SDL.renderer.gpu.device";
    public const string PropTextureCreateColorspaceNumber = "SDL.texture.create.colorspace";
    public const string PropTextureCreateFormatNumber = "SDL.texture.create.format";
    public const string PropTextureCreateAccessNumber = "SDL.texture.create.access";
    public const string PropTextureCreateWidthNumber = "SDL.texture.create.width";
    public const string PropTextureCreateHeightNumber = "SDL.texture.create.height";
    public const string PropTextureCreatePalettePointer = "SDL.texture.create.palette";
    public const string PropTextureCreateSdrWhitePointFloat = "SDL.texture.create.SDR_white_point";
    public const string PropTextureCreateHdrHeadroomFloat = "SDL.texture.create.HDR_headroom";
    public const string PropTextureCreateD3d11TexturePointer = "SDL.texture.create.d3d11.texture";
    public const string PropTextureCreateD3d11TextureUPointer = "SDL.texture.create.d3d11.texture_u";
    public const string PropTextureCreateD3d11TextureVPointer = "SDL.texture.create.d3d11.texture_v";
    public const string PropTextureCreateD3d12TexturePointer = "SDL.texture.create.d3d12.texture";
    public const string PropTextureCreateD3d12TextureUPointer = "SDL.texture.create.d3d12.texture_u";
    public const string PropTextureCreateD3d12TextureVPointer = "SDL.texture.create.d3d12.texture_v";
    public const string PropTextureCreateMetalPixelbufferPointer = "SDL.texture.create.metal.pixelbuffer";
    public const string PropTextureCreateOpenglTextureNumber = "SDL.texture.create.opengl.texture";
    public const string PropTextureCreateOpenglTextureUvNumber = "SDL.texture.create.opengl.texture_uv";
    public const string PropTextureCreateOpenglTextureUNumber = "SDL.texture.create.opengl.texture_u";
    public const string PropTextureCreateOpenglTextureVNumber = "SDL.texture.create.opengl.texture_v";
    public const string PropTextureCreateOpengles2TextureNumber = "SDL.texture.create.opengles2.texture";
    public const string PropTextureCreateOpengles2TextureUvNumber = "SDL.texture.create.opengles2.texture_uv";
    public const string PropTextureCreateOpengles2TextureUNumber = "SDL.texture.create.opengles2.texture_u";
    public const string PropTextureCreateOpengles2TextureVNumber = "SDL.texture.create.opengles2.texture_v";
    public const string PropTextureCreateVulkanTextureNumber = "SDL.texture.create.vulkan.texture";
    public const string PropTextureCreateVulkanLayoutNumber = "SDL.texture.create.vulkan.layout";
    public const string PropTextureCreateGpuTexturePointer = "SDL.texture.create.gpu.texture";
    public const string PropTextureCreateGpuTextureUvPointer = "SDL.texture.create.gpu.texture_uv";
    public const string PropTextureCreateGpuTextureUPointer = "SDL.texture.create.gpu.texture_u";
    public const string PropTextureCreateGpuTextureVPointer = "SDL.texture.create.gpu.texture_v";
    public const string PropTextureColorspaceNumber = "SDL.texture.colorspace";
    public const string PropTextureFormatNumber = "SDL.texture.format";
    public const string PropTextureAccessNumber = "SDL.texture.access";
    public const string PropTextureWidthNumber = "SDL.texture.width";
    public const string PropTextureHeightNumber = "SDL.texture.height";
    public const string PropTextureSdrWhitePointFloat = "SDL.texture.SDR_white_point";
    public const string PropTextureHdrHeadroomFloat = "SDL.texture.HDR_headroom";
    public const string PropTextureD3d11TexturePointer = "SDL.texture.d3d11.texture";
    public const string PropTextureD3d11TextureUPointer = "SDL.texture.d3d11.texture_u";
    public const string PropTextureD3d11TextureVPointer = "SDL.texture.d3d11.texture_v";
    public const string PropTextureD3d12TexturePointer = "SDL.texture.d3d12.texture";
    public const string PropTextureD3d12TextureUPointer = "SDL.texture.d3d12.texture_u";
    public const string PropTextureD3d12TextureVPointer = "SDL.texture.d3d12.texture_v";
    public const string PropTextureOpenglTextureNumber = "SDL.texture.opengl.texture";
    public const string PropTextureOpenglTextureUvNumber = "SDL.texture.opengl.texture_uv";
    public const string PropTextureOpenglTextureUNumber = "SDL.texture.opengl.texture_u";
    public const string PropTextureOpenglTextureVNumber = "SDL.texture.opengl.texture_v";
    public const string PropTextureOpenglTextureTargetNumber = "SDL.texture.opengl.target";
    public const string PropTextureOpenglTexWFloat = "SDL.texture.opengl.tex_w";
    public const string PropTextureOpenglTexHFloat = "SDL.texture.opengl.tex_h";
    public const string PropTextureOpengles2TextureNumber = "SDL.texture.opengles2.texture";
    public const string PropTextureOpengles2TextureUvNumber = "SDL.texture.opengles2.texture_uv";
    public const string PropTextureOpengles2TextureUNumber = "SDL.texture.opengles2.texture_u";
    public const string PropTextureOpengles2TextureVNumber = "SDL.texture.opengles2.texture_v";
    public const string PropTextureOpengles2TextureTargetNumber = "SDL.texture.opengles2.target";
    public const string PropTextureVulkanTextureNumber = "SDL.texture.vulkan.texture";
    public const string PropTextureGpuTexturePointer = "SDL.texture.gpu.texture";
    public const string PropTextureGpuTextureUvPointer = "SDL.texture.gpu.texture_uv";
    public const string PropTextureGpuTextureUPointer = "SDL.texture.gpu.texture_u";
    public const string PropTextureGpuTextureVPointer = "SDL.texture.gpu.texture_v";
    public const int RendererVsyncDisabled = 0;
    public const int RendererVsyncAdaptive = (-1);
    public const int DebugTextFontCharacterSize = 8;
    public const string Revision = "";
    public const float StandardGravity = 9.80665f;
    public const uint SurfacePreallocated = 0x00000001U;
    public const uint SurfaceLockNeeded = 0x00000002U;
    public const uint SurfaceLocked = 0x00000004U;
    public const uint SurfaceSimdAligned = 0x00000008U;
    public const string PropSurfaceSdrWhitePointFloat = "SDL.surface.SDR_white_point";
    public const string PropSurfaceHdrHeadroomFloat = "SDL.surface.HDR_headroom";
    public const string PropSurfaceTonemapOperatorString = "SDL.surface.tonemap";
    public const string PropSurfaceHotspotXNumber = "SDL.surface.hotspot.x";
    public const string PropSurfaceHotspotYNumber = "SDL.surface.hotspot.y";
    public const string PropSurfaceRotationFloat = "SDL.surface.rotation";
    public const string PropThreadCreateEntryFunctionPointer = "SDL.thread.create.entry_function";
    public const string PropThreadCreateNameString = "SDL.thread.create.name";
    public const string PropThreadCreateUserdataPointer = "SDL.thread.create.userdata";
    public const string PropThreadCreateStacksizeNumber = "SDL.thread.create.stacksize";
    public const int MsPerSecond = 1000;
    public const int UsPerSecond = 1000000;
    public const long NsPerSecond = 1000000000L;
    public const int NsPerMs = 1000000;
    public const int NsPerUs = 1000;
    public const uint TrayentryButton = 0x00000001U;
    public const uint TrayentryCheckbox = 0x00000002U;
    public const uint TrayentrySubmenu = 0x00000004U;
    public const uint TrayentryDisabled = 0x80000000U;
    public const uint TrayentryChecked = 0x40000000U;
    public const int MajorVersion = 3;
    public const int MinorVersion = 4;
    public const int MicroVersion = 12;
    public const int Version = ((3) * 1000000 + (4) * 1000 + (12));
    public const string PropGlobalVideoWaylandWlDisplayPointer = "SDL.video.wayland.wl_display";
    public const uint WindowposUndefinedMask = 0x1FFF0000U;
    public const uint WindowposUndefined = (0x1FFF0000U | (0));
    public const uint WindowposCenteredMask = 0x2FFF0000U;
    public const uint WindowposCentered = (0x2FFF0000U | (0));
    public const int GlContextProfileCore = 0x0001;
    public const int GlContextProfileCompatibility = 0x0002;
    public const int GlContextProfileEs = 0x0004;
    public const int GlContextDebugFlag = 0x0001;
    public const int GlContextForwardCompatibleFlag = 0x0002;
    public const int GlContextRobustAccessFlag = 0x0004;
    public const int GlContextResetIsolationFlag = 0x0008;
    public const int GlContextReleaseBehaviorNone = 0x0000;
    public const int GlContextReleaseBehaviorFlush = 0x0001;
    public const int GlContextResetNoNotification = 0x0000;
    public const int GlContextResetLoseContext = 0x0001;
    public const string PropDisplayHdrEnabledBoolean = "SDL.display.HDR_enabled";
    public const string PropDisplayKmsdrmPanelOrientationNumber = "SDL.display.KMSDRM.panel_orientation";
    public const string PropDisplayWaylandWlOutputPointer = "SDL.display.wayland.wl_output";
    public const string PropDisplayWindowsHmonitorPointer = "SDL.display.windows.hmonitor";
    public const string PropWindowCreateAlwaysOnTopBoolean = "SDL.window.create.always_on_top";
    public const string PropWindowCreateBorderlessBoolean = "SDL.window.create.borderless";
    public const string PropWindowCreateConstrainPopupBoolean = "SDL.window.create.constrain_popup";
    public const string PropWindowCreateFocusableBoolean = "SDL.window.create.focusable";
    public const string PropWindowCreateExternalGraphicsContextBoolean = "SDL.window.create.external_graphics_context";
    public const string PropWindowCreateFlagsNumber = "SDL.window.create.flags";
    public const string PropWindowCreateFullscreenBoolean = "SDL.window.create.fullscreen";
    public const string PropWindowCreateHeightNumber = "SDL.window.create.height";
    public const string PropWindowCreateHiddenBoolean = "SDL.window.create.hidden";
    public const string PropWindowCreateHighPixelDensityBoolean = "SDL.window.create.high_pixel_density";
    public const string PropWindowCreateMaximizedBoolean = "SDL.window.create.maximized";
    public const string PropWindowCreateMenuBoolean = "SDL.window.create.menu";
    public const string PropWindowCreateMetalBoolean = "SDL.window.create.metal";
    public const string PropWindowCreateMinimizedBoolean = "SDL.window.create.minimized";
    public const string PropWindowCreateModalBoolean = "SDL.window.create.modal";
    public const string PropWindowCreateMouseGrabbedBoolean = "SDL.window.create.mouse_grabbed";
    public const string PropWindowCreateOpenglBoolean = "SDL.window.create.opengl";
    public const string PropWindowCreateParentPointer = "SDL.window.create.parent";
    public const string PropWindowCreateResizableBoolean = "SDL.window.create.resizable";
    public const string PropWindowCreateTitleString = "SDL.window.create.title";
    public const string PropWindowCreateTransparentBoolean = "SDL.window.create.transparent";
    public const string PropWindowCreateTooltipBoolean = "SDL.window.create.tooltip";
    public const string PropWindowCreateUtilityBoolean = "SDL.window.create.utility";
    public const string PropWindowCreateVulkanBoolean = "SDL.window.create.vulkan";
    public const string PropWindowCreateWidthNumber = "SDL.window.create.width";
    public const string PropWindowCreateXNumber = "SDL.window.create.x";
    public const string PropWindowCreateYNumber = "SDL.window.create.y";
    public const string PropWindowCreateCocoaWindowPointer = "SDL.window.create.cocoa.window";
    public const string PropWindowCreateCocoaViewPointer = "SDL.window.create.cocoa.view";
    public const string PropWindowCreateWindowscenePointer = "SDL.window.create.uikit.windowscene";
    public const string PropWindowCreateWaylandSurfaceRoleCustomBoolean = "SDL.window.create.wayland.surface_role_custom";
    public const string PropWindowCreateWaylandCreateEglWindowBoolean = "SDL.window.create.wayland.create_egl_window";
    public const string PropWindowCreateWaylandWlSurfacePointer = "SDL.window.create.wayland.wl_surface";
    public const string PropWindowCreateWin32HwndPointer = "SDL.window.create.win32.hwnd";
    public const string PropWindowCreateWin32PixelFormatHwndPointer = "SDL.window.create.win32.pixel_format_hwnd";
    public const string PropWindowCreateX11WindowNumber = "SDL.window.create.x11.window";
    public const string PropWindowCreateEmscriptenCanvasIdString = "SDL.window.create.emscripten.canvas_id";
    public const string PropWindowCreateEmscriptenKeyboardElementString = "SDL.window.create.emscripten.keyboard_element";
    public const string PropWindowShapePointer = "SDL.window.shape";
    public const string PropWindowHdrEnabledBoolean = "SDL.window.HDR_enabled";
    public const string PropWindowSdrWhiteLevelFloat = "SDL.window.SDR_white_level";
    public const string PropWindowHdrHeadroomFloat = "SDL.window.HDR_headroom";
    public const string PropWindowAndroidWindowPointer = "SDL.window.android.window";
    public const string PropWindowAndroidSurfacePointer = "SDL.window.android.surface";
    public const string PropWindowUikitWindowPointer = "SDL.window.uikit.window";
    public const string PropWindowUikitMetalViewTagNumber = "SDL.window.uikit.metal_view_tag";
    public const string PropWindowUikitOpenglFramebufferNumber = "SDL.window.uikit.opengl.framebuffer";
    public const string PropWindowUikitOpenglRenderbufferNumber = "SDL.window.uikit.opengl.renderbuffer";
    public const string PropWindowUikitOpenglResolveFramebufferNumber = "SDL.window.uikit.opengl.resolve_framebuffer";
    public const string PropWindowKmsdrmDeviceIndexNumber = "SDL.window.kmsdrm.dev_index";
    public const string PropWindowKmsdrmDrmFdNumber = "SDL.window.kmsdrm.drm_fd";
    public const string PropWindowKmsdrmGbmDevicePointer = "SDL.window.kmsdrm.gbm_dev";
    public const string PropWindowCocoaWindowPointer = "SDL.window.cocoa.window";
    public const string PropWindowCocoaMetalViewTagNumber = "SDL.window.cocoa.metal_view_tag";
    public const string PropWindowOpenvrOverlayIdNumber = "SDL.window.openvr.overlay_id";
    public const string PropWindowVivanteDisplayPointer = "SDL.window.vivante.display";
    public const string PropWindowVivanteWindowPointer = "SDL.window.vivante.window";
    public const string PropWindowVivanteSurfacePointer = "SDL.window.vivante.surface";
    public const string PropWindowWin32HwndPointer = "SDL.window.win32.hwnd";
    public const string PropWindowWin32HdcPointer = "SDL.window.win32.hdc";
    public const string PropWindowWin32InstancePointer = "SDL.window.win32.instance";
    public const string PropWindowWaylandDisplayPointer = "SDL.window.wayland.display";
    public const string PropWindowWaylandSurfacePointer = "SDL.window.wayland.surface";
    public const string PropWindowWaylandViewportPointer = "SDL.window.wayland.viewport";
    public const string PropWindowWaylandEglWindowPointer = "SDL.window.wayland.egl_window";
    public const string PropWindowWaylandXdgSurfacePointer = "SDL.window.wayland.xdg_surface";
    public const string PropWindowWaylandXdgToplevelPointer = "SDL.window.wayland.xdg_toplevel";
    public const string PropWindowWaylandXdgToplevelExportHandleString = "SDL.window.wayland.xdg_toplevel_export_handle";
    public const string PropWindowWaylandXdgPopupPointer = "SDL.window.wayland.xdg_popup";
    public const string PropWindowWaylandXdgPositionerPointer = "SDL.window.wayland.xdg_positioner";
    public const string PropWindowX11DisplayPointer = "SDL.window.x11.display";
    public const string PropWindowX11ScreenNumber = "SDL.window.x11.screen";
    public const string PropWindowX11WindowNumber = "SDL.window.x11.window";
    public const string PropWindowEmscriptenCanvasIdString = "SDL.window.emscripten.canvas_id";
    public const string PropWindowEmscriptenKeyboardElementString = "SDL.window.emscripten.keyboard_element";

    [LibraryImport(LibraryName, EntryPoint = "SDL_AsyncIOFromFile")]
    public static partial AsyncIO AsyncIOFromFile([MarshalAs(UnmanagedType.LPStr)] string file, [MarshalAs(UnmanagedType.LPStr)] string mode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAsyncIOSize")]
    public static partial long GetAsyncIOSize(AsyncIO asyncio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadAsyncIO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadAsyncIO(AsyncIO asyncio, void* ptr, ulong offset, ulong size, AsyncIOQueue queue, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteAsyncIO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteAsyncIO(AsyncIO asyncio, void* ptr, ulong offset, ulong size, AsyncIOQueue queue, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseAsyncIO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CloseAsyncIO(AsyncIO asyncio, byte flush, AsyncIOQueue queue, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateAsyncIOQueue")]
    public static partial AsyncIOQueue CreateAsyncIOQueue();

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyAsyncIOQueue")]
    public static partial void DestroyAsyncIOQueue(AsyncIOQueue queue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAsyncIOResult")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetAsyncIOResult(AsyncIOQueue queue, AsyncIOOutcome* outcome);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitAsyncIOResult")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitAsyncIOResult(AsyncIOQueue queue, AsyncIOOutcome* outcome, int timeoutms);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SignalAsyncIOQueue")]
    public static partial void SignalAsyncIOQueue(AsyncIOQueue queue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadFileAsync")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LoadFileAsync([MarshalAs(UnmanagedType.LPStr)] string file, AsyncIOQueue queue, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TryLockSpinlock")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TryLockSpinlock(int* @lock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockSpinlock")]
    public static partial void LockSpinlock(int* @lock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockSpinlock")]
    public static partial void UnlockSpinlock(int* @lock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
    public static partial void MemoryBarrierReleaseFunction();

    [LibraryImport(LibraryName, EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
    public static partial void MemoryBarrierAcquireFunction();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicInt")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAtomicInt")]
    public static partial int SetAtomicInt(AtomicInt* a, int v);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAtomicInt")]
    public static partial int GetAtomicInt(AtomicInt* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddAtomicInt")]
    public static partial int AddAtomicInt(AtomicInt* a, int v);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicU32")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CompareAndSwapAtomicU32(AtomicU32* a, uint oldval, uint newval);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAtomicU32")]
    public static partial uint SetAtomicU32(AtomicU32* a, uint v);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAtomicU32")]
    public static partial uint GetAtomicU32(AtomicU32* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddAtomicU32")]
    public static partial uint AddAtomicU32(AtomicU32* a, int v);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAtomicPointer")]
    public static partial void* SetAtomicPointer(void** a, void* v);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAtomicPointer")]
    public static partial void* GetAtomicPointer(void** a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumAudioDrivers")]
    public static partial int GetNumAudioDrivers();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetAudioDriver(int index);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentAudioDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCurrentAudioDriver();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioPlaybackDevices")]
    public static partial uint* GetAudioPlaybackDevices(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioRecordingDevices")]
    public static partial uint* GetAudioRecordingDevices(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetAudioDeviceName(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetAudioDeviceFormat(uint devid, AudioSpec* spec, int* sampleFrames);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceChannelMap")]
    public static partial int* GetAudioDeviceChannelMap(uint devid, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenAudioDevice")]
    public static partial uint OpenAudioDevice(uint devid, AudioSpec* spec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePhysical")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsAudioDevicePhysical(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePlayback")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsAudioDevicePlayback(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PauseAudioDevice")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PauseAudioDevice(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResumeAudioDevice")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ResumeAudioDevice(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AudioDevicePaused")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AudioDevicePaused(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceGain")]
    public static partial float GetAudioDeviceGain(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioDeviceGain")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioDeviceGain(uint devid, float gain);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseAudioDevice")]
    public static partial void CloseAudioDevice(uint devid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindAudioStreams")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BindAudioStreams(uint devid, AudioStream streams, int numStreams);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindAudioStream")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BindAudioStream(uint devid, AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnbindAudioStreams")]
    public static partial void UnbindAudioStreams(AudioStream streams, int numStreams);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnbindAudioStream")]
    public static partial void UnbindAudioStream(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamDevice")]
    public static partial uint GetAudioStreamDevice(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateAudioStream")]
    public static partial AudioStream CreateAudioStream(AudioSpec* srcSpec, AudioSpec* dstSpec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamProperties")]
    public static partial uint GetAudioStreamProperties(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetAudioStreamFormat(AudioStream stream, AudioSpec* srcSpec, AudioSpec* dstSpec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamFormat(AudioStream stream, AudioSpec* srcSpec, AudioSpec* dstSpec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
    public static partial float GetAudioStreamFrequencyRatio(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamFrequencyRatio(AudioStream stream, float ratio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamGain")]
    public static partial float GetAudioStreamGain(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGain")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamGain(AudioStream stream, float gain);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
    public static partial int* GetAudioStreamInputChannelMap(AudioStream stream, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
    public static partial int* GetAudioStreamOutputChannelMap(AudioStream stream, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamInputChannelMap(AudioStream stream, int* chmap, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamOutputChannelMap(AudioStream stream, int* chmap, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PutAudioStreamData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PutAudioStreamData(AudioStream stream, void* buf, int len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PutAudioStreamDataNoCopy")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PutAudioStreamDataNoCopy(AudioStream stream, void* buf, int len, delegate* unmanaged[Cdecl]<void*, void*, int, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PutAudioStreamPlanarData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PutAudioStreamPlanarData(AudioStream stream, void** channelBuffers, int numChannels, int numSamples);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamData")]
    public static partial int GetAudioStreamData(AudioStream stream, void* buf, int len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamAvailable")]
    public static partial int GetAudioStreamAvailable(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamQueued")]
    public static partial int GetAudioStreamQueued(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlushAudioStream")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FlushAudioStream(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearAudioStream")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearAudioStream(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PauseAudioStreamDevice")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PauseAudioStreamDevice(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResumeAudioStreamDevice")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ResumeAudioStreamDevice(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AudioStreamDevicePaused")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AudioStreamDevicePaused(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockAudioStream")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LockAudioStream(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockAudioStream")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UnlockAudioStream(AudioStream stream);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGetCallback")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamGetCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamPutCallback")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioStreamPutCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyAudioStream")]
    public static partial void DestroyAudioStream(AudioStream stream);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenAudioDeviceStream")]
    public static partial AudioStream OpenAudioDeviceStream(uint devid, AudioSpec* spec, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioPostmixCallback")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAudioPostmixCallback(uint devid, delegate* unmanaged[Cdecl]<void*, SDL_AudioSpec*, float*, int, void> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadWAV_IO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LoadWAVIO(IOStream src, byte closeio, AudioSpec* spec, byte** audioBuf, uint* audioLen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadWAV")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LoadWAV([MarshalAs(UnmanagedType.LPStr)] string path, AudioSpec* spec, byte** audioBuf, uint* audioLen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MixAudio")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MixAudio(byte* dst, byte* src, AudioFormat format, uint len, float volume);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertAudioSamples")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ConvertAudioSamples(AudioSpec* srcSpec, byte* srcData, int srcLen, AudioSpec* dstSpec, byte** dstData, int* dstLen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioFormatName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetAudioFormatName(AudioFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSilenceValueForFormat")]
    public static partial int GetSilenceValueForFormat(AudioFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MostSignificantBitIndex32")]
    public static partial int MostSignificantBitIndex32(uint x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasExactlyOneBitSet32")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasExactlyOneBitSet32(uint x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ComposeCustomBlendMode")]
    public static partial uint ComposeCustomBlendMode(BlendFactor srccolorfactor, BlendFactor dstcolorfactor, BlendOperation coloroperation, BlendFactor srcalphafactor, BlendFactor dstalphafactor, BlendOperation alphaoperation);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumCameraDrivers")]
    public static partial int GetNumCameraDrivers();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCameraDriver(int index);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentCameraDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCurrentCameraDriver();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameras")]
    public static partial uint* GetCameras(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraSupportedFormats")]
    public static partial CameraSpec** GetCameraSupportedFormats(uint instanceId, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCameraName(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraPosition")]
    public static partial CameraPosition GetCameraPosition(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenCamera")]
    public static partial Camera OpenCamera(uint instanceId, CameraSpec* spec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraPermissionState")]
    public static partial CameraPermissionState GetCameraPermissionState(Camera camera);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraID")]
    public static partial uint GetCameraID(Camera camera);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraProperties")]
    public static partial uint GetCameraProperties(Camera camera);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCameraFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetCameraFormat(Camera camera, CameraSpec* spec);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AcquireCameraFrame")]
    public static partial Surface* AcquireCameraFrame(Camera camera, ulong* timestampns);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseCameraFrame")]
    public static partial void ReleaseCameraFrame(Camera camera, Surface* frame);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseCamera")]
    public static partial void CloseCamera(Camera camera);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetClipboardText")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetClipboardText([MarshalAs(UnmanagedType.LPStr)] string text);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetClipboardText")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetClipboardText();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasClipboardText")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasClipboardText();

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetPrimarySelectionText")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetPrimarySelectionText([MarshalAs(UnmanagedType.LPStr)] string text);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimarySelectionText")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetPrimarySelectionText();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasPrimarySelectionText")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasPrimarySelectionText();

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetClipboardData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetClipboardData(delegate* unmanaged[Cdecl]<void*, sbyte*, nuint*, void*> callback, delegate* unmanaged[Cdecl]<void*, void> cleanup, void* userdata, sbyte** mimeTypes, nuint numMimeTypes);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearClipboardData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearClipboardData();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetClipboardData")]
    public static partial void* GetClipboardData([MarshalAs(UnmanagedType.LPStr)] string mimeType, nuint* size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasClipboardData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasClipboardData([MarshalAs(UnmanagedType.LPStr)] string mimeType);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetClipboardMimeTypes")]
    public static partial sbyte** GetClipboardMimeTypes(nuint* numMimeTypes);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumLogicalCPUCores")]
    public static partial int GetNumLogicalCPUCores();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCPUCacheLineSize")]
    public static partial int GetCPUCacheLineSize();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasAltiVec")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasAltiVec();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasMMX")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasMMX();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasSSE();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE2")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasSSE2();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE3")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasSSE3();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE41")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasSSE41();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasSSE42")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasSSE42();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasAVX();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX2")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasAVX2();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasAVX512F")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasAVX512F();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasARMSIMD")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasARMSIMD();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasNEON")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasNEON();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasLSX")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasLSX();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasLASX")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasLASX();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemRAM")]
    public static partial int GetSystemRAM();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSIMDAlignment")]
    public static partial nuint GetSIMDAlignment();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemPageSize")]
    public static partial int GetSystemPageSize();

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowOpenFileDialog")]
    public static partial void ShowOpenFileDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, DialogFileFilter* filters, int nfilters, [MarshalAs(UnmanagedType.LPStr)] string defaultLocation, byte allowMany);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowSaveFileDialog")]
    public static partial void ShowSaveFileDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, DialogFileFilter* filters, int nfilters, [MarshalAs(UnmanagedType.LPStr)] string defaultLocation);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowOpenFolderDialog")]
    public static partial void ShowOpenFolderDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, [MarshalAs(UnmanagedType.LPStr)] string defaultLocation, byte allowMany);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowFileDialogWithProperties")]
    public static partial void ShowFileDialogWithProperties(FileDialogType type, delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, uint props);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetError")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetError([MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetErrorV")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetErrorV([MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_OutOfMemory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool OutOfMemory();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetError")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetError();

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearError")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearError();

    [LibraryImport(LibraryName, EntryPoint = "SDL_PumpEvents")]
    public static partial void PumpEvents();

    [LibraryImport(LibraryName, EntryPoint = "SDL_PeepEvents")]
    public static partial int PeepEvents(Event* events, int numevents, EventAction action, uint mintype, uint maxtype);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasEvent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasEvent(uint type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasEvents")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasEvents(uint mintype, uint maxtype);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlushEvent")]
    public static partial void FlushEvent(uint type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlushEvents")]
    public static partial void FlushEvents(uint mintype, uint maxtype);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PollEvent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PollEvent(Event* @event);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitEvent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitEvent(Event* @event);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitEventTimeout")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitEventTimeout(Event* @event, int timeoutms);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PushEvent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PushEvent(Event* @event);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetEventFilter")]
    public static partial void SetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetEventFilter")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, by**** filter, void** userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddEventWatch")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AddEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveEventWatch")]
    public static partial void RemoveEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FilterEvents")]
    public static partial void FilterEvents(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetEventEnabled")]
    public static partial void SetEventEnabled(uint type, byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EventEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EventEnabled(uint type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RegisterEvents")]
    public static partial uint RegisterEvents(int numevents);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFromEvent")]
    public static partial Window GetWindowFromEvent(Event* @event);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetEventDescription")]
    public static partial int GetEventDescription(Event* @event, [MarshalAs(UnmanagedType.LPStr)] string buf, int buflen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetBasePath")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetBasePath();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPrefPath")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetPrefPath([MarshalAs(UnmanagedType.LPStr)] string org, [MarshalAs(UnmanagedType.LPStr)] string app);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetUserFolder")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetUserFolder(Folder folder);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CreateDirectory([MarshalAs(UnmanagedType.LPStr)] string path);

    /*todo [LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnumerateDirectory([MarshalAs(UnmanagedType.LPStr)] string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemovePath")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RemovePath([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenamePath")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenamePath([MarshalAs(UnmanagedType.LPStr)] string oldpath, [MarshalAs(UnmanagedType.LPStr)] string newpath);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CopyFile")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CopyFile([MarshalAs(UnmanagedType.LPStr)] string oldpath, [MarshalAs(UnmanagedType.LPStr)] string newpath);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPathInfo")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetPathInfo([MarshalAs(UnmanagedType.LPStr)] string path, PathInfo* info);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GlobDirectory")]
    public static partial sbyte** GlobDirectory([MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.LPStr)] string pattern, uint flags, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDirectory")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCurrentDirectory();

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddGamepadMapping")]
    public static partial int AddGamepadMapping([MarshalAs(UnmanagedType.LPStr)] string mapping);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    public static partial int AddGamepadMappingsFromIO(IOStream src, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromFile")]
    public static partial int AddGamepadMappingsFromFile([MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReloadGamepadMappings")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReloadGamepadMappings();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappings")]
    public static partial sbyte** GetGamepadMappings(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForGUID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadMappingForGUID(GUID guid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMapping")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadMapping(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadMapping")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGamepadMapping(uint instanceId, [MarshalAs(UnmanagedType.LPStr)] string mapping);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasGamepad")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasGamepad();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepads")]
    public static partial uint* GetGamepads(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsGamepad")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsGamepad(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPathForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadPathForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
    public static partial int GetGamepadPlayerIndexForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadGUIDForID")]
    public static partial GUID GetGamepadGUIDForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadVendorForID")]
    public static partial ushort GetGamepadVendorForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductForID")]
    public static partial ushort GetGamepadProductForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersionForID")]
    public static partial ushort GetGamepadProductVersionForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeForID")]
    public static partial GamepadType GetGamepadTypeForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRealGamepadTypeForID")]
    public static partial GamepadType GetRealGamepadTypeForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadMappingForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenGamepad")]
    public static partial Gamepad OpenGamepad(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFromID")]
    public static partial Gamepad GetGamepadFromID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
    public static partial Gamepad GetGamepadFromPlayerIndex(int playerIndex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProperties")]
    public static partial uint GetGamepadProperties(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadID")]
    public static partial uint GetGamepadID(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadName(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPath")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadPath(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadType")]
    public static partial GamepadType GetGamepadType(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRealGamepadType")]
    public static partial GamepadType GetRealGamepadType(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndex")]
    public static partial int GetGamepadPlayerIndex(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadPlayerIndex")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGamepadPlayerIndex(Gamepad gamepad, int playerIndex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadVendor")]
    public static partial ushort GetGamepadVendor(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProduct")]
    public static partial ushort GetGamepadProduct(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersion")]
    public static partial ushort GetGamepadProductVersion(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadFirmwareVersion")]
    public static partial ushort GetGamepadFirmwareVersion(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSerial")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadSerial(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSteamHandle")]
    public static partial ulong GetGamepadSteamHandle(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadConnectionState")]
    public static partial JoystickConnectionState GetGamepadConnectionState(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadPowerInfo")]
    public static partial PowerState GetGamepadPowerInfo(Gamepad gamepad, int* percent);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadConnected")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadConnected(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadJoystick")]
    public static partial Joystick GetGamepadJoystick(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadEventsEnabled")]
    public static partial void SetGamepadEventsEnabled(byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadEventsEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadEventsEnabled();

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadBindings")]
    public static partial GamepadBinding** GetGamepadBindings(Gamepad gamepad, int* count);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateGamepads")]
    public static partial void UpdateGamepads();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeFromString")]
    public static partial GamepadType GetGamepadTypeFromString([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForType")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadStringForType(GamepadType type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAxisFromString")]
    public static partial GamepadAxis GetGamepadAxisFromString([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForAxis")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadStringForAxis(GamepadAxis axis);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasAxis")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadHasAxis(Gamepad gamepad, GamepadAxis axis);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAxis")]
    public static partial short GetGamepadAxis(Gamepad gamepad, GamepadAxis axis);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonFromString")]
    public static partial GamepadButton GetGamepadButtonFromString([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForButton")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadStringForButton(GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasButton")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadHasButton(Gamepad gamepad, GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButton")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetGamepadButton(Gamepad gamepad, GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabelForType")]
    public static partial GamepadButtonLabel GetGamepadButtonLabelForType(GamepadType type, GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabel")]
    public static partial GamepadButtonLabel GetGamepadButtonLabel(Gamepad gamepad, GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpads")]
    public static partial int GetNumGamepadTouchpads(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
    public static partial int GetNumGamepadTouchpadFingers(Gamepad gamepad, int touchpad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadTouchpadFinger")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetGamepadTouchpadFinger(Gamepad gamepad, int touchpad, int finger, bool* down, float* x, float* y, float* pressure);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadHasSensor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadHasSensor(Gamepad gamepad, SensorType type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadSensorEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGamepadSensorEnabled(Gamepad gamepad, SensorType type, byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GamepadSensorEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GamepadSensorEnabled(Gamepad gamepad, SensorType type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorDataRate")]
    public static partial float GetGamepadSensorDataRate(Gamepad gamepad, SensorType type);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetGamepadSensorData(Gamepad gamepad, SensorType type, float* data, int numValues);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RumbleGamepad")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RumbleGamepad(Gamepad gamepad, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RumbleGamepadTriggers")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RumbleGamepadTriggers(Gamepad gamepad, ushort leftRumble, ushort rightRumble, uint durationMs);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGamepadLED")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGamepadLED(Gamepad gamepad, byte red, byte green, byte blue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SendGamepadEffect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SendGamepadEffect(Gamepad gamepad, void* data, int size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseGamepad")]
    public static partial void CloseGamepad(Gamepad gamepad);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadAppleSFSymbolsNameForButton(Gamepad gamepad, GamepadButton button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGamepadAppleSFSymbolsNameForAxis(Gamepad gamepad, GamepadAxis axis);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUSupportsShaderFormats")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GPUSupportsShaderFormats(GPUShaderFormat formatFlags, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUSupportsProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GPUSupportsProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUDevice")]
    public static partial GPUDevice CreateGPUDevice(GPUShaderFormat formatFlags, byte debugMode, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUDeviceWithProperties")]
    public static partial GPUDevice CreateGPUDeviceWithProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyGPUDevice")]
    public static partial void DestroyGPUDevice(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumGPUDrivers")]
    public static partial int GetNumGPUDrivers();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGPUDriver(int index);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUDeviceDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetGPUDeviceDriver(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUShaderFormats")]
    public static partial GPUShaderFormat GetGPUShaderFormats(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUDeviceProperties")]
    public static partial uint GetGPUDeviceProperties(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUComputePipeline")]
    public static partial GPUComputePipeline CreateGPUComputePipeline(GPUDevice device, GPUComputePipelineCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
    public static partial GPUGraphicsPipeline CreateGPUGraphicsPipeline(GPUDevice device, GPUGraphicsPipelineCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUSampler")]
    public static partial GPUSampler CreateGPUSampler(GPUDevice device, GPUSamplerCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUShader")]
    public static partial GPUShader CreateGPUShader(GPUDevice device, GPUShaderCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUTexture")]
    public static partial GPUTexture CreateGPUTexture(GPUDevice device, GPUTextureCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUBuffer")]
    public static partial GPUBuffer CreateGPUBuffer(GPUDevice device, GPUBufferCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUTransferBuffer")]
    public static partial GPUTransferBuffer CreateGPUTransferBuffer(GPUDevice device, GPUTransferBufferCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUBufferName")]
    public static partial void SetGPUBufferName(GPUDevice device, GPUBuffer buffer, [MarshalAs(UnmanagedType.LPStr)] string text);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUTextureName")]
    public static partial void SetGPUTextureName(GPUDevice device, GPUTexture texture, [MarshalAs(UnmanagedType.LPStr)] string text);

    [LibraryImport(LibraryName, EntryPoint = "SDL_InsertGPUDebugLabel")]
    public static partial void InsertGPUDebugLabel(GPUCommandBuffer commandBuffer, [MarshalAs(UnmanagedType.LPStr)] string text);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PushGPUDebugGroup")]
    public static partial void PushGPUDebugGroup(GPUCommandBuffer commandBuffer, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PopGPUDebugGroup")]
    public static partial void PopGPUDebugGroup(GPUCommandBuffer commandBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUTexture")]
    public static partial void ReleaseGPUTexture(GPUDevice device, GPUTexture texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUSampler")]
    public static partial void ReleaseGPUSampler(GPUDevice device, GPUSampler sampler);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUBuffer")]
    public static partial void ReleaseGPUBuffer(GPUDevice device, GPUBuffer buffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUTransferBuffer")]
    public static partial void ReleaseGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUComputePipeline")]
    public static partial void ReleaseGPUComputePipeline(GPUDevice device, GPUComputePipeline computePipeline);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUShader")]
    public static partial void ReleaseGPUShader(GPUDevice device, GPUShader shader);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUGraphicsPipeline")]
    public static partial void ReleaseGPUGraphicsPipeline(GPUDevice device, GPUGraphicsPipeline graphicsPipeline);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AcquireGPUCommandBuffer")]
    public static partial GPUCommandBuffer AcquireGPUCommandBuffer(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PushGPUVertexUniformData")]
    public static partial void PushGPUVertexUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PushGPUFragmentUniformData")]
    public static partial void PushGPUFragmentUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PushGPUComputeUniformData")]
    public static partial void PushGPUComputeUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BeginGPURenderPass")]
    public static partial GPURenderPass BeginGPURenderPass(GPUCommandBuffer commandBuffer, GPUColorTargetInfo* colorTargetInfos, uint numColorTargets, GPUDepthStencilTargetInfo* depthStencilTargetInfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUGraphicsPipeline")]
    public static partial void BindGPUGraphicsPipeline(GPURenderPass renderPass, GPUGraphicsPipeline graphicsPipeline);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUViewport")]
    public static partial void SetGPUViewport(GPURenderPass renderPass, GPUViewport* viewport);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUScissor")]
    public static partial void SetGPUScissor(GPURenderPass renderPass, Rect* scissor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUBlendConstants")]
    public static partial void SetGPUBlendConstants(GPURenderPass renderPass, FColor blendConstants);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUStencilReference")]
    public static partial void SetGPUStencilReference(GPURenderPass renderPass, byte reference);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUVertexBuffers")]
    public static partial void BindGPUVertexBuffers(GPURenderPass renderPass, uint firstSlot, GPUBufferBinding* bindings, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUIndexBuffer")]
    public static partial void BindGPUIndexBuffer(GPURenderPass renderPass, GPUBufferBinding* binding, GPUIndexElementSize indexElementSize);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUVertexSamplers")]
    public static partial void BindGPUVertexSamplers(GPURenderPass renderPass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUVertexStorageTextures")]
    public static partial void BindGPUVertexStorageTextures(GPURenderPass renderPass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
    public static partial void BindGPUVertexStorageBuffers(GPURenderPass renderPass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentSamplers")]
    public static partial void BindGPUFragmentSamplers(GPURenderPass renderPass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
    public static partial void BindGPUFragmentStorageTextures(GPURenderPass renderPass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
    public static partial void BindGPUFragmentStorageBuffers(GPURenderPass renderPass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DrawGPUIndexedPrimitives")]
    public static partial void DrawGPUIndexedPrimitives(GPURenderPass renderPass, uint numIndices, uint numInstances, uint firstIndex, int vertexOffset, uint firstInstance);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DrawGPUPrimitives")]
    public static partial void DrawGPUPrimitives(GPURenderPass renderPass, uint numVertices, uint numInstances, uint firstVertex, uint firstInstance);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DrawGPUPrimitivesIndirect")]
    public static partial void DrawGPUPrimitivesIndirect(GPURenderPass renderPass, GPUBuffer buffer, uint offset, uint drawCount);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect")]
    public static partial void DrawGPUIndexedPrimitivesIndirect(GPURenderPass renderPass, GPUBuffer buffer, uint offset, uint drawCount);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EndGPURenderPass")]
    public static partial void EndGPURenderPass(GPURenderPass renderPass);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BeginGPUComputePass")]
    public static partial GPUComputePass BeginGPUComputePass(GPUCommandBuffer commandBuffer, GPUStorageTextureReadWriteBinding* storageTextureBindings, uint numStorageTextureBindings, GPUStorageBufferReadWriteBinding* storageBufferBindings, uint numStorageBufferBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUComputePipeline")]
    public static partial void BindGPUComputePipeline(GPUComputePass computePass, GPUComputePipeline computePipeline);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUComputeSamplers")]
    public static partial void BindGPUComputeSamplers(GPUComputePass computePass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUComputeStorageTextures")]
    public static partial void BindGPUComputeStorageTextures(GPUComputePass computePass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
    public static partial void BindGPUComputeStorageBuffers(GPUComputePass computePass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DispatchGPUCompute")]
    public static partial void DispatchGPUCompute(GPUComputePass computePass, uint groupcountX, uint groupcountY, uint groupcountZ);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DispatchGPUComputeIndirect")]
    public static partial void DispatchGPUComputeIndirect(GPUComputePass computePass, GPUBuffer buffer, uint offset);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EndGPUComputePass")]
    public static partial void EndGPUComputePass(GPUComputePass computePass);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MapGPUTransferBuffer")]
    public static partial void* MapGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer, byte cycle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnmapGPUTransferBuffer")]
    public static partial void UnmapGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BeginGPUCopyPass")]
    public static partial GPUCopyPass BeginGPUCopyPass(GPUCommandBuffer commandBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UploadToGPUTexture")]
    public static partial void UploadToGPUTexture(GPUCopyPass copyPass, GPUTextureTransferInfo* source, GPUTextureRegion* destination, byte cycle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UploadToGPUBuffer")]
    public static partial void UploadToGPUBuffer(GPUCopyPass copyPass, GPUTransferBufferLocation* source, GPUBufferRegion* destination, byte cycle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CopyGPUTextureToTexture")]
    public static partial void CopyGPUTextureToTexture(GPUCopyPass copyPass, GPUTextureLocation* source, GPUTextureLocation* destination, uint w, uint h, uint d, byte cycle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CopyGPUBufferToBuffer")]
    public static partial void CopyGPUBufferToBuffer(GPUCopyPass copyPass, GPUBufferLocation* source, GPUBufferLocation* destination, uint size, byte cycle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DownloadFromGPUTexture")]
    public static partial void DownloadFromGPUTexture(GPUCopyPass copyPass, GPUTextureRegion* source, GPUTextureTransferInfo* destination);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DownloadFromGPUBuffer")]
    public static partial void DownloadFromGPUBuffer(GPUCopyPass copyPass, GPUBufferRegion* source, GPUTransferBufferLocation* destination);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EndGPUCopyPass")]
    public static partial void EndGPUCopyPass(GPUCopyPass copyPass);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GenerateMipmapsForGPUTexture")]
    public static partial void GenerateMipmapsForGPUTexture(GPUCommandBuffer commandBuffer, GPUTexture texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitGPUTexture")]
    public static partial void BlitGPUTexture(GPUCommandBuffer commandBuffer, GPUBlitInfo* info);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WindowSupportsGPUSwapchainComposition(GPUDevice device, Window window, GPUSwapchainComposition swapchainComposition);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WindowSupportsGPUPresentMode(GPUDevice device, Window window, GPUPresentMode presentMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClaimWindowForGPUDevice")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClaimWindowForGPUDevice(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseWindowFromGPUDevice")]
    public static partial void ReleaseWindowFromGPUDevice(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUSwapchainParameters")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGPUSwapchainParameters(GPUDevice device, Window window, GPUSwapchainComposition swapchainComposition, GPUPresentMode presentMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGPUAllowedFramesInFlight(GPUDevice device, uint allowedFramesInFlight);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUSwapchainTextureFormat")]
    public static partial GPUTextureFormat GetGPUSwapchainTextureFormat(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, out GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitForGPUSwapchain")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitForGPUSwapchain(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitAndAcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, out GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SubmitGPUCommandBuffer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SubmitGPUCommandBuffer(GPUCommandBuffer commandBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence")]
    public static partial GPUFence SubmitGPUCommandBufferAndAcquireFence(GPUCommandBuffer commandBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CancelGPUCommandBuffer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CancelGPUCommandBuffer(GPUCommandBuffer commandBuffer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitForGPUIdle")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitForGPUIdle(GPUDevice device);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitForGPUFences")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitForGPUFences(GPUDevice device, byte waitAll, GPUFence fences, uint numFences);

    [LibraryImport(LibraryName, EntryPoint = "SDL_QueryGPUFence")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool QueryGPUFence(GPUDevice device, GPUFence fence);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReleaseGPUFence")]
    public static partial void ReleaseGPUFence(GPUDevice device, GPUFence fence);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUTextureFormatTexelBlockSize")]
    public static partial uint GPUTextureFormatTexelBlockSize(GPUTextureFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUTextureSupportsFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GPUTextureSupportsFormat(GPUDevice device, GPUTextureFormat format, GPUTextureType type, uint usage);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GPUTextureSupportsSampleCount(GPUDevice device, GPUTextureFormat format, GPUSampleCount sampleCount);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CalculateGPUTextureFormatSize")]
    public static partial uint CalculateGPUTextureFormatSize(GPUTextureFormat format, uint width, uint height, uint depthOrLayerCount);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatFromGPUTextureFormat")]
    public static partial PixelFormat GetPixelFormatFromGPUTextureFormat(GPUTextureFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPUTextureFormatFromPixelFormat")]
    public static partial GPUTextureFormat GetGPUTextureFormatFromPixelFormat(PixelFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GUIDToString")]
    public static partial void GUIDToString(GUID guid, [MarshalAs(UnmanagedType.LPStr)] string pszguid, int cbguid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StringToGUID")]
    public static partial GUID StringToGUID([MarshalAs(UnmanagedType.LPStr)] string pchguid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHaptics")]
    public static partial uint* GetHaptics(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetHapticNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenHaptic")]
    public static partial Haptic OpenHaptic(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticFromID")]
    public static partial Haptic GetHapticFromID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticID")]
    public static partial uint GetHapticID(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetHapticName(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsMouseHaptic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsMouseHaptic();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenHapticFromMouse")]
    public static partial Haptic OpenHapticFromMouse();

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsJoystickHaptic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsJoystickHaptic(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenHapticFromJoystick")]
    public static partial Haptic OpenHapticFromJoystick(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseHaptic")]
    public static partial void CloseHaptic(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMaxHapticEffects")]
    public static partial int GetMaxHapticEffects(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMaxHapticEffectsPlaying")]
    public static partial int GetMaxHapticEffectsPlaying(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticFeatures")]
    public static partial uint GetHapticFeatures(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumHapticAxes")]
    public static partial int GetNumHapticAxes(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HapticEffectSupported")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HapticEffectSupported(Haptic haptic, HapticEffect* effect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateHapticEffect")]
    public static partial int CreateHapticEffect(Haptic haptic, HapticEffect* effect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateHapticEffect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateHapticEffect(Haptic haptic, int effect, HapticEffect* data);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RunHapticEffect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RunHapticEffect(Haptic haptic, int effect, uint iterations);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StopHapticEffect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StopHapticEffect(Haptic haptic, int effect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyHapticEffect")]
    public static partial void DestroyHapticEffect(Haptic haptic, int effect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHapticEffectStatus")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetHapticEffectStatus(Haptic haptic, int effect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetHapticGain")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetHapticGain(Haptic haptic, int gain);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetHapticAutocenter")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetHapticAutocenter(Haptic haptic, int autocenter);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PauseHaptic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PauseHaptic(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResumeHaptic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ResumeHaptic(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StopHapticEffects")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StopHapticEffects(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HapticRumbleSupported")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HapticRumbleSupported(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_InitHapticRumble")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool InitHapticRumble(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PlayHapticRumble")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PlayHapticRumble(Haptic haptic, float strength, uint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StopHapticRumble")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StopHapticRumble(Haptic haptic);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_init")]
    public static partial int HidInit();

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_exit")]
    public static partial int HidExit();

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_device_change_count")]
    public static partial uint HidDeviceChangeCount();

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_enumerate")]
    public static partial HidDeviceInfo* HidEnumerate(ushort vendorId, ushort productId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_free_enumeration")]
    public static partial void HidFreeEnumeration(HidDeviceInfo* devs);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_open")]
    public static partial HidDevice HidOpen(ushort vendorId, ushort productId, uint* serialNumber);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_open_path")]
    public static partial HidDevice HidOpenPath([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_properties")]
    public static partial uint HidGetProperties(HidDevice dev);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_write")]
    public static partial int HidWrite(HidDevice dev, byte* data, nuint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_read_timeout")]
    public static partial int HidReadTimeout(HidDevice dev, byte* data, nuint length, int milliseconds);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_read")]
    public static partial int HidRead(HidDevice dev, byte* data, nuint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_set_nonblocking")]
    public static partial int HidSetNonblocking(HidDevice dev, int nonblock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_send_feature_report")]
    public static partial int HidSendFeatureReport(HidDevice dev, byte* data, nuint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_feature_report")]
    public static partial int HidGetFeatureReport(HidDevice dev, byte* data, nuint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_input_report")]
    public static partial int HidGetInputReport(HidDevice dev, byte* data, nuint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_close")]
    public static partial int HidClose(HidDevice dev);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_manufacturer_string")]
    public static partial int HidGetManufacturerString(HidDevice dev, uint* @string, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_product_string")]
    public static partial int HidGetProductString(HidDevice dev, uint* @string, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_serial_number_string")]
    public static partial int HidGetSerialNumberString(HidDevice dev, uint* @string, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_indexed_string")]
    public static partial int HidGetIndexedString(HidDevice dev, int stringIndex, uint* @string, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_device_info")]
    public static partial HidDeviceInfo* HidGetDeviceInfo(HidDevice dev);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_report_descriptor")]
    public static partial int HidGetReportDescriptor(HidDevice dev, byte* buf, nuint bufSize);

    [LibraryImport(LibraryName, EntryPoint = "SDL_hid_ble_scan")]
    public static partial void HidBleScan(byte active);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetHintWithPriority")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetHintWithPriority([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value, HintPriority priority);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetHint")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetHint([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResetHint")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ResetHint([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResetHints")]
    public static partial void ResetHints();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHint")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetHint([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetHintBoolean")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetHintBoolean([MarshalAs(UnmanagedType.LPStr)] string name, byte defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddHintCallback")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AddHintCallback([MarshalAs(UnmanagedType.LPStr)] string name, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveHintCallback")]
    public static partial void RemoveHintCallback([MarshalAs(UnmanagedType.LPStr)] string name, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Init")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool Init(InitFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_InitSubSystem")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool InitSubSystem(InitFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_QuitSubSystem")]
    public static partial void QuitSubSystem(InitFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WasInit")]
    public static partial InitFlags WasInit(InitFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Quit")]
    public static partial void Quit();

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsMainThread")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsMainThread();

    [LibraryImport(LibraryName, EntryPoint = "SDL_RunOnMainThread")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RunOnMainThread(delegate* unmanaged[Cdecl]<void*, void> callback, void* userdata, byte waitComplete);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAppMetadata")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAppMetadata([MarshalAs(UnmanagedType.LPStr)] string appname, [MarshalAs(UnmanagedType.LPStr)] string appversion, [MarshalAs(UnmanagedType.LPStr)] string appidentifier);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAppMetadataProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetAppMetadataProperty([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAppMetadataProperty")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetAppMetadataProperty([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOFromFile")]
    public static partial IOStream IOFromFile([MarshalAs(UnmanagedType.LPStr)] string file, [MarshalAs(UnmanagedType.LPStr)] string mode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOFromMem")]
    public static partial IOStream IOFromMem(void* mem, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOFromConstMem")]
    public static partial IOStream IOFromConstMem(void* mem, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOFromDynamicMem")]
    public static partial IOStream IOFromDynamicMem();

    /*[LibraryImport(LibraryName, EntryPoint = "SDL_OpenIO")]
    public static partial IOStream OpenIO(IOStreamInterface* iface, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseIO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CloseIO(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetIOProperties")]
    public static partial uint GetIOProperties(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetIOStatus")]
    public static partial IOStatus GetIOStatus(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetIOSize")]
    public static partial long GetIOSize(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SeekIO")]
    public static partial long SeekIO(IOStream context, long offset, IOWhence whence);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TellIO")]
    public static partial long TellIO(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadIO")]
    public static partial nuint ReadIO(IOStream context, void* ptr, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteIO")]
    public static partial nuint WriteIO(IOStream context, void* ptr, nuint size);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_IOprintf")]
    public static partial nuint IOprintf(IOStream context, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOvprintf")]
    public static partial nuint IOvprintf(IOStream context, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlushIO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FlushIO(IOStream context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadFile_IO")]
    public static partial void* LoadFileIO(IOStream src, nuint* datasize, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadFile")]
    public static partial void* LoadFile([MarshalAs(UnmanagedType.LPStr)] string file, nuint* datasize);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SaveFile_IO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SaveFileIO(IOStream src, void* data, nuint datasize, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SaveFile")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SaveFile([MarshalAs(UnmanagedType.LPStr)] string file, void* data, nuint datasize);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU8")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU8(IOStream src, byte* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS8")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS8(IOStream src, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU16LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU16LE(IOStream src, ushort* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS16LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS16LE(IOStream src, short* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU16BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU16BE(IOStream src, ushort* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS16BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS16BE(IOStream src, short* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU32LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU32LE(IOStream src, uint* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS32LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS32LE(IOStream src, int* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU32BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU32BE(IOStream src, uint* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS32BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS32BE(IOStream src, int* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU64LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU64LE(IOStream src, ulong* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS64LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS64LE(IOStream src, long* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadU64BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadU64BE(IOStream src, ulong* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadS64BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadS64BE(IOStream src, long* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU8")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU8(IOStream dst, byte value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS8")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS8(IOStream dst, sbyte value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU16LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU16LE(IOStream dst, ushort value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS16LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS16LE(IOStream dst, short value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU16BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU16BE(IOStream dst, ushort value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS16BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS16BE(IOStream dst, short value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU32LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU32LE(IOStream dst, uint value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS32LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS32LE(IOStream dst, int value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU32BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU32BE(IOStream dst, uint value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS32BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS32BE(IOStream dst, int value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU64LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU64LE(IOStream dst, ulong value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS64LE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS64LE(IOStream dst, long value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteU64BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteU64BE(IOStream dst, ulong value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteS64BE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteS64BE(IOStream dst, long value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockJoysticks")]
    public static partial void LockJoysticks();

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockJoysticks")]
    public static partial void UnlockJoysticks();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasJoystick")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasJoystick();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoysticks")]
    public static partial uint* GetJoysticks(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetJoystickNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPathForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetJoystickPathForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndexForID")]
    public static partial int GetJoystickPlayerIndexForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDForID")]
    public static partial GUID GetJoystickGUIDForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickVendorForID")]
    public static partial ushort GetJoystickVendorForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProductForID")]
    public static partial ushort GetJoystickProductForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersionForID")]
    public static partial ushort GetJoystickProductVersionForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickTypeForID")]
    public static partial JoystickType GetJoystickTypeForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenJoystick")]
    public static partial Joystick OpenJoystick(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFromID")]
    public static partial Joystick GetJoystickFromID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
    public static partial Joystick GetJoystickFromPlayerIndex(int playerIndex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AttachVirtualJoystick")]
    public static partial uint AttachVirtualJoystick(VirtualJoystickDesc* desc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DetachVirtualJoystick")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool DetachVirtualJoystick(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsJoystickVirtual")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsJoystickVirtual(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualAxis")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickVirtualAxis(Joystick joystick, int axis, short value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualBall")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickVirtualBall(Joystick joystick, int ball, short xrel, short yrel);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualButton")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickVirtualButton(Joystick joystick, int button, byte down);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualHat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickVirtualHat(Joystick joystick, int hat, byte value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickVirtualTouchpad(Joystick joystick, int touchpad, int finger, byte down, float x, float y, float pressure);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SendJoystickVirtualSensorData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SendJoystickVirtualSensorData(Joystick joystick, SensorType type, ulong sensorTimestamp, float* data, int numValues);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProperties")]
    public static partial uint GetJoystickProperties(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetJoystickName(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPath")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetJoystickPath(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndex")]
    public static partial int GetJoystickPlayerIndex(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickPlayerIndex")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickPlayerIndex(Joystick joystick, int playerIndex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickGUID")]
    public static partial GUID GetJoystickGUID(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickVendor")]
    public static partial ushort GetJoystickVendor(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProduct")]
    public static partial ushort GetJoystickProduct(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersion")]
    public static partial ushort GetJoystickProductVersion(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickFirmwareVersion")]
    public static partial ushort GetJoystickFirmwareVersion(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickSerial")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetJoystickSerial(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickType")]
    public static partial JoystickType GetJoystickType(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDInfo")]
    public static partial void GetJoystickGUIDInfo(GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16);

    [LibraryImport(LibraryName, EntryPoint = "SDL_JoystickConnected")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool JoystickConnected(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickID")]
    public static partial uint GetJoystickID(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickAxes")]
    public static partial int GetNumJoystickAxes(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickBalls")]
    public static partial int GetNumJoystickBalls(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickHats")]
    public static partial int GetNumJoystickHats(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumJoystickButtons")]
    public static partial int GetNumJoystickButtons(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickEventsEnabled")]
    public static partial void SetJoystickEventsEnabled(byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_JoystickEventsEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool JoystickEventsEnabled();

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateJoysticks")]
    public static partial void UpdateJoysticks();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickAxis")]
    public static partial short GetJoystickAxis(Joystick joystick, int axis);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickAxisInitialState")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetJoystickAxisInitialState(Joystick joystick, int axis, short* state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickBall")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetJoystickBall(Joystick joystick, int ball, int* dx, int* dy);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickHat")]
    public static partial byte GetJoystickHat(Joystick joystick, int hat);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickButton")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetJoystickButton(Joystick joystick, int button);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RumbleJoystick")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RumbleJoystick(Joystick joystick, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RumbleJoystickTriggers")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RumbleJoystickTriggers(Joystick joystick, ushort leftRumble, ushort rightRumble, uint durationMs);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetJoystickLED")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetJoystickLED(Joystick joystick, byte red, byte green, byte blue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SendJoystickEffect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SendJoystickEffect(Joystick joystick, void* data, int size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseJoystick")]
    public static partial void CloseJoystick(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickConnectionState")]
    public static partial JoystickConnectionState GetJoystickConnectionState(Joystick joystick);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetJoystickPowerInfo")]
    public static partial PowerState GetJoystickPowerInfo(Joystick joystick, int* percent);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasKeyboard")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasKeyboard();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboards")]
    public static partial uint* GetKeyboards(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetKeyboardNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus")]
    public static partial Window GetKeyboardFocus();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyboardState")]
    public static partial bool* GetKeyboardState(int* numkeys);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResetKeyboard")]
    public static partial void ResetKeyboard();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetModState")]
    public static partial ushort GetModState();

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetModState")]
    public static partial void SetModState(ushort modstate);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode")]
    public static partial uint GetKeyFromScancode(Scancode scancode, ushort modstate, byte keyEvent);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey")]
    public static partial Scancode GetScancodeFromKey(uint key, ushort* modstate);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetScancodeName")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetScancodeName(Scancode scancode, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetScancodeName(Scancode scancode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName")]
    public static partial Scancode GetScancodeFromName([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetKeyName(uint key);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetKeyFromName")]
    public static partial uint GetKeyFromName([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StartTextInput")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StartTextInput(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StartTextInputWithProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StartTextInputWithProperties(Window window, uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TextInputActive")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TextInputActive(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StopTextInput")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StopTextInput(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearComposition")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearComposition(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextInputArea")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextInputArea(Window window, Rect* rect, int cursor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextInputArea")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextInputArea(Window window, Rect* rect, int* cursor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasScreenKeyboardSupport();

    [LibraryImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ScreenKeyboardShown(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadObject")]
    public static partial SharedObject LoadObject([MarshalAs(UnmanagedType.LPStr)] string sofile);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadFunction")]
    public static partial delegate* unmanaged[Cdecl]<void> LoadFunction(SharedObject handle, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnloadObject")]
    public static partial void UnloadObject(SharedObject handle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPreferredLocales")]
    public static partial Locale** GetPreferredLocales(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLogPriorities")]
    public static partial void SetLogPriorities(LogPriority priority);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLogPriority")]
    public static partial void SetLogPriority(int category, LogPriority priority);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetLogPriority")]
    public static partial LogPriority GetLogPriority(int category);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResetLogPriorities")]
    public static partial void ResetLogPriorities();

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLogPriorityPrefix")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetLogPriorityPrefix(LogPriority priority, [MarshalAs(UnmanagedType.LPStr)] string prefix);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_Log")]
    public static partial void Log([MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogTrace")]
    public static partial void LogTrace(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogVerbose")]
    public static partial void LogVerbose(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogDebug")]
    public static partial void LogDebug(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogInfo")]
    public static partial void LogInfo(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogWarn")]
    public static partial void LogWarn(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogError")]
    public static partial void LogError(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogCritical")]
    public static partial void LogCritical(int category, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogMessage")]
    public static partial void LogMessage(int category, LogPriority priority, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_LogMessageV")]
    public static partial void LogMessageV(int category, LogPriority priority, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultLogOutputFunction")]
    public static partial delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> GetDefaultLogOutputFunction();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetLogOutputFunction")]
    public static partial void GetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, vo**** callback, void** userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLogOutputFunction")]
    public static partial void SetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowMessageBox")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowSimpleMessageBox")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShowSimpleMessageBox(uint flags, [MarshalAs(UnmanagedType.LPStr)] string title, [MarshalAs(UnmanagedType.LPStr)] string message, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Metal_CreateView")]
    public static partial void* MetalCreateView(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Metal_DestroyView")]
    public static partial void MetalDestroyView(void* view);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Metal_GetLayer")]
    public static partial void* MetalGetLayer(void* view);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenURL")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool OpenURL([MarshalAs(UnmanagedType.LPStr)] string url);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasMouse")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasMouse();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMice")]
    public static partial uint* GetMice(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetMouseNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseFocus")]
    public static partial Window GetMouseFocus();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMouseState")]
    public static partial uint GetMouseState(float* x, float* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState")]
    public static partial uint GetGlobalMouseState(float* x, float* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState")]
    public static partial uint GetRelativeMouseState(float* x, float* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindow")]
    public static partial void WarpMouseInWindow(Window window, float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WarpMouseGlobal")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WarpMouseGlobal(float x, float y);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetRelativeMouseTransform")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRelativeMouseTransform(delegate* unmanaged[Cdecl]<void*, ulong, SDL_Window*, uint, float*, float*, void> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowRelativeMouseMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowRelativeMouseMode(Window window, byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowRelativeMouseMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowRelativeMouseMode(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CaptureMouse")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CaptureMouse(byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateCursor")]
    public static partial Cursor CreateCursor(byte* data, byte* mask, int w, int h, int hotX, int hotY);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateColorCursor")]
    public static partial Cursor CreateColorCursor(Surface* surface, int hotX, int hotY);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateAnimatedCursor")]
    public static partial Cursor CreateAnimatedCursor(CursorFrameInfo* frames, int frameCount, int hotX, int hotY);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor")]
    public static partial Cursor CreateSystemCursor(SystemCursor id);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetCursor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetCursor(Cursor cursor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCursor")]
    public static partial Cursor GetCursor();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor")]
    public static partial Cursor GetDefaultCursor();

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyCursor")]
    public static partial void DestroyCursor(Cursor cursor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowCursor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShowCursor();

    [LibraryImport(LibraryName, EntryPoint = "SDL_HideCursor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HideCursor();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CursorVisible")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CursorVisible();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateMutex")]
    public static partial Mutex CreateMutex();

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockMutex")]
    public static partial void LockMutex(Mutex mutex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TryLockMutex")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TryLockMutex(Mutex mutex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockMutex")]
    public static partial void UnlockMutex(Mutex mutex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyMutex")]
    public static partial void DestroyMutex(Mutex mutex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateRWLock")]
    public static partial RWLock CreateRWLock();

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockRWLockForReading")]
    public static partial void LockRWLockForReading(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockRWLockForWriting")]
    public static partial void LockRWLockForWriting(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TryLockRWLockForReading")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TryLockRWLockForReading(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TryLockRWLockForWriting")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TryLockRWLockForWriting(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockRWLock")]
    public static partial void UnlockRWLock(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyRWLock")]
    public static partial void DestroyRWLock(RWLock rwlock);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSemaphore")]
    public static partial Semaphore CreateSemaphore(uint initialValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroySemaphore")]
    public static partial void DestroySemaphore(Semaphore sem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitSemaphore")]
    public static partial void WaitSemaphore(Semaphore sem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TryWaitSemaphore")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TryWaitSemaphore(Semaphore sem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitSemaphoreTimeout")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitSemaphoreTimeout(Semaphore sem, int timeoutms);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SignalSemaphore")]
    public static partial void SignalSemaphore(Semaphore sem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSemaphoreValue")]
    public static partial uint GetSemaphoreValue(Semaphore sem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateCondition")]
    public static partial Condition CreateCondition();

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyCondition")]
    public static partial void DestroyCondition(Condition cond);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SignalCondition")]
    public static partial void SignalCondition(Condition cond);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BroadcastCondition")]
    public static partial void BroadcastCondition(Condition cond);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitCondition")]
    public static partial void WaitCondition(Condition cond, Mutex mutex);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitConditionTimeout")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitConditionTimeout(Condition cond, Mutex mutex, int timeoutms);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShouldInit")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShouldInit(InitState* state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShouldQuit")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShouldQuit(InitState* state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetInitialized")]
    public static partial void SetInitialized(InitState* state, byte initialized);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPenDeviceType")]
    public static partial PenDeviceType GetPenDeviceType(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetPixelFormatName(PixelFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetMasksForPixelFormat(PixelFormat format, int* bpp, uint* rmask, uint* gmask, uint* bmask, uint* amask);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatForMasks")]
    public static partial PixelFormat GetPixelFormatForMasks(int bpp, uint rmask, uint gmask, uint bmask, uint amask);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPixelFormatDetails")]
    public static partial PixelFormatDetails* GetPixelFormatDetails(PixelFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreatePalette")]
    public static partial Palette* CreatePalette(int ncolors);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetPaletteColors")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetPaletteColors(Palette* palette, Color* colors, int firstcolor, int ncolors);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyPalette")]
    public static partial void DestroyPalette(Palette* palette);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MapRGB")]
    public static partial uint MapRGB(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MapRGBA")]
    public static partial uint MapRGBA(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b, byte a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRGB")]
    public static partial void GetRGB(uint pixelvalue, PixelFormatDetails* format, Palette* palette, byte* r, byte* g, byte* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRGBA")]
    public static partial void GetRGBA(uint pixelvalue, PixelFormatDetails* format, Palette* palette, byte* r, byte* g, byte* b, byte* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPlatform")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetPlatform();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPowerInfo")]
    public static partial PowerState GetPowerInfo(int* seconds, int* percent);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateProcess")]
    public static partial Process CreateProcess(sbyte** args, byte pipeStdio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateProcessWithProperties")]
    public static partial Process CreateProcessWithProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetProcessProperties")]
    public static partial uint GetProcessProperties(Process process);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadProcess")]
    public static partial void* ReadProcess(Process process, nuint* datasize, int* exitcode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetProcessInput")]
    public static partial IOStream GetProcessInput(Process process);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetProcessOutput")]
    public static partial IOStream GetProcessOutput(Process process);

    [LibraryImport(LibraryName, EntryPoint = "SDL_KillProcess")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool KillProcess(Process process, byte force);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitProcess")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitProcess(Process process, byte block, int* exitcode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyProcess")]
    public static partial void DestroyProcess(Process process);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties")]
    public static partial uint GetGlobalProperties();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateProperties")]
    public static partial uint CreateProperties();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CopyProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CopyProperties(uint src, uint dst);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LockProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockProperties")]
    public static partial void UnlockProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetPointerPropertyWithCleanup(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, void* value, delegate* unmanaged[Cdecl]<void*, void*, void> cleanup, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetPointerProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetPointerProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, void* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetStringProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetStringProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetNumberProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetNumberProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, long value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetFloatProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetFloatProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, float value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetBooleanProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, byte value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPropertyType")]
    public static partial PropertyType GetPropertyType(uint props, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPointerProperty")]
    public static partial void* GetPointerProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, void* defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetStringProperty")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetStringProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumberProperty")]
    public static partial long GetNumberProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, long defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetFloatProperty")]
    public static partial float GetFloatProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, float defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetBooleanProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name, byte defaultValue);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearProperty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearProperty(uint props, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnumerateProperties(uint props, delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyProperties")]
    public static partial void DestroyProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectToFRect")]
    public static partial void RectToFRect(Rect* rect, FRect* frect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PointInRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PointInRect(Point* p, Rect* r);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectEmpty")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RectEmpty(Rect* r);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectsEqual")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RectsEqual(Rect* a, Rect* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasRectIntersection")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasRectIntersection(Rect* a, Rect* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectIntersection")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectIntersection(Rect* a, Rect* b, Rect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnion")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectUnion(Rect* a, Rect* b, Rect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPoints")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectEnclosingPoints(Point* points, int count, Rect* clip, Rect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersection")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectAndLineIntersection(Rect* rect, int* x1, int* y1, int* x2, int* y2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PointInRectFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PointInRectFloat(FPoint* p, FRect* r);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectEmptyFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RectEmptyFloat(FRect* r);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectsEqualEpsilon")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RectsEqualEpsilon(FRect* a, FRect* b, float epsilon);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RectsEqualFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RectsEqualFloat(FRect* a, FRect* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HasRectIntersectionFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HasRectIntersectionFloat(FRect* a, FRect* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectIntersectionFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectIntersectionFloat(FRect* a, FRect* b, FRect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectUnionFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectUnionFloat(FRect* a, FRect* b, FRect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectEnclosingPointsFloat(FPoint* points, int count, FRect* clip, FRect* result);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRectAndLineIntersectionFloat(FRect* rect, float* x1, float* y1, float* x2, float* y2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers")]
    public static partial int GetNumRenderDrivers();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetRenderDriver(int index);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CreateWindowAndRenderer([MarshalAs(UnmanagedType.LPStr)] string title, int width, int height, WindowFlags windowFlags, Window window, Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateRenderer")]
    public static partial Renderer CreateRenderer(Window window, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties")]
    public static partial Renderer CreateRendererWithProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPURenderer")]
    public static partial Renderer CreateGPURenderer(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGPURendererDevice")]
    public static partial GPUDevice GetGPURendererDevice(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer")]
    public static partial Renderer CreateSoftwareRenderer(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderer")]
    public static partial Renderer GetRenderer(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderWindow")]
    public static partial Window GetRenderWindow(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetRendererName(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererProperties")]
    public static partial uint GetRendererProperties(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderOutputSize(Renderer renderer, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetCurrentRenderOutputSize(Renderer renderer, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTexture")]
    public static partial Texture* CreateTexture(Renderer renderer, PixelFormat format, TextureAccess access, int w, int h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface")]
    public static partial Texture* CreateTextureFromSurface(Renderer renderer, Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties")]
    public static partial Texture* CreateTextureWithProperties(Renderer renderer, uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureProperties")]
    public static partial uint GetTextureProperties(Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture")]
    public static partial Renderer GetRendererFromTexture(Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureSize(Texture* texture, float* w, float* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTexturePalette")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTexturePalette(Texture* texture, Palette* palette);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTexturePalette")]
    public static partial Palette* GetTexturePalette(Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureColorModFloat(Texture* texture, float r, float g, float b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureColorModFloat(Texture* texture, float* r, float* g, float* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureAlphaMod(Texture* texture, byte alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureAlphaModFloat(Texture* texture, float alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureAlphaMod(Texture* texture, byte* alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureAlphaModFloat(Texture* texture, float* alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureBlendMode(Texture* texture, uint blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureBlendMode(Texture* texture, uint* blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTextureScaleMode(Texture* texture, ScaleMode scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTextureScaleMode(Texture* texture, ScaleMode* scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateTexture(Texture* texture, Rect* rect, void* pixels, int pitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateYUVTexture(Texture* texture, Rect* rect, byte* yplane, int ypitch, byte* uplane, int upitch, byte* vplane, int vpitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateNVTexture(Texture* texture, Rect* rect, byte* yplane, int ypitch, byte* uvplane, int uvpitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LockTexture(Texture* texture, Rect* rect, void** pixels, int* pitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockTexture")]
    public static partial void UnlockTexture(Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderTarget")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderTarget(Renderer renderer, Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderTarget")]
    public static partial Texture* GetRenderTarget(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderLogicalPresentation(Renderer renderer, int w, int h, RendererLogicalPresentation mode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderLogicalPresentation(Renderer renderer, int* w, int* h, RendererLogicalPresentation* mode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderLogicalPresentationRect(Renderer renderer, FRect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderCoordinatesFromWindow(Renderer renderer, float windowX, float windowY, float* x, float* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderCoordinatesToWindow(Renderer renderer, float x, float y, float* windowX, float* windowY);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ConvertEventToRenderCoordinates(Renderer renderer, Event* @event);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderViewport")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderViewport(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderViewport")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderViewport(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderViewportSet")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderViewportSet(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderSafeArea")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderSafeArea(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderClipRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderClipRect(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderClipRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderClipRect(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderClipEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderClipEnabled(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderScale")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderScale(Renderer renderer, float scalex, float scaley);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderScale")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderScale(Renderer renderer, float* scalex, float* scaley);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderDrawColor(Renderer renderer, byte r, byte g, byte b, byte a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColorFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderDrawColorFloat(Renderer renderer, float r, float g, float b, float a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColor")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderDrawColor(Renderer renderer, byte* r, byte* g, byte* b, byte* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColorFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderDrawColorFloat(Renderer renderer, float* r, float* g, float* b, float* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderColorScale(Renderer renderer, float scale);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderColorScale")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderColorScale(Renderer renderer, float* scale);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderDrawBlendMode(Renderer renderer, uint blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderDrawBlendMode(Renderer renderer, uint* blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderClear")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderClear(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderPoint")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderPoint(Renderer renderer, float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderPoints")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderPoints(Renderer renderer, FPoint* points, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderLine")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderLine(Renderer renderer, float x1, float y1, float x2, float y2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderLines")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderLines(Renderer renderer, FPoint* points, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderRect(Renderer renderer, FRect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderRects")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderRects(Renderer renderer, FRect* rects, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderFillRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderFillRect(Renderer renderer, FRect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderFillRects")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderFillRects(Renderer renderer, FRect* rects, int count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTexture(Renderer renderer, Texture* texture, FRect* srcrect, FRect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTextureRotated")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTextureRotated(Renderer renderer, Texture* texture, FRect* srcrect, FRect* dstrect, double angle, FPoint* center, FlipMode flip);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTextureAffine")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTextureAffine(Renderer renderer, Texture* texture, FRect* srcrect, FPoint* origin, FPoint* right, FPoint* down);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTextureTiled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTextureTiled(Renderer renderer, Texture* texture, FRect* srcrect, float scale, FRect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTexture9Grid")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTexture9Grid(Renderer renderer, Texture* texture, FRect* srcrect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, FRect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderTexture9GridTiled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderTexture9GridTiled(Renderer renderer, Texture* texture, FRect* srcrect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, FRect* dstrect, float tilescale);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderGeometry")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderGeometry(Renderer renderer, Texture* texture, Vertex* vertices, int numVertices, int* indices, int numIndices);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderGeometryRaw")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderGeometryRaw(Renderer renderer, Texture* texture, float* xy, int xyStride, FColor* color, int colorStride, float* uv, int uvStride, int numVertices, void* indices, int numIndices, int sizeIndices);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderTextureAddressMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderTextureAddressMode(Renderer renderer, TextureAddressMode uMode, TextureAddressMode vMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderTextureAddressMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderTextureAddressMode(Renderer renderer, TextureAddressMode* uMode, TextureAddressMode* vMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderReadPixels")]
    public static partial Surface* RenderReadPixels(Renderer renderer, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderPresent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderPresent(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyTexture")]
    public static partial void DestroyTexture(Texture* texture);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyRenderer")]
    public static partial void DestroyRenderer(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlushRenderer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FlushRenderer(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderMetalLayer")]
    public static partial void* GetRenderMetalLayer(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
    public static partial void* GetRenderMetalCommandEncoder(Renderer renderer);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AddVulkanRenderSemaphores(Renderer renderer, uint waitStageMask, long waitSemaphore, long signalSemaphore);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderVSync")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRenderVSync(Renderer renderer, int vsync);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderVSync")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetRenderVSync(Renderer renderer, int* vsync);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderDebugText")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderDebugText(Renderer renderer, float x, float y, [MarshalAs(UnmanagedType.LPStr)] string str);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_RenderDebugTextFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderDebugTextFormat(Renderer renderer, float x, float y, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetDefaultTextureScaleMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetDefaultTextureScaleMode(Renderer renderer, ScaleMode scaleMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultTextureScaleMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetDefaultTextureScaleMode(Renderer renderer, ScaleMode* scaleMode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPURenderState")]
    public static partial GPURenderState CreateGPURenderState(Renderer renderer, GPURenderStateCreateInfo* createinfo);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPURenderStateFragmentUniforms")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGPURenderStateFragmentUniforms(GPURenderState state, uint slotIndex, void* data, uint length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetGPURenderState")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetGPURenderState(Renderer renderer, GPURenderState state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyGPURenderState")]
    public static partial void DestroyGPURenderState(GPURenderState state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensors")]
    public static partial uint* GetSensors(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNameForID")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetSensorNameForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorTypeForID")]
    public static partial SensorType GetSensorTypeForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
    public static partial int GetSensorNonPortableTypeForID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenSensor")]
    public static partial Sensor OpenSensor(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorFromID")]
    public static partial Sensor GetSensorFromID(uint instanceId);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorProperties")]
    public static partial uint GetSensorProperties(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetSensorName(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorType")]
    public static partial SensorType GetSensorType(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableType")]
    public static partial int GetSensorNonPortableType(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorID")]
    public static partial uint GetSensorID(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSensorData")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSensorData(Sensor sensor, float* data, int numValues);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseSensor")]
    public static partial void CloseSensor(Sensor sensor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateSensors")]
    public static partial void UpdateSensors();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenTitleStorage")]
    public static partial Storage OpenTitleStorage([MarshalAs(UnmanagedType.LPStr)] string @override, uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenUserStorage")]
    public static partial Storage OpenUserStorage([MarshalAs(UnmanagedType.LPStr)] string org, [MarshalAs(UnmanagedType.LPStr)] string app, uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenFileStorage")]
    public static partial Storage OpenFileStorage([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenStorage")]
    public static partial Storage OpenStorage(StorageInterface* iface, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CloseStorage")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CloseStorage(Storage storage);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StorageReady")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StorageReady(Storage storage);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetStorageFileSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetStorageFileSize(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, ulong* length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadStorageFile")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadStorageFile(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, void* destination, ulong length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteStorageFile")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteStorageFile(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, void* source, ulong length);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateStorageDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CreateStorageDirectory(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateStorageDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnumerateStorageDirectory(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveStoragePath")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RemoveStoragePath(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenameStoragePath")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenameStoragePath(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string oldpath, [MarshalAs(UnmanagedType.LPStr)] string newpath);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CopyStorageFile")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CopyStorageFile(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string oldpath, [MarshalAs(UnmanagedType.LPStr)] string newpath);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetStoragePathInfo")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetStoragePathInfo(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, PathInfo* info);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetStorageSpaceRemaining")]
    public static partial ulong GetStorageSpaceRemaining(Storage storage);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GlobStorageDirectory")]
    public static partial sbyte** GlobStorageDirectory(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, [MarshalAs(UnmanagedType.LPStr)] string pattern, uint flags, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurface")]
    public static partial Surface* CreateSurface(int width, int height, PixelFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurfaceFrom")]
    public static partial Surface* CreateSurfaceFrom(int width, int height, PixelFormat format, void* pixels, int pitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroySurface")]
    public static partial void DestroySurface(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceProperties")]
    public static partial uint GetSurfaceProperties(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorspace")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorspace")]
    public static partial Colorspace GetSurfaceColorspace(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurfacePalette")]
    public static partial Palette* CreateSurfacePalette(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfacePalette(Surface* surface, Palette* palette);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfacePalette")]
    public static partial Palette* GetSurfacePalette(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddSurfaceAlternateImage")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool AddSurfaceAlternateImage(Surface* surface, Surface* image);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasAlternateImages")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SurfaceHasAlternateImages(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceImages")]
    public static partial Surface** GetSurfaceImages(Surface* surface, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
    public static partial void RemoveSurfaceAlternateImages(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LockSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool LockSurface(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnlockSurface")]
    public static partial void UnlockSurface(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadSurface_IO")]
    public static partial Surface* LoadSurfaceIO(IOStream src, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadSurface")]
    public static partial Surface* LoadSurface([MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadBMP_IO")]
    public static partial Surface* LoadBMPIO(IOStream src, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadBMP")]
    public static partial Surface* LoadBMP([MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SaveBMP_IO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SaveBMPIO(Surface* surface, IOStream dst, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SaveBMP")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SaveBMP(Surface* surface, [MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadPNG_IO")]
    public static partial Surface* LoadPNGIO(IOStream src, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_LoadPNG")]
    public static partial Surface* LoadPNG([MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SavePNG_IO")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SavePNGIO(Surface* surface, IOStream dst, byte closeio);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SavePNG")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SavePNG(Surface* surface, [MarshalAs(UnmanagedType.LPStr)] string file);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceRLE(Surface* surface, byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasRLE")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SurfaceHasRLE(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorKey")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceColorKey(Surface* surface, byte enabled, uint key);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasColorKey")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SurfaceHasColorKey(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorKey")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSurfaceColorKey(Surface* surface, uint* key);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceAlphaMod(Surface* surface, byte alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSurfaceAlphaMod(Surface* surface, byte* alpha);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceBlendMode(Surface* surface, uint blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSurfaceBlendMode(Surface* surface, uint* blendmode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetSurfaceClipRect(Surface* surface, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceClipRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetSurfaceClipRect(Surface* surface, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlipSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FlipSurface(Surface* surface, FlipMode flip);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RotateSurface")]
    public static partial Surface* RotateSurface(Surface* surface, float angle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DuplicateSurface")]
    public static partial Surface* DuplicateSurface(Surface* surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ScaleSurface")]
    public static partial Surface* ScaleSurface(Surface* surface, int width, int height, ScaleMode scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertSurface")]
    public static partial Surface* ConvertSurface(Surface* surface, PixelFormat format);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
    public static partial Surface* ConvertSurfaceAndColorspace(Surface* surface, PixelFormat format, Palette* palette, Colorspace colorspace, uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertPixels")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ConvertPixels(int width, int height, PixelFormat srcFormat, void* src, int srcPitch, PixelFormat dstFormat, void* dst, int dstPitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ConvertPixelsAndColorspace(int width, int height, PixelFormat srcFormat, Colorspace srcColorspace, uint srcProperties, void* src, int srcPitch, PixelFormat dstFormat, Colorspace dstColorspace, uint dstProperties, void* dst, int dstPitch);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PremultiplyAlpha")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PremultiplyAlpha(int width, int height, PixelFormat srcFormat, void* src, int srcPitch, PixelFormat dstFormat, void* dst, int dstPitch, byte linear);

    [LibraryImport(LibraryName, EntryPoint = "SDL_PremultiplySurfaceAlpha")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool PremultiplySurfaceAlpha(Surface* surface, byte linear);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClearSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClearSurface(Surface* surface, float r, float g, float b, float a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FillSurfaceRect(Surface* dst, Rect* rect, uint color);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FillSurfaceRects")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FillSurfaceRects(Surface* dst, Rect* rects, int count, uint color);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUnchecked")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurfaceUnchecked(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurfaceScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurfaceUncheckedScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StretchSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StretchSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurfaceTiled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurfaceTiledWithScale(Surface* src, Rect* srcrect, float scale, ScaleMode scalemode, Surface* dst, Rect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool BlitSurface9Grid(Surface* src, Rect* srcrect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, ScaleMode scalemode, Surface* dst, Rect* dstrect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGB")]
    public static partial uint MapSurfaceRGB(Surface* surface, byte r, byte g, byte b);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGBA")]
    public static partial uint MapSurfaceRGBA(Surface* surface, byte r, byte g, byte b, byte a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixel")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadSurfacePixel(Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixelFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ReadSurfacePixelFloat(Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixel")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteSurfacePixel(Surface* surface, int x, int y, byte r, byte g, byte b, byte a);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixelFloat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WriteSurfacePixelFloat(Surface* surface, int x, int y, float r, float g, float b, float a);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetX11EventHook")]
    public static partial void SetX11EventHook(delegate* unmanaged[Cdecl]<void*, _XEvent*, byte> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLinuxThreadPriority")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetLinuxThreadPriority(long threadid, int priority);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetLinuxThreadPriorityAndPolicy(long threadid, int sdlpriority, int schedpolicy);

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsTablet")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsTablet();

    [LibraryImport(LibraryName, EntryPoint = "SDL_IsTV")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsTV();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSandbox")]
    public static partial Sandbox GetSandbox();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationWillTerminate")]
    public static partial void OnApplicationWillTerminate();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
    public static partial void OnApplicationDidReceiveMemoryWarning();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationWillEnterBackground")]
    public static partial void OnApplicationWillEnterBackground();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationDidEnterBackground")]
    public static partial void OnApplicationDidEnterBackground();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationWillEnterForeground")]
    public static partial void OnApplicationWillEnterForeground();

    [LibraryImport(LibraryName, EntryPoint = "SDL_OnApplicationDidEnterForeground")]
    public static partial void OnApplicationDidEnterForeground();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateThreadRuntime")]
    public static partial Thread CreateThreadRuntime(delegate* unmanaged[Cdecl]<void*, int> fn, [MarshalAs(UnmanagedType.LPStr)] string name, void* data, delegate* unmanaged[Cdecl]<void> pfnbeginthread, delegate* unmanaged[Cdecl]<void> pfnendthread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime")]
    public static partial Thread CreateThreadWithPropertiesRuntime(uint props, delegate* unmanaged[Cdecl]<void> pfnbeginthread, delegate* unmanaged[Cdecl]<void> pfnendthread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetThreadName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetThreadName(Thread thread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentThreadID")]
    public static partial ulong GetCurrentThreadID();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetThreadID")]
    public static partial ulong GetThreadID(Thread thread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetCurrentThreadPriority")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetCurrentThreadPriority(ThreadPriority priority);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitThread")]
    public static partial void WaitThread(Thread thread, int* status);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetThreadState")]
    public static partial ThreadState GetThreadState(Thread thread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DetachThread")]
    public static partial void DetachThread(Thread thread);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTLS")]
    public static partial void* GetTLS(AtomicInt* id);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTLS")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetTLS(AtomicInt* id, void* value, delegate* unmanaged[Cdecl]<void*, void> destructor);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CleanupTLS")]
    public static partial void CleanupTLS();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDateTimeLocalePreferences")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetDateTimeLocalePreferences(DateFormat* dateformat, TimeFormat* timeformat);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentTime")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetCurrentTime(long* ticks);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TimeToDateTime")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TimeToDateTime(long ticks, DateTime* dt, byte localtime);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DateTimeToTime")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool DateTimeToTime(DateTime* dt, long* ticks);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TimeToWindows")]
    public static partial void TimeToWindows(long ticks, uint* dwlowdatetime, uint* dwhighdatetime);

    [LibraryImport(LibraryName, EntryPoint = "SDL_TimeFromWindows")]
    public static partial long TimeFromWindows(uint dwlowdatetime, uint dwhighdatetime);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDaysInMonth")]
    public static partial int GetDaysInMonth(int year, int month);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDayOfYear")]
    public static partial int GetDayOfYear(int year, int month, int day);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDayOfWeek")]
    public static partial int GetDayOfWeek(int year, int month, int day);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTicks")]
    public static partial ulong GetTicks();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTicksNS")]
    public static partial ulong GetTicksNS();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPerformanceCounter")]
    public static partial ulong GetPerformanceCounter();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPerformanceFrequency")]
    public static partial ulong GetPerformanceFrequency();

    [LibraryImport(LibraryName, EntryPoint = "SDL_Delay")]
    public static partial void Delay(uint ms);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DelayNS")]
    public static partial void DelayNS(ulong ns);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DelayPrecise")]
    public static partial void DelayPrecise(ulong ns);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddTimer")]
    public static partial uint AddTimer(uint interval, delegate* unmanaged[Cdecl]<void*, uint, uint, uint> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_AddTimerNS")]
    public static partial uint AddTimerNS(ulong interval, delegate* unmanaged[Cdecl]<void*, uint, ulong, ulong> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveTimer")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RemoveTimer(uint id);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDevices")]
    public static partial ulong* GetTouchDevices(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetTouchDeviceName(ulong touchid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceType")]
    public static partial TouchDeviceType GetTouchDeviceType(ulong touchid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTouchFingers")]
    public static partial Finger** GetTouchFingers(ulong touchid, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTray")]
    public static partial Tray CreateTray(Surface* icon, [MarshalAs(UnmanagedType.LPStr)] string tooltip);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayIcon")]
    public static partial void SetTrayIcon(Tray tray, Surface* icon);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayTooltip")]
    public static partial void SetTrayTooltip(Tray tray, [MarshalAs(UnmanagedType.LPStr)] string tooltip);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTrayMenu")]
    public static partial TrayMenu CreateTrayMenu(Tray tray);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateTraySubmenu")]
    public static partial TrayMenu CreateTraySubmenu(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayMenu")]
    public static partial TrayMenu GetTrayMenu(Tray tray);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTraySubmenu")]
    public static partial TrayMenu GetTraySubmenu(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayEntries")]
    public static partial TrayEntry GetTrayEntries(TrayMenu menu, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RemoveTrayEntry")]
    public static partial void RemoveTrayEntry(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_InsertTrayEntryAt")]
    public static partial TrayEntry InsertTrayEntryAt(TrayMenu menu, int pos, [MarshalAs(UnmanagedType.LPStr)] string label, uint flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayEntryLabel")]
    public static partial void SetTrayEntryLabel(TrayEntry entry, [MarshalAs(UnmanagedType.LPStr)] string label);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayEntryLabel")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetTrayEntryLabel(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayEntryChecked")]
    public static partial void SetTrayEntryChecked(TrayEntry entry, byte @checked);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayEntryChecked")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTrayEntryChecked(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayEntryEnabled")]
    public static partial void SetTrayEntryEnabled(TrayEntry entry, byte enabled);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayEntryEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetTrayEntryEnabled(TrayEntry entry);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayEntryCallback")]
    public static partial void SetTrayEntryCallback(TrayEntry entry, delegate* unmanaged[Cdecl]<void*, SDL_TrayEntry*, void> callback, void* userdata);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_ClickTrayEntry")]
    public static partial void ClickTrayEntry(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyTray")]
    public static partial void DestroyTray(Tray tray);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayEntryParent")]
    public static partial TrayMenu GetTrayEntryParent(TrayEntry entry);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayMenuParentEntry")]
    public static partial TrayEntry GetTrayMenuParentEntry(TrayMenu menu);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetTrayMenuParentTray")]
    public static partial Tray GetTrayMenuParentTray(TrayMenu menu);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateTrays")]
    public static partial void UpdateTrays();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetVersion")]
    public static partial int GetVersion();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetRevision")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetRevision();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers")]
    public static partial int GetNumVideoDrivers();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetVideoDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetVideoDriver(int index);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetCurrentVideoDriver();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetSystemTheme")]
    public static partial SystemTheme GetSystemTheme();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplays")]
    public static partial uint* GetDisplays(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay")]
    public static partial uint GetPrimaryDisplay();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties")]
    public static partial uint GetDisplayProperties(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetDisplayName(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetDisplayBounds(uint displayid, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetDisplayUsableBounds(uint displayid, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation")]
    public static partial DisplayOrientation GetNaturalDisplayOrientation(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation")]
    public static partial DisplayOrientation GetCurrentDisplayOrientation(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayContentScale")]
    public static partial float GetDisplayContentScale(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes")]
    public static partial DisplayMode** GetFullscreenDisplayModes(uint displayid, int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetClosestFullscreenDisplayMode(uint displayid, int w, int h, float refreshRate, byte includeHighDensityModes, DisplayMode* closest);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode")]
    public static partial DisplayMode* GetDesktopDisplayMode(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode")]
    public static partial DisplayMode* GetCurrentDisplayMode(uint displayid);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint")]
    public static partial uint GetDisplayForPoint(Point* point);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect")]
    public static partial uint GetDisplayForRect(Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow")]
    public static partial uint GetDisplayForWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity")]
    public static partial float GetWindowPixelDensity(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale")]
    public static partial float GetWindowDisplayScale(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowFullscreenMode(Window window, DisplayMode* mode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode")]
    public static partial DisplayMode* GetWindowFullscreenMode(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowICCProfile")]
    public static partial void* GetWindowICCProfile(Window window, nuint* size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat")]
    public static partial PixelFormat GetWindowPixelFormat(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindows")]
    public static partial Window GetWindows(int* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindow")]
    public static partial Window CreateWindow([MarshalAs(UnmanagedType.LPStr)] string title, int w, int h, WindowFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow")]
    public static partial Window CreatePopupWindow(Window parent, int offsetX, int offsetY, int w, int h, WindowFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties")]
    public static partial Window CreateWindowWithProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowID")]
    public static partial uint GetWindowID(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFromID")]
    public static partial Window GetWindowFromID(uint id);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowParent")]
    public static partial Window GetWindowParent(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowProperties")]
    public static partial uint GetWindowProperties(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowFlags")]
    public static partial WindowFlags GetWindowFlags(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowTitle")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowTitle(Window window, [MarshalAs(UnmanagedType.LPStr)] string title);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowTitle")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetWindowTitle(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowIcon")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowIcon(Window window, Surface* icon);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowPosition")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowPosition(Window window, int x, int y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowPosition")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowPosition(Window window, int* x, int* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowSize(Window window, int w, int h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowSize(Window window, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSafeArea")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowSafeArea(Window window, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAspectRatio")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowAspectRatio(Window window, float minAspect, float maxAspect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowAspectRatio")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowAspectRatio(Window window, float* minAspect, float* maxAspect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowBordersSize(Window window, int* top, int* left, int* bottom, int* right);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowSizeInPixels(Window window, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowMinimumSize(Window window, int minW, int minH);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowMinimumSize(Window window, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowMaximumSize(Window window, int maxW, int maxH);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowMaximumSize(Window window, int* w, int* h);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowBordered")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowBordered(Window window, byte bordered);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowResizable")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowResizable(Window window, byte resizable);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowAlwaysOnTop(Window window, byte onTop);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFillDocument")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowFillDocument(Window window, byte fill);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShowWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_HideWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool HideWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RaiseWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RaiseWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MaximizeWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MaximizeWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_MinimizeWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MinimizeWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_RestoreWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RestoreWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowFullscreen(Window window, byte fullscreen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SyncWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SyncWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WindowHasSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WindowHasSurface(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurface")]
    public static partial Surface* GetWindowSurface(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowSurfaceVSync")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowSurfaceVSync(Window window, int vsync);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowSurfaceVSync")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowSurfaceVSync(Window window, int* vsync);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateWindowSurface(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UpdateWindowSurfaceRects(Window window, Rect* rects, int numrects);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool DestroyWindowSurface(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowKeyboardGrab(Window window, byte grabbed);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowMouseGrab(Window window, byte grabbed);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowKeyboardGrab(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GetWindowMouseGrab(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow")]
    public static partial Window GetGrabbedWindow();

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowMouseRect(Window window, Rect* rect);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect")]
    public static partial Rect* GetWindowMouseRect(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowOpacity(Window window, float opacity);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity")]
    public static partial float GetWindowOpacity(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowParent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowParent(Window window, Window parent);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowModal")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowModal(Window window, byte modal);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowFocusable(Window window, byte focusable);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ShowWindowSystemMenu(Window window, int x, int y);

    /* todo [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowHitTest")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowHitTest(Window window, delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callbackData);*/

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowShape")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowShape(Window window, Surface* shape);

    [LibraryImport(LibraryName, EntryPoint = "SDL_FlashWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FlashWindow(Window window, FlashOperation operation);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowProgressState")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowProgressState(Window window, ProgressState state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowProgressState")]
    public static partial ProgressState GetWindowProgressState(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowProgressValue")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowProgressValue(Window window, float value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetWindowProgressValue")]
    public static partial float GetWindowProgressValue(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyWindow")]
    public static partial void DestroyWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ScreenSaverEnabled();

    [LibraryImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnableScreenSaver();

    [LibraryImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool DisableScreenSaver();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_LoadLibrary")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLLoadLibrary([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetProcAddress")]
    public static partial delegate* unmanaged[Cdecl]<void> GLGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string proc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetProcAddress")]
    public static partial delegate* unmanaged[Cdecl]<void> EGLGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string proc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_UnloadLibrary")]
    public static partial void GLUnloadLibrary();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_ExtensionSupported")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_ResetAttributes")]
    public static partial void GLResetAttributes();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetAttribute")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLSetAttribute(GLAttr attr, int value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetAttribute")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLGetAttribute(GLAttr attr, int* value);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_CreateContext")]
    public static partial GLContextState GLCreateContext(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_MakeCurrent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLMakeCurrent(Window window, GLContextState context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentWindow")]
    public static partial Window GLGetCurrentWindow();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentContext")]
    public static partial GLContextState GLGetCurrentContext();

    [LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentDisplay")]
    public static partial void* EGLGetCurrentDisplay();

    [LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentConfig")]
    public static partial void* EGLGetCurrentConfig();

    [LibraryImport(LibraryName, EntryPoint = "SDL_EGL_GetWindowSurface")]
    public static partial void* EGLGetWindowSurface(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
    public static partial void EGLSetAttributeCallbacks(delegate* unmanaged[Cdecl]<void*, nint*> platformattribcallback, delegate* unmanaged[Cdecl]<void*, void*, void*, int*> surfaceattribcallback, delegate* unmanaged[Cdecl]<void*, void*, void*, int*> contextattribcallback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_SetSwapInterval")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLSetSwapInterval(int interval);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_GetSwapInterval")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLGetSwapInterval(int* interval);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_SwapWindow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLSwapWindow(Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GL_DestroyContext")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GLDestroyContext(GLContextState context);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_LoadLibrary")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool VulkanLoadLibrary([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
    public static partial delegate* unmanaged[Cdecl]<void> VulkanGetVkGetInstanceProcAddr();

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_UnloadLibrary")]
    public static partial void VulkanUnloadLibrary();

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
    public static partial sbyte** VulkanGetInstanceExtensions(uint* count);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_CreateSurface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool VulkanCreateSurface(Window window, VkInstanceT instance, VkAllocationCallbacks allocator, VkSurfaceKHRT surface);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_DestroySurface")]
    public static partial void VulkanDestroySurface(VkInstanceT instance, VkSurfaceKHRT surface, VkAllocationCallbacks allocator);

    [LibraryImport(LibraryName, EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool VulkanGetPresentationSupport(VkInstanceT instance, VkPhysicalDeviceT physicaldevice, uint queuefamilyindex);

}
