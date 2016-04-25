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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiCursorGetHotSpot(IntPtr guiCursor, out Point2I outPoint);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiCursorSetHotSpot(IntPtr guiCursor, Point2I value);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiCursorGetRenderOffset(IntPtr guiCursor, out Point2F outPoint);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiCursorSetRenderOffset(IntPtr guiCursor, Point2F value);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string GuiCursorGetBitmapName(IntPtr guiCursor);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiCursorSetBitmapName(IntPtr guiCursor, string value);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiCursorCreateInstance();
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