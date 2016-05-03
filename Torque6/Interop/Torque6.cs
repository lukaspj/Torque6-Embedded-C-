using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;

namespace Torque6.Interop
{
   public static class Torque6
   {
      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate string CallFunction(
         IntPtr name, IntPtr argv, int argc, [MarshalAs(UnmanagedType.I1)] out bool result);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate string CallMethod(IntPtr className
         , uint obj
         , IntPtr name
         , IntPtr argv
         , int argc
         , [MarshalAs(UnmanagedType.I1)] out bool result);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate bool IsMethod(IntPtr className, IntPtr methodName);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate void MainEntryPoint();

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate int T6Main(int pArgc, string[] pArgv, IntPtr pHInstance);

      [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
      public delegate void T6SetCallFunction(
         IntPtr pFunctionPtr, IntPtr pMethodPtr, IntPtr pIsMethodPtr, IntPtr pMainPtr);

      public static string LibraryName;
      internal static IntPtr Torque6LibHandle;
      internal static IDllLoadUtils DllLoadUtils;

      public static void Initialize(string[] args, Libraries libraryNames)
      {
         DllLoadUtils = Platform.IsLinux()
            ? (IDllLoadUtils)new DllLoadUtilsLinux()
            : new DllLoadUtilsWindows();
 
         string platformMain;
         if (Platform.IsLinux())
         {
            platformMain = "unixmain";
            LibraryName = IntPtr.Size == 8 ? libraryNames.Linux64bit : libraryNames.Linux32bit;
         } else if (Platform.IsOSX())
         {
            platformMain = "osxmain";
            LibraryName = IntPtr.Size == 8 ? libraryNames.OSX64bit : libraryNames.OSX32bit;
         }
         else
         {
            platformMain = "winmain";
            LibraryName = IntPtr.Size == 8 ? libraryNames.Windows64bit : libraryNames.Windows32bit;
         }

         Torque6LibHandle = DllLoadUtils.LoadLibrary(LibraryName);
         if (Torque6LibHandle == IntPtr.Zero)
         {
            throw new Exception("Unable to load " + (IntPtr.Size == 8 ? "32" : "64") + " bit dll: " + LibraryName);
         }
         var mainHandle = DllLoadUtils.GetProcAddress(Torque6LibHandle, platformMain);
         var setCallbacksHandle = DllLoadUtils.GetProcAddress(Torque6LibHandle, "SetCallbacks");

         var setCallbacks = (T6SetCallFunction)Marshal.GetDelegateForFunctionPointer(
            setCallbacksHandle, typeof(T6SetCallFunction));

         var main = (T6Main)Marshal.GetDelegateForFunctionPointer(
            mainHandle, typeof(T6Main));

         CallFunction callDelegate = CallFunctionDelegate;
         CallMethod methodDelegate = CallMethodDelegate;
         IsMethod isMethodDelegate = IsMethodDelegate;
         IntPtr mainEntryPointPtr = IntPtr.Zero;
         if (Initializer.GetScriptEntry() != null)
            mainEntryPointPtr =
               Marshal.GetFunctionPointerForDelegate(
                  (MainEntryPoint)Initializer.GetScriptEntry().CreateDelegate(typeof(MainEntryPoint)));

         setCallbacks(Marshal.GetFunctionPointerForDelegate(callDelegate)
            , Marshal.GetFunctionPointerForDelegate(methodDelegate)
            , Marshal.GetFunctionPointerForDelegate(isMethodDelegate)
            , mainEntryPointPtr);

         main(args.Length, args, IntPtr.Zero);

         DllLoadUtils.FreeLibrary(Torque6LibHandle);
      }

      public static string CallFunctionDelegate(IntPtr name, IntPtr argv, int argc, out bool result)
      {
         string _name = Marshal.PtrToStringAnsi(name);
         string[] strings = null;
         if (argv != IntPtr.Zero)
            strings = CustomMarshalling.IntPtrToStringArray(argv, argc);
         return EngineCallbacks.CallScriptFunction(_name, strings, out result);
      }

      public static string CallMethodDelegate(IntPtr className, uint obj, IntPtr name, IntPtr argv, int argc,
         out bool result)
      {
         string _className = Marshal.PtrToStringAnsi(className);
         string _name = Marshal.PtrToStringAnsi(name);

         SimObject objectWrapper = new SimObject(obj);
         string[] strings = {};
         if (argv != IntPtr.Zero)
            strings = CustomMarshalling.IntPtrToStringArray(argv, argc);
         string strRes = EngineCallbacks.CallScriptMethod(_className, objectWrapper, _name, strings, out result);
         if (!result)
            strRes = EngineCallbacks.CallScriptMethod(_className, objectWrapper, _name, strings, out result);
         return strRes;
      }

      public static bool IsMethodDelegate(IntPtr className, IntPtr methodName)
      {
         string _className = Marshal.PtrToStringAnsi(className);
         string _methodName = Marshal.PtrToStringAnsi(methodName);
         return EngineCallbacks.IsMethod(_className, _methodName);
      }

      public struct Libraries
      {
         public string Linux32bit;
         public string Linux64bit;
         public string Windows32bit;
         public string Windows64bit;
         public string OSX32bit;
         public string OSX64bit;
      }
   }
}