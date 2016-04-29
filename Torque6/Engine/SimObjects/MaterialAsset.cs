using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class MaterialAsset : AssetBase
   {
      
      public MaterialAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MaterialAssetCreateInstance());
      }

      public MaterialAsset(uint pId) : base(pId)
      {
      }

      public MaterialAsset(string pName) : base(pName)
      {
      }

      public MaterialAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MaterialAssetGetTemplateFile(IntPtr materialAsset);
         private static _MaterialAssetGetTemplateFile _MaterialAssetGetTemplateFileFunc;
         internal static IntPtr MaterialAssetGetTemplateFile(IntPtr materialAsset)
         {
            if (_MaterialAssetGetTemplateFileFunc == null)
            {
               _MaterialAssetGetTemplateFileFunc =
                  (_MaterialAssetGetTemplateFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MaterialAssetGetTemplateFile"), typeof(_MaterialAssetGetTemplateFile));
            }

            return _MaterialAssetGetTemplateFileFunc(materialAsset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MaterialAssetCreateInstance();
         private static _MaterialAssetCreateInstance _MaterialAssetCreateInstanceFunc;
         internal static IntPtr MaterialAssetCreateInstance()
         {
            if (_MaterialAssetCreateInstanceFunc == null)
            {
               _MaterialAssetCreateInstanceFunc =
                  (_MaterialAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "MaterialAssetCreateInstance"), typeof(_MaterialAssetCreateInstance));
            }

            return _MaterialAssetCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string TemplateFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MaterialAssetGetTemplateFile(ObjectPtr->ObjPtr));
         }

      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}