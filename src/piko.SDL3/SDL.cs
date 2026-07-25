using System.Runtime.InteropServices;
namespace piko.SDL3;
public static unsafe partial class SDL
{
    public const string LibraryName = "SDL3";

    [DllImport(LibraryName, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
    public static extern AssertState ReportAssertion(AssertData* data, string func, string file, int line);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
    public static extern void SetAssertionHandler(delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> handler, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetDefaultAssertionHandler();

    [DllImport(LibraryName, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<SDL_AssertData*, void*, SDL_AssertState> GetAssertionHandler(void** puserdata);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
    public static extern AssertData* GetAssertionReport();

    [DllImport(LibraryName, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
    public static extern void ResetAssertionReport();

    [DllImport(LibraryName, EntryPoint = "SDL_AsyncIOFromFile", ExactSpelling = true)]
    public static extern AsyncIO AsyncIOFromFile(string file, string mode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAsyncIOSize", ExactSpelling = true)]
    public static extern nint GetAsyncIOSize(AsyncIO asyncio);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadAsyncIO", ExactSpelling = true)]
    public static extern bool ReadAsyncIO(AsyncIO asyncio, void* ptr, nuint offset, nuint size, AsyncIOQueue queue, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteAsyncIO", ExactSpelling = true)]
    public static extern bool WriteAsyncIO(AsyncIO asyncio, void* ptr, nuint offset, nuint size, AsyncIOQueue queue, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseAsyncIO", ExactSpelling = true)]
    public static extern bool CloseAsyncIO(AsyncIO asyncio, byte flush, AsyncIOQueue queue, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateAsyncIOQueue", ExactSpelling = true)]
    public static extern AsyncIOQueue CreateAsyncIOQueue();

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyAsyncIOQueue", ExactSpelling = true)]
    public static extern void DestroyAsyncIOQueue(AsyncIOQueue queue);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAsyncIOResult", ExactSpelling = true)]
    public static extern bool GetAsyncIOResult(AsyncIOQueue queue, AsyncIOOutcome* outcome);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitAsyncIOResult", ExactSpelling = true)]
    public static extern bool WaitAsyncIOResult(AsyncIOQueue queue, AsyncIOOutcome* outcome, int timeoutms);

    [DllImport(LibraryName, EntryPoint = "SDL_SignalAsyncIOQueue", ExactSpelling = true)]
    public static extern void SignalAsyncIOQueue(AsyncIOQueue queue);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadFileAsync", ExactSpelling = true)]
    public static extern bool LoadFileAsync(string file, AsyncIOQueue queue, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_TryLockSpinlock", ExactSpelling = true)]
    public static extern bool TryLockSpinlock(int* @lock);

    [DllImport(LibraryName, EntryPoint = "SDL_LockSpinlock", ExactSpelling = true)]
    public static extern void LockSpinlock(int* @lock);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockSpinlock", ExactSpelling = true)]
    public static extern void UnlockSpinlock(int* @lock);

    [DllImport(LibraryName, EntryPoint = "SDL_MemoryBarrierReleaseFunction", ExactSpelling = true)]
    public static extern void MemoryBarrierReleaseFunction();

    [DllImport(LibraryName, EntryPoint = "SDL_MemoryBarrierAcquireFunction", ExactSpelling = true)]
    public static extern void MemoryBarrierAcquireFunction();

    [DllImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicInt", ExactSpelling = true)]
    public static extern bool CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAtomicInt", ExactSpelling = true)]
    public static extern int SetAtomicInt(AtomicInt* a, int v);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAtomicInt", ExactSpelling = true)]
    public static extern int GetAtomicInt(AtomicInt* a);

    [DllImport(LibraryName, EntryPoint = "SDL_AddAtomicInt", ExactSpelling = true)]
    public static extern int AddAtomicInt(AtomicInt* a, int v);

    [DllImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicU32", ExactSpelling = true)]
    public static extern bool CompareAndSwapAtomicU32(AtomicU32* a, uint oldval, uint newval);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAtomicU32", ExactSpelling = true)]
    public static extern uint SetAtomicU32(AtomicU32* a, uint v);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAtomicU32", ExactSpelling = true)]
    public static extern uint GetAtomicU32(AtomicU32* a);

    [DllImport(LibraryName, EntryPoint = "SDL_AddAtomicU32", ExactSpelling = true)]
    public static extern uint AddAtomicU32(AtomicU32* a, int v);

    [DllImport(LibraryName, EntryPoint = "SDL_CompareAndSwapAtomicPointer", ExactSpelling = true)]
    public static extern bool CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAtomicPointer", ExactSpelling = true)]
    public static extern void* SetAtomicPointer(void** a, void* v);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAtomicPointer", ExactSpelling = true)]
    public static extern void* GetAtomicPointer(void** a);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumAudioDrivers", ExactSpelling = true)]
    public static extern int GetNumAudioDrivers();

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioDriver", ExactSpelling = true)]
    public static extern string GetAudioDriver(int index);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentAudioDriver", ExactSpelling = true)]
    public static extern string GetCurrentAudioDriver();

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioPlaybackDevices", ExactSpelling = true)]
    public static extern uint* GetAudioPlaybackDevices(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioRecordingDevices", ExactSpelling = true)]
    public static extern uint* GetAudioRecordingDevices(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceName", ExactSpelling = true)]
    public static extern string GetAudioDeviceName(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceFormat", ExactSpelling = true)]
    public static extern bool GetAudioDeviceFormat(uint devid, AudioSpec* spec, int* sampleFrames);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioDeviceChannelMap(uint devid, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenAudioDevice", ExactSpelling = true)]
    public static extern uint OpenAudioDevice(uint devid, AudioSpec* spec);

    [DllImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePhysical", ExactSpelling = true)]
    public static extern bool IsAudioDevicePhysical(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePlayback", ExactSpelling = true)]
    public static extern bool IsAudioDevicePlayback(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_PauseAudioDevice", ExactSpelling = true)]
    public static extern bool PauseAudioDevice(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_ResumeAudioDevice", ExactSpelling = true)]
    public static extern bool ResumeAudioDevice(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_AudioDevicePaused", ExactSpelling = true)]
    public static extern bool AudioDevicePaused(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceGain", ExactSpelling = true)]
    public static extern float GetAudioDeviceGain(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioDeviceGain", ExactSpelling = true)]
    public static extern bool SetAudioDeviceGain(uint devid, float gain);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseAudioDevice", ExactSpelling = true)]
    public static extern void CloseAudioDevice(uint devid);

    [DllImport(LibraryName, EntryPoint = "SDL_BindAudioStreams", ExactSpelling = true)]
    public static extern bool BindAudioStreams(uint devid, AudioStream streams, int numStreams);

    [DllImport(LibraryName, EntryPoint = "SDL_BindAudioStream", ExactSpelling = true)]
    public static extern bool BindAudioStream(uint devid, AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_UnbindAudioStreams", ExactSpelling = true)]
    public static extern void UnbindAudioStreams(AudioStream streams, int numStreams);

    [DllImport(LibraryName, EntryPoint = "SDL_UnbindAudioStream", ExactSpelling = true)]
    public static extern void UnbindAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamDevice", ExactSpelling = true)]
    public static extern uint GetAudioStreamDevice(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateAudioStream", ExactSpelling = true)]
    public static extern AudioStream CreateAudioStream(AudioSpec* srcSpec, AudioSpec* dstSpec);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamProperties", ExactSpelling = true)]
    public static extern uint GetAudioStreamProperties(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFormat", ExactSpelling = true)]
    public static extern bool GetAudioStreamFormat(AudioStream stream, AudioSpec* srcSpec, AudioSpec* dstSpec);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFormat", ExactSpelling = true)]
    public static extern bool SetAudioStreamFormat(AudioStream stream, AudioSpec* srcSpec, AudioSpec* dstSpec);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFrequencyRatio", ExactSpelling = true)]
    public static extern float GetAudioStreamFrequencyRatio(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFrequencyRatio", ExactSpelling = true)]
    public static extern bool SetAudioStreamFrequencyRatio(AudioStream stream, float ratio);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamGain", ExactSpelling = true)]
    public static extern float GetAudioStreamGain(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGain", ExactSpelling = true)]
    public static extern bool SetAudioStreamGain(AudioStream stream, float gain);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamInputChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioStreamInputChannelMap(AudioStream stream, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamOutputChannelMap", ExactSpelling = true)]
    public static extern int* GetAudioStreamOutputChannelMap(AudioStream stream, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamInputChannelMap", ExactSpelling = true)]
    public static extern bool SetAudioStreamInputChannelMap(AudioStream stream, int* chmap, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamOutputChannelMap", ExactSpelling = true)]
    public static extern bool SetAudioStreamOutputChannelMap(AudioStream stream, int* chmap, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_PutAudioStreamData", ExactSpelling = true)]
    public static extern bool PutAudioStreamData(AudioStream stream, void* buf, int len);

    [DllImport(LibraryName, EntryPoint = "SDL_PutAudioStreamDataNoCopy", ExactSpelling = true)]
    public static extern bool PutAudioStreamDataNoCopy(AudioStream stream, void* buf, int len, delegate* unmanaged[Cdecl]<void*, void*, int, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_PutAudioStreamPlanarData", ExactSpelling = true)]
    public static extern bool PutAudioStreamPlanarData(AudioStream stream, void** channelBuffers, int numChannels, int numSamples);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamData", ExactSpelling = true)]
    public static extern int GetAudioStreamData(AudioStream stream, void* buf, int len);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamAvailable", ExactSpelling = true)]
    public static extern int GetAudioStreamAvailable(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamQueued", ExactSpelling = true)]
    public static extern int GetAudioStreamQueued(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_FlushAudioStream", ExactSpelling = true)]
    public static extern bool FlushAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_ClearAudioStream", ExactSpelling = true)]
    public static extern bool ClearAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_PauseAudioStreamDevice", ExactSpelling = true)]
    public static extern bool PauseAudioStreamDevice(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_ResumeAudioStreamDevice", ExactSpelling = true)]
    public static extern bool ResumeAudioStreamDevice(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_AudioStreamDevicePaused", ExactSpelling = true)]
    public static extern bool AudioStreamDevicePaused(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_LockAudioStream", ExactSpelling = true)]
    public static extern bool LockAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockAudioStream", ExactSpelling = true)]
    public static extern bool UnlockAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGetCallback", ExactSpelling = true)]
    public static extern bool SetAudioStreamGetCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamPutCallback", ExactSpelling = true)]
    public static extern bool SetAudioStreamPutCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyAudioStream", ExactSpelling = true)]
    public static extern void DestroyAudioStream(AudioStream stream);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenAudioDeviceStream", ExactSpelling = true)]
    public static extern AudioStream OpenAudioDeviceStream(uint devid, AudioSpec* spec, delegate* unmanaged[Cdecl]<void*, SDL_AudioStream*, int, int, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAudioPostmixCallback", ExactSpelling = true)]
    public static extern bool SetAudioPostmixCallback(uint devid, delegate* unmanaged[Cdecl]<void*, SDL_AudioSpec*, float*, int, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadWAV_IO", ExactSpelling = true)]
    public static extern bool LoadWAVIO(IOStream src, byte closeio, AudioSpec* spec, byte** audioBuf, uint* audioLen);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadWAV", ExactSpelling = true)]
    public static extern bool LoadWAV(string path, AudioSpec* spec, byte** audioBuf, uint* audioLen);

    [DllImport(LibraryName, EntryPoint = "SDL_MixAudio", ExactSpelling = true)]
    public static extern bool MixAudio(byte* dst, byte* src, AudioFormat format, uint len, float volume);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertAudioSamples", ExactSpelling = true)]
    public static extern bool ConvertAudioSamples(AudioSpec* srcSpec, byte* srcData, int srcLen, AudioSpec* dstSpec, byte** dstData, int* dstLen);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAudioFormatName", ExactSpelling = true)]
    public static extern string GetAudioFormatName(AudioFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSilenceValueForFormat", ExactSpelling = true)]
    public static extern int GetSilenceValueForFormat(AudioFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_MostSignificantBitIndex32", ExactSpelling = true)]
    public static extern int MostSignificantBitIndex32(uint x);

    [DllImport(LibraryName, EntryPoint = "SDL_HasExactlyOneBitSet32", ExactSpelling = true)]
    public static extern bool HasExactlyOneBitSet32(uint x);

    [DllImport(LibraryName, EntryPoint = "SDL_ComposeCustomBlendMode", ExactSpelling = true)]
    public static extern uint ComposeCustomBlendMode(BlendFactor srccolorfactor, BlendFactor dstcolorfactor, BlendOperation coloroperation, BlendFactor srcalphafactor, BlendFactor dstalphafactor, BlendOperation alphaoperation);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumCameraDrivers", ExactSpelling = true)]
    public static extern int GetNumCameraDrivers();

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraDriver", ExactSpelling = true)]
    public static extern string GetCameraDriver(int index);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentCameraDriver", ExactSpelling = true)]
    public static extern string GetCurrentCameraDriver();

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameras", ExactSpelling = true)]
    public static extern uint* GetCameras(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraSupportedFormats", ExactSpelling = true)]
    public static extern CameraSpec** GetCameraSupportedFormats(uint instanceId, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraName", ExactSpelling = true)]
    public static extern string GetCameraName(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraPosition", ExactSpelling = true)]
    public static extern CameraPosition GetCameraPosition(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenCamera", ExactSpelling = true)]
    public static extern Camera OpenCamera(uint instanceId, CameraSpec* spec);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraPermissionState", ExactSpelling = true)]
    public static extern CameraPermissionState GetCameraPermissionState(Camera camera);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraID", ExactSpelling = true)]
    public static extern uint GetCameraID(Camera camera);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraProperties", ExactSpelling = true)]
    public static extern uint GetCameraProperties(Camera camera);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCameraFormat", ExactSpelling = true)]
    public static extern bool GetCameraFormat(Camera camera, CameraSpec* spec);

    [DllImport(LibraryName, EntryPoint = "SDL_AcquireCameraFrame", ExactSpelling = true)]
    public static extern Surface* AcquireCameraFrame(Camera camera, nuint* timestampns);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseCameraFrame", ExactSpelling = true)]
    public static extern void ReleaseCameraFrame(Camera camera, Surface* frame);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseCamera", ExactSpelling = true)]
    public static extern void CloseCamera(Camera camera);

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
    public static extern bool SetClipboardText(string text);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
    public static extern string GetClipboardText();

    [DllImport(LibraryName, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
    public static extern bool HasClipboardText();

    [DllImport(LibraryName, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
    public static extern bool SetPrimarySelectionText(string text);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
    public static extern string GetPrimarySelectionText();

    [DllImport(LibraryName, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
    public static extern bool HasPrimarySelectionText();

    [DllImport(LibraryName, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
    public static extern bool SetClipboardData(delegate* unmanaged[Cdecl]<void*, sbyte*, nuint*, void*> callback, delegate* unmanaged[Cdecl]<void*, void> cleanup, void* userdata, sbyte** mimeTypes, nuint numMimeTypes);

    [DllImport(LibraryName, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
    public static extern bool ClearClipboardData();

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
    public static extern void* GetClipboardData(string mimeType, nuint* size);

    [DllImport(LibraryName, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
    public static extern bool HasClipboardData(string mimeType);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
    public static extern sbyte** GetClipboardMimeTypes(nuint* numMimeTypes);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumLogicalCPUCores", ExactSpelling = true)]
    public static extern int GetNumLogicalCPUCores();

    [DllImport(LibraryName, EntryPoint = "SDL_GetCPUCacheLineSize", ExactSpelling = true)]
    public static extern int GetCPUCacheLineSize();

    [DllImport(LibraryName, EntryPoint = "SDL_HasAltiVec", ExactSpelling = true)]
    public static extern bool HasAltiVec();

    [DllImport(LibraryName, EntryPoint = "SDL_HasMMX", ExactSpelling = true)]
    public static extern bool HasMMX();

    [DllImport(LibraryName, EntryPoint = "SDL_HasSSE", ExactSpelling = true)]
    public static extern bool HasSSE();

    [DllImport(LibraryName, EntryPoint = "SDL_HasSSE2", ExactSpelling = true)]
    public static extern bool HasSSE2();

    [DllImport(LibraryName, EntryPoint = "SDL_HasSSE3", ExactSpelling = true)]
    public static extern bool HasSSE3();

    [DllImport(LibraryName, EntryPoint = "SDL_HasSSE41", ExactSpelling = true)]
    public static extern bool HasSSE41();

    [DllImport(LibraryName, EntryPoint = "SDL_HasSSE42", ExactSpelling = true)]
    public static extern bool HasSSE42();

    [DllImport(LibraryName, EntryPoint = "SDL_HasAVX", ExactSpelling = true)]
    public static extern bool HasAVX();

    [DllImport(LibraryName, EntryPoint = "SDL_HasAVX2", ExactSpelling = true)]
    public static extern bool HasAVX2();

    [DllImport(LibraryName, EntryPoint = "SDL_HasAVX512F", ExactSpelling = true)]
    public static extern bool HasAVX512F();

    [DllImport(LibraryName, EntryPoint = "SDL_HasARMSIMD", ExactSpelling = true)]
    public static extern bool HasARMSIMD();

    [DllImport(LibraryName, EntryPoint = "SDL_HasNEON", ExactSpelling = true)]
    public static extern bool HasNEON();

    [DllImport(LibraryName, EntryPoint = "SDL_HasLSX", ExactSpelling = true)]
    public static extern bool HasLSX();

    [DllImport(LibraryName, EntryPoint = "SDL_HasLASX", ExactSpelling = true)]
    public static extern bool HasLASX();

    [DllImport(LibraryName, EntryPoint = "SDL_GetSystemRAM", ExactSpelling = true)]
    public static extern int GetSystemRAM();

    [DllImport(LibraryName, EntryPoint = "SDL_GetSIMDAlignment", ExactSpelling = true)]
    public static extern nuint GetSIMDAlignment();

    [DllImport(LibraryName, EntryPoint = "SDL_GetSystemPageSize", ExactSpelling = true)]
    public static extern int GetSystemPageSize();

    [DllImport(LibraryName, EntryPoint = "SDL_ShowOpenFileDialog", ExactSpelling = true)]
    public static extern void ShowOpenFileDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, DialogFileFilter* filters, int nfilters, string defaultLocation, byte allowMany);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowSaveFileDialog", ExactSpelling = true)]
    public static extern void ShowSaveFileDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, DialogFileFilter* filters, int nfilters, string defaultLocation);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowOpenFolderDialog", ExactSpelling = true)]
    public static extern void ShowOpenFolderDialog(delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, Window window, string defaultLocation, byte allowMany);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowFileDialogWithProperties", ExactSpelling = true)]
    public static extern void ShowFileDialogWithProperties(FileDialogType type, delegate* unmanaged[Cdecl]<void*, sbyte**, int, void> callback, void* userdata, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_SwapFloat", ExactSpelling = true)]
    public static extern float SwapFloat(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_SetError", ExactSpelling = true)]
    public static extern bool SetError(string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_SetErrorV", ExactSpelling = true)]
    public static extern bool SetErrorV(string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_OutOfMemory", ExactSpelling = true)]
    public static extern bool OutOfMemory();

    [DllImport(LibraryName, EntryPoint = "SDL_GetError", ExactSpelling = true)]
    public static extern string GetError();

    [DllImport(LibraryName, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
    public static extern bool ClearError();

    [DllImport(LibraryName, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
    public static extern void PumpEvents();

    [DllImport(LibraryName, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
    public static extern int PeepEvents(Event* events, int numevents, EventAction action, uint mintype, uint maxtype);

    [DllImport(LibraryName, EntryPoint = "SDL_HasEvent", ExactSpelling = true)]
    public static extern bool HasEvent(uint type);

    [DllImport(LibraryName, EntryPoint = "SDL_HasEvents", ExactSpelling = true)]
    public static extern bool HasEvents(uint mintype, uint maxtype);

    [DllImport(LibraryName, EntryPoint = "SDL_FlushEvent", ExactSpelling = true)]
    public static extern void FlushEvent(uint type);

    [DllImport(LibraryName, EntryPoint = "SDL_FlushEvents", ExactSpelling = true)]
    public static extern void FlushEvents(uint mintype, uint maxtype);

    [DllImport(LibraryName, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
    public static extern bool PollEvent(Event* @event);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitEvent", ExactSpelling = true)]
    public static extern bool WaitEvent(Event* @event);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitEventTimeout", ExactSpelling = true)]
    public static extern bool WaitEventTimeout(Event* @event, int timeoutms);

    [DllImport(LibraryName, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
    public static extern bool PushEvent(Event* @event);

    [DllImport(LibraryName, EntryPoint = "SDL_SetEventFilter", ExactSpelling = true)]
    public static extern void SetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_GetEventFilter", ExactSpelling = true)]
    public static extern bool GetEventFilter(delegate* unmanaged[Cdecl]<void*, SDL_Event*, by**** filter, void** userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
    public static extern bool AddEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveEventWatch", ExactSpelling = true)]
    public static extern void RemoveEventWatch(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_FilterEvents", ExactSpelling = true)]
    public static extern void FilterEvents(delegate* unmanaged[Cdecl]<void*, SDL_Event*, byte> filter, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetEventEnabled", ExactSpelling = true)]
    public static extern void SetEventEnabled(uint type, byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_EventEnabled", ExactSpelling = true)]
    public static extern bool EventEnabled(uint type);

    [DllImport(LibraryName, EntryPoint = "SDL_RegisterEvents", ExactSpelling = true)]
    public static extern uint RegisterEvents(int numevents);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowFromEvent", ExactSpelling = true)]
    public static extern Window GetWindowFromEvent(Event* @event);

    [DllImport(LibraryName, EntryPoint = "SDL_GetEventDescription", ExactSpelling = true)]
    public static extern int GetEventDescription(Event* @event, string buf, int buflen);

    [DllImport(LibraryName, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
    public static extern string GetBasePath();

    [DllImport(LibraryName, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
    public static extern string GetPrefPath(string org, string app);

    [DllImport(LibraryName, EntryPoint = "SDL_GetUserFolder", ExactSpelling = true)]
    public static extern string GetUserFolder(Folder folder);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateDirectory", ExactSpelling = true)]
    public static extern bool CreateDirectory(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_EnumerateDirectory", ExactSpelling = true)]
    public static extern bool EnumerateDirectory(string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_RemovePath", ExactSpelling = true)]
    public static extern bool RemovePath(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_RenamePath", ExactSpelling = true)]
    public static extern bool RenamePath(string oldpath, string newpath);

    [DllImport(LibraryName, EntryPoint = "SDL_CopyFile", ExactSpelling = true)]
    public static extern bool CopyFile(string oldpath, string newpath);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPathInfo", ExactSpelling = true)]
    public static extern bool GetPathInfo(string path, PathInfo* info);

    [DllImport(LibraryName, EntryPoint = "SDL_GlobDirectory", ExactSpelling = true)]
    public static extern sbyte** GlobDirectory(string path, string pattern, uint flags, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
    public static extern string GetCurrentDirectory();

    [DllImport(LibraryName, EntryPoint = "SDL_AddGamepadMapping", ExactSpelling = true)]
    public static extern int AddGamepadMapping(string mapping);

    [DllImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromIO", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromIO(IOStream src, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_AddGamepadMappingsFromFile", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromFile(string file);

    [DllImport(LibraryName, EntryPoint = "SDL_ReloadGamepadMappings", ExactSpelling = true)]
    public static extern bool ReloadGamepadMappings();

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMappings", ExactSpelling = true)]
    public static extern sbyte** GetGamepadMappings(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForGUID", ExactSpelling = true)]
    public static extern string GetGamepadMappingForGUID(GUID guid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMapping", ExactSpelling = true)]
    public static extern string GetGamepadMapping(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGamepadMapping", ExactSpelling = true)]
    public static extern bool SetGamepadMapping(uint instanceId, string mapping);

    [DllImport(LibraryName, EntryPoint = "SDL_HasGamepad", ExactSpelling = true)]
    public static extern bool HasGamepad();

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepads", ExactSpelling = true)]
    public static extern uint* GetGamepads(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_IsGamepad", ExactSpelling = true)]
    public static extern bool IsGamepad(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
    public static extern string GetGamepadNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
    public static extern string GetGamepadPathForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndexForID", ExactSpelling = true)]
    public static extern int GetGamepadPlayerIndexForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadGUIDForID", ExactSpelling = true)]
    public static extern GUID GetGamepadGUIDForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadVendorForID", ExactSpelling = true)]
    public static extern ushort GetGamepadVendorForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProductForID", ExactSpelling = true)]
    public static extern ushort GetGamepadProductForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersionForID", ExactSpelling = true)]
    public static extern ushort GetGamepadProductVersionForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeForID", ExactSpelling = true)]
    public static extern GamepadType GetGamepadTypeForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRealGamepadTypeForID", ExactSpelling = true)]
    public static extern GamepadType GetRealGamepadTypeForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
    public static extern string GetGamepadMappingForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenGamepad", ExactSpelling = true)]
    public static extern Gamepad OpenGamepad(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFromID", ExactSpelling = true)]
    public static extern Gamepad GetGamepadFromID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFromPlayerIndex", ExactSpelling = true)]
    public static extern Gamepad GetGamepadFromPlayerIndex(int playerIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProperties", ExactSpelling = true)]
    public static extern uint GetGamepadProperties(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadID", ExactSpelling = true)]
    public static extern uint GetGamepadID(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadName", ExactSpelling = true)]
    public static extern string GetGamepadName(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPath", ExactSpelling = true)]
    public static extern string GetGamepadPath(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadType", ExactSpelling = true)]
    public static extern GamepadType GetGamepadType(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRealGamepadType", ExactSpelling = true)]
    public static extern GamepadType GetRealGamepadType(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPlayerIndex", ExactSpelling = true)]
    public static extern int GetGamepadPlayerIndex(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGamepadPlayerIndex", ExactSpelling = true)]
    public static extern bool SetGamepadPlayerIndex(Gamepad gamepad, int playerIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadVendor", ExactSpelling = true)]
    public static extern ushort GetGamepadVendor(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProduct", ExactSpelling = true)]
    public static extern ushort GetGamepadProduct(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadProductVersion", ExactSpelling = true)]
    public static extern ushort GetGamepadProductVersion(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadFirmwareVersion", ExactSpelling = true)]
    public static extern ushort GetGamepadFirmwareVersion(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSerial", ExactSpelling = true)]
    public static extern string GetGamepadSerial(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSteamHandle", ExactSpelling = true)]
    public static extern nuint GetGamepadSteamHandle(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadConnectionState", ExactSpelling = true)]
    public static extern JoystickConnectionState GetGamepadConnectionState(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadPowerInfo", ExactSpelling = true)]
    public static extern PowerState GetGamepadPowerInfo(Gamepad gamepad, int* percent);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadConnected", ExactSpelling = true)]
    public static extern bool GamepadConnected(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadJoystick", ExactSpelling = true)]
    public static extern Joystick GetGamepadJoystick(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGamepadEventsEnabled", ExactSpelling = true)]
    public static extern void SetGamepadEventsEnabled(byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadEventsEnabled", ExactSpelling = true)]
    public static extern bool GamepadEventsEnabled();

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadBindings", ExactSpelling = true)]
    public static extern GamepadBinding** GetGamepadBindings(Gamepad gamepad, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateGamepads", ExactSpelling = true)]
    public static extern void UpdateGamepads();

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadTypeFromString", ExactSpelling = true)]
    public static extern GamepadType GetGamepadTypeFromString(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForType", ExactSpelling = true)]
    public static extern string GetGamepadStringForType(GamepadType type);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAxisFromString", ExactSpelling = true)]
    public static extern GamepadAxis GetGamepadAxisFromString(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForAxis", ExactSpelling = true)]
    public static extern string GetGamepadStringForAxis(GamepadAxis axis);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadHasAxis", ExactSpelling = true)]
    public static extern bool GamepadHasAxis(Gamepad gamepad, GamepadAxis axis);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAxis", ExactSpelling = true)]
    public static extern short GetGamepadAxis(Gamepad gamepad, GamepadAxis axis);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonFromString", ExactSpelling = true)]
    public static extern GamepadButton GetGamepadButtonFromString(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadStringForButton", ExactSpelling = true)]
    public static extern string GetGamepadStringForButton(GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadHasButton", ExactSpelling = true)]
    public static extern bool GamepadHasButton(Gamepad gamepad, GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButton", ExactSpelling = true)]
    public static extern bool GetGamepadButton(Gamepad gamepad, GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabelForType", ExactSpelling = true)]
    public static extern GamepadButtonLabel GetGamepadButtonLabelForType(GamepadType type, GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadButtonLabel", ExactSpelling = true)]
    public static extern GamepadButtonLabel GetGamepadButtonLabel(Gamepad gamepad, GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpads", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpads(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumGamepadTouchpadFingers", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpadFingers(Gamepad gamepad, int touchpad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadTouchpadFinger", ExactSpelling = true)]
    public static extern bool GetGamepadTouchpadFinger(Gamepad gamepad, int touchpad, int finger, bool* down, float* x, float* y, float* pressure);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadHasSensor", ExactSpelling = true)]
    public static extern bool GamepadHasSensor(Gamepad gamepad, SensorType type);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGamepadSensorEnabled", ExactSpelling = true)]
    public static extern bool SetGamepadSensorEnabled(Gamepad gamepad, SensorType type, byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_GamepadSensorEnabled", ExactSpelling = true)]
    public static extern bool GamepadSensorEnabled(Gamepad gamepad, SensorType type);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorDataRate", ExactSpelling = true)]
    public static extern float GetGamepadSensorDataRate(Gamepad gamepad, SensorType type);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadSensorData", ExactSpelling = true)]
    public static extern bool GetGamepadSensorData(Gamepad gamepad, SensorType type, float* data, int numValues);

    [DllImport(LibraryName, EntryPoint = "SDL_RumbleGamepad", ExactSpelling = true)]
    public static extern bool RumbleGamepad(Gamepad gamepad, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);

    [DllImport(LibraryName, EntryPoint = "SDL_RumbleGamepadTriggers", ExactSpelling = true)]
    public static extern bool RumbleGamepadTriggers(Gamepad gamepad, ushort leftRumble, ushort rightRumble, uint durationMs);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGamepadLED", ExactSpelling = true)]
    public static extern bool SetGamepadLED(Gamepad gamepad, byte red, byte green, byte blue);

    [DllImport(LibraryName, EntryPoint = "SDL_SendGamepadEffect", ExactSpelling = true)]
    public static extern bool SendGamepadEffect(Gamepad gamepad, void* data, int size);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseGamepad", ExactSpelling = true)]
    public static extern void CloseGamepad(Gamepad gamepad);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", ExactSpelling = true)]
    public static extern string GetGamepadAppleSFSymbolsNameForButton(Gamepad gamepad, GamepadButton button);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", ExactSpelling = true)]
    public static extern string GetGamepadAppleSFSymbolsNameForAxis(Gamepad gamepad, GamepadAxis axis);

    [DllImport(LibraryName, EntryPoint = "SDL_GPUSupportsShaderFormats", ExactSpelling = true)]
    public static extern bool GPUSupportsShaderFormats(uint formatFlags, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GPUSupportsProperties", ExactSpelling = true)]
    public static extern bool GPUSupportsProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUDevice", ExactSpelling = true)]
    public static extern GPUDevice CreateGPUDevice(uint formatFlags, byte debugMode, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUDeviceWithProperties", ExactSpelling = true)]
    public static extern GPUDevice CreateGPUDeviceWithProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyGPUDevice", ExactSpelling = true)]
    public static extern void DestroyGPUDevice(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumGPUDrivers", ExactSpelling = true)]
    public static extern int GetNumGPUDrivers();

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUDriver", ExactSpelling = true)]
    public static extern string GetGPUDriver(int index);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUDeviceDriver", ExactSpelling = true)]
    public static extern string GetGPUDeviceDriver(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUShaderFormats", ExactSpelling = true)]
    public static extern uint GetGPUShaderFormats(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUDeviceProperties", ExactSpelling = true)]
    public static extern uint GetGPUDeviceProperties(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUComputePipeline", ExactSpelling = true)]
    public static extern GPUComputePipeline CreateGPUComputePipeline(GPUDevice device, GPUComputePipelineCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern GPUGraphicsPipeline CreateGPUGraphicsPipeline(GPUDevice device, GPUGraphicsPipelineCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUSampler", ExactSpelling = true)]
    public static extern GPUSampler CreateGPUSampler(GPUDevice device, GPUSamplerCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUShader", ExactSpelling = true)]
    public static extern GPUShader CreateGPUShader(GPUDevice device, GPUShaderCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUTexture", ExactSpelling = true)]
    public static extern GPUTexture CreateGPUTexture(GPUDevice device, GPUTextureCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUBuffer", ExactSpelling = true)]
    public static extern GPUBuffer CreateGPUBuffer(GPUDevice device, GPUBufferCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPUTransferBuffer", ExactSpelling = true)]
    public static extern GPUTransferBuffer CreateGPUTransferBuffer(GPUDevice device, GPUTransferBufferCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUBufferName", ExactSpelling = true)]
    public static extern void SetGPUBufferName(GPUDevice device, GPUBuffer buffer, string text);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUTextureName", ExactSpelling = true)]
    public static extern void SetGPUTextureName(GPUDevice device, GPUTexture texture, string text);

    [DllImport(LibraryName, EntryPoint = "SDL_InsertGPUDebugLabel", ExactSpelling = true)]
    public static extern void InsertGPUDebugLabel(GPUCommandBuffer commandBuffer, string text);

    [DllImport(LibraryName, EntryPoint = "SDL_PushGPUDebugGroup", ExactSpelling = true)]
    public static extern void PushGPUDebugGroup(GPUCommandBuffer commandBuffer, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_PopGPUDebugGroup", ExactSpelling = true)]
    public static extern void PopGPUDebugGroup(GPUCommandBuffer commandBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUTexture", ExactSpelling = true)]
    public static extern void ReleaseGPUTexture(GPUDevice device, GPUTexture texture);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUSampler", ExactSpelling = true)]
    public static extern void ReleaseGPUSampler(GPUDevice device, GPUSampler sampler);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUBuffer", ExactSpelling = true)]
    public static extern void ReleaseGPUBuffer(GPUDevice device, GPUBuffer buffer);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUTransferBuffer", ExactSpelling = true)]
    public static extern void ReleaseGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUComputePipeline", ExactSpelling = true)]
    public static extern void ReleaseGPUComputePipeline(GPUDevice device, GPUComputePipeline computePipeline);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUShader", ExactSpelling = true)]
    public static extern void ReleaseGPUShader(GPUDevice device, GPUShader shader);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern void ReleaseGPUGraphicsPipeline(GPUDevice device, GPUGraphicsPipeline graphicsPipeline);

    [DllImport(LibraryName, EntryPoint = "SDL_AcquireGPUCommandBuffer", ExactSpelling = true)]
    public static extern GPUCommandBuffer AcquireGPUCommandBuffer(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_PushGPUVertexUniformData", ExactSpelling = true)]
    public static extern void PushGPUVertexUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [DllImport(LibraryName, EntryPoint = "SDL_PushGPUFragmentUniformData", ExactSpelling = true)]
    public static extern void PushGPUFragmentUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [DllImport(LibraryName, EntryPoint = "SDL_PushGPUComputeUniformData", ExactSpelling = true)]
    public static extern void PushGPUComputeUniformData(GPUCommandBuffer commandBuffer, uint slotIndex, void* data, uint length);

    [DllImport(LibraryName, EntryPoint = "SDL_BeginGPURenderPass", ExactSpelling = true)]
    public static extern GPURenderPass BeginGPURenderPass(GPUCommandBuffer commandBuffer, GPUColorTargetInfo* colorTargetInfos, uint numColorTargets, GPUDepthStencilTargetInfo* depthStencilTargetInfo);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUGraphicsPipeline", ExactSpelling = true)]
    public static extern void BindGPUGraphicsPipeline(GPURenderPass renderPass, GPUGraphicsPipeline graphicsPipeline);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUViewport", ExactSpelling = true)]
    public static extern void SetGPUViewport(GPURenderPass renderPass, GPUViewport* viewport);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUScissor", ExactSpelling = true)]
    public static extern void SetGPUScissor(GPURenderPass renderPass, Rect* scissor);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUBlendConstants", ExactSpelling = true)]
    public static extern void SetGPUBlendConstants(GPURenderPass renderPass, FColor blendConstants);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUStencilReference", ExactSpelling = true)]
    public static extern void SetGPUStencilReference(GPURenderPass renderPass, byte reference);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUVertexBuffers", ExactSpelling = true)]
    public static extern void BindGPUVertexBuffers(GPURenderPass renderPass, uint firstSlot, GPUBufferBinding* bindings, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUIndexBuffer", ExactSpelling = true)]
    public static extern void BindGPUIndexBuffer(GPURenderPass renderPass, GPUBufferBinding* binding, GPUIndexElementSize indexElementSize);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUVertexSamplers", ExactSpelling = true)]
    public static extern void BindGPUVertexSamplers(GPURenderPass renderPass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUVertexStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUVertexStorageTextures(GPURenderPass renderPass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUVertexStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUVertexStorageBuffers(GPURenderPass renderPass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentSamplers", ExactSpelling = true)]
    public static extern void BindGPUFragmentSamplers(GPURenderPass renderPass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUFragmentStorageTextures(GPURenderPass renderPass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUFragmentStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUFragmentStorageBuffers(GPURenderPass renderPass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_DrawGPUIndexedPrimitives", ExactSpelling = true)]
    public static extern void DrawGPUIndexedPrimitives(GPURenderPass renderPass, uint numIndices, uint numInstances, uint firstIndex, int vertexOffset, uint firstInstance);

    [DllImport(LibraryName, EntryPoint = "SDL_DrawGPUPrimitives", ExactSpelling = true)]
    public static extern void DrawGPUPrimitives(GPURenderPass renderPass, uint numVertices, uint numInstances, uint firstVertex, uint firstInstance);

    [DllImport(LibraryName, EntryPoint = "SDL_DrawGPUPrimitivesIndirect", ExactSpelling = true)]
    public static extern void DrawGPUPrimitivesIndirect(GPURenderPass renderPass, GPUBuffer buffer, uint offset, uint drawCount);

    [DllImport(LibraryName, EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect", ExactSpelling = true)]
    public static extern void DrawGPUIndexedPrimitivesIndirect(GPURenderPass renderPass, GPUBuffer buffer, uint offset, uint drawCount);

    [DllImport(LibraryName, EntryPoint = "SDL_EndGPURenderPass", ExactSpelling = true)]
    public static extern void EndGPURenderPass(GPURenderPass renderPass);

    [DllImport(LibraryName, EntryPoint = "SDL_BeginGPUComputePass", ExactSpelling = true)]
    public static extern GPUComputePass BeginGPUComputePass(GPUCommandBuffer commandBuffer, GPUStorageTextureReadWriteBinding* storageTextureBindings, uint numStorageTextureBindings, GPUStorageBufferReadWriteBinding* storageBufferBindings, uint numStorageBufferBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUComputePipeline", ExactSpelling = true)]
    public static extern void BindGPUComputePipeline(GPUComputePass computePass, GPUComputePipeline computePipeline);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUComputeSamplers", ExactSpelling = true)]
    public static extern void BindGPUComputeSamplers(GPUComputePass computePass, uint firstSlot, GPUTextureSamplerBinding* textureSamplerBindings, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUComputeStorageTextures", ExactSpelling = true)]
    public static extern void BindGPUComputeStorageTextures(GPUComputePass computePass, uint firstSlot, GPUTexture storageTextures, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_BindGPUComputeStorageBuffers", ExactSpelling = true)]
    public static extern void BindGPUComputeStorageBuffers(GPUComputePass computePass, uint firstSlot, GPUBuffer storageBuffers, uint numBindings);

    [DllImport(LibraryName, EntryPoint = "SDL_DispatchGPUCompute", ExactSpelling = true)]
    public static extern void DispatchGPUCompute(GPUComputePass computePass, uint groupcountX, uint groupcountY, uint groupcountZ);

    [DllImport(LibraryName, EntryPoint = "SDL_DispatchGPUComputeIndirect", ExactSpelling = true)]
    public static extern void DispatchGPUComputeIndirect(GPUComputePass computePass, GPUBuffer buffer, uint offset);

    [DllImport(LibraryName, EntryPoint = "SDL_EndGPUComputePass", ExactSpelling = true)]
    public static extern void EndGPUComputePass(GPUComputePass computePass);

    [DllImport(LibraryName, EntryPoint = "SDL_MapGPUTransferBuffer", ExactSpelling = true)]
    public static extern void* MapGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer, byte cycle);

    [DllImport(LibraryName, EntryPoint = "SDL_UnmapGPUTransferBuffer", ExactSpelling = true)]
    public static extern void UnmapGPUTransferBuffer(GPUDevice device, GPUTransferBuffer transferBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_BeginGPUCopyPass", ExactSpelling = true)]
    public static extern GPUCopyPass BeginGPUCopyPass(GPUCommandBuffer commandBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_UploadToGPUTexture", ExactSpelling = true)]
    public static extern void UploadToGPUTexture(GPUCopyPass copyPass, GPUTextureTransferInfo* source, GPUTextureRegion* destination, byte cycle);

    [DllImport(LibraryName, EntryPoint = "SDL_UploadToGPUBuffer", ExactSpelling = true)]
    public static extern void UploadToGPUBuffer(GPUCopyPass copyPass, GPUTransferBufferLocation* source, GPUBufferRegion* destination, byte cycle);

    [DllImport(LibraryName, EntryPoint = "SDL_CopyGPUTextureToTexture", ExactSpelling = true)]
    public static extern void CopyGPUTextureToTexture(GPUCopyPass copyPass, GPUTextureLocation* source, GPUTextureLocation* destination, uint w, uint h, uint d, byte cycle);

    [DllImport(LibraryName, EntryPoint = "SDL_CopyGPUBufferToBuffer", ExactSpelling = true)]
    public static extern void CopyGPUBufferToBuffer(GPUCopyPass copyPass, GPUBufferLocation* source, GPUBufferLocation* destination, uint size, byte cycle);

    [DllImport(LibraryName, EntryPoint = "SDL_DownloadFromGPUTexture", ExactSpelling = true)]
    public static extern void DownloadFromGPUTexture(GPUCopyPass copyPass, GPUTextureRegion* source, GPUTextureTransferInfo* destination);

    [DllImport(LibraryName, EntryPoint = "SDL_DownloadFromGPUBuffer", ExactSpelling = true)]
    public static extern void DownloadFromGPUBuffer(GPUCopyPass copyPass, GPUBufferRegion* source, GPUTransferBufferLocation* destination);

    [DllImport(LibraryName, EntryPoint = "SDL_EndGPUCopyPass", ExactSpelling = true)]
    public static extern void EndGPUCopyPass(GPUCopyPass copyPass);

    [DllImport(LibraryName, EntryPoint = "SDL_GenerateMipmapsForGPUTexture", ExactSpelling = true)]
    public static extern void GenerateMipmapsForGPUTexture(GPUCommandBuffer commandBuffer, GPUTexture texture);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitGPUTexture", ExactSpelling = true)]
    public static extern void BlitGPUTexture(GPUCommandBuffer commandBuffer, GPUBlitInfo* info);

    [DllImport(LibraryName, EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition", ExactSpelling = true)]
    public static extern bool WindowSupportsGPUSwapchainComposition(GPUDevice device, Window window, GPUSwapchainComposition swapchainComposition);

    [DllImport(LibraryName, EntryPoint = "SDL_WindowSupportsGPUPresentMode", ExactSpelling = true)]
    public static extern bool WindowSupportsGPUPresentMode(GPUDevice device, Window window, GPUPresentMode presentMode);

    [DllImport(LibraryName, EntryPoint = "SDL_ClaimWindowForGPUDevice", ExactSpelling = true)]
    public static extern bool ClaimWindowForGPUDevice(GPUDevice device, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseWindowFromGPUDevice", ExactSpelling = true)]
    public static extern void ReleaseWindowFromGPUDevice(GPUDevice device, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUSwapchainParameters", ExactSpelling = true)]
    public static extern bool SetGPUSwapchainParameters(GPUDevice device, Window window, GPUSwapchainComposition swapchainComposition, GPUPresentMode presentMode);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPUAllowedFramesInFlight", ExactSpelling = true)]
    public static extern bool SetGPUAllowedFramesInFlight(GPUDevice device, uint allowedFramesInFlight);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUSwapchainTextureFormat", ExactSpelling = true)]
    public static extern GPUTextureFormat GetGPUSwapchainTextureFormat(GPUDevice device, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_AcquireGPUSwapchainTexture", ExactSpelling = true)]
    public static extern bool AcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitForGPUSwapchain", ExactSpelling = true)]
    public static extern bool WaitForGPUSwapchain(GPUDevice device, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture", ExactSpelling = true)]
    public static extern bool WaitAndAcquireGPUSwapchainTexture(GPUCommandBuffer commandBuffer, Window window, GPUTexture swapchainTexture, uint* swapchainTextureWidth, uint* swapchainTextureHeight);

    [DllImport(LibraryName, EntryPoint = "SDL_SubmitGPUCommandBuffer", ExactSpelling = true)]
    public static extern bool SubmitGPUCommandBuffer(GPUCommandBuffer commandBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence", ExactSpelling = true)]
    public static extern GPUFence SubmitGPUCommandBufferAndAcquireFence(GPUCommandBuffer commandBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_CancelGPUCommandBuffer", ExactSpelling = true)]
    public static extern bool CancelGPUCommandBuffer(GPUCommandBuffer commandBuffer);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitForGPUIdle", ExactSpelling = true)]
    public static extern bool WaitForGPUIdle(GPUDevice device);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitForGPUFences", ExactSpelling = true)]
    public static extern bool WaitForGPUFences(GPUDevice device, byte waitAll, GPUFence fences, uint numFences);

    [DllImport(LibraryName, EntryPoint = "SDL_QueryGPUFence", ExactSpelling = true)]
    public static extern bool QueryGPUFence(GPUDevice device, GPUFence fence);

    [DllImport(LibraryName, EntryPoint = "SDL_ReleaseGPUFence", ExactSpelling = true)]
    public static extern void ReleaseGPUFence(GPUDevice device, GPUFence fence);

    [DllImport(LibraryName, EntryPoint = "SDL_GPUTextureFormatTexelBlockSize", ExactSpelling = true)]
    public static extern uint GPUTextureFormatTexelBlockSize(GPUTextureFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_GPUTextureSupportsFormat", ExactSpelling = true)]
    public static extern bool GPUTextureSupportsFormat(GPUDevice device, GPUTextureFormat format, GPUTextureType type, uint usage);

    [DllImport(LibraryName, EntryPoint = "SDL_GPUTextureSupportsSampleCount", ExactSpelling = true)]
    public static extern bool GPUTextureSupportsSampleCount(GPUDevice device, GPUTextureFormat format, GPUSampleCount sampleCount);

    [DllImport(LibraryName, EntryPoint = "SDL_CalculateGPUTextureFormatSize", ExactSpelling = true)]
    public static extern uint CalculateGPUTextureFormatSize(GPUTextureFormat format, uint width, uint height, uint depthOrLayerCount);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatFromGPUTextureFormat", ExactSpelling = true)]
    public static extern PixelFormat GetPixelFormatFromGPUTextureFormat(GPUTextureFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPUTextureFormatFromPixelFormat", ExactSpelling = true)]
    public static extern GPUTextureFormat GetGPUTextureFormatFromPixelFormat(PixelFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_GUIDToString", ExactSpelling = true)]
    public static extern void GUIDToString(GUID guid, string pszguid, int cbguid);

    [DllImport(LibraryName, EntryPoint = "SDL_StringToGUID", ExactSpelling = true)]
    public static extern GUID StringToGUID(string pchguid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHaptics", ExactSpelling = true)]
    public static extern uint* GetHaptics(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
    public static extern string GetHapticNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenHaptic", ExactSpelling = true)]
    public static extern Haptic OpenHaptic(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticFromID", ExactSpelling = true)]
    public static extern Haptic GetHapticFromID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticID", ExactSpelling = true)]
    public static extern uint GetHapticID(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
    public static extern string GetHapticName(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_IsMouseHaptic", ExactSpelling = true)]
    public static extern bool IsMouseHaptic();

    [DllImport(LibraryName, EntryPoint = "SDL_OpenHapticFromMouse", ExactSpelling = true)]
    public static extern Haptic OpenHapticFromMouse();

    [DllImport(LibraryName, EntryPoint = "SDL_IsJoystickHaptic", ExactSpelling = true)]
    public static extern bool IsJoystickHaptic(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenHapticFromJoystick", ExactSpelling = true)]
    public static extern Haptic OpenHapticFromJoystick(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseHaptic", ExactSpelling = true)]
    public static extern void CloseHaptic(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMaxHapticEffects", ExactSpelling = true)]
    public static extern int GetMaxHapticEffects(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMaxHapticEffectsPlaying", ExactSpelling = true)]
    public static extern int GetMaxHapticEffectsPlaying(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticFeatures", ExactSpelling = true)]
    public static extern uint GetHapticFeatures(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumHapticAxes", ExactSpelling = true)]
    public static extern int GetNumHapticAxes(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
    public static extern bool HapticEffectSupported(Haptic haptic, HapticEffect* effect);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateHapticEffect", ExactSpelling = true)]
    public static extern int CreateHapticEffect(Haptic haptic, HapticEffect* effect);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateHapticEffect", ExactSpelling = true)]
    public static extern bool UpdateHapticEffect(Haptic haptic, int effect, HapticEffect* data);

    [DllImport(LibraryName, EntryPoint = "SDL_RunHapticEffect", ExactSpelling = true)]
    public static extern bool RunHapticEffect(Haptic haptic, int effect, uint iterations);

    [DllImport(LibraryName, EntryPoint = "SDL_StopHapticEffect", ExactSpelling = true)]
    public static extern bool StopHapticEffect(Haptic haptic, int effect);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyHapticEffect", ExactSpelling = true)]
    public static extern void DestroyHapticEffect(Haptic haptic, int effect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHapticEffectStatus", ExactSpelling = true)]
    public static extern bool GetHapticEffectStatus(Haptic haptic, int effect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetHapticGain", ExactSpelling = true)]
    public static extern bool SetHapticGain(Haptic haptic, int gain);

    [DllImport(LibraryName, EntryPoint = "SDL_SetHapticAutocenter", ExactSpelling = true)]
    public static extern bool SetHapticAutocenter(Haptic haptic, int autocenter);

    [DllImport(LibraryName, EntryPoint = "SDL_PauseHaptic", ExactSpelling = true)]
    public static extern bool PauseHaptic(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_ResumeHaptic", ExactSpelling = true)]
    public static extern bool ResumeHaptic(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_StopHapticEffects", ExactSpelling = true)]
    public static extern bool StopHapticEffects(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
    public static extern bool HapticRumbleSupported(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_InitHapticRumble", ExactSpelling = true)]
    public static extern bool InitHapticRumble(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_PlayHapticRumble", ExactSpelling = true)]
    public static extern bool PlayHapticRumble(Haptic haptic, float strength, uint length);

    [DllImport(LibraryName, EntryPoint = "SDL_StopHapticRumble", ExactSpelling = true)]
    public static extern bool StopHapticRumble(Haptic haptic);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_init", ExactSpelling = true)]
    public static extern int HidInit();

    [DllImport(LibraryName, EntryPoint = "SDL_hid_exit", ExactSpelling = true)]
    public static extern int HidExit();

    [DllImport(LibraryName, EntryPoint = "SDL_hid_device_change_count", ExactSpelling = true)]
    public static extern uint HidDeviceChangeCount();

    [DllImport(LibraryName, EntryPoint = "SDL_hid_enumerate", ExactSpelling = true)]
    public static extern HidDeviceInfo* HidEnumerate(ushort vendorId, ushort productId);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_free_enumeration", ExactSpelling = true)]
    public static extern void HidFreeEnumeration(HidDeviceInfo* devs);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_open", ExactSpelling = true)]
    public static extern HidDevice HidOpen(ushort vendorId, ushort productId, uint* serialNumber);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_open_path", ExactSpelling = true)]
    public static extern HidDevice HidOpenPath(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_properties", ExactSpelling = true)]
    public static extern uint HidGetProperties(HidDevice dev);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_write", ExactSpelling = true)]
    public static extern int HidWrite(HidDevice dev, byte* data, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_read_timeout", ExactSpelling = true)]
    public static extern int HidReadTimeout(HidDevice dev, byte* data, nuint length, int milliseconds);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_read", ExactSpelling = true)]
    public static extern int HidRead(HidDevice dev, byte* data, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_set_nonblocking", ExactSpelling = true)]
    public static extern int HidSetNonblocking(HidDevice dev, int nonblock);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_send_feature_report", ExactSpelling = true)]
    public static extern int HidSendFeatureReport(HidDevice dev, byte* data, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_feature_report", ExactSpelling = true)]
    public static extern int HidGetFeatureReport(HidDevice dev, byte* data, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_input_report", ExactSpelling = true)]
    public static extern int HidGetInputReport(HidDevice dev, byte* data, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_close", ExactSpelling = true)]
    public static extern int HidClose(HidDevice dev);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_manufacturer_string", ExactSpelling = true)]
    public static extern int HidGetManufacturerString(HidDevice dev, uint* @string, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_product_string", ExactSpelling = true)]
    public static extern int HidGetProductString(HidDevice dev, uint* @string, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_serial_number_string", ExactSpelling = true)]
    public static extern int HidGetSerialNumberString(HidDevice dev, uint* @string, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_indexed_string", ExactSpelling = true)]
    public static extern int HidGetIndexedString(HidDevice dev, int stringIndex, uint* @string, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_device_info", ExactSpelling = true)]
    public static extern HidDeviceInfo* HidGetDeviceInfo(HidDevice dev);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_get_report_descriptor", ExactSpelling = true)]
    public static extern int HidGetReportDescriptor(HidDevice dev, byte* buf, nuint bufSize);

    [DllImport(LibraryName, EntryPoint = "SDL_hid_ble_scan", ExactSpelling = true)]
    public static extern void HidBleScan(byte active);

    [DllImport(LibraryName, EntryPoint = "SDL_SetHintWithPriority", ExactSpelling = true)]
    public static extern bool SetHintWithPriority(string name, string value, HintPriority priority);

    [DllImport(LibraryName, EntryPoint = "SDL_SetHint", ExactSpelling = true)]
    public static extern bool SetHint(string name, string value);

    [DllImport(LibraryName, EntryPoint = "SDL_ResetHint", ExactSpelling = true)]
    public static extern bool ResetHint(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_ResetHints", ExactSpelling = true)]
    public static extern void ResetHints();

    [DllImport(LibraryName, EntryPoint = "SDL_GetHint", ExactSpelling = true)]
    public static extern string GetHint(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetHintBoolean", ExactSpelling = true)]
    public static extern bool GetHintBoolean(string name, byte defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_AddHintCallback", ExactSpelling = true)]
    public static extern bool AddHintCallback(string name, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveHintCallback", ExactSpelling = true)]
    public static extern void RemoveHintCallback(string name, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, sbyte*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_Init", ExactSpelling = true)]
    public static extern bool Init(uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
    public static extern bool InitSubSystem(uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
    public static extern void QuitSubSystem(uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
    public static extern uint WasInit(uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_Quit", ExactSpelling = true)]
    public static extern void Quit();

    [DllImport(LibraryName, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
    public static extern bool IsMainThread();

    [DllImport(LibraryName, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
    public static extern bool RunOnMainThread(delegate* unmanaged[Cdecl]<void*, void> callback, void* userdata, byte waitComplete);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
    public static extern bool SetAppMetadata(string appname, string appversion, string appidentifier);

    [DllImport(LibraryName, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
    public static extern bool SetAppMetadataProperty(string name, string value);

    [DllImport(LibraryName, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
    public static extern string GetAppMetadataProperty(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_IOFromFile", ExactSpelling = true)]
    public static extern IOStream IOFromFile(string file, string mode);

    [DllImport(LibraryName, EntryPoint = "SDL_IOFromMem", ExactSpelling = true)]
    public static extern IOStream IOFromMem(void* mem, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_IOFromConstMem", ExactSpelling = true)]
    public static extern IOStream IOFromConstMem(void* mem, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_IOFromDynamicMem", ExactSpelling = true)]
    public static extern IOStream IOFromDynamicMem();

    [DllImport(LibraryName, EntryPoint = "SDL_OpenIO", ExactSpelling = true)]
    public static extern IOStream OpenIO(IOStreamInterface* iface, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseIO", ExactSpelling = true)]
    public static extern bool CloseIO(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_GetIOProperties", ExactSpelling = true)]
    public static extern uint GetIOProperties(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_GetIOStatus", ExactSpelling = true)]
    public static extern IOStatus GetIOStatus(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_GetIOSize", ExactSpelling = true)]
    public static extern nint GetIOSize(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_SeekIO", ExactSpelling = true)]
    public static extern nint SeekIO(IOStream context, nint offset, IOWhence whence);

    [DllImport(LibraryName, EntryPoint = "SDL_TellIO", ExactSpelling = true)]
    public static extern nint TellIO(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadIO", ExactSpelling = true)]
    public static extern nuint ReadIO(IOStream context, void* ptr, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteIO", ExactSpelling = true)]
    public static extern nuint WriteIO(IOStream context, void* ptr, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_IOprintf", ExactSpelling = true)]
    public static extern nuint IOprintf(IOStream context, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_IOvprintf", ExactSpelling = true)]
    public static extern nuint IOvprintf(IOStream context, string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_FlushIO", ExactSpelling = true)]
    public static extern bool FlushIO(IOStream context);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadFile_IO", ExactSpelling = true)]
    public static extern void* LoadFileIO(IOStream src, nuint* datasize, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
    public static extern void* LoadFile(string file, nuint* datasize);

    [DllImport(LibraryName, EntryPoint = "SDL_SaveFile_IO", ExactSpelling = true)]
    public static extern bool SaveFileIO(IOStream src, void* data, nuint datasize, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_SaveFile", ExactSpelling = true)]
    public static extern bool SaveFile(string file, void* data, nuint datasize);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
    public static extern bool ReadU8(IOStream src, byte* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS8", ExactSpelling = true)]
    public static extern bool ReadS8(IOStream src, string value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU16LE", ExactSpelling = true)]
    public static extern bool ReadU16LE(IOStream src, ushort* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS16LE", ExactSpelling = true)]
    public static extern bool ReadS16LE(IOStream src, short* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU16BE", ExactSpelling = true)]
    public static extern bool ReadU16BE(IOStream src, ushort* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS16BE", ExactSpelling = true)]
    public static extern bool ReadS16BE(IOStream src, short* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU32LE", ExactSpelling = true)]
    public static extern bool ReadU32LE(IOStream src, uint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS32LE", ExactSpelling = true)]
    public static extern bool ReadS32LE(IOStream src, int* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU32BE", ExactSpelling = true)]
    public static extern bool ReadU32BE(IOStream src, uint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS32BE", ExactSpelling = true)]
    public static extern bool ReadS32BE(IOStream src, int* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU64LE", ExactSpelling = true)]
    public static extern bool ReadU64LE(IOStream src, nuint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS64LE", ExactSpelling = true)]
    public static extern bool ReadS64LE(IOStream src, nint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadU64BE", ExactSpelling = true)]
    public static extern bool ReadU64BE(IOStream src, nuint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadS64BE", ExactSpelling = true)]
    public static extern bool ReadS64BE(IOStream src, nint* value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
    public static extern bool WriteU8(IOStream dst, byte value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS8", ExactSpelling = true)]
    public static extern bool WriteS8(IOStream dst, sbyte value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU16LE", ExactSpelling = true)]
    public static extern bool WriteU16LE(IOStream dst, ushort value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS16LE", ExactSpelling = true)]
    public static extern bool WriteS16LE(IOStream dst, short value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU16BE", ExactSpelling = true)]
    public static extern bool WriteU16BE(IOStream dst, ushort value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS16BE", ExactSpelling = true)]
    public static extern bool WriteS16BE(IOStream dst, short value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU32LE", ExactSpelling = true)]
    public static extern bool WriteU32LE(IOStream dst, uint value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS32LE", ExactSpelling = true)]
    public static extern bool WriteS32LE(IOStream dst, int value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU32BE", ExactSpelling = true)]
    public static extern bool WriteU32BE(IOStream dst, uint value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS32BE", ExactSpelling = true)]
    public static extern bool WriteS32BE(IOStream dst, int value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU64LE", ExactSpelling = true)]
    public static extern bool WriteU64LE(IOStream dst, nuint value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS64LE", ExactSpelling = true)]
    public static extern bool WriteS64LE(IOStream dst, nint value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteU64BE", ExactSpelling = true)]
    public static extern bool WriteU64BE(IOStream dst, nuint value);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteS64BE", ExactSpelling = true)]
    public static extern bool WriteS64BE(IOStream dst, nint value);

    [DllImport(LibraryName, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
    public static extern void LockJoysticks();

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
    public static extern void UnlockJoysticks();

    [DllImport(LibraryName, EntryPoint = "SDL_HasJoystick", ExactSpelling = true)]
    public static extern bool HasJoystick();

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
    public static extern uint* GetJoysticks(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
    public static extern string GetJoystickNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
    public static extern string GetJoystickPathForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
    public static extern int GetJoystickPlayerIndexForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
    public static extern GUID GetJoystickGUIDForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
    public static extern ushort GetJoystickVendorForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
    public static extern ushort GetJoystickProductForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
    public static extern ushort GetJoystickProductVersionForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
    public static extern JoystickType GetJoystickTypeForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
    public static extern Joystick OpenJoystick(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
    public static extern Joystick GetJoystickFromID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
    public static extern Joystick GetJoystickFromPlayerIndex(int playerIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
    public static extern uint AttachVirtualJoystick(VirtualJoystickDesc* desc);

    [DllImport(LibraryName, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
    public static extern bool DetachVirtualJoystick(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
    public static extern bool IsJoystickVirtual(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
    public static extern bool SetJoystickVirtualAxis(Joystick joystick, int axis, short value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
    public static extern bool SetJoystickVirtualBall(Joystick joystick, int ball, short xrel, short yrel);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
    public static extern bool SetJoystickVirtualButton(Joystick joystick, int button, byte down);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
    public static extern bool SetJoystickVirtualHat(Joystick joystick, int hat, byte value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
    public static extern bool SetJoystickVirtualTouchpad(Joystick joystick, int touchpad, int finger, byte down, float x, float y, float pressure);

    [DllImport(LibraryName, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
    public static extern bool SendJoystickVirtualSensorData(Joystick joystick, SensorType type, nuint sensorTimestamp, float* data, int numValues);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
    public static extern uint GetJoystickProperties(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
    public static extern string GetJoystickName(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
    public static extern string GetJoystickPath(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
    public static extern int GetJoystickPlayerIndex(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
    public static extern bool SetJoystickPlayerIndex(Joystick joystick, int playerIndex);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
    public static extern GUID GetJoystickGUID(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
    public static extern ushort GetJoystickVendor(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
    public static extern ushort GetJoystickProduct(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
    public static extern ushort GetJoystickProductVersion(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
    public static extern ushort GetJoystickFirmwareVersion(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
    public static extern string GetJoystickSerial(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
    public static extern JoystickType GetJoystickType(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
    public static extern void GetJoystickGUIDInfo(GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
    public static extern bool JoystickConnected(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
    public static extern uint GetJoystickID(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickAxes", ExactSpelling = true)]
    public static extern int GetNumJoystickAxes(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickBalls", ExactSpelling = true)]
    public static extern int GetNumJoystickBalls(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickHats", ExactSpelling = true)]
    public static extern int GetNumJoystickHats(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumJoystickButtons", ExactSpelling = true)]
    public static extern int GetNumJoystickButtons(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickEventsEnabled", ExactSpelling = true)]
    public static extern void SetJoystickEventsEnabled(byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
    public static extern bool JoystickEventsEnabled();

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
    public static extern void UpdateJoysticks();

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
    public static extern short GetJoystickAxis(Joystick joystick, int axis);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
    public static extern bool GetJoystickAxisInitialState(Joystick joystick, int axis, short* state);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
    public static extern bool GetJoystickBall(Joystick joystick, int ball, int* dx, int* dy);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
    public static extern byte GetJoystickHat(Joystick joystick, int hat);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
    public static extern bool GetJoystickButton(Joystick joystick, int button);

    [DllImport(LibraryName, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
    public static extern bool RumbleJoystick(Joystick joystick, ushort lowFrequencyRumble, ushort highFrequencyRumble, uint durationMs);

    [DllImport(LibraryName, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
    public static extern bool RumbleJoystickTriggers(Joystick joystick, ushort leftRumble, ushort rightRumble, uint durationMs);

    [DllImport(LibraryName, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
    public static extern bool SetJoystickLED(Joystick joystick, byte red, byte green, byte blue);

    [DllImport(LibraryName, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
    public static extern bool SendJoystickEffect(Joystick joystick, void* data, int size);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
    public static extern void CloseJoystick(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
    public static extern JoystickConnectionState GetJoystickConnectionState(Joystick joystick);

    [DllImport(LibraryName, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
    public static extern PowerState GetJoystickPowerInfo(Joystick joystick, int* percent);

    [DllImport(LibraryName, EntryPoint = "SDL_HasKeyboard", ExactSpelling = true)]
    public static extern bool HasKeyboard();

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboards", ExactSpelling = true)]
    public static extern uint* GetKeyboards(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardNameForID", ExactSpelling = true)]
    public static extern string GetKeyboardNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
    public static extern Window GetKeyboardFocus();

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
    public static extern bool* GetKeyboardState(int* numkeys);

    [DllImport(LibraryName, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
    public static extern void ResetKeyboard();

    [DllImport(LibraryName, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
    public static extern ushort GetModState();

    [DllImport(LibraryName, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
    public static extern void SetModState(ushort modstate);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
    public static extern uint GetKeyFromScancode(Scancode scancode, ushort modstate, byte keyEvent);

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
    public static extern Scancode GetScancodeFromKey(uint key, ushort* modstate);

    [DllImport(LibraryName, EntryPoint = "SDL_SetScancodeName", ExactSpelling = true)]
    public static extern bool SetScancodeName(Scancode scancode, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
    public static extern string GetScancodeName(Scancode scancode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
    public static extern Scancode GetScancodeFromName(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
    public static extern string GetKeyName(uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
    public static extern uint GetKeyFromName(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
    public static extern bool StartTextInput(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_StartTextInputWithProperties", ExactSpelling = true)]
    public static extern bool StartTextInputWithProperties(Window window, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_TextInputActive", ExactSpelling = true)]
    public static extern bool TextInputActive(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
    public static extern bool StopTextInput(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
    public static extern bool ClearComposition(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextInputArea", ExactSpelling = true)]
    public static extern bool SetTextInputArea(Window window, Rect* rect, int cursor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextInputArea", ExactSpelling = true)]
    public static extern bool GetTextInputArea(Window window, Rect* rect, int* cursor);

    [DllImport(LibraryName, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
    public static extern bool HasScreenKeyboardSupport();

    [DllImport(LibraryName, EntryPoint = "SDL_ScreenKeyboardShown", ExactSpelling = true)]
    public static extern bool ScreenKeyboardShown(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadObject", ExactSpelling = true)]
    public static extern SharedObject LoadObject(string sofile);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadFunction", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<void> LoadFunction(SharedObject handle, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_UnloadObject", ExactSpelling = true)]
    public static extern void UnloadObject(SharedObject handle);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
    public static extern Locale** GetPreferredLocales(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_SetLogPriorities", ExactSpelling = true)]
    public static extern void SetLogPriorities(LogPriority priority);

    [DllImport(LibraryName, EntryPoint = "SDL_SetLogPriority", ExactSpelling = true)]
    public static extern void SetLogPriority(int category, LogPriority priority);

    [DllImport(LibraryName, EntryPoint = "SDL_GetLogPriority", ExactSpelling = true)]
    public static extern LogPriority GetLogPriority(int category);

    [DllImport(LibraryName, EntryPoint = "SDL_ResetLogPriorities", ExactSpelling = true)]
    public static extern void ResetLogPriorities();

    [DllImport(LibraryName, EntryPoint = "SDL_SetLogPriorityPrefix", ExactSpelling = true)]
    public static extern bool SetLogPriorityPrefix(LogPriority priority, string prefix);

    [DllImport(LibraryName, EntryPoint = "SDL_Log", ExactSpelling = true)]
    public static extern void Log(string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogTrace", ExactSpelling = true)]
    public static extern void LogTrace(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogVerbose", ExactSpelling = true)]
    public static extern void LogVerbose(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogDebug", ExactSpelling = true)]
    public static extern void LogDebug(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogInfo", ExactSpelling = true)]
    public static extern void LogInfo(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogWarn", ExactSpelling = true)]
    public static extern void LogWarn(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogError", ExactSpelling = true)]
    public static extern void LogError(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogCritical", ExactSpelling = true)]
    public static extern void LogCritical(int category, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogMessage", ExactSpelling = true)]
    public static extern void LogMessage(int category, LogPriority priority, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_LogMessageV", ExactSpelling = true)]
    public static extern void LogMessageV(int category, LogPriority priority, string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDefaultLogOutputFunction", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> GetDefaultLogOutputFunction();

    [DllImport(LibraryName, EntryPoint = "SDL_GetLogOutputFunction", ExactSpelling = true)]
    public static extern void GetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, vo**** callback, void** userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetLogOutputFunction", ExactSpelling = true)]
    public static extern void SetLogOutputFunction(delegate* unmanaged[Cdecl]<void*, int, SDL_LogPriority, sbyte*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_main", ExactSpelling = true)]
    public static extern int Main(int argc, sbyte** argv);

    [DllImport(LibraryName, EntryPoint = "SDL_SetMainReady", ExactSpelling = true)]
    public static extern void SetMainReady();

    [DllImport(LibraryName, EntryPoint = "SDL_RunApp", ExactSpelling = true)]
    public static extern int RunApp(int argc, sbyte** argv, delegate* unmanaged[Cdecl]<int, sbyte**, int> mainfunction, void* reserved);

    [DllImport(LibraryName, EntryPoint = "SDL_EnterAppMainCallbacks", ExactSpelling = true)]
    public static extern int EnterAppMainCallbacks(int argc, sbyte** argv, delegate* unmanaged[Cdecl]<void**, int, sbyte**, SDL_AppResult> appinit, delegate* unmanaged[Cdecl]<void*, SDL_AppResult> appiter, delegate* unmanaged[Cdecl]<void*, SDL_Event*, SDL_AppResult> appevent, delegate* unmanaged[Cdecl]<void*, SDL_AppResult, void> appquit);

    [DllImport(LibraryName, EntryPoint = "SDL_GDKSuspendComplete", ExactSpelling = true)]
    public static extern void GDKSuspendComplete();

    [DllImport(LibraryName, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
    public static extern bool ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
    public static extern bool ShowSimpleMessageBox(uint flags, string title, string message, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_Metal_CreateView", ExactSpelling = true)]
    public static extern void* MetalCreateView(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_Metal_DestroyView", ExactSpelling = true)]
    public static extern void MetalDestroyView(void* view);

    [DllImport(LibraryName, EntryPoint = "SDL_Metal_GetLayer", ExactSpelling = true)]
    public static extern void* MetalGetLayer(void* view);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
    public static extern bool OpenURL(string url);

    [DllImport(LibraryName, EntryPoint = "SDL_HasMouse", ExactSpelling = true)]
    public static extern bool HasMouse();

    [DllImport(LibraryName, EntryPoint = "SDL_GetMice", ExactSpelling = true)]
    public static extern uint* GetMice(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMouseNameForID", ExactSpelling = true)]
    public static extern string GetMouseNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMouseFocus", ExactSpelling = true)]
    public static extern Window GetMouseFocus();

    [DllImport(LibraryName, EntryPoint = "SDL_GetMouseState", ExactSpelling = true)]
    public static extern uint GetMouseState(float* x, float* y);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGlobalMouseState", ExactSpelling = true)]
    public static extern uint GetGlobalMouseState(float* x, float* y);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRelativeMouseState", ExactSpelling = true)]
    public static extern uint GetRelativeMouseState(float* x, float* y);

    [DllImport(LibraryName, EntryPoint = "SDL_WarpMouseInWindow", ExactSpelling = true)]
    public static extern void WarpMouseInWindow(Window window, float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_WarpMouseGlobal", ExactSpelling = true)]
    public static extern bool WarpMouseGlobal(float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRelativeMouseTransform", ExactSpelling = true)]
    public static extern bool SetRelativeMouseTransform(delegate* unmanaged[Cdecl]<void*, nuint, SDL_Window*, uint, float*, float*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowRelativeMouseMode", ExactSpelling = true)]
    public static extern bool SetWindowRelativeMouseMode(Window window, byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowRelativeMouseMode", ExactSpelling = true)]
    public static extern bool GetWindowRelativeMouseMode(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_CaptureMouse", ExactSpelling = true)]
    public static extern bool CaptureMouse(byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateCursor", ExactSpelling = true)]
    public static extern Cursor CreateCursor(byte* data, byte* mask, int w, int h, int hotX, int hotY);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateColorCursor", ExactSpelling = true)]
    public static extern Cursor CreateColorCursor(Surface* surface, int hotX, int hotY);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateAnimatedCursor", ExactSpelling = true)]
    public static extern Cursor CreateAnimatedCursor(CursorFrameInfo* frames, int frameCount, int hotX, int hotY);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSystemCursor", ExactSpelling = true)]
    public static extern Cursor CreateSystemCursor(SystemCursor id);

    [DllImport(LibraryName, EntryPoint = "SDL_SetCursor", ExactSpelling = true)]
    public static extern bool SetCursor(Cursor cursor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCursor", ExactSpelling = true)]
    public static extern Cursor GetCursor();

    [DllImport(LibraryName, EntryPoint = "SDL_GetDefaultCursor", ExactSpelling = true)]
    public static extern Cursor GetDefaultCursor();

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyCursor", ExactSpelling = true)]
    public static extern void DestroyCursor(Cursor cursor);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowCursor", ExactSpelling = true)]
    public static extern bool ShowCursor();

    [DllImport(LibraryName, EntryPoint = "SDL_HideCursor", ExactSpelling = true)]
    public static extern bool HideCursor();

    [DllImport(LibraryName, EntryPoint = "SDL_CursorVisible", ExactSpelling = true)]
    public static extern bool CursorVisible();

    [DllImport(LibraryName, EntryPoint = "SDL_CreateMutex", ExactSpelling = true)]
    public static extern Mutex CreateMutex();

    [DllImport(LibraryName, EntryPoint = "SDL_LockMutex", ExactSpelling = true)]
    public static extern void LockMutex(Mutex mutex);

    [DllImport(LibraryName, EntryPoint = "SDL_TryLockMutex", ExactSpelling = true)]
    public static extern bool TryLockMutex(Mutex mutex);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockMutex", ExactSpelling = true)]
    public static extern void UnlockMutex(Mutex mutex);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyMutex", ExactSpelling = true)]
    public static extern void DestroyMutex(Mutex mutex);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRWLock", ExactSpelling = true)]
    public static extern RWLock CreateRWLock();

    [DllImport(LibraryName, EntryPoint = "SDL_LockRWLockForReading", ExactSpelling = true)]
    public static extern void LockRWLockForReading(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_LockRWLockForWriting", ExactSpelling = true)]
    public static extern void LockRWLockForWriting(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_TryLockRWLockForReading", ExactSpelling = true)]
    public static extern bool TryLockRWLockForReading(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_TryLockRWLockForWriting", ExactSpelling = true)]
    public static extern bool TryLockRWLockForWriting(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockRWLock", ExactSpelling = true)]
    public static extern void UnlockRWLock(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyRWLock", ExactSpelling = true)]
    public static extern void DestroyRWLock(RWLock rwlock);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSemaphore", ExactSpelling = true)]
    public static extern Semaphore CreateSemaphore(uint initialValue);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroySemaphore", ExactSpelling = true)]
    public static extern void DestroySemaphore(Semaphore sem);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitSemaphore", ExactSpelling = true)]
    public static extern void WaitSemaphore(Semaphore sem);

    [DllImport(LibraryName, EntryPoint = "SDL_TryWaitSemaphore", ExactSpelling = true)]
    public static extern bool TryWaitSemaphore(Semaphore sem);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitSemaphoreTimeout", ExactSpelling = true)]
    public static extern bool WaitSemaphoreTimeout(Semaphore sem, int timeoutms);

    [DllImport(LibraryName, EntryPoint = "SDL_SignalSemaphore", ExactSpelling = true)]
    public static extern void SignalSemaphore(Semaphore sem);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSemaphoreValue", ExactSpelling = true)]
    public static extern uint GetSemaphoreValue(Semaphore sem);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateCondition", ExactSpelling = true)]
    public static extern Condition CreateCondition();

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyCondition", ExactSpelling = true)]
    public static extern void DestroyCondition(Condition cond);

    [DllImport(LibraryName, EntryPoint = "SDL_SignalCondition", ExactSpelling = true)]
    public static extern void SignalCondition(Condition cond);

    [DllImport(LibraryName, EntryPoint = "SDL_BroadcastCondition", ExactSpelling = true)]
    public static extern void BroadcastCondition(Condition cond);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitCondition", ExactSpelling = true)]
    public static extern void WaitCondition(Condition cond, Mutex mutex);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitConditionTimeout", ExactSpelling = true)]
    public static extern bool WaitConditionTimeout(Condition cond, Mutex mutex, int timeoutms);

    [DllImport(LibraryName, EntryPoint = "SDL_ShouldInit", ExactSpelling = true)]
    public static extern bool ShouldInit(InitState* state);

    [DllImport(LibraryName, EntryPoint = "SDL_ShouldQuit", ExactSpelling = true)]
    public static extern bool ShouldQuit(InitState* state);

    [DllImport(LibraryName, EntryPoint = "SDL_SetInitialized", ExactSpelling = true)]
    public static extern void SetInitialized(InitState* state, byte initialized);

    [DllImport(LibraryName, EntryPoint = "glClearIndex", ExactSpelling = true)]
    public static extern void GlClearIndex(float c);

    [DllImport(LibraryName, EntryPoint = "glClearColor", ExactSpelling = true)]
    public static extern void GlClearColor(float red, float green, float blue, float alpha);

    [DllImport(LibraryName, EntryPoint = "glClear", ExactSpelling = true)]
    public static extern void GlClear(uint mask);

    [DllImport(LibraryName, EntryPoint = "glIndexMask", ExactSpelling = true)]
    public static extern void GlIndexMask(uint mask);

    [DllImport(LibraryName, EntryPoint = "glColorMask", ExactSpelling = true)]
    public static extern void GlColorMask(byte red, byte green, byte blue, byte alpha);

    [DllImport(LibraryName, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
    public static extern void GlAlphaFunc(uint func, float @ref);

    [DllImport(LibraryName, EntryPoint = "glBlendFunc", ExactSpelling = true)]
    public static extern void GlBlendFunc(uint sfactor, uint dfactor);

    [DllImport(LibraryName, EntryPoint = "glLogicOp", ExactSpelling = true)]
    public static extern void GlLogicOp(uint opcode);

    [DllImport(LibraryName, EntryPoint = "glCullFace", ExactSpelling = true)]
    public static extern void GlCullFace(uint mode);

    [DllImport(LibraryName, EntryPoint = "glFrontFace", ExactSpelling = true)]
    public static extern void GlFrontFace(uint mode);

    [DllImport(LibraryName, EntryPoint = "glPointSize", ExactSpelling = true)]
    public static extern void GlPointSize(float size);

    [DllImport(LibraryName, EntryPoint = "glLineWidth", ExactSpelling = true)]
    public static extern void GlLineWidth(float width);

    [DllImport(LibraryName, EntryPoint = "glLineStipple", ExactSpelling = true)]
    public static extern void GlLineStipple(int factor, ushort pattern);

    [DllImport(LibraryName, EntryPoint = "glPolygonMode", ExactSpelling = true)]
    public static extern void GlPolygonMode(uint face, uint mode);

    [DllImport(LibraryName, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
    public static extern void GlPolygonOffset(float factor, float units);

    [DllImport(LibraryName, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
    public static extern void GlPolygonStipple(byte* mask);

    [DllImport(LibraryName, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
    public static extern void GlGetPolygonStipple(byte* mask);

    [DllImport(LibraryName, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
    public static extern void GlEdgeFlag(byte flag);

    [DllImport(LibraryName, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
    public static extern void GlEdgeFlagv(byte* flag);

    [DllImport(LibraryName, EntryPoint = "glScissor", ExactSpelling = true)]
    public static extern void GlScissor(int x, int y, int width, int height);

    [DllImport(LibraryName, EntryPoint = "glClipPlane", ExactSpelling = true)]
    public static extern void GlClipPlane(uint plane, double* equation);

    [DllImport(LibraryName, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
    public static extern void GlGetClipPlane(uint plane, double* equation);

    [DllImport(LibraryName, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
    public static extern void GlDrawBuffer(uint mode);

    [DllImport(LibraryName, EntryPoint = "glReadBuffer", ExactSpelling = true)]
    public static extern void GlReadBuffer(uint mode);

    [DllImport(LibraryName, EntryPoint = "glEnable", ExactSpelling = true)]
    public static extern void GlEnable(uint cap);

    [DllImport(LibraryName, EntryPoint = "glDisable", ExactSpelling = true)]
    public static extern void GlDisable(uint cap);

    [DllImport(LibraryName, EntryPoint = "glIsEnabled", ExactSpelling = true)]
    public static extern byte GlIsEnabled(uint cap);

    [DllImport(LibraryName, EntryPoint = "glEnableClientState", ExactSpelling = true)]
    public static extern void GlEnableClientState(uint cap);

    [DllImport(LibraryName, EntryPoint = "glDisableClientState", ExactSpelling = true)]
    public static extern void GlDisableClientState(uint cap);

    [DllImport(LibraryName, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
    public static extern void GlGetBooleanv(uint pname, byte* @params);

    [DllImport(LibraryName, EntryPoint = "glGetDoublev", ExactSpelling = true)]
    public static extern void GlGetDoublev(uint pname, double* @params);

    [DllImport(LibraryName, EntryPoint = "glGetFloatv", ExactSpelling = true)]
    public static extern void GlGetFloatv(uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
    public static extern void GlGetIntegerv(uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glPushAttrib", ExactSpelling = true)]
    public static extern void GlPushAttrib(uint mask);

    [DllImport(LibraryName, EntryPoint = "glPopAttrib", ExactSpelling = true)]
    public static extern void GlPopAttrib();

    [DllImport(LibraryName, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
    public static extern void GlPushClientAttrib(uint mask);

    [DllImport(LibraryName, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
    public static extern void GlPopClientAttrib();

    [DllImport(LibraryName, EntryPoint = "glRenderMode", ExactSpelling = true)]
    public static extern int GlRenderMode(uint mode);

    [DllImport(LibraryName, EntryPoint = "glGetError", ExactSpelling = true)]
    public static extern uint GlGetError();

    [DllImport(LibraryName, EntryPoint = "glGetString", ExactSpelling = true)]
    public static extern byte* GlGetString(uint name);

    [DllImport(LibraryName, EntryPoint = "glFinish", ExactSpelling = true)]
    public static extern void GlFinish();

    [DllImport(LibraryName, EntryPoint = "glFlush", ExactSpelling = true)]
    public static extern void GlFlush();

    [DllImport(LibraryName, EntryPoint = "glHint", ExactSpelling = true)]
    public static extern void GlHint(uint target, uint mode);

    [DllImport(LibraryName, EntryPoint = "glClearDepth", ExactSpelling = true)]
    public static extern void GlClearDepth(double depth);

    [DllImport(LibraryName, EntryPoint = "glDepthFunc", ExactSpelling = true)]
    public static extern void GlDepthFunc(uint func);

    [DllImport(LibraryName, EntryPoint = "glDepthMask", ExactSpelling = true)]
    public static extern void GlDepthMask(byte flag);

    [DllImport(LibraryName, EntryPoint = "glDepthRange", ExactSpelling = true)]
    public static extern void GlDepthRange(double nearVal, double farVal);

    [DllImport(LibraryName, EntryPoint = "glClearAccum", ExactSpelling = true)]
    public static extern void GlClearAccum(float red, float green, float blue, float alpha);

    [DllImport(LibraryName, EntryPoint = "glAccum", ExactSpelling = true)]
    public static extern void GlAccum(uint op, float value);

    [DllImport(LibraryName, EntryPoint = "glMatrixMode", ExactSpelling = true)]
    public static extern void GlMatrixMode(uint mode);

    [DllImport(LibraryName, EntryPoint = "glOrtho", ExactSpelling = true)]
    public static extern void GlOrtho(double left, double right, double bottom, double top, double nearVal, double farVal);

    [DllImport(LibraryName, EntryPoint = "glFrustum", ExactSpelling = true)]
    public static extern void GlFrustum(double left, double right, double bottom, double top, double nearVal, double farVal);

    [DllImport(LibraryName, EntryPoint = "glViewport", ExactSpelling = true)]
    public static extern void GlViewport(int x, int y, int width, int height);

    [DllImport(LibraryName, EntryPoint = "glPushMatrix", ExactSpelling = true)]
    public static extern void GlPushMatrix();

    [DllImport(LibraryName, EntryPoint = "glPopMatrix", ExactSpelling = true)]
    public static extern void GlPopMatrix();

    [DllImport(LibraryName, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
    public static extern void GlLoadIdentity();

    [DllImport(LibraryName, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
    public static extern void GlLoadMatrixd(double* m);

    [DllImport(LibraryName, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
    public static extern void GlLoadMatrixf(float* m);

    [DllImport(LibraryName, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
    public static extern void GlMultMatrixd(double* m);

    [DllImport(LibraryName, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
    public static extern void GlMultMatrixf(float* m);

    [DllImport(LibraryName, EntryPoint = "glRotated", ExactSpelling = true)]
    public static extern void GlRotated(double angle, double x, double y, double z);

    [DllImport(LibraryName, EntryPoint = "glRotatef", ExactSpelling = true)]
    public static extern void GlRotatef(float angle, float x, float y, float z);

    [DllImport(LibraryName, EntryPoint = "glScaled", ExactSpelling = true)]
    public static extern void GlScaled(double x, double y, double z);

    [DllImport(LibraryName, EntryPoint = "glScalef", ExactSpelling = true)]
    public static extern void GlScalef(float x, float y, float z);

    [DllImport(LibraryName, EntryPoint = "glTranslated", ExactSpelling = true)]
    public static extern void GlTranslated(double x, double y, double z);

    [DllImport(LibraryName, EntryPoint = "glTranslatef", ExactSpelling = true)]
    public static extern void GlTranslatef(float x, float y, float z);

    [DllImport(LibraryName, EntryPoint = "glIsList", ExactSpelling = true)]
    public static extern byte GlIsList(uint list);

    [DllImport(LibraryName, EntryPoint = "glDeleteLists", ExactSpelling = true)]
    public static extern void GlDeleteLists(uint list, int range);

    [DllImport(LibraryName, EntryPoint = "glGenLists", ExactSpelling = true)]
    public static extern uint GlGenLists(int range);

    [DllImport(LibraryName, EntryPoint = "glNewList", ExactSpelling = true)]
    public static extern void GlNewList(uint list, uint mode);

    [DllImport(LibraryName, EntryPoint = "glEndList", ExactSpelling = true)]
    public static extern void GlEndList();

    [DllImport(LibraryName, EntryPoint = "glCallList", ExactSpelling = true)]
    public static extern void GlCallList(uint list);

    [DllImport(LibraryName, EntryPoint = "glCallLists", ExactSpelling = true)]
    public static extern void GlCallLists(int n, uint type, void* lists);

    [DllImport(LibraryName, EntryPoint = "glListBase", ExactSpelling = true)]
    public static extern void GlListBase(uint @base);

    [DllImport(LibraryName, EntryPoint = "glBegin", ExactSpelling = true)]
    public static extern void GlBegin(uint mode);

    [DllImport(LibraryName, EntryPoint = "glEnd", ExactSpelling = true)]
    public static extern void GlEnd();

    [DllImport(LibraryName, EntryPoint = "glVertex2d", ExactSpelling = true)]
    public static extern void GlVertex2d(double x, double y);

    [DllImport(LibraryName, EntryPoint = "glVertex2f", ExactSpelling = true)]
    public static extern void GlVertex2f(float x, float y);

    [DllImport(LibraryName, EntryPoint = "glVertex2i", ExactSpelling = true)]
    public static extern void GlVertex2i(int x, int y);

    [DllImport(LibraryName, EntryPoint = "glVertex2s", ExactSpelling = true)]
    public static extern void GlVertex2s(short x, short y);

    [DllImport(LibraryName, EntryPoint = "glVertex3d", ExactSpelling = true)]
    public static extern void GlVertex3d(double x, double y, double z);

    [DllImport(LibraryName, EntryPoint = "glVertex3f", ExactSpelling = true)]
    public static extern void GlVertex3f(float x, float y, float z);

    [DllImport(LibraryName, EntryPoint = "glVertex3i", ExactSpelling = true)]
    public static extern void GlVertex3i(int x, int y, int z);

    [DllImport(LibraryName, EntryPoint = "glVertex3s", ExactSpelling = true)]
    public static extern void GlVertex3s(short x, short y, short z);

    [DllImport(LibraryName, EntryPoint = "glVertex4d", ExactSpelling = true)]
    public static extern void GlVertex4d(double x, double y, double z, double w);

    [DllImport(LibraryName, EntryPoint = "glVertex4f", ExactSpelling = true)]
    public static extern void GlVertex4f(float x, float y, float z, float w);

    [DllImport(LibraryName, EntryPoint = "glVertex4i", ExactSpelling = true)]
    public static extern void GlVertex4i(int x, int y, int z, int w);

    [DllImport(LibraryName, EntryPoint = "glVertex4s", ExactSpelling = true)]
    public static extern void GlVertex4s(short x, short y, short z, short w);

    [DllImport(LibraryName, EntryPoint = "glVertex2dv", ExactSpelling = true)]
    public static extern void GlVertex2dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glVertex2fv", ExactSpelling = true)]
    public static extern void GlVertex2fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glVertex2iv", ExactSpelling = true)]
    public static extern void GlVertex2iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glVertex2sv", ExactSpelling = true)]
    public static extern void GlVertex2sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glVertex3dv", ExactSpelling = true)]
    public static extern void GlVertex3dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glVertex3fv", ExactSpelling = true)]
    public static extern void GlVertex3fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glVertex3iv", ExactSpelling = true)]
    public static extern void GlVertex3iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glVertex3sv", ExactSpelling = true)]
    public static extern void GlVertex3sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glVertex4dv", ExactSpelling = true)]
    public static extern void GlVertex4dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glVertex4fv", ExactSpelling = true)]
    public static extern void GlVertex4fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glVertex4iv", ExactSpelling = true)]
    public static extern void GlVertex4iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glVertex4sv", ExactSpelling = true)]
    public static extern void GlVertex4sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glNormal3b", ExactSpelling = true)]
    public static extern void GlNormal3b(sbyte nx, sbyte ny, sbyte nz);

    [DllImport(LibraryName, EntryPoint = "glNormal3d", ExactSpelling = true)]
    public static extern void GlNormal3d(double nx, double ny, double nz);

    [DllImport(LibraryName, EntryPoint = "glNormal3f", ExactSpelling = true)]
    public static extern void GlNormal3f(float nx, float ny, float nz);

    [DllImport(LibraryName, EntryPoint = "glNormal3i", ExactSpelling = true)]
    public static extern void GlNormal3i(int nx, int ny, int nz);

    [DllImport(LibraryName, EntryPoint = "glNormal3s", ExactSpelling = true)]
    public static extern void GlNormal3s(short nx, short ny, short nz);

    [DllImport(LibraryName, EntryPoint = "glNormal3bv", ExactSpelling = true)]
    public static extern void GlNormal3bv(string v);

    [DllImport(LibraryName, EntryPoint = "glNormal3dv", ExactSpelling = true)]
    public static extern void GlNormal3dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glNormal3fv", ExactSpelling = true)]
    public static extern void GlNormal3fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glNormal3iv", ExactSpelling = true)]
    public static extern void GlNormal3iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glNormal3sv", ExactSpelling = true)]
    public static extern void GlNormal3sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glIndexd", ExactSpelling = true)]
    public static extern void GlIndexd(double c);

    [DllImport(LibraryName, EntryPoint = "glIndexf", ExactSpelling = true)]
    public static extern void GlIndexf(float c);

    [DllImport(LibraryName, EntryPoint = "glIndexi", ExactSpelling = true)]
    public static extern void GlIndexi(int c);

    [DllImport(LibraryName, EntryPoint = "glIndexs", ExactSpelling = true)]
    public static extern void GlIndexs(short c);

    [DllImport(LibraryName, EntryPoint = "glIndexub", ExactSpelling = true)]
    public static extern void GlIndexub(byte c);

    [DllImport(LibraryName, EntryPoint = "glIndexdv", ExactSpelling = true)]
    public static extern void GlIndexdv(double* c);

    [DllImport(LibraryName, EntryPoint = "glIndexfv", ExactSpelling = true)]
    public static extern void GlIndexfv(float* c);

    [DllImport(LibraryName, EntryPoint = "glIndexiv", ExactSpelling = true)]
    public static extern void GlIndexiv(int* c);

    [DllImport(LibraryName, EntryPoint = "glIndexsv", ExactSpelling = true)]
    public static extern void GlIndexsv(short* c);

    [DllImport(LibraryName, EntryPoint = "glIndexubv", ExactSpelling = true)]
    public static extern void GlIndexubv(byte* c);

    [DllImport(LibraryName, EntryPoint = "glColor3b", ExactSpelling = true)]
    public static extern void GlColor3b(sbyte red, sbyte green, sbyte blue);

    [DllImport(LibraryName, EntryPoint = "glColor3d", ExactSpelling = true)]
    public static extern void GlColor3d(double red, double green, double blue);

    [DllImport(LibraryName, EntryPoint = "glColor3f", ExactSpelling = true)]
    public static extern void GlColor3f(float red, float green, float blue);

    [DllImport(LibraryName, EntryPoint = "glColor3i", ExactSpelling = true)]
    public static extern void GlColor3i(int red, int green, int blue);

    [DllImport(LibraryName, EntryPoint = "glColor3s", ExactSpelling = true)]
    public static extern void GlColor3s(short red, short green, short blue);

    [DllImport(LibraryName, EntryPoint = "glColor3ub", ExactSpelling = true)]
    public static extern void GlColor3ub(byte red, byte green, byte blue);

    [DllImport(LibraryName, EntryPoint = "glColor3ui", ExactSpelling = true)]
    public static extern void GlColor3ui(uint red, uint green, uint blue);

    [DllImport(LibraryName, EntryPoint = "glColor3us", ExactSpelling = true)]
    public static extern void GlColor3us(ushort red, ushort green, ushort blue);

    [DllImport(LibraryName, EntryPoint = "glColor4b", ExactSpelling = true)]
    public static extern void GlColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4d", ExactSpelling = true)]
    public static extern void GlColor4d(double red, double green, double blue, double alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4f", ExactSpelling = true)]
    public static extern void GlColor4f(float red, float green, float blue, float alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4i", ExactSpelling = true)]
    public static extern void GlColor4i(int red, int green, int blue, int alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4s", ExactSpelling = true)]
    public static extern void GlColor4s(short red, short green, short blue, short alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4ub", ExactSpelling = true)]
    public static extern void GlColor4ub(byte red, byte green, byte blue, byte alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4ui", ExactSpelling = true)]
    public static extern void GlColor4ui(uint red, uint green, uint blue, uint alpha);

    [DllImport(LibraryName, EntryPoint = "glColor4us", ExactSpelling = true)]
    public static extern void GlColor4us(ushort red, ushort green, ushort blue, ushort alpha);

    [DllImport(LibraryName, EntryPoint = "glColor3bv", ExactSpelling = true)]
    public static extern void GlColor3bv(string v);

    [DllImport(LibraryName, EntryPoint = "glColor3dv", ExactSpelling = true)]
    public static extern void GlColor3dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glColor3fv", ExactSpelling = true)]
    public static extern void GlColor3fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glColor3iv", ExactSpelling = true)]
    public static extern void GlColor3iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glColor3sv", ExactSpelling = true)]
    public static extern void GlColor3sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glColor3ubv", ExactSpelling = true)]
    public static extern void GlColor3ubv(byte* v);

    [DllImport(LibraryName, EntryPoint = "glColor3uiv", ExactSpelling = true)]
    public static extern void GlColor3uiv(uint* v);

    [DllImport(LibraryName, EntryPoint = "glColor3usv", ExactSpelling = true)]
    public static extern void GlColor3usv(ushort* v);

    [DllImport(LibraryName, EntryPoint = "glColor4bv", ExactSpelling = true)]
    public static extern void GlColor4bv(string v);

    [DllImport(LibraryName, EntryPoint = "glColor4dv", ExactSpelling = true)]
    public static extern void GlColor4dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glColor4fv", ExactSpelling = true)]
    public static extern void GlColor4fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glColor4iv", ExactSpelling = true)]
    public static extern void GlColor4iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glColor4sv", ExactSpelling = true)]
    public static extern void GlColor4sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glColor4ubv", ExactSpelling = true)]
    public static extern void GlColor4ubv(byte* v);

    [DllImport(LibraryName, EntryPoint = "glColor4uiv", ExactSpelling = true)]
    public static extern void GlColor4uiv(uint* v);

    [DllImport(LibraryName, EntryPoint = "glColor4usv", ExactSpelling = true)]
    public static extern void GlColor4usv(ushort* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
    public static extern void GlTexCoord1d(double s);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
    public static extern void GlTexCoord1f(float s);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
    public static extern void GlTexCoord1i(int s);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
    public static extern void GlTexCoord1s(short s);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
    public static extern void GlTexCoord2d(double s, double t);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
    public static extern void GlTexCoord2f(float s, float t);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
    public static extern void GlTexCoord2i(int s, int t);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
    public static extern void GlTexCoord2s(short s, short t);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
    public static extern void GlTexCoord3d(double s, double t, double r);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
    public static extern void GlTexCoord3f(float s, float t, float r);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
    public static extern void GlTexCoord3i(int s, int t, int r);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
    public static extern void GlTexCoord3s(short s, short t, short r);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
    public static extern void GlTexCoord4d(double s, double t, double r, double q);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
    public static extern void GlTexCoord4f(float s, float t, float r, float q);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
    public static extern void GlTexCoord4i(int s, int t, int r, int q);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
    public static extern void GlTexCoord4s(short s, short t, short r, short q);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
    public static extern void GlTexCoord1dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
    public static extern void GlTexCoord1fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
    public static extern void GlTexCoord1iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
    public static extern void GlTexCoord1sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
    public static extern void GlTexCoord2dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
    public static extern void GlTexCoord2fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
    public static extern void GlTexCoord2iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
    public static extern void GlTexCoord2sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
    public static extern void GlTexCoord3dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
    public static extern void GlTexCoord3fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
    public static extern void GlTexCoord3iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
    public static extern void GlTexCoord3sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
    public static extern void GlTexCoord4dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
    public static extern void GlTexCoord4fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
    public static extern void GlTexCoord4iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
    public static extern void GlTexCoord4sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
    public static extern void GlRasterPos2d(double x, double y);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
    public static extern void GlRasterPos2f(float x, float y);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
    public static extern void GlRasterPos2i(int x, int y);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
    public static extern void GlRasterPos2s(short x, short y);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
    public static extern void GlRasterPos3d(double x, double y, double z);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
    public static extern void GlRasterPos3f(float x, float y, float z);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
    public static extern void GlRasterPos3i(int x, int y, int z);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
    public static extern void GlRasterPos3s(short x, short y, short z);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
    public static extern void GlRasterPos4d(double x, double y, double z, double w);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
    public static extern void GlRasterPos4f(float x, float y, float z, float w);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
    public static extern void GlRasterPos4i(int x, int y, int z, int w);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
    public static extern void GlRasterPos4s(short x, short y, short z, short w);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
    public static extern void GlRasterPos2dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
    public static extern void GlRasterPos2fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
    public static extern void GlRasterPos2iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
    public static extern void GlRasterPos2sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
    public static extern void GlRasterPos3dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
    public static extern void GlRasterPos3fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
    public static extern void GlRasterPos3iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
    public static extern void GlRasterPos3sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
    public static extern void GlRasterPos4dv(double* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
    public static extern void GlRasterPos4fv(float* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
    public static extern void GlRasterPos4iv(int* v);

    [DllImport(LibraryName, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
    public static extern void GlRasterPos4sv(short* v);

    [DllImport(LibraryName, EntryPoint = "glRectd", ExactSpelling = true)]
    public static extern void GlRectd(double x1, double y1, double x2, double y2);

    [DllImport(LibraryName, EntryPoint = "glRectf", ExactSpelling = true)]
    public static extern void GlRectf(float x1, float y1, float x2, float y2);

    [DllImport(LibraryName, EntryPoint = "glRecti", ExactSpelling = true)]
    public static extern void GlRecti(int x1, int y1, int x2, int y2);

    [DllImport(LibraryName, EntryPoint = "glRects", ExactSpelling = true)]
    public static extern void GlRects(short x1, short y1, short x2, short y2);

    [DllImport(LibraryName, EntryPoint = "glRectdv", ExactSpelling = true)]
    public static extern void GlRectdv(double* v1, double* v2);

    [DllImport(LibraryName, EntryPoint = "glRectfv", ExactSpelling = true)]
    public static extern void GlRectfv(float* v1, float* v2);

    [DllImport(LibraryName, EntryPoint = "glRectiv", ExactSpelling = true)]
    public static extern void GlRectiv(int* v1, int* v2);

    [DllImport(LibraryName, EntryPoint = "glRectsv", ExactSpelling = true)]
    public static extern void GlRectsv(short* v1, short* v2);

    [DllImport(LibraryName, EntryPoint = "glVertexPointer", ExactSpelling = true)]
    public static extern void GlVertexPointer(int size, uint type, int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glNormalPointer", ExactSpelling = true)]
    public static extern void GlNormalPointer(uint type, int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glColorPointer", ExactSpelling = true)]
    public static extern void GlColorPointer(int size, uint type, int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glIndexPointer", ExactSpelling = true)]
    public static extern void GlIndexPointer(uint type, int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
    public static extern void GlTexCoordPointer(int size, uint type, int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
    public static extern void GlEdgeFlagPointer(int stride, void* ptr);

    [DllImport(LibraryName, EntryPoint = "glGetPointerv", ExactSpelling = true)]
    public static extern void GlGetPointerv(uint pname, void** @params);

    [DllImport(LibraryName, EntryPoint = "glArrayElement", ExactSpelling = true)]
    public static extern void GlArrayElement(int i);

    [DllImport(LibraryName, EntryPoint = "glDrawArrays", ExactSpelling = true)]
    public static extern void GlDrawArrays(uint mode, int first, int count);

    [DllImport(LibraryName, EntryPoint = "glDrawElements", ExactSpelling = true)]
    public static extern void GlDrawElements(uint mode, int count, uint type, void* indices);

    [DllImport(LibraryName, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
    public static extern void GlInterleavedArrays(uint format, int stride, void* pointer);

    [DllImport(LibraryName, EntryPoint = "glShadeModel", ExactSpelling = true)]
    public static extern void GlShadeModel(uint mode);

    [DllImport(LibraryName, EntryPoint = "glLightf", ExactSpelling = true)]
    public static extern void GlLightf(uint light, uint pname, float param2);

    [DllImport(LibraryName, EntryPoint = "glLighti", ExactSpelling = true)]
    public static extern void GlLighti(uint light, uint pname, int param2);

    [DllImport(LibraryName, EntryPoint = "glLightfv", ExactSpelling = true)]
    public static extern void GlLightfv(uint light, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glLightiv", ExactSpelling = true)]
    public static extern void GlLightiv(uint light, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetLightfv", ExactSpelling = true)]
    public static extern void GlGetLightfv(uint light, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetLightiv", ExactSpelling = true)]
    public static extern void GlGetLightiv(uint light, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glLightModelf", ExactSpelling = true)]
    public static extern void GlLightModelf(uint pname, float param1);

    [DllImport(LibraryName, EntryPoint = "glLightModeli", ExactSpelling = true)]
    public static extern void GlLightModeli(uint pname, int param1);

    [DllImport(LibraryName, EntryPoint = "glLightModelfv", ExactSpelling = true)]
    public static extern void GlLightModelfv(uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glLightModeliv", ExactSpelling = true)]
    public static extern void GlLightModeliv(uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glMaterialf", ExactSpelling = true)]
    public static extern void GlMaterialf(uint face, uint pname, float param2);

    [DllImport(LibraryName, EntryPoint = "glMateriali", ExactSpelling = true)]
    public static extern void GlMateriali(uint face, uint pname, int param2);

    [DllImport(LibraryName, EntryPoint = "glMaterialfv", ExactSpelling = true)]
    public static extern void GlMaterialfv(uint face, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glMaterialiv", ExactSpelling = true)]
    public static extern void GlMaterialiv(uint face, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
    public static extern void GlGetMaterialfv(uint face, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
    public static extern void GlGetMaterialiv(uint face, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glColorMaterial", ExactSpelling = true)]
    public static extern void GlColorMaterial(uint face, uint mode);

    [DllImport(LibraryName, EntryPoint = "glPixelZoom", ExactSpelling = true)]
    public static extern void GlPixelZoom(float xfactor, float yfactor);

    [DllImport(LibraryName, EntryPoint = "glPixelStoref", ExactSpelling = true)]
    public static extern void GlPixelStoref(uint pname, float param1);

    [DllImport(LibraryName, EntryPoint = "glPixelStorei", ExactSpelling = true)]
    public static extern void GlPixelStorei(uint pname, int param1);

    [DllImport(LibraryName, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
    public static extern void GlPixelTransferf(uint pname, float param1);

    [DllImport(LibraryName, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
    public static extern void GlPixelTransferi(uint pname, int param1);

    [DllImport(LibraryName, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
    public static extern void GlPixelMapfv(uint map, int mapsize, float* values);

    [DllImport(LibraryName, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
    public static extern void GlPixelMapuiv(uint map, int mapsize, uint* values);

    [DllImport(LibraryName, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
    public static extern void GlPixelMapusv(uint map, int mapsize, ushort* values);

    [DllImport(LibraryName, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
    public static extern void GlGetPixelMapfv(uint map, float* values);

    [DllImport(LibraryName, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
    public static extern void GlGetPixelMapuiv(uint map, uint* values);

    [DllImport(LibraryName, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
    public static extern void GlGetPixelMapusv(uint map, ushort* values);

    [DllImport(LibraryName, EntryPoint = "glBitmap", ExactSpelling = true)]
    public static extern void GlBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

    [DllImport(LibraryName, EntryPoint = "glReadPixels", ExactSpelling = true)]
    public static extern void GlReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glDrawPixels", ExactSpelling = true)]
    public static extern void GlDrawPixels(int width, int height, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glCopyPixels", ExactSpelling = true)]
    public static extern void GlCopyPixels(int x, int y, int width, int height, uint type);

    [DllImport(LibraryName, EntryPoint = "glStencilFunc", ExactSpelling = true)]
    public static extern void GlStencilFunc(uint func, int @ref, uint mask);

    [DllImport(LibraryName, EntryPoint = "glStencilMask", ExactSpelling = true)]
    public static extern void GlStencilMask(uint mask);

    [DllImport(LibraryName, EntryPoint = "glStencilOp", ExactSpelling = true)]
    public static extern void GlStencilOp(uint fail, uint zfail, uint zpass);

    [DllImport(LibraryName, EntryPoint = "glClearStencil", ExactSpelling = true)]
    public static extern void GlClearStencil(int s);

    [DllImport(LibraryName, EntryPoint = "glTexGend", ExactSpelling = true)]
    public static extern void GlTexGend(uint coord, uint pname, double param2);

    [DllImport(LibraryName, EntryPoint = "glTexGenf", ExactSpelling = true)]
    public static extern void GlTexGenf(uint coord, uint pname, float param2);

    [DllImport(LibraryName, EntryPoint = "glTexGeni", ExactSpelling = true)]
    public static extern void GlTexGeni(uint coord, uint pname, int param2);

    [DllImport(LibraryName, EntryPoint = "glTexGendv", ExactSpelling = true)]
    public static extern void GlTexGendv(uint coord, uint pname, double* @params);

    [DllImport(LibraryName, EntryPoint = "glTexGenfv", ExactSpelling = true)]
    public static extern void GlTexGenfv(uint coord, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glTexGeniv", ExactSpelling = true)]
    public static extern void GlTexGeniv(uint coord, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
    public static extern void GlGetTexGendv(uint coord, uint pname, double* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
    public static extern void GlGetTexGenfv(uint coord, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
    public static extern void GlGetTexGeniv(uint coord, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glTexEnvf", ExactSpelling = true)]
    public static extern void GlTexEnvf(uint target, uint pname, float param2);

    [DllImport(LibraryName, EntryPoint = "glTexEnvi", ExactSpelling = true)]
    public static extern void GlTexEnvi(uint target, uint pname, int param2);

    [DllImport(LibraryName, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
    public static extern void GlTexEnvfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glTexEnviv", ExactSpelling = true)]
    public static extern void GlTexEnviv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
    public static extern void GlGetTexEnvfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
    public static extern void GlGetTexEnviv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glTexParameterf", ExactSpelling = true)]
    public static extern void GlTexParameterf(uint target, uint pname, float param2);

    [DllImport(LibraryName, EntryPoint = "glTexParameteri", ExactSpelling = true)]
    public static extern void GlTexParameteri(uint target, uint pname, int param2);

    [DllImport(LibraryName, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
    public static extern void GlTexParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
    public static extern void GlTexParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
    public static extern void GlGetTexParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
    public static extern void GlGetTexParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
    public static extern void GlGetTexLevelParameterfv(uint target, int level, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
    public static extern void GlGetTexLevelParameteriv(uint target, int level, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glTexImage1D", ExactSpelling = true)]
    public static extern void GlTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glTexImage2D", ExactSpelling = true)]
    public static extern void GlTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glGetTexImage", ExactSpelling = true)]
    public static extern void GlGetTexImage(uint target, int level, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glGenTextures", ExactSpelling = true)]
    public static extern void GlGenTextures(int n, uint* textures);

    [DllImport(LibraryName, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
    public static extern void GlDeleteTextures(int n, uint* textures);

    [DllImport(LibraryName, EntryPoint = "glBindTexture", ExactSpelling = true)]
    public static extern void GlBindTexture(uint target, uint texture);

    [DllImport(LibraryName, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
    public static extern void GlPrioritizeTextures(int n, uint* textures, float* priorities);

    [DllImport(LibraryName, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
    public static extern byte GlAreTexturesResident(int n, uint* textures, byte* residences);

    [DllImport(LibraryName, EntryPoint = "glIsTexture", ExactSpelling = true)]
    public static extern byte GlIsTexture(uint texture);

    [DllImport(LibraryName, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
    public static extern void GlTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
    public static extern void GlTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
    public static extern void GlCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

    [DllImport(LibraryName, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
    public static extern void GlCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

    [DllImport(LibraryName, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
    public static extern void GlCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

    [DllImport(LibraryName, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
    public static extern void GlCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

    [DllImport(LibraryName, EntryPoint = "glMap1d", ExactSpelling = true)]
    public static extern void GlMap1d(uint target, double u1, double u2, int stride, int order, double* points);

    [DllImport(LibraryName, EntryPoint = "glMap1f", ExactSpelling = true)]
    public static extern void GlMap1f(uint target, float u1, float u2, int stride, int order, float* points);

    [DllImport(LibraryName, EntryPoint = "glMap2d", ExactSpelling = true)]
    public static extern void GlMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

    [DllImport(LibraryName, EntryPoint = "glMap2f", ExactSpelling = true)]
    public static extern void GlMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

    [DllImport(LibraryName, EntryPoint = "glGetMapdv", ExactSpelling = true)]
    public static extern void GlGetMapdv(uint target, uint query, double* v);

    [DllImport(LibraryName, EntryPoint = "glGetMapfv", ExactSpelling = true)]
    public static extern void GlGetMapfv(uint target, uint query, float* v);

    [DllImport(LibraryName, EntryPoint = "glGetMapiv", ExactSpelling = true)]
    public static extern void GlGetMapiv(uint target, uint query, int* v);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
    public static extern void GlEvalCoord1d(double u);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
    public static extern void GlEvalCoord1f(float u);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
    public static extern void GlEvalCoord1dv(double* u);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
    public static extern void GlEvalCoord1fv(float* u);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
    public static extern void GlEvalCoord2d(double u, double v);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
    public static extern void GlEvalCoord2f(float u, float v);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
    public static extern void GlEvalCoord2dv(double* u);

    [DllImport(LibraryName, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
    public static extern void GlEvalCoord2fv(float* u);

    [DllImport(LibraryName, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
    public static extern void GlMapGrid1d(int un, double u1, double u2);

    [DllImport(LibraryName, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
    public static extern void GlMapGrid1f(int un, float u1, float u2);

    [DllImport(LibraryName, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
    public static extern void GlMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

    [DllImport(LibraryName, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
    public static extern void GlMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

    [DllImport(LibraryName, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
    public static extern void GlEvalPoint1(int i);

    [DllImport(LibraryName, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
    public static extern void GlEvalPoint2(int i, int j);

    [DllImport(LibraryName, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
    public static extern void GlEvalMesh1(uint mode, int i1, int i2);

    [DllImport(LibraryName, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
    public static extern void GlEvalMesh2(uint mode, int i1, int i2, int j1, int j2);

    [DllImport(LibraryName, EntryPoint = "glFogf", ExactSpelling = true)]
    public static extern void GlFogf(uint pname, float param1);

    [DllImport(LibraryName, EntryPoint = "glFogi", ExactSpelling = true)]
    public static extern void GlFogi(uint pname, int param1);

    [DllImport(LibraryName, EntryPoint = "glFogfv", ExactSpelling = true)]
    public static extern void GlFogfv(uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glFogiv", ExactSpelling = true)]
    public static extern void GlFogiv(uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
    public static extern void GlFeedbackBuffer(int size, uint type, float* buffer);

    [DllImport(LibraryName, EntryPoint = "glPassThrough", ExactSpelling = true)]
    public static extern void GlPassThrough(float token);

    [DllImport(LibraryName, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
    public static extern void GlSelectBuffer(int size, uint* buffer);

    [DllImport(LibraryName, EntryPoint = "glInitNames", ExactSpelling = true)]
    public static extern void GlInitNames();

    [DllImport(LibraryName, EntryPoint = "glLoadName", ExactSpelling = true)]
    public static extern void GlLoadName(uint name);

    [DllImport(LibraryName, EntryPoint = "glPushName", ExactSpelling = true)]
    public static extern void GlPushName(uint name);

    [DllImport(LibraryName, EntryPoint = "glPopName", ExactSpelling = true)]
    public static extern void GlPopName();

    [DllImport(LibraryName, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
    public static extern void GlDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

    [DllImport(LibraryName, EntryPoint = "glTexImage3D", ExactSpelling = true)]
    public static extern void GlTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
    public static extern void GlTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

    [DllImport(LibraryName, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
    public static extern void GlCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

    [DllImport(LibraryName, EntryPoint = "glColorTable", ExactSpelling = true)]
    public static extern void GlColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table);

    [DllImport(LibraryName, EntryPoint = "glColorSubTable", ExactSpelling = true)]
    public static extern void GlColorSubTable(uint target, int start, int count, uint format, uint type, void* data);

    [DllImport(LibraryName, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
    public static extern void GlColorTableParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
    public static extern void GlColorTableParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
    public static extern void GlCopyColorSubTable(uint target, int start, int x, int y, int width);

    [DllImport(LibraryName, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
    public static extern void GlCopyColorTable(uint target, uint internalformat, int x, int y, int width);

    [DllImport(LibraryName, EntryPoint = "glGetColorTable", ExactSpelling = true)]
    public static extern void GlGetColorTable(uint target, uint format, uint type, void* table);

    [DllImport(LibraryName, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
    public static extern void GlGetColorTableParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
    public static extern void GlGetColorTableParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glBlendEquation", ExactSpelling = true)]
    public static extern void GlBlendEquation(uint mode);

    [DllImport(LibraryName, EntryPoint = "glBlendColor", ExactSpelling = true)]
    public static extern void GlBlendColor(float red, float green, float blue, float alpha);

    [DllImport(LibraryName, EntryPoint = "glHistogram", ExactSpelling = true)]
    public static extern void GlHistogram(uint target, int width, uint internalformat, byte sink);

    [DllImport(LibraryName, EntryPoint = "glResetHistogram", ExactSpelling = true)]
    public static extern void GlResetHistogram(uint target);

    [DllImport(LibraryName, EntryPoint = "glGetHistogram", ExactSpelling = true)]
    public static extern void GlGetHistogram(uint target, byte reset, uint format, uint type, void* values);

    [DllImport(LibraryName, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
    public static extern void GlGetHistogramParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
    public static extern void GlGetHistogramParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glMinmax", ExactSpelling = true)]
    public static extern void GlMinmax(uint target, uint internalformat, byte sink);

    [DllImport(LibraryName, EntryPoint = "glResetMinmax", ExactSpelling = true)]
    public static extern void GlResetMinmax(uint target);

    [DllImport(LibraryName, EntryPoint = "glGetMinmax", ExactSpelling = true)]
    public static extern void GlGetMinmax(uint target, byte reset, uint format, uint types, void* values);

    [DllImport(LibraryName, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
    public static extern void GlGetMinmaxParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
    public static extern void GlGetMinmaxParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
    public static extern void GlConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image);

    [DllImport(LibraryName, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
    public static extern void GlConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image);

    [DllImport(LibraryName, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
    public static extern void GlConvolutionParameterf(uint target, uint pname, float @params);

    [DllImport(LibraryName, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
    public static extern void GlConvolutionParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
    public static extern void GlConvolutionParameteri(uint target, uint pname, int @params);

    [DllImport(LibraryName, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
    public static extern void GlConvolutionParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
    public static extern void GlCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);

    [DllImport(LibraryName, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
    public static extern void GlCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);

    [DllImport(LibraryName, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
    public static extern void GlGetConvolutionFilter(uint target, uint format, uint type, void* image);

    [DllImport(LibraryName, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
    public static extern void GlGetConvolutionParameterfv(uint target, uint pname, float* @params);

    [DllImport(LibraryName, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
    public static extern void GlGetConvolutionParameteriv(uint target, uint pname, int* @params);

    [DllImport(LibraryName, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
    public static extern void GlSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);

    [DllImport(LibraryName, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
    public static extern void GlGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);

    [DllImport(LibraryName, EntryPoint = "glActiveTexture", ExactSpelling = true)]
    public static extern void GlActiveTexture(uint texture);

    [DllImport(LibraryName, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
    public static extern void GlClientActiveTexture(uint texture);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
    public static extern void GlCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
    public static extern void GlCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
    public static extern void GlCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
    public static extern void GlCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
    public static extern void GlCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
    public static extern void GlCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imagesize, void* data);

    [DllImport(LibraryName, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
    public static extern void GlGetCompressedTexImage(uint target, int lod, void* img);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1d(uint target, double s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1dv(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1f(uint target, float s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1fv(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1i(uint target, int s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1iv(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1s(uint target, short s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1sv(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2d(uint target, double s, double t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2dv(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2f(uint target, float s, float t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2fv(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2i(uint target, int s, int t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2iv(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2s(uint target, short s, short t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2sv(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3d(uint target, double s, double t, double r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3dv(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3f(uint target, float s, float t, float r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3fv(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3i(uint target, int s, int t, int r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3iv(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3s(uint target, short s, short t, short r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3sv(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4d(uint target, double s, double t, double r, double q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4dv(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4f(uint target, float s, float t, float r, float q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4fv(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4i(uint target, int s, int t, int r, int q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4iv(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4s(uint target, short s, short t, short r, short q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4sv(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
    public static extern void GlLoadTransposeMatrixd(double* m);

    [DllImport(LibraryName, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
    public static extern void GlLoadTransposeMatrixf(float* m);

    [DllImport(LibraryName, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
    public static extern void GlMultTransposeMatrixd(double* m);

    [DllImport(LibraryName, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
    public static extern void GlMultTransposeMatrixf(float* m);

    [DllImport(LibraryName, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
    public static extern void GlSampleCoverage(float value, byte invert);

    [DllImport(LibraryName, EntryPoint = "glActiveTextureARB", ExactSpelling = true)]
    public static extern void GlActiveTextureARB(uint texture);

    [DllImport(LibraryName, EntryPoint = "glClientActiveTextureARB", ExactSpelling = true)]
    public static extern void GlClientActiveTextureARB(uint texture);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1dARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1dARB(uint target, double s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1dvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1dvARB(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1fARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1fARB(uint target, float s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1fvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1fvARB(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1iARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1iARB(uint target, int s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1ivARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1ivARB(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1sARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1sARB(uint target, short s);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord1svARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord1svARB(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2dARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2dARB(uint target, double s, double t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2dvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2dvARB(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2fARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2fARB(uint target, float s, float t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2fvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2fvARB(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2iARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2iARB(uint target, int s, int t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2ivARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2ivARB(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2sARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2sARB(uint target, short s, short t);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord2svARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord2svARB(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3dARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3dARB(uint target, double s, double t, double r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3dvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3dvARB(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3fARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3fARB(uint target, float s, float t, float r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3fvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3fvARB(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3iARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3iARB(uint target, int s, int t, int r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3ivARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3ivARB(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3sARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3sARB(uint target, short s, short t, short r);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord3svARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord3svARB(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4dARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4dARB(uint target, double s, double t, double r, double q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4dvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4dvARB(uint target, double* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4fARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4fARB(uint target, float s, float t, float r, float q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4fvARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4fvARB(uint target, float* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4iARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4iARB(uint target, int s, int t, int r, int q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4ivARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4ivARB(uint target, int* v);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4sARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4sARB(uint target, short s, short t, short r, short q);

    [DllImport(LibraryName, EntryPoint = "glMultiTexCoord4svARB", ExactSpelling = true)]
    public static extern void GlMultiTexCoord4svARB(uint target, short* v);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPenDeviceType", ExactSpelling = true)]
    public static extern PenDeviceType GetPenDeviceType(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName", ExactSpelling = true)]
    public static extern string GetPixelFormatName(PixelFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormat", ExactSpelling = true)]
    public static extern bool GetMasksForPixelFormat(PixelFormat format, int* bpp, uint* rmask, uint* gmask, uint* bmask, uint* amask);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatForMasks", ExactSpelling = true)]
    public static extern PixelFormat GetPixelFormatForMasks(int bpp, uint rmask, uint gmask, uint bmask, uint amask);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatDetails", ExactSpelling = true)]
    public static extern PixelFormatDetails* GetPixelFormatDetails(PixelFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_CreatePalette", ExactSpelling = true)]
    public static extern Palette* CreatePalette(int ncolors);

    [DllImport(LibraryName, EntryPoint = "SDL_SetPaletteColors", ExactSpelling = true)]
    public static extern bool SetPaletteColors(Palette* palette, Color* colors, int firstcolor, int ncolors);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyPalette", ExactSpelling = true)]
    public static extern void DestroyPalette(Palette* palette);

    [DllImport(LibraryName, EntryPoint = "SDL_MapRGB", ExactSpelling = true)]
    public static extern uint MapRGB(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_MapRGBA", ExactSpelling = true)]
    public static extern uint MapRGBA(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b, byte a);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRGB", ExactSpelling = true)]
    public static extern void GetRGB(uint pixelvalue, PixelFormatDetails* format, Palette* palette, byte* r, byte* g, byte* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRGBA", ExactSpelling = true)]
    public static extern void GetRGBA(uint pixelvalue, PixelFormatDetails* format, Palette* palette, byte* r, byte* g, byte* b, byte* a);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPlatform", ExactSpelling = true)]
    public static extern string GetPlatform();

    [DllImport(LibraryName, EntryPoint = "SDL_GetPowerInfo", ExactSpelling = true)]
    public static extern PowerState GetPowerInfo(int* seconds, int* percent);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateProcess", ExactSpelling = true)]
    public static extern Process CreateProcess(sbyte** args, byte pipeStdio);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateProcessWithProperties", ExactSpelling = true)]
    public static extern Process CreateProcessWithProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_GetProcessProperties", ExactSpelling = true)]
    public static extern uint GetProcessProperties(Process process);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadProcess", ExactSpelling = true)]
    public static extern void* ReadProcess(Process process, nuint* datasize, int* exitcode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetProcessInput", ExactSpelling = true)]
    public static extern IOStream GetProcessInput(Process process);

    [DllImport(LibraryName, EntryPoint = "SDL_GetProcessOutput", ExactSpelling = true)]
    public static extern IOStream GetProcessOutput(Process process);

    [DllImport(LibraryName, EntryPoint = "SDL_KillProcess", ExactSpelling = true)]
    public static extern bool KillProcess(Process process, byte force);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitProcess", ExactSpelling = true)]
    public static extern bool WaitProcess(Process process, byte block, int* exitcode);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyProcess", ExactSpelling = true)]
    public static extern void DestroyProcess(Process process);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGlobalProperties", ExactSpelling = true)]
    public static extern uint GetGlobalProperties();

    [DllImport(LibraryName, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
    public static extern uint CreateProperties();

    [DllImport(LibraryName, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
    public static extern bool CopyProperties(uint src, uint dst);

    [DllImport(LibraryName, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
    public static extern bool LockProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
    public static extern void UnlockProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
    public static extern bool SetPointerPropertyWithCleanup(uint props, string name, void* value, delegate* unmanaged[Cdecl]<void*, void*, void> cleanup, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
    public static extern bool SetPointerProperty(uint props, string name, void* value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
    public static extern bool SetStringProperty(uint props, string name, string value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
    public static extern bool SetNumberProperty(uint props, string name, nint value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
    public static extern bool SetFloatProperty(uint props, string name, float value);

    [DllImport(LibraryName, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
    public static extern bool SetBooleanProperty(uint props, string name, byte value);

    [DllImport(LibraryName, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
    public static extern bool HasProperty(uint props, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPropertyType", ExactSpelling = true)]
    public static extern PropertyType GetPropertyType(uint props, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPointerProperty", ExactSpelling = true)]
    public static extern void* GetPointerProperty(uint props, string name, void* defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_GetStringProperty", ExactSpelling = true)]
    public static extern string GetStringProperty(uint props, string name, string defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumberProperty", ExactSpelling = true)]
    public static extern nint GetNumberProperty(uint props, string name, nint defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_GetFloatProperty", ExactSpelling = true)]
    public static extern float GetFloatProperty(uint props, string name, float defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_GetBooleanProperty", ExactSpelling = true)]
    public static extern bool GetBooleanProperty(uint props, string name, byte defaultValue);

    [DllImport(LibraryName, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
    public static extern bool ClearProperty(uint props, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
    public static extern bool EnumerateProperties(uint props, delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
    public static extern void DestroyProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_RectToFRect", ExactSpelling = true)]
    public static extern void RectToFRect(Rect* rect, FRect* frect);

    [DllImport(LibraryName, EntryPoint = "SDL_PointInRect", ExactSpelling = true)]
    public static extern bool PointInRect(Point* p, Rect* r);

    [DllImport(LibraryName, EntryPoint = "SDL_RectEmpty", ExactSpelling = true)]
    public static extern bool RectEmpty(Rect* r);

    [DllImport(LibraryName, EntryPoint = "SDL_RectsEqual", ExactSpelling = true)]
    public static extern bool RectsEqual(Rect* a, Rect* b);

    [DllImport(LibraryName, EntryPoint = "SDL_HasRectIntersection", ExactSpelling = true)]
    public static extern bool HasRectIntersection(Rect* a, Rect* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectIntersection", ExactSpelling = true)]
    public static extern bool GetRectIntersection(Rect* a, Rect* b, Rect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectUnion", ExactSpelling = true)]
    public static extern bool GetRectUnion(Rect* a, Rect* b, Rect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPoints", ExactSpelling = true)]
    public static extern bool GetRectEnclosingPoints(Point* points, int count, Rect* clip, Rect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersection", ExactSpelling = true)]
    public static extern bool GetRectAndLineIntersection(Rect* rect, int* x1, int* y1, int* x2, int* y2);

    [DllImport(LibraryName, EntryPoint = "SDL_PointInRectFloat", ExactSpelling = true)]
    public static extern bool PointInRectFloat(FPoint* p, FRect* r);

    [DllImport(LibraryName, EntryPoint = "SDL_RectEmptyFloat", ExactSpelling = true)]
    public static extern bool RectEmptyFloat(FRect* r);

    [DllImport(LibraryName, EntryPoint = "SDL_RectsEqualEpsilon", ExactSpelling = true)]
    public static extern bool RectsEqualEpsilon(FRect* a, FRect* b, float epsilon);

    [DllImport(LibraryName, EntryPoint = "SDL_RectsEqualFloat", ExactSpelling = true)]
    public static extern bool RectsEqualFloat(FRect* a, FRect* b);

    [DllImport(LibraryName, EntryPoint = "SDL_HasRectIntersectionFloat", ExactSpelling = true)]
    public static extern bool HasRectIntersectionFloat(FRect* a, FRect* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectIntersectionFloat", ExactSpelling = true)]
    public static extern bool GetRectIntersectionFloat(FRect* a, FRect* b, FRect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectUnionFloat", ExactSpelling = true)]
    public static extern bool GetRectUnionFloat(FRect* a, FRect* b, FRect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectEnclosingPointsFloat", ExactSpelling = true)]
    public static extern bool GetRectEnclosingPointsFloat(FPoint* points, int count, FRect* clip, FRect* result);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRectAndLineIntersectionFloat", ExactSpelling = true)]
    public static extern bool GetRectAndLineIntersectionFloat(FRect* rect, float* x1, float* y1, float* x2, float* y2);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
    public static extern int GetNumRenderDrivers();

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderDriver", ExactSpelling = true)]
    public static extern string GetRenderDriver(int index);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
    public static extern bool CreateWindowAndRenderer(string title, int width, int height, nuint windowFlags, Window window, Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
    public static extern Renderer CreateRenderer(Window window, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties", ExactSpelling = true)]
    public static extern Renderer CreateRendererWithProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPURenderer", ExactSpelling = true)]
    public static extern Renderer CreateGPURenderer(GPUDevice device, Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGPURendererDevice", ExactSpelling = true)]
    public static extern GPUDevice GetGPURendererDevice(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
    public static extern Renderer CreateSoftwareRenderer(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
    public static extern Renderer GetRenderer(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderWindow", ExactSpelling = true)]
    public static extern Window GetRenderWindow(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRendererName", ExactSpelling = true)]
    public static extern string GetRendererName(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRendererProperties", ExactSpelling = true)]
    public static extern uint GetRendererProperties(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize", ExactSpelling = true)]
    public static extern bool GetRenderOutputSize(Renderer renderer, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize", ExactSpelling = true)]
    public static extern bool GetCurrentRenderOutputSize(Renderer renderer, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
    public static extern Texture* CreateTexture(Renderer renderer, PixelFormat format, TextureAccess access, int w, int h);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
    public static extern Texture* CreateTextureFromSurface(Renderer renderer, Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties", ExactSpelling = true)]
    public static extern Texture* CreateTextureWithProperties(Renderer renderer, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureProperties", ExactSpelling = true)]
    public static extern uint GetTextureProperties(Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture", ExactSpelling = true)]
    public static extern Renderer GetRendererFromTexture(Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureSize", ExactSpelling = true)]
    public static extern bool GetTextureSize(Texture* texture, float* w, float* h);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTexturePalette", ExactSpelling = true)]
    public static extern bool SetTexturePalette(Texture* texture, Palette* palette);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTexturePalette", ExactSpelling = true)]
    public static extern Palette* GetTexturePalette(Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
    public static extern bool SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat", ExactSpelling = true)]
    public static extern bool SetTextureColorModFloat(Texture* texture, float r, float g, float b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
    public static extern bool GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat", ExactSpelling = true)]
    public static extern bool GetTextureColorModFloat(Texture* texture, float* r, float* g, float* b);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
    public static extern bool SetTextureAlphaMod(Texture* texture, byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat", ExactSpelling = true)]
    public static extern bool SetTextureAlphaModFloat(Texture* texture, float alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
    public static extern bool GetTextureAlphaMod(Texture* texture, byte* alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat", ExactSpelling = true)]
    public static extern bool GetTextureAlphaModFloat(Texture* texture, float* alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
    public static extern bool SetTextureBlendMode(Texture* texture, uint blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
    public static extern bool GetTextureBlendMode(Texture* texture, uint* blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
    public static extern bool SetTextureScaleMode(Texture* texture, ScaleMode scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
    public static extern bool GetTextureScaleMode(Texture* texture, ScaleMode* scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
    public static extern bool UpdateTexture(Texture* texture, Rect* rect, void* pixels, int pitch);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
    public static extern bool UpdateYUVTexture(Texture* texture, Rect* rect, byte* yplane, int ypitch, byte* uplane, int upitch, byte* vplane, int vpitch);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
    public static extern bool UpdateNVTexture(Texture* texture, Rect* rect, byte* yplane, int ypitch, byte* uvplane, int uvpitch);

    [DllImport(LibraryName, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
    public static extern bool LockTexture(Texture* texture, Rect* rect, void** pixels, int* pitch);

    [DllImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
    public static extern bool LockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
    public static extern void UnlockTexture(Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
    public static extern bool SetRenderTarget(Renderer renderer, Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
    public static extern Texture* GetRenderTarget(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation", ExactSpelling = true)]
    public static extern bool SetRenderLogicalPresentation(Renderer renderer, int w, int h, RendererLogicalPresentation mode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation", ExactSpelling = true)]
    public static extern bool GetRenderLogicalPresentation(Renderer renderer, int* w, int* h, RendererLogicalPresentation* mode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentationRect", ExactSpelling = true)]
    public static extern bool GetRenderLogicalPresentationRect(Renderer renderer, FRect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow", ExactSpelling = true)]
    public static extern bool RenderCoordinatesFromWindow(Renderer renderer, float windowX, float windowY, float* x, float* y);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow", ExactSpelling = true)]
    public static extern bool RenderCoordinatesToWindow(Renderer renderer, float x, float y, float* windowX, float* windowY);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertEventToRenderCoordinates", ExactSpelling = true)]
    public static extern bool ConvertEventToRenderCoordinates(Renderer renderer, Event* @event);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderViewport", ExactSpelling = true)]
    public static extern bool SetRenderViewport(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderViewport", ExactSpelling = true)]
    public static extern bool GetRenderViewport(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderViewportSet", ExactSpelling = true)]
    public static extern bool RenderViewportSet(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderSafeArea", ExactSpelling = true)]
    public static extern bool GetRenderSafeArea(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderClipRect", ExactSpelling = true)]
    public static extern bool SetRenderClipRect(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderClipRect", ExactSpelling = true)]
    public static extern bool GetRenderClipRect(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderClipEnabled", ExactSpelling = true)]
    public static extern bool RenderClipEnabled(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderScale", ExactSpelling = true)]
    public static extern bool SetRenderScale(Renderer renderer, float scalex, float scaley);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderScale", ExactSpelling = true)]
    public static extern bool GetRenderScale(Renderer renderer, float* scalex, float* scaley);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
    public static extern bool SetRenderDrawColor(Renderer renderer, byte r, byte g, byte b, byte a);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColorFloat", ExactSpelling = true)]
    public static extern bool SetRenderDrawColorFloat(Renderer renderer, float r, float g, float b, float a);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
    public static extern bool GetRenderDrawColor(Renderer renderer, byte* r, byte* g, byte* b, byte* a);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColorFloat", ExactSpelling = true)]
    public static extern bool GetRenderDrawColorFloat(Renderer renderer, float* r, float* g, float* b, float* a);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale", ExactSpelling = true)]
    public static extern bool SetRenderColorScale(Renderer renderer, float scale);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderColorScale", ExactSpelling = true)]
    public static extern bool GetRenderColorScale(Renderer renderer, float* scale);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
    public static extern bool SetRenderDrawBlendMode(Renderer renderer, uint blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
    public static extern bool GetRenderDrawBlendMode(Renderer renderer, uint* blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
    public static extern bool RenderClear(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderPoint", ExactSpelling = true)]
    public static extern bool RenderPoint(Renderer renderer, float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderPoints", ExactSpelling = true)]
    public static extern bool RenderPoints(Renderer renderer, FPoint* points, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderLine", ExactSpelling = true)]
    public static extern bool RenderLine(Renderer renderer, float x1, float y1, float x2, float y2);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderLines", ExactSpelling = true)]
    public static extern bool RenderLines(Renderer renderer, FPoint* points, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderRect", ExactSpelling = true)]
    public static extern bool RenderRect(Renderer renderer, FRect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderRects", ExactSpelling = true)]
    public static extern bool RenderRects(Renderer renderer, FRect* rects, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
    public static extern bool RenderFillRect(Renderer renderer, FRect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
    public static extern bool RenderFillRects(Renderer renderer, FRect* rects, int count);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTexture", ExactSpelling = true)]
    public static extern bool RenderTexture(Renderer renderer, Texture* texture, FRect* srcrect, FRect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTextureRotated", ExactSpelling = true)]
    public static extern bool RenderTextureRotated(Renderer renderer, Texture* texture, FRect* srcrect, FRect* dstrect, double angle, FPoint* center, FlipMode flip);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTextureAffine", ExactSpelling = true)]
    public static extern bool RenderTextureAffine(Renderer renderer, Texture* texture, FRect* srcrect, FPoint* origin, FPoint* right, FPoint* down);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTextureTiled", ExactSpelling = true)]
    public static extern bool RenderTextureTiled(Renderer renderer, Texture* texture, FRect* srcrect, float scale, FRect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTexture9Grid", ExactSpelling = true)]
    public static extern bool RenderTexture9Grid(Renderer renderer, Texture* texture, FRect* srcrect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, FRect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderTexture9GridTiled", ExactSpelling = true)]
    public static extern bool RenderTexture9GridTiled(Renderer renderer, Texture* texture, FRect* srcrect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, FRect* dstrect, float tilescale);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
    public static extern bool RenderGeometry(Renderer renderer, Texture* texture, Vertex* vertices, int numVertices, int* indices, int numIndices);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
    public static extern bool RenderGeometryRaw(Renderer renderer, Texture* texture, float* xy, int xyStride, FColor* color, int colorStride, float* uv, int uvStride, int numVertices, void* indices, int numIndices, int sizeIndices);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderTextureAddressMode", ExactSpelling = true)]
    public static extern bool SetRenderTextureAddressMode(Renderer renderer, TextureAddressMode uMode, TextureAddressMode vMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderTextureAddressMode", ExactSpelling = true)]
    public static extern bool GetRenderTextureAddressMode(Renderer renderer, TextureAddressMode* uMode, TextureAddressMode* vMode);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
    public static extern Surface* RenderReadPixels(Renderer renderer, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
    public static extern bool RenderPresent(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
    public static extern void DestroyTexture(Texture* texture);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
    public static extern void DestroyRenderer(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_FlushRenderer", ExactSpelling = true)]
    public static extern bool FlushRenderer(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderMetalLayer", ExactSpelling = true)]
    public static extern void* GetRenderMetalLayer(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderMetalCommandEncoder", ExactSpelling = true)]
    public static extern void* GetRenderMetalCommandEncoder(Renderer renderer);

    [DllImport(LibraryName, EntryPoint = "SDL_AddVulkanRenderSemaphores", ExactSpelling = true)]
    public static extern bool AddVulkanRenderSemaphores(Renderer renderer, uint waitStageMask, nint waitSemaphore, nint signalSemaphore);

    [DllImport(LibraryName, EntryPoint = "SDL_SetRenderVSync", ExactSpelling = true)]
    public static extern bool SetRenderVSync(Renderer renderer, int vsync);

    [DllImport(LibraryName, EntryPoint = "SDL_GetRenderVSync", ExactSpelling = true)]
    public static extern bool GetRenderVSync(Renderer renderer, int* vsync);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderDebugText", ExactSpelling = true)]
    public static extern bool RenderDebugText(Renderer renderer, float x, float y, string str);

    [DllImport(LibraryName, EntryPoint = "SDL_RenderDebugTextFormat", ExactSpelling = true)]
    public static extern bool RenderDebugTextFormat(Renderer renderer, float x, float y, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_SetDefaultTextureScaleMode", ExactSpelling = true)]
    public static extern bool SetDefaultTextureScaleMode(Renderer renderer, ScaleMode scaleMode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDefaultTextureScaleMode", ExactSpelling = true)]
    public static extern bool GetDefaultTextureScaleMode(Renderer renderer, ScaleMode* scaleMode);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateGPURenderState", ExactSpelling = true)]
    public static extern GPURenderState CreateGPURenderState(Renderer renderer, GPURenderStateCreateInfo* createinfo);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPURenderStateFragmentUniforms", ExactSpelling = true)]
    public static extern bool SetGPURenderStateFragmentUniforms(GPURenderState state, uint slotIndex, void* data, uint length);

    [DllImport(LibraryName, EntryPoint = "SDL_SetGPURenderState", ExactSpelling = true)]
    public static extern bool SetGPURenderState(Renderer renderer, GPURenderState state);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyGPURenderState", ExactSpelling = true)]
    public static extern void DestroyGPURenderState(GPURenderState state);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensors", ExactSpelling = true)]
    public static extern uint* GetSensors(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorNameForID", ExactSpelling = true)]
    public static extern string GetSensorNameForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorTypeForID", ExactSpelling = true)]
    public static extern SensorType GetSensorTypeForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableTypeForID", ExactSpelling = true)]
    public static extern int GetSensorNonPortableTypeForID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenSensor", ExactSpelling = true)]
    public static extern Sensor OpenSensor(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorFromID", ExactSpelling = true)]
    public static extern Sensor GetSensorFromID(uint instanceId);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorProperties", ExactSpelling = true)]
    public static extern uint GetSensorProperties(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorName", ExactSpelling = true)]
    public static extern string GetSensorName(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorType", ExactSpelling = true)]
    public static extern SensorType GetSensorType(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorNonPortableType", ExactSpelling = true)]
    public static extern int GetSensorNonPortableType(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorID", ExactSpelling = true)]
    public static extern uint GetSensorID(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSensorData", ExactSpelling = true)]
    public static extern bool GetSensorData(Sensor sensor, float* data, int numValues);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseSensor", ExactSpelling = true)]
    public static extern void CloseSensor(Sensor sensor);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateSensors", ExactSpelling = true)]
    public static extern void UpdateSensors();

    [DllImport(LibraryName, EntryPoint = "SDL_malloc", ExactSpelling = true)]
    public static extern void* Malloc(nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_calloc", ExactSpelling = true)]
    public static extern void* Calloc(nuint nmemb, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_realloc", ExactSpelling = true)]
    public static extern void* Realloc(void* mem, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_free", ExactSpelling = true)]
    public static extern void Free(void* mem);

    [DllImport(LibraryName, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
    public static extern void GetOriginalMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*** mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*** callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, voi**** reallocFunc, delegate* unmanaged[Cdecl]<void*, voi*** freeFunc);

    [DllImport(LibraryName, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
    public static extern void GetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*** mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*** callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, voi**** reallocFunc, delegate* unmanaged[Cdecl]<void*, voi*** freeFunc);

    [DllImport(LibraryName, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
    public static extern bool SetMemoryFunctions(delegate* unmanaged[Cdecl]<nuint, void*> mallocFunc, delegate* unmanaged[Cdecl]<nuint, nuint, void*> callocFunc, delegate* unmanaged[Cdecl]<void*, nuint, void*> reallocFunc, delegate* unmanaged[Cdecl]<void*, void> freeFunc);

    [DllImport(LibraryName, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
    public static extern void* AlignedAlloc(nuint alignment, nuint size);

    [DllImport(LibraryName, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
    public static extern void AlignedFree(void* mem);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
    public static extern int GetNumAllocations();

    [DllImport(LibraryName, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
    public static extern Environment GetEnvironment();

    [DllImport(LibraryName, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
    public static extern Environment CreateEnvironment(byte populated);

    [DllImport(LibraryName, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
    public static extern string GetEnvironmentVariable(Environment env, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
    public static extern sbyte** GetEnvironmentVariables(Environment env);

    [DllImport(LibraryName, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
    public static extern bool SetEnvironmentVariable(Environment env, string name, string value, byte overwrite);

    [DllImport(LibraryName, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
    public static extern bool UnsetEnvironmentVariable(Environment env, string name);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyEnvironment", ExactSpelling = true)]
    public static extern void DestroyEnvironment(Environment env);

    [DllImport(LibraryName, EntryPoint = "SDL_getenv", ExactSpelling = true)]
    public static extern string Getenv(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_getenv_unsafe", ExactSpelling = true)]
    public static extern string GetenvUnsafe(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_setenv_unsafe", ExactSpelling = true)]
    public static extern int SetenvUnsafe(string name, string value, int overwrite);

    [DllImport(LibraryName, EntryPoint = "SDL_unsetenv_unsafe", ExactSpelling = true)]
    public static extern int UnsetenvUnsafe(string name);

    [DllImport(LibraryName, EntryPoint = "SDL_qsort", ExactSpelling = true)]
    public static extern void Qsort(void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, int> compare);

    [DllImport(LibraryName, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
    public static extern void* Bsearch(void* key, void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, int> compare);

    [DllImport(LibraryName, EntryPoint = "SDL_qsort_r", ExactSpelling = true)]
    public static extern void QsortR(void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_bsearch_r", ExactSpelling = true)]
    public static extern void* BsearchR(void* key, void* @base, nuint nmemb, nuint size, delegate* unmanaged[Cdecl]<void*, void*, void*, int> compare, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_abs", ExactSpelling = true)]
    public static extern int Abs(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isalpha", ExactSpelling = true)]
    public static extern int Isalpha(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isalnum", ExactSpelling = true)]
    public static extern int Isalnum(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isblank", ExactSpelling = true)]
    public static extern int Isblank(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_iscntrl", ExactSpelling = true)]
    public static extern int Iscntrl(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isdigit", ExactSpelling = true)]
    public static extern int Isdigit(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isxdigit", ExactSpelling = true)]
    public static extern int Isxdigit(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_ispunct", ExactSpelling = true)]
    public static extern int Ispunct(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isspace", ExactSpelling = true)]
    public static extern int Isspace(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isupper", ExactSpelling = true)]
    public static extern int Isupper(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_islower", ExactSpelling = true)]
    public static extern int Islower(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isprint", ExactSpelling = true)]
    public static extern int Isprint(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_isgraph", ExactSpelling = true)]
    public static extern int Isgraph(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_toupper", ExactSpelling = true)]
    public static extern int Toupper(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_tolower", ExactSpelling = true)]
    public static extern int Tolower(int x);

    [DllImport(LibraryName, EntryPoint = "SDL_crc16", ExactSpelling = true)]
    public static extern ushort Crc16(ushort crc, void* data, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_crc32", ExactSpelling = true)]
    public static extern uint Crc32(uint crc, void* data, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_murmur3_32", ExactSpelling = true)]
    public static extern uint Murmur332(void* data, nuint len, uint seed);

    [DllImport(LibraryName, EntryPoint = "SDL_memcpy", ExactSpelling = true)]
    public static extern void* Memcpy(void* dst, void* src, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_memmove", ExactSpelling = true)]
    public static extern void* Memmove(void* dst, void* src, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_memset", ExactSpelling = true)]
    public static extern void* Memset(void* dst, int c, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_memset4", ExactSpelling = true)]
    public static extern void* Memset4(void* dst, uint val, nuint dwords);

    [DllImport(LibraryName, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
    public static extern int Memcmp(void* s1, void* s2, nuint len);

    [DllImport(LibraryName, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
    public static extern nuint Wcslen(uint* wstr);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsnlen", ExactSpelling = true)]
    public static extern nuint Wcsnlen(uint* wstr, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
    public static extern nuint Wcslcpy(uint* dst, uint* src, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
    public static extern nuint Wcslcat(uint* dst, uint* src, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
    public static extern uint* Wcsdup(uint* wstr);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
    public static extern uint* Wcsstr(uint* haystack, uint* needle);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsnstr", ExactSpelling = true)]
    public static extern uint* Wcsnstr(uint* haystack, uint* needle, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
    public static extern int Wcscmp(uint* str1, uint* str2);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
    public static extern int Wcsncmp(uint* str1, uint* str2, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
    public static extern int Wcscasecmp(uint* str1, uint* str2);

    [DllImport(LibraryName, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
    public static extern int Wcsncasecmp(uint* str1, uint* str2, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_wcstol", ExactSpelling = true)]
    public static extern nint Wcstol(uint* str, uint** endp, int @base);

    [DllImport(LibraryName, EntryPoint = "SDL_strlen", ExactSpelling = true)]
    public static extern nuint Strlen(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strnlen", ExactSpelling = true)]
    public static extern nuint Strnlen(string str, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
    public static extern nuint Strlcpy(string dst, string src, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
    public static extern nuint Utf8strlcpy(string dst, string src, nuint dstBytes);

    [DllImport(LibraryName, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
    public static extern nuint Strlcat(string dst, string src, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strdup", ExactSpelling = true)]
    public static extern string Strdup(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strndup", ExactSpelling = true)]
    public static extern string Strndup(string str, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strrev", ExactSpelling = true)]
    public static extern string Strrev(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strupr", ExactSpelling = true)]
    public static extern string Strupr(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
    public static extern string Strlwr(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strchr", ExactSpelling = true)]
    public static extern string Strchr(string str, int c);

    [DllImport(LibraryName, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
    public static extern string Strrchr(string str, int c);

    [DllImport(LibraryName, EntryPoint = "SDL_strstr", ExactSpelling = true)]
    public static extern string Strstr(string haystack, string needle);

    [DllImport(LibraryName, EntryPoint = "SDL_strnstr", ExactSpelling = true)]
    public static extern string Strnstr(string haystack, string needle, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
    public static extern string Strcasestr(string haystack, string needle);

    [DllImport(LibraryName, EntryPoint = "SDL_strtok_r", ExactSpelling = true)]
    public static extern string StrtokR(string str, string delim, sbyte** saveptr);

    [DllImport(LibraryName, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
    public static extern nuint Utf8strlen(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
    public static extern nuint Utf8strnlen(string str, nuint bytes);

    [DllImport(LibraryName, EntryPoint = "SDL_itoa", ExactSpelling = true)]
    public static extern string Itoa(int value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
    public static extern string Uitoa(uint value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
    public static extern string Ltoa(nint value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
    public static extern string Ultoa(nuint value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
    public static extern string Lltoa(long value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
    public static extern string Ulltoa(ulong value, string str, int radix);

    [DllImport(LibraryName, EntryPoint = "SDL_atoi", ExactSpelling = true)]
    public static extern int Atoi(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_atof", ExactSpelling = true)]
    public static extern double Atof(string str);

    [DllImport(LibraryName, EntryPoint = "SDL_strtol", ExactSpelling = true)]
    public static extern nint Strtol(string str, sbyte** endp, int @base);

    [DllImport(LibraryName, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
    public static extern nuint Strtoul(string str, sbyte** endp, int @base);

    [DllImport(LibraryName, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
    public static extern long Strtoll(string str, sbyte** endp, int @base);

    [DllImport(LibraryName, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
    public static extern ulong Strtoull(string str, sbyte** endp, int @base);

    [DllImport(LibraryName, EntryPoint = "SDL_strtod", ExactSpelling = true)]
    public static extern double Strtod(string str, sbyte** endp);

    [DllImport(LibraryName, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
    public static extern int Strcmp(string str1, string str2);

    [DllImport(LibraryName, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
    public static extern int Strncmp(string str1, string str2, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
    public static extern int Strcasecmp(string str1, string str2);

    [DllImport(LibraryName, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
    public static extern int Strncasecmp(string str1, string str2, nuint maxlen);

    [DllImport(LibraryName, EntryPoint = "SDL_strpbrk", ExactSpelling = true)]
    public static extern string Strpbrk(string str, string breakset);

    [DllImport(LibraryName, EntryPoint = "SDL_StepUTF8", ExactSpelling = true)]
    public static extern uint StepUTF8(sbyte** pstr, nuint* pslen);

    [DllImport(LibraryName, EntryPoint = "SDL_StepBackUTF8", ExactSpelling = true)]
    public static extern uint StepBackUTF8(string start, sbyte** pstr);

    [DllImport(LibraryName, EntryPoint = "SDL_UCS4ToUTF8", ExactSpelling = true)]
    public static extern string UCS4ToUTF8(uint codepoint, string dst);

    [DllImport(LibraryName, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
    public static extern int Sscanf(string text, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_vsscanf", ExactSpelling = true)]
    public static extern int Vsscanf(string text, string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
    public static extern int Snprintf(string text, nuint maxlen, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_swprintf", ExactSpelling = true)]
    public static extern int Swprintf(uint* text, nuint maxlen, uint* fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_vsnprintf", ExactSpelling = true)]
    public static extern int Vsnprintf(string text, nuint maxlen, string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_vswprintf", ExactSpelling = true)]
    public static extern int Vswprintf(uint* text, nuint maxlen, uint* fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
    public static extern int Asprintf(sbyte** strp, string fmt, __arglist );

    [DllImport(LibraryName, EntryPoint = "SDL_vasprintf", ExactSpelling = true)]
    public static extern int Vasprintf(sbyte** strp, string fmt, __va_list_tag* ap);

    [DllImport(LibraryName, EntryPoint = "SDL_srand", ExactSpelling = true)]
    public static extern void Srand(nuint seed);

    [DllImport(LibraryName, EntryPoint = "SDL_rand", ExactSpelling = true)]
    public static extern int Rand(int n);

    [DllImport(LibraryName, EntryPoint = "SDL_randf", ExactSpelling = true)]
    public static extern float Randf();

    [DllImport(LibraryName, EntryPoint = "SDL_rand_bits", ExactSpelling = true)]
    public static extern uint RandBits();

    [DllImport(LibraryName, EntryPoint = "SDL_rand_r", ExactSpelling = true)]
    public static extern int RandR(nuint* state, int n);

    [DllImport(LibraryName, EntryPoint = "SDL_randf_r", ExactSpelling = true)]
    public static extern float RandfR(nuint* state);

    [DllImport(LibraryName, EntryPoint = "SDL_rand_bits_r", ExactSpelling = true)]
    public static extern uint RandBitsR(nuint* state);

    [DllImport(LibraryName, EntryPoint = "SDL_acos", ExactSpelling = true)]
    public static extern double Acos(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_acosf", ExactSpelling = true)]
    public static extern float Acosf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_asin", ExactSpelling = true)]
    public static extern double Asin(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_asinf", ExactSpelling = true)]
    public static extern float Asinf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_atan", ExactSpelling = true)]
    public static extern double Atan(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_atanf", ExactSpelling = true)]
    public static extern float Atanf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_atan2", ExactSpelling = true)]
    public static extern double Atan2(double y, double x);

    [DllImport(LibraryName, EntryPoint = "SDL_atan2f", ExactSpelling = true)]
    public static extern float Atan2f(float y, float x);

    [DllImport(LibraryName, EntryPoint = "SDL_ceil", ExactSpelling = true)]
    public static extern double Ceil(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_ceilf", ExactSpelling = true)]
    public static extern float Ceilf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_copysign", ExactSpelling = true)]
    public static extern double Copysign(double x, double y);

    [DllImport(LibraryName, EntryPoint = "SDL_copysignf", ExactSpelling = true)]
    public static extern float Copysignf(float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_cos", ExactSpelling = true)]
    public static extern double Cos(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_cosf", ExactSpelling = true)]
    public static extern float Cosf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_exp", ExactSpelling = true)]
    public static extern double Exp(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_expf", ExactSpelling = true)]
    public static extern float Expf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_fabs", ExactSpelling = true)]
    public static extern double Fabs(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_fabsf", ExactSpelling = true)]
    public static extern float Fabsf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_floor", ExactSpelling = true)]
    public static extern double Floor(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_floorf", ExactSpelling = true)]
    public static extern float Floorf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_trunc", ExactSpelling = true)]
    public static extern double Trunc(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_truncf", ExactSpelling = true)]
    public static extern float Truncf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_fmod", ExactSpelling = true)]
    public static extern double Fmod(double x, double y);

    [DllImport(LibraryName, EntryPoint = "SDL_fmodf", ExactSpelling = true)]
    public static extern float Fmodf(float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_isinf", ExactSpelling = true)]
    public static extern int Isinf(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_isinff", ExactSpelling = true)]
    public static extern int Isinff(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_isnan", ExactSpelling = true)]
    public static extern int Isnan(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_isnanf", ExactSpelling = true)]
    public static extern int Isnanf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_log", ExactSpelling = true)]
    public static extern double Log(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_logf", ExactSpelling = true)]
    public static extern float Logf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_log10", ExactSpelling = true)]
    public static extern double Log10(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_log10f", ExactSpelling = true)]
    public static extern float Log10f(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_modf", ExactSpelling = true)]
    public static extern double Modf(double x, double* y);

    [DllImport(LibraryName, EntryPoint = "SDL_modff", ExactSpelling = true)]
    public static extern float Modff(float x, float* y);

    [DllImport(LibraryName, EntryPoint = "SDL_pow", ExactSpelling = true)]
    public static extern double Pow(double x, double y);

    [DllImport(LibraryName, EntryPoint = "SDL_powf", ExactSpelling = true)]
    public static extern float Powf(float x, float y);

    [DllImport(LibraryName, EntryPoint = "SDL_round", ExactSpelling = true)]
    public static extern double Round(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_roundf", ExactSpelling = true)]
    public static extern float Roundf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_lround", ExactSpelling = true)]
    public static extern nint Lround(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
    public static extern nint Lroundf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_scalbn", ExactSpelling = true)]
    public static extern double Scalbn(double x, int n);

    [DllImport(LibraryName, EntryPoint = "SDL_scalbnf", ExactSpelling = true)]
    public static extern float Scalbnf(float x, int n);

    [DllImport(LibraryName, EntryPoint = "SDL_sin", ExactSpelling = true)]
    public static extern double Sin(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_sinf", ExactSpelling = true)]
    public static extern float Sinf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_sqrt", ExactSpelling = true)]
    public static extern double Sqrt(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_sqrtf", ExactSpelling = true)]
    public static extern float Sqrtf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_tan", ExactSpelling = true)]
    public static extern double Tan(double x);

    [DllImport(LibraryName, EntryPoint = "SDL_tanf", ExactSpelling = true)]
    public static extern float Tanf(float x);

    [DllImport(LibraryName, EntryPoint = "SDL_iconv_open", ExactSpelling = true)]
    public static extern IconvDataT IconvOpen(string tocode, string fromcode);

    [DllImport(LibraryName, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
    public static extern int IconvClose(IconvDataT cd);

    [DllImport(LibraryName, EntryPoint = "SDL_iconv", ExactSpelling = true)]
    public static extern nuint Iconv(IconvDataT cd, sbyte** inbuf, nuint* inbytesleft, sbyte** outbuf, nuint* outbytesleft);

    [DllImport(LibraryName, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
    public static extern string IconvString(string tocode, string fromcode, string inbuf, nuint inbytesleft);

    [DllImport(LibraryName, EntryPoint = "SDL_size_mul_check_overflow", ExactSpelling = true)]
    public static extern bool SizeMulCheckOverflow(nuint a, nuint b, nuint* ret);

    [DllImport(LibraryName, EntryPoint = "SDL_size_mul_check_overflow_builtin", ExactSpelling = true)]
    public static extern bool SizeMulCheckOverflowBuiltin(nuint a, nuint b, nuint* ret);

    [DllImport(LibraryName, EntryPoint = "SDL_size_add_check_overflow", ExactSpelling = true)]
    public static extern bool SizeAddCheckOverflow(nuint a, nuint b, nuint* ret);

    [DllImport(LibraryName, EntryPoint = "SDL_size_add_check_overflow_builtin", ExactSpelling = true)]
    public static extern bool SizeAddCheckOverflowBuiltin(nuint a, nuint b, nuint* ret);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
    public static extern Storage OpenTitleStorage(string @override, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
    public static extern Storage OpenUserStorage(string org, string app, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
    public static extern Storage OpenFileStorage(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
    public static extern Storage OpenStorage(StorageInterface* iface, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
    public static extern bool CloseStorage(Storage storage);

    [DllImport(LibraryName, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
    public static extern bool StorageReady(Storage storage);

    [DllImport(LibraryName, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
    public static extern bool GetStorageFileSize(Storage storage, string path, nuint* length);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
    public static extern bool ReadStorageFile(Storage storage, string path, void* destination, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
    public static extern bool WriteStorageFile(Storage storage, string path, void* source, nuint length);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
    public static extern bool CreateStorageDirectory(Storage storage, string path);

    [DllImport(LibraryName, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
    public static extern bool EnumerateStorageDirectory(Storage storage, string path, delegate* unmanaged[Cdecl]<void*, sbyte*, sbyte*, SDL_EnumerationResult> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
    public static extern bool RemoveStoragePath(Storage storage, string path);

    [DllImport(LibraryName, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
    public static extern bool RenameStoragePath(Storage storage, string oldpath, string newpath);

    [DllImport(LibraryName, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
    public static extern bool CopyStorageFile(Storage storage, string oldpath, string newpath);

    [DllImport(LibraryName, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
    public static extern bool GetStoragePathInfo(Storage storage, string path, PathInfo* info);

    [DllImport(LibraryName, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
    public static extern nuint GetStorageSpaceRemaining(Storage storage);

    [DllImport(LibraryName, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
    public static extern sbyte** GlobStorageDirectory(Storage storage, string path, string pattern, uint flags, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSurface", ExactSpelling = true)]
    public static extern Surface* CreateSurface(int width, int height, PixelFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSurfaceFrom", ExactSpelling = true)]
    public static extern Surface* CreateSurfaceFrom(int width, int height, PixelFormat format, void* pixels, int pitch);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroySurface", ExactSpelling = true)]
    public static extern void DestroySurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceProperties", ExactSpelling = true)]
    public static extern uint GetSurfaceProperties(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorspace", ExactSpelling = true)]
    public static extern bool SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorspace", ExactSpelling = true)]
    public static extern Colorspace GetSurfaceColorspace(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateSurfacePalette", ExactSpelling = true)]
    public static extern Palette* CreateSurfacePalette(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette", ExactSpelling = true)]
    public static extern bool SetSurfacePalette(Surface* surface, Palette* palette);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfacePalette", ExactSpelling = true)]
    public static extern Palette* GetSurfacePalette(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_AddSurfaceAlternateImage", ExactSpelling = true)]
    public static extern bool AddSurfaceAlternateImage(Surface* surface, Surface* image);

    [DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasAlternateImages", ExactSpelling = true)]
    public static extern bool SurfaceHasAlternateImages(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceImages", ExactSpelling = true)]
    public static extern Surface** GetSurfaceImages(Surface* surface, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveSurfaceAlternateImages", ExactSpelling = true)]
    public static extern void RemoveSurfaceAlternateImages(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_LockSurface", ExactSpelling = true)]
    public static extern bool LockSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_UnlockSurface", ExactSpelling = true)]
    public static extern void UnlockSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadSurface_IO", ExactSpelling = true)]
    public static extern Surface* LoadSurfaceIO(IOStream src, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadSurface", ExactSpelling = true)]
    public static extern Surface* LoadSurface(string file);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadBMP_IO", ExactSpelling = true)]
    public static extern Surface* LoadBMPIO(IOStream src, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadBMP", ExactSpelling = true)]
    public static extern Surface* LoadBMP(string file);

    [DllImport(LibraryName, EntryPoint = "SDL_SaveBMP_IO", ExactSpelling = true)]
    public static extern bool SaveBMPIO(Surface* surface, IOStream dst, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_SaveBMP", ExactSpelling = true)]
    public static extern bool SaveBMP(Surface* surface, string file);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadPNG_IO", ExactSpelling = true)]
    public static extern Surface* LoadPNGIO(IOStream src, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_LoadPNG", ExactSpelling = true)]
    public static extern Surface* LoadPNG(string file);

    [DllImport(LibraryName, EntryPoint = "SDL_SavePNG_IO", ExactSpelling = true)]
    public static extern bool SavePNGIO(Surface* surface, IOStream dst, byte closeio);

    [DllImport(LibraryName, EntryPoint = "SDL_SavePNG", ExactSpelling = true)]
    public static extern bool SavePNG(Surface* surface, string file);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE", ExactSpelling = true)]
    public static extern bool SetSurfaceRLE(Surface* surface, byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasRLE", ExactSpelling = true)]
    public static extern bool SurfaceHasRLE(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorKey", ExactSpelling = true)]
    public static extern bool SetSurfaceColorKey(Surface* surface, byte enabled, uint key);

    [DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasColorKey", ExactSpelling = true)]
    public static extern bool SurfaceHasColorKey(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorKey", ExactSpelling = true)]
    public static extern bool GetSurfaceColorKey(Surface* surface, uint* key);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod", ExactSpelling = true)]
    public static extern bool SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", ExactSpelling = true)]
    public static extern bool GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod", ExactSpelling = true)]
    public static extern bool SetSurfaceAlphaMod(Surface* surface, byte alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", ExactSpelling = true)]
    public static extern bool GetSurfaceAlphaMod(Surface* surface, byte* alpha);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode", ExactSpelling = true)]
    public static extern bool SetSurfaceBlendMode(Surface* surface, uint blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", ExactSpelling = true)]
    public static extern bool GetSurfaceBlendMode(Surface* surface, uint* blendmode);

    [DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect", ExactSpelling = true)]
    public static extern bool SetSurfaceClipRect(Surface* surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceClipRect", ExactSpelling = true)]
    public static extern bool GetSurfaceClipRect(Surface* surface, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_FlipSurface", ExactSpelling = true)]
    public static extern bool FlipSurface(Surface* surface, FlipMode flip);

    [DllImport(LibraryName, EntryPoint = "SDL_RotateSurface", ExactSpelling = true)]
    public static extern Surface* RotateSurface(Surface* surface, float angle);

    [DllImport(LibraryName, EntryPoint = "SDL_DuplicateSurface", ExactSpelling = true)]
    public static extern Surface* DuplicateSurface(Surface* surface);

    [DllImport(LibraryName, EntryPoint = "SDL_ScaleSurface", ExactSpelling = true)]
    public static extern Surface* ScaleSurface(Surface* surface, int width, int height, ScaleMode scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurface", ExactSpelling = true)]
    public static extern Surface* ConvertSurface(Surface* surface, PixelFormat format);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceAndColorspace", ExactSpelling = true)]
    public static extern Surface* ConvertSurfaceAndColorspace(Surface* surface, PixelFormat format, Palette* palette, Colorspace colorspace, uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertPixels", ExactSpelling = true)]
    public static extern bool ConvertPixels(int width, int height, PixelFormat srcFormat, void* src, int srcPitch, PixelFormat dstFormat, void* dst, int dstPitch);

    [DllImport(LibraryName, EntryPoint = "SDL_ConvertPixelsAndColorspace", ExactSpelling = true)]
    public static extern bool ConvertPixelsAndColorspace(int width, int height, PixelFormat srcFormat, Colorspace srcColorspace, uint srcProperties, void* src, int srcPitch, PixelFormat dstFormat, Colorspace dstColorspace, uint dstProperties, void* dst, int dstPitch);

    [DllImport(LibraryName, EntryPoint = "SDL_PremultiplyAlpha", ExactSpelling = true)]
    public static extern bool PremultiplyAlpha(int width, int height, PixelFormat srcFormat, void* src, int srcPitch, PixelFormat dstFormat, void* dst, int dstPitch, byte linear);

    [DllImport(LibraryName, EntryPoint = "SDL_PremultiplySurfaceAlpha", ExactSpelling = true)]
    public static extern bool PremultiplySurfaceAlpha(Surface* surface, byte linear);

    [DllImport(LibraryName, EntryPoint = "SDL_ClearSurface", ExactSpelling = true)]
    public static extern bool ClearSurface(Surface* surface, float r, float g, float b, float a);

    [DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect", ExactSpelling = true)]
    public static extern bool FillSurfaceRect(Surface* dst, Rect* rect, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRects", ExactSpelling = true)]
    public static extern bool FillSurfaceRects(Surface* dst, Rect* rects, int count, uint color);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurface", ExactSpelling = true)]
    public static extern bool BlitSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUnchecked", ExactSpelling = true)]
    public static extern bool BlitSurfaceUnchecked(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled", ExactSpelling = true)]
    public static extern bool BlitSurfaceScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", ExactSpelling = true)]
    public static extern bool BlitSurfaceUncheckedScaled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_StretchSurface", ExactSpelling = true)]
    public static extern bool StretchSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect, ScaleMode scalemode);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiled", ExactSpelling = true)]
    public static extern bool BlitSurfaceTiled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiledWithScale", ExactSpelling = true)]
    public static extern bool BlitSurfaceTiledWithScale(Surface* src, Rect* srcrect, float scale, ScaleMode scalemode, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid", ExactSpelling = true)]
    public static extern bool BlitSurface9Grid(Surface* src, Rect* srcrect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, ScaleMode scalemode, Surface* dst, Rect* dstrect);

    [DllImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGB", ExactSpelling = true)]
    public static extern uint MapSurfaceRGB(Surface* surface, byte r, byte g, byte b);

    [DllImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGBA", ExactSpelling = true)]
    public static extern uint MapSurfaceRGBA(Surface* surface, byte r, byte g, byte b, byte a);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixel", ExactSpelling = true)]
    public static extern bool ReadSurfacePixel(Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);

    [DllImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixelFloat", ExactSpelling = true)]
    public static extern bool ReadSurfacePixelFloat(Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixel", ExactSpelling = true)]
    public static extern bool WriteSurfacePixel(Surface* surface, int x, int y, byte r, byte g, byte b, byte a);

    [DllImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixelFloat", ExactSpelling = true)]
    public static extern bool WriteSurfacePixelFloat(Surface* surface, int x, int y, float r, float g, float b, float a);

    [DllImport(LibraryName, EntryPoint = "SDL_SetX11EventHook", ExactSpelling = true)]
    public static extern void SetX11EventHook(delegate* unmanaged[Cdecl]<void*, _XEvent*, byte> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_SetLinuxThreadPriority", ExactSpelling = true)]
    public static extern bool SetLinuxThreadPriority(nint threadid, int priority);

    [DllImport(LibraryName, EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy", ExactSpelling = true)]
    public static extern bool SetLinuxThreadPriorityAndPolicy(nint threadid, int sdlpriority, int schedpolicy);

    [DllImport(LibraryName, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
    public static extern bool IsTablet();

    [DllImport(LibraryName, EntryPoint = "SDL_IsTV", ExactSpelling = true)]
    public static extern bool IsTV();

    [DllImport(LibraryName, EntryPoint = "SDL_GetSandbox", ExactSpelling = true)]
    public static extern Sandbox GetSandbox();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationWillTerminate", ExactSpelling = true)]
    public static extern void OnApplicationWillTerminate();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning", ExactSpelling = true)]
    public static extern void OnApplicationDidReceiveMemoryWarning();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationWillEnterBackground", ExactSpelling = true)]
    public static extern void OnApplicationWillEnterBackground();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationDidEnterBackground", ExactSpelling = true)]
    public static extern void OnApplicationDidEnterBackground();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationWillEnterForeground", ExactSpelling = true)]
    public static extern void OnApplicationWillEnterForeground();

    [DllImport(LibraryName, EntryPoint = "SDL_OnApplicationDidEnterForeground", ExactSpelling = true)]
    public static extern void OnApplicationDidEnterForeground();

    [DllImport(LibraryName, EntryPoint = "SDL_CreateThreadRuntime", ExactSpelling = true)]
    public static extern Thread CreateThreadRuntime(delegate* unmanaged[Cdecl]<void*, int> fn, string name, void* data, delegate* unmanaged[Cdecl]<void> pfnbeginthread, delegate* unmanaged[Cdecl]<void> pfnendthread);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime", ExactSpelling = true)]
    public static extern Thread CreateThreadWithPropertiesRuntime(uint props, delegate* unmanaged[Cdecl]<void> pfnbeginthread, delegate* unmanaged[Cdecl]<void> pfnendthread);

    [DllImport(LibraryName, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
    public static extern string GetThreadName(Thread thread);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentThreadID", ExactSpelling = true)]
    public static extern nuint GetCurrentThreadID();

    [DllImport(LibraryName, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
    public static extern nuint GetThreadID(Thread thread);

    [DllImport(LibraryName, EntryPoint = "SDL_SetCurrentThreadPriority", ExactSpelling = true)]
    public static extern bool SetCurrentThreadPriority(ThreadPriority priority);

    [DllImport(LibraryName, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
    public static extern void WaitThread(Thread thread, int* status);

    [DllImport(LibraryName, EntryPoint = "SDL_GetThreadState", ExactSpelling = true)]
    public static extern ThreadState GetThreadState(Thread thread);

    [DllImport(LibraryName, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
    public static extern void DetachThread(Thread thread);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTLS", ExactSpelling = true)]
    public static extern void* GetTLS(AtomicInt* id);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTLS", ExactSpelling = true)]
    public static extern bool SetTLS(AtomicInt* id, void* value, delegate* unmanaged[Cdecl]<void*, void> destructor);

    [DllImport(LibraryName, EntryPoint = "SDL_CleanupTLS", ExactSpelling = true)]
    public static extern void CleanupTLS();

    [DllImport(LibraryName, EntryPoint = "SDL_GetDateTimeLocalePreferences", ExactSpelling = true)]
    public static extern bool GetDateTimeLocalePreferences(DateFormat* dateformat, TimeFormat* timeformat);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentTime", ExactSpelling = true)]
    public static extern bool GetCurrentTime(nint* ticks);

    [DllImport(LibraryName, EntryPoint = "SDL_TimeToDateTime", ExactSpelling = true)]
    public static extern bool TimeToDateTime(nint ticks, DateTime* dt, byte localtime);

    [DllImport(LibraryName, EntryPoint = "SDL_DateTimeToTime", ExactSpelling = true)]
    public static extern bool DateTimeToTime(DateTime* dt, nint* ticks);

    [DllImport(LibraryName, EntryPoint = "SDL_TimeToWindows", ExactSpelling = true)]
    public static extern void TimeToWindows(nint ticks, uint* dwlowdatetime, uint* dwhighdatetime);

    [DllImport(LibraryName, EntryPoint = "SDL_TimeFromWindows", ExactSpelling = true)]
    public static extern nint TimeFromWindows(uint dwlowdatetime, uint dwhighdatetime);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDaysInMonth", ExactSpelling = true)]
    public static extern int GetDaysInMonth(int year, int month);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDayOfYear", ExactSpelling = true)]
    public static extern int GetDayOfYear(int year, int month, int day);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDayOfWeek", ExactSpelling = true)]
    public static extern int GetDayOfWeek(int year, int month, int day);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
    public static extern nuint GetTicks();

    [DllImport(LibraryName, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
    public static extern nuint GetTicksNS();

    [DllImport(LibraryName, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
    public static extern nuint GetPerformanceCounter();

    [DllImport(LibraryName, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
    public static extern nuint GetPerformanceFrequency();

    [DllImport(LibraryName, EntryPoint = "SDL_Delay", ExactSpelling = true)]
    public static extern void Delay(uint ms);

    [DllImport(LibraryName, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
    public static extern void DelayNS(nuint ns);

    [DllImport(LibraryName, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
    public static extern void DelayPrecise(nuint ns);

    [DllImport(LibraryName, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
    public static extern uint AddTimer(uint interval, delegate* unmanaged[Cdecl]<void*, uint, uint, uint> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
    public static extern uint AddTimerNS(nuint interval, delegate* unmanaged[Cdecl]<void*, uint, nuint, nuint> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
    public static extern bool RemoveTimer(uint id);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTouchDevices", ExactSpelling = true)]
    public static extern nuint* GetTouchDevices(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceName", ExactSpelling = true)]
    public static extern string GetTouchDeviceName(nuint touchid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
    public static extern TouchDeviceType GetTouchDeviceType(nuint touchid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTouchFingers", ExactSpelling = true)]
    public static extern Finger** GetTouchFingers(nuint touchid, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTray", ExactSpelling = true)]
    public static extern Tray CreateTray(Surface* icon, string tooltip);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayIcon", ExactSpelling = true)]
    public static extern void SetTrayIcon(Tray tray, Surface* icon);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayTooltip", ExactSpelling = true)]
    public static extern void SetTrayTooltip(Tray tray, string tooltip);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTrayMenu", ExactSpelling = true)]
    public static extern TrayMenu CreateTrayMenu(Tray tray);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateTraySubmenu", ExactSpelling = true)]
    public static extern TrayMenu CreateTraySubmenu(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayMenu", ExactSpelling = true)]
    public static extern TrayMenu GetTrayMenu(Tray tray);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTraySubmenu", ExactSpelling = true)]
    public static extern TrayMenu GetTraySubmenu(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayEntries", ExactSpelling = true)]
    public static extern TrayEntry GetTrayEntries(TrayMenu menu, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_RemoveTrayEntry", ExactSpelling = true)]
    public static extern void RemoveTrayEntry(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_InsertTrayEntryAt", ExactSpelling = true)]
    public static extern TrayEntry InsertTrayEntryAt(TrayMenu menu, int pos, string label, uint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayEntryLabel", ExactSpelling = true)]
    public static extern void SetTrayEntryLabel(TrayEntry entry, string label);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayEntryLabel", ExactSpelling = true)]
    public static extern string GetTrayEntryLabel(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayEntryChecked", ExactSpelling = true)]
    public static extern void SetTrayEntryChecked(TrayEntry entry, byte @checked);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayEntryChecked", ExactSpelling = true)]
    public static extern bool GetTrayEntryChecked(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayEntryEnabled", ExactSpelling = true)]
    public static extern void SetTrayEntryEnabled(TrayEntry entry, byte enabled);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayEntryEnabled", ExactSpelling = true)]
    public static extern bool GetTrayEntryEnabled(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_SetTrayEntryCallback", ExactSpelling = true)]
    public static extern void SetTrayEntryCallback(TrayEntry entry, delegate* unmanaged[Cdecl]<void*, SDL_TrayEntry*, void> callback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_ClickTrayEntry", ExactSpelling = true)]
    public static extern void ClickTrayEntry(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyTray", ExactSpelling = true)]
    public static extern void DestroyTray(Tray tray);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayEntryParent", ExactSpelling = true)]
    public static extern TrayMenu GetTrayEntryParent(TrayEntry entry);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayMenuParentEntry", ExactSpelling = true)]
    public static extern TrayEntry GetTrayMenuParentEntry(TrayMenu menu);

    [DllImport(LibraryName, EntryPoint = "SDL_GetTrayMenuParentTray", ExactSpelling = true)]
    public static extern Tray GetTrayMenuParentTray(TrayMenu menu);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateTrays", ExactSpelling = true)]
    public static extern void UpdateTrays();

    [DllImport(LibraryName, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
    public static extern int GetVersion();

    [DllImport(LibraryName, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
    public static extern string GetRevision();

    [DllImport(LibraryName, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
    public static extern int GetNumVideoDrivers();

    [DllImport(LibraryName, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
    public static extern string GetVideoDriver(int index);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
    public static extern string GetCurrentVideoDriver();

    [DllImport(LibraryName, EntryPoint = "SDL_GetSystemTheme", ExactSpelling = true)]
    public static extern SystemTheme GetSystemTheme();

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplays", ExactSpelling = true)]
    public static extern uint* GetDisplays(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetPrimaryDisplay", ExactSpelling = true)]
    public static extern uint GetPrimaryDisplay();

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayProperties", ExactSpelling = true)]
    public static extern uint GetDisplayProperties(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
    public static extern string GetDisplayName(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
    public static extern bool GetDisplayBounds(uint displayid, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
    public static extern bool GetDisplayUsableBounds(uint displayid, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetNaturalDisplayOrientation", ExactSpelling = true)]
    public static extern DisplayOrientation GetNaturalDisplayOrientation(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayOrientation", ExactSpelling = true)]
    public static extern DisplayOrientation GetCurrentDisplayOrientation(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayContentScale", ExactSpelling = true)]
    public static extern float GetDisplayContentScale(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetFullscreenDisplayModes", ExactSpelling = true)]
    public static extern DisplayMode** GetFullscreenDisplayModes(uint displayid, int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", ExactSpelling = true)]
    public static extern bool GetClosestFullscreenDisplayMode(uint displayid, int w, int h, float refreshRate, byte includeHighDensityModes, DisplayMode* closest);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
    public static extern DisplayMode* GetDesktopDisplayMode(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
    public static extern DisplayMode* GetCurrentDisplayMode(uint displayid);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForPoint", ExactSpelling = true)]
    public static extern uint GetDisplayForPoint(Point* point);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForRect", ExactSpelling = true)]
    public static extern uint GetDisplayForRect(Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetDisplayForWindow", ExactSpelling = true)]
    public static extern uint GetDisplayForWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelDensity", ExactSpelling = true)]
    public static extern float GetWindowPixelDensity(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowDisplayScale", ExactSpelling = true)]
    public static extern float GetWindowDisplayScale(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreenMode", ExactSpelling = true)]
    public static extern bool SetWindowFullscreenMode(Window window, DisplayMode* mode);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowFullscreenMode", ExactSpelling = true)]
    public static extern DisplayMode* GetWindowFullscreenMode(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
    public static extern void* GetWindowICCProfile(Window window, nuint* size);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
    public static extern PixelFormat GetWindowPixelFormat(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindows", ExactSpelling = true)]
    public static extern Window GetWindows(int* count);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
    public static extern Window CreateWindow(string title, int w, int h, nuint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_CreatePopupWindow", ExactSpelling = true)]
    public static extern Window CreatePopupWindow(Window parent, int offsetX, int offsetY, int w, int h, nuint flags);

    [DllImport(LibraryName, EntryPoint = "SDL_CreateWindowWithProperties", ExactSpelling = true)]
    public static extern Window CreateWindowWithProperties(uint props);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
    public static extern uint GetWindowID(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
    public static extern Window GetWindowFromID(uint id);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowParent", ExactSpelling = true)]
    public static extern Window GetWindowParent(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowProperties", ExactSpelling = true)]
    public static extern uint GetWindowProperties(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
    public static extern nuint GetWindowFlags(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
    public static extern bool SetWindowTitle(Window window, string title);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
    public static extern string GetWindowTitle(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
    public static extern bool SetWindowIcon(Window window, Surface* icon);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
    public static extern bool SetWindowPosition(Window window, int x, int y);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
    public static extern bool GetWindowPosition(Window window, int* x, int* y);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
    public static extern bool SetWindowSize(Window window, int w, int h);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
    public static extern bool GetWindowSize(Window window, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowSafeArea", ExactSpelling = true)]
    public static extern bool GetWindowSafeArea(Window window, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowAspectRatio", ExactSpelling = true)]
    public static extern bool SetWindowAspectRatio(Window window, float minAspect, float maxAspect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowAspectRatio", ExactSpelling = true)]
    public static extern bool GetWindowAspectRatio(Window window, float* minAspect, float* maxAspect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
    public static extern bool GetWindowBordersSize(Window window, int* top, int* left, int* bottom, int* right);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
    public static extern bool GetWindowSizeInPixels(Window window, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
    public static extern bool SetWindowMinimumSize(Window window, int minW, int minH);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
    public static extern bool GetWindowMinimumSize(Window window, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
    public static extern bool SetWindowMaximumSize(Window window, int maxW, int maxH);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
    public static extern bool GetWindowMaximumSize(Window window, int* w, int* h);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
    public static extern bool SetWindowBordered(Window window, byte bordered);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
    public static extern bool SetWindowResizable(Window window, byte resizable);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
    public static extern bool SetWindowAlwaysOnTop(Window window, byte onTop);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowFillDocument", ExactSpelling = true)]
    public static extern bool SetWindowFillDocument(Window window, byte fill);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
    public static extern bool ShowWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
    public static extern bool HideWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
    public static extern bool RaiseWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
    public static extern bool MaximizeWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
    public static extern bool MinimizeWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
    public static extern bool RestoreWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
    public static extern bool SetWindowFullscreen(Window window, byte fullscreen);

    [DllImport(LibraryName, EntryPoint = "SDL_SyncWindow", ExactSpelling = true)]
    public static extern bool SyncWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_WindowHasSurface", ExactSpelling = true)]
    public static extern bool WindowHasSurface(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
    public static extern Surface* GetWindowSurface(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowSurfaceVSync", ExactSpelling = true)]
    public static extern bool SetWindowSurfaceVSync(Window window, int vsync);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowSurfaceVSync", ExactSpelling = true)]
    public static extern bool GetWindowSurfaceVSync(Window window, int* vsync);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
    public static extern bool UpdateWindowSurface(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
    public static extern bool UpdateWindowSurfaceRects(Window window, Rect* rects, int numrects);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyWindowSurface", ExactSpelling = true)]
    public static extern bool DestroyWindowSurface(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
    public static extern bool SetWindowKeyboardGrab(Window window, byte grabbed);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
    public static extern bool SetWindowMouseGrab(Window window, byte grabbed);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
    public static extern bool GetWindowKeyboardGrab(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
    public static extern bool GetWindowMouseGrab(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
    public static extern Window GetGrabbedWindow();

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
    public static extern bool SetWindowMouseRect(Window window, Rect* rect);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
    public static extern Rect* GetWindowMouseRect(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
    public static extern bool SetWindowOpacity(Window window, float opacity);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
    public static extern float GetWindowOpacity(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowParent", ExactSpelling = true)]
    public static extern bool SetWindowParent(Window window, Window parent);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowModal", ExactSpelling = true)]
    public static extern bool SetWindowModal(Window window, byte modal);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowFocusable", ExactSpelling = true)]
    public static extern bool SetWindowFocusable(Window window, byte focusable);

    [DllImport(LibraryName, EntryPoint = "SDL_ShowWindowSystemMenu", ExactSpelling = true)]
    public static extern bool ShowWindowSystemMenu(Window window, int x, int y);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
    public static extern bool SetWindowHitTest(Window window, delegate* unmanaged[Cdecl]<SDL_Window*, SDL_Point*, void*, SDL_HitTestResult> callback, void* callbackData);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
    public static extern bool SetWindowShape(Window window, Surface* shape);

    [DllImport(LibraryName, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
    public static extern bool FlashWindow(Window window, FlashOperation operation);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowProgressState", ExactSpelling = true)]
    public static extern bool SetWindowProgressState(Window window, ProgressState state);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowProgressState", ExactSpelling = true)]
    public static extern ProgressState GetWindowProgressState(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_SetWindowProgressValue", ExactSpelling = true)]
    public static extern bool SetWindowProgressValue(Window window, float value);

    [DllImport(LibraryName, EntryPoint = "SDL_GetWindowProgressValue", ExactSpelling = true)]
    public static extern float GetWindowProgressValue(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
    public static extern void DestroyWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_ScreenSaverEnabled", ExactSpelling = true)]
    public static extern bool ScreenSaverEnabled();

    [DllImport(LibraryName, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
    public static extern bool EnableScreenSaver();

    [DllImport(LibraryName, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
    public static extern bool DisableScreenSaver();

    [DllImport(LibraryName, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
    public static extern bool GLLoadLibrary(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<void> GLGetProcAddress(string proc);

    [DllImport(LibraryName, EntryPoint = "SDL_EGL_GetProcAddress", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<void> EGLGetProcAddress(string proc);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
    public static extern void GLUnloadLibrary();

    [DllImport(LibraryName, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
    public static extern bool GLExtensionSupported(string extension);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
    public static extern void GLResetAttributes();

    [DllImport(LibraryName, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
    public static extern bool GLSetAttribute(GLAttr attr, int value);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
    public static extern bool GLGetAttribute(GLAttr attr, int* value);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
    public static extern GLContextState GLCreateContext(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
    public static extern bool GLMakeCurrent(Window window, GLContextState context);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
    public static extern Window GLGetCurrentWindow();

    [DllImport(LibraryName, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
    public static extern GLContextState GLGetCurrentContext();

    [DllImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentDisplay", ExactSpelling = true)]
    public static extern void* EGLGetCurrentDisplay();

    [DllImport(LibraryName, EntryPoint = "SDL_EGL_GetCurrentConfig", ExactSpelling = true)]
    public static extern void* EGLGetCurrentConfig();

    [DllImport(LibraryName, EntryPoint = "SDL_EGL_GetWindowSurface", ExactSpelling = true)]
    public static extern void* EGLGetWindowSurface(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_EGL_SetAttributeCallbacks", ExactSpelling = true)]
    public static extern void EGLSetAttributeCallbacks(delegate* unmanaged[Cdecl]<void*, nint*> platformattribcallback, delegate* unmanaged[Cdecl]<void*, void*, void*, int*> surfaceattribcallback, delegate* unmanaged[Cdecl]<void*, void*, void*, int*> contextattribcallback, void* userdata);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
    public static extern bool GLSetSwapInterval(int interval);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
    public static extern bool GLGetSwapInterval(int* interval);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
    public static extern bool GLSwapWindow(Window window);

    [DllImport(LibraryName, EntryPoint = "SDL_GL_DestroyContext", ExactSpelling = true)]
    public static extern bool GLDestroyContext(GLContextState context);

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_LoadLibrary", ExactSpelling = true)]
    public static extern bool VulkanLoadLibrary(string path);

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr", ExactSpelling = true)]
    public static extern delegate* unmanaged[Cdecl]<void> VulkanGetVkGetInstanceProcAddr();

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_UnloadLibrary", ExactSpelling = true)]
    public static extern void VulkanUnloadLibrary();

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetInstanceExtensions", ExactSpelling = true)]
    public static extern sbyte** VulkanGetInstanceExtensions(uint* count);

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_CreateSurface", ExactSpelling = true)]
    public static extern bool VulkanCreateSurface(Window window, VkInstanceT instance, VkAllocationCallbacks allocator, VkSurfaceKHRT surface);

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_DestroySurface", ExactSpelling = true)]
    public static extern void VulkanDestroySurface(VkInstanceT instance, VkSurfaceKHRT surface, VkAllocationCallbacks allocator);

    [DllImport(LibraryName, EntryPoint = "SDL_Vulkan_GetPresentationSupport", ExactSpelling = true)]
    public static extern bool VulkanGetPresentationSupport(VkInstanceT instance, VkPhysicalDeviceT physicaldevice, uint queuefamilyindex);

}
