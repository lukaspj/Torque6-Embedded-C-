using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Audio
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Audio_OpenALInitDriver();
         private static _Audio_OpenALInitDriver _Audio_OpenALInitDriverFunc;
         internal static bool Audio_OpenALInitDriver()
         {
            if (_Audio_OpenALInitDriverFunc == null)
            {
               _Audio_OpenALInitDriverFunc =
                  (_Audio_OpenALInitDriver)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_OpenALInitDriver"), typeof(_Audio_OpenALInitDriver));
            }

            return _Audio_OpenALInitDriverFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_OpenALShutdownDriver();
         private static _Audio_OpenALShutdownDriver _Audio_OpenALShutdownDriverFunc;
         internal static void Audio_OpenALShutdownDriver()
         {
            if (_Audio_OpenALShutdownDriverFunc == null)
            {
               _Audio_OpenALShutdownDriverFunc =
                  (_Audio_OpenALShutdownDriver)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_OpenALShutdownDriver"), typeof(_Audio_OpenALShutdownDriver));
            }

            _Audio_OpenALShutdownDriverFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Audio_AlGetString(string ALEnum);
         private static _Audio_AlGetString _Audio_AlGetStringFunc;
         internal static IntPtr Audio_AlGetString(string ALEnum)
         {
            if (_Audio_AlGetStringFunc == null)
            {
               _Audio_AlGetStringFunc =
                  (_Audio_AlGetString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlGetString"), typeof(_Audio_AlGetString));
            }

            return _Audio_AlGetStringFunc(ALEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_AlxGetAudioLength(string assetId);
         private static _Audio_AlxGetAudioLength _Audio_AlxGetAudioLengthFunc;
         internal static int Audio_AlxGetAudioLength(string assetId)
         {
            if (_Audio_AlxGetAudioLengthFunc == null)
            {
               _Audio_AlxGetAudioLengthFunc =
                  (_Audio_AlxGetAudioLength)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetAudioLength"), typeof(_Audio_AlxGetAudioLength));
            }

            return _Audio_AlxGetAudioLengthFunc(assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_AlxCreateSource(string assetId);
         private static _Audio_AlxCreateSource _Audio_AlxCreateSourceFunc;
         internal static int Audio_AlxCreateSource(string assetId)
         {
            if (_Audio_AlxCreateSourceFunc == null)
            {
               _Audio_AlxCreateSourceFunc =
                  (_Audio_AlxCreateSource)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxCreateSource"), typeof(_Audio_AlxCreateSource));
            }

            return _Audio_AlxCreateSourceFunc(assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxSourceF(int handle, string ALEnum, float value);
         private static _Audio_AlxSourceF _Audio_AlxSourceFFunc;
         internal static void Audio_AlxSourceF(int handle, string ALEnum, float value)
         {
            if (_Audio_AlxSourceFFunc == null)
            {
               _Audio_AlxSourceFFunc =
                  (_Audio_AlxSourceF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxSourceF"), typeof(_Audio_AlxSourceF));
            }

            _Audio_AlxSourceFFunc(handle, ALEnum, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxSource3F(int handle, string ALEnum, Point3F pos);
         private static _Audio_AlxSource3F _Audio_AlxSource3FFunc;
         internal static void Audio_AlxSource3F(int handle, string ALEnum, Point3F pos)
         {
            if (_Audio_AlxSource3FFunc == null)
            {
               _Audio_AlxSource3FFunc =
                  (_Audio_AlxSource3F)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxSource3F"), typeof(_Audio_AlxSource3F));
            }

            _Audio_AlxSource3FFunc(handle, ALEnum, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxSourceI(int handle, string ALEnum, int value);
         private static _Audio_AlxSourceI _Audio_AlxSourceIFunc;
         internal static void Audio_AlxSourceI(int handle, string ALEnum, int value)
         {
            if (_Audio_AlxSourceIFunc == null)
            {
               _Audio_AlxSourceIFunc =
                  (_Audio_AlxSourceI)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxSourceI"), typeof(_Audio_AlxSourceI));
            }

            _Audio_AlxSourceIFunc(handle, ALEnum, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Audio_AlxGetSourceF(int handle, string ALEnum);
         private static _Audio_AlxGetSourceF _Audio_AlxGetSourceFFunc;
         internal static float Audio_AlxGetSourceF(int handle, string ALEnum)
         {
            if (_Audio_AlxGetSourceFFunc == null)
            {
               _Audio_AlxGetSourceFFunc =
                  (_Audio_AlxGetSourceF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetSourceF"), typeof(_Audio_AlxGetSourceF));
            }

            return _Audio_AlxGetSourceFFunc(handle, ALEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxGetSource3F(int handle, string ALEnum, Point3F outPos);
         private static _Audio_AlxGetSource3F _Audio_AlxGetSource3FFunc;
         internal static void Audio_AlxGetSource3F(int handle, string ALEnum, Point3F outPos)
         {
            if (_Audio_AlxGetSource3FFunc == null)
            {
               _Audio_AlxGetSource3FFunc =
                  (_Audio_AlxGetSource3F)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetSource3F"), typeof(_Audio_AlxGetSource3F));
            }

            _Audio_AlxGetSource3FFunc(handle, ALEnum, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_AlxGetSourceI(int handle, string ALEnum);
         private static _Audio_AlxGetSourceI _Audio_AlxGetSourceIFunc;
         internal static int Audio_AlxGetSourceI(int handle, string ALEnum)
         {
            if (_Audio_AlxGetSourceIFunc == null)
            {
               _Audio_AlxGetSourceIFunc =
                  (_Audio_AlxGetSourceI)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetSourceI"), typeof(_Audio_AlxGetSourceI));
            }

            return _Audio_AlxGetSourceIFunc(handle, ALEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_AlxPlay(string assetId);
         private static _Audio_AlxPlay _Audio_AlxPlayFunc;
         internal static int Audio_AlxPlay(string assetId)
         {
            if (_Audio_AlxPlayFunc == null)
            {
               _Audio_AlxPlayFunc =
                  (_Audio_AlxPlay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxPlay"), typeof(_Audio_AlxPlay));
            }

            return _Audio_AlxPlayFunc(assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Audio_AlxPause(uint handle);
         private static _Audio_AlxPause _Audio_AlxPauseFunc;
         internal static bool Audio_AlxPause(uint handle)
         {
            if (_Audio_AlxPauseFunc == null)
            {
               _Audio_AlxPauseFunc =
                  (_Audio_AlxPause)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxPause"), typeof(_Audio_AlxPause));
            }

            return _Audio_AlxPauseFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxUnpause(uint handle);
         private static _Audio_AlxUnpause _Audio_AlxUnpauseFunc;
         internal static void Audio_AlxUnpause(uint handle)
         {
            if (_Audio_AlxUnpauseFunc == null)
            {
               _Audio_AlxUnpauseFunc =
                  (_Audio_AlxUnpause)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxUnpause"), typeof(_Audio_AlxUnpause));
            }

            _Audio_AlxUnpauseFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxStop(uint handle);
         private static _Audio_AlxStop _Audio_AlxStopFunc;
         internal static void Audio_AlxStop(uint handle)
         {
            if (_Audio_AlxStopFunc == null)
            {
               _Audio_AlxStopFunc =
                  (_Audio_AlxStop)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxStop"), typeof(_Audio_AlxStop));
            }

            _Audio_AlxStopFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxStopAll();
         private static _Audio_AlxStopAll _Audio_AlxStopAllFunc;
         internal static void Audio_AlxStopAll()
         {
            if (_Audio_AlxStopAllFunc == null)
            {
               _Audio_AlxStopAllFunc =
                  (_Audio_AlxStopAll)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxStopAll"), typeof(_Audio_AlxStopAll));
            }

            _Audio_AlxStopAllFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Audio_AlxIsPlaying(uint handle);
         private static _Audio_AlxIsPlaying _Audio_AlxIsPlayingFunc;
         internal static bool Audio_AlxIsPlaying(uint handle)
         {
            if (_Audio_AlxIsPlayingFunc == null)
            {
               _Audio_AlxIsPlayingFunc =
                  (_Audio_AlxIsPlaying)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxIsPlaying"), typeof(_Audio_AlxIsPlaying));
            }

            return _Audio_AlxIsPlayingFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlxListenerF(string ALEnum, float value);
         private static _Audio_AlxListenerF _Audio_AlxListenerFFunc;
         internal static void Audio_AlxListenerF(string ALEnum, float value)
         {
            if (_Audio_AlxListenerFFunc == null)
            {
               _Audio_AlxListenerFFunc =
                  (_Audio_AlxListenerF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxListenerF"), typeof(_Audio_AlxListenerF));
            }

            _Audio_AlxListenerFFunc(ALEnum, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlListener3F(string ALEnum, Point3F pos);
         private static _Audio_AlListener3F _Audio_AlListener3FFunc;
         internal static void Audio_AlListener3F(string ALEnum, Point3F pos)
         {
            if (_Audio_AlListener3FFunc == null)
            {
               _Audio_AlListener3FFunc =
                  (_Audio_AlListener3F)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlListener3F"), typeof(_Audio_AlListener3F));
            }

            _Audio_AlListener3FFunc(ALEnum, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Audio_AlxGetListenerF(string ALEnum);
         private static _Audio_AlxGetListenerF _Audio_AlxGetListenerFFunc;
         internal static float Audio_AlxGetListenerF(string ALEnum)
         {
            if (_Audio_AlxGetListenerFFunc == null)
            {
               _Audio_AlxGetListenerFFunc =
                  (_Audio_AlxGetListenerF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetListenerF"), typeof(_Audio_AlxGetListenerF));
            }

            return _Audio_AlxGetListenerFFunc(ALEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_AlGetListener3F(string ALEnum, Point3F outPos);
         private static _Audio_AlGetListener3F _Audio_AlGetListener3FFunc;
         internal static void Audio_AlGetListener3F(string ALEnum, Point3F outPos)
         {
            if (_Audio_AlGetListener3FFunc == null)
            {
               _Audio_AlGetListener3FFunc =
                  (_Audio_AlGetListener3F)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlGetListener3F"), typeof(_Audio_AlGetListener3F));
            }

            _Audio_AlGetListener3FFunc(ALEnum, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_AlGetListenerI(string ALEnum);
         private static _Audio_AlGetListenerI _Audio_AlGetListenerIFunc;
         internal static int Audio_AlGetListenerI(string ALEnum)
         {
            if (_Audio_AlGetListenerIFunc == null)
            {
               _Audio_AlGetListenerIFunc =
                  (_Audio_AlGetListenerI)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlGetListenerI"), typeof(_Audio_AlGetListenerI));
            }

            return _Audio_AlGetListenerIFunc(ALEnum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Audio_AlxGetChannelVolume(uint channel);
         private static _Audio_AlxGetChannelVolume _Audio_AlxGetChannelVolumeFunc;
         internal static float Audio_AlxGetChannelVolume(uint channel)
         {
            if (_Audio_AlxGetChannelVolumeFunc == null)
            {
               _Audio_AlxGetChannelVolumeFunc =
                  (_Audio_AlxGetChannelVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetChannelVolume"), typeof(_Audio_AlxGetChannelVolume));
            }

            return _Audio_AlxGetChannelVolumeFunc(channel);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Audio_AlxSetChannelVolume(uint channel, float volume);
         private static _Audio_AlxSetChannelVolume _Audio_AlxSetChannelVolumeFunc;
         internal static bool Audio_AlxSetChannelVolume(uint channel, float volume)
         {
            if (_Audio_AlxSetChannelVolumeFunc == null)
            {
               _Audio_AlxSetChannelVolumeFunc =
                  (_Audio_AlxSetChannelVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxSetChannelVolume"), typeof(_Audio_AlxSetChannelVolume));
            }

            return _Audio_AlxSetChannelVolumeFunc(channel, volume);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Audio_AlxGetStreamPosition(uint handle);
         private static _Audio_AlxGetStreamPosition _Audio_AlxGetStreamPositionFunc;
         internal static float Audio_AlxGetStreamPosition(uint handle)
         {
            if (_Audio_AlxGetStreamPositionFunc == null)
            {
               _Audio_AlxGetStreamPositionFunc =
                  (_Audio_AlxGetStreamPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetStreamPosition"), typeof(_Audio_AlxGetStreamPosition));
            }

            return _Audio_AlxGetStreamPositionFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _Audio_AlxGetStreamDuration(uint handle);
         private static _Audio_AlxGetStreamDuration _Audio_AlxGetStreamDurationFunc;
         internal static float Audio_AlxGetStreamDuration(uint handle)
         {
            if (_Audio_AlxGetStreamDurationFunc == null)
            {
               _Audio_AlxGetStreamDurationFunc =
                  (_Audio_AlxGetStreamDuration)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_AlxGetStreamDuration"), typeof(_Audio_AlxGetStreamDuration));
            }

            return _Audio_AlxGetStreamDurationFunc(handle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _Audio_StartiOSAudioStream(string assetId);
         private static _Audio_StartiOSAudioStream _Audio_StartiOSAudioStreamFunc;
         internal static int Audio_StartiOSAudioStream(string assetId)
         {
            if (_Audio_StartiOSAudioStreamFunc == null)
            {
               _Audio_StartiOSAudioStreamFunc =
                  (_Audio_StartiOSAudioStream)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_StartiOSAudioStream"), typeof(_Audio_StartiOSAudioStream));
            }

            return _Audio_StartiOSAudioStreamFunc(assetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_StopiOSAudioStream(int streamId);
         private static _Audio_StopiOSAudioStream _Audio_StopiOSAudioStreamFunc;
         internal static void Audio_StopiOSAudioStream(int streamId)
         {
            if (_Audio_StopiOSAudioStreamFunc == null)
            {
               _Audio_StopiOSAudioStreamFunc =
                  (_Audio_StopiOSAudioStream)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_StopiOSAudioStream"), typeof(_Audio_StopiOSAudioStream));
            }

            _Audio_StopiOSAudioStreamFunc(streamId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Audio_SetiOSAudioStreamVolume(int streamId, float volume);
         private static _Audio_SetiOSAudioStreamVolume _Audio_SetiOSAudioStreamVolumeFunc;
         internal static void Audio_SetiOSAudioStreamVolume(int streamId, float volume)
         {
            if (_Audio_SetiOSAudioStreamVolumeFunc == null)
            {
               _Audio_SetiOSAudioStreamVolumeFunc =
                  (_Audio_SetiOSAudioStreamVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Audio_SetiOSAudioStreamVolume"), typeof(_Audio_SetiOSAudioStreamVolume));
            }

            _Audio_SetiOSAudioStreamVolumeFunc(streamId, volume);
         }
      }

      #endregion
      
      #region Functions

      public static bool OpenALInitDriver()
      {
         return InternalUnsafeMethods.Audio_OpenALInitDriver();
      }

      public static void OpenALShutdownDriver()
      {
         InternalUnsafeMethods.Audio_OpenALShutdownDriver();
      }

      public static string AlGetString(string ALEnum)
      {
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.Audio_AlGetString(ALEnum));
      }

      public static int AlxGetAudioLength(string assetId)
      {
         return InternalUnsafeMethods.Audio_AlxGetAudioLength(assetId);
      }

      public static int AlxCreateSource(string assetId)
      {
         return InternalUnsafeMethods.Audio_AlxCreateSource(assetId);
      }

      public static void AlxSourceF(int handle, string ALEnum, float value)
      {
         InternalUnsafeMethods.Audio_AlxSourceF(handle, ALEnum, value);
      }

      public static void AlxSource3F(int handle, string ALEnum, Point3F pos)
      {
         InternalUnsafeMethods.Audio_AlxSource3F(handle, ALEnum, pos);
      }

      public static void AlxSourceI(int handle, string ALEnum, int value)
      {
         InternalUnsafeMethods.Audio_AlxSourceI(handle, ALEnum, value);
      }

      public static float AlxGetSourceF(int handle, string ALEnum)
      {
         return InternalUnsafeMethods.Audio_AlxGetSourceF(handle, ALEnum);
      }

      public static void AlxGetSource3F(int handle, string ALEnum, Point3F outPos)
      {
         InternalUnsafeMethods.Audio_AlxGetSource3F(handle, ALEnum, outPos);
      }

      public static int AlxGetSourceI(int handle, string ALEnum)
      {
         return InternalUnsafeMethods.Audio_AlxGetSourceI(handle, ALEnum);
      }

      public static int AlxPlay(string assetId)
      {
         return InternalUnsafeMethods.Audio_AlxPlay(assetId);
      }

      public static bool AlxPause(uint handle)
      {
         return InternalUnsafeMethods.Audio_AlxPause(handle);
      }

      public static void AlxUnpause(uint handle)
      {
         InternalUnsafeMethods.Audio_AlxUnpause(handle);
      }

      public static void AlxStop(uint handle)
      {
         InternalUnsafeMethods.Audio_AlxStop(handle);
      }

      public static void AlxStopAll()
      {
         InternalUnsafeMethods.Audio_AlxStopAll();
      }

      public static bool AlxIsPlaying(uint handle)
      {
         return InternalUnsafeMethods.Audio_AlxIsPlaying(handle);
      }

      public static void AlxListenerF(string ALEnum, float value)
      {
         InternalUnsafeMethods.Audio_AlxListenerF(ALEnum, value);
      }

      public static void AlListener3F(string ALEnum, Point3F pos)
      {
         InternalUnsafeMethods.Audio_AlListener3F(ALEnum, pos);
      }

      public static float AlxGetListenerF(string ALEnum)
      {
         return InternalUnsafeMethods.Audio_AlxGetListenerF(ALEnum);
      }

      public static void AlGetListener3F(string ALEnum, Point3F outPos)
      {
         InternalUnsafeMethods.Audio_AlGetListener3F(ALEnum, outPos);
      }

      public static int AlGetListenerI(string ALEnum)
      {
         return InternalUnsafeMethods.Audio_AlGetListenerI(ALEnum);
      }

      public static float AlxGetChannelVolume(uint channel)
      {
         return InternalUnsafeMethods.Audio_AlxGetChannelVolume(channel);
      }

      public static bool AlxSetChannelVolume(uint channel, float volume)
      {
         return InternalUnsafeMethods.Audio_AlxSetChannelVolume(channel, volume);
      }

      public static float AlxGetStreamPosition(uint handle)
      {
         return InternalUnsafeMethods.Audio_AlxGetStreamPosition(handle);
      }

      public static float AlxGetStreamDuration(uint handle)
      {
         return InternalUnsafeMethods.Audio_AlxGetStreamDuration(handle);
      }

      public static int StartiOSAudioStream(string assetId)
      {
         return InternalUnsafeMethods.Audio_StartiOSAudioStream(assetId);
      }

      public static void StopiOSAudioStream(int streamId)
      {
         InternalUnsafeMethods.Audio_StopiOSAudioStream(streamId);
      }

      public static void SetiOSAudioStreamVolume(int streamId, float volume)
      {
         InternalUnsafeMethods.Audio_SetiOSAudioStreamVolume(streamId, volume);
      }      

      #endregion
   }
}