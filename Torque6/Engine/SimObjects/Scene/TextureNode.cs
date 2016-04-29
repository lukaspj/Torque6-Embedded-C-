using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class TextureNode : BaseNode
   {
      
      public TextureNode()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.TextureNodeCreateInstance());
      }

      public TextureNode(uint pId) : base(pId)
      {
      }

      public TextureNode(string pName) : base(pName)
      {
      }

      public TextureNode(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public TextureNode(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public TextureNode(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _TextureNodeGetSlot(IntPtr textureNode);
         private static _TextureNodeGetSlot _TextureNodeGetSlotFunc;
         internal static int TextureNodeGetSlot(IntPtr textureNode)
         {
            if (_TextureNodeGetSlotFunc == null)
            {
               _TextureNodeGetSlotFunc =
                  (_TextureNodeGetSlot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureNodeGetSlot"), typeof(_TextureNodeGetSlot));
            }

            return _TextureNodeGetSlotFunc(textureNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TextureNodeSetSlot(IntPtr textureNode, int slot);
         private static _TextureNodeSetSlot _TextureNodeSetSlotFunc;
         internal static void TextureNodeSetSlot(IntPtr textureNode, int slot)
         {
            if (_TextureNodeSetSlotFunc == null)
            {
               _TextureNodeSetSlotFunc =
                  (_TextureNodeSetSlot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureNodeSetSlot"), typeof(_TextureNodeSetSlot));
            }

            _TextureNodeSetSlotFunc(textureNode, slot);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _TextureNodeGetPremultiplyAlpha(IntPtr textureNode);
         private static _TextureNodeGetPremultiplyAlpha _TextureNodeGetPremultiplyAlphaFunc;
         internal static bool TextureNodeGetPremultiplyAlpha(IntPtr textureNode)
         {
            if (_TextureNodeGetPremultiplyAlphaFunc == null)
            {
               _TextureNodeGetPremultiplyAlphaFunc =
                  (_TextureNodeGetPremultiplyAlpha)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureNodeGetPremultiplyAlpha"), typeof(_TextureNodeGetPremultiplyAlpha));
            }

            return _TextureNodeGetPremultiplyAlphaFunc(textureNode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _TextureNodeSetPremultiplyAlpha(IntPtr textureNode, bool val);
         private static _TextureNodeSetPremultiplyAlpha _TextureNodeSetPremultiplyAlphaFunc;
         internal static void TextureNodeSetPremultiplyAlpha(IntPtr textureNode, bool val)
         {
            if (_TextureNodeSetPremultiplyAlphaFunc == null)
            {
               _TextureNodeSetPremultiplyAlphaFunc =
                  (_TextureNodeSetPremultiplyAlpha)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureNodeSetPremultiplyAlpha"), typeof(_TextureNodeSetPremultiplyAlpha));
            }

            _TextureNodeSetPremultiplyAlphaFunc(textureNode, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TextureNodeCreateInstance();
         private static _TextureNodeCreateInstance _TextureNodeCreateInstanceFunc;
         internal static IntPtr TextureNodeCreateInstance()
         {
            if (_TextureNodeCreateInstanceFunc == null)
            {
               _TextureNodeCreateInstanceFunc =
                  (_TextureNodeCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "TextureNodeCreateInstance"), typeof(_TextureNodeCreateInstance));
            }

            return _TextureNodeCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public int Slot
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TextureNodeGetSlot(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TextureNodeSetSlot(ObjectPtr->ObjPtr, value);
         }
      }
      public bool PremultiplyAlpha
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.TextureNodeGetPremultiplyAlpha(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.TextureNodeSetPremultiplyAlpha(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}