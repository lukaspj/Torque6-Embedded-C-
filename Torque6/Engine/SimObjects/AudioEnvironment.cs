using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class AudioEnvironment : SimDataBlock
   {
      
      public AudioEnvironment()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AudioEnvironmentCreateInstance());
      }

      public AudioEnvironment(uint pId) : base(pId)
      {
      }

      public AudioEnvironment(string pName) : base(pName)
      {
      }

      public AudioEnvironment(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AudioEnvironment(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AudioEnvironment(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _AudioEnvironmentGetUseRoom(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetUseRoom _AudioEnvironmentGetUseRoomFunc;
         internal static bool AudioEnvironmentGetUseRoom(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetUseRoomFunc == null)
            {
               _AudioEnvironmentGetUseRoomFunc =
                  (_AudioEnvironmentGetUseRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetUseRoom"), typeof(_AudioEnvironmentGetUseRoom));
            }

            return _AudioEnvironmentGetUseRoomFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetUseRoom(IntPtr audioEnvironment, bool useRoom);
         private static _AudioEnvironmentSetUseRoom _AudioEnvironmentSetUseRoomFunc;
         internal static void AudioEnvironmentSetUseRoom(IntPtr audioEnvironment, bool useRoom)
         {
            if (_AudioEnvironmentSetUseRoomFunc == null)
            {
               _AudioEnvironmentSetUseRoomFunc =
                  (_AudioEnvironmentSetUseRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetUseRoom"), typeof(_AudioEnvironmentSetUseRoom));
            }

            _AudioEnvironmentSetUseRoomFunc(audioEnvironment, useRoom);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetRoom(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetRoom _AudioEnvironmentGetRoomFunc;
         internal static int AudioEnvironmentGetRoom(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetRoomFunc == null)
            {
               _AudioEnvironmentGetRoomFunc =
                  (_AudioEnvironmentGetRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetRoom"), typeof(_AudioEnvironmentGetRoom));
            }

            return _AudioEnvironmentGetRoomFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetRoom(IntPtr audioEnvironment, int room);
         private static _AudioEnvironmentSetRoom _AudioEnvironmentSetRoomFunc;
         internal static void AudioEnvironmentSetRoom(IntPtr audioEnvironment, int room)
         {
            if (_AudioEnvironmentSetRoomFunc == null)
            {
               _AudioEnvironmentSetRoomFunc =
                  (_AudioEnvironmentSetRoom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetRoom"), typeof(_AudioEnvironmentSetRoom));
            }

            _AudioEnvironmentSetRoomFunc(audioEnvironment, room);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetRoomHF(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetRoomHF _AudioEnvironmentGetRoomHFFunc;
         internal static int AudioEnvironmentGetRoomHF(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetRoomHFFunc == null)
            {
               _AudioEnvironmentGetRoomHFFunc =
                  (_AudioEnvironmentGetRoomHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetRoomHF"), typeof(_AudioEnvironmentGetRoomHF));
            }

            return _AudioEnvironmentGetRoomHFFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetRoomHF(IntPtr audioEnvironment, int room);
         private static _AudioEnvironmentSetRoomHF _AudioEnvironmentSetRoomHFFunc;
         internal static void AudioEnvironmentSetRoomHF(IntPtr audioEnvironment, int room)
         {
            if (_AudioEnvironmentSetRoomHFFunc == null)
            {
               _AudioEnvironmentSetRoomHFFunc =
                  (_AudioEnvironmentSetRoomHF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetRoomHF"), typeof(_AudioEnvironmentSetRoomHF));
            }

            _AudioEnvironmentSetRoomHFFunc(audioEnvironment, room);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetReflections(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetReflections _AudioEnvironmentGetReflectionsFunc;
         internal static int AudioEnvironmentGetReflections(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetReflectionsFunc == null)
            {
               _AudioEnvironmentGetReflectionsFunc =
                  (_AudioEnvironmentGetReflections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetReflections"), typeof(_AudioEnvironmentGetReflections));
            }

            return _AudioEnvironmentGetReflectionsFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetReflections(IntPtr audioEnvironment, int reflections);
         private static _AudioEnvironmentSetReflections _AudioEnvironmentSetReflectionsFunc;
         internal static void AudioEnvironmentSetReflections(IntPtr audioEnvironment, int reflections)
         {
            if (_AudioEnvironmentSetReflectionsFunc == null)
            {
               _AudioEnvironmentSetReflectionsFunc =
                  (_AudioEnvironmentSetReflections)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetReflections"), typeof(_AudioEnvironmentSetReflections));
            }

            _AudioEnvironmentSetReflectionsFunc(audioEnvironment, reflections);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetReverb(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetReverb _AudioEnvironmentGetReverbFunc;
         internal static int AudioEnvironmentGetReverb(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetReverbFunc == null)
            {
               _AudioEnvironmentGetReverbFunc =
                  (_AudioEnvironmentGetReverb)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetReverb"), typeof(_AudioEnvironmentGetReverb));
            }

            return _AudioEnvironmentGetReverbFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetReverb(IntPtr audioEnvironment, int reverb);
         private static _AudioEnvironmentSetReverb _AudioEnvironmentSetReverbFunc;
         internal static void AudioEnvironmentSetReverb(IntPtr audioEnvironment, int reverb)
         {
            if (_AudioEnvironmentSetReverbFunc == null)
            {
               _AudioEnvironmentSetReverbFunc =
                  (_AudioEnvironmentSetReverb)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetReverb"), typeof(_AudioEnvironmentSetReverb));
            }

            _AudioEnvironmentSetReverbFunc(audioEnvironment, reverb);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetRoomRolloffFactor(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetRoomRolloffFactor _AudioEnvironmentGetRoomRolloffFactorFunc;
         internal static float AudioEnvironmentGetRoomRolloffFactor(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetRoomRolloffFactorFunc == null)
            {
               _AudioEnvironmentGetRoomRolloffFactorFunc =
                  (_AudioEnvironmentGetRoomRolloffFactor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetRoomRolloffFactor"), typeof(_AudioEnvironmentGetRoomRolloffFactor));
            }

            return _AudioEnvironmentGetRoomRolloffFactorFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetRoomRolloffFactor(IntPtr audioEnvironment, float factor);
         private static _AudioEnvironmentSetRoomRolloffFactor _AudioEnvironmentSetRoomRolloffFactorFunc;
         internal static void AudioEnvironmentSetRoomRolloffFactor(IntPtr audioEnvironment, float factor)
         {
            if (_AudioEnvironmentSetRoomRolloffFactorFunc == null)
            {
               _AudioEnvironmentSetRoomRolloffFactorFunc =
                  (_AudioEnvironmentSetRoomRolloffFactor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetRoomRolloffFactor"), typeof(_AudioEnvironmentSetRoomRolloffFactor));
            }

            _AudioEnvironmentSetRoomRolloffFactorFunc(audioEnvironment, factor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetDecayTime(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetDecayTime _AudioEnvironmentGetDecayTimeFunc;
         internal static float AudioEnvironmentGetDecayTime(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetDecayTimeFunc == null)
            {
               _AudioEnvironmentGetDecayTimeFunc =
                  (_AudioEnvironmentGetDecayTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetDecayTime"), typeof(_AudioEnvironmentGetDecayTime));
            }

            return _AudioEnvironmentGetDecayTimeFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetDecayTime(IntPtr audioEnvironment, float time);
         private static _AudioEnvironmentSetDecayTime _AudioEnvironmentSetDecayTimeFunc;
         internal static void AudioEnvironmentSetDecayTime(IntPtr audioEnvironment, float time)
         {
            if (_AudioEnvironmentSetDecayTimeFunc == null)
            {
               _AudioEnvironmentSetDecayTimeFunc =
                  (_AudioEnvironmentSetDecayTime)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetDecayTime"), typeof(_AudioEnvironmentSetDecayTime));
            }

            _AudioEnvironmentSetDecayTimeFunc(audioEnvironment, time);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetDecayHFRatio(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetDecayHFRatio _AudioEnvironmentGetDecayHFRatioFunc;
         internal static float AudioEnvironmentGetDecayHFRatio(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetDecayHFRatioFunc == null)
            {
               _AudioEnvironmentGetDecayHFRatioFunc =
                  (_AudioEnvironmentGetDecayHFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetDecayHFRatio"), typeof(_AudioEnvironmentGetDecayHFRatio));
            }

            return _AudioEnvironmentGetDecayHFRatioFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetDecayHFRatio(IntPtr audioEnvironment, float ratio);
         private static _AudioEnvironmentSetDecayHFRatio _AudioEnvironmentSetDecayHFRatioFunc;
         internal static void AudioEnvironmentSetDecayHFRatio(IntPtr audioEnvironment, float ratio)
         {
            if (_AudioEnvironmentSetDecayHFRatioFunc == null)
            {
               _AudioEnvironmentSetDecayHFRatioFunc =
                  (_AudioEnvironmentSetDecayHFRatio)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetDecayHFRatio"), typeof(_AudioEnvironmentSetDecayHFRatio));
            }

            _AudioEnvironmentSetDecayHFRatioFunc(audioEnvironment, ratio);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetReflectionsDelay(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetReflectionsDelay _AudioEnvironmentGetReflectionsDelayFunc;
         internal static float AudioEnvironmentGetReflectionsDelay(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetReflectionsDelayFunc == null)
            {
               _AudioEnvironmentGetReflectionsDelayFunc =
                  (_AudioEnvironmentGetReflectionsDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetReflectionsDelay"), typeof(_AudioEnvironmentGetReflectionsDelay));
            }

            return _AudioEnvironmentGetReflectionsDelayFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetReflectionsDelay(IntPtr audioEnvironment, float delay);
         private static _AudioEnvironmentSetReflectionsDelay _AudioEnvironmentSetReflectionsDelayFunc;
         internal static void AudioEnvironmentSetReflectionsDelay(IntPtr audioEnvironment, float delay)
         {
            if (_AudioEnvironmentSetReflectionsDelayFunc == null)
            {
               _AudioEnvironmentSetReflectionsDelayFunc =
                  (_AudioEnvironmentSetReflectionsDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetReflectionsDelay"), typeof(_AudioEnvironmentSetReflectionsDelay));
            }

            _AudioEnvironmentSetReflectionsDelayFunc(audioEnvironment, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetReverbDelay(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetReverbDelay _AudioEnvironmentGetReverbDelayFunc;
         internal static float AudioEnvironmentGetReverbDelay(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetReverbDelayFunc == null)
            {
               _AudioEnvironmentGetReverbDelayFunc =
                  (_AudioEnvironmentGetReverbDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetReverbDelay"), typeof(_AudioEnvironmentGetReverbDelay));
            }

            return _AudioEnvironmentGetReverbDelayFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetReverbDelay(IntPtr audioEnvironment, float delay);
         private static _AudioEnvironmentSetReverbDelay _AudioEnvironmentSetReverbDelayFunc;
         internal static void AudioEnvironmentSetReverbDelay(IntPtr audioEnvironment, float delay)
         {
            if (_AudioEnvironmentSetReverbDelayFunc == null)
            {
               _AudioEnvironmentSetReverbDelayFunc =
                  (_AudioEnvironmentSetReverbDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetReverbDelay"), typeof(_AudioEnvironmentSetReverbDelay));
            }

            _AudioEnvironmentSetReverbDelayFunc(audioEnvironment, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetRoomVolume(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetRoomVolume _AudioEnvironmentGetRoomVolumeFunc;
         internal static int AudioEnvironmentGetRoomVolume(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetRoomVolumeFunc == null)
            {
               _AudioEnvironmentGetRoomVolumeFunc =
                  (_AudioEnvironmentGetRoomVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetRoomVolume"), typeof(_AudioEnvironmentGetRoomVolume));
            }

            return _AudioEnvironmentGetRoomVolumeFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetRoomVolume(IntPtr audioEnvironment, float volume);
         private static _AudioEnvironmentSetRoomVolume _AudioEnvironmentSetRoomVolumeFunc;
         internal static void AudioEnvironmentSetRoomVolume(IntPtr audioEnvironment, float volume)
         {
            if (_AudioEnvironmentSetRoomVolumeFunc == null)
            {
               _AudioEnvironmentSetRoomVolumeFunc =
                  (_AudioEnvironmentSetRoomVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetRoomVolume"), typeof(_AudioEnvironmentSetRoomVolume));
            }

            _AudioEnvironmentSetRoomVolumeFunc(audioEnvironment, volume);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetEffectVolume(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetEffectVolume _AudioEnvironmentGetEffectVolumeFunc;
         internal static float AudioEnvironmentGetEffectVolume(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetEffectVolumeFunc == null)
            {
               _AudioEnvironmentGetEffectVolumeFunc =
                  (_AudioEnvironmentGetEffectVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetEffectVolume"), typeof(_AudioEnvironmentGetEffectVolume));
            }

            return _AudioEnvironmentGetEffectVolumeFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetEffectVolume(IntPtr audioEnvironment, float volume);
         private static _AudioEnvironmentSetEffectVolume _AudioEnvironmentSetEffectVolumeFunc;
         internal static void AudioEnvironmentSetEffectVolume(IntPtr audioEnvironment, float volume)
         {
            if (_AudioEnvironmentSetEffectVolumeFunc == null)
            {
               _AudioEnvironmentSetEffectVolumeFunc =
                  (_AudioEnvironmentSetEffectVolume)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetEffectVolume"), typeof(_AudioEnvironmentSetEffectVolume));
            }

            _AudioEnvironmentSetEffectVolumeFunc(audioEnvironment, volume);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetDamping(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetDamping _AudioEnvironmentGetDampingFunc;
         internal static float AudioEnvironmentGetDamping(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetDampingFunc == null)
            {
               _AudioEnvironmentGetDampingFunc =
                  (_AudioEnvironmentGetDamping)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetDamping"), typeof(_AudioEnvironmentGetDamping));
            }

            return _AudioEnvironmentGetDampingFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetDamping(IntPtr audioEnvironment, float damping);
         private static _AudioEnvironmentSetDamping _AudioEnvironmentSetDampingFunc;
         internal static void AudioEnvironmentSetDamping(IntPtr audioEnvironment, float damping)
         {
            if (_AudioEnvironmentSetDampingFunc == null)
            {
               _AudioEnvironmentSetDampingFunc =
                  (_AudioEnvironmentSetDamping)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetDamping"), typeof(_AudioEnvironmentSetDamping));
            }

            _AudioEnvironmentSetDampingFunc(audioEnvironment, damping);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetEnvironmentSize(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetEnvironmentSize _AudioEnvironmentGetEnvironmentSizeFunc;
         internal static float AudioEnvironmentGetEnvironmentSize(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetEnvironmentSizeFunc == null)
            {
               _AudioEnvironmentGetEnvironmentSizeFunc =
                  (_AudioEnvironmentGetEnvironmentSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetEnvironmentSize"), typeof(_AudioEnvironmentGetEnvironmentSize));
            }

            return _AudioEnvironmentGetEnvironmentSizeFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetEnvironmentSize(IntPtr audioEnvironment, float size);
         private static _AudioEnvironmentSetEnvironmentSize _AudioEnvironmentSetEnvironmentSizeFunc;
         internal static void AudioEnvironmentSetEnvironmentSize(IntPtr audioEnvironment, float size)
         {
            if (_AudioEnvironmentSetEnvironmentSizeFunc == null)
            {
               _AudioEnvironmentSetEnvironmentSizeFunc =
                  (_AudioEnvironmentSetEnvironmentSize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetEnvironmentSize"), typeof(_AudioEnvironmentSetEnvironmentSize));
            }

            _AudioEnvironmentSetEnvironmentSizeFunc(audioEnvironment, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetEnvironmentDiffusion(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetEnvironmentDiffusion _AudioEnvironmentGetEnvironmentDiffusionFunc;
         internal static float AudioEnvironmentGetEnvironmentDiffusion(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetEnvironmentDiffusionFunc == null)
            {
               _AudioEnvironmentGetEnvironmentDiffusionFunc =
                  (_AudioEnvironmentGetEnvironmentDiffusion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetEnvironmentDiffusion"), typeof(_AudioEnvironmentGetEnvironmentDiffusion));
            }

            return _AudioEnvironmentGetEnvironmentDiffusionFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetEnvironmentDiffusion(IntPtr audioEnvironment, float diffusion);
         private static _AudioEnvironmentSetEnvironmentDiffusion _AudioEnvironmentSetEnvironmentDiffusionFunc;
         internal static void AudioEnvironmentSetEnvironmentDiffusion(IntPtr audioEnvironment, float diffusion)
         {
            if (_AudioEnvironmentSetEnvironmentDiffusionFunc == null)
            {
               _AudioEnvironmentSetEnvironmentDiffusionFunc =
                  (_AudioEnvironmentSetEnvironmentDiffusion)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetEnvironmentDiffusion"), typeof(_AudioEnvironmentSetEnvironmentDiffusion));
            }

            _AudioEnvironmentSetEnvironmentDiffusionFunc(audioEnvironment, diffusion);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AudioEnvironmentGetAirAbsorption(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetAirAbsorption _AudioEnvironmentGetAirAbsorptionFunc;
         internal static float AudioEnvironmentGetAirAbsorption(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetAirAbsorptionFunc == null)
            {
               _AudioEnvironmentGetAirAbsorptionFunc =
                  (_AudioEnvironmentGetAirAbsorption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetAirAbsorption"), typeof(_AudioEnvironmentGetAirAbsorption));
            }

            return _AudioEnvironmentGetAirAbsorptionFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetAirAbsorption(IntPtr audioEnvironment, float absorption);
         private static _AudioEnvironmentSetAirAbsorption _AudioEnvironmentSetAirAbsorptionFunc;
         internal static void AudioEnvironmentSetAirAbsorption(IntPtr audioEnvironment, float absorption)
         {
            if (_AudioEnvironmentSetAirAbsorptionFunc == null)
            {
               _AudioEnvironmentSetAirAbsorptionFunc =
                  (_AudioEnvironmentSetAirAbsorption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetAirAbsorption"), typeof(_AudioEnvironmentSetAirAbsorption));
            }

            _AudioEnvironmentSetAirAbsorptionFunc(audioEnvironment, absorption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _AudioEnvironmentGetFlags(IntPtr audioEnvironment);
         private static _AudioEnvironmentGetFlags _AudioEnvironmentGetFlagsFunc;
         internal static int AudioEnvironmentGetFlags(IntPtr audioEnvironment)
         {
            if (_AudioEnvironmentGetFlagsFunc == null)
            {
               _AudioEnvironmentGetFlagsFunc =
                  (_AudioEnvironmentGetFlags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentGetFlags"), typeof(_AudioEnvironmentGetFlags));
            }

            return _AudioEnvironmentGetFlagsFunc(audioEnvironment);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AudioEnvironmentSetFlags(IntPtr audioEnvironment, int flags);
         private static _AudioEnvironmentSetFlags _AudioEnvironmentSetFlagsFunc;
         internal static void AudioEnvironmentSetFlags(IntPtr audioEnvironment, int flags)
         {
            if (_AudioEnvironmentSetFlagsFunc == null)
            {
               _AudioEnvironmentSetFlagsFunc =
                  (_AudioEnvironmentSetFlags)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentSetFlags"), typeof(_AudioEnvironmentSetFlags));
            }

            _AudioEnvironmentSetFlagsFunc(audioEnvironment, flags);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AudioEnvironmentCreateInstance();
         private static _AudioEnvironmentCreateInstance _AudioEnvironmentCreateInstanceFunc;
         internal static IntPtr AudioEnvironmentCreateInstance()
         {
            if (_AudioEnvironmentCreateInstanceFunc == null)
            {
               _AudioEnvironmentCreateInstanceFunc =
                  (_AudioEnvironmentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AudioEnvironmentCreateInstance"), typeof(_AudioEnvironmentCreateInstance));
            }

            return _AudioEnvironmentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool UseRoom
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetUseRoom(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetUseRoom(ObjectPtr->ObjPtr, value);
         }
      }
      public int Room
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetRoom(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetRoom(ObjectPtr->ObjPtr, value);
         }
      }
      public int RoomHF
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetRoomHF(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetRoomHF(ObjectPtr->ObjPtr, value);
         }
      }
      public int Reflections
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetReflections(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetReflections(ObjectPtr->ObjPtr, value);
         }
      }
      public int Reverb
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetReverb(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetReverb(ObjectPtr->ObjPtr, value);
         }
      }
      public float RoomRolloffFactor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetRoomRolloffFactor(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetRoomRolloffFactor(ObjectPtr->ObjPtr, value);
         }
      }
      public float DecayTime
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetDecayTime(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetDecayTime(ObjectPtr->ObjPtr, value);
         }
      }
      public float DecayHFRatio
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetDecayHFRatio(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetDecayHFRatio(ObjectPtr->ObjPtr, value);
         }
      }
      public float ReflectionsDelay
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetReflectionsDelay(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetReflectionsDelay(ObjectPtr->ObjPtr, value);
         }
      }
      public float ReverbDelay
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetReverbDelay(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetReverbDelay(ObjectPtr->ObjPtr, value);
         }
      }
      public float RoomVolume
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetRoomVolume(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetRoomVolume(ObjectPtr->ObjPtr, value);
         }
      }
      public float EffectVolume
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetEffectVolume(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetEffectVolume(ObjectPtr->ObjPtr, value);
         }
      }
      public float Damping
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetDamping(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetDamping(ObjectPtr->ObjPtr, value);
         }
      }
      public float EnvironmentSize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetEnvironmentSize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetEnvironmentSize(ObjectPtr->ObjPtr, value);
         }
      }
      public float EnvironmentDiffusion
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetEnvironmentDiffusion(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetEnvironmentDiffusion(ObjectPtr->ObjPtr, value);
         }
      }
      public float AirAbsorption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetAirAbsorption(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetAirAbsorption(ObjectPtr->ObjPtr, value);
         }
      }
      public int Flags
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AudioEnvironmentGetFlags(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AudioEnvironmentSetFlags(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}