using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class AnimationComponent : BaseComponent
   {
      
      public AnimationComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.AnimationComponentCreateInstance());
      }

      public AnimationComponent(uint pId) : base(pId)
      {
      }

      public AnimationComponent(string pName) : base(pName)
      {
      }

      public AnimationComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public AnimationComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public AnimationComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _AnimationComponentGetSpeed(IntPtr animationComponent);
         private static _AnimationComponentGetSpeed _AnimationComponentGetSpeedFunc;
         internal static float AnimationComponentGetSpeed(IntPtr animationComponent)
         {
            if (_AnimationComponentGetSpeedFunc == null)
            {
               _AnimationComponentGetSpeedFunc =
                  (_AnimationComponentGetSpeed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentGetSpeed"), typeof(_AnimationComponentGetSpeed));
            }

            return _AnimationComponentGetSpeedFunc(animationComponent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AnimationComponentSetSpeed(IntPtr animationComponent, float val);
         private static _AnimationComponentSetSpeed _AnimationComponentSetSpeedFunc;
         internal static void AnimationComponentSetSpeed(IntPtr animationComponent, float val)
         {
            if (_AnimationComponentSetSpeedFunc == null)
            {
               _AnimationComponentSetSpeedFunc =
                  (_AnimationComponentSetSpeed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentSetSpeed"), typeof(_AnimationComponentSetSpeed));
            }

            _AnimationComponentSetSpeedFunc(animationComponent, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AnimationComponentGetTarget(IntPtr animationComponent);
         private static _AnimationComponentGetTarget _AnimationComponentGetTargetFunc;
         internal static IntPtr AnimationComponentGetTarget(IntPtr animationComponent)
         {
            if (_AnimationComponentGetTargetFunc == null)
            {
               _AnimationComponentGetTargetFunc =
                  (_AnimationComponentGetTarget)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentGetTarget"), typeof(_AnimationComponentGetTarget));
            }

            return _AnimationComponentGetTargetFunc(animationComponent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AnimationComponentSetTarget(IntPtr animationComponent, IntPtr val);
         private static _AnimationComponentSetTarget _AnimationComponentSetTargetFunc;
         internal static void AnimationComponentSetTarget(IntPtr animationComponent, IntPtr val)
         {
            if (_AnimationComponentSetTargetFunc == null)
            {
               _AnimationComponentSetTargetFunc =
                  (_AnimationComponentSetTarget)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentSetTarget"), typeof(_AnimationComponentSetTarget));
            }

            _AnimationComponentSetTargetFunc(animationComponent, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AnimationComponentGetMeshAsset(IntPtr animationComponent);
         private static _AnimationComponentGetMeshAsset _AnimationComponentGetMeshAssetFunc;
         internal static IntPtr AnimationComponentGetMeshAsset(IntPtr animationComponent)
         {
            if (_AnimationComponentGetMeshAssetFunc == null)
            {
               _AnimationComponentGetMeshAssetFunc =
                  (_AnimationComponentGetMeshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentGetMeshAsset"), typeof(_AnimationComponentGetMeshAsset));
            }

            return _AnimationComponentGetMeshAssetFunc(animationComponent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AnimationComponentSetMeshAsset(IntPtr animationComponent, string meshAssetId);
         private static _AnimationComponentSetMeshAsset _AnimationComponentSetMeshAssetFunc;
         internal static void AnimationComponentSetMeshAsset(IntPtr animationComponent, string meshAssetId)
         {
            if (_AnimationComponentSetMeshAssetFunc == null)
            {
               _AnimationComponentSetMeshAssetFunc =
                  (_AnimationComponentSetMeshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentSetMeshAsset"), typeof(_AnimationComponentSetMeshAsset));
            }

            _AnimationComponentSetMeshAssetFunc(animationComponent, meshAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AnimationComponentCreateInstance();
         private static _AnimationComponentCreateInstance _AnimationComponentCreateInstanceFunc;
         internal static IntPtr AnimationComponentCreateInstance()
         {
            if (_AnimationComponentCreateInstanceFunc == null)
            {
               _AnimationComponentCreateInstanceFunc =
                  (_AnimationComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "AnimationComponentCreateInstance"), typeof(_AnimationComponentCreateInstance));
            }

            return _AnimationComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public float Speed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.AnimationComponentGetSpeed(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AnimationComponentSetSpeed(ObjectPtr->ObjPtr, value);
         }
      }
      public MeshComponent Target
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new MeshComponent(InternalUnsafeMethods.AnimationComponentGetTarget(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AnimationComponentSetTarget(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public string MeshAsset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.AnimationComponentGetMeshAsset(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.AnimationComponentSetMeshAsset(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}