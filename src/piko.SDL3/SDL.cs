using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public const string LibraryName = "SDL3";

    public const int AssertLevel = 2;
    public const string File = "SDL_assert.h";
    public const string AssertFile = "SDL_assert.h";
    public const int Line = 710;
    public const int NullWhileLoopCondition = (0);
    public const uint AudioMaskBitsize = (0xFFU);
    public const uint AudioMaskFloat = (1U << 8);
    public const uint AudioMaskBigEndian = (1U << 12);
    public const uint AudioMaskSigned = (1U << 15);
    public const uint AudioDeviceDefaultPlayback = ((uint)(0xFFFFFFFFU));
    public const uint AudioDeviceDefaultRecording = ((uint)(0xFFFFFFFEU));
    public const string PropAudiostreamAutoCleanupBoolean = "SDL.audiostream.auto_cleanup";
    public const int Null = 0;
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
    public const string ElfNoteDlopenPrioritySuggested = "suggested";
    public const string ElfNoteDlopenPriorityRecommended = "recommended";
    public const string ElfNoteDlopenPriorityRequired = "required";
    public const int LilEndian = 1234;
    public const int BigEndian = 4321;
    public const int Byteorder = 1234;
    public const int Floatwordorder = 1234;
    public const bool HasBuiltinBswap16 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 8));
    public const bool HasBuiltinBswap32 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 3));
    public const bool HasBuiltinBswap64 = (1) != 0 || (4 > 4 || (4 == 4 && 2 >= 3));
    public const bool HasBrokenBswap = (4 == 2 && 2 <= 95);
    public const uint GlobCaseinsensitive = (1U << 0);
    public const string PropGamepadCapMonoLedBoolean = "SDL.joystick.cap.mono_led";
    public const string PropGamepadCapRgbLedBoolean = "SDL.joystick.cap.rgb_led";
    public const string PropGamepadCapPlayerLedBoolean = "SDL.joystick.cap.player_led";
    public const string PropGamepadCapRumbleBoolean = "SDL.joystick.cap.rumble";
    public const string PropGamepadCapTriggerRumbleBoolean = "SDL.joystick.cap.trigger_rumble";
    public const uint GpuTextureusageSampler = (1U << 0);
    public const uint GpuTextureusageColorTarget = (1U << 1);
    public const uint GpuTextureusageDepthStencilTarget = (1U << 2);
    public const uint GpuTextureusageGraphicsStorageRead = (1U << 3);
    public const uint GpuTextureusageComputeStorageRead = (1U << 4);
    public const uint GpuTextureusageComputeStorageWrite = (1U << 5);
    public const uint GpuTextureusageComputeStorageSimultaneousReadWrite = (1U << 6);
    public const uint GpuBufferusageVertex = (1U << 0);
    public const uint GpuBufferusageIndex = (1U << 1);
    public const uint GpuBufferusageIndirect = (1U << 2);
    public const uint GpuBufferusageGraphicsStorageRead = (1U << 3);
    public const uint GpuBufferusageComputeStorageRead = (1U << 4);
    public const uint GpuBufferusageComputeStorageWrite = (1U << 5);
    public const int GpuShaderformatInvalid = 0;
    public const uint GpuShaderformatPrivate = (1U << 0);
    public const uint GpuShaderformatSpirv = (1U << 1);
    public const uint GpuShaderformatDxbc = (1U << 2);
    public const uint GpuShaderformatDxil = (1U << 3);
    public const uint GpuShaderformatMsl = (1U << 4);
    public const uint GpuShaderformatMetallib = (1U << 5);
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
    public const uint HapticConstant = (1U << 0);
    public const uint HapticSine = (1U << 1);
    public const uint HapticSquare = (1U << 2);
    public const uint HapticTriangle = (1U << 3);
    public const uint HapticSawtoothup = (1U << 4);
    public const uint HapticSawtoothdown = (1U << 5);
    public const uint HapticRamp = (1U << 6);
    public const uint HapticSpring = (1U << 7);
    public const uint HapticDamper = (1U << 8);
    public const uint HapticInertia = (1U << 9);
    public const uint HapticFriction = (1U << 10);
    public const uint HapticLeftright = (1U << 11);
    public const uint HapticReserved1 = (1U << 12);
    public const uint HapticReserved2 = (1U << 13);
    public const uint HapticReserved3 = (1U << 14);
    public const uint HapticCustom = (1U << 15);
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
    public const uint InitAudio = 0x00000010U;
    public const uint InitVideo = 0x00000020U;
    public const uint InitJoystick = 0x00000200U;
    public const uint InitHaptic = 0x00001000U;
    public const uint InitGamepad = 0x00002000U;
    public const uint InitEvents = 0x00004000U;
    public const uint InitSensor = 0x00008000U;
    public const uint InitCamera = 0x00010000U;
    public const string PropAppMetadataNameString = "SDL.app.metadata.name";
    public const string PropAppMetadataVersionString = "SDL.app.metadata.version";
    public const string PropAppMetadataIdentifierString = "SDL.app.metadata.identifier";
    public const string PropAppMetadataCreatorString = "SDL.app.metadata.creator";
    public const string PropAppMetadataCopyrightString = "SDL.app.metadata.copyright";
    public const string PropAppMetadataUrlString = "SDL.app.metadata.url";
    public const string PropAppMetadataTypeString = "SDL.app.metadata.type";
    public const int MmxIntrinsics = 1;
    public const int SseIntrinsics = 1;
    public const int Sse2Intrinsics = 1;
    public const int Sse3Intrinsics = 1;
    public const int Sse41Intrinsics = 1;
    public const int Sse42Intrinsics = 1;
    public const int AvxIntrinsics = 1;
    public const int Avx2Intrinsics = 1;
    public const int Avx512fIntrinsics = 1;
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
    public const int KhronosSupportInt64 = 1;
    public const int KhronosSupportFloat = 1;
    public const int KhronosMaxEnum = 0x7FFFFFFF;
    public const int GlVersion11 = 1;
    public const int GlVersion12 = 1;
    public const int GlVersion13 = 1;
    public const int GlArbImaging = 1;
    public const int GlFalse = 0;
    public const int GlTrue = 1;
    public const int GlByte = 0x1400;
    public const int GlUnsignedByte = 0x1401;
    public const int GlShort = 0x1402;
    public const int GlUnsignedShort = 0x1403;
    public const int GlInt = 0x1404;
    public const int GlUnsignedInt = 0x1405;
    public const int GlFloat = 0x1406;
    public const int Gl2Bytes = 0x1407;
    public const int Gl3Bytes = 0x1408;
    public const int Gl4Bytes = 0x1409;
    public const int GlDouble = 0x140A;
    public const int GlPoints = 0x0000;
    public const int GlLines = 0x0001;
    public const int GlLineLoop = 0x0002;
    public const int GlLineStrip = 0x0003;
    public const int GlTriangles = 0x0004;
    public const int GlTriangleStrip = 0x0005;
    public const int GlTriangleFan = 0x0006;
    public const int GlQuads = 0x0007;
    public const int GlQuadStrip = 0x0008;
    public const int GlPolygon = 0x0009;
    public const int GlVertexArray = 0x8074;
    public const int GlNormalArray = 0x8075;
    public const int GlColorArray = 0x8076;
    public const int GlIndexArray = 0x8077;
    public const int GlTextureCoordArray = 0x8078;
    public const int GlEdgeFlagArray = 0x8079;
    public const int GlVertexArraySize = 0x807A;
    public const int GlVertexArrayType = 0x807B;
    public const int GlVertexArrayStride = 0x807C;
    public const int GlNormalArrayType = 0x807E;
    public const int GlNormalArrayStride = 0x807F;
    public const int GlColorArraySize = 0x8081;
    public const int GlColorArrayType = 0x8082;
    public const int GlColorArrayStride = 0x8083;
    public const int GlIndexArrayType = 0x8085;
    public const int GlIndexArrayStride = 0x8086;
    public const int GlTextureCoordArraySize = 0x8088;
    public const int GlTextureCoordArrayType = 0x8089;
    public const int GlTextureCoordArrayStride = 0x808A;
    public const int GlEdgeFlagArrayStride = 0x808C;
    public const int GlVertexArrayPointer = 0x808E;
    public const int GlNormalArrayPointer = 0x808F;
    public const int GlColorArrayPointer = 0x8090;
    public const int GlIndexArrayPointer = 0x8091;
    public const int GlTextureCoordArrayPointer = 0x8092;
    public const int GlEdgeFlagArrayPointer = 0x8093;
    public const int GlV2f = 0x2A20;
    public const int GlV3f = 0x2A21;
    public const int GlC4ubV2f = 0x2A22;
    public const int GlC4ubV3f = 0x2A23;
    public const int GlC3fV3f = 0x2A24;
    public const int GlN3fV3f = 0x2A25;
    public const int GlC4fN3fV3f = 0x2A26;
    public const int GlT2fV3f = 0x2A27;
    public const int GlT4fV4f = 0x2A28;
    public const int GlT2fC4ubV3f = 0x2A29;
    public const int GlT2fC3fV3f = 0x2A2A;
    public const int GlT2fN3fV3f = 0x2A2B;
    public const int GlT2fC4fN3fV3f = 0x2A2C;
    public const int GlT4fC4fN3fV4f = 0x2A2D;
    public const int GlMatrixMode = 0x0BA0;
    public const int GlModelview = 0x1700;
    public const int GlProjection = 0x1701;
    public const int GlTexture = 0x1702;
    public const int GlPointSmooth = 0x0B10;
    public const int GlPointSize = 0x0B11;
    public const int GlPointSizeGranularity = 0x0B13;
    public const int GlPointSizeRange = 0x0B12;
    public const int GlLineSmooth = 0x0B20;
    public const int GlLineStipple = 0x0B24;
    public const int GlLineStipplePattern = 0x0B25;
    public const int GlLineStippleRepeat = 0x0B26;
    public const int GlLineWidth = 0x0B21;
    public const int GlLineWidthGranularity = 0x0B23;
    public const int GlLineWidthRange = 0x0B22;
    public const int GlPoint = 0x1B00;
    public const int GlLine = 0x1B01;
    public const int GlFill = 0x1B02;
    public const int GlCw = 0x0900;
    public const int GlCcw = 0x0901;
    public const int GlFront = 0x0404;
    public const int GlBack = 0x0405;
    public const int GlPolygonMode = 0x0B40;
    public const int GlPolygonSmooth = 0x0B41;
    public const int GlPolygonStipple = 0x0B42;
    public const int GlEdgeFlag = 0x0B43;
    public const int GlCullFace = 0x0B44;
    public const int GlCullFaceMode = 0x0B45;
    public const int GlFrontFace = 0x0B46;
    public const int GlPolygonOffsetFactor = 0x8038;
    public const int GlPolygonOffsetUnits = 0x2A00;
    public const int GlPolygonOffsetPoint = 0x2A01;
    public const int GlPolygonOffsetLine = 0x2A02;
    public const int GlPolygonOffsetFill = 0x8037;
    public const int GlCompile = 0x1300;
    public const int GlCompileAndExecute = 0x1301;
    public const int GlListBase = 0x0B32;
    public const int GlListIndex = 0x0B33;
    public const int GlListMode = 0x0B30;
    public const int GlNever = 0x0200;
    public const int GlLess = 0x0201;
    public const int GlEqual = 0x0202;
    public const int GlLequal = 0x0203;
    public const int GlGreater = 0x0204;
    public const int GlNotequal = 0x0205;
    public const int GlGequal = 0x0206;
    public const int GlAlways = 0x0207;
    public const int GlDepthTest = 0x0B71;
    public const int GlDepthBits = 0x0D56;
    public const int GlDepthClearValue = 0x0B73;
    public const int GlDepthFunc = 0x0B74;
    public const int GlDepthRange = 0x0B70;
    public const int GlDepthWritemask = 0x0B72;
    public const int GlDepthComponent = 0x1902;
    public const int GlLighting = 0x0B50;
    public const int GlLight0 = 0x4000;
    public const int GlLight1 = 0x4001;
    public const int GlLight2 = 0x4002;
    public const int GlLight3 = 0x4003;
    public const int GlLight4 = 0x4004;
    public const int GlLight5 = 0x4005;
    public const int GlLight6 = 0x4006;
    public const int GlLight7 = 0x4007;
    public const int GlSpotExponent = 0x1205;
    public const int GlSpotCutoff = 0x1206;
    public const int GlConstantAttenuation = 0x1207;
    public const int GlLinearAttenuation = 0x1208;
    public const int GlQuadraticAttenuation = 0x1209;
    public const int GlAmbient = 0x1200;
    public const int GlDiffuse = 0x1201;
    public const int GlSpecular = 0x1202;
    public const int GlShininess = 0x1601;
    public const int GlEmission = 0x1600;
    public const int GlPosition = 0x1203;
    public const int GlSpotDirection = 0x1204;
    public const int GlAmbientAndDiffuse = 0x1602;
    public const int GlColorIndexes = 0x1603;
    public const int GlLightModelTwoSide = 0x0B52;
    public const int GlLightModelLocalViewer = 0x0B51;
    public const int GlLightModelAmbient = 0x0B53;
    public const int GlFrontAndBack = 0x0408;
    public const int GlShadeModel = 0x0B54;
    public const int GlFlat = 0x1D00;
    public const int GlSmooth = 0x1D01;
    public const int GlColorMaterial = 0x0B57;
    public const int GlColorMaterialFace = 0x0B55;
    public const int GlColorMaterialParameter = 0x0B56;
    public const int GlNormalize = 0x0BA1;
    public const int GlClipPlane0 = 0x3000;
    public const int GlClipPlane1 = 0x3001;
    public const int GlClipPlane2 = 0x3002;
    public const int GlClipPlane3 = 0x3003;
    public const int GlClipPlane4 = 0x3004;
    public const int GlClipPlane5 = 0x3005;
    public const int GlAccumRedBits = 0x0D58;
    public const int GlAccumGreenBits = 0x0D59;
    public const int GlAccumBlueBits = 0x0D5A;
    public const int GlAccumAlphaBits = 0x0D5B;
    public const int GlAccumClearValue = 0x0B80;
    public const int GlAccum = 0x0100;
    public const int GlAdd = 0x0104;
    public const int GlLoad = 0x0101;
    public const int GlMult = 0x0103;
    public const int GlReturn = 0x0102;
    public const int GlAlphaTest = 0x0BC0;
    public const int GlAlphaTestRef = 0x0BC2;
    public const int GlAlphaTestFunc = 0x0BC1;
    public const int GlBlend = 0x0BE2;
    public const int GlBlendSrc = 0x0BE1;
    public const int GlBlendDst = 0x0BE0;
    public const int GlZero = 0;
    public const int GlOne = 1;
    public const int GlSrcColor = 0x0300;
    public const int GlOneMinusSrcColor = 0x0301;
    public const int GlSrcAlpha = 0x0302;
    public const int GlOneMinusSrcAlpha = 0x0303;
    public const int GlDstAlpha = 0x0304;
    public const int GlOneMinusDstAlpha = 0x0305;
    public const int GlDstColor = 0x0306;
    public const int GlOneMinusDstColor = 0x0307;
    public const int GlSrcAlphaSaturate = 0x0308;
    public const int GlFeedback = 0x1C01;
    public const int GlRender = 0x1C00;
    public const int GlSelect = 0x1C02;
    public const int Gl2d = 0x0600;
    public const int Gl3d = 0x0601;
    public const int Gl3dColor = 0x0602;
    public const int Gl3dColorTexture = 0x0603;
    public const int Gl4dColorTexture = 0x0604;
    public const int GlPointToken = 0x0701;
    public const int GlLineToken = 0x0702;
    public const int GlLineResetToken = 0x0707;
    public const int GlPolygonToken = 0x0703;
    public const int GlBitmapToken = 0x0704;
    public const int GlDrawPixelToken = 0x0705;
    public const int GlCopyPixelToken = 0x0706;
    public const int GlPassThroughToken = 0x0700;
    public const int GlFeedbackBufferPointer = 0x0DF0;
    public const int GlFeedbackBufferSize = 0x0DF1;
    public const int GlFeedbackBufferType = 0x0DF2;
    public const int GlSelectionBufferPointer = 0x0DF3;
    public const int GlSelectionBufferSize = 0x0DF4;
    public const int GlFog = 0x0B60;
    public const int GlFogMode = 0x0B65;
    public const int GlFogDensity = 0x0B62;
    public const int GlFogColor = 0x0B66;
    public const int GlFogIndex = 0x0B61;
    public const int GlFogStart = 0x0B63;
    public const int GlFogEnd = 0x0B64;
    public const int GlLinear = 0x2601;
    public const int GlExp = 0x0800;
    public const int GlExp2 = 0x0801;
    public const int GlLogicOp = 0x0BF1;
    public const int GlIndexLogicOp = 0x0BF1;
    public const int GlColorLogicOp = 0x0BF2;
    public const int GlLogicOpMode = 0x0BF0;
    public const int GlClear = 0x1500;
    public const int GlSet = 0x150F;
    public const int GlCopy = 0x1503;
    public const int GlCopyInverted = 0x150C;
    public const int GlNoop = 0x1505;
    public const int GlInvert = 0x150A;
    public const int GlAnd = 0x1501;
    public const int GlNand = 0x150E;
    public const int GlOr = 0x1507;
    public const int GlNor = 0x1508;
    public const int GlXor = 0x1506;
    public const int GlEquiv = 0x1509;
    public const int GlAndReverse = 0x1502;
    public const int GlAndInverted = 0x1504;
    public const int GlOrReverse = 0x150B;
    public const int GlOrInverted = 0x150D;
    public const int GlStencilBits = 0x0D57;
    public const int GlStencilTest = 0x0B90;
    public const int GlStencilClearValue = 0x0B91;
    public const int GlStencilFunc = 0x0B92;
    public const int GlStencilValueMask = 0x0B93;
    public const int GlStencilFail = 0x0B94;
    public const int GlStencilPassDepthFail = 0x0B95;
    public const int GlStencilPassDepthPass = 0x0B96;
    public const int GlStencilRef = 0x0B97;
    public const int GlStencilWritemask = 0x0B98;
    public const int GlStencilIndex = 0x1901;
    public const int GlKeep = 0x1E00;
    public const int GlReplace = 0x1E01;
    public const int GlIncr = 0x1E02;
    public const int GlDecr = 0x1E03;
    public const int GlNone = 0;
    public const int GlLeft = 0x0406;
    public const int GlRight = 0x0407;
    public const int GlFrontLeft = 0x0400;
    public const int GlFrontRight = 0x0401;
    public const int GlBackLeft = 0x0402;
    public const int GlBackRight = 0x0403;
    public const int GlAux0 = 0x0409;
    public const int GlAux1 = 0x040A;
    public const int GlAux2 = 0x040B;
    public const int GlAux3 = 0x040C;
    public const int GlColorIndex = 0x1900;
    public const int GlRed = 0x1903;
    public const int GlGreen = 0x1904;
    public const int GlBlue = 0x1905;
    public const int GlAlpha = 0x1906;
    public const int GlLuminance = 0x1909;
    public const int GlLuminanceAlpha = 0x190A;
    public const int GlAlphaBits = 0x0D55;
    public const int GlRedBits = 0x0D52;
    public const int GlGreenBits = 0x0D53;
    public const int GlBlueBits = 0x0D54;
    public const int GlIndexBits = 0x0D51;
    public const int GlSubpixelBits = 0x0D50;
    public const int GlAuxBuffers = 0x0C00;
    public const int GlReadBuffer = 0x0C02;
    public const int GlDrawBuffer = 0x0C01;
    public const int GlDoublebuffer = 0x0C32;
    public const int GlStereo = 0x0C33;
    public const int GlBitmap = 0x1A00;
    public const int GlColor = 0x1800;
    public const int GlDepth = 0x1801;
    public const int GlStencil = 0x1802;
    public const int GlDither = 0x0BD0;
    public const int GlRgb = 0x1907;
    public const int GlRgba = 0x1908;
    public const int GlMaxListNesting = 0x0B31;
    public const int GlMaxEvalOrder = 0x0D30;
    public const int GlMaxLights = 0x0D31;
    public const int GlMaxClipPlanes = 0x0D32;
    public const int GlMaxTextureSize = 0x0D33;
    public const int GlMaxPixelMapTable = 0x0D34;
    public const int GlMaxAttribStackDepth = 0x0D35;
    public const int GlMaxModelviewStackDepth = 0x0D36;
    public const int GlMaxNameStackDepth = 0x0D37;
    public const int GlMaxProjectionStackDepth = 0x0D38;
    public const int GlMaxTextureStackDepth = 0x0D39;
    public const int GlMaxViewportDims = 0x0D3A;
    public const int GlMaxClientAttribStackDepth = 0x0D3B;
    public const int GlAttribStackDepth = 0x0BB0;
    public const int GlClientAttribStackDepth = 0x0BB1;
    public const int GlColorClearValue = 0x0C22;
    public const int GlColorWritemask = 0x0C23;
    public const int GlCurrentIndex = 0x0B01;
    public const int GlCurrentColor = 0x0B00;
    public const int GlCurrentNormal = 0x0B02;
    public const int GlCurrentRasterColor = 0x0B04;
    public const int GlCurrentRasterDistance = 0x0B09;
    public const int GlCurrentRasterIndex = 0x0B05;
    public const int GlCurrentRasterPosition = 0x0B07;
    public const int GlCurrentRasterTextureCoords = 0x0B06;
    public const int GlCurrentRasterPositionValid = 0x0B08;
    public const int GlCurrentTextureCoords = 0x0B03;
    public const int GlIndexClearValue = 0x0C20;
    public const int GlIndexMode = 0x0C30;
    public const int GlIndexWritemask = 0x0C21;
    public const int GlModelviewMatrix = 0x0BA6;
    public const int GlModelviewStackDepth = 0x0BA3;
    public const int GlNameStackDepth = 0x0D70;
    public const int GlProjectionMatrix = 0x0BA7;
    public const int GlProjectionStackDepth = 0x0BA4;
    public const int GlRenderMode = 0x0C40;
    public const int GlRgbaMode = 0x0C31;
    public const int GlTextureMatrix = 0x0BA8;
    public const int GlTextureStackDepth = 0x0BA5;
    public const int GlViewport = 0x0BA2;
    public const int GlAutoNormal = 0x0D80;
    public const int GlMap1Color4 = 0x0D90;
    public const int GlMap1Index = 0x0D91;
    public const int GlMap1Normal = 0x0D92;
    public const int GlMap1TextureCoord1 = 0x0D93;
    public const int GlMap1TextureCoord2 = 0x0D94;
    public const int GlMap1TextureCoord3 = 0x0D95;
    public const int GlMap1TextureCoord4 = 0x0D96;
    public const int GlMap1Vertex3 = 0x0D97;
    public const int GlMap1Vertex4 = 0x0D98;
    public const int GlMap2Color4 = 0x0DB0;
    public const int GlMap2Index = 0x0DB1;
    public const int GlMap2Normal = 0x0DB2;
    public const int GlMap2TextureCoord1 = 0x0DB3;
    public const int GlMap2TextureCoord2 = 0x0DB4;
    public const int GlMap2TextureCoord3 = 0x0DB5;
    public const int GlMap2TextureCoord4 = 0x0DB6;
    public const int GlMap2Vertex3 = 0x0DB7;
    public const int GlMap2Vertex4 = 0x0DB8;
    public const int GlMap1GridDomain = 0x0DD0;
    public const int GlMap1GridSegments = 0x0DD1;
    public const int GlMap2GridDomain = 0x0DD2;
    public const int GlMap2GridSegments = 0x0DD3;
    public const int GlCoeff = 0x0A00;
    public const int GlOrder = 0x0A01;
    public const int GlDomain = 0x0A02;
    public const int GlPerspectiveCorrectionHint = 0x0C50;
    public const int GlPointSmoothHint = 0x0C51;
    public const int GlLineSmoothHint = 0x0C52;
    public const int GlPolygonSmoothHint = 0x0C53;
    public const int GlFogHint = 0x0C54;
    public const int GlDontCare = 0x1100;
    public const int GlFastest = 0x1101;
    public const int GlNicest = 0x1102;
    public const int GlScissorBox = 0x0C10;
    public const int GlScissorTest = 0x0C11;
    public const int GlMapColor = 0x0D10;
    public const int GlMapStencil = 0x0D11;
    public const int GlIndexShift = 0x0D12;
    public const int GlIndexOffset = 0x0D13;
    public const int GlRedScale = 0x0D14;
    public const int GlRedBias = 0x0D15;
    public const int GlGreenScale = 0x0D18;
    public const int GlGreenBias = 0x0D19;
    public const int GlBlueScale = 0x0D1A;
    public const int GlBlueBias = 0x0D1B;
    public const int GlAlphaScale = 0x0D1C;
    public const int GlAlphaBias = 0x0D1D;
    public const int GlDepthScale = 0x0D1E;
    public const int GlDepthBias = 0x0D1F;
    public const int GlPixelMapSToSSize = 0x0CB1;
    public const int GlPixelMapIToISize = 0x0CB0;
    public const int GlPixelMapIToRSize = 0x0CB2;
    public const int GlPixelMapIToGSize = 0x0CB3;
    public const int GlPixelMapIToBSize = 0x0CB4;
    public const int GlPixelMapIToASize = 0x0CB5;
    public const int GlPixelMapRToRSize = 0x0CB6;
    public const int GlPixelMapGToGSize = 0x0CB7;
    public const int GlPixelMapBToBSize = 0x0CB8;
    public const int GlPixelMapAToASize = 0x0CB9;
    public const int GlPixelMapSToS = 0x0C71;
    public const int GlPixelMapIToI = 0x0C70;
    public const int GlPixelMapIToR = 0x0C72;
    public const int GlPixelMapIToG = 0x0C73;
    public const int GlPixelMapIToB = 0x0C74;
    public const int GlPixelMapIToA = 0x0C75;
    public const int GlPixelMapRToR = 0x0C76;
    public const int GlPixelMapGToG = 0x0C77;
    public const int GlPixelMapBToB = 0x0C78;
    public const int GlPixelMapAToA = 0x0C79;
    public const int GlPackAlignment = 0x0D05;
    public const int GlPackLsbFirst = 0x0D01;
    public const int GlPackRowLength = 0x0D02;
    public const int GlPackSkipPixels = 0x0D04;
    public const int GlPackSkipRows = 0x0D03;
    public const int GlPackSwapBytes = 0x0D00;
    public const int GlUnpackAlignment = 0x0CF5;
    public const int GlUnpackLsbFirst = 0x0CF1;
    public const int GlUnpackRowLength = 0x0CF2;
    public const int GlUnpackSkipPixels = 0x0CF4;
    public const int GlUnpackSkipRows = 0x0CF3;
    public const int GlUnpackSwapBytes = 0x0CF0;
    public const int GlZoomX = 0x0D16;
    public const int GlZoomY = 0x0D17;
    public const int GlTextureEnv = 0x2300;
    public const int GlTextureEnvMode = 0x2200;
    public const int GlTexture1d = 0x0DE0;
    public const int GlTexture2d = 0x0DE1;
    public const int GlTextureWrapS = 0x2802;
    public const int GlTextureWrapT = 0x2803;
    public const int GlTextureMagFilter = 0x2800;
    public const int GlTextureMinFilter = 0x2801;
    public const int GlTextureEnvColor = 0x2201;
    public const int GlTextureGenS = 0x0C60;
    public const int GlTextureGenT = 0x0C61;
    public const int GlTextureGenR = 0x0C62;
    public const int GlTextureGenQ = 0x0C63;
    public const int GlTextureGenMode = 0x2500;
    public const int GlTextureBorderColor = 0x1004;
    public const int GlTextureWidth = 0x1000;
    public const int GlTextureHeight = 0x1001;
    public const int GlTextureBorder = 0x1005;
    public const int GlTextureComponents = 0x1003;
    public const int GlTextureRedSize = 0x805C;
    public const int GlTextureGreenSize = 0x805D;
    public const int GlTextureBlueSize = 0x805E;
    public const int GlTextureAlphaSize = 0x805F;
    public const int GlTextureLuminanceSize = 0x8060;
    public const int GlTextureIntensitySize = 0x8061;
    public const int GlNearestMipmapNearest = 0x2700;
    public const int GlNearestMipmapLinear = 0x2702;
    public const int GlLinearMipmapNearest = 0x2701;
    public const int GlLinearMipmapLinear = 0x2703;
    public const int GlObjectLinear = 0x2401;
    public const int GlObjectPlane = 0x2501;
    public const int GlEyeLinear = 0x2400;
    public const int GlEyePlane = 0x2502;
    public const int GlSphereMap = 0x2402;
    public const int GlDecal = 0x2101;
    public const int GlModulate = 0x2100;
    public const int GlNearest = 0x2600;
    public const int GlRepeat = 0x2901;
    public const int GlClamp = 0x2900;
    public const int GlS = 0x2000;
    public const int GlT = 0x2001;
    public const int GlR = 0x2002;
    public const int GlQ = 0x2003;
    public const int GlVendor = 0x1F00;
    public const int GlRenderer = 0x1F01;
    public const int GlVersion = 0x1F02;
    public const int GlExtensions = 0x1F03;
    public const int GlNoError = 0;
    public const int GlInvalidEnum = 0x0500;
    public const int GlInvalidValue = 0x0501;
    public const int GlInvalidOperation = 0x0502;
    public const int GlStackOverflow = 0x0503;
    public const int GlStackUnderflow = 0x0504;
    public const int GlOutOfMemory = 0x0505;
    public const int GlCurrentBit = 0x00000001;
    public const int GlPointBit = 0x00000002;
    public const int GlLineBit = 0x00000004;
    public const int GlPolygonBit = 0x00000008;
    public const int GlPolygonStippleBit = 0x00000010;
    public const int GlPixelModeBit = 0x00000020;
    public const int GlLightingBit = 0x00000040;
    public const int GlFogBit = 0x00000080;
    public const int GlDepthBufferBit = 0x00000100;
    public const int GlAccumBufferBit = 0x00000200;
    public const int GlStencilBufferBit = 0x00000400;
    public const int GlViewportBit = 0x00000800;
    public const int GlTransformBit = 0x00001000;
    public const int GlEnableBit = 0x00002000;
    public const int GlColorBufferBit = 0x00004000;
    public const int GlHintBit = 0x00008000;
    public const int GlEvalBit = 0x00010000;
    public const int GlListBit = 0x00020000;
    public const int GlTextureBit = 0x00040000;
    public const int GlScissorBit = 0x00080000;
    public const int GlAllAttribBits = 0x000FFFFF;
    public const int GlProxyTexture1d = 0x8063;
    public const int GlProxyTexture2d = 0x8064;
    public const int GlTexturePriority = 0x8066;
    public const int GlTextureResident = 0x8067;
    public const int GlTextureBinding1d = 0x8068;
    public const int GlTextureBinding2d = 0x8069;
    public const int GlTextureInternalFormat = 0x1003;
    public const int GlAlpha4 = 0x803B;
    public const int GlAlpha8 = 0x803C;
    public const int GlAlpha12 = 0x803D;
    public const int GlAlpha16 = 0x803E;
    public const int GlLuminance4 = 0x803F;
    public const int GlLuminance8 = 0x8040;
    public const int GlLuminance12 = 0x8041;
    public const int GlLuminance16 = 0x8042;
    public const int GlLuminance4Alpha4 = 0x8043;
    public const int GlLuminance6Alpha2 = 0x8044;
    public const int GlLuminance8Alpha8 = 0x8045;
    public const int GlLuminance12Alpha4 = 0x8046;
    public const int GlLuminance12Alpha12 = 0x8047;
    public const int GlLuminance16Alpha16 = 0x8048;
    public const int GlIntensity = 0x8049;
    public const int GlIntensity4 = 0x804A;
    public const int GlIntensity8 = 0x804B;
    public const int GlIntensity12 = 0x804C;
    public const int GlIntensity16 = 0x804D;
    public const int GlR3G3B2 = 0x2A10;
    public const int GlRgb4 = 0x804F;
    public const int GlRgb5 = 0x8050;
    public const int GlRgb8 = 0x8051;
    public const int GlRgb10 = 0x8052;
    public const int GlRgb12 = 0x8053;
    public const int GlRgb16 = 0x8054;
    public const int GlRgba2 = 0x8055;
    public const int GlRgba4 = 0x8056;
    public const int GlRgb5A1 = 0x8057;
    public const int GlRgba8 = 0x8058;
    public const int GlRgb10A2 = 0x8059;
    public const int GlRgba12 = 0x805A;
    public const int GlRgba16 = 0x805B;
    public const int GlClientPixelStoreBit = 0x00000001;
    public const int GlClientVertexArrayBit = 0x00000002;
    public const uint GlAllClientAttribBits = 0xFFFFFFFF;
    public const uint GlClientAllAttribBits = 0xFFFFFFFF;
    public const int GlRescaleNormal = 0x803A;
    public const int GlClampToEdge = 0x812F;
    public const int GlMaxElementsVertices = 0x80E8;
    public const int GlMaxElementsIndices = 0x80E9;
    public const int GlBgr = 0x80E0;
    public const int GlBgra = 0x80E1;
    public const int GlUnsignedByte332 = 0x8032;
    public const int GlUnsignedByte233Rev = 0x8362;
    public const int GlUnsignedShort565 = 0x8363;
    public const int GlUnsignedShort565Rev = 0x8364;
    public const int GlUnsignedShort4444 = 0x8033;
    public const int GlUnsignedShort4444Rev = 0x8365;
    public const int GlUnsignedShort5551 = 0x8034;
    public const int GlUnsignedShort1555Rev = 0x8366;
    public const int GlUnsignedInt8888 = 0x8035;
    public const int GlUnsignedInt8888Rev = 0x8367;
    public const int GlUnsignedInt1010102 = 0x8036;
    public const int GlUnsignedInt2101010Rev = 0x8368;
    public const int GlLightModelColorControl = 0x81F8;
    public const int GlSingleColor = 0x81F9;
    public const int GlSeparateSpecularColor = 0x81FA;
    public const int GlTextureMinLod = 0x813A;
    public const int GlTextureMaxLod = 0x813B;
    public const int GlTextureBaseLevel = 0x813C;
    public const int GlTextureMaxLevel = 0x813D;
    public const int GlSmoothPointSizeRange = 0x0B12;
    public const int GlSmoothPointSizeGranularity = 0x0B13;
    public const int GlSmoothLineWidthRange = 0x0B22;
    public const int GlSmoothLineWidthGranularity = 0x0B23;
    public const int GlAliasedPointSizeRange = 0x846D;
    public const int GlAliasedLineWidthRange = 0x846E;
    public const int GlPackSkipImages = 0x806B;
    public const int GlPackImageHeight = 0x806C;
    public const int GlUnpackSkipImages = 0x806D;
    public const int GlUnpackImageHeight = 0x806E;
    public const int GlTexture3d = 0x806F;
    public const int GlProxyTexture3d = 0x8070;
    public const int GlTextureDepth = 0x8071;
    public const int GlTextureWrapR = 0x8072;
    public const int GlMax3dTextureSize = 0x8073;
    public const int GlTextureBinding3d = 0x806A;
    public const int GlConstantColor = 0x8001;
    public const int GlOneMinusConstantColor = 0x8002;
    public const int GlConstantAlpha = 0x8003;
    public const int GlOneMinusConstantAlpha = 0x8004;
    public const int GlColorTable = 0x80D0;
    public const int GlPostConvolutionColorTable = 0x80D1;
    public const int GlPostColorMatrixColorTable = 0x80D2;
    public const int GlProxyColorTable = 0x80D3;
    public const int GlProxyPostConvolutionColorTable = 0x80D4;
    public const int GlProxyPostColorMatrixColorTable = 0x80D5;
    public const int GlColorTableScale = 0x80D6;
    public const int GlColorTableBias = 0x80D7;
    public const int GlColorTableFormat = 0x80D8;
    public const int GlColorTableWidth = 0x80D9;
    public const int GlColorTableRedSize = 0x80DA;
    public const int GlColorTableGreenSize = 0x80DB;
    public const int GlColorTableBlueSize = 0x80DC;
    public const int GlColorTableAlphaSize = 0x80DD;
    public const int GlColorTableLuminanceSize = 0x80DE;
    public const int GlColorTableIntensitySize = 0x80DF;
    public const int GlConvolution1d = 0x8010;
    public const int GlConvolution2d = 0x8011;
    public const int GlSeparable2d = 0x8012;
    public const int GlConvolutionBorderMode = 0x8013;
    public const int GlConvolutionFilterScale = 0x8014;
    public const int GlConvolutionFilterBias = 0x8015;
    public const int GlReduce = 0x8016;
    public const int GlConvolutionFormat = 0x8017;
    public const int GlConvolutionWidth = 0x8018;
    public const int GlConvolutionHeight = 0x8019;
    public const int GlMaxConvolutionWidth = 0x801A;
    public const int GlMaxConvolutionHeight = 0x801B;
    public const int GlPostConvolutionRedScale = 0x801C;
    public const int GlPostConvolutionGreenScale = 0x801D;
    public const int GlPostConvolutionBlueScale = 0x801E;
    public const int GlPostConvolutionAlphaScale = 0x801F;
    public const int GlPostConvolutionRedBias = 0x8020;
    public const int GlPostConvolutionGreenBias = 0x8021;
    public const int GlPostConvolutionBlueBias = 0x8022;
    public const int GlPostConvolutionAlphaBias = 0x8023;
    public const int GlConstantBorder = 0x8151;
    public const int GlReplicateBorder = 0x8153;
    public const int GlConvolutionBorderColor = 0x8154;
    public const int GlColorMatrix = 0x80B1;
    public const int GlColorMatrixStackDepth = 0x80B2;
    public const int GlMaxColorMatrixStackDepth = 0x80B3;
    public const int GlPostColorMatrixRedScale = 0x80B4;
    public const int GlPostColorMatrixGreenScale = 0x80B5;
    public const int GlPostColorMatrixBlueScale = 0x80B6;
    public const int GlPostColorMatrixAlphaScale = 0x80B7;
    public const int GlPostColorMatrixRedBias = 0x80B8;
    public const int GlPostColorMatrixGreenBias = 0x80B9;
    public const int GlPostColorMatrixBlueBias = 0x80BA;
    public const int GlPostColorMatrixAlphaBias = 0x80BB;
    public const int GlHistogram = 0x8024;
    public const int GlProxyHistogram = 0x8025;
    public const int GlHistogramWidth = 0x8026;
    public const int GlHistogramFormat = 0x8027;
    public const int GlHistogramRedSize = 0x8028;
    public const int GlHistogramGreenSize = 0x8029;
    public const int GlHistogramBlueSize = 0x802A;
    public const int GlHistogramAlphaSize = 0x802B;
    public const int GlHistogramLuminanceSize = 0x802C;
    public const int GlHistogramSink = 0x802D;
    public const int GlMinmax = 0x802E;
    public const int GlMinmaxFormat = 0x802F;
    public const int GlMinmaxSink = 0x8030;
    public const int GlTableTooLarge = 0x8031;
    public const int GlBlendEquation = 0x8009;
    public const int GlMin = 0x8007;
    public const int GlMax = 0x8008;
    public const int GlFuncAdd = 0x8006;
    public const int GlFuncSubtract = 0x800A;
    public const int GlFuncReverseSubtract = 0x800B;
    public const int GlBlendColor = 0x8005;
    public const int GlTexture0 = 0x84C0;
    public const int GlTexture1 = 0x84C1;
    public const int GlTexture2 = 0x84C2;
    public const int GlTexture3 = 0x84C3;
    public const int GlTexture4 = 0x84C4;
    public const int GlTexture5 = 0x84C5;
    public const int GlTexture6 = 0x84C6;
    public const int GlTexture7 = 0x84C7;
    public const int GlTexture8 = 0x84C8;
    public const int GlTexture9 = 0x84C9;
    public const int GlTexture10 = 0x84CA;
    public const int GlTexture11 = 0x84CB;
    public const int GlTexture12 = 0x84CC;
    public const int GlTexture13 = 0x84CD;
    public const int GlTexture14 = 0x84CE;
    public const int GlTexture15 = 0x84CF;
    public const int GlTexture16 = 0x84D0;
    public const int GlTexture17 = 0x84D1;
    public const int GlTexture18 = 0x84D2;
    public const int GlTexture19 = 0x84D3;
    public const int GlTexture20 = 0x84D4;
    public const int GlTexture21 = 0x84D5;
    public const int GlTexture22 = 0x84D6;
    public const int GlTexture23 = 0x84D7;
    public const int GlTexture24 = 0x84D8;
    public const int GlTexture25 = 0x84D9;
    public const int GlTexture26 = 0x84DA;
    public const int GlTexture27 = 0x84DB;
    public const int GlTexture28 = 0x84DC;
    public const int GlTexture29 = 0x84DD;
    public const int GlTexture30 = 0x84DE;
    public const int GlTexture31 = 0x84DF;
    public const int GlActiveTexture = 0x84E0;
    public const int GlClientActiveTexture = 0x84E1;
    public const int GlMaxTextureUnits = 0x84E2;
    public const int GlNormalMap = 0x8511;
    public const int GlReflectionMap = 0x8512;
    public const int GlTextureCubeMap = 0x8513;
    public const int GlTextureBindingCubeMap = 0x8514;
    public const int GlTextureCubeMapPositiveX = 0x8515;
    public const int GlTextureCubeMapNegativeX = 0x8516;
    public const int GlTextureCubeMapPositiveY = 0x8517;
    public const int GlTextureCubeMapNegativeY = 0x8518;
    public const int GlTextureCubeMapPositiveZ = 0x8519;
    public const int GlTextureCubeMapNegativeZ = 0x851A;
    public const int GlProxyTextureCubeMap = 0x851B;
    public const int GlMaxCubeMapTextureSize = 0x851C;
    public const int GlCompressedAlpha = 0x84E9;
    public const int GlCompressedLuminance = 0x84EA;
    public const int GlCompressedLuminanceAlpha = 0x84EB;
    public const int GlCompressedIntensity = 0x84EC;
    public const int GlCompressedRgb = 0x84ED;
    public const int GlCompressedRgba = 0x84EE;
    public const int GlTextureCompressionHint = 0x84EF;
    public const int GlTextureCompressedImageSize = 0x86A0;
    public const int GlTextureCompressed = 0x86A1;
    public const int GlNumCompressedTextureFormats = 0x86A2;
    public const int GlCompressedTextureFormats = 0x86A3;
    public const int GlMultisample = 0x809D;
    public const int GlSampleAlphaToCoverage = 0x809E;
    public const int GlSampleAlphaToOne = 0x809F;
    public const int GlSampleCoverage = 0x80A0;
    public const int GlSampleBuffers = 0x80A8;
    public const int GlSamples = 0x80A9;
    public const int GlSampleCoverageValue = 0x80AA;
    public const int GlSampleCoverageInvert = 0x80AB;
    public const int GlMultisampleBit = 0x20000000;
    public const int GlTransposeModelviewMatrix = 0x84E3;
    public const int GlTransposeProjectionMatrix = 0x84E4;
    public const int GlTransposeTextureMatrix = 0x84E5;
    public const int GlTransposeColorMatrix = 0x84E6;
    public const int GlCombine = 0x8570;
    public const int GlCombineRgb = 0x8571;
    public const int GlCombineAlpha = 0x8572;
    public const int GlSource0Rgb = 0x8580;
    public const int GlSource1Rgb = 0x8581;
    public const int GlSource2Rgb = 0x8582;
    public const int GlSource0Alpha = 0x8588;
    public const int GlSource1Alpha = 0x8589;
    public const int GlSource2Alpha = 0x858A;
    public const int GlOperand0Rgb = 0x8590;
    public const int GlOperand1Rgb = 0x8591;
    public const int GlOperand2Rgb = 0x8592;
    public const int GlOperand0Alpha = 0x8598;
    public const int GlOperand1Alpha = 0x8599;
    public const int GlOperand2Alpha = 0x859A;
    public const int GlRgbScale = 0x8573;
    public const int GlAddSigned = 0x8574;
    public const int GlInterpolate = 0x8575;
    public const int GlSubtract = 0x84E7;
    public const int GlConstant = 0x8576;
    public const int GlPrimaryColor = 0x8577;
    public const int GlPrevious = 0x8578;
    public const int GlDot3Rgb = 0x86AE;
    public const int GlDot3Rgba = 0x86AF;
    public const int GlClampToBorder = 0x812D;
    public const int GlArbMultitexture = 1;
    public const int GlTexture0Arb = 0x84C0;
    public const int GlTexture1Arb = 0x84C1;
    public const int GlTexture2Arb = 0x84C2;
    public const int GlTexture3Arb = 0x84C3;
    public const int GlTexture4Arb = 0x84C4;
    public const int GlTexture5Arb = 0x84C5;
    public const int GlTexture6Arb = 0x84C6;
    public const int GlTexture7Arb = 0x84C7;
    public const int GlTexture8Arb = 0x84C8;
    public const int GlTexture9Arb = 0x84C9;
    public const int GlTexture10Arb = 0x84CA;
    public const int GlTexture11Arb = 0x84CB;
    public const int GlTexture12Arb = 0x84CC;
    public const int GlTexture13Arb = 0x84CD;
    public const int GlTexture14Arb = 0x84CE;
    public const int GlTexture15Arb = 0x84CF;
    public const int GlTexture16Arb = 0x84D0;
    public const int GlTexture17Arb = 0x84D1;
    public const int GlTexture18Arb = 0x84D2;
    public const int GlTexture19Arb = 0x84D3;
    public const int GlTexture20Arb = 0x84D4;
    public const int GlTexture21Arb = 0x84D5;
    public const int GlTexture22Arb = 0x84D6;
    public const int GlTexture23Arb = 0x84D7;
    public const int GlTexture24Arb = 0x84D8;
    public const int GlTexture25Arb = 0x84D9;
    public const int GlTexture26Arb = 0x84DA;
    public const int GlTexture27Arb = 0x84DB;
    public const int GlTexture28Arb = 0x84DC;
    public const int GlTexture29Arb = 0x84DD;
    public const int GlTexture30Arb = 0x84DE;
    public const int GlTexture31Arb = 0x84DF;
    public const int GlActiveTextureArb = 0x84E0;
    public const int GlClientActiveTextureArb = 0x84E1;
    public const int GlMaxTextureUnitsArb = 0x84E2;
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
    public const int PlatformLinux = 1;
    public const int PlatformUnix = 1;
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
    public const sbyte MaxSint8 = ((sbyte)(0x7F));
    public const sbyte MinSint8 = ((sbyte)(~0x7F));
    public const byte MaxUint8 = ((byte)(0xFF));
    public const byte MinUint8 = ((byte)(0x00));
    public const short MaxSint16 = ((short)(0x7FFF));
    public const short MinSint16 = ((short)(~0x7FFF));
    public const ushort MaxUint16 = ((ushort)(0xFFFF));
    public const ushort MinUint16 = ((ushort)(0x0000));
    public const int MaxSint32 = ((int)(0x7FFFFFFF));
    public const int MinSint32 = ((int)(~0x7FFFFFFF));
    public const uint MaxUint32 = ((uint)(0xFFFFFFFFU));
    public const uint MinUint32 = ((uint)(0x00000000));
    public const nuint MinUint64 = 0x0000000000000000U;
    public const float FltEpsilon = 1.1920928955078125e-07F;
    public const string Pris64 = "ld";
    public const string Priu64 = "lu";
    public const string Prix64 = "lx";
    public const string Prix64 = "lX";
    public const string Pris32 = "d";
    public const string Priu32 = "u";
    public const string Prix32 = "x";
    public const string Prix32 = "X";
    public const string PrillPrefix = "ll";
    public const string Prilld = "lld";
    public const string Prillu = "llu";
    public const string Prillx = "llx";
    public const string Prillx = "llX";
    public const int InvalidUnicodeCodepoint = 0xFFFD;
    public const double PiD = 3.141592653589793238462643383279502884;
    public const float PiF = 3.141592653589793238462643383279502884F;
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
    public const nuint WindowFullscreen = 0x0000000000000001U;
    public const nuint WindowOpengl = 0x0000000000000002U;
    public const nuint WindowOccluded = 0x0000000000000004U;
    public const nuint WindowHidden = 0x0000000000000008U;
    public const nuint WindowBorderless = 0x0000000000000010U;
    public const nuint WindowResizable = 0x0000000000000020U;
    public const nuint WindowMinimized = 0x0000000000000040U;
    public const nuint WindowMaximized = 0x0000000000000080U;
    public const nuint WindowMouseGrabbed = 0x0000000000000100U;
    public const nuint WindowInputFocus = 0x0000000000000200U;
    public const nuint WindowMouseFocus = 0x0000000000000400U;
    public const nuint WindowExternal = 0x0000000000000800U;
    public const nuint WindowModal = 0x0000000000001000U;
    public const nuint WindowHighPixelDensity = 0x0000000000002000U;
    public const nuint WindowMouseCapture = 0x0000000000004000U;
    public const nuint WindowMouseRelativeMode = 0x0000000000008000U;
    public const nuint WindowAlwaysOnTop = 0x0000000000010000U;
    public const nuint WindowUtility = 0x0000000000020000U;
    public const nuint WindowTooltip = 0x0000000000040000U;
    public const nuint WindowPopupMenu = 0x0000000000080000U;
    public const nuint WindowKeyboardGrabbed = 0x0000000000100000U;
    public const nuint WindowFillDocument = 0x0000000000200000U;
    public const nuint WindowVulkan = 0x0000000010000000U;
    public const nuint WindowMetal = 0x0000000020000000U;
    public const nuint WindowTransparent = 0x0000000040000000U;
    public const nuint WindowNotFocusable = 0x0000000080000000U;
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
    public const int WindowSurfaceVsyncDisabled = 0;
    public const int WindowSurfaceVsyncAdaptive = (-1);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ReportAssertion")]
    public static partial AssertState ReportAssertion(AssertData* data, [MarshalAs(UnmanagedType.LPStr)] string func, [MarshalAs(UnmanagedType.LPStr)] string file, int line);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAssertionHandler")]
    public static partial void SetAssertionHandler(delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetDefaultAssertionHandler")]
    public static partial delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAssertionHandler")]
    public static partial delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetAssertionReport")]
    public static partial AssertData* GetAssertionReport();

    [LibraryImport(LibraryName, EntryPoint = "SDL_ResetAssertionReport")]
    public static partial void ResetAssertionReport();

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGetCallback")]
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
    public static partial bool SetAudioPostmixCallback(uint devid, delegate* unmanaged[Cdecl]<void*, SDL_AudioSpec*, float*, int, void> callback, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SwapFloat")]
    public static partial float SwapFloat(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetError")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetError([MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetErrorV")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetErrorV([MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetEventFilter")]
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
    public static partial void FilterEvents(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnumerateDirectory([MarshalAs(UnmanagedType.LPStr)] string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetGamepadBindings")]
    public static partial GamepadBinding** GetGamepadBindings(Gamepad gamepad, int* count);

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
    public static partial bool GPUSupportsShaderFormats(uint formatFlags, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GPUSupportsProperties")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GPUSupportsProperties(uint props);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateGPUDevice")]
    public static partial GPUDevice CreateGPUDevice(uint formatFlags, byte debugMode, [MarshalAs(UnmanagedType.LPStr)] string name);

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
    public static partial uint GetGPUShaderFormats(GPUDevice device);

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
    public static partial bool AcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitForGPUSwapchain")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitForGPUSwapchain(GPUDevice device, Window window);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool WaitAndAcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

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
    public static partial bool Init(uint flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_InitSubSystem")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool InitSubSystem(uint flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_QuitSubSystem")]
    public static partial void QuitSubSystem(uint flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_WasInit")]
    public static partial uint WasInit(uint flags);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_OpenIO")]
    public static partial IOStream OpenIO(IOStreamInterface* iface, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOprintf")]
    public static partial nuint IOprintf(IOStream context, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_IOvprintf")]
    public static partial nuint IOvprintf(IOStream context, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_Log")]
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
    public static partial void SetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> callback, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_main")]
    public static partial int Main(int argc, sbyte** argv);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetMainReady")]
    public static partial void SetMainReady();

    [LibraryImport(LibraryName, EntryPoint = "SDL_RunApp")]
    public static partial int RunApp(int argc, sbyte** argv, delegate* unmanaged[Cdecl]<int, sbyte**, int> mainfunction, void* reserved);

    [LibraryImport(LibraryName, EntryPoint = "SDL_EnterAppMainCallbacks")]
    public static partial int EnterAppMainCallbacks(int argc, sbyte** argv, delegate* unmanaged[Cdecl]<void**, int, sbyte**, SDL_AppResult> appinit, delegate* unmanaged[Cdecl]<void*, SDL_AppResult> appiter, delegate* unmanaged[Cdecl]<void*, SDL_Event*, SDL_AppResult> appevent, delegate* unmanaged[Cdecl]<void*, SDL_AppResult, void> appquit);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GDKSuspendComplete")]
    public static partial void GDKSuspendComplete();

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetRelativeMouseTransform")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetRelativeMouseTransform(delegate* unmanaged[Cdecl]<void*, ulong, SDL_Window*, uint, float*, float*, void> callback, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "glClearIndex")]
    public static partial void GlClearIndex(float c);

    [LibraryImport(LibraryName, EntryPoint = "glClearColor")]
    public static partial void GlClearColor(float red, float green, float blue, float alpha);

    [LibraryImport(LibraryName, EntryPoint = "glClear")]
    public static partial void GlClear(uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glIndexMask")]
    public static partial void GlIndexMask(uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glColorMask")]
    public static partial void GlColorMask(byte red, byte green, byte blue, byte alpha);

    [LibraryImport(LibraryName, EntryPoint = "glAlphaFunc")]
    public static partial void GlAlphaFunc(uint func, float @ref);

    [LibraryImport(LibraryName, EntryPoint = "glBlendFunc")]
    public static partial void GlBlendFunc(uint sfactor, uint dfactor);

    [LibraryImport(LibraryName, EntryPoint = "glLogicOp")]
    public static partial void GlLogicOp(uint opcode);

    [LibraryImport(LibraryName, EntryPoint = "glCullFace")]
    public static partial void GlCullFace(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glFrontFace")]
    public static partial void GlFrontFace(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glPointSize")]
    public static partial void GlPointSize(float size);

    [LibraryImport(LibraryName, EntryPoint = "glLineWidth")]
    public static partial void GlLineWidth(float width);

    [LibraryImport(LibraryName, EntryPoint = "glLineStipple")]
    public static partial void GlLineStipple(int factor, ushort pattern);

    [LibraryImport(LibraryName, EntryPoint = "glPolygonMode")]
    public static partial void GlPolygonMode(uint face, uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glPolygonOffset")]
    public static partial void GlPolygonOffset(float factor, float units);

    [LibraryImport(LibraryName, EntryPoint = "glPolygonStipple")]
    public static partial void GlPolygonStipple(byte* mask);

    [LibraryImport(LibraryName, EntryPoint = "glGetPolygonStipple")]
    public static partial void GlGetPolygonStipple(byte* mask);

    [LibraryImport(LibraryName, EntryPoint = "glEdgeFlag")]
    public static partial void GlEdgeFlag(byte flag);

    [LibraryImport(LibraryName, EntryPoint = "glEdgeFlagv")]
    public static partial void GlEdgeFlagv(byte* flag);

    [LibraryImport(LibraryName, EntryPoint = "glScissor")]
    public static partial void GlScissor(int x, int y, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "glClipPlane")]
    public static partial void GlClipPlane(uint plane, double* equation);

    [LibraryImport(LibraryName, EntryPoint = "glGetClipPlane")]
    public static partial void GlGetClipPlane(uint plane, double* equation);

    [LibraryImport(LibraryName, EntryPoint = "glDrawBuffer")]
    public static partial void GlDrawBuffer(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glReadBuffer")]
    public static partial void GlReadBuffer(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glEnable")]
    public static partial void GlEnable(uint cap);

    [LibraryImport(LibraryName, EntryPoint = "glDisable")]
    public static partial void GlDisable(uint cap);

    [LibraryImport(LibraryName, EntryPoint = "glIsEnabled")]
    public static partial byte GlIsEnabled(uint cap);

    [LibraryImport(LibraryName, EntryPoint = "glEnableClientState")]
    public static partial void GlEnableClientState(uint cap);

    [LibraryImport(LibraryName, EntryPoint = "glDisableClientState")]
    public static partial void GlDisableClientState(uint cap);

    [LibraryImport(LibraryName, EntryPoint = "glGetBooleanv")]
    public static partial void GlGetBooleanv(uint pname, byte* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetDoublev")]
    public static partial void GlGetDoublev(uint pname, double* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetFloatv")]
    public static partial void GlGetFloatv(uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetIntegerv")]
    public static partial void GlGetIntegerv(uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glPushAttrib")]
    public static partial void GlPushAttrib(uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glPopAttrib")]
    public static partial void GlPopAttrib();

    [LibraryImport(LibraryName, EntryPoint = "glPushClientAttrib")]
    public static partial void GlPushClientAttrib(uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glPopClientAttrib")]
    public static partial void GlPopClientAttrib();

    [LibraryImport(LibraryName, EntryPoint = "glRenderMode")]
    public static partial int GlRenderMode(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glGetError")]
    public static partial uint GlGetError();

    [LibraryImport(LibraryName, EntryPoint = "glGetString")]
    public static partial byte* GlGetString(uint name);

    [LibraryImport(LibraryName, EntryPoint = "glFinish")]
    public static partial void GlFinish();

    [LibraryImport(LibraryName, EntryPoint = "glFlush")]
    public static partial void GlFlush();

    [LibraryImport(LibraryName, EntryPoint = "glHint")]
    public static partial void GlHint(uint target, uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glClearDepth")]
    public static partial void GlClearDepth(double depth);

    [LibraryImport(LibraryName, EntryPoint = "glDepthFunc")]
    public static partial void GlDepthFunc(uint func);

    [LibraryImport(LibraryName, EntryPoint = "glDepthMask")]
    public static partial void GlDepthMask(byte flag);

    [LibraryImport(LibraryName, EntryPoint = "glDepthRange")]
    public static partial void GlDepthRange(double nearVal, double farVal);

    [LibraryImport(LibraryName, EntryPoint = "glClearAccum")]
    public static partial void GlClearAccum(float red, float green, float blue, float alpha);

    [LibraryImport(LibraryName, EntryPoint = "glAccum")]
    public static partial void GlAccum(uint op, float value);

    [LibraryImport(LibraryName, EntryPoint = "glMatrixMode")]
    public static partial void GlMatrixMode(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glOrtho")]
    public static partial void GlOrtho(double left, double right, double bottom, double top, double nearVal, double farVal);

    [LibraryImport(LibraryName, EntryPoint = "glFrustum")]
    public static partial void GlFrustum(double left, double right, double bottom, double top, double nearVal, double farVal);

    [LibraryImport(LibraryName, EntryPoint = "glViewport")]
    public static partial void GlViewport(int x, int y, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "glPushMatrix")]
    public static partial void GlPushMatrix();

    [LibraryImport(LibraryName, EntryPoint = "glPopMatrix")]
    public static partial void GlPopMatrix();

    [LibraryImport(LibraryName, EntryPoint = "glLoadIdentity")]
    public static partial void GlLoadIdentity();

    [LibraryImport(LibraryName, EntryPoint = "glLoadMatrixd")]
    public static partial void GlLoadMatrixd(double* m);

    [LibraryImport(LibraryName, EntryPoint = "glLoadMatrixf")]
    public static partial void GlLoadMatrixf(float* m);

    [LibraryImport(LibraryName, EntryPoint = "glMultMatrixd")]
    public static partial void GlMultMatrixd(double* m);

    [LibraryImport(LibraryName, EntryPoint = "glMultMatrixf")]
    public static partial void GlMultMatrixf(float* m);

    [LibraryImport(LibraryName, EntryPoint = "glRotated")]
    public static partial void GlRotated(double angle, double x, double y, double z);

    [LibraryImport(LibraryName, EntryPoint = "glRotatef")]
    public static partial void GlRotatef(float angle, float x, float y, float z);

    [LibraryImport(LibraryName, EntryPoint = "glScaled")]
    public static partial void GlScaled(double x, double y, double z);

    [LibraryImport(LibraryName, EntryPoint = "glScalef")]
    public static partial void GlScalef(float x, float y, float z);

    [LibraryImport(LibraryName, EntryPoint = "glTranslated")]
    public static partial void GlTranslated(double x, double y, double z);

    [LibraryImport(LibraryName, EntryPoint = "glTranslatef")]
    public static partial void GlTranslatef(float x, float y, float z);

    [LibraryImport(LibraryName, EntryPoint = "glIsList")]
    public static partial byte GlIsList(uint list);

    [LibraryImport(LibraryName, EntryPoint = "glDeleteLists")]
    public static partial void GlDeleteLists(uint list, int range);

    [LibraryImport(LibraryName, EntryPoint = "glGenLists")]
    public static partial uint GlGenLists(int range);

    [LibraryImport(LibraryName, EntryPoint = "glNewList")]
    public static partial void GlNewList(uint list, uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glEndList")]
    public static partial void GlEndList();

    [LibraryImport(LibraryName, EntryPoint = "glCallList")]
    public static partial void GlCallList(uint list);

    [LibraryImport(LibraryName, EntryPoint = "glCallLists")]
    public static partial void GlCallLists(int n, uint type, void* lists);

    [LibraryImport(LibraryName, EntryPoint = "glListBase")]
    public static partial void GlListBase(uint @base);

    [LibraryImport(LibraryName, EntryPoint = "glBegin")]
    public static partial void GlBegin(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glEnd")]
    public static partial void GlEnd();

    [LibraryImport(LibraryName, EntryPoint = "glVertex2d")]
    public static partial void GlVertex2d(double x, double y);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2f")]
    public static partial void GlVertex2f(float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2i")]
    public static partial void GlVertex2i(int x, int y);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2s")]
    public static partial void GlVertex2s(short x, short y);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3d")]
    public static partial void GlVertex3d(double x, double y, double z);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3f")]
    public static partial void GlVertex3f(float x, float y, float z);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3i")]
    public static partial void GlVertex3i(int x, int y, int z);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3s")]
    public static partial void GlVertex3s(short x, short y, short z);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4d")]
    public static partial void GlVertex4d(double x, double y, double z, double w);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4f")]
    public static partial void GlVertex4f(float x, float y, float z, float w);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4i")]
    public static partial void GlVertex4i(int x, int y, int z, int w);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4s")]
    public static partial void GlVertex4s(short x, short y, short z, short w);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2dv")]
    public static partial void GlVertex2dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2fv")]
    public static partial void GlVertex2fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2iv")]
    public static partial void GlVertex2iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex2sv")]
    public static partial void GlVertex2sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3dv")]
    public static partial void GlVertex3dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3fv")]
    public static partial void GlVertex3fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3iv")]
    public static partial void GlVertex3iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex3sv")]
    public static partial void GlVertex3sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4dv")]
    public static partial void GlVertex4dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4fv")]
    public static partial void GlVertex4fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4iv")]
    public static partial void GlVertex4iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glVertex4sv")]
    public static partial void GlVertex4sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3b")]
    public static partial void GlNormal3b(sbyte nx, sbyte ny, sbyte nz);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3d")]
    public static partial void GlNormal3d(double nx, double ny, double nz);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3f")]
    public static partial void GlNormal3f(float nx, float ny, float nz);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3i")]
    public static partial void GlNormal3i(int nx, int ny, int nz);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3s")]
    public static partial void GlNormal3s(short nx, short ny, short nz);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3bv")]
    public static partial void GlNormal3bv([MarshalAs(UnmanagedType.LPStr)] string v);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3dv")]
    public static partial void GlNormal3dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3fv")]
    public static partial void GlNormal3fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3iv")]
    public static partial void GlNormal3iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glNormal3sv")]
    public static partial void GlNormal3sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glIndexd")]
    public static partial void GlIndexd(double c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexf")]
    public static partial void GlIndexf(float c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexi")]
    public static partial void GlIndexi(int c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexs")]
    public static partial void GlIndexs(short c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexub")]
    public static partial void GlIndexub(byte c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexdv")]
    public static partial void GlIndexdv(double* c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexfv")]
    public static partial void GlIndexfv(float* c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexiv")]
    public static partial void GlIndexiv(int* c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexsv")]
    public static partial void GlIndexsv(short* c);

    [LibraryImport(LibraryName, EntryPoint = "glIndexubv")]
    public static partial void GlIndexubv(byte* c);

    [LibraryImport(LibraryName, EntryPoint = "glColor3b")]
    public static partial void GlColor3b(sbyte red, sbyte green, sbyte blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3d")]
    public static partial void GlColor3d(double red, double green, double blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3f")]
    public static partial void GlColor3f(float red, float green, float blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3i")]
    public static partial void GlColor3i(int red, int green, int blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3s")]
    public static partial void GlColor3s(short red, short green, short blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3ub")]
    public static partial void GlColor3ub(byte red, byte green, byte blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3ui")]
    public static partial void GlColor3ui(uint red, uint green, uint blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor3us")]
    public static partial void GlColor3us(ushort red, ushort green, ushort blue);

    [LibraryImport(LibraryName, EntryPoint = "glColor4b")]
    public static partial void GlColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4d")]
    public static partial void GlColor4d(double red, double green, double blue, double alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4f")]
    public static partial void GlColor4f(float red, float green, float blue, float alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4i")]
    public static partial void GlColor4i(int red, int green, int blue, int alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4s")]
    public static partial void GlColor4s(short red, short green, short blue, short alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4ub")]
    public static partial void GlColor4ub(byte red, byte green, byte blue, byte alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4ui")]
    public static partial void GlColor4ui(uint red, uint green, uint blue, uint alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor4us")]
    public static partial void GlColor4us(ushort red, ushort green, ushort blue, ushort alpha);

    [LibraryImport(LibraryName, EntryPoint = "glColor3bv")]
    public static partial void GlColor3bv([MarshalAs(UnmanagedType.LPStr)] string v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3dv")]
    public static partial void GlColor3dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3fv")]
    public static partial void GlColor3fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3iv")]
    public static partial void GlColor3iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3sv")]
    public static partial void GlColor3sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3ubv")]
    public static partial void GlColor3ubv(byte* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3uiv")]
    public static partial void GlColor3uiv(uint* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor3usv")]
    public static partial void GlColor3usv(ushort* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4bv")]
    public static partial void GlColor4bv([MarshalAs(UnmanagedType.LPStr)] string v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4dv")]
    public static partial void GlColor4dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4fv")]
    public static partial void GlColor4fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4iv")]
    public static partial void GlColor4iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4sv")]
    public static partial void GlColor4sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4ubv")]
    public static partial void GlColor4ubv(byte* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4uiv")]
    public static partial void GlColor4uiv(uint* v);

    [LibraryImport(LibraryName, EntryPoint = "glColor4usv")]
    public static partial void GlColor4usv(ushort* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1d")]
    public static partial void GlTexCoord1d(double s);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1f")]
    public static partial void GlTexCoord1f(float s);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1i")]
    public static partial void GlTexCoord1i(int s);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1s")]
    public static partial void GlTexCoord1s(short s);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2d")]
    public static partial void GlTexCoord2d(double s, double t);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2f")]
    public static partial void GlTexCoord2f(float s, float t);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2i")]
    public static partial void GlTexCoord2i(int s, int t);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2s")]
    public static partial void GlTexCoord2s(short s, short t);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3d")]
    public static partial void GlTexCoord3d(double s, double t, double r);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3f")]
    public static partial void GlTexCoord3f(float s, float t, float r);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3i")]
    public static partial void GlTexCoord3i(int s, int t, int r);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3s")]
    public static partial void GlTexCoord3s(short s, short t, short r);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4d")]
    public static partial void GlTexCoord4d(double s, double t, double r, double q);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4f")]
    public static partial void GlTexCoord4f(float s, float t, float r, float q);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4i")]
    public static partial void GlTexCoord4i(int s, int t, int r, int q);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4s")]
    public static partial void GlTexCoord4s(short s, short t, short r, short q);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1dv")]
    public static partial void GlTexCoord1dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1fv")]
    public static partial void GlTexCoord1fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1iv")]
    public static partial void GlTexCoord1iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord1sv")]
    public static partial void GlTexCoord1sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2dv")]
    public static partial void GlTexCoord2dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2fv")]
    public static partial void GlTexCoord2fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2iv")]
    public static partial void GlTexCoord2iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord2sv")]
    public static partial void GlTexCoord2sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3dv")]
    public static partial void GlTexCoord3dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3fv")]
    public static partial void GlTexCoord3fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3iv")]
    public static partial void GlTexCoord3iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord3sv")]
    public static partial void GlTexCoord3sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4dv")]
    public static partial void GlTexCoord4dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4fv")]
    public static partial void GlTexCoord4fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4iv")]
    public static partial void GlTexCoord4iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoord4sv")]
    public static partial void GlTexCoord4sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2d")]
    public static partial void GlRasterPos2d(double x, double y);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2f")]
    public static partial void GlRasterPos2f(float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2i")]
    public static partial void GlRasterPos2i(int x, int y);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2s")]
    public static partial void GlRasterPos2s(short x, short y);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3d")]
    public static partial void GlRasterPos3d(double x, double y, double z);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3f")]
    public static partial void GlRasterPos3f(float x, float y, float z);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3i")]
    public static partial void GlRasterPos3i(int x, int y, int z);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3s")]
    public static partial void GlRasterPos3s(short x, short y, short z);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4d")]
    public static partial void GlRasterPos4d(double x, double y, double z, double w);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4f")]
    public static partial void GlRasterPos4f(float x, float y, float z, float w);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4i")]
    public static partial void GlRasterPos4i(int x, int y, int z, int w);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4s")]
    public static partial void GlRasterPos4s(short x, short y, short z, short w);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2dv")]
    public static partial void GlRasterPos2dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2fv")]
    public static partial void GlRasterPos2fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2iv")]
    public static partial void GlRasterPos2iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos2sv")]
    public static partial void GlRasterPos2sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3dv")]
    public static partial void GlRasterPos3dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3fv")]
    public static partial void GlRasterPos3fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3iv")]
    public static partial void GlRasterPos3iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos3sv")]
    public static partial void GlRasterPos3sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4dv")]
    public static partial void GlRasterPos4dv(double* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4fv")]
    public static partial void GlRasterPos4fv(float* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4iv")]
    public static partial void GlRasterPos4iv(int* v);

    [LibraryImport(LibraryName, EntryPoint = "glRasterPos4sv")]
    public static partial void GlRasterPos4sv(short* v);

    [LibraryImport(LibraryName, EntryPoint = "glRectd")]
    public static partial void GlRectd(double x1, double y1, double x2, double y2);

    [LibraryImport(LibraryName, EntryPoint = "glRectf")]
    public static partial void GlRectf(float x1, float y1, float x2, float y2);

    [LibraryImport(LibraryName, EntryPoint = "glRecti")]
    public static partial void GlRecti(int x1, int y1, int x2, int y2);

    [LibraryImport(LibraryName, EntryPoint = "glRects")]
    public static partial void GlRects(short x1, short y1, short x2, short y2);

    [LibraryImport(LibraryName, EntryPoint = "glRectdv")]
    public static partial void GlRectdv(double* v1, double* v2);

    [LibraryImport(LibraryName, EntryPoint = "glRectfv")]
    public static partial void GlRectfv(float* v1, float* v2);

    [LibraryImport(LibraryName, EntryPoint = "glRectiv")]
    public static partial void GlRectiv(int* v1, int* v2);

    [LibraryImport(LibraryName, EntryPoint = "glRectsv")]
    public static partial void GlRectsv(short* v1, short* v2);

    [LibraryImport(LibraryName, EntryPoint = "glVertexPointer")]
    public static partial void GlVertexPointer(int size, uint type, int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glNormalPointer")]
    public static partial void GlNormalPointer(uint type, int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glColorPointer")]
    public static partial void GlColorPointer(int size, uint type, int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glIndexPointer")]
    public static partial void GlIndexPointer(uint type, int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glTexCoordPointer")]
    public static partial void GlTexCoordPointer(int size, uint type, int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glEdgeFlagPointer")]
    public static partial void GlEdgeFlagPointer(int stride, void* ptr);

    [LibraryImport(LibraryName, EntryPoint = "glGetPointerv")]
    public static partial void GlGetPointerv(uint pname, void** @params);

    [LibraryImport(LibraryName, EntryPoint = "glArrayElement")]
    public static partial void GlArrayElement(int i);

    [LibraryImport(LibraryName, EntryPoint = "glDrawArrays")]
    public static partial void GlDrawArrays(uint mode, int first, int count);

    [LibraryImport(LibraryName, EntryPoint = "glDrawElements")]
    public static partial void GlDrawElements(uint mode, int count, uint type, void* indices);

    [LibraryImport(LibraryName, EntryPoint = "glInterleavedArrays")]
    public static partial void GlInterleavedArrays(uint format, int stride, void* pointer);

    [LibraryImport(LibraryName, EntryPoint = "glShadeModel")]
    public static partial void GlShadeModel(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glLightf")]
    public static partial void GlLightf(uint light, uint pname, float param2);

    [LibraryImport(LibraryName, EntryPoint = "glLighti")]
    public static partial void GlLighti(uint light, uint pname, int param2);

    [LibraryImport(LibraryName, EntryPoint = "glLightfv")]
    public static partial void GlLightfv(uint light, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glLightiv")]
    public static partial void GlLightiv(uint light, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetLightfv")]
    public static partial void GlGetLightfv(uint light, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetLightiv")]
    public static partial void GlGetLightiv(uint light, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glLightModelf")]
    public static partial void GlLightModelf(uint pname, float param1);

    [LibraryImport(LibraryName, EntryPoint = "glLightModeli")]
    public static partial void GlLightModeli(uint pname, int param1);

    [LibraryImport(LibraryName, EntryPoint = "glLightModelfv")]
    public static partial void GlLightModelfv(uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glLightModeliv")]
    public static partial void GlLightModeliv(uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glMaterialf")]
    public static partial void GlMaterialf(uint face, uint pname, float param2);

    [LibraryImport(LibraryName, EntryPoint = "glMateriali")]
    public static partial void GlMateriali(uint face, uint pname, int param2);

    [LibraryImport(LibraryName, EntryPoint = "glMaterialfv")]
    public static partial void GlMaterialfv(uint face, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glMaterialiv")]
    public static partial void GlMaterialiv(uint face, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetMaterialfv")]
    public static partial void GlGetMaterialfv(uint face, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetMaterialiv")]
    public static partial void GlGetMaterialiv(uint face, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glColorMaterial")]
    public static partial void GlColorMaterial(uint face, uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glPixelZoom")]
    public static partial void GlPixelZoom(float xfactor, float yfactor);

    [LibraryImport(LibraryName, EntryPoint = "glPixelStoref")]
    public static partial void GlPixelStoref(uint pname, float param1);

    [LibraryImport(LibraryName, EntryPoint = "glPixelStorei")]
    public static partial void GlPixelStorei(uint pname, int param1);

    [LibraryImport(LibraryName, EntryPoint = "glPixelTransferf")]
    public static partial void GlPixelTransferf(uint pname, float param1);

    [LibraryImport(LibraryName, EntryPoint = "glPixelTransferi")]
    public static partial void GlPixelTransferi(uint pname, int param1);

    [LibraryImport(LibraryName, EntryPoint = "glPixelMapfv")]
    public static partial void GlPixelMapfv(uint map, int mapsize, float* values);

    [LibraryImport(LibraryName, EntryPoint = "glPixelMapuiv")]
    public static partial void GlPixelMapuiv(uint map, int mapsize, uint* values);

    [LibraryImport(LibraryName, EntryPoint = "glPixelMapusv")]
    public static partial void GlPixelMapusv(uint map, int mapsize, ushort* values);

    [LibraryImport(LibraryName, EntryPoint = "glGetPixelMapfv")]
    public static partial void GlGetPixelMapfv(uint map, float* values);

    [LibraryImport(LibraryName, EntryPoint = "glGetPixelMapuiv")]
    public static partial void GlGetPixelMapuiv(uint map, uint* values);

    [LibraryImport(LibraryName, EntryPoint = "glGetPixelMapusv")]
    public static partial void GlGetPixelMapusv(uint map, ushort* values);

    [LibraryImport(LibraryName, EntryPoint = "glBitmap")]
    public static partial void GlBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

    [LibraryImport(LibraryName, EntryPoint = "glReadPixels")]
    public static partial void GlReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glDrawPixels")]
    public static partial void GlDrawPixels(int width, int height, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glCopyPixels")]
    public static partial void GlCopyPixels(int x, int y, int width, int height, uint type);

    [LibraryImport(LibraryName, EntryPoint = "glStencilFunc")]
    public static partial void GlStencilFunc(uint func, int @ref, uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glStencilMask")]
    public static partial void GlStencilMask(uint mask);

    [LibraryImport(LibraryName, EntryPoint = "glStencilOp")]
    public static partial void GlStencilOp(uint fail, uint zfail, uint zpass);

    [LibraryImport(LibraryName, EntryPoint = "glClearStencil")]
    public static partial void GlClearStencil(int s);

    [LibraryImport(LibraryName, EntryPoint = "glTexGend")]
    public static partial void GlTexGend(uint coord, uint pname, double param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexGenf")]
    public static partial void GlTexGenf(uint coord, uint pname, float param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexGeni")]
    public static partial void GlTexGeni(uint coord, uint pname, int param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexGendv")]
    public static partial void GlTexGendv(uint coord, uint pname, double* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexGenfv")]
    public static partial void GlTexGenfv(uint coord, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexGeniv")]
    public static partial void GlTexGeniv(uint coord, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexGendv")]
    public static partial void GlGetTexGendv(uint coord, uint pname, double* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexGenfv")]
    public static partial void GlGetTexGenfv(uint coord, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexGeniv")]
    public static partial void GlGetTexGeniv(uint coord, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexEnvf")]
    public static partial void GlTexEnvf(uint target, uint pname, float param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexEnvi")]
    public static partial void GlTexEnvi(uint target, uint pname, int param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexEnvfv")]
    public static partial void GlTexEnvfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexEnviv")]
    public static partial void GlTexEnviv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexEnvfv")]
    public static partial void GlGetTexEnvfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexEnviv")]
    public static partial void GlGetTexEnviv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexParameterf")]
    public static partial void GlTexParameterf(uint target, uint pname, float param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexParameteri")]
    public static partial void GlTexParameteri(uint target, uint pname, int param2);

    [LibraryImport(LibraryName, EntryPoint = "glTexParameterfv")]
    public static partial void GlTexParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexParameteriv")]
    public static partial void GlTexParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexParameterfv")]
    public static partial void GlGetTexParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexParameteriv")]
    public static partial void GlGetTexParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexLevelParameterfv")]
    public static partial void GlGetTexLevelParameterfv(uint target, int level, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexLevelParameteriv")]
    public static partial void GlGetTexLevelParameteriv(uint target, int level, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glTexImage1D")]
    public static partial void GlTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glTexImage2D")]
    public static partial void GlTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glGetTexImage")]
    public static partial void GlGetTexImage(uint target, int level, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glGenTextures")]
    public static partial void GlGenTextures(int n, uint* textures);

    [LibraryImport(LibraryName, EntryPoint = "glDeleteTextures")]
    public static partial void GlDeleteTextures(int n, uint* textures);

    [LibraryImport(LibraryName, EntryPoint = "glBindTexture")]
    public static partial void GlBindTexture(uint target, uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glPrioritizeTextures")]
    public static partial void GlPrioritizeTextures(int n, uint* textures, float* priorities);

    [LibraryImport(LibraryName, EntryPoint = "glAreTexturesResident")]
    public static partial byte GlAreTexturesResident(int n, uint* textures, byte* residences);

    [LibraryImport(LibraryName, EntryPoint = "glIsTexture")]
    public static partial byte GlIsTexture(uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glTexSubImage1D")]
    public static partial void GlTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glTexSubImage2D")]
    public static partial void GlTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glCopyTexImage1D")]
    public static partial void GlCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

    [LibraryImport(LibraryName, EntryPoint = "glCopyTexImage2D")]
    public static partial void GlCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

    [LibraryImport(LibraryName, EntryPoint = "glCopyTexSubImage1D")]
    public static partial void GlCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

    [LibraryImport(LibraryName, EntryPoint = "glCopyTexSubImage2D")]
    public static partial void GlCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "glMap1d")]
    public static partial void GlMap1d(uint target, double u1, double u2, int stride, int order, double* points);

    [LibraryImport(LibraryName, EntryPoint = "glMap1f")]
    public static partial void GlMap1f(uint target, float u1, float u2, int stride, int order, float* points);

    [LibraryImport(LibraryName, EntryPoint = "glMap2d")]
    public static partial void GlMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

    [LibraryImport(LibraryName, EntryPoint = "glMap2f")]
    public static partial void GlMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

    [LibraryImport(LibraryName, EntryPoint = "glGetMapdv")]
    public static partial void GlGetMapdv(uint target, uint query, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glGetMapfv")]
    public static partial void GlGetMapfv(uint target, uint query, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glGetMapiv")]
    public static partial void GlGetMapiv(uint target, uint query, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord1d")]
    public static partial void GlEvalCoord1d(double u);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord1f")]
    public static partial void GlEvalCoord1f(float u);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord1dv")]
    public static partial void GlEvalCoord1dv(double* u);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord1fv")]
    public static partial void GlEvalCoord1fv(float* u);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord2d")]
    public static partial void GlEvalCoord2d(double u, double v);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord2f")]
    public static partial void GlEvalCoord2f(float u, float v);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord2dv")]
    public static partial void GlEvalCoord2dv(double* u);

    [LibraryImport(LibraryName, EntryPoint = "glEvalCoord2fv")]
    public static partial void GlEvalCoord2fv(float* u);

    [LibraryImport(LibraryName, EntryPoint = "glMapGrid1d")]
    public static partial void GlMapGrid1d(int un, double u1, double u2);

    [LibraryImport(LibraryName, EntryPoint = "glMapGrid1f")]
    public static partial void GlMapGrid1f(int un, float u1, float u2);

    [LibraryImport(LibraryName, EntryPoint = "glMapGrid2d")]
    public static partial void GlMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

    [LibraryImport(LibraryName, EntryPoint = "glMapGrid2f")]
    public static partial void GlMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

    [LibraryImport(LibraryName, EntryPoint = "glEvalPoint1")]
    public static partial void GlEvalPoint1(int i);

    [LibraryImport(LibraryName, EntryPoint = "glEvalPoint2")]
    public static partial void GlEvalPoint2(int i, int j);

    [LibraryImport(LibraryName, EntryPoint = "glEvalMesh1")]
    public static partial void GlEvalMesh1(uint mode, int i1, int i2);

    [LibraryImport(LibraryName, EntryPoint = "glEvalMesh2")]
    public static partial void GlEvalMesh2(uint mode, int i1, int i2, int j1, int j2);

    [LibraryImport(LibraryName, EntryPoint = "glFogf")]
    public static partial void GlFogf(uint pname, float param1);

    [LibraryImport(LibraryName, EntryPoint = "glFogi")]
    public static partial void GlFogi(uint pname, int param1);

    [LibraryImport(LibraryName, EntryPoint = "glFogfv")]
    public static partial void GlFogfv(uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glFogiv")]
    public static partial void GlFogiv(uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glFeedbackBuffer")]
    public static partial void GlFeedbackBuffer(int size, uint type, float* buffer);

    [LibraryImport(LibraryName, EntryPoint = "glPassThrough")]
    public static partial void GlPassThrough(float token);

    [LibraryImport(LibraryName, EntryPoint = "glSelectBuffer")]
    public static partial void GlSelectBuffer(int size, uint* buffer);

    [LibraryImport(LibraryName, EntryPoint = "glInitNames")]
    public static partial void GlInitNames();

    [LibraryImport(LibraryName, EntryPoint = "glLoadName")]
    public static partial void GlLoadName(uint name);

    [LibraryImport(LibraryName, EntryPoint = "glPushName")]
    public static partial void GlPushName(uint name);

    [LibraryImport(LibraryName, EntryPoint = "glPopName")]
    public static partial void GlPopName();

    [LibraryImport(LibraryName, EntryPoint = "glDrawRangeElements")]
    public static partial void GlDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

    [LibraryImport(LibraryName, EntryPoint = "glTexImage3D")]
    public static partial void GlTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glTexSubImage3D")]
    public static partial void GlTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

    [LibraryImport(LibraryName, EntryPoint = "glCopyTexSubImage3D")]
    public static partial void GlCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "glColorTable")]
    public static partial void GlColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table);

    [LibraryImport(LibraryName, EntryPoint = "glColorSubTable")]
    public static partial void GlColorSubTable(uint target, int start, int count, uint format, uint type, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glColorTableParameteriv")]
    public static partial void GlColorTableParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glColorTableParameterfv")]
    public static partial void GlColorTableParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glCopyColorSubTable")]
    public static partial void GlCopyColorSubTable(uint target, int start, int x, int y, int width);

    [LibraryImport(LibraryName, EntryPoint = "glCopyColorTable")]
    public static partial void GlCopyColorTable(uint target, uint internalformat, int x, int y, int width);

    [LibraryImport(LibraryName, EntryPoint = "glGetColorTable")]
    public static partial void GlGetColorTable(uint target, uint format, uint type, void* table);

    [LibraryImport(LibraryName, EntryPoint = "glGetColorTableParameterfv")]
    public static partial void GlGetColorTableParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetColorTableParameteriv")]
    public static partial void GlGetColorTableParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glBlendEquation")]
    public static partial void GlBlendEquation(uint mode);

    [LibraryImport(LibraryName, EntryPoint = "glBlendColor")]
    public static partial void GlBlendColor(float red, float green, float blue, float alpha);

    [LibraryImport(LibraryName, EntryPoint = "glHistogram")]
    public static partial void GlHistogram(uint target, int width, uint internalformat, byte sink);

    [LibraryImport(LibraryName, EntryPoint = "glResetHistogram")]
    public static partial void GlResetHistogram(uint target);

    [LibraryImport(LibraryName, EntryPoint = "glGetHistogram")]
    public static partial void GlGetHistogram(uint target, byte reset, uint format, uint type, void* values);

    [LibraryImport(LibraryName, EntryPoint = "glGetHistogramParameterfv")]
    public static partial void GlGetHistogramParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetHistogramParameteriv")]
    public static partial void GlGetHistogramParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glMinmax")]
    public static partial void GlMinmax(uint target, uint internalformat, byte sink);

    [LibraryImport(LibraryName, EntryPoint = "glResetMinmax")]
    public static partial void GlResetMinmax(uint target);

    [LibraryImport(LibraryName, EntryPoint = "glGetMinmax")]
    public static partial void GlGetMinmax(uint target, byte reset, uint format, uint types, void* values);

    [LibraryImport(LibraryName, EntryPoint = "glGetMinmaxParameterfv")]
    public static partial void GlGetMinmaxParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetMinmaxParameteriv")]
    public static partial void GlGetMinmaxParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionFilter1D")]
    public static partial void GlConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionFilter2D")]
    public static partial void GlConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionParameterf")]
    public static partial void GlConvolutionParameterf(uint target, uint pname, float @params);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionParameterfv")]
    public static partial void GlConvolutionParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionParameteri")]
    public static partial void GlConvolutionParameteri(uint target, uint pname, int @params);

    [LibraryImport(LibraryName, EntryPoint = "glConvolutionParameteriv")]
    public static partial void GlConvolutionParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glCopyConvolutionFilter1D")]
    public static partial void GlCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);

    [LibraryImport(LibraryName, EntryPoint = "glCopyConvolutionFilter2D")]
    public static partial void GlCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);

    [LibraryImport(LibraryName, EntryPoint = "glGetConvolutionFilter")]
    public static partial void GlGetConvolutionFilter(uint target, uint format, uint type, void* image);

    [LibraryImport(LibraryName, EntryPoint = "glGetConvolutionParameterfv")]
    public static partial void GlGetConvolutionParameterfv(uint target, uint pname, float* @params);

    [LibraryImport(LibraryName, EntryPoint = "glGetConvolutionParameteriv")]
    public static partial void GlGetConvolutionParameteriv(uint target, uint pname, int* @params);

    [LibraryImport(LibraryName, EntryPoint = "glSeparableFilter2D")]
    public static partial void GlSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);

    [LibraryImport(LibraryName, EntryPoint = "glGetSeparableFilter")]
    public static partial void GlGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);

    [LibraryImport(LibraryName, EntryPoint = "glActiveTexture")]
    public static partial void GlActiveTexture(uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glClientActiveTexture")]
    public static partial void GlClientActiveTexture(uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexImage1D")]
    public static partial void GlCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexImage2D")]
    public static partial void GlCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexImage3D")]
    public static partial void GlCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexSubImage1D")]
    public static partial void GlCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexSubImage2D")]
    public static partial void GlCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glCompressedTexSubImage3D")]
    public static partial void GlCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imagesize, void* data);

    [LibraryImport(LibraryName, EntryPoint = "glGetCompressedTexImage")]
    public static partial void GlGetCompressedTexImage(uint target, int lod, void* img);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1d")]
    public static partial void GlMultiTexCoord1d(uint target, double s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1dv")]
    public static partial void GlMultiTexCoord1dv(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1f")]
    public static partial void GlMultiTexCoord1f(uint target, float s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1fv")]
    public static partial void GlMultiTexCoord1fv(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1i")]
    public static partial void GlMultiTexCoord1i(uint target, int s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1iv")]
    public static partial void GlMultiTexCoord1iv(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1s")]
    public static partial void GlMultiTexCoord1s(uint target, short s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1sv")]
    public static partial void GlMultiTexCoord1sv(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2d")]
    public static partial void GlMultiTexCoord2d(uint target, double s, double t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2dv")]
    public static partial void GlMultiTexCoord2dv(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2f")]
    public static partial void GlMultiTexCoord2f(uint target, float s, float t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2fv")]
    public static partial void GlMultiTexCoord2fv(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2i")]
    public static partial void GlMultiTexCoord2i(uint target, int s, int t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2iv")]
    public static partial void GlMultiTexCoord2iv(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2s")]
    public static partial void GlMultiTexCoord2s(uint target, short s, short t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2sv")]
    public static partial void GlMultiTexCoord2sv(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3d")]
    public static partial void GlMultiTexCoord3d(uint target, double s, double t, double r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3dv")]
    public static partial void GlMultiTexCoord3dv(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3f")]
    public static partial void GlMultiTexCoord3f(uint target, float s, float t, float r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3fv")]
    public static partial void GlMultiTexCoord3fv(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3i")]
    public static partial void GlMultiTexCoord3i(uint target, int s, int t, int r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3iv")]
    public static partial void GlMultiTexCoord3iv(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3s")]
    public static partial void GlMultiTexCoord3s(uint target, short s, short t, short r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3sv")]
    public static partial void GlMultiTexCoord3sv(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4d")]
    public static partial void GlMultiTexCoord4d(uint target, double s, double t, double r, double q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4dv")]
    public static partial void GlMultiTexCoord4dv(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4f")]
    public static partial void GlMultiTexCoord4f(uint target, float s, float t, float r, float q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4fv")]
    public static partial void GlMultiTexCoord4fv(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4i")]
    public static partial void GlMultiTexCoord4i(uint target, int s, int t, int r, int q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4iv")]
    public static partial void GlMultiTexCoord4iv(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4s")]
    public static partial void GlMultiTexCoord4s(uint target, short s, short t, short r, short q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4sv")]
    public static partial void GlMultiTexCoord4sv(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glLoadTransposeMatrixd")]
    public static partial void GlLoadTransposeMatrixd(double* m);

    [LibraryImport(LibraryName, EntryPoint = "glLoadTransposeMatrixf")]
    public static partial void GlLoadTransposeMatrixf(float* m);

    [LibraryImport(LibraryName, EntryPoint = "glMultTransposeMatrixd")]
    public static partial void GlMultTransposeMatrixd(double* m);

    [LibraryImport(LibraryName, EntryPoint = "glMultTransposeMatrixf")]
    public static partial void GlMultTransposeMatrixf(float* m);

    [LibraryImport(LibraryName, EntryPoint = "glSampleCoverage")]
    public static partial void GlSampleCoverage(float value, byte invert);

    [LibraryImport(LibraryName, EntryPoint = "glActiveTextureARB")]
    public static partial void GlActiveTextureARB(uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glClientActiveTextureARB")]
    public static partial void GlClientActiveTextureARB(uint texture);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1dARB")]
    public static partial void GlMultiTexCoord1dARB(uint target, double s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1dvARB")]
    public static partial void GlMultiTexCoord1dvARB(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1fARB")]
    public static partial void GlMultiTexCoord1fARB(uint target, float s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1fvARB")]
    public static partial void GlMultiTexCoord1fvARB(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1iARB")]
    public static partial void GlMultiTexCoord1iARB(uint target, int s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1ivARB")]
    public static partial void GlMultiTexCoord1ivARB(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1sARB")]
    public static partial void GlMultiTexCoord1sARB(uint target, short s);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord1svARB")]
    public static partial void GlMultiTexCoord1svARB(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2dARB")]
    public static partial void GlMultiTexCoord2dARB(uint target, double s, double t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2dvARB")]
    public static partial void GlMultiTexCoord2dvARB(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2fARB")]
    public static partial void GlMultiTexCoord2fARB(uint target, float s, float t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2fvARB")]
    public static partial void GlMultiTexCoord2fvARB(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2iARB")]
    public static partial void GlMultiTexCoord2iARB(uint target, int s, int t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2ivARB")]
    public static partial void GlMultiTexCoord2ivARB(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2sARB")]
    public static partial void GlMultiTexCoord2sARB(uint target, short s, short t);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord2svARB")]
    public static partial void GlMultiTexCoord2svARB(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3dARB")]
    public static partial void GlMultiTexCoord3dARB(uint target, double s, double t, double r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3dvARB")]
    public static partial void GlMultiTexCoord3dvARB(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3fARB")]
    public static partial void GlMultiTexCoord3fARB(uint target, float s, float t, float r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3fvARB")]
    public static partial void GlMultiTexCoord3fvARB(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3iARB")]
    public static partial void GlMultiTexCoord3iARB(uint target, int s, int t, int r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3ivARB")]
    public static partial void GlMultiTexCoord3ivARB(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3sARB")]
    public static partial void GlMultiTexCoord3sARB(uint target, short s, short t, short r);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord3svARB")]
    public static partial void GlMultiTexCoord3svARB(uint target, short* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4dARB")]
    public static partial void GlMultiTexCoord4dARB(uint target, double s, double t, double r, double q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4dvARB")]
    public static partial void GlMultiTexCoord4dvARB(uint target, double* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4fARB")]
    public static partial void GlMultiTexCoord4fARB(uint target, float s, float t, float r, float q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4fvARB")]
    public static partial void GlMultiTexCoord4fvARB(uint target, float* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4iARB")]
    public static partial void GlMultiTexCoord4iARB(uint target, int s, int t, int r, int q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4ivARB")]
    public static partial void GlMultiTexCoord4ivARB(uint target, int* v);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4sARB")]
    public static partial void GlMultiTexCoord4sARB(uint target, short s, short t, short r, short q);

    [LibraryImport(LibraryName, EntryPoint = "glMultiTexCoord4svARB")]
    public static partial void GlMultiTexCoord4svARB(uint target, short* v);

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
    public static partial bool CreateWindowAndRenderer([MarshalAs(UnmanagedType.LPStr)] string title, int width, int height, SDL_WindowFlags windowFlags, Window window, Renderer renderer);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_RenderDebugTextFormat")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool RenderDebugTextFormat(Renderer renderer, float x, float y, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_malloc")]
    public static partial void* Malloc(nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_calloc")]
    public static partial void* Calloc(nuint nmemb, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_realloc")]
    public static partial void* Realloc(void* mem, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_free")]
    public static partial void Free(void* mem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetOriginalMemoryFunctions")]
    public static partial void GetOriginalMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*** mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*** callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, voi**** reallocFunc, delegate* unmanaged[Cdecl]<void*, voi*** freeFunc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetMemoryFunctions")]
    public static partial void GetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*** mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*** callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, voi**** reallocFunc, delegate* unmanaged[Cdecl]<void*, voi*** freeFunc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetMemoryFunctions")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*> mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*> callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, void*> reallocFunc, delegate* unmanaged[Cdecl]<void*, void> freeFunc);

    [LibraryImport(LibraryName, EntryPoint = "SDL_aligned_alloc")]
    public static partial void* AlignedAlloc(nuint alignment, nuint size);

    [LibraryImport(LibraryName, EntryPoint = "SDL_aligned_free")]
    public static partial void AlignedFree(void* mem);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetNumAllocations")]
    public static partial int GetNumAllocations();

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetEnvironment")]
    public static partial Environment GetEnvironment();

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreateEnvironment")]
    public static partial Environment CreateEnvironment(byte populated);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetEnvironmentVariable")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetEnvironmentVariable(Environment env, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_GetEnvironmentVariables")]
    public static partial sbyte** GetEnvironmentVariables(Environment env);

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetEnvironmentVariable")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetEnvironmentVariable(Environment env, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value, byte overwrite);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UnsetEnvironmentVariable")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool UnsetEnvironmentVariable(Environment env, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_DestroyEnvironment")]
    public static partial void DestroyEnvironment(Environment env);

    [LibraryImport(LibraryName, EntryPoint = "SDL_getenv")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Getenv([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_getenv_unsafe")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string GetenvUnsafe([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_setenv_unsafe")]
    public static partial int SetenvUnsafe([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value, int overwrite);

    [LibraryImport(LibraryName, EntryPoint = "SDL_unsetenv_unsafe")]
    public static partial int UnsetenvUnsafe([MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(LibraryName, EntryPoint = "SDL_qsort")]
    public static partial void Qsort(void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, int> compare);

    [LibraryImport(LibraryName, EntryPoint = "SDL_bsearch")]
    public static partial void* Bsearch(void* key, void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, int> compare);

    [LibraryImport(LibraryName, EntryPoint = "SDL_qsort_r")]
    public static partial void QsortR(void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_bsearch_r")]
    public static partial void* BsearchR(void* key, void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

    [LibraryImport(LibraryName, EntryPoint = "SDL_abs")]
    public static partial int Abs(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isalpha")]
    public static partial int Isalpha(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isalnum")]
    public static partial int Isalnum(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isblank")]
    public static partial int Isblank(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_iscntrl")]
    public static partial int Iscntrl(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isdigit")]
    public static partial int Isdigit(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isxdigit")]
    public static partial int Isxdigit(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ispunct")]
    public static partial int Ispunct(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isspace")]
    public static partial int Isspace(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isupper")]
    public static partial int Isupper(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_islower")]
    public static partial int Islower(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isprint")]
    public static partial int Isprint(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isgraph")]
    public static partial int Isgraph(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_toupper")]
    public static partial int Toupper(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_tolower")]
    public static partial int Tolower(int x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_crc16")]
    public static partial ushort Crc16(ushort crc, void* data, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_crc32")]
    public static partial uint Crc32(uint crc, void* data, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_murmur3_32")]
    public static partial uint Murmur332(void* data, nuint len, uint seed);

    [LibraryImport(LibraryName, EntryPoint = "SDL_memcpy")]
    public static partial void* Memcpy(void* dst, void* src, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_memmove")]
    public static partial void* Memmove(void* dst, void* src, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_memset")]
    public static partial void* Memset(void* dst, int c, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_memset4")]
    public static partial void* Memset4(void* dst, uint val, nuint dwords);

    [LibraryImport(LibraryName, EntryPoint = "SDL_memcmp")]
    public static partial int Memcmp(void* s1, void* s2, nuint len);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcslen")]
    public static partial nuint Wcslen(uint* wstr);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsnlen")]
    public static partial nuint Wcsnlen(uint* wstr, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcslcpy")]
    public static partial nuint Wcslcpy(uint* dst, uint* src, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcslcat")]
    public static partial nuint Wcslcat(uint* dst, uint* src, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsdup")]
    public static partial uint* Wcsdup(uint* wstr);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsstr")]
    public static partial uint* Wcsstr(uint* haystack, uint* needle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsnstr")]
    public static partial uint* Wcsnstr(uint* haystack, uint* needle, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcscmp")]
    public static partial int Wcscmp(uint* str1, uint* str2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsncmp")]
    public static partial int Wcsncmp(uint* str1, uint* str2, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcscasecmp")]
    public static partial int Wcscasecmp(uint* str1, uint* str2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcsncasecmp")]
    public static partial int Wcsncasecmp(uint* str1, uint* str2, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_wcstol")]
    public static partial nint Wcstol(uint* str, uint** endp, int @base);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strlen")]
    public static partial nuint Strlen([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strnlen")]
    public static partial nuint Strnlen([MarshalAs(UnmanagedType.LPStr)] string str, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strlcpy")]
    public static partial nuint Strlcpy([MarshalAs(UnmanagedType.LPStr)] string dst, [MarshalAs(UnmanagedType.LPStr)] string src, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_utf8strlcpy")]
    public static partial nuint Utf8strlcpy([MarshalAs(UnmanagedType.LPStr)] string dst, [MarshalAs(UnmanagedType.LPStr)] string src, nuint dstBytes);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strlcat")]
    public static partial nuint Strlcat([MarshalAs(UnmanagedType.LPStr)] string dst, [MarshalAs(UnmanagedType.LPStr)] string src, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strdup")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strdup([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strndup")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strndup([MarshalAs(UnmanagedType.LPStr)] string str, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strrev")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strrev([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strupr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strupr([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strlwr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strlwr([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strchr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strchr([MarshalAs(UnmanagedType.LPStr)] string str, int c);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strrchr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strrchr([MarshalAs(UnmanagedType.LPStr)] string str, int c);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strstr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strstr([MarshalAs(UnmanagedType.LPStr)] string haystack, [MarshalAs(UnmanagedType.LPStr)] string needle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strnstr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strnstr([MarshalAs(UnmanagedType.LPStr)] string haystack, [MarshalAs(UnmanagedType.LPStr)] string needle, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strcasestr")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strcasestr([MarshalAs(UnmanagedType.LPStr)] string haystack, [MarshalAs(UnmanagedType.LPStr)] string needle);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtok_r")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string StrtokR([MarshalAs(UnmanagedType.LPStr)] string str, [MarshalAs(UnmanagedType.LPStr)] string delim, sbyte** saveptr);

    [LibraryImport(LibraryName, EntryPoint = "SDL_utf8strlen")]
    public static partial nuint Utf8strlen([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_utf8strnlen")]
    public static partial nuint Utf8strnlen([MarshalAs(UnmanagedType.LPStr)] string str, nuint bytes);

    [LibraryImport(LibraryName, EntryPoint = "SDL_itoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Itoa(int value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_uitoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Uitoa(uint value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ltoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Ltoa(nint value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ultoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Ultoa(nuint value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_lltoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Lltoa(long value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ulltoa")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Ulltoa(ulong value, [MarshalAs(UnmanagedType.LPStr)] string str, int radix);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atoi")]
    public static partial int Atoi([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atof")]
    public static partial double Atof([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtol")]
    public static partial nint Strtol([MarshalAs(UnmanagedType.LPStr)] string str, sbyte** endp, int @base);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtoul")]
    public static partial nuint Strtoul([MarshalAs(UnmanagedType.LPStr)] string str, sbyte** endp, int @base);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtoll")]
    public static partial long Strtoll([MarshalAs(UnmanagedType.LPStr)] string str, sbyte** endp, int @base);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtoull")]
    public static partial ulong Strtoull([MarshalAs(UnmanagedType.LPStr)] string str, sbyte** endp, int @base);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strtod")]
    public static partial double Strtod([MarshalAs(UnmanagedType.LPStr)] string str, sbyte** endp);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strcmp")]
    public static partial int Strcmp([MarshalAs(UnmanagedType.LPStr)] string str1, [MarshalAs(UnmanagedType.LPStr)] string str2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strncmp")]
    public static partial int Strncmp([MarshalAs(UnmanagedType.LPStr)] string str1, [MarshalAs(UnmanagedType.LPStr)] string str2, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strcasecmp")]
    public static partial int Strcasecmp([MarshalAs(UnmanagedType.LPStr)] string str1, [MarshalAs(UnmanagedType.LPStr)] string str2);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strncasecmp")]
    public static partial int Strncasecmp([MarshalAs(UnmanagedType.LPStr)] string str1, [MarshalAs(UnmanagedType.LPStr)] string str2, nuint maxlen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_strpbrk")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string Strpbrk([MarshalAs(UnmanagedType.LPStr)] string str, [MarshalAs(UnmanagedType.LPStr)] string breakset);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StepUTF8")]
    public static partial uint StepUTF8(sbyte** pstr, nuint* pslen);

    [LibraryImport(LibraryName, EntryPoint = "SDL_StepBackUTF8")]
    public static partial uint StepBackUTF8([MarshalAs(UnmanagedType.LPStr)] string start, sbyte** pstr);

    [LibraryImport(LibraryName, EntryPoint = "SDL_UCS4ToUTF8")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string UCS4ToUTF8(uint codepoint, [MarshalAs(UnmanagedType.LPStr)] string dst);

    [LibraryImport(LibraryName, EntryPoint = "SDL_sscanf")]
    public static partial int Sscanf([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_vsscanf")]
    public static partial int Vsscanf([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

    [LibraryImport(LibraryName, EntryPoint = "SDL_snprintf")]
    public static partial int Snprintf([MarshalAs(UnmanagedType.LPStr)] string text, nuint maxlen, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_swprintf")]
    public static partial int Swprintf(uint* text, nuint maxlen, uint* fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_vsnprintf")]
    public static partial int Vsnprintf([MarshalAs(UnmanagedType.LPStr)] string text, nuint maxlen, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

    [LibraryImport(LibraryName, EntryPoint = "SDL_vswprintf")]
    public static partial int Vswprintf(uint* text, nuint maxlen, uint* fmt, __va_list_tag* ap);

    [LibraryImport(LibraryName, EntryPoint = "SDL_asprintf")]
    public static partial int Asprintf(sbyte** strp, [MarshalAs(UnmanagedType.LPStr)] string fmt, __arglist );

    [LibraryImport(LibraryName, EntryPoint = "SDL_vasprintf")]
    public static partial int Vasprintf(sbyte** strp, [MarshalAs(UnmanagedType.LPStr)] string fmt, __va_list_tag* ap);

    [LibraryImport(LibraryName, EntryPoint = "SDL_srand")]
    public static partial void Srand(ulong seed);

    [LibraryImport(LibraryName, EntryPoint = "SDL_rand")]
    public static partial int Rand(int n);

    [LibraryImport(LibraryName, EntryPoint = "SDL_randf")]
    public static partial float Randf();

    [LibraryImport(LibraryName, EntryPoint = "SDL_rand_bits")]
    public static partial uint RandBits();

    [LibraryImport(LibraryName, EntryPoint = "SDL_rand_r")]
    public static partial int RandR(ulong* state, int n);

    [LibraryImport(LibraryName, EntryPoint = "SDL_randf_r")]
    public static partial float RandfR(ulong* state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_rand_bits_r")]
    public static partial uint RandBitsR(ulong* state);

    [LibraryImport(LibraryName, EntryPoint = "SDL_acos")]
    public static partial double Acos(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_acosf")]
    public static partial float Acosf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_asin")]
    public static partial double Asin(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_asinf")]
    public static partial float Asinf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atan")]
    public static partial double Atan(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atanf")]
    public static partial float Atanf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atan2")]
    public static partial double Atan2(double y, double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_atan2f")]
    public static partial float Atan2f(float y, float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ceil")]
    public static partial double Ceil(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_ceilf")]
    public static partial float Ceilf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_copysign")]
    public static partial double Copysign(double x, double y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_copysignf")]
    public static partial float Copysignf(float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_cos")]
    public static partial double Cos(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_cosf")]
    public static partial float Cosf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_exp")]
    public static partial double Exp(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_expf")]
    public static partial float Expf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_fabs")]
    public static partial double Fabs(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_fabsf")]
    public static partial float Fabsf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_floor")]
    public static partial double Floor(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_floorf")]
    public static partial float Floorf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_trunc")]
    public static partial double Trunc(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_truncf")]
    public static partial float Truncf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_fmod")]
    public static partial double Fmod(double x, double y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_fmodf")]
    public static partial float Fmodf(float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isinf")]
    public static partial int Isinf(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isinff")]
    public static partial int Isinff(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isnan")]
    public static partial int Isnan(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_isnanf")]
    public static partial int Isnanf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_log")]
    public static partial double Log(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_logf")]
    public static partial float Logf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_log10")]
    public static partial double Log10(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_log10f")]
    public static partial float Log10f(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_modf")]
    public static partial double Modf(double x, double* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_modff")]
    public static partial float Modff(float x, float* y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_pow")]
    public static partial double Pow(double x, double y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_powf")]
    public static partial float Powf(float x, float y);

    [LibraryImport(LibraryName, EntryPoint = "SDL_round")]
    public static partial double Round(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_roundf")]
    public static partial float Roundf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_lround")]
    public static partial nint Lround(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_lroundf")]
    public static partial nint Lroundf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_scalbn")]
    public static partial double Scalbn(double x, int n);

    [LibraryImport(LibraryName, EntryPoint = "SDL_scalbnf")]
    public static partial float Scalbnf(float x, int n);

    [LibraryImport(LibraryName, EntryPoint = "SDL_sin")]
    public static partial double Sin(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_sinf")]
    public static partial float Sinf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_sqrt")]
    public static partial double Sqrt(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_sqrtf")]
    public static partial float Sqrtf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_tan")]
    public static partial double Tan(double x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_tanf")]
    public static partial float Tanf(float x);

    [LibraryImport(LibraryName, EntryPoint = "SDL_iconv_open")]
    public static partial IconvDataT IconvOpen([MarshalAs(UnmanagedType.LPStr)] string tocode, [MarshalAs(UnmanagedType.LPStr)] string fromcode);

    [LibraryImport(LibraryName, EntryPoint = "SDL_iconv_close")]
    public static partial int IconvClose(IconvDataT cd);

    [LibraryImport(LibraryName, EntryPoint = "SDL_iconv")]
    public static partial nuint Iconv(IconvDataT cd, sbyte** inbuf, nuint* inbytesleft, sbyte** outbuf, nuint* outbytesleft);

    [LibraryImport(LibraryName, EntryPoint = "SDL_iconv_string")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string IconvString([MarshalAs(UnmanagedType.LPStr)] string tocode, [MarshalAs(UnmanagedType.LPStr)] string fromcode, [MarshalAs(UnmanagedType.LPStr)] string inbuf, nuint inbytesleft);

    [LibraryImport(LibraryName, EntryPoint = "SDL_size_mul_check_overflow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SizeMulCheckOverflow(nuint a, nuint b, nuint* ret);

    [LibraryImport(LibraryName, EntryPoint = "SDL_size_mul_check_overflow_builtin")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SizeMulCheckOverflowBuiltin(nuint a, nuint b, nuint* ret);

    [LibraryImport(LibraryName, EntryPoint = "SDL_size_add_check_overflow")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SizeAddCheckOverflow(nuint a, nuint b, nuint* ret);

    [LibraryImport(LibraryName, EntryPoint = "SDL_size_add_check_overflow_builtin")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SizeAddCheckOverflowBuiltin(nuint a, nuint b, nuint* ret);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_EnumerateStorageDirectory")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool EnumerateStorageDirectory(Storage storage, [MarshalAs(UnmanagedType.LPStr)] string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetX11EventHook")]
    public static partial void SetX11EventHook(delegate* unmanaged[Cdecl]<void*, _XEvent*, byte> callback, void* userdata);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetTrayEntryCallback")]
    public static partial void SetTrayEntryCallback(TrayEntry entry, delegate* unmanaged[Cdecl]<void*, SDL_TrayEntry*, void> callback, void* userdata);

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
    public static partial Window CreateWindow([MarshalAs(UnmanagedType.LPStr)] string title, int w, int h, SDL_WindowFlags flags);

    [LibraryImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow")]
    public static partial Window CreatePopupWindow(Window parent, int offsetX, int offsetY, int w, int h, SDL_WindowFlags flags);

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
    public static partial SDL_WindowFlags GetWindowFlags(Window window);

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

    [LibraryImport(LibraryName, EntryPoint = "SDL_SetWindowHitTest")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool SetWindowHitTest(Window window, delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callbackData);

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
