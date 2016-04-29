using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AudioAsset : AssetBase
   {
      
      public AudioAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AudioAssetCreateInstance());
      }

      public AudioAsset(uint pId) : base(pId)
      {
      }

      public AudioAsset(string pName) : base(pName)
      {
      }

      public AudioAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AudioAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AudioAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioAssetGetAudioFile(IntPtr audioAsset);
         private static _AudioAssetGetAudioFile _AudioAssetGetAudioFileFunc;
         internal static IntPtr AudioAssetGetAudioFile(IntPtr audioAsset)
         {
            if (_AudioAssetGetAudioFileFunc == null)
            {
               _AudioAssetGetAudioFileFunc =
                  (_AudioAssetGetAudioFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetGetAudioFile"), typeof(_AudioAssetGetAudioFile));
            }

            return _AudioAssetGetAudioFileFunc(audioAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioAssetSetAudioFile(IntPtr audioAsset, string val);
         private static _AudioAssetSetAudioFile _AudioAssetSetAudioFileFunc;
         internal static void AudioAssetSetAudioFile(IntPtr audioAsset, string val)
         {
            if (_AudioAssetSetAudioFileFunc == null)
            {
               _AudioAssetSetAudioFileFunc =
                  (_AudioAssetSetAudioFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetSetAudioFile"), typeof(_AudioAssetSetAudioFile));
            }

            _AudioAssetSetAudioFileFunc(audioAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioAssetGetVolume(IntPtr audioAsset);
         private static _AudioAssetGetVolume _AudioAssetGetVolumeFunc;
         internal static float AudioAssetGetVolume(IntPtr audioAsset)
         {
            if (_AudioAssetGetVolumeFunc == null)
            {
               _AudioAssetGetVolumeFunc =
                  (_AudioAssetGetVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetGetVolume"), typeof(_AudioAssetGetVolume));
            }

            return _AudioAssetGetVolumeFunc(audioAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioAssetSetVolume(IntPtr audioAsset, float val);
         private static _AudioAssetSetVolume _AudioAssetSetVolumeFunc;
         internal static void AudioAssetSetVolume(IntPtr audioAsset, float val)
         {
            if (_AudioAssetSetVolumeFunc == null)
            {
               _AudioAssetSetVolumeFunc =
                  (_AudioAssetSetVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetSetVolume"), typeof(_AudioAssetSetVolume));
            }

            _AudioAssetSetVolumeFunc(audioAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioAssetGetVolumeChannel(IntPtr audioAsset);
         private static _AudioAssetGetVolumeChannel _AudioAssetGetVolumeChannelFunc;
         internal static int AudioAssetGetVolumeChannel(IntPtr audioAsset)
         {
            if (_AudioAssetGetVolumeChannelFunc == null)
            {
               _AudioAssetGetVolumeChannelFunc =
                  (_AudioAssetGetVolumeChannel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetGetVolumeChannel"), typeof(_AudioAssetGetVolumeChannel));
            }

            return _AudioAssetGetVolumeChannelFunc(audioAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioAssetSetVolumeChannel(IntPtr audioAsset, int val);
         private static _AudioAssetSetVolumeChannel _AudioAssetSetVolumeChannelFunc;
         internal static void AudioAssetSetVolumeChannel(IntPtr audioAsset, int val)
         {
            if (_AudioAssetSetVolumeChannelFunc == null)
            {
               _AudioAssetSetVolumeChannelFunc =
                  (_AudioAssetSetVolumeChannel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetSetVolumeChannel"), typeof(_AudioAssetSetVolumeChannel));
            }

            _AudioAssetSetVolumeChannelFunc(audioAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AudioAssetGetLooping(IntPtr audioAsset);
         private static _AudioAssetGetLooping _AudioAssetGetLoopingFunc;
         internal static bool AudioAssetGetLooping(IntPtr audioAsset)
         {
            if (_AudioAssetGetLoopingFunc == null)
            {
               _AudioAssetGetLoopingFunc =
                  (_AudioAssetGetLooping)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetGetLooping"), typeof(_AudioAssetGetLooping));
            }

            return _AudioAssetGetLoopingFunc(audioAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioAssetSetLooping(IntPtr audioAsset, bool val);
         private static _AudioAssetSetLooping _AudioAssetSetLoopingFunc;
         internal static void AudioAssetSetLooping(IntPtr audioAsset, bool val)
         {
            if (_AudioAssetSetLoopingFunc == null)
            {
               _AudioAssetSetLoopingFunc =
                  (_AudioAssetSetLooping)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetSetLooping"), typeof(_AudioAssetSetLooping));
            }

            _AudioAssetSetLoopingFunc(audioAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AudioAssetGetStreaming(IntPtr audioAsset);
         private static _AudioAssetGetStreaming _AudioAssetGetStreamingFunc;
         internal static bool AudioAssetGetStreaming(IntPtr audioAsset)
         {
            if (_AudioAssetGetStreamingFunc == null)
            {
               _AudioAssetGetStreamingFunc =
                  (_AudioAssetGetStreaming)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetGetStreaming"), typeof(_AudioAssetGetStreaming));
            }

            return _AudioAssetGetStreamingFunc(audioAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioAssetSetStreaming(IntPtr audioAsset, bool val);
         private static _AudioAssetSetStreaming _AudioAssetSetStreamingFunc;
         internal static void AudioAssetSetStreaming(IntPtr audioAsset, bool val)
         {
            if (_AudioAssetSetStreamingFunc == null)
            {
               _AudioAssetSetStreamingFunc =
                  (_AudioAssetSetStreaming)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetSetStreaming"), typeof(_AudioAssetSetStreaming));
            }

            _AudioAssetSetStreamingFunc(audioAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioAssetCreateInstance();
         private static _AudioAssetCreateInstance _AudioAssetCreateInstanceFunc;
         internal static IntPtr AudioAssetCreateInstance()
         {
            if (_AudioAssetCreateInstanceFunc == null)
            {
               _AudioAssetCreateInstanceFunc =
                  (_AudioAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioAssetCreateInstance"), typeof(_AudioAssetCreateInstance));
            }

            return _AudioAssetCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string AudioFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AudioAssetGetAudioFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioAssetSetAudioFile(ObjectPtr->ObjPtr, value);
         }
      }
      public float Volume
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioAssetGetVolume(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioAssetSetVolume(ObjectPtr->ObjPtr, value);
         }
      }
      public int VolumeChannel
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioAssetGetVolumeChannel(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioAssetSetVolumeChannel(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Looping
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioAssetGetLooping(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioAssetSetLooping(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Streaming
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioAssetGetStreaming(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioAssetSetStreaming(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}