using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiCursor : SimObject
   {
      
      public GuiCursor()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiCursorCreateInstance());
      }

      public GuiCursor(uint pId) : base(pId)
      {
      }

      public GuiCursor(string pName) : base(pName)
      {
      }

      public GuiCursor(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCursor(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCursor(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCursorGetHotSpot(IntPtr guiCursor, out Point2I outPoint);
         private static _GuiCursorGetHotSpot _GuiCursorGetHotSpotFunc;
         internal static void GuiCursorGetHotSpot(IntPtr guiCursor, out Point2I outPoint)
         {
            if (_GuiCursorGetHotSpotFunc == null)
            {
               _GuiCursorGetHotSpotFunc =
                  (_GuiCursorGetHotSpot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorGetHotSpot"), typeof(_GuiCursorGetHotSpot));
            }

            _GuiCursorGetHotSpotFunc(guiCursor, out outPoint);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCursorSetHotSpot(IntPtr guiCursor, Point2I value);
         private static _GuiCursorSetHotSpot _GuiCursorSetHotSpotFunc;
         internal static void GuiCursorSetHotSpot(IntPtr guiCursor, Point2I value)
         {
            if (_GuiCursorSetHotSpotFunc == null)
            {
               _GuiCursorSetHotSpotFunc =
                  (_GuiCursorSetHotSpot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorSetHotSpot"), typeof(_GuiCursorSetHotSpot));
            }

            _GuiCursorSetHotSpotFunc(guiCursor, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCursorGetRenderOffset(IntPtr guiCursor, out Point2F outPoint);
         private static _GuiCursorGetRenderOffset _GuiCursorGetRenderOffsetFunc;
         internal static void GuiCursorGetRenderOffset(IntPtr guiCursor, out Point2F outPoint)
         {
            if (_GuiCursorGetRenderOffsetFunc == null)
            {
               _GuiCursorGetRenderOffsetFunc =
                  (_GuiCursorGetRenderOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorGetRenderOffset"), typeof(_GuiCursorGetRenderOffset));
            }

            _GuiCursorGetRenderOffsetFunc(guiCursor, out outPoint);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCursorSetRenderOffset(IntPtr guiCursor, Point2F value);
         private static _GuiCursorSetRenderOffset _GuiCursorSetRenderOffsetFunc;
         internal static void GuiCursorSetRenderOffset(IntPtr guiCursor, Point2F value)
         {
            if (_GuiCursorSetRenderOffsetFunc == null)
            {
               _GuiCursorSetRenderOffsetFunc =
                  (_GuiCursorSetRenderOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorSetRenderOffset"), typeof(_GuiCursorSetRenderOffset));
            }

            _GuiCursorSetRenderOffsetFunc(guiCursor, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCursorGetBitmapName(IntPtr guiCursor);
         private static _GuiCursorGetBitmapName _GuiCursorGetBitmapNameFunc;
         internal static IntPtr GuiCursorGetBitmapName(IntPtr guiCursor)
         {
            if (_GuiCursorGetBitmapNameFunc == null)
            {
               _GuiCursorGetBitmapNameFunc =
                  (_GuiCursorGetBitmapName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorGetBitmapName"), typeof(_GuiCursorGetBitmapName));
            }

            return _GuiCursorGetBitmapNameFunc(guiCursor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCursorSetBitmapName(IntPtr guiCursor, string value);
         private static _GuiCursorSetBitmapName _GuiCursorSetBitmapNameFunc;
         internal static void GuiCursorSetBitmapName(IntPtr guiCursor, string value)
         {
            if (_GuiCursorSetBitmapNameFunc == null)
            {
               _GuiCursorSetBitmapNameFunc =
                  (_GuiCursorSetBitmapName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorSetBitmapName"), typeof(_GuiCursorSetBitmapName));
            }

            _GuiCursorSetBitmapNameFunc(guiCursor, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCursorCreateInstance();
         private static _GuiCursorCreateInstance _GuiCursorCreateInstanceFunc;
         internal static IntPtr GuiCursorCreateInstance()
         {
            if (_GuiCursorCreateInstanceFunc == null)
            {
               _GuiCursorCreateInstanceFunc =
                  (_GuiCursorCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCursorCreateInstance"), typeof(_GuiCursorCreateInstance));
            }

            return _GuiCursorCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public Point2I HotSpot
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2I outVal;
            InternalUnsafeMethods.GuiCursorGetHotSpot(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCursorSetHotSpot(ObjectPtr->ObjPtr, value);
         }
      }
      public Point2F RenderOffset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Point2F outVal;
            InternalUnsafeMethods.GuiCursorGetRenderOffset(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCursorSetRenderOffset(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiCursorGetBitmapName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCursorSetBitmapName(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}