using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiDragAndDropControl : GuiControl
   {
      
      public GuiDragAndDropControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiDragAndDropControlCreateInstance());
      }

      public GuiDragAndDropControl(uint pId) : base(pId)
      {
      }

      public GuiDragAndDropControl(string pName) : base(pName)
      {
      }

      public GuiDragAndDropControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiDragAndDropControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiDragAndDropControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiDragAndDropControlGetDeleteOnMouseUp(IntPtr ctrl);
         private static _GuiDragAndDropControlGetDeleteOnMouseUp _GuiDragAndDropControlGetDeleteOnMouseUpFunc;
         internal static bool GuiDragAndDropControlGetDeleteOnMouseUp(IntPtr ctrl)
         {
            if (_GuiDragAndDropControlGetDeleteOnMouseUpFunc == null)
            {
               _GuiDragAndDropControlGetDeleteOnMouseUpFunc =
                  (_GuiDragAndDropControlGetDeleteOnMouseUp)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDragAndDropControlGetDeleteOnMouseUp"), typeof(_GuiDragAndDropControlGetDeleteOnMouseUp));
            }

            return _GuiDragAndDropControlGetDeleteOnMouseUpFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDragAndDropControlSetDeleteOnMouseUp(IntPtr ctrl, bool deleteOnMouseUp);
         private static _GuiDragAndDropControlSetDeleteOnMouseUp _GuiDragAndDropControlSetDeleteOnMouseUpFunc;
         internal static void GuiDragAndDropControlSetDeleteOnMouseUp(IntPtr ctrl, bool deleteOnMouseUp)
         {
            if (_GuiDragAndDropControlSetDeleteOnMouseUpFunc == null)
            {
               _GuiDragAndDropControlSetDeleteOnMouseUpFunc =
                  (_GuiDragAndDropControlSetDeleteOnMouseUp)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDragAndDropControlSetDeleteOnMouseUp"), typeof(_GuiDragAndDropControlSetDeleteOnMouseUp));
            }

            _GuiDragAndDropControlSetDeleteOnMouseUpFunc(ctrl, deleteOnMouseUp);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDragAndDropControlCreateInstance();
         private static _GuiDragAndDropControlCreateInstance _GuiDragAndDropControlCreateInstanceFunc;
         internal static IntPtr GuiDragAndDropControlCreateInstance()
         {
            if (_GuiDragAndDropControlCreateInstanceFunc == null)
            {
               _GuiDragAndDropControlCreateInstanceFunc =
                  (_GuiDragAndDropControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDragAndDropControlCreateInstance"), typeof(_GuiDragAndDropControlCreateInstance));
            }

            return _GuiDragAndDropControlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiDragAndDropControlStartDragging(IntPtr ctrl, Point2I offset);
         private static _GuiDragAndDropControlStartDragging _GuiDragAndDropControlStartDraggingFunc;
         internal static void GuiDragAndDropControlStartDragging(IntPtr ctrl, Point2I offset)
         {
            if (_GuiDragAndDropControlStartDraggingFunc == null)
            {
               _GuiDragAndDropControlStartDraggingFunc =
                  (_GuiDragAndDropControlStartDragging)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiDragAndDropControlStartDragging"), typeof(_GuiDragAndDropControlStartDragging));
            }

            _GuiDragAndDropControlStartDraggingFunc(ctrl, offset);
         }
      }
      
      #endregion

      #region Properties

      public bool DeleteOnMouseUp
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiDragAndDropControlGetDeleteOnMouseUp(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiDragAndDropControlSetDeleteOnMouseUp(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void StartDragging(Point2I offset)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiDragAndDropControlStartDragging(ObjectPtr->ObjPtr, offset);
      }
      
      #endregion

      
   }
}