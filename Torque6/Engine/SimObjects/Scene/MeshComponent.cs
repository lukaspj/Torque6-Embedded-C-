using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class MeshComponent : BaseComponent
   {
      
      public MeshComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MeshComponentCreateInstance());
      }

      public MeshComponent(uint pId) : base(pId)
      {
      }

      public MeshComponent(string pName) : base(pName)
      {
      }

      public MeshComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MeshComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MeshComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshComponentGetMeshAsset(IntPtr MeshComponent);
         private static _MeshComponentGetMeshAsset _MeshComponentGetMeshAssetFunc;
         internal static IntPtr MeshComponentGetMeshAsset(IntPtr MeshComponent)
         {
            if (_MeshComponentGetMeshAssetFunc == null)
            {
               _MeshComponentGetMeshAssetFunc =
                  (_MeshComponentGetMeshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshComponentGetMeshAsset"), typeof(_MeshComponentGetMeshAsset));
            }

            return _MeshComponentGetMeshAssetFunc(MeshComponent);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MeshComponentSetMeshAsset(IntPtr MeshComponent, string meshAssetId);
         private static _MeshComponentSetMeshAsset _MeshComponentSetMeshAssetFunc;
         internal static void MeshComponentSetMeshAsset(IntPtr MeshComponent, string meshAssetId)
         {
            if (_MeshComponentSetMeshAssetFunc == null)
            {
               _MeshComponentSetMeshAssetFunc =
                  (_MeshComponentSetMeshAsset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshComponentSetMeshAsset"), typeof(_MeshComponentSetMeshAsset));
            }

            _MeshComponentSetMeshAssetFunc(MeshComponent, meshAssetId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshComponentCreateInstance();
         private static _MeshComponentCreateInstance _MeshComponentCreateInstanceFunc;
         internal static IntPtr MeshComponentCreateInstance()
         {
            if (_MeshComponentCreateInstanceFunc == null)
            {
               _MeshComponentCreateInstanceFunc =
                  (_MeshComponentCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshComponentCreateInstance"), typeof(_MeshComponentCreateInstance));
            }

            return _MeshComponentCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string MeshAsset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MeshComponentGetMeshAsset(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MeshComponentSetMeshAsset(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}