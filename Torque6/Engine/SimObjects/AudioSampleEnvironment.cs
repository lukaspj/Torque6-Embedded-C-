using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AudioSampleEnvironment : SimDataBlock
   {
      
      public AudioSampleEnvironment()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AudioSampleEnvironmentCreateInstance());
      }

      public AudioSampleEnvironment(uint pId) : base(pId)
      {
      }

      public AudioSampleEnvironment(string pName) : base(pName)
      {
      }

      public AudioSampleEnvironment(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AudioSampleEnvironment(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AudioSampleEnvironment(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioSampleEnvironmentGetDirect(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetDirect _AudioSampleEnvironmentGetDirectFunc;
         internal static int AudioSampleEnvironmentGetDirect(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetDirectFunc == null)
            {
               _AudioSampleEnvironmentGetDirectFunc =
                  (_AudioSampleEnvironmentGetDirect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetDirect"), typeof(_AudioSampleEnvironmentGetDirect));
            }

            return _AudioSampleEnvironmentGetDirectFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetDirect(IntPtr audioEnvironment, int direct);
         private static _AudioSampleEnvironmentSetDirect _AudioSampleEnvironmentSetDirectFunc;
         internal static void AudioSampleEnvironmentSetDirect(IntPtr audioEnvironment, int direct)
         {
            if (_AudioSampleEnvironmentSetDirectFunc == null)
            {
               _AudioSampleEnvironmentSetDirectFunc =
                  (_AudioSampleEnvironmentSetDirect)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetDirect"), typeof(_AudioSampleEnvironmentSetDirect));
            }

            _AudioSampleEnvironmentSetDirectFunc(audioEnvironment, direct);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioSampleEnvironmentGetDirectHF(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetDirectHF _AudioSampleEnvironmentGetDirectHFFunc;
         internal static int AudioSampleEnvironmentGetDirectHF(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetDirectHFFunc == null)
            {
               _AudioSampleEnvironmentGetDirectHFFunc =
                  (_AudioSampleEnvironmentGetDirectHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetDirectHF"), typeof(_AudioSampleEnvironmentGetDirectHF));
            }

            return _AudioSampleEnvironmentGetDirectHFFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetDirectHF(IntPtr audioEnvironment, int directHF);
         private static _AudioSampleEnvironmentSetDirectHF _AudioSampleEnvironmentSetDirectHFFunc;
         internal static void AudioSampleEnvironmentSetDirectHF(IntPtr audioEnvironment, int directHF)
         {
            if (_AudioSampleEnvironmentSetDirectHFFunc == null)
            {
               _AudioSampleEnvironmentSetDirectHFFunc =
                  (_AudioSampleEnvironmentSetDirectHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetDirectHF"), typeof(_AudioSampleEnvironmentSetDirectHF));
            }

            _AudioSampleEnvironmentSetDirectHFFunc(audioEnvironment, directHF);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioSampleEnvironmentGetRoom(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetRoom _AudioSampleEnvironmentGetRoomFunc;
         internal static int AudioSampleEnvironmentGetRoom(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetRoomFunc == null)
            {
               _AudioSampleEnvironmentGetRoomFunc =
                  (_AudioSampleEnvironmentGetRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetRoom"), typeof(_AudioSampleEnvironmentGetRoom));
            }

            return _AudioSampleEnvironmentGetRoomFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetRoom(IntPtr audioEnvironment, int room);
         private static _AudioSampleEnvironmentSetRoom _AudioSampleEnvironmentSetRoomFunc;
         internal static void AudioSampleEnvironmentSetRoom(IntPtr audioEnvironment, int room)
         {
            if (_AudioSampleEnvironmentSetRoomFunc == null)
            {
               _AudioSampleEnvironmentSetRoomFunc =
                  (_AudioSampleEnvironmentSetRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetRoom"), typeof(_AudioSampleEnvironmentSetRoom));
            }

            _AudioSampleEnvironmentSetRoomFunc(audioEnvironment, room);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetObstruction(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetObstruction _AudioSampleEnvironmentGetObstructionFunc;
         internal static float AudioSampleEnvironmentGetObstruction(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetObstructionFunc == null)
            {
               _AudioSampleEnvironmentGetObstructionFunc =
                  (_AudioSampleEnvironmentGetObstruction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetObstruction"), typeof(_AudioSampleEnvironmentGetObstruction));
            }

            return _AudioSampleEnvironmentGetObstructionFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetObstruction(IntPtr audioEnvironment, float obstruction);
         private static _AudioSampleEnvironmentSetObstruction _AudioSampleEnvironmentSetObstructionFunc;
         internal static void AudioSampleEnvironmentSetObstruction(IntPtr audioEnvironment, float obstruction)
         {
            if (_AudioSampleEnvironmentSetObstructionFunc == null)
            {
               _AudioSampleEnvironmentSetObstructionFunc =
                  (_AudioSampleEnvironmentSetObstruction)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetObstruction"), typeof(_AudioSampleEnvironmentSetObstruction));
            }

            _AudioSampleEnvironmentSetObstructionFunc(audioEnvironment, obstruction);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetObstructionLFRatio(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetObstructionLFRatio _AudioSampleEnvironmentGetObstructionLFRatioFunc;
         internal static float AudioSampleEnvironmentGetObstructionLFRatio(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetObstructionLFRatioFunc == null)
            {
               _AudioSampleEnvironmentGetObstructionLFRatioFunc =
                  (_AudioSampleEnvironmentGetObstructionLFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetObstructionLFRatio"), typeof(_AudioSampleEnvironmentGetObstructionLFRatio));
            }

            return _AudioSampleEnvironmentGetObstructionLFRatioFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetObstructionLFRatio(IntPtr audioEnvironment, float ratio);
         private static _AudioSampleEnvironmentSetObstructionLFRatio _AudioSampleEnvironmentSetObstructionLFRatioFunc;
         internal static void AudioSampleEnvironmentSetObstructionLFRatio(IntPtr audioEnvironment, float ratio)
         {
            if (_AudioSampleEnvironmentSetObstructionLFRatioFunc == null)
            {
               _AudioSampleEnvironmentSetObstructionLFRatioFunc =
                  (_AudioSampleEnvironmentSetObstructionLFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetObstructionLFRatio"), typeof(_AudioSampleEnvironmentSetObstructionLFRatio));
            }

            _AudioSampleEnvironmentSetObstructionLFRatioFunc(audioEnvironment, ratio);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetOcclusion(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetOcclusion _AudioSampleEnvironmentGetOcclusionFunc;
         internal static float AudioSampleEnvironmentGetOcclusion(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetOcclusionFunc == null)
            {
               _AudioSampleEnvironmentGetOcclusionFunc =
                  (_AudioSampleEnvironmentGetOcclusion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetOcclusion"), typeof(_AudioSampleEnvironmentGetOcclusion));
            }

            return _AudioSampleEnvironmentGetOcclusionFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetOcclusion(IntPtr audioEnvironment, float occlusion);
         private static _AudioSampleEnvironmentSetOcclusion _AudioSampleEnvironmentSetOcclusionFunc;
         internal static void AudioSampleEnvironmentSetOcclusion(IntPtr audioEnvironment, float occlusion)
         {
            if (_AudioSampleEnvironmentSetOcclusionFunc == null)
            {
               _AudioSampleEnvironmentSetOcclusionFunc =
                  (_AudioSampleEnvironmentSetOcclusion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetOcclusion"), typeof(_AudioSampleEnvironmentSetOcclusion));
            }

            _AudioSampleEnvironmentSetOcclusionFunc(audioEnvironment, occlusion);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetOcclusionLFRatio(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetOcclusionLFRatio _AudioSampleEnvironmentGetOcclusionLFRatioFunc;
         internal static float AudioSampleEnvironmentGetOcclusionLFRatio(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetOcclusionLFRatioFunc == null)
            {
               _AudioSampleEnvironmentGetOcclusionLFRatioFunc =
                  (_AudioSampleEnvironmentGetOcclusionLFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetOcclusionLFRatio"), typeof(_AudioSampleEnvironmentGetOcclusionLFRatio));
            }

            return _AudioSampleEnvironmentGetOcclusionLFRatioFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetOcclusionLFRatio(IntPtr audioEnvironment, float ratio);
         private static _AudioSampleEnvironmentSetOcclusionLFRatio _AudioSampleEnvironmentSetOcclusionLFRatioFunc;
         internal static void AudioSampleEnvironmentSetOcclusionLFRatio(IntPtr audioEnvironment, float ratio)
         {
            if (_AudioSampleEnvironmentSetOcclusionLFRatioFunc == null)
            {
               _AudioSampleEnvironmentSetOcclusionLFRatioFunc =
                  (_AudioSampleEnvironmentSetOcclusionLFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetOcclusionLFRatio"), typeof(_AudioSampleEnvironmentSetOcclusionLFRatio));
            }

            _AudioSampleEnvironmentSetOcclusionLFRatioFunc(audioEnvironment, ratio);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetOcclusionRoomRatio(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetOcclusionRoomRatio _AudioSampleEnvironmentGetOcclusionRoomRatioFunc;
         internal static float AudioSampleEnvironmentGetOcclusionRoomRatio(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetOcclusionRoomRatioFunc == null)
            {
               _AudioSampleEnvironmentGetOcclusionRoomRatioFunc =
                  (_AudioSampleEnvironmentGetOcclusionRoomRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetOcclusionRoomRatio"), typeof(_AudioSampleEnvironmentGetOcclusionRoomRatio));
            }

            return _AudioSampleEnvironmentGetOcclusionRoomRatioFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetOcclusionRoomRatio(IntPtr audioEnvironment, float ratio);
         private static _AudioSampleEnvironmentSetOcclusionRoomRatio _AudioSampleEnvironmentSetOcclusionRoomRatioFunc;
         internal static void AudioSampleEnvironmentSetOcclusionRoomRatio(IntPtr audioEnvironment, float ratio)
         {
            if (_AudioSampleEnvironmentSetOcclusionRoomRatioFunc == null)
            {
               _AudioSampleEnvironmentSetOcclusionRoomRatioFunc =
                  (_AudioSampleEnvironmentSetOcclusionRoomRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetOcclusionRoomRatio"), typeof(_AudioSampleEnvironmentSetOcclusionRoomRatio));
            }

            _AudioSampleEnvironmentSetOcclusionRoomRatioFunc(audioEnvironment, ratio);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetRoomRolloff(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetRoomRolloff _AudioSampleEnvironmentGetRoomRolloffFunc;
         internal static float AudioSampleEnvironmentGetRoomRolloff(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetRoomRolloffFunc == null)
            {
               _AudioSampleEnvironmentGetRoomRolloffFunc =
                  (_AudioSampleEnvironmentGetRoomRolloff)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetRoomRolloff"), typeof(_AudioSampleEnvironmentGetRoomRolloff));
            }

            return _AudioSampleEnvironmentGetRoomRolloffFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetRoomRolloff(IntPtr audioEnvironment, float rolloff);
         private static _AudioSampleEnvironmentSetRoomRolloff _AudioSampleEnvironmentSetRoomRolloffFunc;
         internal static void AudioSampleEnvironmentSetRoomRolloff(IntPtr audioEnvironment, float rolloff)
         {
            if (_AudioSampleEnvironmentSetRoomRolloffFunc == null)
            {
               _AudioSampleEnvironmentSetRoomRolloffFunc =
                  (_AudioSampleEnvironmentSetRoomRolloff)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetRoomRolloff"), typeof(_AudioSampleEnvironmentSetRoomRolloff));
            }

            _AudioSampleEnvironmentSetRoomRolloffFunc(audioEnvironment, rolloff);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioSampleEnvironmentGetAirAbsorption(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetAirAbsorption _AudioSampleEnvironmentGetAirAbsorptionFunc;
         internal static float AudioSampleEnvironmentGetAirAbsorption(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetAirAbsorptionFunc == null)
            {
               _AudioSampleEnvironmentGetAirAbsorptionFunc =
                  (_AudioSampleEnvironmentGetAirAbsorption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetAirAbsorption"), typeof(_AudioSampleEnvironmentGetAirAbsorption));
            }

            return _AudioSampleEnvironmentGetAirAbsorptionFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetAirAbsorption(IntPtr audioEnvironment, float absorption);
         private static _AudioSampleEnvironmentSetAirAbsorption _AudioSampleEnvironmentSetAirAbsorptionFunc;
         internal static void AudioSampleEnvironmentSetAirAbsorption(IntPtr audioEnvironment, float absorption)
         {
            if (_AudioSampleEnvironmentSetAirAbsorptionFunc == null)
            {
               _AudioSampleEnvironmentSetAirAbsorptionFunc =
                  (_AudioSampleEnvironmentSetAirAbsorption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetAirAbsorption"), typeof(_AudioSampleEnvironmentSetAirAbsorption));
            }

            _AudioSampleEnvironmentSetAirAbsorptionFunc(audioEnvironment, absorption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioSampleEnvironmentGetOutsideVolumeHF(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetOutsideVolumeHF _AudioSampleEnvironmentGetOutsideVolumeHFFunc;
         internal static int AudioSampleEnvironmentGetOutsideVolumeHF(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetOutsideVolumeHFFunc == null)
            {
               _AudioSampleEnvironmentGetOutsideVolumeHFFunc =
                  (_AudioSampleEnvironmentGetOutsideVolumeHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetOutsideVolumeHF"), typeof(_AudioSampleEnvironmentGetOutsideVolumeHF));
            }

            return _AudioSampleEnvironmentGetOutsideVolumeHFFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetOutsideVolumeHF(IntPtr audioEnvironment, int volume);
         private static _AudioSampleEnvironmentSetOutsideVolumeHF _AudioSampleEnvironmentSetOutsideVolumeHFFunc;
         internal static void AudioSampleEnvironmentSetOutsideVolumeHF(IntPtr audioEnvironment, int volume)
         {
            if (_AudioSampleEnvironmentSetOutsideVolumeHFFunc == null)
            {
               _AudioSampleEnvironmentSetOutsideVolumeHFFunc =
                  (_AudioSampleEnvironmentSetOutsideVolumeHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetOutsideVolumeHF"), typeof(_AudioSampleEnvironmentSetOutsideVolumeHF));
            }

            _AudioSampleEnvironmentSetOutsideVolumeHFFunc(audioEnvironment, volume);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioSampleEnvironmentGetFlags(IntPtr audioEnvironment);
         private static _AudioSampleEnvironmentGetFlags _AudioSampleEnvironmentGetFlagsFunc;
         internal static int AudioSampleEnvironmentGetFlags(IntPtr audioEnvironment)
         {
            if (_AudioSampleEnvironmentGetFlagsFunc == null)
            {
               _AudioSampleEnvironmentGetFlagsFunc =
                  (_AudioSampleEnvironmentGetFlags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentGetFlags"), typeof(_AudioSampleEnvironmentGetFlags));
            }

            return _AudioSampleEnvironmentGetFlagsFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioSampleEnvironmentSetFlags(IntPtr audioEnvironment, int flags);
         private static _AudioSampleEnvironmentSetFlags _AudioSampleEnvironmentSetFlagsFunc;
         internal static void AudioSampleEnvironmentSetFlags(IntPtr audioEnvironment, int flags)
         {
            if (_AudioSampleEnvironmentSetFlagsFunc == null)
            {
               _AudioSampleEnvironmentSetFlagsFunc =
                  (_AudioSampleEnvironmentSetFlags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentSetFlags"), typeof(_AudioSampleEnvironmentSetFlags));
            }

            _AudioSampleEnvironmentSetFlagsFunc(audioEnvironment, flags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioSampleEnvironmentCreateInstance();
         private static _AudioSampleEnvironmentCreateInstance _AudioSampleEnvironmentCreateInstanceFunc;
         internal static IntPtr AudioSampleEnvironmentCreateInstance()
         {
            if (_AudioSampleEnvironmentCreateInstanceFunc == null)
            {
               _AudioSampleEnvironmentCreateInstanceFunc =
                  (_AudioSampleEnvironmentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioSampleEnvironmentCreateInstance"), typeof(_AudioSampleEnvironmentCreateInstance));
            }

            return _AudioSampleEnvironmentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public int Direct
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetDirect(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetDirect(ObjectPtr->ObjPtr, value);
         }
      }
      public int DirectHF
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetDirectHF(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetDirectHF(ObjectPtr->ObjPtr, value);
         }
      }
      public int Room
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetRoom(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetRoom(ObjectPtr->ObjPtr, value);
         }
      }
      public float Obstruction
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetObstruction(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetObstruction(ObjectPtr->ObjPtr, value);
         }
      }
      public float ObstructionLFRatio
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetObstructionLFRatio(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetObstructionLFRatio(ObjectPtr->ObjPtr, value);
         }
      }
      public float Occlusion
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetOcclusion(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetOcclusion(ObjectPtr->ObjPtr, value);
         }
      }
      public float OcclusionLFRatio
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetOcclusionLFRatio(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetOcclusionLFRatio(ObjectPtr->ObjPtr, value);
         }
      }
      public float OcclusionRoomRatio
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetOcclusionRoomRatio(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetOcclusionRoomRatio(ObjectPtr->ObjPtr, value);
         }
      }
      public float RoomRolloff
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetRoomRolloff(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetRoomRolloff(ObjectPtr->ObjPtr, value);
         }
      }
      public float AirAbsorption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetAirAbsorption(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetAirAbsorption(ObjectPtr->ObjPtr, value);
         }
      }
      public int OutsideVolumeHF
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetOutsideVolumeHF(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetOutsideVolumeHF(ObjectPtr->ObjPtr, value);
         }
      }
      public int Flags
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioSampleEnvironmentGetFlags(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioSampleEnvironmentSetFlags(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}