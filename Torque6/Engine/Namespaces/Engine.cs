using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Engine
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DebugBreak();
         private static _Engine_DebugBreak _Engine_DebugBreakFunc;
         internal static void Engine_DebugBreak()
         {
            if (_Engine_DebugBreakFunc == null)
            {
               _Engine_DebugBreakFunc =
                  (_Engine_DebugBreak)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DebugBreak"), typeof(_Engine_DebugBreak));
            }

            _Engine_DebugBreakFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetAppleDeviceIPAddress();
         private static _Engine_GetAppleDeviceIPAddress _Engine_GetAppleDeviceIPAddressFunc;
         internal static IntPtr Engine_GetAppleDeviceIPAddress()
         {
            if (_Engine_GetAppleDeviceIPAddressFunc == null)
            {
               _Engine_GetAppleDeviceIPAddressFunc =
                  (_Engine_GetAppleDeviceIPAddress)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetAppleDeviceIPAddress"), typeof(_Engine_GetAppleDeviceIPAddress));
            }

            return _Engine_GetAppleDeviceIPAddressFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_Quit();
         private static _Engine_Quit _Engine_QuitFunc;
         internal static void Engine_Quit()
         {
            if (_Engine_QuitFunc == null)
            {
               _Engine_QuitFunc =
                  (_Engine_Quit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_Quit"), typeof(_Engine_Quit));
            }

            _Engine_QuitFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_QuitWithErrorMessage(string msg);
         private static _Engine_QuitWithErrorMessage _Engine_QuitWithErrorMessageFunc;
         internal static void Engine_QuitWithErrorMessage(string msg)
         {
            if (_Engine_QuitWithErrorMessageFunc == null)
            {
               _Engine_QuitWithErrorMessageFunc =
                  (_Engine_QuitWithErrorMessage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_QuitWithErrorMessage"), typeof(_Engine_QuitWithErrorMessage));
            }

            _Engine_QuitWithErrorMessageFunc(msg);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_Detag(int tagId);
         private static _Engine_Detag _Engine_DetagFunc;
         internal static IntPtr Engine_Detag(int tagId)
         {
            if (_Engine_DetagFunc == null)
            {
               _Engine_DetagFunc =
                  (_Engine_Detag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_Detag"), typeof(_Engine_Detag));
            }

            return _Engine_DetagFunc(tagId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetTag(string taggedString);
         private static _Engine_GetTag _Engine_GetTagFunc;
         internal static IntPtr Engine_GetTag(string taggedString)
         {
            if (_Engine_GetTagFunc == null)
            {
               _Engine_GetTagFunc =
                  (_Engine_GetTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetTag"), typeof(_Engine_GetTag));
            }

            return _Engine_GetTagFunc(taggedString);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetStockColorCount();
         private static _Engine_GetStockColorCount _Engine_GetStockColorCountFunc;
         internal static int Engine_GetStockColorCount()
         {
            if (_Engine_GetStockColorCountFunc == null)
            {
               _Engine_GetStockColorCountFunc =
                  (_Engine_GetStockColorCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetStockColorCount"), typeof(_Engine_GetStockColorCount));
            }

            return _Engine_GetStockColorCountFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetStockColorName(int index);
         private static _Engine_GetStockColorName _Engine_GetStockColorNameFunc;
         internal static IntPtr Engine_GetStockColorName(int index)
         {
            if (_Engine_GetStockColorNameFunc == null)
            {
               _Engine_GetStockColorNameFunc =
                  (_Engine_GetStockColorName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetStockColorName"), typeof(_Engine_GetStockColorName));
            }

            return _Engine_GetStockColorNameFunc(index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsStockColor(string name);
         private static _Engine_IsStockColor _Engine_IsStockColorFunc;
         internal static bool Engine_IsStockColor(string name)
         {
            if (_Engine_IsStockColorFunc == null)
            {
               _Engine_IsStockColorFunc =
                  (_Engine_IsStockColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsStockColor"), typeof(_Engine_IsStockColor));
            }

            return _Engine_IsStockColorFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate Color _Engine_GetStockColor(string name);
         private static _Engine_GetStockColor _Engine_GetStockColorFunc;
         internal static Color Engine_GetStockColor(string name)
         {
            if (_Engine_GetStockColorFunc == null)
            {
               _Engine_GetStockColorFunc =
                  (_Engine_GetStockColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetStockColor"), typeof(_Engine_GetStockColor));
            }

            return _Engine_GetStockColorFunc(name);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_CaptureScreenArea(int posX, int posY, uint width, uint height, string fileName, string fileType);
         private static _Engine_CaptureScreenArea _Engine_CaptureScreenAreaFunc;
         internal static bool Engine_CaptureScreenArea(int posX, int posY, uint width, uint height, string fileName, string fileType)
         {
            if (_Engine_CaptureScreenAreaFunc == null)
            {
               _Engine_CaptureScreenAreaFunc =
                  (_Engine_CaptureScreenArea)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CaptureScreenArea"), typeof(_Engine_CaptureScreenArea));
            }

            return _Engine_CaptureScreenAreaFunc(posX, posY, width, height, fileName, fileType);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_PNG2JPG(string bmpname, uint quality);
         private static _Engine_PNG2JPG _Engine_PNG2JPGFunc;
         internal static bool Engine_PNG2JPG(string bmpname, uint quality)
         {
            if (_Engine_PNG2JPGFunc == null)
            {
               _Engine_PNG2JPGFunc =
                  (_Engine_PNG2JPG)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PNG2JPG"), typeof(_Engine_PNG2JPG));
            }

            return _Engine_PNG2JPGFunc(bmpname, quality);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_ShowStats(bool enable);
         private static _Engine_ShowStats _Engine_ShowStatsFunc;
         internal static void Engine_ShowStats(bool enable)
         {
            if (_Engine_ShowStatsFunc == null)
            {
               _Engine_ShowStatsFunc =
                  (_Engine_ShowStats)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ShowStats"), typeof(_Engine_ShowStats));
            }

            _Engine_ShowStatsFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_PopulateFontCacheString(string faceName, int size, string str);
         private static _Engine_PopulateFontCacheString _Engine_PopulateFontCacheStringFunc;
         internal static void Engine_PopulateFontCacheString(string faceName, int size, string str)
         {
            if (_Engine_PopulateFontCacheStringFunc == null)
            {
               _Engine_PopulateFontCacheStringFunc =
                  (_Engine_PopulateFontCacheString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PopulateFontCacheString"), typeof(_Engine_PopulateFontCacheString));
            }

            _Engine_PopulateFontCacheStringFunc(faceName, size, str);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_PopulateFontCacheRange(string faceName, int size, int rangeStart, int rangeEnd);
         private static _Engine_PopulateFontCacheRange _Engine_PopulateFontCacheRangeFunc;
         internal static void Engine_PopulateFontCacheRange(string faceName, int size, int rangeStart, int rangeEnd)
         {
            if (_Engine_PopulateFontCacheRangeFunc == null)
            {
               _Engine_PopulateFontCacheRangeFunc =
                  (_Engine_PopulateFontCacheRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PopulateFontCacheRange"), typeof(_Engine_PopulateFontCacheRange));
            }

            _Engine_PopulateFontCacheRangeFunc(faceName, size, rangeStart, rangeEnd);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DumpFontCacheStatus();
         private static _Engine_DumpFontCacheStatus _Engine_DumpFontCacheStatusFunc;
         internal static void Engine_DumpFontCacheStatus()
         {
            if (_Engine_DumpFontCacheStatusFunc == null)
            {
               _Engine_DumpFontCacheStatusFunc =
                  (_Engine_DumpFontCacheStatus)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DumpFontCacheStatus"), typeof(_Engine_DumpFontCacheStatus));
            }

            _Engine_DumpFontCacheStatusFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_WriteFontCache();
         private static _Engine_WriteFontCache _Engine_WriteFontCacheFunc;
         internal static void Engine_WriteFontCache()
         {
            if (_Engine_WriteFontCacheFunc == null)
            {
               _Engine_WriteFontCacheFunc =
                  (_Engine_WriteFontCache)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_WriteFontCache"), typeof(_Engine_WriteFontCache));
            }

            _Engine_WriteFontCacheFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_PopulateAllFontCacheString(string inString);
         private static _Engine_PopulateAllFontCacheString _Engine_PopulateAllFontCacheStringFunc;
         internal static void Engine_PopulateAllFontCacheString(string inString)
         {
            if (_Engine_PopulateAllFontCacheStringFunc == null)
            {
               _Engine_PopulateAllFontCacheStringFunc =
                  (_Engine_PopulateAllFontCacheString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PopulateAllFontCacheString"), typeof(_Engine_PopulateAllFontCacheString));
            }

            _Engine_PopulateAllFontCacheStringFunc(inString);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_PopulateAllFontCacheRange(int rangeStart, int rangeEnd);
         private static _Engine_PopulateAllFontCacheRange _Engine_PopulateAllFontCacheRangeFunc;
         internal static void Engine_PopulateAllFontCacheRange(int rangeStart, int rangeEnd)
         {
            if (_Engine_PopulateAllFontCacheRangeFunc == null)
            {
               _Engine_PopulateAllFontCacheRangeFunc =
                  (_Engine_PopulateAllFontCacheRange)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PopulateAllFontCacheRange"), typeof(_Engine_PopulateAllFontCacheRange));
            }

            _Engine_PopulateAllFontCacheRangeFunc(rangeStart, rangeEnd);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_ExportCachedFont(string fontName, int size, string fileName, int padding, int kerning);
         private static _Engine_ExportCachedFont _Engine_ExportCachedFontFunc;
         internal static void Engine_ExportCachedFont(string fontName, int size, string fileName, int padding, int kerning)
         {
            if (_Engine_ExportCachedFontFunc == null)
            {
               _Engine_ExportCachedFontFunc =
                  (_Engine_ExportCachedFont)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ExportCachedFont"), typeof(_Engine_ExportCachedFont));
            }

            _Engine_ExportCachedFontFunc(fontName, size, fileName, padding, kerning);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_ImportCachedFont(string fontName, int size, string fileName, int padding, int kerning);
         private static _Engine_ImportCachedFont _Engine_ImportCachedFontFunc;
         internal static void Engine_ImportCachedFont(string fontName, int size, string fileName, int padding, int kerning)
         {
            if (_Engine_ImportCachedFontFunc == null)
            {
               _Engine_ImportCachedFontFunc =
                  (_Engine_ImportCachedFont)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ImportCachedFont"), typeof(_Engine_ImportCachedFont));
            }

            _Engine_ImportCachedFontFunc(fontName, size, fileName, padding, kerning);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DuplicateCachedFont(string oldFontName, int oldFontSize, string newFontName, int newFontSize);
         private static _Engine_DuplicateCachedFont _Engine_DuplicateCachedFontFunc;
         internal static void Engine_DuplicateCachedFont(string oldFontName, int oldFontSize, string newFontName, int newFontSize)
         {
            if (_Engine_DuplicateCachedFontFunc == null)
            {
               _Engine_DuplicateCachedFontFunc =
                  (_Engine_DuplicateCachedFont)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DuplicateCachedFont"), typeof(_Engine_DuplicateCachedFont));
            }

            _Engine_DuplicateCachedFontFunc(oldFontName, oldFontSize, newFontName, newFontSize);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_MaterialAssetGetTextureFile(IntPtr textureAsset);
         private static _Engine_MaterialAssetGetTextureFile _Engine_MaterialAssetGetTextureFileFunc;
         internal static IntPtr Engine_MaterialAssetGetTextureFile(IntPtr textureAsset)
         {
            if (_Engine_MaterialAssetGetTextureFileFunc == null)
            {
               _Engine_MaterialAssetGetTextureFileFunc =
                  (_Engine_MaterialAssetGetTextureFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MaterialAssetGetTextureFile"), typeof(_Engine_MaterialAssetGetTextureFile));
            }

            return _Engine_MaterialAssetGetTextureFileFunc(textureAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_FlushTextureCache();
         private static _Engine_FlushTextureCache _Engine_FlushTextureCacheFunc;
         internal static void Engine_FlushTextureCache()
         {
            if (_Engine_FlushTextureCacheFunc == null)
            {
               _Engine_FlushTextureCacheFunc =
                  (_Engine_FlushTextureCache)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FlushTextureCache"), typeof(_Engine_FlushTextureCache));
            }

            _Engine_FlushTextureCacheFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DumpTextureManagerMetrics();
         private static _Engine_DumpTextureManagerMetrics _Engine_DumpTextureManagerMetricsFunc;
         internal static void Engine_DumpTextureManagerMetrics()
         {
            if (_Engine_DumpTextureManagerMetricsFunc == null)
            {
               _Engine_DumpTextureManagerMetricsFunc =
                  (_Engine_DumpTextureManagerMetrics)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DumpTextureManagerMetrics"), typeof(_Engine_DumpTextureManagerMetrics));
            }

            _Engine_DumpTextureManagerMetricsFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_CreateCanvas(string windowTitle);
         private static _Engine_CreateCanvas _Engine_CreateCanvasFunc;
         internal static bool Engine_CreateCanvas(string windowTitle)
         {
            if (_Engine_CreateCanvasFunc == null)
            {
               _Engine_CreateCanvasFunc =
                  (_Engine_CreateCanvas)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CreateCanvas"), typeof(_Engine_CreateCanvas));
            }

            return _Engine_CreateCanvasFunc(windowTitle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_SetCanvasTitle(string windowTitle);
         private static _Engine_SetCanvasTitle _Engine_SetCanvasTitleFunc;
         internal static void Engine_SetCanvasTitle(string windowTitle)
         {
            if (_Engine_SetCanvasTitleFunc == null)
            {
               _Engine_SetCanvasTitleFunc =
                  (_Engine_SetCanvasTitle)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetCanvasTitle"), typeof(_Engine_SetCanvasTitle));
            }

            _Engine_SetCanvasTitleFunc(windowTitle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_ScreenShot(string file, string format);
         private static _Engine_ScreenShot _Engine_ScreenShotFunc;
         internal static void Engine_ScreenShot(string file, string format)
         {
            if (_Engine_ScreenShotFunc == null)
            {
               _Engine_ScreenShotFunc =
                  (_Engine_ScreenShot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ScreenShot"), typeof(_Engine_ScreenShot));
            }

            _Engine_ScreenShotFunc(file, format);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_StripMLControlChars(string sourceString);
         private static _Engine_StripMLControlChars _Engine_StripMLControlCharsFunc;
         internal static IntPtr Engine_StripMLControlChars(string sourceString)
         {
            if (_Engine_StripMLControlCharsFunc == null)
            {
               _Engine_StripMLControlCharsFunc =
                  (_Engine_StripMLControlChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StripMLControlChars"), typeof(_Engine_StripMLControlChars));
            }

            return _Engine_StripMLControlCharsFunc(sourceString);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_InitLeapMotionManager();
         private static _Engine_InitLeapMotionManager _Engine_InitLeapMotionManagerFunc;
         internal static void Engine_InitLeapMotionManager()
         {
            if (_Engine_InitLeapMotionManagerFunc == null)
            {
               _Engine_InitLeapMotionManagerFunc =
                  (_Engine_InitLeapMotionManager)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_InitLeapMotionManager"), typeof(_Engine_InitLeapMotionManager));
            }

            _Engine_InitLeapMotionManagerFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_EnableLeapMotionManager(bool enable);
         private static _Engine_EnableLeapMotionManager _Engine_EnableLeapMotionManagerFunc;
         internal static void Engine_EnableLeapMotionManager(bool enable)
         {
            if (_Engine_EnableLeapMotionManagerFunc == null)
            {
               _Engine_EnableLeapMotionManagerFunc =
                  (_Engine_EnableLeapMotionManager)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableLeapMotionManager"), typeof(_Engine_EnableLeapMotionManager));
            }

            _Engine_EnableLeapMotionManagerFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsLeapMotionManagerEnabled();
         private static _Engine_IsLeapMotionManagerEnabled _Engine_IsLeapMotionManagerEnabledFunc;
         internal static bool Engine_IsLeapMotionManagerEnabled()
         {
            if (_Engine_IsLeapMotionManagerEnabledFunc == null)
            {
               _Engine_IsLeapMotionManagerEnabledFunc =
                  (_Engine_IsLeapMotionManagerEnabled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsLeapMotionManagerEnabled"), typeof(_Engine_IsLeapMotionManagerEnabled));
            }

            return _Engine_IsLeapMotionManagerEnabledFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_EnableLeapCursorControl(bool enable);
         private static _Engine_EnableLeapCursorControl _Engine_EnableLeapCursorControlFunc;
         internal static void Engine_EnableLeapCursorControl(bool enable)
         {
            if (_Engine_EnableLeapCursorControlFunc == null)
            {
               _Engine_EnableLeapCursorControlFunc =
                  (_Engine_EnableLeapCursorControl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableLeapCursorControl"), typeof(_Engine_EnableLeapCursorControl));
            }

            _Engine_EnableLeapCursorControlFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsLeapCursorControlled();
         private static _Engine_IsLeapCursorControlled _Engine_IsLeapCursorControlledFunc;
         internal static bool Engine_IsLeapCursorControlled()
         {
            if (_Engine_IsLeapCursorControlledFunc == null)
            {
               _Engine_IsLeapCursorControlledFunc =
                  (_Engine_IsLeapCursorControlled)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsLeapCursorControlled"), typeof(_Engine_IsLeapCursorControlled));
            }

            return _Engine_IsLeapCursorControlledFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_ConfigureLeapGesture(string gestureString, float value);
         private static _Engine_ConfigureLeapGesture _Engine_ConfigureLeapGestureFunc;
         internal static bool Engine_ConfigureLeapGesture(string gestureString, float value)
         {
            if (_Engine_ConfigureLeapGestureFunc == null)
            {
               _Engine_ConfigureLeapGestureFunc =
                  (_Engine_ConfigureLeapGesture)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ConfigureLeapGesture"), typeof(_Engine_ConfigureLeapGesture));
            }

            return _Engine_ConfigureLeapGestureFunc(gestureString, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_GetPointFromProjection(Point3F pos, Point2F outPos);
         private static _Engine_GetPointFromProjection _Engine_GetPointFromProjectionFunc;
         internal static void Engine_GetPointFromProjection(Point3F pos, Point2F outPos)
         {
            if (_Engine_GetPointFromProjectionFunc == null)
            {
               _Engine_GetPointFromProjectionFunc =
                  (_Engine_GetPointFromProjection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetPointFromProjection"), typeof(_Engine_GetPointFromProjection));
            }

            _Engine_GetPointFromProjectionFunc(pos, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_GetPointFromIntersection(int fingerID, Point2F outPos);
         private static _Engine_GetPointFromIntersection _Engine_GetPointFromIntersectionFunc;
         internal static void Engine_GetPointFromIntersection(int fingerID, Point2F outPos)
         {
            if (_Engine_GetPointFromIntersectionFunc == null)
            {
               _Engine_GetPointFromIntersectionFunc =
                  (_Engine_GetPointFromIntersection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetPointFromIntersection"), typeof(_Engine_GetPointFromIntersection));
            }

            _Engine_GetPointFromIntersectionFunc(fingerID, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FindFirstFile(string pattern);
         private static _Engine_FindFirstFile _Engine_FindFirstFileFunc;
         internal static IntPtr Engine_FindFirstFile(string pattern)
         {
            if (_Engine_FindFirstFileFunc == null)
            {
               _Engine_FindFirstFileFunc =
                  (_Engine_FindFirstFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FindFirstFile"), typeof(_Engine_FindFirstFile));
            }

            return _Engine_FindFirstFileFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FindNextFile(string pattern);
         private static _Engine_FindNextFile _Engine_FindNextFileFunc;
         internal static IntPtr Engine_FindNextFile(string pattern)
         {
            if (_Engine_FindNextFileFunc == null)
            {
               _Engine_FindNextFileFunc =
                  (_Engine_FindNextFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FindNextFile"), typeof(_Engine_FindNextFile));
            }

            return _Engine_FindNextFileFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetFileCount(string pattern);
         private static _Engine_GetFileCount _Engine_GetFileCountFunc;
         internal static int Engine_GetFileCount(string pattern)
         {
            if (_Engine_GetFileCountFunc == null)
            {
               _Engine_GetFileCountFunc =
                  (_Engine_GetFileCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetFileCount"), typeof(_Engine_GetFileCount));
            }

            return _Engine_GetFileCountFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FindFirstFileMultiExpr(string pattern);
         private static _Engine_FindFirstFileMultiExpr _Engine_FindFirstFileMultiExprFunc;
         internal static IntPtr Engine_FindFirstFileMultiExpr(string pattern)
         {
            if (_Engine_FindFirstFileMultiExprFunc == null)
            {
               _Engine_FindFirstFileMultiExprFunc =
                  (_Engine_FindFirstFileMultiExpr)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FindFirstFileMultiExpr"), typeof(_Engine_FindFirstFileMultiExpr));
            }

            return _Engine_FindFirstFileMultiExprFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FindNextFileMultiExpr(string pattern);
         private static _Engine_FindNextFileMultiExpr _Engine_FindNextFileMultiExprFunc;
         internal static IntPtr Engine_FindNextFileMultiExpr(string pattern)
         {
            if (_Engine_FindNextFileMultiExprFunc == null)
            {
               _Engine_FindNextFileMultiExprFunc =
                  (_Engine_FindNextFileMultiExpr)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FindNextFileMultiExpr"), typeof(_Engine_FindNextFileMultiExpr));
            }

            return _Engine_FindNextFileMultiExprFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetFileCountMultiExpr(string pattern);
         private static _Engine_GetFileCountMultiExpr _Engine_GetFileCountMultiExprFunc;
         internal static int Engine_GetFileCountMultiExpr(string pattern)
         {
            if (_Engine_GetFileCountMultiExprFunc == null)
            {
               _Engine_GetFileCountMultiExprFunc =
                  (_Engine_GetFileCountMultiExpr)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetFileCountMultiExpr"), typeof(_Engine_GetFileCountMultiExpr));
            }

            return _Engine_GetFileCountMultiExprFunc(pattern);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetFileCRC(string fileName);
         private static _Engine_GetFileCRC _Engine_GetFileCRCFunc;
         internal static int Engine_GetFileCRC(string fileName)
         {
            if (_Engine_GetFileCRCFunc == null)
            {
               _Engine_GetFileCRCFunc =
                  (_Engine_GetFileCRC)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetFileCRC"), typeof(_Engine_GetFileCRC));
            }

            return _Engine_GetFileCRCFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsDirectory(string path);
         private static _Engine_IsDirectory _Engine_IsDirectoryFunc;
         internal static bool Engine_IsDirectory(string path)
         {
            if (_Engine_IsDirectoryFunc == null)
            {
               _Engine_IsDirectoryFunc =
                  (_Engine_IsDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsDirectory"), typeof(_Engine_IsDirectory));
            }

            return _Engine_IsDirectoryFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsFile(string fileName);
         private static _Engine_IsFile _Engine_IsFileFunc;
         internal static bool Engine_IsFile(string fileName)
         {
            if (_Engine_IsFileFunc == null)
            {
               _Engine_IsFileFunc =
                  (_Engine_IsFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsFile"), typeof(_Engine_IsFile));
            }

            return _Engine_IsFileFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsWriteableFileName(string fileName);
         private static _Engine_IsWriteableFileName _Engine_IsWriteableFileNameFunc;
         internal static bool Engine_IsWriteableFileName(string fileName)
         {
            if (_Engine_IsWriteableFileNameFunc == null)
            {
               _Engine_IsWriteableFileNameFunc =
                  (_Engine_IsWriteableFileName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsWriteableFileName"), typeof(_Engine_IsWriteableFileName));
            }

            return _Engine_IsWriteableFileNameFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetDirectoryList(string dirPath, int depth);
         private static _Engine_GetDirectoryList _Engine_GetDirectoryListFunc;
         internal static IntPtr Engine_GetDirectoryList(string dirPath, int depth)
         {
            if (_Engine_GetDirectoryListFunc == null)
            {
               _Engine_GetDirectoryListFunc =
                  (_Engine_GetDirectoryList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetDirectoryList"), typeof(_Engine_GetDirectoryList));
            }

            return _Engine_GetDirectoryListFunc(dirPath, depth);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetFileList(string strPath);
         private static _Engine_GetFileList _Engine_GetFileListFunc;
         internal static IntPtr Engine_GetFileList(string strPath)
         {
            if (_Engine_GetFileListFunc == null)
            {
               _Engine_GetFileListFunc =
                  (_Engine_GetFileList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetFileList"), typeof(_Engine_GetFileList));
            }

            return _Engine_GetFileListFunc(strPath);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_FileSize(string fileName);
         private static _Engine_FileSize _Engine_FileSizeFunc;
         internal static int Engine_FileSize(string fileName)
         {
            if (_Engine_FileSizeFunc == null)
            {
               _Engine_FileSizeFunc =
                  (_Engine_FileSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FileSize"), typeof(_Engine_FileSize));
            }

            return _Engine_FileSizeFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_FileDelete(string fileName);
         private static _Engine_FileDelete _Engine_FileDeleteFunc;
         internal static bool Engine_FileDelete(string fileName)
         {
            if (_Engine_FileDeleteFunc == null)
            {
               _Engine_FileDeleteFunc =
                  (_Engine_FileDelete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FileDelete"), typeof(_Engine_FileDelete));
            }

            return _Engine_FileDeleteFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_DirectoryDelete(string directoryName);
         private static _Engine_DirectoryDelete _Engine_DirectoryDeleteFunc;
         internal static bool Engine_DirectoryDelete(string directoryName)
         {
            if (_Engine_DirectoryDeleteFunc == null)
            {
               _Engine_DirectoryDeleteFunc =
                  (_Engine_DirectoryDelete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DirectoryDelete"), typeof(_Engine_DirectoryDelete));
            }

            return _Engine_DirectoryDeleteFunc(directoryName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsValidImageFile(string filePath);
         private static _Engine_IsValidImageFile _Engine_IsValidImageFileFunc;
         internal static bool Engine_IsValidImageFile(string filePath)
         {
            if (_Engine_IsValidImageFileFunc == null)
            {
               _Engine_IsValidImageFileFunc =
                  (_Engine_IsValidImageFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsValidImageFile"), typeof(_Engine_IsValidImageFile));
            }

            return _Engine_IsValidImageFileFunc(filePath);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FileExt(string fileName);
         private static _Engine_FileExt _Engine_FileExtFunc;
         internal static IntPtr Engine_FileExt(string fileName)
         {
            if (_Engine_FileExtFunc == null)
            {
               _Engine_FileExtFunc =
                  (_Engine_FileExt)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FileExt"), typeof(_Engine_FileExt));
            }

            return _Engine_FileExtFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FileBase(string fileName);
         private static _Engine_FileBase _Engine_FileBaseFunc;
         internal static IntPtr Engine_FileBase(string fileName)
         {
            if (_Engine_FileBaseFunc == null)
            {
               _Engine_FileBaseFunc =
                  (_Engine_FileBase)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FileBase"), typeof(_Engine_FileBase));
            }

            return _Engine_FileBaseFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FileName(string fileName);
         private static _Engine_FileName _Engine_FileNameFunc;
         internal static IntPtr Engine_FileName(string fileName)
         {
            if (_Engine_FileNameFunc == null)
            {
               _Engine_FileNameFunc =
                  (_Engine_FileName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FileName"), typeof(_Engine_FileName));
            }

            return _Engine_FileNameFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_FilePath(string fileName);
         private static _Engine_FilePath _Engine_FilePathFunc;
         internal static IntPtr Engine_FilePath(string fileName)
         {
            if (_Engine_FilePathFunc == null)
            {
               _Engine_FilePathFunc =
                  (_Engine_FilePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_FilePath"), typeof(_Engine_FilePath));
            }

            return _Engine_FilePathFunc(fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_OpenFolder(string path);
         private static _Engine_OpenFolder _Engine_OpenFolderFunc;
         internal static void Engine_OpenFolder(string path)
         {
            if (_Engine_OpenFolderFunc == null)
            {
               _Engine_OpenFolderFunc =
                  (_Engine_OpenFolder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_OpenFolder"), typeof(_Engine_OpenFolder));
            }

            _Engine_OpenFolderFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_PathCopy(string fromFile, string toFile, bool noOverwrite);
         private static _Engine_PathCopy _Engine_PathCopyFunc;
         internal static bool Engine_PathCopy(string fromFile, string toFile, bool noOverwrite)
         {
            if (_Engine_PathCopyFunc == null)
            {
               _Engine_PathCopyFunc =
                  (_Engine_PathCopy)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PathCopy"), typeof(_Engine_PathCopy));
            }

            return _Engine_PathCopyFunc(fromFile, toFile, noOverwrite);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetCurrentDirectory();
         private static _Engine_GetCurrentDirectory _Engine_GetCurrentDirectoryFunc;
         internal static IntPtr Engine_GetCurrentDirectory()
         {
            if (_Engine_GetCurrentDirectoryFunc == null)
            {
               _Engine_GetCurrentDirectoryFunc =
                  (_Engine_GetCurrentDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetCurrentDirectory"), typeof(_Engine_GetCurrentDirectory));
            }

            return _Engine_GetCurrentDirectoryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetCurrentDirectory(string absolutePathName);
         private static _Engine_SetCurrentDirectory _Engine_SetCurrentDirectoryFunc;
         internal static bool Engine_SetCurrentDirectory(string absolutePathName)
         {
            if (_Engine_SetCurrentDirectoryFunc == null)
            {
               _Engine_SetCurrentDirectoryFunc =
                  (_Engine_SetCurrentDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetCurrentDirectory"), typeof(_Engine_SetCurrentDirectory));
            }

            return _Engine_SetCurrentDirectoryFunc(absolutePathName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetExecutableName();
         private static _Engine_GetExecutableName _Engine_GetExecutableNameFunc;
         internal static IntPtr Engine_GetExecutableName()
         {
            if (_Engine_GetExecutableNameFunc == null)
            {
               _Engine_GetExecutableNameFunc =
                  (_Engine_GetExecutableName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetExecutableName"), typeof(_Engine_GetExecutableName));
            }

            return _Engine_GetExecutableNameFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetMainDotCsDir();
         private static _Engine_GetMainDotCsDir _Engine_GetMainDotCsDirFunc;
         internal static IntPtr Engine_GetMainDotCsDir()
         {
            if (_Engine_GetMainDotCsDirFunc == null)
            {
               _Engine_GetMainDotCsDirFunc =
                  (_Engine_GetMainDotCsDir)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetMainDotCsDir"), typeof(_Engine_GetMainDotCsDir));
            }

            return _Engine_GetMainDotCsDirFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_MakeFullPath(string path, string currentWorkingDirectory);
         private static _Engine_MakeFullPath _Engine_MakeFullPathFunc;
         internal static IntPtr Engine_MakeFullPath(string path, string currentWorkingDirectory)
         {
            if (_Engine_MakeFullPathFunc == null)
            {
               _Engine_MakeFullPathFunc =
                  (_Engine_MakeFullPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MakeFullPath"), typeof(_Engine_MakeFullPath));
            }

            return _Engine_MakeFullPathFunc(path, currentWorkingDirectory);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_MakeRelativePath(string path, string to);
         private static _Engine_MakeRelativePath _Engine_MakeRelativePathFunc;
         internal static IntPtr Engine_MakeRelativePath(string path, string to)
         {
            if (_Engine_MakeRelativePathFunc == null)
            {
               _Engine_MakeRelativePathFunc =
                  (_Engine_MakeRelativePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MakeRelativePath"), typeof(_Engine_MakeRelativePath));
            }

            return _Engine_MakeRelativePathFunc(path, to);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_PathConcat(string path, int argc, string[] argv);
         private static _Engine_PathConcat _Engine_PathConcatFunc;
         internal static IntPtr Engine_PathConcat(string path, int argc, string[] argv)
         {
            if (_Engine_PathConcatFunc == null)
            {
               _Engine_PathConcatFunc =
                  (_Engine_PathConcat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PathConcat"), typeof(_Engine_PathConcat));
            }

            return _Engine_PathConcatFunc(path, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_RestartInstance();
         private static _Engine_RestartInstance _Engine_RestartInstanceFunc;
         internal static void Engine_RestartInstance()
         {
            if (_Engine_RestartInstanceFunc == null)
            {
               _Engine_RestartInstanceFunc =
                  (_Engine_RestartInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RestartInstance"), typeof(_Engine_RestartInstance));
            }

            _Engine_RestartInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_CreatePath(string path);
         private static _Engine_CreatePath _Engine_CreatePathFunc;
         internal static bool Engine_CreatePath(string path)
         {
            if (_Engine_CreatePathFunc == null)
            {
               _Engine_CreatePathFunc =
                  (_Engine_CreatePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CreatePath"), typeof(_Engine_CreatePath));
            }

            return _Engine_CreatePathFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DumpResources(bool onlyLoaded);
         private static _Engine_DumpResources _Engine_DumpResourcesFunc;
         internal static void Engine_DumpResources(bool onlyLoaded)
         {
            if (_Engine_DumpResourcesFunc == null)
            {
               _Engine_DumpResourcesFunc =
                  (_Engine_DumpResources)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DumpResources"), typeof(_Engine_DumpResources));
            }

            _Engine_DumpResourcesFunc(onlyLoaded);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_AddResPath(string path, bool ignoreZips);
         private static _Engine_AddResPath _Engine_AddResPathFunc;
         internal static void Engine_AddResPath(string path, bool ignoreZips)
         {
            if (_Engine_AddResPathFunc == null)
            {
               _Engine_AddResPathFunc =
                  (_Engine_AddResPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_AddResPath"), typeof(_Engine_AddResPath));
            }

            _Engine_AddResPathFunc(path, ignoreZips);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_RemoveResPath(string path);
         private static _Engine_RemoveResPath _Engine_RemoveResPathFunc;
         internal static void Engine_RemoveResPath(string path)
         {
            if (_Engine_RemoveResPathFunc == null)
            {
               _Engine_RemoveResPathFunc =
                  (_Engine_RemoveResPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RemoveResPath"), typeof(_Engine_RemoveResPath));
            }

            _Engine_RemoveResPathFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_SetModPaths(string path);
         private static _Engine_SetModPaths _Engine_SetModPathsFunc;
         internal static void Engine_SetModPaths(string path)
         {
            if (_Engine_SetModPathsFunc == null)
            {
               _Engine_SetModPathsFunc =
                  (_Engine_SetModPaths)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetModPaths"), typeof(_Engine_SetModPaths));
            }

            _Engine_SetModPathsFunc(path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetModPaths();
         private static _Engine_GetModPaths _Engine_GetModPathsFunc;
         internal static IntPtr Engine_GetModPaths()
         {
            if (_Engine_GetModPathsFunc == null)
            {
               _Engine_GetModPathsFunc =
                  (_Engine_GetModPaths)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetModPaths"), typeof(_Engine_GetModPaths));
            }

            return _Engine_GetModPathsFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_PurgeResources();
         private static _Engine_PurgeResources _Engine_PurgeResourcesFunc;
         internal static void Engine_PurgeResources()
         {
            if (_Engine_PurgeResourcesFunc == null)
            {
               _Engine_PurgeResourcesFunc =
                  (_Engine_PurgeResources)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PurgeResources"), typeof(_Engine_PurgeResources));
            }

            _Engine_PurgeResourcesFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsUsingVFS();
         private static _Engine_IsUsingVFS _Engine_IsUsingVFSFunc;
         internal static bool Engine_IsUsingVFS()
         {
            if (_Engine_IsUsingVFSFunc == null)
            {
               _Engine_IsUsingVFSFunc =
                  (_Engine_IsUsingVFS)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsUsingVFS"), typeof(_Engine_IsUsingVFS));
            }

            return _Engine_IsUsingVFSFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetMaxFrameAllocation();
         private static _Engine_GetMaxFrameAllocation _Engine_GetMaxFrameAllocationFunc;
         internal static int Engine_GetMaxFrameAllocation()
         {
            if (_Engine_GetMaxFrameAllocationFunc == null)
            {
               _Engine_GetMaxFrameAllocationFunc =
                  (_Engine_GetMaxFrameAllocation)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetMaxFrameAllocation"), typeof(_Engine_GetMaxFrameAllocation));
            }

            return _Engine_GetMaxFrameAllocationFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsQueueRegistered(string queueName);
         private static _Engine_IsQueueRegistered _Engine_IsQueueRegisteredFunc;
         internal static bool Engine_IsQueueRegistered(string queueName)
         {
            if (_Engine_IsQueueRegisteredFunc == null)
            {
               _Engine_IsQueueRegisteredFunc =
                  (_Engine_IsQueueRegistered)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsQueueRegistered"), typeof(_Engine_IsQueueRegistered));
            }

            return _Engine_IsQueueRegisteredFunc(queueName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_RegisterMessageQueue(string queueName);
         private static _Engine_RegisterMessageQueue _Engine_RegisterMessageQueueFunc;
         internal static void Engine_RegisterMessageQueue(string queueName)
         {
            if (_Engine_RegisterMessageQueueFunc == null)
            {
               _Engine_RegisterMessageQueueFunc =
                  (_Engine_RegisterMessageQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RegisterMessageQueue"), typeof(_Engine_RegisterMessageQueue));
            }

            _Engine_RegisterMessageQueueFunc(queueName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_UnregisterMessageQueue(string queueName);
         private static _Engine_UnregisterMessageQueue _Engine_UnregisterMessageQueueFunc;
         internal static void Engine_UnregisterMessageQueue(string queueName)
         {
            if (_Engine_UnregisterMessageQueueFunc == null)
            {
               _Engine_UnregisterMessageQueueFunc =
                  (_Engine_UnregisterMessageQueue)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_UnregisterMessageQueue"), typeof(_Engine_UnregisterMessageQueue));
            }

            _Engine_UnregisterMessageQueueFunc(queueName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_RegisterMessageListener(string queueName, IntPtr listener);
         private static _Engine_RegisterMessageListener _Engine_RegisterMessageListenerFunc;
         internal static bool Engine_RegisterMessageListener(string queueName, IntPtr listener)
         {
            if (_Engine_RegisterMessageListenerFunc == null)
            {
               _Engine_RegisterMessageListenerFunc =
                  (_Engine_RegisterMessageListener)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RegisterMessageListener"), typeof(_Engine_RegisterMessageListener));
            }

            return _Engine_RegisterMessageListenerFunc(queueName, listener);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_UnregisterMessageListener(string queueName, IntPtr listener);
         private static _Engine_UnregisterMessageListener _Engine_UnregisterMessageListenerFunc;
         internal static void Engine_UnregisterMessageListener(string queueName, IntPtr listener)
         {
            if (_Engine_UnregisterMessageListenerFunc == null)
            {
               _Engine_UnregisterMessageListenerFunc =
                  (_Engine_UnregisterMessageListener)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_UnregisterMessageListener"), typeof(_Engine_UnregisterMessageListener));
            }

            _Engine_UnregisterMessageListenerFunc(queueName, listener);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_DispatchMessage(string queueName, string evt, string data);
         private static _Engine_DispatchMessage _Engine_DispatchMessageFunc;
         internal static bool Engine_DispatchMessage(string queueName, string evt, string data)
         {
            if (_Engine_DispatchMessageFunc == null)
            {
               _Engine_DispatchMessageFunc =
                  (_Engine_DispatchMessage)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DispatchMessage"), typeof(_Engine_DispatchMessage));
            }

            return _Engine_DispatchMessageFunc(queueName, evt, data);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_DispatchMessageObject(string queueName, IntPtr msgObj);
         private static _Engine_DispatchMessageObject _Engine_DispatchMessageObjectFunc;
         internal static bool Engine_DispatchMessageObject(string queueName, IntPtr msgObj)
         {
            if (_Engine_DispatchMessageObjectFunc == null)
            {
               _Engine_DispatchMessageObjectFunc =
                  (_Engine_DispatchMessageObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DispatchMessageObject"), typeof(_Engine_DispatchMessageObject));
            }

            return _Engine_DispatchMessageObjectFunc(queueName, msgObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DNetSetLogging(bool enabled);
         private static _Engine_DNetSetLogging _Engine_DNetSetLoggingFunc;
         internal static void Engine_DNetSetLogging(bool enabled)
         {
            if (_Engine_DNetSetLoggingFunc == null)
            {
               _Engine_DNetSetLoggingFunc =
                  (_Engine_DNetSetLogging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DNetSetLogging"), typeof(_Engine_DNetSetLogging));
            }

            _Engine_DNetSetLoggingFunc(enabled);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_AllowConnections(bool enable);
         private static _Engine_AllowConnections _Engine_AllowConnectionsFunc;
         internal static void Engine_AllowConnections(bool enable)
         {
            if (_Engine_AllowConnectionsFunc == null)
            {
               _Engine_AllowConnectionsFunc =
                  (_Engine_AllowConnections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_AllowConnections"), typeof(_Engine_AllowConnections));
            }

            _Engine_AllowConnectionsFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DumpNetStringTable();
         private static _Engine_DumpNetStringTable _Engine_DumpNetStringTableFunc;
         internal static void Engine_DumpNetStringTable()
         {
            if (_Engine_DumpNetStringTableFunc == null)
            {
               _Engine_DumpNetStringTableFunc =
                  (_Engine_DumpNetStringTable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DumpNetStringTable"), typeof(_Engine_DumpNetStringTable));
            }

            _Engine_DumpNetStringTableFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_CommandToServer(int argc, string[] argv);
         private static _Engine_CommandToServer _Engine_CommandToServerFunc;
         internal static void Engine_CommandToServer(int argc, string[] argv)
         {
            if (_Engine_CommandToServerFunc == null)
            {
               _Engine_CommandToServerFunc =
                  (_Engine_CommandToServer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CommandToServer"), typeof(_Engine_CommandToServer));
            }

            _Engine_CommandToServerFunc(argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_CommandToClient(IntPtr conn, int argc, string[] argv);
         private static _Engine_CommandToClient _Engine_CommandToClientFunc;
         internal static void Engine_CommandToClient(IntPtr conn, int argc, string[] argv)
         {
            if (_Engine_CommandToClientFunc == null)
            {
               _Engine_CommandToClientFunc =
                  (_Engine_CommandToClient)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CommandToClient"), typeof(_Engine_CommandToClient));
            }

            _Engine_CommandToClientFunc(conn, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_RemoveTaggedString(string tag);
         private static _Engine_RemoveTaggedString _Engine_RemoveTaggedStringFunc;
         internal static void Engine_RemoveTaggedString(string tag)
         {
            if (_Engine_RemoveTaggedStringFunc == null)
            {
               _Engine_RemoveTaggedStringFunc =
                  (_Engine_RemoveTaggedString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RemoveTaggedString"), typeof(_Engine_RemoveTaggedString));
            }

            _Engine_RemoveTaggedStringFunc(tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_AddTaggedString(string tag);
         private static _Engine_AddTaggedString _Engine_AddTaggedStringFunc;
         internal static IntPtr Engine_AddTaggedString(string tag)
         {
            if (_Engine_AddTaggedStringFunc == null)
            {
               _Engine_AddTaggedStringFunc =
                  (_Engine_AddTaggedString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_AddTaggedString"), typeof(_Engine_AddTaggedString));
            }

            return _Engine_AddTaggedStringFunc(tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetTaggedString(string tag);
         private static _Engine_GetTaggedString _Engine_GetTaggedStringFunc;
         internal static IntPtr Engine_GetTaggedString(string tag)
         {
            if (_Engine_GetTaggedStringFunc == null)
            {
               _Engine_GetTaggedStringFunc =
                  (_Engine_GetTaggedString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetTaggedString"), typeof(_Engine_GetTaggedString));
            }

            return _Engine_GetTaggedStringFunc(tag);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_BuildTaggedString(string format, int argc, string[] argv);
         private static _Engine_BuildTaggedString _Engine_BuildTaggedStringFunc;
         internal static IntPtr Engine_BuildTaggedString(string format, int argc, string[] argv)
         {
            if (_Engine_BuildTaggedStringFunc == null)
            {
               _Engine_BuildTaggedStringFunc =
                  (_Engine_BuildTaggedString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_BuildTaggedString"), typeof(_Engine_BuildTaggedString));
            }

            return _Engine_BuildTaggedStringFunc(format, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_QueryLanServers(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags);
         private static _Engine_QueryLanServers _Engine_QueryLanServersFunc;
         internal static void Engine_QueryLanServers(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags)
         {
            if (_Engine_QueryLanServersFunc == null)
            {
               _Engine_QueryLanServersFunc =
                  (_Engine_QueryLanServers)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_QueryLanServers"), typeof(_Engine_QueryLanServers));
            }

            _Engine_QueryLanServersFunc(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_QueryMasterServer(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags);
         private static _Engine_QueryMasterServer _Engine_QueryMasterServerFunc;
         internal static void Engine_QueryMasterServer(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags)
         {
            if (_Engine_QueryMasterServerFunc == null)
            {
               _Engine_QueryMasterServerFunc =
                  (_Engine_QueryMasterServer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_QueryMasterServer"), typeof(_Engine_QueryMasterServer));
            }

            _Engine_QueryMasterServerFunc(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_QuerySingleServer(string address, byte flags);
         private static _Engine_QuerySingleServer _Engine_QuerySingleServerFunc;
         internal static void Engine_QuerySingleServer(string address, byte flags)
         {
            if (_Engine_QuerySingleServerFunc == null)
            {
               _Engine_QuerySingleServerFunc =
                  (_Engine_QuerySingleServer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_QuerySingleServer"), typeof(_Engine_QuerySingleServer));
            }

            _Engine_QuerySingleServerFunc(address, flags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_CancelServerQuery();
         private static _Engine_CancelServerQuery _Engine_CancelServerQueryFunc;
         internal static void Engine_CancelServerQuery()
         {
            if (_Engine_CancelServerQueryFunc == null)
            {
               _Engine_CancelServerQueryFunc =
                  (_Engine_CancelServerQuery)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CancelServerQuery"), typeof(_Engine_CancelServerQuery));
            }

            _Engine_CancelServerQueryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_StopServerQuery();
         private static _Engine_StopServerQuery _Engine_StopServerQueryFunc;
         internal static void Engine_StopServerQuery()
         {
            if (_Engine_StopServerQueryFunc == null)
            {
               _Engine_StopServerQueryFunc =
                  (_Engine_StopServerQuery)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StopServerQuery"), typeof(_Engine_StopServerQuery));
            }

            _Engine_StopServerQueryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_StartHeartBeat();
         private static _Engine_StartHeartBeat _Engine_StartHeartBeatFunc;
         internal static void Engine_StartHeartBeat()
         {
            if (_Engine_StartHeartBeatFunc == null)
            {
               _Engine_StartHeartBeatFunc =
                  (_Engine_StartHeartBeat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StartHeartBeat"), typeof(_Engine_StartHeartBeat));
            }

            _Engine_StartHeartBeatFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_StopHeartBeat();
         private static _Engine_StopHeartBeat _Engine_StopHeartBeatFunc;
         internal static void Engine_StopHeartBeat()
         {
            if (_Engine_StopHeartBeatFunc == null)
            {
               _Engine_StopHeartBeatFunc =
                  (_Engine_StopHeartBeat)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StopHeartBeat"), typeof(_Engine_StopHeartBeat));
            }

            _Engine_StopHeartBeatFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetServerCount();
         private static _Engine_GetServerCount _Engine_GetServerCountFunc;
         internal static int Engine_GetServerCount()
         {
            if (_Engine_GetServerCountFunc == null)
            {
               _Engine_GetServerCountFunc =
                  (_Engine_GetServerCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetServerCount"), typeof(_Engine_GetServerCount));
            }

            return _Engine_GetServerCountFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetServerInfo(int index);
         private static _Engine_SetServerInfo _Engine_SetServerInfoFunc;
         internal static bool Engine_SetServerInfo(int index)
         {
            if (_Engine_SetServerInfoFunc == null)
            {
               _Engine_SetServerInfoFunc =
                  (_Engine_SetServerInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetServerInfo"), typeof(_Engine_SetServerInfo));
            }

            return _Engine_SetServerInfoFunc(index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_telnetSetParameters(int port, string consolePass, string listenPass, bool remoteEcho);
         private static _Engine_telnetSetParameters _Engine_telnetSetParametersFunc;
         internal static void Engine_telnetSetParameters(int port, string consolePass, string listenPass, bool remoteEcho)
         {
            if (_Engine_telnetSetParametersFunc == null)
            {
               _Engine_telnetSetParametersFunc =
                  (_Engine_telnetSetParameters)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_telnetSetParameters"), typeof(_Engine_telnetSetParameters));
            }

            _Engine_telnetSetParametersFunc(port, consolePass, listenPass, remoteEcho);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_TamlWrite(IntPtr obj, string filename, string format, bool compressed);
         private static _Engine_TamlWrite _Engine_TamlWriteFunc;
         internal static bool Engine_TamlWrite(IntPtr obj, string filename, string format, bool compressed)
         {
            if (_Engine_TamlWriteFunc == null)
            {
               _Engine_TamlWriteFunc =
                  (_Engine_TamlWrite)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_TamlWrite"), typeof(_Engine_TamlWrite));
            }

            return _Engine_TamlWriteFunc(obj, filename, format, compressed);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_TamlRead(string filename, string format);
         private static _Engine_TamlRead _Engine_TamlReadFunc;
         internal static IntPtr Engine_TamlRead(string filename, string format)
         {
            if (_Engine_TamlReadFunc == null)
            {
               _Engine_TamlReadFunc =
                  (_Engine_TamlRead)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_TamlRead"), typeof(_Engine_TamlRead));
            }

            return _Engine_TamlReadFunc(filename, format);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_GenerateTamlSchema();
         private static _Engine_GenerateTamlSchema _Engine_GenerateTamlSchemaFunc;
         internal static bool Engine_GenerateTamlSchema()
         {
            if (_Engine_GenerateTamlSchemaFunc == null)
            {
               _Engine_GenerateTamlSchemaFunc =
                  (_Engine_GenerateTamlSchema)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GenerateTamlSchema"), typeof(_Engine_GenerateTamlSchema));
            }

            return _Engine_GenerateTamlSchemaFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_InputPushCursor(string cursorShapeName);
         private static _Engine_InputPushCursor _Engine_InputPushCursorFunc;
         internal static void Engine_InputPushCursor(string cursorShapeName)
         {
            if (_Engine_InputPushCursorFunc == null)
            {
               _Engine_InputPushCursorFunc =
                  (_Engine_InputPushCursor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_InputPushCursor"), typeof(_Engine_InputPushCursor));
            }

            _Engine_InputPushCursorFunc(cursorShapeName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_InputPopCursor();
         private static _Engine_InputPopCursor _Engine_InputPopCursorFunc;
         internal static void Engine_InputPopCursor()
         {
            if (_Engine_InputPopCursorFunc == null)
            {
               _Engine_InputPopCursorFunc =
                  (_Engine_InputPopCursor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_InputPopCursor"), typeof(_Engine_InputPopCursor));
            }

            _Engine_InputPopCursorFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetTemporaryDirectory();
         private static _Engine_GetTemporaryDirectory _Engine_GetTemporaryDirectoryFunc;
         internal static IntPtr Engine_GetTemporaryDirectory()
         {
            if (_Engine_GetTemporaryDirectoryFunc == null)
            {
               _Engine_GetTemporaryDirectoryFunc =
                  (_Engine_GetTemporaryDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetTemporaryDirectory"), typeof(_Engine_GetTemporaryDirectory));
            }

            return _Engine_GetTemporaryDirectoryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetTemporaryFileName();
         private static _Engine_GetTemporaryFileName _Engine_GetTemporaryFileNameFunc;
         internal static IntPtr Engine_GetTemporaryFileName()
         {
            if (_Engine_GetTemporaryFileNameFunc == null)
            {
               _Engine_GetTemporaryFileNameFunc =
                  (_Engine_GetTemporaryFileName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetTemporaryFileName"), typeof(_Engine_GetTemporaryFileName));
            }

            return _Engine_GetTemporaryFileNameFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetUserDataDirectory();
         private static _Engine_GetUserDataDirectory _Engine_GetUserDataDirectoryFunc;
         internal static IntPtr Engine_GetUserDataDirectory()
         {
            if (_Engine_GetUserDataDirectoryFunc == null)
            {
               _Engine_GetUserDataDirectoryFunc =
                  (_Engine_GetUserDataDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetUserDataDirectory"), typeof(_Engine_GetUserDataDirectory));
            }

            return _Engine_GetUserDataDirectoryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetUserHomeDirectory();
         private static _Engine_GetUserHomeDirectory _Engine_GetUserHomeDirectoryFunc;
         internal static IntPtr Engine_GetUserHomeDirectory()
         {
            if (_Engine_GetUserHomeDirectoryFunc == null)
            {
               _Engine_GetUserHomeDirectoryFunc =
                  (_Engine_GetUserHomeDirectory)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetUserHomeDirectory"), typeof(_Engine_GetUserHomeDirectory));
            }

            return _Engine_GetUserHomeDirectoryFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_SetMainDotCsDir(string csDir);
         private static _Engine_SetMainDotCsDir _Engine_SetMainDotCsDirFunc;
         internal static void Engine_SetMainDotCsDir(string csDir)
         {
            if (_Engine_SetMainDotCsDirFunc == null)
            {
               _Engine_SetMainDotCsDirFunc =
                  (_Engine_SetMainDotCsDir)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetMainDotCsDir"), typeof(_Engine_SetMainDotCsDir));
            }

            _Engine_SetMainDotCsDirFunc(csDir);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_ActivateKeyboard();
         private static _Engine_ActivateKeyboard _Engine_ActivateKeyboardFunc;
         internal static bool Engine_ActivateKeyboard()
         {
            if (_Engine_ActivateKeyboardFunc == null)
            {
               _Engine_ActivateKeyboardFunc =
                  (_Engine_ActivateKeyboard)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ActivateKeyboard"), typeof(_Engine_ActivateKeyboard));
            }

            return _Engine_ActivateKeyboardFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DeactivateKeyboard();
         private static _Engine_DeactivateKeyboard _Engine_DeactivateKeyboardFunc;
         internal static void Engine_DeactivateKeyboard()
         {
            if (_Engine_DeactivateKeyboardFunc == null)
            {
               _Engine_DeactivateKeyboardFunc =
                  (_Engine_DeactivateKeyboard)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DeactivateKeyboard"), typeof(_Engine_DeactivateKeyboard));
            }

            _Engine_DeactivateKeyboardFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_EnableMouse();
         private static _Engine_EnableMouse _Engine_EnableMouseFunc;
         internal static void Engine_EnableMouse()
         {
            if (_Engine_EnableMouseFunc == null)
            {
               _Engine_EnableMouseFunc =
                  (_Engine_EnableMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableMouse"), typeof(_Engine_EnableMouse));
            }

            _Engine_EnableMouseFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DisableMouse();
         private static _Engine_DisableMouse _Engine_DisableMouseFunc;
         internal static void Engine_DisableMouse()
         {
            if (_Engine_DisableMouseFunc == null)
            {
               _Engine_DisableMouseFunc =
                  (_Engine_DisableMouse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DisableMouse"), typeof(_Engine_DisableMouse));
            }

            _Engine_DisableMouseFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_EnableJoystick();
         private static _Engine_EnableJoystick _Engine_EnableJoystickFunc;
         internal static bool Engine_EnableJoystick()
         {
            if (_Engine_EnableJoystickFunc == null)
            {
               _Engine_EnableJoystickFunc =
                  (_Engine_EnableJoystick)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableJoystick"), typeof(_Engine_EnableJoystick));
            }

            return _Engine_EnableJoystickFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DisableJoystick();
         private static _Engine_DisableJoystick _Engine_DisableJoystickFunc;
         internal static void Engine_DisableJoystick()
         {
            if (_Engine_DisableJoystickFunc == null)
            {
               _Engine_DisableJoystickFunc =
                  (_Engine_DisableJoystick)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DisableJoystick"), typeof(_Engine_DisableJoystick));
            }

            _Engine_DisableJoystickFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_EchoInputState();
         private static _Engine_EchoInputState _Engine_EchoInputStateFunc;
         internal static void Engine_EchoInputState()
         {
            if (_Engine_EchoInputStateFunc == null)
            {
               _Engine_EchoInputStateFunc =
                  (_Engine_EchoInputState)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EchoInputState"), typeof(_Engine_EchoInputState));
            }

            _Engine_EchoInputStateFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_EnableXInput();
         private static _Engine_EnableXInput _Engine_EnableXInputFunc;
         internal static bool Engine_EnableXInput()
         {
            if (_Engine_EnableXInputFunc == null)
            {
               _Engine_EnableXInputFunc =
                  (_Engine_EnableXInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableXInput"), typeof(_Engine_EnableXInput));
            }

            return _Engine_EnableXInputFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DisableXInput();
         private static _Engine_DisableXInput _Engine_DisableXInputFunc;
         internal static void Engine_DisableXInput()
         {
            if (_Engine_DisableXInputFunc == null)
            {
               _Engine_DisableXInputFunc =
                  (_Engine_DisableXInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DisableXInput"), typeof(_Engine_DisableXInput));
            }

            _Engine_DisableXInputFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_ResetXInput();
         private static _Engine_ResetXInput _Engine_ResetXInputFunc;
         internal static void Engine_ResetXInput()
         {
            if (_Engine_ResetXInputFunc == null)
            {
               _Engine_ResetXInputFunc =
                  (_Engine_ResetXInput)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ResetXInput"), typeof(_Engine_ResetXInput));
            }

            _Engine_ResetXInputFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsXInputConnected(int controllerID);
         private static _Engine_IsXInputConnected _Engine_IsXInputConnectedFunc;
         internal static bool Engine_IsXInputConnected(int controllerID)
         {
            if (_Engine_IsXInputConnectedFunc == null)
            {
               _Engine_IsXInputConnectedFunc =
                  (_Engine_IsXInputConnected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsXInputConnected"), typeof(_Engine_IsXInputConnected));
            }

            return _Engine_IsXInputConnectedFunc(controllerID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetXInputState(int controllerID, string prop, bool current);
         private static _Engine_GetXInputState _Engine_GetXInputStateFunc;
         internal static int Engine_GetXInputState(int controllerID, string prop, bool current)
         {
            if (_Engine_GetXInputStateFunc == null)
            {
               _Engine_GetXInputStateFunc =
                  (_Engine_GetXInputState)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetXInputState"), typeof(_Engine_GetXInputState));
            }

            return _Engine_GetXInputStateFunc(controllerID, prop, current);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_Rumble(string device, float xRumble, float yRumble);
         private static _Engine_Rumble _Engine_RumbleFunc;
         internal static void Engine_Rumble(string device, float xRumble, float yRumble)
         {
            if (_Engine_RumbleFunc == null)
            {
               _Engine_RumbleFunc =
                  (_Engine_Rumble)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_Rumble"), typeof(_Engine_Rumble));
            }

            _Engine_RumbleFunc(device, xRumble, yRumble);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetNetPort(int port);
         private static _Engine_SetNetPort _Engine_SetNetPortFunc;
         internal static bool Engine_SetNetPort(int port)
         {
            if (_Engine_SetNetPortFunc == null)
            {
               _Engine_SetNetPortFunc =
                  (_Engine_SetNetPort)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetNetPort"), typeof(_Engine_SetNetPort));
            }

            return _Engine_SetNetPortFunc(port);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_CloseNetPort();
         private static _Engine_CloseNetPort _Engine_CloseNetPortFunc;
         internal static void Engine_CloseNetPort()
         {
            if (_Engine_CloseNetPortFunc == null)
            {
               _Engine_CloseNetPortFunc =
                  (_Engine_CloseNetPort)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CloseNetPort"), typeof(_Engine_CloseNetPort));
            }

            _Engine_CloseNetPortFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_StripChars(string sourceString, string chars);
         private static _Engine_StripChars _Engine_StripCharsFunc;
         internal static IntPtr Engine_StripChars(string sourceString, string chars)
         {
            if (_Engine_StripCharsFunc == null)
            {
               _Engine_StripCharsFunc =
                  (_Engine_StripChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StripChars"), typeof(_Engine_StripChars));
            }

            return _Engine_StripCharsFunc(sourceString, chars);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_StripColorCodes(string sourceString, string chars);
         private static _Engine_StripColorCodes _Engine_StripColorCodesFunc;
         internal static IntPtr Engine_StripColorCodes(string sourceString, string chars)
         {
            if (_Engine_StripColorCodesFunc == null)
            {
               _Engine_StripColorCodesFunc =
                  (_Engine_StripColorCodes)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_StripColorCodes"), typeof(_Engine_StripColorCodes));
            }

            return _Engine_StripColorCodesFunc(sourceString, chars);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetDisplayDevice(string deviceName, uint width, uint height, uint bpp, bool fullScreen);
         private static _Engine_SetDisplayDevice _Engine_SetDisplayDeviceFunc;
         internal static bool Engine_SetDisplayDevice(string deviceName, uint width, uint height, uint bpp, bool fullScreen)
         {
            if (_Engine_SetDisplayDeviceFunc == null)
            {
               _Engine_SetDisplayDeviceFunc =
                  (_Engine_SetDisplayDevice)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetDisplayDevice"), typeof(_Engine_SetDisplayDevice));
            }

            return _Engine_SetDisplayDeviceFunc(deviceName, width, height, bpp, fullScreen);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetScreenMode(uint width, uint height, uint bpp, bool fullScreen);
         private static _Engine_SetScreenMode _Engine_SetScreenModeFunc;
         internal static bool Engine_SetScreenMode(uint width, uint height, uint bpp, bool fullScreen)
         {
            if (_Engine_SetScreenModeFunc == null)
            {
               _Engine_SetScreenModeFunc =
                  (_Engine_SetScreenMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetScreenMode"), typeof(_Engine_SetScreenMode));
            }

            return _Engine_SetScreenModeFunc(width, height, bpp, fullScreen);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_ToggleFullScreen();
         private static _Engine_ToggleFullScreen _Engine_ToggleFullScreenFunc;
         internal static bool Engine_ToggleFullScreen()
         {
            if (_Engine_ToggleFullScreenFunc == null)
            {
               _Engine_ToggleFullScreenFunc =
                  (_Engine_ToggleFullScreen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ToggleFullScreen"), typeof(_Engine_ToggleFullScreen));
            }

            return _Engine_ToggleFullScreenFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsFullScreen();
         private static _Engine_IsFullScreen _Engine_IsFullScreenFunc;
         internal static bool Engine_IsFullScreen()
         {
            if (_Engine_IsFullScreenFunc == null)
            {
               _Engine_IsFullScreenFunc =
                  (_Engine_IsFullScreen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsFullScreen"), typeof(_Engine_IsFullScreen));
            }

            return _Engine_IsFullScreenFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SwitchBitDepth();
         private static _Engine_SwitchBitDepth _Engine_SwitchBitDepthFunc;
         internal static bool Engine_SwitchBitDepth()
         {
            if (_Engine_SwitchBitDepthFunc == null)
            {
               _Engine_SwitchBitDepthFunc =
                  (_Engine_SwitchBitDepth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SwitchBitDepth"), typeof(_Engine_SwitchBitDepth));
            }

            return _Engine_SwitchBitDepthFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_PrevResolution();
         private static _Engine_PrevResolution _Engine_PrevResolutionFunc;
         internal static bool Engine_PrevResolution()
         {
            if (_Engine_PrevResolutionFunc == null)
            {
               _Engine_PrevResolutionFunc =
                  (_Engine_PrevResolution)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_PrevResolution"), typeof(_Engine_PrevResolution));
            }

            return _Engine_PrevResolutionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_NextResolution();
         private static _Engine_NextResolution _Engine_NextResolutionFunc;
         internal static bool Engine_NextResolution()
         {
            if (_Engine_NextResolutionFunc == null)
            {
               _Engine_NextResolutionFunc =
                  (_Engine_NextResolution)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_NextResolution"), typeof(_Engine_NextResolution));
            }

            return _Engine_NextResolutionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetResolution();
         private static _Engine_GetResolution _Engine_GetResolutionFunc;
         internal static IntPtr Engine_GetResolution()
         {
            if (_Engine_GetResolutionFunc == null)
            {
               _Engine_GetResolutionFunc =
                  (_Engine_GetResolution)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetResolution"), typeof(_Engine_GetResolution));
            }

            return _Engine_GetResolutionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetResolution(uint width, uint height, uint bpp);
         private static _Engine_SetResolution _Engine_SetResolutionFunc;
         internal static bool Engine_SetResolution(uint width, uint height, uint bpp)
         {
            if (_Engine_SetResolutionFunc == null)
            {
               _Engine_SetResolutionFunc =
                  (_Engine_SetResolution)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetResolution"), typeof(_Engine_SetResolution));
            }

            return _Engine_SetResolutionFunc(width, height, bpp);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetDesktopResolution();
         private static _Engine_GetDesktopResolution _Engine_GetDesktopResolutionFunc;
         internal static IntPtr Engine_GetDesktopResolution()
         {
            if (_Engine_GetDesktopResolutionFunc == null)
            {
               _Engine_GetDesktopResolutionFunc =
                  (_Engine_GetDesktopResolution)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetDesktopResolution"), typeof(_Engine_GetDesktopResolution));
            }

            return _Engine_GetDesktopResolutionFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetDisplayDeviceList();
         private static _Engine_GetDisplayDeviceList _Engine_GetDisplayDeviceListFunc;
         internal static IntPtr Engine_GetDisplayDeviceList()
         {
            if (_Engine_GetDisplayDeviceListFunc == null)
            {
               _Engine_GetDisplayDeviceListFunc =
                  (_Engine_GetDisplayDeviceList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetDisplayDeviceList"), typeof(_Engine_GetDisplayDeviceList));
            }

            return _Engine_GetDisplayDeviceListFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetResolutionList(string deviceName);
         private static _Engine_GetResolutionList _Engine_GetResolutionListFunc;
         internal static IntPtr Engine_GetResolutionList(string deviceName)
         {
            if (_Engine_GetResolutionListFunc == null)
            {
               _Engine_GetResolutionListFunc =
                  (_Engine_GetResolutionList)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetResolutionList"), typeof(_Engine_GetResolutionList));
            }

            return _Engine_GetResolutionListFunc(deviceName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetVideoDriverInfo();
         private static _Engine_GetVideoDriverInfo _Engine_GetVideoDriverInfoFunc;
         internal static IntPtr Engine_GetVideoDriverInfo()
         {
            if (_Engine_GetVideoDriverInfoFunc == null)
            {
               _Engine_GetVideoDriverInfoFunc =
                  (_Engine_GetVideoDriverInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetVideoDriverInfo"), typeof(_Engine_GetVideoDriverInfo));
            }

            return _Engine_GetVideoDriverInfoFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsDeviceFullScreenOnly(string deviceName);
         private static _Engine_IsDeviceFullScreenOnly _Engine_IsDeviceFullScreenOnlyFunc;
         internal static bool Engine_IsDeviceFullScreenOnly(string deviceName)
         {
            if (_Engine_IsDeviceFullScreenOnlyFunc == null)
            {
               _Engine_IsDeviceFullScreenOnlyFunc =
                  (_Engine_IsDeviceFullScreenOnly)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsDeviceFullScreenOnly"), typeof(_Engine_IsDeviceFullScreenOnly));
            }

            return _Engine_IsDeviceFullScreenOnlyFunc(deviceName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_VideoSetGammaCorrection(float gamma);
         private static _Engine_VideoSetGammaCorrection _Engine_VideoSetGammaCorrectionFunc;
         internal static void Engine_VideoSetGammaCorrection(float gamma)
         {
            if (_Engine_VideoSetGammaCorrectionFunc == null)
            {
               _Engine_VideoSetGammaCorrectionFunc =
                  (_Engine_VideoSetGammaCorrection)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_VideoSetGammaCorrection"), typeof(_Engine_VideoSetGammaCorrection));
            }

            _Engine_VideoSetGammaCorrectionFunc(gamma);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetVerticalSync(bool enable);
         private static _Engine_SetVerticalSync _Engine_SetVerticalSyncFunc;
         internal static bool Engine_SetVerticalSync(bool enable)
         {
            if (_Engine_SetVerticalSyncFunc == null)
            {
               _Engine_SetVerticalSyncFunc =
                  (_Engine_SetVerticalSync)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetVerticalSync"), typeof(_Engine_SetVerticalSync));
            }

            return _Engine_SetVerticalSyncFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_MinimizeWindow();
         private static _Engine_MinimizeWindow _Engine_MinimizeWindowFunc;
         internal static void Engine_MinimizeWindow()
         {
            if (_Engine_MinimizeWindowFunc == null)
            {
               _Engine_MinimizeWindowFunc =
                  (_Engine_MinimizeWindow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MinimizeWindow"), typeof(_Engine_MinimizeWindow));
            }

            _Engine_MinimizeWindowFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_RestoreWindow();
         private static _Engine_RestoreWindow _Engine_RestoreWindowFunc;
         internal static void Engine_RestoreWindow()
         {
            if (_Engine_RestoreWindowFunc == null)
            {
               _Engine_RestoreWindowFunc =
                  (_Engine_RestoreWindow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RestoreWindow"), typeof(_Engine_RestoreWindow));
            }

            _Engine_RestoreWindowFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_SetMouseLock(bool enable);
         private static _Engine_SetMouseLock _Engine_SetMouseLockFunc;
         internal static void Engine_SetMouseLock(bool enable)
         {
            if (_Engine_SetMouseLockFunc == null)
            {
               _Engine_SetMouseLockFunc =
                  (_Engine_SetMouseLock)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetMouseLock"), typeof(_Engine_SetMouseLock));
            }

            _Engine_SetMouseLockFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetRealTime();
         private static _Engine_GetRealTime _Engine_GetRealTimeFunc;
         internal static int Engine_GetRealTime()
         {
            if (_Engine_GetRealTimeFunc == null)
            {
               _Engine_GetRealTimeFunc =
                  (_Engine_GetRealTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetRealTime"), typeof(_Engine_GetRealTime));
            }

            return _Engine_GetRealTimeFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetLocalTime();
         private static _Engine_GetLocalTime _Engine_GetLocalTimeFunc;
         internal static IntPtr Engine_GetLocalTime()
         {
            if (_Engine_GetLocalTimeFunc == null)
            {
               _Engine_GetLocalTimeFunc =
                  (_Engine_GetLocalTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetLocalTime"), typeof(_Engine_GetLocalTime));
            }

            return _Engine_GetLocalTimeFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetClipboard();
         private static _Engine_GetClipboard _Engine_GetClipboardFunc;
         internal static IntPtr Engine_GetClipboard()
         {
            if (_Engine_GetClipboardFunc == null)
            {
               _Engine_GetClipboardFunc =
                  (_Engine_GetClipboard)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetClipboard"), typeof(_Engine_GetClipboard));
            }

            return _Engine_GetClipboardFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SetClipboard(string val);
         private static _Engine_SetClipboard _Engine_SetClipboardFunc;
         internal static bool Engine_SetClipboard(string val)
         {
            if (_Engine_SetClipboardFunc == null)
            {
               _Engine_SetClipboardFunc =
                  (_Engine_SetClipboard)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SetClipboard"), typeof(_Engine_SetClipboard));
            }

            return _Engine_SetClipboardFunc(val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_CreateUUID();
         private static _Engine_CreateUUID _Engine_CreateUUIDFunc;
         internal static IntPtr Engine_CreateUUID()
         {
            if (_Engine_CreateUUIDFunc == null)
            {
               _Engine_CreateUUIDFunc =
                  (_Engine_CreateUUID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CreateUUID"), typeof(_Engine_CreateUUID));
            }

            return _Engine_CreateUUIDFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_MessageBox(string title, string message, string buttons, string icon);
         private static _Engine_MessageBox _Engine_MessageBoxFunc;
         internal static int Engine_MessageBox(string title, string message, string buttons, string icon)
         {
            if (_Engine_MessageBoxFunc == null)
            {
               _Engine_MessageBoxFunc =
                  (_Engine_MessageBox)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MessageBox"), typeof(_Engine_MessageBox));
            }

            return _Engine_MessageBoxFunc(title, message, buttons, icon);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_InitDisplayDeviceInfo();
         private static _Engine_InitDisplayDeviceInfo _Engine_InitDisplayDeviceInfoFunc;
         internal static void Engine_InitDisplayDeviceInfo()
         {
            if (_Engine_InitDisplayDeviceInfoFunc == null)
            {
               _Engine_InitDisplayDeviceInfoFunc =
                  (_Engine_InitDisplayDeviceInfo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_InitDisplayDeviceInfo"), typeof(_Engine_InitDisplayDeviceInfo));
            }

            _Engine_InitDisplayDeviceInfoFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_EnableWinConsole(bool enable);
         private static _Engine_EnableWinConsole _Engine_EnableWinConsoleFunc;
         internal static void Engine_EnableWinConsole(bool enable)
         {
            if (_Engine_EnableWinConsoleFunc == null)
            {
               _Engine_EnableWinConsoleFunc =
                  (_Engine_EnableWinConsole)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_EnableWinConsole"), typeof(_Engine_EnableWinConsole));
            }

            _Engine_EnableWinConsoleFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_ShellExecute(string executable, string args, string directory);
         private static _Engine_ShellExecute _Engine_ShellExecuteFunc;
         internal static bool Engine_ShellExecute(string executable, string args, string directory)
         {
            if (_Engine_ShellExecuteFunc == null)
            {
               _Engine_ShellExecuteFunc =
                  (_Engine_ShellExecute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ShellExecute"), typeof(_Engine_ShellExecute));
            }

            return _Engine_ShellExecuteFunc(executable, args, directory);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_ShellExecuteBlocking(string executable, string args, string directory);
         private static _Engine_ShellExecuteBlocking _Engine_ShellExecuteBlockingFunc;
         internal static bool Engine_ShellExecuteBlocking(string executable, string args, string directory)
         {
            if (_Engine_ShellExecuteBlockingFunc == null)
            {
               _Engine_ShellExecuteBlockingFunc =
                  (_Engine_ShellExecuteBlocking)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_ShellExecuteBlocking"), typeof(_Engine_ShellExecuteBlocking));
            }

            return _Engine_ShellExecuteBlockingFunc(executable, args, directory);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_GLEnableLogging(bool enable);
         private static _Engine_GLEnableLogging _Engine_GLEnableLoggingFunc;
         internal static void Engine_GLEnableLogging(bool enable)
         {
            if (_Engine_GLEnableLoggingFunc == null)
            {
               _Engine_GLEnableLoggingFunc =
                  (_Engine_GLEnableLogging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GLEnableLogging"), typeof(_Engine_GLEnableLogging));
            }

            _Engine_GLEnableLoggingFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_GLEnableOutline(bool enable);
         private static _Engine_GLEnableOutline _Engine_GLEnableOutlineFunc;
         internal static void Engine_GLEnableOutline(bool enable)
         {
            if (_Engine_GLEnableOutlineFunc == null)
            {
               _Engine_GLEnableOutlineFunc =
                  (_Engine_GLEnableOutline)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GLEnableOutline"), typeof(_Engine_GLEnableOutline));
            }

            _Engine_GLEnableOutlineFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_GLEnableMetrics(bool enable);
         private static _Engine_GLEnableMetrics _Engine_GLEnableMetricsFunc;
         internal static void Engine_GLEnableMetrics(bool enable)
         {
            if (_Engine_GLEnableMetricsFunc == null)
            {
               _Engine_GLEnableMetricsFunc =
                  (_Engine_GLEnableMetrics)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GLEnableMetrics"), typeof(_Engine_GLEnableMetrics));
            }

            _Engine_GLEnableMetricsFunc(enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsJoystickDetected();
         private static _Engine_IsJoystickDetected _Engine_IsJoystickDetectedFunc;
         internal static bool Engine_IsJoystickDetected()
         {
            if (_Engine_IsJoystickDetectedFunc == null)
            {
               _Engine_IsJoystickDetectedFunc =
                  (_Engine_IsJoystickDetected)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsJoystickDetected"), typeof(_Engine_IsJoystickDetected));
            }

            return _Engine_IsJoystickDetectedFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_GetJoystickAxes(int instance);
         private static _Engine_GetJoystickAxes _Engine_GetJoystickAxesFunc;
         internal static IntPtr Engine_GetJoystickAxes(int instance)
         {
            if (_Engine_GetJoystickAxesFunc == null)
            {
               _Engine_GetJoystickAxesFunc =
                  (_Engine_GetJoystickAxes)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetJoystickAxes"), typeof(_Engine_GetJoystickAxes));
            }

            return _Engine_GetJoystickAxesFunc(instance);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetJoystickCount();
         private static _Engine_GetJoystickCount _Engine_GetJoystickCountFunc;
         internal static int Engine_GetJoystickCount()
         {
            if (_Engine_GetJoystickCountFunc == null)
            {
               _Engine_GetJoystickCountFunc =
                  (_Engine_GetJoystickCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetJoystickCount"), typeof(_Engine_GetJoystickCount));
            }

            return _Engine_GetJoystickCountFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_MathInit(int argc, string[] argv);
         private static _Engine_MathInit _Engine_MathInitFunc;
         internal static void Engine_MathInit(int argc, string[] argv)
         {
            if (_Engine_MathInitFunc == null)
            {
               _Engine_MathInitFunc =
                  (_Engine_MathInit)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_MathInit"), typeof(_Engine_MathInit));
            }

            _Engine_MathInitFunc(argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetSimTime();
         private static _Engine_GetSimTime _Engine_GetSimTimeFunc;
         internal static int Engine_GetSimTime()
         {
            if (_Engine_GetSimTimeFunc == null)
            {
               _Engine_GetSimTimeFunc =
                  (_Engine_GetSimTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetSimTime"), typeof(_Engine_GetSimTime));
            }

            return _Engine_GetSimTimeFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_Cancel(int eventID);
         private static _Engine_Cancel _Engine_CancelFunc;
         internal static void Engine_Cancel(int eventID)
         {
            if (_Engine_CancelFunc == null)
            {
               _Engine_CancelFunc =
                  (_Engine_Cancel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_Cancel"), typeof(_Engine_Cancel));
            }

            _Engine_CancelFunc(eventID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsEventPending(int eventID);
         private static _Engine_IsEventPending _Engine_IsEventPendingFunc;
         internal static bool Engine_IsEventPending(int eventID)
         {
            if (_Engine_IsEventPendingFunc == null)
            {
               _Engine_IsEventPendingFunc =
                  (_Engine_IsEventPending)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsEventPending"), typeof(_Engine_IsEventPending));
            }

            return _Engine_IsEventPendingFunc(eventID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetEventTimeLeft(int eventID);
         private static _Engine_GetEventTimeLeft _Engine_GetEventTimeLeftFunc;
         internal static int Engine_GetEventTimeLeft(int eventID)
         {
            if (_Engine_GetEventTimeLeftFunc == null)
            {
               _Engine_GetEventTimeLeftFunc =
                  (_Engine_GetEventTimeLeft)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetEventTimeLeft"), typeof(_Engine_GetEventTimeLeft));
            }

            return _Engine_GetEventTimeLeftFunc(eventID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetScheduleDuration(int eventID);
         private static _Engine_GetScheduleDuration _Engine_GetScheduleDurationFunc;
         internal static int Engine_GetScheduleDuration(int eventID)
         {
            if (_Engine_GetScheduleDurationFunc == null)
            {
               _Engine_GetScheduleDurationFunc =
                  (_Engine_GetScheduleDuration)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetScheduleDuration"), typeof(_Engine_GetScheduleDuration));
            }

            return _Engine_GetScheduleDurationFunc(eventID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_GetTimeSinceStart(int eventID);
         private static _Engine_GetTimeSinceStart _Engine_GetTimeSinceStartFunc;
         internal static int Engine_GetTimeSinceStart(int eventID)
         {
            if (_Engine_GetTimeSinceStartFunc == null)
            {
               _Engine_GetTimeSinceStartFunc =
                  (_Engine_GetTimeSinceStart)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_GetTimeSinceStart"), typeof(_Engine_GetTimeSinceStart));
            }

            return _Engine_GetTimeSinceStartFunc(eventID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_Schedule(uint timeDelta, IntPtr refObject, string functionName, int argc, string[] argv);
         private static _Engine_Schedule _Engine_ScheduleFunc;
         internal static int Engine_Schedule(uint timeDelta, IntPtr refObject, string functionName, int argc, string[] argv)
         {
            if (_Engine_ScheduleFunc == null)
            {
               _Engine_ScheduleFunc =
                  (_Engine_Schedule)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_Schedule"), typeof(_Engine_Schedule));
            }

            return _Engine_ScheduleFunc(timeDelta, refObject, functionName, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsObjectByName(string handle);
         private static _Engine_IsObjectByName _Engine_IsObjectByNameFunc;
         internal static bool Engine_IsObjectByName(string handle)
         {
            if (_Engine_IsObjectByNameFunc == null)
            {
               _Engine_IsObjectByNameFunc =
                  (_Engine_IsObjectByName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsObjectByName"), typeof(_Engine_IsObjectByName));
            }

            return _Engine_IsObjectByNameFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_IsObjectByID(int handle);
         private static _Engine_IsObjectByID _Engine_IsObjectByIDFunc;
         internal static bool Engine_IsObjectByID(int handle)
         {
            if (_Engine_IsObjectByIDFunc == null)
            {
               _Engine_IsObjectByIDFunc =
                  (_Engine_IsObjectByID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_IsObjectByID"), typeof(_Engine_IsObjectByID));
            }

            return _Engine_IsObjectByIDFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_DeleteDataBlocks();
         private static _Engine_DeleteDataBlocks _Engine_DeleteDataBlocksFunc;
         internal static void Engine_DeleteDataBlocks()
         {
            if (_Engine_DeleteDataBlocksFunc == null)
            {
               _Engine_DeleteDataBlocksFunc =
                  (_Engine_DeleteDataBlocks)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_DeleteDataBlocks"), typeof(_Engine_DeleteDataBlocks));
            }

            _Engine_DeleteDataBlocksFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Engine_SaveObject(IntPtr obj, string filename);
         private static _Engine_SaveObject _Engine_SaveObjectFunc;
         internal static bool Engine_SaveObject(IntPtr obj, string filename)
         {
            if (_Engine_SaveObjectFunc == null)
            {
               _Engine_SaveObjectFunc =
                  (_Engine_SaveObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_SaveObject"), typeof(_Engine_SaveObject));
            }

            return _Engine_SaveObjectFunc(obj, filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Engine_LoadObject(string filename);
         private static _Engine_LoadObject _Engine_LoadObjectFunc;
         internal static IntPtr Engine_LoadObject(string filename)
         {
            if (_Engine_LoadObjectFunc == null)
            {
               _Engine_LoadObjectFunc =
                  (_Engine_LoadObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_LoadObject"), typeof(_Engine_LoadObject));
            }

            return _Engine_LoadObjectFunc(filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_CopyBehaviorToComponent(IntPtr behavior, IntPtr component);
         private static _Engine_CopyBehaviorToComponent _Engine_CopyBehaviorToComponentFunc;
         internal static void Engine_CopyBehaviorToComponent(IntPtr behavior, IntPtr component)
         {
            if (_Engine_CopyBehaviorToComponentFunc == null)
            {
               _Engine_CopyBehaviorToComponentFunc =
                  (_Engine_CopyBehaviorToComponent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_CopyBehaviorToComponent"), typeof(_Engine_CopyBehaviorToComponent));
            }

            _Engine_CopyBehaviorToComponentFunc(behavior, component);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_sbmDumpStats();
         private static _Engine_sbmDumpStats _Engine_sbmDumpStatsFunc;
         internal static void Engine_sbmDumpStats()
         {
            if (_Engine_sbmDumpStatsFunc == null)
            {
               _Engine_sbmDumpStatsFunc =
                  (_Engine_sbmDumpStats)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_sbmDumpStats"), typeof(_Engine_sbmDumpStats));
            }

            _Engine_sbmDumpStatsFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Engine_sbmDumpStrings();
         private static _Engine_sbmDumpStrings _Engine_sbmDumpStringsFunc;
         internal static void Engine_sbmDumpStrings()
         {
            if (_Engine_sbmDumpStringsFunc == null)
            {
               _Engine_sbmDumpStringsFunc =
                  (_Engine_sbmDumpStrings)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_sbmDumpStrings"), typeof(_Engine_sbmDumpStrings));
            }

            _Engine_sbmDumpStringsFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Engine_RunAllUnitTests();
         private static _Engine_RunAllUnitTests _Engine_RunAllUnitTestsFunc;
         internal static int Engine_RunAllUnitTests()
         {
            if (_Engine_RunAllUnitTestsFunc == null)
            {
               _Engine_RunAllUnitTestsFunc =
                  (_Engine_RunAllUnitTests)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Engine_RunAllUnitTests"), typeof(_Engine_RunAllUnitTests));
            }

            return _Engine_RunAllUnitTestsFunc();
         }
      }

      #endregion
      
      #region Functions

      public static void DebugBreak()
      {
         InternalUnsafeMethods.Engine_DebugBreak();
      }

      public static string GetAppleDeviceIPAddress()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetAppleDeviceIPAddress());
      }

      public static void Quit()
      {
         InternalUnsafeMethods.Engine_Quit();
      }

      public static void QuitWithErrorMessage(string msg)
      {
         InternalUnsafeMethods.Engine_QuitWithErrorMessage(msg);
      }

      public static string Detag(int tagId)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_Detag(tagId));
      }

      public static string GetTag(string taggedString)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetTag(taggedString));
      }

      public static int GetStockColorCount()
      {
         return InternalUnsafeMethods.Engine_GetStockColorCount();
      }

      public static string GetStockColorName(int index)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetStockColorName(index));
      }

      public static bool IsStockColor(string name)
      {
         return InternalUnsafeMethods.Engine_IsStockColor(name);
      }

      public static Color GetStockColor(string name)
      {
         return InternalUnsafeMethods.Engine_GetStockColor(name);
      }

      public static bool CaptureScreenArea(int posX, int posY, uint width, uint height, string fileName, string fileType)
      {
         return InternalUnsafeMethods.Engine_CaptureScreenArea(posX, posY, width, height, fileName, fileType);
      }

      public static bool PNG2JPG(string bmpname, uint quality)
      {
         return InternalUnsafeMethods.Engine_PNG2JPG(bmpname, quality);
      }

      public static void ShowStats(bool enable)
      {
         InternalUnsafeMethods.Engine_ShowStats(enable);
      }

      public static void PopulateFontCacheString(string faceName, int size, string str)
      {
         InternalUnsafeMethods.Engine_PopulateFontCacheString(faceName, size, str);
      }

      public static void PopulateFontCacheRange(string faceName, int size, int rangeStart, int rangeEnd)
      {
         InternalUnsafeMethods.Engine_PopulateFontCacheRange(faceName, size, rangeStart, rangeEnd);
      }

      public static void DumpFontCacheStatus()
      {
         InternalUnsafeMethods.Engine_DumpFontCacheStatus();
      }

      public static void WriteFontCache()
      {
         InternalUnsafeMethods.Engine_WriteFontCache();
      }

      public static void PopulateAllFontCacheString(string inString)
      {
         InternalUnsafeMethods.Engine_PopulateAllFontCacheString(inString);
      }

      public static void PopulateAllFontCacheRange(int rangeStart, int rangeEnd)
      {
         InternalUnsafeMethods.Engine_PopulateAllFontCacheRange(rangeStart, rangeEnd);
      }

      public static void ExportCachedFont(string fontName, int size, string fileName, int padding, int kerning)
      {
         InternalUnsafeMethods.Engine_ExportCachedFont(fontName, size, fileName, padding, kerning);
      }

      public static void ImportCachedFont(string fontName, int size, string fileName, int padding, int kerning)
      {
         InternalUnsafeMethods.Engine_ImportCachedFont(fontName, size, fileName, padding, kerning);
      }

      public static void DuplicateCachedFont(string oldFontName, int oldFontSize, string newFontName, int newFontSize)
      {
         InternalUnsafeMethods.Engine_DuplicateCachedFont(oldFontName, oldFontSize, newFontName, newFontSize);
      }

      public static string MaterialAssetGetTextureFile(TextureAsset textureAsset)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_MaterialAssetGetTextureFile(textureAsset.ObjectPtr->ObjPtr));
      }

      public static void FlushTextureCache()
      {
         InternalUnsafeMethods.Engine_FlushTextureCache();
      }

      public static void DumpTextureManagerMetrics()
      {
         InternalUnsafeMethods.Engine_DumpTextureManagerMetrics();
      }

      public static bool CreateCanvas(string windowTitle)
      {
         return InternalUnsafeMethods.Engine_CreateCanvas(windowTitle);
      }

      public static void SetCanvasTitle(string windowTitle)
      {
         InternalUnsafeMethods.Engine_SetCanvasTitle(windowTitle);
      }

      public static void ScreenShot(string file, string format)
      {
         InternalUnsafeMethods.Engine_ScreenShot(file, format);
      }

      public static string StripMLControlChars(string sourceString)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_StripMLControlChars(sourceString));
      }

      public static void InitLeapMotionManager()
      {
         InternalUnsafeMethods.Engine_InitLeapMotionManager();
      }

      public static void EnableLeapMotionManager(bool enable)
      {
         InternalUnsafeMethods.Engine_EnableLeapMotionManager(enable);
      }

      public static bool IsLeapMotionManagerEnabled()
      {
         return InternalUnsafeMethods.Engine_IsLeapMotionManagerEnabled();
      }

      public static void EnableLeapCursorControl(bool enable)
      {
         InternalUnsafeMethods.Engine_EnableLeapCursorControl(enable);
      }

      public static bool IsLeapCursorControlled()
      {
         return InternalUnsafeMethods.Engine_IsLeapCursorControlled();
      }

      public static bool ConfigureLeapGesture(string gestureString, float value)
      {
         return InternalUnsafeMethods.Engine_ConfigureLeapGesture(gestureString, value);
      }

      public static void GetPointFromProjection(Point3F pos, Point2F outPos)
      {
         InternalUnsafeMethods.Engine_GetPointFromProjection(pos, outPos);
      }

      public static void GetPointFromIntersection(int fingerID, Point2F outPos)
      {
         InternalUnsafeMethods.Engine_GetPointFromIntersection(fingerID, outPos);
      }

      public static string FindFirstFile(string pattern)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FindFirstFile(pattern));
      }

      public static string FindNextFile(string pattern)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FindNextFile(pattern));
      }

      public static int GetFileCount(string pattern)
      {
         return InternalUnsafeMethods.Engine_GetFileCount(pattern);
      }

      public static string FindFirstFileMultiExpr(string pattern)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FindFirstFileMultiExpr(pattern));
      }

      public static string FindNextFileMultiExpr(string pattern)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FindNextFileMultiExpr(pattern));
      }

      public static int GetFileCountMultiExpr(string pattern)
      {
         return InternalUnsafeMethods.Engine_GetFileCountMultiExpr(pattern);
      }

      public static int GetFileCRC(string fileName)
      {
         return InternalUnsafeMethods.Engine_GetFileCRC(fileName);
      }

      public static bool IsDirectory(string path)
      {
         return InternalUnsafeMethods.Engine_IsDirectory(path);
      }

      public static bool IsFile(string fileName)
      {
         return InternalUnsafeMethods.Engine_IsFile(fileName);
      }

      public static bool IsWriteableFileName(string fileName)
      {
         return InternalUnsafeMethods.Engine_IsWriteableFileName(fileName);
      }

      public static string GetDirectoryList(string dirPath, int depth)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetDirectoryList(dirPath, depth));
      }

      public static string GetFileList(string strPath)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetFileList(strPath));
      }

      public static int FileSize(string fileName)
      {
         return InternalUnsafeMethods.Engine_FileSize(fileName);
      }

      public static bool FileDelete(string fileName)
      {
         return InternalUnsafeMethods.Engine_FileDelete(fileName);
      }

      public static bool DirectoryDelete(string directoryName)
      {
         return InternalUnsafeMethods.Engine_DirectoryDelete(directoryName);
      }

      public static bool IsValidImageFile(string filePath)
      {
         return InternalUnsafeMethods.Engine_IsValidImageFile(filePath);
      }

      public static string FileExt(string fileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FileExt(fileName));
      }

      public static string FileBase(string fileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FileBase(fileName));
      }

      public static string FileName(string fileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FileName(fileName));
      }

      public static string FilePath(string fileName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_FilePath(fileName));
      }

      public static void OpenFolder(string path)
      {
         InternalUnsafeMethods.Engine_OpenFolder(path);
      }

      public static bool PathCopy(string fromFile, string toFile, bool noOverwrite)
      {
         return InternalUnsafeMethods.Engine_PathCopy(fromFile, toFile, noOverwrite);
      }

      public static string GetCurrentDirectory()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetCurrentDirectory());
      }

      public static bool SetCurrentDirectory(string absolutePathName)
      {
         return InternalUnsafeMethods.Engine_SetCurrentDirectory(absolutePathName);
      }

      public static string GetExecutableName()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetExecutableName());
      }

      public static string GetMainDotCsDir()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetMainDotCsDir());
      }

      public static string MakeFullPath(string path, string currentWorkingDirectory)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_MakeFullPath(path, currentWorkingDirectory));
      }

      public static string MakeRelativePath(string path, string to)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_MakeRelativePath(path, to));
      }

      public static string PathConcat(string path, int argc, string[] argv)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_PathConcat(path, argc, argv));
      }

      public static void RestartInstance()
      {
         InternalUnsafeMethods.Engine_RestartInstance();
      }

      public static bool CreatePath(string path)
      {
         return InternalUnsafeMethods.Engine_CreatePath(path);
      }

      public static void DumpResources(bool onlyLoaded)
      {
         InternalUnsafeMethods.Engine_DumpResources(onlyLoaded);
      }

      public static void AddResPath(string path, bool ignoreZips)
      {
         InternalUnsafeMethods.Engine_AddResPath(path, ignoreZips);
      }

      public static void RemoveResPath(string path)
      {
         InternalUnsafeMethods.Engine_RemoveResPath(path);
      }

      public static void SetModPaths(string path)
      {
         InternalUnsafeMethods.Engine_SetModPaths(path);
      }

      public static string GetModPaths()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetModPaths());
      }

      public static void PurgeResources()
      {
         InternalUnsafeMethods.Engine_PurgeResources();
      }

      public static bool IsUsingVFS()
      {
         return InternalUnsafeMethods.Engine_IsUsingVFS();
      }

      public static int GetMaxFrameAllocation()
      {
         return InternalUnsafeMethods.Engine_GetMaxFrameAllocation();
      }

      public static bool IsQueueRegistered(string queueName)
      {
         return InternalUnsafeMethods.Engine_IsQueueRegistered(queueName);
      }

      public static void RegisterMessageQueue(string queueName)
      {
         InternalUnsafeMethods.Engine_RegisterMessageQueue(queueName);
      }

      public static void UnregisterMessageQueue(string queueName)
      {
         InternalUnsafeMethods.Engine_UnregisterMessageQueue(queueName);
      }

      public static bool RegisterMessageListener(string queueName, SimObject listener)
      {
         return InternalUnsafeMethods.Engine_RegisterMessageListener(queueName, listener.ObjectPtr->ObjPtr);
      }

      public static void UnregisterMessageListener(string queueName, SimObject listener)
      {
         InternalUnsafeMethods.Engine_UnregisterMessageListener(queueName, listener.ObjectPtr->ObjPtr);
      }

      public static bool DispatchMessage(string queueName, string evt, string data)
      {
         return InternalUnsafeMethods.Engine_DispatchMessage(queueName, evt, data);
      }

      public static bool DispatchMessageObject(string queueName, Message msgObj)
      {
         return InternalUnsafeMethods.Engine_DispatchMessageObject(queueName, msgObj.ObjectPtr->ObjPtr);
      }

      public static void DNetSetLogging(bool enabled)
      {
         InternalUnsafeMethods.Engine_DNetSetLogging(enabled);
      }

      public static void AllowConnections(bool enable)
      {
         InternalUnsafeMethods.Engine_AllowConnections(enable);
      }

      public static void DumpNetStringTable()
      {
         InternalUnsafeMethods.Engine_DumpNetStringTable();
      }

      public static void CommandToServer(int argc, string[] argv)
      {
         InternalUnsafeMethods.Engine_CommandToServer(argc, argv);
      }

      public static void CommandToClient(NetConnection conn, int argc, string[] argv)
      {
         InternalUnsafeMethods.Engine_CommandToClient(conn.ObjectPtr->ObjPtr, argc, argv);
      }

      public static void RemoveTaggedString(string tag)
      {
         InternalUnsafeMethods.Engine_RemoveTaggedString(tag);
      }

      public static string AddTaggedString(string tag)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_AddTaggedString(tag));
      }

      public static string GetTaggedString(string tag)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetTaggedString(tag));
      }

      public static string BuildTaggedString(string format, int argc, string[] argv)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_BuildTaggedString(format, argc, argv));
      }

      public static void QueryLanServers(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags)
      {
         InternalUnsafeMethods.Engine_QueryLanServers(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
      }

      public static void QueryMasterServer(uint lanPort, byte flags, string gameType, string missionType, byte minPlayers, byte maxPlayers, byte maxBots, uint regionMask, uint maxPing, ushort minCPU, byte filterFlags)
      {
         InternalUnsafeMethods.Engine_QueryMasterServer(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
      }

      public static void QuerySingleServer(string address, byte flags)
      {
         InternalUnsafeMethods.Engine_QuerySingleServer(address, flags);
      }

      public static void CancelServerQuery()
      {
         InternalUnsafeMethods.Engine_CancelServerQuery();
      }

      public static void StopServerQuery()
      {
         InternalUnsafeMethods.Engine_StopServerQuery();
      }

      public static void StartHeartBeat()
      {
         InternalUnsafeMethods.Engine_StartHeartBeat();
      }

      public static void StopHeartBeat()
      {
         InternalUnsafeMethods.Engine_StopHeartBeat();
      }

      public static int GetServerCount()
      {
         return InternalUnsafeMethods.Engine_GetServerCount();
      }

      public static bool SetServerInfo(int index)
      {
         return InternalUnsafeMethods.Engine_SetServerInfo(index);
      }

      public static void telnetSetParameters(int port, string consolePass, string listenPass, bool remoteEcho)
      {
         InternalUnsafeMethods.Engine_telnetSetParameters(port, consolePass, listenPass, remoteEcho);
      }

      public static bool TamlWrite(SimObject obj, string filename, string format, bool compressed)
      {
         return InternalUnsafeMethods.Engine_TamlWrite(obj.ObjectPtr->ObjPtr, filename, format, compressed);
      }

      public static SimObject TamlRead(string filename, string format)
      {
         return new SimObject(InternalUnsafeMethods.Engine_TamlRead(filename, format));
      }

      public static bool GenerateTamlSchema()
      {
         return InternalUnsafeMethods.Engine_GenerateTamlSchema();
      }

      public static void InputPushCursor(string cursorShapeName)
      {
         InternalUnsafeMethods.Engine_InputPushCursor(cursorShapeName);
      }

      public static void InputPopCursor()
      {
         InternalUnsafeMethods.Engine_InputPopCursor();
      }

      public static string GetTemporaryDirectory()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetTemporaryDirectory());
      }

      public static string GetTemporaryFileName()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetTemporaryFileName());
      }

      public static string GetUserDataDirectory()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetUserDataDirectory());
      }

      public static string GetUserHomeDirectory()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetUserHomeDirectory());
      }

      public static void SetMainDotCsDir(string csDir)
      {
         InternalUnsafeMethods.Engine_SetMainDotCsDir(csDir);
      }

      public static bool ActivateKeyboard()
      {
         return InternalUnsafeMethods.Engine_ActivateKeyboard();
      }

      public static void DeactivateKeyboard()
      {
         InternalUnsafeMethods.Engine_DeactivateKeyboard();
      }

      public static void EnableMouse()
      {
         InternalUnsafeMethods.Engine_EnableMouse();
      }

      public static void DisableMouse()
      {
         InternalUnsafeMethods.Engine_DisableMouse();
      }

      public static bool EnableJoystick()
      {
         return InternalUnsafeMethods.Engine_EnableJoystick();
      }

      public static void DisableJoystick()
      {
         InternalUnsafeMethods.Engine_DisableJoystick();
      }

      public static void EchoInputState()
      {
         InternalUnsafeMethods.Engine_EchoInputState();
      }

      public static bool EnableXInput()
      {
         return InternalUnsafeMethods.Engine_EnableXInput();
      }

      public static void DisableXInput()
      {
         InternalUnsafeMethods.Engine_DisableXInput();
      }

      public static void ResetXInput()
      {
         InternalUnsafeMethods.Engine_ResetXInput();
      }

      public static bool IsXInputConnected(int controllerID)
      {
         return InternalUnsafeMethods.Engine_IsXInputConnected(controllerID);
      }

      public static int GetXInputState(int controllerID, string prop, bool current)
      {
         return InternalUnsafeMethods.Engine_GetXInputState(controllerID, prop, current);
      }

      public static void Rumble(string device, float xRumble, float yRumble)
      {
         InternalUnsafeMethods.Engine_Rumble(device, xRumble, yRumble);
      }

      public static bool SetNetPort(int port)
      {
         return InternalUnsafeMethods.Engine_SetNetPort(port);
      }

      public static void CloseNetPort()
      {
         InternalUnsafeMethods.Engine_CloseNetPort();
      }

      public static string StripChars(string sourceString, string chars)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_StripChars(sourceString, chars));
      }

      public static string StripColorCodes(string sourceString, string chars)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_StripColorCodes(sourceString, chars));
      }

      public static bool SetDisplayDevice(string deviceName, uint width, uint height, uint bpp, bool fullScreen)
      {
         return InternalUnsafeMethods.Engine_SetDisplayDevice(deviceName, width, height, bpp, fullScreen);
      }

      public static bool SetScreenMode(uint width, uint height, uint bpp, bool fullScreen)
      {
         return InternalUnsafeMethods.Engine_SetScreenMode(width, height, bpp, fullScreen);
      }

      public static bool ToggleFullScreen()
      {
         return InternalUnsafeMethods.Engine_ToggleFullScreen();
      }

      public static bool IsFullScreen()
      {
         return InternalUnsafeMethods.Engine_IsFullScreen();
      }

      public static bool SwitchBitDepth()
      {
         return InternalUnsafeMethods.Engine_SwitchBitDepth();
      }

      public static bool PrevResolution()
      {
         return InternalUnsafeMethods.Engine_PrevResolution();
      }

      public static bool NextResolution()
      {
         return InternalUnsafeMethods.Engine_NextResolution();
      }

      public static string GetResolution()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetResolution());
      }

      public static bool SetResolution(uint width, uint height, uint bpp)
      {
         return InternalUnsafeMethods.Engine_SetResolution(width, height, bpp);
      }

      public static string GetDesktopResolution()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetDesktopResolution());
      }

      public static string GetDisplayDeviceList()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetDisplayDeviceList());
      }

      public static string GetResolutionList(string deviceName)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetResolutionList(deviceName));
      }

      public static string GetVideoDriverInfo()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetVideoDriverInfo());
      }

      public static bool IsDeviceFullScreenOnly(string deviceName)
      {
         return InternalUnsafeMethods.Engine_IsDeviceFullScreenOnly(deviceName);
      }

      public static void VideoSetGammaCorrection(float gamma)
      {
         InternalUnsafeMethods.Engine_VideoSetGammaCorrection(gamma);
      }

      public static bool SetVerticalSync(bool enable)
      {
         return InternalUnsafeMethods.Engine_SetVerticalSync(enable);
      }

      public static void MinimizeWindow()
      {
         InternalUnsafeMethods.Engine_MinimizeWindow();
      }

      public static void RestoreWindow()
      {
         InternalUnsafeMethods.Engine_RestoreWindow();
      }

      public static void SetMouseLock(bool enable)
      {
         InternalUnsafeMethods.Engine_SetMouseLock(enable);
      }

      public static int GetRealTime()
      {
         return InternalUnsafeMethods.Engine_GetRealTime();
      }

      public static string GetLocalTime()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetLocalTime());
      }

      public static string GetClipboard()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetClipboard());
      }

      public static bool SetClipboard(string val)
      {
         return InternalUnsafeMethods.Engine_SetClipboard(val);
      }

      public static string CreateUUID()
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_CreateUUID());
      }

      public static int MessageBox(string title, string message, string buttons, string icon)
      {
         return InternalUnsafeMethods.Engine_MessageBox(title, message, buttons, icon);
      }

      public static void InitDisplayDeviceInfo()
      {
         InternalUnsafeMethods.Engine_InitDisplayDeviceInfo();
      }

      public static void EnableWinConsole(bool enable)
      {
         InternalUnsafeMethods.Engine_EnableWinConsole(enable);
      }

      public static bool ShellExecute(string executable, string args, string directory)
      {
         return InternalUnsafeMethods.Engine_ShellExecute(executable, args, directory);
      }

      public static bool ShellExecuteBlocking(string executable, string args, string directory)
      {
         return InternalUnsafeMethods.Engine_ShellExecuteBlocking(executable, args, directory);
      }

      public static void GLEnableLogging(bool enable)
      {
         InternalUnsafeMethods.Engine_GLEnableLogging(enable);
      }

      public static void GLEnableOutline(bool enable)
      {
         InternalUnsafeMethods.Engine_GLEnableOutline(enable);
      }

      public static void GLEnableMetrics(bool enable)
      {
         InternalUnsafeMethods.Engine_GLEnableMetrics(enable);
      }

      public static bool IsJoystickDetected()
      {
         return InternalUnsafeMethods.Engine_IsJoystickDetected();
      }

      public static string GetJoystickAxes(int instance)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Engine_GetJoystickAxes(instance));
      }

      public static int GetJoystickCount()
      {
         return InternalUnsafeMethods.Engine_GetJoystickCount();
      }

      public static void MathInit(int argc, string[] argv)
      {
         InternalUnsafeMethods.Engine_MathInit(argc, argv);
      }

      public static int GetSimTime()
      {
         return InternalUnsafeMethods.Engine_GetSimTime();
      }

      public static void Cancel(int eventID)
      {
         InternalUnsafeMethods.Engine_Cancel(eventID);
      }

      public static bool IsEventPending(int eventID)
      {
         return InternalUnsafeMethods.Engine_IsEventPending(eventID);
      }

      public static int GetEventTimeLeft(int eventID)
      {
         return InternalUnsafeMethods.Engine_GetEventTimeLeft(eventID);
      }

      public static int GetScheduleDuration(int eventID)
      {
         return InternalUnsafeMethods.Engine_GetScheduleDuration(eventID);
      }

      public static int GetTimeSinceStart(int eventID)
      {
         return InternalUnsafeMethods.Engine_GetTimeSinceStart(eventID);
      }

      public static int Schedule(uint timeDelta, SimObject refObject, string functionName, int argc, string[] argv)
      {
         return InternalUnsafeMethods.Engine_Schedule(timeDelta, refObject.ObjectPtr->ObjPtr, functionName, argc, argv);
      }

      public static bool IsObjectByName(string handle)
      {
         return InternalUnsafeMethods.Engine_IsObjectByName(handle);
      }

      public static bool IsObjectByID(int handle)
      {
         return InternalUnsafeMethods.Engine_IsObjectByID(handle);
      }

      public static void DeleteDataBlocks()
      {
         InternalUnsafeMethods.Engine_DeleteDataBlocks();
      }

      public static bool SaveObject(SimObject obj, string filename)
      {
         return InternalUnsafeMethods.Engine_SaveObject(obj.ObjectPtr->ObjPtr, filename);
      }

      public static SimObject LoadObject(string filename)
      {
         return new SimObject(InternalUnsafeMethods.Engine_LoadObject(filename));
      }

      public static void CopyBehaviorToComponent(BehaviorInstance behavior, SimComponent component)
      {
         InternalUnsafeMethods.Engine_CopyBehaviorToComponent(behavior.ObjectPtr->ObjPtr, component.ObjectPtr->ObjPtr);
      }

      public static void sbmDumpStats()
      {
         InternalUnsafeMethods.Engine_sbmDumpStats();
      }

      public static void sbmDumpStrings()
      {
         InternalUnsafeMethods.Engine_sbmDumpStrings();
      }

      public static int RunAllUnitTests()
      {
         return InternalUnsafeMethods.Engine_RunAllUnitTests();
      }      

      #endregion
   }
}