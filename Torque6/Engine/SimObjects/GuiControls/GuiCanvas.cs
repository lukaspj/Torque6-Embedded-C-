using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiCanvas : GuiControl
   {
      
      public GuiCanvas()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiCanvasCreateInstance());
      }

      public GuiCanvas(uint pId) : base(pId)
      {
      }

      public GuiCanvas(string pName) : base(pName)
      {
      }

      public GuiCanvas(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCanvas(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiCanvas(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiCanvasGetUseBackgroundColor(IntPtr canvas);
         private static _GuiCanvasGetUseBackgroundColor _GuiCanvasGetUseBackgroundColorFunc;
         internal static bool GuiCanvasGetUseBackgroundColor(IntPtr canvas)
         {
            if (_GuiCanvasGetUseBackgroundColorFunc == null)
            {
               _GuiCanvasGetUseBackgroundColorFunc =
                  (_GuiCanvasGetUseBackgroundColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasGetUseBackgroundColor"), typeof(_GuiCanvasGetUseBackgroundColor));
            }

            return _GuiCanvasGetUseBackgroundColorFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetUseBackgroundColor(IntPtr canvas, bool use);
         private static _GuiCanvasSetUseBackgroundColor _GuiCanvasSetUseBackgroundColorFunc;
         internal static void GuiCanvasSetUseBackgroundColor(IntPtr canvas, bool use)
         {
            if (_GuiCanvasSetUseBackgroundColorFunc == null)
            {
               _GuiCanvasSetUseBackgroundColorFunc =
                  (_GuiCanvasSetUseBackgroundColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetUseBackgroundColor"), typeof(_GuiCanvasSetUseBackgroundColor));
            }

            _GuiCanvasSetUseBackgroundColorFunc(canvas, use);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasGetBackgroundColor(IntPtr canvas, out Color outColor);
         private static _GuiCanvasGetBackgroundColor _GuiCanvasGetBackgroundColorFunc;
         internal static void GuiCanvasGetBackgroundColor(IntPtr canvas, out Color outColor)
         {
            if (_GuiCanvasGetBackgroundColorFunc == null)
            {
               _GuiCanvasGetBackgroundColorFunc =
                  (_GuiCanvasGetBackgroundColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasGetBackgroundColor"), typeof(_GuiCanvasGetBackgroundColor));
            }

            _GuiCanvasGetBackgroundColorFunc(canvas, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetBackgroundColor(IntPtr canvas, Color color);
         private static _GuiCanvasSetBackgroundColor _GuiCanvasSetBackgroundColorFunc;
         internal static void GuiCanvasSetBackgroundColor(IntPtr canvas, Color color)
         {
            if (_GuiCanvasSetBackgroundColorFunc == null)
            {
               _GuiCanvasSetBackgroundColorFunc =
                  (_GuiCanvasSetBackgroundColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetBackgroundColor"), typeof(_GuiCanvasSetBackgroundColor));
            }

            _GuiCanvasSetBackgroundColorFunc(canvas, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCanvasCreateInstance();
         private static _GuiCanvasCreateInstance _GuiCanvasCreateInstanceFunc;
         internal static IntPtr GuiCanvasCreateInstance()
         {
            if (_GuiCanvasCreateInstanceFunc == null)
            {
               _GuiCanvasCreateInstanceFunc =
                  (_GuiCanvasCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasCreateInstance"), typeof(_GuiCanvasCreateInstance));
            }

            return _GuiCanvasCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCanvasGetContent(IntPtr canvas);
         private static _GuiCanvasGetContent _GuiCanvasGetContentFunc;
         internal static IntPtr GuiCanvasGetContent(IntPtr canvas)
         {
            if (_GuiCanvasGetContentFunc == null)
            {
               _GuiCanvasGetContentFunc =
                  (_GuiCanvasGetContent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasGetContent"), typeof(_GuiCanvasGetContent));
            }

            return _GuiCanvasGetContentFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetContent(IntPtr canvas, IntPtr ctrl);
         private static _GuiCanvasSetContent _GuiCanvasSetContentFunc;
         internal static void GuiCanvasSetContent(IntPtr canvas, IntPtr ctrl)
         {
            if (_GuiCanvasSetContentFunc == null)
            {
               _GuiCanvasSetContentFunc =
                  (_GuiCanvasSetContent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetContent"), typeof(_GuiCanvasSetContent));
            }

            _GuiCanvasSetContentFunc(canvas, ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasPushDialog(IntPtr canvas, IntPtr ctrl, int layer);
         private static _GuiCanvasPushDialog _GuiCanvasPushDialogFunc;
         internal static void GuiCanvasPushDialog(IntPtr canvas, IntPtr ctrl, int layer)
         {
            if (_GuiCanvasPushDialogFunc == null)
            {
               _GuiCanvasPushDialogFunc =
                  (_GuiCanvasPushDialog)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasPushDialog"), typeof(_GuiCanvasPushDialog));
            }

            _GuiCanvasPushDialogFunc(canvas, ctrl, layer);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasPopDialog(IntPtr canvas, IntPtr ctrl);
         private static _GuiCanvasPopDialog _GuiCanvasPopDialogFunc;
         internal static void GuiCanvasPopDialog(IntPtr canvas, IntPtr ctrl)
         {
            if (_GuiCanvasPopDialogFunc == null)
            {
               _GuiCanvasPopDialogFunc =
                  (_GuiCanvasPopDialog)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasPopDialog"), typeof(_GuiCanvasPopDialog));
            }

            _GuiCanvasPopDialogFunc(canvas, ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasPopLayer(IntPtr canvas, int layer);
         private static _GuiCanvasPopLayer _GuiCanvasPopLayerFunc;
         internal static void GuiCanvasPopLayer(IntPtr canvas, int layer)
         {
            if (_GuiCanvasPopLayerFunc == null)
            {
               _GuiCanvasPopLayerFunc =
                  (_GuiCanvasPopLayer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasPopLayer"), typeof(_GuiCanvasPopLayer));
            }

            _GuiCanvasPopLayerFunc(canvas, layer);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasCursorOn(IntPtr canvas);
         private static _GuiCanvasCursorOn _GuiCanvasCursorOnFunc;
         internal static void GuiCanvasCursorOn(IntPtr canvas)
         {
            if (_GuiCanvasCursorOnFunc == null)
            {
               _GuiCanvasCursorOnFunc =
                  (_GuiCanvasCursorOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasCursorOn"), typeof(_GuiCanvasCursorOn));
            }

            _GuiCanvasCursorOnFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasCursorOff(IntPtr canvas);
         private static _GuiCanvasCursorOff _GuiCanvasCursorOffFunc;
         internal static void GuiCanvasCursorOff(IntPtr canvas)
         {
            if (_GuiCanvasCursorOffFunc == null)
            {
               _GuiCanvasCursorOffFunc =
                  (_GuiCanvasCursorOff)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasCursorOff"), typeof(_GuiCanvasCursorOff));
            }

            _GuiCanvasCursorOffFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetCursor(IntPtr canvas, IntPtr cursor);
         private static _GuiCanvasSetCursor _GuiCanvasSetCursorFunc;
         internal static void GuiCanvasSetCursor(IntPtr canvas, IntPtr cursor)
         {
            if (_GuiCanvasSetCursorFunc == null)
            {
               _GuiCanvasSetCursorFunc =
                  (_GuiCanvasSetCursor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetCursor"), typeof(_GuiCanvasSetCursor));
            }

            _GuiCanvasSetCursorFunc(canvas, cursor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasRenderFront(IntPtr canvas, bool enable);
         private static _GuiCanvasRenderFront _GuiCanvasRenderFrontFunc;
         internal static void GuiCanvasRenderFront(IntPtr canvas, bool enable)
         {
            if (_GuiCanvasRenderFrontFunc == null)
            {
               _GuiCanvasRenderFrontFunc =
                  (_GuiCanvasRenderFront)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasRenderFront"), typeof(_GuiCanvasRenderFront));
            }

            _GuiCanvasRenderFrontFunc(canvas, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasShowCursor(IntPtr canvas);
         private static _GuiCanvasShowCursor _GuiCanvasShowCursorFunc;
         internal static void GuiCanvasShowCursor(IntPtr canvas)
         {
            if (_GuiCanvasShowCursorFunc == null)
            {
               _GuiCanvasShowCursorFunc =
                  (_GuiCanvasShowCursor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasShowCursor"), typeof(_GuiCanvasShowCursor));
            }

            _GuiCanvasShowCursorFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasHideCursor(IntPtr canvas);
         private static _GuiCanvasHideCursor _GuiCanvasHideCursorFunc;
         internal static void GuiCanvasHideCursor(IntPtr canvas)
         {
            if (_GuiCanvasHideCursorFunc == null)
            {
               _GuiCanvasHideCursorFunc =
                  (_GuiCanvasHideCursor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasHideCursor"), typeof(_GuiCanvasHideCursor));
            }

            _GuiCanvasHideCursorFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiCanvasIsCursorOn(IntPtr canvas);
         private static _GuiCanvasIsCursorOn _GuiCanvasIsCursorOnFunc;
         internal static bool GuiCanvasIsCursorOn(IntPtr canvas)
         {
            if (_GuiCanvasIsCursorOnFunc == null)
            {
               _GuiCanvasIsCursorOnFunc =
                  (_GuiCanvasIsCursorOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasIsCursorOn"), typeof(_GuiCanvasIsCursorOn));
            }

            return _GuiCanvasIsCursorOnFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetDoubleClickDelay(IntPtr canvas, int delay);
         private static _GuiCanvasSetDoubleClickDelay _GuiCanvasSetDoubleClickDelayFunc;
         internal static void GuiCanvasSetDoubleClickDelay(IntPtr canvas, int delay)
         {
            if (_GuiCanvasSetDoubleClickDelayFunc == null)
            {
               _GuiCanvasSetDoubleClickDelayFunc =
                  (_GuiCanvasSetDoubleClickDelay)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetDoubleClickDelay"), typeof(_GuiCanvasSetDoubleClickDelay));
            }

            _GuiCanvasSetDoubleClickDelayFunc(canvas, delay);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetDoubleClickMoveBuffer(IntPtr canvas, int width, int height);
         private static _GuiCanvasSetDoubleClickMoveBuffer _GuiCanvasSetDoubleClickMoveBufferFunc;
         internal static void GuiCanvasSetDoubleClickMoveBuffer(IntPtr canvas, int width, int height)
         {
            if (_GuiCanvasSetDoubleClickMoveBufferFunc == null)
            {
               _GuiCanvasSetDoubleClickMoveBufferFunc =
                  (_GuiCanvasSetDoubleClickMoveBuffer)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetDoubleClickMoveBuffer"), typeof(_GuiCanvasSetDoubleClickMoveBuffer));
            }

            _GuiCanvasSetDoubleClickMoveBufferFunc(canvas, width, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasRepaint(IntPtr canvas);
         private static _GuiCanvasRepaint _GuiCanvasRepaintFunc;
         internal static void GuiCanvasRepaint(IntPtr canvas)
         {
            if (_GuiCanvasRepaintFunc == null)
            {
               _GuiCanvasRepaintFunc =
                  (_GuiCanvasRepaint)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasRepaint"), typeof(_GuiCanvasRepaint));
            }

            _GuiCanvasRepaintFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasReset(IntPtr canvas);
         private static _GuiCanvasReset _GuiCanvasResetFunc;
         internal static void GuiCanvasReset(IntPtr canvas)
         {
            if (_GuiCanvasResetFunc == null)
            {
               _GuiCanvasResetFunc =
                  (_GuiCanvasReset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasReset"), typeof(_GuiCanvasReset));
            }

            _GuiCanvasResetFunc(canvas);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasGetCursorPos(IntPtr canvas, Point2I outPos);
         private static _GuiCanvasGetCursorPos _GuiCanvasGetCursorPosFunc;
         internal static void GuiCanvasGetCursorPos(IntPtr canvas, Point2I outPos)
         {
            if (_GuiCanvasGetCursorPosFunc == null)
            {
               _GuiCanvasGetCursorPosFunc =
                  (_GuiCanvasGetCursorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasGetCursorPos"), typeof(_GuiCanvasGetCursorPos));
            }

            _GuiCanvasGetCursorPosFunc(canvas, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiCanvasSetCursorPos(IntPtr canvas, Point2I pos);
         private static _GuiCanvasSetCursorPos _GuiCanvasSetCursorPosFunc;
         internal static void GuiCanvasSetCursorPos(IntPtr canvas, Point2I pos)
         {
            if (_GuiCanvasSetCursorPosFunc == null)
            {
               _GuiCanvasSetCursorPosFunc =
                  (_GuiCanvasSetCursorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasSetCursorPos"), typeof(_GuiCanvasSetCursorPos));
            }

            _GuiCanvasSetCursorPosFunc(canvas, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCanvasGetMouseControl(IntPtr canvas);
         private static _GuiCanvasGetMouseControl _GuiCanvasGetMouseControlFunc;
         internal static IntPtr GuiCanvasGetMouseControl(IntPtr canvas)
         {
            if (_GuiCanvasGetMouseControlFunc == null)
            {
               _GuiCanvasGetMouseControlFunc =
                  (_GuiCanvasGetMouseControl)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiCanvasGetMouseControl"), typeof(_GuiCanvasGetMouseControl));
            }

            return _GuiCanvasGetMouseControlFunc(canvas);
         }
      }
      
      #endregion

      #region Properties

      public bool UseBackgroundColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiCanvasGetUseBackgroundColor(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCanvasSetUseBackgroundColor(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BackgroundColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiCanvasGetBackgroundColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiCanvasSetBackgroundColor(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public GuiControl GetContent()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new GuiControl(InternalUnsafeMethods.GuiCanvasGetContent(ObjectPtr->ObjPtr));
      }

      public void SetContent(GuiControl ctrl)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasSetContent(ObjectPtr->ObjPtr, ctrl.ObjectPtr->ObjPtr);
      }

      public void PushDialog(GuiControl ctrl, int layer)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasPushDialog(ObjectPtr->ObjPtr, ctrl.ObjectPtr->ObjPtr, layer);
      }

      public void PopDialog(GuiControl ctrl)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasPopDialog(ObjectPtr->ObjPtr, ctrl.ObjectPtr->ObjPtr);
      }

      public void PopLayer(int layer)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasPopLayer(ObjectPtr->ObjPtr, layer);
      }

      public void CursorOn()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasCursorOn(ObjectPtr->ObjPtr);
      }

      public void CursorOff()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasCursorOff(ObjectPtr->ObjPtr);
      }

      public void SetCursor(GuiCursor cursor)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasSetCursor(ObjectPtr->ObjPtr, cursor.ObjectPtr->ObjPtr);
      }

      public void RenderFront(bool enable)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasRenderFront(ObjectPtr->ObjPtr, enable);
      }

      public void ShowCursor()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasShowCursor(ObjectPtr->ObjPtr);
      }

      public void HideCursor()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasHideCursor(ObjectPtr->ObjPtr);
      }

      public bool IsCursorOn()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiCanvasIsCursorOn(ObjectPtr->ObjPtr);
      }

      public void SetDoubleClickDelay(int delay)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasSetDoubleClickDelay(ObjectPtr->ObjPtr, delay);
      }

      public void SetDoubleClickMoveBuffer(int width, int height)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasSetDoubleClickMoveBuffer(ObjectPtr->ObjPtr, width, height);
      }

      public void Repaint()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasRepaint(ObjectPtr->ObjPtr);
      }

      public void Reset()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasReset(ObjectPtr->ObjPtr);
      }

      public void GetCursorPos(Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasGetCursorPos(ObjectPtr->ObjPtr, outPos);
      }

      public void SetCursorPos(Point2I pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiCanvasSetCursorPos(ObjectPtr->ObjPtr, pos);
      }

      public GuiControl GetMouseControl()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new GuiControl(InternalUnsafeMethods.GuiCanvasGetMouseControl(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}