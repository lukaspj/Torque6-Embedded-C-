using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class MeshAsset : AssetBase
   {
      
      public MeshAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MeshAssetCreateInstance());
      }

      public MeshAsset(uint pId) : base(pId)
      {
      }

      public MeshAsset(string pName) : base(pName)
      {
      }

      public MeshAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MeshAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MeshAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshAssetGetMeshFile(IntPtr meshAsset);
         private static _MeshAssetGetMeshFile _MeshAssetGetMeshFileFunc;
         internal static IntPtr MeshAssetGetMeshFile(IntPtr meshAsset)
         {
            if (_MeshAssetGetMeshFileFunc == null)
            {
               _MeshAssetGetMeshFileFunc =
                  (_MeshAssetGetMeshFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshAssetGetMeshFile"), typeof(_MeshAssetGetMeshFile));
            }

            return _MeshAssetGetMeshFileFunc(meshAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _MeshAssetSetMeshFile(IntPtr meshAsset, string val);
         private static _MeshAssetSetMeshFile _MeshAssetSetMeshFileFunc;
         internal static void MeshAssetSetMeshFile(IntPtr meshAsset, string val)
         {
            if (_MeshAssetSetMeshFileFunc == null)
            {
               _MeshAssetSetMeshFileFunc =
                  (_MeshAssetSetMeshFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshAssetSetMeshFile"), typeof(_MeshAssetSetMeshFile));
            }

            _MeshAssetSetMeshFileFunc(meshAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshAssetCreateInstance();
         private static _MeshAssetCreateInstance _MeshAssetCreateInstanceFunc;
         internal static IntPtr MeshAssetCreateInstance()
         {
            if (_MeshAssetCreateInstanceFunc == null)
            {
               _MeshAssetCreateInstanceFunc =
                  (_MeshAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MeshAssetCreateInstance"), typeof(_MeshAssetCreateInstance));
            }

            return _MeshAssetCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string MeshFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MeshAssetGetMeshFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MeshAssetSetMeshFile(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}