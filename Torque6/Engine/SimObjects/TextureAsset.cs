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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr TextureAssetCreateInstance();
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}