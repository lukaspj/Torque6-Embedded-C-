using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class TextureAsset : AssetBase
   {
      
      public TextureAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TextureAssetCreateInstance());
      }

      public TextureAsset(uint pId) : base(pId)
      {
      }

      public TextureAsset(string pName) : base(pName)
      {
      }

      public TextureAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public TextureAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public TextureAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TextureAssetCreateInstance();
         private static _TextureAssetCreateInstance _TextureAssetCreateInstanceFunc;
         internal static IntPtr TextureAssetCreateInstance()
         {
            if (_TextureAssetCreateInstanceFunc == null)
            {
               _TextureAssetCreateInstanceFunc =
                  (_TextureAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureAssetCreateInstance"), typeof(_TextureAssetCreateInstance));
            }

            return _TextureAssetCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}